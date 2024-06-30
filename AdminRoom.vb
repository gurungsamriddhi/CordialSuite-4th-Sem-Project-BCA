Imports System.ComponentModel.Design
Imports System.Data.SqlClient

Public Class AdminRoom
    Dim managerooms As New roomsSql()
    Private originalroomnumber As String

    Private Sub AdminRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populaterooms()
    End Sub

    Private Sub populaterooms()

        Dim query As String = "SELECT * FROM rooms"
        managerooms.ExecuteQuery(query, DGV_Rooms)
        DGV_Rooms.DefaultCellStyle.BackColor = Color.White
        DGV_Rooms.DefaultCellStyle.ForeColor = Color.Black
        DGV_Rooms.AlternatingRowsDefaultCellStyle = Nothing
    End Sub

    Private Sub searchrooms_txtbx_TextChanged(sender As Object, e As EventArgs) Handles searchrooms_txtbx.TextChanged
        FilterroomsByKeyword(searchrooms_txtbx.Text.Trim())
    End Sub

    Private Sub FilterroomsByKeyword(keyword As String)
        Dim query As String = "SELECT * FROM rooms where
                          ( CAST(roomID AS VARCHAR) LIKE @Keyword OR 
                           Roomnumber LIKE @Keyword OR 
                           Roomtype LIKE @Keyword OR
                           BedCount LIKE @Keyword OR 
                           RoomStatus LIKE @keyword OR
                           Pricepernight LIKE @Keyword)"
        managerooms.SearchRooms(query, keyword, DGV_Rooms)
    End Sub
    Private Sub TabControlrooms_Enter(sender As Object, e As EventArgs) Handles TabControlrooms.Enter
        populaterooms()
    End Sub

    Private Sub TabPageviewrooms_Leave(sender As Object, e As EventArgs) Handles TabPageviewrooms.Leave
        searchrooms_txtbx.Clear()
    End Sub

    Private Sub TabPagemanagerooms_Leave(sender As Object, e As EventArgs) Handles TabPagemanagerooms.Leave
        roomnumber_txtbx.Clear()
        pricepernight_txtbx.Clear()
        bedcount_cmbbx.SelectedIndex = -1
        roomtype_cmbbx.SelectedIndex = -1
        roomstatus_cmbbx.SelectedIndex = -1

        Lbl_roomid.Text = String.Empty
        Lbl_roomidshow.Text = String.Empty
        Lbl_msgbedcount.Text = String.Empty
        Lbl_msgpricepernight.Text = String.Empty
        Lbl_msgroomno.Text = String.Empty
        Lbl_msgroomstatus.Text = String.Empty
        Lbl_msgroomtype.Text = String.Empty


    End Sub

    Private Sub addroom_btn_Click(sender As Object, e As EventArgs) Handles addroom_btn.Click
        Dim isValid As Boolean = True

        ' Validate Room Number
        Dim roomnumber As Integer
        If String.IsNullOrEmpty(roomnumber) AndAlso Not Integer.TryParse(roomnumber_txtbx.Text.Trim(), roomnumber) OrElse roomnumber <= 0 OrElse roomnumber < 100 OrElse roomnumber > 1000 Then
            isValid = False
            Lbl_msgroomno.Text = "Invalid Room Number. It must be between 100 and 1000."
            Lbl_msgroomno.ForeColor = Color.Red
            roomnumber_txtbx.Focus()

        Else
            Lbl_msgroomno.Text = ""
        End If

        If managerooms.RoomExists(roomnumber) OrElse Not String.IsNullOrEmpty(Lbl_roomidshow.Text) Then
            isValid = False
            MessageBox.Show("Room number already exists or Room ID is provided. You can only update existing rooms.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            roomnumber_txtbx.Focus()
            Exit Sub
        End If

        ' Validate Room Status
        Dim roomstatus As String = If(roomstatus_cmbbx.SelectedItem IsNot Nothing, roomstatus_cmbbx.SelectedItem.ToString(), "")
        If String.IsNullOrEmpty(roomstatus) Then
            isValid = False
            Lbl_msgroomstatus.Text = "Invalid Room Status."
            Lbl_msgroomstatus.ForeColor = Color.Red
        Else
            Lbl_msgroomstatus.Text = ""
        End If

        ' Validate Bed Count
        Dim bedcount As String = If(bedcount_cmbbx.SelectedItem IsNot Nothing, bedcount_cmbbx.SelectedItem.ToString(), "")
        If String.IsNullOrEmpty(bedcount) Then
            isValid = False
            Lbl_msgbedcount.Text = "Invalid Bed Count."
            Lbl_msgbedcount.ForeColor = Color.Red
        Else
            Lbl_msgbedcount.Text = ""
        End If

        ' Validate Room Type
        Dim roomtype As String = If(roomtype_cmbbx.SelectedItem IsNot Nothing, roomtype_cmbbx.SelectedItem.ToString(), "")
        If String.IsNullOrEmpty(roomtype) Then
            isValid = False
            Lbl_msgroomtype.Text = "Invalid Room Type."
            Lbl_msgroomtype.ForeColor = Color.Red
        Else
            Lbl_msgroomtype.Text = ""
        End If

        ' Validate Price per Night
        Dim pricepernight As Decimal
        If String.IsNullOrEmpty(pricepernight) AndAlso Not Decimal.TryParse(pricepernight_txtbx.Text.Trim(), pricepernight) OrElse pricepernight <= 0 Then
            isValid = False
            Lbl_msgpricepernight.Text = "Invalid Price per Night."
            Lbl_msgpricepernight.ForeColor = Color.Red
        Else
            Lbl_msgpricepernight.Text = ""
        End If

        ' If any validation failed, show error message and exit
        If Not isValid Then
            MessageBox.Show("Please fill out all the fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Insert the room information into the database
        Dim query As String = "INSERT INTO rooms (RoomType, Roomnumber, BedCount, RoomStatus, Pricepernight) " &
                      "VALUES (@RoomType, @Roomnumber, @BedCount, @RoomStatus, @Pricepernight)"

        Dim parameters As New List(Of SqlParameter)()
        parameters.Add(New SqlParameter("@RoomType", roomtype))
        parameters.Add(New SqlParameter("@Roomnumber", roomnumber))
        parameters.Add(New SqlParameter("@BedCount", bedcount))
        parameters.Add(New SqlParameter("@RoomStatus", roomstatus))
        parameters.Add(New SqlParameter("@Pricepernight", pricepernight))

        ' Execute the insertion query
        Try
            managerooms.ExecuteNonQueryWithParameters(query, parameters)
            MessageBox.Show("Room added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            populaterooms() ' Refresh the DataGridView after adding the room
        Catch ex As Exception
            MessageBox.Show("Error adding room: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub DGV_Rooms_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Rooms.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DGV_Rooms.Rows(e.RowIndex)

            Dim roomid As String = selectedRow.Cells("roomID").Value.ToString()
            Dim roomtype As String = selectedRow.Cells("Roomtype").Value.ToString()
            originalroomnumber = selectedRow.Cells("Roomnumber").Value.ToString()
            Dim bedcount As String = selectedRow.Cells("BedCount").Value.ToString()
            Dim roomstatus As String = selectedRow.Cells("RoomStatus").Value.ToString()
            Dim pricepernight As String = selectedRow.Cells("Pricepernight").Value.ToString()
            Lbl_roomid.Text = " Room ID:"
            Lbl_roomidshow.Text = roomid
            roomstatus_cmbbx.SelectedItem = roomstatus
            pricepernight_txtbx.Text = pricepernight
            roomtype_cmbbx.SelectedItem = roomtype
            roomnumber_txtbx.Text = originalroomnumber
            bedcount_cmbbx.SelectedItem = bedcount

        End If
    End Sub
    Private Sub TabPageviewrooms_Enter(sender As Object, e As EventArgs) Handles TabPageviewrooms.Enter
        populaterooms()
    End Sub

    Private Sub updateroom_btn_Click(sender As Object, e As EventArgs) Handles updateroom_btn.Click
        Dim isValid As Boolean = True
        If String.IsNullOrEmpty(Lbl_roomidshow.Text) Then
            MessageBox.Show("Please select a room to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim roomid As Integer = Convert.ToInt32(Lbl_roomidshow.Text.Trim())
        ' Validate Room Number
        Dim roomnumber As Integer
        If Not Integer.TryParse(roomnumber_txtbx.Text.Trim(), roomnumber) OrElse roomnumber <= 0 OrElse roomnumber < 100 OrElse roomnumber > 1000 Then
            isValid = False
            Lbl_msgroomno.Text = "Invalid Room Number. It must be between 100 and 1000."
            Lbl_msgroomno.ForeColor = Color.Red
            roomnumber_txtbx.Focus()
            Exit Sub
        Else
            Lbl_msgroomno.Text = ""
        End If

        ' Check if the room number is unique and changed
        If roomnumber <> CInt(originalroomnumber) Then
            If managerooms.RoomExists(roomnumber) Then
                isValid = False
                MessageBox.Show("Room already exists with this number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                roomnumber_txtbx.Focus()
                Exit Sub
            End If
        End If
        ' Validate Room Status
        Dim roomstatus As String = If(roomstatus_cmbbx.SelectedItem IsNot Nothing, roomstatus_cmbbx.SelectedItem.ToString(), "")
        If String.IsNullOrEmpty(roomstatus) Then
            isValid = False
            Lbl_msgroomstatus.Text = "Invalid Room Status."
            Lbl_msgroomstatus.ForeColor = Color.Red
        Else
            Lbl_msgroomstatus.Text = ""
        End If

        ' Validate Bed Count
        Dim bedcount As String = If(bedcount_cmbbx.SelectedItem IsNot Nothing, bedcount_cmbbx.SelectedItem.ToString(), "")
        If String.IsNullOrEmpty(bedcount) Then
            isValid = False
            Lbl_msgbedcount.Text = "Invalid Bed Count."
            Lbl_msgbedcount.ForeColor = Color.Red
        Else
            Lbl_msgbedcount.Text = ""
        End If

        ' Validate Room Type
        Dim roomtype As String = If(roomtype_cmbbx.SelectedItem IsNot Nothing, roomtype_cmbbx.SelectedItem.ToString(), "")
        If String.IsNullOrEmpty(roomtype) Then
            isValid = False
            Lbl_msgroomtype.Text = "Invalid Room Type."
            Lbl_msgroomtype.ForeColor = Color.Red
        Else
            Lbl_msgroomtype.Text = ""
        End If

        ' Validate Price per Night
        Dim pricepernight As Decimal
        If Not Decimal.TryParse(pricepernight_txtbx.Text.Trim(), pricepernight) OrElse pricepernight <= 0 Then
            isValid = False
            Lbl_msgpricepernight.Text = "Invalid Price per Night."
            Lbl_msgpricepernight.ForeColor = Color.Red
        Else
            Lbl_msgpricepernight.Text = ""
        End If

        ' If any validation failed, show error message and exit
        If Not isValid Then
            MessageBox.Show("Please fill out all the fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' If any validation failed, show error message and exit
        If Not isValid Then
            MessageBox.Show("Please fill out all the fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Update the room information in the database only if there's a change in room number
        Dim query As String = "UPDATE rooms SET RoomType = @RoomType, Roomnumber = @Roomnumber, BedCount = @BedCount, RoomStatus = @RoomStatus, Pricepernight = @Pricepernight " &
                      "WHERE roomID = @roomID"

        Dim parameters As New List(Of SqlParameter)()
        parameters.Add(New SqlParameter("@RoomType", roomtype))
        parameters.Add(New SqlParameter("@Roomnumber", roomnumber))
        parameters.Add(New SqlParameter("@BedCount", bedcount))
        parameters.Add(New SqlParameter("@RoomStatus", roomstatus))
        parameters.Add(New SqlParameter("@Pricepernight", pricepernight))
        parameters.Add(New SqlParameter("@roomID", roomid))

        ' Execute the update query
        Try
            managerooms.ExecuteNonQueryWithParameters(query, parameters)
            MessageBox.Show("Room updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            populaterooms() ' Refresh the DataGridView after updating the room
        Catch ex As Exception
            MessageBox.Show("Error updating room: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub deleteroom_btn_Click(sender As Object, e As EventArgs) Handles deleteroom_btn.Click
        If String.IsNullOrEmpty(Lbl_roomidshow.Text) Then
            MessageBox.Show("Please select a room to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Ask for confirmation before deleting
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this room?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            ' Proceed with deletion
            Dim roomID As Integer
            If Not Integer.TryParse(Lbl_roomidshow.Text, roomID) Then
                MessageBox.Show("Invalid Room ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim query As String = "DELETE FROM rooms WHERE roomID = @roomID"
            Dim parameters As New List(Of SqlParameter)()
            parameters.Add(New SqlParameter("@roomID", roomID))

            ' Execute the delete query
            Try
                managerooms.ExecuteNonQueryWithParameters(query, parameters)
                MessageBox.Show("Room deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                populaterooms() ' Refresh the DataGridView after deleting the room
                roomnumber_txtbx.Clear()
                pricepernight_txtbx.Clear()
                bedcount_cmbbx.SelectedIndex = -1
                roomtype_cmbbx.SelectedIndex = -1
                roomstatus_cmbbx.SelectedIndex = -1

                Lbl_roomid.Text = String.Empty
                Lbl_roomidshow.Text = String.Empty
                Lbl_msgbedcount.Text = String.Empty
                Lbl_msgpricepernight.Text = String.Empty
                Lbl_msgroomno.Text = String.Empty
                Lbl_msgroomstatus.Text = String.Empty
                Lbl_msgroomtype.Text = String.Empty

            Catch ex As Exception
                MessageBox.Show("Error deleting room: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        roomnumber_txtbx.Clear()
        pricepernight_txtbx.Clear()
        bedcount_cmbbx.SelectedIndex = -1
        roomtype_cmbbx.SelectedIndex = -1
        roomstatus_cmbbx.SelectedIndex = -1

        Lbl_roomid.Text = String.Empty
        Lbl_roomidshow.Text = String.Empty
        Lbl_msgbedcount.Text = String.Empty
        Lbl_msgpricepernight.Text = String.Empty
        Lbl_msgroomno.Text = String.Empty
        Lbl_msgroomstatus.Text = String.Empty
        Lbl_msgroomtype.Text = String.Empty

    End Sub
End Class