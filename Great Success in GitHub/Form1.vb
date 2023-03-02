Public Class Form1
    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        lblOutput.Text = "First Line before update"

        lblOutput.Text = "Second Line... update for me."
    End Sub
End Class
