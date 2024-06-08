Public Class Splay

    Private Sub Lbl_displayfp_Click(sender As Object, e As EventArgs) Handles Lbl_displayfp.Click
        Dim optionsform As New Options()  'open opttionform
        optionsform.Show()
        Me.Hide()
    End Sub

    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Dispose()
    End Sub
End Class
