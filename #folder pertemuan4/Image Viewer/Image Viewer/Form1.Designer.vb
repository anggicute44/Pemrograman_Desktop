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
        ImageList1 = New ImageList(components)
        statusStrip1 = New StatusStrip()
        ToolStripStatusReady = New ToolStripStatusLabel()
        ToolStripStatusDimension = New ToolStripStatusLabel()
        ToolStripStatusBits = New ToolStripStatusLabel()
        ToolStripStatusResolution = New ToolStripStatusLabel()
        ToolStripStatusRawFormat = New ToolStripStatusLabel()
        ToolTip1 = New ToolTip(components)
        tvDrive = New TreeView()
        LlvImage = New ListView()
        chName = New ColumnHeader()
        chExtension = New ColumnHeader()
        chFileSize = New ColumnHeader()
        chLastModified = New ColumnHeader()
        chLastAccessed = New ColumnHeader()
        chCreatedDate = New ColumnHeader()
        chAttributes = New ColumnHeader()
        PictureBox1 = New PictureBox()
        SplitContainerUtama = New SplitContainer()
        SplitContainerBawah = New SplitContainer()
        SplitContainerBawah2 = New SplitContainer()
        TabControl = New TabControl()
        TabControl1 = New TabPage()
        PropertyGrid1 = New PropertyGrid()
        TabControl2 = New TabPage()
        LlvExif = New ListView()
        BindingSource1 = New BindingSource(components)
        statusStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainerUtama, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainerUtama.Panel1.SuspendLayout()
        SplitContainerUtama.Panel2.SuspendLayout()
        SplitContainerUtama.SuspendLayout()
        CType(SplitContainerBawah, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainerBawah.Panel1.SuspendLayout()
        SplitContainerBawah.Panel2.SuspendLayout()
        SplitContainerBawah.SuspendLayout()
        CType(SplitContainerBawah2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainerBawah2.Panel1.SuspendLayout()
        SplitContainerBawah2.Panel2.SuspendLayout()
        SplitContainerBawah2.SuspendLayout()
        TabControl.SuspendLayout()
        TabControl1.SuspendLayout()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' statusStrip1
        ' 
        statusStrip1.ImageScalingSize = New Size(24, 24)
        statusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusReady, ToolStripStatusDimension, ToolStripStatusBits, ToolStripStatusResolution, ToolStripStatusRawFormat})
        statusStrip1.Location = New Point(0, 414)
        statusStrip1.Name = "statusStrip1"
        statusStrip1.Size = New Size(800, 36)
        statusStrip1.TabIndex = 0
        statusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusReady
        ' 
        ToolStripStatusReady.Name = "ToolStripStatusReady"
        ToolStripStatusReady.Size = New Size(60, 29)
        ToolStripStatusReady.Text = "Ready"
        ' 
        ' ToolStripStatusDimension
        ' 
        ToolStripStatusDimension.BorderSides = ToolStripStatusLabelBorderSides.Left
        ToolStripStatusDimension.BorderStyle = Border3DStyle.Etched
        ToolStripStatusDimension.Name = "ToolStripStatusDimension"
        ToolStripStatusDimension.Size = New Size(109, 29)
        ToolStripStatusDimension.Text = "Dimensions"
        ' 
        ' ToolStripStatusBits
        ' 
        ToolStripStatusBits.BorderSides = ToolStripStatusLabelBorderSides.Left
        ToolStripStatusBits.BorderStyle = Border3DStyle.Etched
        ToolStripStatusBits.Name = "ToolStripStatusBits"
        ToolStripStatusBits.Size = New Size(83, 29)
        ToolStripStatusBits.Text = "# of bits"
        ' 
        ' ToolStripStatusResolution
        ' 
        ToolStripStatusResolution.BorderSides = ToolStripStatusLabelBorderSides.Left
        ToolStripStatusResolution.BorderStyle = Border3DStyle.Etched
        ToolStripStatusResolution.Name = "ToolStripStatusResolution"
        ToolStripStatusResolution.Size = New Size(99, 29)
        ToolStripStatusResolution.Text = "Resolution"
        ' 
        ' ToolStripStatusRawFormat
        ' 
        ToolStripStatusRawFormat.BorderSides = ToolStripStatusLabelBorderSides.Left
        ToolStripStatusRawFormat.BorderStyle = Border3DStyle.Etched
        ToolStripStatusRawFormat.Name = "ToolStripStatusRawFormat"
        ToolStripStatusRawFormat.Size = New Size(111, 29)
        ToolStripStatusRawFormat.Text = "Raw Format"
        ' 
        ' ToolTip1
        ' 
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
        ' 
        ' tvDrive
        ' 
        tvDrive.Dock = DockStyle.Fill
        tvDrive.ImageIndex = 0
        tvDrive.ImageList = ImageList1
        tvDrive.Location = New Point(0, 0)
        tvDrive.Name = "tvDrive"
        tvDrive.SelectedImageIndex = 0
        tvDrive.Size = New Size(172, 414)
        tvDrive.TabIndex = 0
        ToolTip1.SetToolTip(tvDrive, "Please select drive/folder that contain" & vbCrLf & "one or more images")
        ' 
        ' LlvImage
        ' 
        LlvImage.Columns.AddRange(New ColumnHeader() {chName, chExtension, chFileSize, chLastModified, chLastAccessed, chCreatedDate, chAttributes})
        LlvImage.GridLines = True
        LlvImage.Location = New Point(-1, 3)
        LlvImage.Name = "LlvImage"
        LlvImage.Size = New Size(624, 170)
        LlvImage.SmallImageList = ImageList1
        LlvImage.TabIndex = 0
        ToolTip1.SetToolTip(LlvImage, "Image file(s)" & vbCrLf)
        LlvImage.UseCompatibleStateImageBehavior = False
        LlvImage.View = View.Details
        ' 
        ' chName
        ' 
        chName.Tag = ""
        chName.Text = "Name"
        ' 
        ' chExtension
        ' 
        chExtension.Text = "Extension"
        ' 
        ' chFileSize
        ' 
        chFileSize.Text = "File Size"
        ' 
        ' chLastModified
        ' 
        chLastModified.Text = " Modified Date"
        ' 
        ' chLastAccessed
        ' 
        chLastAccessed.Text = "Last Accessed"
        ' 
        ' chCreatedDate
        ' 
        chCreatedDate.Text = "Created Date"
        ' 
        ' chAttributes
        ' 
        chAttributes.Text = "Attributes"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(27, 19)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(302, 197)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ToolTip1.SetToolTip(PictureBox1, "Double click to view this image in auto" & vbCrLf & "size mode!")
        ' 
        ' SplitContainerUtama
        ' 
        SplitContainerUtama.Dock = DockStyle.Fill
        SplitContainerUtama.Location = New Point(0, 0)
        SplitContainerUtama.Name = "SplitContainerUtama"
        ' 
        ' SplitContainerUtama.Panel1
        ' 
        SplitContainerUtama.Panel1.Controls.Add(tvDrive)
        ' 
        ' SplitContainerUtama.Panel2
        ' 
        SplitContainerUtama.Panel2.Controls.Add(SplitContainerBawah)
        SplitContainerUtama.Size = New Size(800, 414)
        SplitContainerUtama.SplitterDistance = 172
        SplitContainerUtama.TabIndex = 1
        ' 
        ' SplitContainerBawah
        ' 
        SplitContainerBawah.Dock = DockStyle.Fill
        SplitContainerBawah.Location = New Point(0, 0)
        SplitContainerBawah.Name = "SplitContainerBawah"
        SplitContainerBawah.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainerBawah.Panel1
        ' 
        SplitContainerBawah.Panel1.Controls.Add(LlvImage)
        ' 
        ' SplitContainerBawah.Panel2
        ' 
        SplitContainerBawah.Panel2.Controls.Add(SplitContainerBawah2)
        SplitContainerBawah.Size = New Size(624, 414)
        SplitContainerBawah.SplitterDistance = 176
        SplitContainerBawah.TabIndex = 0
        ' 
        ' SplitContainerBawah2
        ' 
        SplitContainerBawah2.Dock = DockStyle.Fill
        SplitContainerBawah2.Location = New Point(0, 0)
        SplitContainerBawah2.Name = "SplitContainerBawah2"
        ' 
        ' SplitContainerBawah2.Panel1
        ' 
        SplitContainerBawah2.Panel1.Controls.Add(TabControl)
        SplitContainerBawah2.Panel1.Controls.Add(LlvExif)
        ' 
        ' SplitContainerBawah2.Panel2
        ' 
        SplitContainerBawah2.Panel2.Controls.Add(PictureBox1)
        SplitContainerBawah2.Size = New Size(624, 234)
        SplitContainerBawah2.SplitterDistance = 263
        SplitContainerBawah2.TabIndex = 0
        ' 
        ' TabControl
        ' 
        TabControl.Controls.Add(TabControl1)
        TabControl.Controls.Add(TabControl2)
        TabControl.Dock = DockStyle.Fill
        TabControl.Location = New Point(0, 0)
        TabControl.Name = "TabControl"
        TabControl.SelectedIndex = 0
        TabControl.Size = New Size(263, 234)
        TabControl.TabIndex = 0
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(PropertyGrid1)
        TabControl1.Location = New Point(4, 34)
        TabControl1.Name = "TabControl1"
        TabControl1.Padding = New Padding(3)
        TabControl1.Size = New Size(255, 196)
        TabControl1.TabIndex = 0
        TabControl1.Text = "Image Properties"
        TabControl1.UseVisualStyleBackColor = True
        ' 
        ' PropertyGrid1
        ' 
        PropertyGrid1.Dock = DockStyle.Fill
        PropertyGrid1.Location = New Point(3, 3)
        PropertyGrid1.Name = "PropertyGrid1"
        PropertyGrid1.Size = New Size(249, 190)
        PropertyGrid1.TabIndex = 1
        ' 
        ' TabControl2
        ' 
        TabControl2.Location = New Point(4, 34)
        TabControl2.Name = "TabControl2"
        TabControl2.Padding = New Padding(3)
        TabControl2.Size = New Size(255, 196)
        TabControl2.TabIndex = 1
        TabControl2.Text = "EXIF Metadata"
        TabControl2.UseVisualStyleBackColor = True
        ' 
        ' LlvExif
        ' 
        LlvExif.GridLines = True
        LlvExif.Location = New Point(-12, 3)
        LlvExif.Name = "LlvExif"
        LlvExif.Size = New Size(272, 231)
        LlvExif.TabIndex = 0
        LlvExif.UseCompatibleStateImageBehavior = False
        LlvExif.View = View.Details
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SplitContainerUtama)
        Controls.Add(statusStrip1)
        Name = "Form1"
        Text = "Form1"
        statusStrip1.ResumeLayout(False)
        statusStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainerUtama.Panel1.ResumeLayout(False)
        SplitContainerUtama.Panel2.ResumeLayout(False)
        CType(SplitContainerUtama, ComponentModel.ISupportInitialize).EndInit()
        SplitContainerUtama.ResumeLayout(False)
        SplitContainerBawah.Panel1.ResumeLayout(False)
        SplitContainerBawah.Panel2.ResumeLayout(False)
        CType(SplitContainerBawah, ComponentModel.ISupportInitialize).EndInit()
        SplitContainerBawah.ResumeLayout(False)
        SplitContainerBawah2.Panel1.ResumeLayout(False)
        SplitContainerBawah2.Panel2.ResumeLayout(False)
        CType(SplitContainerBawah2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainerBawah2.ResumeLayout(False)
        TabControl.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents statusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusDimension As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusBits As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusResolution As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusRawFormat As ToolStripStatusLabel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SplitContainerUtama As SplitContainer
    Friend WithEvents SplitContainerBawah As SplitContainer
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents SplitContainerBawah2 As SplitContainer
    Friend WithEvents tvDrive As TreeView
    Friend WithEvents LlvImage As ListView
    Friend WithEvents chName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chFileSize As ColumnHeader
    Friend WithEvents chLastModified As ColumnHeader
    Friend WithEvents chLastAccessed As ColumnHeader
    Friend WithEvents chCreatedDate As ColumnHeader
    Friend WithEvents chAttributes As ColumnHeader
    Friend WithEvents LlvExif As ListView
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabControl1 As TabPage
    Friend WithEvents TabControl2 As TabPage
    Friend WithEvents PropertyGrid1 As PropertyGrid
    Friend WithEvents PictureBox1 As PictureBox

End Class
