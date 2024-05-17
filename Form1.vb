Public Class Form1
    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged
        Dim username, password As String
        username = txtuser.Text
        password = txtpassword.Text
        If (username.Equals("admin") And password.Equals("admin")) Then
            MessageBox.Show("Login Success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class