<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLangganan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtBiaya = New TextBox()
        lblBiaya = New Label()
        btnHapus = New Button()
        btnEdit = New Button()
        txtNoPlat = New TextBox()
        txtNama = New TextBox()
        lblNoPlat = New Label()
        lblNama = New Label()
        Label1 = New Label()
        lblExpired = New Label()
        DateTimePicker1 = New DateTimePicker()
        btnTambah = New Button()
        lblJenis = New Label()
        cmbJenis = New ComboBox()
        lblId = New Label()
        Label8 = New Label()
        DataGridView1 = New DataGridView()
        Button4 = New Button()
        btnCancel = New Button()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtBiaya
        ' 
        txtBiaya.BackColor = SystemColors.GradientActiveCaption
        txtBiaya.BorderStyle = BorderStyle.FixedSingle
        txtBiaya.Location = New Point(217, 207)
        txtBiaya.Name = "txtBiaya"
        txtBiaya.Size = New Size(201, 31)
        txtBiaya.TabIndex = 24
        ' 
        ' lblBiaya
        ' 
        lblBiaya.AutoSize = True
        lblBiaya.BackColor = SystemColors.GradientActiveCaption
        lblBiaya.Location = New Point(33, 207)
        lblBiaya.Name = "lblBiaya"
        lblBiaya.Size = New Size(140, 25)
        lblBiaya.TabIndex = 23
        lblBiaya.Text = "Tarif Langganan:"
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.WhiteSmoke
        btnHapus.Location = New Point(683, 255)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(112, 32)
        btnHapus.TabIndex = 22
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.WhiteSmoke
        btnEdit.Location = New Point(565, 255)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(112, 32)
        btnEdit.TabIndex = 21
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' txtNoPlat
        ' 
        txtNoPlat.BackColor = SystemColors.GradientActiveCaption
        txtNoPlat.BorderStyle = BorderStyle.FixedSingle
        txtNoPlat.Location = New Point(217, 160)
        txtNoPlat.Name = "txtNoPlat"
        txtNoPlat.Size = New Size(201, 31)
        txtNoPlat.TabIndex = 20
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = SystemColors.GradientActiveCaption
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.Location = New Point(217, 100)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(277, 31)
        txtNama.TabIndex = 19
        ' 
        ' lblNoPlat
        ' 
        lblNoPlat.AutoSize = True
        lblNoPlat.BackColor = SystemColors.GradientActiveCaption
        lblNoPlat.Location = New Point(30, 160)
        lblNoPlat.Name = "lblNoPlat"
        lblNoPlat.Size = New Size(107, 25)
        lblNoPlat.TabIndex = 18
        lblNoPlat.Text = "Nomor Plat:"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = SystemColors.GradientActiveCaption
        lblNama.Location = New Point(30, 102)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(155, 25)
        lblNama.TabIndex = 17
        lblNama.Text = "Nama Pelanggan :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(467, 65)
        Label1.TabIndex = 16
        Label1.Text = "SIParkir - Ubah Profil"
        ' 
        ' lblExpired
        ' 
        lblExpired.AutoSize = True
        lblExpired.BackColor = SystemColors.GradientActiveCaption
        lblExpired.Location = New Point(33, 262)
        lblExpired.Name = "lblExpired"
        lblExpired.Size = New Size(136, 25)
        lblExpired.TabIndex = 25
        lblExpired.Text = "Berlaku Hingga:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarMonthBackground = SystemColors.GradientActiveCaption
        DateTimePicker1.CalendarTitleBackColor = SystemColors.GradientActiveCaption
        DateTimePicker1.Location = New Point(217, 257)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(201, 31)
        DateTimePicker1.TabIndex = 27
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.WhiteSmoke
        btnTambah.Location = New Point(447, 255)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 32)
        btnTambah.TabIndex = 28
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.BackColor = SystemColors.GradientActiveCaption
        lblJenis.Location = New Point(483, 162)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(58, 25)
        lblJenis.TabIndex = 29
        lblJenis.Text = "Jenis :"
        ' 
        ' cmbJenis
        ' 
        cmbJenis.FormattingEnabled = True
        cmbJenis.Items.AddRange(New Object() {"Motor", "Mobil", "Taxi/Umum", "Truk", "Sepeda"})
        cmbJenis.Location = New Point(552, 161)
        cmbJenis.Name = "cmbJenis"
        cmbJenis.Size = New Size(138, 33)
        cmbJenis.TabIndex = 30
        cmbJenis.Text = "option 1"
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.BackColor = SystemColors.GradientActiveCaption
        lblId.Location = New Point(514, 102)
        lblId.Name = "lblId"
        lblId.Size = New Size(119, 25)
        lblId.TabIndex = 31
        lblId.Text = "Id Pelanggan:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.GradientActiveCaption
        Label8.Location = New Point(33, 329)
        Label8.Name = "Label8"
        Label8.Size = New Size(259, 25)
        Label8.TabIndex = 32
        Label8.Text = "Kendaraan terdaftar Pelanggan:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        DataGridView1.Location = New Point(30, 357)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(810, 164)
        DataGridView1.TabIndex = 33
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.WhiteSmoke
        Button4.Location = New Point(728, 551)
        Button4.Name = "Button4"
        Button4.Size = New Size(112, 32)
        Button4.TabIndex = 34
        Button4.Text = "Tutup"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.WhiteSmoke
        btnCancel.Location = New Point(801, 255)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 32)
        btnCancel.TabIndex = 35
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "id"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "No Plat"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Nama Pemilik"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Biaya"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Jenis"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.Width = 150
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Expired"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.Width = 150
        ' 
        ' frmLangganan
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(936, 624)
        Controls.Add(btnCancel)
        Controls.Add(Button4)
        Controls.Add(DataGridView1)
        Controls.Add(Label8)
        Controls.Add(lblId)
        Controls.Add(cmbJenis)
        Controls.Add(lblJenis)
        Controls.Add(btnTambah)
        Controls.Add(DateTimePicker1)
        Controls.Add(lblExpired)
        Controls.Add(txtBiaya)
        Controls.Add(lblBiaya)
        Controls.Add(btnHapus)
        Controls.Add(btnEdit)
        Controls.Add(txtNoPlat)
        Controls.Add(txtNama)
        Controls.Add(lblNoPlat)
        Controls.Add(lblNama)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "frmLangganan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Langganan"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtBiaya As TextBox
    Friend WithEvents lblBiaya As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtNoPlat As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNoPlat As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblExpired As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnTambah As Button
    Friend WithEvents lblJenis As Label
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents lblId As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
