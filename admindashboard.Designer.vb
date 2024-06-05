<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admindashboard
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
        logoutbtn = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Panel1 = New Panel()
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
        Label1guests = New Label()
        inttotfg = New Label()
        inttotmg = New Label()
        inttotguests = New Label()
        maleg_label = New Label()
        femaleg_label = New Label()
        guest_totlabel = New Label()
        closebtn = New Button()
        Paneluser.SuspendLayout()
        Panel1.SuspendLayout()
        roompanel1.SuspendLayout()
        guestpanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Paneluser
        ' 
        Paneluser.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Paneluser.Controls.Add(logoutbtn)
        Paneluser.Controls.Add(Button1)
        Paneluser.Controls.Add(Button2)
        Paneluser.Controls.Add(Button3)
        Paneluser.Controls.Add(Button4)
        Paneluser.Controls.Add(Button5)
        Paneluser.Dock = DockStyle.Left
        Paneluser.Location = New Point(0, 0)
        Paneluser.Margin = New Padding(3, 2, 3, 2)
        Paneluser.Name = "Paneluser"
        Paneluser.Size = New Size(177, 423)
        Paneluser.TabIndex = 19
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
        logoutbtn.Location = New Point(21, 324)
        logoutbtn.Margin = New Padding(3, 2, 3, 2)
        logoutbtn.Name = "logoutbtn"
        logoutbtn.Size = New Size(118, 35)
        logoutbtn.TabIndex = 9
        logoutbtn.Text = "Log Out"
        logoutbtn.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button1.FlatAppearance.BorderColor = SystemColors.Control
        Button1.FlatAppearance.BorderSize = 2
        Button1.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Button1.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Tahoma", 10.8F)
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(19, 94)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 30)
        Button1.TabIndex = 8
        Button1.Text = "Hotel Status"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button2.FlatAppearance.BorderColor = SystemColors.Control
        Button2.FlatAppearance.BorderSize = 2
        Button2.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Button2.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Tahoma", 10.8F)
        Button2.ForeColor = SystemColors.Control
        Button2.Location = New Point(19, 232)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(128, 30)
        Button2.TabIndex = 7
        Button2.Text = "Transaction"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button3.FlatAppearance.BorderColor = SystemColors.Control
        Button3.FlatAppearance.BorderSize = 2
        Button3.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Button3.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Tahoma", 10.8F)
        Button3.ForeColor = SystemColors.Control
        Button3.Location = New Point(19, 163)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(128, 30)
        Button3.TabIndex = 6
        Button3.Text = "View Employee"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button4.FlatAppearance.BorderColor = SystemColors.Control
        Button4.FlatAppearance.BorderSize = 2
        Button4.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Button4.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Tahoma", 10.8F)
        Button4.ForeColor = SystemColors.Control
        Button4.Location = New Point(19, 197)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(128, 30)
        Button4.TabIndex = 5
        Button4.Text = "Rooms"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button5.FlatAppearance.BorderColor = SystemColors.Control
        Button5.FlatAppearance.BorderSize = 2
        Button5.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Button5.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Tahoma", 10.8F)
        Button5.ForeColor = SystemColors.Control
        Button5.Location = New Point(19, 128)
        Button5.Margin = New Padding(3, 2, 3, 2)
        Button5.Name = "Button5"
        Button5.RightToLeft = RightToLeft.No
        Button5.Size = New Size(128, 30)
        Button5.TabIndex = 3
        Button5.Text = "View Guest"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(closebtn)
        Panel1.Controls.Add(guestpanel2)
        Panel1.Controls.Add(roompanel2)
        Panel1.Controls.Add(roompanel1)
        Panel1.Controls.Add(guestpanel1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(177, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(694, 423)
        Panel1.TabIndex = 10
        ' 
        ' guestpanel2
        ' 
        guestpanel2.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        guestpanel2.BorderStyle = BorderStyle.Fixed3D
        guestpanel2.Location = New Point(67, 148)
        guestpanel2.Margin = New Padding(3, 2, 3, 2)
        guestpanel2.Name = "guestpanel2"
        guestpanel2.Size = New Size(239, 18)
        guestpanel2.TabIndex = 7
        ' 
        ' roompanel2
        ' 
        roompanel2.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        roompanel2.BorderStyle = BorderStyle.Fixed3D
        roompanel2.Location = New Point(391, 148)
        roompanel2.Margin = New Padding(3, 2, 3, 2)
        roompanel2.Name = "roompanel2"
        roompanel2.Size = New Size(239, 18)
        roompanel2.TabIndex = 8
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
        roompanel1.Location = New Point(391, 162)
        roompanel1.Margin = New Padding(3, 2, 3, 2)
        roompanel1.Name = "roompanel1"
        roompanel1.Size = New Size(239, 129)
        roompanel1.TabIndex = 10
        ' 
        ' Label2rooms
        ' 
        Label2rooms.AutoSize = True
        Label2rooms.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2rooms.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Label2rooms.Location = New Point(85, 14)
        Label2rooms.Name = "Label2rooms"
        Label2rooms.Size = New Size(61, 19)
        Label2rooms.TabIndex = 10
        Label2rooms.Text = "ROOMS"
        ' 
        ' intavailablerooms
        ' 
        intavailablerooms.AutoSize = True
        intavailablerooms.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        intavailablerooms.ForeColor = Color.DarkBlue
        intavailablerooms.Location = New Point(205, 94)
        intavailablerooms.Name = "intavailablerooms"
        intavailablerooms.Size = New Size(26, 17)
        intavailablerooms.TabIndex = 9
        intavailablerooms.Text = "10"
        ' 
        ' intoccupiedrooms
        ' 
        intoccupiedrooms.AutoSize = True
        intoccupiedrooms.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        intoccupiedrooms.ForeColor = Color.Crimson
        intoccupiedrooms.Location = New Point(205, 73)
        intoccupiedrooms.Name = "intoccupiedrooms"
        intoccupiedrooms.Size = New Size(26, 17)
        intoccupiedrooms.TabIndex = 10
        intoccupiedrooms.Text = "10"
        ' 
        ' inttotrooms
        ' 
        inttotrooms.AutoSize = True
        inttotrooms.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        inttotrooms.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        inttotrooms.Location = New Point(205, 50)
        inttotrooms.Name = "inttotrooms"
        inttotrooms.Size = New Size(26, 17)
        inttotrooms.TabIndex = 11
        inttotrooms.Text = "10"
        ' 
        ' Lblavailablerooms
        ' 
        Lblavailablerooms.AutoSize = True
        Lblavailablerooms.FlatStyle = FlatStyle.Flat
        Lblavailablerooms.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lblavailablerooms.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Lblavailablerooms.Location = New Point(8, 94)
        Lblavailablerooms.Name = "Lblavailablerooms"
        Lblavailablerooms.Size = New Size(109, 15)
        Lblavailablerooms.TabIndex = 8
        Lblavailablerooms.Text = "AVAILABLE ROOMS"
        ' 
        ' Lbltotalrooms
        ' 
        Lbltotalrooms.AutoSize = True
        Lbltotalrooms.FlatStyle = FlatStyle.Flat
        Lbltotalrooms.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbltotalrooms.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Lbltotalrooms.Location = New Point(8, 50)
        Lbltotalrooms.Name = "Lbltotalrooms"
        Lbltotalrooms.Size = New Size(84, 15)
        Lbltotalrooms.TabIndex = 6
        Lbltotalrooms.Text = "TOTAL ROOMS"
        ' 
        ' Lbloccupied
        ' 
        Lbloccupied.AutoSize = True
        Lbloccupied.FlatStyle = FlatStyle.Flat
        Lbloccupied.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbloccupied.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Lbloccupied.Location = New Point(8, 73)
        Lbloccupied.Name = "Lbloccupied"
        Lbloccupied.Size = New Size(109, 15)
        Lbloccupied.TabIndex = 7
        Lbloccupied.Text = "OCCUPIED ROOMS"
        ' 
        ' guestpanel1
        ' 
        guestpanel1.BackColor = SystemColors.ButtonHighlight
        guestpanel1.BorderStyle = BorderStyle.Fixed3D
        guestpanel1.Controls.Add(Label1guests)
        guestpanel1.Controls.Add(inttotfg)
        guestpanel1.Controls.Add(inttotmg)
        guestpanel1.Controls.Add(inttotguests)
        guestpanel1.Controls.Add(maleg_label)
        guestpanel1.Controls.Add(femaleg_label)
        guestpanel1.Controls.Add(guest_totlabel)
        guestpanel1.Location = New Point(67, 162)
        guestpanel1.Margin = New Padding(3, 2, 3, 2)
        guestpanel1.Name = "guestpanel1"
        guestpanel1.Size = New Size(239, 129)
        guestpanel1.TabIndex = 9
        ' 
        ' Label1guests
        ' 
        Label1guests.AutoSize = True
        Label1guests.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1guests.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Label1guests.Location = New Point(74, 14)
        Label1guests.Name = "Label1guests"
        Label1guests.Size = New Size(60, 19)
        Label1guests.TabIndex = 9
        Label1guests.Text = "GUESTS"
        ' 
        ' inttotfg
        ' 
        inttotfg.AutoSize = True
        inttotfg.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        inttotfg.ForeColor = Color.Fuchsia
        inttotfg.Location = New Point(205, 73)
        inttotfg.Name = "inttotfg"
        inttotfg.Size = New Size(26, 17)
        inttotfg.TabIndex = 8
        inttotfg.Text = "10"
        ' 
        ' inttotmg
        ' 
        inttotmg.AutoSize = True
        inttotmg.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        inttotmg.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        inttotmg.Location = New Point(205, 94)
        inttotmg.Name = "inttotmg"
        inttotmg.Size = New Size(26, 17)
        inttotmg.TabIndex = 7
        inttotmg.Text = "10"
        ' 
        ' inttotguests
        ' 
        inttotguests.AutoSize = True
        inttotguests.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        inttotguests.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        inttotguests.Location = New Point(205, 50)
        inttotguests.Name = "inttotguests"
        inttotguests.Size = New Size(26, 17)
        inttotguests.TabIndex = 6
        inttotguests.Text = "10"
        ' 
        ' maleg_label
        ' 
        maleg_label.AutoSize = True
        maleg_label.FlatStyle = FlatStyle.Flat
        maleg_label.Font = New Font("Segoe UI", 9F)
        maleg_label.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        maleg_label.Location = New Point(3, 94)
        maleg_label.Name = "maleg_label"
        maleg_label.Size = New Size(81, 15)
        maleg_label.TabIndex = 5
        maleg_label.Text = "MALE GUESTS"
        ' 
        ' femaleg_label
        ' 
        femaleg_label.AutoSize = True
        femaleg_label.FlatStyle = FlatStyle.Flat
        femaleg_label.Font = New Font("Segoe UI", 9F)
        femaleg_label.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        femaleg_label.Location = New Point(3, 73)
        femaleg_label.Name = "femaleg_label"
        femaleg_label.Size = New Size(93, 15)
        femaleg_label.TabIndex = 4
        femaleg_label.Text = "FEMALE GUESTS"
        ' 
        ' guest_totlabel
        ' 
        guest_totlabel.AutoSize = True
        guest_totlabel.FlatStyle = FlatStyle.Flat
        guest_totlabel.Font = New Font("Segoe UI", 9F)
        guest_totlabel.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        guest_totlabel.Location = New Point(3, 50)
        guest_totlabel.Name = "guest_totlabel"
        guest_totlabel.Size = New Size(124, 15)
        guest_totlabel.TabIndex = 3
        guest_totlabel.Text = "TOTAL NO. OF GUESTS"
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        closebtn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        closebtn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = SystemColors.ControlLightLight
        closebtn.Location = New Point(652, 2)
        closebtn.Margin = New Padding(3, 2, 3, 2)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(41, 26)
        closebtn.TabIndex = 11
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' admindashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(871, 423)
        ControlBox = False
        Controls.Add(Panel1)
        Controls.Add(Paneluser)
        MaximizeBox = False
        MinimizeBox = False
        Name = "admindashboard"
        Paneluser.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        roompanel1.ResumeLayout(False)
        roompanel1.PerformLayout()
        guestpanel1.ResumeLayout(False)
        guestpanel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Paneluser As Panel
    Friend WithEvents logoutbtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents Label1guests As Label
    Friend WithEvents inttotfg As Label
    Friend WithEvents inttotmg As Label
    Friend WithEvents inttotguests As Label
    Friend WithEvents maleg_label As Label
    Friend WithEvents femaleg_label As Label
    Friend WithEvents guest_totlabel As Label
    Friend WithEvents closebtn As Button
End Class
