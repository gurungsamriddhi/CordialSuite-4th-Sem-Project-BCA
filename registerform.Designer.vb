<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registerform
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
        LblFirstname = New Label()
        LblDOB = New Label()
        LblConfirmpw = New Label()
        LblAddress = New Label()
        LblPhonenumber = New Label()
        LblUsertype = New Label()
        LblGender = New Label()
        LblUsername = New Label()
        LblPassword = New Label()
        Pnlregister = New Panel()
        Linktologin = New LinkLabel()
        closebtn = New Button()
        userDOB_dtp = New DateTimePicker()
        usertype_cmbbx = New ComboBox()
        gender_cmbbx = New ComboBox()
        userln_txtbx = New TextBox()
        userAddress_txtbx = New TextBox()
        userPhone_txtbx = New TextBox()
        username_txtbx = New TextBox()
        password_txtbx = New TextBox()
        confirmpw_txtbx = New TextBox()
        Registerbtn = New Button()
        userfn_txtbx = New TextBox()
        LblLastname = New Label()
        Pnlregister.SuspendLayout()
        SuspendLayout()
        ' 
        ' LblFirstname
        ' 
        LblFirstname.AutoSize = True
        LblFirstname.BackColor = Color.Transparent
        LblFirstname.FlatStyle = FlatStyle.Flat
        LblFirstname.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LblFirstname.ForeColor = SystemColors.ControlLightLight
        LblFirstname.Location = New Point(191, 78)
        LblFirstname.Name = "LblFirstname"
        LblFirstname.Size = New Size(93, 23)
        LblFirstname.TabIndex = 0
        LblFirstname.Text = "First Name"
        LblFirstname.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblDOB
        ' 
        LblDOB.AutoSize = True
        LblDOB.FlatStyle = FlatStyle.Flat
        LblDOB.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LblDOB.ForeColor = SystemColors.ControlLightLight
        LblDOB.Location = New Point(576, 151)
        LblDOB.Name = "LblDOB"
        LblDOB.Size = New Size(108, 23)
        LblDOB.TabIndex = 1
        LblDOB.Text = "Date of Birth"
        LblDOB.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblConfirmpw
        ' 
        LblConfirmpw.AutoSize = True
        LblConfirmpw.FlatStyle = FlatStyle.Flat
        LblConfirmpw.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LblConfirmpw.ForeColor = SystemColors.ControlLightLight
        LblConfirmpw.Location = New Point(576, 379)
        LblConfirmpw.Name = "LblConfirmpw"
        LblConfirmpw.Size = New Size(149, 23)
        LblConfirmpw.TabIndex = 2
        LblConfirmpw.Text = "Confirm Password"
        LblConfirmpw.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAddress
        ' 
        LblAddress.AutoSize = True
        LblAddress.FlatStyle = FlatStyle.Flat
        LblAddress.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LblAddress.ForeColor = SystemColors.ControlLightLight
        LblAddress.Location = New Point(189, 151)
        LblAddress.Name = "LblAddress"
        LblAddress.Size = New Size(70, 23)
        LblAddress.TabIndex = 3
        LblAddress.Text = "Address"
        LblAddress.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblPhonenumber
        ' 
        LblPhonenumber.AutoSize = True
        LblPhonenumber.FlatStyle = FlatStyle.Flat
        LblPhonenumber.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LblPhonenumber.ForeColor = SystemColors.ControlLightLight
        LblPhonenumber.ImageAlign = ContentAlignment.TopRight
        LblPhonenumber.Location = New Point(576, 225)
        LblPhonenumber.Name = "LblPhonenumber"
        LblPhonenumber.Size = New Size(119, 23)
        LblPhonenumber.TabIndex = 4
        LblPhonenumber.Text = "Phonenumber"
        LblPhonenumber.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblUsertype
        ' 
        LblUsertype.AutoSize = True
        LblUsertype.FlatStyle = FlatStyle.Flat
        LblUsertype.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LblUsertype.ForeColor = SystemColors.ControlLightLight
        LblUsertype.Location = New Point(576, 303)
        LblUsertype.Name = "LblUsertype"
        LblUsertype.Size = New Size(85, 23)
        LblUsertype.TabIndex = 5
        LblUsertype.Text = "User Type"
        LblUsertype.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblGender
        ' 
        LblGender.AutoSize = True
        LblGender.FlatStyle = FlatStyle.Flat
        LblGender.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LblGender.ForeColor = SystemColors.ControlLightLight
        LblGender.Location = New Point(189, 225)
        LblGender.Name = "LblGender"
        LblGender.Size = New Size(66, 23)
        LblGender.TabIndex = 6
        LblGender.Text = "Gender"
        LblGender.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblUsername
        ' 
        LblUsername.AutoSize = True
        LblUsername.FlatStyle = FlatStyle.Flat
        LblUsername.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LblUsername.ForeColor = SystemColors.ControlLightLight
        LblUsername.Location = New Point(191, 303)
        LblUsername.Name = "LblUsername"
        LblUsername.Size = New Size(87, 23)
        LblUsername.TabIndex = 7
        LblUsername.Text = "Username"
        LblUsername.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblPassword
        ' 
        LblPassword.AutoSize = True
        LblPassword.FlatStyle = FlatStyle.Flat
        LblPassword.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LblPassword.ForeColor = SystemColors.ControlLightLight
        LblPassword.Location = New Point(189, 379)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(82, 23)
        LblPassword.TabIndex = 8
        LblPassword.Text = "Password"
        LblPassword.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Pnlregister
        ' 
        Pnlregister.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(70))
        Pnlregister.Controls.Add(Linktologin)
        Pnlregister.Controls.Add(closebtn)
        Pnlregister.Controls.Add(userDOB_dtp)
        Pnlregister.Controls.Add(usertype_cmbbx)
        Pnlregister.Controls.Add(gender_cmbbx)
        Pnlregister.Controls.Add(userln_txtbx)
        Pnlregister.Controls.Add(userAddress_txtbx)
        Pnlregister.Controls.Add(userPhone_txtbx)
        Pnlregister.Controls.Add(username_txtbx)
        Pnlregister.Controls.Add(password_txtbx)
        Pnlregister.Controls.Add(confirmpw_txtbx)
        Pnlregister.Controls.Add(Registerbtn)
        Pnlregister.Controls.Add(userfn_txtbx)
        Pnlregister.Controls.Add(LblLastname)
        Pnlregister.Controls.Add(LblPassword)
        Pnlregister.Controls.Add(LblUsername)
        Pnlregister.Controls.Add(LblGender)
        Pnlregister.Controls.Add(LblUsertype)
        Pnlregister.Controls.Add(LblPhonenumber)
        Pnlregister.Controls.Add(LblAddress)
        Pnlregister.Controls.Add(LblConfirmpw)
        Pnlregister.Controls.Add(LblDOB)
        Pnlregister.Controls.Add(LblFirstname)
        Pnlregister.Dock = DockStyle.Fill
        Pnlregister.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Pnlregister.Location = New Point(0, 0)
        Pnlregister.Name = "Pnlregister"
        Pnlregister.Size = New Size(970, 590)
        Pnlregister.TabIndex = 0
        ' 
        ' Linktologin
        ' 
        Linktologin.ActiveLinkColor = Color.DeepPink
        Linktologin.AutoSize = True
        Linktologin.BackColor = Color.Transparent
        Linktologin.DisabledLinkColor = Color.Purple
        Linktologin.Font = New Font("Segoe UI", 9.0F)
        Linktologin.ForeColor = SystemColors.ControlLightLight
        Linktologin.LinkColor = SystemColors.ControlLightLight
        Linktologin.Location = New Point(400, 544)
        Linktologin.Name = "Linktologin"
        Linktologin.Size = New Size(207, 20)
        Linktologin.TabIndex = 28
        Linktologin.TabStop = True
        Linktologin.Text = "Alredy have an account?Login"
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.Transparent
        closebtn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        closebtn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = SystemColors.ControlLightLight
        closebtn.Location = New Point(911, 12)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(47, 34)
        closebtn.TabIndex = 26
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' userDOB_dtp
        ' 
        userDOB_dtp.CalendarFont = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        userDOB_dtp.CalendarForeColor = SystemColors.GradientInactiveCaption
        userDOB_dtp.CalendarMonthBackground = SystemColors.GradientInactiveCaption
        userDOB_dtp.CalendarTitleBackColor = SystemColors.GradientActiveCaption
        userDOB_dtp.CalendarTitleForeColor = SystemColors.GradientInactiveCaption
        userDOB_dtp.CalendarTrailingForeColor = SystemColors.GradientInactiveCaption
        userDOB_dtp.Font = New Font("Segoe UI", 10.2F)
        userDOB_dtp.Format = DateTimePickerFormat.Short
        userDOB_dtp.Location = New Point(576, 178)
        userDOB_dtp.Name = "userDOB_dtp"
        userDOB_dtp.Size = New Size(235, 30)
        userDOB_dtp.TabIndex = 25
        ' 
        ' usertype_cmbbx
        ' 
        usertype_cmbbx.BackColor = SystemColors.Menu
        usertype_cmbbx.FlatStyle = FlatStyle.System
        usertype_cmbbx.Font = New Font("Segoe UI", 10.2F)
        usertype_cmbbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        usertype_cmbbx.FormattingEnabled = True
        usertype_cmbbx.Items.AddRange(New Object() {"Admin", "User"})
        usertype_cmbbx.Location = New Point(576, 325)
        usertype_cmbbx.Name = "usertype_cmbbx"
        usertype_cmbbx.Size = New Size(235, 31)
        usertype_cmbbx.TabIndex = 22
        ' 
        ' gender_cmbbx
        ' 
        gender_cmbbx.AutoCompleteCustomSource.AddRange(New String() {"Female", "Male", "Others"})
        gender_cmbbx.BackColor = SystemColors.Menu
        gender_cmbbx.FlatStyle = FlatStyle.System
        gender_cmbbx.Font = New Font("Segoe UI", 10.2F)
        gender_cmbbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        gender_cmbbx.FormattingEnabled = True
        gender_cmbbx.Items.AddRange(New Object() {"Female", "Male", "Others"})
        gender_cmbbx.Location = New Point(191, 251)
        gender_cmbbx.Name = "gender_cmbbx"
        gender_cmbbx.Size = New Size(235, 31)
        gender_cmbbx.TabIndex = 21
        ' 
        ' userln_txtbx
        ' 
        userln_txtbx.BackColor = SystemColors.ControlLightLight
        userln_txtbx.Font = New Font("Segoe UI", 10.2F)
        userln_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        userln_txtbx.Location = New Point(576, 103)
        userln_txtbx.Name = "userln_txtbx"
        userln_txtbx.Size = New Size(235, 30)
        userln_txtbx.TabIndex = 20
        ' 
        ' userAddress_txtbx
        ' 
        userAddress_txtbx.BackColor = SystemColors.ControlLightLight
        userAddress_txtbx.Font = New Font("Segoe UI", 10.2F)
        userAddress_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        userAddress_txtbx.Location = New Point(191, 177)
        userAddress_txtbx.Name = "userAddress_txtbx"
        userAddress_txtbx.Size = New Size(235, 30)
        userAddress_txtbx.TabIndex = 19
        ' 
        ' userPhone_txtbx
        ' 
        userPhone_txtbx.BackColor = SystemColors.ControlLightLight
        userPhone_txtbx.Font = New Font("Segoe UI", 10.2F)
        userPhone_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        userPhone_txtbx.Location = New Point(576, 251)
        userPhone_txtbx.Name = "userPhone_txtbx"
        userPhone_txtbx.Size = New Size(235, 30)
        userPhone_txtbx.TabIndex = 17
        ' 
        ' username_txtbx
        ' 
        username_txtbx.BackColor = SystemColors.ControlLightLight
        username_txtbx.Font = New Font("Segoe UI", 10.2F)
        username_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        username_txtbx.Location = New Point(191, 329)
        username_txtbx.Name = "username_txtbx"
        username_txtbx.Size = New Size(235, 30)
        username_txtbx.TabIndex = 16
        ' 
        ' password_txtbx
        ' 
        password_txtbx.BackColor = SystemColors.ControlLightLight
        password_txtbx.Font = New Font("Segoe UI", 10.2F)
        password_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        password_txtbx.Location = New Point(191, 404)
        password_txtbx.Name = "password_txtbx"
        password_txtbx.Size = New Size(235, 30)
        password_txtbx.TabIndex = 15
        ' 
        ' confirmpw_txtbx
        ' 
        confirmpw_txtbx.BackColor = SystemColors.ControlLightLight
        confirmpw_txtbx.Font = New Font("Segoe UI", 10.2F)
        confirmpw_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        confirmpw_txtbx.Location = New Point(576, 405)
        confirmpw_txtbx.Name = "confirmpw_txtbx"
        confirmpw_txtbx.Size = New Size(235, 30)
        confirmpw_txtbx.TabIndex = 14
        ' 
        ' Registerbtn
        ' 
        Registerbtn.BackColor = SystemColors.ControlLightLight
        Registerbtn.FlatAppearance.BorderColor = SystemColors.GradientActiveCaption
        Registerbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Registerbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Registerbtn.FlatStyle = FlatStyle.Flat
        Registerbtn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Registerbtn.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Registerbtn.Location = New Point(392, 478)
        Registerbtn.Name = "Registerbtn"
        Registerbtn.Size = New Size(215, 47)
        Registerbtn.TabIndex = 11
        Registerbtn.Text = "Register"
        Registerbtn.UseVisualStyleBackColor = False
        ' 
        ' userfn_txtbx
        ' 
        userfn_txtbx.BackColor = SystemColors.ControlLightLight
        userfn_txtbx.Font = New Font("Segoe UI", 10.2F)
        userfn_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        userfn_txtbx.Location = New Point(191, 103)
        userfn_txtbx.Name = "userfn_txtbx"
        userfn_txtbx.Size = New Size(235, 30)
        userfn_txtbx.TabIndex = 10
        ' 
        ' LblLastname
        ' 
        LblLastname.AutoSize = True
        LblLastname.FlatStyle = FlatStyle.Flat
        LblLastname.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LblLastname.ForeColor = SystemColors.ControlLightLight
        LblLastname.Location = New Point(576, 78)
        LblLastname.Name = "LblLastname"
        LblLastname.Size = New Size(91, 23)
        LblLastname.TabIndex = 9
        LblLastname.Text = "Last Name"
        LblLastname.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Registerform
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.Disable
        BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        ClientSize = New Size(970, 590)
        Controls.Add(Pnlregister)
        FormBorderStyle = FormBorderStyle.None
        Name = "Registerform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registration"
        Pnlregister.ResumeLayout(False)
        Pnlregister.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LblFirstname As Label
    Friend WithEvents LblDOB As Label
    Friend WithEvents LblConfirmpw As Label
    Friend WithEvents LblAddress As Label
    Friend WithEvents LblPhonenumber As Label
    Friend WithEvents LblUsertype As Label
    Friend WithEvents LblGender As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents Pnlregister As Panel
    Friend WithEvents LblLastname As Label
    Friend WithEvents userfn_txtbx As TextBox
    Friend WithEvents Registerbtn As Button
    Friend WithEvents gender_cmbbx As ComboBox
    Friend WithEvents userln_txtbx As TextBox
    Friend WithEvents userAddress_txtbx As TextBox
    Friend WithEvents userPhone_txtbx As TextBox
    Friend WithEvents username_txtbx As TextBox
    Friend WithEvents password_txtbx As TextBox
    Friend WithEvents usertype_cmbbx As ComboBox
    Friend WithEvents userDOB_dtp As DateTimePicker
    Friend WithEvents confirmpw_txtbx As TextBox
    Friend WithEvents closebtn As Button
    Friend WithEvents Linktologin As LinkLabel
End Class
