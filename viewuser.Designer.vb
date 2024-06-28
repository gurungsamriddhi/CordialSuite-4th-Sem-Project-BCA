<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewuser
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DGV_users = New DataGridView()
        searchkeyword_txtbx = New TextBox()
        Tabcontrolusers = New TabControl()
        TabPageViewUser = New TabPage()
        Lbl_anykeyword = New Label()
        updateusertabpage = New TabPage()
        Lbl_useridshow = New Label()
        Lbl_upuserid = New Label()
        Lbl_msgpassword = New Label()
        Lbl_msggender = New Label()
        Lbl_msgaddress = New Label()
        Lbl_msgDOB = New Label()
        Lbl_msglastname = New Label()
        Lbl_msgphone = New Label()
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
        userfn_txtbx = New TextBox()
        LblLastname = New Label()
        LblPassword = New Label()
        LblUsername = New Label()
        LblGender = New Label()
        LblUsertype = New Label()
        LblPhonenumber = New Label()
        LblAddress = New Label()
        LblDOB = New Label()
        LblFirstname = New Label()
        updateuser_Btn = New Button()
        TabPagedeluser = New TabPage()
        Lbl_useridshowdel = New Label()
        userdel_btn = New Button()
        usernamedel_txtbx = New TextBox()
        usertypedel_cmbbx = New ComboBox()
        Label2 = New Label()
        Lbl_username = New Label()
        Lbl_userid = New Label()
        Lblguestlist = New Label()
        CType(DGV_users, ComponentModel.ISupportInitialize).BeginInit()
        Tabcontrolusers.SuspendLayout()
        TabPageViewUser.SuspendLayout()
        updateusertabpage.SuspendLayout()
        TabPagedeluser.SuspendLayout()
        SuspendLayout()
        ' 
        ' DGV_users
        ' 
        DGV_users.AllowUserToAddRows = False
        DGV_users.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.White
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DGV_users.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DGV_users.Anchor = AnchorStyles.None
        DGV_users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DGV_users.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DGV_users.BackgroundColor = SystemColors.MenuBar
        DGV_users.BorderStyle = BorderStyle.None
        DGV_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_users.GridColor = Color.Black
        DGV_users.Location = New Point(29, 173)
        DGV_users.Name = "DGV_users"
        DGV_users.ReadOnly = True
        DGV_users.RowHeadersWidth = 51
        DGV_users.Size = New Size(978, 495)
        DGV_users.TabIndex = 6
        ' 
        ' searchkeyword_txtbx
        ' 
        searchkeyword_txtbx.Anchor = AnchorStyles.None
        searchkeyword_txtbx.BackColor = SystemColors.ControlLightLight
        searchkeyword_txtbx.BorderStyle = BorderStyle.FixedSingle
        searchkeyword_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchkeyword_txtbx.ForeColor = Color.Black
        searchkeyword_txtbx.Location = New Point(378, 72)
        searchkeyword_txtbx.Multiline = True
        searchkeyword_txtbx.Name = "searchkeyword_txtbx"
        searchkeyword_txtbx.Size = New Size(361, 47)
        searchkeyword_txtbx.TabIndex = 7
        ' 
        ' Tabcontrolusers
        ' 
        Tabcontrolusers.Alignment = TabAlignment.Bottom
        Tabcontrolusers.Controls.Add(TabPageViewUser)
        Tabcontrolusers.Controls.Add(updateusertabpage)
        Tabcontrolusers.Controls.Add(TabPagedeluser)
        Tabcontrolusers.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Tabcontrolusers.Location = New Point(12, 43)
        Tabcontrolusers.Name = "Tabcontrolusers"
        Tabcontrolusers.SelectedIndex = 0
        Tabcontrolusers.Size = New Size(1041, 737)
        Tabcontrolusers.TabIndex = 10
        ' 
        ' TabPageViewUser
        ' 
        TabPageViewUser.Controls.Add(Lbl_anykeyword)
        TabPageViewUser.Controls.Add(DGV_users)
        TabPageViewUser.Controls.Add(searchkeyword_txtbx)
        TabPageViewUser.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabPageViewUser.Location = New Point(4, 4)
        TabPageViewUser.Name = "TabPageViewUser"
        TabPageViewUser.Padding = New Padding(3)
        TabPageViewUser.Size = New Size(1033, 696)
        TabPageViewUser.TabIndex = 0
        TabPageViewUser.Text = "Search User"
        TabPageViewUser.UseVisualStyleBackColor = True
        ' 
        ' Lbl_anykeyword
        ' 
        Lbl_anykeyword.Anchor = AnchorStyles.None
        Lbl_anykeyword.AutoSize = True
        Lbl_anykeyword.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_anykeyword.ForeColor = SystemColors.ActiveCaptionText
        Lbl_anykeyword.Location = New Point(241, 82)
        Lbl_anykeyword.Name = "Lbl_anykeyword"
        Lbl_anykeyword.Size = New Size(131, 25)
        Lbl_anykeyword.TabIndex = 9
        Lbl_anykeyword.Text = "Any Keyword:"
        ' 
        ' updateusertabpage
        ' 
        updateusertabpage.Controls.Add(Lbl_useridshow)
        updateusertabpage.Controls.Add(Lbl_upuserid)
        updateusertabpage.Controls.Add(Lbl_msgpassword)
        updateusertabpage.Controls.Add(Lbl_msggender)
        updateusertabpage.Controls.Add(Lbl_msgaddress)
        updateusertabpage.Controls.Add(Lbl_msgDOB)
        updateusertabpage.Controls.Add(Lbl_msglastname)
        updateusertabpage.Controls.Add(Lbl_msgphone)
        updateusertabpage.Controls.Add(Lbl_msgusername)
        updateusertabpage.Controls.Add(Lbl_msgusertype)
        updateusertabpage.Controls.Add(Lbl_msgfirstname)
        updateusertabpage.Controls.Add(userDOB_dtp)
        updateusertabpage.Controls.Add(usertype_cmbbx)
        updateusertabpage.Controls.Add(gender_cmbbx)
        updateusertabpage.Controls.Add(userln_txtbx)
        updateusertabpage.Controls.Add(userAddress_txtbx)
        updateusertabpage.Controls.Add(userPhone_txtbx)
        updateusertabpage.Controls.Add(username_txtbx)
        updateusertabpage.Controls.Add(password_txtbx)
        updateusertabpage.Controls.Add(userfn_txtbx)
        updateusertabpage.Controls.Add(LblLastname)
        updateusertabpage.Controls.Add(LblPassword)
        updateusertabpage.Controls.Add(LblUsername)
        updateusertabpage.Controls.Add(LblGender)
        updateusertabpage.Controls.Add(LblUsertype)
        updateusertabpage.Controls.Add(LblPhonenumber)
        updateusertabpage.Controls.Add(LblAddress)
        updateusertabpage.Controls.Add(LblDOB)
        updateusertabpage.Controls.Add(LblFirstname)
        updateusertabpage.Controls.Add(updateuser_Btn)
        updateusertabpage.Location = New Point(4, 4)
        updateusertabpage.Name = "updateusertabpage"
        updateusertabpage.Padding = New Padding(3)
        updateusertabpage.Size = New Size(1033, 655)
        updateusertabpage.TabIndex = 1
        updateusertabpage.Text = "Update User"
        updateusertabpage.UseVisualStyleBackColor = True
        ' 
        ' Lbl_useridshow
        ' 
        Lbl_useridshow.AutoSize = True
        Lbl_useridshow.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_useridshow.ForeColor = SystemColors.ControlText
        Lbl_useridshow.Location = New Point(243, 24)
        Lbl_useridshow.Name = "Lbl_useridshow"
        Lbl_useridshow.Size = New Size(0, 28)
        Lbl_useridshow.TabIndex = 70
        ' 
        ' Lbl_upuserid
        ' 
        Lbl_upuserid.AutoSize = True
        Lbl_upuserid.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_upuserid.ForeColor = Color.Red
        Lbl_upuserid.Location = New Point(147, 24)
        Lbl_upuserid.Name = "Lbl_upuserid"
        Lbl_upuserid.Size = New Size(90, 28)
        Lbl_upuserid.TabIndex = 69
        Lbl_upuserid.Text = "USER ID:"
        ' 
        ' Lbl_msgpassword
        ' 
        Lbl_msgpassword.AutoSize = True
        Lbl_msgpassword.Font = New Font("Segoe UI", 9F)
        Lbl_msgpassword.ForeColor = Color.Black
        Lbl_msgpassword.Location = New Point(147, 572)
        Lbl_msgpassword.Name = "Lbl_msgpassword"
        Lbl_msgpassword.Size = New Size(0, 20)
        Lbl_msgpassword.TabIndex = 68
        ' 
        ' Lbl_msggender
        ' 
        Lbl_msggender.AutoSize = True
        Lbl_msggender.Font = New Font("Segoe UI", 9F)
        Lbl_msggender.ForeColor = SystemColors.ControlText
        Lbl_msggender.Location = New Point(147, 362)
        Lbl_msggender.Name = "Lbl_msggender"
        Lbl_msggender.Size = New Size(0, 20)
        Lbl_msggender.TabIndex = 66
        ' 
        ' Lbl_msgaddress
        ' 
        Lbl_msgaddress.AutoSize = True
        Lbl_msgaddress.Font = New Font("Segoe UI", 9F)
        Lbl_msgaddress.ForeColor = SystemColors.ControlText
        Lbl_msgaddress.Location = New Point(147, 254)
        Lbl_msgaddress.Name = "Lbl_msgaddress"
        Lbl_msgaddress.Size = New Size(0, 20)
        Lbl_msgaddress.TabIndex = 65
        ' 
        ' Lbl_msgDOB
        ' 
        Lbl_msgDOB.AutoSize = True
        Lbl_msgDOB.ForeColor = SystemColors.ControlLightLight
        Lbl_msgDOB.Location = New Point(584, 254)
        Lbl_msgDOB.Name = "Lbl_msgDOB"
        Lbl_msgDOB.Size = New Size(0, 28)
        Lbl_msgDOB.TabIndex = 64
        ' 
        ' Lbl_msglastname
        ' 
        Lbl_msglastname.AutoSize = True
        Lbl_msglastname.BackColor = Color.Transparent
        Lbl_msglastname.Font = New Font("Segoe UI", 9F)
        Lbl_msglastname.ForeColor = Color.Black
        Lbl_msglastname.Location = New Point(584, 154)
        Lbl_msglastname.Name = "Lbl_msglastname"
        Lbl_msglastname.Size = New Size(0, 20)
        Lbl_msglastname.TabIndex = 63
        ' 
        ' Lbl_msgphone
        ' 
        Lbl_msgphone.AutoSize = True
        Lbl_msgphone.Font = New Font("Segoe UI", 9F)
        Lbl_msgphone.ForeColor = Color.Black
        Lbl_msgphone.Location = New Point(584, 356)
        Lbl_msgphone.Name = "Lbl_msgphone"
        Lbl_msgphone.Size = New Size(0, 20)
        Lbl_msgphone.TabIndex = 62
        ' 
        ' Lbl_msgusername
        ' 
        Lbl_msgusername.AutoSize = True
        Lbl_msgusername.Font = New Font("Segoe UI", 9F)
        Lbl_msgusername.ForeColor = Color.Black
        Lbl_msgusername.Location = New Point(147, 466)
        Lbl_msgusername.Name = "Lbl_msgusername"
        Lbl_msgusername.Size = New Size(0, 20)
        Lbl_msgusername.TabIndex = 61
        ' 
        ' Lbl_msgusertype
        ' 
        Lbl_msgusertype.AutoSize = True
        Lbl_msgusertype.Font = New Font("Segoe UI", 9F)
        Lbl_msgusertype.ForeColor = Color.Black
        Lbl_msgusertype.Location = New Point(584, 466)
        Lbl_msgusertype.Name = "Lbl_msgusertype"
        Lbl_msgusertype.Size = New Size(0, 20)
        Lbl_msgusertype.TabIndex = 60
        ' 
        ' Lbl_msgfirstname
        ' 
        Lbl_msgfirstname.AutoSize = True
        Lbl_msgfirstname.BackColor = Color.Transparent
        Lbl_msgfirstname.Font = New Font("Segoe UI", 9F)
        Lbl_msgfirstname.ForeColor = Color.Black
        Lbl_msgfirstname.Location = New Point(147, 154)
        Lbl_msgfirstname.Name = "Lbl_msgfirstname"
        Lbl_msgfirstname.Size = New Size(0, 20)
        Lbl_msgfirstname.TabIndex = 59
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
        userDOB_dtp.Location = New Point(584, 221)
        userDOB_dtp.MaxDate = New Date(2025, 1, 1, 0, 0, 0, 0)
        userDOB_dtp.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        userDOB_dtp.Name = "userDOB_dtp"
        userDOB_dtp.Size = New Size(272, 30)
        userDOB_dtp.TabIndex = 58
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
        usertype_cmbbx.Location = New Point(584, 432)
        usertype_cmbbx.Name = "usertype_cmbbx"
        usertype_cmbbx.Size = New Size(272, 31)
        usertype_cmbbx.TabIndex = 57
        ' 
        ' gender_cmbbx
        ' 
        gender_cmbbx.AutoCompleteCustomSource.AddRange(New String() {"Female", "Male", "Others"})
        gender_cmbbx.BackColor = SystemColors.ControlLightLight
        gender_cmbbx.FlatStyle = FlatStyle.System
        gender_cmbbx.Font = New Font("Segoe UI", 10.2F)
        gender_cmbbx.ForeColor = Color.Black
        gender_cmbbx.FormattingEnabled = True
        gender_cmbbx.Items.AddRange(New Object() {"Female", "Male", "Others"})
        gender_cmbbx.Location = New Point(147, 328)
        gender_cmbbx.Name = "gender_cmbbx"
        gender_cmbbx.Size = New Size(272, 31)
        gender_cmbbx.TabIndex = 56
        ' 
        ' userln_txtbx
        ' 
        userln_txtbx.BackColor = SystemColors.ControlLightLight
        userln_txtbx.Font = New Font("Segoe UI", 10.8F)
        userln_txtbx.ForeColor = Color.Black
        userln_txtbx.Location = New Point(584, 120)
        userln_txtbx.Name = "userln_txtbx"
        userln_txtbx.Size = New Size(272, 31)
        userln_txtbx.TabIndex = 55
        ' 
        ' userAddress_txtbx
        ' 
        userAddress_txtbx.BackColor = SystemColors.ControlLightLight
        userAddress_txtbx.Font = New Font("Segoe UI", 10.2F)
        userAddress_txtbx.ForeColor = Color.Black
        userAddress_txtbx.Location = New Point(147, 221)
        userAddress_txtbx.Name = "userAddress_txtbx"
        userAddress_txtbx.Size = New Size(272, 30)
        userAddress_txtbx.TabIndex = 54
        ' 
        ' userPhone_txtbx
        ' 
        userPhone_txtbx.BackColor = SystemColors.ControlLightLight
        userPhone_txtbx.Font = New Font("Segoe UI", 10.2F)
        userPhone_txtbx.ForeColor = Color.Black
        userPhone_txtbx.Location = New Point(584, 325)
        userPhone_txtbx.Name = "userPhone_txtbx"
        userPhone_txtbx.Size = New Size(272, 30)
        userPhone_txtbx.TabIndex = 53
        ' 
        ' username_txtbx
        ' 
        username_txtbx.BackColor = SystemColors.ControlLightLight
        username_txtbx.Font = New Font("Segoe UI", 10.2F)
        username_txtbx.ForeColor = Color.Black
        username_txtbx.Location = New Point(147, 433)
        username_txtbx.Name = "username_txtbx"
        username_txtbx.Size = New Size(272, 30)
        username_txtbx.TabIndex = 52
        ' 
        ' password_txtbx
        ' 
        password_txtbx.BackColor = SystemColors.ControlLightLight
        password_txtbx.Font = New Font("Segoe UI", 10.2F)
        password_txtbx.ForeColor = Color.Black
        password_txtbx.Location = New Point(147, 539)
        password_txtbx.Name = "password_txtbx"
        password_txtbx.Size = New Size(272, 30)
        password_txtbx.TabIndex = 51
        ' 
        ' userfn_txtbx
        ' 
        userfn_txtbx.BackColor = SystemColors.ControlLightLight
        userfn_txtbx.Font = New Font("Segoe UI", 10.8F)
        userfn_txtbx.ForeColor = Color.Black
        userfn_txtbx.Location = New Point(147, 120)
        userfn_txtbx.Name = "userfn_txtbx"
        userfn_txtbx.Size = New Size(272, 31)
        userfn_txtbx.TabIndex = 49
        ' 
        ' LblLastname
        ' 
        LblLastname.AutoSize = True
        LblLastname.FlatStyle = FlatStyle.Flat
        LblLastname.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LblLastname.ForeColor = Color.Black
        LblLastname.Location = New Point(584, 89)
        LblLastname.Name = "LblLastname"
        LblLastname.Size = New Size(108, 28)
        LblLastname.TabIndex = 48
        LblLastname.Text = "Last Name"
        LblLastname.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblPassword
        ' 
        LblPassword.AutoSize = True
        LblPassword.FlatStyle = FlatStyle.Flat
        LblPassword.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LblPassword.ForeColor = Color.Black
        LblPassword.Location = New Point(145, 510)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(97, 28)
        LblPassword.TabIndex = 47
        LblPassword.Text = "Password"
        LblPassword.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblUsername
        ' 
        LblUsername.AutoSize = True
        LblUsername.FlatStyle = FlatStyle.Flat
        LblUsername.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LblUsername.ForeColor = Color.Black
        LblUsername.Location = New Point(145, 402)
        LblUsername.Name = "LblUsername"
        LblUsername.Size = New Size(104, 28)
        LblUsername.TabIndex = 46
        LblUsername.Text = "Username"
        LblUsername.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblGender
        ' 
        LblGender.AutoSize = True
        LblGender.BackColor = Color.Transparent
        LblGender.FlatStyle = FlatStyle.Flat
        LblGender.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LblGender.ForeColor = Color.Black
        LblGender.Location = New Point(145, 297)
        LblGender.Name = "LblGender"
        LblGender.Size = New Size(79, 28)
        LblGender.TabIndex = 45
        LblGender.Text = "Gender"
        LblGender.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblUsertype
        ' 
        LblUsertype.AutoSize = True
        LblUsertype.FlatStyle = FlatStyle.Flat
        LblUsertype.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LblUsertype.ForeColor = Color.Black
        LblUsertype.Location = New Point(584, 402)
        LblUsertype.Name = "LblUsertype"
        LblUsertype.Size = New Size(102, 28)
        LblUsertype.TabIndex = 44
        LblUsertype.Text = "User Type"
        LblUsertype.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblPhonenumber
        ' 
        LblPhonenumber.AutoSize = True
        LblPhonenumber.FlatStyle = FlatStyle.Flat
        LblPhonenumber.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LblPhonenumber.ForeColor = Color.Black
        LblPhonenumber.ImageAlign = ContentAlignment.TopRight
        LblPhonenumber.Location = New Point(584, 295)
        LblPhonenumber.Name = "LblPhonenumber"
        LblPhonenumber.Size = New Size(143, 28)
        LblPhonenumber.TabIndex = 43
        LblPhonenumber.Text = "Phonenumber"
        LblPhonenumber.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAddress
        ' 
        LblAddress.AutoSize = True
        LblAddress.BackColor = Color.Transparent
        LblAddress.FlatStyle = FlatStyle.Flat
        LblAddress.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LblAddress.ForeColor = Color.Black
        LblAddress.Location = New Point(145, 190)
        LblAddress.Name = "LblAddress"
        LblAddress.Size = New Size(85, 28)
        LblAddress.TabIndex = 42
        LblAddress.Text = "Address"
        LblAddress.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblDOB
        ' 
        LblDOB.AutoSize = True
        LblDOB.BackColor = Color.Transparent
        LblDOB.FlatStyle = FlatStyle.Flat
        LblDOB.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LblDOB.ForeColor = Color.Black
        LblDOB.Location = New Point(584, 190)
        LblDOB.Name = "LblDOB"
        LblDOB.Size = New Size(129, 28)
        LblDOB.TabIndex = 40
        LblDOB.Text = "Date of Birth"
        LblDOB.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblFirstname
        ' 
        LblFirstname.AutoSize = True
        LblFirstname.BackColor = Color.Transparent
        LblFirstname.FlatStyle = FlatStyle.Flat
        LblFirstname.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LblFirstname.ForeColor = Color.Black
        LblFirstname.Location = New Point(145, 89)
        LblFirstname.Name = "LblFirstname"
        LblFirstname.Size = New Size(110, 28)
        LblFirstname.TabIndex = 39
        LblFirstname.Text = "First Name"
        LblFirstname.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' updateuser_Btn
        ' 
        updateuser_Btn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        updateuser_Btn.FlatAppearance.BorderColor = SystemColors.Window
        updateuser_Btn.FlatAppearance.BorderSize = 2
        updateuser_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        updateuser_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        updateuser_Btn.FlatStyle = FlatStyle.Flat
        updateuser_Btn.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        updateuser_Btn.ForeColor = SystemColors.Window
        updateuser_Btn.Location = New Point(421, 593)
        updateuser_Btn.Name = "updateuser_Btn"
        updateuser_Btn.Size = New Size(192, 54)
        updateuser_Btn.TabIndex = 12
        updateuser_Btn.Text = "Update"
        updateuser_Btn.UseVisualStyleBackColor = False
        ' 
        ' TabPagedeluser
        ' 
        TabPagedeluser.Controls.Add(Lbl_useridshowdel)
        TabPagedeluser.Controls.Add(userdel_btn)
        TabPagedeluser.Controls.Add(usernamedel_txtbx)
        TabPagedeluser.Controls.Add(usertypedel_cmbbx)
        TabPagedeluser.Controls.Add(Label2)
        TabPagedeluser.Controls.Add(Lbl_username)
        TabPagedeluser.Controls.Add(Lbl_userid)
        TabPagedeluser.Location = New Point(4, 4)
        TabPagedeluser.Name = "TabPagedeluser"
        TabPagedeluser.Padding = New Padding(3)
        TabPagedeluser.Size = New Size(1033, 655)
        TabPagedeluser.TabIndex = 2
        TabPagedeluser.Text = "Delete User"
        TabPagedeluser.UseVisualStyleBackColor = True
        ' 
        ' Lbl_useridshowdel
        ' 
        Lbl_useridshowdel.AutoSize = True
        Lbl_useridshowdel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_useridshowdel.ForeColor = SystemColors.ControlText
        Lbl_useridshowdel.Location = New Point(391, 199)
        Lbl_useridshowdel.Name = "Lbl_useridshowdel"
        Lbl_useridshowdel.Size = New Size(0, 28)
        Lbl_useridshowdel.TabIndex = 62
        ' 
        ' userdel_btn
        ' 
        userdel_btn.BackColor = Color.Red
        userdel_btn.FlatAppearance.BorderColor = SystemColors.Window
        userdel_btn.FlatAppearance.BorderSize = 2
        userdel_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(204), CByte(0), CByte(0))
        userdel_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(204), CByte(0), CByte(0))
        userdel_btn.FlatStyle = FlatStyle.Flat
        userdel_btn.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        userdel_btn.ForeColor = SystemColors.Window
        userdel_btn.Location = New Point(386, 515)
        userdel_btn.Name = "userdel_btn"
        userdel_btn.Size = New Size(194, 54)
        userdel_btn.TabIndex = 61
        userdel_btn.Text = "Delete"
        userdel_btn.UseVisualStyleBackColor = False
        ' 
        ' usernamedel_txtbx
        ' 
        usernamedel_txtbx.BackColor = SystemColors.ControlLightLight
        usernamedel_txtbx.Font = New Font("Segoe UI", 10.2F)
        usernamedel_txtbx.ForeColor = Color.Black
        usernamedel_txtbx.Location = New Point(391, 283)
        usernamedel_txtbx.Name = "usernamedel_txtbx"
        usernamedel_txtbx.Size = New Size(272, 30)
        usernamedel_txtbx.TabIndex = 59
        ' 
        ' usertypedel_cmbbx
        ' 
        usertypedel_cmbbx.BackColor = SystemColors.ControlLightLight
        usertypedel_cmbbx.FlatStyle = FlatStyle.System
        usertypedel_cmbbx.Font = New Font("Segoe UI", 10.2F)
        usertypedel_cmbbx.ForeColor = Color.Black
        usertypedel_cmbbx.FormattingEnabled = True
        usertypedel_cmbbx.Items.AddRange(New Object() {"Admin", "User"})
        usertypedel_cmbbx.Location = New Point(391, 367)
        usertypedel_cmbbx.Name = "usertypedel_cmbbx"
        usertypedel_cmbbx.Size = New Size(272, 31)
        usertypedel_cmbbx.TabIndex = 58
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(253, 365)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 28)
        Label2.TabIndex = 48
        Label2.Text = "User Type"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Lbl_username
        ' 
        Lbl_username.AutoSize = True
        Lbl_username.FlatStyle = FlatStyle.Flat
        Lbl_username.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_username.ForeColor = Color.Black
        Lbl_username.Location = New Point(262, 285)
        Lbl_username.Name = "Lbl_username"
        Lbl_username.Size = New Size(104, 28)
        Lbl_username.TabIndex = 47
        Lbl_username.Text = "Username"
        Lbl_username.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Lbl_userid
        ' 
        Lbl_userid.AutoSize = True
        Lbl_userid.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_userid.ForeColor = Color.Red
        Lbl_userid.Location = New Point(276, 199)
        Lbl_userid.Name = "Lbl_userid"
        Lbl_userid.Size = New Size(84, 28)
        Lbl_userid.TabIndex = 0
        Lbl_userid.Text = "User ID:"
        ' 
        ' Lblguestlist
        ' 
        Lblguestlist.AutoSize = True
        Lblguestlist.BackColor = Color.Transparent
        Lblguestlist.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblguestlist.ForeColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Lblguestlist.Location = New Point(471, 9)
        Lblguestlist.Name = "Lblguestlist"
        Lblguestlist.Size = New Size(147, 31)
        Lblguestlist.TabIndex = 1
        Lblguestlist.Text = "VIEW USERS"
        ' 
        ' viewuser
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Menu
        ClientSize = New Size(1077, 792)
        Controls.Add(Tabcontrolusers)
        Controls.Add(Lblguestlist)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Name = "viewuser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Search User"
        CType(DGV_users, ComponentModel.ISupportInitialize).EndInit()
        Tabcontrolusers.ResumeLayout(False)
        TabPageViewUser.ResumeLayout(False)
        TabPageViewUser.PerformLayout()
        updateusertabpage.ResumeLayout(False)
        updateusertabpage.PerformLayout()
        TabPagedeluser.ResumeLayout(False)
        TabPagedeluser.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DGV_users As DataGridView
    Friend WithEvents searchkeyword_txtbx As TextBox
    Friend WithEvents Tabcontrolusers As TabControl
    Friend WithEvents TabPageViewUser As TabPage
    Friend WithEvents updateusertabpage As TabPage
    Friend WithEvents Lbl_anykeyword As Label
    Friend WithEvents updateuser_Btn As Button
    Friend WithEvents Lbl_msggender As Label
    Friend WithEvents Lbl_msgaddress As Label
    Friend WithEvents Lbl_msgDOB As Label
    Friend WithEvents Lbl_msglastname As Label
    Friend WithEvents Lbl_msgphone As Label
    Friend WithEvents Lbl_msgusername As Label
    Friend WithEvents Lbl_msgusertype As Label
    Friend WithEvents Lbl_msgfirstname As Label
    Friend WithEvents userDOB_dtp As DateTimePicker
    Friend WithEvents usertype_cmbbx As ComboBox
    Friend WithEvents gender_cmbbx As ComboBox
    Friend WithEvents userln_txtbx As TextBox
    Friend WithEvents userAddress_txtbx As TextBox
    Friend WithEvents userPhone_txtbx As TextBox
    Friend WithEvents username_txtbx As TextBox
    Friend WithEvents password_txtbx As TextBox
    Friend WithEvents userfn_txtbx As TextBox
    Friend WithEvents LblLastname As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblGender As Label
    Friend WithEvents LblUsertype As Label
    Friend WithEvents LblPhonenumber As Label
    Friend WithEvents LblAddress As Label
    Friend WithEvents LblDOB As Label
    Friend WithEvents LblFirstname As Label
    Friend WithEvents Lbl_msgpassword As Label
    Friend WithEvents TabPagedeluser As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Lbl_username As Label
    Friend WithEvents Lbl_userid As Label
    Friend WithEvents userdel_btn As Button
    Friend WithEvents usernamedel_txtbx As TextBox
    Friend WithEvents usertypedel_cmbbx As ComboBox
    Friend WithEvents Lbl_upuserid As Label
    Friend WithEvents Lbl_useridshow As Label
    Friend WithEvents Lbl_useridshowdel As Label
    Friend WithEvents Lblguestlist As Label
End Class
