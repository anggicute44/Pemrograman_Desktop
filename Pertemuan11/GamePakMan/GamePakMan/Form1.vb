Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1
    'map (peta papan permainan)
    Dim map = {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                {0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0},
                {0, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0},
                {1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0},
                {0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 0},
                {0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 1, 0, 1, 0, 1, 0, 0, 1, 1, 0},
                {0, 1, 0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                {0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0},
                {0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0},
                {0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0},
                {0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0},
                {0, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}}

    'kumpulan variabel
    Dim tsz = 40 'tile size (ukuran grid/tilenya)
    Dim pacx = 1 'pakman itu di petak x mana sekarang
    Dim pacy = 1 'pakman itu di petak y mana sekarang

    Dim enmx = 9 'musuh 1 di petak x berapa
    Dim enmy = 7 'musuh 1 di petak y berapa
    Dim enmx1 = 17 'musuh 2 di petak x berapa
    Dim enmy1 = 13 'musuh 2 di petak y berapa
    Dim enmx2 = 12 'musuh 3 di petak x berapa
    Dim enmy2 = 3 'musuh 3 di petak y berapa

    Dim goalx = 1 'goal (pintu keluar pakman di petak x brp
    Dim goaly = 7 'goal di petak y berapa
    Dim bmp As Bitmap
    Dim oldpacx = 0
    Dim oldpacy = 0

    'deklarasi sprite citra yang digunakan
    Dim wall As Image = My.Resources.bata
    Dim way As Image = My.Resources.rumput

    Dim arahPakman As String
    Dim pac As Image = My.Resources.pakman
    Dim pacbawah As Image = My.Resources.pakman2
    Dim packiri As Image = My.Resources.pakman3
    Dim pacatas As Image = My.Resources.pakman4

    Dim enm As Image = My.Resources.hantu1
    Dim enm1 As Image = My.Resources.hantu2
    Dim enm2 As Image = My.Resources.hantu3

    Dim nyawa = 3
    Dim hati As Image = My.Resources.nyawa

    Dim goal As Image = My.Resources.omah

    Private Sub resetDefault()
        tsz = 40 'tile size (ukuran grid/tilenya)

        pacx = 1 'pakman itu di petak x mana sekarang
        pacy = 1 'pakman itu di petak y mana sekarang

        enmx = 9 'musuh itu di petak x berapa
        enmy = 7 'musuh itu di petak y berapa

        enmx1 = 17 'musuh 2 di petak x berapa
        enmy1 = 13 'musuh 2 di petak y berapa

        enmx2 = 9 'musuh 3 di petak x berapa
        enmy2 = 11 'musuh 3 di petak y berapa

        goalx = 1 'goal (pintu keluar pakman di petak x brp
        goaly = 7 'goal di petak y berapa

        oldpacx = 0
        oldpacy = 0
        Redraw()
        Timer1.Enabled = True
    End Sub

    Private Sub Redraw()
        Dim g As Graphics = Graphics.FromImage(PictureBox1.Image)

        'gambarkan background (jalan dan tembok)
        For y = 0 To (map.GetUpperBound(0)) '0 to tinggi map
            For x = 0 To map.GetUpperBound(1) '0 to lebar map
                If map(y, x) = 0 Then
                    g.DrawImage(wall, x * tsz, y * tsz, tsz, tsz)
                Else
                    g.DrawImage(way, x * tsz, y * tsz, tsz, tsz)
                End If
            Next
        Next

        'gambarkan nyawa
        For i As Integer = 0 To nyawa - 1
            g.DrawImage(hati, i * tsz, PictureBox1.Height - tsz, tsz, tsz)
        Next

        'gambarkan pacman
        g.DrawImage(pac, pacx * tsz, pacy * tsz, tsz, tsz)
        Select Case arahPakman
            Case "atas"
                g.DrawImage(pacatas, pacx * tsz, pacy * tsz, tsz, tsz)
            Case "bawah"
                g.DrawImage(pacbawah, pacx * tsz, pacy * tsz, tsz, tsz)
            Case "kiri"
                g.DrawImage(packiri, pacx * tsz, pacy * tsz, tsz, tsz)
            Case "kanan"
                g.DrawImage(pac, pacx * tsz, pacy * tsz, tsz, tsz)
        End Select

        'gambarkan musuh
        g.DrawImage(enm, enmx * tsz, enmy * tsz, tsz, tsz)
        g.DrawImage(enm1, enmx1 * tsz, enmy1 * tsz, tsz, tsz)
        g.DrawImage(enm2, enmx2 * tsz, enmy2 * tsz, tsz, tsz)

        'gambarkan goal
        g.DrawImage(goal, goalx * tsz, (map.GetUpperBound(0) - 1) * tsz, tsz, tsz)

        PictureBox1.Refresh()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                If map(pacy - 1, pacx) = 1 Then
                    pacy = pacy - 1
                End If
                arahPakman = "atas"
            Case Keys.Down
                If map(pacy + 1, pacx) = 1 Then
                    pacy = pacy + 1
                End If
                arahPakman = "bawah"
            Case Keys.Right
                If map(pacy, pacx + 1) = 1 Then
                    pacx = pacx + 1
                End If
                arahPakman = "kanan"
            Case Keys.Left
                If map(pacy, pacx - 1) = 1 Then
                    pacx = pacx - 1
                End If
                arahPakman = "kiri"
        End Select
        Redraw()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sesuaikan dulu ukuran picturebox dan form
        PictureBox1.Width = map.GetLength(1) * tsz
        PictureBox1.Height = map.GetLength(0) * tsz
        Me.Width = PictureBox1.Width + tsz
        Me.Height = PictureBox1.Height + tsz + tsz
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Image = bmp
        Redraw()
    End Sub

    Private Sub KejarPakman(hantu As Integer)
        Dim hx As Integer
        Dim hy As Integer

        ' Menentukan posisi hantu berdasarkan nomor hantu
        Select Case hantu
            Case 1
                hx = enmx
                hy = enmy
            Case 2
                hx = enmx1
                hy = enmy1
            Case 3
                hx = enmx2
                hy = enmy2
        End Select

        ' Hitung jarak di sumbu x dan y
        Dim jarakx As Integer = pacx - hx
        Dim jaraky As Integer = pacy - hy

        ' Tentukan arah gerakan hantu berdasarkan jarak di sumbu x dan y
        Dim arah As Integer
        If Math.Abs(jarakx) > Math.Abs(jaraky) Then
            If jarakx > 0 Then
                arah = 1 ' Kanan
            Else
                arah = 3 ' Kiri
            End If
        Else
            If jaraky > 0 Then
                arah = 2 ' Bawah
            Else
                arah = 0 ' Atas
            End If
        End If

        ' Cek arah dan update posisi hantu jika memungkinkan
        Dim moved As Boolean = False
        Select Case arah
            Case 0
                If hy > 0 AndAlso map(hy - 1, hx) = 1 AndAlso Not PosisiHantu(hx, hy - 1, hantu) Then
                    hy -= 1
                    moved = True
                End If
            Case 1
                If hx < map.GetUpperBound(1) AndAlso map(hy, hx + 1) = 1 AndAlso Not PosisiHantu(hx + 1, hy, hantu) Then
                    hx += 1
                    moved = True
                End If
            Case 2
                If hy < map.GetUpperBound(0) AndAlso map(hy + 1, hx) = 1 AndAlso Not PosisiHantu(hx, hy + 1, hantu) Then
                    hy += 1
                    moved = True
                End If
            Case 3
                If hx > 0 AndAlso map(hy, hx - 1) = 1 AndAlso Not PosisiHantu(hx - 1, hy, hantu) Then
                    hx -= 1
                    moved = True
                End If
        End Select

        ' Jika hantu tidak bergerak, pilih arah lain yang memungkinkan
        If Not moved Then
            For i As Integer = 0 To 3
                Select Case i
                    Case 0
                        If hy > 0 AndAlso map(hy - 1, hx) = 1 AndAlso Not PosisiHantu(hx, hy - 1, hantu) Then
                            hy -= 1
                            Exit For
                        End If
                    Case 1
                        If hx < map.GetUpperBound(1) AndAlso map(hy, hx + 1) = 1 AndAlso Not PosisiHantu(hx + 1, hy, hantu) Then
                            hx += 1
                            Exit For
                        End If
                    Case 2
                        If hy < map.GetUpperBound(0) AndAlso map(hy + 1, hx) = 1 AndAlso Not PosisiHantu(hx, hy + 1, hantu) Then
                            hy += 1
                            Exit For
                        End If
                    Case 3
                        If hx > 0 AndAlso map(hy, hx - 1) = 1 AndAlso Not PosisiHantu(hx - 1, hy, hantu) Then
                            hx -= 1
                            Exit For
                        End If
                End Select
            Next
        End If

        ' Update posisi hantu berdasarkan nomor hantu
        Select Case hantu
            Case 1
                enmx = hx
                enmy = hy
            Case 2
                enmx1 = hx
                enmy1 = hy
            Case 3
                enmx2 = hx
                enmy2 = hy
        End Select
    End Sub

    ' Fungsi untuk hantu bergerak secara acak
    Private Sub GerakAcak(hantu As Integer)
        Dim hx As Integer
        Dim hy As Integer

        Select Case hantu
            Case 1
                hx = enmx
                hy = enmy
            Case 2
                hx = enmx1
                hy = enmy1
            Case 3
                hx = enmx2
                hy = enmy2
        End Select

        Dim arah As Integer = Math.Floor(Rnd() * 4)
        Select Case arah
            Case 0
                If map(hy - 1, hx) = 1 Then hy -= 1
            Case 1
                If map(hy, hx + 1) = 1 Then hx += 1
            Case 2
                If map(hy + 1, hx) = 1 Then hy += 1
            Case 3
                If map(hy, hx - 1) = 1 Then hx -= 1
        End Select

        Select Case hantu
            Case 1
                enmx = hx
                enmy = hy
            Case 2
                enmx1 = hx
                enmy1 = hy
            Case 3
                enmx2 = hx
                enmy2 = hy
        End Select
    End Sub
    Private Function PosisiHantu(x As Integer, y As Integer, hantu As Integer) As Boolean
        Select Case hantu
            Case 1
                Return (x = enmx1 AndAlso y = enmy1) OrElse (x = enmx2 AndAlso y = enmy2)
            Case 2
                Return (x = enmx AndAlso y = enmy) OrElse (x = enmx2 AndAlso y = enmy2)
            Case 3
                Return (x = enmx AndAlso y = enmy) OrElse (x = enmx1 AndAlso y = enmy1)
            Case Else
                Return False
        End Select
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'engine untuk hantu
        If (pacx = 1 And pacy = 1) Then
            GerakAcak(1)
            GerakAcak(2)
            GerakAcak(3)
        Else
            'Hitung jarak PakMan dengan Hantu
            Dim jarak1 As Integer = Math.Abs(pacx - enmx) + Math.Abs(pacy - enmy)
            Dim jarak2 As Integer = Math.Abs(pacx - enmx1) + Math.Abs(pacy - enmy1)
            Dim jarak3 As Integer = Math.Abs(pacx - enmx2) + Math.Abs(pacy - enmy2)

            'Urutkan jarak hantu
            Dim jarak() As Integer = {jarak1, jarak2, jarak3}
            Dim hantuIndex() As Integer = {1, 2, 3}
            Array.Sort(jarak, hantuIndex)

            KejarPakman(hantuIndex(0))
            KejarPakman(hantuIndex(1))
            GerakAcak(hantuIndex(2))
        End If

        oldpacx = pacx
        oldpacy = pacy
        Redraw()

        'cek apakah posisi pakman sama dg musuh
        If (pacx = enmx) And (pacy = enmy) Then
            Timer1.Enabled = False
            nyawa -= 1
            resetDefault()
        ElseIf (pacx = enmx1) And (pacy = enmy1) Then
            Timer1.Enabled = False
            nyawa -= 1
            resetDefault()
        ElseIf (pacx = enmx2) And (pacy = enmy2) Then
            Timer1.Enabled = False
            nyawa -= 1
            resetDefault()
        End If

        If nyawa = 0 Then
            Timer1.Enabled = False
            MsgBox("Nyawa habis! Game Over!")
            If (MsgBoxResult.Ok) Then
                nyawa = 3
                resetDefault()
            End If
        End If

        'cek apakah posisi pakman sama dg rumah
        If (pacx = goalx) And (pacy = (map.GetUpperBound(0) - 1)) Then
            Timer1.Enabled = False
            MsgBox("Pakman safe at Home!")
        End If
    End Sub
End Class
