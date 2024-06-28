Public Class checkin

    Private Sub Closebtn_Click(sender As Object, e As EventArgs)
        Dispose
        End

    End Sub

    Private Sub Checkinbtn_Click(sender As Object, e As EventArgs) Handles checkinbtn.Click
        Dim guestID As Integer = GuestID_cmbbx.SelectedItem
        Dim arrivaldate As Date = arrivaldate_DTP.Value
        Dim arrivaltime As DateTime = arrivaltime_DTP.Value
        Dim noofguests As Integer = guestnumber_NUD.Value
        Dim reserveddays As Integer = Reserveddays_txtbx.Text.Trim
        Dim checkoutdate As Date = checkoutdate_DTP.Value
        Dim checkouttime As DateTime = checkouttime_DTP.Value
        Dim noofrooms As Integer = roomno_cmbbxbx.SelectedItem
        Dim roomtype As String = Roomtype_cmbbx.SelectedItem







    End Sub

    Private Sub GuestID_cmbbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GuestID_cmbbx.SelectedIndexChanged

        If GuestID_cmbbx.SelectedIndex <> -1 Then
            Lbl_msgguestid.Text = "" ' Clear error message if a valid item is selected
        Else
            Lbl_msgguestid.Text = "Please select a guest ID."
        End If
    End Sub

    Private Sub Arrivaldate_DTP_ValueChanged(sender As Object, e As EventArgs) Handles arrivaldate_DTP.ValueChanged
        Dim validmindate As Date = Date.Today.AddYears(-100)

        If arrivaldate_DTP.Value >= validmindate Then
            Lbl_msgarrivaldate.Text = "" ' Clear error message if valid date
        ElseIf arrivaldate_DTP.Value = Date.MinValue Then
            arrivaldate_DTP.Value = Date.Today ' Set default value to today if no date is selected
        Else
            Lbl_msgarrivaldate.Text = "Please select a valid arrival date (today or later)."
        End If

    End Sub


    Private Sub Arrivaltime_DTP_ValueChanged(sender As Object, e As EventArgs) Handles arrivaltime_DTP.ValueChanged
        If arrivaltime_DTP.Value < arrivaltime_DTP.MinDate Then
            ' Set the default time to the current time
            arrivaltime_DTP.Value = DateTime.Now
        End If
    End Sub


    Private Sub Guestnumber_NUD_ValueChanged(sender As Object, e As EventArgs) Handles guestnumber_NUD.ValueChanged

    End Sub

    Private Sub Reserveddays_txtbx_TextChanged(sender As Object, e As EventArgs) Handles Reserveddays_txtbx.TextChanged
        Dim input As String = Reserveddays_txtbx.Text.Trim()
        Dim days As Integer

        If Integer.TryParse(input, days) Then
            If days > 0 AndAlso days <= 30 Then ' Assuming maximum reservation is 30 days
                ' Valid input, clear any error message
                Lbl_msgdaysreserved.Text = ""
            Else
                ' Show error message for invalid number of days
                Lbl_msgdaysreserved.Text = "Please enter a valid number of days (1-30)."
            End If
        Else
            ' Show error message for non-numeric input
            Lbl_msgdaysreserved.Text = "Please enter a valid number of days (1-30)."
        End If
    End Sub




    Private Sub Roomtype_cmbbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Roomtype_cmbbx.SelectedIndexChanged
        'Lblroomtype
    End Sub

    Private Sub Checkoutdate_DTP_ValueChanged(sender As Object, e As EventArgs) Handles checkoutdate_DTP.ValueChanged
        ' Lbl_msgcheckout
    End Sub

    Private Sub Checkouttime_DTP_ValueChanged(sender As Object, e As EventArgs) Handles checkouttime_DTP.ValueChanged

    End Sub

    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click

    End Sub

    Private Sub Checkin_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Roomno_cmbbxbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles roomno_cmbbxbx.SelectedIndexChanged
        Dim selectedRoom As Integer

        If Integer.TryParse(roomno_cmbbxbx.SelectedItem.ToString(), selectedRoom) Then
            ' Input is a valid integer, do further processing if needed
            Lbl_msgroomno.Text = "" ' Clear any previous error message
        Else
            ' Input is not a valid integer, show error message
            Lbl_msgroomno.Text = "Please select a valid room number."
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Application.Exit

    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs)

    End Sub
End Class