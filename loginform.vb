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
                Me.Hide()
                Dim admindashboard As New Admin
                admindashboard.Show()
                admindashboard.Labeladminname.Text = loginusername

            ElseIf userType = "User" Then
                Me.Hide()
                Dim userdashboard As New usersmodel
                userdashboard.Show()
                userdashboard.Labelusername.Text = loginusername

            Else
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub


    Private Sub closebtn_Click_1(sender As Object, e As EventArgs) Handles closebtn.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub admin_btn_Click(sender As Object, e As EventArgs) Handles admin_btn.Click

        Dim superadminlogin As New superadmin_login()
        superadminlogin.Show()
        Me.Hide()
    End Sub

    Private Sub minimise_btn_Click(sender As Object, e As EventArgs) Handles minimise_btn.Click
        Me.WindowState = FormWindowState.Minimized


    End Sub
End Class
