
Public Class Options

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Register_btn_Click(sender As Object, e As EventArgs) Handles Register_btn.Click
        splay.Hide()
        Me.Hide()

        Registerform.Show()
    End Sub

    Private Sub Login_btn_Click(sender As Object, e As EventArgs) Handles Login_btn.Click
        'splay.Hide()
        'Me.Hide()
        'loginform.Show()

    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click

    End Sub

    Private Sub PanelLogin_Paint(sender As Object, e As PaintEventArgs) Handles PanelLogin.Paint

    End Sub
End Class