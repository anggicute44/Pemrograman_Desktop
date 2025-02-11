<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtDecimal = New Label()
        TextBox1 = New TextBox()
        btnConvert = New Button()
        btnExit = New Button()
        txtBinar = New Label()
        txtOcta = New Label()
        txtHex = New Label()
        Label5 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        SuspendLayout()
        ' 
        ' txtDecimal
        ' 
        txtDecimal.AutoSize = True
        txtDecimal.Location = New Point(91, 82)
        txtDecimal.Name = "txtDecimal"
        txtDecimal.Size = New Size(126, 25)
        txtDecimal.TabIndex = 0
        txtDecimal.Text = "angka desimal"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(234, 83)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(176, 31)
        TextBox1.TabIndex = 1
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(444, 91)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(112, 34)
        btnConvert.TabIndex = 2
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(574, 91)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(112, 34)
        btnExit.TabIndex = 3
        btnExit.Text = "Keluar"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' txtBinar
        ' 
        txtBinar.AutoSize = True
        txtBinar.Location = New Point(103, 129)
        txtBinar.Name = "txtBinar"
        txtBinar.Size = New Size(55, 25)
        txtBinar.TabIndex = 4
        txtBinar.Text = "Biner:"
        ' 
        ' txtOcta
        ' 
        txtOcta.AutoSize = True
        txtOcta.Location = New Point(104, 183)
        txtOcta.Name = "txtOcta"
        txtOcta.Size = New Size(58, 25)
        txtOcta.TabIndex = 5
        txtOcta.Text = "Oktal:"
        ' 
        ' txtHex
        ' 
        txtHex.AutoSize = True
        txtHex.Location = New Point(104, 231)
        txtHex.Name = "txtHex"
        txtHex.Size = New Size(125, 25)
        txtHex.TabIndex = 6
        txtHex.Text = "Heksadesimal:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(369, 278)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 25)
        Label5.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(232, 134)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(178, 31)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(232, 231)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(178, 31)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(232, 183)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(178, 31)
        TextBox4.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label5)
        Controls.Add(txtHex)
        Controls.Add(txtOcta)
        Controls.Add(txtBinar)
        Controls.Add(btnExit)
        Controls.Add(btnConvert)
        Controls.Add(TextBox1)
        Controls.Add(txtDecimal)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDecimal As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtBinar As Label
    Friend WithEvents txtOcta As Label
    Friend WithEvents txtHex As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox

End Class
