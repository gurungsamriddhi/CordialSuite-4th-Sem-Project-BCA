Imports System.Data.SqlClient

Public Class Reservation
    Dim isvalidinput As Boolean
    Private Sub browse_btn_Click(sender As Object, e As EventArgs) Handles browse_btn.Click
        Dim guestSelectionForm As New guestselectionform()

        ' Handle the GuestSelected event
        AddHandler guestSelectionForm.GuestSelected, AddressOf OnGuestSelected

        guestSelectionForm.ShowDialog()
    End Sub

    Private Sub OnGuestSelected(guestid As Integer, firstName As String, lastName As String)
        ' Concatenate the first name and last name and display in guestname_txtbx
        guestname_txtbx.Text = firstName & " " & lastName
        Lbl_guestidshow.Text = guestid.ToString()
        guestname_txtbx.ReadOnly = True

    End Sub


    Private Sub browseroom_btn_Click(sender As Object, e As EventArgs) Handles browseroom_btn.Click
        Dim roomselectionForm As New roomselectionform(Me)

        roomselectionForm.ShowDialog()

    End Sub

    Public Sub AddRoomSelection(roomID As Integer, roomNumber As String, roomType As String, bedCount As String)
        ' Display room details in text boxes or any other controls as needed
        roomno_txtbx.Text &= roomNumber & " "
        roomtype_txtbx.Text &= roomType & " "
        bedcount_txtbx.Text &= bedCount & " "
        lbl_roomidshow.Text &= roomID & " "

        roomno_txtbx.ReadOnly = True
        roomtype_txtbx.ReadOnly = True
        bedcount_txtbx.ReadOnly = True
    End Sub

    Private Sub reservationbtn_Click(sender As Object, e As EventArgs) Handles reservationbtn.Click
        Dim isValid As Boolean = True
        Dim guestname As String = guestname_txtbx.Text
        Dim roomno As String = roomno_txtbx.Text
        Dim noofdaysreserved As String = Reserveddays_txtbx.Text
        Dim noofguests As Integer = CInt(guestnumber_NUD.Value)
        Dim guestreservationstatus As String = status_cmbbx.SelectedItem.ToString()

        If String.IsNullOrEmpty(guestname) Then
            isValid = False
            Lbl_msgguestname.Text = "Guest name cannot be empty."
            Lbl_msgguestname.ForeColor = Color.Red
        End If

        ' Validate room number
        If String.IsNullOrEmpty(roomno) Then
            isValid = False
            Lbl_msgroomno.Text = "Room number cannot be empty."
            Lbl_msgroomno.ForeColor = Color.Red
        End If

        ' Validate number of days reserved
        If String.IsNullOrEmpty(noofdaysreserved) OrElse Not Integer.TryParse(noofdaysreserved, Nothing) Then
            isValid = False
            Lbl_msgdaysreserved.Text = "Invalid number of days."
            Lbl_msgdaysreserved.ForeColor = Color.Red
        End If

        ' Validate number of guests
        If noofguests <= 0 Then
            isValid = False
            Lbl_msgnoofguests.Text = "Number of guests must be greater than zero."
            Lbl_msgnoofguests.ForeColor = Color.Red
        End If

        ' Validate reservation status
        If status_cmbbx.SelectedIndex = -1 Then
            isValid = False
            lbl_msgstatus.Text = "Please select a status."
            lbl_msgstatus.ForeColor = Color.Red
        End If

        If Not isValid Then
            MessageBox.Show("Please fill out all the fields correctly.")
            Exit Sub
        End If

    End Sub

    Private Sub arrivaldate_DTP_ValueChanged(sender As Object, e As EventArgs) Handles arrivaldate_DTP.ValueChanged

    End Sub

    Private Sub checkoutdate_DTP_ValueChanged(sender As Object, e As EventArgs) Handles checkoutdate_DTP.ValueChanged

    End Sub

    Private Sub Reserveddays_txtbx_TextChanged(sender As Object, e As EventArgs) Handles Reserveddays_txtbx.TextChanged

    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        roomno_txtbx.Text = ""
        roomtype_txtbx.Text = ""
        bedcount_txtbx.Text = ""


    End Sub

    Private Sub tabpageaddreservations_Click(sender As Object, e As EventArgs) Handles tabpageaddreservations.Click

    End Sub


End Class