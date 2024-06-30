Public Class admindashboardform
    Dim usercount As New userssql()
    Dim roomscount As New roomsSql()
    Dim guestcount As New guestssql()

    Private Sub admindashboardform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateDashboardCounts()
    End Sub

    Private Sub UpdateDashboardCounts()
        lbl_nusersshow.Text = GetUserCount().ToString()
        Lbl_nroomsshow.Text = GetRoomCount().ToString()
        Lbl_nfemaleshow.Text = GetFemaleGuestCount().ToString()
        lbl_nmaleshow.Text = GetMaleGuestCount().ToString()
        Lbl_totguestshow.Text = GetTotalGuestCount().ToString()

    End Sub

    Private Function GetUserCount() As Integer
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE UserType = 'User'"
        Return usercount.ExecuteScalar(query)
    End Function

    Private Function GetRoomCount() As Integer
        Dim query As String = "SELECT COUNT(*) FROM Rooms"
        Return roomscount.ExecuteScalar(query)
    End Function

    Private Function GetFemaleGuestCount() As Integer
        Dim query As String = "SELECT COUNT(*) FROM guests WHERE Gender = 'Female'"
        Return guestcount.ExecuteScalar(query)
    End Function

    Private Function GetMaleGuestCount() As Integer
        Dim query As String = "SELECT COUNT(*) FROM guests WHERE Gender = 'Male'"
        Return guestcount.ExecuteScalar(query)
    End Function

    Private Function GetTotalGuestCount() As Integer
        Dim query As String = "SELECT COUNT(*) FROM guests"
        Return guestcount.ExecuteScalar(query)
    End Function
End Class
