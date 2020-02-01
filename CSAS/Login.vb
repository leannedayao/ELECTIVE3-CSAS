Public Class Login
    Private Sub SignUpNow_Click(sender As Object, e As EventArgs) Handles SignUpNow.Click
        Me.Hide()
        Dim SignUp As New SignUp
        SignUp.Show()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Me.Hide()
        Dim SignUp As New AdminHome
        AdminHome.Show()
    End Sub
End Class