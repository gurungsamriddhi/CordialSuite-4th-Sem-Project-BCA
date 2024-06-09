Public Class splash

    Private Sub Lbl_displayfp_Click(sender As Object, e As EventArgs) Handles Lbl_displayfp.Click
        Dim Loginform As New Loginform() 'loginform call
        Loginform.Show()
        Me.Hide()
    End Sub



    Private Sub closebtn_Click_1(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Dispose()
        End
    End Sub
End Class
