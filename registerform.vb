
Imports System.Data
Imports System.Data.SqlClient

Public Class Registerform
    'Dim con As New sqlconnection
    Private Sub Registerbtn_Click(sender As Object, e As EventArgs) Handles Registerbtn.Click
        Dim loginform As New Loginform
        loginform.Show()
        Me.Hide()
    End Sub

    Private Sub Registerform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Dispose()
        End
    End Sub
End Class
