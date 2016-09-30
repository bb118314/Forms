Public Class MainForm

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnDisplayForm_Click(sender As Object, e As EventArgs) Handles btnDisplayForm.Click
        ' Display a messageform
        Dim frmMessage As New MessageForm
        ' Modal style
        frmMessage.ShowDialog()
    End Sub
End Class
