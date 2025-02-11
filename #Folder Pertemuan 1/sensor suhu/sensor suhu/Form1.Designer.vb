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
        txtCelcius = New Label()
        TextBox1 = New TextBox()
        btnKeluar = New Button()
        btnConvert = New Button()
        SuspendLayout()
        ' 
        ' txtCelcius
        ' 
        txtCelcius.AutoSize = True
        txtCelcius.Location = New Point(190, 133)
        txtCelcius.Name = "txtCelcius"
        txtCelcius.Size = New Size(63, 25)
        txtCelcius.TabIndex = 0
        txtCelcius.Text = "celcius"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(271, 135)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 1
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(572, 135)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(112, 34)
        btnKeluar.TabIndex = 2
        btnKeluar.Text = "keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(445, 133)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(112, 34)
        btnConvert.TabIndex = 3
        btnConvert.Text = "convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnConvert)
        Controls.Add(btnKeluar)
        Controls.Add(TextBox1)
        Controls.Add(txtCelcius)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCelcius As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnConvert As Button

End Class
