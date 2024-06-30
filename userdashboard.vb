Public Class usersmodel

    Public Sub Switchpanel(ByVal panel As Form)

        Pnl_userdashboard.Controls.Clear()
        panel.TopLevel = False
        Pnl_userdashboard.Controls.Add(panel)
        panel.Show()
    End Sub


    Private Sub Logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        ' Display a MessageBox asking the user if they want to logout
        Dim result As DialogResult = MessageBox.Show("Do you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Close the current form (Userdashboard)
            Me.Close()

            ' Show the Loginform and clear text boxes
            Loginform.Show()
            Loginform.txtbxusername.Clear()
            Loginform.txtbxpassword.Clear()
        End If
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub dashboard_btn_Click(sender As Object, e As EventArgs) Handles dashboard_btn.Click

        Dim userDashboard As New userdashboardform()
        Switchpanel(userDashboard)

    End Sub

    Private Sub guest_btn_Click(sender As Object, e As EventArgs) Handles guest_btn.Click
        Switchpanel(Guestform)
    End Sub

    Private Sub checkin_btn_Click(sender As Object, e As EventArgs) Handles checkin_btn.Click
        Switchpanel(Reservation)
    End Sub

    Private Sub rooms_btn_Click(sender As Object, e As EventArgs) Handles rooms_btn.Click
        Switchpanel(Viewroomsinfo)
    End Sub

    Private Sub checkout_btn_Click(sender As Object, e As EventArgs) Handles checkout_btn.Click
        Switchpanel(GuestCheckout)
    End Sub

    Private Sub billing_btn_Click(sender As Object, e As EventArgs) Handles billing_btn.Click
        Switchpanel(billing)
    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userDashboard As New userdashboardform()
        Switchpanel(userDashboard)
    End Sub

    Private Sub minimise_btn_Click(sender As Object, e As EventArgs) Handles minimise_btn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class