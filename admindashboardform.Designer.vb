<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admindashboardform
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
        Pnl_users = New Panel()
        lbl_nusersshow = New Label()
        users_lbl = New Label()
        Pnl_Rooms = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Lbl_roomsavailable = New Label()
        Lbl_roomsreserved = New Label()
        Lbl_totrooms = New Label()
        Lbl_nroomsshow = New Label()
        rooms_lbl = New Label()
        Pnl_guests = New Panel()
        lbl_nmaleshow = New Label()
        Lbl_nfemaleshow = New Label()
        Lbl_maleguests = New Label()
        Lbl_femaleguests = New Label()
        Lbl_totguests = New Label()
        Lbl_totguestshow = New Label()
        guests_lbl = New Label()
        pnl_roomsales = New Panel()
        Lbl_nadminsshow = New Label()
        roomsales_lbl = New Label()
        Lbl_admindashboard = New Label()
        Pnl_users.SuspendLayout()
        Pnl_Rooms.SuspendLayout()
        Pnl_guests.SuspendLayout()
        pnl_roomsales.SuspendLayout()
        SuspendLayout()
        ' 
        ' Pnl_users
        ' 
        Pnl_users.BackColor = Color.FromArgb(CByte(31), CByte(160), CByte(180))
        Pnl_users.Controls.Add(lbl_nusersshow)
        Pnl_users.Controls.Add(users_lbl)
        Pnl_users.Location = New Point(666, 109)
        Pnl_users.Name = "Pnl_users"
        Pnl_users.Size = New Size(296, 236)
        Pnl_users.TabIndex = 43
        ' 
        ' lbl_nusersshow
        ' 
        lbl_nusersshow.AutoSize = True
        lbl_nusersshow.BackColor = Color.Transparent
        lbl_nusersshow.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_nusersshow.ForeColor = SystemColors.ControlLightLight
        lbl_nusersshow.Location = New Point(139, 60)
        lbl_nusersshow.Name = "lbl_nusersshow"
        lbl_nusersshow.Size = New Size(27, 31)
        lbl_nusersshow.TabIndex = 3
        lbl_nusersshow.Text = "3"
        ' 
        ' users_lbl
        ' 
        users_lbl.AutoSize = True
        users_lbl.BackColor = Color.Transparent
        users_lbl.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        users_lbl.ForeColor = SystemColors.HighlightText
        users_lbl.Location = New Point(82, 17)
        users_lbl.Name = "users_lbl"
        users_lbl.Size = New Size(134, 31)
        users_lbl.TabIndex = 1
        users_lbl.Text = "Total users:"
        ' 
        ' Pnl_Rooms
        ' 
        Pnl_Rooms.BackColor = Color.FromArgb(CByte(31), CByte(150), CByte(190))
        Pnl_Rooms.Controls.Add(Label4)
        Pnl_Rooms.Controls.Add(Label3)
        Pnl_Rooms.Controls.Add(Lbl_roomsavailable)
        Pnl_Rooms.Controls.Add(Lbl_roomsreserved)
        Pnl_Rooms.Controls.Add(Lbl_totrooms)
        Pnl_Rooms.Controls.Add(Lbl_nroomsshow)
        Pnl_Rooms.Controls.Add(rooms_lbl)
        Pnl_Rooms.Location = New Point(132, 109)
        Pnl_Rooms.Name = "Pnl_Rooms"
        Pnl_Rooms.Size = New Size(296, 236)
        Pnl_Rooms.TabIndex = 44
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(237, 185)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 31)
        Label4.TabIndex = 9
        Label4.Text = "12"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(237, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 31)
        Label3.TabIndex = 8
        Label3.Text = "12"
        ' 
        ' Lbl_roomsavailable
        ' 
        Lbl_roomsavailable.AutoSize = True
        Lbl_roomsavailable.BackColor = Color.Transparent
        Lbl_roomsavailable.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_roomsavailable.ForeColor = SystemColors.HighlightText
        Lbl_roomsavailable.Location = New Point(23, 185)
        Lbl_roomsavailable.Name = "Lbl_roomsavailable"
        Lbl_roomsavailable.Size = New Size(192, 31)
        Lbl_roomsavailable.TabIndex = 5
        Lbl_roomsavailable.Text = "Rooms Available:"
        ' 
        ' Lbl_roomsreserved
        ' 
        Lbl_roomsreserved.AutoSize = True
        Lbl_roomsreserved.BackColor = Color.Transparent
        Lbl_roomsreserved.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_roomsreserved.ForeColor = SystemColors.HighlightText
        Lbl_roomsreserved.Location = New Point(23, 127)
        Lbl_roomsreserved.Name = "Lbl_roomsreserved"
        Lbl_roomsreserved.Size = New Size(192, 31)
        Lbl_roomsreserved.TabIndex = 4
        Lbl_roomsreserved.Text = "Rooms Reserved:"
        ' 
        ' Lbl_totrooms
        ' 
        Lbl_totrooms.AutoSize = True
        Lbl_totrooms.BackColor = Color.Transparent
        Lbl_totrooms.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_totrooms.ForeColor = SystemColors.HighlightText
        Lbl_totrooms.Location = New Point(23, 71)
        Lbl_totrooms.Name = "Lbl_totrooms"
        Lbl_totrooms.Size = New Size(148, 31)
        Lbl_totrooms.TabIndex = 3
        Lbl_totrooms.Text = "Total Rooms:"
        ' 
        ' Lbl_nroomsshow
        ' 
        Lbl_nroomsshow.AutoSize = True
        Lbl_nroomsshow.BackColor = Color.Transparent
        Lbl_nroomsshow.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_nroomsshow.ForeColor = SystemColors.ControlLightLight
        Lbl_nroomsshow.Location = New Point(237, 71)
        Lbl_nroomsshow.Name = "Lbl_nroomsshow"
        Lbl_nroomsshow.Size = New Size(36, 31)
        Lbl_nroomsshow.TabIndex = 2
        Lbl_nroomsshow.Text = "12"
        ' 
        ' rooms_lbl
        ' 
        rooms_lbl.AutoSize = True
        rooms_lbl.BackColor = Color.Transparent
        rooms_lbl.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rooms_lbl.ForeColor = SystemColors.HighlightText
        rooms_lbl.Location = New Point(106, 17)
        rooms_lbl.Name = "rooms_lbl"
        rooms_lbl.Size = New Size(87, 31)
        rooms_lbl.TabIndex = 1
        rooms_lbl.Text = "Rooms"
        ' 
        ' Pnl_guests
        ' 
        Pnl_guests.BackColor = Color.FromArgb(CByte(20), CByte(150), CByte(150))
        Pnl_guests.Controls.Add(lbl_nmaleshow)
        Pnl_guests.Controls.Add(Lbl_nfemaleshow)
        Pnl_guests.Controls.Add(Lbl_maleguests)
        Pnl_guests.Controls.Add(Lbl_femaleguests)
        Pnl_guests.Controls.Add(Lbl_totguests)
        Pnl_guests.Controls.Add(Lbl_totguestshow)
        Pnl_guests.Controls.Add(guests_lbl)
        Pnl_guests.Location = New Point(132, 414)
        Pnl_guests.Name = "Pnl_guests"
        Pnl_guests.Size = New Size(296, 229)
        Pnl_guests.TabIndex = 45
        ' 
        ' lbl_nmaleshow
        ' 
        lbl_nmaleshow.AutoSize = True
        lbl_nmaleshow.BackColor = Color.Transparent
        lbl_nmaleshow.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_nmaleshow.ForeColor = SystemColors.ControlLightLight
        lbl_nmaleshow.Location = New Point(249, 184)
        lbl_nmaleshow.Name = "lbl_nmaleshow"
        lbl_nmaleshow.Size = New Size(27, 31)
        lbl_nmaleshow.TabIndex = 10
        lbl_nmaleshow.Text = "5"
        ' 
        ' Lbl_nfemaleshow
        ' 
        Lbl_nfemaleshow.AutoSize = True
        Lbl_nfemaleshow.BackColor = Color.Transparent
        Lbl_nfemaleshow.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_nfemaleshow.ForeColor = SystemColors.ControlLightLight
        Lbl_nfemaleshow.Location = New Point(249, 123)
        Lbl_nfemaleshow.Name = "Lbl_nfemaleshow"
        Lbl_nfemaleshow.Size = New Size(27, 31)
        Lbl_nfemaleshow.TabIndex = 9
        Lbl_nfemaleshow.Text = "5"
        ' 
        ' Lbl_maleguests
        ' 
        Lbl_maleguests.AutoSize = True
        Lbl_maleguests.BackColor = Color.Transparent
        Lbl_maleguests.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_maleguests.ForeColor = SystemColors.HighlightText
        Lbl_maleguests.Location = New Point(29, 184)
        Lbl_maleguests.Name = "Lbl_maleguests"
        Lbl_maleguests.Size = New Size(71, 31)
        Lbl_maleguests.TabIndex = 8
        Lbl_maleguests.Text = "Male:"
        ' 
        ' Lbl_femaleguests
        ' 
        Lbl_femaleguests.AutoSize = True
        Lbl_femaleguests.BackColor = Color.Transparent
        Lbl_femaleguests.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_femaleguests.ForeColor = SystemColors.HighlightText
        Lbl_femaleguests.Location = New Point(28, 123)
        Lbl_femaleguests.Name = "Lbl_femaleguests"
        Lbl_femaleguests.Size = New Size(94, 31)
        Lbl_femaleguests.TabIndex = 7
        Lbl_femaleguests.Text = "Female:"
        ' 
        ' Lbl_totguests
        ' 
        Lbl_totguests.AutoSize = True
        Lbl_totguests.BackColor = Color.Transparent
        Lbl_totguests.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_totguests.ForeColor = SystemColors.HighlightText
        Lbl_totguests.Location = New Point(28, 63)
        Lbl_totguests.Name = "Lbl_totguests"
        Lbl_totguests.Size = New Size(146, 31)
        Lbl_totguests.TabIndex = 6
        Lbl_totguests.Text = "Total Guests:"
        ' 
        ' Lbl_totguestshow
        ' 
        Lbl_totguestshow.AutoSize = True
        Lbl_totguestshow.BackColor = Color.Transparent
        Lbl_totguestshow.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_totguestshow.ForeColor = SystemColors.ControlLightLight
        Lbl_totguestshow.Location = New Point(249, 63)
        Lbl_totguestshow.Name = "Lbl_totguestshow"
        Lbl_totguestshow.Size = New Size(27, 31)
        Lbl_totguestshow.TabIndex = 1
        Lbl_totguestshow.Text = "5"
        ' 
        ' guests_lbl
        ' 
        guests_lbl.AutoSize = True
        guests_lbl.BackColor = Color.Transparent
        guests_lbl.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        guests_lbl.ForeColor = SystemColors.HighlightText
        guests_lbl.Location = New Point(108, 10)
        guests_lbl.Name = "guests_lbl"
        guests_lbl.Size = New Size(85, 31)
        guests_lbl.TabIndex = 1
        guests_lbl.Text = "Guests"
        ' 
        ' pnl_roomsales
        ' 
        pnl_roomsales.BackColor = Color.FromArgb(CByte(30), CByte(110), CByte(150))
        pnl_roomsales.Controls.Add(Lbl_nadminsshow)
        pnl_roomsales.Controls.Add(roomsales_lbl)
        pnl_roomsales.ForeColor = SystemColors.GradientActiveCaption
        pnl_roomsales.Location = New Point(666, 400)
        pnl_roomsales.Name = "pnl_roomsales"
        pnl_roomsales.Size = New Size(296, 229)
        pnl_roomsales.TabIndex = 46
        ' 
        ' Lbl_nadminsshow
        ' 
        Lbl_nadminsshow.AutoSize = True
        Lbl_nadminsshow.BackColor = Color.Transparent
        Lbl_nadminsshow.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_nadminsshow.ForeColor = SystemColors.ControlLightLight
        Lbl_nadminsshow.Location = New Point(73, 61)
        Lbl_nadminsshow.Name = "Lbl_nadminsshow"
        Lbl_nadminsshow.Size = New Size(0, 31)
        Lbl_nadminsshow.TabIndex = 3
        ' 
        ' roomsales_lbl
        ' 
        roomsales_lbl.AutoSize = True
        roomsales_lbl.BackColor = Color.Transparent
        roomsales_lbl.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        roomsales_lbl.ForeColor = SystemColors.HighlightText
        roomsales_lbl.Location = New Point(82, 12)
        roomsales_lbl.Name = "roomsales_lbl"
        roomsales_lbl.Size = New Size(143, 31)
        roomsales_lbl.TabIndex = 0
        roomsales_lbl.Text = "Room Sales:"
        ' 
        ' Lbl_admindashboard
        ' 
        Lbl_admindashboard.AutoSize = True
        Lbl_admindashboard.BackColor = Color.Transparent
        Lbl_admindashboard.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_admindashboard.ForeColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Lbl_admindashboard.Location = New Point(416, 20)
        Lbl_admindashboard.Name = "Lbl_admindashboard"
        Lbl_admindashboard.Size = New Size(244, 31)
        Lbl_admindashboard.TabIndex = 47
        Lbl_admindashboard.Text = "ADMIN DASHBOARD"
        ' 
        ' admindashboardform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1077, 777)
        Controls.Add(Lbl_admindashboard)
        Controls.Add(pnl_roomsales)
        Controls.Add(Pnl_guests)
        Controls.Add(Pnl_Rooms)
        Controls.Add(Pnl_users)
        FormBorderStyle = FormBorderStyle.None
        Name = "admindashboardform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "admindashboardform"
        Pnl_users.ResumeLayout(False)
        Pnl_users.PerformLayout()
        Pnl_Rooms.ResumeLayout(False)
        Pnl_Rooms.PerformLayout()
        Pnl_guests.ResumeLayout(False)
        Pnl_guests.PerformLayout()
        pnl_roomsales.ResumeLayout(False)
        pnl_roomsales.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Pnl_users As Panel
    Friend WithEvents lbl_nusersshow As Label
    Friend WithEvents users_lbl As Label
    Friend WithEvents Pnl_Rooms As Panel
    Friend WithEvents Lbl_nroomsshow As Label
    Friend WithEvents rooms_lbl As Label
    Friend WithEvents Pnl_guests As Panel
    Friend WithEvents Lbl_totguestshow As Label
    Friend WithEvents guests_lbl As Label
    Friend WithEvents Lbl_roomsavailable As Label
    Friend WithEvents Lbl_roomsreserved As Label
    Friend WithEvents Lbl_totrooms As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_nmaleshow As Label
    Friend WithEvents Lbl_nfemaleshow As Label
    Friend WithEvents Lbl_maleguests As Label
    Friend WithEvents Lbl_femaleguests As Label
    Friend WithEvents Lbl_totguests As Label
    Friend WithEvents pnl_roomsales As Panel
    Friend WithEvents Lbl_nadminsshow As Label
    Friend WithEvents roomsales_lbl As Label
    Friend WithEvents Lbl_admindashboard As Label
End Class
