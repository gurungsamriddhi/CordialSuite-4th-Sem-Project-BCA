Public Class superadmin_dashboard
    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Register_btn_Click(sender As Object, e As EventArgs)
        Dim register As New Registerform                'shows registerform
        register.Show
        Hide


    End Sub

    Private Sub Login_btn_Click(sender As Object, e As EventArgs)
        Dim login As New Loginform  'shows loginform
        login.Show
        Hide
    End Sub

    Private Sub Closebtn_Click(sender As Object, e As EventArgs)
        Dispose    'closes the form when close button is clicked
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
        Me.Dispose()
        End

    End Sub
End Class