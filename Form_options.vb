
Imports Utility
Public Class Form_options
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Dim register As New Registerform()
        LoadForm(register, Me)
    End Sub



    Private Sub Signup_btn_Click(sender As Object, e As EventArgs) Handles Register_btn.Click

    End Sub

    Private Sub Login_btn_Click(sender As Object, e As EventArgs) Handles Login_btn.Click

    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click

    End Sub

    Private Sub Panel_options_Paint(sender As Object, e As PaintEventArgs) Handles Panel_options.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class