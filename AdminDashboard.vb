Public Class AdminDashboard
    Public Sub Switchpanel(ByVal panel As Form)

        Pnl_diffpanel.Controls.Clear()
        panel.TopLevel = False
        Pnl_diffpanel.Controls.Add(panel)
        panel.Show()
    End Sub



    Private Sub statusbtn_Click(sender As Object, e As EventArgs) Handles statusbtn.Click
        Switchpanel(hotel_statusaadmin)
    End Sub

    Private Sub viewguestbtn_Click(sender As Object, e As EventArgs) Handles viewguestbtn.Click
        Switchpanel(ViewGuest)
    End Sub

    Private Sub viewempbtn_Click(sender As Object, e As EventArgs) Handles viewempbtn.Click
        Switchpanel(Viewemployee)
    End Sub

    Private Sub roomsbtn_Click(sender As Object, e As EventArgs) Handles roomsbtn.Click
        Switchpanel(Updateroom)
    End Sub

    Private Sub transactionbtn_Click(sender As Object, e As EventArgs) Handles transactionbtn.Click
        Switchpanel(Revenue)
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





    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub close_Btn_Click(sender As Object, e As EventArgs) Handles close_Btn.Click
        Application.Exit()

    End Sub
End Class