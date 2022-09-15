Public Class Form1
    Private Sub HitungToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HitungToolStripMenuItem.Click
        frmHitungTambah.Show()
    End Sub

    Private Sub KurangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim a As New frmHitungKurang

        a.Show()
    End Sub

    Private Sub KaliToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim a As New frmHitungKali
        a.Show()
    End Sub

    Private Sub BagiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim a As New frmHitungBagi
        a.Show()
    End Sub

    Private Sub TerbesarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TerbesarToolStripMenuItem.Click
        Dim a As New frmIF_terbesar
        a.Show()
    End Sub

    Private Sub KelipatanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KelipatanToolStripMenuItem.Click
        Dim a As New frmRepeat_Kelipatan
        a.Show()
    End Sub
End Class
