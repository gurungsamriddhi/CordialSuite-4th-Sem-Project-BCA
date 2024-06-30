Public Class userdashboardform
    Dim reservationcounts As New reservationsSql()

  Private Sub UpdateDashboardCounts()
        Lbl_nroomsshow.Text = GettotalroomsCount().ToString()
        Lbl_totguestshow.Text = GettotalguestsCount().ToString()
        Lbl_roomsavailableshow.Text = GetavailableroomsCount().ToString()
        Lbl_nfemaleshow.Text = GetfemaleguestCount().ToString()
        lbl_nmaleshsow.Text = getmaleguestscount().tostring()
        lbl_Reservedroomshow.Text = GetreservedroomsCount().ToString()
    End Sub

    Private Function GettotalguestsCount() As Integer
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE UserType= 'Admin'"
        Return reservationcounts.ExecuteScalar(query)
    End Function

    Private Function GettotalroomsCount() As Integer
        Dim query As String = "SELECT COUNT(*) FROM rooms"
        Return reservationcounts.ExecuteScalar(query)
    End Function
    Private Function GetreservedroomsCount() As Integer
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE UserType = 'User'"
        Return reservationcounts.ExecuteScalar(query)
    End Function

    Private Function GetavailableroomsCount() As Integer
        Dim query As String = "SELECT COUNT(*) FROM Rooms"
        Return reservationcounts.ExecuteScalar(query)
    End Function

    Private Function GetfemaleguestCount() As Integer
        Dim query As String = "SELECT COUNT(*) FROM Rooms"
        Return reservationcounts.ExecuteScalar(query)
    End Function
    Private Function GetmaleguestsCount() As Integer
        Dim query As String = "SELECT COUNT(*) FROM Rooms"
        Return reservationcounts.ExecuteScalar(query)
    End Function


    Private Sub userdashboardform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateDashboardCounts()
    End Sub
End Class