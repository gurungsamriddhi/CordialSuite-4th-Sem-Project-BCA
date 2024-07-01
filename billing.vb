
Imports System.Data.SqlClient
Public Class Billing
    Dim managebilling As New billingSql()
    Private Sub browsereservation_btn_Click(sender As Object, e As EventArgs) Handles browsereservation_btn.Click
        Dim reservationselection As New browsereservations(Me)

        reservationselection.ShowDialog()
    End Sub
    Public Sub ReservationSelection(reservationid As Integer, roomNumber As String, roomType As String, reserveddays As Integer, guestname As String, roomtotal As Decimal, pricepernight As Decimal)
        ' Display room details in text boxes or any other controls as needed
        reservationid_txtbx.Text = reservationid
        roomno_txtbx.Text = roomNumber
        roomtype_txtbx.Text = roomType
        Reserveddays_txtbx.Text = reserveddays
        guestname_txtbx.Text = guestname
        roomtotal_txtbx.Text = roomtotal
        pricepernight_txtbx.Text = pricepernight.ToString()

        roomno_txtbx.ReadOnly = True
        roomtype_txtbx.ReadOnly = True
        Reserveddays_txtbx.ReadOnly = True
        pricepernight_txtbx.ReadOnly = True
        guestname_txtbx.ReadOnly = True
        reservationid_txtbx.ReadOnly = True
        roomtotal_txtbx.ReadOnly = True

    End Sub

    Private Sub paymentsave_btn_Click(sender As Object, e As EventArgs) Handles paymentsave_btn.Click
        If String.IsNullOrEmpty(reservationid_txtbx.Text) Then
            MessageBox.Show("Please select a reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If paymentmethod_cmbbx.SelectedItem Is Nothing Then
            lbl_msgpaymethod.Text = "Please select a payment method."
            Return
        End If
        Dim paymentMethod As String = paymentmethod_cmbbx.SelectedItem.ToString()

        ' Validate Payment Status
        If paymentstatus_cmbbx.SelectedItem Is Nothing Then
            Lbl_msgpaysttaus.Text = "Please select a payment status."
            Return
        End If

        Dim amount As Decimal
        If Not Decimal.TryParse(totalamt_txtbx.Text, amount) AndAlso String.IsNullOrEmpty(amount) Then
            Lbl_msgtotal.Text = "Please enter a valid total amount or calculate it."
            Return
        End If
        Dim status As String = paymentstatus_cmbbx.SelectedItem.ToString()

        Dim reservationID As Integer = Integer.Parse(reservationid_txtbx.Text)
        Dim paymentDate As Date = paymentdate_DTP.Value ' Get payment date from DateTimePicker

        Dim discount As Decimal
        If String.IsNullOrWhiteSpace(discount_txtbx.Text) Then
            discount = 0 ' Set default value if the text box is empty
        Else
            discount = Decimal.Parse(discount_txtbx.Text)
        End If

        ' Get services from TextBox (no need to check for empty as string can be empty)
        Dim services As String = services_txtbx.Text

        ' Check if the servicesTotal text box is empty and parse the value if it's not
        Dim servicesTotal As Decimal
        If String.IsNullOrWhiteSpace(servicestotal_txtbx.Text) Then
            servicesTotal = 0 ' Set default value if the text box is empty
        Else
            servicesTotal = Decimal.Parse(servicestotal_txtbx.Text)
        End If

        ' Construct the SQL query using parameterized query to avoid SQL injection
        Dim query As String = "INSERT INTO payments (ReservationID, PaymentDate, Amount, PaymentMethod, Status, Discount, Services, Servicestotal) " &
                              "VALUES (@ReservationID, @PaymentDate, @Amount, @PaymentMethod, @Status, @Discount, @Services, @Servicestotal)"

        ' Create a list of SQL parameters for safe insertion
        Dim parameters As New List(Of SqlParameter)()
        parameters.Add(New SqlParameter("@ReservationID", reservationID))
        parameters.Add(New SqlParameter("@PaymentDate", paymentDate))
        parameters.Add(New SqlParameter("@Amount", amount))
        parameters.Add(New SqlParameter("@PaymentMethod", paymentMethod))
        parameters.Add(New SqlParameter("@Status", status))
        parameters.Add(New SqlParameter("@Discount", discount))
        parameters.Add(New SqlParameter("@Services", services))
        parameters.Add(New SqlParameter("@Servicestotal", servicesTotal))

        ' Execute the insertion query
        managebilling.ExecuteNonQueryWithParameters(query, parameters)

        MessageBox.Show("Payment saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub calculate_btn_Click(sender As Object, e As EventArgs) Handles calculate_btn.Click
        Dim roomTotal As Decimal
        If Decimal.TryParse(roomtotal_txtbx.Text, roomTotal) Then
            Dim discount As Decimal = 0
            Dim servicesTotal As Decimal = 0

            If Not String.IsNullOrEmpty(discount_txtbx.Text) Then
                Decimal.TryParse(discount_txtbx.Text, discount)
            End If

            If Not String.IsNullOrEmpty(servicestotal_txtbx.Text) Then
                Decimal.TryParse(servicestotal_txtbx.Text, servicesTotal)
            End If

            Dim totalAmount As Decimal = roomTotal - discount + servicesTotal
            totalamt_txtbx.Text = totalAmount.ToString()
        Else
            totalamt_txtbx.Text = roomtotal_txtbx.Text ' Show room total if it's valid, otherwise leave it empty or handle as needed
        End If
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        reservationid_txtbx.Clear()
        roomno_txtbx.Clear()
        roomtype_txtbx.Clear()
        totalamt_txtbx.Clear()
        servicestotal_txtbx.Clear()
        services_txtbx.Clear()
        pricepernight_txtbx.Clear()
        paymentmethod_cmbbx.SelectedIndex = -1
        paymentstatus_cmbbx.SelectedIndex = -1
        paymentdate_DTP.Value = Date.Today
        guestname_txtbx.Clear()
        discount_txtbx.Clear()
        Reserveddays_txtbx.Clear()
        roomtotal_txtbx.Clear()

    End Sub

    Private Sub billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        paymentdate_DTP.Value = Date.Today
    End Sub
End Class