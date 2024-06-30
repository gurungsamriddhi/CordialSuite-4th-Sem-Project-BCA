<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class billing
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
        Lbl_billing = New Label()
        Lbl_guestname = New Label()
        guestname_txtbx = New TextBox()
        Lblroomno = New Label()
        roomno_txtbx = New TextBox()
        Lbl_Reservationid = New Label()
        reservationid_txtbx = New TextBox()
        browsereservation_btn = New Button()
        Lbl_status = New Label()
        paymentstatus_cmbbx = New ComboBox()
        Lbl_paymentmethod = New Label()
        paymentmethod_cmbbx = New ComboBox()
        Lbl_totalamount = New Label()
        totalamt_txtbx = New TextBox()
        Lbl_Services = New Label()
        Lblpaymentdate = New Label()
        paymentdate_DTP = New DateTimePicker()
        Lblroomtype = New Label()
        roomtype_txtbx = New TextBox()
        Lbl_pricepernight = New Label()
        pricepernight_txtbx = New TextBox()
        Lbldaysreserved = New Label()
        Reserveddays_txtbx = New TextBox()
        Lbl_roomtotal = New Label()
        roomtotal_txtbx = New TextBox()
        Lbl_discount = New Label()
        discount_txtbx = New TextBox()
        services_txtbx = New TextBox()
        Lbl_Servicestotal = New Label()
        servicestotal_txtbx = New TextBox()
        paymentsave_btn = New Button()
        clear_btn = New Button()
        calculate_btn = New Button()
        Lbl_msgtotal = New Label()
        Lbl_msgpaysttaus = New Label()
        lbl_msgpaymethod = New Label()
        SuspendLayout()
        ' 
        ' Lbl_billing
        ' 
        Lbl_billing.AutoSize = True
        Lbl_billing.BackColor = Color.Transparent
        Lbl_billing.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_billing.ForeColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Lbl_billing.Location = New Point(504, 25)
        Lbl_billing.Name = "Lbl_billing"
        Lbl_billing.Size = New Size(101, 31)
        Lbl_billing.TabIndex = 23
        Lbl_billing.Text = "BILLING"
        Lbl_billing.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Lbl_guestname
        ' 
        Lbl_guestname.AutoSize = True
        Lbl_guestname.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_guestname.ForeColor = Color.Black
        Lbl_guestname.Location = New Point(39, 182)
        Lbl_guestname.Name = "Lbl_guestname"
        Lbl_guestname.Size = New Size(136, 28)
        Lbl_guestname.TabIndex = 133
        Lbl_guestname.Text = "Guest Name: "
        ' 
        ' guestname_txtbx
        ' 
        guestname_txtbx.BackColor = SystemColors.ControlLightLight
        guestname_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        guestname_txtbx.ForeColor = Color.Black
        guestname_txtbx.Location = New Point(181, 172)
        guestname_txtbx.Name = "guestname_txtbx"
        guestname_txtbx.ReadOnly = True
        guestname_txtbx.Size = New Size(226, 38)
        guestname_txtbx.TabIndex = 134
        ' 
        ' Lblroomno
        ' 
        Lblroomno.AutoSize = True
        Lblroomno.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblroomno.ForeColor = Color.Black
        Lblroomno.Location = New Point(626, 99)
        Lblroomno.Name = "Lblroomno"
        Lblroomno.Size = New Size(103, 28)
        Lblroomno.TabIndex = 136
        Lblroomno.Text = "Room No:"
        ' 
        ' roomno_txtbx
        ' 
        roomno_txtbx.BackColor = SystemColors.ButtonHighlight
        roomno_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        roomno_txtbx.ForeColor = Color.Black
        roomno_txtbx.Location = New Point(747, 86)
        roomno_txtbx.Multiline = True
        roomno_txtbx.Name = "roomno_txtbx"
        roomno_txtbx.ReadOnly = True
        roomno_txtbx.Size = New Size(227, 41)
        roomno_txtbx.TabIndex = 137
        ' 
        ' Lbl_Reservationid
        ' 
        Lbl_Reservationid.AutoSize = True
        Lbl_Reservationid.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_Reservationid.ForeColor = Color.Black
        Lbl_Reservationid.Location = New Point(39, 104)
        Lbl_Reservationid.Name = "Lbl_Reservationid"
        Lbl_Reservationid.Size = New Size(144, 28)
        Lbl_Reservationid.TabIndex = 139
        Lbl_Reservationid.Text = "Reservation ID"
        ' 
        ' reservationid_txtbx
        ' 
        reservationid_txtbx.BackColor = SystemColors.ControlLightLight
        reservationid_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        reservationid_txtbx.ForeColor = Color.Black
        reservationid_txtbx.Location = New Point(182, 94)
        reservationid_txtbx.Name = "reservationid_txtbx"
        reservationid_txtbx.ReadOnly = True
        reservationid_txtbx.Size = New Size(226, 38)
        reservationid_txtbx.TabIndex = 140
        ' 
        ' browsereservation_btn
        ' 
        browsereservation_btn.Location = New Point(428, 86)
        browsereservation_btn.Name = "browsereservation_btn"
        browsereservation_btn.Size = New Size(94, 44)
        browsereservation_btn.TabIndex = 141
        browsereservation_btn.Text = "Browse"
        browsereservation_btn.UseVisualStyleBackColor = True
        ' 
        ' Lbl_status
        ' 
        Lbl_status.AutoSize = True
        Lbl_status.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_status.ForeColor = Color.Black
        Lbl_status.Location = New Point(591, 501)
        Lbl_status.Name = "Lbl_status"
        Lbl_status.Size = New Size(157, 28)
        Lbl_status.TabIndex = 142
        Lbl_status.Text = "Payment Status:"
        ' 
        ' paymentstatus_cmbbx
        ' 
        paymentstatus_cmbbx.BackColor = SystemColors.ControlLight
        paymentstatus_cmbbx.FlatStyle = FlatStyle.Flat
        paymentstatus_cmbbx.Font = New Font("Segoe UI", 13.8F)
        paymentstatus_cmbbx.ForeColor = Color.Black
        paymentstatus_cmbbx.FormattingEnabled = True
        paymentstatus_cmbbx.Items.AddRange(New Object() {"Paid"})
        paymentstatus_cmbbx.Location = New Point(754, 490)
        paymentstatus_cmbbx.Name = "paymentstatus_cmbbx"
        paymentstatus_cmbbx.Size = New Size(227, 39)
        paymentstatus_cmbbx.TabIndex = 143
        ' 
        ' Lbl_paymentmethod
        ' 
        Lbl_paymentmethod.AutoSize = True
        Lbl_paymentmethod.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_paymentmethod.ForeColor = Color.Black
        Lbl_paymentmethod.Location = New Point(594, 590)
        Lbl_paymentmethod.Name = "Lbl_paymentmethod"
        Lbl_paymentmethod.Size = New Size(174, 28)
        Lbl_paymentmethod.TabIndex = 144
        Lbl_paymentmethod.Text = "Payment Method:"
        ' 
        ' paymentmethod_cmbbx
        ' 
        paymentmethod_cmbbx.BackColor = SystemColors.ControlLight
        paymentmethod_cmbbx.FlatStyle = FlatStyle.Flat
        paymentmethod_cmbbx.Font = New Font("Segoe UI", 13.8F)
        paymentmethod_cmbbx.ForeColor = Color.Black
        paymentmethod_cmbbx.FormattingEnabled = True
        paymentmethod_cmbbx.Items.AddRange(New Object() {"Cash", "Credit Card", "Online"})
        paymentmethod_cmbbx.Location = New Point(774, 579)
        paymentmethod_cmbbx.Name = "paymentmethod_cmbbx"
        paymentmethod_cmbbx.Size = New Size(207, 39)
        paymentmethod_cmbbx.TabIndex = 145
        ' 
        ' Lbl_totalamount
        ' 
        Lbl_totalamount.AutoSize = True
        Lbl_totalamount.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_totalamount.ForeColor = Color.Black
        Lbl_totalamount.Location = New Point(69, 517)
        Lbl_totalamount.Name = "Lbl_totalamount"
        Lbl_totalamount.Size = New Size(60, 28)
        Lbl_totalamount.TabIndex = 148
        Lbl_totalamount.Text = "Total:"
        ' 
        ' totalamt_txtbx
        ' 
        totalamt_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        totalamt_txtbx.ForeColor = Color.Black
        totalamt_txtbx.Location = New Point(185, 507)
        totalamt_txtbx.Name = "totalamt_txtbx"
        totalamt_txtbx.Size = New Size(227, 38)
        totalamt_txtbx.TabIndex = 149
        ' 
        ' Lbl_Services
        ' 
        Lbl_Services.AutoSize = True
        Lbl_Services.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_Services.ForeColor = Color.Black
        Lbl_Services.Location = New Point(626, 348)
        Lbl_Services.Name = "Lbl_Services"
        Lbl_Services.Size = New Size(91, 28)
        Lbl_Services.TabIndex = 150
        Lbl_Services.Text = "Services:"
        ' 
        ' Lblpaymentdate
        ' 
        Lblpaymentdate.AutoSize = True
        Lblpaymentdate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblpaymentdate.ForeColor = Color.Black
        Lblpaymentdate.Location = New Point(35, 590)
        Lblpaymentdate.Name = "Lblpaymentdate"
        Lblpaymentdate.Size = New Size(144, 28)
        Lblpaymentdate.TabIndex = 151
        Lblpaymentdate.Text = "Payment Date:"
        ' 
        ' paymentdate_DTP
        ' 
        paymentdate_DTP.CalendarForeColor = Color.Black
        paymentdate_DTP.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        paymentdate_DTP.Location = New Point(185, 584)
        paymentdate_DTP.MinDate = New Date(1909, 1, 1, 0, 0, 0, 0)
        paymentdate_DTP.Name = "paymentdate_DTP"
        paymentdate_DTP.Size = New Size(353, 34)
        paymentdate_DTP.TabIndex = 152
        paymentdate_DTP.Value = New Date(2024, 6, 6, 0, 0, 0, 0)
        ' 
        ' Lblroomtype
        ' 
        Lblroomtype.AutoSize = True
        Lblroomtype.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblroomtype.ForeColor = Color.Black
        Lblroomtype.Location = New Point(47, 265)
        Lblroomtype.Name = "Lblroomtype"
        Lblroomtype.Size = New Size(119, 28)
        Lblroomtype.TabIndex = 153
        Lblroomtype.Text = "Room Type:"
        ' 
        ' roomtype_txtbx
        ' 
        roomtype_txtbx.BackColor = SystemColors.ControlLightLight
        roomtype_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        roomtype_txtbx.ForeColor = Color.Black
        roomtype_txtbx.Location = New Point(185, 252)
        roomtype_txtbx.Multiline = True
        roomtype_txtbx.Name = "roomtype_txtbx"
        roomtype_txtbx.ReadOnly = True
        roomtype_txtbx.Size = New Size(223, 41)
        roomtype_txtbx.TabIndex = 154
        ' 
        ' Lbl_pricepernight
        ' 
        Lbl_pricepernight.AutoSize = True
        Lbl_pricepernight.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_pricepernight.ForeColor = Color.Black
        Lbl_pricepernight.Location = New Point(581, 265)
        Lbl_pricepernight.Name = "Lbl_pricepernight"
        Lbl_pricepernight.Size = New Size(150, 28)
        Lbl_pricepernight.TabIndex = 155
        Lbl_pricepernight.Text = "Price Per night:"
        ' 
        ' pricepernight_txtbx
        ' 
        pricepernight_txtbx.BackColor = SystemColors.ControlLightLight
        pricepernight_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pricepernight_txtbx.ForeColor = Color.Black
        pricepernight_txtbx.Location = New Point(751, 252)
        pricepernight_txtbx.Multiline = True
        pricepernight_txtbx.Name = "pricepernight_txtbx"
        pricepernight_txtbx.ReadOnly = True
        pricepernight_txtbx.Size = New Size(223, 41)
        pricepernight_txtbx.TabIndex = 156
        ' 
        ' Lbldaysreserved
        ' 
        Lbldaysreserved.AutoSize = True
        Lbldaysreserved.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbldaysreserved.ForeColor = Color.Black
        Lbldaysreserved.Location = New Point(594, 182)
        Lbldaysreserved.Name = "Lbldaysreserved"
        Lbldaysreserved.Size = New Size(137, 28)
        Lbldaysreserved.TabIndex = 157
        Lbldaysreserved.Text = "Reserve Days:"
        ' 
        ' Reserveddays_txtbx
        ' 
        Reserveddays_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Reserveddays_txtbx.ForeColor = Color.Black
        Reserveddays_txtbx.Location = New Point(747, 169)
        Reserveddays_txtbx.Name = "Reserveddays_txtbx"
        Reserveddays_txtbx.Size = New Size(227, 38)
        Reserveddays_txtbx.TabIndex = 158
        ' 
        ' Lbl_roomtotal
        ' 
        Lbl_roomtotal.AutoSize = True
        Lbl_roomtotal.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_roomtotal.ForeColor = Color.Black
        Lbl_roomtotal.Location = New Point(48, 353)
        Lbl_roomtotal.Name = "Lbl_roomtotal"
        Lbl_roomtotal.Size = New Size(119, 28)
        Lbl_roomtotal.TabIndex = 159
        Lbl_roomtotal.Text = "Room Total:"
        ' 
        ' roomtotal_txtbx
        ' 
        roomtotal_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        roomtotal_txtbx.ForeColor = Color.Black
        roomtotal_txtbx.Location = New Point(185, 343)
        roomtotal_txtbx.Name = "roomtotal_txtbx"
        roomtotal_txtbx.Size = New Size(227, 38)
        roomtotal_txtbx.TabIndex = 160
        ' 
        ' Lbl_discount
        ' 
        Lbl_discount.AutoSize = True
        Lbl_discount.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_discount.ForeColor = Color.Black
        Lbl_discount.Location = New Point(620, 430)
        Lbl_discount.Name = "Lbl_discount"
        Lbl_discount.Size = New Size(97, 28)
        Lbl_discount.TabIndex = 161
        Lbl_discount.Text = "Discount:"
        ' 
        ' discount_txtbx
        ' 
        discount_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        discount_txtbx.ForeColor = Color.Black
        discount_txtbx.Location = New Point(747, 420)
        discount_txtbx.Name = "discount_txtbx"
        discount_txtbx.Size = New Size(233, 38)
        discount_txtbx.TabIndex = 162
        ' 
        ' services_txtbx
        ' 
        services_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        services_txtbx.ForeColor = Color.Black
        services_txtbx.Location = New Point(751, 333)
        services_txtbx.Multiline = True
        services_txtbx.Name = "services_txtbx"
        services_txtbx.Size = New Size(230, 38)
        services_txtbx.TabIndex = 163
        ' 
        ' Lbl_Servicestotal
        ' 
        Lbl_Servicestotal.AutoSize = True
        Lbl_Servicestotal.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_Servicestotal.ForeColor = Color.Black
        Lbl_Servicestotal.Location = New Point(39, 435)
        Lbl_Servicestotal.Name = "Lbl_Servicestotal"
        Lbl_Servicestotal.Size = New Size(140, 28)
        Lbl_Servicestotal.TabIndex = 164
        Lbl_Servicestotal.Text = "Services Total:"
        ' 
        ' servicestotal_txtbx
        ' 
        servicestotal_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        servicestotal_txtbx.ForeColor = Color.Black
        servicestotal_txtbx.Location = New Point(185, 425)
        servicestotal_txtbx.Multiline = True
        servicestotal_txtbx.Name = "servicestotal_txtbx"
        servicestotal_txtbx.Size = New Size(227, 38)
        servicestotal_txtbx.TabIndex = 165
        ' 
        ' paymentsave_btn
        ' 
        paymentsave_btn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        paymentsave_btn.FlatAppearance.BorderColor = SystemColors.Window
        paymentsave_btn.FlatAppearance.BorderSize = 2
        paymentsave_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        paymentsave_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        paymentsave_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        paymentsave_btn.FlatStyle = FlatStyle.Flat
        paymentsave_btn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        paymentsave_btn.ForeColor = SystemColors.ControlLightLight
        paymentsave_btn.Location = New Point(536, 704)
        paymentsave_btn.Name = "paymentsave_btn"
        paymentsave_btn.Size = New Size(152, 51)
        paymentsave_btn.TabIndex = 166
        paymentsave_btn.Text = "Save"
        paymentsave_btn.UseVisualStyleBackColor = False
        ' 
        ' clear_btn
        ' 
        clear_btn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        clear_btn.FlatAppearance.BorderColor = SystemColors.Window
        clear_btn.FlatAppearance.BorderSize = 2
        clear_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        clear_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        clear_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        clear_btn.FlatStyle = FlatStyle.Flat
        clear_btn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        clear_btn.ForeColor = SystemColors.ControlLightLight
        clear_btn.Location = New Point(705, 704)
        clear_btn.Name = "clear_btn"
        clear_btn.Size = New Size(137, 51)
        clear_btn.TabIndex = 167
        clear_btn.Text = "Clear"
        clear_btn.UseVisualStyleBackColor = False
        ' 
        ' calculate_btn
        ' 
        calculate_btn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        calculate_btn.FlatAppearance.BorderColor = SystemColors.Window
        calculate_btn.FlatAppearance.BorderSize = 2
        calculate_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        calculate_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        calculate_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        calculate_btn.FlatStyle = FlatStyle.Flat
        calculate_btn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        calculate_btn.ForeColor = SystemColors.ControlLightLight
        calculate_btn.Location = New Point(370, 704)
        calculate_btn.Name = "calculate_btn"
        calculate_btn.Size = New Size(152, 51)
        calculate_btn.TabIndex = 168
        calculate_btn.Text = "Calculate"
        calculate_btn.UseVisualStyleBackColor = False
        ' 
        ' Lbl_msgtotal
        ' 
        Lbl_msgtotal.AutoSize = True
        Lbl_msgtotal.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_msgtotal.ForeColor = Color.Red
        Lbl_msgtotal.Location = New Point(69, 553)
        Lbl_msgtotal.Name = "Lbl_msgtotal"
        Lbl_msgtotal.Size = New Size(0, 20)
        Lbl_msgtotal.TabIndex = 169
        ' 
        ' Lbl_msgpaysttaus
        ' 
        Lbl_msgpaysttaus.AutoSize = True
        Lbl_msgpaysttaus.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_msgpaysttaus.ForeColor = Color.Red
        Lbl_msgpaysttaus.Location = New Point(605, 538)
        Lbl_msgpaysttaus.Name = "Lbl_msgpaysttaus"
        Lbl_msgpaysttaus.Size = New Size(0, 20)
        Lbl_msgpaysttaus.TabIndex = 170
        ' 
        ' lbl_msgpaymethod
        ' 
        lbl_msgpaymethod.AutoSize = True
        lbl_msgpaymethod.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_msgpaymethod.ForeColor = Color.Red
        lbl_msgpaymethod.Location = New Point(605, 618)
        lbl_msgpaymethod.Name = "lbl_msgpaymethod"
        lbl_msgpaymethod.Size = New Size(0, 20)
        lbl_msgpaymethod.TabIndex = 171
        ' 
        ' billing
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Menu
        ClientSize = New Size(1077, 777)
        Controls.Add(lbl_msgpaymethod)
        Controls.Add(Lbl_msgpaysttaus)
        Controls.Add(Lbl_msgtotal)
        Controls.Add(calculate_btn)
        Controls.Add(clear_btn)
        Controls.Add(paymentsave_btn)
        Controls.Add(servicestotal_txtbx)
        Controls.Add(Lbl_Servicestotal)
        Controls.Add(services_txtbx)
        Controls.Add(discount_txtbx)
        Controls.Add(Lbl_discount)
        Controls.Add(roomtotal_txtbx)
        Controls.Add(Lbl_roomtotal)
        Controls.Add(Reserveddays_txtbx)
        Controls.Add(Lbldaysreserved)
        Controls.Add(pricepernight_txtbx)
        Controls.Add(Lbl_pricepernight)
        Controls.Add(roomtype_txtbx)
        Controls.Add(Lblroomtype)
        Controls.Add(paymentdate_DTP)
        Controls.Add(Lblpaymentdate)
        Controls.Add(Lbl_Services)
        Controls.Add(totalamt_txtbx)
        Controls.Add(Lbl_totalamount)
        Controls.Add(paymentmethod_cmbbx)
        Controls.Add(Lbl_paymentmethod)
        Controls.Add(paymentstatus_cmbbx)
        Controls.Add(Lbl_status)
        Controls.Add(browsereservation_btn)
        Controls.Add(reservationid_txtbx)
        Controls.Add(Lbl_Reservationid)
        Controls.Add(roomno_txtbx)
        Controls.Add(Lblroomno)
        Controls.Add(guestname_txtbx)
        Controls.Add(Lbl_guestname)
        Controls.Add(Lbl_billing)
        FormBorderStyle = FormBorderStyle.None
        Name = "billing"
        Text = "billing"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Lbl_billing As Label
    Friend WithEvents Lbl_guestname As Label
    Friend WithEvents guestname_txtbx As TextBox
    Friend WithEvents Lblroomno As Label
    Friend WithEvents roomno_txtbx As TextBox
    Friend WithEvents Lbl_Reservationid As Label
    Friend WithEvents reservationid_txtbx As TextBox
    Friend WithEvents browsereservation_btn As Button
    Friend WithEvents Lbl_status As Label
    Friend WithEvents paymentstatus_cmbbx As ComboBox
    Friend WithEvents Lbl_paymentmethod As Label
    Friend WithEvents paymentmethod_cmbbx As ComboBox
    Friend WithEvents Lbl_totalamount As Label
    Friend WithEvents totalamt_txtbx As TextBox
    Friend WithEvents Lbl_Services As Label
    Friend WithEvents Lblpaymentdate As Label
    Friend WithEvents paymentdate_DTP As DateTimePicker
    Friend WithEvents Lblroomtype As Label
    Friend WithEvents roomtype_txtbx As TextBox
    Friend WithEvents Lbl_pricepernight As Label
    Friend WithEvents pricepernight_txtbx As TextBox
    Friend WithEvents Lbldaysreserved As Label
    Friend WithEvents Reserveddays_txtbx As TextBox
    Friend WithEvents Lbl_roomtotal As Label
    Friend WithEvents roomtotal_txtbx As TextBox
    Friend WithEvents Lbl_discount As Label
    Friend WithEvents discount_txtbx As TextBox
    Friend WithEvents services_txtbx As TextBox
    Friend WithEvents Lbl_Servicestotal As Label
    Friend WithEvents servicestotal_txtbx As TextBox
    Friend WithEvents paymentsave_btn As Button
    Friend WithEvents clear_btn As Button
    Friend WithEvents calculate_btn As Button
    Friend WithEvents Lbl_msgtotal As Label
    Friend WithEvents Lbl_msgpaysttaus As Label
    Friend WithEvents lbl_msgpaymethod As Label
End Class
