<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class roomsales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Lbl_transaction = New Label()
        DGV_sales = New DataGridView()
        Guestfirstname = New DataGridViewTextBoxColumn()
        guestlastname = New DataGridViewTextBoxColumn()
        Roomno = New DataGridViewTextBoxColumn()
        roomtype = New DataGridViewTextBoxColumn()
        Bedcount = New DataGridViewTextBoxColumn()
        Roomtotal = New DataGridViewTextBoxColumn()
        Services = New DataGridViewTextBoxColumn()
        Servicestotal = New DataGridViewTextBoxColumn()
        Paymentdate = New DataGridViewTextBoxColumn()
        paymentmethod = New DataGridViewTextBoxColumn()
        discount = New DataGridViewTextBoxColumn()
        totalamount = New DataGridViewTextBoxColumn()
        Lbl_totalroomsales = New Label()
        Lbl_totalroomsalesamtshow = New Label()
        selectperiod_cmbbx = New ComboBox()
        Lbl_Selectperiod = New Label()
        CType(DGV_sales, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Lbl_transaction
        ' 
        Lbl_transaction.AutoSize = True
        Lbl_transaction.BackColor = Color.Transparent
        Lbl_transaction.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_transaction.ForeColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Lbl_transaction.Location = New Point(484, 20)
        Lbl_transaction.Name = "Lbl_transaction"
        Lbl_transaction.Size = New Size(74, 31)
        Lbl_transaction.TabIndex = 25
        Lbl_transaction.Text = " Sales"
        Lbl_transaction.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DGV_sales
        ' 
        DGV_sales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV_sales.BackgroundColor = SystemColors.Control
        DGV_sales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_sales.Columns.AddRange(New DataGridViewColumn() {Guestfirstname, guestlastname, Roomno, roomtype, Bedcount, Roomtotal, Services, Servicestotal, Paymentdate, paymentmethod, discount, totalamount})
        DGV_sales.Location = New Point(59, 134)
        DGV_sales.Name = "DGV_sales"
        DGV_sales.RowHeadersWidth = 51
        DGV_sales.Size = New Size(984, 421)
        DGV_sales.TabIndex = 26
        ' 
        ' Guestfirstname
        ' 
        Guestfirstname.DataPropertyName = "Firstname"
        Guestfirstname.HeaderText = "Guest Firstname"
        Guestfirstname.MinimumWidth = 6
        Guestfirstname.Name = "Guestfirstname"
        ' 
        ' guestlastname
        ' 
        guestlastname.DataPropertyName = "Lastname"
        guestlastname.HeaderText = "Guest Lastname"
        guestlastname.MinimumWidth = 6
        guestlastname.Name = "guestlastname"
        ' 
        ' Roomno
        ' 
        Roomno.DataPropertyName = "Roomnumber"
        Roomno.HeaderText = "Room No"
        Roomno.MinimumWidth = 6
        Roomno.Name = "Roomno"
        ' 
        ' roomtype
        ' 
        roomtype.DataPropertyName = "Roomtype"
        roomtype.HeaderText = "Room Type"
        roomtype.MinimumWidth = 6
        roomtype.Name = "roomtype"
        ' 
        ' Bedcount
        ' 
        Bedcount.DataPropertyName = "BedCount"
        Bedcount.HeaderText = "Bed Count"
        Bedcount.MinimumWidth = 6
        Bedcount.Name = "Bedcount"
        ' 
        ' Roomtotal
        ' 
        Roomtotal.DataPropertyName = "TotalAmount"
        Roomtotal.HeaderText = "Room Total"
        Roomtotal.MinimumWidth = 6
        Roomtotal.Name = "Roomtotal"
        ' 
        ' Services
        ' 
        Services.DataPropertyName = "Services"
        Services.HeaderText = "Services"
        Services.MinimumWidth = 6
        Services.Name = "Services"
        ' 
        ' Servicestotal
        ' 
        Servicestotal.DataPropertyName = "Servicestotal"
        Servicestotal.HeaderText = "Services Total"
        Servicestotal.MinimumWidth = 6
        Servicestotal.Name = "Servicestotal"
        ' 
        ' Paymentdate
        ' 
        Paymentdate.DataPropertyName = "PaymentDate"
        Paymentdate.HeaderText = "Payment Date"
        Paymentdate.MinimumWidth = 6
        Paymentdate.Name = "Paymentdate"
        ' 
        ' paymentmethod
        ' 
        paymentmethod.DataPropertyName = "PaymentMethod"
        paymentmethod.HeaderText = "Payment Method"
        paymentmethod.MinimumWidth = 6
        paymentmethod.Name = "paymentmethod"
        ' 
        ' discount
        ' 
        discount.DataPropertyName = "Discount"
        discount.HeaderText = "Discount"
        discount.MinimumWidth = 6
        discount.Name = "discount"
        ' 
        ' totalamount
        ' 
        totalamount.DataPropertyName = "Amount"
        totalamount.HeaderText = "Total Amount"
        totalamount.MinimumWidth = 6
        totalamount.Name = "totalamount"
        ' 
        ' Lbl_totalroomsales
        ' 
        Lbl_totalroomsales.AutoSize = True
        Lbl_totalroomsales.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_totalroomsales.Location = New Point(59, 678)
        Lbl_totalroomsales.Name = "Lbl_totalroomsales"
        Lbl_totalroomsales.Size = New Size(112, 28)
        Lbl_totalroomsales.TabIndex = 27
        Lbl_totalroomsales.Text = "Total Sales:"
        ' 
        ' Lbl_totalroomsalesamtshow
        ' 
        Lbl_totalroomsalesamtshow.AutoSize = True
        Lbl_totalroomsalesamtshow.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_totalroomsalesamtshow.Location = New Point(234, 656)
        Lbl_totalroomsalesamtshow.Name = "Lbl_totalroomsalesamtshow"
        Lbl_totalroomsalesamtshow.Size = New Size(0, 28)
        Lbl_totalroomsalesamtshow.TabIndex = 28
        ' 
        ' selectperiod_cmbbx
        ' 
        selectperiod_cmbbx.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        selectperiod_cmbbx.FormattingEnabled = True
        selectperiod_cmbbx.Items.AddRange(New Object() {"One Month", "One Year"})
        selectperiod_cmbbx.Location = New Point(244, 619)
        selectperiod_cmbbx.Name = "selectperiod_cmbbx"
        selectperiod_cmbbx.Size = New Size(151, 36)
        selectperiod_cmbbx.TabIndex = 29
        ' 
        ' Lbl_Selectperiod
        ' 
        Lbl_Selectperiod.AutoSize = True
        Lbl_Selectperiod.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_Selectperiod.Location = New Point(59, 622)
        Lbl_Selectperiod.Name = "Lbl_Selectperiod"
        Lbl_Selectperiod.Size = New Size(135, 28)
        Lbl_Selectperiod.TabIndex = 30
        Lbl_Selectperiod.Text = "Select Period:"
        ' 
        ' roomsales
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1077, 777)
        Controls.Add(Lbl_Selectperiod)
        Controls.Add(selectperiod_cmbbx)
        Controls.Add(Lbl_totalroomsalesamtshow)
        Controls.Add(Lbl_totalroomsales)
        Controls.Add(DGV_sales)
        Controls.Add(Lbl_transaction)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "roomsales"
        Text = "Revenue"
        CType(DGV_sales, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_transaction As Label
    Friend WithEvents DGV_sales As DataGridView
    Friend WithEvents Lbl_totalroomsales As Label
    Friend WithEvents Lbl_totalroomsalesamtshow As Label
    Friend WithEvents selectperiod_cmbbx As ComboBox
    Friend WithEvents Lbl_Selectperiod As Label
    Friend WithEvents Guestfirstname As DataGridViewTextBoxColumn
    Friend WithEvents guestlastname As DataGridViewTextBoxColumn
    Friend WithEvents Roomno As DataGridViewTextBoxColumn
    Friend WithEvents roomtype As DataGridViewTextBoxColumn
    Friend WithEvents Bedcount As DataGridViewTextBoxColumn
    Friend WithEvents Roomtotal As DataGridViewTextBoxColumn
    Friend WithEvents Services As DataGridViewTextBoxColumn
    Friend WithEvents Servicestotal As DataGridViewTextBoxColumn
    Friend WithEvents Paymentdate As DataGridViewTextBoxColumn
    Friend WithEvents paymentmethod As DataGridViewTextBoxColumn
    Friend WithEvents discount As DataGridViewTextBoxColumn
    Friend WithEvents totalamount As DataGridViewTextBoxColumn
End Class
