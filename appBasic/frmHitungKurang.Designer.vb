<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHitungKurang
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
        Me.Tutup = New System.Windows.Forms.Button()
        Me.Hitung = New System.Windows.Forms.Button()
        Me.Hasil = New System.Windows.Forms.Label()
        Me.B = New System.Windows.Forms.Label()
        Me.A = New System.Windows.Forms.Label()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtHasil = New System.Windows.Forms.TextBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Tutup
        '
        Me.Tutup.Location = New System.Drawing.Point(332, 63)
        Me.Tutup.Name = "Tutup"
        Me.Tutup.Size = New System.Drawing.Size(90, 32)
        Me.Tutup.TabIndex = 15
        Me.Tutup.Text = "Tutup"
        Me.Tutup.UseVisualStyleBackColor = True
        '
        'Hitung
        '
        Me.Hitung.Location = New System.Drawing.Point(332, 23)
        Me.Hitung.Name = "Hitung"
        Me.Hitung.Size = New System.Drawing.Size(90, 31)
        Me.Hitung.TabIndex = 14
        Me.Hitung.Text = "Hitung"
        Me.Hitung.UseVisualStyleBackColor = True
        '
        'Hasil
        '
        Me.Hasil.AutoSize = True
        Me.Hasil.Location = New System.Drawing.Point(23, 82)
        Me.Hasil.Name = "Hasil"
        Me.Hasil.Size = New System.Drawing.Size(30, 13)
        Me.Hasil.TabIndex = 13
        Me.Hasil.Text = "Hasil"
        '
        'B
        '
        Me.B.AutoSize = True
        Me.B.Location = New System.Drawing.Point(23, 56)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(14, 13)
        Me.B.TabIndex = 12
        Me.B.Text = "B"
        '
        'A
        '
        Me.A.AutoSize = True
        Me.A.Location = New System.Drawing.Point(23, 26)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(14, 13)
        Me.A.TabIndex = 11
        Me.A.Text = "A"
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(68, 49)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(210, 20)
        Me.txtB.TabIndex = 10
        '
        'txtHasil
        '
        Me.txtHasil.Location = New System.Drawing.Point(68, 75)
        Me.txtHasil.Name = "txtHasil"
        Me.txtHasil.Size = New System.Drawing.Size(210, 20)
        Me.txtHasil.TabIndex = 9
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(68, 23)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(210, 20)
        Me.txtA.TabIndex = 8
        '
        'frmHitungKurang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 261)
        Me.Controls.Add(Me.Tutup)
        Me.Controls.Add(Me.Hitung)
        Me.Controls.Add(Me.Hasil)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.A)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtHasil)
        Me.Controls.Add(Me.txtA)
        Me.Name = "frmHitungKurang"
        Me.Text = "frmHitungKurang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tutup As System.Windows.Forms.Button
    Friend WithEvents Hitung As System.Windows.Forms.Button
    Friend WithEvents Hasil As System.Windows.Forms.Label
    Friend WithEvents B As System.Windows.Forms.Label
    Friend WithEvents A As System.Windows.Forms.Label
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtHasil As System.Windows.Forms.TextBox
    Friend WithEvents txtA As System.Windows.Forms.TextBox
End Class
