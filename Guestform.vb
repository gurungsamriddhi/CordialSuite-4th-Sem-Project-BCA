Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader

Public Class Guestform
    Dim isvalidinput As Boolean
    Dim guestssql As New guestssql()

    Private Sub closebtn_Click_1(sender As Object, e As EventArgs) Handles closebtn.Click
        Application.Exit()

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





    Private Sub newguest_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateguests()

    End Sub
    Private Sub searchguest_txtbx_TextChanged(sender As Object, e As EventArgs) Handles searchguest_txtbx.TextChanged

    End Sub

    Private Sub Tabpage_newguest_Leave(sender As Object, e As EventArgs) Handles Tabpage_newguest.Leave
        gfirstname_txtbx.Clear()
        glastname_txtbx.Clear()
        gaddress_txtbx.Clear()
        cmbbx_genderG.SelectedIndex = -1
        contact_txtbx.Clear()

    End Sub

    Private Sub Gemail_txtbx_TextChanged(sender As Object, e As EventArgs) Handles Gemail_txtbx.TextChanged
        If Not IsValidEmailLength(Gemail_txtbx.Text) Then
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
        If String.IsNullOrEmpty(guestemail) OrElse Not IsValidEmailLength(guestemail) Then
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
        ' Insert the guest information into the database
        Dim query As String = "INSERT INTO guests (FirstName, LastName,Address,Contact, Gender,Email) 
          VALUES (@FirstName, @LastName,@Address, @Contact,@Gender,@email )"



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
            Dim email As String = selectedRow.Cells("Email").Value.ToString()

            Lbl_userid.Text = "Guest ID:"
            Lbl_useridshow.Text = userid
            cmbbx_genderG.SelectedItem = gender
            gfirstname_txtbx.Text = firstName
            glastname_txtbx.Text = lastName
            gaddress_txtbx.Text = address
            contact_txtbx.Text = phone

        End If
    End Sub





    Private Sub gfirstname_txtbx_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click

    End Sub
End Class



