<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Labeladminname = New Label()
        Lbl_currentadmin = New Label()
        logoutbtn = New Button()
        statusbtn = New Button()
        transactionbtn = New Button()
        viewempbtn = New Button()
        roomsbtn = New Button()
        viewguestbtn = New Button()
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
        Paneluser.Controls.Add(Labeladminname)
        Paneluser.Controls.Add(Lbl_currentadmin)
        Paneluser.Controls.Add(logoutbtn)
        Paneluser.Controls.Add(statusbtn)
        Paneluser.Controls.Add(transactionbtn)
        Paneluser.Controls.Add(viewempbtn)
        Paneluser.Controls.Add(roomsbtn)
        Paneluser.Controls.Add(viewguestbtn)
        Paneluser.Dock = DockStyle.Left
        Paneluser.Location = New Point(0, 0)
        Paneluser.Name = "Paneluser"
        Paneluser.Size = New Size(201, 585)
        Paneluser.TabIndex = 1
        ' 
        ' Labeladminname
        ' 
        Labeladminname.AutoSize = True
        Labeladminname.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Labeladminname.FlatStyle = FlatStyle.Flat
        Labeladminname.Font = New Font("Tahoma", 10.8F)
        Labeladminname.ForeColor = SystemColors.ControlLightLight
        Labeladminname.Location = New Point(54, 40)
        Labeladminname.Name = "Labeladminname"
        Labeladminname.Size = New Size(101, 22)
        Labeladminname.TabIndex = 11
        Labeladminname.Text = "adminname"
        Labeladminname.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Lbl_currentadmin
        ' 
        Lbl_currentadmin.AutoSize = True
        Lbl_currentadmin.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Lbl_currentadmin.FlatStyle = FlatStyle.Flat
        Lbl_currentadmin.Font = New Font("Tahoma", 10.8F)
        Lbl_currentadmin.ForeColor = SystemColors.ControlLightLight
        Lbl_currentadmin.Location = New Point(39, 13)
        Lbl_currentadmin.Name = "Lbl_currentadmin"
        Lbl_currentadmin.Size = New Size(115, 22)
        Lbl_currentadmin.TabIndex = 10
        Lbl_currentadmin.Text = "Current User:"
        Lbl_currentadmin.TextAlign = ContentAlignment.TopCenter
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
        logoutbtn.Location = New Point(29, 495)
        logoutbtn.Name = "logoutbtn"
        logoutbtn.Size = New Size(135, 41)
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
        statusbtn.Location = New Point(22, 125)
        statusbtn.Name = "statusbtn"
        statusbtn.Size = New Size(146, 40)
        statusbtn.TabIndex = 8
        statusbtn.Text = "Hotel Status"
        statusbtn.UseVisualStyleBackColor = False
        ' 
        ' transactionbtn
        ' 
        transactionbtn.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        transactionbtn.FlatAppearance.BorderColor = SystemColors.Control
        transactionbtn.FlatAppearance.BorderSize = 2
        transactionbtn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        transactionbtn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        transactionbtn.FlatStyle = FlatStyle.Flat
        transactionbtn.Font = New Font("Tahoma", 10.8F)
        transactionbtn.ForeColor = SystemColors.Control
        transactionbtn.Location = New Point(22, 309)
        transactionbtn.Name = "transactionbtn"
        transactionbtn.Size = New Size(146, 40)
        transactionbtn.TabIndex = 7
        transactionbtn.Text = "Transaction"
        transactionbtn.UseVisualStyleBackColor = False
        ' 
        ' viewempbtn
        ' 
        viewempbtn.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        viewempbtn.FlatAppearance.BorderColor = SystemColors.Control
        viewempbtn.FlatAppearance.BorderSize = 2
        viewempbtn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        viewempbtn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        viewempbtn.FlatStyle = FlatStyle.Flat
        viewempbtn.Font = New Font("Tahoma", 10.8F)
        viewempbtn.ForeColor = SystemColors.Control
        viewempbtn.Location = New Point(22, 217)
        viewempbtn.Name = "viewempbtn"
        viewempbtn.Size = New Size(146, 40)
        viewempbtn.TabIndex = 6
        viewempbtn.Text = "View Employee"
        viewempbtn.UseVisualStyleBackColor = False
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
        ' viewguestbtn
        ' 
        viewguestbtn.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        viewguestbtn.FlatAppearance.BorderColor = SystemColors.Control
        viewguestbtn.FlatAppearance.BorderSize = 2
        viewguestbtn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        viewguestbtn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        viewguestbtn.FlatStyle = FlatStyle.Flat
        viewguestbtn.Font = New Font("Tahoma", 10.8F)
        viewguestbtn.ForeColor = SystemColors.Control
        viewguestbtn.Location = New Point(22, 171)
        viewguestbtn.Name = "viewguestbtn"
        viewguestbtn.Size = New Size(146, 40)
        viewguestbtn.TabIndex = 3
        viewguestbtn.Text = "View Guest"
        viewguestbtn.UseVisualStyleBackColor = False
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
        pnlhotel_status.TabIndex = 3
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        closebtn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        closebtn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = SystemColors.ControlLightLight
        closebtn.Location = New Point(770, 3)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(47, 35)
        closebtn.TabIndex = 7
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' guestpanel2
        ' 
        guestpanel2.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        guestpanel2.BorderStyle = BorderStyle.Fixed3D
        guestpanel2.Location = New Point(50, 159)
        guestpanel2.Name = "guestpanel2"
        guestpanel2.Size = New Size(273, 23)
        guestpanel2.TabIndex = 0
        ' 
        ' roompanel2
        ' 
        roompanel2.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        roompanel2.BorderStyle = BorderStyle.Fixed3D
        roompanel2.Location = New Point(421, 159)
        roompanel2.Name = "roompanel2"
        roompanel2.Size = New Size(273, 23)
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
        roompanel1.Location = New Point(421, 177)
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
        intavailablerooms.Location = New Point(234, 125)
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
        inttotrooms.Location = New Point(234, 67)
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
        Lblavailablerooms.Location = New Point(9, 125)
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
        Lbltotalrooms.Location = New Point(9, 67)
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
        guestpanel1.Location = New Point(50, 177)
        guestpanel1.Name = "guestpanel1"
        guestpanel1.Size = New Size(273, 171)
        guestpanel1.TabIndex = 5
        ' 
        ' Lbl1guests
        ' 
        Lbl1guests.AutoSize = True
        Lbl1guests.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl1guests.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Lbl1guests.Location = New Point(85, 19)
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
        inttotmg.Location = New Point(234, 125)
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
        inttotguests.Location = New Point(234, 67)
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
        maleg_label.Location = New Point(3, 125)
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
        guest_totlabel.Location = New Point(3, 67)
        guest_totlabel.Name = "guest_totlabel"
        guest_totlabel.Size = New Size(157, 20)
        guest_totlabel.TabIndex = 3
        guest_totlabel.Text = "TOTAL NO. OF GUESTS"
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1021, 585)
        Controls.Add(pnlhotel_status)
        Controls.Add(Paneluser)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "AdminDashboard"
        Text = "AdminDashboard"
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
    Friend WithEvents Labeladminname As Label
    Friend WithEvents Lbl_currentadmin As Label
    Friend WithEvents logoutbtn As Button
    Friend WithEvents statusbtn As Button
    Friend WithEvents transactionbtn As Button
    Friend WithEvents viewempbtn As Button
    Friend WithEvents roomsbtn As Button
    Friend WithEvents viewguestbtn As Button
    Friend WithEvents pnlhotel_status As Panel
    Friend WithEvents closebtn As Button
    Friend WithEvents guestpanel2 As Panel
    Friend WithEvents roompanel2 As Panel
    Friend WithEvents roompanel1 As Panel
    Friend WithEvents Label2rooms As Label
    Friend WithEvents intavailablerooms As Label
    Friend WithEvents intoccupiedrooms As Label
    Friend WithEvents inttotrooms As Label
    Friend WithEvents Lblavailablerooms As Label
    Friend WithEvents Lbltotalrooms As Label
    Friend WithEvents Lbloccupied As Label
    Friend WithEvents guestpanel1 As Panel
    Friend WithEvents Lbl1guests As Label
    Friend WithEvents inttotfg As Label
    Friend WithEvents inttotmg As Label
    Friend WithEvents inttotguests As Label
    Friend WithEvents maleg_label As Label
    Friend WithEvents femaleg_label As Label
    Friend WithEvents guest_totlabel As Label
End Class
