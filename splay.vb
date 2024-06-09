Public Class Splay

    Private Sub Lbl_displayfp_Click(sender As Object, e As EventArgs) Handles Lbl_displayfp.Click
        'dim numbers as integer
        Dim Loginform As New Loginform()
        Loginform.Show()
        Me.Hide()


        'Dim optionsform As New Options()  'open opttionform
        'optionsform.Show()
        'Me.Hide()
    End Sub

    Private Sub Closebtn_Click(sender As Object, e As EventArgs)
        Dispose
    End Sub
End Class
