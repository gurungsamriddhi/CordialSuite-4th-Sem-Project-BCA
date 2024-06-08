Imports System.Data.SqlClient



Public Class Newguest_form
    Dim isvalidinput As Boolean
    Public Sub Guest()

    End Sub


    Private Sub Newguestbtn_Click(sender As Object, e As EventArgs) Handles addnewguest_btn.Click

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

End Class