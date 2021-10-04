Public Class quick_scan
    Private Sub quick_scan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - 507, Screen.PrimaryScreen.WorkingArea.Height - 209)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = True
        Timer1.Interval = 100

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        ProgressBar2.Increment(1)
        If ProgressBar1.Value = 100 And ProgressBar2.Value = 100 Then
            Timer1.Stop()
            MsgBox("Scan Completed Successuflly!", MsgBoxStyle.Information, "Completed")
            ProgressBar1.Value = 0
            ProgressBar2.Value = 0

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Enabled = True
        Timer1.Interval = 500
    End Sub
End Class