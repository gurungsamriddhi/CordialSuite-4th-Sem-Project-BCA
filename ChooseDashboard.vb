Public Class ChooseDashboard


    Private Sub Admin_Dashboard_Click(sender As Object, e As EventArgs) Handles Admin_Dashboard.Click
        Dim admindashboardform As New admindashboard
        admindashboardform.Show()
        Me.Hide()
    End Sub

    Private Sub User_Dashboard_Click(sender As Object, e As EventArgs) Handles User_Dashboard.Click
        Dim userdashboardform As New userdashboard
        userdashboardform.Show()
        Me.Hide()
    End Sub

    Private Sub closebtn_Click_1(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Dispose()
        End
    End Sub
End Class