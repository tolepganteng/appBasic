Public Class frmBilPrima
    Dim x, y As Integer
    Private Sub btnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitung.Click
        lblMin = Val(txtA.Text)
        lblMax = Val(txtB.Text)
        If txtA.Text = "" Then
            MsgBox("Batas bawah harus diisi")
        End If
        If txtB.Text = "" Then
            MsgBox("Batas atas harus diisi!")
        End If
        If ((lblMin <> 0) And (lblMax <> 0)) Then
            If lblMin <= 1 Then
                lblMin = 2
            End If
            For x = lblMin To lblMax
                z = 0
                For y = 2 To x
                    LblHasil = x Mod y
                    If LblHasil = 0 Then
                        z = z + 1
                    End If
                Next y
                If z <= 1 Then
                    List1.AddItem(x)
                    a = a + 1
                    jml = jml + x
                End If
                Label7.Caption = a
                Label8.Caption = jml
                Label9.Caption = Round(jml / a)
            Next x
        End If
    End Sub

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        Close()
    End Sub
End Class