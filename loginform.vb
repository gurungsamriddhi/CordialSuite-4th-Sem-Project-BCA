Public Class Loginform
    Dim usercontroller As New UserController()
    Private Sub Loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBoxshowpw_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxshowpw.CheckedChanged
        If CheckBoxshowpw.Checked Then
            txtbxpassword.UseSystemPasswordChar = False ' Show password
        Else
            txtbxpassword.UseSystemPasswordChar = True ' Hide password
        End If
    End Sub

    Private Sub Linkforgotpw_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        Dim loginusername = txtbxusername.Text.Trim
        Dim loginpassword = txtbxpassword.Text.Trim

        Dim userType = usercontroller.authenticateuser(loginusername, loginpassword)

        If userType = "Admin" Then
            Dim admindashboard As New AdminDashboard
            admindashboard.Show()
            admindashboard.Labeladminname.Text = loginusername



            Hide()
        ElseIf userType = "User" Then
            Dim userdashboard As New userdashboard

            userdashboard.Show()
            userdashboard.Labelusername.Text = loginusername
            Hide()
        Else
            MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub closebtn_Click_1(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Dispose()
        End
    End Sub

    Private Sub admin_btn_Click(sender As Object, e As EventArgs) Handles admin_btn.Click
        Dim superadminlogin As New superadmin_login()
        superadminlogin.Show()
        Me.Hide()
    End Sub
End Class
