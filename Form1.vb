Public Class MainForm

    Dim nStuff As SpriteType
    Dim ladder(NUMLADDERS) As PictureBox
    Dim fStuff(NUMFLOORS) As FloorType
    Dim ball(NUMBALLS) As PictureBox
    Dim bStuff(NUMBALLS) As SpriteType

    Const NUMLADDERS As Integer = 7
    Const NUMFLOORS As Integer = 6
    Const NUMBALLS As Integer = 3



    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        nStuff.picNum = 1
        ladder(0) = Ladder0
        ladder(1) = Ladder1
        ladder(2) = Ladder2
        ladder(3) = Ladder3
        ladder(4) = Ladder4
        ladder(5) = Ladder5
        ladder(6) = Ladder6
        ladder(7) = Ladder7
        Call Ballset()
        Call FloorSet()
        Timer1.Start()
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left Then       'move left 
            If Nansen.Left > 50 Then
                nStuff.speed.X = -7
            Else
                nStuff.speed.X = 0
            End If
            nStuff.facingRight = False
        End If

        If e.KeyCode = Keys.Right Then      'move right 
            If Nansen.Left < 580 Then
                nStuff.speed.X = 7
            Else
                nStuff.speed.X = 0
            End If
            nStuff.facingRight = True
        End If

        If e.KeyCode = Keys.Up And nStuff.floating = False Then
            nStuff.speed.Y = -5
        End If
        If e.KeyCode = Keys.Down And nStuff.floating = False Then
            nStuff.speed.Y = 5
        End If

        If e.KeyCode = Keys.Space And nStuff.speed.Y = 0 Then
            nStuff.speed.Y = -5
            nStuff.floattime = 0
            nStuff.floating = True
            nStuff.onFloor = False
        End If

    End Sub

    Private Sub MainForm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
            nStuff.speed.X = 0
        End If

        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            If nStuff.floating = False Then
                nStuff.speed.Y = 0
            End If
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call MoveNansen()
        Call AnimateNansen()
        Call MoveBall()

    End Sub


    ''' <summary>
    ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' </summary>


    Private Sub MoveNansen()
        nStuff.floorNumber = GetFloorNumber(Nansen.Top)

        If nStuff.floating = True Then
            Call Jumping(nStuff)
        Else
            nStuff.onLadder = CheckLadder()
            If nStuff.onLadder = False Then
                MoveAlongFloor(nStuff, Nansen)
            Else
                nStuff.speed.X = 0
            End If
        End If

        If (Nansen.Left < 77 And nStuff.speed.X < 0) Or (Nansen.Left > 540 And nStuff.speed.X > 0) Then
            nStuff.speed.X = 0
        End If

        Nansen.Left += nStuff.speed.X
        Nansen.Top += nStuff.speed.Y
    End Sub

    Private Sub AnimateMoveRight()

        If nStuff.picNum = 1 Then
            nStuff.picNum = 2
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) &
                                      "\pics\nansenRightMove2.jpg")
        ElseIf nStuff.picNum = 2 Then
            nStuff.picNum = 3
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) &
                                      "\pics\nansenRightMove3.jpg")
        ElseIf nStuff.picNum = 3 Then
            nStuff.picNum = 1
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) &
                                      "\pics\nansenRightMove1.jpg")
        End If

    End Sub

    Private Sub AnimateMoveLeft()

        If nStuff.picNum = 1 Then
            nStuff.picNum = 2
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) &
                                      "\pics\nansenLeftMove2.jpg")
        ElseIf nStuff.picNum = 2 Then
            nStuff.picNum = 3
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) &
                                      "\pics\nansenLeftMove3.jpg")
        ElseIf nStuff.picNum = 3 Then
            nStuff.picNum = 1
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) &
                                      "\pics\nansenLeftMove1.jpg")
        End If

    End Sub

    Private Sub AnimateJump()
        If nStuff.speed.X > 0 And nStuff.facingRight = True Then
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) &
                                      "\pics\nansenRightFloat.jpg")
        ElseIf nStuff.speed.X < 0 And nStuff.facingRight = False Then
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) &
                                      "\pics\nansenLeftFloat.jpg")
        End If
    End Sub

    Private Sub AnimateStanding()
        If nStuff.facingRight = True Then
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) &
                                      "\pics\NansenRightMove1.jpg")
        Else
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) &
                                      "\pics\NansenLeftMove1.jpg")
        End If
    End Sub

    Private Sub AnimateNansen()

        If nStuff.speed.Y <> 0 Then
            If nStuff.floating = False Then
                Call AnimateClimb()
            Else
                Call AnimateJump()
            End If
        ElseIf nStuff.onLadder = False Then

            If nStuff.speed.X > 0 Then
                Call AnimateMoveRight()
            ElseIf nStuff.speed.X < 0 Then
                Call AnimateMoveLeft()
            Else
                Call AnimateStanding()
            End If
        End If

    End Sub

    Private Sub AnimateClimb()
        If nStuff.picNum = 1 Then
            nStuff.picNum = 2
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) &
                                      "\pics\NansenClimb2.jpg")
        ElseIf nStuff.picNum = 2 Then
            nStuff.picNum = 3
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) &
                                      "\pics\NansenClimb3.jpg")
        ElseIf nStuff.picNum = 3 Then
            nStuff.picNum = 1
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) &
                                      "\pics\NansenClimb1.jpg")
        End If

    End Sub

    Private Function CheckLadder()
        Dim index As Integer
        Dim ladderoffset As Integer
        ladderoffset = 15

        For index = 0 To NUMLADDERS
            If nStuff.speed.Y < 0 Then
                If Nansen.Left > ladder(index).Left - ladderoffset And Nansen.Right < ladder(index).Right +
                    ladderoffset Then
                    If Nansen.Top < ladder(index).Bottom And Nansen.Bottom > ladder(index).Top Then
                        Return True
                    End If
                End If
            ElseIf nStuff.speed.Y > 0 Then
                If Nansen.Left > ladder(index).Left - ladderoffset And Nansen.Right < ladder(index).Right +
                    ladderoffset Then
                    If Nansen.Bottom < ladder(index).Bottom And Nansen.Bottom > ladder(index).Top - ladderoffset Then
                        Return True
                    End If
                End If
            ElseIf nStuff.speed.Y = 0 Then
                If Nansen.Left > ladder(index).Left - ladderoffset And Nansen.Right < ladder(index).Right +
                    ladderoffset Then
                    If Nansen.Bottom < ladder(index).Bottom - ladderoffset And Nansen.Bottom > ladder(index).Top +
                        ladderoffset Then
                        Return True
                    End If
                End If
            End If
        Next index
        Return False
        '      If Nansen.Left > ladder(0).Left And Nansen.Right < ladder(0).Right Then
        '          If Nansen.Top < ladder(0).Bottom And Nansen.Bottom > ladder(0).Top Then
        '              Return True
        '          End If
        '      End If
    End Function

    Public Sub FloorSet()
        fStuff(0).slope = -0.00000001
        fStuff(1).slope = 0.078
        fStuff(2).slope = -0.078
        fStuff(3).slope = 0.078
        fStuff(4).slope = -0.078
        fStuff(5).slope = 0
        fStuff(6).slope = 0

        fStuff(0).x = 137
        fStuff(1).x = 137
        fStuff(2).x = 137
        fStuff(3).x = 137
        fStuff(4).x = 137
        fStuff(5).x = 137
        fStuff(6).x = 137

        fStuff(0).y = 465
        fStuff(1).y = 377
        fStuff(2).y = 327
        fStuff(3).y = 226
        fStuff(4).y = 176
        fStuff(5).y = 92
        fStuff(6).y = 42

        fStuff(0).LeftEdge = 0
        fStuff(1).LeftEdge = 0
        fStuff(2).LeftEdge = 133
        fStuff(3).LeftEdge = 0
        fStuff(4).LeftEdge = 133
        fStuff(5).LeftEdge = 0
        fStuff(6).LeftEdge = 200

        fStuff(0).RightEdge = 570
        fStuff(1).RightEdge = 507
        fStuff(2).RightEdge = 570
        fStuff(3).RightEdge = 507
        fStuff(4).RightEdge = 570
        fStuff(5).RightEdge = 507
        fStuff(6).RightEdge = 312



    End Sub

    Private Function GetFloorNumber(ByVal ThingTop As Integer)
        If ThingTop < 20 Then
            Return 6
        ElseIf ThingTop < 73 Then
            Return 5
        ElseIf ThingTop < 160 Then
            Return 4
        ElseIf ThingTop < 240 Then
            Return 3
        ElseIf ThingTop < 320 Then
            Return 2
        ElseIf ThingTop < 393 Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub Jumping(ByRef sprite As SpriteType)
        If sprite.floattime = 5 Then
            If sprite.speed.Y = -5 Then
                sprite.speed.Y = 5
            Else
                sprite.speed.Y = 0
                sprite.floating = False
            End If
            sprite.floattime = 1
        Else
            sprite.floattime = sprite.floattime + 1
        End If
    End Sub

    Private Sub MoveAlongFloor(ByRef sprite As SpriteType, ByRef thing As PictureBox)
        sprite.speed.Y = 0
        sprite.onFloor = True
        thing.Top = fStuff(sprite.floorNumber).slope * (thing.Left - fStuff(sprite.floorNumber).x) +
            fStuff(sprite.floorNumber).y - thing.Height
        If thing.Left > fStuff(sprite.floorNumber).RightEdge Then
            sprite.floating = True
            sprite.floattime = 1
            sprite.speed.Y = 5
        ElseIf thing.Left + thing.Width < fStuff(sprite.floorNumber).LeftEdge Then
            sprite.floating = True
            sprite.floattime = 1
            sprite.speed.Y = 5
        End If
    End Sub

    Private Sub Ballset()
        Dim index As Integer

        ball(0) = Ball0
        ball(1) = Ball1
        ball(2) = Ball2
        ball(3) = Ball3

        For index = 0 To 3
            bStuff(index).floating = False
            bStuff(index).onLadder = False
            bStuff(index).picNum = 1
            bStuff(index).speed.X = 10
            bStuff(index).speed.Y = 0
        Next index
    End Sub

    Private Sub MoveBall()

        bStuff(0).floorNumber = GetFloorNumber(ball(0).Top)

        If bStuff(0).floating = True Then
            Call Jumping(bStuff(0))
        Else
            bStuff(0).onLadder = BallCheckLadder()
            If bStuff(0).onLadder = False Then
                If fStuff(bStuff(0).floorNumber).slope < 0 Then
                    bStuff(0).speed.X = -10
                Else
                    bStuff(0).speed.X = 10
                End If
                MoveAlongFloor(bStuff(0), ball(0))
            Else
                bStuff(0).speed.X = 0
                bStuff(0).speed.Y = 10
                bStuff(0).floating = True
            End If
        End If

        If (ball(0).Left < 77 And bStuff(0).speed.X < 0) Or (ball(0).Left > 540 And bStuff(0).speed.X > 0) Then
            bStuff(0).speed.X = 0
        End If

        ball(0).Left = ball(0).Left + bStuff(0).speed.X
        ball(0).Top = ball(0).Top + bStuff(0).speed.Y
    End Sub

    Private Function BallCheckLadder()
        Dim index As Integer
        Dim ballladderoffset As Integer

        ballladderoffset = 13
        If Int(Rnd() * 5) = 0 Then
            For index = 0 To NUMLADDERS
                If ball(0).Left > ladder(index).Left And ball(0).Right < ladder(index).Right Then
                    If ball(0).Bottom + ballladderoffset > ladder(index).Top And ball(0).Bottom - ballladderoffset < ladder(index).Top Then
                        Return True
                    End If
                End If
            Next index
        End If
        Return False
    End Function

End Class
