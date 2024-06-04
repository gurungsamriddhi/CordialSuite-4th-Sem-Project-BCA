
Imports System.Data
Imports System.Data.SqlClient

Public Class Registerform
    'Dim con As New sqlconnection
    Private Sub Registerbtn_Click(sender As Object, e As EventArgs) Handles Registerbtn.Click
        'Dim user_firstname As String = userfn_txtbx.Text
        'Dim user_lastname As String = userLn_txtbx.Text
        'Dim user_address As String = Useraddress_txtbx.Text
        'Dim user_dateofbirth As Date = user_dobDTP.Value
        'Dim user_type As String = usertype_cmbbx.SelectedItem.Text
        'Dim user_gender As String = usergender_cmbbx.SelectedItem.text
        'Dim user_phone As Long = userPhone_txtbx.Text


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
