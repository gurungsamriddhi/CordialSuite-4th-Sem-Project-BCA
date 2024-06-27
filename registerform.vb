Public Class Registerform
    Public isValidInput As Boolean
    Dim userController As New UserController()
    Dim loadusers As New viewuser()


    Private Sub Registerbtn_Click(sender As Object, e As EventArgs) Handles Registerbtn.Click
        ' Retrieve and trim text inputs from textboxes
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



        ' Validation checks for each input field while registering
        Dim isValid As Boolean = True

        If String.IsNullOrEmpty(user_firstname) OrElse Not IsAlphabeticOnly(user_firstname) OrElse user_firstname.Length <= 1 Then
            isValid = False
            Lbl_msgfirstname.Text = Validationmessages.InvalidFirstName

            Lbl_msgfirstname.ForeColor = Color.Red
        End If

        If String.IsNullOrEmpty(user_lastname) OrElse Not IsAlphabeticOnly(user_lastname) OrElse user_lastname.Length <= 1 Then
            isValid = False
            Lbl_msglastname.Text = Validationmessages.InvalidLastName
            Lbl_msglastname.ForeColor = Color.Red
        End If

        If String.IsNullOrEmpty(user_address) Then
            isValid = False
            Lbl_msgaddress.Text = Validationmessages.InvalidAddress
            Lbl_msgaddress.ForeColor = Color.Red
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

        If String.IsNullOrEmpty(user_phone) OrElse Not IsPhoneNumber(user_phone) Then
            isValid = False
            Lbl_msgphone.Text = Validationmessages.InvalidPhone
            Lbl_msgphone.ForeColor = Color.Red
        End If

        If String.IsNullOrEmpty(user_username) OrElse user_username.Length < 5 Then
            isValid = False
            Lbl_msgusername.Text = Validationmessages.InvalidUsername
            Lbl_msgusername.ForeColor = Color.Red
        End If

        If String.IsNullOrEmpty(user_password) OrElse user_password.Length < 8 Then
            isValid = False
            Lbl_msgpassword.Text = Validationmessages.InvalidPassword
            Lbl_msgpassword.ForeColor = Color.Red
        End If



        If user_password <> user_confirmPassword OrElse String.IsNullOrEmpty(user_confirmPassword) Then
            isValid = False
            Lbl_msgconfirmpw.Text = Validationmessages.PasswordsDoNotMatch

            Lbl_msgconfirmpw.ForeColor = Color.Red
        Else
            Lbl_msgconfirmpw.Text = Validationmessages.PasswordsMatch
            Lbl_msgconfirmpw.ForeColor = Color.Green
        End If


        ' Show message box if any validation fails
        If Not isValid Then
            MessageBox.Show("Please fill out all the fields correctly.")
            Exit Sub
        End If



        Dim newUser As New User() With {
    .FirstName = user_firstname,
    .LastName = user_lastname,
    .Address = user_address,
    .Age = user_Age,
    .UserType = user_type,
    .Gender = user_gender,
    .PhoneNumber = user_phone,
    .Username = user_username,
    .Password = user_password
    }



        If userController.validusername(newUser.Username) Then
            MessageBox.Show("Username already exists. Please choose a different username.")
            username_txtbx.Clear()
            username_txtbx.Focus()
        Else
            userController.AddUser(newUser)
            MessageBox.Show("User registered successfully.")
            loadusers.populateUsers()

        End If

    End Sub




    'input validation for each textboxes
    Private Sub Registerform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the default value of the DateTimePicker to 18 years ago from today
        userDOB_dtp.Value = Date.Today.AddYears(-18)

    End Sub



    Private Sub Linktologin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim userloginform As New Loginform
        Loginform.Show()
        Hide()
    End Sub

    Private Sub Userfn_txtbx_TextChanged(sender As Object, e As EventArgs) Handles userfn_txtbx.TextChanged
        isValidInput = IsAlphabeticOnly(userfn_txtbx.Text)
        If isValidInput Then
            ' Clear the message in the label if the input is valid
            Lbl_msgfirstname.Text = ""
        Else

            Lbl_msgfirstname.Text = Validationmessages.InvalidFirstName
        End If
    End Sub

    Private Function IsAlphabeticOnly(input As String) As Boolean     'function that checks if the values is alphabets or not
        For Each character As Char In input                           ' Loop through each character in the input string
            If Not Char.IsLetter(character) Then                      ' Check if the character is not an alphabetic character
                Return False                                          ' Return false if any non-alphabetic character is found
            End If
        Next
        Return True                                                   ' Return true if all characters are alphabetic
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

    Private Sub Username_txtbx_TextChanged(sender As Object, e As EventArgs) Handles username_txtbx.TextChanged
        If username_txtbx.Text.Length < 5 Then
            Lbl_msgusername.Text = Validationmessages.InvalidUsername
        Else
            Lbl_msgusername.Text = ""
        End If
    End Sub

    Private Sub Password_txtbx_TextChanged(sender As Object, e As EventArgs) Handles password_txtbx.TextChanged
        ' Check if the password contains at least one special character
        Dim hasSpecialChar As Boolean = password_txtbx.Text.Any(Function(c) Not Char.IsLetterOrDigit(c)) 'checks is anycaharacter in the password is specialchar or not


        If password_txtbx.Text.Length < 8 Then
            Lbl_msgpassword.Text = Validationmessages.InvalidPassword
        ElseIf Not hasSpecialChar Then
            Lbl_msgpassword.Text = "Password must contain at least one special character."
            Lbl_msgpassword.ForeColor = Color.Red
        Else
            Lbl_msgpassword.Text = ""
        End If
    End Sub



    Private Function IsPhoneNumber(input As String) As Boolean
        ' Check if the input is numeric and has 10 digits
        Return input.All(AddressOf Char.IsDigit) AndAlso input.Length = 10
    End Function



    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Application.Exit()
        End
    End Sub

    Public Sub clearinputs()

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
        confirmpw_txtbx.Clear()

        'label clear
        Lbl_msgfirstname.Text = String.Empty
        Lbl_msglastname.Text = String.Empty
        Lbl_msgaddress.Text = String.Empty
        Lbl_msgDOB.Text = String.Empty
        Lbl_msgusertype.Text = String.Empty
        Lbl_msggender.Text = String.Empty
        Lbl_msgphone.Text = String.Empty
        Lbl_msgusername.Text = String.Empty
        Lbl_msgpassword.Text = String.Empty
        Lbl_msgconfirmpw.Text = String.Empty
    End Sub

    Private Sub Registerform_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        clearinputs()

    End Sub
    Private Sub Registerform_leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        clearinputs()
    End Sub

    Private Sub Pnlregister_Paint(sender As Object, e As PaintEventArgs) Handles Pnlregister.Paint

    End Sub
End Class


