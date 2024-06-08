Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Reservation
    <Key>
    Public Property ReservationID As Integer

    <ForeignKey("User")>
    Public Property UserID As Integer

    <ForeignKey("Room")>
    Public Property RoomID As Integer

    <Required>
    Public Property CheckInDate As Date

    <Required>
    Public Property CheckOutDate As Date

    <Required>
    <MaxLength(50)>
    Public Property Status As String

    Public Overridable Property User As User
    Public Overridable Property Room As Room
    Public Overridable Property Payments As ICollection(Of Payment)
End Class
