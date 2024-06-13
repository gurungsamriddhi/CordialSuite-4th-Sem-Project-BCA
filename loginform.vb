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
        Dim loginusername = txtbxusername.Text.Trim()
        Dim loginpassword = txtbxpassword.Text.Trim()

        ' Check if either the username or password fields are empty
        If loginusername = String.Empty OrElse loginpassword = String.Empty Then
            MessageBox.Show("Please fill out all fields.", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim userType = usercontroller.authenticateuser(loginusername, loginpassword)

            If userType = "Admin" Then
                Dim admindashboard As New AdminDashboard
                admindashboard.Show()
                admindashboard.Labeladminname.Text = loginusername
                Me.Close()
            ElseIf userType = "User" Then
                Dim userdashboard As New userdashboard
                userdashboard.Show()
                userdashboard.Labelusername.Text = loginusername
                Me.Close()
            Else
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
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
