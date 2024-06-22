Imports System.Data.SqlClient

Public Class viewuser

    Dim sqlConnector As New sql.sqlconnector()
    Public isValidInput As Boolean

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
        Tabcontrolusers.SelectedTab = update_deletetabpage
    End Sub

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
        TabPageViewUser_Enter(sender, e)
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
        End If
    End Sub

    Private Sub searchusername_txtbx_Leave(sender As Object, e As EventArgs) Handles searchusername_txtbx.Leave
        searchusername_txtbx.Clear()
    End Sub

    Private Sub updateuser_Btn_Click(sender As Object, e As EventArgs) Handles updateuser_Btn.Click


        inputvalidation()
        UpdateUser()
    End Sub

    Private Sub deluser_Btn_Click(sender As Object, e As EventArgs) Handles deluser_Btn.Click
        inputvalidation()

        Dim result = MessageBox.Show("Do you want to delete this user?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            DeleteUser(username_txtbx.Text)
        End If
    End Sub

    Private Sub TabPageViewUser_Enter(sender As Object, e As EventArgs) Handles TabPageViewUser.Enter
        populateUsers()
    End Sub

    Private Sub TabPageViewUser_Leave(sender As Object, e As EventArgs) Handles TabPageViewUser.Leave
        searchusername_txtbx.Clear()
    End Sub

    Private Sub searchusername_txtbx_TextChanged(sender As Object, e As EventArgs) Handles searchusername_txtbx.TextChanged
        FilterUsersByUsername(searchusername_txtbx.Text.Trim())
    End Sub

    Private Sub FilterUsersByUsername(username As String)
        Dim query As String = "SELECT * FROM users WHERE Usertype IN ('admin', 'user') AND Username LIKE @Username"
        sqlConnector.SearchUsers(query, username, DGV_users)
    End Sub

    Private Sub UpdateUser()
        Dim query As String = "UPDATE users SET FirstName = @FirstName, LastName = @LastName, Address = @Address, " &
                              "PhoneNumber = @PhoneNumber, Gender = @Gender, UserType = @UserType, Password = @Password, " &
                              "Age=@Age WHERE Username = @Username"

        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@FirstName", userfn_txtbx.Text),
            New SqlParameter("@LastName", userln_txtbx.Text),
            New SqlParameter("@Address", userAddress_txtbx.Text),
            New SqlParameter("@PhoneNumber", userPhone_txtbx.Text),
            New SqlParameter("@Gender", gender_cmbbx.SelectedItem.ToString()),
            New SqlParameter("@UserType", usertype_cmbbx.SelectedItem.ToString()),
            New SqlParameter("@Password", password_txtbx.Text),
            New SqlParameter("@Age", userDOB_dtp.Value),
            New SqlParameter("@Username", username_txtbx.Text)
        }

        sqlConnector.ExecuteNonQueryWithParameters(query, parameters)
        MessageBox.Show("User updated successfully.")
        populateUsers()
        clear()
    End Sub

    Private Sub DeleteUser(username As String)
        Dim query As String = "DELETE FROM users WHERE Username = @Username"
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@Username", username)
        }

        sqlConnector.ExecuteNonQueryWithParameters(query, parameters)
        MessageBox.Show("User deleted successfully.")
        populateUsers()
        clear()
    End Sub

    Private Sub Userfn_txtbx_TextChanged(sender As Object, e As EventArgs) Handles userfn_txtbx.TextChanged
        ' Check if the text in the textbox contains any non-alphabetic characters
        isValidInput = IsAlphabeticOnly(userfn_txtbx.Text)

        If isValidInput Then
            ' Clear the message in the label if the input is valid
            Lbl_msgfirstname.Text = ""
        Else
            ' Show a message in the label indicating that only alphabetic characters are allowed
            Lbl_msgfirstname.Text = "Please enter a valid name (alphabets only)."
        End If
    End Sub

    Private Function IsAlphabeticOnly(input As String) As Boolean     'function that checks if the values is alphabets or not

        For Each character As Char In input       ' Loop through each character in the input string

            If Not Char.IsLetter(character) Then      ' Check if the character is not an alphabetic character

                Return False         ' Return false if any non-alphabetic character is found
            End If
        Next


        Return True   ' Return true if all characters are alphabetic
    End Function

    Private Sub Userln_txtbx_TextChanged(sender As Object, e As EventArgs) Handles userln_txtbx.TextChanged
        isValidInput = IsAlphabeticOnly(userln_txtbx.Text)
        If isValidInput Then

            Lbl_msglastname.Text = ""
        Else

            Lbl_msglastname.Text = "Please enter a valid name (alphabets only)."
        End If
    End Sub

    Private Sub UserAddress_txtbx_TextChanged(sender As Object, e As EventArgs) Handles userAddress_txtbx.TextChanged
        If String.IsNullOrWhiteSpace(userAddress_txtbx.Text) Then
            ' Show a message in the label indicating that the address cannot be empty
            Lbl_msgaddress.Text = "Please enter a valid address."
        Else
            ' Clear the message in the label if the address is valid
            Lbl_msgaddress.Text = ""
        End If
    End Sub

    Private Sub UserDOB_dtp_ValueChanged(sender As Object, e As EventArgs) Handles userDOB_dtp.ValueChanged
        ' Define the minimum and maximum valid dates for validation
        Dim minValidDate As New Date(1900, 1, 1)
        Dim maxValidDate As Date = Date.Today.AddDays(-1) ' Ensure the user is at least one day old
        Dim selectedDate As Date = userDOB_dtp.Value

        ' Check if the selected date is within the valid range
        If selectedDate < minValidDate Then

            Lbl_msgDOB.Text = "Please select a valid date of birth between 01/01/1910 and yesterday."

        ElseIf selectedDate > maxValidDate Then

            Lbl_msgDOB.Text = "Date of birth cannot be set to the future."
        Else

            Lbl_msgDOB.Text = ""
        End If

    End Sub

    Private Sub Usertype_cmbbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles usertype_cmbbx.SelectedIndexChanged

        If usertype_cmbbx.SelectedIndex = -1 Then
            Lbl_msgusertype.Text = "Please select a valid user type."
        Else
            Lbl_msgusertype.Text = ""
        End If


    End Sub

    Private Sub UserPhone_txtbx_TextChanged(sender As Object, e As EventArgs) Handles userPhone_txtbx.TextChanged
        If Not IsPhoneNumber(userPhone_txtbx.Text) Then
            Lbl_msgphone.Text = "Please enter a valid phone number."
        Else
            Lbl_msgphone.Text = ""
        End If
    End Sub

    Private Sub Gender_cmbbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gender_cmbbx.SelectedIndexChanged
        If gender_cmbbx.SelectedIndex = -1 Then
            Lbl_msggender.Text = "Please select a valid gender."
        Else
            Lbl_msggender.Text = ""
        End If
    End Sub

    Private Sub Username_txtbx_TextChanged(sender As Object, e As EventArgs) Handles username_txtbx.TextChanged
        If username_txtbx.Text.Length < 5 Then
            Lbl_msgusername.Text = "Please enter a valid username (at least 5 characters)."
        Else
            Lbl_msgusername.Text = ""
        End If
    End Sub

    Private Sub Password_txtbx_TextChanged(sender As Object, e As EventArgs) Handles password_txtbx.TextChanged
        ' Check if the password contains at least one special character
        Dim hasSpecialChar As Boolean = password_txtbx.Text.Any(Function(c) Not Char.IsLetterOrDigit(c)) 'checks is anycaharacter in the password is specialchar or not


        If password_txtbx.Text.Length < 8 Then
            Lbl_msgpassword.Text = "Password must be at least 8 characters."
        ElseIf Not hasSpecialChar Then
            Lbl_msgpassword.Text = "Password must contain at least one special character."
        Else
            Lbl_msgpassword.Text = ""
        End If
    End Sub


    Private Sub Confirmpw_txtbx_TextChanged(sender As Object, e As EventArgs) Handles confirmpw_txtbx.TextChanged
        If password_txtbx.Text <> confirmpw_txtbx.Text Then
            Lbl_msgconfirmpw.Text = "Passwords do not match."
        Else
            Lbl_msgconfirmpw.Text = ""
        End If
    End Sub
    Private Function IsPhoneNumber(input As String) As Boolean
        ' Check if the input is numeric and has 10 digits
        Return input.All(AddressOf Char.IsDigit) AndAlso input.Length = 10
    End Function

    Private Function CalculateAge(selectedDate As Date) As Integer
        ' Calculate the age based on the selected date and today's date
        Dim age As Integer = Date.Now.Year - selectedDate.Year
        If selectedDate > Date.Now.AddYears(-age) Then
            age -= 1 ' Adjust the age if the birthday hasn't occurred yet this year
        End If

        Return age
    End Function

    Public Sub inputvalidation()

        Dim user_firstname As String = userfn_txtbx.Text.Trim()
        Dim user_lastname As String = userln_txtbx.Text.Trim()
        Dim user_address As String = userAddress_txtbx.Text.Trim()
        Dim user_dateofbirth As Date = userDOB_dtp.Value
        Dim user_type As String = If(usertype_cmbbx.SelectedItem IsNot Nothing, usertype_cmbbx.SelectedItem.ToString(), String.Empty)
        Dim user_gender As String = If(gender_cmbbx.SelectedItem IsNot Nothing, gender_cmbbx.SelectedItem.ToString(), String.Empty)
        Dim user_phone As String = userPhone_txtbx.Text.Trim()
        Dim user_username As String = username_txtbx.Text.Trim()
        Dim user_password As String = password_txtbx.Text.Trim()
        Dim user_confirmPassword As String = confirmpw_txtbx.Text.Trim()
        Dim user_Age As Integer = CalculateAge(userDOB_dtp.Value)



        ' Validation checks for each input field
        Dim isValid As Boolean = True

        If String.IsNullOrEmpty(user_firstname) OrElse Not IsAlphabeticOnly(user_firstname) OrElse user_firstname.Length <= 1 Then
            isValid = False
            Lbl_msgfirstname.Text = "Please enter a valid first name (alphabets only and
                                    more than one letter)."
            Lbl_msgfirstname.ForeColor = Color.Red
        End If

        If String.IsNullOrEmpty(user_lastname) OrElse Not IsAlphabeticOnly(user_lastname) OrElse user_lastname.Length <= 1 Then
            isValid = False
            Lbl_msglastname.Text = "Please enter a valid last name (alphabets only and
                                    more than one letter)."
            Lbl_msglastname.ForeColor = Color.Red
        End If

        If String.IsNullOrEmpty(user_address) Then
            isValid = False
            Lbl_msgaddress.Text = "Please enter a valid address."
            Lbl_msgaddress.ForeColor = Color.Red
        End If

        If userDOB_dtp.Value < New Date(1900, 1, 1) OrElse userDOB_dtp.Value > Date.Today.AddDays(-1) Then
            isValid = False
            Lbl_msgDOB.Text = "Please select a valid date of birth between 01/01/1900 
                             and yesterday."
            Lbl_msgDOB.ForeColor = Color.Red
        End If

        If String.IsNullOrEmpty(user_type) Then
            isValid = False
            Lbl_msgusertype.Text = "Please select a valid user type."
            Lbl_msgusertype.ForeColor = Color.Red
        End If

        If String.IsNullOrEmpty(user_gender) Then
            isValid = False
            Lbl_msggender.Text = "Please select a valid gender."
            Lbl_msggender.ForeColor = Color.Red
        End If

        If Not IsPhoneNumber(user_phone) Then
            isValid = False
            Lbl_msgphone.Text = "Please enter a valid phone number."
            Lbl_msgphone.ForeColor = Color.Red
        End If

        If String.IsNullOrEmpty(user_username) OrElse user_username.Length < 5 Then
            isValid = False
            Lbl_msgusername.Text = "Please enter a valid username (at least 5 characters)."
            Lbl_msgusername.ForeColor = Color.Red
        End If

        If String.IsNullOrEmpty(user_password) OrElse user_password.Length < 8 Then
            isValid = False
            Lbl_msgpassword.Text = "Please enter a valid password (at least 8 characters)."
            Lbl_msgpassword.ForeColor = Color.Red
        End If



        If user_password <> user_confirmPassword OrElse String.IsNullOrEmpty(user_confirmPassword) Then
            isValid = False
            Lbl_msgconfirmpw.Text = "Passwords do not match."
            Lbl_msgconfirmpw.ForeColor = Color.Red
        Else
            Lbl_msgconfirmpw.Text = "Passwords match."
            Lbl_msgconfirmpw.ForeColor = Color.Green
        End If


        ' Show message box if any validation fails
        If Not isValid Then
            MessageBox.Show("Please fill out all the fields correctly.")
            Exit Sub
        End If
    End Sub


End Class
