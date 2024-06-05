Public Class Loginform
    Private Sub Loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        Dim ChooseDashboardform As New ChooseDashboard
        ChooseDashboardform.Show()
        Me.Hide()


    End Sub





    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Dispose()
        End
    End Sub
End Class
