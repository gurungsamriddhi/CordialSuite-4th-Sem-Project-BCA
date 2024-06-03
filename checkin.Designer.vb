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
        DTPcheckoutdate = New DateTimePicker()
        DTPcheckouttime = New DateTimePicker()
        NUDnguest = New NumericUpDown()
        DTParrivaldate = New DateTimePicker()
        DTParrivaltime = New DateTimePicker()
        GuestIDcombobx = New ComboBox()
        Reserveddaystxtbx = New TextBox()
        Nroomtxtbx = New TextBox()
        Roomtypecombobx = New ComboBox()
        Panelgci = New Panel()
        checkinbtn = New Button()
        clearbtn = New Button()
        closebtn = New Button()
        CType(NUDnguest, ComponentModel.ISupportInitialize).BeginInit()
        Panelgci.SuspendLayout()
        SuspendLayout()
        ' 
        ' Lblguestid
        ' 
        Lblguestid.AutoSize = True
        Lblguestid.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lblguestid.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
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
        Lblgcheckin.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblgcheckin.ForeColor = SystemColors.ControlLightLight
        Lblgcheckin.Location = New Point(330, 9)
        Lblgcheckin.Name = "Lblgcheckin"
        Lblgcheckin.Size = New Size(168, 28)
        Lblgcheckin.TabIndex = 10
        Lblgcheckin.Text = "GUEST CHECK-IN"
        ' 
        ' DTPcheckoutdate
        ' 
        DTPcheckoutdate.CalendarForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        DTPcheckoutdate.Location = New Point(181, 401)
        DTPcheckoutdate.Name = "DTPcheckoutdate"
        DTPcheckoutdate.Size = New Size(264, 27)
        DTPcheckoutdate.TabIndex = 11
        ' 
        ' DTPcheckouttime
        ' 
        DTPcheckouttime.Format = DateTimePickerFormat.Time
        DTPcheckouttime.Location = New Point(602, 400)
        DTPcheckouttime.Name = "DTPcheckouttime"
        DTPcheckouttime.Size = New Size(151, 27)
        DTPcheckouttime.TabIndex = 12
        ' 
        ' NUDnguest
        ' 
        NUDnguest.Location = New Point(163, 258)
        NUDnguest.Name = "NUDnguest"
        NUDnguest.Size = New Size(150, 27)
        NUDnguest.TabIndex = 13
        NUDnguest.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' DTParrivaldate
        ' 
        DTParrivaldate.CalendarForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        DTParrivaldate.Location = New Point(157, 189)
        DTParrivaldate.Name = "DTParrivaldate"
        DTParrivaldate.Size = New Size(264, 27)
        DTParrivaldate.TabIndex = 14
        ' 
        ' DTParrivaltime
        ' 
        DTParrivaltime.Format = DateTimePickerFormat.Time
        DTParrivaltime.Location = New Point(602, 185)
        DTParrivaltime.Name = "DTParrivaltime"
        DTParrivaltime.Size = New Size(151, 27)
        DTParrivaltime.TabIndex = 15
        DTParrivaltime.Value = New Date(2024, 6, 1, 16, 36, 0, 0)
        ' 
        ' GuestIDcombobx
        ' 
        GuestIDcombobx.BackColor = SystemColors.ScrollBar
        GuestIDcombobx.FlatStyle = FlatStyle.Flat
        GuestIDcombobx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        GuestIDcombobx.FormattingEnabled = True
        GuestIDcombobx.Location = New Point(148, 115)
        GuestIDcombobx.Name = "GuestIDcombobx"
        GuestIDcombobx.Size = New Size(100, 28)
        GuestIDcombobx.TabIndex = 16
        ' 
        ' Reserveddaystxtbx
        ' 
        Reserveddaystxtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Reserveddaystxtbx.Location = New Point(602, 258)
        Reserveddaystxtbx.Name = "Reserveddaystxtbx"
        Reserveddaystxtbx.Size = New Size(151, 30)
        Reserveddaystxtbx.TabIndex = 17
        ' 
        ' Nroomtxtbx
        ' 
        Nroomtxtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Nroomtxtbx.Location = New Point(163, 326)
        Nroomtxtbx.Name = "Nroomtxtbx"
        Nroomtxtbx.Size = New Size(143, 30)
        Nroomtxtbx.TabIndex = 19
        ' 
        ' Roomtypecombobx
        ' 
        Roomtypecombobx.BackColor = SystemColors.ScrollBar
        Roomtypecombobx.FlatStyle = FlatStyle.Flat
        Roomtypecombobx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Roomtypecombobx.FormattingEnabled = True
        Roomtypecombobx.Location = New Point(602, 328)
        Roomtypecombobx.Name = "Roomtypecombobx"
        Roomtypecombobx.Size = New Size(169, 28)
        Roomtypecombobx.TabIndex = 20
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
        ' checkinbtn
        ' 
        checkinbtn.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        checkinbtn.FlatAppearance.BorderColor = Color.White
        checkinbtn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        checkinbtn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        checkinbtn.FlatStyle = FlatStyle.Flat
        checkinbtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        clearbtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        clearbtn.ForeColor = SystemColors.ControlLightLight
        clearbtn.Location = New Point(478, 502)
        clearbtn.Name = "clearbtn"
        clearbtn.Size = New Size(135, 42)
        clearbtn.TabIndex = 24
        clearbtn.Text = "Clear"
        clearbtn.UseVisualStyleBackColor = False
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = SystemColors.ControlLightLight
        closebtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 12F, FontStyle.Bold)
        closebtn.Location = New Point(770, 8)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(47, 34)
        closebtn.TabIndex = 26
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' checkin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(829, 585)
        Controls.Add(clearbtn)
        Controls.Add(checkinbtn)
        Controls.Add(Panelgci)
        Controls.Add(Roomtypecombobx)
        Controls.Add(Nroomtxtbx)
        Controls.Add(Reserveddaystxtbx)
        Controls.Add(GuestIDcombobx)
        Controls.Add(DTParrivaltime)
        Controls.Add(DTParrivaldate)
        Controls.Add(NUDnguest)
        Controls.Add(DTPcheckouttime)
        Controls.Add(DTPcheckoutdate)
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
        CType(NUDnguest, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DTPcheckoutdate As DateTimePicker
    Friend WithEvents DTPcheckouttime As DateTimePicker
    Friend WithEvents NUDnguest As NumericUpDown
    Friend WithEvents DTParrivaldate As DateTimePicker
    Friend WithEvents DTParrivaltime As DateTimePicker
    Friend WithEvents GuestIDcombobx As ComboBox
    Friend WithEvents Reserveddaystxtbx As TextBox
    Friend WithEvents Nroomtxtbx As TextBox
    Friend WithEvents Roomtypecombobx As ComboBox
    Friend WithEvents Panelgci As Panel
    Friend WithEvents checkinbtn As Button
    Friend WithEvents clearbtn As Button
    Friend WithEvents closebtn As Button
End Class
