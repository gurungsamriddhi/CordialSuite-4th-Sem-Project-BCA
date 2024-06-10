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
        Pnl_diffform = New Panel()
        Panel1 = New Panel()
        Lbl_currentuser = New Label()
        Labelusername = New Label()
        logoutbtn = New Button()
        closebtn = New Button()
        statusbtn = New Button()
        checkoutbtn = New Button()
        checkinbtn = New Button()
        roomsbtn = New Button()
        billingbtn = New Button()
        addguestbtn = New Button()
        Pnl_diffform.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Pnl_diffform
        ' 
        Pnl_diffform.BackColor = SystemColors.Control
        Pnl_diffform.Controls.Add(Panel1)
        Pnl_diffform.Controls.Add(logoutbtn)
        Pnl_diffform.Controls.Add(closebtn)
        Pnl_diffform.Dock = DockStyle.Right
        Pnl_diffform.Location = New Point(252, 0)
        Pnl_diffform.Name = "Pnl_diffform"
        Pnl_diffform.Size = New Size(948, 750)
        Pnl_diffform.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Panel1.Controls.Add(Lbl_currentuser)
        Panel1.Controls.Add(Labelusername)
        Panel1.Location = New Point(0, 68)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(948, 99)
        Panel1.TabIndex = 15
        ' 
        ' Lbl_currentuser
        ' 
        Lbl_currentuser.AutoSize = True
        Lbl_currentuser.BackColor = Color.Transparent
        Lbl_currentuser.FlatStyle = FlatStyle.Flat
        Lbl_currentuser.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        Lbl_currentuser.ForeColor = SystemColors.ControlLightLight
        Lbl_currentuser.Location = New Point(3, 24)
        Lbl_currentuser.Name = "Lbl_currentuser"
        Lbl_currentuser.Size = New Size(138, 27)
        Lbl_currentuser.TabIndex = 10
        Lbl_currentuser.Text = "Current User:"
        Lbl_currentuser.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Labelusername
        ' 
        Labelusername.AutoSize = True
        Labelusername.BackColor = Color.Transparent
        Labelusername.FlatStyle = FlatStyle.Flat
        Labelusername.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        Labelusername.ForeColor = SystemColors.ControlLightLight
        Labelusername.Location = New Point(147, 24)
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
        logoutbtn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        logoutbtn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        logoutbtn.FlatStyle = FlatStyle.Flat
        logoutbtn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        logoutbtn.ForeColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        logoutbtn.Location = New Point(774, 5)
        logoutbtn.Name = "logoutbtn"
        logoutbtn.Size = New Size(120, 39)
        logoutbtn.TabIndex = 9
        logoutbtn.Text = "Log Out"
        logoutbtn.UseVisualStyleBackColor = False
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.Transparent
        closebtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        closebtn.FlatAppearance.BorderSize = 2
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        closebtn.Location = New Point(900, 5)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(43, 42)
        closebtn.TabIndex = 12
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' statusbtn
        ' 
        statusbtn.BackColor = Color.Transparent
        statusbtn.FlatAppearance.BorderColor = SystemColors.Control
        statusbtn.FlatAppearance.BorderSize = 2
        statusbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        statusbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        statusbtn.FlatStyle = FlatStyle.Flat
        statusbtn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        statusbtn.ForeColor = SystemColors.Control
        statusbtn.Location = New Point(19, 171)
        statusbtn.Name = "statusbtn"
        statusbtn.Size = New Size(205, 45)
        statusbtn.TabIndex = 8
        statusbtn.Text = "Hotel Status"
        statusbtn.UseVisualStyleBackColor = False
        ' 
        ' checkoutbtn
        ' 
        checkoutbtn.BackColor = Color.Transparent
        checkoutbtn.FlatAppearance.BorderColor = SystemColors.Control
        checkoutbtn.FlatAppearance.BorderSize = 2
        checkoutbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        checkoutbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        checkoutbtn.FlatStyle = FlatStyle.Flat
        checkoutbtn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        checkoutbtn.ForeColor = SystemColors.Control
        checkoutbtn.Location = New Point(19, 407)
        checkoutbtn.Name = "checkoutbtn"
        checkoutbtn.Size = New Size(205, 45)
        checkoutbtn.TabIndex = 7
        checkoutbtn.Text = "Check-out"
        checkoutbtn.UseVisualStyleBackColor = False
        ' 
        ' checkinbtn
        ' 
        checkinbtn.BackColor = Color.Transparent
        checkinbtn.FlatAppearance.BorderColor = SystemColors.Control
        checkinbtn.FlatAppearance.BorderSize = 2
        checkinbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        checkinbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        checkinbtn.FlatStyle = FlatStyle.Flat
        checkinbtn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        checkinbtn.ForeColor = SystemColors.Control
        checkinbtn.Location = New Point(20, 289)
        checkinbtn.Name = "checkinbtn"
        checkinbtn.Size = New Size(205, 45)
        checkinbtn.TabIndex = 6
        checkinbtn.Text = "Check-in"
        checkinbtn.UseVisualStyleBackColor = False
        ' 
        ' roomsbtn
        ' 
        roomsbtn.BackColor = Color.Transparent
        roomsbtn.FlatAppearance.BorderColor = SystemColors.Control
        roomsbtn.FlatAppearance.BorderSize = 2
        roomsbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        roomsbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        roomsbtn.FlatStyle = FlatStyle.Flat
        roomsbtn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        roomsbtn.ForeColor = SystemColors.Control
        roomsbtn.Location = New Point(20, 348)
        roomsbtn.Name = "roomsbtn"
        roomsbtn.Size = New Size(205, 45)
        roomsbtn.TabIndex = 5
        roomsbtn.Text = "Rooms"
        roomsbtn.UseVisualStyleBackColor = False
        ' 
        ' billingbtn
        ' 
        billingbtn.BackColor = Color.Transparent
        billingbtn.FlatAppearance.BorderColor = SystemColors.Control
        billingbtn.FlatAppearance.BorderSize = 2
        billingbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        billingbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        billingbtn.FlatStyle = FlatStyle.Flat
        billingbtn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        billingbtn.ForeColor = SystemColors.Control
        billingbtn.Location = New Point(20, 466)
        billingbtn.Name = "billingbtn"
        billingbtn.Size = New Size(205, 45)
        billingbtn.TabIndex = 4
        billingbtn.Text = "Billing"
        billingbtn.UseVisualStyleBackColor = False
        ' 
        ' addguestbtn
        ' 
        addguestbtn.BackColor = Color.Transparent
        addguestbtn.FlatAppearance.BorderColor = SystemColors.Control
        addguestbtn.FlatAppearance.BorderSize = 2
        addguestbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        addguestbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        addguestbtn.FlatStyle = FlatStyle.Flat
        addguestbtn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        addguestbtn.ForeColor = SystemColors.Control
        addguestbtn.Location = New Point(19, 229)
        addguestbtn.Name = "addguestbtn"
        addguestbtn.Size = New Size(205, 45)
        addguestbtn.TabIndex = 3
        addguestbtn.Text = "Add Guest"
        addguestbtn.UseVisualStyleBackColor = False
        ' 
        ' userdashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        ClientSize = New Size(1200, 750)
        Controls.Add(billingbtn)
        Controls.Add(checkoutbtn)
        Controls.Add(statusbtn)
        Controls.Add(roomsbtn)
        Controls.Add(checkinbtn)
        Controls.Add(Pnl_diffform)
        Controls.Add(addguestbtn)
        FormBorderStyle = FormBorderStyle.None
        Name = "userdashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Userdashboard"
        Pnl_diffform.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Pnl_diffform As Panel
    Friend WithEvents statusbtn As Button
    Friend WithEvents checkoutbtn As Button
    Friend WithEvents checkinbtn As Button
    Friend WithEvents roomsbtn As Button
    Friend WithEvents billingbtn As Button
    Friend WithEvents addguestbtn As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents logoutbtn As Button
    Friend WithEvents Lbl_currentuser As Label
    Friend WithEvents Labelusername As Label
    Friend WithEvents closebtn As Button
    Friend WithEvents Panel1 As Panel
End Class