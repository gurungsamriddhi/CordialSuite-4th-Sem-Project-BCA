<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Viewemployee
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        close_Btn = New Button()
        closebtn = New Button()
        Lblviewg = New Label()
        Tabcontrolusers = New TabControl()
        TabPageViewemployee = New TabPage()
        Label1 = New Label()
        DGV_employee = New DataGridView()
        searchkeyword_txtbx = New TextBox()
        updateemployeetabpage = New TabPage()
        Lbl_useridshow = New Label()
        Lbl_upuserid = New Label()
        Lbl_msggender = New Label()
        Lbl_msgaddress = New Label()
        Lbl_msgDOB = New Label()
        Lbl_msglastname = New Label()
        Lbl_msgphone = New Label()
        Lbl_msgusertype = New Label()
        Lbl_msgfirstname = New Label()
        userDOB_dtp = New DateTimePicker()
        usertype_cmbbx = New ComboBox()
        gender_cmbbx = New ComboBox()
        userln_txtbx = New TextBox()
        userAddress_txtbx = New TextBox()
        userPhone_txtbx = New TextBox()
        userfn_txtbx = New TextBox()
        LblLastname = New Label()
        LblGender = New Label()
        LblUsertype = New Label()
        LblPhonenumber = New Label()
        LblAddress = New Label()
        LblDOB = New Label()
        LblFirstname = New Label()
        updateemployee_Btn = New Button()
        Panel1.SuspendLayout()
        Tabcontrolusers.SuspendLayout()
        TabPageViewemployee.SuspendLayout()
        CType(DGV_employee, ComponentModel.ISupportInitialize).BeginInit()
        updateemployeetabpage.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Panel1.Controls.Add(close_Btn)
        Panel1.Controls.Add(closebtn)
        Panel1.Controls.Add(Lblviewg)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1037, 57)
        Panel1.TabIndex = 63
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
        close_Btn.Location = New Point(991, 9)
        close_Btn.Name = "close_Btn"
        close_Btn.Size = New Size(43, 42)
        close_Btn.TabIndex = 24
        close_Btn.Text = "X"
        close_Btn.UseVisualStyleBackColor = False
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = SystemColors.ControlLightLight
        closebtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        closebtn.Location = New Point(431, 313)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(47, 35)
        closebtn.TabIndex = 23
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Lblviewg
        ' 
        Lblviewg.AutoSize = True
        Lblviewg.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblviewg.ForeColor = SystemColors.Window
        Lblviewg.Location = New Point(377, 9)
        Lblviewg.Name = "Lblviewg"
        Lblviewg.Size = New Size(204, 31)
        Lblviewg.TabIndex = 23
        Lblviewg.Text = "VIEW EMPLOYEES"
        ' 
        ' Tabcontrolusers
        ' 
        Tabcontrolusers.Alignment = TabAlignment.Bottom
        Tabcontrolusers.Controls.Add(TabPageViewemployee)
        Tabcontrolusers.Controls.Add(updateemployeetabpage)
        Tabcontrolusers.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Tabcontrolusers.Location = New Point(26, 63)
        Tabcontrolusers.Name = "Tabcontrolusers"
        Tabcontrolusers.SelectedIndex = 0
        Tabcontrolusers.Size = New Size(985, 717)
        Tabcontrolusers.TabIndex = 64
        ' 
        ' TabPageViewemployee
        ' 
        TabPageViewemployee.Controls.Add(Label1)
        TabPageViewemployee.Controls.Add(DGV_employee)
        TabPageViewemployee.Controls.Add(searchkeyword_txtbx)
        TabPageViewemployee.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabPageViewemployee.Location = New Point(4, 4)
        TabPageViewemployee.Name = "TabPageViewemployee"
        TabPageViewemployee.Padding = New Padding(3)
        TabPageViewemployee.Size = New Size(977, 676)
        TabPageViewemployee.TabIndex = 0
        TabPageViewemployee.Text = "Search Employee"
        TabPageViewemployee.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(226, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 25)
        Label1.TabIndex = 9
        Label1.Text = "Any Keyword:"
        ' 
        ' DGV_employee
        ' 
        DGV_employee.AllowUserToAddRows = False
        DGV_employee.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.White
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DGV_employee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        DGV_employee.Anchor = AnchorStyles.None
        DGV_employee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DGV_employee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DGV_employee.BackgroundColor = SystemColors.MenuBar
        DGV_employee.BorderStyle = BorderStyle.None
        DGV_employee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_employee.GridColor = Color.Black
        DGV_employee.Location = New Point(30, 136)
        DGV_employee.Name = "DGV_employee"
        DGV_employee.ReadOnly = True
        DGV_employee.RowHeadersWidth = 51
        DGV_employee.Size = New Size(923, 495)
        DGV_employee.TabIndex = 6
        ' 
        ' searchkeyword_txtbx
        ' 
        searchkeyword_txtbx.Anchor = AnchorStyles.None
        searchkeyword_txtbx.BackColor = SystemColors.ControlLightLight
        searchkeyword_txtbx.BorderStyle = BorderStyle.FixedSingle
        searchkeyword_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchkeyword_txtbx.ForeColor = Color.Black
        searchkeyword_txtbx.Location = New Point(363, 78)
        searchkeyword_txtbx.Multiline = True
        searchkeyword_txtbx.Name = "searchkeyword_txtbx"
        searchkeyword_txtbx.Size = New Size(324, 47)
        searchkeyword_txtbx.TabIndex = 7
        ' 
        ' updateemployeetabpage
        ' 
        updateemployeetabpage.Controls.Add(Lbl_useridshow)
        updateemployeetabpage.Controls.Add(Lbl_upuserid)
        updateemployeetabpage.Controls.Add(Lbl_msggender)
        updateemployeetabpage.Controls.Add(Lbl_msgaddress)
        updateemployeetabpage.Controls.Add(Lbl_msgDOB)
        updateemployeetabpage.Controls.Add(Lbl_msglastname)
        updateemployeetabpage.Controls.Add(Lbl_msgphone)
        updateemployeetabpage.Controls.Add(Lbl_msgusertype)
        updateemployeetabpage.Controls.Add(Lbl_msgfirstname)
        updateemployeetabpage.Controls.Add(userDOB_dtp)
        updateemployeetabpage.Controls.Add(usertype_cmbbx)
        updateemployeetabpage.Controls.Add(gender_cmbbx)
        updateemployeetabpage.Controls.Add(userln_txtbx)
        updateemployeetabpage.Controls.Add(userAddress_txtbx)
        updateemployeetabpage.Controls.Add(userPhone_txtbx)
        updateemployeetabpage.Controls.Add(userfn_txtbx)
        updateemployeetabpage.Controls.Add(LblLastname)
        updateemployeetabpage.Controls.Add(LblGender)
        updateemployeetabpage.Controls.Add(LblUsertype)
        updateemployeetabpage.Controls.Add(LblPhonenumber)
        updateemployeetabpage.Controls.Add(LblAddress)
        updateemployeetabpage.Controls.Add(LblDOB)
        updateemployeetabpage.Controls.Add(LblFirstname)
        updateemployeetabpage.Controls.Add(updateemployee_Btn)
        updateemployeetabpage.Location = New Point(4, 4)
        updateemployeetabpage.Name = "updateemployeetabpage"
        updateemployeetabpage.Padding = New Padding(3)
        updateemployeetabpage.Size = New Size(977, 676)
        updateemployeetabpage.TabIndex = 1
        updateemployeetabpage.Text = "Update Employee Information"
        updateemployeetabpage.UseVisualStyleBackColor = True
        ' 
        ' Lbl_useridshow
        ' 
        Lbl_useridshow.AutoSize = True
        Lbl_useridshow.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_useridshow.ForeColor = SystemColors.ControlText
        Lbl_useridshow.Location = New Point(244, 36)
        Lbl_useridshow.Name = "Lbl_useridshow"
        Lbl_useridshow.Size = New Size(0, 28)
        Lbl_useridshow.TabIndex = 70
        ' 
        ' Lbl_upuserid
        ' 
        Lbl_upuserid.AutoSize = True
        Lbl_upuserid.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_upuserid.ForeColor = Color.Red
        Lbl_upuserid.Location = New Point(148, 36)
        Lbl_upuserid.Name = "Lbl_upuserid"
        Lbl_upuserid.Size = New Size(90, 28)
        Lbl_upuserid.TabIndex = 69
        Lbl_upuserid.Text = "USER ID:"
        ' 
        ' Lbl_msggender
        ' 
        Lbl_msggender.AutoSize = True
        Lbl_msggender.ForeColor = SystemColors.ControlLightLight
        Lbl_msggender.Location = New Point(153, 512)
        Lbl_msggender.Name = "Lbl_msggender"
        Lbl_msggender.Size = New Size(0, 28)
        Lbl_msggender.TabIndex = 66
        ' 
        ' Lbl_msgaddress
        ' 
        Lbl_msgaddress.AutoSize = True
        Lbl_msgaddress.ForeColor = SystemColors.ControlLightLight
        Lbl_msgaddress.Location = New Point(150, 263)
        Lbl_msgaddress.Name = "Lbl_msgaddress"
        Lbl_msgaddress.Size = New Size(0, 28)
        Lbl_msgaddress.TabIndex = 65
        ' 
        ' Lbl_msgDOB
        ' 
        Lbl_msgDOB.AutoSize = True
        Lbl_msgDOB.ForeColor = SystemColors.ControlLightLight
        Lbl_msgDOB.Location = New Point(155, 385)
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
        Lbl_msglastname.Location = New Point(573, 167)
        Lbl_msglastname.Name = "Lbl_msglastname"
        Lbl_msglastname.Size = New Size(0, 20)
        Lbl_msglastname.TabIndex = 63
        ' 
        ' Lbl_msgphone
        ' 
        Lbl_msgphone.AutoSize = True
        Lbl_msgphone.ForeColor = Color.Black
        Lbl_msgphone.Location = New Point(569, 381)
        Lbl_msgphone.Name = "Lbl_msgphone"
        Lbl_msgphone.Size = New Size(0, 28)
        Lbl_msgphone.TabIndex = 62
        ' 
        ' Lbl_msgusertype
        ' 
        Lbl_msgusertype.AutoSize = True
        Lbl_msgusertype.ForeColor = Color.Black
        Lbl_msgusertype.Location = New Point(564, 512)
        Lbl_msgusertype.Name = "Lbl_msgusertype"
        Lbl_msgusertype.Size = New Size(0, 28)
        Lbl_msgusertype.TabIndex = 60
        ' 
        ' Lbl_msgfirstname
        ' 
        Lbl_msgfirstname.AutoSize = True
        Lbl_msgfirstname.BackColor = Color.Transparent
        Lbl_msgfirstname.Font = New Font("Segoe UI", 9F)
        Lbl_msgfirstname.ForeColor = Color.Black
        Lbl_msgfirstname.Location = New Point(151, 167)
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
        userDOB_dtp.Location = New Point(152, 349)
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
        usertype_cmbbx.Items.AddRange(New Object() {"User"})
        usertype_cmbbx.Location = New Point(561, 475)
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
        gender_cmbbx.Location = New Point(150, 475)
        gender_cmbbx.Name = "gender_cmbbx"
        gender_cmbbx.Size = New Size(272, 31)
        gender_cmbbx.TabIndex = 56
        ' 
        ' userln_txtbx
        ' 
        userln_txtbx.BackColor = SystemColors.ControlLightLight
        userln_txtbx.Font = New Font("Segoe UI", 10.8F)
        userln_txtbx.ForeColor = Color.Black
        userln_txtbx.Location = New Point(570, 130)
        userln_txtbx.Name = "userln_txtbx"
        userln_txtbx.Size = New Size(286, 31)
        userln_txtbx.TabIndex = 55
        ' 
        ' userAddress_txtbx
        ' 
        userAddress_txtbx.BackColor = SystemColors.ControlLightLight
        userAddress_txtbx.Font = New Font("Segoe UI", 10.2F)
        userAddress_txtbx.ForeColor = Color.Black
        userAddress_txtbx.Location = New Point(147, 227)
        userAddress_txtbx.Name = "userAddress_txtbx"
        userAddress_txtbx.Size = New Size(710, 30)
        userAddress_txtbx.TabIndex = 54
        ' 
        ' userPhone_txtbx
        ' 
        userPhone_txtbx.BackColor = SystemColors.ControlLightLight
        userPhone_txtbx.Font = New Font("Segoe UI", 10.2F)
        userPhone_txtbx.ForeColor = Color.Black
        userPhone_txtbx.Location = New Point(563, 348)
        userPhone_txtbx.Name = "userPhone_txtbx"
        userPhone_txtbx.Size = New Size(272, 30)
        userPhone_txtbx.TabIndex = 53
        ' 
        ' userfn_txtbx
        ' 
        userfn_txtbx.BackColor = SystemColors.ControlLightLight
        userfn_txtbx.Font = New Font("Segoe UI", 10.8F)
        userfn_txtbx.ForeColor = Color.Black
        userfn_txtbx.Location = New Point(148, 130)
        userfn_txtbx.Name = "userfn_txtbx"
        userfn_txtbx.Size = New Size(325, 31)
        userfn_txtbx.TabIndex = 49
        ' 
        ' LblLastname
        ' 
        LblLastname.AutoSize = True
        LblLastname.FlatStyle = FlatStyle.Flat
        LblLastname.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LblLastname.ForeColor = Color.Black
        LblLastname.Location = New Point(573, 102)
        LblLastname.Name = "LblLastname"
        LblLastname.Size = New Size(108, 28)
        LblLastname.TabIndex = 48
        LblLastname.Text = "Last Name"
        LblLastname.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblGender
        ' 
        LblGender.AutoSize = True
        LblGender.BackColor = Color.Transparent
        LblGender.FlatStyle = FlatStyle.Flat
        LblGender.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LblGender.ForeColor = Color.Black
        LblGender.Location = New Point(151, 447)
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
        LblUsertype.Location = New Point(561, 444)
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
        LblPhonenumber.Location = New Point(566, 321)
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
        LblAddress.Location = New Point(148, 199)
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
        LblDOB.Location = New Point(155, 321)
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
        LblFirstname.Location = New Point(149, 102)
        LblFirstname.Name = "LblFirstname"
        LblFirstname.Size = New Size(110, 28)
        LblFirstname.TabIndex = 39
        LblFirstname.Text = "First Name"
        LblFirstname.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' updateemployee_Btn
        ' 
        updateemployee_Btn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        updateemployee_Btn.FlatAppearance.BorderColor = SystemColors.Window
        updateemployee_Btn.FlatAppearance.BorderSize = 2
        updateemployee_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        updateemployee_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        updateemployee_Btn.FlatStyle = FlatStyle.Flat
        updateemployee_Btn.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        updateemployee_Btn.ForeColor = SystemColors.Window
        updateemployee_Btn.Location = New Point(401, 591)
        updateemployee_Btn.Name = "updateemployee_Btn"
        updateemployee_Btn.Size = New Size(192, 54)
        updateemployee_Btn.TabIndex = 12
        updateemployee_Btn.Text = "Update"
        updateemployee_Btn.UseVisualStyleBackColor = False
        ' 
        ' Viewemployee
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1037, 792)
        Controls.Add(Tabcontrolusers)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Viewemployee"
        Text = "Viewemployee"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Tabcontrolusers.ResumeLayout(False)
        TabPageViewemployee.ResumeLayout(False)
        TabPageViewemployee.PerformLayout()
        CType(DGV_employee, ComponentModel.ISupportInitialize).EndInit()
        updateemployeetabpage.ResumeLayout(False)
        updateemployeetabpage.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents close_Btn As Button
    Friend WithEvents closebtn As Button
    Friend WithEvents Lblviewg As Label
    Friend WithEvents Tabcontrolusers As TabControl
    Friend WithEvents TabPageViewemployee As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents DGV_employee As DataGridView
    Friend WithEvents searchkeyword_txtbx As TextBox
    Friend WithEvents updateemployeetabpage As TabPage
    Friend WithEvents Lbl_useridshow As Label
    Friend WithEvents Lbl_upuserid As Label
    Friend WithEvents Lbl_msggender As Label
    Friend WithEvents Lbl_msgaddress As Label
    Friend WithEvents Lbl_msgDOB As Label
    Friend WithEvents Lbl_msglastname As Label
    Friend WithEvents Lbl_msgphone As Label
    Friend WithEvents Lbl_msgusertype As Label
    Friend WithEvents Lbl_msgfirstname As Label
    Friend WithEvents userDOB_dtp As DateTimePicker
    Friend WithEvents usertype_cmbbx As ComboBox
    Friend WithEvents gender_cmbbx As ComboBox
    Friend WithEvents userln_txtbx As TextBox
    Friend WithEvents userAddress_txtbx As TextBox
    Friend WithEvents userPhone_txtbx As TextBox
    Friend WithEvents userfn_txtbx As TextBox
    Friend WithEvents LblLastname As Label
    Friend WithEvents LblGender As Label
    Friend WithEvents LblUsertype As Label
    Friend WithEvents LblPhonenumber As Label
    Friend WithEvents LblAddress As Label
    Friend WithEvents LblDOB As Label
    Friend WithEvents LblFirstname As Label
    Friend WithEvents updateemployee_Btn As Button
End Class
