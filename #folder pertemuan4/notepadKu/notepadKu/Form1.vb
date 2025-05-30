﻿Public Class Form1
    Dim namafile As String
    Dim ygdicari As String
    Dim posisihasilcari As Integer
    Dim StringToPrint As String

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim dr As DialogResult
        If txtNotepad.Modified Then
            dr = MessageBox.Show("Do you want to save the changes?", "NotepadKu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If (dr = DialogResult.No) Or (dr = DialogResult.Cancel) Then
                'do nothing
            ElseIf dr = DialogResult.Yes Then
                saveToolStripMenuItem_Click(sender, e)
            End If
        End If
        Me.Text = "NotepadKu"
        namafile = String.Empty
        txtNotepad.Clear()
        txtNotepad.SelectionStart = 0
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim dr As DialogResult
        If txtNotepad.Modified Then
            dr = MessageBox.Show("Do you want to save the changes?", "NotepadKu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If dr = DialogResult.No Then 'langsung buka file baru
                dr = OpenFileDialog1.ShowDialog()
                If dr = DialogResult.OK Then
                    txtNotepad.Text = System.IO.File.ReadAllText(OpenFileDialog1.FileName)
                    namafile = OpenFileDialog1.FileName
                End If
            ElseIf dr = DialogResult.Cancel Then
                'do nothing
            ElseIf dr = DialogResult.Yes Then 'save
                saveToolStripMenuItem_Click(sender, e)
            End If
        Else
            dr = openFileDialog1.ShowDialog() 'langsung buka file baru
            If dr = DialogResult.OK Then
                txtNotepad.Text = System.IO.File.ReadAllText(openFileDialog1.FileName)
                namafile = openFileDialog1.FileName
            End If
        End If
        Me.Text = "NotepadKu - (" & namafile & ")"
        txtNotepad.SelectionStart = 0
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim dr As DialogResult
        If namafile = String.Empty Then
            dr = SaveFileDialog1.ShowDialog()
            If dr = DialogResult.OK Then
                System.IO.File.WriteAllText(SaveFileDialog1.FileName, txtNotepad.Text)
                namafile = SaveFileDialog1.FileName
            End If
        Else
            System.IO.File.WriteAllText(namafile, txtNotepad.Text)
        End If
        Me.Text = "NotepadKu - (" & namafile & ")"
        txtNotepad.SelectionStart = 0
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim dr As DialogResult
        dr = SaveFileDialog1.ShowDialog()
        If dr = DialogResult.OK Then
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, txtNotepad.Text)
            namafile = SaveFileDialog1.FileName
        End If
        Me.Text = "NotepadKu - (" & namafile & ")"
        txtNotepad.SelectionStart = 0
    End Sub

    Private Sub pageSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles pageSetupToolStripMenu.Click
        Dim dr As DialogResult
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.Document.DefaultPageSettings.Color = False
        dr = PageSetupDialog1.ShowDialog
        If dr = DialogResult.OK Then
            PrintDocument1.DefaultPageSettings = PageSetupDialog1.PageSettings
        End If
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Dim dr As DialogResult
        StringToPrint = txtNotepad.Text
        PrintDocument1.DocumentName = "NotepadKu"
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.Document = PrintDocument1
        dr = PrintDialog1.ShowDialog()
        If dr = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub CloseToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem7.Click
        NewToolStripMenuItem_Click(sender, e)
        txtNotepad.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim dr As DialogResult
        If txtNotepad.Modified Then
            dr = MessageBox.Show("Do you want to save the changes?", "NotepadKu", MessageBoxButtons.YesNoCancel)
            If dr = DialogResult.Yes Then
                SaveToolStripMenuItem_Click(sender, e)
                Application.Exit()
            ElseIf dr = DialogResult.Cancel Then
                'do nothing
            ElseIf dr = DialogResult.No Then
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        If txtNotepad.CanUndo Then
            txtNotepad.Undo()
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        Clipboard.Clear()
        If txtNotepad.SelectionLength > 0 Then
            txtNotepad.Cut()
        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Clipboard.Clear()
        If txtNotepad.SelectionLength > 0 Then
            txtNotepad.Copy()
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        If Clipboard.ContainsText() Then
            txtNotepad.Paste()
        End If
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        ygdicari = InputBox("Enter text to be found: ", "Find", "", 100, 100)
        posisihasilcari = InStr(1, txtNotepad.Text, ygdicari, CompareMethod.Text)
        If posisihasilcari > 0 Then
            txtNotepad.Focus()
            txtNotepad.SelectionStart = posisihasilcari - 1
            txtNotepad.SelectionLength = ygdicari.Length
        Else
            MessageBox.Show("Text is not found.")
        End If
    End Sub

    Private Sub findNextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles findNextToolStripMenuItem.Click
        posisihasilcari = InStr(posisihasilcari + 1, txtNotepad.Text, ygdicari, CompareMethod.Text)
        If posisihasilcari > 0 Then
            txtNotepad.Focus()
            txtNotepad.SelectionStart = posisihasilcari - 1
            txtNotepad.SelectionLength = ygdicari.Length
        Else
            MessageBox.Show("Text is not found.")
        End If
    End Sub

    Private Sub replaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles replaceToolStripMenuItem.Click
        ygdicari = InputBox("Enter text to be replaced: ", "Find", "", 100, 100)
        Dim digantijadi As String = InputBox("Replace with: ", "Replace", "", 100, 100)
        posisihasilcari = InStr(1, txtNotepad.Text, ygdicari, CompareMethod.Text)
        If posisihasilcari > 0 Then
            txtNotepad.Focus()
            txtNotepad.SelectionStart = posisihasilcari - 1
            txtNotepad.SelectionLength = ygdicari.Length
            txtNotepad.SelectedText = ""
            txtNotepad.SelectedText = digantijadi
        Else
            MessageBox.Show("Text is not found.")
        End If
    End Sub

    Private Declare Function SendMessage _
        Lib "user32.dll" Alias "SendMessageA" (
            ByVal hWnd As Long,
            ByVal wMsg As Long,
            ByVal wParam As Long,
            ByRef lParam As Long
        ) As Long
    Private Const EM_LINEINDEX As Long = &HBB

    Public Sub GotoLine(txtBox As TextBox, ByVal nLineNumber As Long)
        If nLineNumber > 0 Then
            txtBox.SelectionStart = SendMessage(txtBox.Handle, EM_LINEINDEX, nLineNumber - 1, 0)
        End If
    End Sub

    Private Sub goToToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles goToToolStripMenuItem.Click
        Dim baris As String = InputBox("Go to line: ", "Go to Line", "", 100, 100)
        GotoLine(txtNotepad, CInt(baris))
    End Sub

    Private Sub selectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles selectAllToolStripMenuItem.Click
        txtNotepad.SelectAll()
    End Sub

    Private Sub insertDateTimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles insertDateTimeToolStripMenuItem.Click
        txtNotepad.SelectedText = Convert.ToString(Now())
    End Sub

    Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click
        txtNotepad.WordWrap = Not txtNotepad.WordWrap
        WordWrapToolStripMenuItem.Checked = Not WordWrapToolStripMenuItem.Checked
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Dim dr As DialogResult
        dr = FontDialog1.ShowDialog()
        If dr = DialogResult.OK Then
            txtNotepad.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        StatusStrip1.Visible = Not StatusStrip1.Visible
        StatusBarToolStripMenuItem.Checked = Not StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub aboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles aboutToolStripMenuItem1.Click
        MessageBox.Show("NotepadKu dibuat oleh Antonius RC (C) 2014")
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.CapsLock Then
            capsStripStatus.Enabled = Not capsStripStatus.Enabled
        End If
        If e.KeyCode = Keys.NumLock Then
            numStripStatus.Enabled = Not numStripStatus.Enabled
        End If
        If (e.KeyCode = Keys.Insert) AndAlso (insertStripStatus.Text = "INS") Then
            insertStripStatus.Text = "OVR"
        Else
            insertStripStatus.Text = "INS"
        End If
    End Sub

    Private Sub txtNotepad_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNotepad.KeyUp
        Dim line As Integer = txtNotepad.GetLineFromCharIndex(txtNotepad.SelectionStart) + 1
        ToolStripStatusLine.Text = "Line: " & line
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim numChars As Integer 'untuk jumlah karakter
        Dim numLines As Integer 'untuk jumlah baris
        Dim stringForPage As String
        Dim strFormat As New StringFormat()
        Dim PrintFont As Font
        PrintFont = txtNotepad.Font
        Dim rectDraw As New RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height)
        Dim sizeMeasure As New SizeF(e.MarginBounds.Width, e.MarginBounds.Height - PrintFont.GetHeight(e.Graphics))
        strFormat.Trimming = StringTrimming.Word
        e.Graphics.MeasureString(StringToPrint, PrintFont, sizeMeasure, strFormat, numChars, numLines)
        stringForPage = StringToPrint.Substring(0, numChars)
        e.Graphics.DrawString(stringForPage, PrintFont, Brushes.Black, rectDraw, strFormat)
        If numChars < StringToPrint.Length Then
            StringToPrint = StringToPrint.Substring(numChars)
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNotepad.WordWrap = False
        txtNotepad.Font = New Font("Lucida Console", 10, FontStyle.Regular)
        txtNotepad.WordWrap = False
    End Sub

End Class
