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
        LabelName = New Label()
        LabelDOB = New Label()
        Label2 = New Label()
        LabelAddress = New Label()
        LabelPhonenumber = New Label()
        LabelRole = New Label()
        LabelGender = New Label()
        LabelUsername = New Label()
        LabelPassword = New Label()
        Panelregister = New Panel()
        DOBdtp = New DateTimePicker()
        role_combobx = New ComboBox()
        gender_combobx = New ComboBox()
        ln_txtbx = New TextBox()
        As_txtbx = New TextBox()
        Phone_txtbx = New TextBox()
        username_txtbx = New TextBox()
        password_txtbx = New TextBox()
        confirmpw_txtbx = New TextBox()
        Panel2 = New Panel()
        Panel1 = New Panel()
        Button1 = New Button()
        fn_txtbx = New TextBox()
        LabelLastname = New Label()
        Panelregister.SuspendLayout()
        SuspendLayout()
        ' 
        ' LabelName
        ' 
        LabelName.AutoSize = True
        LabelName.BackColor = Color.Transparent
        LabelName.FlatStyle = FlatStyle.Flat
        LabelName.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LabelName.ForeColor = SystemColors.ControlLightLight
        LabelName.Location = New Point(191, 87)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(93, 23)
        LabelName.TabIndex = 0
        LabelName.Text = "First Name"
        LabelName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelDOB
        ' 
        LabelDOB.AutoSize = True
        LabelDOB.FlatStyle = FlatStyle.Flat
        LabelDOB.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LabelDOB.ForeColor = SystemColors.ControlLightLight
        LabelDOB.Location = New Point(576, 160)
        LabelDOB.Name = "LabelDOB"
        LabelDOB.Size = New Size(108, 23)
        LabelDOB.TabIndex = 1
        LabelDOB.Text = "Date of Birth"
        LabelDOB.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(576, 388)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 23)
        Label2.TabIndex = 2
        Label2.Text = "Confirm Password"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelAddress
        ' 
        LabelAddress.AutoSize = True
        LabelAddress.FlatStyle = FlatStyle.Flat
        LabelAddress.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LabelAddress.ForeColor = SystemColors.ControlLightLight
        LabelAddress.Location = New Point(189, 160)
        LabelAddress.Name = "LabelAddress"
        LabelAddress.Size = New Size(70, 23)
        LabelAddress.TabIndex = 3
        LabelAddress.Text = "Address"
        LabelAddress.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelPhonenumber
        ' 
        LabelPhonenumber.AutoSize = True
        LabelPhonenumber.FlatStyle = FlatStyle.Flat
        LabelPhonenumber.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LabelPhonenumber.ForeColor = SystemColors.ControlLightLight
        LabelPhonenumber.ImageAlign = ContentAlignment.TopRight
        LabelPhonenumber.Location = New Point(576, 234)
        LabelPhonenumber.Name = "LabelPhonenumber"
        LabelPhonenumber.Size = New Size(119, 23)
        LabelPhonenumber.TabIndex = 4
        LabelPhonenumber.Text = "Phonenumber"
        LabelPhonenumber.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelRole
        ' 
        LabelRole.AutoSize = True
        LabelRole.FlatStyle = FlatStyle.Flat
        LabelRole.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LabelRole.ForeColor = SystemColors.ControlLightLight
        LabelRole.Location = New Point(576, 312)
        LabelRole.Name = "LabelRole"
        LabelRole.Size = New Size(44, 23)
        LabelRole.TabIndex = 5
        LabelRole.Text = "Role"
        LabelRole.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelGender
        ' 
        LabelGender.AutoSize = True
        LabelGender.FlatStyle = FlatStyle.Flat
        LabelGender.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LabelGender.ForeColor = SystemColors.ControlLightLight
        LabelGender.Location = New Point(189, 234)
        LabelGender.Name = "LabelGender"
        LabelGender.Size = New Size(66, 23)
        LabelGender.TabIndex = 6
        LabelGender.Text = "Gender"
        LabelGender.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelUsername
        ' 
        LabelUsername.AutoSize = True
        LabelUsername.FlatStyle = FlatStyle.Flat
        LabelUsername.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LabelUsername.ForeColor = SystemColors.ControlLightLight
        LabelUsername.Location = New Point(191, 312)
        LabelUsername.Name = "LabelUsername"
        LabelUsername.Size = New Size(87, 23)
        LabelUsername.TabIndex = 7
        LabelUsername.Text = "Username"
        LabelUsername.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelPassword
        ' 
        LabelPassword.AutoSize = True
        LabelPassword.FlatStyle = FlatStyle.Flat
        LabelPassword.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LabelPassword.ForeColor = SystemColors.ControlLightLight
        LabelPassword.Location = New Point(189, 388)
        LabelPassword.Name = "LabelPassword"
        LabelPassword.Size = New Size(82, 23)
        LabelPassword.TabIndex = 8
        LabelPassword.Text = "Password"
        LabelPassword.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panelregister
        ' 
        Panelregister.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(70))
        Panelregister.Controls.Add(DOBdtp)
        Panelregister.Controls.Add(role_combobx)
        Panelregister.Controls.Add(gender_combobx)
        Panelregister.Controls.Add(ln_txtbx)
        Panelregister.Controls.Add(As_txtbx)
        Panelregister.Controls.Add(Phone_txtbx)
        Panelregister.Controls.Add(username_txtbx)
        Panelregister.Controls.Add(password_txtbx)
        Panelregister.Controls.Add(confirmpw_txtbx)
        Panelregister.Controls.Add(Panel2)
        Panelregister.Controls.Add(Panel1)
        Panelregister.Controls.Add(Button1)
        Panelregister.Controls.Add(fn_txtbx)
        Panelregister.Controls.Add(LabelLastname)
        Panelregister.Controls.Add(LabelPassword)
        Panelregister.Controls.Add(LabelUsername)
        Panelregister.Controls.Add(LabelGender)
        Panelregister.Controls.Add(LabelRole)
        Panelregister.Controls.Add(LabelPhonenumber)
        Panelregister.Controls.Add(LabelAddress)
        Panelregister.Controls.Add(Label2)
        Panelregister.Controls.Add(LabelDOB)
        Panelregister.Controls.Add(LabelName)
        Panelregister.Dock = DockStyle.Fill
        Panelregister.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Panelregister.Location = New Point(0, 0)
        Panelregister.Name = "Panelregister"
        Panelregister.Size = New Size(970, 590)
        Panelregister.TabIndex = 0
        ' 
        ' DOBdtp
        ' 
        DOBdtp.CalendarFont = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DOBdtp.CalendarForeColor = SystemColors.GradientInactiveCaption
        DOBdtp.CalendarMonthBackground = SystemColors.GradientInactiveCaption
        DOBdtp.CalendarTitleBackColor = SystemColors.GradientActiveCaption
        DOBdtp.CalendarTitleForeColor = SystemColors.GradientInactiveCaption
        DOBdtp.CalendarTrailingForeColor = SystemColors.GradientInactiveCaption
        DOBdtp.Font = New Font("Segoe UI", 10.2F)
        DOBdtp.Format = DateTimePickerFormat.Short
        DOBdtp.Location = New Point(576, 187)
        DOBdtp.Name = "DOBdtp"
        DOBdtp.Size = New Size(235, 30)
        DOBdtp.TabIndex = 25
        ' 
        ' role_combobx
        ' 
        role_combobx.BackColor = SystemColors.Menu
        role_combobx.FlatStyle = FlatStyle.System
        role_combobx.Font = New Font("Segoe UI", 10.2F)
        role_combobx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        role_combobx.FormattingEnabled = True
        role_combobx.Items.AddRange(New Object() {"Admin", "User"})
        role_combobx.Location = New Point(576, 334)
        role_combobx.Name = "role_combobx"
        role_combobx.Size = New Size(235, 31)
        role_combobx.TabIndex = 22
        ' 
        ' gender_combobx
        ' 
        gender_combobx.AutoCompleteCustomSource.AddRange(New String() {"Female", "Male", "Others"})
        gender_combobx.BackColor = SystemColors.Menu
        gender_combobx.FlatStyle = FlatStyle.System
        gender_combobx.Font = New Font("Segoe UI", 10.2F)
        gender_combobx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        gender_combobx.FormattingEnabled = True
        gender_combobx.Items.AddRange(New Object() {"Female", "Male", "Others"})
        gender_combobx.Location = New Point(191, 260)
        gender_combobx.Name = "gender_combobx"
        gender_combobx.Size = New Size(235, 31)
        gender_combobx.TabIndex = 21
        ' 
        ' ln_txtbx
        ' 
        ln_txtbx.BackColor = SystemColors.ControlLightLight
        ln_txtbx.Font = New Font("Segoe UI", 10.2F)
        ln_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        ln_txtbx.Location = New Point(576, 112)
        ln_txtbx.Name = "ln_txtbx"
        ln_txtbx.Size = New Size(235, 30)
        ln_txtbx.TabIndex = 20
        ' 
        ' As_txtbx
        ' 
        As_txtbx.BackColor = SystemColors.ControlLightLight
        As_txtbx.Font = New Font("Segoe UI", 10.2F)
        As_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        As_txtbx.Location = New Point(191, 186)
        As_txtbx.Name = "As_txtbx"
        As_txtbx.Size = New Size(235, 30)
        As_txtbx.TabIndex = 19
        ' 
        ' Phone_txtbx
        ' 
        Phone_txtbx.BackColor = SystemColors.ControlLightLight
        Phone_txtbx.Font = New Font("Segoe UI", 10.2F)
        Phone_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Phone_txtbx.Location = New Point(576, 260)
        Phone_txtbx.Name = "Phone_txtbx"
        Phone_txtbx.Size = New Size(235, 30)
        Phone_txtbx.TabIndex = 17
        ' 
        ' username_txtbx
        ' 
        username_txtbx.BackColor = SystemColors.ControlLightLight
        username_txtbx.Font = New Font("Segoe UI", 10.2F)
        username_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        username_txtbx.Location = New Point(191, 338)
        username_txtbx.Name = "username_txtbx"
        username_txtbx.Size = New Size(235, 30)
        username_txtbx.TabIndex = 16
        ' 
        ' password_txtbx
        ' 
        password_txtbx.BackColor = SystemColors.ControlLightLight
        password_txtbx.Font = New Font("Segoe UI", 10.2F)
        password_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        password_txtbx.Location = New Point(191, 413)
        password_txtbx.Name = "password_txtbx"
        password_txtbx.Size = New Size(235, 30)
        password_txtbx.TabIndex = 15
        ' 
        ' confirmpw_txtbx
        ' 
        confirmpw_txtbx.BackColor = SystemColors.ControlLightLight
        confirmpw_txtbx.Font = New Font("Segoe UI", 10.2F)
        confirmpw_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        confirmpw_txtbx.Location = New Point(576, 414)
        confirmpw_txtbx.Name = "confirmpw_txtbx"
        confirmpw_txtbx.Size = New Size(235, 30)
        confirmpw_txtbx.TabIndex = 14
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 576)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(970, 14)
        Panel2.TabIndex = 13
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLightLight
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Dock = DockStyle.Top
        Panel1.ForeColor = SystemColors.ControlLightLight
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(970, 30)
        Panel1.TabIndex = 12
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ControlLightLight
        Button1.FlatAppearance.BorderColor = SystemColors.GradientActiveCaption
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button1.Location = New Point(405, 490)
        Button1.Name = "Button1"
        Button1.Size = New Size(215, 47)
        Button1.TabIndex = 11
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' fn_txtbx
        ' 
        fn_txtbx.BackColor = SystemColors.ControlLightLight
        fn_txtbx.Font = New Font("Segoe UI", 10.2F)
        fn_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        fn_txtbx.Location = New Point(191, 112)
        fn_txtbx.Name = "fn_txtbx"
        fn_txtbx.Size = New Size(235, 30)
        fn_txtbx.TabIndex = 10
        ' 
        ' LabelLastname
        ' 
        LabelLastname.AutoSize = True
        LabelLastname.FlatStyle = FlatStyle.Flat
        LabelLastname.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LabelLastname.ForeColor = SystemColors.ControlLightLight
        LabelLastname.Location = New Point(576, 87)
        LabelLastname.Name = "LabelLastname"
        LabelLastname.Size = New Size(91, 23)
        LabelLastname.TabIndex = 9
        LabelLastname.Text = "Last Name"
        LabelLastname.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Registerform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.Disable
        BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        ClientSize = New Size(970, 590)
        Controls.Add(Panelregister)
        Name = "Registerform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registration"
        Panelregister.ResumeLayout(False)
        Panelregister.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LabelName As Label
    Friend WithEvents LabelDOB As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelAddress As Label
    Friend WithEvents LabelPhonenumber As Label
    Friend WithEvents LabelRole As Label
    Friend WithEvents LabelGender As Label
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents Panelregister As Panel
    Friend WithEvents LabelLastname As Label
    Friend WithEvents fn_txtbx As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents gender_combobx As ComboBox
    Friend WithEvents ln_txtbx As TextBox
    Friend WithEvents As_txtbx As TextBox
    Friend WithEvents Phone_txtbx As TextBox
    Friend WithEvents username_txtbx As TextBox
    Friend WithEvents password_txtbx As TextBox
    Friend WithEvents role_combobx As ComboBox
    Friend WithEvents DOBdtp As DateTimePicker
    Friend WithEvents confirmpw_txtbx As TextBox
End Class
