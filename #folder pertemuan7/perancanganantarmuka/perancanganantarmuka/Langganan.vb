Imports MySql.Data.MySqlClient

Public Class frmLangganan
    Dim myConn As New MySqlConnection("server=localhost;user id=root;password=;database=your_database")
    Dim myCommand As MySqlCommand
    Dim myDataReader As MySqlDataReader

    Private Sub RefreshGrid()
        DataGridView1.Rows.Clear()
        Dim sql As String = "SELECT * FROM tbllangganan"
        If myConn.State = ConnectionState.Closed Then myConn.Open()
        myCommand = New MySqlCommand(sql, myConn)
        myDataReader = myCommand.ExecuteReader
        Dim i As Integer = 0
        While myDataReader.Read()
            DataGridView1.Rows.Add(myDataReader("id"), myDataReader("no_plat"), myDataReader("nama"),
                                   myDataReader("biaya"), myDataReader("jenis"), myDataReader("expired"))
            i += 1
        End While
        myDataReader.Close()
    End Sub

    Private Sub frmLangganan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim idx As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
        Dim sql As String = "SELECT * FROM tbllangganan WHERE id=" & idx
        If myConn.State = ConnectionState.Closed Then myConn.Open()
        myCommand = New MySqlCommand(sql, myConn)
        myDataReader = myCommand.ExecuteReader
        If myDataReader.Read() Then
            lblId.Text = myDataReader("id")
            txtNoPlat.Text = myDataReader("no_plat")
            txtNama.Text = myDataReader("nama")
            txtBiaya.Text = myDataReader("biaya")
            cmbJenis.Text = myDataReader("jenis")
            DateTimePicker1.Text = myDataReader("expired")
        End If
        myDataReader.Close()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If btnTambah.Text = "Tambah" Then
            btnTambah.Text = "Simpan"
            txtNoPlat.Enabled = True
            txtNama.Enabled = True
            txtBiaya.Enabled = True
            cmbJenis.Enabled = True
            DateTimePicker1.Enabled = True
            btnCancel.Visible = True
            btnEdit.Enabled = False
            btnHapus.Enabled = False
            txtNoPlat.Clear()
            txtNama.Clear()
            txtBiaya.Clear()
            cmbJenis.Text = ""
        ElseIf btnTambah.Text = "Simpan" Then
            Dim waktu As String = DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")
            Dim sql As String = "INSERT INTO tbllangganan(no_plat, nama, jenis, biaya, expired) VALUES ('" & txtNoPlat.Text & "','" & txtNama.Text & "','" & cmbJenis.Text & "'," & txtBiaya.Text & ", '" & waktu & "')"
            If myConn.State = ConnectionState.Closed Then myConn.Open()
            myCommand = New MySqlCommand(sql, myConn)
            myCommand.ExecuteNonQuery()
            btnTambah.Text = "Tambah"
            txtNoPlat.Enabled = False
            txtNama.Enabled = False
            txtBiaya.Enabled = False
            cmbJenis.Enabled = False
            DateTimePicker1.Enabled = False
            btnCancel.Visible = False
            btnEdit.Enabled = True
            btnHapus.Enabled = True
            RefreshGrid()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If DataGridView1.CurrentRow.Cells(0).Value.ToString <> "" Then
            If MessageBox.Show("Delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim sql As String = "DELETE FROM tbllangganan WHERE id=" & DataGridView1.CurrentRow.Cells(0).Value.ToString
                If myConn.State = ConnectionState.Closed Then myConn.Open()
                myCommand = New MySqlCommand(sql, myConn)
                If myCommand.ExecuteNonQuery() = 1 Then
                    MsgBox("Delete success!")
                    RefreshGrid()
                End If
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit" Then
            btnEdit.Text = "Simpan"
            txtNoPlat.Enabled = True
            txtNama.Enabled = True
            txtBiaya.Enabled = True
            cmbJenis.Enabled = True
            DateTimePicker1.Enabled = True
            btnCancel.Visible = True
            btnTambah.Enabled = False
            btnHapus.Enabled = False
        ElseIf btnEdit.Text = "Simpan" Then
            Dim waktu As String = DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")
            Dim sql As String = "UPDATE tbllangganan SET no_plat = '" & txtNoPlat.Text & "', nama = '" & txtNama.Text & "', jenis = '" & cmbJenis.Text & "', biaya = " & txtBiaya.Text & ", expired = '" & waktu & "' WHERE id = " & lblId.Text
            If myConn.State = ConnectionState.Closed Then myConn.Open()
            myCommand = New MySqlCommand(sql, myConn)
            If myCommand.ExecuteNonQuery() = 1 Then
                MsgBox("Update success!")
                RefreshGrid()
            End If
            btnEdit.Text = "Edit"
            txtNoPlat.Enabled = False
            txtNama.Enabled = False
            txtBiaya.Enabled = False
            cmbJenis.Enabled = False
            DateTimePicker1.Enabled = False
            btnCancel.Visible = False
            btnTambah.Enabled = True
            btnHapus.Enabled = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If btnTambah.Text = "Simpan" Then
            btnTambah.Text = "Tambah"
            txtNoPlat.Enabled = False
            txtNama.Enabled = False
            txtBiaya.Enabled = False
            cmbJenis.Enabled = False
            DateTimePicker1.Enabled = False
            btnCancel.Visible = False
            btnEdit.Enabled = True
            btnHapus.Enabled = True
        ElseIf btnEdit.Text = "Simpan" Then
            btnEdit.Text = "Edit"
            txtNoPlat.Enabled = False
            txtNama.Enabled = False
            txtBiaya.Enabled = False
            cmbJenis.Enabled = False
            DateTimePicker1.Enabled = False
            btnCancel.Visible = False
            btnTambah.Enabled = True
            btnHapus.Enabled = True
        End If
    End Sub
End Class