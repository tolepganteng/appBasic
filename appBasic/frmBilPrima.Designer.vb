<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBilPrima
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
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.LblHasil = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtHasil = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(326, 52)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(90, 32)
        Me.btnTutup.TabIndex = 39
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(326, 12)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(90, 31)
        Me.btnHitung.TabIndex = 38
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'LblHasil
        '
        Me.LblHasil.AutoSize = True
        Me.LblHasil.Location = New System.Drawing.Point(17, 71)
        Me.LblHasil.Name = "LblHasil"
        Me.LblHasil.Size = New System.Drawing.Size(30, 13)
        Me.LblHasil.TabIndex = 37
        Me.LblHasil.Text = "Hasil"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(17, 45)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(27, 13)
        Me.lblMax.TabIndex = 36
        Me.lblMax.Text = "Max"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(17, 15)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(24, 13)
        Me.lblMin.TabIndex = 35
        Me.lblMin.Text = "Min"
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(53, 38)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(210, 20)
        Me.txtB.TabIndex = 34
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(53, 12)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(210, 20)
        Me.txtA.TabIndex = 32
        '
        'txtHasil
        '
        Me.txtHasil.Location = New System.Drawing.Point(53, 71)
        Me.txtHasil.Multiline = True
        Me.txtHasil.Name = "txtHasil"
        Me.txtHasil.Size = New System.Drawing.Size(219, 89)
        Me.txtHasil.TabIndex = 40
        '
        'frmBilPrima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 286)
        Me.Controls.Add(Me.txtHasil)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.LblHasil)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Name = "frmBilPrima"
        Me.Text = "frmBilPrima"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents btnHitung As System.Windows.Forms.Button
    Friend WithEvents LblHasil As System.Windows.Forms.Label
    Friend WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents txtHasil As System.Windows.Forms.TextBox
End Class
