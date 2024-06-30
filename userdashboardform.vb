Public Class userdashboardform
    Dim reservationcounts As New reservationsSql()

  Private Sub UpdateDashboardCounts()

        Lbl_totguestshow.Text = GettotalguestsCount().ToString()
        Lbl_roomsavailableshow.Text = GetavailableroomsCount().ToString()
        Lbl_nfemaleshow.Text = GetfemaleguestCount().ToString()
        lbl_nmaleshsow.Text = getmaleguestscount().tostring()
        lbl_Reservedroomshow.Text = GetreservedroomsCount().ToString()
    End Sub

    Private Function GettotalguestsCount() As Integer
        Dim query As String = "SELECT SUM(NumberOfGuests) FROM reservations where status='Check-In'"
        Return reservationcounts.ExecuteScalar(query)
    End Function


    Private Function GetreservedroomsCount() As Integer
        Dim query As String = "SELECT COUNT(*) FROM reservations where Status='Check-In'"
        Return reservationcounts.ExecuteScalar(query)
    End Function

    Private Function GetavailableroomsCount() As Integer
        Dim query As String = "SELECT COUNT(*) FROM rooms " &
                          "LEFT JOIN reservations ON rooms.RoomID = reservations.RoomID " &
                          "AND reservations.Status IN ('Check-out', 'Cancelled') " &
                          "WHERE reservations.ReservationID IS NULL"
        Return reservationcounts.ExecuteScalar(query)
    End Function

    Private Function GetfemaleguestCount() As Integer
        Dim query As String = "SELECT COUNT(*) FROM guests " &
                     "INNER JOIN reservations ON guests.GuestID = reservations.GuestID " &
                     "WHERE guests.Gender = 'Female' AND reservations.Status = 'Check-In'"

        Return reservationcounts.ExecuteScalar(query)
    End Function
    Private Function GetmaleguestsCount() As Integer
        Dim query As String = "SELECT COUNT(*) FROM guests " &
                         "INNER JOIN reservations ON guests.GuestID = reservations.GuestID " &
                         "WHERE guests.Gender = 'Male'  AND reservations.Status = 'Check-In'"
        Return reservationcounts.ExecuteScalar(query)
    End Function


    Private Sub userdashboardform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateDashboardCounts()
    End Sub
End Class