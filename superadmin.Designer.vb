<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class superadmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Pnl_dashboard = New Panel()
        Panel2 = New Panel()
        lbl_superadminname = New Label()
        Lbl_currentadmin = New Label()
        logoutbtn = New Button()
        register_btn = New Button()
        vieuser_btn = New Button()
        admindashboard_btn = New Button()
        close_Btn = New Button()
        superadmindashboard_btn = New Button()
        minimise_btn = New Button()
        Pnl_dashboard.SuspendLayout()
        SuspendLayout()
        ' 
        ' Pnl_dashboard
        ' 
        Pnl_dashboard.BackColor = SystemColors.Control
        Pnl_dashboard.Controls.Add(Panel2)
        Pnl_dashboard.Location = New Point(240, 57)
        Pnl_dashboard.Name = "Pnl_dashboard"
        Pnl_dashboard.Size = New Size(1077, 777)
        Pnl_dashboard.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Window
        Panel2.Location = New Point(3, 153)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(0, 0)
        Panel2.TabIndex = 10
        ' 
        ' lbl_superadminname
        ' 
        lbl_superadminname.AutoSize = True
        lbl_superadminname.BackColor = Color.Transparent
        lbl_superadminname.FlatStyle = FlatStyle.Flat
        lbl_superadminname.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        lbl_superadminname.ForeColor = SystemColors.Window
        lbl_superadminname.Location = New Point(384, 18)
        lbl_superadminname.Name = "lbl_superadminname"
        lbl_superadminname.Size = New Size(177, 27)
        lbl_superadminname.TabIndex = 11
        lbl_superadminname.Text = "superadminname"
        lbl_superadminname.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Lbl_currentadmin
        ' 
        Lbl_currentadmin.AutoSize = True
        Lbl_currentadmin.BackColor = Color.Transparent
        Lbl_currentadmin.FlatStyle = FlatStyle.Flat
        Lbl_currentadmin.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        Lbl_currentadmin.ForeColor = SystemColors.Window
        Lbl_currentadmin.Location = New Point(240, 18)
        Lbl_currentadmin.Name = "Lbl_currentadmin"
        Lbl_currentadmin.Size = New Size(138, 27)
        Lbl_currentadmin.TabIndex = 10
        Lbl_currentadmin.Text = "Current User:"
        Lbl_currentadmin.TextAlign = ContentAlignment.TopCenter
        ' 
        ' logoutbtn
        ' 
        logoutbtn.BackColor = Color.Transparent
        logoutbtn.FlatAppearance.BorderColor = SystemColors.Control
        logoutbtn.FlatAppearance.BorderSize = 2
        logoutbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        logoutbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        logoutbtn.FlatStyle = FlatStyle.Flat
        logoutbtn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        logoutbtn.ForeColor = SystemColors.Window
        logoutbtn.Location = New Point(16, 776)
        logoutbtn.Name = "logoutbtn"
        logoutbtn.Size = New Size(205, 45)
        logoutbtn.TabIndex = 10
        logoutbtn.Text = "Log Out"
        logoutbtn.UseVisualStyleBackColor = False
        ' 
        ' register_btn
        ' 
        register_btn.BackColor = Color.Transparent
        register_btn.FlatAppearance.BorderColor = SystemColors.Window
        register_btn.FlatAppearance.BorderSize = 2
        register_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        register_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        register_btn.FlatStyle = FlatStyle.Flat
        register_btn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        register_btn.ForeColor = SystemColors.Window
        register_btn.Location = New Point(16, 303)
        register_btn.Name = "register_btn"
        register_btn.Size = New Size(205, 45)
        register_btn.TabIndex = 9
        register_btn.Text = "Register New User"
        register_btn.UseVisualStyleBackColor = False
        ' 
        ' vieuser_btn
        ' 
        vieuser_btn.BackColor = Color.Transparent
        vieuser_btn.FlatAppearance.BorderColor = SystemColors.Window
        vieuser_btn.FlatAppearance.BorderSize = 2
        vieuser_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        vieuser_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        vieuser_btn.FlatStyle = FlatStyle.Flat
        vieuser_btn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        vieuser_btn.ForeColor = SystemColors.Window
        vieuser_btn.Location = New Point(16, 354)
        vieuser_btn.Name = "vieuser_btn"
        vieuser_btn.Size = New Size(205, 45)
        vieuser_btn.TabIndex = 11
        vieuser_btn.Text = "View Users"
        vieuser_btn.UseVisualStyleBackColor = False
        ' 
        ' admindashboard_btn
        ' 
        admindashboard_btn.BackColor = Color.Transparent
        admindashboard_btn.FlatAppearance.BorderColor = SystemColors.Window
        admindashboard_btn.FlatAppearance.BorderSize = 2
        admindashboard_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        admindashboard_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        admindashboard_btn.FlatStyle = FlatStyle.Flat
        admindashboard_btn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        admindashboard_btn.ForeColor = SystemColors.Window
        admindashboard_btn.Location = New Point(16, 405)
        admindashboard_btn.Name = "admindashboard_btn"
        admindashboard_btn.Size = New Size(205, 45)
        admindashboard_btn.TabIndex = 13
        admindashboard_btn.Text = "Admin Dashboard"
        admindashboard_btn.UseVisualStyleBackColor = False
        ' 
        ' close_Btn
        ' 
        close_Btn.BackColor = Color.Transparent
        close_Btn.FlatAppearance.BorderColor = Color.White
        close_Btn.FlatAppearance.BorderSize = 2
        close_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        close_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        close_Btn.FlatStyle = FlatStyle.Flat
        close_Btn.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        close_Btn.ForeColor = SystemColors.Window
        close_Btn.Location = New Point(1270, 7)
        close_Btn.Name = "close_Btn"
        close_Btn.Size = New Size(42, 39)
        close_Btn.TabIndex = 25
        close_Btn.Text = "X"
        close_Btn.UseVisualStyleBackColor = False
        ' 
        ' superadmindashboard_btn
        ' 
        superadmindashboard_btn.BackColor = Color.Transparent
        superadmindashboard_btn.FlatAppearance.BorderColor = SystemColors.Window
        superadmindashboard_btn.FlatAppearance.BorderSize = 2
        superadmindashboard_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        superadmindashboard_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        superadmindashboard_btn.FlatStyle = FlatStyle.Flat
        superadmindashboard_btn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        superadmindashboard_btn.ForeColor = SystemColors.Window
        superadmindashboard_btn.Location = New Point(16, 252)
        superadmindashboard_btn.Name = "superadmindashboard_btn"
        superadmindashboard_btn.Size = New Size(205, 45)
        superadmindashboard_btn.TabIndex = 26
        superadmindashboard_btn.Text = "Dashboard"
        superadmindashboard_btn.UseVisualStyleBackColor = False
        ' 
        ' minimise_btn
        ' 
        minimise_btn.BackColor = Color.Transparent
        minimise_btn.FlatAppearance.BorderColor = Color.White
        minimise_btn.FlatAppearance.BorderSize = 2
        minimise_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        minimise_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        minimise_btn.FlatStyle = FlatStyle.Flat
        minimise_btn.Font = New Font("Perpetua Titling MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        minimise_btn.ForeColor = SystemColors.Window
        minimise_btn.Location = New Point(1216, 7)
        minimise_btn.Name = "minimise_btn"
        minimise_btn.Size = New Size(42, 39)
        minimise_btn.TabIndex = 30
        minimise_btn.Text = "-"
        minimise_btn.UseVisualStyleBackColor = False
        ' 
        ' superadmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        ClientSize = New Size(1317, 833)
        Controls.Add(minimise_btn)
        Controls.Add(superadmindashboard_btn)
        Controls.Add(close_Btn)
        Controls.Add(lbl_superadminname)
        Controls.Add(admindashboard_btn)
        Controls.Add(Lbl_currentadmin)
        Controls.Add(vieuser_btn)
        Controls.Add(logoutbtn)
        Controls.Add(register_btn)
        Controls.Add(Pnl_dashboard)
        ForeColor = Color.Transparent
        FormBorderStyle = FormBorderStyle.None
        Name = "superadmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Options"
        Pnl_dashboard.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents label1 As label
    Friend WithEvents Pnl_dashboard As Panel
    Friend WithEvents register_btn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents logoutbtn As Button
    Friend WithEvents lbl_superadminname As Label
    Friend WithEvents Lbl_currentadmin As Label
    Friend WithEvents vieuser_btn As Button
    Friend WithEvents admindashboard_btn As Button
    Friend WithEvents close_Btn As Button
    Friend WithEvents superadmindashboard_btn As Button
    Friend WithEvents minimise_btn As Button
End Class
