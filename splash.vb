Public Class splash


    Private Sub closebtn_Click_1(sender As Object, e As EventArgs) Handles closebtn.Click
        Application.Exit()
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBarsplashscreen.Increment(3)
        loading_txtbx.Text = "Loading..."
        If ProgressBarsplashscreen.Value = 100 Then
            Me.Hide()
            Dim Loginform As New Loginform()
            Loginform.Show()
            Timer1.Enabled = False

        End If
    End Sub

    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub


End Class
