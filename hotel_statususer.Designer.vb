<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hotel_statususer
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
        Panel1 = New Panel()
        close_Btn = New Button()
        closebtn = New Button()
        Lblviewg = New Label()
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
        logoutbtn = New Button()
        Panel1.SuspendLayout()
        roompanel1.SuspendLayout()
        guestpanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Panel1.Controls.Add(logoutbtn)
        Panel1.Controls.Add(close_Btn)
        Panel1.Controls.Add(closebtn)
        Panel1.Controls.Add(Lblviewg)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(948, 57)
        Panel1.TabIndex = 43
        ' 
        ' close_Btn
        ' 
        close_Btn.BackColor = Color.Transparent
        close_Btn.FlatAppearance.BorderColor = Color.White
        close_Btn.FlatAppearance.BorderSize = 2
        close_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        close_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        close_Btn.FlatStyle = FlatStyle.Flat
        close_Btn.Font = New Font("Lucida Fax", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        close_Btn.ForeColor = SystemColors.Window
        close_Btn.Location = New Point(900, 5)
        close_Btn.Name = "close_Btn"
        close_Btn.Size = New Size(43, 42)
        close_Btn.TabIndex = 24
        close_Btn.Text = "X"
        close_Btn.UseVisualStyleBackColor = False
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
        Lblviewg.Location = New Point(377, 9)
        Lblviewg.Name = "Lblviewg"
        Lblviewg.Size = New Size(235, 31)
        Lblviewg.TabIndex = 23
        Lblviewg.Text = "VIEW HOTEL STATUS"
        ' 
        ' guestpanel2
        ' 
        guestpanel2.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        guestpanel2.BorderStyle = BorderStyle.Fixed3D
        guestpanel2.Location = New Point(152, 232)
        guestpanel2.Name = "guestpanel2"
        guestpanel2.Size = New Size(273, 22)
        guestpanel2.TabIndex = 44
        ' 
        ' roompanel2
        ' 
        roompanel2.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        roompanel2.BorderStyle = BorderStyle.Fixed3D
        roompanel2.Location = New Point(523, 232)
        roompanel2.Name = "roompanel2"
        roompanel2.Size = New Size(273, 22)
        roompanel2.TabIndex = 45
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
        roompanel1.Location = New Point(523, 251)
        roompanel1.Name = "roompanel1"
        roompanel1.Size = New Size(273, 171)
        roompanel1.TabIndex = 47
        ' 
        ' Label2rooms
        ' 
        Label2rooms.AutoSize = True
        Label2rooms.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2rooms.ForeColor = Color.Black
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
        Lblavailablerooms.ForeColor = Color.Black
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
        Lbltotalrooms.ForeColor = Color.Black
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
        Lbloccupied.ForeColor = Color.Black
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
        guestpanel1.Location = New Point(152, 251)
        guestpanel1.Name = "guestpanel1"
        guestpanel1.Size = New Size(273, 171)
        guestpanel1.TabIndex = 46
        ' 
        ' Lbl1guests
        ' 
        Lbl1guests.AutoSize = True
        Lbl1guests.BackColor = Color.Transparent
        Lbl1guests.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl1guests.ForeColor = Color.Black
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
        maleg_label.ForeColor = Color.Black
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
        femaleg_label.ForeColor = Color.Black
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
        guest_totlabel.ForeColor = Color.Black
        guest_totlabel.Location = New Point(3, 66)
        guest_totlabel.Name = "guest_totlabel"
        guest_totlabel.Size = New Size(157, 20)
        guest_totlabel.TabIndex = 3
        guest_totlabel.Text = "TOTAL NO. OF GUESTS"
        ' 
        ' logoutbtn
        ' 
        logoutbtn.BackColor = Color.Transparent
        logoutbtn.FlatAppearance.BorderColor = SystemColors.Window
        logoutbtn.FlatAppearance.BorderSize = 0
        logoutbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        logoutbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        logoutbtn.FlatStyle = FlatStyle.Flat
        logoutbtn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        logoutbtn.ForeColor = SystemColors.Window
        logoutbtn.Location = New Point(794, 2)
        logoutbtn.Name = "logoutbtn"
        logoutbtn.Size = New Size(100, 51)
        logoutbtn.TabIndex = 48
        logoutbtn.Text = "Log Out"
        logoutbtn.TextAlign = ContentAlignment.MiddleLeft
        logoutbtn.UseVisualStyleBackColor = False
        ' 
        ' hotel_statususer
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(948, 750)
        Controls.Add(guestpanel2)
        Controls.Add(roompanel2)
        Controls.Add(roompanel1)
        Controls.Add(guestpanel1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "hotel_statususer"
        StartPosition = FormStartPosition.CenterScreen
        Text = "hotel_statususer"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        roompanel1.ResumeLayout(False)
        roompanel1.PerformLayout()
        guestpanel1.ResumeLayout(False)
        guestpanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents closebtn As Button
    Friend WithEvents Lblviewg As Label
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
    Friend WithEvents close_Btn As Button
    Friend WithEvents logoutbtn As Button
End Class
