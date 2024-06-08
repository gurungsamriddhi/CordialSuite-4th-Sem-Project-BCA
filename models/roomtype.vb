Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("roomtypetbl")>
Public Class RoomType
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    <Column("roomtypeID")>
    Public Property RoomTypeID As Integer

    <Column("roomtype")>
    Public Property RoomType As String

    <Column("Pricepernight")>
    Public Property PricePerNight As Decimal

    <Column("description")>
    Public Property Description As String

    ' Navigation property for rooms of this type
    Public Overridable Property Rooms As ICollection(Of Room)
End Class
