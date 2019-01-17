<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Nansen = New System.Windows.Forms.PictureBox()
        Me.Ball0 = New System.Windows.Forms.PictureBox()
        Me.Ball3 = New System.Windows.Forms.PictureBox()
        Me.Ball2 = New System.Windows.Forms.PictureBox()
        Me.Ball1 = New System.Windows.Forms.PictureBox()
        Me.Ladder7 = New System.Windows.Forms.PictureBox()
        Me.Ladder6 = New System.Windows.Forms.PictureBox()
        Me.Ladder3 = New System.Windows.Forms.PictureBox()
        Me.Ladder0 = New System.Windows.Forms.PictureBox()
        Me.Ladder1 = New System.Windows.Forms.PictureBox()
        Me.Ladder2 = New System.Windows.Forms.PictureBox()
        Me.Ladder4 = New System.Windows.Forms.PictureBox()
        Me.Ladder5 = New System.Windows.Forms.PictureBox()
        Me.Background = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MainPanel.SuspendLayout()
        CType(Me.Nansen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ball0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ball3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ball2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ball1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ladder7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ladder6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ladder3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ladder0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ladder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ladder2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ladder4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ladder5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MainPanel.Controls.Add(Me.Nansen)
        Me.MainPanel.Controls.Add(Me.Ball0)
        Me.MainPanel.Controls.Add(Me.Ball3)
        Me.MainPanel.Controls.Add(Me.Ball2)
        Me.MainPanel.Controls.Add(Me.Ball1)
        Me.MainPanel.Controls.Add(Me.Ladder7)
        Me.MainPanel.Controls.Add(Me.Ladder6)
        Me.MainPanel.Controls.Add(Me.Ladder3)
        Me.MainPanel.Controls.Add(Me.Ladder0)
        Me.MainPanel.Controls.Add(Me.Ladder1)
        Me.MainPanel.Controls.Add(Me.Ladder2)
        Me.MainPanel.Controls.Add(Me.Ladder4)
        Me.MainPanel.Controls.Add(Me.Ladder5)
        Me.MainPanel.Controls.Add(Me.Background)
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(800, 600)
        Me.MainPanel.TabIndex = 0
        '
        'Nansen
        '
        Me.Nansen.BackColor = System.Drawing.Color.Transparent
        Me.Nansen.Image = CType(resources.GetObject("Nansen.Image"), System.Drawing.Image)
        Me.Nansen.Location = New System.Drawing.Point(104, 431)
        Me.Nansen.Name = "Nansen"
        Me.Nansen.Size = New System.Drawing.Size(24, 34)
        Me.Nansen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Nansen.TabIndex = 0
        Me.Nansen.TabStop = False
        '
        'Ball0
        '
        Me.Ball0.BackColor = System.Drawing.Color.Transparent
        Me.Ball0.Image = CType(resources.GetObject("Ball0.Image"), System.Drawing.Image)
        Me.Ball0.Location = New System.Drawing.Point(251, 17)
        Me.Ball0.Name = "Ball0"
        Me.Ball0.Size = New System.Drawing.Size(24, 20)
        Me.Ball0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Ball0.TabIndex = 13
        Me.Ball0.TabStop = False
        '
        'Ball3
        '
        Me.Ball3.BackColor = System.Drawing.Color.Transparent
        Me.Ball3.Image = CType(resources.GetObject("Ball3.Image"), System.Drawing.Image)
        Me.Ball3.Location = New System.Drawing.Point(412, 75)
        Me.Ball3.Name = "Ball3"
        Me.Ball3.Size = New System.Drawing.Size(24, 20)
        Me.Ball3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Ball3.TabIndex = 12
        Me.Ball3.TabStop = False
        '
        'Ball2
        '
        Me.Ball2.BackColor = System.Drawing.Color.Transparent
        Me.Ball2.Image = CType(resources.GetObject("Ball2.Image"), System.Drawing.Image)
        Me.Ball2.Location = New System.Drawing.Point(368, 75)
        Me.Ball2.Name = "Ball2"
        Me.Ball2.Size = New System.Drawing.Size(24, 20)
        Me.Ball2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Ball2.TabIndex = 11
        Me.Ball2.TabStop = False
        '
        'Ball1
        '
        Me.Ball1.BackColor = System.Drawing.Color.Transparent
        Me.Ball1.Image = CType(resources.GetObject("Ball1.Image"), System.Drawing.Image)
        Me.Ball1.Location = New System.Drawing.Point(327, 75)
        Me.Ball1.Name = "Ball1"
        Me.Ball1.Size = New System.Drawing.Size(24, 20)
        Me.Ball1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Ball1.TabIndex = 10
        Me.Ball1.TabStop = False
        '
        'Ladder7
        '
        Me.Ladder7.Image = CType(resources.GetObject("Ladder7.Image"), System.Drawing.Image)
        Me.Ladder7.Location = New System.Drawing.Point(176, 376)
        Me.Ladder7.Name = "Ladder7"
        Me.Ladder7.Size = New System.Drawing.Size(41, 89)
        Me.Ladder7.TabIndex = 9
        Me.Ladder7.TabStop = False
        '
        'Ladder6
        '
        Me.Ladder6.Image = CType(resources.GetObject("Ladder6.Image"), System.Drawing.Image)
        Me.Ladder6.Location = New System.Drawing.Point(453, 395)
        Me.Ladder6.Name = "Ladder6"
        Me.Ladder6.Size = New System.Drawing.Size(41, 70)
        Me.Ladder6.TabIndex = 8
        Me.Ladder6.TabStop = False
        '
        'Ladder3
        '
        Me.Ladder3.Image = CType(resources.GetObject("Ladder3.Image"), System.Drawing.Image)
        Me.Ladder3.Location = New System.Drawing.Point(470, 244)
        Me.Ladder3.Name = "Ladder3"
        Me.Ladder3.Size = New System.Drawing.Size(41, 62)
        Me.Ladder3.TabIndex = 7
        Me.Ladder3.TabStop = False
        '
        'Ladder0
        '
        Me.Ladder0.Image = CType(resources.GetObject("Ladder0.Image"), System.Drawing.Image)
        Me.Ladder0.Location = New System.Drawing.Point(271, 43)
        Me.Ladder0.Name = "Ladder0"
        Me.Ladder0.Size = New System.Drawing.Size(41, 52)
        Me.Ladder0.TabIndex = 6
        Me.Ladder0.TabStop = False
        '
        'Ladder1
        '
        Me.Ladder1.Image = CType(resources.GetObject("Ladder1.Image"), System.Drawing.Image)
        Me.Ladder1.Location = New System.Drawing.Point(453, 89)
        Me.Ladder1.Name = "Ladder1"
        Me.Ladder1.Size = New System.Drawing.Size(41, 65)
        Me.Ladder1.TabIndex = 5
        Me.Ladder1.TabStop = False
        '
        'Ladder2
        '
        Me.Ladder2.Image = CType(resources.GetObject("Ladder2.Image"), System.Drawing.Image)
        Me.Ladder2.Location = New System.Drawing.Point(368, 153)
        Me.Ladder2.Name = "Ladder2"
        Me.Ladder2.Size = New System.Drawing.Size(41, 90)
        Me.Ladder2.TabIndex = 4
        Me.Ladder2.TabStop = False
        '
        'Ladder4
        '
        Me.Ladder4.Image = CType(resources.GetObject("Ladder4.Image"), System.Drawing.Image)
        Me.Ladder4.Location = New System.Drawing.Point(143, 173)
        Me.Ladder4.Name = "Ladder4"
        Me.Ladder4.Size = New System.Drawing.Size(41, 55)
        Me.Ladder4.TabIndex = 3
        Me.Ladder4.TabStop = False
        '
        'Ladder5
        '
        Me.Ladder5.Image = CType(resources.GetObject("Ladder5.Image"), System.Drawing.Image)
        Me.Ladder5.Location = New System.Drawing.Point(310, 311)
        Me.Ladder5.Name = "Ladder5"
        Me.Ladder5.Size = New System.Drawing.Size(41, 82)
        Me.Ladder5.TabIndex = 2
        Me.Ladder5.TabStop = False
        '
        'Background
        '
        Me.Background.Image = CType(resources.GetObject("Background.Image"), System.Drawing.Image)
        Me.Background.Location = New System.Drawing.Point(0, 0)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(640, 480)
        Me.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Background.TabIndex = 1
        Me.Background.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Controls.Add(Me.MainPanel)
        Me.Name = "MainForm"
        Me.Text = "Polar Peril"
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        CType(Me.Nansen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ball0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ball3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ball2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ball1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ladder7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ladder6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ladder3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ladder0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ladder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ladder2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ladder4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ladder5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPanel As Panel
    Friend WithEvents Nansen As PictureBox
    Friend WithEvents Background As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Ladder6 As PictureBox
    Friend WithEvents Ladder3 As PictureBox
    Friend WithEvents Ladder0 As PictureBox
    Friend WithEvents Ladder1 As PictureBox
    Friend WithEvents Ladder2 As PictureBox
    Friend WithEvents Ladder4 As PictureBox
    Friend WithEvents Ladder5 As PictureBox
    Friend WithEvents Ladder7 As PictureBox
    Friend WithEvents Ball0 As PictureBox
    Friend WithEvents Ball3 As PictureBox
    Friend WithEvents Ball2 As PictureBox
    Friend WithEvents Ball1 As PictureBox
End Class
