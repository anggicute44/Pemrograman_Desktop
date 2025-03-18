Imports System.Data.Common
Imports System.Net
Imports System.Windows.Input
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms




Module ModuleDB
    Public pengguna As String = "anton"
    Public ppassword As String = "anton"
    Public myStrCon As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder()
    Public myConn As MySqlConnection
    Public myCommand As MySqlCommand
    Public myDataReader As MySqlDataReader
    Public myDataAdapter As MySqlDataAdapter
    Public jns As String = String.Empty
    Public tbluser As String = "users" 'nama tabel user
    Public bts As Integer = 5
    Public Sub CreateConnection()
        myStrCon.UserID = "root"
        myStrCon.Server = "localhost"
        myStrCon.Password = ""
        myStrCon.Database = "test" 'sesuaikan nama databasenya
        myConn = New MySqlConnection(myStrCon.ToString)
    End Sub
End Module
Public Class frmUtama
    Sub RefreshGrid()
        Dim i As Integer = 0
        DataGridView1.Rows.Clear()
        Dim sql As String = "SELECT * FROM tblparkir WHERE DATE(`waktu_masuk`) = CURDATE()"

        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If

        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If

        myDataReader = myCommand.ExecuteReader()

        If myDataReader.HasRows Then
            While myDataReader.Read()
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = myDataReader("no_plat")
                DataGridView1.Item(1, i).Value = myDataReader("waktu_masuk")
                DataGridView1.Item(2, i).Value = myDataReader("waktu_keluar")
                DataGridView1.Item(3, i).Value = myDataReader("harga")
                DataGridView1.Item(4, i).Value = myDataReader("jenis")
                DataGridView1.Item(5, i).Value = myDataReader("id")
                i += 1
            End While
        End If

        If Not myDataReader.IsClosed Then
            myDataReader.Close()
        End If
    End Sub
    Sub HitungJumlah()
        Dim sql As String = "SELECT jenis, COUNT(*) AS jml, " & bts & " - COUNT(*) AS sisa " &
                        "FROM tblparkir WHERE DATE(`waktu_masuk`) = CURDATE() AND waktu_keluar IS NULL " &
                        "GROUP BY jenis"

        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If

        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If

        myDataReader = myCommand.ExecuteReader()
        Dim hsl As String = "Jumlah "

        If myDataReader.HasRows Then
            While myDataReader.Read()
                hsl &= myDataReader("jenis").ToString() & " = " & myDataReader("jml").ToString() & ", "
            End While
            lblJmlKendaraan.Text = hsl
        Else
            lblJmlKendaraan.Text = "0 Motor, 0 Mobil, 0 Taksi, 0 Sepeda, 0 Bis/Truk"
        End If

        If Not myDataReader.IsClosed Then
            myDataReader.Close()
        End If
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim sql As String
        Dim harga As Integer = 0
        Dim nomor As String = String.Empty
        pengguna = "anton"

        If e.KeyCode = Keys.F1 Then
            jns = "Motor"
        ElseIf e.KeyCode = Keys.F2 Then
            jns = "Mobil"
        ElseIf e.KeyCode = Keys.F3 Then
            jns = "Taksi/Umum"
        ElseIf e.KeyCode = Keys.F4 Then
            jns = "Sepeda"
        ElseIf e.KeyCode = Keys.F5 Then
            jns = "Bus/Truk"
        End If

        lblInfoJenis.Text = jns

        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If

        If e.KeyCode = Keys.Return Then
            sql = "SELECT * FROM tblparkir WHERE no_plat='" & txtNoPlat.Text.ToUpper() & "' AND waktu_keluar IS NULL AND DATE(`waktu_masuk`) = CURDATE()"

            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If

            Dim hasil1 As MySqlDataReader = myCommand.ExecuteReader()

            If hasil1.HasRows Then ' Jika sudah ada, update jadi keluar
                If MessageBox.Show("Keluar dari Parkir?", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    hasil1.Read()
                    jns = hasil1("jenis").ToString()
                    nomor = hasil1("id").ToString()

                    Select Case jns
                        Case "Motor"
                            harga = 2000
                        Case "Mobil", "Taksi/Umum"
                            harga = 3000
                        Case "Sepeda"
                            harga = 1000
                        Case "Bus/Truk"
                            harga = 4000
                    End Select

                    If Not hasil1.IsClosed Then
                        hasil1.Close()
                    End If

                    sql = "UPDATE tblparkir SET waktu_keluar = CURRENT_TIMESTAMP(), " &
                      "harga = IF(CEIL((UNIX_TIMESTAMP(waktu_keluar) - UNIX_TIMESTAMP(waktu_masuk)) / 60 / 60) > 1, " &
                      "CEIL((UNIX_TIMESTAMP(waktu_keluar) - UNIX_TIMESTAMP(waktu_masuk)) / 60 / 60) * " & Str(harga) & ", " & Str(harga) & ") " &
                      "WHERE id = " & nomor

                    myCommand.CommandText = sql
                    myCommand.ExecuteNonQuery()

                    sql = "SELECT * FROM tblparkir WHERE id = " & nomor
                    myCommand.CommandText = sql
                    hasil1 = myCommand.ExecuteReader()
                    hasil1.Read()

                    lblHarga.Text = "Rp. " & hasil1("harga").ToString()

                    If Not hasil1.IsClosed Then
                        hasil1.Close()
                    End If

                    MsgBox("Sukses Keluar!")
                    jns = String.Empty
                End If
            Else ' Jika belum ada, masukkan baru
                If jns = String.Empty Then
                    MsgBox("Masukan jenis kendaraan berikut:" & vbCrLf & lblJenis.Text)
                    hasil1.Close()
                    Exit Sub
                End If

                sql = "INSERT INTO tblparkir(no_plat, jenis, user) VALUES ('" & txtNoPlat.Text.ToUpper() & "', '" & lblInfoJenis.Text & "', '" & pengguna & "')"

                If Not hasil1.IsClosed Then
                    hasil1.Close()
                End If

                myCommand.CommandText = sql
                myCommand.ExecuteNonQuery()
                jns = String.Empty
            End If

            lblPlat.Text = txtNoPlat.Text.ToUpper()
        End If

        RefreshGrid()
        HitungJumlah()

        If myConn.State = ConnectionState.Open Then
            myConn.Close()
        End If
    End Sub
    Private Sub LaporanPendapatanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPendapatanToolStripMenuItem.Click
        Dim sql As String = "SELECT SUM(harga) FROM tblparkir WHERE DATE(waktu_masuk) = CURDATE() AND DATE(waktu_keluar) = CURDATE()"

        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If

        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If

        Dim hasil As Object = myCommand.ExecuteScalar()
        Dim total As String = ""

        If hasil Is DBNull.Value OrElse hasil Is Nothing Then
            total = "0"
        Else
            total = hasil.ToString()
        End If

        MsgBox("Total Pendapatan hari ini: Rp. " & total)
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTgl.Text = "Tangggal : " & Now.Day & " - " & Now.Month & " - " & Now.Year
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        frmLogin.txtUsername.Clear()
        frmLogin.txtPassword.Clear()
        frmLogin.txtUsername.Focus()
        frmLogin.ShowDialog()
    End Sub

    Private Sub ProfilToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfilToolStripMenuItem1.Click
        frmProfil.ShowDialog()
    End Sub

    Private Sub DaftarKendaraanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaftarKendaraanToolStripMenuItem.Click
        frmLangganan.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If MessageBox.Show("Delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Dim sql As String = "DELETE FROM tblparkir WHERE id=" & DataGridView1.CurrentRow.Cells(5).Value.ToString
            MsgBox(sql)

            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If

            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If

            Dim hasil As Integer = myCommand.ExecuteNonQuery()
            If hasil = 1 Then
                MsgBox("Delete success!")
                RefreshGrid()
                HitungJumlah()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        lblPlat.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click

    End Sub

    Private Sub LanggananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarKendaraanToolStripMenuItem.Click

    End Sub
End Class