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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.GradientActiveCaption
        Label2.Location = New Point(145, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 25)
        Label2.TabIndex = 1
        Label2.Text = "Usename :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.GradientActiveCaption
        Label3.Location = New Point(145, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 25)
        Label3.TabIndex = 2
        Label3.Text = "Passoword :"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.GradientActiveCaption
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(286, 142)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(201, 31)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.GradientActiveCaption
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(286, 195)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(201, 31)
        TextBox2.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.WhiteSmoke
        Button1.Location = New Point(170, 298)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 39)
        Button1.TabIndex = 5
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.WhiteSmoke
        Button2.Location = New Point(344, 298)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 39)
        Button2.TabIndex = 6
        Button2.Text = "Keluar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(629, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
