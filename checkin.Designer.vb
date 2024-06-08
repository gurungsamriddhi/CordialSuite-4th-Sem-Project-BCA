<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkin
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
        Lblguestid = New Label()
        Lblcheckouttime = New Label()
        Lblroomtype = New Label()
        Lblcheckoutdate = New Label()
        Lblroomno = New Label()
        Lbldaysreserved = New Label()
        Lblnguests = New Label()
        Lblarrivaltime = New Label()
        Lblarrivaldate = New Label()
        Lblgcheckin = New Label()
        checkoutdate_DTP = New DateTimePicker()
        checkouttime_DTP = New DateTimePicker()
        guestnumber_NUD = New NumericUpDown()
        arrivaldate_DTP = New DateTimePicker()
        arrivaltime_DTP = New DateTimePicker()
        GuestID_cmbbx = New ComboBox()
        Reserveddays_txtbx = New TextBox()
        Roomtype_cmbbx = New ComboBox()
        Panelgci = New Panel()
        closebtn = New Button()
        checkinbtn = New Button()
        clearbtn = New Button()
        Lbl_msgguestid = New Label()
        Lbl_msgroomtype = New Label()
        Lbl_msgdaysreserved = New Label()
        roomno_cmbbxbx = New ComboBox()
        Lbl_msgcheckout = New Label()
        Lbl_msgarrivaldate = New Label()
        Lbl_msgroomno = New Label()
        CType(guestnumber_NUD, ComponentModel.ISupportInitialize).BeginInit()
        Panelgci.SuspendLayout()
        SuspendLayout()
        ' 
        ' Lblguestid
        ' 
        Lblguestid.AutoSize = True
        Lblguestid.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lblguestid.ForeColor = Color.Blue
        Lblguestid.Location = New Point(50, 120)
        Lblguestid.Name = "Lblguestid"
        Lblguestid.Size = New Size(80, 23)
        Lblguestid.TabIndex = 0
        Lblguestid.Text = "Guest ID:"
        ' 
        ' Lblcheckouttime
        ' 
        Lblcheckouttime.AutoSize = True
        Lblcheckouttime.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lblcheckouttime.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblcheckouttime.Location = New Point(468, 404)
        Lblcheckouttime.Name = "Lblcheckouttime"
        Lblcheckouttime.Size = New Size(128, 23)
        Lblcheckouttime.TabIndex = 1
        Lblcheckouttime.Text = "Checkout Time:"
        ' 
        ' Lblroomtype
        ' 
        Lblroomtype.AutoSize = True
        Lblroomtype.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lblroomtype.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblroomtype.Location = New Point(459, 333)
        Lblroomtype.Name = "Lblroomtype"
        Lblroomtype.Size = New Size(99, 23)
        Lblroomtype.TabIndex = 2
        Lblroomtype.Text = "Room Type:"
        ' 
        ' Lblcheckoutdate
        ' 
        Lblcheckoutdate.AutoSize = True
        Lblcheckoutdate.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lblcheckoutdate.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblcheckoutdate.Location = New Point(50, 405)
        Lblcheckoutdate.Name = "Lblcheckoutdate"
        Lblcheckoutdate.Size = New Size(125, 23)
        Lblcheckoutdate.TabIndex = 3
        Lblcheckoutdate.Text = "Checkout date:"
        ' 
        ' Lblroomno
        ' 
        Lblroomno.AutoSize = True
        Lblroomno.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lblroomno.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblroomno.Location = New Point(50, 333)
        Lblroomno.Name = "Lblroomno"
        Lblroomno.Size = New Size(87, 23)
        Lblroomno.TabIndex = 4
        Lblroomno.Text = "Room No:"
        ' 
        ' Lbldaysreserved
        ' 
        Lbldaysreserved.AutoSize = True
        Lbldaysreserved.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbldaysreserved.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lbldaysreserved.Location = New Point(418, 262)
        Lbldaysreserved.Name = "Lbldaysreserved"
        Lbldaysreserved.Size = New Size(169, 23)
        Lbldaysreserved.TabIndex = 5
        Lbldaysreserved.Text = "No of days Reserved:"
        ' 
        ' Lblnguests
        ' 
        Lblnguests.AutoSize = True
        Lblnguests.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lblnguests.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblnguests.Location = New Point(46, 261)
        Lblnguests.Name = "Lblnguests"
        Lblnguests.Size = New Size(111, 23)
        Lblnguests.TabIndex = 6
        Lblnguests.Text = "No of guests:"
        ' 
        ' Lblarrivaltime
        ' 
        Lblarrivaltime.AutoSize = True
        Lblarrivaltime.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lblarrivaltime.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblarrivaltime.Location = New Point(478, 189)
        Lblarrivaltime.Name = "Lblarrivaltime"
        Lblarrivaltime.Size = New Size(104, 23)
        Lblarrivaltime.TabIndex = 7
        Lblarrivaltime.Text = "Arrival Time:"
        ' 
        ' Lblarrivaldate
        ' 
        Lblarrivaldate.AutoSize = True
        Lblarrivaldate.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lblarrivaldate.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblarrivaldate.Location = New Point(50, 193)
        Lblarrivaldate.Name = "Lblarrivaldate"
        Lblarrivaldate.Size = New Size(101, 23)
        Lblarrivaldate.TabIndex = 8
        Lblarrivaldate.Text = "Arrival date:"
        ' 
        ' Lblgcheckin
        ' 
        Lblgcheckin.AutoSize = True
        Lblgcheckin.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblgcheckin.ForeColor = SystemColors.ControlLightLight
        Lblgcheckin.Location = New Point(330, 9)
        Lblgcheckin.Name = "Lblgcheckin"
        Lblgcheckin.Size = New Size(168, 28)
        Lblgcheckin.TabIndex = 10
        Lblgcheckin.Text = "GUEST CHECK-IN"
        ' 
        ' checkoutdate_DTP
        ' 
        checkoutdate_DTP.CalendarForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        checkoutdate_DTP.Location = New Point(181, 401)
        checkoutdate_DTP.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        checkoutdate_DTP.Name = "checkoutdate_DTP"
        checkoutdate_DTP.Size = New Size(264, 27)
        checkoutdate_DTP.TabIndex = 11
        ' 
        ' checkouttime_DTP
        ' 
        checkouttime_DTP.Format = DateTimePickerFormat.Time
        checkouttime_DTP.Location = New Point(602, 400)
        checkouttime_DTP.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        checkouttime_DTP.Name = "checkouttime_DTP"
        checkouttime_DTP.ShowUpDown = True
        checkouttime_DTP.Size = New Size(151, 27)
        checkouttime_DTP.TabIndex = 12
        checkouttime_DTP.Value = New Date(2024, 6, 5, 21, 12, 0, 0)
        ' 
        ' guestnumber_NUD
        ' 
        guestnumber_NUD.Location = New Point(163, 258)
        guestnumber_NUD.Name = "guestnumber_NUD"
        guestnumber_NUD.Size = New Size(150, 27)
        guestnumber_NUD.TabIndex = 13
        guestnumber_NUD.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' arrivaldate_DTP
        ' 
        arrivaldate_DTP.CalendarForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        arrivaldate_DTP.Location = New Point(157, 189)
        arrivaldate_DTP.MinDate = New Date(1909, 1, 1, 0, 0, 0, 0)
        arrivaldate_DTP.Name = "arrivaldate_DTP"
        arrivaldate_DTP.Size = New Size(264, 27)
        arrivaldate_DTP.TabIndex = 14
        arrivaldate_DTP.Value = New Date(2024, 6, 6, 0, 0, 0, 0)
        ' 
        ' arrivaltime_DTP
        ' 
        arrivaltime_DTP.Format = DateTimePickerFormat.Time
        arrivaltime_DTP.Location = New Point(602, 185)
        arrivaltime_DTP.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        arrivaltime_DTP.Name = "arrivaltime_DTP"
        arrivaltime_DTP.ShowUpDown = True
        arrivaltime_DTP.Size = New Size(151, 27)
        arrivaltime_DTP.TabIndex = 15
        arrivaltime_DTP.Value = New Date(2024, 6, 1, 16, 36, 0, 0)
        ' 
        ' GuestID_cmbbx
        ' 
        GuestID_cmbbx.BackColor = SystemColors.ScrollBar
        GuestID_cmbbx.FlatStyle = FlatStyle.Flat
        GuestID_cmbbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        GuestID_cmbbx.FormattingEnabled = True
        GuestID_cmbbx.Location = New Point(148, 115)
        GuestID_cmbbx.Name = "GuestID_cmbbx"
        GuestID_cmbbx.Size = New Size(100, 28)
        GuestID_cmbbx.TabIndex = 16
        ' 
        ' Reserveddays_txtbx
        ' 
        Reserveddays_txtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Reserveddays_txtbx.Location = New Point(602, 255)
        Reserveddays_txtbx.Name = "Reserveddays_txtbx"
        Reserveddays_txtbx.Size = New Size(151, 30)
        Reserveddays_txtbx.TabIndex = 17
        ' 
        ' Roomtype_cmbbx
        ' 
        Roomtype_cmbbx.BackColor = SystemColors.ScrollBar
        Roomtype_cmbbx.FlatStyle = FlatStyle.Flat
        Roomtype_cmbbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Roomtype_cmbbx.FormattingEnabled = True
        Roomtype_cmbbx.Location = New Point(602, 328)
        Roomtype_cmbbx.Name = "Roomtype_cmbbx"
        Roomtype_cmbbx.Size = New Size(169, 28)
        Roomtype_cmbbx.TabIndex = 20
        ' 
        ' Panelgci
        ' 
        Panelgci.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Panelgci.Controls.Add(closebtn)
        Panelgci.Controls.Add(Lblgcheckin)
        Panelgci.Dock = DockStyle.Top
        Panelgci.Location = New Point(0, 0)
        Panelgci.Name = "Panelgci"
        Panelgci.Size = New Size(829, 47)
        Panelgci.TabIndex = 21
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = SystemColors.ControlLightLight
        closebtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 12.0F, FontStyle.Bold)
        closebtn.Location = New Point(770, 8)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(47, 34)
        closebtn.TabIndex = 26
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' checkinbtn
        ' 
        checkinbtn.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        checkinbtn.FlatAppearance.BorderColor = Color.White
        checkinbtn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        checkinbtn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        checkinbtn.FlatStyle = FlatStyle.Flat
        checkinbtn.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        checkinbtn.ForeColor = SystemColors.ControlLightLight
        checkinbtn.Location = New Point(276, 502)
        checkinbtn.Name = "checkinbtn"
        checkinbtn.Size = New Size(155, 42)
        checkinbtn.TabIndex = 22
        checkinbtn.Text = "Check In"
        checkinbtn.UseVisualStyleBackColor = False
        ' 
        ' clearbtn
        ' 
        clearbtn.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        clearbtn.FlatAppearance.BorderColor = Color.White
        clearbtn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        clearbtn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        clearbtn.FlatStyle = FlatStyle.Flat
        clearbtn.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        clearbtn.ForeColor = SystemColors.ControlLightLight
        clearbtn.Location = New Point(478, 502)
        clearbtn.Name = "clearbtn"
        clearbtn.Size = New Size(135, 42)
        clearbtn.TabIndex = 24
        clearbtn.Text = "Clear"
        clearbtn.UseVisualStyleBackColor = False
        ' 
        ' Lbl_msgguestid
        ' 
        Lbl_msgguestid.AutoSize = True
        Lbl_msgguestid.ForeColor = Color.Red
        Lbl_msgguestid.Location = New Point(148, 146)
        Lbl_msgguestid.Name = "Lbl_msgguestid"
        Lbl_msgguestid.Size = New Size(0, 20)
        Lbl_msgguestid.TabIndex = 25
        ' 
        ' Lbl_msgroomtype
        ' 
        Lbl_msgroomtype.AutoSize = True
        Lbl_msgroomtype.ForeColor = Color.Red
        Lbl_msgroomtype.Location = New Point(602, 359)
        Lbl_msgroomtype.Name = "Lbl_msgroomtype"
        Lbl_msgroomtype.Size = New Size(0, 20)
        Lbl_msgroomtype.TabIndex = 27
        ' 
        ' Lbl_msgdaysreserved
        ' 
        Lbl_msgdaysreserved.AutoSize = True
        Lbl_msgdaysreserved.ForeColor = Color.Red
        Lbl_msgdaysreserved.Location = New Point(602, 291)
        Lbl_msgdaysreserved.Name = "Lbl_msgdaysreserved"
        Lbl_msgdaysreserved.Size = New Size(0, 20)
        Lbl_msgdaysreserved.TabIndex = 28
        ' 
        ' roomno_cmbbxbx
        ' 
        roomno_cmbbxbx.BackColor = SystemColors.ScrollBar
        roomno_cmbbxbx.FlatStyle = FlatStyle.Flat
        roomno_cmbbxbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        roomno_cmbbxbx.FormattingEnabled = True
        roomno_cmbbxbx.Location = New Point(157, 328)
        roomno_cmbbxbx.Name = "roomno_cmbbxbx"
        roomno_cmbbxbx.Size = New Size(169, 28)
        roomno_cmbbxbx.TabIndex = 29
        ' 
        ' Lbl_msgcheckout
        ' 
        Lbl_msgcheckout.AutoSize = True
        Lbl_msgcheckout.ForeColor = Color.Red
        Lbl_msgcheckout.Location = New Point(181, 431)
        Lbl_msgcheckout.Name = "Lbl_msgcheckout"
        Lbl_msgcheckout.Size = New Size(0, 20)
        Lbl_msgcheckout.TabIndex = 30
        ' 
        ' Lbl_msgarrivaldate
        ' 
        Lbl_msgarrivaldate.AutoSize = True
        Lbl_msgarrivaldate.ForeColor = Color.Red
        Lbl_msgarrivaldate.Location = New Point(158, 219)
        Lbl_msgarrivaldate.Name = "Lbl_msgarrivaldate"
        Lbl_msgarrivaldate.Size = New Size(0, 20)
        Lbl_msgarrivaldate.TabIndex = 31
        ' 
        ' Lbl_msgroomno
        ' 
        Lbl_msgroomno.AutoSize = True
        Lbl_msgroomno.ForeColor = Color.Red
        Lbl_msgroomno.Location = New Point(156, 358)
        Lbl_msgroomno.Name = "Lbl_msgroomno"
        Lbl_msgroomno.Size = New Size(0, 20)
        Lbl_msgroomno.TabIndex = 32
        ' 
        ' checkin
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(829, 585)
        Controls.Add(Lbl_msgroomno)
        Controls.Add(Lbl_msgarrivaldate)
        Controls.Add(Lbl_msgcheckout)
        Controls.Add(roomno_cmbbxbx)
        Controls.Add(Lbl_msgdaysreserved)
        Controls.Add(Lbl_msgroomtype)
        Controls.Add(Lbl_msgguestid)
        Controls.Add(clearbtn)
        Controls.Add(checkinbtn)
        Controls.Add(Panelgci)
        Controls.Add(Roomtype_cmbbx)
        Controls.Add(Reserveddays_txtbx)
        Controls.Add(GuestID_cmbbx)
        Controls.Add(arrivaltime_DTP)
        Controls.Add(arrivaldate_DTP)
        Controls.Add(guestnumber_NUD)
        Controls.Add(checkouttime_DTP)
        Controls.Add(checkoutdate_DTP)
        Controls.Add(Lblarrivaldate)
        Controls.Add(Lblarrivaltime)
        Controls.Add(Lblnguests)
        Controls.Add(Lbldaysreserved)
        Controls.Add(Lblroomno)
        Controls.Add(Lblcheckoutdate)
        Controls.Add(Lblroomtype)
        Controls.Add(Lblcheckouttime)
        Controls.Add(Lblguestid)
        FormBorderStyle = FormBorderStyle.None
        Name = "checkin"
        Text = "checkin"
        CType(guestnumber_NUD, ComponentModel.ISupportInitialize).EndInit()
        Panelgci.ResumeLayout(False)
        Panelgci.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lblguestid As Label
    Friend WithEvents Lblcheckouttime As Label
    Friend WithEvents Lblroomtype As Label
    Friend WithEvents Lblcheckoutdate As Label
    Friend WithEvents Lblroomno As Label
    Friend WithEvents Lbldaysreserved As Label
    Friend WithEvents Lblnguests As Label
    Friend WithEvents Lblarrivaltime As Label
    Friend WithEvents Lblarrivaldate As Label
    Friend WithEvents Lblgcheckin As Label
    Friend WithEvents checkoutdate_DTP As DateTimePicker
    Friend WithEvents checkouttime_DTP As DateTimePicker
    Friend WithEvents guestnumber_NUD As NumericUpDown
    Friend WithEvents arrivaldate_DTP As DateTimePicker
    Friend WithEvents arrivaltime_DTP As DateTimePicker
    Friend WithEvents GuestID_cmbbx As ComboBox
    Friend WithEvents Reserveddays_txtbx As TextBox
    Friend WithEvents Roomtype_cmbbx As ComboBox
    Friend WithEvents Panelgci As Panel
    Friend WithEvents checkinbtn As Button
    Friend WithEvents clearbtn As Button
    Friend WithEvents closebtn As Button
    Friend WithEvents Lbl_msgguestid As Label
    Friend WithEvents L As Label
    Friend WithEvents Lbl_msgroomtype As Label
    Friend WithEvents Lbl_msgdaysreserved As Label
    Friend WithEvents roomno_cmbbxbx As ComboBox
    Friend WithEvents Lbl_msgcheckout As Label
    Friend WithEvents Lbl_msgarrivaldate As Label
    Friend WithEvents Lbl_msgroomno As Label
End Class
