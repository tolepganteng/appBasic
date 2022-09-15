Public Class frmRepeat_Kelipatan
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim _a As Single, _b As Single, _hasil As String

        'Input
        _a = txtA.Text
        _b = txtB.Text

        'Proses
        For i = 1 To _b
            _hasil = _hasil & " " & _a * i
        Next

        'Output
        txtHasil.Text = _hasil

    End Sub
End Class