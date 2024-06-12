Imports System.Data.SqlClient



Public Class Newguest_form
    Dim isvalidinput As Boolean
    Public Sub Guest()

    End Sub




    Private Sub Closebtn_Click(sender As Object, e As EventArgs)
        Dispose
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
        If cmbbx_genderG.SelectedIndex = -1 Then
            Lbl_msgggender.Text = "Please select a valid user type."
        Else
            Lbl_msgggender.Text = ""
        End If

    End Sub



    Private Sub addnewguest_btn_Click(sender As Object, e As EventArgs) Handles addnewguest_btn.Click
        Dim guest_firstname As String = gfirstname_txtbx.Text.Trim()

        Dim guest_lastname As String = glastname_txtbx.Text.Trim()
        Dim guest_country As String = Country_cmbbx.SelectedItem
        Dim guest_contact As String = contact_txtbx.Text.Trim()
        Dim guest_gender As String = cmbbx_genderG.SelectedItem
        Dim guest_email As String = Gemail_txtbx.Text
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Application.Exit()
        End
    End Sub

    Private Sub newguest_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GuestID_txtbx_TextChanged(sender As Object, e As EventArgs) Handles GuestID_txtbx.TextChanged

    End Sub

    Private Sub Gemail_txtbx_TextChanged(sender As Object, e As EventArgs) Handles Gemail_txtbx.TextChanged

    End Sub

    Private Sub Country_cmbbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Country_cmbbx.SelectedIndexChanged

    End Sub

    Private Sub Lblnoofadults_Click(sender As Object, e As EventArgs) Handles Lblnoofadults.Click

    End Sub

    Private Sub nadult_txtbx_TextChanged(sender As Object, e As EventArgs) Handles nadult_txtbx.TextChanged

    End Sub

    Private Sub nchildren_txtbx_TextChanged(sender As Object, e As EventArgs) Handles nchildren_txtbx.TextChanged

    End Sub

    Private Sub contact_txtbx_TextChanged(sender As Object, e As EventArgs) Handles contact_txtbx.TextChanged

    End Sub
End Class

