Public Class superadmin_login


    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Dispose()
        End
    End Sub

    Private Sub adminlogin_btn_Click(sender As Object, e As EventArgs) Handles adminlogin_btn.Click
        Dim superadmindashboad As New superadmin_dashboard()
        superadmindashboad.Show()
        Me.Hide()

    End Sub

    Private Sub lbl_password_Click(sender As Object, e As EventArgs) Handles lbl_password.Click

    End Sub
End Class