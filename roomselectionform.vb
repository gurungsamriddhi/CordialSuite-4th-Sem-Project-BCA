Public Class roomselectionform
    Dim managerooms As New roomsSql()
    Private selectedRooms As New List(Of DataGridViewRow)
    Private reservationForm As Reservation

    ' Constructor to accept Reservation form instance
    Public Sub New(reservation As Reservation)
        InitializeComponent()
        Me.reservationForm = reservation
    End Sub

    Private Sub roomselectionform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populaterooms()
    End Sub
    Private Sub populaterooms()

        Dim query As String = "SELECT * FROM rooms"
        managerooms.ExecuteQuery(query, DGV_Rooms)
        DGV_Rooms.DefaultCellStyle.BackColor = Color.White
        DGV_Rooms.DefaultCellStyle.ForeColor = Color.Black
        DGV_Rooms.AlternatingRowsDefaultCellStyle = Nothing
    End Sub

    Private Sub DGV_Rooms_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Rooms.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DGV_Rooms.Rows(e.RowIndex)
            If Not selectedRooms.Contains(selectedRow) Then
                selectedRooms.Add(selectedRow)
                ' Optionally, you can highlight selected rows for visual feedback
                selectedRow.DefaultCellStyle.BackColor = Color.LightBlue
            Else
                MessageBox.Show("This room is already selected.", "Room Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub confirmSelection_btn_Click(sender As Object, e As EventArgs) Handles confirmSelection_btn.Click


        ' Process selected rooms
        For Each roomRow As DataGridViewRow In selectedRooms
            Dim roomID As Integer = Integer.Parse(roomRow.Cells("roomID").Value.ToString())
            Dim roomNumber As String = roomRow.Cells("Roomnumber").Value.ToString()
            Dim roomType As String = roomRow.Cells("Roomtype").Value.ToString()
            Dim bedCount As String = roomRow.Cells("BedCount").Value.ToString()

            reservationForm.AddRoomSelection(roomID, roomNumber, roomType, bedCount)
        Next

        Me.Close()
    End Sub


End Class