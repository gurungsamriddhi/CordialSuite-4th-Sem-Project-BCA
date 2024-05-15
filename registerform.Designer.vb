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
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        Panel8 = New Panel()
        Panel9 = New Panel()
        Panel10 = New Panel()
        Panel11 = New Panel()
        Panel12 = New Panel()
        Panel13 = New Panel()
        Panel3 = New Panel()
        role_combobx = New ComboBox()
        gender_combobx = New ComboBox()
        ln_txtbx = New TextBox()
        As_txtbx = New TextBox()
        dob_txtbx = New TextBox()
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
        LabelName.BorderStyle = BorderStyle.Fixed3D
        LabelName.FlatStyle = FlatStyle.Flat
        LabelName.Font = New Font("Tahoma", 10.8F)
        LabelName.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        LabelName.Location = New Point(191, 40)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(96, 24)
        LabelName.TabIndex = 0
        LabelName.Text = "First Name"
        LabelName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelDOB
        ' 
        LabelDOB.AutoSize = True
        LabelDOB.BorderStyle = BorderStyle.Fixed3D
        LabelDOB.FlatStyle = FlatStyle.Flat
        LabelDOB.Font = New Font("Tahoma", 10.8F)
        LabelDOB.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        LabelDOB.Location = New Point(576, 116)
        LabelDOB.Name = "LabelDOB"
        LabelDOB.Size = New Size(113, 24)
        LabelDOB.TabIndex = 1
        LabelDOB.Text = "Date of Birth"
        LabelDOB.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Tahoma", 10.8F)
        Label2.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Label2.Location = New Point(576, 342)
        Label2.Name = "Label2"
        Label2.Size = New Size(154, 24)
        Label2.TabIndex = 2
        Label2.Text = "Confirm Password"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelAddress
        ' 
        LabelAddress.AutoSize = True
        LabelAddress.BorderStyle = BorderStyle.Fixed3D
        LabelAddress.FlatStyle = FlatStyle.Flat
        LabelAddress.Font = New Font("Tahoma", 10.8F)
        LabelAddress.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        LabelAddress.Location = New Point(191, 116)
        LabelAddress.Name = "LabelAddress"
        LabelAddress.Size = New Size(74, 24)
        LabelAddress.TabIndex = 3
        LabelAddress.Text = "Address"
        LabelAddress.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelPhonenumber
        ' 
        LabelPhonenumber.AutoSize = True
        LabelPhonenumber.BorderStyle = BorderStyle.Fixed3D
        LabelPhonenumber.FlatStyle = FlatStyle.Flat
        LabelPhonenumber.Font = New Font("Tahoma", 10.8F)
        LabelPhonenumber.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        LabelPhonenumber.ImageAlign = ContentAlignment.TopRight
        LabelPhonenumber.Location = New Point(576, 190)
        LabelPhonenumber.Name = "LabelPhonenumber"
        LabelPhonenumber.Size = New Size(121, 24)
        LabelPhonenumber.TabIndex = 4
        LabelPhonenumber.Text = "Phonenumber"
        LabelPhonenumber.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelRole
        ' 
        LabelRole.AutoSize = True
        LabelRole.BorderStyle = BorderStyle.Fixed3D
        LabelRole.FlatStyle = FlatStyle.Flat
        LabelRole.Font = New Font("Tahoma", 10.8F)
        LabelRole.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        LabelRole.Location = New Point(576, 268)
        LabelRole.Name = "LabelRole"
        LabelRole.Size = New Size(46, 24)
        LabelRole.TabIndex = 5
        LabelRole.Text = "Role"
        LabelRole.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelGender
        ' 
        LabelGender.AutoSize = True
        LabelGender.BorderStyle = BorderStyle.Fixed3D
        LabelGender.FlatStyle = FlatStyle.Flat
        LabelGender.Font = New Font("Tahoma", 10.8F)
        LabelGender.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        LabelGender.Location = New Point(191, 190)
        LabelGender.Name = "LabelGender"
        LabelGender.Size = New Size(68, 24)
        LabelGender.TabIndex = 6
        LabelGender.Text = "Gender"
        LabelGender.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelUsername
        ' 
        LabelUsername.AutoSize = True
        LabelUsername.BorderStyle = BorderStyle.Fixed3D
        LabelUsername.FlatStyle = FlatStyle.Flat
        LabelUsername.Font = New Font("Tahoma", 10.8F)
        LabelUsername.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        LabelUsername.Location = New Point(191, 268)
        LabelUsername.Name = "LabelUsername"
        LabelUsername.Size = New Size(90, 24)
        LabelUsername.TabIndex = 7
        LabelUsername.Text = "Username"
        LabelUsername.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelPassword
        ' 
        LabelPassword.AutoSize = True
        LabelPassword.BorderStyle = BorderStyle.Fixed3D
        LabelPassword.FlatStyle = FlatStyle.Flat
        LabelPassword.Font = New Font("Tahoma", 10.8F)
        LabelPassword.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        LabelPassword.Location = New Point(191, 342)
        LabelPassword.Name = "LabelPassword"
        LabelPassword.Size = New Size(86, 24)
        LabelPassword.TabIndex = 8
        LabelPassword.Text = "Password"
        LabelPassword.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panelregister
        ' 
        Panelregister.BackColor = Color.Azure
        Panelregister.Controls.Add(Panel5)
        Panelregister.Controls.Add(Panel6)
        Panelregister.Controls.Add(Panel7)
        Panelregister.Controls.Add(Panel8)
        Panelregister.Controls.Add(Panel9)
        Panelregister.Controls.Add(Panel10)
        Panelregister.Controls.Add(Panel11)
        Panelregister.Controls.Add(Panel12)
        Panelregister.Controls.Add(Panel13)
        Panelregister.Controls.Add(Panel3)
        Panelregister.Controls.Add(role_combobx)
        Panelregister.Controls.Add(gender_combobx)
        Panelregister.Controls.Add(ln_txtbx)
        Panelregister.Controls.Add(As_txtbx)
        Panelregister.Controls.Add(dob_txtbx)
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
        Panelregister.Size = New Size(947, 536)
        Panelregister.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Panel5.Location = New Point(560, 294)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(15, 28)
        Panel5.TabIndex = 24
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Panel6.Location = New Point(560, 369)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(15, 28)
        Panel6.TabIndex = 24
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Panel7.Location = New Point(560, 218)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(15, 28)
        Panel7.TabIndex = 24
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Panel8.Location = New Point(560, 143)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(15, 28)
        Panel8.TabIndex = 24
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Panel9.Location = New Point(560, 67)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(15, 28)
        Panel9.TabIndex = 24
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Panel10.Location = New Point(177, 369)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(15, 28)
        Panel10.TabIndex = 24
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Panel11.Location = New Point(177, 295)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(15, 28)
        Panel11.TabIndex = 24
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Panel12.Location = New Point(177, 218)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(15, 28)
        Panel12.TabIndex = 24
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Panel13.Location = New Point(177, 143)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(15, 28)
        Panel13.TabIndex = 24
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Panel3.Location = New Point(177, 67)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(15, 28)
        Panel3.TabIndex = 23
        ' 
        ' role_combobx
        ' 
        role_combobx.BackColor = Color.White
        role_combobx.FlatStyle = FlatStyle.Flat
        role_combobx.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        role_combobx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        role_combobx.FormattingEnabled = True
        role_combobx.Location = New Point(576, 294)
        role_combobx.Name = "role_combobx"
        role_combobx.Size = New Size(202, 29)
        role_combobx.TabIndex = 22
        ' 
        ' gender_combobx
        ' 
        gender_combobx.BackColor = Color.White
        gender_combobx.FlatStyle = FlatStyle.Flat
        gender_combobx.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gender_combobx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        gender_combobx.FormattingEnabled = True
        gender_combobx.Location = New Point(191, 217)
        gender_combobx.Name = "gender_combobx"
        gender_combobx.Size = New Size(202, 29)
        gender_combobx.TabIndex = 21
        ' 
        ' ln_txtbx
        ' 
        ln_txtbx.BackColor = SystemColors.InactiveBorder
        ln_txtbx.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ln_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        ln_txtbx.Location = New Point(576, 67)
        ln_txtbx.Name = "ln_txtbx"
        ln_txtbx.Size = New Size(202, 28)
        ln_txtbx.TabIndex = 20
        ' 
        ' As_txtbx
        ' 
        As_txtbx.BackColor = SystemColors.InactiveBorder
        As_txtbx.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        As_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        As_txtbx.Location = New Point(191, 143)
        As_txtbx.Name = "As_txtbx"
        As_txtbx.Size = New Size(202, 28)
        As_txtbx.TabIndex = 19
        ' 
        ' dob_txtbx
        ' 
        dob_txtbx.BackColor = SystemColors.InactiveBorder
        dob_txtbx.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dob_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        dob_txtbx.Location = New Point(576, 143)
        dob_txtbx.Name = "dob_txtbx"
        dob_txtbx.Size = New Size(202, 28)
        dob_txtbx.TabIndex = 18
        ' 
        ' Phone_txtbx
        ' 
        Phone_txtbx.BackColor = SystemColors.InactiveBorder
        Phone_txtbx.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Phone_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Phone_txtbx.Location = New Point(576, 218)
        Phone_txtbx.Name = "Phone_txtbx"
        Phone_txtbx.Size = New Size(202, 28)
        Phone_txtbx.TabIndex = 17
        ' 
        ' username_txtbx
        ' 
        username_txtbx.BackColor = SystemColors.InactiveBorder
        username_txtbx.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        username_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        username_txtbx.Location = New Point(191, 296)
        username_txtbx.Name = "username_txtbx"
        username_txtbx.Size = New Size(202, 28)
        username_txtbx.TabIndex = 16
        ' 
        ' password_txtbx
        ' 
        password_txtbx.BackColor = SystemColors.InactiveBorder
        password_txtbx.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        password_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        password_txtbx.Location = New Point(191, 369)
        password_txtbx.Name = "password_txtbx"
        password_txtbx.Size = New Size(202, 28)
        password_txtbx.TabIndex = 15
        ' 
        ' confirmpw_txtbx
        ' 
        confirmpw_txtbx.BackColor = SystemColors.InactiveBorder
        confirmpw_txtbx.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        confirmpw_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        confirmpw_txtbx.Location = New Point(576, 369)
        confirmpw_txtbx.Name = "confirmpw_txtbx"
        confirmpw_txtbx.Size = New Size(202, 28)
        confirmpw_txtbx.TabIndex = 14
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 522)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(947, 14)
        Panel2.TabIndex = 13
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(947, 14)
        Panel1.TabIndex = 12
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(10), CByte(6), CByte(47))
        Button1.FlatAppearance.BorderColor = SystemColors.GradientActiveCaption
        Button1.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Button1.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.InactiveBorder
        Button1.Location = New Point(375, 440)
        Button1.Name = "Button1"
        Button1.Size = New Size(212, 52)
        Button1.TabIndex = 11
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' fn_txtbx
        ' 
        fn_txtbx.BackColor = SystemColors.InactiveBorder
        fn_txtbx.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        fn_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        fn_txtbx.Location = New Point(191, 67)
        fn_txtbx.Name = "fn_txtbx"
        fn_txtbx.Size = New Size(202, 28)
        fn_txtbx.TabIndex = 10
        ' 
        ' LabelLastname
        ' 
        LabelLastname.AutoSize = True
        LabelLastname.BorderStyle = BorderStyle.Fixed3D
        LabelLastname.FlatStyle = FlatStyle.Flat
        LabelLastname.Font = New Font("Tahoma", 10.8F)
        LabelLastname.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        LabelLastname.Location = New Point(576, 40)
        LabelLastname.Name = "LabelLastname"
        LabelLastname.Size = New Size(95, 24)
        LabelLastname.TabIndex = 9
        LabelLastname.Text = "Last Name"
        LabelLastname.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Registerform
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.Disable
        BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        ClientSize = New Size(947, 536)
        Controls.Add(Panelregister)
        Name = "Registerform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registrationform"
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
    Friend WithEvents dob_txtbx As TextBox
    Friend WithEvents Phone_txtbx As TextBox
    Friend WithEvents username_txtbx As TextBox
    Friend WithEvents password_txtbx As TextBox
    Friend WithEvents confirmpw_txtbx As TextBox
    Friend WithEvents role_combobx As ComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel3 As Panel
End Class
