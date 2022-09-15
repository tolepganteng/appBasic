Public Class frmHitungBagi

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim _a As Single, _b As Single, _hasil As Single
        'Input
        _a = txtA.Text
        _b = txtB.Text

        'Proses
        _hasil = _a / _b

        'Output
        txtHasil.Text = _hasil
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub frmHitungBagi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class