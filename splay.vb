
Imports Utility

Public Class splay
    Private Sub frontfp_form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Lbl_displayfp_Click(sender As Object, e As EventArgs) Handles Lbl_displayfp.Click
        'Dim userdashboard As New userdashboard()
        ' LoadForm(userdashboard, Me)
        Dim options As New Registerform()
        LoadForm(options, Me)

    End Sub
End Class
