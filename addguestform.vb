
Public Class Addguestform

    Private Sub Guestlistbtn_Click(sender As Object, e As EventArgs) Handles guestlistbtn.Click

    End Sub


    Public Sub Switchpanel(ByVal panel As Form)

        pnlguestlist.Controls.Clear()
        panel.TopLevel = False
        pnlguestlist.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub Newguestbtn_Click(sender As Object, e As EventArgs) Handles newguest_btn.Click
        Switchpanel(newguest_form)
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
End Class