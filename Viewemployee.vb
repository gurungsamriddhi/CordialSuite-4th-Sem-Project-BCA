Public Class Viewemployee
    Dim usercontroller As New UserController()

    Private Sub PopulateDataGridView()
        Dim usersTable As DataTable = usercontroller.GetUsersDataTable()
        DGV_viewemployee.DataSource = usersTable
    End Sub





    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Dispose()
        End
    End Sub

    Private Sub DGV_viewemployee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_viewemployee.CellContentClick

    End Sub
End Class
