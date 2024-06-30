Imports System.Data.SqlClient

Public Class Reservation
    Dim isvalidinput As Boolean
    Dim managereservation As New reservationsSql()


    Private Sub browse_btn_Click(sender As Object, e As EventArgs) Handles browse_btn.Click

        Dim guestSelectionForm As New guestselectionform(Me)
        guestname_txtbx.Text = "" ' Clear previous guest name
        Lbl_guestidshow.Text = String.Empty

        guestSelectionForm.ShowDialog()

    End Sub

    Public Sub OnGuestSelected(guestid As Integer, firstName As String, lastName As String)
        ' Concatenate the first name and last name and display in guestname_txtbx
        guestname_txtbx.Text = firstName & " " & lastName
        Lbl_guestidshow.Text = guestid.ToString()
        guestname_txtbx.ReadOnly = True
    End Sub

    Private Sub browseroom_btn_Click(sender As Object, e As EventArgs) Handles browseroom_btn.Click
        Dim roomselectionForm As New roomselectionform(Me)
        roomno_txtbx.Text = ""
        roomtype_txtbx.Text = ""
        lbl_roomidshow.Text = String.Empty
        bedcount_txtbx.Text = ""
        pricepernight_txtbx.Text = ""
        roomselectionForm.ShowDialog()
    End Sub

    Public Sub AddRoomSelection(roomID As Integer, roomNumber As String, roomType As String, bedCount As String, pricepernight As Decimal)
        ' Display room details in text boxes or any other controls as needed
        roomno_txtbx.Text = roomNumber
        roomtype_txtbx.Text = roomType
        bedcount_txtbx.Text = bedCount
        lbl_roomidshow.Text = roomID.ToString()
        pricepernight_txtbx.Text = pricepernight.ToString()

        roomno_txtbx.ReadOnly = True
        roomtype_txtbx.ReadOnly = True
        bedcount_txtbx.ReadOnly = True
        pricepernight_txtbx.ReadOnly = True
    End Sub

    ' Method to calculate the total amount
    Public Function calculatedamount(pricepernight As Decimal, noofdays As Integer) As Decimal
        Return noofdays * pricepernight
    End Function

    Private Sub Reserveddays_txtbx_TextChanged(sender As Object, e As EventArgs) Handles Reserveddays_txtbx.TextChanged
        Lbl_msgdaysreserved.Text = String.Empty
        Dim noofdays As Integer

        ' Validate and parse input from Reserveddays_txtbx
        If Integer.TryParse(Reserveddays_txtbx.Text, noofdays) Then
            ' Calculate checkout date based on check-in date and reserved days
            Dim checkindate As Date = arrivaldate_DTP.Value
            Dim checkoutdate As Date = checkindate.AddDays(noofdays)

            ' Update checkout date DateTimePicker
            checkoutdate_DTP.Value = checkoutdate

            ' Validate and calculate total amount
            Dim pricePerNight As Decimal
            If Decimal.TryParse(pricepernight_txtbx.Text, pricePerNight) Then
                Dim totalAmount As Decimal = calculatedamount(pricePerNight, noofdays)
                totalamt_txtbx.Text = totalAmount.ToString("F2") ' Display the total amount in the textbox
            Else
                MessageBox.Show("Invalid price per night. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                pricepernight_txtbx.Text = String.Empty ' Reset the textbox to empty or handle invalid input as needed
                totalamt_txtbx.Text = "0.00" ' Reset total amount display
            End If

            checkoutdate_DTP.Enabled = True ' Enable checkout date picker once valid input is provided
        ElseIf Reserveddays_txtbx.Text <> String.Empty Then
            MessageBox.Show("Please enter a valid number of days.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Reserveddays_txtbx.Text = String.Empty ' Reset the textbox to empty
            totalamt_txtbx.Text = "0.00" ' Reset to 0 if input is invalid
            checkoutdate_DTP.Enabled = False ' Disable checkout date picker if input is invalid
        End If
    End Sub


    Private Sub reservationbtn_Click(sender As Object, e As EventArgs) Handles reservationbtn.Click
        Dim isValid As Boolean = True
        Dim guestname As String = guestname_txtbx.Text
        Dim roomno As String = roomno_txtbx.Text
        Dim noofdaysreserved As String = Reserveddays_txtbx.Text
        Dim pricepernight As Decimal
        Dim noofdays As Integer
        Dim noofguests As Integer = CInt(guestnumber_NUD.Value)
        Dim guestreservationstatus As String = String.Empty
        Dim checkindate As Date = arrivaldate_DTP.Value.Date
        Dim checkoutdate As Date = checkoutdate_DTP.Value.Date
        Dim totalamount As Decimal

        If Not String.IsNullOrEmpty(Lbl_reservationidshow.Text) Then
            MessageBox.Show("Existing reservations can only be cancelled or updated.")
            Exit Sub ' Exit the sub to prevent further execution
        End If
        If String.IsNullOrEmpty(pricepernight_txtbx.Text) OrElse Not Decimal.TryParse(pricepernight_txtbx.Text, pricepernight) Then
            isValid = False
            Lbl_msgpricepernight.Text = "Choose a room or enter a valid price per night."
            Lbl_msgpricepernight.ForeColor = Color.Red
        Else
            Lbl_msgpricepernight.Text = String.Empty
        End If
        ' Validate guest name
        If String.IsNullOrEmpty(guestname) Then
            isValid = False
            Lbl_msgguestname.Text = "Guest name cannot be empty."
            Lbl_msgguestname.ForeColor = Color.Red
        Else
            Lbl_msgguestname.Text = String.Empty
        End If

        ' Validate room number
        If String.IsNullOrEmpty(roomno) Then
            isValid = False
            Lbl_msgroomno.Text = "Room number cannot be empty."
            Lbl_msgroomno.ForeColor = Color.Red
        Else
            Lbl_msgroomno.Text = String.Empty
        End If

        ' Validate number of days reserved
        If String.IsNullOrEmpty(noofdaysreserved) OrElse Not Integer.TryParse(noofdaysreserved, noofdays) Then
            isValid = False
            Lbl_msgdaysreserved.Text = "Invalid number of days."
            Lbl_msgdaysreserved.ForeColor = Color.Red
        Else
            Lbl_msgdaysreserved.Text = String.Empty
            totalamount = calculatedamount(pricePerNight, noofdays)
        End If

        ' Validate number of guests
        If noofguests <= 0 Then
            isValid = False
            Lbl_msgnoofguests.Text = "Number of guests must be greater than zero."
            Lbl_msgnoofguests.ForeColor = Color.Red
        Else
            Lbl_msgnoofguests.Text = String.Empty
        End If

        ' Validate reservation status
        If status_cmbbx.SelectedIndex = -1 Then
            isValid = False
            lbl_msgstatus.Text = "Please select a status."
            lbl_msgstatus.ForeColor = Color.Red
        Else
            lbl_msgstatus.Text = String.Empty
            guestreservationstatus = status_cmbbx.SelectedItem.ToString()
        End If


        If Not isValid Then
            MessageBox.Show("Please fill out all the fields correctly.")
            Exit Sub
        End If

        If Not RoomIsAvailable(lbl_roomidshow.Text, checkindate, checkoutdate) Then
            MessageBox.Show("This room is not available for the selected dates.")
            Exit Sub
        End If
        Dim query As String = "INSERT INTO reservations (GuestID, RoomID, CheckInDate, CheckOutDate, NumberOfGuests, TotalAmount, Status,Numberofdaysreserved) " &
                          "VALUES (@GuestID, @RoomID, @CheckInDate, @CheckOutDate, @NumberOfGuests, @TotalAmount, @Status, @Numberofdaysreserved);"

        Dim parameters As New List(Of SqlParameter)()
        parameters.Add(New SqlParameter("@GuestID", Lbl_guestidshow.Text))
        parameters.Add(New SqlParameter("@RoomID", lbl_roomidshow.Text))
        parameters.Add(New SqlParameter("@CheckInDate", checkindate.Date))
        parameters.Add(New SqlParameter("@CheckOutDate", checkoutdate.Date))
        parameters.Add(New SqlParameter("@NumberOfGuests", noofguests))
        parameters.Add(New SqlParameter("@TotalAmount", totalamount))
        parameters.Add(New SqlParameter("@Status", guestreservationstatus))
        parameters.Add(New SqlParameter("@Numberofdaysreserved", noofdaysreserved))

        managereservation.ExecuteNonQueryWithParameters(query, parameters)
        MessageBox.Show("Room Alloted.")
        populatereservations()
    End Sub


    Private Function RoomIsAvailable(roomID As Integer, checkInDate As Date, checkOutDate As Date) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM reservations WHERE RoomID = @RoomID AND Status = 'Check-In' AND (@CheckInDate < CheckOutDate AND @CheckOutDate > CheckInDate);"

        Dim parameters As New List(Of SqlParameter)()
        parameters.Add(New SqlParameter("@RoomID", roomID))
        parameters.Add(New SqlParameter("@CheckInDate", checkInDate))
        parameters.Add(New SqlParameter("@CheckOutDate", checkOutDate))

        Dim result As Object = managereservation.ExecuteScalarWithParameters(query, parameters)

        If result IsNot Nothing AndAlso Integer.TryParse(result.ToString(), Nothing) Then
            Return Convert.ToInt32(result) = 0 ' Room is available if count is zero
        Else
            Return False ' Error occurred or no result
        End If
    End Function


    Private Sub guestname_txtbx_TextChanged(sender As Object, e As EventArgs) Handles guestname_txtbx.TextChanged
        Lbl_msgguestname.Text = String.Empty
    End Sub

    Private Sub roomno_txtbx_TextChanged(sender As Object, e As EventArgs) Handles roomno_txtbx.TextChanged
        Lbl_msgroomno.Text = String.Empty
    End Sub



    Private Sub guestnumber_NUD_ValueChanged(sender As Object, e As EventArgs) Handles guestnumber_NUD.ValueChanged
        Lbl_msgnoofguests.Text = String.Empty
    End Sub

    Private Sub status_cmbbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles status_cmbbx.SelectedIndexChanged
        lbl_msgstatus.Text = String.Empty
    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        roomno_txtbx.Clear()
        roomtype_txtbx.Clear()
        bedcount_txtbx.Clear()
        Lbl_guestidshow.Text = String.Empty
        lbl_roomidshow.Text = String.Empty
        lbl_msgstatus.Text = String.Empty
        guestname_txtbx.Clear()
        arrivaldate_DTP.Value = Date.Today
        checkoutdate_DTP.Enabled = True
        pricepernight_txtbx.Clear()
        Reserveddays_txtbx.Clear()
        Lbl_msgdaysreserved.Text = String.Empty
        totalamt_txtbx.Clear()
        status_cmbbx.SelectedIndex = -1
        guestnumber_NUD.Value = 1
        Lbl_Reservation.Text = String.Empty
        Lbl_reservationidshow.Text = String.Empty

    End Sub

    Private Sub tabpageaddreservations_Click(sender As Object, e As EventArgs) Handles tabpageaddreservations.Click
    End Sub

    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        arrivaldate_DTP.Value = Date.Today
        populatereservations()

    End Sub

    Private Sub checkoutdate_DTP_ValueChanged(sender As Object, e As EventArgs) Handles checkoutdate_DTP.ValueChanged

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

        managereservation.ExecuteQuery(query, DGV_reservations)

        DGV_reservations.DefaultCellStyle.BackColor = Color.White
        DGV_reservations.DefaultCellStyle.ForeColor = Color.Black
        DGV_reservations.AlternatingRowsDefaultCellStyle = Nothing
        DGV_reservations.ReadOnly = True
        DGV_reservations.Columns("GuestID").Visible = False
        DGV_reservations.Columns("ReservationID").Visible = False
        DGV_reservations.Columns("roomID").Visible = False
    End Sub

    Private Sub DGV_reservations_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_reservations.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DGV_reservations.Rows(e.RowIndex)
            Dim reservationid As Integer = Convert.ToInt32(selectedRow.Cells("ReservationID").Value)
            Dim guestID As Integer = Convert.ToInt32(selectedRow.Cells("GuestId").Value)
            Dim guestName As String = selectedRow.Cells("guestfirstname").Value.ToString() & " " & selectedRow.Cells("guestlastname").Value.ToString()
            Dim roomtype As String = selectedRow.Cells("roomtype").Value.ToString()
            Dim bedcount As String = selectedRow.Cells("roombedcount").Value.ToString()
            Dim pricepernight As Decimal = Convert.ToDecimal(selectedRow.Cells("roompricepernight").Value).ToString("F2")


            lbl_roomidshow.Text = selectedRow.Cells("roomID").Value.ToString()
            roomtype_txtbx.Text = roomtype
            bedcount_txtbx.Text = bedcount
            pricepernight_txtbx.Text = pricepernight
            Lbl_Reservation.Text = "Reservation ID:"
            Lbl_reservationidshow.Text = reservationid
            Lbl_guestidshow.Text = guestID.ToString()
            guestname_txtbx.Text = guestName
            roomno_txtbx.Text = selectedRow.Cells("roomno").Value.ToString()
            Reserveddays_txtbx.Text = selectedRow.Cells("noofdaysreserved").Value.ToString()
            guestnumber_NUD.Value = Convert.ToInt32(selectedRow.Cells("NumberofGuests").Value)
            status_cmbbx.SelectedItem = selectedRow.Cells("status").Value.ToString()
            arrivaldate_DTP.Value = Convert.ToDateTime(selectedRow.Cells("Checkindate").Value)
            checkoutdate_DTP.Value = Convert.ToDateTime(selectedRow.Cells("Checkoutdate").Value)
            totalamt_txtbx.Text = Convert.ToDecimal(selectedRow.Cells("Totalamount").Value).ToString("F2")



            ' Disable editing for certain fields if needed
            guestname_txtbx.ReadOnly = True
            roomno_txtbx.ReadOnly = True
            arrivaldate_DTP.Enabled = True
            checkoutdate_DTP.Enabled = False
        End If
    End Sub

    Private Sub TabPageviewreservations_Enter(sender As Object, e As EventArgs) Handles TabPageviewreservations.Enter
        populatereservations()

    End Sub

    Private Sub TabControlreservation_Enter(sender As Object, e As EventArgs) Handles TabControlreservation.Enter
        populatereservations()
    End Sub

    Private Sub searchkeyword_txtbx_TextChanged(sender As Object, e As EventArgs) Handles searchkeyword_txtbx.TextChanged
        FilterreservationsByKeyword(searchkeyword_txtbx.Text.Trim())
    End Sub

    Private Sub FilterreservationsByKeyword(keyword As String)
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
        managereservation.SearchReservations(query, keyword, DGV_reservations)
    End Sub
    Private Sub tabpageaddreservations_Leave(sender As Object, e As EventArgs) Handles tabpageaddreservations.Leave
        roomno_txtbx.Clear()
        roomtype_txtbx.Clear()
        bedcount_txtbx.Clear()
        Lbl_guestidshow.Text = String.Empty
        lbl_roomidshow.Text = String.Empty
        lbl_msgstatus.Text = String.Empty
        guestname_txtbx.Clear()
        arrivaldate_DTP.Value = Date.Today
        checkoutdate_DTP.Enabled = True
        pricepernight_txtbx.Clear()
        Reserveddays_txtbx.Clear()
        Lbl_msgdaysreserved.Text = String.Empty
        totalamt_txtbx.Clear()
        status_cmbbx.SelectedIndex = -1
        guestnumber_NUD.Value = 1
        Lbl_Reservation.Text = String.Empty
        Lbl_reservationidshow.Text = String.Empty
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        ' Ensure necessary fields are filled
        If String.IsNullOrEmpty(Lbl_reservationidshow.Text) Then
            MessageBox.Show("Please select a reservation to update.")
            Exit Sub ' Exit the sub to prevent further execution
        End If

        Dim isValid As Boolean = True
        Dim guestname As String = guestname_txtbx.Text
        Dim roomno As String = roomno_txtbx.Text
        Dim noofdaysreserved As String = Reserveddays_txtbx.Text
        Dim pricepernight As Decimal = pricepernight_txtbx.Text
        Dim noofdays As Integer
        Dim noofguests As Integer = CInt(guestnumber_NUD.Value)
        Dim guestreservationstatus As String = status_cmbbx.SelectedItem.ToString()
        Dim checkindate As Date = arrivaldate_DTP.Value.Date
        Dim checkoutdate As Date = checkoutdate_DTP.Value.Date
        Dim totalamount As Decimal = 0 ' Update total amount if needed

        ' Validate guest name
        If String.IsNullOrEmpty(guestname) Then
            isValid = False
            Lbl_msgguestname.Text = "Guest name cannot be empty."
            Lbl_msgguestname.ForeColor = Color.Red
        Else
            Lbl_msgguestname.Text = String.Empty
        End If

        ' Validate room number
        If String.IsNullOrEmpty(roomno) Then
            isValid = False
            Lbl_msgroomno.Text = "Room number cannot be empty."
            Lbl_msgroomno.ForeColor = Color.Red
        Else
            Lbl_msgroomno.Text = String.Empty
        End If

        ' Validate number of days reserved
        If String.IsNullOrEmpty(noofdaysreserved) OrElse Not Integer.TryParse(noofdaysreserved, noofdays) Then
            isValid = False
            Lbl_msgdaysreserved.Text = "Invalid number of days."
            Lbl_msgdaysreserved.ForeColor = Color.Red
        Else
            Lbl_msgdaysreserved.Text = String.Empty
            totalamount = calculatedamount(pricepernight, noofdays)
        End If

        ' Validate number of guests
        If noofguests <= 0 Then
            isValid = False
            Lbl_msgnoofguests.Text = "Number of guests must be greater than zero."
            Lbl_msgnoofguests.ForeColor = Color.Red
        Else
            Lbl_msgnoofguests.Text = String.Empty
        End If

        ' Validate reservation status
        If status_cmbbx.SelectedIndex = -1 Then
            isValid = False
            lbl_msgstatus.Text = "Please select a status."
            lbl_msgstatus.ForeColor = Color.Red
        Else
            lbl_msgstatus.Text = String.Empty
            guestreservationstatus = status_cmbbx.SelectedItem.ToString()
        End If

        ' Check room availability
        If Not RoomIsAvailable(lbl_roomidshow.Text, checkindate, checkoutdate) Then
            MessageBox.Show("This room is not available for the selected dates.")
            Exit Sub
        End If

        ' If any validation fails, show message and exit
        If Not isValid Then
            MessageBox.Show("Please fill out all the fields correctly.")
            Exit Sub
        End If
        Dim query As String = "
                             UPDATE r
                            SET
                          r.CheckInDate = @CheckInDate,
                          r.CheckOutDate = @CheckOutDate,
                         r.NumberOfGuests = @NumberOfGuests,
                        r.TotalAmount = @TotalAmount,
                        r.Status = @Status,
                        r.Numberofdaysreserved = @Numberofdaysreserved
                        FROM reservations r
                        INNER JOIN rooms rm ON r.RoomID = rm.RoomID
                           WHERE
                       r.GuestID = @GuestID AND r.RoomID = @RoomID;"

        ' Set up parameters for the query
        Dim parameters As New List(Of SqlParameter)()
        parameters.Add(New SqlParameter("@CheckInDate", checkindate))
        parameters.Add(New SqlParameter("@CheckOutDate", checkoutdate))
        parameters.Add(New SqlParameter("@NumberOfGuests", noofguests))
        parameters.Add(New SqlParameter("@TotalAmount", totalamount))
        parameters.Add(New SqlParameter("@Status", guestreservationstatus))
        parameters.Add(New SqlParameter("@Numberofdaysreserved", noofdaysreserved))
        parameters.Add(New SqlParameter("@RoomNumber", roomno))
        parameters.Add(New SqlParameter("@GuestID", Lbl_guestidshow.Text))
        parameters.Add(New SqlParameter("@RoomID", lbl_roomidshow.Text))

        ' Execute the update query
        managereservation.ExecuteNonQueryWithParameters(query, parameters)

        ' Show success message
        MessageBox.Show("Reservation updated successfully.")

        ' Refresh the reservations view
        populatereservations()
    End Sub



    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        ' Check if a reservation ID is present
        If String.IsNullOrEmpty(Lbl_reservationidshow.Text) Then
            MessageBox.Show("Please select a reservation to cancel.")
            Exit Sub ' Exit the sub to prevent further execution
        End If

        ' Confirm cancellation with the user
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel this reservation?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' If the user clicks 'No', exit the sub
        If result = DialogResult.No Then
            Exit Sub
        End If

        ' Perform the update operation to set the status to "Cancelled"
        Dim query As String = "UPDATE reservations SET Status = @Status WHERE ReservationID = @ReservationID;"

        Dim parameters As New List(Of SqlParameter)()
        parameters.Add(New SqlParameter("@Status", "Cancelled"))
        parameters.Add(New SqlParameter("@ReservationID", Lbl_reservationidshow.Text))

        ' Execute the update query
        managereservation.ExecuteNonQueryWithParameters(query, parameters)

        MessageBox.Show("Reservation has been cancelled.")
        populatereservations()
        roomno_txtbx.Clear()
        roomtype_txtbx.Clear()
        bedcount_txtbx.Clear()
        Lbl_guestidshow.Text = String.Empty
        lbl_roomidshow.Text = String.Empty
        lbl_msgstatus.Text = String.Empty
        guestname_txtbx.Clear()
        arrivaldate_DTP.Value = Date.Today
        checkoutdate_DTP.Enabled = True
        pricepernight_txtbx.Clear()
        Reserveddays_txtbx.Clear()
        Lbl_msgdaysreserved.Text = String.Empty
        totalamt_txtbx.Clear()
        status_cmbbx.SelectedIndex = -1
        guestnumber_NUD.Value = 1
        Lbl_Reservation.Text = String.Empty
        Lbl_reservationidshow.Text = String.Empty

    End Sub

    Private Sub DGV_reservations_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_reservations.CellContentClick

    End Sub
End Class
