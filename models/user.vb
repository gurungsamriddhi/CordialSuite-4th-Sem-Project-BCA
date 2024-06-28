Imports System.ComponentModel.DataAnnotations.Schema

Public Class user
    <Column("id")>
    Public Property UserID As Integer
    <Column("FirstName")>
    Public Property FirstName As String
    <Column("LastName")>
    Public Property LastName As String
    <Column("Address")>
    Public Property Address As String
    <Column("PhoneNumber")>
    Public Property PhoneNumber As String
    <Column("Gender")>
    Public Property Gender As String
    <Column("UserType")>
    Public Property UserType As String
    <Column("Username")>
    Public Property Username As String
    <Column("Password")>
    Public Property Password As String
    <Column("Age")>
    Public Property Age As Integer

End Class