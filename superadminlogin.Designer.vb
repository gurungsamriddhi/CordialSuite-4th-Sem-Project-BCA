<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class superadmin_login
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
        lbl_password = New Label()
        txtbx_adminpassword = New TextBox()
        showpw_checkbx = New CheckBox()
        adminlogin_btn = New Button()
        lbllink_cancel = New LinkLabel()
        closebtn = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        txtbx_adminusername = New TextBox()
        Lblusername = New Label()
        minimise_btn = New Button()
        SuspendLayout()
        ' 
        ' lbl_password
        ' 
        lbl_password.AutoSize = True
        lbl_password.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_password.ForeColor = Color.White
        lbl_password.Location = New Point(145, 261)
        lbl_password.Name = "lbl_password"
        lbl_password.Size = New Size(97, 28)
        lbl_password.TabIndex = 2
        lbl_password.Text = "Password"
        ' 
        ' txtbx_adminpassword
        ' 
        txtbx_adminpassword.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbx_adminpassword.Location = New Point(145, 293)
        txtbx_adminpassword.Margin = New Padding(3, 4, 3, 4)
        txtbx_adminpassword.Name = "txtbx_adminpassword"
        txtbx_adminpassword.Size = New Size(359, 38)
        txtbx_adminpassword.TabIndex = 4
        txtbx_adminpassword.UseSystemPasswordChar = True
        ' 
        ' showpw_checkbx
        ' 
        showpw_checkbx.AutoSize = True
        showpw_checkbx.BackColor = Color.Transparent
        showpw_checkbx.FlatAppearance.CheckedBackColor = SystemColors.InactiveCaption
        showpw_checkbx.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        showpw_checkbx.ForeColor = Color.White
        showpw_checkbx.Location = New Point(145, 345)
        showpw_checkbx.Name = "showpw_checkbx"
        showpw_checkbx.Size = New Size(170, 32)
        showpw_checkbx.TabIndex = 8
        showpw_checkbx.Text = "Show password"
        showpw_checkbx.UseVisualStyleBackColor = False
        ' 
        ' adminlogin_btn
        ' 
        adminlogin_btn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        adminlogin_btn.FlatAppearance.BorderColor = SystemColors.Window
        adminlogin_btn.FlatAppearance.BorderSize = 2
        adminlogin_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        adminlogin_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        adminlogin_btn.FlatStyle = FlatStyle.Flat
        adminlogin_btn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        adminlogin_btn.ForeColor = SystemColors.ControlLightLight
        adminlogin_btn.Location = New Point(242, 444)
        adminlogin_btn.Margin = New Padding(3, 4, 3, 4)
        adminlogin_btn.Name = "adminlogin_btn"
        adminlogin_btn.Size = New Size(183, 45)
        adminlogin_btn.TabIndex = 9
        adminlogin_btn.Text = "Login"
        adminlogin_btn.UseVisualStyleBackColor = False
        ' 
        ' lbllink_cancel
        ' 
        lbllink_cancel.ActiveLinkColor = Color.Pink
        lbllink_cancel.AutoSize = True
        lbllink_cancel.DisabledLinkColor = Color.Silver
        lbllink_cancel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbllink_cancel.LinkColor = SystemColors.Window
        lbllink_cancel.Location = New Point(290, 493)
        lbllink_cancel.Name = "lbllink_cancel"
        lbllink_cancel.Size = New Size(69, 28)
        lbllink_cancel.TabIndex = 10
        lbllink_cancel.TabStop = True
        lbllink_cancel.Text = "Cancel"
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.Transparent
        closebtn.FlatAppearance.BorderColor = Color.White
        closebtn.FlatAppearance.BorderSize = 2
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = SystemColors.Window
        closebtn.Location = New Point(572, 12)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(42, 39)
        closebtn.TabIndex = 11
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Window
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(23, 539)
        Panel1.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(145, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(246, 31)
        Label1.TabIndex = 13
        Label1.Text = "SUPER ADMIN LOGIN"
        ' 
        ' txtbx_adminusername
        ' 
        txtbx_adminusername.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbx_adminusername.Location = New Point(146, 177)
        txtbx_adminusername.Margin = New Padding(3, 4, 3, 4)
        txtbx_adminusername.Name = "txtbx_adminusername"
        txtbx_adminusername.Size = New Size(359, 38)
        txtbx_adminusername.TabIndex = 15
        ' 
        ' Lblusername
        ' 
        Lblusername.AutoSize = True
        Lblusername.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblusername.ForeColor = Color.White
        Lblusername.Location = New Point(145, 142)
        Lblusername.Margin = New Padding(3)
        Lblusername.Name = "Lblusername"
        Lblusername.Size = New Size(104, 28)
        Lblusername.TabIndex = 14
        Lblusername.Text = "Username"
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
        minimise_btn.Location = New Point(515, 12)
        minimise_btn.Name = "minimise_btn"
        minimise_btn.Size = New Size(42, 39)
        minimise_btn.TabIndex = 29
        minimise_btn.Text = "-"
        minimise_btn.UseVisualStyleBackColor = False
        ' 
        ' superadmin_login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        ClientSize = New Size(627, 539)
        Controls.Add(minimise_btn)
        Controls.Add(txtbx_adminusername)
        Controls.Add(Lblusername)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(closebtn)
        Controls.Add(lbllink_cancel)
        Controls.Add(adminlogin_btn)
        Controls.Add(showpw_checkbx)
        Controls.Add(txtbx_adminpassword)
        Controls.Add(lbl_password)
        ForeColor = SystemColors.Window
        FormBorderStyle = FormBorderStyle.None
        Name = "superadmin_login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "superadminlogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_password As Label
    Friend WithEvents txtbx_adminpassword As TextBox
    Friend WithEvents showpw_checkbx As CheckBox
    Friend WithEvents adminlogin_btn As Button
    Friend WithEvents lbllink_cancel As LinkLabel
    Friend WithEvents closebtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbx_adminusername As TextBox
    Friend WithEvents Lblusername As Label
    Friend WithEvents minimise_btn As Button
End Class
