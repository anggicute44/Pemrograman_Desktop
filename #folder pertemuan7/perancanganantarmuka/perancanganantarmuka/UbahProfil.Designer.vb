<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfil
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
        btnClose = New Button()
        btnSave = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        lblPassword = New Label()
        lblUsername = New Label()
        Label1 = New Label()
        lblRetype = New Label()
        txtRetype = New TextBox()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.WhiteSmoke
        btnClose.Location = New Point(343, 330)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(112, 39)
        btnClose.TabIndex = 13
        btnClose.Text = "Tutup"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.WhiteSmoke
        btnSave.Location = New Point(207, 330)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 39)
        btnSave.TabIndex = 12
        btnSave.Text = "Simpan"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = SystemColors.GradientActiveCaption
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Location = New Point(326, 185)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(201, 31)
        txtPassword.TabIndex = 11
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = SystemColors.GradientActiveCaption
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Location = New Point(326, 124)
        txtUsername.Name = "txtUsername"
        txtUsername.ReadOnly = True
        txtUsername.Size = New Size(201, 31)
        txtUsername.TabIndex = 10
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.BackColor = SystemColors.GradientActiveCaption
        lblPassword.Location = New Point(165, 185)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(142, 25)
        lblPassword.TabIndex = 9
        lblPassword.Text = "Passoword Baru:"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.BackColor = SystemColors.GradientActiveCaption
        lblUsername.Location = New Point(165, 124)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(94, 25)
        lblUsername.TabIndex = 8
        lblUsername.Text = "Usename :"
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
        ' lblRetype
        ' 
        lblRetype.AutoSize = True
        lblRetype.BackColor = SystemColors.GradientActiveCaption
        lblRetype.Location = New Point(165, 243)
        lblRetype.Name = "lblRetype"
        lblRetype.Size = New Size(109, 25)
        lblRetype.TabIndex = 14
        lblRetype.Text = "Retype Pass:"
        ' 
        ' txtRetype
        ' 
        txtRetype.BackColor = SystemColors.GradientActiveCaption
        txtRetype.BorderStyle = BorderStyle.FixedSingle
        txtRetype.Location = New Point(326, 241)
        txtRetype.Name = "txtRetype"
        txtRetype.Size = New Size(201, 31)
        txtRetype.TabIndex = 15
        ' 
        ' frmProfil
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(txtRetype)
        Controls.Add(lblRetype)
        Controls.Add(btnClose)
        Controls.Add(btnSave)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "frmProfil"
        StartPosition = FormStartPosition.CenterParent
        Text = "Form Profil"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblRetype As Label
    Friend WithEvents txtRetype As TextBox
End Class
