Public Class browsereservations
    Dim managereservation As New reservationsSql()
    Private billingform As billing

    ' Constructor to accept Reservation form instance
    Public Sub New(billing As billing)
        InitializeComponent()
        Me.billingform = billing
    End Sub

    Private Sub populatereservations()
        Dim query As String = "SELECT " &
    "    guests.GuestID, " &
    "    guests.FirstName, " &
    "    guests.LastName, " &
    "    rooms.roomID, " &
    "    rooms.RoomNumber, " &
    "    rooms.RoomType, " &
    "    rooms.BedCount, " &
    "    rooms.PricePerNight, " &
    "    reservations.ReservationID, " &
    "    reservations.CheckInDate, " &
    "    reservations.CheckOutDate, " &
    "    reservations.NumberOfDaysReserved, " &
    "    reservations.NumberOfGuests, " &
    "    reservations.TotalAmount, " &
    "    reservations.Status " &
    "FROM " &
    "    reservations " &
    "    INNER JOIN guests ON reservations.GuestID = guests.GuestID " &
    "    INNER JOIN rooms ON reservations.RoomID = rooms.RoomID " &
    "WHERE " &
    "    reservations.Status = 'Check-out';"


        managereservation.ExecuteQuery(query, DGV_reservations)

        DGV_reservations.DefaultCellStyle.BackColor = Color.White
        DGV_reservations.DefaultCellStyle.ForeColor = Color.Black
        DGV_reservations.AlternatingRowsDefaultCellStyle = Nothing
        DGV_reservations.ReadOnly = True
        DGV_reservations.Columns("GuestID").Visible = False
        DGV_reservations.Columns("ReservationID").Visible = False
        DGV_reservations.Columns("roomID").Visible = False
    End Sub
    Private Sub DGV_reservations_DoubleClick(sender As Object, e As EventArgs) Handles DGV_reservations.DoubleClick
        If DGV_reservations.CurrentRow IsNot Nothing Then
            Dim selectedRow As DataGridViewRow = DGV_reservations.CurrentRow

            Dim reservationid As Integer = CInt(selectedRow.Cells("ReservationID").Value)
            Dim guestName As String = selectedRow.Cells("guestfirstname").Value.ToString() & " " & selectedRow.Cells("guestlastname").Value.ToString()
            Dim roomtype As String = selectedRow.Cells("roomtype").Value.ToString()
            Dim reserveddays As Integer = CInt(selectedRow.Cells("noofdaysreserved").Value)
            Dim pricepernight As Decimal = CDec(selectedRow.Cells("roompricepernight").Value)
            Dim totalamount As Decimal = CDec(selectedRow.Cells("Totalamount").Value)
            Dim roomnumber As Integer = CInt(selectedRow.Cells("roomno").Value)

            billingform.ReservationSelection(reservationid, roomnumber, roomtype, reserveddays, guestName, totalamount, pricepernight)
            Me.Close()
        End If
    End Sub

    Private Sub browsereservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populatereservations()

    End Sub
End Class