Public Class Registerform
    Public isValidInput As Boolean
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

        ' Validation checks for each input field
        Dim isValid As Boolean = True

        If String.IsNullOrEmpty(user_firstname) OrElse Not IsAlphabeticOnly(user_firstname) OrElse user_firstname.Length <= 1 Then
            isValid = False
            Lbl_msgfirstname.Text = "Please enter a valid first name (alphabets only and more than one letter)."
        End If

        If String.IsNullOrEmpty(user_lastname) OrElse Not IsAlphabeticOnly(user_lastname) OrElse user_lastname.Length <= 1 Then
            isValid = False
            Lbl_msglastname.Text = "Please enter a valid last name (alphabets only and more than one letter)."
        End If

        If String.IsNullOrEmpty(user_address) Then
            isValid = False
            Lbl_msgaddress.Text = "Please enter a valid address."
        End If

        If userDOB_dtp.Value < New Date(1910, 1, 1) OrElse userDOB_dtp.Value > Date.Today.AddDays(-1) Then
            isValid = False
            Lbl_msgDOB.Text = "Please select a valid date of birth between 01/01/1910 and yesterday."
        End If

        If String.IsNullOrEmpty(user_type) Then
            isValid = False
            Lbl_msgusertype.Text = "Please select a valid user type."
        End If

        If String.IsNullOrEmpty(user_gender) Then
            isValid = False
            Lbl_msggender.Text = "Please select a valid gender."
        End If

        If Not IsPhoneNumber(user_phone) Then
            isValid = False
            Lbl_msgphone.Text = "Please enter a valid phone number."
        End If

        If String.IsNullOrEmpty(user_username) OrElse user_username.Length < 5 Then
            isValid = False
            Lbl_msgusername.Text = "Please enter a valid username (at least 5 characters)."
        End If

        If String.IsNullOrEmpty(user_password) OrElse user_password.Length < 8 Then
            isValid = False
            Lbl_msgpassword.Text = "Please enter a valid password (at least 8 characters)."
        End If

        If user_password <> user_confirmPassword Then
            isValid = False
            Lbl_msgconfirmpw.Text = "Passwords do not match."
        End If

        ' Show message box if any validation fails
        If Not isValid Then
            MessageBox.Show("Please fill out all the fields correctly.")
            Exit Sub
        End If
        Dim newUser As New User()
        newUser.FirstName = user_firstname
        newUser.LastName = user_lastname
        newUser.Address = user_address
        newUser.DateOfBirth = user_dateofbirth
        newUser.UserType = user_type
        newUser.Gender = user_gender
        newUser.PhoneNumber = user_phone
        newUser.Username = user_username
        newUser.Password = user_password

        ' Call UserController method to register the user
        Dim userController As New UserController()
        Dim registrationResult As Boolean = userController.RegisterUser(newUser)

        If registrationResult Then
            MessageBox.Show("User registered successfully.")
            Dim loginform As New Loginform
            loginform.Show()
            Me.Hide()
        Else
            MessageBox.Show("User registration failed. Please try again.")
        End If
    End Sub



    Private Sub Registerform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the minimum and maximum dates for the DateTimePicker
        userDOB_dtp.MinDate = New Date(1900, 1, 1)
        userDOB_dtp.MaxDate = New Date(2025, 1, 1)

        ' Set the default value of the DateTimePicker to 18 years ago from today
        userDOB_dtp.Value = Date.Today.AddYears(-18)
    End Sub








    Private Sub Linktologin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Linktologin.LinkClicked
        Dim userloginform As New Loginform
        Loginform.Show()
        Hide()
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

    Private Function IsAlphabeticOnly(input As String) As Boolean 'function that checks if the values is alphabets or not
        ' Loop through each character in the input string
        For Each character As Char In input
            ' Check if the character is not an alphabetic character
            If Not Char.IsLetter(character) Then
                ' Return false if any non-alphabetic character is found
                Return False
            End If
        Next

        ' Return true if all characters are alphabetic
        Return True
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
        Dim minValidDate As New Date(1910, 1, 1)
        Dim maxValidDate As Date = Date.Today.AddDays(-1) ' Ensure the user is at least one day old

        ' Get the selected date from the DateTimePicker
        Dim selectedDate As Date = userDOB_dtp.Value

        ' Check if the selected date is within the valid range
        If selectedDate < minValidDate Then
            ' Show a message in the label indicating that the selected date is invalid
            Lbl_msgDOB.Text = "Please select a valid date of birth between 01/01/1910 and yesterday."
            ' Optionally, you can reset the DateTimePicker value to the default date or clear it
        ElseIf selectedDate > maxValidDate Then
            ' Show a message in the label indicating that the date of birth cannot be in the future
            Lbl_msgDOB.Text = "Date of birth cannot be set to the future."
        Else
            ' Clear the message in the label if the date is valid
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


    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Dispose()
        End
    End Sub
End Class


