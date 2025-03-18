Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class frmLogin


    Private Sub Login_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Return Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        Try
            ' SQL query dengan parameter untuk menghindari SQL Injection
            Dim sql As String = "SELECT username, password FROM " & tbluser & " WHERE username = " + txtUsername.Text + " AND password = @password"

            ' Pastikan koneksi terbuka
            If myConn Is Nothing Then
                CreateConnection()
            End If
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If

            ' Gunakan parameterized query untuk keamanan
            myCommand = New MySqlCommand(sql, myConn)

            myCommand.Parameters.AddWithValue("@password", txtPassword.Text)

            ' Eksekusi query
            myDataReader = myCommand.ExecuteReader()

            ' Cek apakah data ditemukan
            If myDataReader.HasRows Then
                myDataReader.Close()

                ' Simpan informasi pengguna
                pengguna = txtUsername.Text
                ppassword = txtPassword.Text

                ' Tampilkan informasi di form utama
                frmUtama.lblInfoUser.Text = "Informasi - (User: " & pengguna & ")"
                frmUtama.lblTgl.Text = "Tanggal : " & Now.Day & " - " & Now.Month & " - " & Now.Year
                frmUtama.RefreshGrid()
                frmUtama.HitungJumlah()

                ' Tampilkan form utama dan sembunyikan form login
                frmUtama.Show()
                Me.Hide()
            Else
                MsgBox("Username / Password salah!", MsgBoxStyle.Exclamation, "Login Gagal")
            End If

            ' Pastikan data reader ditutup jika masih terbuka
            If Not myDataReader.IsClosed Then
                myDataReader.Close()
            End If
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            ' Tutup koneksi untuk menghindari kebocoran sumber daya
            If myConn IsNot Nothing AndAlso myConn.State = ConnectionState.Open Then
                myConn.Close()
            End If
        End Try
    End Sub
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateConnection()
    End Sub

End Class
