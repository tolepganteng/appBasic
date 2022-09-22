Public Class frmLooping02
    Dim kecepatan As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbJam.Text = Format(DateTime.Now, "hh:mm:ss")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = Not Timer1.Enabled
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Button1.Left = Button1.Left + kecepatan
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        kecepatan = kecepatan + 2
        Timer2.Interval = 100
    End Sub
End Class