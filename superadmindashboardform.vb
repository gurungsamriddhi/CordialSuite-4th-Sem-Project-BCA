Public Class superadmindashboardform
    Dim usercount As New userssql()
    Dim guestcount As New guestssql()
    Dim roomcount As New roomsSql()
    Private Sub superadmindashboardform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateDashboardCounts()
    End Sub

    Private Sub pnl_Admin_Paint(sender As Object, e As PaintEventArgs) Handles pnl_Admin.Paint
        ' Update admin count label
        Lbl_nadminsshow.Text = GetAdminCount().ToString()
    End Sub

    Private Sub Pnl_users_Paint(sender As Object, e As PaintEventArgs) Handles Pnl_users.Paint
        ' Update user count label
        lbl_nusershow.Text = GetUserCount().ToString()
    End Sub

    Private Sub Pnl_Rooms_Paint(sender As Object, e As PaintEventArgs) Handles Pnl_Rooms.Paint
        ' Update room count label
        Lbl_nroomsshow.Text = GetRoomCount().ToString()
    End Sub

    Private Sub Pnl_totguests_Paint(sender As Object, e As PaintEventArgs) Handles Pnl_totguests.Paint
        ' Update total guests count label
        Lbl_totguestshow.Text = GetGuestCount().ToString()
    End Sub

    Private Sub UpdateDashboardCounts()
        Lbl_nadminsshow.Text = GetAdminCount().ToString()
        lbl_nusershow.Text = GetUserCount().ToString()
        Lbl_nroomsshow.Text = GetRoomCount().ToString()
        Lbl_totguestshow.Text = GetGuestCount().ToString()
    End Sub

    Private Function GetAdminCount() As Integer
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE UserType= 'Admin'"
        Return usercount.ExecuteScalar(query)
    End Function

    Private Function GetUserCount() As Integer
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE UserType = 'User'"
        Return usercount.ExecuteScalar(query)
    End Function

    Private Function GetRoomCount() As Integer
        Dim query As String = "SELECT COUNT(*) FROM Rooms"
        Return roomcount.ExecuteScalar(query)
    End Function

    Private Function GetGuestCount() As Integer
        Dim query As String = "SELECT COUNT(*) FROM Guests"
        Return guestcount.ExecuteScalar(query)
    End Function
End Class
