Public Class frmHitungKali

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim _a As Single, _b As Single, _hasil As Single
        'Input
        _a = txtA.Text
        _b = txtB.Text

        'Proses
        _hasil = _a * _b

        'Output
        txtHasil.Text = _hasil
    End Sub

End Class