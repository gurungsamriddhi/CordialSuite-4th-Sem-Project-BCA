Public Class superadmin_dashboard
    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Register_btn_Click(sender As Object, e As EventArgs)
        Dim register As New Registerform()               'shows registerform
        register.Show
        Hide


    End Sub

    Private Sub Login_btn_Click(sender As Object, e As EventArgs)
        Dim login As New Loginform() 'shows loginform
        login.Show
        Hide
    End Sub

    Private Sub Closebtn_Click(sender As Object, e As EventArgs)
        Application.Exit()
        'closes the form when close button is clicked
        End
    End Sub
    Public Sub Switchpanel(ByVal panel As Form)

        Pnl_diffform.Controls.Clear()
        panel.TopLevel = False
        Pnl_diffform.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub statusbtn_Click(sender As Object, e As EventArgs) Handles statusbtn.Click
        Switchpanel(Registerform)
    End Sub

    Private Sub closebtn_Click_1(sender As Object, e As EventArgs) Handles closebtn.Click
        Application.Exit()

    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's choice in the MessageBox
        If result = DialogResult.Yes Then
            ' Close the current form (Userdashboard)
            Me.Close()

            ' Show the Loginform and clear text boxes
            Loginform.Show()
            Loginform.txtbxusername.Clear()
            Loginform.txtbxpassword.Clear()
        End If
    End Sub

    Private Sub admindashb_btn_Click(sender As Object, e As EventArgs) Handles admindashb_btn.Click
        Dim admindashboardform As New AdminDashboard
        admindashboardform.Show()
        Me.Hide()
    End Sub

    Private Sub lbl_superadminname_Click(sender As Object, e As EventArgs) Handles lbl_superadminname.Click

    End Sub
End Class