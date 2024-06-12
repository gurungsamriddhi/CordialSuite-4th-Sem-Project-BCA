Imports System.Data.SqlClient

Public Class viewuser

    Dim sqlConnector As New sql.sqlconnector()

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show("Do you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Close()
            Loginform.Show()
            Loginform.txtbxusername.Clear()
            Loginform.txtbxpassword.Clear()
        End If
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Application.Exit()
    End Sub

    'Public Sub clear()
    '    usertype_cmbbx.Items.Clear()
    '    password_txtbx.Clear()
    '    Tabcontrolusers.SelectedTab = update_deletetabpage
    'End Sub

    'Private Sub updateuser_Btn_Click(sender As Object, e As EventArgs) Handles updateuser_Btn.Click
    '    If usertype_cmbbx.SelectedItem Is Nothing OrElse String.IsNullOrWhiteSpace(UD_usernametxtbx.Text) OrElse
    '       String.IsNullOrWhiteSpace(UD_passwordtxtbx.Text) Then
    '        MessageBox.Show("Please fill out all fields.", "Require all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

    Public Sub populateUsers()
        ' Adjust the query to select all columns from the users table
        Dim query As String = "SELECT * FROM users WHERE Usertype IN ('admin', 'user')"
        Dim dataTable As DataTable = sqlConnector.ExecuteQuery(query)

        ' Assuming you have a DataGridView control named DGV_users
        DGV_users.DataSource = dataTable

        DGV_users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DGV_users.AutoGenerateColumns = True ' Allow columns to be automatically generate

        ' Ensure styles are correctly set
        DGV_users.DefaultCellStyle.BackColor = Color.White
        DGV_users.DefaultCellStyle.ForeColor = Color.Black
        DGV_users.AlternatingRowsDefaultCellStyle = Nothing ' Or set to a proper style
    End Sub

    Private Sub viewuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateUsers()

    End Sub

    Private Sub UD_usertypecmbbx_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub searchusername_txtbx_Enter(sender As Object, e As EventArgs) Handles searchusername_txtbx.Enter
        sqlConnector.SearchUsers("SELECT * FROM users WHERE Usertype IN ('admin', 'user')", DGV_users)

    End Sub


    Private Sub DGV_users_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_users.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DGV_users.Rows(e.RowIndex)

            ' Access data from the selected row
            Dim dob As Date = CDate(selectedRow.Cells("UserDOB").Value)
            Dim userType As String = selectedRow.Cells("UserType").Value.ToString()
            Dim gender As String = selectedRow.Cells("Gender").Value.ToString()
            Dim lastName As String = selectedRow.Cells("LastName").Value.ToString()
            Dim address As String = selectedRow.Cells("Address").Value.ToString()
            Dim phone As String = selectedRow.Cells("Phone").Value.ToString()
            Dim username As String = selectedRow.Cells("Username").Value.ToString()
            Dim password As String = selectedRow.Cells("Password").Value.ToString()

            ' Set values to controls
            userDOB_dtp.Value = dob
            usertype_cmbbx.SelectedItem = userType
            gender_cmbbx.SelectedItem = gender
            userln_txtbx.Text = lastName
            userAddress_txtbx.Text = address
            userPhone_txtbx.Text = phone
            username_txtbx.Text = username
            password_txtbx.Text = password

            ' You can decide what to do with the ID value, such as storing it in a hidden field or variable.
            Dim id As Integer = Convert.ToInt32(selectedRow.Cells("ID").Value)

        End If
    End Sub

    Private Sub searchusername_txtbx_Leave(sender As Object, e As EventArgs) Handles searchusername_txtbx.Leave
        searchusername_txtbx.Clear()
    End Sub

    Private Sub updateuser_Btn_Click(sender As Object, e As EventArgs) Handles updateuser_Btn.Click

    End Sub

    Private Sub deluser_Btn_Click(sender As Object, e As EventArgs) Handles deluser_Btn.Click

    End Sub
End Class
