Public Class pongMain
    Dim speed As Single = 10
    Dim rndInst As New Random()
    Dim xVel As Single = Math.Cos(rndInst.Next(5, 10)) * speed
    Dim yVel As Single = Math.Sin(rndInst.Next(5, 10)) * speed
    Dim compScore As Integer = 0
    Dim plrScore As Integer = 0

    Private Sub gameTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gameTimer.Tick
        If gameBall.Location.Y > 5 And gameBall.Location.Y < Me.Height - 40 - paddlePlayer.Height Then
            paddleComputer.Location = New Point(paddleComputer.Location.X, gameBall.Location.Y)
        End If
        gameBall.Location = New Point(gameBall.Location.X + xVel, gameBall.Location.Y + yVel)

        If gameBall.Location.Y < 27 Then
            gameBall.Location = New Point(gameBall.Location.X, 27)
            yVel = -yVel
        End If

        If gameBall.Location.Y > Me.Height - gameBall.Size.Height - 45 Then
            gameBall.Location = New Point(gameBall.Location.X, Me.Height - gameBall.Size.Height - 45)
            yVel = -yVel
        End If

        If gameBall.Bounds.IntersectsWith(paddlePlayer.Bounds) Then
            gameBall.Location = New Point(gameBall.Location.X, gameBall.Location.Y)
            xVel = -xVel
        End If

        If gameBall.Bounds.IntersectsWith(paddleComputer.Bounds) Then
            gameBall.Location = New Point(gameBall.Location.X, gameBall.Location.Y)
            xVel = -xVel
        End If

        If gameBall.Location.X < 0 Then
            plrScore += 1
            gameBall.Location = New Point(Me.Size.Width / 2, Me.Size.Height / 2)
            plrScoreDraw.Text = Convert.ToString(plrScore)
        End If

        If gameBall.Location.X > Me.Width - gameBall.Size.Width - paddlePlayer.Width Then
            compScore += 1
            gameBall.Location = New Point(Me.Size.Width / 2, Me.Size.Height / 2)
            compScoreDraw.Text = Convert.ToString(compScore)
        End If

        If compScore >= 15 Or plrScore >= 15 Then
            Dim ans As String
            Windows.Forms.Cursor.Show()
            gameTimer.Stop()
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            ans = MsgBox("Game Over! Would you like to try again?", vbYesNo)
            If (ans = vbYes) Then
                plrScoreDraw.Text = "00"
                compScoreDraw.Text = "00"
                compScore = 0
                plrScore = 0
                gameTimer.Start()
            End If
            If (ans = vbNo) Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub pongMain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Y > 28 And e.Y < Me.Height - 42 - paddlePlayer.Height Then
            paddlePlayer.Location = New Point(paddlePlayer.Location.X, e.Y)
        End If
    End Sub

    Private Sub pongMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Q And paddlePlayer.Location.Y > 35 Then
            paddlePlayer.Location = New Point(paddlePlayer.Location.X, paddlePlayer.Location.Y - 18)
        End If
        If e.KeyValue = Keys.A And paddlePlayer.Location.Y < 292 Then
            paddlePlayer.Location = New Point(paddlePlayer.Location.X, paddlePlayer.Location.Y + 18)
        End If
    End Sub

    Private Sub pongMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Windows.Forms.Cursor.Hide()

    End Sub

End Class
