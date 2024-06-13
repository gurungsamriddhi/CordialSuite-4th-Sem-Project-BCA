

Public Class superadmin_login

    Dim usercontroller As New UserController()
    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Application.Exit()
    End Sub




    Private Sub showpw_checkbx_CheckedChanged(sender As Object, e As EventArgs) Handles showpw_checkbx.CheckedChanged
        If showpw_checkbx.Checked Then
            txtbx_adminpassword.UseSystemPasswordChar = False ' Show password
        Else
            txtbx_adminpassword.UseSystemPasswordChar = True ' Hide password
        End If
    End Sub

    Private Sub lbllink_cancel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbllink_cancel.LinkClicked
        Dim log As New Loginform()
        log.Show()
        Me.Close()
    End Sub

    Private Sub adminlogin_btn_Click(sender As Object, e As EventArgs) Handles adminlogin_btn.Click
        Dim username As String = txtbx_adminusername.Text.Trim()
        Dim password As String = txtbx_adminpassword.Text.Trim()

        If username = String.Empty OrElse password = String.Empty Then
            MessageBox.Show("Please fill out all fields", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If usercontroller.ValidateSuperAdminCredentials(username, password) Then
                Dim superadminDashboardForm As New superadmin_dashboard()
                superadminDashboardForm.Show()
                superadminDashboardForm.lbl_superadminname.Text = username
                Me.Close()
            Else
                ' Superadmin login failed, show error message or handle accordingly
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

End Class