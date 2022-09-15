Public Class frmHitungKurang

    Private Sub Hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hitung.Click
        Dim _a As Single, _b As Single, _hasil As Single
        'Input
        _a = txtA.Text
        _b = txtB.Text

        'Proses
        _hasil = _a - _b

        'Output
        txtHasil.Text = _Hasil
    End Sub

    Private Sub frmHitungKurang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtA.TextChanged

    End Sub

    Private Sub txtHasil_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHasil.TextChanged

    End Sub

    Private Sub txtB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtB.TextChanged

    End Sub

    Private Sub A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A.Click

    End Sub

    Private Sub B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B.Click

    End Sub

    Private Sub Hasil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hasil.Click

    End Sub

    Private Sub Tutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tutup.Click

    End Sub
End Class