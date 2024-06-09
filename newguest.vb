Imports System.Data.SqlClient



Public Class Newguest_form
    Dim isvalidinput As Boolean
    Public Sub Guest()

    End Sub




    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Dispose()
        End

    End Sub

    Private Sub gfirstname_txtbx_TextChanged(sender As Object, e As EventArgs) Handles gfirstname_txtbx.TextChanged
        isvalidinput = IsAlphabeticOnly(gfirstname_txtbx.Text)

        If isValidInput Then
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

    Private Sub glastname_txtbx_TextChanged(sender As Object, e As EventArgs) Handles glastname_txtbx.TextChanged
        isvalidinput = IsAlphabeticOnly(gfirstname_txtbx.Text)

        If isvalidinput Then
            ' Clear the message in the label if the input is valid
            Lbl_msgglastname.Text = ""
        Else
            ' Show a message in the label indicating that only alphabetic characters are allowed
            Lbl_msgglastname.Text = "Please enter a valid name (alphabets only)."
        End If
    End Sub

    Private Sub cmbbx_genderG_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbx_genderG.SelectedIndexChanged

    End Sub

    Private Sub addnewguest_btn_Click(sender As Object, e As EventArgs) Handles addnewguest_btn.Click
        Dim guest_firstname As String = gfirstname_txtbx.Text.Trim()

        Dim guest_lastname As String = glastname_txtbx.Text.Trim()
        Dim guest_country As String = Country_cmbbx.SelectedItem
        Dim guest_contact As String = contact_txtbx.Text.Trim()
        Dim guest_gender As String = cmbbx_genderG.SelectedItem
        Dim guest_email As String = Gemail_txtbx.Text
    End Sub


End Class

