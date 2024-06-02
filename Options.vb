
Public Class Options

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Register_btn_Click(sender As Object, e As EventArgs) Handles Register_btn.Click
        Dim register As New Registerform
        register.Show()
        Me.Hide()


    End Sub

    Private Sub Login_btn_Click(sender As Object, e As EventArgs) Handles Login_btn.Click
        Dim login As New Loginform
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PanelLogin_Paint(sender As Object, e As PaintEventArgs) Handles PanelLogin.Paint

    End Sub



    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Dispose()
        End
    End Sub
End Class