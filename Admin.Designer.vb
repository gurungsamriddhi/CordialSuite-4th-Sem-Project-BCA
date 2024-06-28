<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Pnl_admindashboard = New Panel()
        close_Btn = New Button()
        Labeladminname = New Label()
        Lbl_currentadmin = New Label()
        logoutbtn = New Button()
        dashboard_btn = New Button()
        transactionbtn = New Button()
        viewempbtn = New Button()
        roomsbtn = New Button()
        viewguestbtn = New Button()
        back_btn = New Button()
        SuspendLayout()
        ' 
        ' Pnl_admindashboard
        ' 
        Pnl_admindashboard.BackColor = SystemColors.Control
        Pnl_admindashboard.Location = New Point(240, 56)
        Pnl_admindashboard.Name = "Pnl_admindashboard"
        Pnl_admindashboard.Size = New Size(1077, 777)
        Pnl_admindashboard.TabIndex = 1
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
        close_Btn.Location = New Point(1265, 3)
        close_Btn.Name = "close_Btn"
        close_Btn.Size = New Size(48, 48)
        close_Btn.TabIndex = 25
        close_Btn.Text = "X"
        close_Btn.UseVisualStyleBackColor = False
        ' 
        ' Labeladminname
        ' 
        Labeladminname.AutoSize = True
        Labeladminname.BackColor = Color.Transparent
        Labeladminname.FlatStyle = FlatStyle.Flat
        Labeladminname.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        Labeladminname.ForeColor = SystemColors.Window
        Labeladminname.Location = New Point(384, 15)
        Labeladminname.Name = "Labeladminname"
        Labeladminname.Size = New Size(124, 27)
        Labeladminname.TabIndex = 11
        Labeladminname.Text = "adminname"
        Labeladminname.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Lbl_currentadmin
        ' 
        Lbl_currentadmin.AutoSize = True
        Lbl_currentadmin.BackColor = Color.Transparent
        Lbl_currentadmin.FlatStyle = FlatStyle.Flat
        Lbl_currentadmin.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        Lbl_currentadmin.ForeColor = SystemColors.Window
        Lbl_currentadmin.Location = New Point(240, 15)
        Lbl_currentadmin.Name = "Lbl_currentadmin"
        Lbl_currentadmin.Size = New Size(138, 27)
        Lbl_currentadmin.TabIndex = 10
        Lbl_currentadmin.Text = "Current User:"
        Lbl_currentadmin.TextAlign = ContentAlignment.TopCenter
        ' 
        ' logoutbtn
        ' 
        logoutbtn.BackColor = Color.Transparent
        logoutbtn.FlatAppearance.BorderColor = SystemColors.Window
        logoutbtn.FlatAppearance.BorderSize = 2
        logoutbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        logoutbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        logoutbtn.FlatStyle = FlatStyle.Flat
        logoutbtn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        logoutbtn.ForeColor = SystemColors.Window
        logoutbtn.Location = New Point(20, 776)
        logoutbtn.Name = "logoutbtn"
        logoutbtn.Size = New Size(205, 45)
        logoutbtn.TabIndex = 9
        logoutbtn.Text = "Log Out"
        logoutbtn.UseVisualStyleBackColor = False
        ' 
        ' dashboard_btn
        ' 
        dashboard_btn.BackColor = Color.Transparent
        dashboard_btn.FlatAppearance.BorderColor = SystemColors.Window
        dashboard_btn.FlatAppearance.BorderSize = 2
        dashboard_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        dashboard_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        dashboard_btn.FlatStyle = FlatStyle.Flat
        dashboard_btn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        dashboard_btn.ForeColor = SystemColors.Window
        dashboard_btn.Location = New Point(20, 225)
        dashboard_btn.Name = "dashboard_btn"
        dashboard_btn.Size = New Size(205, 45)
        dashboard_btn.TabIndex = 8
        dashboard_btn.Text = "Dashboard"
        dashboard_btn.UseVisualStyleBackColor = False
        ' 
        ' transactionbtn
        ' 
        transactionbtn.BackColor = Color.Transparent
        transactionbtn.FlatAppearance.BorderColor = SystemColors.Window
        transactionbtn.FlatAppearance.BorderSize = 2
        transactionbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        transactionbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        transactionbtn.FlatStyle = FlatStyle.Flat
        transactionbtn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        transactionbtn.ForeColor = SystemColors.Window
        transactionbtn.Location = New Point(20, 431)
        transactionbtn.Name = "transactionbtn"
        transactionbtn.Size = New Size(205, 45)
        transactionbtn.TabIndex = 7
        transactionbtn.Text = "Transaction"
        transactionbtn.UseVisualStyleBackColor = False
        ' 
        ' viewempbtn
        ' 
        viewempbtn.BackColor = Color.Transparent
        viewempbtn.FlatAppearance.BorderColor = SystemColors.Window
        viewempbtn.FlatAppearance.BorderSize = 2
        viewempbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        viewempbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        viewempbtn.FlatStyle = FlatStyle.Flat
        viewempbtn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        viewempbtn.ForeColor = SystemColors.Window
        viewempbtn.Location = New Point(20, 329)
        viewempbtn.Name = "viewempbtn"
        viewempbtn.Size = New Size(205, 45)
        viewempbtn.TabIndex = 6
        viewempbtn.Text = "View Employee"
        viewempbtn.UseVisualStyleBackColor = False
        ' 
        ' roomsbtn
        ' 
        roomsbtn.BackColor = Color.Transparent
        roomsbtn.FlatAppearance.BorderColor = SystemColors.Window
        roomsbtn.FlatAppearance.BorderSize = 2
        roomsbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        roomsbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        roomsbtn.FlatStyle = FlatStyle.Flat
        roomsbtn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        roomsbtn.ForeColor = SystemColors.Window
        roomsbtn.Location = New Point(20, 380)
        roomsbtn.Name = "roomsbtn"
        roomsbtn.Size = New Size(205, 45)
        roomsbtn.TabIndex = 5
        roomsbtn.Text = "Rooms"
        roomsbtn.UseVisualStyleBackColor = False
        ' 
        ' viewguestbtn
        ' 
        viewguestbtn.BackColor = Color.Transparent
        viewguestbtn.FlatAppearance.BorderColor = SystemColors.Window
        viewguestbtn.FlatAppearance.BorderSize = 2
        viewguestbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        viewguestbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        viewguestbtn.FlatStyle = FlatStyle.Flat
        viewguestbtn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        viewguestbtn.ForeColor = SystemColors.Window
        viewguestbtn.Location = New Point(20, 277)
        viewguestbtn.Name = "viewguestbtn"
        viewguestbtn.Size = New Size(205, 45)
        viewguestbtn.TabIndex = 3
        viewguestbtn.Text = "View Guest"
        viewguestbtn.UseVisualStyleBackColor = False
        ' 
        ' back_btn
        ' 
        back_btn.BackColor = Color.Transparent
        back_btn.FlatAppearance.BorderColor = SystemColors.Window
        back_btn.FlatAppearance.BorderSize = 2
        back_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        back_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        back_btn.FlatStyle = FlatStyle.Flat
        back_btn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        back_btn.ForeColor = SystemColors.Window
        back_btn.Location = New Point(20, 712)
        back_btn.Name = "back_btn"
        back_btn.Size = New Size(205, 45)
        back_btn.TabIndex = 26
        back_btn.Text = "Back"
        back_btn.UseVisualStyleBackColor = False
        back_btn.Visible = False
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(170))
        ClientSize = New Size(1317, 833)
        Controls.Add(back_btn)
        Controls.Add(Labeladminname)
        Controls.Add(close_Btn)
        Controls.Add(Lbl_currentadmin)
        Controls.Add(logoutbtn)
        Controls.Add(transactionbtn)
        Controls.Add(Pnl_admindashboard)
        Controls.Add(roomsbtn)
        Controls.Add(viewempbtn)
        Controls.Add(dashboard_btn)
        Controls.Add(viewguestbtn)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminDashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Pnl_admindashboard As Panel
    Friend WithEvents Labeladminname As Label
    Friend WithEvents Lbl_currentadmin As Label
    Friend WithEvents logoutbtn As Button
    Friend WithEvents dashboard_btn As Button
    Friend WithEvents transactionbtn As Button
    Friend WithEvents viewempbtn As Button
    Friend WithEvents roomsbtn As Button
    Friend WithEvents viewguestbtn As Button
    Friend WithEvents close_Btn As Button
    Friend WithEvents back_btn As Button
End Class
