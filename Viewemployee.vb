
Imports System.Data.SqlClient
Public Class Viewemployee
    Dim usercontroller As New UserController()
    Dim manageemployee As New userssql()
    Public isValidInput As Boolean


    Public Sub clear()
        userfn_txtbx.Clear()
        userln_txtbx.Clear()
        userPhone_txtbx.Clear()
        userAddress_txtbx.Clear()
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
        Tabcontrolusers.SelectedTab = updateemployeetabpage

        Lbl_msgfirstname.Text = String.Empty
        Lbl_msglastname.Text = String.Empty
        Lbl_msgaddress.Text = String.Empty
        Lbl_msgDOB.Text = String.Empty
        Lbl_msgusertype.Text = String.Empty
        Lbl_msggender.Text = String.Empty
        Lbl_msgphone.Text = String.Empty

        Lbl_useridshow.Text = String.Empty
    End Sub

    Private Sub close_Btn_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show("Do you want to exit the application?", "Exit Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Application.Exit
        End If
    End Sub

    Public Sub populateemployees()
        Dim query As String = "SELECT id,FirstName,LastName,Address,PhoneNumber,Age,Gender,UserType  FROM users WHERE Usertype='user'"
        manageemployee.ExecuteQuery(query, DGV_employee)

        DGV_employee.AutoGenerateColumns = True

        DGV_employee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DGV_employee.AutoSizeRowsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DGV_employee.DefaultCellStyle.BackColor = Color.White
        DGV_employee.DefaultCellStyle.ForeColor = Color.Black
        DGV_employee.AlternatingRowsDefaultCellStyle = Nothing
        For Each column As DataGridViewColumn In DGV_employee.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

        DGV_employee.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)
    End Sub



    Private Sub Viewemployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabPageViewemployee_Enter(sender, e)

    End Sub

    Private Sub TabPageViewemployee_Enter(sender As Object, e As EventArgs) Handles TabPageViewemployee.Enter
        populateemployees()

    End Sub


    Private Sub searchkeyword_txtbx_TextChanged(sender As Object, e As EventArgs) Handles searchkeyword_txtbx.TextChanged
        FilterUsersByKeyword(searchkeyword_txtbx.Text.Trim())
    End Sub

    Private Sub FilterUsersByKeyword(keyword As String)
        Dim query As String = "SELECT * FROM users WHERE Usertype ='user'AND 
                          (cast(id as varchar) LIKE @Keyword OR 
                           FirstName LIKE @Keyword OR 
                           LastName LIKE @Keyword OR 
                           Address LIKE @keyword OR
                           PhoneNumber LIKE @Keyword OR 
                           Age LIKE @Keyword OR 
                           
                           UserType LIKE @Keyword OR 
                           Gender LIKE @Keyword)"
        manageemployee.SearchUsers(query, keyword, DGV_employee)
    End Sub


    Private Sub Userfn_txtbx_TextChanged(sender As Object, e As EventArgs) Handles userfn_txtbx.TextChanged
        ' Check if the text in the textbox contains any non-alphabetic characters
        isValidInput = IsAlphabeticOnly(userfn_txtbx.Text)

        If isValidInput Then
            ' Clear the message in the label if the input is valid
            Lbl_msgfirstname.Text = ""
        Else

            Lbl_msgfirstname.Text = InvalidFirstName
        End If
    End Sub

    Private Function IsAlphabeticOnly(input As String) As Boolean
        For Each character As Char In input
            If Not Char.IsLetter(character) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub Userln_txtbx_TextChanged(sender As Object, e As EventArgs) Handles userln_txtbx.TextChanged
        isValidInput = IsAlphabeticOnly(userln_txtbx.Text)
        If isValidInput Then

            Lbl_msglastname.Text = ""
        Else

            Lbl_msglastname.Text = Validationmessages.InvalidLastName
        End If
    End Sub

    Private Sub UserAddress_txtbx_TextChanged(sender As Object, e As EventArgs) Handles userAddress_txtbx.TextChanged
        If String.IsNullOrWhiteSpace(userAddress_txtbx.Text) Then
            ' Show a message in the label indicating that the address cannot be empty
            Lbl_msgaddress.Text = Validationmessages.InvalidAddress
        Else
            ' Clear the message in the label if the address is valid
            Lbl_msgaddress.Text = ""
        End If
    End Sub

    Private Sub UserDOB_dtp_ValueChanged(sender As Object, e As EventArgs) Handles userDOB_dtp.ValueChanged
        Dim minValidDate As New Date(1900, 1, 1)
        Dim maxValidDate As Date = Date.Today.AddDays(-1)
        Dim selectedDate As Date = userDOB_dtp.Value

        ' Check if the selected date is within the valid range
        If selectedDate < minValidDate Then
            Lbl_msgDOB.Text = Validationmessages.InvalidDOB
        ElseIf selectedDate > maxValidDate Then
            Lbl_msgDOB.Text = "Date of birth cannot be set to the future."
        Else
            ' Calculate age and validate
            Dim age As Integer = CalculateAge(selectedDate)
            If age < 14 Then
                Lbl_msgDOB.Text = "Age must be at least 14 years."
            Else
                Lbl_msgDOB.Text = ""
            End If
        End If
    End Sub


    Private Sub Usertype_cmbbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles usertype_cmbbx.SelectedIndexChanged

        If usertype_cmbbx.SelectedIndex = -1 Then
            Lbl_msgusertype.Text = Validationmessages.InvalidUserType
        Else
            Lbl_msgusertype.Text = ""
        End If


    End Sub

    Private Sub UserPhone_txtbx_TextChanged(sender As Object, e As EventArgs) Handles userPhone_txtbx.TextChanged
        If Not IsPhoneNumber(userPhone_txtbx.Text) Then
            Lbl_msgphone.Text = Validationmessages.InvalidPhone

        Else
            Lbl_msgphone.Text = ""
        End If
    End Sub

    Private Sub Gender_cmbbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gender_cmbbx.SelectedIndexChanged
        If gender_cmbbx.SelectedIndex = -1 Then
            Lbl_msggender.Text = Validationmessages.InvalidGender
        Else
            Lbl_msggender.Text = ""
        End If
    End Sub



    Private Sub DGV_employee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_employee.CellClick

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DGV_employee.Rows(e.RowIndex)
            Dim age As Integer = Convert.ToInt32(selectedRow.Cells("Age").Value)
            Dim dob As Date = Date.Today.AddYears(-age)
            Dim userType As String = selectedRow.Cells("UserType").Value.ToString()
            Dim gender As String = selectedRow.Cells("Gender").Value.ToString()
            Dim firstName As String = selectedRow.Cells("FirstName").Value.ToString()
            Dim lastName As String = selectedRow.Cells("LastName").Value.ToString()
            Dim address As String = selectedRow.Cells("Address").Value.ToString()
            Dim phone As String = selectedRow.Cells("PhoneNumber").Value.ToString()

            Dim userid As Integer = selectedRow.Cells("id").Value.ToString()


            Lbl_useridshow.Text = userid
            userDOB_dtp.Value = dob
            usertype_cmbbx.SelectedItem = userType
            gender_cmbbx.SelectedItem = gender
            userfn_txtbx.Text = firstName
            userln_txtbx.Text = lastName
            userAddress_txtbx.Text = address
            userPhone_txtbx.Text = phone



        End If
    End Sub

    Private Sub updateemployee_Btn_Click(sender As Object, e As EventArgs) Handles updateemployee_Btn.Click
        If inputvalidation() Then

            UpdateEmployee()

        End If
    End Sub
    Public Function inputvalidation() As Boolean
        Dim user_firstname As String = userfn_txtbx.Text.Trim()
        Dim user_lastname As String = userln_txtbx.Text.Trim()
        Dim user_address As String = userAddress_txtbx.Text.Trim()
        Dim user_dateofbirth As Date = userDOB_dtp.Value
        Dim user_type As String = If(usertype_cmbbx.SelectedItem IsNot Nothing, usertype_cmbbx.SelectedItem.ToString(), String.Empty)
        Dim user_gender As String = If(gender_cmbbx.SelectedItem IsNot Nothing, gender_cmbbx.SelectedItem.ToString(), String.Empty)
        Dim user_phone As String = userPhone_txtbx.Text.Trim()


        Dim user_Age As Integer = CalculateAge(userDOB_dtp.Value)

        Dim isValid As Boolean = True

        If String.IsNullOrEmpty(user_firstname) OrElse Not IsAlphabeticOnly(user_firstname) OrElse user_firstname.Length <= 1 Then
            isValid = False
            Lbl_msgfirstname.Text = Validationmessages.InvalidFirstName
            Lbl_msgfirstname.ForeColor = Color.Red
            userfn_txtbx.Clear()
        End If

        If String.IsNullOrEmpty(user_lastname) OrElse Not IsAlphabeticOnly(user_lastname) OrElse user_lastname.Length <= 1 Then
            isValid = False
            Lbl_msglastname.Text = Validationmessages.InvalidLastName
            Lbl_msglastname.ForeColor = Color.Red
            userln_txtbx.Clear()
        End If

        If String.IsNullOrEmpty(user_address) Then
            isValid = False
            Lbl_msgaddress.Text = Validationmessages.InvalidAddress
            Lbl_msgaddress.ForeColor = Color.Red
            userAddress_txtbx.Clear()
        End If

        If userDOB_dtp.Value < New Date(1900, 1, 1) OrElse userDOB_dtp.Value > Date.Today.AddDays(-1) Then
            isValid = False
            Lbl_msgDOB.Text = Validationmessages.InvalidDOB
            Lbl_msgDOB.ForeColor = Color.Red
        End If

        If String.IsNullOrEmpty(user_type) Then
            isValid = False
            Lbl_msgusertype.Text = Validationmessages.InvalidUserType
            Lbl_msgusertype.ForeColor = Color.Red
        End If

        If String.IsNullOrEmpty(user_gender) Then
            isValid = False
            Lbl_msggender.Text = Validationmessages.InvalidGender
            Lbl_msggender.ForeColor = Color.Red
        End If

        If String.IsNullOrEmpty(user_phone) AndAlso Not IsPhoneNumber(user_phone) Then
            isValid = False
            Lbl_msgphone.Text = Validationmessages.InvalidPhone
            Lbl_msgphone.ForeColor = Color.Red
            userPhone_txtbx.Clear()
        End If
        Return isValid
    End Function

    Private Sub UpdateEmployee()
        Dim userage As Integer = CalculateAge(userDOB_dtp.Value)

        Dim query As String = "UPDATE users SET FirstName = @FirstName, LastName = @LastName, " &
                          "Address = @Address, PhoneNumber = @PhoneNumber, " &
                          "Gender = @Gender, UserType = @UserType, Age = @Age " &
                          "WHERE id = @userid"
        Dim parameters As New List(Of SqlParameter) From {
        New SqlParameter("@FirstName", userfn_txtbx.Text),
        New SqlParameter("@LastName", userln_txtbx.Text),
        New SqlParameter("@Address", userAddress_txtbx.Text),
        New SqlParameter("@PhoneNumber", userPhone_txtbx.Text),
        New SqlParameter("@Gender", gender_cmbbx.SelectedItem.ToString()),
        New SqlParameter("@UserType", usertype_cmbbx.SelectedItem.ToString()),
        New SqlParameter("@Age", userage),
        New SqlParameter("@userid", Lbl_useridshow.Text)
       }

        manageemployee.ExecuteNonQueryWithParameters(query, parameters)
        MessageBox.Show("User updated successfully.")
        populateemployees()
        clear()
    End Sub

    Private Sub updateemployeetabpage_Enter(sender As Object, e As EventArgs) Handles updateemployeetabpage.Enter

    End Sub

    Private Sub updateemployeetabpage_Leave(sender As Object, e As EventArgs) Handles updateemployeetabpage.Leave

    End Sub



    Private Sub Tabcontrolusers_Leave(sender As Object, e As EventArgs) Handles Tabcontrolusers.Leave
        searchkeyword_txtbx.Clear()
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        userfn_txtbx.Clear()
        userln_txtbx.Clear()
        userPhone_txtbx.Clear()
        userAddress_txtbx.Clear()
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

        Lbl_msgfirstname.Text = String.Empty
        Lbl_msglastname.Text = String.Empty
        Lbl_msgaddress.Text = String.Empty
        Lbl_msgDOB.Text = String.Empty
        Lbl_msgusertype.Text = String.Empty
        Lbl_msggender.Text = String.Empty
        Lbl_msgphone.Text = String.Empty
        Lbl_useridshow.Text = String.Empty
    End Sub
End Class