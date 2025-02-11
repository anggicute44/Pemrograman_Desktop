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
        btnConvert = New Button()
        btnKeluar = New Button()
        txtFahrenheit = New TextBox()
        txtReamur = New TextBox()
        txtKelvin = New TextBox()
        SuspendLayout()
        ' 
        ' txtCelcius
        ' 
        txtCelcius.AutoSize = True
        txtCelcius.Location = New Point(159, 107)
        txtCelcius.Name = "txtCelcius"
        txtCelcius.Size = New Size(63, 25)
        txtCelcius.TabIndex = 0
        txtCelcius.Text = "celcius"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(251, 112)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 1
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(483, 112)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(112, 34)
        btnConvert.TabIndex = 2
        btnConvert.Text = "convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(632, 110)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(112, 34)
        btnKeluar.TabIndex = 3
        btnKeluar.Text = "keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' txtFahrenheit
        ' 
        txtFahrenheit.Location = New Point(203, 199)
        txtFahrenheit.Name = "txtFahrenheit"
        txtFahrenheit.Size = New Size(150, 31)
        txtFahrenheit.TabIndex = 4
        ' 
        ' txtReamur
        ' 
        txtReamur.Location = New Point(402, 199)
        txtReamur.Name = "txtReamur"
        txtReamur.Size = New Size(150, 31)
        txtReamur.TabIndex = 5
        ' 
        ' txtKelvin
        ' 
        txtKelvin.Location = New Point(594, 199)
        txtKelvin.Name = "txtKelvin"
        txtKelvin.Size = New Size(150, 31)
        txtKelvin.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtKelvin)
        Controls.Add(txtReamur)
        Controls.Add(txtFahrenheit)
        Controls.Add(btnKeluar)
        Controls.Add(btnConvert)
        Controls.Add(TextBox1)
        Controls.Add(txtCelcius)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCelcius As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents txtReamur As TextBox
    Friend WithEvents txtKelvin As TextBox

End Class
