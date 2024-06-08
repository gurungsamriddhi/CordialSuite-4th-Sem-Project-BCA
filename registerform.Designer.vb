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
        Lbl_msggender = New Label()
        Lbl_msgaddress = New Label()
        Lbl_msgDOB = New Label()
        Lbl_msglastname = New Label()
        Lbl_msgphone = New Label()
        Lbl_msgconfirmpw = New Label()
        Lbl_msgpassword = New Label()
        Lbl_msgusername = New Label()
        Lbl_msgusertype = New Label()
        Lbl_msgfirstname = New Label()
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
        LblFirstname.Location = New Point(191, 48)
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
        LblDOB.Location = New Point(576, 136)
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
        LblConfirmpw.Location = New Point(576, 407)
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
        LblAddress.Location = New Point(189, 136)
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
        LblPhonenumber.Location = New Point(576, 222)
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
        LblUsertype.Location = New Point(576, 313)
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
        LblGender.Location = New Point(189, 222)
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
        LblUsername.Location = New Point(189, 313)
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
        LblPassword.Location = New Point(189, 407)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(82, 23)
        LblPassword.TabIndex = 8
        LblPassword.Text = "Password"
        LblPassword.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Pnlregister
        ' 
        Pnlregister.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Pnlregister.Controls.Add(Lbl_msggender)
        Pnlregister.Controls.Add(Lbl_msgaddress)
        Pnlregister.Controls.Add(Lbl_msgDOB)
        Pnlregister.Controls.Add(Lbl_msglastname)
        Pnlregister.Controls.Add(Lbl_msgphone)
        Pnlregister.Controls.Add(Lbl_msgconfirmpw)
        Pnlregister.Controls.Add(Lbl_msgpassword)
        Pnlregister.Controls.Add(Lbl_msgusername)
        Pnlregister.Controls.Add(Lbl_msgusertype)
        Pnlregister.Controls.Add(Lbl_msgfirstname)
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
        ' Lbl_msggender
        ' 
        Lbl_msggender.AutoSize = True
        Lbl_msggender.ForeColor = SystemColors.ControlLightLight
        Lbl_msggender.Location = New Point(189, 274)
        Lbl_msggender.Name = "Lbl_msggender"
        Lbl_msggender.Size = New Size(0, 20)
        Lbl_msggender.TabIndex = 38
        ' 
        ' Lbl_msgaddress
        ' 
        Lbl_msgaddress.AutoSize = True
        Lbl_msgaddress.ForeColor = SystemColors.ControlLightLight
        Lbl_msgaddress.Location = New Point(191, 187)
        Lbl_msgaddress.Name = "Lbl_msgaddress"
        Lbl_msgaddress.Size = New Size(0, 20)
        Lbl_msgaddress.TabIndex = 37
        ' 
        ' Lbl_msgDOB
        ' 
        Lbl_msgDOB.AutoSize = True
        Lbl_msgDOB.ForeColor = SystemColors.ControlLightLight
        Lbl_msgDOB.Location = New Point(576, 187)
        Lbl_msgDOB.Name = "Lbl_msgDOB"
        Lbl_msgDOB.Size = New Size(0, 20)
        Lbl_msgDOB.TabIndex = 36
        ' 
        ' Lbl_msglastname
        ' 
        Lbl_msglastname.AutoSize = True
        Lbl_msglastname.ForeColor = SystemColors.ControlLightLight
        Lbl_msglastname.Location = New Point(576, 100)
        Lbl_msglastname.Name = "Lbl_msglastname"
        Lbl_msglastname.Size = New Size(0, 20)
        Lbl_msglastname.TabIndex = 35
        ' 
        ' Lbl_msgphone
        ' 
        Lbl_msgphone.AutoSize = True
        Lbl_msgphone.ForeColor = SystemColors.ControlLightLight
        Lbl_msgphone.Location = New Point(576, 274)
        Lbl_msgphone.Name = "Lbl_msgphone"
        Lbl_msgphone.Size = New Size(0, 20)
        Lbl_msgphone.TabIndex = 34
        ' 
        ' Lbl_msgconfirmpw
        ' 
        Lbl_msgconfirmpw.AutoSize = True
        Lbl_msgconfirmpw.ForeColor = SystemColors.ControlLightLight
        Lbl_msgconfirmpw.Location = New Point(576, 460)
        Lbl_msgconfirmpw.Name = "Lbl_msgconfirmpw"
        Lbl_msgconfirmpw.Size = New Size(0, 20)
        Lbl_msgconfirmpw.TabIndex = 33
        ' 
        ' Lbl_msgpassword
        ' 
        Lbl_msgpassword.AutoSize = True
        Lbl_msgpassword.ForeColor = SystemColors.ControlLightLight
        Lbl_msgpassword.Location = New Point(189, 460)
        Lbl_msgpassword.Name = "Lbl_msgpassword"
        Lbl_msgpassword.Size = New Size(0, 20)
        Lbl_msgpassword.TabIndex = 32
        ' 
        ' Lbl_msgusername
        ' 
        Lbl_msgusername.AutoSize = True
        Lbl_msgusername.ForeColor = SystemColors.ControlLightLight
        Lbl_msgusername.Location = New Point(191, 366)
        Lbl_msgusername.Name = "Lbl_msgusername"
        Lbl_msgusername.Size = New Size(0, 20)
        Lbl_msgusername.TabIndex = 31
        ' 
        ' Lbl_msgusertype
        ' 
        Lbl_msgusertype.AutoSize = True
        Lbl_msgusertype.ForeColor = SystemColors.ControlLightLight
        Lbl_msgusertype.Location = New Point(576, 366)
        Lbl_msgusertype.Name = "Lbl_msgusertype"
        Lbl_msgusertype.Size = New Size(0, 20)
        Lbl_msgusertype.TabIndex = 30
        ' 
        ' Lbl_msgfirstname
        ' 
        Lbl_msgfirstname.AutoSize = True
        Lbl_msgfirstname.ForeColor = SystemColors.ControlLightLight
        Lbl_msgfirstname.Location = New Point(191, 100)
        Lbl_msgfirstname.Name = "Lbl_msgfirstname"
        Lbl_msgfirstname.Size = New Size(0, 20)
        Lbl_msgfirstname.TabIndex = 29
        ' 
        ' Linktologin
        ' 
        Linktologin.ActiveLinkColor = Color.DeepPink
        Linktologin.AutoSize = True
        Linktologin.BackColor = Color.Transparent
        Linktologin.DisabledLinkColor = Color.Purple
        Linktologin.Font = New Font("Segoe UI", 9F)
        Linktologin.ForeColor = SystemColors.ControlLightLight
        Linktologin.LinkColor = SystemColors.ControlLightLight
        Linktologin.Location = New Point(392, 550)
        Linktologin.Name = "Linktologin"
        Linktologin.Size = New Size(215, 20)
        Linktologin.TabIndex = 28
        Linktologin.TabStop = True
        Linktologin.Text = "Already have an account?Login"
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.Transparent
        closebtn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        closebtn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        userDOB_dtp.Location = New Point(576, 158)
        userDOB_dtp.MaxDate = New Date(2025, 1, 1, 0, 0, 0, 0)
        userDOB_dtp.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        userDOB_dtp.Name = "userDOB_dtp"
        userDOB_dtp.Size = New Size(235, 30)
        userDOB_dtp.TabIndex = 25
        userDOB_dtp.Value = New Date(2024, 6, 5, 0, 0, 0, 0)
        ' 
        ' usertype_cmbbx
        ' 
        usertype_cmbbx.BackColor = SystemColors.Menu
        usertype_cmbbx.FlatStyle = FlatStyle.System
        usertype_cmbbx.Font = New Font("Segoe UI", 10.2F)
        usertype_cmbbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        usertype_cmbbx.FormattingEnabled = True
        usertype_cmbbx.Items.AddRange(New Object() {"Admin", "User"})
        usertype_cmbbx.Location = New Point(576, 336)
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
        gender_cmbbx.Location = New Point(191, 244)
        gender_cmbbx.Name = "gender_cmbbx"
        gender_cmbbx.Size = New Size(235, 31)
        gender_cmbbx.TabIndex = 21
        ' 
        ' userln_txtbx
        ' 
        userln_txtbx.BackColor = SystemColors.ControlLightLight
        userln_txtbx.Font = New Font("Segoe UI", 10.2F)
        userln_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        userln_txtbx.Location = New Point(576, 70)
        userln_txtbx.Name = "userln_txtbx"
        userln_txtbx.Size = New Size(235, 30)
        userln_txtbx.TabIndex = 20
        ' 
        ' userAddress_txtbx
        ' 
        userAddress_txtbx.BackColor = SystemColors.ControlLightLight
        userAddress_txtbx.Font = New Font("Segoe UI", 10.2F)
        userAddress_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        userAddress_txtbx.Location = New Point(191, 157)
        userAddress_txtbx.Name = "userAddress_txtbx"
        userAddress_txtbx.Size = New Size(235, 30)
        userAddress_txtbx.TabIndex = 19
        ' 
        ' userPhone_txtbx
        ' 
        userPhone_txtbx.BackColor = SystemColors.ControlLightLight
        userPhone_txtbx.Font = New Font("Segoe UI", 10.2F)
        userPhone_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        userPhone_txtbx.Location = New Point(576, 243)
        userPhone_txtbx.Name = "userPhone_txtbx"
        userPhone_txtbx.Size = New Size(235, 30)
        userPhone_txtbx.TabIndex = 17
        ' 
        ' username_txtbx
        ' 
        username_txtbx.BackColor = SystemColors.ControlLightLight
        username_txtbx.Font = New Font("Segoe UI", 10.2F)
        username_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        username_txtbx.Location = New Point(191, 337)
        username_txtbx.Name = "username_txtbx"
        username_txtbx.Size = New Size(235, 30)
        username_txtbx.TabIndex = 16
        ' 
        ' password_txtbx
        ' 
        password_txtbx.BackColor = SystemColors.ControlLightLight
        password_txtbx.Font = New Font("Segoe UI", 10.2F)
        password_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        password_txtbx.Location = New Point(191, 430)
        password_txtbx.Name = "password_txtbx"
        password_txtbx.Size = New Size(235, 30)
        password_txtbx.TabIndex = 15
        ' 
        ' confirmpw_txtbx
        ' 
        confirmpw_txtbx.BackColor = SystemColors.ControlLightLight
        confirmpw_txtbx.Font = New Font("Segoe UI", 10.2F)
        confirmpw_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        confirmpw_txtbx.Location = New Point(576, 430)
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
        Registerbtn.Location = New Point(392, 500)
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
        userfn_txtbx.Location = New Point(191, 70)
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
        LblLastname.Location = New Point(576, 48)
        LblLastname.Name = "LblLastname"
        LblLastname.Size = New Size(91, 23)
        LblLastname.TabIndex = 9
        LblLastname.Text = "Last Name"
        LblLastname.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Registerform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
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
    Friend WithEvents Lbl_msgconfirmpw As Label
    Friend WithEvents Lbl_msgpassword As Label
    Friend WithEvents Lbl_msgusername As Label
    Friend WithEvents Lbl_msgusertype As Label
    Friend WithEvents Lbl_msgfirstname As Label
    Friend WithEvents Lbl_msggender As Label
    Friend WithEvents Lbl_msgaddress As Label
    Friend WithEvents Lbl_msgDOB As Label
    Friend WithEvents Lbl_msglastname As Label
    Friend WithEvents Lbl_msgphone As Label
End Class
