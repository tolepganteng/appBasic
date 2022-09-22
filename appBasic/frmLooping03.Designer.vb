<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLooping03
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
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblFinish = New System.Windows.Forms.Label()
        Me.lblCheat = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(32, 23)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(41, 13)
        Me.lblA.TabIndex = 0
        Me.lblA.Text = "mobil A"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(32, 54)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(41, 13)
        Me.lblB.TabIndex = 1
        Me.lblB.Text = "mobil B"
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Location = New System.Drawing.Point(32, 84)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(41, 13)
        Me.lblC.TabIndex = 2
        Me.lblC.Text = "mobil C"
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Location = New System.Drawing.Point(32, 117)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(42, 13)
        Me.lblD.TabIndex = 3
        Me.lblD.Text = "mobil D"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(35, 198)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 35)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(132, 198)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 35)
        Me.btnStop.TabIndex = 5
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(231, 198)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 35)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        '
        'lblFinish
        '
        Me.lblFinish.AutoSize = True
        Me.lblFinish.Location = New System.Drawing.Point(460, 9)
        Me.lblFinish.Name = "lblFinish"
        Me.lblFinish.Size = New System.Drawing.Size(34, 13)
        Me.lblFinish.TabIndex = 7
        Me.lblFinish.Text = "Finish"
        '
        'lblCheat
        '
        Me.lblCheat.AutoSize = True
        Me.lblCheat.Location = New System.Drawing.Point(460, 261)
        Me.lblCheat.Name = "lblCheat"
        Me.lblCheat.Size = New System.Drawing.Size(35, 13)
        Me.lblCheat.TabIndex = 8
        Me.lblCheat.Text = "Cheat"
        '
        'frmLooping03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 295)
        Me.Controls.Add(Me.lblCheat)
        Me.Controls.Add(Me.lblFinish)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblD)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Name = "frmLooping03"
        Me.Text = "frmLooping03"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents lblC As System.Windows.Forms.Label
    Friend WithEvents lblD As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lblFinish As System.Windows.Forms.Label
    Friend WithEvents lblCheat As System.Windows.Forms.Label
End Class
