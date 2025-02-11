<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class calculator
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
        txtInput = New TextBox()
        Panel2 = New Panel()
        CmdEqual = New Button()
        CmdInverse = New Button()
        CmdSqrt = New Button()
        CmdPowerOf = New Button()
        CmdAddition = New Button()
        CmdSubtract = New Button()
        CmdMultiply = New Button()
        CmdDivision = New Button()
        CmdDecimal = New Button()
        CmdSign = New Button()
        Cmd0 = New Button()
        Cmd3 = New Button()
        Cmd2 = New Button()
        Cmd1 = New Button()
        Cmd6 = New Button()
        Cmd5 = New Button()
        Cmd4 = New Button()
        Cmd9 = New Button()
        Cmd8 = New Button()
        Cmd7 = New Button()
        cmdC = New Button()
        cmdCE = New Button()
        cmdBackspace = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtInput)
        Panel1.Location = New Point(174, 40)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(558, 111)
        Panel1.TabIndex = 0
        ' 
        ' txtInput
        ' 
        txtInput.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtInput.Location = New Point(170, 17)
        txtInput.Multiline = True
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(330, 69)
        txtInput.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(CmdEqual)
        Panel2.Controls.Add(CmdInverse)
        Panel2.Controls.Add(CmdSqrt)
        Panel2.Controls.Add(CmdPowerOf)
        Panel2.Controls.Add(CmdAddition)
        Panel2.Controls.Add(CmdSubtract)
        Panel2.Controls.Add(CmdMultiply)
        Panel2.Controls.Add(CmdDivision)
        Panel2.Controls.Add(CmdDecimal)
        Panel2.Controls.Add(CmdSign)
        Panel2.Controls.Add(Cmd0)
        Panel2.Controls.Add(Cmd3)
        Panel2.Controls.Add(Cmd2)
        Panel2.Controls.Add(Cmd1)
        Panel2.Controls.Add(Cmd6)
        Panel2.Controls.Add(Cmd5)
        Panel2.Controls.Add(Cmd4)
        Panel2.Controls.Add(Cmd9)
        Panel2.Controls.Add(Cmd8)
        Panel2.Controls.Add(Cmd7)
        Panel2.Controls.Add(cmdC)
        Panel2.Controls.Add(cmdCE)
        Panel2.Controls.Add(cmdBackspace)
        Panel2.Location = New Point(174, 169)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(569, 526)
        Panel2.TabIndex = 1
        ' 
        ' CmdEqual
        ' 
        CmdEqual.Location = New Point(473, 235)
        CmdEqual.Name = "CmdEqual"
        CmdEqual.Size = New Size(89, 39)
        CmdEqual.TabIndex = 22
        CmdEqual.Text = "="
        CmdEqual.UseVisualStyleBackColor = True
        ' 
        ' CmdInverse
        ' 
        CmdInverse.Location = New Point(383, 240)
        CmdInverse.Name = "CmdInverse"
        CmdInverse.Size = New Size(85, 34)
        CmdInverse.TabIndex = 21
        CmdInverse.Text = "1/x"
        CmdInverse.UseVisualStyleBackColor = True
        ' 
        ' CmdSqrt
        ' 
        CmdSqrt.Location = New Point(473, 193)
        CmdSqrt.Name = "CmdSqrt"
        CmdSqrt.Size = New Size(82, 34)
        CmdSqrt.TabIndex = 20
        CmdSqrt.Text = "SQRT"
        CmdSqrt.UseVisualStyleBackColor = True
        ' 
        ' CmdPowerOf
        ' 
        CmdPowerOf.Location = New Point(383, 193)
        CmdPowerOf.Name = "CmdPowerOf"
        CmdPowerOf.Size = New Size(85, 34)
        CmdPowerOf.TabIndex = 19
        CmdPowerOf.Text = "X^"
        CmdPowerOf.UseVisualStyleBackColor = True
        ' 
        ' CmdAddition
        ' 
        CmdAddition.Location = New Point(473, 134)
        CmdAddition.Name = "CmdAddition"
        CmdAddition.Size = New Size(85, 37)
        CmdAddition.TabIndex = 18
        CmdAddition.Text = "+"
        CmdAddition.UseVisualStyleBackColor = True
        ' 
        ' CmdSubtract
        ' 
        CmdSubtract.Location = New Point(383, 134)
        CmdSubtract.Name = "CmdSubtract"
        CmdSubtract.Size = New Size(89, 40)
        CmdSubtract.TabIndex = 17
        CmdSubtract.Text = "-"
        CmdSubtract.UseVisualStyleBackColor = True
        ' 
        ' CmdMultiply
        ' 
        CmdMultiply.Location = New Point(473, 80)
        CmdMultiply.Name = "CmdMultiply"
        CmdMultiply.Size = New Size(82, 39)
        CmdMultiply.TabIndex = 16
        CmdMultiply.Text = "*"
        CmdMultiply.UseVisualStyleBackColor = True
        ' 
        ' CmdDivision
        ' 
        CmdDivision.Location = New Point(383, 80)
        CmdDivision.Name = "CmdDivision"
        CmdDivision.Size = New Size(85, 39)
        CmdDivision.TabIndex = 15
        CmdDivision.Text = "/"
        CmdDivision.UseVisualStyleBackColor = True
        ' 
        ' CmdDecimal
        ' 
        CmdDecimal.Location = New Point(281, 240)
        CmdDecimal.Name = "CmdDecimal"
        CmdDecimal.Size = New Size(96, 34)
        CmdDecimal.TabIndex = 14
        CmdDecimal.Text = "."
        CmdDecimal.UseVisualStyleBackColor = True
        ' 
        ' CmdSign
        ' 
        CmdSign.Location = New Point(153, 240)
        CmdSign.Name = "CmdSign"
        CmdSign.Size = New Size(102, 34)
        CmdSign.TabIndex = 13
        CmdSign.Text = "+/-"
        CmdSign.UseVisualStyleBackColor = True
        ' 
        ' Cmd0
        ' 
        Cmd0.Location = New Point(29, 240)
        Cmd0.Name = "Cmd0"
        Cmd0.Size = New Size(94, 34)
        Cmd0.TabIndex = 12
        Cmd0.Text = "0"
        Cmd0.UseVisualStyleBackColor = True
        ' 
        ' Cmd3
        ' 
        Cmd3.Location = New Point(281, 193)
        Cmd3.Name = "Cmd3"
        Cmd3.Size = New Size(96, 34)
        Cmd3.TabIndex = 11
        Cmd3.Text = "3"
        Cmd3.UseVisualStyleBackColor = True
        ' 
        ' Cmd2
        ' 
        Cmd2.Location = New Point(153, 191)
        Cmd2.Name = "Cmd2"
        Cmd2.Size = New Size(102, 36)
        Cmd2.TabIndex = 10
        Cmd2.Text = "2"
        Cmd2.UseVisualStyleBackColor = True
        ' 
        ' Cmd1
        ' 
        Cmd1.Location = New Point(29, 189)
        Cmd1.Name = "Cmd1"
        Cmd1.Size = New Size(94, 38)
        Cmd1.TabIndex = 9
        Cmd1.Text = "1"
        Cmd1.UseVisualStyleBackColor = True
        ' 
        ' Cmd6
        ' 
        Cmd6.Location = New Point(281, 137)
        Cmd6.Name = "Cmd6"
        Cmd6.Size = New Size(96, 32)
        Cmd6.TabIndex = 8
        Cmd6.Text = "6"
        Cmd6.UseVisualStyleBackColor = True
        ' 
        ' Cmd5
        ' 
        Cmd5.Location = New Point(153, 137)
        Cmd5.Name = "Cmd5"
        Cmd5.Size = New Size(102, 34)
        Cmd5.TabIndex = 7
        Cmd5.Text = "5"
        Cmd5.UseVisualStyleBackColor = True
        ' 
        ' Cmd4
        ' 
        Cmd4.Location = New Point(29, 137)
        Cmd4.Name = "Cmd4"
        Cmd4.Size = New Size(94, 32)
        Cmd4.TabIndex = 6
        Cmd4.Text = "4"
        Cmd4.UseVisualStyleBackColor = True
        ' 
        ' Cmd9
        ' 
        Cmd9.Location = New Point(281, 82)
        Cmd9.Name = "Cmd9"
        Cmd9.Size = New Size(96, 34)
        Cmd9.TabIndex = 5
        Cmd9.Text = "9"
        Cmd9.UseVisualStyleBackColor = True
        ' 
        ' Cmd8
        ' 
        Cmd8.Location = New Point(153, 82)
        Cmd8.Name = "Cmd8"
        Cmd8.Size = New Size(102, 34)
        Cmd8.TabIndex = 4
        Cmd8.Text = "8"
        Cmd8.UseVisualStyleBackColor = True
        ' 
        ' Cmd7
        ' 
        Cmd7.Location = New Point(29, 80)
        Cmd7.Name = "Cmd7"
        Cmd7.Size = New Size(94, 36)
        Cmd7.TabIndex = 3
        Cmd7.Text = "7"
        Cmd7.UseVisualStyleBackColor = True
        ' 
        ' cmdC
        ' 
        cmdC.Location = New Point(473, 26)
        cmdC.Name = "cmdC"
        cmdC.Size = New Size(62, 40)
        cmdC.TabIndex = 2
        cmdC.Text = "C"
        cmdC.UseVisualStyleBackColor = True
        ' 
        ' cmdCE
        ' 
        cmdCE.Location = New Point(398, 26)
        cmdCE.Name = "cmdCE"
        cmdCE.Size = New Size(55, 45)
        cmdCE.TabIndex = 1
        cmdCE.Text = "CE"
        cmdCE.UseVisualStyleBackColor = True
        ' 
        ' cmdBackspace
        ' 
        cmdBackspace.Location = New Point(29, 26)
        cmdBackspace.Name = "cmdBackspace"
        cmdBackspace.Size = New Size(112, 34)
        cmdBackspace.TabIndex = 0
        cmdBackspace.Text = "Backspace"
        cmdBackspace.UseVisualStyleBackColor = True
        ' 
        ' calculator
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 690)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "calculator"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtInput As TextBox
    Friend WithEvents CmdPowerOf As Button
    Friend WithEvents CmdAddition As Button
    Friend WithEvents CmdSubtract As Button
    Friend WithEvents CmdMultiply As Button
    Friend WithEvents CmdDivision As Button
    Friend WithEvents CmdDecimal As Button
    Friend WithEvents CmdSign As Button
    Friend WithEvents Cmd0 As Button
    Friend WithEvents Cmd3 As Button
    Friend WithEvents Cmd2 As Button
    Friend WithEvents Cmd1 As Button
    Friend WithEvents Cmd6 As Button
    Friend WithEvents Cmd5 As Button
    Friend WithEvents Cmd4 As Button
    Friend WithEvents Cmd9 As Button
    Friend WithEvents Cmd8 As Button
    Friend WithEvents Cmd7 As Button
    Friend WithEvents cmdC As Button
    Friend WithEvents cmdCE As Button
    Friend WithEvents cmdBackspace As Button
    Friend WithEvents CmdEqual As Button
    Friend WithEvents CmdInverse As Button
    Friend WithEvents CmdSqrt As Button

End Class
