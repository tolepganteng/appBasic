Public Class frmHitungTambah
   
    Private Sub Hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hitung.Click
        Dim _a As Single, _b As Single, _hasil As Single

        'Input
        _a = txtA.Text
        _b = txtB.Text

        'Proses
        _hasil = _a + _b

        'Output
        txtHasil.Text = _Hasil

    End Sub


    Private Sub Tutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tutup.Click
        gA = txtA.Text
        gB = txtB.Text
        Close()
    End Sub
End Class