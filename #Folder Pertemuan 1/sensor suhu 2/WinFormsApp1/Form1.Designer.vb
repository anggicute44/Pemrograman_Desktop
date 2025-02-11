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
        Button2 = New Button()
        lblReamur = New Label()
        lblKelvin = New Label()
        lblFahrenheit = New Label()
        SuspendLayout()
        ' 
        ' txtCelcius
        ' 
        txtCelcius.AutoSize = True
        txtCelcius.Location = New Point(124, 93)
        txtCelcius.Name = "txtCelcius"
        txtCelcius.Size = New Size(66, 25)
        txtCelcius.TabIndex = 0
        txtCelcius.Text = "Celcius"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(197, 91)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 1
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(385, 98)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(112, 34)
        btnConvert.TabIndex = 2
        btnConvert.Text = "convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(529, 98)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 3
        Button2.Text = "keluar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' lblReamur
        ' 
        lblReamur.AutoSize = True
        lblReamur.Location = New Point(328, 245)
        lblReamur.Name = "lblReamur"
        lblReamur.Size = New Size(72, 25)
        lblReamur.TabIndex = 4
        lblReamur.Text = "Reamur"
        ' 
        ' lblKelvin
        ' 
        lblKelvin.AutoSize = True
        lblKelvin.Location = New Point(484, 245)
        lblKelvin.Name = "lblKelvin"
        lblKelvin.Size = New Size(58, 25)
        lblKelvin.TabIndex = 5
        lblKelvin.Text = "Kelvin"
        ' 
        ' lblFahrenheit
        ' 
        lblFahrenheit.AutoSize = True
        lblFahrenheit.Location = New Point(146, 245)
        lblFahrenheit.Name = "lblFahrenheit"
        lblFahrenheit.Size = New Size(93, 25)
        lblFahrenheit.TabIndex = 6
        lblFahrenheit.Text = "Fahrenheit"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblFahrenheit)
        Controls.Add(lblKelvin)
        Controls.Add(lblReamur)
        Controls.Add(Button2)
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
    Friend WithEvents Button2 As Button
    Friend WithEvents lblReamur As Label
    Friend WithEvents lblKelvin As Label
    Friend WithEvents lblFahrenheit As Label

End Class
