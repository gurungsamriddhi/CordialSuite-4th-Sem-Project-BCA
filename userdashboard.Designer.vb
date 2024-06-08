<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userdashboard
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
        Paneluser = New Panel()
        Labelusername = New Label()
        Lbl_currentuser = New Label()
        logoutbtn = New Button()
        statusbtn = New Button()
        checkoutbtn = New Button()
        checkinbtn = New Button()
        roomsbtn = New Button()
        billingbtn = New Button()
        addguestbtn = New Button()
        pnlhotel_status = New Panel()
        closebtn = New Button()
        guestpanel2 = New Panel()
        roompanel2 = New Panel()
        roompanel1 = New Panel()
        Label2rooms = New Label()
        intavailablerooms = New Label()
        intoccupiedrooms = New Label()
        inttotrooms = New Label()
        Lblavailablerooms = New Label()
        Lbltotalrooms = New Label()
        Lbloccupied = New Label()
        guestpanel1 = New Panel()
        Lbl1guests = New Label()
        inttotfg = New Label()
        inttotmg = New Label()
        inttotguests = New Label()
        maleg_label = New Label()
        femaleg_label = New Label()
        guest_totlabel = New Label()
        Paneluser.SuspendLayout()
        pnlhotel_status.SuspendLayout()
        roompanel1.SuspendLayout()
        guestpanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Paneluser
        ' 
        Paneluser.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Paneluser.Controls.Add(Labelusername)
        Paneluser.Controls.Add(Lbl_currentuser)
        Paneluser.Controls.Add(logoutbtn)
        Paneluser.Controls.Add(statusbtn)
        Paneluser.Controls.Add(checkoutbtn)
        Paneluser.Controls.Add(checkinbtn)
        Paneluser.Controls.Add(roomsbtn)
        Paneluser.Controls.Add(billingbtn)
        Paneluser.Controls.Add(addguestbtn)
        Paneluser.Dock = DockStyle.Left
        Paneluser.Location = New Point(0, 0)
        Paneluser.Name = "Paneluser"
        Paneluser.Size = New Size(201, 585)
        Paneluser.TabIndex = 0
        ' 
        ' Labelusername
        ' 
        Labelusername.AutoSize = True
        Labelusername.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Labelusername.FlatStyle = FlatStyle.Flat
        Labelusername.Font = New Font("Tahoma", 10.2F)
        Labelusername.ForeColor = SystemColors.ControlLightLight
        Labelusername.Location = New Point(54, 40)
        Labelusername.Name = "Labelusername"
        Labelusername.Size = New Size(83, 21)
        Labelusername.TabIndex = 11
        Labelusername.Text = "username"
        Labelusername.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Lbl_currentuser
        ' 
        Lbl_currentuser.AutoSize = True
        Lbl_currentuser.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Lbl_currentuser.FlatStyle = FlatStyle.Flat
        Lbl_currentuser.Font = New Font("Tahoma", 10.2F)
        Lbl_currentuser.ForeColor = SystemColors.ControlLightLight
        Lbl_currentuser.Location = New Point(39, 13)
        Lbl_currentuser.Name = "Lbl_currentuser"
        Lbl_currentuser.Size = New Size(110, 21)
        Lbl_currentuser.TabIndex = 10
        Lbl_currentuser.Text = "Current User:"
        Lbl_currentuser.TextAlign = ContentAlignment.TopCenter
        ' 
        ' logoutbtn
        ' 
        logoutbtn.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        logoutbtn.FlatAppearance.BorderColor = SystemColors.Control
        logoutbtn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        logoutbtn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        logoutbtn.FlatStyle = FlatStyle.Flat
        logoutbtn.Font = New Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        logoutbtn.ForeColor = SystemColors.Control
        logoutbtn.Location = New Point(29, 538)
        logoutbtn.Name = "logoutbtn"
        logoutbtn.Size = New Size(135, 35)
        logoutbtn.TabIndex = 9
        logoutbtn.Text = "Log Out"
        logoutbtn.UseVisualStyleBackColor = False
        ' 
        ' statusbtn
        ' 
        statusbtn.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        statusbtn.FlatAppearance.BorderColor = SystemColors.Control
        statusbtn.FlatAppearance.BorderSize = 2
        statusbtn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        statusbtn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        statusbtn.FlatStyle = FlatStyle.Flat
        statusbtn.Font = New Font("Tahoma", 10.8F)
        statusbtn.ForeColor = SystemColors.Control
        statusbtn.Location = New Point(22, 126)
        statusbtn.Name = "statusbtn"
        statusbtn.Size = New Size(146, 40)
        statusbtn.TabIndex = 8
        statusbtn.Text = "Hotel Status"
        statusbtn.UseVisualStyleBackColor = False
        ' 
        ' checkoutbtn
        ' 
        checkoutbtn.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        checkoutbtn.FlatAppearance.BorderColor = SystemColors.Control
        checkoutbtn.FlatAppearance.BorderSize = 2
        checkoutbtn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        checkoutbtn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        checkoutbtn.FlatStyle = FlatStyle.Flat
        checkoutbtn.Font = New Font("Tahoma", 10.8F)
        checkoutbtn.ForeColor = SystemColors.Control
        checkoutbtn.Location = New Point(22, 309)
        checkoutbtn.Name = "checkoutbtn"
        checkoutbtn.Size = New Size(146, 40)
        checkoutbtn.TabIndex = 7
        checkoutbtn.Text = "Check-out"
        checkoutbtn.UseVisualStyleBackColor = False
        ' 
        ' checkinbtn
        ' 
        checkinbtn.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        checkinbtn.FlatAppearance.BorderColor = SystemColors.Control
        checkinbtn.FlatAppearance.BorderSize = 2
        checkinbtn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        checkinbtn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        checkinbtn.FlatStyle = FlatStyle.Flat
        checkinbtn.Font = New Font("Tahoma", 10.8F)
        checkinbtn.ForeColor = SystemColors.Control
        checkinbtn.Location = New Point(22, 217)
        checkinbtn.Name = "checkinbtn"
        checkinbtn.Size = New Size(146, 40)
        checkinbtn.TabIndex = 6
        checkinbtn.Text = "Check-in"
        checkinbtn.UseVisualStyleBackColor = False
        ' 
        ' roomsbtn
        ' 
        roomsbtn.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        roomsbtn.FlatAppearance.BorderColor = SystemColors.Control
        roomsbtn.FlatAppearance.BorderSize = 2
        roomsbtn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        roomsbtn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        roomsbtn.FlatStyle = FlatStyle.Flat
        roomsbtn.Font = New Font("Tahoma", 10.8F)
        roomsbtn.ForeColor = SystemColors.Control
        roomsbtn.Location = New Point(22, 263)
        roomsbtn.Name = "roomsbtn"
        roomsbtn.Size = New Size(146, 40)
        roomsbtn.TabIndex = 5
        roomsbtn.Text = "Rooms"
        roomsbtn.UseVisualStyleBackColor = False
        ' 
        ' billingbtn
        ' 
        billingbtn.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        billingbtn.FlatAppearance.BorderColor = SystemColors.Control
        billingbtn.FlatAppearance.BorderSize = 2
        billingbtn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        billingbtn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        billingbtn.FlatStyle = FlatStyle.Flat
        billingbtn.Font = New Font("Tahoma", 10.8F)
        billingbtn.ForeColor = SystemColors.Control
        billingbtn.Location = New Point(22, 355)
        billingbtn.Name = "billingbtn"
        billingbtn.Size = New Size(146, 40)
        billingbtn.TabIndex = 4
        billingbtn.Text = "Billing"
        billingbtn.UseVisualStyleBackColor = False
        ' 
        ' addguestbtn
        ' 
        addguestbtn.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        addguestbtn.FlatAppearance.BorderColor = SystemColors.Control
        addguestbtn.FlatAppearance.BorderSize = 2
        addguestbtn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        addguestbtn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        addguestbtn.FlatStyle = FlatStyle.Flat
        addguestbtn.Font = New Font("Tahoma", 10.8F)
        addguestbtn.ForeColor = SystemColors.Control
        addguestbtn.Location = New Point(22, 171)
        addguestbtn.Name = "addguestbtn"
        addguestbtn.Size = New Size(146, 40)
        addguestbtn.TabIndex = 3
        addguestbtn.Text = "Add Guest"
        addguestbtn.UseVisualStyleBackColor = False
        ' 
        ' pnlhotel_status
        ' 
        pnlhotel_status.BackColor = SystemColors.Control
        pnlhotel_status.Controls.Add(closebtn)
        pnlhotel_status.Controls.Add(guestpanel2)
        pnlhotel_status.Controls.Add(roompanel2)
        pnlhotel_status.Controls.Add(roompanel1)
        pnlhotel_status.Controls.Add(guestpanel1)
        pnlhotel_status.Dock = DockStyle.Fill
        pnlhotel_status.Location = New Point(201, 0)
        pnlhotel_status.Name = "pnlhotel_status"
        pnlhotel_status.Size = New Size(820, 585)
        pnlhotel_status.TabIndex = 2
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        closebtn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        closebtn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = SystemColors.ControlLightLight
        closebtn.Location = New Point(770, 3)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(47, 34)
        closebtn.TabIndex = 7
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' guestpanel2
        ' 
        guestpanel2.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        guestpanel2.BorderStyle = BorderStyle.Fixed3D
        guestpanel2.Location = New Point(91, 164)
        guestpanel2.Name = "guestpanel2"
        guestpanel2.Size = New Size(273, 22)
        guestpanel2.TabIndex = 0
        ' 
        ' roompanel2
        ' 
        roompanel2.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        roompanel2.BorderStyle = BorderStyle.Fixed3D
        roompanel2.Location = New Point(462, 164)
        roompanel2.Name = "roompanel2"
        roompanel2.Size = New Size(273, 22)
        roompanel2.TabIndex = 1
        ' 
        ' roompanel1
        ' 
        roompanel1.BackColor = SystemColors.ButtonHighlight
        roompanel1.BorderStyle = BorderStyle.Fixed3D
        roompanel1.Controls.Add(Label2rooms)
        roompanel1.Controls.Add(intavailablerooms)
        roompanel1.Controls.Add(intoccupiedrooms)
        roompanel1.Controls.Add(inttotrooms)
        roompanel1.Controls.Add(Lblavailablerooms)
        roompanel1.Controls.Add(Lbltotalrooms)
        roompanel1.Controls.Add(Lbloccupied)
        roompanel1.Location = New Point(462, 183)
        roompanel1.Name = "roompanel1"
        roompanel1.Size = New Size(273, 171)
        roompanel1.TabIndex = 6
        ' 
        ' Label2rooms
        ' 
        Label2rooms.AutoSize = True
        Label2rooms.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2rooms.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Label2rooms.Location = New Point(97, 19)
        Label2rooms.Name = "Label2rooms"
        Label2rooms.Size = New Size(72, 23)
        Label2rooms.TabIndex = 10
        Label2rooms.Text = "ROOMS"
        ' 
        ' intavailablerooms
        ' 
        intavailablerooms.AutoSize = True
        intavailablerooms.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        intavailablerooms.ForeColor = Color.DarkBlue
        intavailablerooms.Location = New Point(234, 126)
        intavailablerooms.Name = "intavailablerooms"
        intavailablerooms.Size = New Size(32, 21)
        intavailablerooms.TabIndex = 9
        intavailablerooms.Text = "10"
        ' 
        ' intoccupiedrooms
        ' 
        intoccupiedrooms.AutoSize = True
        intoccupiedrooms.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        intoccupiedrooms.ForeColor = Color.Crimson
        intoccupiedrooms.Location = New Point(234, 97)
        intoccupiedrooms.Name = "intoccupiedrooms"
        intoccupiedrooms.Size = New Size(32, 21)
        intoccupiedrooms.TabIndex = 10
        intoccupiedrooms.Text = "10"
        ' 
        ' inttotrooms
        ' 
        inttotrooms.AutoSize = True
        inttotrooms.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        inttotrooms.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        inttotrooms.Location = New Point(234, 66)
        inttotrooms.Name = "inttotrooms"
        inttotrooms.Size = New Size(32, 21)
        inttotrooms.TabIndex = 11
        inttotrooms.Text = "10"
        ' 
        ' Lblavailablerooms
        ' 
        Lblavailablerooms.AutoSize = True
        Lblavailablerooms.FlatStyle = FlatStyle.Flat
        Lblavailablerooms.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lblavailablerooms.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Lblavailablerooms.Location = New Point(9, 126)
        Lblavailablerooms.Name = "Lblavailablerooms"
        Lblavailablerooms.Size = New Size(137, 20)
        Lblavailablerooms.TabIndex = 8
        Lblavailablerooms.Text = "AVAILABLE ROOMS"
        ' 
        ' Lbltotalrooms
        ' 
        Lbltotalrooms.AutoSize = True
        Lbltotalrooms.FlatStyle = FlatStyle.Flat
        Lbltotalrooms.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbltotalrooms.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Lbltotalrooms.Location = New Point(9, 66)
        Lbltotalrooms.Name = "Lbltotalrooms"
        Lbltotalrooms.Size = New Size(106, 20)
        Lbltotalrooms.TabIndex = 6
        Lbltotalrooms.Text = "TOTAL ROOMS"
        ' 
        ' Lbloccupied
        ' 
        Lbloccupied.AutoSize = True
        Lbloccupied.FlatStyle = FlatStyle.Flat
        Lbloccupied.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbloccupied.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Lbloccupied.Location = New Point(9, 97)
        Lbloccupied.Name = "Lbloccupied"
        Lbloccupied.Size = New Size(135, 20)
        Lbloccupied.TabIndex = 7
        Lbloccupied.Text = "OCCUPIED ROOMS"
        ' 
        ' guestpanel1
        ' 
        guestpanel1.BackColor = SystemColors.ButtonHighlight
        guestpanel1.BorderStyle = BorderStyle.Fixed3D
        guestpanel1.Controls.Add(Lbl1guests)
        guestpanel1.Controls.Add(inttotfg)
        guestpanel1.Controls.Add(inttotmg)
        guestpanel1.Controls.Add(inttotguests)
        guestpanel1.Controls.Add(maleg_label)
        guestpanel1.Controls.Add(femaleg_label)
        guestpanel1.Controls.Add(guest_totlabel)
        guestpanel1.Location = New Point(91, 183)
        guestpanel1.Name = "guestpanel1"
        guestpanel1.Size = New Size(273, 171)
        guestpanel1.TabIndex = 5
        ' 
        ' Lbl1guests
        ' 
        Lbl1guests.AutoSize = True
        Lbl1guests.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl1guests.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Lbl1guests.Location = New Point(84, 19)
        Lbl1guests.Name = "Lbl1guests"
        Lbl1guests.Size = New Size(70, 23)
        Lbl1guests.TabIndex = 9
        Lbl1guests.Text = "GUESTS"
        ' 
        ' inttotfg
        ' 
        inttotfg.AutoSize = True
        inttotfg.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        inttotfg.ForeColor = Color.Fuchsia
        inttotfg.Location = New Point(234, 97)
        inttotfg.Name = "inttotfg"
        inttotfg.Size = New Size(32, 21)
        inttotfg.TabIndex = 8
        inttotfg.Text = "10"
        ' 
        ' inttotmg
        ' 
        inttotmg.AutoSize = True
        inttotmg.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        inttotmg.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        inttotmg.Location = New Point(234, 126)
        inttotmg.Name = "inttotmg"
        inttotmg.Size = New Size(32, 21)
        inttotmg.TabIndex = 7
        inttotmg.Text = "10"
        ' 
        ' inttotguests
        ' 
        inttotguests.AutoSize = True
        inttotguests.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        inttotguests.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        inttotguests.Location = New Point(234, 66)
        inttotguests.Name = "inttotguests"
        inttotguests.Size = New Size(32, 21)
        inttotguests.TabIndex = 6
        inttotguests.Text = "10"
        ' 
        ' maleg_label
        ' 
        maleg_label.AutoSize = True
        maleg_label.FlatStyle = FlatStyle.Flat
        maleg_label.Font = New Font("Segoe UI", 9F)
        maleg_label.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        maleg_label.Location = New Point(3, 126)
        maleg_label.Name = "maleg_label"
        maleg_label.Size = New Size(103, 20)
        maleg_label.TabIndex = 5
        maleg_label.Text = "MALE GUESTS"
        ' 
        ' femaleg_label
        ' 
        femaleg_label.AutoSize = True
        femaleg_label.FlatStyle = FlatStyle.Flat
        femaleg_label.Font = New Font("Segoe UI", 9F)
        femaleg_label.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        femaleg_label.Location = New Point(3, 97)
        femaleg_label.Name = "femaleg_label"
        femaleg_label.Size = New Size(118, 20)
        femaleg_label.TabIndex = 4
        femaleg_label.Text = "FEMALE GUESTS"
        ' 
        ' guest_totlabel
        ' 
        guest_totlabel.AutoSize = True
        guest_totlabel.FlatStyle = FlatStyle.Flat
        guest_totlabel.Font = New Font("Segoe UI", 9F)
        guest_totlabel.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        guest_totlabel.Location = New Point(3, 66)
        guest_totlabel.Name = "guest_totlabel"
        guest_totlabel.Size = New Size(157, 20)
        guest_totlabel.TabIndex = 3
        guest_totlabel.Text = "TOTAL NO. OF GUESTS"
        ' 
        ' userdashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(1021, 585)
        Controls.Add(pnlhotel_status)
        Controls.Add(Paneluser)
        FormBorderStyle = FormBorderStyle.None
        Name = "userdashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Userdashboard"
        Paneluser.ResumeLayout(False)
        Paneluser.PerformLayout()
        pnlhotel_status.ResumeLayout(False)
        roompanel1.ResumeLayout(False)
        roompanel1.PerformLayout()
        guestpanel1.ResumeLayout(False)
        guestpanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Paneluser As Panel
    Friend WithEvents statusbtn As Button
    Friend WithEvents checkoutbtn As Button
    Friend WithEvents checkinbtn As Button
    Friend WithEvents roomsbtn As Button
    Friend WithEvents billingbtn As Button
    Friend WithEvents addguestbtn As Button
    Friend WithEvents pnlhotel_status As Panel
    Friend WithEvents guestpanel1 As Panel
    Friend WithEvents roompanel2 As Panel
    Friend WithEvents roompanel1 As Panel
    Friend WithEvents guestpanel2 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents guest_totlabel As Label
    Friend WithEvents maleg_label As Label
    Friend WithEvents femaleg_label As Label
    Friend WithEvents intavailablerooms As Label
    Friend WithEvents intoccupiedrooms As Label
    Friend WithEvents inttotrooms As Label
    Friend WithEvents inttotfg As Label
    Friend WithEvents inttotmg As Label
    Friend WithEvents inttotguests As Label
    Friend WithEvents logoutbtn As Button
    Friend WithEvents Label2rooms As Label
    Friend WithEvents Lbl1guests As Label
    Friend WithEvents Lblavailablerooms As Label
    Friend WithEvents Lbltotalrooms As Label
    Friend WithEvents Lbloccupied As Label
    Friend WithEvents closebtn As Button
    Friend WithEvents Lbl_currentuser As Label
    Friend WithEvents Labelusername As Label
End Class