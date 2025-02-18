Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Selanjutnya_Click(sender As Object, e As EventArgs) Handles Selanjutnya.Click
        ' Membuat instance Form2
        Dim form2 As New Form2()

        ' Menampilkan Form2
        form2.Show()

        ' Menyembunyikan Form1
        Me.Hide()
    End Sub

End Class
