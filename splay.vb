



Public Class Splay
    Private Sub Splay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Lbl_displayfp_Click(sender As Object, e As EventArgs) Handles Lbl_displayfp.Click
        Dim userdashboard As New userdashboard()
        LoadForm(userdashboard, Me)
        'Dim options As New Options()
        'LoadForm(options, Me)
        'Dim addguest As New addguestform()
        'LoadForm(addguestform, Me)

    End Sub
End Class
