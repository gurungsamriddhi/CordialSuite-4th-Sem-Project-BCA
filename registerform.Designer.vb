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
        Lbl_registeruser = New Label()
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
        LblFirstname.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        LblFirstname.ForeColor = Color.Black
        LblFirstname.Location = New Point(166, 72)
        LblFirstname.Name = "LblFirstname"
        LblFirstname.Size = New Size(110, 28)
        LblFirstname.TabIndex = 0
        LblFirstname.Text = "First Name"
        LblFirstname.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblDOB
        ' 
        LblDOB.AutoSize = True
        LblDOB.BackColor = Color.Transparent
        LblDOB.FlatStyle = FlatStyle.Flat
        LblDOB.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        LblDOB.ForeColor = Color.Black
        LblDOB.Location = New Point(606, 200)
        LblDOB.Name = "LblDOB"
        LblDOB.Size = New Size(129, 28)
        LblDOB.TabIndex = 1
        LblDOB.Text = "Date of Birth"
        LblDOB.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblConfirmpw
        ' 
        LblConfirmpw.AutoSize = True
        LblConfirmpw.FlatStyle = FlatStyle.Flat
        LblConfirmpw.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        LblConfirmpw.ForeColor = Color.Black
        LblConfirmpw.Location = New Point(607, 579)
        LblConfirmpw.Name = "LblConfirmpw"
        LblConfirmpw.Size = New Size(176, 28)
        LblConfirmpw.TabIndex = 2
        LblConfirmpw.Text = "Confirm Password"
        LblConfirmpw.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAddress
        ' 
        LblAddress.AutoSize = True
        LblAddress.BackColor = Color.Transparent
        LblAddress.FlatStyle = FlatStyle.Flat
        LblAddress.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        LblAddress.ForeColor = Color.Black
        LblAddress.Location = New Point(166, 195)
        LblAddress.Name = "LblAddress"
        LblAddress.Size = New Size(85, 28)
        LblAddress.TabIndex = 3
        LblAddress.Text = "Address"
        LblAddress.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblPhonenumber
        ' 
        LblPhonenumber.AutoSize = True
        LblPhonenumber.FlatStyle = FlatStyle.Flat
        LblPhonenumber.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        LblPhonenumber.ForeColor = Color.Black
        LblPhonenumber.ImageAlign = ContentAlignment.TopRight
        LblPhonenumber.Location = New Point(606, 319)
        LblPhonenumber.Name = "LblPhonenumber"
        LblPhonenumber.Size = New Size(143, 28)
        LblPhonenumber.TabIndex = 4
        LblPhonenumber.Text = "Phonenumber"
        LblPhonenumber.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblUsertype
        ' 
        LblUsertype.AutoSize = True
        LblUsertype.FlatStyle = FlatStyle.Flat
        LblUsertype.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        LblUsertype.ForeColor = Color.Black
        LblUsertype.Location = New Point(606, 448)
        LblUsertype.Name = "LblUsertype"
        LblUsertype.Size = New Size(102, 28)
        LblUsertype.TabIndex = 5
        LblUsertype.Text = "User Type"
        LblUsertype.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblGender
        ' 
        LblGender.AutoSize = True
        LblGender.BackColor = Color.Transparent
        LblGender.FlatStyle = FlatStyle.Flat
        LblGender.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        LblGender.ForeColor = Color.Black
        LblGender.Location = New Point(166, 315)
        LblGender.Name = "LblGender"
        LblGender.Size = New Size(79, 28)
        LblGender.TabIndex = 6
        LblGender.Text = "Gender"
        LblGender.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblUsername
        ' 
        LblUsername.AutoSize = True
        LblUsername.FlatStyle = FlatStyle.Flat
        LblUsername.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        LblUsername.ForeColor = Color.Black
        LblUsername.Location = New Point(166, 444)
        LblUsername.Name = "LblUsername"
        LblUsername.Size = New Size(104, 28)
        LblUsername.TabIndex = 7
        LblUsername.Text = "Username"
        LblUsername.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblPassword
        ' 
        LblPassword.AutoSize = True
        LblPassword.FlatStyle = FlatStyle.Flat
        LblPassword.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        LblPassword.ForeColor = Color.Black
        LblPassword.Location = New Point(173, 575)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(97, 28)
        LblPassword.TabIndex = 8
        LblPassword.Text = "Password"
        LblPassword.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Pnlregister
        ' 
        Pnlregister.BackColor = SystemColors.Menu
        Pnlregister.Controls.Add(Lbl_registeruser)
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
        Pnlregister.ForeColor = SystemColors.HighlightText
        Pnlregister.Location = New Point(0, 0)
        Pnlregister.Name = "Pnlregister"
        Pnlregister.Size = New Size(1077, 777)
        Pnlregister.TabIndex = 0
        ' 
        ' Lbl_registeruser
        ' 
        Lbl_registeruser.AutoSize = True
        Lbl_registeruser.BackColor = Color.Transparent
        Lbl_registeruser.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_registeruser.ForeColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Lbl_registeruser.Location = New Point(489, 20)
        Lbl_registeruser.Name = "Lbl_registeruser"
        Lbl_registeruser.Size = New Size(180, 31)
        Lbl_registeruser.TabIndex = 39
        Lbl_registeruser.Text = "REGISTER USER"
        ' 
        ' Lbl_msggender
        ' 
        Lbl_msggender.AutoSize = True
        Lbl_msggender.ForeColor = SystemColors.ControlLightLight
        Lbl_msggender.Location = New Point(168, 388)
        Lbl_msggender.Name = "Lbl_msggender"
        Lbl_msggender.Size = New Size(0, 20)
        Lbl_msggender.TabIndex = 38
        ' 
        ' Lbl_msgaddress
        ' 
        Lbl_msgaddress.AutoSize = True
        Lbl_msgaddress.ForeColor = SystemColors.ControlLightLight
        Lbl_msgaddress.Location = New Point(174, 281)
        Lbl_msgaddress.Name = "Lbl_msgaddress"
        Lbl_msgaddress.Size = New Size(0, 20)
        Lbl_msgaddress.TabIndex = 37
        ' 
        ' Lbl_msgDOB
        ' 
        Lbl_msgDOB.AutoSize = True
        Lbl_msgDOB.ForeColor = SystemColors.ControlLightLight
        Lbl_msgDOB.Location = New Point(606, 280)
        Lbl_msgDOB.Name = "Lbl_msgDOB"
        Lbl_msgDOB.Size = New Size(0, 20)
        Lbl_msgDOB.TabIndex = 36
        ' 
        ' Lbl_msglastname
        ' 
        Lbl_msglastname.AutoSize = True
        Lbl_msglastname.BackColor = Color.Transparent
        Lbl_msglastname.Font = New Font("Segoe UI", 9.0F)
        Lbl_msglastname.ForeColor = Color.Black
        Lbl_msglastname.Location = New Point(606, 162)
        Lbl_msglastname.Name = "Lbl_msglastname"
        Lbl_msglastname.Size = New Size(0, 20)
        Lbl_msglastname.TabIndex = 35
        ' 
        ' Lbl_msgphone
        ' 
        Lbl_msgphone.AutoSize = True
        Lbl_msgphone.ForeColor = Color.Black
        Lbl_msgphone.Location = New Point(606, 396)
        Lbl_msgphone.Name = "Lbl_msgphone"
        Lbl_msgphone.Size = New Size(0, 20)
        Lbl_msgphone.TabIndex = 34
        ' 
        ' Lbl_msgconfirmpw
        ' 
        Lbl_msgconfirmpw.AutoSize = True
        Lbl_msgconfirmpw.ForeColor = Color.Black
        Lbl_msgconfirmpw.Location = New Point(607, 654)
        Lbl_msgconfirmpw.Name = "Lbl_msgconfirmpw"
        Lbl_msgconfirmpw.Size = New Size(0, 20)
        Lbl_msgconfirmpw.TabIndex = 33
        ' 
        ' Lbl_msgpassword
        ' 
        Lbl_msgpassword.AutoSize = True
        Lbl_msgpassword.ForeColor = Color.Black
        Lbl_msgpassword.Location = New Point(174, 650)
        Lbl_msgpassword.Name = "Lbl_msgpassword"
        Lbl_msgpassword.Size = New Size(0, 20)
        Lbl_msgpassword.TabIndex = 32
        ' 
        ' Lbl_msgusername
        ' 
        Lbl_msgusername.AutoSize = True
        Lbl_msgusername.ForeColor = Color.Black
        Lbl_msgusername.Location = New Point(174, 530)
        Lbl_msgusername.Name = "Lbl_msgusername"
        Lbl_msgusername.Size = New Size(0, 20)
        Lbl_msgusername.TabIndex = 31
        ' 
        ' Lbl_msgusertype
        ' 
        Lbl_msgusertype.AutoSize = True
        Lbl_msgusertype.ForeColor = Color.Black
        Lbl_msgusertype.Location = New Point(606, 528)
        Lbl_msgusertype.Name = "Lbl_msgusertype"
        Lbl_msgusertype.Size = New Size(0, 20)
        Lbl_msgusertype.TabIndex = 30
        ' 
        ' Lbl_msgfirstname
        ' 
        Lbl_msgfirstname.AutoSize = True
        Lbl_msgfirstname.BackColor = Color.Transparent
        Lbl_msgfirstname.Font = New Font("Segoe UI", 9.0F)
        Lbl_msgfirstname.ForeColor = Color.Black
        Lbl_msgfirstname.Location = New Point(166, 162)
        Lbl_msgfirstname.Name = "Lbl_msgfirstname"
        Lbl_msgfirstname.Size = New Size(0, 20)
        Lbl_msgfirstname.TabIndex = 29
        ' 
        ' userDOB_dtp
        ' 
        userDOB_dtp.CalendarFont = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        userDOB_dtp.CalendarForeColor = Color.Black
        userDOB_dtp.CalendarMonthBackground = SystemColors.GradientActiveCaption
        userDOB_dtp.CalendarTitleBackColor = SystemColors.GradientActiveCaption
        userDOB_dtp.CalendarTitleForeColor = SystemColors.GradientInactiveCaption
        userDOB_dtp.CalendarTrailingForeColor = SystemColors.GradientInactiveCaption
        userDOB_dtp.Font = New Font("Segoe UI", 10.2F)
        userDOB_dtp.Format = DateTimePickerFormat.Short
        userDOB_dtp.Location = New Point(607, 234)
        userDOB_dtp.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        userDOB_dtp.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        userDOB_dtp.Name = "userDOB_dtp"
        userDOB_dtp.Size = New Size(338, 30)
        userDOB_dtp.TabIndex = 25
        userDOB_dtp.Value = New Date(2024, 6, 5, 0, 0, 0, 0)
        ' 
        ' usertype_cmbbx
        ' 
        usertype_cmbbx.BackColor = SystemColors.ControlLightLight
        usertype_cmbbx.FlatStyle = FlatStyle.System
        usertype_cmbbx.Font = New Font("Segoe UI", 10.2F)
        usertype_cmbbx.ForeColor = Color.Black
        usertype_cmbbx.FormattingEnabled = True
        usertype_cmbbx.Items.AddRange(New Object() {"Admin", "User"})
        usertype_cmbbx.Location = New Point(606, 486)
        usertype_cmbbx.Name = "usertype_cmbbx"
        usertype_cmbbx.Size = New Size(329, 31)
        usertype_cmbbx.TabIndex = 22
        ' 
        ' gender_cmbbx
        ' 
        gender_cmbbx.AutoCompleteCustomSource.AddRange(New String() {"Female", "Male", "Others"})
        gender_cmbbx.BackColor = SystemColors.ControlLightLight
        gender_cmbbx.FlatStyle = FlatStyle.System
        gender_cmbbx.Font = New Font("Segoe UI", 10.2F)
        gender_cmbbx.ForeColor = Color.Black
        gender_cmbbx.FormattingEnabled = True
        gender_cmbbx.ItemHeight = 23
        gender_cmbbx.Items.AddRange(New Object() {"Female", "Male", "Others"})
        gender_cmbbx.Location = New Point(168, 354)
        gender_cmbbx.Name = "gender_cmbbx"
        gender_cmbbx.Size = New Size(353, 31)
        gender_cmbbx.TabIndex = 21
        ' 
        ' userln_txtbx
        ' 
        userln_txtbx.BackColor = SystemColors.ControlLightLight
        userln_txtbx.Font = New Font("Segoe UI", 10.2F)
        userln_txtbx.ForeColor = Color.Black
        userln_txtbx.Location = New Point(606, 115)
        userln_txtbx.Multiline = True
        userln_txtbx.Name = "userln_txtbx"
        userln_txtbx.Size = New Size(339, 37)
        userln_txtbx.TabIndex = 20
        ' 
        ' userAddress_txtbx
        ' 
        userAddress_txtbx.BackColor = SystemColors.ControlLightLight
        userAddress_txtbx.Font = New Font("Segoe UI", 10.2F)
        userAddress_txtbx.ForeColor = Color.Black
        userAddress_txtbx.Location = New Point(168, 234)
        userAddress_txtbx.Multiline = True
        userAddress_txtbx.Name = "userAddress_txtbx"
        userAddress_txtbx.Size = New Size(353, 41)
        userAddress_txtbx.TabIndex = 19
        ' 
        ' userPhone_txtbx
        ' 
        userPhone_txtbx.BackColor = SystemColors.ControlLightLight
        userPhone_txtbx.Font = New Font("Segoe UI", 10.2F)
        userPhone_txtbx.ForeColor = Color.Black
        userPhone_txtbx.Location = New Point(606, 357)
        userPhone_txtbx.Name = "userPhone_txtbx"
        userPhone_txtbx.Size = New Size(329, 30)
        userPhone_txtbx.TabIndex = 17
        ' 
        ' username_txtbx
        ' 
        username_txtbx.BackColor = SystemColors.ControlLightLight
        username_txtbx.Font = New Font("Segoe UI", 10.2F)
        username_txtbx.ForeColor = Color.Black
        username_txtbx.Location = New Point(168, 483)
        username_txtbx.Multiline = True
        username_txtbx.Name = "username_txtbx"
        username_txtbx.Size = New Size(353, 41)
        username_txtbx.TabIndex = 16
        ' 
        ' password_txtbx
        ' 
        password_txtbx.BackColor = SystemColors.ControlLightLight
        password_txtbx.Font = New Font("Segoe UI", 10.2F)
        password_txtbx.ForeColor = Color.Black
        password_txtbx.Location = New Point(169, 606)
        password_txtbx.Multiline = True
        password_txtbx.Name = "password_txtbx"
        password_txtbx.Size = New Size(353, 41)
        password_txtbx.TabIndex = 15
        ' 
        ' confirmpw_txtbx
        ' 
        confirmpw_txtbx.BackColor = SystemColors.ControlLightLight
        confirmpw_txtbx.Font = New Font("Segoe UI", 10.2F)
        confirmpw_txtbx.ForeColor = Color.Black
        confirmpw_txtbx.Location = New Point(607, 610)
        confirmpw_txtbx.Multiline = True
        confirmpw_txtbx.Name = "confirmpw_txtbx"
        confirmpw_txtbx.Size = New Size(353, 41)
        confirmpw_txtbx.TabIndex = 14
        ' 
        ' Registerbtn
        ' 
        Registerbtn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Registerbtn.FlatAppearance.BorderColor = SystemColors.Window
        Registerbtn.FlatAppearance.BorderSize = 2
        Registerbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Registerbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Registerbtn.FlatStyle = FlatStyle.Flat
        Registerbtn.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Registerbtn.Location = New Point(461, 693)
        Registerbtn.Name = "Registerbtn"
        Registerbtn.Size = New Size(219, 54)
        Registerbtn.TabIndex = 11
        Registerbtn.Text = "Register"
        Registerbtn.UseVisualStyleBackColor = False
        ' 
        ' userfn_txtbx
        ' 
        userfn_txtbx.BackColor = SystemColors.ControlLightLight
        userfn_txtbx.Font = New Font("Segoe UI", 10.2F)
        userfn_txtbx.ForeColor = Color.Black
        userfn_txtbx.Location = New Point(168, 111)
        userfn_txtbx.Multiline = True
        userfn_txtbx.Name = "userfn_txtbx"
        userfn_txtbx.Size = New Size(353, 41)
        userfn_txtbx.TabIndex = 10
        ' 
        ' LblLastname
        ' 
        LblLastname.AutoSize = True
        LblLastname.FlatStyle = FlatStyle.Flat
        LblLastname.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        LblLastname.ForeColor = Color.Black
        LblLastname.Location = New Point(606, 76)
        LblLastname.Name = "LblLastname"
        LblLastname.Size = New Size(108, 28)
        LblLastname.TabIndex = 9
        LblLastname.Text = "Last Name"
        LblLastname.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Registerform
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.Disable
        BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        ClientSize = New Size(1077, 777)
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
    Friend WithEvents Lbl_registeruser As Label

End Class
