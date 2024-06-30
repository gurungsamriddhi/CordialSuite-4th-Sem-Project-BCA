Imports System.IO

Public Class roomselectionform
    Dim managerooms As New roomsSql()
    Private reservationForm As Reservation

    ' Constructor to accept Reservation form instance to send the values to reservationform
    Public Sub New(reservation As Reservation)
        InitializeComponent()
        Me.reservationForm = reservation
    End Sub

    Private Sub roomselectionform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populaterooms()
    End Sub

    Private Sub populaterooms()

        Dim query As String = "SELECT *FROM rooms"
        managerooms.ExecuteQuery(query, DGV_Rooms)
        DGV_Rooms.DefaultCellStyle.BackColor = Color.White
        DGV_Rooms.DefaultCellStyle.ForeColor = Color.Black
        DGV_Rooms.AlternatingRowsDefaultCellStyle = Nothing
    End Sub

    Private Sub DGV_Rooms_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Rooms.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DGV_Rooms.Rows(e.RowIndex)
            Dim roomID As Integer = Integer.Parse(selectedRow.Cells("roomID").Value.ToString())
            Dim roomNumber As String = selectedRow.Cells("Roomnumber").Value.ToString()
            Dim roomType As String = selectedRow.Cells("Roomtype").Value.ToString()
            Dim bedCount As String = selectedRow.Cells("BedCount").Value.ToString()
            Dim pricepernight As Decimal = Decimal.Parse(selectedRow.Cells("Pricepernight").Value.ToString())

            reservationForm.AddRoomSelection(roomID, roomNumber, roomType, bedCount, pricepernight)
            Me.Close()
        End If
    End Sub


End Class
