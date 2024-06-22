
Public Class Guestform

    Private Sub Guestlistbtn_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub closebtn_Click_1(sender As Object, e As EventArgs) Handles closebtn.Click
        Application.Exit()

    End Sub




    Dim isvalidinput As Boolean
    Public Sub Guest()

    End Sub

    Private Sub gfirstname_txtbx_TextChanged(sender As Object, e As EventArgs)
        isvalidinput = IsAlphabeticOnly(gfirstname_txtbx.Text)

        If isvalidinput Then
            ' Clear the message in the label if the input is valid
            Lbl_msggfirstname.Text = ""
        Else
            ' Show a message in the label indicating that only alphabetic characters are allowed
            Lbl_msggfirstname.Text = "Please enter a valid name (alphabets only)."
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

    Private Sub glastname_txtbx_TextChanged(sender As Object, e As EventArgs)
        isvalidinput = IsAlphabeticOnly(gfirstname_txtbx.Text)

        If isvalidinput Then
            ' Clear the message in the label if the input is valid
            Lbl_msgglastname.Text = ""
        Else
            ' Show a message in the label indicating that only alphabetic characters are allowed
            Lbl_msgglastname.Text = "Please enter a valid name (alphabets only)."
        End If
    End Sub

    Private Sub cmbbx_genderG_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cmbbx_genderG.SelectedIndex = -1 Then
            Lbl_msgggender.Text = "Please select a valid user type."
        Else
            Lbl_msgggender.Text = ""
        End If

    End Sub



    Private Sub addnewguest_btn_Click(sender As Object, e As EventArgs)
        Dim guest_firstname = gfirstname_txtbx.Text.Trim

        Dim guest_lastname = glastname_txtbx.Text.Trim
        Dim guest_country As String = Country_cmbbx.SelectedItem
        Dim guest_contact = contact_txtbx.Text.Trim
        Dim guest_gender As String = cmbbx_genderG.SelectedItem
        Dim guest_email = Gemail_txtbx.Text
    End Sub

    Private Sub newguest_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GuestID_txtbx_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Gemail_txtbx_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Country_cmbbx_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Lblnoofadults_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub nadult_txtbx_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub nchildren_txtbx_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub contact_txtbx_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Tabpage_addnewguest_Click(sender As Object, e As EventArgs) Handles Tabpage_addnewguest.Click

    End Sub
End Class



