Public Class Loginform
    Dim usercontroller As New UserController()
    Private Sub Loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Dispose()
        End
    End Sub

    Private Sub Linkregister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Linktoregister.LinkClicked
        Dim register As New Registerform
        Registerform.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBoxshowpw_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxshowpw.CheckedChanged
        If CheckBoxshowpw.Checked Then
            txtbxpassword.UseSystemPasswordChar = False ' Show password
        Else
            txtbxpassword.UseSystemPasswordChar = True ' Hide password
        End If
    End Sub

    Private Sub Linkforgotpw_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Linkforgotpw.LinkClicked

    End Sub

    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        Dim loginusername As String = txtbxusername.Text.Trim()
        Dim loginpassword As String = txtbxpassword.Text.Trim()

        Dim userType As String = usercontroller.authenticateuser(loginusername, loginpassword)

        If userType = "Admin" Then
            Dim admindashboard As New AdminDashboard()
            admindashboard.Show()
            Me.Hide()
        ElseIf userType = "User" Then
            Dim userdashboard As New userdashboard()
            userdashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


End Class
