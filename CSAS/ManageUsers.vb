Public Class ManageUsers
    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        Me.Hide()
        Dim ManageUsers As New AdminHome
        AdminHome.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles ManageUser.Click
        Me.Hide()
        Dim ManageUsers As New ManageUsers
        ManageUsers.Show()
    End Sub

    Private Sub AddUser_Click(sender As Object, e As EventArgs) Handles AddUser.Click
        Me.Hide()
        Dim ManageUsers As New AddUser
        AddUser.Show()
    End Sub
End Class