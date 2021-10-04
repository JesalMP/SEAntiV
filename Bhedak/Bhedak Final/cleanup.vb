Public Class cleanup
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        FileSystem.Kill("C:\Users\Jesal\AppData\Local\Temp\*.*")
    End Sub
End Class