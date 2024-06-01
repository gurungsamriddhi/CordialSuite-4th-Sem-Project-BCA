

Public Class Userdashboard

    Public Sub Switchpanel(ByVal panel As Form)
        diffformpanel.Controls.Clear()
        panel.TopLevel = False
        diffformpanel.Controls.Add(panel)
        panel.Show()
    End Sub



    Private Sub Addguestbtn_Click(sender As Object, e As EventArgs) Handles addguestbtn.Click
        switchpanel(addguestform)
    End Sub



    Private Sub Roomsbtn_Click(sender As Object, e As EventArgs) Handles roomsbtn.Click
        switchpanel(rooms)
    End Sub

    Private Sub Checkinbtn_Click(sender As Object, e As EventArgs) Handles checkinbtn.Click
        switchpanel(checkin)
    End Sub
    Private Sub Checkoutbtn_Click(sender As Object, e As EventArgs) Handles checkoutbtn.Click
        switchpanel(checkout)
    End Sub
    Private Sub Billingbtn_Click(sender As Object, e As EventArgs) Handles billingbtn.Click
        switchpanel(billing)
    End Sub


End Class