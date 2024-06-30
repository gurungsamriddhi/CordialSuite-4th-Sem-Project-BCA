Public Class GuestSelectionForm
    Private reservationform As Reservation

    ' Constructor to accept Reservation form instance
    Public Sub New(reservation As Reservation)
        InitializeComponent()
        Me.reservationForm = reservation
    End Sub


    Dim guestssql As New guestssql()

    Private Sub GuestSelectionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate DataGridView with guest data
        PopulateGuests()
    End Sub

    Private Sub PopulateGuests()
        Dim query As String = "SELECT * FROM guests"
        guestssql.ExecuteQuery(query, DGV_Guests)
        DGV_Guests.AutoGenerateColumns = True
        DGV_Guests.DefaultCellStyle.BackColor = Color.White
        DGV_Guests.DefaultCellStyle.ForeColor = Color.Black
        DGV_Guests.AlternatingRowsDefaultCellStyle = Nothing
    End Sub

    Private Sub DGV_Guests_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Guests.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DGV_Guests.Rows(e.RowIndex)
            Dim guestid As Integer = Integer.Parse(selectedRow.Cells("GuestId").Value.ToString())
            Dim firstName As String = selectedRow.Cells("FirstName").Value.ToString()
            Dim lastName As String = selectedRow.Cells("LastName").Value.ToString()

            ' Raise the GuestSelected event
            reservationform.OnGuestSelected(guestid, firstName, lastName)
            Me.Close()
        End If
    End Sub

 
End Class
