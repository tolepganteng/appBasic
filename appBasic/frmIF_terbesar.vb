Public Class frmIF_terbesar

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim _a As Single, _b As Single, _hasil As Single
        'Input
        _a = txtA.Text
        _b = txtB.Text

        'Proses
        If _a > _b Then
            _hasil = _b
        Else
            _hasil = _b
        End If

        'Output
        txtHasil.Text = _hasil
    End Sub
End Class