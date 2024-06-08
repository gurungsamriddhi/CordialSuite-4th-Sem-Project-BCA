Public Class Options
    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Register_btn_Click(sender As Object, e As EventArgs) Handles Register_btn.Click
        Dim register As New Registerform                'shows registerform
        register.Show()
        Me.Hide()


    End Sub

    Private Sub Login_btn_Click(sender As Object, e As EventArgs) Handles Login_btn.Click
        Dim login As New Loginform  'shows loginform
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Dispose()    'closes the form when close button is clicked
        End
    End Sub
End Class