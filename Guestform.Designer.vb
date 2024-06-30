<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guestform
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
        pnlguestlist = New Panel()
        Tabpage_updateguest = New TabControl()
        tabpage_viewguest = New TabPage()
        lbl_anykeyword = New Label()
        searchguest_txtbx = New TextBox()
        DGV_Guests = New DataGridView()
        Tabpage_manageguest = New TabPage()
        update_btn = New Button()
        Lbl_guestidshow = New Label()
        Lbl_guestid = New Label()
        Lbl_msgemail = New Label()
        gaddress_txtbx = New TextBox()
        Lbl_msgggender = New Label()
        Lbl_msggfirstname = New Label()
        Lbl_msgcontactno = New Label()
        Lbl_msggaddress = New Label()
        Lbl_msgglastname = New Label()
        cmbbx_genderG = New ComboBox()
        glastname_txtbx = New TextBox()
        contact_txtbx = New TextBox()
        Gemail_txtbx = New TextBox()
        gfirstname_txtbx = New TextBox()
        add_btn = New Button()
        Lbl_lastname = New Label()
        Lbl_email = New Label()
        Lbl_address = New Label()
        Lbl_contactno = New Label()
        Lbl_gender = New Label()
        Lbl_firstname = New Label()
        Lblguestlist = New Label()
        clear_btn = New Button()
        pnlguestlist.SuspendLayout()
        Tabpage_updateguest.SuspendLayout()
        tabpage_viewguest.SuspendLayout()
        CType(DGV_Guests, ComponentModel.ISupportInitialize).BeginInit()
        Tabpage_manageguest.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlguestlist
        ' 
        pnlguestlist.BackColor = SystemColors.ButtonFace
        pnlguestlist.Controls.Add(Tabpage_updateguest)
        pnlguestlist.Controls.Add(Lblguestlist)
        pnlguestlist.Dock = DockStyle.Fill
        pnlguestlist.Location = New Point(0, 0)
        pnlguestlist.Name = "pnlguestlist"
        pnlguestlist.Size = New Size(1077, 777)
        pnlguestlist.TabIndex = 1
        ' 
        ' Tabpage_updateguest
        ' 
        Tabpage_updateguest.Alignment = TabAlignment.Bottom
        Tabpage_updateguest.Anchor = AnchorStyles.None
        Tabpage_updateguest.Controls.Add(tabpage_viewguest)
        Tabpage_updateguest.Controls.Add(Tabpage_manageguest)
        Tabpage_updateguest.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Tabpage_updateguest.Location = New Point(27, 57)
        Tabpage_updateguest.Name = "Tabpage_updateguest"
        Tabpage_updateguest.SelectedIndex = 0
        Tabpage_updateguest.Size = New Size(1026, 708)
        Tabpage_updateguest.TabIndex = 6
        ' 
        ' tabpage_viewguest
        ' 
        tabpage_viewguest.Controls.Add(lbl_anykeyword)
        tabpage_viewguest.Controls.Add(searchguest_txtbx)
        tabpage_viewguest.Controls.Add(DGV_Guests)
        tabpage_viewguest.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tabpage_viewguest.Location = New Point(4, 4)
        tabpage_viewguest.Name = "tabpage_viewguest"
        tabpage_viewguest.Padding = New Padding(3)
        tabpage_viewguest.Size = New Size(1018, 667)
        tabpage_viewguest.TabIndex = 1
        tabpage_viewguest.Text = "View Guest"
        tabpage_viewguest.UseVisualStyleBackColor = True
        ' 
        ' lbl_anykeyword
        ' 
        lbl_anykeyword.Anchor = AnchorStyles.None
        lbl_anykeyword.AutoSize = True
        lbl_anykeyword.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_anykeyword.ForeColor = SystemColors.ActiveCaptionText
        lbl_anykeyword.Location = New Point(226, 45)
        lbl_anykeyword.Name = "lbl_anykeyword"
        lbl_anykeyword.Size = New Size(131, 25)
        lbl_anykeyword.TabIndex = 10
        lbl_anykeyword.Text = "Any Keyword:"
        ' 
        ' searchguest_txtbx
        ' 
        searchguest_txtbx.BorderStyle = BorderStyle.FixedSingle
        searchguest_txtbx.Location = New Point(363, 38)
        searchguest_txtbx.Multiline = True
        searchguest_txtbx.Name = "searchguest_txtbx"
        searchguest_txtbx.Size = New Size(358, 49)
        searchguest_txtbx.TabIndex = 1
        ' 
        ' DGV_Guests
        ' 
        DGV_Guests.AllowUserToAddRows = False
        DGV_Guests.AllowUserToDeleteRows = False
        DGV_Guests.Anchor = AnchorStyles.None
        DGV_Guests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DGV_Guests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DGV_Guests.BackgroundColor = SystemColors.Menu
        DGV_Guests.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DGV_Guests.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DGV_Guests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_Guests.Location = New Point(17, 119)
        DGV_Guests.Name = "DGV_Guests"
        DGV_Guests.ReadOnly = True
        DGV_Guests.RowHeadersWidth = 51
        DGV_Guests.Size = New Size(983, 530)
        DGV_Guests.TabIndex = 0
        ' 
        ' Tabpage_manageguest
        ' 
        Tabpage_manageguest.Controls.Add(clear_btn)
        Tabpage_manageguest.Controls.Add(update_btn)
        Tabpage_manageguest.Controls.Add(Lbl_guestidshow)
        Tabpage_manageguest.Controls.Add(Lbl_guestid)
        Tabpage_manageguest.Controls.Add(Lbl_msgemail)
        Tabpage_manageguest.Controls.Add(gaddress_txtbx)
        Tabpage_manageguest.Controls.Add(Lbl_msgggender)
        Tabpage_manageguest.Controls.Add(Lbl_msggfirstname)
        Tabpage_manageguest.Controls.Add(Lbl_msgcontactno)
        Tabpage_manageguest.Controls.Add(Lbl_msggaddress)
        Tabpage_manageguest.Controls.Add(Lbl_msgglastname)
        Tabpage_manageguest.Controls.Add(cmbbx_genderG)
        Tabpage_manageguest.Controls.Add(glastname_txtbx)
        Tabpage_manageguest.Controls.Add(contact_txtbx)
        Tabpage_manageguest.Controls.Add(Gemail_txtbx)
        Tabpage_manageguest.Controls.Add(gfirstname_txtbx)
        Tabpage_manageguest.Controls.Add(add_btn)
        Tabpage_manageguest.Controls.Add(Lbl_lastname)
        Tabpage_manageguest.Controls.Add(Lbl_email)
        Tabpage_manageguest.Controls.Add(Lbl_address)
        Tabpage_manageguest.Controls.Add(Lbl_contactno)
        Tabpage_manageguest.Controls.Add(Lbl_gender)
        Tabpage_manageguest.Controls.Add(Lbl_firstname)
        Tabpage_manageguest.Location = New Point(4, 4)
        Tabpage_manageguest.Name = "Tabpage_manageguest"
        Tabpage_manageguest.Padding = New Padding(3)
        Tabpage_manageguest.Size = New Size(1018, 667)
        Tabpage_manageguest.TabIndex = 2
        Tabpage_manageguest.Text = "Manage Guests"
        Tabpage_manageguest.UseVisualStyleBackColor = True
        ' 
        ' update_btn
        ' 
        update_btn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        update_btn.FlatAppearance.BorderColor = SystemColors.Window
        update_btn.FlatAppearance.BorderSize = 2
        update_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        update_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        update_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        update_btn.FlatStyle = FlatStyle.Flat
        update_btn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        update_btn.ForeColor = SystemColors.ControlLightLight
        update_btn.Location = New Point(495, 588)
        update_btn.Name = "update_btn"
        update_btn.Size = New Size(154, 49)
        update_btn.TabIndex = 93
        update_btn.Text = "Update"
        update_btn.UseVisualStyleBackColor = False
        ' 
        ' Lbl_guestidshow
        ' 
        Lbl_guestidshow.AutoSize = True
        Lbl_guestidshow.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_guestidshow.ForeColor = Color.Black
        Lbl_guestidshow.Location = New Point(225, 17)
        Lbl_guestidshow.Name = "Lbl_guestidshow"
        Lbl_guestidshow.Size = New Size(0, 28)
        Lbl_guestidshow.TabIndex = 92
        ' 
        ' Lbl_guestid
        ' 
        Lbl_guestid.AutoSize = True
        Lbl_guestid.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_guestid.ForeColor = Color.Red
        Lbl_guestid.Location = New Point(94, 17)
        Lbl_guestid.Name = "Lbl_guestid"
        Lbl_guestid.Size = New Size(0, 28)
        Lbl_guestid.TabIndex = 91
        ' 
        ' Lbl_msgemail
        ' 
        Lbl_msgemail.AutoSize = True
        Lbl_msgemail.BackColor = Color.Transparent
        Lbl_msgemail.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_msgemail.ForeColor = Color.Red
        Lbl_msgemail.Location = New Point(546, 321)
        Lbl_msgemail.Name = "Lbl_msgemail"
        Lbl_msgemail.Size = New Size(0, 23)
        Lbl_msgemail.TabIndex = 90
        ' 
        ' gaddress_txtbx
        ' 
        gaddress_txtbx.BackColor = SystemColors.ControlLightLight
        gaddress_txtbx.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gaddress_txtbx.ForeColor = Color.Black
        gaddress_txtbx.Location = New Point(543, 450)
        gaddress_txtbx.Multiline = True
        gaddress_txtbx.Name = "gaddress_txtbx"
        gaddress_txtbx.Size = New Size(345, 41)
        gaddress_txtbx.TabIndex = 89
        ' 
        ' Lbl_msgggender
        ' 
        Lbl_msgggender.AutoSize = True
        Lbl_msgggender.BackColor = Color.Transparent
        Lbl_msgggender.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_msgggender.ForeColor = Color.Red
        Lbl_msgggender.Location = New Point(97, 323)
        Lbl_msgggender.Name = "Lbl_msgggender"
        Lbl_msgggender.Size = New Size(0, 23)
        Lbl_msgggender.TabIndex = 86
        ' 
        ' Lbl_msggfirstname
        ' 
        Lbl_msggfirstname.AutoSize = True
        Lbl_msggfirstname.BackColor = Color.Transparent
        Lbl_msggfirstname.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_msggfirstname.ForeColor = Color.Red
        Lbl_msggfirstname.Location = New Point(97, 161)
        Lbl_msggfirstname.Name = "Lbl_msggfirstname"
        Lbl_msggfirstname.Size = New Size(0, 23)
        Lbl_msggfirstname.TabIndex = 84
        ' 
        ' Lbl_msgcontactno
        ' 
        Lbl_msgcontactno.AutoSize = True
        Lbl_msgcontactno.BackColor = Color.Transparent
        Lbl_msgcontactno.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_msgcontactno.ForeColor = Color.Red
        Lbl_msgcontactno.Location = New Point(97, 502)
        Lbl_msgcontactno.Name = "Lbl_msgcontactno"
        Lbl_msgcontactno.Size = New Size(0, 23)
        Lbl_msgcontactno.TabIndex = 83
        ' 
        ' Lbl_msggaddress
        ' 
        Lbl_msggaddress.AutoSize = True
        Lbl_msggaddress.BackColor = Color.Transparent
        Lbl_msggaddress.ForeColor = Color.Red
        Lbl_msggaddress.Location = New Point(546, 497)
        Lbl_msggaddress.Name = "Lbl_msggaddress"
        Lbl_msggaddress.Size = New Size(0, 28)
        Lbl_msggaddress.TabIndex = 82
        ' 
        ' Lbl_msgglastname
        ' 
        Lbl_msgglastname.AutoSize = True
        Lbl_msgglastname.BackColor = Color.Transparent
        Lbl_msgglastname.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_msgglastname.ForeColor = Color.Red
        Lbl_msgglastname.Location = New Point(543, 163)
        Lbl_msgglastname.Name = "Lbl_msgglastname"
        Lbl_msgglastname.Size = New Size(0, 23)
        Lbl_msgglastname.TabIndex = 80
        ' 
        ' cmbbx_genderG
        ' 
        cmbbx_genderG.BackColor = SystemColors.ControlLight
        cmbbx_genderG.FlatStyle = FlatStyle.Flat
        cmbbx_genderG.Font = New Font("Segoe UI", 13.8F)
        cmbbx_genderG.ForeColor = Color.Black
        cmbbx_genderG.FormattingEnabled = True
        cmbbx_genderG.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cmbbx_genderG.Location = New Point(97, 273)
        cmbbx_genderG.Name = "cmbbx_genderG"
        cmbbx_genderG.Size = New Size(200, 39)
        cmbbx_genderG.TabIndex = 78
        ' 
        ' glastname_txtbx
        ' 
        glastname_txtbx.BackColor = SystemColors.ControlLightLight
        glastname_txtbx.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        glastname_txtbx.ForeColor = SystemColors.ControlText
        glastname_txtbx.Location = New Point(541, 107)
        glastname_txtbx.Multiline = True
        glastname_txtbx.Name = "glastname_txtbx"
        glastname_txtbx.Size = New Size(345, 41)
        glastname_txtbx.TabIndex = 76
        ' 
        ' contact_txtbx
        ' 
        contact_txtbx.BackColor = SystemColors.ControlLightLight
        contact_txtbx.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        contact_txtbx.ForeColor = Color.Black
        contact_txtbx.Location = New Point(97, 450)
        contact_txtbx.Multiline = True
        contact_txtbx.Name = "contact_txtbx"
        contact_txtbx.Size = New Size(345, 41)
        contact_txtbx.TabIndex = 75
        ' 
        ' Gemail_txtbx
        ' 
        Gemail_txtbx.BackColor = SystemColors.ControlLightLight
        Gemail_txtbx.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Gemail_txtbx.ForeColor = Color.Black
        Gemail_txtbx.Location = New Point(543, 269)
        Gemail_txtbx.Multiline = True
        Gemail_txtbx.Name = "Gemail_txtbx"
        Gemail_txtbx.Size = New Size(345, 41)
        Gemail_txtbx.TabIndex = 73
        ' 
        ' gfirstname_txtbx
        ' 
        gfirstname_txtbx.BackColor = SystemColors.ControlLightLight
        gfirstname_txtbx.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gfirstname_txtbx.ForeColor = SystemColors.ControlText
        gfirstname_txtbx.Location = New Point(97, 112)
        gfirstname_txtbx.Multiline = True
        gfirstname_txtbx.Name = "gfirstname_txtbx"
        gfirstname_txtbx.Size = New Size(345, 41)
        gfirstname_txtbx.TabIndex = 72
        ' 
        ' add_btn
        ' 
        add_btn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        add_btn.FlatAppearance.BorderColor = SystemColors.Window
        add_btn.FlatAppearance.BorderSize = 2
        add_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        add_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        add_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        add_btn.FlatStyle = FlatStyle.Flat
        add_btn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        add_btn.ForeColor = SystemColors.ControlLightLight
        add_btn.Location = New Point(311, 588)
        add_btn.Name = "add_btn"
        add_btn.Size = New Size(154, 49)
        add_btn.TabIndex = 71
        add_btn.Text = "Add "
        add_btn.UseVisualStyleBackColor = False
        ' 
        ' Lbl_lastname
        ' 
        Lbl_lastname.AutoSize = True
        Lbl_lastname.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_lastname.ForeColor = Color.Black
        Lbl_lastname.Location = New Point(539, 69)
        Lbl_lastname.Name = "Lbl_lastname"
        Lbl_lastname.Size = New Size(99, 28)
        Lbl_lastname.TabIndex = 69
        Lbl_lastname.Text = "Lastname"
        ' 
        ' Lbl_email
        ' 
        Lbl_email.AutoSize = True
        Lbl_email.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_email.ForeColor = Color.Black
        Lbl_email.Location = New Point(543, 229)
        Lbl_email.Name = "Lbl_email"
        Lbl_email.Size = New Size(68, 28)
        Lbl_email.TabIndex = 67
        Lbl_email.Text = "E-mail"
        ' 
        ' Lbl_address
        ' 
        Lbl_address.AutoSize = True
        Lbl_address.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_address.ForeColor = Color.Black
        Lbl_address.Location = New Point(546, 411)
        Lbl_address.Name = "Lbl_address"
        Lbl_address.Size = New Size(85, 28)
        Lbl_address.TabIndex = 66
        Lbl_address.Text = "Address"
        ' 
        ' Lbl_contactno
        ' 
        Lbl_contactno.AutoSize = True
        Lbl_contactno.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_contactno.ForeColor = Color.Black
        Lbl_contactno.Location = New Point(97, 411)
        Lbl_contactno.Name = "Lbl_contactno"
        Lbl_contactno.Size = New Size(81, 28)
        Lbl_contactno.TabIndex = 65
        Lbl_contactno.Text = "Contact"
        ' 
        ' Lbl_gender
        ' 
        Lbl_gender.AutoSize = True
        Lbl_gender.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_gender.ForeColor = Color.Black
        Lbl_gender.Location = New Point(97, 234)
        Lbl_gender.Name = "Lbl_gender"
        Lbl_gender.Size = New Size(79, 28)
        Lbl_gender.TabIndex = 62
        Lbl_gender.Text = "Gender"
        ' 
        ' Lbl_firstname
        ' 
        Lbl_firstname.AutoSize = True
        Lbl_firstname.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_firstname.ForeColor = Color.Black
        Lbl_firstname.Location = New Point(94, 74)
        Lbl_firstname.Name = "Lbl_firstname"
        Lbl_firstname.Size = New Size(101, 28)
        Lbl_firstname.TabIndex = 61
        Lbl_firstname.Text = "Firstname"
        ' 
        ' Lblguestlist
        ' 
        Lblguestlist.AutoSize = True
        Lblguestlist.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblguestlist.ForeColor = Color.FromArgb(CByte(32), CByte(114), CByte(170))
        Lblguestlist.Location = New Point(500, 9)
        Lblguestlist.Name = "Lblguestlist"
        Lblguestlist.Size = New Size(91, 31)
        Lblguestlist.TabIndex = 1
        Lblguestlist.Text = "GUEST "
        ' 
        ' clear_btn
        ' 
        clear_btn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        clear_btn.FlatAppearance.BorderColor = SystemColors.Window
        clear_btn.FlatAppearance.BorderSize = 2
        clear_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        clear_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        clear_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        clear_btn.FlatStyle = FlatStyle.Flat
        clear_btn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        clear_btn.ForeColor = SystemColors.ControlLightLight
        clear_btn.Location = New Point(683, 588)
        clear_btn.Name = "clear_btn"
        clear_btn.Size = New Size(154, 49)
        clear_btn.TabIndex = 94
        clear_btn.Text = "Clear"
        clear_btn.UseVisualStyleBackColor = False
        ' 
        ' Guestform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1077, 777)
        Controls.Add(pnlguestlist)
        FormBorderStyle = FormBorderStyle.None
        Name = "Guestform"
        Text = "addguestform"
        pnlguestlist.ResumeLayout(False)
        pnlguestlist.PerformLayout()
        Tabpage_updateguest.ResumeLayout(False)
        tabpage_viewguest.ResumeLayout(False)
        tabpage_viewguest.PerformLayout()
        CType(DGV_Guests, ComponentModel.ISupportInitialize).EndInit()
        Tabpage_manageguest.ResumeLayout(False)
        Tabpage_manageguest.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnlguestlist As Panel
    Friend WithEvents searchbtn As Button
    Friend WithEvents Lblguestlist As Label
    Friend WithEvents DataGridViewGuestlist As DataGridView
    Friend WithEvents Tabpage_updateguest As TabControl
    Friend WithEvents tabpage_viewguest As TabPage
    Friend WithEvents searchguest_txtbx As TextBox
    Friend WithEvents DGV_Guests As DataGridView
    Friend WithEvents Lbl_msgnadults As Label
    Friend WithEvents Lbl_msgguestid As Label
    Friend WithEvents Country_cmbbx As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents lbl_anykeyword As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Tabpage_manageguest As TabPage
    Friend WithEvents Lbl_guestidshow As Label
    Friend WithEvents Lbl_guestid As Label
    Friend WithEvents Lbl_msgemail As Label
    Friend WithEvents gaddress_txtbx As TextBox
    Friend WithEvents Lbl_msgggender As Label
    Friend WithEvents Lbl_msggfirstname As Label
    Friend WithEvents Lbl_msgcontactno As Label
    Friend WithEvents Lbl_msggaddress As Label
    Friend WithEvents Lbl_msgglastname As Label
    Friend WithEvents cmbbx_genderG As ComboBox
    Friend WithEvents glastname_txtbx As TextBox
    Friend WithEvents contact_txtbx As TextBox
    Friend WithEvents Gemail_txtbx As TextBox
    Friend WithEvents gfirstname_txtbx As TextBox
    Friend WithEvents add_btn As Button
    Friend WithEvents Lbl_lastname As Label
    Friend WithEvents Lbl_email As Label
    Friend WithEvents Lbl_address As Label
    Friend WithEvents Lbl_contactno As Label
    Friend WithEvents Lbl_gender As Label
    Friend WithEvents Lbl_firstname As Label
    Friend WithEvents update_btn As Button
    Friend WithEvents clear_btn As Button
End Class
