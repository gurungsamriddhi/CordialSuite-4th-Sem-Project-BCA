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

    Private Sub DGV_Checkout_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Checkout.CellClick
        ' Additional logic can be implemented here if needed
    End Sub

End Class

