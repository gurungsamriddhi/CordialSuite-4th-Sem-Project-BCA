Public Class Billing
    Private Sub browsereservation_btn_Click(sender As Object, e As EventArgs) Handles browsereservation_btn.Click
        Dim reservationselection As New browsereservations()


    End Sub
    Public Sub AddReservationSelection(reservationid As Integer, roomNumber As String, roomType As String, bedCount As String, pricepernight As Decimal)
        ' Display room details in text boxes or any other controls as needed
        roomno_txtbx.Text &= roomNumber
        roomtype_txtbx.Text &= roomType
        Reserveddays_txtbx.Text &= Reserveddays
        guestname_txtbx.Text &= guestname_txtbx
        roomtotal_txtbx.Text &=


        pricepernight_txtbx.Text = pricepernight.ToString()

        roomno_txtbx.ReadOnly = True
        roomtype_txtbx.ReadOnly = True

        pricepernight_txtbx.ReadOnly = True
    End Sub
End Class