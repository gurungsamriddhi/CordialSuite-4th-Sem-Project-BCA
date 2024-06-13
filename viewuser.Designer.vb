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
        searchusername_txtbx = New TextBox()
        Panel1 = New Panel()
        closebtn = New Button()
        Lblguestlist = New Label()
        Tabcontrolusers = New TabControl()
        TabPageViewUser = New TabPage()
        Label1 = New Label()
        update_deletetabpage = New TabPage()
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
        confirmpw_txtbx = New TextBox()
        userfn_txtbx = New TextBox()
        LblLastname = New Label()
        LblPassword = New Label()
        LblUsername = New Label()
        LblGender = New Label()
        LblUsertype = New Label()
        LblPhonenumber = New Label()
        LblAddress = New Label()
        LblConfirmpw = New Label()
        LblDOB = New Label()
        LblFirstname = New Label()
        deluser_Btn = New Button()
        updateuser_Btn = New Button()
        CType(DGV_users, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Tabcontrolusers.SuspendLayout()
        TabPageViewUser.SuspendLayout()
        update_deletetabpage.SuspendLayout()
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
        DGV_users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV_users.BackgroundColor = SystemColors.MenuBar
        DGV_users.BorderStyle = BorderStyle.None
        DGV_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_users.GridColor = Color.Black
        DGV_users.Location = New Point(22, 152)
        DGV_users.Name = "DGV_users"
        DGV_users.ReadOnly = True
        DGV_users.RowHeadersWidth = 51
        DGV_users.Size = New Size(923, 438)
        DGV_users.TabIndex = 6
        ' 
        ' searchusername_txtbx
        ' 
        searchusername_txtbx.Anchor = AnchorStyles.None
        searchusername_txtbx.BackColor = SystemColors.ControlLightLight
        searchusername_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchusername_txtbx.ForeColor = Color.Black
        searchusername_txtbx.Location = New Point(355, 89)
        searchusername_txtbx.Name = "searchusername_txtbx"
        searchusername_txtbx.Size = New Size(285, 38)
        searchusername_txtbx.TabIndex = 7
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Panel1.Controls.Add(closebtn)
        Panel1.Controls.Add(Lblguestlist)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1000, 58)
        Panel1.TabIndex = 9
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.Transparent
        closebtn.FlatAppearance.BorderColor = Color.White
        closebtn.FlatAppearance.BorderSize = 2
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = SystemColors.Window
        closebtn.Location = New Point(949, 3)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(48, 48)
        closebtn.TabIndex = 12
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Lblguestlist
        ' 
        Lblguestlist.AutoSize = True
        Lblguestlist.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblguestlist.ForeColor = SystemColors.ControlLightLight
        Lblguestlist.Location = New Point(402, 12)
        Lblguestlist.Name = "Lblguestlist"
        Lblguestlist.Size = New Size(147, 31)
        Lblguestlist.TabIndex = 1
        Lblguestlist.Text = "VIEW USERS"
        ' 
        ' Tabcontrolusers
        ' 
        Tabcontrolusers.Alignment = TabAlignment.Bottom
        Tabcontrolusers.Anchor = AnchorStyles.None
        Tabcontrolusers.Controls.Add(TabPageViewUser)
        Tabcontrolusers.Controls.Add(update_deletetabpage)
        Tabcontrolusers.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Tabcontrolusers.Location = New Point(12, 80)
        Tabcontrolusers.Name = "Tabcontrolusers"
        Tabcontrolusers.SelectedIndex = 0
        Tabcontrolusers.Size = New Size(976, 658)
        Tabcontrolusers.TabIndex = 10
        ' 
        ' TabPageViewUser
        ' 
        TabPageViewUser.Controls.Add(Label1)
        TabPageViewUser.Controls.Add(DGV_users)
        TabPageViewUser.Controls.Add(searchusername_txtbx)
        TabPageViewUser.Location = New Point(4, 4)
        TabPageViewUser.Name = "TabPageViewUser"
        TabPageViewUser.Padding = New Padding(3)
        TabPageViewUser.Size = New Size(968, 622)
        TabPageViewUser.TabIndex = 0
        TabPageViewUser.Text = "Search User"
        TabPageViewUser.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(355, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 25)
        Label1.TabIndex = 9
        Label1.Text = "Username :"
        ' 
        ' update_deletetabpage
        ' 
        update_deletetabpage.Controls.Add(Lbl_msggender)
        update_deletetabpage.Controls.Add(Lbl_msgaddress)
        update_deletetabpage.Controls.Add(Lbl_msgDOB)
        update_deletetabpage.Controls.Add(Lbl_msglastname)
        update_deletetabpage.Controls.Add(Lbl_msgphone)
        update_deletetabpage.Controls.Add(Lbl_msgusername)
        update_deletetabpage.Controls.Add(Lbl_msgusertype)
        update_deletetabpage.Controls.Add(Lbl_msgfirstname)
        update_deletetabpage.Controls.Add(userDOB_dtp)
        update_deletetabpage.Controls.Add(usertype_cmbbx)
        update_deletetabpage.Controls.Add(gender_cmbbx)
        update_deletetabpage.Controls.Add(userln_txtbx)
        update_deletetabpage.Controls.Add(userAddress_txtbx)
        update_deletetabpage.Controls.Add(userPhone_txtbx)
        update_deletetabpage.Controls.Add(username_txtbx)
        update_deletetabpage.Controls.Add(password_txtbx)
        update_deletetabpage.Controls.Add(confirmpw_txtbx)
        update_deletetabpage.Controls.Add(userfn_txtbx)
        update_deletetabpage.Controls.Add(LblLastname)
        update_deletetabpage.Controls.Add(LblPassword)
        update_deletetabpage.Controls.Add(LblUsername)
        update_deletetabpage.Controls.Add(LblGender)
        update_deletetabpage.Controls.Add(LblUsertype)
        update_deletetabpage.Controls.Add(LblPhonenumber)
        update_deletetabpage.Controls.Add(LblAddress)
        update_deletetabpage.Controls.Add(LblConfirmpw)
        update_deletetabpage.Controls.Add(LblDOB)
        update_deletetabpage.Controls.Add(LblFirstname)
        update_deletetabpage.Controls.Add(deluser_Btn)
        update_deletetabpage.Controls.Add(updateuser_Btn)
        update_deletetabpage.Location = New Point(4, 4)
        update_deletetabpage.Name = "update_deletetabpage"
        update_deletetabpage.Padding = New Padding(3)
        update_deletetabpage.Size = New Size(968, 622)
        update_deletetabpage.TabIndex = 1
        update_deletetabpage.Text = "Update and Delete User"
        update_deletetabpage.UseVisualStyleBackColor = True
        ' 
        ' Lbl_msggender
        ' 
        Lbl_msggender.AutoSize = True
        Lbl_msggender.ForeColor = SystemColors.ControlLightLight
        Lbl_msggender.Location = New Point(147, 330)
        Lbl_msggender.Name = "Lbl_msggender"
        Lbl_msggender.Size = New Size(0, 23)
        Lbl_msggender.TabIndex = 66
        ' 
        ' Lbl_msgaddress
        ' 
        Lbl_msgaddress.AutoSize = True
        Lbl_msgaddress.ForeColor = SystemColors.ControlLightLight
        Lbl_msgaddress.Location = New Point(147, 222)
        Lbl_msgaddress.Name = "Lbl_msgaddress"
        Lbl_msgaddress.Size = New Size(0, 23)
        Lbl_msgaddress.TabIndex = 65
        ' 
        ' Lbl_msgDOB
        ' 
        Lbl_msgDOB.AutoSize = True
        Lbl_msgDOB.ForeColor = SystemColors.ControlLightLight
        Lbl_msgDOB.Location = New Point(551, 223)
        Lbl_msgDOB.Name = "Lbl_msgDOB"
        Lbl_msgDOB.Size = New Size(0, 23)
        Lbl_msgDOB.TabIndex = 64
        ' 
        ' Lbl_msglastname
        ' 
        Lbl_msglastname.AutoSize = True
        Lbl_msglastname.BackColor = Color.Transparent
        Lbl_msglastname.Font = New Font("Segoe UI", 9F)
        Lbl_msglastname.ForeColor = Color.Black
        Lbl_msglastname.Location = New Point(551, 140)
        Lbl_msglastname.Name = "Lbl_msglastname"
        Lbl_msglastname.Size = New Size(0, 20)
        Lbl_msglastname.TabIndex = 63
        ' 
        ' Lbl_msgphone
        ' 
        Lbl_msgphone.AutoSize = True
        Lbl_msgphone.ForeColor = Color.Black
        Lbl_msgphone.Location = New Point(551, 326)
        Lbl_msgphone.Name = "Lbl_msgphone"
        Lbl_msgphone.Size = New Size(0, 23)
        Lbl_msgphone.TabIndex = 62
        ' 
        ' Lbl_msgusername
        ' 
        Lbl_msgusername.AutoSize = True
        Lbl_msgusername.ForeColor = Color.Black
        Lbl_msgusername.Location = New Point(147, 434)
        Lbl_msgusername.Name = "Lbl_msgusername"
        Lbl_msgusername.Size = New Size(0, 23)
        Lbl_msgusername.TabIndex = 61
        ' 
        ' Lbl_msgusertype
        ' 
        Lbl_msgusertype.AutoSize = True
        Lbl_msgusertype.ForeColor = Color.Black
        Lbl_msgusertype.Location = New Point(551, 434)
        Lbl_msgusertype.Name = "Lbl_msgusertype"
        Lbl_msgusertype.Size = New Size(0, 23)
        Lbl_msgusertype.TabIndex = 60
        ' 
        ' Lbl_msgfirstname
        ' 
        Lbl_msgfirstname.AutoSize = True
        Lbl_msgfirstname.BackColor = Color.Transparent
        Lbl_msgfirstname.Font = New Font("Segoe UI", 9F)
        Lbl_msgfirstname.ForeColor = Color.Black
        Lbl_msgfirstname.Location = New Point(147, 140)
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
        userDOB_dtp.Location = New Point(551, 190)
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
        usertype_cmbbx.Location = New Point(551, 400)
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
        gender_cmbbx.Location = New Point(147, 296)
        gender_cmbbx.Name = "gender_cmbbx"
        gender_cmbbx.Size = New Size(272, 31)
        gender_cmbbx.TabIndex = 56
        ' 
        ' userln_txtbx
        ' 
        userln_txtbx.BackColor = SystemColors.ControlLightLight
        userln_txtbx.Font = New Font("Segoe UI", 10.8F)
        userln_txtbx.ForeColor = Color.Black
        userln_txtbx.Location = New Point(551, 77)
        userln_txtbx.Name = "userln_txtbx"
        userln_txtbx.Size = New Size(272, 31)
        userln_txtbx.TabIndex = 55
        ' 
        ' userAddress_txtbx
        ' 
        userAddress_txtbx.BackColor = SystemColors.ControlLightLight
        userAddress_txtbx.Font = New Font("Segoe UI", 10.2F)
        userAddress_txtbx.ForeColor = Color.Black
        userAddress_txtbx.Location = New Point(147, 189)
        userAddress_txtbx.Name = "userAddress_txtbx"
        userAddress_txtbx.Size = New Size(272, 30)
        userAddress_txtbx.TabIndex = 54
        ' 
        ' userPhone_txtbx
        ' 
        userPhone_txtbx.BackColor = SystemColors.ControlLightLight
        userPhone_txtbx.Font = New Font("Segoe UI", 10.2F)
        userPhone_txtbx.ForeColor = Color.Black
        userPhone_txtbx.Location = New Point(551, 295)
        userPhone_txtbx.Name = "userPhone_txtbx"
        userPhone_txtbx.Size = New Size(272, 30)
        userPhone_txtbx.TabIndex = 53
        ' 
        ' username_txtbx
        ' 
        username_txtbx.BackColor = SystemColors.ControlLightLight
        username_txtbx.Font = New Font("Segoe UI", 10.2F)
        username_txtbx.ForeColor = Color.Black
        username_txtbx.Location = New Point(147, 401)
        username_txtbx.Name = "username_txtbx"
        username_txtbx.Size = New Size(272, 30)
        username_txtbx.TabIndex = 52
        ' 
        ' password_txtbx
        ' 
        password_txtbx.BackColor = SystemColors.ControlLightLight
        password_txtbx.Font = New Font("Segoe UI", 10.2F)
        password_txtbx.ForeColor = Color.Black
        password_txtbx.Location = New Point(147, 506)
        password_txtbx.Name = "password_txtbx"
        password_txtbx.Size = New Size(272, 30)
        password_txtbx.TabIndex = 51
        ' 
        ' confirmpw_txtbx
        ' 
        confirmpw_txtbx.BackColor = SystemColors.ControlLightLight
        confirmpw_txtbx.Font = New Font("Segoe UI", 10.2F)
        confirmpw_txtbx.ForeColor = Color.Black
        confirmpw_txtbx.Location = New Point(551, 506)
        confirmpw_txtbx.Name = "confirmpw_txtbx"
        confirmpw_txtbx.Size = New Size(272, 30)
        confirmpw_txtbx.TabIndex = 50
        ' 
        ' userfn_txtbx
        ' 
        userfn_txtbx.BackColor = SystemColors.ControlLightLight
        userfn_txtbx.Font = New Font("Segoe UI", 10.8F)
        userfn_txtbx.ForeColor = Color.Black
        userfn_txtbx.Location = New Point(147, 77)
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
        LblLastname.Location = New Point(551, 46)
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
        LblPassword.Location = New Point(145, 477)
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
        LblUsername.Location = New Point(145, 370)
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
        LblGender.Location = New Point(145, 265)
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
        LblUsertype.Location = New Point(551, 370)
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
        LblPhonenumber.Location = New Point(551, 265)
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
        LblAddress.Location = New Point(145, 158)
        LblAddress.Name = "LblAddress"
        LblAddress.Size = New Size(85, 28)
        LblAddress.TabIndex = 42
        LblAddress.Text = "Address"
        LblAddress.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblConfirmpw
        ' 
        LblConfirmpw.AutoSize = True
        LblConfirmpw.FlatStyle = FlatStyle.Flat
        LblConfirmpw.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LblConfirmpw.ForeColor = Color.Black
        LblConfirmpw.Location = New Point(550, 477)
        LblConfirmpw.Name = "LblConfirmpw"
        LblConfirmpw.Size = New Size(176, 28)
        LblConfirmpw.TabIndex = 41
        LblConfirmpw.Text = "Confirm Password"
        LblConfirmpw.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblDOB
        ' 
        LblDOB.AutoSize = True
        LblDOB.BackColor = Color.Transparent
        LblDOB.FlatStyle = FlatStyle.Flat
        LblDOB.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LblDOB.ForeColor = Color.Black
        LblDOB.Location = New Point(551, 159)
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
        LblFirstname.Location = New Point(145, 46)
        LblFirstname.Name = "LblFirstname"
        LblFirstname.Size = New Size(110, 28)
        LblFirstname.TabIndex = 39
        LblFirstname.Text = "First Name"
        LblFirstname.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' deluser_Btn
        ' 
        deluser_Btn.BackColor = Color.Red
        deluser_Btn.FlatAppearance.BorderColor = SystemColors.Window
        deluser_Btn.FlatAppearance.BorderSize = 2
        deluser_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(204), CByte(0), CByte(0))
        deluser_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(204), CByte(0), CByte(0))
        deluser_Btn.FlatStyle = FlatStyle.Flat
        deluser_Btn.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        deluser_Btn.ForeColor = SystemColors.Window
        deluser_Btn.Location = New Point(500, 562)
        deluser_Btn.Name = "deluser_Btn"
        deluser_Btn.Size = New Size(194, 54)
        deluser_Btn.TabIndex = 13
        deluser_Btn.Text = "Delete"
        deluser_Btn.UseVisualStyleBackColor = False
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
        updateuser_Btn.Location = New Point(288, 562)
        updateuser_Btn.Name = "updateuser_Btn"
        updateuser_Btn.Size = New Size(192, 54)
        updateuser_Btn.TabIndex = 12
        updateuser_Btn.Text = "Update"
        updateuser_Btn.UseVisualStyleBackColor = False
        ' 
        ' viewuser
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 750)
        Controls.Add(Tabcontrolusers)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Name = "viewuser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Search User"
        CType(DGV_users, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Tabcontrolusers.ResumeLayout(False)
        TabPageViewUser.ResumeLayout(False)
        TabPageViewUser.PerformLayout()
        update_deletetabpage.ResumeLayout(False)
        update_deletetabpage.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DGV_users As DataGridView
    Friend WithEvents searchusername_txtbx As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents closebtn As Button
    Friend WithEvents Lblguestlist As Label
    Friend WithEvents Tabcontrolusers As TabControl
    Friend WithEvents TabPageViewUser As TabPage
    Friend WithEvents update_deletetabpage As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents updateuser_Btn As Button
    Friend WithEvents deluser_Btn As Button
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
    Friend WithEvents confirmpw_txtbx As TextBox
    Friend WithEvents userfn_txtbx As TextBox
    Friend WithEvents LblLastname As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblGender As Label
    Friend WithEvents LblUsertype As Label
    Friend WithEvents LblPhonenumber As Label
    Friend WithEvents LblAddress As Label
    Friend WithEvents LblConfirmpw As Label
    Friend WithEvents LblDOB As Label
    Friend WithEvents LblFirstname As Label
End Class
