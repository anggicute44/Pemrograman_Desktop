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
        components = New ComponentModel.Container()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        lblPath = New Label()
        txtPath = New TextBox()
        btnPath = New Button()
        lblExt = New Label()
        txtExt = New TextBox()
        lblOri = New Label()
        lblPreview = New Label()
        lvOri = New ListView()
        chFileName = New ColumnHeader()
        chExtension = New ColumnHeader()
        chAttribute = New ColumnHeader()
        chCreated = New ColumnHeader()
        chAccessed = New ColumnHeader()
        chModified = New ColumnHeader()
        lvPreview = New ListView()
        chFileName2 = New ColumnHeader()
        chExtension2 = New ColumnHeader()
        chAttribute2 = New ColumnHeader()
        chCreated2 = New ColumnHeader()
        chAccessed2 = New ColumnHeader()
        chModified2 = New ColumnHeader()
        TabControl1 = New TabControl()
        TpFilename = New TabPage()
        cbCaseF = New ComboBox()
        txtInsertAfterF = New TextBox()
        txtRightCropNCharF = New TextBox()
        txtWithThisF = New TextBox()
        txtReplaceThisF = New TextBox()
        txtInsertBeforeF = New TextBox()
        txtLeftCropNCharF = New TextBox()
        txtReplaceWithF = New TextBox()
        lblWithThisF = New Label()
        lblCaseF = New Label()
        rbRightCropNCharF = New RadioButton()
        rbLeftCropNCharF = New RadioButton()
        rbInsertAfterF = New RadioButton()
        rbInsertBeforeF = New RadioButton()
        rbReplaceThisF = New RadioButton()
        rbReplaceWithF = New RadioButton()
        TpExtension = New TabPage()
        cbCaseE = New ComboBox()
        txtInsertAfterE = New TextBox()
        txtRightCropNCharE = New TextBox()
        txtWithThisE = New TextBox()
        txtReplaceThisE = New TextBox()
        txtInsertBeforeE = New TextBox()
        txtLeftCropNCharE = New TextBox()
        txtReplaceWithE = New TextBox()
        lblWithThisE = New Label()
        lblCaseE = New Label()
        rbRightCropNCharE = New RadioButton()
        rbLeftCropNCharE = New RadioButton()
        rbInsertAfterE = New RadioButton()
        rbInsertBeforeE = New RadioButton()
        rbReplaceThisE = New RadioButton()
        rbReplaceWithE = New RadioButton()
        TpAutoNumber = New TabPage()
        gbWith = New GroupBox()
        nudIncrementBy = New NumericUpDown()
        nudStartWithNumber = New NumericUpDown()
        lblIncrementBy = New Label()
        lblStartWithNumber = New Label()
        gbPlace = New GroupBox()
        rbBeforeFileName = New RadioButton()
        rbAfterFileName = New RadioButton()
        btnPreview = New Button()
        btnRename = New Button()
        btnUndo = New Button()
        ImageList1 = New ImageList(components)
        TabControl1.SuspendLayout()
        TpFilename.SuspendLayout()
        TpExtension.SuspendLayout()
        TpAutoNumber.SuspendLayout()
        gbWith.SuspendLayout()
        CType(nudIncrementBy, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudStartWithNumber, ComponentModel.ISupportInitialize).BeginInit()
        gbPlace.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblPath
        ' 
        lblPath.AutoSize = True
        lblPath.Location = New Point(24, 16)
        lblPath.Name = "lblPath"
        lblPath.Size = New Size(50, 25)
        lblPath.TabIndex = 0
        lblPath.Text = "Path:"
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(80, 13)
        txtPath.Multiline = True
        txtPath.Name = "txtPath"
        txtPath.Size = New Size(668, 34)
        txtPath.TabIndex = 1
        ' 
        ' btnPath
        ' 
        btnPath.BackColor = SystemColors.ButtonFace
        btnPath.FlatStyle = FlatStyle.System
        btnPath.ForeColor = Color.Gray
        btnPath.Location = New Point(768, 12)
        btnPath.Name = "btnPath"
        btnPath.Size = New Size(74, 35)
        btnPath.TabIndex = 2
        btnPath.Text = "...."
        btnPath.TextAlign = ContentAlignment.BottomCenter
        btnPath.UseVisualStyleBackColor = False
        ' 
        ' lblExt
        ' 
        lblExt.AutoSize = True
        lblExt.Location = New Point(864, 17)
        lblExt.Name = "lblExt"
        lblExt.Size = New Size(70, 25)
        lblExt.TabIndex = 3
        lblExt.Text = "File Ext:"
        ' 
        ' txtExt
        ' 
        txtExt.Location = New Point(953, 16)
        txtExt.Name = "txtExt"
        txtExt.Size = New Size(69, 31)
        txtExt.TabIndex = 4
        txtExt.Text = "*.*"
        ' 
        ' lblOri
        ' 
        lblOri.AutoSize = True
        lblOri.Location = New Point(24, 59)
        lblOri.Name = "lblOri"
        lblOri.Size = New Size(109, 25)
        lblOri.TabIndex = 5
        lblOri.Text = "Original File:"
        ' 
        ' lblPreview
        ' 
        lblPreview.AutoSize = True
        lblPreview.Location = New Point(518, 59)
        lblPreview.Name = "lblPreview"
        lblPreview.Size = New Size(107, 25)
        lblPreview.TabIndex = 6
        lblPreview.Text = "Preview File:"
        ' 
        ' lvOri
        ' 
        lvOri.Columns.AddRange(New ColumnHeader() {chFileName, chExtension, chAttribute, chCreated, chAccessed, chModified})
        lvOri.GridLines = True
        lvOri.Location = New Point(12, 87)
        lvOri.Name = "lvOri"
        lvOri.Size = New Size(478, 351)
        lvOri.TabIndex = 7
        lvOri.UseCompatibleStateImageBehavior = False
        lvOri.View = View.Details
        ' 
        ' chFileName
        ' 
        chFileName.Text = "File Name"
        ' 
        ' chExtension
        ' 
        chExtension.Text = "Extension"
        ' 
        ' chAttribute
        ' 
        chAttribute.Text = "Attributes"
        ' 
        ' chCreated
        ' 
        chCreated.Text = "Date Created"
        ' 
        ' chAccessed
        ' 
        chAccessed.Text = "Date Accessed"
        ' 
        ' chModified
        ' 
        chModified.Text = "Date Modified"
        ' 
        ' lvPreview
        ' 
        lvPreview.Columns.AddRange(New ColumnHeader() {chFileName2, chExtension2, chAttribute2, chCreated2, chAccessed2, chModified2})
        lvPreview.GridLines = True
        lvPreview.Location = New Point(503, 87)
        lvPreview.Name = "lvPreview"
        lvPreview.Size = New Size(555, 351)
        lvPreview.TabIndex = 8
        lvPreview.UseCompatibleStateImageBehavior = False
        lvPreview.View = View.Details
        ' 
        ' chFileName2
        ' 
        chFileName2.Text = "File Name"
        ' 
        ' chExtension2
        ' 
        chExtension2.Text = "Extension"
        ' 
        ' chAttribute2
        ' 
        chAttribute2.Text = "Attributes"
        ' 
        ' chCreated2
        ' 
        chCreated2.Text = "Date Created"
        ' 
        ' chAccessed2
        ' 
        chAccessed2.Text = "Date Accessed"
        ' 
        ' chModified2
        ' 
        chModified2.Text = "Date Modified"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TpFilename)
        TabControl1.Controls.Add(TpExtension)
        TabControl1.Controls.Add(TpAutoNumber)
        TabControl1.Location = New Point(12, 444)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(894, 291)
        TabControl1.TabIndex = 9
        ' 
        ' TpFilename
        ' 
        TpFilename.Controls.Add(cbCaseF)
        TpFilename.Controls.Add(txtInsertAfterF)
        TpFilename.Controls.Add(txtRightCropNCharF)
        TpFilename.Controls.Add(txtWithThisF)
        TpFilename.Controls.Add(txtReplaceThisF)
        TpFilename.Controls.Add(txtInsertBeforeF)
        TpFilename.Controls.Add(txtLeftCropNCharF)
        TpFilename.Controls.Add(txtReplaceWithF)
        TpFilename.Controls.Add(lblWithThisF)
        TpFilename.Controls.Add(lblCaseF)
        TpFilename.Controls.Add(rbRightCropNCharF)
        TpFilename.Controls.Add(rbLeftCropNCharF)
        TpFilename.Controls.Add(rbInsertAfterF)
        TpFilename.Controls.Add(rbInsertBeforeF)
        TpFilename.Controls.Add(rbReplaceThisF)
        TpFilename.Controls.Add(rbReplaceWithF)
        TpFilename.Location = New Point(4, 34)
        TpFilename.Name = "TpFilename"
        TpFilename.Padding = New Padding(3)
        TpFilename.Size = New Size(886, 253)
        TpFilename.TabIndex = 0
        TpFilename.Text = "Filename"
        TpFilename.UseVisualStyleBackColor = True
        ' 
        ' cbCaseF
        ' 
        cbCaseF.FormattingEnabled = True
        cbCaseF.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        cbCaseF.Location = New Point(570, 27)
        cbCaseF.Name = "cbCaseF"
        cbCaseF.Size = New Size(291, 33)
        cbCaseF.TabIndex = 15
        ' 
        ' txtInsertAfterF
        ' 
        txtInsertAfterF.Location = New Point(594, 128)
        txtInsertAfterF.Name = "txtInsertAfterF"
        txtInsertAfterF.ReadOnly = True
        txtInsertAfterF.Size = New Size(267, 31)
        txtInsertAfterF.TabIndex = 14
        ' 
        ' txtRightCropNCharF
        ' 
        txtRightCropNCharF.Location = New Point(645, 199)
        txtRightCropNCharF.Name = "txtRightCropNCharF"
        txtRightCropNCharF.ReadOnly = True
        txtRightCropNCharF.Size = New Size(216, 31)
        txtRightCropNCharF.TabIndex = 13
        ' 
        ' txtWithThisF
        ' 
        txtWithThisF.Location = New Point(541, 69)
        txtWithThisF.Name = "txtWithThisF"
        txtWithThisF.ReadOnly = True
        txtWithThisF.Size = New Size(320, 31)
        txtWithThisF.TabIndex = 12
        ' 
        ' txtReplaceThisF
        ' 
        txtReplaceThisF.Location = New Point(150, 68)
        txtReplaceThisF.Name = "txtReplaceThisF"
        txtReplaceThisF.ReadOnly = True
        txtReplaceThisF.Size = New Size(280, 31)
        txtReplaceThisF.TabIndex = 11
        ' 
        ' txtInsertBeforeF
        ' 
        txtInsertBeforeF.Location = New Point(150, 129)
        txtInsertBeforeF.Name = "txtInsertBeforeF"
        txtInsertBeforeF.ReadOnly = True
        txtInsertBeforeF.Size = New Size(307, 31)
        txtInsertBeforeF.TabIndex = 10
        ' 
        ' txtLeftCropNCharF
        ' 
        txtLeftCropNCharF.Location = New Point(175, 200)
        txtLeftCropNCharF.Name = "txtLeftCropNCharF"
        txtLeftCropNCharF.ReadOnly = True
        txtLeftCropNCharF.Size = New Size(207, 31)
        txtLeftCropNCharF.TabIndex = 9
        ' 
        ' txtReplaceWithF
        ' 
        txtReplaceWithF.Location = New Point(150, 20)
        txtReplaceWithF.Name = "txtReplaceWithF"
        txtReplaceWithF.ReadOnly = True
        txtReplaceWithF.Size = New Size(346, 31)
        txtReplaceWithF.TabIndex = 8
        ' 
        ' lblWithThisF
        ' 
        lblWithThisF.AutoSize = True
        lblWithThisF.Location = New Point(436, 68)
        lblWithThisF.Name = "lblWithThisF"
        lblWithThisF.Size = New Size(82, 25)
        lblWithThisF.TabIndex = 7
        lblWithThisF.Text = "With this"
        ' 
        ' lblCaseF
        ' 
        lblCaseF.AutoSize = True
        lblCaseF.Location = New Point(502, 25)
        lblCaseF.Name = "lblCaseF"
        lblCaseF.Size = New Size(53, 25)
        lblCaseF.TabIndex = 6
        lblCaseF.Text = "Case:"
        ' 
        ' rbRightCropNCharF
        ' 
        rbRightCropNCharF.AutoSize = True
        rbRightCropNCharF.Location = New Point(463, 201)
        rbRightCropNCharF.Name = "rbRightCropNCharF"
        rbRightCropNCharF.Size = New Size(176, 29)
        rbRightCropNCharF.TabIndex = 5
        rbRightCropNCharF.TabStop = True
        rbRightCropNCharF.Text = "Right Crop n char"
        rbRightCropNCharF.UseVisualStyleBackColor = True
        ' 
        ' rbLeftCropNCharF
        ' 
        rbLeftCropNCharF.AutoSize = True
        rbLeftCropNCharF.Location = New Point(6, 201)
        rbLeftCropNCharF.Name = "rbLeftCropNCharF"
        rbLeftCropNCharF.Size = New Size(163, 29)
        rbLeftCropNCharF.TabIndex = 4
        rbLeftCropNCharF.TabStop = True
        rbLeftCropNCharF.Text = "Left Crop n char"
        rbLeftCropNCharF.UseVisualStyleBackColor = True
        ' 
        ' rbInsertAfterF
        ' 
        rbInsertAfterF.AutoSize = True
        rbInsertAfterF.Location = New Point(463, 129)
        rbInsertAfterF.Name = "rbInsertAfterF"
        rbInsertAfterF.Size = New Size(125, 29)
        rbInsertAfterF.TabIndex = 3
        rbInsertAfterF.TabStop = True
        rbInsertAfterF.Text = "Insert After"
        rbInsertAfterF.UseVisualStyleBackColor = True
        ' 
        ' rbInsertBeforeF
        ' 
        rbInsertBeforeF.AutoSize = True
        rbInsertBeforeF.Location = New Point(10, 131)
        rbInsertBeforeF.Name = "rbInsertBeforeF"
        rbInsertBeforeF.Size = New Size(137, 29)
        rbInsertBeforeF.TabIndex = 2
        rbInsertBeforeF.TabStop = True
        rbInsertBeforeF.Text = "Insert Before"
        rbInsertBeforeF.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceThisF
        ' 
        rbReplaceThisF.AutoSize = True
        rbReplaceThisF.Location = New Point(6, 66)
        rbReplaceThisF.Name = "rbReplaceThisF"
        rbReplaceThisF.Size = New Size(133, 29)
        rbReplaceThisF.TabIndex = 1
        rbReplaceThisF.TabStop = True
        rbReplaceThisF.Text = "Replace This"
        rbReplaceThisF.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceWithF
        ' 
        rbReplaceWithF.AutoSize = True
        rbReplaceWithF.Location = New Point(6, 19)
        rbReplaceWithF.Name = "rbReplaceWithF"
        rbReplaceWithF.Size = New Size(139, 29)
        rbReplaceWithF.TabIndex = 0
        rbReplaceWithF.TabStop = True
        rbReplaceWithF.Text = "Replace With"
        rbReplaceWithF.UseVisualStyleBackColor = True
        ' 
        ' TpExtension
        ' 
        TpExtension.Controls.Add(cbCaseE)
        TpExtension.Controls.Add(txtInsertAfterE)
        TpExtension.Controls.Add(txtRightCropNCharE)
        TpExtension.Controls.Add(txtWithThisE)
        TpExtension.Controls.Add(txtReplaceThisE)
        TpExtension.Controls.Add(txtInsertBeforeE)
        TpExtension.Controls.Add(txtLeftCropNCharE)
        TpExtension.Controls.Add(txtReplaceWithE)
        TpExtension.Controls.Add(lblWithThisE)
        TpExtension.Controls.Add(lblCaseE)
        TpExtension.Controls.Add(rbRightCropNCharE)
        TpExtension.Controls.Add(rbLeftCropNCharE)
        TpExtension.Controls.Add(rbInsertAfterE)
        TpExtension.Controls.Add(rbInsertBeforeE)
        TpExtension.Controls.Add(rbReplaceThisE)
        TpExtension.Controls.Add(rbReplaceWithE)
        TpExtension.Location = New Point(4, 34)
        TpExtension.Name = "TpExtension"
        TpExtension.Size = New Size(886, 253)
        TpExtension.TabIndex = 1
        TpExtension.Text = "Extension"
        TpExtension.UseVisualStyleBackColor = True
        ' 
        ' cbCaseE
        ' 
        cbCaseE.FormattingEnabled = True
        cbCaseE.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        cbCaseE.Location = New Point(580, 28)
        cbCaseE.Name = "cbCaseE"
        cbCaseE.Size = New Size(291, 33)
        cbCaseE.TabIndex = 31
        ' 
        ' txtInsertAfterE
        ' 
        txtInsertAfterE.Location = New Point(604, 129)
        txtInsertAfterE.Name = "txtInsertAfterE"
        txtInsertAfterE.ReadOnly = True
        txtInsertAfterE.Size = New Size(267, 31)
        txtInsertAfterE.TabIndex = 30
        ' 
        ' txtRightCropNCharE
        ' 
        txtRightCropNCharE.Location = New Point(655, 200)
        txtRightCropNCharE.Name = "txtRightCropNCharE"
        txtRightCropNCharE.ReadOnly = True
        txtRightCropNCharE.Size = New Size(216, 31)
        txtRightCropNCharE.TabIndex = 29
        ' 
        ' txtWithThisE
        ' 
        txtWithThisE.Location = New Point(551, 70)
        txtWithThisE.Name = "txtWithThisE"
        txtWithThisE.ReadOnly = True
        txtWithThisE.Size = New Size(320, 31)
        txtWithThisE.TabIndex = 28
        ' 
        ' txtReplaceThisE
        ' 
        txtReplaceThisE.Location = New Point(160, 69)
        txtReplaceThisE.Name = "txtReplaceThisE"
        txtReplaceThisE.ReadOnly = True
        txtReplaceThisE.Size = New Size(280, 31)
        txtReplaceThisE.TabIndex = 27
        ' 
        ' txtInsertBeforeE
        ' 
        txtInsertBeforeE.Location = New Point(160, 130)
        txtInsertBeforeE.Name = "txtInsertBeforeE"
        txtInsertBeforeE.ReadOnly = True
        txtInsertBeforeE.Size = New Size(307, 31)
        txtInsertBeforeE.TabIndex = 26
        ' 
        ' txtLeftCropNCharE
        ' 
        txtLeftCropNCharE.Location = New Point(185, 201)
        txtLeftCropNCharE.Name = "txtLeftCropNCharE"
        txtLeftCropNCharE.ReadOnly = True
        txtLeftCropNCharE.Size = New Size(207, 31)
        txtLeftCropNCharE.TabIndex = 25
        ' 
        ' txtReplaceWithE
        ' 
        txtReplaceWithE.Location = New Point(160, 21)
        txtReplaceWithE.Name = "txtReplaceWithE"
        txtReplaceWithE.ReadOnly = True
        txtReplaceWithE.Size = New Size(346, 31)
        txtReplaceWithE.TabIndex = 24
        ' 
        ' lblWithThisE
        ' 
        lblWithThisE.AutoSize = True
        lblWithThisE.Location = New Point(446, 69)
        lblWithThisE.Name = "lblWithThisE"
        lblWithThisE.Size = New Size(82, 25)
        lblWithThisE.TabIndex = 23
        lblWithThisE.Text = "With this"
        ' 
        ' lblCaseE
        ' 
        lblCaseE.AutoSize = True
        lblCaseE.Location = New Point(512, 26)
        lblCaseE.Name = "lblCaseE"
        lblCaseE.Size = New Size(53, 25)
        lblCaseE.TabIndex = 22
        lblCaseE.Text = "Case:"
        ' 
        ' rbRightCropNCharE
        ' 
        rbRightCropNCharE.AutoSize = True
        rbRightCropNCharE.Location = New Point(473, 202)
        rbRightCropNCharE.Name = "rbRightCropNCharE"
        rbRightCropNCharE.Size = New Size(176, 29)
        rbRightCropNCharE.TabIndex = 21
        rbRightCropNCharE.TabStop = True
        rbRightCropNCharE.Text = "Right Crop n char"
        rbRightCropNCharE.UseVisualStyleBackColor = True
        ' 
        ' rbLeftCropNCharE
        ' 
        rbLeftCropNCharE.AutoSize = True
        rbLeftCropNCharE.Location = New Point(16, 202)
        rbLeftCropNCharE.Name = "rbLeftCropNCharE"
        rbLeftCropNCharE.Size = New Size(163, 29)
        rbLeftCropNCharE.TabIndex = 20
        rbLeftCropNCharE.TabStop = True
        rbLeftCropNCharE.Text = "Left Crop n char"
        rbLeftCropNCharE.UseVisualStyleBackColor = True
        ' 
        ' rbInsertAfterE
        ' 
        rbInsertAfterE.AutoSize = True
        rbInsertAfterE.Location = New Point(473, 130)
        rbInsertAfterE.Name = "rbInsertAfterE"
        rbInsertAfterE.Size = New Size(125, 29)
        rbInsertAfterE.TabIndex = 19
        rbInsertAfterE.TabStop = True
        rbInsertAfterE.Text = "Insert After"
        rbInsertAfterE.UseVisualStyleBackColor = True
        ' 
        ' rbInsertBeforeE
        ' 
        rbInsertBeforeE.AutoSize = True
        rbInsertBeforeE.Location = New Point(20, 132)
        rbInsertBeforeE.Name = "rbInsertBeforeE"
        rbInsertBeforeE.Size = New Size(137, 29)
        rbInsertBeforeE.TabIndex = 18
        rbInsertBeforeE.TabStop = True
        rbInsertBeforeE.Text = "Insert Before"
        rbInsertBeforeE.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceThisE
        ' 
        rbReplaceThisE.AutoSize = True
        rbReplaceThisE.Location = New Point(16, 67)
        rbReplaceThisE.Name = "rbReplaceThisE"
        rbReplaceThisE.Size = New Size(133, 29)
        rbReplaceThisE.TabIndex = 17
        rbReplaceThisE.TabStop = True
        rbReplaceThisE.Text = "Replace This"
        rbReplaceThisE.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceWithE
        ' 
        rbReplaceWithE.AutoSize = True
        rbReplaceWithE.Location = New Point(16, 20)
        rbReplaceWithE.Name = "rbReplaceWithE"
        rbReplaceWithE.Size = New Size(139, 29)
        rbReplaceWithE.TabIndex = 16
        rbReplaceWithE.TabStop = True
        rbReplaceWithE.Text = "Replace With"
        rbReplaceWithE.UseVisualStyleBackColor = True
        ' 
        ' TpAutoNumber
        ' 
        TpAutoNumber.Controls.Add(gbWith)
        TpAutoNumber.Controls.Add(gbPlace)
        TpAutoNumber.Location = New Point(4, 34)
        TpAutoNumber.Name = "TpAutoNumber"
        TpAutoNumber.Size = New Size(886, 253)
        TpAutoNumber.TabIndex = 2
        TpAutoNumber.Text = "AutoNumber"
        TpAutoNumber.UseVisualStyleBackColor = True
        ' 
        ' gbWith
        ' 
        gbWith.Controls.Add(nudIncrementBy)
        gbWith.Controls.Add(nudStartWithNumber)
        gbWith.Controls.Add(lblIncrementBy)
        gbWith.Controls.Add(lblStartWithNumber)
        gbWith.Location = New Point(425, 58)
        gbWith.Name = "gbWith"
        gbWith.Size = New Size(435, 150)
        gbWith.TabIndex = 1
        gbWith.TabStop = False
        gbWith.Text = "With:"
        ' 
        ' nudIncrementBy
        ' 
        nudIncrementBy.Location = New Point(195, 83)
        nudIncrementBy.Name = "nudIncrementBy"
        nudIncrementBy.Size = New Size(180, 31)
        nudIncrementBy.TabIndex = 3
        nudIncrementBy.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' nudStartWithNumber
        ' 
        nudStartWithNumber.Location = New Point(193, 29)
        nudStartWithNumber.Name = "nudStartWithNumber"
        nudStartWithNumber.Size = New Size(180, 31)
        nudStartWithNumber.TabIndex = 2
        nudStartWithNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' lblIncrementBy
        ' 
        lblIncrementBy.AutoSize = True
        lblIncrementBy.Location = New Point(15, 83)
        lblIncrementBy.Name = "lblIncrementBy"
        lblIncrementBy.Size = New Size(120, 25)
        lblIncrementBy.TabIndex = 1
        lblIncrementBy.Text = "Increment by:"
        ' 
        ' lblStartWithNumber
        ' 
        lblStartWithNumber.AutoSize = True
        lblStartWithNumber.Location = New Point(15, 30)
        lblStartWithNumber.Name = "lblStartWithNumber"
        lblStartWithNumber.Size = New Size(157, 25)
        lblStartWithNumber.TabIndex = 0
        lblStartWithNumber.Text = "Start with number:"
        ' 
        ' gbPlace
        ' 
        gbPlace.Controls.Add(rbBeforeFileName)
        gbPlace.Controls.Add(rbAfterFileName)
        gbPlace.Location = New Point(37, 51)
        gbPlace.Name = "gbPlace"
        gbPlace.Size = New Size(330, 150)
        gbPlace.TabIndex = 0
        gbPlace.TabStop = False
        gbPlace.Text = "Place:"
        ' 
        ' rbBeforeFileName
        ' 
        rbBeforeFileName.AutoSize = True
        rbBeforeFileName.Location = New Point(13, 89)
        rbBeforeFileName.Name = "rbBeforeFileName"
        rbBeforeFileName.Size = New Size(160, 29)
        rbBeforeFileName.TabIndex = 1
        rbBeforeFileName.TabStop = True
        rbBeforeFileName.Text = "Before filename"
        rbBeforeFileName.UseVisualStyleBackColor = True
        ' 
        ' rbAfterFileName
        ' 
        rbAfterFileName.AutoSize = True
        rbAfterFileName.Location = New Point(16, 36)
        rbAfterFileName.Name = "rbAfterFileName"
        rbAfterFileName.Size = New Size(148, 29)
        rbAfterFileName.TabIndex = 0
        rbAfterFileName.TabStop = True
        rbAfterFileName.Text = "After filename"
        rbAfterFileName.UseVisualStyleBackColor = True
        ' 
        ' btnPreview
        ' 
        btnPreview.Location = New Point(921, 494)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(112, 34)
        btnPreview.TabIndex = 10
        btnPreview.Text = "Preview"
        btnPreview.UseVisualStyleBackColor = True
        ' 
        ' btnRename
        ' 
        btnRename.Location = New Point(921, 555)
        btnRename.Name = "btnRename"
        btnRename.Size = New Size(112, 34)
        btnRename.TabIndex = 11
        btnRename.Text = "Rename"
        btnRename.UseVisualStyleBackColor = True
        ' 
        ' btnUndo
        ' 
        btnUndo.Location = New Point(921, 619)
        btnUndo.Name = "btnUndo"
        btnUndo.Size = New Size(112, 34)
        btnUndo.TabIndex = 12
        btnUndo.Text = "Undo"
        btnUndo.UseVisualStyleBackColor = True
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1064, 747)
        Controls.Add(btnUndo)
        Controls.Add(btnRename)
        Controls.Add(btnPreview)
        Controls.Add(TabControl1)
        Controls.Add(lvPreview)
        Controls.Add(lvOri)
        Controls.Add(lblPreview)
        Controls.Add(lblOri)
        Controls.Add(txtExt)
        Controls.Add(lblExt)
        Controls.Add(btnPath)
        Controls.Add(txtPath)
        Controls.Add(lblPath)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mass Renamer"
        TabControl1.ResumeLayout(False)
        TpFilename.ResumeLayout(False)
        TpFilename.PerformLayout()
        TpExtension.ResumeLayout(False)
        TpExtension.PerformLayout()
        TpAutoNumber.ResumeLayout(False)
        gbWith.ResumeLayout(False)
        gbWith.PerformLayout()
        CType(nudIncrementBy, ComponentModel.ISupportInitialize).EndInit()
        CType(nudStartWithNumber, ComponentModel.ISupportInitialize).EndInit()
        gbPlace.ResumeLayout(False)
        gbPlace.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents lblPath As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnPath As Button
    Friend WithEvents lblExt As Label
    Friend WithEvents txtExt As TextBox
    Friend WithEvents lblOri As Label
    Friend WithEvents lblPreview As Label
    Friend WithEvents lvOri As ListView
    Friend WithEvents lvPreview As ListView
    Friend WithEvents chFileName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chAttribute As ColumnHeader
    Friend WithEvents chCreated As ColumnHeader
    Friend WithEvents chAccessed As ColumnHeader
    Friend WithEvents chModified As ColumnHeader
    Friend WithEvents chFileName2 As ColumnHeader
    Friend WithEvents chExtension2 As ColumnHeader
    Friend WithEvents chAttribute2 As ColumnHeader
    Friend WithEvents chCreated2 As ColumnHeader
    Friend WithEvents chAccessed2 As ColumnHeader
    Friend WithEvents chModified2 As ColumnHeader
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TpFilename As TabPage
    Friend WithEvents TpExtension As TabPage
    Friend WithEvents TpAutoNumber As TabPage
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnRename As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents rbLeftCropNCharF As RadioButton
    Friend WithEvents rbInsertAfterF As RadioButton
    Friend WithEvents rbInsertBeforeF As RadioButton
    Friend WithEvents rbReplaceThisF As RadioButton
    Friend WithEvents rbReplaceWithF As RadioButton
    Friend WithEvents rbRightCropNCharF As RadioButton
    Friend WithEvents txtInsertAfterF As TextBox
    Friend WithEvents txtRightCropNCharF As TextBox
    Friend WithEvents txtWithThisF As TextBox
    Friend WithEvents txtReplaceThisF As TextBox
    Friend WithEvents txtInsertBeforeF As TextBox
    Friend WithEvents txtLeftCropNCharF As TextBox
    Friend WithEvents txtReplaceWithF As TextBox
    Friend WithEvents lblWithThisF As Label
    Friend WithEvents lblCaseF As Label
    Friend WithEvents cbCaseF As ComboBox
    Friend WithEvents cbCaseE As ComboBox
    Friend WithEvents txtInsertAfterE As TextBox
    Friend WithEvents txtRightCropNCharE As TextBox
    Friend WithEvents txtWithThisE As TextBox
    Friend WithEvents txtReplaceThisE As TextBox
    Friend WithEvents txtInsertBeforeE As TextBox
    Friend WithEvents txtLeftCropNCharE As TextBox
    Friend WithEvents txtReplaceWithE As TextBox
    Friend WithEvents lblWithThisE As Label
    Friend WithEvents lblCaseE As Label
    Friend WithEvents rbRightCropNCharE As RadioButton
    Friend WithEvents rbLeftCropNCharE As RadioButton
    Friend WithEvents rbInsertAfterE As RadioButton
    Friend WithEvents rbInsertBeforeE As RadioButton
    Friend WithEvents rbReplaceThisE As RadioButton
    Friend WithEvents rbReplaceWithE As RadioButton
    Friend WithEvents gbWith As GroupBox
    Friend WithEvents lblStartWithNumber As Label
    Friend WithEvents gbPlace As GroupBox
    Friend WithEvents rbBeforeFileName As RadioButton
    Friend WithEvents rbAfterFileName As RadioButton
    Friend WithEvents lblIncrementBy As Label
    Friend WithEvents nudIncrementBy As NumericUpDown
    Friend WithEvents nudStartWithNumber As NumericUpDown
    Friend WithEvents ImageList1 As ImageList

End Class
