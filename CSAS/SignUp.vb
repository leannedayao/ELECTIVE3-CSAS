Public Class SignUp
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub FNtext_MouseDown(sender As Object, e As MouseEventArgs) Handles FNtext.MouseDown
        FNtext.Text = ""
    End Sub

    Private Sub LNtext_MouseDown(sender As Object, e As MouseEventArgs) Handles LNtext.MouseDown
        LNtext.Text = ""
    End Sub

    Private Sub PhoneNum(sender As Object, e As MouseEventArgs) Handles NumText.MouseDown
        NumText.Text = ""
    End Sub

    Private Sub Uname(sender As Object, e As MouseEventArgs) Handles UNtext.MouseDown
        UNtext.Text = ""
    End Sub

    Private Sub NewPass(sender As Object, e As MouseEventArgs) Handles PasswordText.MouseDown
        PasswordText.Text = ""
    End Sub

End Class