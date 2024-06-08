Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Payment
    <Key>
    Public Property PaymentID As Integer

    <ForeignKey("Reservation")>
    Public Property ReservationID As Integer
    Public Property PaymentDate As Date


    Public Property Amount As Decimal

    <MaxLength(50)>
    Public Property PaymentMethod As String

    Public Overridable Property Reservation As Reservation
End Class
