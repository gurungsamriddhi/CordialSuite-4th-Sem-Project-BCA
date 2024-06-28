<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usersmodel
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
        Pnl_userdashboard = New Panel()
        Lbl_currentuser = New Label()
        closebtn = New Button()
        Labelusername = New Label()
        logoutbtn = New Button()
        dashboard_btn = New Button()
        checkout_btn = New Button()
        checkin_btn = New Button()
        rooms_btn = New Button()
        billing_btn = New Button()
        guest_btn = New Button()
        SuspendLayout()
        ' 
        ' Pnl_userdashboard
        ' 
        Pnl_userdashboard.BackColor = SystemColors.Control
        Pnl_userdashboard.Location = New Point(240, 56)
        Pnl_userdashboard.Name = "Pnl_userdashboard"
        Pnl_userdashboard.Size = New Size(1077, 777)
        Pnl_userdashboard.TabIndex = 0
        ' 
        ' Lbl_currentuser
        ' 
        Lbl_currentuser.AutoSize = True
        Lbl_currentuser.BackColor = Color.Transparent
        Lbl_currentuser.FlatStyle = FlatStyle.Flat
        Lbl_currentuser.Font = New Font("Segoe UI Emoji", 12.0F, FontStyle.Bold)
        Lbl_currentuser.ForeColor = SystemColors.ControlLightLight
        Lbl_currentuser.Location = New Point(240, 13)
        Lbl_currentuser.Name = "Lbl_currentuser"
        Lbl_currentuser.Size = New Size(138, 27)
        Lbl_currentuser.TabIndex = 10
        Lbl_currentuser.Text = "Current User:"
        Lbl_currentuser.TextAlign = ContentAlignment.TopCenter
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.Transparent
        closebtn.FlatAppearance.BorderColor = SystemColors.Control
        closebtn.FlatAppearance.BorderSize = 2
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = SystemColors.Control
        closebtn.Location = New Point(1261, 5)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(48, 42)
        closebtn.TabIndex = 12
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Labelusername
        ' 
        Labelusername.AutoSize = True
        Labelusername.BackColor = Color.Transparent
        Labelusername.FlatStyle = FlatStyle.Flat
        Labelusername.Font = New Font("Segoe UI Emoji", 12.0F, FontStyle.Bold)
        Labelusername.ForeColor = SystemColors.ControlLightLight
        Labelusername.Location = New Point(384, 13)
        Labelusername.Name = "Labelusername"
        Labelusername.Size = New Size(104, 27)
        Labelusername.TabIndex = 11
        Labelusername.Text = "username"
        Labelusername.TextAlign = ContentAlignment.TopCenter
        ' 
        ' logoutbtn
        ' 
        logoutbtn.BackColor = Color.Transparent
        logoutbtn.FlatAppearance.BorderColor = SystemColors.Control
        logoutbtn.FlatAppearance.BorderSize = 2
        logoutbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        logoutbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        logoutbtn.FlatStyle = FlatStyle.Flat
        logoutbtn.Font = New Font("Segoe UI Emoji", 12.0F, FontStyle.Bold)
        logoutbtn.ForeColor = SystemColors.Window
        logoutbtn.Location = New Point(21, 776)
        logoutbtn.Name = "logoutbtn"
        logoutbtn.Size = New Size(204, 45)
        logoutbtn.TabIndex = 9
        logoutbtn.Text = "Log Out"
        logoutbtn.UseVisualStyleBackColor = False
        ' 
        ' dashboard_btn
        ' 
        dashboard_btn.BackColor = Color.Transparent
        dashboard_btn.FlatAppearance.BorderColor = SystemColors.Control
        dashboard_btn.FlatAppearance.BorderSize = 2
        dashboard_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        dashboard_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        dashboard_btn.FlatStyle = FlatStyle.Flat
        dashboard_btn.Font = New Font("Segoe UI Emoji", 12.0F, FontStyle.Bold)
        dashboard_btn.ForeColor = SystemColors.Control
        dashboard_btn.Location = New Point(19, 212)
        dashboard_btn.Name = "dashboard_btn"
        dashboard_btn.Size = New Size(205, 45)
        dashboard_btn.TabIndex = 8
        dashboard_btn.Text = "Dashboard"
        dashboard_btn.UseVisualStyleBackColor = False
        ' 
        ' checkout_btn
        ' 
        checkout_btn.BackColor = Color.Transparent
        checkout_btn.FlatAppearance.BorderColor = SystemColors.Control
        checkout_btn.FlatAppearance.BorderSize = 2
        checkout_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        checkout_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        checkout_btn.FlatStyle = FlatStyle.Flat
        checkout_btn.Font = New Font("Segoe UI Emoji", 12.0F, FontStyle.Bold)
        checkout_btn.ForeColor = SystemColors.Control
        checkout_btn.Location = New Point(19, 416)
        checkout_btn.Name = "checkout_btn"
        checkout_btn.Size = New Size(205, 45)
        checkout_btn.TabIndex = 7
        checkout_btn.Text = "Check-out"
        checkout_btn.UseVisualStyleBackColor = False
        ' 
        ' checkin_btn
        ' 
        checkin_btn.BackColor = Color.Transparent
        checkin_btn.FlatAppearance.BorderColor = SystemColors.Control
        checkin_btn.FlatAppearance.BorderSize = 2
        checkin_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        checkin_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        checkin_btn.FlatStyle = FlatStyle.Flat
        checkin_btn.Font = New Font("Segoe UI Emoji", 12.0F, FontStyle.Bold)
        checkin_btn.ForeColor = SystemColors.Control
        checkin_btn.Location = New Point(20, 314)
        checkin_btn.Name = "checkin_btn"
        checkin_btn.Size = New Size(205, 45)
        checkin_btn.TabIndex = 6
        checkin_btn.Text = "Check-in"
        checkin_btn.UseVisualStyleBackColor = False
        ' 
        ' rooms_btn
        ' 
        rooms_btn.BackColor = Color.Transparent
        rooms_btn.FlatAppearance.BorderColor = SystemColors.Control
        rooms_btn.FlatAppearance.BorderSize = 2
        rooms_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        rooms_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        rooms_btn.FlatStyle = FlatStyle.Flat
        rooms_btn.Font = New Font("Segoe UI Emoji", 12.0F, FontStyle.Bold)
        rooms_btn.ForeColor = SystemColors.Control
        rooms_btn.Location = New Point(20, 365)
        rooms_btn.Name = "rooms_btn"
        rooms_btn.Size = New Size(205, 45)
        rooms_btn.TabIndex = 5
        rooms_btn.Text = "Rooms"
        rooms_btn.UseVisualStyleBackColor = False
        ' 
        ' billing_btn
        ' 
        billing_btn.BackColor = Color.Transparent
        billing_btn.FlatAppearance.BorderColor = SystemColors.Control
        billing_btn.FlatAppearance.BorderSize = 2
        billing_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        billing_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        billing_btn.FlatStyle = FlatStyle.Flat
        billing_btn.Font = New Font("Segoe UI Emoji", 12.0F, FontStyle.Bold)
        billing_btn.ForeColor = SystemColors.Control
        billing_btn.Location = New Point(20, 467)
        billing_btn.Name = "billing_btn"
        billing_btn.Size = New Size(205, 45)
        billing_btn.TabIndex = 4
        billing_btn.Text = "Billing"
        billing_btn.UseVisualStyleBackColor = False
        ' 
        ' guest_btn
        ' 
        guest_btn.BackColor = Color.Transparent
        guest_btn.FlatAppearance.BorderColor = SystemColors.Control
        guest_btn.FlatAppearance.BorderSize = 2
        guest_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        guest_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        guest_btn.FlatStyle = FlatStyle.Flat
        guest_btn.Font = New Font("Segoe UI Emoji", 12.0F, FontStyle.Bold)
        guest_btn.ForeColor = SystemColors.Control
        guest_btn.Location = New Point(19, 262)
        guest_btn.Name = "guest_btn"
        guest_btn.Size = New Size(205, 45)
        guest_btn.TabIndex = 3
        guest_btn.Text = " Guest"
        guest_btn.UseVisualStyleBackColor = False
        ' 
        ' User
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        ClientSize = New Size(1317, 833)
        Controls.Add(closebtn)
        Controls.Add(Lbl_currentuser)
        Controls.Add(Labelusername)
        Controls.Add(billing_btn)
        Controls.Add(logoutbtn)
        Controls.Add(checkout_btn)
        Controls.Add(dashboard_btn)
        Controls.Add(rooms_btn)
        Controls.Add(checkin_btn)
        Controls.Add(Pnl_userdashboard)
        Controls.Add(guest_btn)
        FormBorderStyle = FormBorderStyle.None
        Name = "User"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Userdashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Pnl_userdashboard As Panel
    Friend WithEvents dashboard_btn As Button
    Friend WithEvents checkout_btn As Button
    Friend WithEvents checkin_btn As Button
    Friend WithEvents rooms_btn As Button
    Friend WithEvents billing_btn As Button
    Friend WithEvents guest_btn As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents logoutbtn As Button
    Friend WithEvents Lbl_currentuser As Label
    Friend WithEvents Labelusername As Label
    Friend WithEvents closebtn As Button
End Class