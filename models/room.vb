Imports System.ComponentModel.DataAnnotations

Public Class roomsproperty

    Public Property roomId As Integer
    Public Property RoomNumber As String
    Public Property roomType As String

    Public Property roomtypeid As Integer
    Public Property pricepernight As Decimal
    <MaxLength(266)>
    Public Property Description As String



End Class
