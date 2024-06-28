<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class superadmindashboardform
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
        Lbl_registeruser = New Label()
        pnl_Admin = New Panel()
        Lbl_nadminsshow = New Label()
        admin_lbl = New Label()
        Pnl_users = New Panel()
        lbl_nusershow = New Label()
        users_lbl = New Label()
        Pnl_Rooms = New Panel()
        Lbl_nroomsshow = New Label()
        rooms_lbl = New Label()
        Pnl_totguests = New Panel()
        Lbl_totguestshow = New Label()
        totguests_lbl = New Label()
        pnl_Admin.SuspendLayout()
        Pnl_users.SuspendLayout()
        Pnl_Rooms.SuspendLayout()
        Pnl_totguests.SuspendLayout()
        SuspendLayout()
        ' 
        ' Lbl_registeruser
        ' 
        Lbl_registeruser.AutoSize = True
        Lbl_registeruser.BackColor = Color.Transparent
        Lbl_registeruser.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_registeruser.ForeColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Lbl_registeruser.Location = New Point(387, 27)
        Lbl_registeruser.Name = "Lbl_registeruser"
        Lbl_registeruser.Size = New Size(315, 31)
        Lbl_registeruser.TabIndex = 40
        Lbl_registeruser.Text = "SUPERADMIN DASHBOARD"
        ' 
        ' pnl_Admin
        ' 
        pnl_Admin.BackColor = Color.FromArgb(CByte(30), CByte(110), CByte(150))
        pnl_Admin.Controls.Add(Lbl_nadminsshow)
        pnl_Admin.Controls.Add(admin_lbl)
        pnl_Admin.ForeColor = SystemColors.GradientActiveCaption
        pnl_Admin.Location = New Point(179, 161)
        pnl_Admin.Name = "pnl_Admin"
        pnl_Admin.Size = New Size(250, 125)
        pnl_Admin.TabIndex = 41
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
        ' admin_lbl
        ' 
        admin_lbl.AutoSize = True
        admin_lbl.BackColor = Color.Transparent
        admin_lbl.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        admin_lbl.ForeColor = SystemColors.HighlightText
        admin_lbl.Location = New Point(73, 12)
        admin_lbl.Name = "admin_lbl"
        admin_lbl.Size = New Size(92, 31)
        admin_lbl.TabIndex = 0
        admin_lbl.Text = "Admin:"
        ' 
        ' Pnl_users
        ' 
        Pnl_users.BackColor = Color.FromArgb(CByte(31), CByte(160), CByte(180))
        Pnl_users.Controls.Add(lbl_nusershow)
        Pnl_users.Controls.Add(users_lbl)
        Pnl_users.Location = New Point(667, 161)
        Pnl_users.Name = "Pnl_users"
        Pnl_users.Size = New Size(250, 125)
        Pnl_users.TabIndex = 42
        ' 
        ' lbl_nusershow
        ' 
        lbl_nusershow.AutoSize = True
        lbl_nusershow.BackColor = Color.Transparent
        lbl_nusershow.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_nusershow.ForeColor = SystemColors.ControlLightLight
        lbl_nusershow.Location = New Point(75, 61)
        lbl_nusershow.Name = "lbl_nusershow"
        lbl_nusershow.Size = New Size(0, 31)
        lbl_nusershow.TabIndex = 3
        ' 
        ' users_lbl
        ' 
        users_lbl.AutoSize = True
        users_lbl.BackColor = Color.Transparent
        users_lbl.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        users_lbl.ForeColor = SystemColors.HighlightText
        users_lbl.Location = New Point(87, 4)
        users_lbl.Name = "users_lbl"
        users_lbl.Size = New Size(69, 31)
        users_lbl.TabIndex = 1
        users_lbl.Text = "User:"
        ' 
        ' Pnl_Rooms
        ' 
        Pnl_Rooms.BackColor = Color.FromArgb(CByte(31), CByte(150), CByte(190))
        Pnl_Rooms.Controls.Add(Lbl_nroomsshow)
        Pnl_Rooms.Controls.Add(rooms_lbl)
        Pnl_Rooms.Location = New Point(179, 431)
        Pnl_Rooms.Name = "Pnl_Rooms"
        Pnl_Rooms.Size = New Size(250, 125)
        Pnl_Rooms.TabIndex = 43
        ' 
        ' Lbl_nroomsshow
        ' 
        Lbl_nroomsshow.AutoSize = True
        Lbl_nroomsshow.BackColor = Color.Transparent
        Lbl_nroomsshow.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_nroomsshow.ForeColor = SystemColors.ControlLightLight
        Lbl_nroomsshow.Location = New Point(73, 65)
        Lbl_nroomsshow.Name = "Lbl_nroomsshow"
        Lbl_nroomsshow.Size = New Size(0, 31)
        Lbl_nroomsshow.TabIndex = 2
        ' 
        ' rooms_lbl
        ' 
        rooms_lbl.AutoSize = True
        rooms_lbl.BackColor = Color.Transparent
        rooms_lbl.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rooms_lbl.ForeColor = SystemColors.HighlightText
        rooms_lbl.Location = New Point(16, 13)
        rooms_lbl.Name = "rooms_lbl"
        rooms_lbl.Size = New Size(219, 31)
        rooms_lbl.TabIndex = 1
        rooms_lbl.Text = "Total No of Rooms:"
        ' 
        ' Pnl_totguests
        ' 
        Pnl_totguests.BackColor = Color.FromArgb(CByte(20), CByte(150), CByte(150))
        Pnl_totguests.Controls.Add(Lbl_totguestshow)
        Pnl_totguests.Controls.Add(totguests_lbl)
        Pnl_totguests.Location = New Point(667, 431)
        Pnl_totguests.Name = "Pnl_totguests"
        Pnl_totguests.Size = New Size(250, 125)
        Pnl_totguests.TabIndex = 44
        ' 
        ' Lbl_totguestshow
        ' 
        Lbl_totguestshow.AutoSize = True
        Lbl_totguestshow.BackColor = Color.Transparent
        Lbl_totguestshow.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_totguestshow.ForeColor = SystemColors.ControlLightLight
        Lbl_totguestshow.Location = New Point(75, 63)
        Lbl_totguestshow.Name = "Lbl_totguestshow"
        Lbl_totguestshow.Size = New Size(0, 31)
        Lbl_totguestshow.TabIndex = 1
        ' 
        ' totguests_lbl
        ' 
        totguests_lbl.AutoSize = True
        totguests_lbl.BackColor = Color.Transparent
        totguests_lbl.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        totguests_lbl.ForeColor = SystemColors.HighlightText
        totguests_lbl.Location = New Point(8, 11)
        totguests_lbl.Name = "totguests_lbl"
        totguests_lbl.Size = New Size(227, 31)
        totguests_lbl.TabIndex = 1
        totguests_lbl.Text = "Total Guests visited:"
        ' 
        ' superadmindashboardform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1077, 777)
        Controls.Add(Pnl_totguests)
        Controls.Add(Pnl_Rooms)
        Controls.Add(Pnl_users)
        Controls.Add(pnl_Admin)
        Controls.Add(Lbl_registeruser)
        FormBorderStyle = FormBorderStyle.None
        Name = "superadmindashboardform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "superadmindashboardform"
        pnl_Admin.ResumeLayout(False)
        pnl_Admin.PerformLayout()
        Pnl_users.ResumeLayout(False)
        Pnl_users.PerformLayout()
        Pnl_Rooms.ResumeLayout(False)
        Pnl_Rooms.PerformLayout()
        Pnl_totguests.ResumeLayout(False)
        Pnl_totguests.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_registeruser As Label
    Friend WithEvents pnl_Admin As Panel
    Friend WithEvents Pnl_users As Panel
    Friend WithEvents admin_lbl As Label
    Friend WithEvents users_lbl As Label
    Friend WithEvents Pnl_Rooms As Panel
    Friend WithEvents rooms_lbl As Label
    Friend WithEvents Pnl_totguests As Panel
    Friend WithEvents totguests_lbl As Label
    Friend WithEvents Lbl_nadminsshow As Label
    Friend WithEvents lbl_nusershow As Label
    Friend WithEvents Lbl_nroomsshow As Label
    Friend WithEvents Lbl_totguestshow As Label
End Class
