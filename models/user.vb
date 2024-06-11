Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("users")>
Public Class User
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    <Column("id")>
    Public Property UserID As Integer

    <Column("Firstname")>
    Public Property FirstName As String

    <Column("Lastname")>
    Public Property LastName As String

    <Column("Address")>
    Public Property Address As String

    <Column("PhoneNumber")>
    Public Property PhoneNumber As String

    <Column("Age")>
    Public Property Age As Integer?

    <Column("Gender")>
    Public Property Gender As String

    <Column("UserType")>
    Public Property UserType As String

    <Column("Username")>
    Public Property Username As String

    <Column("Password")>
    Public Property Password As String
End Class
