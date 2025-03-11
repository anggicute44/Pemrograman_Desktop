<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        ComboBox1 = New ComboBox()
        Label6 = New Label()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(117, 18)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(138, 33)
        ComboBox1.TabIndex = 32
        ComboBox1.Text = "Bulan"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.GradientActiveCaption
        Label6.Location = New Point(31, 21)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 25)
        Label6.TabIndex = 31
        Label6.Text = "Periode :"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.WhiteSmoke
        Button1.Location = New Point(368, 18)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 33)
        Button1.TabIndex = 41
        Button1.Text = "Tampilkan!"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.GradientActiveCaption
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Location = New Point(284, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 27)
        Label1.TabIndex = 42
        Label1.Text = "Tahun"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.GradientActiveCaption
        Label2.Location = New Point(31, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 25)
        Label2.TabIndex = 43
        Label2.Text = "Laporan :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(31, 111)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(733, 315)
        TextBox1.TabIndex = 44
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(652, 450)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 45
        Button2.Text = "Tutup"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Laporan
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 509)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Label6)
        Name = "Laporan"
        Text = "Laporan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
End Class
