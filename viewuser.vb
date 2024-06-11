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
        UD_usertypecmbbx.Items.Clear()
        UD_usernametxtbx.Clear()
        UD_passwordtxtbx.Clear()
        Tabcontrolusers.SelectedTab = update_deletetabpage
    End Sub

    Private Sub updateuser_Btn_Click(sender As Object, e As EventArgs) Handles updateuser_Btn.Click
        If UD_usertypecmbbx.SelectedItem Is Nothing OrElse String.IsNullOrWhiteSpace(UD_usernametxtbx.Text) OrElse
           String.IsNullOrWhiteSpace(UD_passwordtxtbx.Text) Then
            MessageBox.Show("Please fill out all fields.", "Require all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub populateUsers()
        Dim query As String = "SELECT id, Usertype, Username, Password FROM users WHERE Usertype IN ('admin', 'user')"
        Dim dataTable As DataTable = sqlConnector.ExecuteQuery(query)

        ' Assuming you have a DataGridView control named DataGridViewUsers
        DGV_users.DataSource = dataTable
    End Sub

    Private Sub viewuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateUsers()
        DGV_users.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        DGV_users.AutoGenerateColumns = False
    End Sub
End Class
