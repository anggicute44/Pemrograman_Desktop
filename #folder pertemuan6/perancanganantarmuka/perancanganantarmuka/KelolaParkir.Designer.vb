<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KelolaParkir
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
        Label8 = New Label()
        Label7 = New Label()
        ComboBox1 = New ComboBox()
        Label6 = New Label()
        Button3 = New Button()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        MenuStrip1 = New MenuStrip()
        SistemToolStripMenuItem = New ToolStripMenuItem()
        SistemToolStripMenuItem1 = New ToolStripMenuItem()
        AturProfilToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        AdminToolStripMenuItem = New ToolStripMenuItem()
        LanggananToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem1 = New ToolStripMenuItem()
        TentangToolStripMenuItem = New ToolStripMenuItem()
        Label2 = New Label()
        Panel1 = New Panel()
        Label4 = New Label()
        DataGridView1 = New DataGridView()
        Panel2 = New Panel()
        Label5 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.GradientActiveCaption
        Label8.Location = New Point(44, 369)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 25)
        Label8.TabIndex = 50
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.GradientActiveCaption
        Label7.Location = New Point(477, 208)
        Label7.Name = "Label7"
        Label7.Size = New Size(212, 25)
        Label7.TabIndex = 49
        Label7.Text = "Kendaraan Sedang Parkir:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.ForeColor = SystemColors.ActiveCaptionText
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(161, 254)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(181, 33)
        ComboBox1.TabIndex = 48
        ComboBox1.Text = "option 1"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.GradientActiveCaption
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(12, 254)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 25)
        Label6.TabIndex = 47
        Label6.Text = "Jenis :"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.WhiteSmoke
        Button3.Location = New Point(161, 313)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 44)
        Button3.TabIndex = 46
        Button3.Text = "Masuk"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.WhiteSmoke
        Button1.Location = New Point(293, 313)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 44)
        Button1.TabIndex = 40
        Button1.Text = "Keluar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.GradientActiveCaption
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.ForeColor = SystemColors.InfoText
        TextBox1.Location = New Point(161, 208)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(277, 31)
        TextBox1.TabIndex = 38
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.GradientActiveCaption
        Label3.Location = New Point(12, 214)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 25)
        Label3.TabIndex = 37
        Label3.Text = "Nomor Plat:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(-2, -6)
        Label1.Name = "Label1"
        Label1.Size = New Size(491, 65)
        Label1.TabIndex = 35
        Label1.Text = "SIParkir - Form Utama"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {SistemToolStripMenuItem, AdminToolStripMenuItem, BantuanToolStripMenuItem})
        MenuStrip1.Location = New Point(8, 59)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.System
        MenuStrip1.Size = New Size(262, 33)
        MenuStrip1.TabIndex = 53
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SistemToolStripMenuItem
        ' 
        SistemToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SistemToolStripMenuItem1, AturProfilToolStripMenuItem, LogoutToolStripMenuItem})
        SistemToolStripMenuItem.Name = "SistemToolStripMenuItem"
        SistemToolStripMenuItem.Size = New Size(81, 29)
        SistemToolStripMenuItem.Text = "Sistem"
        ' 
        ' SistemToolStripMenuItem1
        ' 
        SistemToolStripMenuItem1.Name = "SistemToolStripMenuItem1"
        SistemToolStripMenuItem1.Size = New Size(270, 34)
        SistemToolStripMenuItem1.Text = "Sistem"
        ' 
        ' AturProfilToolStripMenuItem
        ' 
        AturProfilToolStripMenuItem.Name = "AturProfilToolStripMenuItem"
        AturProfilToolStripMenuItem.Size = New Size(270, 34)
        AturProfilToolStripMenuItem.Text = "Atur Profil"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(270, 34)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' AdminToolStripMenuItem
        ' 
        AdminToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LanggananToolStripMenuItem, LaporanToolStripMenuItem})
        AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        AdminToolStripMenuItem.Size = New Size(81, 29)
        AdminToolStripMenuItem.Text = "Admin"
        ' 
        ' LanggananToolStripMenuItem
        ' 
        LanggananToolStripMenuItem.Name = "LanggananToolStripMenuItem"
        LanggananToolStripMenuItem.Size = New Size(270, 34)
        LanggananToolStripMenuItem.Text = "Langganan"
        ' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(270, 34)
        LaporanToolStripMenuItem.Text = "Laporan"
        ' 
        ' BantuanToolStripMenuItem
        ' 
        BantuanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BantuanToolStripMenuItem1, TentangToolStripMenuItem})
        BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        BantuanToolStripMenuItem.Size = New Size(92, 29)
        BantuanToolStripMenuItem.Text = "Bantuan"
        ' 
        ' BantuanToolStripMenuItem1
        ' 
        BantuanToolStripMenuItem1.Name = "BantuanToolStripMenuItem1"
        BantuanToolStripMenuItem1.Size = New Size(270, 34)
        BantuanToolStripMenuItem1.Text = "Bantuan"
        ' 
        ' TentangToolStripMenuItem
        ' 
        TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        TentangToolStripMenuItem.Size = New Size(270, 34)
        TentangToolStripMenuItem.Text = "Tentang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.GradientActiveCaption
        Label2.Location = New Point(12, 394)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 25)
        Label2.TabIndex = 54
        Label2.Text = "Biaya Parkir:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonFace
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(161, 394)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 96)
        Panel1.TabIndex = 55
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ButtonFace
        Label4.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(36, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(181, 65)
        Label4.TabIndex = 0
        Label4.Text = "50.000"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(477, 236)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(412, 427)
        DataGridView1.TabIndex = 56
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonFace
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(8, 88)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(935, 103)
        Panel2.TabIndex = 57
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(253, 4)
        Label5.Name = "Label5"
        Label5.Size = New Size(390, 96)
        Label5.TabIndex = 0
        Label5.Text = "R 6872 ZH"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.GradientActiveCaption
        Label9.Location = New Point(12, 590)
        Label9.Name = "Label9"
        Label9.Size = New Size(176, 25)
        Label9.TabIndex = 58
        Label9.Text = "Tanggal : 12 -34-578"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.GradientActiveCaption
        Label10.Location = New Point(12, 552)
        Label10.Name = "Label10"
        Label10.Size = New Size(87, 25)
        Label10.TabIndex = 59
        Label10.Text = "Informasi"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = SystemColors.GradientActiveCaption
        Label11.Location = New Point(292, 590)
        Label11.Name = "Label11"
        Label11.Size = New Size(113, 25)
        Label11.TabIndex = 60
        Label11.Text = "jam:00:00:00"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = SystemColors.GradientActiveCaption
        Label12.Location = New Point(12, 664)
        Label12.Name = "Label12"
        Label12.Size = New Size(339, 25)
        Label12.TabIndex = 61
        Label12.Text = "o Motor,o Mobil,o Taksi, o Spd,o Bis/Truk"
        ' 
        ' Label13
        ' 
        Label13.BackColor = SystemColors.ActiveCaptionText
        Label13.Location = New Point(20, 507)
        Label13.Name = "Label13"
        Label13.Size = New Size(440, 10)
        Label13.TabIndex = 62
        Label13.Text = "Label13"
        ' 
        ' KelolaParkir
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(954, 725)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Panel2)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(ComboBox1)
        Controls.Add(Label6)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "KelolaParkir"
        Text = "KelolaParkir"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SistemToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AturProfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LanggananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
