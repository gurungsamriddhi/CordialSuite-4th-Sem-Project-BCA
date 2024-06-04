
Imports System.Data
Imports System.Data.SqlClient

Public Class Registerform
    'Dim con As New sqlconnection
    Private Sub Registerbtn_Click(sender As Object, e As EventArgs) Handles Registerbtn.Click
        ' Retrieve and trim text inputs from textboxes
        Dim user_firstname As String = userfn_txtbx.Text.Trim()
        Dim user_lastname As String = userln_txtbx.Text.Trim()
        Dim user_address As String = userAddress_txtbx.Text.Trim()

        ' Retrieve date input from DateTimePicker
        Dim user_dateofbirth As Date = userDOB_dtp.Value

        ' Ensure that a selection is made in the ComboBox and retrieve the selected item
        Dim user_type As String
        If usertype_cmbbx.SelectedItem IsNot Nothing Then
            user_type = usertype_cmbbx.SelectedItem.ToString()
        Else
            MessageBox.Show("Please select a user type.")
            Exit Sub
        End If

        ' Ensure that a selection is made in the ComboBox and retrieve the selected item
        Dim user_gender As String
        If gender_cmbbx.SelectedItem IsNot Nothing Then
            user_gender = gender_cmbbx.SelectedItem.ToString()
        Else
            MessageBox.Show("Please select a gender.")
            Exit Sub
        End If

        ' Validate and trim phone number input
        Dim user_phone As String = userPhone_txtbx.Text.Trim()
        If String.IsNullOrEmpty(user_phone) Then
            MessageBox.Show("Please enter a valid phone number.")
            Exit Sub
        End If


        Dim loginform As New Loginform
        loginform.Show()

    End Sub

    Private Sub Registerform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Dispose()
        End
    End Sub


    Private Sub Linktologin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Linktologin.LinkClicked
        Dim userloginform As New Loginform
        Loginform.Show()
        Hide()
    End Sub
End Class
