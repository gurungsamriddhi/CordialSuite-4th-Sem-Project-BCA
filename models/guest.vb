Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Guest
    <Key>
    Public Property GuestId As Integer

    <Column("GFirst_name")>
    Public Property FirstName As String

    <Column("GLast_name")>
    Public Property LastName As String

    <Column("GCountry")>
    Public Property Country As String

    <Column("GPhonenumber")>
    Public Property PhoneNumber As String

    <Column("GGender")>
    Public Property Gender As String

    <Column("GEmail")>
    Public Property Email As String
End Class
