<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UbahProfil
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
        Button2 = New Button()
        Button1 = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        TextBox3 = New TextBox()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.WhiteSmoke
        Button2.Location = New Point(343, 330)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 39)
        Button2.TabIndex = 13
        Button2.Text = "Tutup"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.WhiteSmoke
        Button1.Location = New Point(207, 330)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 39)
        Button1.TabIndex = 12
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.GradientActiveCaption
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(326, 185)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(201, 31)
        TextBox2.TabIndex = 11
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.GradientActiveCaption
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(326, 124)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(201, 31)
        TextBox1.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.GradientActiveCaption
        Label3.Location = New Point(165, 185)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 25)
        Label3.TabIndex = 9
        Label3.Text = "Passoword Baru:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.GradientActiveCaption
        Label2.Location = New Point(165, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 25)
        Label2.TabIndex = 8
        Label2.Text = "Usename :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(2, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(467, 65)
        Label1.TabIndex = 7
        Label1.Text = "SIParkir - Ubah Profil"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.GradientActiveCaption
        Label4.Location = New Point(165, 243)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 25)
        Label4.TabIndex = 14
        Label4.Text = "Ketik Lagi:"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.GradientActiveCaption
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Location = New Point(326, 241)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(201, 31)
        TextBox3.TabIndex = 15
        ' 
        ' UbahProfil
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "UbahProfil"
        Text = "UbahProfil"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
