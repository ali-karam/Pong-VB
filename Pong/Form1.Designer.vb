<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pongMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.paddleComputer = New System.Windows.Forms.PictureBox()
        Me.gameBall = New System.Windows.Forms.PictureBox()
        Me.paddlePlayer = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.compScoreDraw = New System.Windows.Forms.Label()
        Me.plrScoreDraw = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.paddleComputer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gameBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paddlePlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'paddleComputer
        '
        Me.paddleComputer.BackColor = System.Drawing.Color.Maroon
        Me.paddleComputer.Location = New System.Drawing.Point(604, 161)
        Me.paddleComputer.Name = "paddleComputer"
        Me.paddleComputer.Size = New System.Drawing.Size(16, 128)
        Me.paddleComputer.TabIndex = 0
        Me.paddleComputer.TabStop = False
        '
        'gameBall
        '
        Me.gameBall.BackColor = System.Drawing.Color.Maroon
        Me.gameBall.Location = New System.Drawing.Point(310, 215)
        Me.gameBall.Name = "gameBall"
        Me.gameBall.Size = New System.Drawing.Size(20, 20)
        Me.gameBall.TabIndex = 1
        Me.gameBall.TabStop = False
        '
        'paddlePlayer
        '
        Me.paddlePlayer.BackColor = System.Drawing.Color.Maroon
        Me.paddlePlayer.Location = New System.Drawing.Point(3, 161)
        Me.paddlePlayer.Name = "paddlePlayer"
        Me.paddlePlayer.Size = New System.Drawing.Size(16, 128)
        Me.paddlePlayer.TabIndex = 2
        Me.paddlePlayer.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(347, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 3
        '
        'gameTimer
        '
        Me.gameTimer.Enabled = True
        Me.gameTimer.Interval = 20
        '
        'compScoreDraw
        '
        Me.compScoreDraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compScoreDraw.Location = New System.Drawing.Point(345, -3)
        Me.compScoreDraw.Name = "compScoreDraw"
        Me.compScoreDraw.Size = New System.Drawing.Size(46, 26)
        Me.compScoreDraw.TabIndex = 5
        Me.compScoreDraw.Text = "00"
        Me.compScoreDraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'plrScoreDraw
        '
        Me.plrScoreDraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plrScoreDraw.Location = New System.Drawing.Point(231, -3)
        Me.plrScoreDraw.Name = "plrScoreDraw"
        Me.plrScoreDraw.Size = New System.Drawing.Size(46, 26)
        Me.plrScoreDraw.TabIndex = 7
        Me.plrScoreDraw.Text = "00"
        Me.plrScoreDraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(3, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(617, 2)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(3, 437)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(617, 2)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Location = New System.Drawing.Point(310, 26)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(2, 410)
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'pongMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.plrScoreDraw)
        Me.Controls.Add(Me.compScoreDraw)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.paddlePlayer)
        Me.Controls.Add(Me.gameBall)
        Me.Controls.Add(Me.paddleComputer)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "pongMain"
        Me.Text = "Pong"
        CType(Me.paddleComputer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gameBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paddlePlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents paddleComputer As PictureBox
    Friend WithEvents gameBall As PictureBox
    Friend WithEvents paddlePlayer As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gameTimer As Timer
    Friend WithEvents compScoreDraw As Label
    Friend WithEvents plrScoreDraw As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
