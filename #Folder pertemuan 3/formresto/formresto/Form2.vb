Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Kembali_Click(sender As Object, e As EventArgs) Handles kembali.Click
        Dim form1 As New Form1() ' Membuat instance Form1
        form1.Show() ' Menampilkan Form1
        Me.Close() ' Menutup Form2 agar kembali ke Form1
    End Sub

    Private Sub Simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        ' Menampilkan pesan konfirmasi dengan tombol OK dan Cancel
        Dim result As DialogResult = MessageBox.Show("Pesanan diterima, silahkan lakukan pembayaran pada kasir.",
                                                     "Konfirmasi Pesanan",
                                                     MessageBoxButtons.OKCancel,
                                                     MessageBoxIcon.Information)

        ' Jika pengguna menekan tombol OK
        If result = DialogResult.OK Then
            MessageBox.Show("Terima kasih atas pesanan Anda!", "Terima Kasih", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class