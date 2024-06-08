Public Class ChooseDashboard
    Private Sub Lblnewg_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Userdashboard_btn_Click(sender As Object, e As EventArgs) Handles Userdashboard_btn.Click
        Dim userdashboardform As New userdashboard
        userdashboardform.Show()
        Me.Hide()
    End Sub

    Private Sub admindashboard_btn_Click(sender As Object, e As EventArgs) Handles admindashboard_btn.Click
        Dim admindashboardform As New AdminDashboard
        admindashboardform.Show()
        Me.Hide()
    End Sub

    Private Sub closebtn_Click_1(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Dispose()
        End
    End Sub
End Class