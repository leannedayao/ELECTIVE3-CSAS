Public Class Community
    Private Sub CancellButton_Click(sender As Object, e As EventArgs) Handles CancellButton.Click
        Me.Hide()
        Dim SignUp As New AdminHome
        AdminHome.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim SignUp As New AdminHome
        AdminHome.Show()
    End Sub
End Class