Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("roomstbl")>
Public Class Room
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    <Column("roomID")>
    Public Property RoomID As Integer

    <Column("Room_status")>
    Public Property RoomStatus As String

    <Column("Room_typeID")>
    Public Property RoomTypeID As Integer

    <Column("room_number")>
    Public Property RoomNumber As String

    ' Navigation property for the room type
    Public Overridable Property RoomType As RoomType
End Class
