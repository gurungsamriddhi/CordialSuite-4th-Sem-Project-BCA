<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
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
        checkout_btn = New Button()
        TabControlreservation = New TabControl()
        tabpageaddreservations = New TabPage()
        lbl_msgstatus = New Label()
        status_cmbbx = New ComboBox()
        Label1 = New Label()
        lbl_roomidshow = New Label()
        Lbl_roomid = New Label()
        roomtype_txtbx = New TextBox()
        bedcount_txtbx = New TextBox()
        roomno_txtbx = New TextBox()
        browseroom_btn = New Button()
        Lbl_guestidshow = New Label()
        Lbl_guestid = New Label()
        Lbl_guestname = New Label()
        guestname_txtbx = New TextBox()
        browse_btn = New Button()
        Lbl_bedcount = New Label()
        Lbl_msgroomno = New Label()
        Lbl_msgdaysreserved = New Label()
        Lbl_msgguestname = New Label()
        clearbtn = New Button()
        reservationbtn = New Button()
        Reserveddays_txtbx = New TextBox()
        arrivaldate_DTP = New DateTimePicker()
        guestnumber_NUD = New NumericUpDown()
        checkoutdate_DTP = New DateTimePicker()
        Lblarrivaldate = New Label()
        Lblnguests = New Label()
        Lbldaysreserved = New Label()
        Lblroomno = New Label()
        Lblcheckoutdate = New Label()
        Lblroomtype = New Label()
        Lblguestid = New Label()
        TabPageviewreservations = New TabPage()
        Lbl_anykeyword = New Label()
        searchkeyword_txtbx = New TextBox()
        DGV_reservations = New DataGridView()
        TabPage1 = New TabPage()
        Lbl_guestcheckin = New Label()
        Lbl_msgnoofguests = New Label()
        TabControlreservation.SuspendLayout()
        tabpageaddreservations.SuspendLayout()
        CType(guestnumber_NUD, ComponentModel.ISupportInitialize).BeginInit()
        TabPageviewreservations.SuspendLayout()
        CType(DGV_reservations, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' checkout_btn
        ' 
        checkout_btn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        checkout_btn.FlatAppearance.BorderColor = SystemColors.Window
        checkout_btn.FlatAppearance.BorderSize = 2
        checkout_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        checkout_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        checkout_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        checkout_btn.FlatStyle = FlatStyle.Flat
        checkout_btn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        checkout_btn.ForeColor = SystemColors.ControlLightLight
        checkout_btn.Location = New Point(418, 616)
        checkout_btn.Name = "checkout_btn"
        checkout_btn.Size = New Size(143, 58)
        checkout_btn.TabIndex = 46
        checkout_btn.Text = "Check Out"
        checkout_btn.UseVisualStyleBackColor = False
        ' 
        ' TabControlreservation
        ' 
        TabControlreservation.Alignment = TabAlignment.Bottom
        TabControlreservation.Anchor = AnchorStyles.None
        TabControlreservation.Controls.Add(tabpageaddreservations)
        TabControlreservation.Controls.Add(TabPageviewreservations)
        TabControlreservation.Controls.Add(TabPage1)
        TabControlreservation.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControlreservation.Location = New Point(12, 54)
        TabControlreservation.Name = "TabControlreservation"
        TabControlreservation.SelectedIndex = 0
        TabControlreservation.Size = New Size(1053, 696)
        TabControlreservation.TabIndex = 47
        ' 
        ' tabpageaddreservations
        ' 
        tabpageaddreservations.Controls.Add(Lbl_msgnoofguests)
        tabpageaddreservations.Controls.Add(lbl_msgstatus)
        tabpageaddreservations.Controls.Add(status_cmbbx)
        tabpageaddreservations.Controls.Add(Label1)
        tabpageaddreservations.Controls.Add(lbl_roomidshow)
        tabpageaddreservations.Controls.Add(Lbl_roomid)
        tabpageaddreservations.Controls.Add(roomtype_txtbx)
        tabpageaddreservations.Controls.Add(bedcount_txtbx)
        tabpageaddreservations.Controls.Add(roomno_txtbx)
        tabpageaddreservations.Controls.Add(browseroom_btn)
        tabpageaddreservations.Controls.Add(Lbl_guestidshow)
        tabpageaddreservations.Controls.Add(Lbl_guestid)
        tabpageaddreservations.Controls.Add(Lbl_guestname)
        tabpageaddreservations.Controls.Add(guestname_txtbx)
        tabpageaddreservations.Controls.Add(browse_btn)
        tabpageaddreservations.Controls.Add(Lbl_bedcount)
        tabpageaddreservations.Controls.Add(Lbl_msgroomno)
        tabpageaddreservations.Controls.Add(Lbl_msgdaysreserved)
        tabpageaddreservations.Controls.Add(Lbl_msgguestname)
        tabpageaddreservations.Controls.Add(clearbtn)
        tabpageaddreservations.Controls.Add(reservationbtn)
        tabpageaddreservations.Controls.Add(Reserveddays_txtbx)
        tabpageaddreservations.Controls.Add(arrivaldate_DTP)
        tabpageaddreservations.Controls.Add(guestnumber_NUD)
        tabpageaddreservations.Controls.Add(checkoutdate_DTP)
        tabpageaddreservations.Controls.Add(Lblarrivaldate)
        tabpageaddreservations.Controls.Add(Lblnguests)
        tabpageaddreservations.Controls.Add(Lbldaysreserved)
        tabpageaddreservations.Controls.Add(Lblroomno)
        tabpageaddreservations.Controls.Add(Lblcheckoutdate)
        tabpageaddreservations.Controls.Add(Lblroomtype)
        tabpageaddreservations.Controls.Add(Lblguestid)
        tabpageaddreservations.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tabpageaddreservations.Location = New Point(4, 4)
        tabpageaddreservations.Name = "tabpageaddreservations"
        tabpageaddreservations.Padding = New Padding(3)
        tabpageaddreservations.Size = New Size(1045, 655)
        tabpageaddreservations.TabIndex = 0
        tabpageaddreservations.Text = "Add Reservations"
        tabpageaddreservations.UseVisualStyleBackColor = True
        ' 
        ' lbl_msgstatus
        ' 
        lbl_msgstatus.AutoSize = True
        lbl_msgstatus.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_msgstatus.ForeColor = Color.Red
        lbl_msgstatus.Location = New Point(652, 530)
        lbl_msgstatus.Name = "lbl_msgstatus"
        lbl_msgstatus.Size = New Size(0, 20)
        lbl_msgstatus.TabIndex = 143
        ' 
        ' status_cmbbx
        ' 
        status_cmbbx.BackColor = SystemColors.ControlLight
        status_cmbbx.FlatStyle = FlatStyle.Flat
        status_cmbbx.Font = New Font("Segoe UI", 13.8F)
        status_cmbbx.ForeColor = Color.Black
        status_cmbbx.FormattingEnabled = True
        status_cmbbx.Items.AddRange(New Object() {"Checked-In", "Reserved"})
        status_cmbbx.Location = New Point(778, 481)
        status_cmbbx.Name = "status_cmbbx"
        status_cmbbx.Size = New Size(200, 39)
        status_cmbbx.TabIndex = 142
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(652, 492)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 28)
        Label1.TabIndex = 141
        Label1.Text = "Status:"
        ' 
        ' lbl_roomidshow
        ' 
        lbl_roomidshow.AutoSize = True
        lbl_roomidshow.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lbl_roomidshow.ForeColor = SystemColors.WindowText
        lbl_roomidshow.Location = New Point(184, 176)
        lbl_roomidshow.Name = "lbl_roomidshow"
        lbl_roomidshow.Size = New Size(0, 28)
        lbl_roomidshow.TabIndex = 140
        ' 
        ' Lbl_roomid
        ' 
        Lbl_roomid.AutoSize = True
        Lbl_roomid.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_roomid.ForeColor = Color.Red
        Lbl_roomid.Location = New Point(73, 176)
        Lbl_roomid.Name = "Lbl_roomid"
        Lbl_roomid.Size = New Size(96, 28)
        Lbl_roomid.TabIndex = 139
        Lbl_roomid.Text = "Room ID:"
        ' 
        ' roomtype_txtbx
        ' 
        roomtype_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        roomtype_txtbx.ForeColor = Color.Black
        roomtype_txtbx.Location = New Point(778, 221)
        roomtype_txtbx.Multiline = True
        roomtype_txtbx.Name = "roomtype_txtbx"
        roomtype_txtbx.ReadOnly = True
        roomtype_txtbx.Size = New Size(223, 41)
        roomtype_txtbx.TabIndex = 138
        ' 
        ' bedcount_txtbx
        ' 
        bedcount_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bedcount_txtbx.ForeColor = Color.Black
        bedcount_txtbx.Location = New Point(213, 315)
        bedcount_txtbx.Multiline = True
        bedcount_txtbx.Name = "bedcount_txtbx"
        bedcount_txtbx.ReadOnly = True
        bedcount_txtbx.Size = New Size(227, 41)
        bedcount_txtbx.TabIndex = 137
        ' 
        ' roomno_txtbx
        ' 
        roomno_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        roomno_txtbx.ForeColor = Color.Black
        roomno_txtbx.Location = New Point(213, 221)
        roomno_txtbx.Multiline = True
        roomno_txtbx.Name = "roomno_txtbx"
        roomno_txtbx.ReadOnly = True
        roomno_txtbx.Size = New Size(227, 41)
        roomno_txtbx.TabIndex = 136
        ' 
        ' browseroom_btn
        ' 
        browseroom_btn.Location = New Point(451, 221)
        browseroom_btn.Name = "browseroom_btn"
        browseroom_btn.Size = New Size(94, 44)
        browseroom_btn.TabIndex = 135
        browseroom_btn.Text = "Browse"
        browseroom_btn.UseVisualStyleBackColor = True
        ' 
        ' Lbl_guestidshow
        ' 
        Lbl_guestidshow.AutoSize = True
        Lbl_guestidshow.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_guestidshow.ForeColor = SystemColors.WindowText
        Lbl_guestidshow.Location = New Point(184, 37)
        Lbl_guestidshow.Name = "Lbl_guestidshow"
        Lbl_guestidshow.Size = New Size(0, 28)
        Lbl_guestidshow.TabIndex = 134
        ' 
        ' Lbl_guestid
        ' 
        Lbl_guestid.AutoSize = True
        Lbl_guestid.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_guestid.ForeColor = Color.Red
        Lbl_guestid.Location = New Point(73, 37)
        Lbl_guestid.Name = "Lbl_guestid"
        Lbl_guestid.Size = New Size(96, 28)
        Lbl_guestid.TabIndex = 133
        Lbl_guestid.Text = "Guest ID:"
        ' 
        ' Lbl_guestname
        ' 
        Lbl_guestname.AutoSize = True
        Lbl_guestname.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_guestname.ForeColor = Color.Black
        Lbl_guestname.Location = New Point(75, 98)
        Lbl_guestname.Name = "Lbl_guestname"
        Lbl_guestname.Size = New Size(136, 28)
        Lbl_guestname.TabIndex = 132
        Lbl_guestname.Text = "Guest Name: "
        ' 
        ' guestname_txtbx
        ' 
        guestname_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        guestname_txtbx.ForeColor = Color.Black
        guestname_txtbx.Location = New Point(213, 88)
        guestname_txtbx.Name = "guestname_txtbx"
        guestname_txtbx.ReadOnly = True
        guestname_txtbx.Size = New Size(226, 38)
        guestname_txtbx.TabIndex = 131
        ' 
        ' browse_btn
        ' 
        browse_btn.Location = New Point(445, 82)
        browse_btn.Name = "browse_btn"
        browse_btn.Size = New Size(94, 44)
        browse_btn.TabIndex = 130
        browse_btn.Text = "Browse"
        browse_btn.UseVisualStyleBackColor = True
        ' 
        ' Lbl_bedcount
        ' 
        Lbl_bedcount.AutoSize = True
        Lbl_bedcount.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_bedcount.ForeColor = Color.Black
        Lbl_bedcount.Location = New Point(75, 320)
        Lbl_bedcount.Name = "Lbl_bedcount"
        Lbl_bedcount.Size = New Size(113, 28)
        Lbl_bedcount.TabIndex = 124
        Lbl_bedcount.Text = "Bed Count:"
        ' 
        ' Lbl_msgroomno
        ' 
        Lbl_msgroomno.AutoSize = True
        Lbl_msgroomno.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_msgroomno.ForeColor = Color.Red
        Lbl_msgroomno.Location = New Point(213, 265)
        Lbl_msgroomno.Name = "Lbl_msgroomno"
        Lbl_msgroomno.Size = New Size(0, 23)
        Lbl_msgroomno.TabIndex = 123
        ' 
        ' Lbl_msgdaysreserved
        ' 
        Lbl_msgdaysreserved.AutoSize = True
        Lbl_msgdaysreserved.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_msgdaysreserved.ForeColor = Color.Red
        Lbl_msgdaysreserved.Location = New Point(648, 456)
        Lbl_msgdaysreserved.Name = "Lbl_msgdaysreserved"
        Lbl_msgdaysreserved.Size = New Size(0, 20)
        Lbl_msgdaysreserved.TabIndex = 119
        ' 
        ' Lbl_msgguestname
        ' 
        Lbl_msgguestname.AutoSize = True
        Lbl_msgguestname.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_msgguestname.ForeColor = Color.Red
        Lbl_msgguestname.Location = New Point(213, 131)
        Lbl_msgguestname.Name = "Lbl_msgguestname"
        Lbl_msgguestname.Size = New Size(0, 20)
        Lbl_msgguestname.TabIndex = 117
        ' 
        ' clearbtn
        ' 
        clearbtn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        clearbtn.FlatAppearance.BorderColor = SystemColors.Window
        clearbtn.FlatAppearance.BorderSize = 2
        clearbtn.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        clearbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        clearbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        clearbtn.FlatStyle = FlatStyle.Flat
        clearbtn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        clearbtn.ForeColor = SystemColors.ControlLightLight
        clearbtn.Location = New Point(581, 575)
        clearbtn.Name = "clearbtn"
        clearbtn.Size = New Size(143, 58)
        clearbtn.TabIndex = 116
        clearbtn.Text = "Clear"
        clearbtn.UseVisualStyleBackColor = False
        ' 
        ' reservationbtn
        ' 
        reservationbtn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        reservationbtn.FlatAppearance.BorderColor = SystemColors.Window
        reservationbtn.FlatAppearance.BorderSize = 2
        reservationbtn.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        reservationbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        reservationbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        reservationbtn.FlatStyle = FlatStyle.Flat
        reservationbtn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        reservationbtn.ForeColor = SystemColors.ControlLightLight
        reservationbtn.Location = New Point(384, 575)
        reservationbtn.Name = "reservationbtn"
        reservationbtn.Size = New Size(161, 58)
        reservationbtn.TabIndex = 115
        reservationbtn.Text = "Add"
        reservationbtn.UseVisualStyleBackColor = False
        ' 
        ' Reserveddays_txtbx
        ' 
        Reserveddays_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Reserveddays_txtbx.ForeColor = Color.Black
        Reserveddays_txtbx.Location = New Point(778, 401)
        Reserveddays_txtbx.Name = "Reserveddays_txtbx"
        Reserveddays_txtbx.Size = New Size(145, 38)
        Reserveddays_txtbx.TabIndex = 113
        ' 
        ' arrivaldate_DTP
        ' 
        arrivaldate_DTP.CalendarForeColor = Color.Black
        arrivaldate_DTP.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        arrivaldate_DTP.Location = New Point(213, 406)
        arrivaldate_DTP.MinDate = New Date(1909, 1, 1, 0, 0, 0, 0)
        arrivaldate_DTP.Name = "arrivaldate_DTP"
        arrivaldate_DTP.Size = New Size(353, 34)
        arrivaldate_DTP.TabIndex = 111
        arrivaldate_DTP.Value = New Date(2024, 6, 6, 0, 0, 0, 0)
        ' 
        ' guestnumber_NUD
        ' 
        guestnumber_NUD.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        guestnumber_NUD.Location = New Point(778, 314)
        guestnumber_NUD.Name = "guestnumber_NUD"
        guestnumber_NUD.Size = New Size(207, 38)
        guestnumber_NUD.TabIndex = 110
        guestnumber_NUD.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' checkoutdate_DTP
        ' 
        checkoutdate_DTP.CalendarForeColor = Color.Black
        checkoutdate_DTP.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        checkoutdate_DTP.Location = New Point(213, 492)
        checkoutdate_DTP.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        checkoutdate_DTP.Name = "checkoutdate_DTP"
        checkoutdate_DTP.Size = New Size(353, 34)
        checkoutdate_DTP.TabIndex = 109
        ' 
        ' Lblarrivaldate
        ' 
        Lblarrivaldate.AutoSize = True
        Lblarrivaldate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblarrivaldate.ForeColor = Color.Black
        Lblarrivaldate.Location = New Point(75, 412)
        Lblarrivaldate.Name = "Lblarrivaldate"
        Lblarrivaldate.Size = New Size(120, 28)
        Lblarrivaldate.TabIndex = 108
        Lblarrivaldate.Text = "Arrival date:"
        ' 
        ' Lblnguests
        ' 
        Lblnguests.AutoSize = True
        Lblnguests.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblnguests.ForeColor = Color.Black
        Lblnguests.Location = New Point(637, 320)
        Lblnguests.Name = "Lblnguests"
        Lblnguests.Size = New Size(135, 28)
        Lblnguests.TabIndex = 107
        Lblnguests.Text = "No of guests:"
        ' 
        ' Lbldaysreserved
        ' 
        Lbldaysreserved.AutoSize = True
        Lbldaysreserved.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbldaysreserved.ForeColor = Color.Black
        Lbldaysreserved.Location = New Point(637, 411)
        Lbldaysreserved.Name = "Lbldaysreserved"
        Lbldaysreserved.Size = New Size(137, 28)
        Lbldaysreserved.TabIndex = 106
        Lbldaysreserved.Text = "Reserve Days:"
        ' 
        ' Lblroomno
        ' 
        Lblroomno.AutoSize = True
        Lblroomno.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblroomno.ForeColor = Color.Black
        Lblroomno.Location = New Point(75, 234)
        Lblroomno.Name = "Lblroomno"
        Lblroomno.Size = New Size(103, 28)
        Lblroomno.TabIndex = 105
        Lblroomno.Text = "Room No:"
        ' 
        ' Lblcheckoutdate
        ' 
        Lblcheckoutdate.AutoSize = True
        Lblcheckoutdate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblcheckoutdate.ForeColor = Color.Black
        Lblcheckoutdate.Location = New Point(58, 498)
        Lblcheckoutdate.Name = "Lblcheckoutdate"
        Lblcheckoutdate.Size = New Size(149, 28)
        Lblcheckoutdate.TabIndex = 104
        Lblcheckoutdate.Text = "Checkout date:"
        ' 
        ' Lblroomtype
        ' 
        Lblroomtype.AutoSize = True
        Lblroomtype.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblroomtype.ForeColor = Color.Black
        Lblroomtype.Location = New Point(628, 234)
        Lblroomtype.Name = "Lblroomtype"
        Lblroomtype.Size = New Size(119, 28)
        Lblroomtype.TabIndex = 103
        Lblroomtype.Text = "Room Type:"
        ' 
        ' Lblguestid
        ' 
        Lblguestid.AutoSize = True
        Lblguestid.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblguestid.ForeColor = Color.Red
        Lblguestid.Location = New Point(46, 26)
        Lblguestid.Name = "Lblguestid"
        Lblguestid.Size = New Size(0, 28)
        Lblguestid.TabIndex = 102
        ' 
        ' TabPageviewreservations
        ' 
        TabPageviewreservations.Controls.Add(Lbl_anykeyword)
        TabPageviewreservations.Controls.Add(searchkeyword_txtbx)
        TabPageviewreservations.Controls.Add(DGV_reservations)
        TabPageviewreservations.Location = New Point(4, 4)
        TabPageviewreservations.Name = "TabPageviewreservations"
        TabPageviewreservations.Padding = New Padding(3)
        TabPageviewreservations.Size = New Size(1045, 655)
        TabPageviewreservations.TabIndex = 1
        TabPageviewreservations.Text = "View Reservations"
        TabPageviewreservations.UseVisualStyleBackColor = True
        ' 
        ' Lbl_anykeyword
        ' 
        Lbl_anykeyword.Anchor = AnchorStyles.None
        Lbl_anykeyword.AutoSize = True
        Lbl_anykeyword.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_anykeyword.ForeColor = SystemColors.ActiveCaptionText
        Lbl_anykeyword.Location = New Point(265, 40)
        Lbl_anykeyword.Name = "Lbl_anykeyword"
        Lbl_anykeyword.Size = New Size(131, 25)
        Lbl_anykeyword.TabIndex = 10
        Lbl_anykeyword.Text = "Any Keyword:"
        ' 
        ' searchkeyword_txtbx
        ' 
        searchkeyword_txtbx.Anchor = AnchorStyles.None
        searchkeyword_txtbx.BackColor = SystemColors.ControlLightLight
        searchkeyword_txtbx.BorderStyle = BorderStyle.FixedSingle
        searchkeyword_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchkeyword_txtbx.ForeColor = Color.Black
        searchkeyword_txtbx.Location = New Point(402, 33)
        searchkeyword_txtbx.Multiline = True
        searchkeyword_txtbx.Name = "searchkeyword_txtbx"
        searchkeyword_txtbx.Size = New Size(324, 47)
        searchkeyword_txtbx.TabIndex = 8
        ' 
        ' DGV_reservations
        ' 
        DGV_reservations.BackgroundColor = SystemColors.Menu
        DGV_reservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_reservations.Location = New Point(25, 122)
        DGV_reservations.Name = "DGV_reservations"
        DGV_reservations.RowHeadersWidth = 51
        DGV_reservations.Size = New Size(996, 505)
        DGV_reservations.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Location = New Point(4, 4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1045, 655)
        TabPage1.TabIndex = 2
        TabPage1.Text = "Manage Reservations"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Lbl_guestcheckin
        ' 
        Lbl_guestcheckin.AutoSize = True
        Lbl_guestcheckin.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_guestcheckin.ForeColor = Color.FromArgb(CByte(32), CByte(114), CByte(170))
        Lbl_guestcheckin.Location = New Point(475, 9)
        Lbl_guestcheckin.Name = "Lbl_guestcheckin"
        Lbl_guestcheckin.Size = New Size(164, 31)
        Lbl_guestcheckin.TabIndex = 48
        Lbl_guestcheckin.Text = "RESERVATION"
        Lbl_guestcheckin.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Lbl_msgnoofguests
        ' 
        Lbl_msgnoofguests.AutoSize = True
        Lbl_msgnoofguests.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_msgnoofguests.ForeColor = Color.Red
        Lbl_msgnoofguests.Location = New Point(648, 357)
        Lbl_msgnoofguests.Name = "Lbl_msgnoofguests"
        Lbl_msgnoofguests.Size = New Size(0, 20)
        Lbl_msgnoofguests.TabIndex = 144
        ' 
        ' Reservation
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1077, 792)
        Controls.Add(Lbl_guestcheckin)
        Controls.Add(TabControlreservation)
        Controls.Add(checkout_btn)
        FormBorderStyle = FormBorderStyle.None
        Name = "Reservation"
        Text = "checkout"
        TabControlreservation.ResumeLayout(False)
        tabpageaddreservations.ResumeLayout(False)
        tabpageaddreservations.PerformLayout()
        CType(guestnumber_NUD, ComponentModel.ISupportInitialize).EndInit()
        TabPageviewreservations.ResumeLayout(False)
        TabPageviewreservations.PerformLayout()
        CType(DGV_reservations, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents checkout_btn As Button
    Friend WithEvents TabControlreservation As TabControl
    Friend WithEvents tabpageaddreservations As TabPage
    Friend WithEvents TabPageviewreservations As TabPage
    Friend WithEvents Lbl_bedcount As Label
    Friend WithEvents Lbl_msgroomno As Label
    Friend WithEvents Lbl_msgdaysreserved As Label
    Friend WithEvents Lbl_msgguestname As Label
    Friend WithEvents clearbtn As Button
    Friend WithEvents reservationbtn As Button
    Friend WithEvents Reserveddays_txtbx As TextBox
    Friend WithEvents arrivaldate_DTP As DateTimePicker
    Friend WithEvents guestnumber_NUD As NumericUpDown
    Friend WithEvents checkoutdate_DTP As DateTimePicker
    Friend WithEvents Lblarrivaldate As Label
    Friend WithEvents Lblnguests As Label
    Friend WithEvents Lbldaysreserved As Label
    Friend WithEvents Lblroomno As Label
    Friend WithEvents Lblcheckoutdate As Label
    Friend WithEvents Lblroomtype As Label
    Friend WithEvents Lblguestid As Label
    Friend WithEvents Lbl_guestcheckin As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DGV_reservations As DataGridView
    Friend WithEvents searchkeyword_txtbx As TextBox
    Friend WithEvents Lbl_anykeyword As Label
    Friend WithEvents browse_btn As Button
    Friend WithEvents Lbl_guestname As Label
    Friend WithEvents guestname_txtbx As TextBox
    Friend WithEvents Lbl_guestid As Label
    Friend WithEvents Lbl_guestidshow As Label
    Friend WithEvents roomno_txtbx As TextBox
    Friend WithEvents browseroom_btn As Button
    Friend WithEvents roomtype_txtbx As TextBox
    Friend WithEvents bedcount_txtbx As TextBox
    Friend WithEvents lbl_roomidshow As Label
    Friend WithEvents Lbl_roomid As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_msgstatus As Label
    Friend WithEvents status_cmbbx As ComboBox
    Friend WithEvents Lbl_msgnoofguests As Label
End Class
