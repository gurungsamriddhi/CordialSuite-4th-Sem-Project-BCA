Public Class GuestSelectionForm
    ' Event to pass the selected guest details
    Public Event GuestSelected(guestid As Integer, firstName As String, lastName As String)

    Dim guestssql As New guestssql()

    Private Sub GuestSelectionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate DataGridView with guest data
        PopulateGuests()
    End Sub

    Private Sub PopulateGuests()
        Dim query As String = "SELECT * FROM guests"
        guestssql.ExecuteQuery(query, DGV_Guests)
        DGV_Guests.AutoGenerateColumns = True
        DGV_Guests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DGV_Guests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DGV_Guests.DefaultCellStyle.BackColor = Color.White
        DGV_Guests.DefaultCellStyle.ForeColor = Color.Black
        DGV_Guests.AlternatingRowsDefaultCellStyle = Nothing
        ' Loop through columns and set the AutoSizeMode property
        For Each column As DataGridViewColumn In DGV_Guests.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
        ' Adjust the height of the header row to display the full content
        DGV_Guests.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)
    End Sub

    Private Sub DGV_Guests_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Guests.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DGV_Guests.Rows(e.RowIndex)
            Dim guestid As Integer = Integer.Parse(selectedRow.Cells("GuestId").Value.ToString())
            Dim firstName As String = selectedRow.Cells("FirstName").Value.ToString()
            Dim lastName As String = selectedRow.Cells("LastName").Value.ToString()

            ' Raise the GuestSelected event
            RaiseEvent GuestSelected(guestid, firstName, lastName)
            Me.Close()
        End If
    End Sub
End Class
