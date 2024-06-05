Public Class admindashboard

    Public Sub Switchpanel(ByVal panel As Form)

        Me.Controls.Clear()
        panel.TopLevel = False
        Me.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Switchpanel(newguestform)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Switchpanel(Viewemployee)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Switchpanel(newroom)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Switchpanel(Revenue)
    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click

    End Sub

    Private Sub guestpanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label2rooms_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs)
        Dispose()
        End
    End Sub

    Public Sub admindashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class