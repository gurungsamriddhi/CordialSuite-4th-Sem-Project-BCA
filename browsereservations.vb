Public Class browsereservations
    Dim managereservation As New reservationsSql()

    Private Sub populatereservations()
        Dim query As String = "SELECT " &
        "    guests.GuestID ," &
        "    guests.FirstName ," &
        "    guests.LastName, " &
        "    rooms.roomID ," &
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
        "    reservations.Status IN ('Check-In', 'Check-Out');"

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

    End Sub
End Class