
Imports Utility

Public Class frontfp_form1
    Private Sub frontfp_form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Lbl_displayfp_Click(sender As Object, e As EventArgs) Handles Lbl_displayfp.Click
        Dim dashboard As New Form2()
        loadForm(dashboard, Me)
    End Sub
End Class
