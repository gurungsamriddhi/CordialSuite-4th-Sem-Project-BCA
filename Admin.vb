Public Class Admin
    Public Sub Switchpanel(ByVal panel As Form)

        Pnl_admindashboard.Controls.Clear()
        panel.TopLevel = False
        Pnl_admindashboard.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub viewguestbtn_Click(sender As Object, e As EventArgs) Handles viewguestbtn.Click
        Switchpanel(ViewGuestinfo)
    End Sub

    Private Sub viewempbtn_Click(sender As Object, e As EventArgs) Handles viewempbtn.Click
        Switchpanel(Viewemployee)
    End Sub

    Private Sub roomsbtn_Click(sender As Object, e As EventArgs) Handles roomsbtn.Click
        Switchpanel(AdminRoom)
    End Sub

    Private Sub transactionbtn_Click(sender As Object, e As EventArgs) Handles transactionbtn.Click
        Switchpanel(Transaction)
    End Sub


    Private Sub close_Btn_Click(sender As Object, e As EventArgs) Handles close_Btn.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub dashboard_btn_Click(sender As Object, e As EventArgs) Handles dashboard_btn.Click
        Dim adminDashboard As New admindashboardform()
        Switchpanel(adminDashboard)
    End Sub


    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adminDashboard As New admindashboardform()
        Switchpanel(adminDashboard)
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

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        Me.Hide()

        ' Show SuperAdmin dashboard form
        Dim superAdminForm As New superadmin()
        superAdminForm.Show()
    End Sub
End Class