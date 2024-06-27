Module Validationmessages
    Public Const InvalidFirstName As String = "Please enter a valid first name (alphabets only and
more than one letter)."
    Public Const InvalidLastName As String = "Please enter a valid last name (alphabets only and
more than one letter)."
    Public Const InvalidAddress As String = "Please enter a valid address."
    Public Const InvalidDOB As String = "Please select a valid date of birth."
    Public Const InvalidUserType As String = "Please select a user type."
    Public Const InvalidGender As String = "Please select a gender."
    Public Const InvalidPhone As String = "Please enter a valid phone number."
    Public Const InvalidUsername As String = "Please enter a valid username (at least 5 characters)."
    Public Const InvalidPassword As String = "Please enter a valid password (at least 8 characters)."
    Public Const PasswordsDoNotMatch As String = "Passwords do not match."
    Public Const PasswordsMatch As String = "Passwords match."
    Public Const invalidemail As String = "Please enter a valid E-mail."

    Public Function IsPhoneNumber(input As String) As Boolean
        If input.StartsWith("+") Then
            Return input.Substring(1).All(AddressOf Char.IsDigit) AndAlso input.Length <= 15
        Else
            Return input.All(AddressOf Char.IsDigit) AndAlso input.Length <= 15
        End If
    End Function
    Public Function CalculateAge(selectedDate As Date) As Integer
        ' Calculate the age based on the selected date and today's date
        Dim age As Integer = Date.Now.Year - selectedDate.Year
        If selectedDate > Date.Now.AddYears(-age) Then
            age -= 1 ' Adjust the age if the birthday hasn't occurred yet this year
        End If

        ' Validate the age to be at least 18
        If age < 14 Then
            Return 0 ' Return 0 or another suitable value indicating invalid age
        Else
            Return age
        End If
    End Function

    Public Function IsValidEmailLength(email As String) As Boolean
        ' Check if the email length does not exceed 254 characters
        Return email.Length <= 254
    End Function

End Module
