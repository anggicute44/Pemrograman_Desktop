Public Class Form1


    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        Dim decimalNumber As Integer


        If Integer.TryParse(txtDecimal.Text, decimalNumber) Then

            txtBinar.Text = Convert.ToString(decimalNumber, 2)
            txtOcta.Text = Convert.ToString(decimalNumber, 8)
            txtHex.Text = Convert.ToString(decimalNumber, 16).ToUpper()
        Else
            MsgBox("Masukkan angka desimal ", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub
End Class



