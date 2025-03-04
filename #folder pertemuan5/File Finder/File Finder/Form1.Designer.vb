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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        StatusStrip1 = New StatusStrip()
        ToolStripProgressBar1 = New ToolStripProgressBar()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ExportToolStripMenuItem = New ToolStripMenuItem()
        RefreshToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem1 = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        ImageList1 = New ImageList(components)
        ContextMenuStrip = New ContextMenuStrip(components)
        OpenToolStripMenuItem = New ToolStripMenuItem()
        OpenAndSelectFileInFolderToolStripMenuItem = New ToolStripMenuItem()
        CopyPathToolStripMenuItem = New ToolStripMenuItem()
        CopyFolderPathToClipboardToolStripMenuItem = New ToolStripMenuItem()
        lblFind = New Label()
        cbFind = New ComboBox()
        txtExtension = New TextBox()
        btnSearch = New Button()
        Panel1 = New Panel()
        SplitContainer1 = New SplitContainer()
        SplitContainer2 = New SplitContainer()
        tvDrive = New TreeView()
        Panel2 = New Panel()
        Label3 = New Label()
        lblInfo = New Label()
        LlvFile = New ListView()
        chFileName = New ColumnHeader()
        chExtension = New ColumnHeader()
        chFileSize = New ColumnHeader()
        chModified = New ColumnHeader()
        chAccessed = New ColumnHeader()
        chCreated = New ColumnHeader()
        chAttributes = New ColumnHeader()
        chFullPath = New ColumnHeader()
        StatusStrip1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        ContextMenuStrip.SuspendLayout()
        Panel1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripProgressBar1, ToolStripStatusLabel1})
        StatusStrip1.Location = New Point(0, 516)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(799, 32)
        StatusStrip1.TabIndex = 0
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripProgressBar1
        ' 
        ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        ToolStripProgressBar1.Size = New Size(100, 24)
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(680, 25)
        ToolStripStatusLabel1.Spring = True
        ToolStripStatusLabel1.Text = "Ready"
        ToolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(799, 33)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExportToolStripMenuItem, RefreshToolStripMenuItem, ToolStripSeparator1, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(54, 29)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' ExportToolStripMenuItem
        ' 
        ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        ExportToolStripMenuItem.Size = New Size(315, 34)
        ExportToolStripMenuItem.Text = "Export File List to Text File"
        ' 
        ' RefreshToolStripMenuItem
        ' 
        RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        RefreshToolStripMenuItem.Size = New Size(315, 34)
        RefreshToolStripMenuItem.Text = "Refresh Folder"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(312, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(315, 34)
        ExitToolStripMenuItem.Text = "E&xit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HelpToolStripMenuItem1, AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(65, 29)
        HelpToolStripMenuItem.Text = "&Help"
        ' 
        ' HelpToolStripMenuItem1
        ' 
        HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        HelpToolStripMenuItem1.Size = New Size(164, 34)
        HelpToolStripMenuItem1.Text = "Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(164, 34)
        AboutToolStripMenuItem.Text = "A&bout"
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "drive.bmp")
        ImageList1.Images.SetKeyName(1, "folder.bmp")
        ImageList1.Images.SetKeyName(2, "file.bmp")
        ImageList1.Images.SetKeyName(3, "exe.bmp")
        ImageList1.Images.SetKeyName(4, "image.ico")
        ' 
        ' ContextMenuStrip
        ' 
        ContextMenuStrip.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip.Items.AddRange(New ToolStripItem() {OpenToolStripMenuItem, OpenAndSelectFileInFolderToolStripMenuItem, CopyPathToolStripMenuItem, CopyFolderPathToClipboardToolStripMenuItem})
        ContextMenuStrip.Name = "ContextMenuStrip1"
        ContextMenuStrip.Size = New Size(337, 132)
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(336, 32)
        OpenToolStripMenuItem.Text = "Open/Execute File "
        ' 
        ' OpenAndSelectFileInFolderToolStripMenuItem
        ' 
        OpenAndSelectFileInFolderToolStripMenuItem.Name = "OpenAndSelectFileInFolderToolStripMenuItem"
        OpenAndSelectFileInFolderToolStripMenuItem.Size = New Size(336, 32)
        OpenAndSelectFileInFolderToolStripMenuItem.Text = "Open and Select File in Folder"
        ' 
        ' CopyPathToolStripMenuItem
        ' 
        CopyPathToolStripMenuItem.Name = "CopyPathToolStripMenuItem"
        CopyPathToolStripMenuItem.Size = New Size(336, 32)
        CopyPathToolStripMenuItem.Text = "Copy Full Path to Clipboard"
        ' 
        ' CopyFolderPathToClipboardToolStripMenuItem
        ' 
        CopyFolderPathToClipboardToolStripMenuItem.Name = "CopyFolderPathToClipboardToolStripMenuItem"
        CopyFolderPathToClipboardToolStripMenuItem.Size = New Size(336, 32)
        CopyFolderPathToClipboardToolStripMenuItem.Text = "Coppy Folder Path to Clipboard"
        ' 
        ' lblFind
        ' 
        lblFind.AutoSize = True
        lblFind.Location = New Point(6, 17)
        lblFind.Name = "lblFind"
        lblFind.Size = New Size(50, 25)
        lblFind.TabIndex = 3
        lblFind.Text = "Find:"
        ' 
        ' cbFind
        ' 
        cbFind.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbFind.AutoCompleteSource = AutoCompleteSource.FileSystem
        cbFind.FormattingEnabled = True
        cbFind.Location = New Point(53, 14)
        cbFind.Name = "cbFind"
        cbFind.Size = New Size(461, 33)
        cbFind.TabIndex = 4
        ' 
        ' txtExtension
        ' 
        txtExtension.Location = New Point(538, 14)
        txtExtension.Name = "txtExtension"
        txtExtension.Size = New Size(99, 31)
        txtExtension.TabIndex = 5
        txtExtension.Text = "*.*"
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(660, 5)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(98, 49)
        btnSearch.TabIndex = 6
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblFind)
        Panel1.Controls.Add(cbFind)
        Panel1.Controls.Add(btnSearch)
        Panel1.Controls.Add(txtExtension)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 33)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(799, 54)
        Panel1.TabIndex = 7
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 87)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(SplitContainer2)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(LlvFile)
        SplitContainer1.Size = New Size(799, 429)
        SplitContainer1.SplitterDistance = 265
        SplitContainer1.TabIndex = 8
        ' 
        ' SplitContainer2
        ' 
        SplitContainer2.Dock = DockStyle.Fill
        SplitContainer2.Location = New Point(0, 0)
        SplitContainer2.Name = "SplitContainer2"
        SplitContainer2.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer2.Panel1
        ' 
        SplitContainer2.Panel1.Controls.Add(tvDrive)
        ' 
        ' SplitContainer2.Panel2
        ' 
        SplitContainer2.Panel2.Controls.Add(Panel2)
        SplitContainer2.Size = New Size(265, 429)
        SplitContainer2.SplitterDistance = 263
        SplitContainer2.TabIndex = 1
        ' 
        ' tvDrive
        ' 
        tvDrive.Dock = DockStyle.Fill
        tvDrive.ImageIndex = 0
        tvDrive.ImageList = ImageList1
        tvDrive.Location = New Point(0, 0)
        tvDrive.Name = "tvDrive"
        tvDrive.SelectedImageIndex = 0
        tvDrive.Size = New Size(265, 263)
        tvDrive.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(lblInfo)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(265, 162)
        Panel2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(30, 68)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 25)
        Label3.TabIndex = 1
        ' 
        ' lblInfo
        ' 
        lblInfo.AutoSize = True
        lblInfo.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInfo.Location = New Point(19, 24)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(196, 25)
        lblInfo.TabIndex = 0
        lblInfo.Text = "Free Fixed Disk info:"
        ' 
        ' LlvFile
        ' 
        LlvFile.Columns.AddRange(New ColumnHeader() {chFileName, chExtension, chFileSize, chModified, chAccessed, chCreated, chAttributes, chFullPath})
        LlvFile.ContextMenuStrip = ContextMenuStrip
        LlvFile.Dock = DockStyle.Fill
        LlvFile.GridLines = True
        LlvFile.Location = New Point(0, 0)
        LlvFile.Name = "LlvFile"
        LlvFile.Size = New Size(530, 429)
        LlvFile.SmallImageList = ImageList1
        LlvFile.TabIndex = 0
        LlvFile.UseCompatibleStateImageBehavior = False
        LlvFile.View = View.Details
        ' 
        ' chFileName
        ' 
        chFileName.Text = "Name"
        ' 
        ' chExtension
        ' 
        chExtension.Text = "Extension"
        ' 
        ' chFileSize
        ' 
        chFileSize.Text = "File Size"
        ' 
        ' chModified
        ' 
        chModified.Text = "Last Modified"
        ' 
        ' chAccessed
        ' 
        chAccessed.Text = "Last Accessed"
        ' 
        ' chCreated
        ' 
        chCreated.Text = "Created Date"
        ' 
        ' chAttributes
        ' 
        chAttributes.Text = "Attributes"
        ' 
        ' chFullPath
        ' 
        chFullPath.Text = "Full Path"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(799, 548)
        Controls.Add(SplitContainer1)
        Controls.Add(Panel1)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FileFinder"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ContextMenuStrip.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel2.ResumeLayout(False)
        CType(SplitContainer2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenAndSelectFileInFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyPathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyFolderPathToClipboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblFind As Label
    Friend WithEvents cbFind As ComboBox
    Friend WithEvents txtExtension As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblInfo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LlvFile As ListView
    Friend WithEvents chFileName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chFileSize As ColumnHeader
    Friend WithEvents chModified As ColumnHeader
    Friend WithEvents chAccessed As ColumnHeader
    Friend WithEvents chCreated As ColumnHeader
    Friend WithEvents chAttributes As ColumnHeader
    Friend WithEvents chFullPath As ColumnHeader
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents tvDrive As TreeView

End Class
