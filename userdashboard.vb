

Public Class Userdashboard

    Public Sub Switchpanel(ByVal panel As Form)

        diffformpanel.Controls.Clear()
        panel.TopLevel = False
        diffformpanel.Controls.Add(panel)
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

    Private Sub statusbtn_Click(sender As Object, e As EventArgs) Handles statusbtn.Click

    End Sub

    Private Sub userdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Dispose()
        End
    End Sub
    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Me.Close()
        Loginform.Show()
        Loginform.txtbxusername.Clear()
        Loginform.txtbxpassword.Clear()
    End Sub
End Class