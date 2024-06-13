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

    Public Sub clear()
        Dim ID As String = ""
        ' Clear all text boxes
        userfn_txtbx.Clear()
        userln_txtbx.Clear()
        userPhone_txtbx.Clear()
        userAddress_txtbx.Clear()
        password_txtbx.Clear()
        gender_cmbbx.Items.Clear()
        gender_cmbbx.Items.Add("Male")
        gender_cmbbx.Items.Add("Female")
        gender_cmbbx.Items.Add("Other")
        gender_cmbbx.Text = String.Empty
        usertype_cmbbx.Items.Clear()
        usertype_cmbbx.Items.Add("Admin")
        usertype_cmbbx.Items.Add("User")
        usertype_cmbbx.Text = String.Empty
        userDOB_dtp.Value = Date.Today.AddYears(-18)
        ID = ""

        Tabcontrolusers.SelectedTab = update_deletetabpage
    End Sub


    'Private Sub updateuser_Btn_Click(sender As Object, e As EventArgs) Handles updateuser_Btn.Click
    '    If usertype_cmbbx.SelectedItem Is Nothing OrElse String.IsNullOrWhiteSpace(UD_usernametxtbx.Text) OrElse
    '       String.IsNullOrWhiteSpace(UD_passwordtxtbx.Text) Then
    '        MessageBox.Show("Please fill out all fields.", "Require all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

    Public Sub populateUsers()

        Dim query As String = "SELECT * FROM users WHERE Usertype IN ('admin', 'user')"
        Dim dataTable As DataTable = sqlConnector.ExecuteQuery(query)
        DGV_users.DataSource = dataTable
        DGV_users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DGV_users.AutoGenerateColumns = True
        DGV_users.DefaultCellStyle.BackColor = Color.White
        DGV_users.DefaultCellStyle.ForeColor = Color.Black
        DGV_users.AlternatingRowsDefaultCellStyle = Nothing

    End Sub

    Private Sub viewuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateUsers()

    End Sub

    Private Sub searchusername_txtbx_Enter(sender As Object, e As EventArgs) Handles searchusername_txtbx.Enter
        sqlConnector.SearchUsers("SELECT * FROM users WHERE Usertype IN ('admin', 'user')", DGV_users)

    End Sub


    Private Sub DGV_users_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_users.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DGV_users.Rows(e.RowIndex)
            Dim age As Integer = Convert.ToInt32(selectedRow.Cells("Age").Value)
            Dim dob As Date = Date.Today.AddYears(-age)
            Dim userType As String = selectedRow.Cells("UserType").Value.ToString()
            Dim gender As String = selectedRow.Cells("Gender").Value.ToString()
            Dim firstName As String = selectedRow.Cells("FirstName").Value.ToString()
            Dim lastName As String = selectedRow.Cells("LastName").Value.ToString()
            Dim address As String = selectedRow.Cells("Address").Value.ToString()
            Dim phone As String = selectedRow.Cells("PhoneNumber").Value.ToString()
            Dim username As String = selectedRow.Cells("Username").Value.ToString()
            Dim password As String = selectedRow.Cells("Password").Value.ToString()

            userDOB_dtp.Value = dob
            usertype_cmbbx.SelectedItem = userType
            gender_cmbbx.SelectedItem = gender
            userfn_txtbx.Text = firstName
            userln_txtbx.Text = lastName
            userAddress_txtbx.Text = address
            userPhone_txtbx.Text = phone
            username_txtbx.Text = username
            password_txtbx.Text = password
            Dim id As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)

        End If
    End Sub

    Private Sub searchusername_txtbx_Leave(sender As Object, e As EventArgs) Handles searchusername_txtbx.Leave
        searchusername_txtbx.Clear()
    End Sub

    Private Sub updateuser_Btn_Click(sender As Object, e As EventArgs) Handles updateuser_Btn.Click

    End Sub

    Private Sub deluser_Btn_Click(sender As Object, e As EventArgs) Handles deluser_Btn.Click

    End Sub


    Private Sub TabPageViewUser_Enter(sender As Object, e As EventArgs) Handles TabPageViewUser.Enter
        searchusername_txtbx.Clear()
    End Sub

    Private Sub TabPageViewUser_Leave(sender As Object, e As EventArgs) Handles TabPageViewUser.Leave
        searchusername_txtbx.Clear()
    End Sub
End Class
