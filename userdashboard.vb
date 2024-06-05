

Imports System.Diagnostics.Eventing.Reader

Public Class Userdashboard

    Public Sub Switchpanel(ByVal panel As Form)

        pnlhotel_status.Controls.Clear()
        panel.TopLevel = False
        pnlhotel_status.Controls.Add(panel)
        panel.Show()



    End Sub



    Private Sub Addguestbtn_Click(sender As Object, e As EventArgs) Handles addguestbtn.Click
        Switchpanel(addguestform)
    End Sub



    Private Sub Roomsbtn_Click(sender As Object, e As EventArgs) Handles roomsbtn.Click
        Switchpanel(rooms)
    End Sub

    Private Sub Checkinbtn_Click(sender As Object, e As EventArgs) Handles checkinbtn.Click
        Switchpanel(checkin)
    End Sub
    Private Sub Checkoutbtn_Click(sender As Object, e As EventArgs) Handles checkoutbtn.Click
        Switchpanel(checkout)
    End Sub
    Private Sub Billingbtn_Click(sender As Object, e As EventArgs) Handles billingbtn.Click
        Switchpanel(billing)
    End Sub

    Private Sub Statusbtn_Click(sender As Object, e As EventArgs) Handles statusbtn.Click


    End Sub

    Private Sub Userdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Closebtn_Click(sender As Object, e As EventArgs)
        Dispose()
        End
    End Sub
<<<<<<< HEAD

=======
    Private Sub Logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        ' Display a MessageBox asking the user if they want to logout
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
>>>>>>> master

End Class