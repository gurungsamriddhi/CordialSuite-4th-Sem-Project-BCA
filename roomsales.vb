Public Class roomsales

    Dim viewsales As New billingSql()

    Private Sub roomsales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populatesales()
        PopulateMonths()
    End Sub

    Private Sub populatesales()
        Dim query As String = "SELECT 
            guests.FirstName,
            guests.LastName,
            rooms.RoomNumber,
            rooms.RoomType,
            rooms.BedCount,
            reservations.TotalAmount,
            payments.Services,
            payments.Servicestotal,
            payments.Discount,
            payments.Amount,
            payments.PaymentMethod,
            payments.PaymentDate
        FROM
            reservations
            INNER JOIN guests ON reservations.GuestID = guests.GuestID
            INNER JOIN rooms ON reservations.RoomID = rooms.RoomID
            INNER JOIN payments ON reservations.ReservationID = payments.ReservationID
        WHERE
            payments.Status = 'Paid';"

        viewsales.ExecuteQuery(query, DGV_sales)

        DGV_sales.DefaultCellStyle.BackColor = Color.White
        DGV_sales.DefaultCellStyle.ForeColor = Color.Black
        DGV_sales.AlternatingRowsDefaultCellStyle = Nothing
    End Sub

    Private Sub PopulateMonths()
        selectperiod_cmbbx.Items.Clear()
        For i As Integer = 1 To 12
            selectperiod_cmbbx.Items.Add(New DateTime(1, i, 1).ToString("MMMM"))
        Next
        selectperiod_cmbbx.SelectedIndex = DateTime.Now.Month - 1
    End Sub

    Private Sub selectperiod_cmbbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles selectperiod_cmbbx.SelectedIndexChanged
        FilterSalesByMonth(selectperiod_cmbbx.SelectedIndex + 1)
    End Sub

    Private Sub FilterSalesByMonth(month As Integer)
        Dim query As String = "SELECT 
            guests.FirstName,
            guests.LastName,
            rooms.RoomNumber,
            rooms.RoomType,
            rooms.BedCount,
            reservations.TotalAmount,
            payments.Services,
            payments.Servicestotal,
            payments.Discount,
            payments.Amount,
            payments.PaymentMethod,
            payments.PaymentDate
        FROM
            reservations
            INNER JOIN guests ON reservations.GuestID = guests.GuestID
            INNER JOIN rooms ON reservations.RoomID = rooms.RoomID
            INNER JOIN payments ON reservations.ReservationID = payments.ReservationID
        WHERE
            payments.Status = 'Paid'
            AND MONTH(payments.PaymentDate) = @SelectedMonth;"

        viewsales.ExecuteQuery(query.Replace("@SelectedMonth", month.ToString()), DGV_sales)
        CalculateTotalAmount()
    End Sub

    Private Sub CalculateTotalAmount()
        Dim totalAmount As Decimal = 0
        For Each row As DataGridViewRow In DGV_sales.Rows
            If Not row.IsNewRow Then
                totalAmount += Convert.ToDecimal(row.Cells("totalamount").Value)
            End If
        Next
        Lbl_totalroomsales.Text = "Total Room Sales: " & totalAmount.ToString("F2")
    End Sub
End Class
