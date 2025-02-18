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
        Panel1 = New Panel()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Label5 = New Label()
        Label4 = New Label()
        ComboBox1 = New ComboBox()
        Selanjutnya = New Button()
        Panel2 = New Panel()
        NumericUpDown1 = New NumericUpDown()
        TextBox3 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gainsboro
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(RadioButton2)
        Panel1.Controls.Add(RadioButton1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Location = New Point(11, 200)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(249, 187)
        Panel1.TabIndex = 7
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(13, 148)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(109, 29)
        RadioButton2.TabIndex = 4
        RadioButton2.TabStop = True
        RadioButton2.Text = "❌ Tidak"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(13, 113)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(84, 29)
        RadioButton1.TabIndex = 3
        RadioButton1.TabStop = True
        RadioButton1.Text = "✔ Ya"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(3, 74)
        Label5.Name = "Label5"
        Label5.Size = New Size(168, 25)
        Label5.TabIndex = 2
        Label5.Text = "konfirmasi Pesanan:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(3, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(193, 25)
        Label4.TabIndex = 1
        Label4.Text = "List Meja yang Tersedia"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.MenuBar
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FlatStyle = FlatStyle.Flat
        ComboBox1.ForeColor = SystemColors.MenuText
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"☐ Meja 1 - 2 Kursi", "", "☐ Meja 2 - 4 Kursi", "", "☐ Meja 3 - 6 Kursi", "", "☐ Meja 4 - 8 Kursi"})
        ComboBox1.Location = New Point(3, 28)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(214, 33)
        ComboBox1.TabIndex = 0
        ' 
        ' Selanjutnya
        ' 
        Selanjutnya.BackColor = Color.Gainsboro
        Selanjutnya.BackgroundImageLayout = ImageLayout.Center
        Selanjutnya.ForeColor = SystemColors.ActiveCaptionText
        Selanjutnya.Location = New Point(181, 465)
        Selanjutnya.Name = "Selanjutnya"
        Selanjutnya.Size = New Size(374, 69)
        Selanjutnya.TabIndex = 8
        Selanjutnya.Text = "Selanjutnya"
        Selanjutnya.TextImageRelation = TextImageRelation.TextAboveImage
        Selanjutnya.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Firebrick
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(NumericUpDown1)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(41, 32)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(656, 427)
        Panel2.TabIndex = 9
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(11, 107)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(623, 31)
        NumericUpDown1.TabIndex = 12
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Location = New Point(7, 41)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(638, 31)
        TextBox3.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Brown
        Label3.Font = New Font("Bodoni Bk BT", 12F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(6, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 29)
        Label3.TabIndex = 9
        Label3.Text = "Pilih Meja:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Brown
        Label2.Font = New Font("Bodoni Bk BT", 12F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(7, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 29)
        Label2.TabIndex = 8
        Label2.Text = "Jumlah Tamu:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Brown
        Label1.Font = New Font("Bodoni Bk BT", 12F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(3, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 29)
        Label1.TabIndex = 7
        Label1.Text = "Nama :"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Brown
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 569)
        Controls.Add(Panel2)
        Controls.Add(Selanjutnya)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Selanjutnya As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown

End Class
