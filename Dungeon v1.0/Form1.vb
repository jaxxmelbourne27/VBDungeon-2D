Imports System.IO

Public Class Form1
    Dim screen(15, 15) As Integer
    Dim a, b, c, d, e, x, y As Integer
    Dim counter As Integer = 1
    Dim currentTile As Integer
    Dim board(1, 1) As Integer
    Dim map As String
    Dim playerAction As Image = Image.FromFile("..\..\Resources\player.png")

    Sub ScreenWrap()
        If board(0, 0) = 1 Then
            map = "..\..\Resources\maps\map1.csv"
        ElseIf board(1, 0) = 1 Then
            map = "..\..\Resources\maps\map2.csv"
        ElseIf board(0, 1) = 1 Then
            map = "..\..\Resources\maps\map3.csv"
        ElseIf board(1, 1) = 1 Then
            map = "..\..\Resources\maps\map4.csv"
        End If
        ReadFile()
        StringImage()
    End Sub

    Sub ReadFile()
        Dim x As Integer
        Dim y As Integer
        Dim strarray(1, 1) As String

        If File.Exists(map) Then
            Dim temp As StreamReader = File.OpenText(map)
            Dim lines() As String
            Dim line() As String
            lines = temp.ReadToEnd().Split(Environment.NewLine)
            line = lines(0).Split(",")
            ReDim screen(15, 15)

            For y = 0 To 15
                line = lines(y).Split(",")
                For x = 0 To 15
                    screen(x, y) = line(x)
                Next
            Next
        End If
    End Sub

    Sub StringImage2(PictureBox, d, e)
        PictureBox.Image = If(screen(d, e) = 0, playerAction, If(screen(d, e) = 1, Image.FromFile("..\..\Resources\1.png"), If(screen(d, e) = 2, Image.FromFile("..\..\Resources\2.png"), If(screen(d, e) = 3, Image.FromFile("..\..\Resources\3.png"), If(screen(d, e) = 4, Image.FromFile("..\..\Resources\4.png"), If(screen(d, e) = 5, Image.FromFile("..\..\Resources\5.png"), If(screen(d, e) = 6, Image.FromFile("..\..\Resources\6.png"), If(screen(d, e) = 7, Image.FromFile("..\..\Resources\7.png"), If(screen(d, e) = 8, Image.FromFile("..\..\Resources\8.png"), If(screen(d, e) = 9, Image.FromFile("..\..\Resources\9.png"), If(screen(d, e) = 10, Image.FromFile("..\..\Resources\10.png"), If(screen(d, e) = 11, Image.FromFile("..\..\Resources\11.png"), If(screen(d, e) = 12, Image.FromFile("..\..\Resources\12.png"), If(screen(d, e) = 13, Image.FromFile("..\..\Resources\13.png"), If(screen(d, e) = 14, Image.FromFile("..\..\Resources\14.png"), If(screen(d, e) = 15, Image.FromFile("..\..\Resources\15.png"), If(screen(d, e) = 16, Image.FromFile("..\..\Resources\16.png"), Image.FromFile("..\..\Resources\NULL.png"))))))))))))))))))
        If screen(d, e) = 0 Then
            PictureBox.BackgroundImage = Image.FromFile(If(currentTile = 1, "..\..\Resources\1.png", If(currentTile = 2, "..\..\Resources\2.png", If(currentTile = 3, "..\..\Resources\3.png", If(currentTile = 4, "..\..\Resources\4.png", If(currentTile = 5, "..\..\Resources\5.png", If(currentTile = 6, "..\..\Resources\6.png", If(currentTile = 7, "..\..\Resources\7.png", If(currentTile = 8, "..\..\Resources\8.png", If(currentTile = 9, "..\..\Resources\9.png", If(currentTile = 10, "..\..\Resources\10.png", If(currentTile = 11, "..\..\Resources\11.png", If(currentTile = 12, "..\..\Resources\12.png", If(currentTile = 13, "..\..\Resources\13.png", If(currentTile = 14, "..\..\Resources\14.png", If(currentTile = 15, "..\..\Resources\15.png", If(currentTile = 16, "..\..\Resources\16.png", "..\..\Resources\NULL.png")))))))))))))))))
        End If
    End Sub

    Sub StringImage()
        StringImage2(PictureBox1, 0, 0)
        StringImage2(PictureBox2, 1, 0)
        StringImage2(PictureBox3, 2, 0)
        StringImage2(PictureBox4, 3, 0)
        StringImage2(PictureBox5, 4, 0)
        StringImage2(PictureBox6, 5, 0)
        StringImage2(PictureBox7, 6, 0)
        StringImage2(PictureBox8, 7, 0)
        StringImage2(PictureBox9, 8, 0)
        StringImage2(PictureBox10, 9, 0)
        StringImage2(PictureBox11, 10, 0)
        StringImage2(PictureBox12, 11, 0)
        StringImage2(PictureBox13, 12, 0)
        StringImage2(PictureBox14, 13, 0)
        StringImage2(PictureBox15, 14, 0)
        StringImage2(PictureBox16, 15, 0)
        StringImage2(PictureBox32, 0, 1)
        StringImage2(PictureBox31, 1, 1)
        StringImage2(PictureBox30, 2, 1)
        StringImage2(PictureBox29, 3, 1)
        StringImage2(PictureBox28, 4, 1)
        StringImage2(PictureBox27, 5, 1)
        StringImage2(PictureBox26, 6, 1)
        StringImage2(PictureBox25, 7, 1)
        StringImage2(PictureBox24, 8, 1)
        StringImage2(PictureBox23, 9, 1)
        StringImage2(PictureBox22, 10, 1)
        StringImage2(PictureBox21, 11, 1)
        StringImage2(PictureBox20, 12, 1)
        StringImage2(PictureBox19, 13, 1)
        StringImage2(PictureBox18, 14, 1)
        StringImage2(PictureBox17, 15, 1)
        StringImage2(PictureBox64, 0, 2)
        StringImage2(PictureBox63, 1, 2)
        StringImage2(PictureBox62, 2, 2)
        StringImage2(PictureBox61, 3, 2)
        StringImage2(PictureBox60, 4, 2)
        StringImage2(PictureBox59, 5, 2)
        StringImage2(PictureBox58, 6, 2)
        StringImage2(PictureBox57, 7, 2)
        StringImage2(PictureBox56, 8, 2)
        StringImage2(PictureBox55, 9, 2)
        StringImage2(PictureBox54, 10, 2)
        StringImage2(PictureBox53, 11, 2)
        StringImage2(PictureBox52, 12, 2)
        StringImage2(PictureBox51, 13, 2)
        StringImage2(PictureBox50, 14, 2)
        StringImage2(PictureBox49, 15, 2)
        StringImage2(PictureBox48, 0, 3)
        StringImage2(PictureBox47, 1, 3)
        StringImage2(PictureBox46, 2, 3)
        StringImage2(PictureBox45, 3, 3)
        StringImage2(PictureBox44, 4, 3)
        StringImage2(PictureBox43, 5, 3)
        StringImage2(PictureBox42, 6, 3)
        StringImage2(PictureBox41, 7, 3)
        StringImage2(PictureBox40, 8, 3)
        StringImage2(PictureBox39, 9, 3)
        StringImage2(PictureBox38, 10, 3)
        StringImage2(PictureBox37, 11, 3)
        StringImage2(PictureBox36, 12, 3)
        StringImage2(PictureBox35, 13, 3)
        StringImage2(PictureBox34, 14, 3)
        StringImage2(PictureBox33, 15, 3)
        StringImage2(PictureBox128, 0, 4)
        StringImage2(PictureBox127, 1, 4)
        StringImage2(PictureBox126, 2, 4)
        StringImage2(PictureBox125, 3, 4)
        StringImage2(PictureBox124, 4, 4)
        StringImage2(PictureBox123, 5, 4)
        StringImage2(PictureBox122, 6, 4)
        StringImage2(PictureBox121, 7, 4)
        StringImage2(PictureBox120, 8, 4)
        StringImage2(PictureBox119, 9, 4)
        StringImage2(PictureBox118, 10, 4)
        StringImage2(PictureBox117, 11, 4)
        StringImage2(PictureBox116, 12, 4)
        StringImage2(PictureBox115, 13, 4)
        StringImage2(PictureBox114, 14, 4)
        StringImage2(PictureBox113, 15, 4)
        StringImage2(PictureBox112, 0, 5)
        StringImage2(PictureBox111, 1, 5)
        StringImage2(PictureBox110, 2, 5)
        StringImage2(PictureBox109, 3, 5)
        StringImage2(PictureBox108, 4, 5)
        StringImage2(PictureBox107, 5, 5)
        StringImage2(PictureBox106, 6, 5)
        StringImage2(PictureBox105, 7, 5)
        StringImage2(PictureBox104, 8, 5)
        StringImage2(PictureBox103, 9, 5)
        StringImage2(PictureBox102, 10, 5)
        StringImage2(PictureBox101, 11, 5)
        StringImage2(PictureBox100, 12, 5)
        StringImage2(PictureBox99, 13, 5)
        StringImage2(PictureBox98, 14, 5)
        StringImage2(PictureBox97, 15, 5)
        StringImage2(PictureBox96, 0, 6)
        StringImage2(PictureBox95, 1, 6)
        StringImage2(PictureBox94, 2, 6)
        StringImage2(PictureBox93, 3, 6)
        StringImage2(PictureBox92, 4, 6)
        StringImage2(PictureBox91, 5, 6)
        StringImage2(PictureBox90, 6, 6)
        StringImage2(PictureBox89, 7, 6)
        StringImage2(PictureBox88, 8, 6)
        StringImage2(PictureBox87, 9, 6)
        StringImage2(PictureBox86, 10, 6)
        StringImage2(PictureBox85, 11, 6)
        StringImage2(PictureBox84, 12, 6)
        StringImage2(PictureBox83, 13, 6)
        StringImage2(PictureBox82, 14, 6)
        StringImage2(PictureBox81, 15, 6)
        StringImage2(PictureBox80, 0, 7)
        StringImage2(PictureBox79, 1, 7)
        StringImage2(PictureBox78, 2, 7)
        StringImage2(PictureBox77, 3, 7)
        StringImage2(PictureBox76, 4, 7)
        StringImage2(PictureBox75, 5, 7)
        StringImage2(PictureBox74, 6, 7)
        StringImage2(PictureBox73, 7, 7)
        StringImage2(PictureBox72, 8, 7)
        StringImage2(PictureBox71, 9, 7)
        StringImage2(PictureBox70, 10, 7)
        StringImage2(PictureBox69, 11, 7)
        StringImage2(PictureBox68, 12, 7)
        StringImage2(PictureBox67, 13, 7)
        StringImage2(PictureBox66, 14, 7)
        StringImage2(PictureBox65, 15, 7)
        StringImage2(PictureBox256, 0, 8)
        StringImage2(PictureBox255, 1, 8)
        StringImage2(PictureBox254, 2, 8)
        StringImage2(PictureBox253, 3, 8)
        StringImage2(PictureBox252, 4, 8)
        StringImage2(PictureBox251, 5, 8)
        StringImage2(PictureBox250, 6, 8)
        StringImage2(PictureBox249, 7, 8)
        StringImage2(PictureBox248, 8, 8)
        StringImage2(PictureBox247, 9, 8)
        StringImage2(PictureBox246, 10, 8)
        StringImage2(PictureBox245, 11, 8)
        StringImage2(PictureBox244, 12, 8)
        StringImage2(PictureBox243, 13, 8)
        StringImage2(PictureBox242, 14, 8)
        StringImage2(PictureBox241, 15, 8)
        StringImage2(PictureBox240, 0, 9)
        StringImage2(PictureBox239, 1, 9)
        StringImage2(PictureBox238, 2, 9)
        StringImage2(PictureBox237, 3, 9)
        StringImage2(PictureBox236, 4, 9)
        StringImage2(PictureBox235, 5, 9)
        StringImage2(PictureBox234, 6, 9)
        StringImage2(PictureBox233, 7, 9)
        StringImage2(PictureBox232, 8, 9)
        StringImage2(PictureBox231, 9, 9)
        StringImage2(PictureBox230, 10, 9)
        StringImage2(PictureBox229, 11, 9)
        StringImage2(PictureBox228, 12, 9)
        StringImage2(PictureBox227, 13, 9)
        StringImage2(PictureBox226, 14, 9)
        StringImage2(PictureBox225, 15, 9)
        StringImage2(PictureBox224, 0, 10)
        StringImage2(PictureBox223, 1, 10)
        StringImage2(PictureBox222, 2, 10)
        StringImage2(PictureBox221, 3, 10)
        StringImage2(PictureBox220, 4, 10)
        StringImage2(PictureBox219, 5, 10)
        StringImage2(PictureBox218, 6, 10)
        StringImage2(PictureBox217, 7, 10)
        StringImage2(PictureBox216, 8, 10)
        StringImage2(PictureBox215, 9, 10)
        StringImage2(PictureBox214, 10, 10)
        StringImage2(PictureBox213, 11, 10)
        StringImage2(PictureBox212, 12, 10)
        StringImage2(PictureBox211, 13, 10)
        StringImage2(PictureBox210, 14, 10)
        StringImage2(PictureBox209, 15, 10)
        StringImage2(PictureBox208, 0, 11)
        StringImage2(PictureBox207, 1, 11)
        StringImage2(PictureBox206, 2, 11)
        StringImage2(PictureBox205, 3, 11)
        StringImage2(PictureBox204, 4, 11)
        StringImage2(PictureBox203, 5, 11)
        StringImage2(PictureBox202, 6, 11)
        StringImage2(PictureBox201, 7, 11)
        StringImage2(PictureBox200, 8, 11)
        StringImage2(PictureBox199, 9, 11)
        StringImage2(PictureBox198, 10, 11)
        StringImage2(PictureBox197, 11, 11)
        StringImage2(PictureBox196, 12, 11)
        StringImage2(PictureBox195, 13, 11)
        StringImage2(PictureBox194, 14, 11)
        StringImage2(PictureBox193, 15, 11)
        StringImage2(PictureBox192, 0, 12)
        StringImage2(PictureBox191, 1, 12)
        StringImage2(PictureBox190, 2, 12)
        StringImage2(PictureBox189, 3, 12)
        StringImage2(PictureBox188, 4, 12)
        StringImage2(PictureBox187, 5, 12)
        StringImage2(PictureBox186, 6, 12)
        StringImage2(PictureBox185, 7, 12)
        StringImage2(PictureBox184, 8, 12)
        StringImage2(PictureBox183, 9, 12)
        StringImage2(PictureBox182, 10, 12)
        StringImage2(PictureBox181, 11, 12)
        StringImage2(PictureBox180, 12, 12)
        StringImage2(PictureBox179, 13, 12)
        StringImage2(PictureBox178, 14, 12)
        StringImage2(PictureBox177, 15, 12)
        StringImage2(PictureBox176, 0, 13)
        StringImage2(PictureBox175, 1, 13)
        StringImage2(PictureBox174, 2, 13)
        StringImage2(PictureBox173, 3, 13)
        StringImage2(PictureBox172, 4, 13)
        StringImage2(PictureBox171, 5, 13)
        StringImage2(PictureBox170, 6, 13)
        StringImage2(PictureBox169, 7, 13)
        StringImage2(PictureBox168, 8, 13)
        StringImage2(PictureBox167, 9, 13)
        StringImage2(PictureBox166, 10, 13)
        StringImage2(PictureBox165, 11, 13)
        StringImage2(PictureBox164, 12, 13)
        StringImage2(PictureBox163, 13, 13)
        StringImage2(PictureBox162, 14, 13)
        StringImage2(PictureBox161, 15, 13)
        StringImage2(PictureBox160, 0, 14)
        StringImage2(PictureBox159, 1, 14)
        StringImage2(PictureBox158, 2, 14)
        StringImage2(PictureBox157, 3, 14)
        StringImage2(PictureBox156, 4, 14)
        StringImage2(PictureBox155, 5, 14)
        StringImage2(PictureBox154, 6, 14)
        StringImage2(PictureBox153, 7, 14)
        StringImage2(PictureBox152, 8, 14)
        StringImage2(PictureBox151, 9, 14)
        StringImage2(PictureBox150, 10, 14)
        StringImage2(PictureBox149, 11, 14)
        StringImage2(PictureBox148, 12, 14)
        StringImage2(PictureBox147, 13, 14)
        StringImage2(PictureBox146, 14, 14)
        StringImage2(PictureBox145, 15, 14)
        StringImage2(PictureBox144, 0, 15)
        StringImage2(PictureBox143, 1, 15)
        StringImage2(PictureBox142, 2, 15)
        StringImage2(PictureBox141, 3, 15)
        StringImage2(PictureBox140, 4, 15)
        StringImage2(PictureBox139, 5, 15)
        StringImage2(PictureBox138, 6, 15)
        StringImage2(PictureBox137, 7, 15)
        StringImage2(PictureBox136, 8, 15)
        StringImage2(PictureBox135, 9, 15)
        StringImage2(PictureBox134, 10, 15)
        StringImage2(PictureBox133, 11, 15)
        StringImage2(PictureBox132, 12, 15)
        StringImage2(PictureBox131, 13, 15)
        StringImage2(PictureBox130, 14, 15)
        StringImage2(PictureBox129, 15, 15)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                If Not x = 0 Then
                    If Not screen(x - 1, y) = 2 Then
                        screen(x, y) = currentTile
                        x = x - 1
                        currentTile = screen(x, y)
                        screen(x, y) = 0
                    End If
                Else
                    screen(x, y) = currentTile
                    currentTile = screen(x, y)
                    screen(x, y) = 0
                    If board(0, 0) = 1 Then
                        screen(x, y) = currentTile
                        screen(x, y) = 0
                    ElseIf board(1, 0) = 1 Then
                        board(0, 0) = 1
                        board(1, 0) = 0
                        x = 15
                        ScreenWrap()
                    ElseIf board(0, 1) = 1 Then
                        screen(x, y) = currentTile
                        screen(x, y) = 0
                    ElseIf board(1, 1) = 1 Then
                        board(1, 1) = 0
                        board(0, 1) = 1
                        x = 15
                        ScreenWrap()
                    End If
                End If
                e.Handled = True
            Case Keys.Right
                If Not x = 15 Then
                    If Not screen(x + 1, y) = 2 Then
                        screen(x, y) = currentTile
                        x = x + 1
                        currentTile = screen(x, y)
                        screen(x, y) = 0
                    End If
                Else
                    screen(x, y) = currentTile
                    currentTile = screen(x, y)
                    screen(x, y) = 0
                    If board(0, 0) = 1 Then
                        board(1, 0) = 1
                        board(0, 0) = 0
                        x = 0
                        ScreenWrap()
                    ElseIf board(1, 0) = 1 Then
                        screen(x, y) = currentTile
                        screen(x, y) = 0
                    ElseIf board(0, 1) = 1 Then
                        board(1, 1) = 1
                        board(0, 1) = 0
                        x = 0
                        ScreenWrap()
                    ElseIf board(1, 1) = 1 Then
                        screen(x, y) = currentTile
                        screen(x, y) = 0
                    End If
                End If
                e.Handled = True
            Case Keys.Down
                If Not y = 15 Then
                    If Not screen(x, y + 1) = 2 Then
                        screen(x, y) = currentTile
                        y = y + 1
                        currentTile = screen(x, y)
                        screen(x, y) = 0
                    End If
                Else
                    screen(x, y) = currentTile
                    currentTile = screen(x, y)
                    screen(x, y) = 0
                    If board(0, 0) = 1 Then
                        board(0, 1) = 1
                        board(0, 0) = 0
                        y = 0
                        ScreenWrap()
                    ElseIf board(1, 0) = 1 Then
                        board(1, 1) = 1
                        board(1, 0) = 0
                        y = 0
                        ScreenWrap()
                    ElseIf board(0, 1) = 1 Then
                        screen(x, y) = currentTile
                        screen(x, y) = 0
                    ElseIf board(1, 1) = 1 Then
                        screen(x, y) = currentTile
                        screen(x, y) = 0
                    End If
                End If
                e.Handled = True
            Case Keys.Up
                If Not y = 0 Then
                    If Not screen(x, y - 1) = 2 Then
                        screen(x, y) = currentTile
                        y = y - 1
                        currentTile = screen(x, y)
                        screen(x, y) = 0
                    End If
                Else
                    screen(x, y) = currentTile
                    currentTile = screen(x, y)
                    screen(x, y) = 0
                    If board(0, 0) = 1 Then
                        screen(x, y) = currentTile
                        screen(x, y) = 0
                    ElseIf board(1, 0) = 1 Then
                        screen(x, y) = currentTile
                        screen(x, y) = 0
                    ElseIf board(0, 1) = 1 Then
                        board(0, 1) = 0
                        board(0, 0) = 1
                        y = 15
                        ScreenWrap()
                    ElseIf board(1, 1) = 1 Then
                        board(1, 1) = 0
                        board(1, 0) = 1
                        y = 15
                        ScreenWrap()
                    End If
                End If
                e.Handled = True
        End Select
        screen(x, y) = 0
    End Sub

    Sub changeTextures()
        If counter = 1 Then
            playerAction = Image.FromFile("..\..\Resources\player.png")
            counter = 2
        ElseIf counter = 2 Then
            playerAction = Image.FromFile("..\..\Resources\player2.png")
            counter = 3
        ElseIf counter = 3 Then
            playerAction = Image.FromFile("..\..\Resources\player3.png")
            counter = 4
        ElseIf counter = 4 Then
            playerAction = Image.FromFile("..\..\Resources\player4.png")
            counter = 1
        End If
        StringImage()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sub1 As New tileClock(200)
        sub1.StartTimer()

        For i As Integer = 0 To 1
            For j As Integer = 0 To 1
                board(j, i) = 0
            Next
        Next
        x = 8
        y = 8
        map = "..\..\Resources\maps\map3.csv"
        board(0, 1) = 1
        ReadFile()
        currentTile = screen(x, y)
        screen(x, y) = 0
        StringImage()
    End Sub
End Class

Public Class tileClock
    Private WithEvents Timer1 As New Timer

    Public Sub New(TickValue As Integer)
        Timer1 = New Windows.Forms.Timer
        Timer1.Interval = TickValue
    End Sub

    Public Sub StartTimer()
        Timer1.Start()
    End Sub

    Private Sub Timer_Tick() Handles Timer1.Tick
        Form1.changeTextures()
    End Sub
End Class
