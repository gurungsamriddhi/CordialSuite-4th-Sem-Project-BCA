Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("users")>
Public Class User
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    <Column("id")>
    Public Property UserID As Integer

    <Column("first_name")>
    Public Property FirstName As String

    <Column("last_name")>
    Public Property LastName As String

    <Column("address")>
    Public Property Address As String

    <Column("phonenumber")>
    Public Property PhoneNumber As String

    <Column("age")>
    Public Property Age As Integer?

    <Column("gender")>
    Public Property Gender As String

    <Column("user_type")>
    Public Property UserType As String

    <Column("username")>
    Public Property Username As String

    <Column("password")>
    Public Property Password As String
End Class
