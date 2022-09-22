Public Class frmLooping03
    Dim a As Integer = 1
    Dim b As System.Random = New System.Random
    Dim a1 As Integer, a2 As Integer, a3 As Integer, a4 As Integer
    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Timer1.Enabled = False
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Timer1.Enabled = True
        a1 = 10
        a2 = 20
        a3 = 15
        a4 = 13
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblA.Left = lblA.Left + b.Next(a, a1)
        lblB.Left = lblB.Left + b.Next(a, a2)
        lblC.Left = lblC.Left + b.Next(a, a3)
        lblD.Left = lblD.Left + b.Next(a, a4)
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Timer1.Enabled = False
        lblA.Left = 36
        lblB.Left = 36
        lblC.Left = 36
        lblD.Left = 36
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If lblA.Left + lblA.Width >= lblFinish.Left Or _
            lblB.Left + lblB.Width >= lblFinish.Left Or _
            lblC.Left + lblC.Width >= lblFinish.Left Or _
            lblD.Left + lblD.Width >= lblFinish.Left Then
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub lblCheat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCheat.Click
        a1 = 40
    End Sub

    Private Sub lblA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblA.Click

    End Sub
End Class