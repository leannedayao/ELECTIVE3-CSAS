Public Class AdminHome
    Private Sub SchoolButton_Click(sender As Object, e As EventArgs) Handles SchoolButton.Click
        Me.Hide()
        Dim SignUp As New School
        School.Show()
    End Sub

    Private Sub CommunityButton_Click(sender As Object, e As EventArgs) Handles CommunityButton.Click
        Me.Hide()
        Dim SignUp As New Community
        Community.Show()
    End Sub

    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        Me.Hide()
        Dim SignUp As New Login
        Login.Show()
    End Sub

    Private Sub ManageUsers_MouseClick(sender As Object, e As MouseEventArgs) Handles ManageUsers.MouseClick
        Me.Hide()
        Dim SignUp As New ManageUsers
        ManageUsers.Show()
    End Sub
End Class