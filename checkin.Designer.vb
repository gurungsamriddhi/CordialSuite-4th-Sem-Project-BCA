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
        checkoutdate_DTP = New DateTimePicker()
        checkouttime_DTP = New DateTimePicker()
        guestnumber_NUD = New NumericUpDown()
        arrivaldate_DTP = New DateTimePicker()
        arrivaltime_DTP = New DateTimePicker()
        GuestID_cmbbx = New ComboBox()
        Reserveddays_txtbx = New TextBox()
        Roomtype_cmbbx = New ComboBox()
        checkinbtn = New Button()
        clearbtn = New Button()
        Lbl_msgguestid = New Label()
        Lbl_msgroomtype = New Label()
        Lbl_msgdaysreserved = New Label()
        roomno_cmbbxbx = New ComboBox()
        Lbl_msgcheckout = New Label()
        Lbl_msgarrivaldate = New Label()
        Lbl_msgroomno = New Label()
        Panel1 = New Panel()
        closebtn = New Button()
        Lblviewg = New Label()
        Button1 = New Button()
        CType(guestnumber_NUD, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Lblguestid
        ' 
        Lblguestid.AutoSize = True
        Lblguestid.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblguestid.ForeColor = Color.Black
        Lblguestid.Location = New Point(43, 115)
        Lblguestid.Name = "Lblguestid"
        Lblguestid.Size = New Size(96, 28)
        Lblguestid.TabIndex = 0
        Lblguestid.Text = "Guest ID:"
        ' 
        ' Lblcheckouttime
        ' 
        Lblcheckouttime.AutoSize = True
        Lblcheckouttime.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblcheckouttime.ForeColor = Color.Black
        Lblcheckouttime.Location = New Point(535, 551)
        Lblcheckouttime.Name = "Lblcheckouttime"
        Lblcheckouttime.Size = New Size(154, 28)
        Lblcheckouttime.TabIndex = 1
        Lblcheckouttime.Text = "Checkout Time:"
        ' 
        ' Lblroomtype
        ' 
        Lblroomtype.AutoSize = True
        Lblroomtype.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblroomtype.ForeColor = Color.Black
        Lblroomtype.Location = New Point(537, 433)
        Lblroomtype.Name = "Lblroomtype"
        Lblroomtype.Size = New Size(119, 28)
        Lblroomtype.TabIndex = 2
        Lblroomtype.Text = "Room Type:"
        ' 
        ' Lblcheckoutdate
        ' 
        Lblcheckoutdate.AutoSize = True
        Lblcheckoutdate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblcheckoutdate.ForeColor = Color.Black
        Lblcheckoutdate.Location = New Point(32, 551)
        Lblcheckoutdate.Name = "Lblcheckoutdate"
        Lblcheckoutdate.Size = New Size(149, 28)
        Lblcheckoutdate.TabIndex = 3
        Lblcheckoutdate.Text = "Checkout date:"
        ' 
        ' Lblroomno
        ' 
        Lblroomno.AutoSize = True
        Lblroomno.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblroomno.ForeColor = Color.Black
        Lblroomno.Location = New Point(36, 428)
        Lblroomno.Name = "Lblroomno"
        Lblroomno.Size = New Size(103, 28)
        Lblroomno.TabIndex = 4
        Lblroomno.Text = "Room No:"
        ' 
        ' Lbldaysreserved
        ' 
        Lbldaysreserved.AutoSize = True
        Lbldaysreserved.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbldaysreserved.ForeColor = Color.Black
        Lbldaysreserved.Location = New Point(448, 320)
        Lbldaysreserved.Name = "Lbldaysreserved"
        Lbldaysreserved.Size = New Size(205, 28)
        Lbldaysreserved.TabIndex = 5
        Lbldaysreserved.Text = "No of days Reserved:"
        ' 
        ' Lblnguests
        ' 
        Lblnguests.AutoSize = True
        Lblnguests.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblnguests.ForeColor = Color.Black
        Lblnguests.Location = New Point(32, 320)
        Lblnguests.Name = "Lblnguests"
        Lblnguests.Size = New Size(135, 28)
        Lblnguests.TabIndex = 6
        Lblnguests.Text = "No of guests:"
        ' 
        ' Lblarrivaltime
        ' 
        Lblarrivaltime.AutoSize = True
        Lblarrivaltime.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblarrivaltime.ForeColor = Color.Black
        Lblarrivaltime.Location = New Point(516, 205)
        Lblarrivaltime.Name = "Lblarrivaltime"
        Lblarrivaltime.Size = New Size(125, 28)
        Lblarrivaltime.TabIndex = 7
        Lblarrivaltime.Text = "Arrival Time:"
        ' 
        ' Lblarrivaldate
        ' 
        Lblarrivaldate.AutoSize = True
        Lblarrivaldate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblarrivaldate.ForeColor = Color.Black
        Lblarrivaldate.Location = New Point(43, 206)
        Lblarrivaldate.Name = "Lblarrivaldate"
        Lblarrivaldate.Size = New Size(120, 28)
        Lblarrivaldate.TabIndex = 8
        Lblarrivaldate.Text = "Arrival date:"
        ' 
        ' checkoutdate_DTP
        ' 
        checkoutdate_DTP.CalendarForeColor = Color.Black
        checkoutdate_DTP.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        checkoutdate_DTP.Location = New Point(181, 548)
        checkoutdate_DTP.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        checkoutdate_DTP.Name = "checkoutdate_DTP"
        checkoutdate_DTP.Size = New Size(291, 31)
        checkoutdate_DTP.TabIndex = 11
        ' 
        ' checkouttime_DTP
        ' 
        checkouttime_DTP.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        checkouttime_DTP.Format = DateTimePickerFormat.Time
        checkouttime_DTP.Location = New Point(710, 548)
        checkouttime_DTP.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        checkouttime_DTP.Name = "checkouttime_DTP"
        checkouttime_DTP.ShowUpDown = True
        checkouttime_DTP.Size = New Size(151, 31)
        checkouttime_DTP.TabIndex = 12
        checkouttime_DTP.Value = New Date(2024, 6, 5, 21, 12, 0, 0)
        ' 
        ' guestnumber_NUD
        ' 
        guestnumber_NUD.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        guestnumber_NUD.Location = New Point(181, 320)
        guestnumber_NUD.Name = "guestnumber_NUD"
        guestnumber_NUD.Size = New Size(150, 31)
        guestnumber_NUD.TabIndex = 13
        guestnumber_NUD.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' arrivaldate_DTP
        ' 
        arrivaldate_DTP.CalendarForeColor = Color.Black
        arrivaldate_DTP.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        arrivaldate_DTP.Location = New Point(181, 207)
        arrivaldate_DTP.MinDate = New Date(1909, 1, 1, 0, 0, 0, 0)
        arrivaldate_DTP.Name = "arrivaldate_DTP"
        arrivaldate_DTP.Size = New Size(264, 31)
        arrivaldate_DTP.TabIndex = 14
        arrivaldate_DTP.Value = New Date(2024, 6, 6, 0, 0, 0, 0)
        ' 
        ' arrivaltime_DTP
        ' 
        arrivaltime_DTP.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        arrivaltime_DTP.Format = DateTimePickerFormat.Time
        arrivaltime_DTP.Location = New Point(659, 205)
        arrivaltime_DTP.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        arrivaltime_DTP.Name = "arrivaltime_DTP"
        arrivaltime_DTP.ShowUpDown = True
        arrivaltime_DTP.Size = New Size(202, 31)
        arrivaltime_DTP.TabIndex = 15
        arrivaltime_DTP.Value = New Date(2024, 6, 1, 16, 36, 0, 0)
        ' 
        ' GuestID_cmbbx
        ' 
        GuestID_cmbbx.BackColor = SystemColors.ScrollBar
        GuestID_cmbbx.FlatStyle = FlatStyle.Flat
        GuestID_cmbbx.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GuestID_cmbbx.ForeColor = Color.Black
        GuestID_cmbbx.FormattingEnabled = True
        GuestID_cmbbx.Location = New Point(166, 110)
        GuestID_cmbbx.Name = "GuestID_cmbbx"
        GuestID_cmbbx.Size = New Size(115, 33)
        GuestID_cmbbx.TabIndex = 16
        ' 
        ' Reserveddays_txtbx
        ' 
        Reserveddays_txtbx.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Reserveddays_txtbx.ForeColor = Color.Black
        Reserveddays_txtbx.Location = New Point(659, 317)
        Reserveddays_txtbx.Name = "Reserveddays_txtbx"
        Reserveddays_txtbx.Size = New Size(202, 31)
        Reserveddays_txtbx.TabIndex = 17
        ' 
        ' Roomtype_cmbbx
        ' 
        Roomtype_cmbbx.BackColor = SystemColors.ScrollBar
        Roomtype_cmbbx.FlatStyle = FlatStyle.Flat
        Roomtype_cmbbx.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Roomtype_cmbbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Roomtype_cmbbx.FormattingEnabled = True
        Roomtype_cmbbx.Location = New Point(680, 433)
        Roomtype_cmbbx.Name = "Roomtype_cmbbx"
        Roomtype_cmbbx.Size = New Size(181, 33)
        Roomtype_cmbbx.TabIndex = 20
        ' 
        ' checkinbtn
        ' 
        checkinbtn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        checkinbtn.FlatAppearance.BorderColor = SystemColors.Window
        checkinbtn.FlatAppearance.BorderSize = 2
        checkinbtn.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        checkinbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        checkinbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        checkinbtn.FlatStyle = FlatStyle.Flat
        checkinbtn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        checkinbtn.ForeColor = SystemColors.ControlLightLight
        checkinbtn.Location = New Point(304, 639)
        checkinbtn.Name = "checkinbtn"
        checkinbtn.Size = New Size(155, 42)
        checkinbtn.TabIndex = 22
        checkinbtn.Text = "Check In"
        checkinbtn.UseVisualStyleBackColor = False
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
        clearbtn.Location = New Point(516, 639)
        clearbtn.Name = "clearbtn"
        clearbtn.Size = New Size(137, 42)
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
        Lbl_msgroomtype.Location = New Point(680, 459)
        Lbl_msgroomtype.Name = "Lbl_msgroomtype"
        Lbl_msgroomtype.Size = New Size(0, 20)
        Lbl_msgroomtype.TabIndex = 27
        ' 
        ' Lbl_msgdaysreserved
        ' 
        Lbl_msgdaysreserved.AutoSize = True
        Lbl_msgdaysreserved.ForeColor = Color.Red
        Lbl_msgdaysreserved.Location = New Point(602, 391)
        Lbl_msgdaysreserved.Name = "Lbl_msgdaysreserved"
        Lbl_msgdaysreserved.Size = New Size(0, 20)
        Lbl_msgdaysreserved.TabIndex = 28
        ' 
        ' roomno_cmbbxbx
        ' 
        roomno_cmbbxbx.BackColor = SystemColors.ScrollBar
        roomno_cmbbxbx.FlatStyle = FlatStyle.Flat
        roomno_cmbbxbx.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        roomno_cmbbxbx.ForeColor = Color.Black
        roomno_cmbbxbx.FormattingEnabled = True
        roomno_cmbbxbx.Location = New Point(157, 428)
        roomno_cmbbxbx.Name = "roomno_cmbbxbx"
        roomno_cmbbxbx.Size = New Size(169, 33)
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
        Lbl_msgarrivaldate.Location = New Point(166, 262)
        Lbl_msgarrivaldate.Name = "Lbl_msgarrivaldate"
        Lbl_msgarrivaldate.Size = New Size(0, 20)
        Lbl_msgarrivaldate.TabIndex = 31
        ' 
        ' Lbl_msgroomno
        ' 
        Lbl_msgroomno.AutoSize = True
        Lbl_msgroomno.ForeColor = Color.Red
        Lbl_msgroomno.Location = New Point(156, 458)
        Lbl_msgroomno.Name = "Lbl_msgroomno"
        Lbl_msgroomno.Size = New Size(0, 20)
        Lbl_msgroomno.TabIndex = 32
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(closebtn)
        Panel1.Controls.Add(Lblviewg)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(948, 54)
        Panel1.TabIndex = 44
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = SystemColors.ControlLightLight
        closebtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        closebtn.Location = New Point(431, 313)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(47, 35)
        closebtn.TabIndex = 23
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Lblviewg
        ' 
        Lblviewg.AutoSize = True
        Lblviewg.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblviewg.ForeColor = SystemColors.Window
        Lblviewg.Location = New Point(375, 9)
        Lblviewg.Name = "Lblviewg"
        Lblviewg.Size = New Size(198, 62)
        Lblviewg.TabIndex = 23
        Lblviewg.Text = "GUEST CHECK-IN" & vbCrLf & vbCrLf
        Lblviewg.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderColor = Color.White
        Button1.FlatAppearance.BorderSize = 2
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Lucida Fax", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.Window
        Button1.Location = New Point(902, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(43, 42)
        Button1.TabIndex = 45
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' checkin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(948, 709)
        Controls.Add(Panel1)
        Controls.Add(Lbl_msgroomno)
        Controls.Add(Lbl_msgarrivaldate)
        Controls.Add(Lbl_msgcheckout)
        Controls.Add(roomno_cmbbxbx)
        Controls.Add(Lbl_msgdaysreserved)
        Controls.Add(Lbl_msgroomtype)
        Controls.Add(Lbl_msgguestid)
        Controls.Add(clearbtn)
        Controls.Add(checkinbtn)
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
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
    Friend WithEvents checkoutdate_DTP As DateTimePicker
    Friend WithEvents checkouttime_DTP As DateTimePicker
    Friend WithEvents guestnumber_NUD As NumericUpDown
    Friend WithEvents arrivaldate_DTP As DateTimePicker
    Friend WithEvents arrivaltime_DTP As DateTimePicker
    Friend WithEvents GuestID_cmbbx As ComboBox
    Friend WithEvents Reserveddays_txtbx As TextBox
    Friend WithEvents Roomtype_cmbbx As ComboBox
    Friend WithEvents checkinbtn As Button
    Friend WithEvents clearbtn As Button
    Friend WithEvents Lbl_msgguestid As Label
    Friend WithEvents L As Label
    Friend WithEvents Lbl_msgroomtype As Label
    Friend WithEvents Lbl_msgdaysreserved As Label
    Friend WithEvents roomno_cmbbxbx As ComboBox
    Friend WithEvents Lbl_msgcheckout As Label
    Friend WithEvents Lbl_msgarrivaldate As Label
    Friend WithEvents Lbl_msgroomno As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents closebtn As Button
    Friend WithEvents Lblviewg As Label
    Friend WithEvents Button1 As Button
End Class
