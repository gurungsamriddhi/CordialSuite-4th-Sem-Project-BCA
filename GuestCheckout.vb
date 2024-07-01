Imports System.Data.SqlClient

Public Class GuestCheckout

    Dim checkout As New reservationsSql()

    Private Sub GuestCheckout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populatereservations()
        ' Enable multi-row selection in DataGridView
        DGV_Checkout.MultiSelect = True
        DGV_Checkout.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

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
        "    reservations.Status = 'Check-In';"

        checkout.ExecuteQuery(query, DGV_Checkout)

        DGV_Checkout.DefaultCellStyle.BackColor = Color.White
        DGV_Checkout.DefaultCellStyle.ForeColor = Color.Black
        DGV_Checkout.AlternatingRowsDefaultCellStyle = Nothing
        DGV_Checkout.ReadOnly = True
        DGV_Checkout.Columns("GuestID").Visible = False
        DGV_Checkout.Columns("ReservationID").Visible = False
        DGV_Checkout.Columns("roomID").Visible = False
    End Sub

    Private Sub checkout_btn_Click(sender As Object, e As EventArgs) Handles checkout_btn.Click
        For Each selectedRow As DataGridViewRow In DGV_Checkout.SelectedRows
            Dim reservationID As Integer = Convert.ToInt32(selectedRow.Cells("ReservationID").Value)
            UpdateReservationStatus(reservationID)
        Next

        ' Refresh the DataGridView after checkout
        populatereservations()
        MessageBox.Show("Selected reservations have been checked out.", "Checkout Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub UpdateReservationStatus(reservationID As Integer)
        Dim query As String = "UPDATE reservations SET Status = 'Check-out' WHERE ReservationID = @ReservationID"
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@ReservationID", reservationID)
        }
        checkout.ExecuteNonQueryWithParameters(query, parameters)
    End Sub

    Private Sub searchkeyword_txtbx_TextChanged(sender As Object, e As EventArgs) Handles searchkeyword_txtbx.TextChanged
        Filtercheckinsbykeyword(searchkeyword_txtbx.Text.Trim)
    End Sub

    Private Sub filtercheckinsbykeyword(keyword As String)
        Dim query As String = "
        SELECT r.*, ro.Roomnumber,ro.RoomType, ro.BedCount, ro.PricePerNight,g.Firstname,g.Lastname
        FROM reservations r
        INNER JOIN rooms ro ON r.RoomID = ro.RoomID
        inner join guests g on r.GuestId = g.GuestId
        WHERE r.status='Check-In' and (
           r.Numberofdaysreserved like @keyword OR
            ro.Roomnumber LIKE @Keyword OR
            ro.RoomType LIKE @Keyword OR
            ro.BedCount LIKE @Keyword OR
            r.Status LIKE @Keyword OR
            ro.Pricepernight LIKE @Keyword or
            g.Firstname like @keyword or
            g.lastname like @keyword)"
        checkout.SearchReservations(query, keyword, DGV_Checkout)
    End Sub
End Class

