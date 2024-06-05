
Public Class Addguestform

    Private Sub Guestlistbtn_Click(sender As Object, e As EventArgs) Handles guestlistbtn.Click

    End Sub


    Public Sub Switchpanel(ByVal panel As Form)

        pnlguestlist.Controls.Clear()
        panel.TopLevel = False
        pnlguestlist.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub Newguestbtn_Click(sender As Object, e As EventArgs) Handles newguestbtn.Click
        Switchpanel(newguest_form)
    End Sub



    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Dispose()
        End

    End Sub
End Class