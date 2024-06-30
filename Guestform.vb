Imports System.Data.SqlClient


Public Class Guestform
    Dim isvalidinput As Boolean
    Dim guestssql As New guestssql()
    Private originalEmail As String

    Private Sub closebtn_Click_1(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show("Do you want to exit the application?", "Exit Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Application.Exit
        End If

    End Sub


    Private Sub populateguests()
        Dim query As String = "SELECT * FROM guests"
        guestssql.ExecuteQuery(query, DGV_Guests)
        DGV_Guests.AutoGenerateColumns = True
        DGV_Guests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DGV_Guests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DGV_Guests.DefaultCellStyle.BackColor = Color.White
        DGV_Guests.DefaultCellStyle.ForeColor = Color.Black
        DGV_Guests.AlternatingRowsDefaultCellStyle = Nothing
        ' Loop through columns and set the AutoSizeMode property
        For Each column As DataGridViewColumn In DGV_Guests.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
        ' Adjust the height of the header row to display the full content
        DGV_Guests.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)
    End Sub


    Private Sub gfirstname_txtbx_TextChanged(sender As Object, e As EventArgs)
        isvalidinput = IsAlphabeticOnly(gfirstname_txtbx.Text)

        If isvalidinput Then
            ' Clear the message in the label if the input is valid
            Lbl_msggfirstname.Text = ""
        Else
            ' Show a message in the label indicating that only alphabetic characters are allowed
            Lbl_msggfirstname.Text = InvalidFirstName
        End If
    End Sub

    Private Function IsAlphabeticOnly(input As String) As Boolean 'function that checks if the values is alphabets or not

        For Each character As Char In input ' Loop through each character in the input string

            If Not Char.IsLetter(character) Then ' Check if the character is not an alphabetic character

                Return False ' Return false if any non-alphabetic character is found
            End If
        Next


        Return True ' Return true if all characters are alphabetic
    End Function


    Private Sub glastname_txtbx_TextChanged(sender As Object, e As EventArgs)
        isvalidinput = IsAlphabeticOnly(gfirstname_txtbx.Text)

        If isvalidinput Then
            ' Clear the message in the label if the input is valid
            Lbl_msgglastname.Text = ""
        Else
            ' Show a message in the label indicating that only alphabetic characters are allowed
            Lbl_msgglastname.Text = InvalidLastName
        End If
    End Sub

    Private Sub cmbbx_genderG_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cmbbx_genderG.SelectedIndex = -1 Then
            Lbl_msgggender.Text = InvalidGender
        Else
            Lbl_msgggender.Text = ""
        End If

    End Sub
    Private Sub Gemail_txtbx_TextChanged(sender As Object, e As EventArgs) Handles Gemail_txtbx.TextChanged
        If Not IsValidEmail(Gemail_txtbx.Text) Then
            Lbl_msgemail.Text = invalidemail
        Else
            Lbl_msgemail.Text = ""
        End If
    End Sub

    Private Sub contact_txtbx_TextChanged(sender As Object, e As EventArgs) Handles contact_txtbx.TextChanged
        If Not IsPhoneNumber(contact_txtbx.Text) Then
            Lbl_msgcontactno.Text = InvalidPhone

        Else
            Lbl_msgcontactno.Text = ""
        End If
    End Sub

    Private Sub gaddress_txtbx_TextChanged(sender As Object, e As EventArgs) Handles gaddress_txtbx.TextChanged
        If String.IsNullOrWhiteSpace(gaddress_txtbx.Text) Then
            ' Show a message in the label indicating that the address cannot be empty
            Lbl_msggaddress.Text = InvalidAddress
        Else
            ' Clear the message in the label if the address is valid
            Lbl_msggaddress.Text = ""
        End If
    End Sub

    Private Sub newguest_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateguests()

    End Sub
    Private Sub searchguest_txtbx_TextChanged(sender As Object, e As EventArgs) Handles searchguest_txtbx.TextChanged
        FilterguestsByKeyword(searchguest_txtbx.Text.Trim())
    End Sub
    Private Sub FilterguestsByKeyword(keyword As String)
        Dim query As String = "SELECT * FROM guests where
                          ( CAST(GuestId AS VARCHAR) LIKE @Keyword OR 
                           Firstname LIKE @Keyword OR
                           Lastname LIKE @Keyword OR 
                           Address LIKE @Keyword OR 
                           Contact LIKE @keyword OR
                           Gender LIKE @Keyword OR 
                           Email LIKE @Keyword )"
        guestssql.SearchGuests(query, keyword, DGV_Guests)
    End Sub

    Private Sub Tabpage_newguest_Leave(sender As Object, e As EventArgs) Handles Tabpage_manageguest.Leave
        gfirstname_txtbx.Clear()
        glastname_txtbx.Clear()
        gaddress_txtbx.Clear()
        cmbbx_genderG.SelectedIndex = -1
        contact_txtbx.Clear()
        Gemail_txtbx.Clear()
        Lbl_msgcontactno.Text = String.Empty
        Lbl_msggaddress.Text = String.Empty
        Lbl_msggfirstname.Text = String.Empty
        Lbl_msgglastname.Text = String.Empty
        Lbl_msgggender.Text = String.Empty
        Lbl_guestid.Text = String.Empty
        Lbl_guestidshow.Text = String.Empty
        Lbl_msgemail.Text = String.Empty

    End Sub


    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        Dim isValid As Boolean = True
        ' Trim the input values
        Dim guestfirstname As String = gfirstname_txtbx.Text.Trim()
        Dim guestlastname As String = glastname_txtbx.Text.Trim()
        Dim guestgender As String = If(cmbbx_genderG.SelectedItem IsNot Nothing, cmbbx_genderG.SelectedItem.ToString(), "")
        Dim guestcontact As String = contact_txtbx.Text.Trim()
        Dim guestaddress As String = gaddress_txtbx.Text.Trim()
        Dim guestemail As String = Gemail_txtbx.Text.Trim()

        ' Validate the inputs
        If String.IsNullOrEmpty(guestfirstname) OrElse Not IsAlphabeticOnly(guestfirstname) OrElse guestfirstname.Length <= 1 Then
            isValid = False
            Lbl_msggfirstname.Text = Validationmessages.InvalidFirstName
            Lbl_msggfirstname.ForeColor = Color.Red
        End If

        If String.IsNullOrEmpty(guestlastname) OrElse Not IsAlphabeticOnly(guestlastname) OrElse guestlastname.Length <= 1 Then
            isValid = False
            Lbl_msgglastname.Text = Validationmessages.InvalidLastName
            Lbl_msgglastname.ForeColor = Color.Red
        End If

        If String.IsNullOrEmpty(guestemail) OrElse Not IsValidEmail(guestemail) Then
            isValid = False
            Lbl_msgemail.Text = invalidemail
            Lbl_msgemail.ForeColor = Color.Red
        ElseIf guestssql.EmailExists(guestemail) OrElse Not String.IsNullOrEmpty(Lbl_guestidshow.Text) Then
            isValid = False
            MessageBox.Show("E-mail exists or Guest already exists with this ID. You can only update existing guests.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Gemail_txtbx.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(guestaddress) Then
            isValid = False
            Lbl_msggaddress.Text = Validationmessages.InvalidAddress
            Lbl_msggaddress.ForeColor = Color.Red
        End If

        If String.IsNullOrEmpty(guestgender) Then
            isValid = False
            Lbl_msgggender.Text = Validationmessages.InvalidGender
            Lbl_msgggender.ForeColor = Color.Red
        End If

        If String.IsNullOrEmpty(guestcontact) OrElse Not IsPhoneNumber(guestcontact) Then
            isValid = False
            Lbl_msgcontactno.Text = Validationmessages.InvalidPhone
            Lbl_msgcontactno.ForeColor = Color.Red
        End If

        If Not isValid Then
            MessageBox.Show("Please fill out all the fields correctly.")
            Exit Sub
        End If


        ' Insert the guest information into the database
        Dim query As String = "INSERT INTO guests (FirstName, LastName, Address, Contact, Gender, Email) " &
                          "VALUES (@FirstName, @LastName, @Address, @Contact, @Gender, @Email)"

        Dim parameters As New List(Of SqlParameter)()
        parameters.Add(New SqlParameter("@FirstName", guestfirstname))
        parameters.Add(New SqlParameter("@LastName", guestlastname))
        parameters.Add(New SqlParameter("@Address", guestaddress))
        parameters.Add(New SqlParameter("@Contact", guestcontact))
        parameters.Add(New SqlParameter("@Gender", guestgender))
        parameters.Add(New SqlParameter("@Email", guestemail))

        ' Execute the insertion query
        Try
            guestssql.ExecuteNonQueryWithParameters(query, parameters)
            MessageBox.Show("Guest added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            populateguests() ' Refresh the DataGridView after adding the guest
        Catch ex As Exception
            MessageBox.Show("Error adding guest: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub tabpage_viewguest_Enter(sender As Object, e As EventArgs) Handles tabpage_viewguest.Enter
        populateguests()
    End Sub

    Private Sub TabGuestcontrol_Enter(sender As Object, e As EventArgs) Handles Tabpage_updateguest.Enter
        populateguests()
    End Sub

    Private Sub DGV_Guests_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Guests.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DGV_Guests.Rows(e.RowIndex)

            Dim gender As String = selectedRow.Cells("Gender").Value.ToString()
            Dim firstName As String = selectedRow.Cells("FirstName").Value.ToString()
            Dim lastName As String = selectedRow.Cells("LastName").Value.ToString()
            Dim address As String = selectedRow.Cells("Address").Value.ToString()
            Dim phone As String = selectedRow.Cells("Contact").Value.ToString()
            Dim userid As Integer = selectedRow.Cells("GuestId").Value.ToString()
            originalEmail = selectedRow.Cells("Email").Value.ToString()

            Lbl_guestid.Text = "Guest ID:"
            Lbl_guestidshow.Text = userid
            cmbbx_genderG.SelectedItem = gender
            gfirstname_txtbx.Text = firstName
            glastname_txtbx.Text = lastName
            gaddress_txtbx.Text = address
            contact_txtbx.Text = phone
            Gemail_txtbx.Text = originalemail

        End If
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        ' Check if the guest ID is present
        If String.IsNullOrEmpty(Lbl_guestidshow.Text) Then
            MessageBox.Show("Please select a guest to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Trim the input values
        Dim guestId As Integer = Convert.ToInt32(Lbl_guestidshow.Text.Trim())
        Dim guestfirstname As String = gfirstname_txtbx.Text.Trim()
        Dim guestlastname As String = glastname_txtbx.Text.Trim()
        Dim guestgender As String = If(cmbbx_genderG.SelectedItem IsNot Nothing, cmbbx_genderG.SelectedItem.ToString(), "")
        Dim guestcontact As String = contact_txtbx.Text.Trim()
        Dim guestaddress As String = gaddress_txtbx.Text.Trim()
        Dim guestemail As String = Gemail_txtbx.Text.Trim()

        ' Validate the inputs
        Dim isValid As Boolean = True

        If String.IsNullOrEmpty(guestfirstname) OrElse Not IsAlphabeticOnly(guestfirstname) OrElse guestfirstname.Length <= 1 Then
            isValid = False
            Lbl_msggfirstname.Text = Validationmessages.InvalidFirstName
            Lbl_msggfirstname.ForeColor = Color.Red
        End If

        If String.IsNullOrEmpty(guestlastname) OrElse Not IsAlphabeticOnly(guestlastname) OrElse guestlastname.Length <= 1 Then
            isValid = False
            Lbl_msgglastname.Text = Validationmessages.InvalidLastName
            Lbl_msgglastname.ForeColor = Color.Red
        End If

        If String.IsNullOrEmpty(guestemail) OrElse Not IsValidEmail(guestemail) Then
            isValid = False
            Lbl_msgemail.Text = invalidemail
            Lbl_msgemail.ForeColor = Color.Red
        End If

        If String.IsNullOrEmpty(guestaddress) Then
            isValid = False
            Lbl_msggaddress.Text = Validationmessages.InvalidAddress
            Lbl_msggaddress.ForeColor = Color.Red
        End If

        If String.IsNullOrEmpty(guestgender) Then
            isValid = False
            Lbl_msgggender.Text = Validationmessages.InvalidGender
            Lbl_msgggender.ForeColor = Color.Red
        End If

        If String.IsNullOrEmpty(guestcontact) OrElse Not IsPhoneNumber(guestcontact) Then
            isValid = False
            Lbl_msgcontactno.Text = Validationmessages.InvalidPhone
            Lbl_msgcontactno.ForeColor = Color.Red
        End If

        If Not isValid Then
            MessageBox.Show("Please fill out all the fields correctly.")
            Exit Sub
        End If

        ' Check if the email exists only if it was changed
        If Not guestemail.Equals(originalEmail, StringComparison.OrdinalIgnoreCase) AndAlso guestssql.EmailExists(guestemail) Then
            MessageBox.Show("E-mail already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Gemail_txtbx.Focus()
            Exit Sub
        End If

        ' Update the guest information in the database
        Dim query As String = "UPDATE guests SET FirstName = @FirstName, LastName = @LastName, Address = @Address, Contact = @Contact, Gender = @Gender, Email = @Email WHERE GuestId = @GuestId"

        Dim parameters As New List(Of SqlParameter)()
        parameters.Add(New SqlParameter("@GuestId", guestId))
        parameters.Add(New SqlParameter("@FirstName", guestfirstname))
        parameters.Add(New SqlParameter("@LastName", guestlastname))
        parameters.Add(New SqlParameter("@Address", guestaddress))
        parameters.Add(New SqlParameter("@Contact", guestcontact))
        parameters.Add(New SqlParameter("@Gender", guestgender))
        parameters.Add(New SqlParameter("@Email", guestemail))

        ' Execute the update query
        Try
            guestssql.ExecuteNonQueryWithParameters(query, parameters)
            MessageBox.Show("Guest updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            populateguests() ' Refresh the DataGridView after updating the guest
        Catch ex As Exception
            MessageBox.Show("Error updating guest: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        gfirstname_txtbx.Clear()
        glastname_txtbx.Clear()
        gaddress_txtbx.Clear()
        cmbbx_genderG.SelectedIndex = -1
        contact_txtbx.Clear()
        Gemail_txtbx.Clear()
        Lbl_msgcontactno.Text = String.Empty
        Lbl_msggaddress.Text = String.Empty
        Lbl_msggfirstname.Text = String.Empty
        Lbl_msgglastname.Text = String.Empty
        Lbl_msgggender.Text = String.Empty
        Lbl_guestid.Text = String.Empty
        Lbl_guestidshow.Text = String.Empty
        Lbl_msgemail.Text = String.Empty
    End Sub
End Class
