



Public Class Splay
    Private Sub Splay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Lbl_displayfp_Click(sender As Object, e As EventArgs) Handles Lbl_displayfp.Click
        'Dim userdashboard As New userdashboard()
        ' LoadForm(userdashboard, Me)
        'Dim options As New Options()
        'Utility.LoadForm(options, Me)
        ' Dim addguest As New addguestform()
        'LoadForm(addguestform, Me)
        ' Dim newguestform As New newguestform()
        ' LoadForm(newguestform, Me)
        Dim optionsform As New Options
        optionsform.Show()
        Me.Hide()
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Dispose()
    End Sub
End Class
