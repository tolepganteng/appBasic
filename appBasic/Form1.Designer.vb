<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.HitungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KurangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KaliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BagiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecisionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerbesarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KelipatanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerbesarKecilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(601, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HitungToolStripMenuItem, Me.DecisionToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(601, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'HitungToolStripMenuItem
        '
        Me.HitungToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahToolStripMenuItem, Me.KurangToolStripMenuItem, Me.KaliToolStripMenuItem, Me.BagiToolStripMenuItem})
        Me.HitungToolStripMenuItem.Name = "HitungToolStripMenuItem"
        Me.HitungToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.HitungToolStripMenuItem.Text = "Hitung"
        '
        'TambahToolStripMenuItem
        '
        Me.TambahToolStripMenuItem.Name = "TambahToolStripMenuItem"
        Me.TambahToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.TambahToolStripMenuItem.Text = "Tambah"
        '
        'KurangToolStripMenuItem
        '
        Me.KurangToolStripMenuItem.Name = "KurangToolStripMenuItem"
        Me.KurangToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.KurangToolStripMenuItem.Text = "Kurang"
        '
        'KaliToolStripMenuItem
        '
        Me.KaliToolStripMenuItem.Name = "KaliToolStripMenuItem"
        Me.KaliToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.KaliToolStripMenuItem.Text = "Kali"
        '
        'BagiToolStripMenuItem
        '
        Me.BagiToolStripMenuItem.Name = "BagiToolStripMenuItem"
        Me.BagiToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.BagiToolStripMenuItem.Text = "Bagi"
        '
        'DecisionToolStripMenuItem
        '
        Me.DecisionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TerbesarToolStripMenuItem, Me.KelipatanToolStripMenuItem, Me.TerbesarKecilToolStripMenuItem})
        Me.DecisionToolStripMenuItem.Name = "DecisionToolStripMenuItem"
        Me.DecisionToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.DecisionToolStripMenuItem.Text = "Decision"
        '
        'TerbesarToolStripMenuItem
        '
        Me.TerbesarToolStripMenuItem.Name = "TerbesarToolStripMenuItem"
        Me.TerbesarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TerbesarToolStripMenuItem.Text = "Terbesar"
        '
        'KelipatanToolStripMenuItem
        '
        Me.KelipatanToolStripMenuItem.Name = "KelipatanToolStripMenuItem"
        Me.KelipatanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.KelipatanToolStripMenuItem.Text = "Kelipatan"
        '
        'TerbesarKecilToolStripMenuItem
        '
        Me.TerbesarKecilToolStripMenuItem.Name = "TerbesarKecilToolStripMenuItem"
        Me.TerbesarKecilToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TerbesarKecilToolStripMenuItem.Text = "Terbesar&Kecil"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 292)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents HitungToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KurangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KaliToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BagiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecisionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TerbesarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KelipatanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TerbesarKecilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
