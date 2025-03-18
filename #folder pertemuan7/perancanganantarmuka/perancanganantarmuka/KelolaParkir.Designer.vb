<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtama
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
        components = New ComponentModel.Container()
        Label8 = New Label()
        Label7 = New Label()
        txtNoPlat = New TextBox()
        lblInputPlat = New Label()
        Label1 = New Label()
        MenuStrip1 = New MenuStrip()
        SistemToolStripMenuItem = New ToolStripMenuItem()
        ProfilToolStripMenuItem1 = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        AdminToolStripMenuItem = New ToolStripMenuItem()
        DaftarKendaraanToolStripMenuItem = New ToolStripMenuItem()
        LaporanPendapatanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem1 = New ToolStripMenuItem()
        TentangToolStripMenuItem = New ToolStripMenuItem()
        Label2 = New Label()
        pnlHarga = New Panel()
        lblHarga = New Label()
        DataGridView1 = New DataGridView()
        ColNoPlat = New DataGridViewTextBoxColumn()
        ColMasuk = New DataGridViewTextBoxColumn()
        ColKeluar = New DataGridViewTextBoxColumn()
        ColHarga = New DataGridViewTextBoxColumn()
        ColJenis = New DataGridViewTextBoxColumn()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        DeleteToolStripMenuItem = New ToolStripMenuItem()
        pnlPlat = New Panel()
        lblPlat = New Label()
        lblTgl = New Label()
        lblInfoUser = New Label()
        Label11 = New Label()
        lblJmlKendaraan = New Label()
        Label13 = New Label()
        pnlInput = New Panel()
        lblInfoJenis = New Label()
        lblTekan = New Label()
        lblJenis = New Label()
        pnlGrid = New Panel()
        MenuStrip1.SuspendLayout()
        pnlHarga.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        ContextMenuStrip1.SuspendLayout()
        pnlPlat.SuspendLayout()
        pnlInput.SuspendLayout()
        pnlGrid.SuspendLayout()
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
        ' txtNoPlat
        ' 
        txtNoPlat.BackColor = SystemColors.GradientActiveCaption
        txtNoPlat.BorderStyle = BorderStyle.FixedSingle
        txtNoPlat.ForeColor = SystemColors.InfoText
        txtNoPlat.Location = New Point(116, 19)
        txtNoPlat.Name = "txtNoPlat"
        txtNoPlat.Size = New Size(277, 31)
        txtNoPlat.TabIndex = 38
        ' 
        ' lblInputPlat
        ' 
        lblInputPlat.AutoSize = True
        lblInputPlat.BackColor = SystemColors.GradientActiveCaption
        lblInputPlat.Location = New Point(3, 21)
        lblInputPlat.Name = "lblInputPlat"
        lblInputPlat.Size = New Size(107, 25)
        lblInputPlat.TabIndex = 37
        lblInputPlat.Text = "Nomor Plat:"
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
        MenuStrip1.Size = New Size(442, 33)
        MenuStrip1.TabIndex = 53
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SistemToolStripMenuItem
        ' 
        SistemToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProfilToolStripMenuItem1, LogoutToolStripMenuItem})
        SistemToolStripMenuItem.Name = "SistemToolStripMenuItem"
        SistemToolStripMenuItem.Size = New Size(81, 29)
        SistemToolStripMenuItem.Text = "Sistem"
        ' 
        ' ProfilToolStripMenuItem1
        ' 
        ProfilToolStripMenuItem1.Name = "ProfilToolStripMenuItem1"
        ProfilToolStripMenuItem1.Size = New Size(270, 34)
        ProfilToolStripMenuItem1.Text = "Profil"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(270, 34)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' AdminToolStripMenuItem
        ' 
        AdminToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DaftarKendaraanToolStripMenuItem, LaporanPendapatanToolStripMenuItem})
        AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        AdminToolStripMenuItem.Size = New Size(81, 29)
        AdminToolStripMenuItem.Text = "Admin"
        ' 
        ' DaftarKendaraanToolStripMenuItem
        ' 
        DaftarKendaraanToolStripMenuItem.Name = "DaftarKendaraanToolStripMenuItem"
        DaftarKendaraanToolStripMenuItem.Size = New Size(289, 34)
        DaftarKendaraanToolStripMenuItem.Text = "Kendaraan Langganan"
        ' 
        ' LaporanPendapatanToolStripMenuItem
        ' 
        LaporanPendapatanToolStripMenuItem.Name = "LaporanPendapatanToolStripMenuItem"
        LaporanPendapatanToolStripMenuItem.Size = New Size(289, 34)
        LaporanPendapatanToolStripMenuItem.Text = "Laporan pendapatan"
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
        BantuanToolStripMenuItem1.Size = New Size(178, 34)
        BantuanToolStripMenuItem1.Text = "Bantuan"
        ' 
        ' TentangToolStripMenuItem
        ' 
        TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        TentangToolStripMenuItem.Size = New Size(178, 34)
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
        ' pnlHarga
        ' 
        pnlHarga.BackColor = SystemColors.ButtonFace
        pnlHarga.BorderStyle = BorderStyle.Fixed3D
        pnlHarga.Controls.Add(lblHarga)
        pnlHarga.Location = New Point(161, 394)
        pnlHarga.Name = "pnlHarga"
        pnlHarga.Size = New Size(300, 96)
        pnlHarga.TabIndex = 55
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.BackColor = SystemColors.ButtonFace
        lblHarga.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHarga.Location = New Point(36, 11)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(181, 65)
        lblHarga.TabIndex = 0
        lblHarga.Text = "50.000"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ColNoPlat, ColMasuk, ColKeluar, ColHarga, ColJenis})
        DataGridView1.ContextMenuStrip = ContextMenuStrip1
        DataGridView1.Location = New Point(13, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(417, 394)
        DataGridView1.TabIndex = 56
        ' 
        ' ColNoPlat
        ' 
        ColNoPlat.HeaderText = "No Plat"
        ColNoPlat.MinimumWidth = 8
        ColNoPlat.Name = "ColNoPlat"
        ColNoPlat.ReadOnly = True
        ColNoPlat.Width = 150
        ' 
        ' ColMasuk
        ' 
        ColMasuk.HeaderText = "Masuk "
        ColMasuk.MinimumWidth = 8
        ColMasuk.Name = "ColMasuk"
        ColMasuk.ReadOnly = True
        ColMasuk.Width = 150
        ' 
        ' ColKeluar
        ' 
        ColKeluar.HeaderText = "Keluar"
        ColKeluar.MinimumWidth = 8
        ColKeluar.Name = "ColKeluar"
        ColKeluar.ReadOnly = True
        ColKeluar.Width = 150
        ' 
        ' ColHarga
        ' 
        ColHarga.HeaderText = "Harga"
        ColHarga.MinimumWidth = 8
        ColHarga.Name = "ColHarga"
        ColHarga.ReadOnly = True
        ColHarga.Width = 150
        ' 
        ' ColJenis
        ' 
        ColJenis.HeaderText = "Jenis"
        ColJenis.MinimumWidth = 8
        ColJenis.Name = "ColJenis"
        ColJenis.ReadOnly = True
        ColJenis.Width = 150
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {DeleteToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(135, 36)
        ' 
        ' DeleteToolStripMenuItem
        ' 
        DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        DeleteToolStripMenuItem.Size = New Size(134, 32)
        DeleteToolStripMenuItem.Text = "Delete"
        ' 
        ' pnlPlat
        ' 
        pnlPlat.BackColor = SystemColors.ButtonFace
        pnlPlat.BorderStyle = BorderStyle.Fixed3D
        pnlPlat.Controls.Add(lblPlat)
        pnlPlat.Location = New Point(8, 88)
        pnlPlat.Name = "pnlPlat"
        pnlPlat.Size = New Size(935, 103)
        pnlPlat.TabIndex = 57
        ' 
        ' lblPlat
        ' 
        lblPlat.AutoSize = True
        lblPlat.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlat.Location = New Point(253, 4)
        lblPlat.Name = "lblPlat"
        lblPlat.Size = New Size(390, 96)
        lblPlat.TabIndex = 0
        lblPlat.Text = "R 6872 ZH"
        ' 
        ' lblTgl
        ' 
        lblTgl.AutoSize = True
        lblTgl.BackColor = SystemColors.GradientActiveCaption
        lblTgl.Location = New Point(12, 590)
        lblTgl.Name = "lblTgl"
        lblTgl.Size = New Size(176, 25)
        lblTgl.TabIndex = 58
        lblTgl.Text = "Tanggal : 12 -34-578"
        ' 
        ' lblInfoUser
        ' 
        lblInfoUser.AutoSize = True
        lblInfoUser.BackColor = SystemColors.GradientActiveCaption
        lblInfoUser.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInfoUser.Location = New Point(12, 552)
        lblInfoUser.Name = "lblInfoUser"
        lblInfoUser.Size = New Size(93, 25)
        lblInfoUser.TabIndex = 59
        lblInfoUser.Text = "Informasi"
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
        ' lblJmlKendaraan
        ' 
        lblJmlKendaraan.AutoSize = True
        lblJmlKendaraan.BackColor = SystemColors.GradientActiveCaption
        lblJmlKendaraan.Location = New Point(12, 664)
        lblJmlKendaraan.Name = "lblJmlKendaraan"
        lblJmlKendaraan.Size = New Size(339, 25)
        lblJmlKendaraan.TabIndex = 61
        lblJmlKendaraan.Text = "o Motor,o Mobil,o Taksi, o Spd,o Bis/Truk"
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
        ' pnlInput
        ' 
        pnlInput.BorderStyle = BorderStyle.Fixed3D
        pnlInput.Controls.Add(lblInfoJenis)
        pnlInput.Controls.Add(lblTekan)
        pnlInput.Controls.Add(lblJenis)
        pnlInput.Controls.Add(txtNoPlat)
        pnlInput.Controls.Add(lblInputPlat)
        pnlInput.Location = New Point(20, 197)
        pnlInput.Name = "pnlInput"
        pnlInput.Size = New Size(429, 180)
        pnlInput.TabIndex = 64
        ' 
        ' lblInfoJenis
        ' 
        lblInfoJenis.AutoSize = True
        lblInfoJenis.Location = New Point(401, 21)
        lblInfoJenis.Name = "lblInfoJenis"
        lblInfoJenis.Size = New Size(0, 25)
        lblInfoJenis.TabIndex = 41
        ' 
        ' lblTekan
        ' 
        lblTekan.AutoSize = True
        lblTekan.Location = New Point(3, 108)
        lblTekan.Name = "lblTekan"
        lblTekan.Size = New Size(220, 50)
        lblTekan.TabIndex = 40
        lblTekan.Text = "Tekan Enter untuk Masuk /" & vbCrLf & "Keluar" & vbCrLf
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Location = New Point(3, 58)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(398, 50)
        lblJenis.TabIndex = 39
        lblJenis.Text = "F1 - Motor, F2 - Mobil, F3 -Taksi, F4 - Sepeda, F5" & vbCrLf & " - Bis/Truk" & vbCrLf
        ' 
        ' pnlGrid
        ' 
        pnlGrid.AutoScroll = True
        pnlGrid.Controls.Add(DataGridView1)
        pnlGrid.Location = New Point(478, 254)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Size = New Size(444, 412)
        pnlGrid.TabIndex = 65
        ' 
        ' frmUtama
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(954, 725)
        Controls.Add(pnlGrid)
        Controls.Add(pnlInput)
        Controls.Add(Label13)
        Controls.Add(lblJmlKendaraan)
        Controls.Add(Label11)
        Controls.Add(lblInfoUser)
        Controls.Add(lblTgl)
        Controls.Add(pnlPlat)
        Controls.Add(pnlHarga)
        Controls.Add(Label2)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        KeyPreview = True
        MainMenuStrip = MenuStrip1
        MinimizeBox = False
        Name = "frmUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Parkir System v.1.0"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        pnlHarga.ResumeLayout(False)
        pnlHarga.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ContextMenuStrip1.ResumeLayout(False)
        pnlPlat.ResumeLayout(False)
        pnlPlat.PerformLayout()
        pnlInput.ResumeLayout(False)
        pnlInput.PerformLayout()
        pnlGrid.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNoPlat As TextBox
    Friend WithEvents lblInputPlat As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfilToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaftarKendaraanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPendapatanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlHarga As Panel
    Friend WithEvents lblHarga As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents pnlPlat As Panel
    Friend WithEvents lblPlat As Label
    Friend WithEvents lblTgl As Label
    Friend WithEvents lblInfoUser As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblJmlKendaraan As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlInput As Panel
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents lblTekan As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents lblInfoJenis As Label
    Friend WithEvents ColNoPlat As DataGridViewTextBoxColumn
    Friend WithEvents ColMasuk As DataGridViewTextBoxColumn
    Friend WithEvents ColKeluar As DataGridViewTextBoxColumn
    Friend WithEvents ColHarga As DataGridViewTextBoxColumn
    Friend WithEvents ColJenis As DataGridViewTextBoxColumn
End Class
