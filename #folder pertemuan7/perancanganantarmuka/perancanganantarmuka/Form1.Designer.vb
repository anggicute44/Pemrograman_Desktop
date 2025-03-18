<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Label1 = New Label()
        lblUsername = New Label()
        lblPassword = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(2, -2)
        Label1.Name = "Label1"
        Label1.Size = New Size(349, 65)
        Label1.TabIndex = 0
        Label1.Text = "SIParkir - Login"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.BackColor = SystemColors.GradientActiveCaption
        lblUsername.Location = New Point(145, 142)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(94, 25)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Usename :"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.BackColor = SystemColors.GradientActiveCaption
        lblPassword.Location = New Point(145, 198)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(107, 25)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Passoword :"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = SystemColors.GradientActiveCaption
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Location = New Point(286, 142)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(201, 31)
        txtUsername.TabIndex = 3
        txtUsername.Text = "username"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = SystemColors.GradientActiveCaption
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(286, 195)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(201, 31)
        txtPassword.TabIndex = 4
        txtPassword.Text = "password"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.WhiteSmoke
        btnLogin.Location = New Point(170, 298)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 39)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.WhiteSmoke
        btnExit.Location = New Point(344, 298)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(112, 39)
        btnExit.TabIndex = 6
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(629, 450)
        Controls.Add(btnExit)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button

End Class
