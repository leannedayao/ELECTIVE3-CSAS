Public Class Index
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Me.Hide()
        Dim Login As New Login
        Login.Show()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_MouseHover(sender As Object, e As EventArgs) Handles CloseButton.MouseHover
        CloseButton.BackColor = Color.FromArgb(246, 197, 164)
    End Sub
End Class
