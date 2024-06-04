Public Class Loginform
    Private Sub Loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        Dim userdashboardform As New userdashboard
        userdashboardform.Show()
        Me.Hide()


    End Sub





    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Dispose()
        End
    End Sub

    Private Sub Linkregister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Linktoregister.LinkClicked
        Dim register As New Registerform
        Registerform.Show()
        Me.Hide()
    End Sub
End Class
