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
        pnlguestlist = New Panel()
        TabGuestcontrol = New TabControl()
        TabPage1 = New TabPage()
        Lbl_msgggender = New Label()
        Lbl_msgnadults = New Label()
        Lbl_msggfirstname = New Label()
        Lbl_msgcontact = New Label()
        Ll_msggcountry = New Label()
        Lbl_msgguestid = New Label()
        Lbl_msgglastname = New Label()
        Country_cmbbx = New ComboBox()
        cmbbx_genderG = New ComboBox()
        nchildren_txtbx = New TextBox()
        glastname_txtbx = New TextBox()
        contact_txtbx = New TextBox()
        nadult_txtbx = New TextBox()
        Gemail_txtbx = New TextBox()
        gfirstname_txtbx = New TextBox()
        addnewguest_btn = New Button()
        clear_btn = New Button()
        Lblglastname = New Label()
        LglguestID = New Label()
        Lblgemail = New Label()
        Lblgcountry = New Label()
        Lblcontact = New Label()
        Lblnoofchildren = New Label()
        Lblnoofadults = New Label()
        LblgGender = New Label()
        Lblgfirstname = New Label()
        tabpage_viewguest = New TabPage()
        TextBox1 = New TextBox()
        DGV_Guests = New DataGridView()
        GuestID = New DataGridViewTextBoxColumn()
        Firstname = New DataGridViewTextBoxColumn()
        Lastname = New DataGridViewTextBoxColumn()
        Country = New DataGridViewTextBoxColumn()
        Phonenumber = New DataGridViewTextBoxColumn()
        Gender = New DataGridViewTextBoxColumn()
        Email = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        closebtn = New Button()
        Lblguestlist = New Label()
        guestid_cmbbx = New ComboBox()
        del_btn = New Button()
        pnlguestlist.SuspendLayout()
        TabGuestcontrol.SuspendLayout()
        TabPage1.SuspendLayout()
        tabpage_viewguest.SuspendLayout()
        CType(DGV_Guests, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlguestlist
        ' 
        pnlguestlist.BackColor = SystemColors.Control
        pnlguestlist.Controls.Add(TabGuestcontrol)
        pnlguestlist.Controls.Add(Panel1)
        pnlguestlist.Dock = DockStyle.Fill
        pnlguestlist.Location = New Point(0, 0)
        pnlguestlist.Name = "pnlguestlist"
        pnlguestlist.Size = New Size(948, 750)
        pnlguestlist.TabIndex = 1
        ' 
        ' TabGuestcontrol
        ' 
        TabGuestcontrol.Alignment = TabAlignment.Bottom
        TabGuestcontrol.Anchor = AnchorStyles.None
        TabGuestcontrol.Controls.Add(TabPage1)
        TabGuestcontrol.Controls.Add(tabpage_viewguest)
        TabGuestcontrol.Location = New Point(23, 78)
        TabGuestcontrol.Name = "TabGuestcontrol"
        TabGuestcontrol.SelectedIndex = 0
        TabGuestcontrol.Size = New Size(899, 651)
        TabGuestcontrol.TabIndex = 6
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(del_btn)
        TabPage1.Controls.Add(guestid_cmbbx)
        TabPage1.Controls.Add(Lbl_msgggender)
        TabPage1.Controls.Add(Lbl_msgnadults)
        TabPage1.Controls.Add(Lbl_msggfirstname)
        TabPage1.Controls.Add(Lbl_msgcontact)
        TabPage1.Controls.Add(Ll_msggcountry)
        TabPage1.Controls.Add(Lbl_msgguestid)
        TabPage1.Controls.Add(Lbl_msgglastname)
        TabPage1.Controls.Add(Country_cmbbx)
        TabPage1.Controls.Add(cmbbx_genderG)
        TabPage1.Controls.Add(nchildren_txtbx)
        TabPage1.Controls.Add(glastname_txtbx)
        TabPage1.Controls.Add(contact_txtbx)
        TabPage1.Controls.Add(nadult_txtbx)
        TabPage1.Controls.Add(Gemail_txtbx)
        TabPage1.Controls.Add(gfirstname_txtbx)
        TabPage1.Controls.Add(addnewguest_btn)
        TabPage1.Controls.Add(clear_btn)
        TabPage1.Controls.Add(Lblglastname)
        TabPage1.Controls.Add(LglguestID)
        TabPage1.Controls.Add(Lblgemail)
        TabPage1.Controls.Add(Lblgcountry)
        TabPage1.Controls.Add(Lblcontact)
        TabPage1.Controls.Add(Lblnoofchildren)
        TabPage1.Controls.Add(Lblnoofadults)
        TabPage1.Controls.Add(LblgGender)
        TabPage1.Controls.Add(Lblgfirstname)
        TabPage1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabPage1.Location = New Point(4, 4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(891, 618)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Add New Guest"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Lbl_msgggender
        ' 
        Lbl_msgggender.AutoSize = True
        Lbl_msgggender.BackColor = Color.Transparent
        Lbl_msgggender.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_msgggender.ForeColor = Color.Red
        Lbl_msgggender.Location = New Point(127, 225)
        Lbl_msgggender.Name = "Lbl_msgggender"
        Lbl_msgggender.Size = New Size(0, 23)
        Lbl_msgggender.TabIndex = 58
        ' 
        ' Lbl_msgnadults
        ' 
        Lbl_msgnadults.AutoSize = True
        Lbl_msgnadults.BackColor = Color.Transparent
        Lbl_msgnadults.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_msgnadults.ForeColor = Color.Red
        Lbl_msgnadults.Location = New Point(127, 480)
        Lbl_msgnadults.Name = "Lbl_msgnadults"
        Lbl_msgnadults.Size = New Size(0, 23)
        Lbl_msgnadults.TabIndex = 57
        ' 
        ' Lbl_msggfirstname
        ' 
        Lbl_msggfirstname.AutoSize = True
        Lbl_msggfirstname.BackColor = Color.Transparent
        Lbl_msggfirstname.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_msggfirstname.ForeColor = Color.Red
        Lbl_msggfirstname.Location = New Point(127, 114)
        Lbl_msggfirstname.Name = "Lbl_msggfirstname"
        Lbl_msggfirstname.Size = New Size(0, 23)
        Lbl_msggfirstname.TabIndex = 56
        ' 
        ' Lbl_msgcontact
        ' 
        Lbl_msgcontact.AutoSize = True
        Lbl_msgcontact.BackColor = Color.Transparent
        Lbl_msgcontact.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_msgcontact.ForeColor = Color.Red
        Lbl_msgcontact.Location = New Point(502, 480)
        Lbl_msgcontact.Name = "Lbl_msgcontact"
        Lbl_msgcontact.Size = New Size(0, 23)
        Lbl_msgcontact.TabIndex = 55
        ' 
        ' Ll_msggcountry
        ' 
        Ll_msggcountry.AutoSize = True
        Ll_msggcountry.BackColor = Color.Transparent
        Ll_msggcountry.ForeColor = Color.Red
        Ll_msggcountry.Location = New Point(499, 332)
        Ll_msggcountry.Name = "Ll_msggcountry"
        Ll_msggcountry.Size = New Size(0, 28)
        Ll_msggcountry.TabIndex = 54
        ' 
        ' Lbl_msgguestid
        ' 
        Lbl_msgguestid.AutoSize = True
        Lbl_msgguestid.BackColor = Color.Transparent
        Lbl_msgguestid.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_msgguestid.ForeColor = Color.Red
        Lbl_msgguestid.Location = New Point(502, 224)
        Lbl_msgguestid.Name = "Lbl_msgguestid"
        Lbl_msgguestid.Size = New Size(0, 23)
        Lbl_msgguestid.TabIndex = 53
        ' 
        ' Lbl_msgglastname
        ' 
        Lbl_msgglastname.AutoSize = True
        Lbl_msgglastname.BackColor = Color.Transparent
        Lbl_msgglastname.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_msgglastname.ForeColor = Color.Red
        Lbl_msgglastname.Location = New Point(502, 114)
        Lbl_msgglastname.Name = "Lbl_msgglastname"
        Lbl_msgglastname.Size = New Size(0, 23)
        Lbl_msgglastname.TabIndex = 52
        ' 
        ' Country_cmbbx
        ' 
        Country_cmbbx.BackColor = SystemColors.ControlLight
        Country_cmbbx.DropDownHeight = 200
        Country_cmbbx.DropDownWidth = 100
        Country_cmbbx.FlatStyle = FlatStyle.Flat
        Country_cmbbx.Font = New Font("Segoe UI", 13.8F)
        Country_cmbbx.ForeColor = Color.Black
        Country_cmbbx.FormattingEnabled = True
        Country_cmbbx.IntegralHeight = False
        Country_cmbbx.Items.AddRange(New Object() {"Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "The Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo, Democratic Republic of the", "Congo, Republic of the", "Costa Rica", "Côte d’Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor (Timor-Leste)", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "The Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, North", "Korea, South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia, Federated States of", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar (Burma)", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "Sudan", "Sudan, South", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe", ""})
        Country_cmbbx.Location = New Point(499, 298)
        Country_cmbbx.Name = "Country_cmbbx"
        Country_cmbbx.Size = New Size(282, 39)
        Country_cmbbx.TabIndex = 51
        ' 
        ' cmbbx_genderG
        ' 
        cmbbx_genderG.BackColor = SystemColors.ControlLight
        cmbbx_genderG.FlatStyle = FlatStyle.Flat
        cmbbx_genderG.Font = New Font("Segoe UI", 13.8F)
        cmbbx_genderG.ForeColor = Color.Black
        cmbbx_genderG.FormattingEnabled = True
        cmbbx_genderG.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cmbbx_genderG.Location = New Point(127, 183)
        cmbbx_genderG.Name = "cmbbx_genderG"
        cmbbx_genderG.Size = New Size(172, 39)
        cmbbx_genderG.TabIndex = 50
        ' 
        ' nchildren_txtbx
        ' 
        nchildren_txtbx.BackColor = SystemColors.ControlLightLight
        nchildren_txtbx.Font = New Font("Segoe UI", 13.8F)
        nchildren_txtbx.ForeColor = Color.Black
        nchildren_txtbx.Location = New Point(307, 439)
        nchildren_txtbx.Name = "nchildren_txtbx"
        nchildren_txtbx.Size = New Size(149, 38)
        nchildren_txtbx.TabIndex = 49
        ' 
        ' glastname_txtbx
        ' 
        glastname_txtbx.BackColor = SystemColors.ControlLightLight
        glastname_txtbx.Font = New Font("Segoe UI", 13.8F)
        glastname_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        glastname_txtbx.Location = New Point(499, 73)
        glastname_txtbx.Name = "glastname_txtbx"
        glastname_txtbx.Size = New Size(282, 38)
        glastname_txtbx.TabIndex = 48
        ' 
        ' contact_txtbx
        ' 
        contact_txtbx.BackColor = SystemColors.ControlLightLight
        contact_txtbx.Font = New Font("Segoe UI", 13.8F)
        contact_txtbx.ForeColor = Color.Black
        contact_txtbx.Location = New Point(500, 434)
        contact_txtbx.Name = "contact_txtbx"
        contact_txtbx.Size = New Size(281, 38)
        contact_txtbx.TabIndex = 47
        ' 
        ' nadult_txtbx
        ' 
        nadult_txtbx.BackColor = SystemColors.ControlLightLight
        nadult_txtbx.Font = New Font("Segoe UI", 13.8F)
        nadult_txtbx.ForeColor = Color.Black
        nadult_txtbx.Location = New Point(125, 439)
        nadult_txtbx.Name = "nadult_txtbx"
        nadult_txtbx.Size = New Size(139, 38)
        nadult_txtbx.TabIndex = 46
        ' 
        ' Gemail_txtbx
        ' 
        Gemail_txtbx.BackColor = SystemColors.ControlLightLight
        Gemail_txtbx.Font = New Font("Segoe UI", 13.8F)
        Gemail_txtbx.ForeColor = Color.Black
        Gemail_txtbx.Location = New Point(121, 299)
        Gemail_txtbx.Name = "Gemail_txtbx"
        Gemail_txtbx.Size = New Size(285, 38)
        Gemail_txtbx.TabIndex = 45
        ' 
        ' gfirstname_txtbx
        ' 
        gfirstname_txtbx.BackColor = SystemColors.ControlLightLight
        gfirstname_txtbx.Font = New Font("Segoe UI", 13.8F)
        gfirstname_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        gfirstname_txtbx.Location = New Point(127, 73)
        gfirstname_txtbx.Name = "gfirstname_txtbx"
        gfirstname_txtbx.Size = New Size(282, 38)
        gfirstname_txtbx.TabIndex = 43
        ' 
        ' addnewguest_btn
        ' 
        addnewguest_btn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        addnewguest_btn.FlatAppearance.BorderColor = SystemColors.Window
        addnewguest_btn.FlatAppearance.BorderSize = 2
        addnewguest_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        addnewguest_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        addnewguest_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        addnewguest_btn.FlatStyle = FlatStyle.Flat
        addnewguest_btn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        addnewguest_btn.ForeColor = SystemColors.ControlLightLight
        addnewguest_btn.Location = New Point(228, 534)
        addnewguest_btn.Name = "addnewguest_btn"
        addnewguest_btn.Size = New Size(127, 49)
        addnewguest_btn.TabIndex = 42
        addnewguest_btn.Text = "Add "
        addnewguest_btn.UseVisualStyleBackColor = False
        ' 
        ' clear_btn
        ' 
        clear_btn.BackColor = Color.Red
        clear_btn.FlatAppearance.BorderColor = SystemColors.Window
        clear_btn.FlatAppearance.BorderSize = 2
        clear_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        clear_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        clear_btn.FlatStyle = FlatStyle.Flat
        clear_btn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        clear_btn.ForeColor = SystemColors.ControlLightLight
        clear_btn.Location = New Point(550, 534)
        clear_btn.Name = "clear_btn"
        clear_btn.Size = New Size(127, 49)
        clear_btn.TabIndex = 41
        clear_btn.Text = "Clear"
        clear_btn.UseVisualStyleBackColor = False
        ' 
        ' Lblglastname
        ' 
        Lblglastname.AutoSize = True
        Lblglastname.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblglastname.ForeColor = Color.Black
        Lblglastname.Location = New Point(496, 42)
        Lblglastname.Name = "Lblglastname"
        Lblglastname.Size = New Size(108, 28)
        Lblglastname.TabIndex = 40
        Lblglastname.Text = "Last Name"
        ' 
        ' LglguestID
        ' 
        LglguestID.AutoSize = True
        LglguestID.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LglguestID.ForeColor = Color.Black
        LglguestID.Location = New Point(499, 152)
        LglguestID.Name = "LglguestID"
        LglguestID.Size = New Size(91, 28)
        LglguestID.TabIndex = 39
        LglguestID.Text = "Guest ID"
        ' 
        ' Lblgemail
        ' 
        Lblgemail.AutoSize = True
        Lblgemail.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblgemail.ForeColor = Color.Black
        Lblgemail.Location = New Point(121, 273)
        Lblgemail.Name = "Lblgemail"
        Lblgemail.Size = New Size(60, 28)
        Lblgemail.TabIndex = 38
        Lblgemail.Text = "Email"
        ' 
        ' Lblgcountry
        ' 
        Lblgcountry.AutoSize = True
        Lblgcountry.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblgcountry.ForeColor = Color.Black
        Lblgcountry.Location = New Point(496, 267)
        Lblgcountry.Name = "Lblgcountry"
        Lblgcountry.Size = New Size(85, 28)
        Lblgcountry.TabIndex = 37
        Lblgcountry.Text = "Country"
        ' 
        ' Lblcontact
        ' 
        Lblcontact.AutoSize = True
        Lblcontact.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblcontact.ForeColor = Color.Black
        Lblcontact.Location = New Point(500, 403)
        Lblcontact.Name = "Lblcontact"
        Lblcontact.Size = New Size(116, 28)
        Lblcontact.TabIndex = 36
        Lblcontact.Text = "Contact no."
        ' 
        ' Lblnoofchildren
        ' 
        Lblnoofchildren.AutoSize = True
        Lblnoofchildren.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblnoofchildren.ForeColor = Color.Black
        Lblnoofchildren.Location = New Point(301, 408)
        Lblnoofchildren.Name = "Lblnoofchildren"
        Lblnoofchildren.Size = New Size(151, 28)
        Lblnoofchildren.TabIndex = 35
        Lblnoofchildren.Text = "No. of Children"
        ' 
        ' Lblnoofadults
        ' 
        Lblnoofadults.AutoSize = True
        Lblnoofadults.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblnoofadults.ForeColor = Color.Black
        Lblnoofadults.Location = New Point(122, 408)
        Lblnoofadults.Name = "Lblnoofadults"
        Lblnoofadults.Size = New Size(133, 28)
        Lblnoofadults.TabIndex = 34
        Lblnoofadults.Text = "No. of Adults"
        ' 
        ' LblgGender
        ' 
        LblgGender.AutoSize = True
        LblgGender.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LblgGender.ForeColor = Color.Black
        LblgGender.Location = New Point(127, 152)
        LblgGender.Name = "LblgGender"
        LblgGender.Size = New Size(79, 28)
        LblgGender.TabIndex = 33
        LblgGender.Text = "Gender"
        ' 
        ' Lblgfirstname
        ' 
        Lblgfirstname.AutoSize = True
        Lblgfirstname.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lblgfirstname.ForeColor = Color.Black
        Lblgfirstname.Location = New Point(124, 42)
        Lblgfirstname.Name = "Lblgfirstname"
        Lblgfirstname.Size = New Size(110, 28)
        Lblgfirstname.TabIndex = 32
        Lblgfirstname.Text = "First Name"
        ' 
        ' tabpage_viewguest
        ' 
        tabpage_viewguest.Controls.Add(TextBox1)
        tabpage_viewguest.Controls.Add(DGV_Guests)
        tabpage_viewguest.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tabpage_viewguest.Location = New Point(4, 4)
        tabpage_viewguest.Name = "tabpage_viewguest"
        tabpage_viewguest.Padding = New Padding(3)
        tabpage_viewguest.Size = New Size(891, 618)
        tabpage_viewguest.TabIndex = 1
        tabpage_viewguest.Text = "View Guest"
        tabpage_viewguest.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(315, 60)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(281, 34)
        TextBox1.TabIndex = 1
        ' 
        ' DGV_Guests
        ' 
        DGV_Guests.AllowUserToAddRows = False
        DGV_Guests.AllowUserToDeleteRows = False
        DGV_Guests.Anchor = AnchorStyles.None
        DGV_Guests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DGV_Guests.BackgroundColor = SystemColors.Menu
        DGV_Guests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_Guests.Columns.AddRange(New DataGridViewColumn() {GuestID, Firstname, Lastname, Country, Phonenumber, Gender, Email})
        DGV_Guests.Location = New Point(31, 118)
        DGV_Guests.Name = "DGV_Guests"
        DGV_Guests.ReadOnly = True
        DGV_Guests.RowHeadersWidth = 51
        DGV_Guests.Size = New Size(840, 475)
        DGV_Guests.TabIndex = 0
        ' 
        ' GuestID
        ' 
        GuestID.DataPropertyName = "GuestId"
        GuestID.HeaderText = "GuestID"
        GuestID.MinimumWidth = 6
        GuestID.Name = "GuestID"
        GuestID.ReadOnly = True
        GuestID.Width = 110
        ' 
        ' Firstname
        ' 
        Firstname.DataPropertyName = "GFirst_name"
        Firstname.HeaderText = "Firstname"
        Firstname.MinimumWidth = 6
        Firstname.Name = "Firstname"
        Firstname.ReadOnly = True
        Firstname.Width = 126
        ' 
        ' Lastname
        ' 
        Lastname.DataPropertyName = "GLast_name"
        Lastname.HeaderText = "Lastname"
        Lastname.MinimumWidth = 6
        Lastname.Name = "Lastname"
        Lastname.ReadOnly = True
        Lastname.Width = 123
        ' 
        ' Country
        ' 
        Country.DataPropertyName = "GCountry"
        Country.HeaderText = "Country"
        Country.MinimumWidth = 6
        Country.Name = "Country"
        Country.ReadOnly = True
        Country.Width = 111
        ' 
        ' Phonenumber
        ' 
        Phonenumber.DataPropertyName = "GPhonenumber"
        Phonenumber.HeaderText = "Phonenumber"
        Phonenumber.MinimumWidth = 6
        Phonenumber.Name = "Phonenumber"
        Phonenumber.ReadOnly = True
        Phonenumber.Width = 164
        ' 
        ' Gender
        ' 
        Gender.DataPropertyName = "GGender"
        Gender.HeaderText = "Gender"
        Gender.MinimumWidth = 6
        Gender.Name = "Gender"
        Gender.ReadOnly = True
        Gender.Width = 105
        ' 
        ' Email
        ' 
        Email.DataPropertyName = "GEmail"
        Email.HeaderText = "Email"
        Email.MinimumWidth = 6
        Email.Name = "Email"
        Email.ReadOnly = True
        Email.Width = 88
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Panel1.Controls.Add(closebtn)
        Panel1.Controls.Add(Lblguestlist)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(948, 50)
        Panel1.TabIndex = 4
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
        closebtn.Location = New Point(902, 5)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(43, 42)
        closebtn.TabIndex = 12
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Lblguestlist
        ' 
        Lblguestlist.AutoSize = True
        Lblguestlist.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblguestlist.ForeColor = SystemColors.ControlLightLight
        Lblguestlist.Location = New Point(450, 11)
        Lblguestlist.Name = "Lblguestlist"
        Lblguestlist.Size = New Size(91, 31)
        Lblguestlist.TabIndex = 1
        Lblguestlist.Text = "GUEST "
        ' 
        ' guestid_cmbbx
        ' 
        guestid_cmbbx.BackColor = SystemColors.ControlLight
        guestid_cmbbx.FlatStyle = FlatStyle.Flat
        guestid_cmbbx.Font = New Font("Segoe UI", 13.8F)
        guestid_cmbbx.ForeColor = Color.Black
        guestid_cmbbx.FormattingEnabled = True
        guestid_cmbbx.Items.AddRange(New Object() {"Male", "Female", "Others"})
        guestid_cmbbx.Location = New Point(502, 183)
        guestid_cmbbx.Name = "guestid_cmbbx"
        guestid_cmbbx.Size = New Size(187, 39)
        guestid_cmbbx.TabIndex = 59
        ' 
        ' del_btn
        ' 
        del_btn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        del_btn.FlatAppearance.BorderColor = SystemColors.Window
        del_btn.FlatAppearance.BorderSize = 2
        del_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        del_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        del_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        del_btn.FlatStyle = FlatStyle.Flat
        del_btn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        del_btn.ForeColor = SystemColors.ControlLightLight
        del_btn.Location = New Point(387, 534)
        del_btn.Name = "del_btn"
        del_btn.Size = New Size(127, 49)
        del_btn.TabIndex = 60
        del_btn.Text = "Update"
        del_btn.UseVisualStyleBackColor = False
        ' 
        ' Guestform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(948, 750)
        Controls.Add(pnlguestlist)
        FormBorderStyle = FormBorderStyle.None
        Name = "Guestform"
        Text = "addguestform"
        pnlguestlist.ResumeLayout(False)
        TabGuestcontrol.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        tabpage_viewguest.ResumeLayout(False)
        tabpage_viewguest.PerformLayout()
        CType(DGV_Guests, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnlguestlist As Panel
    Friend WithEvents searchbtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lblguestlist As Label
    Friend WithEvents DataGridViewGuestlist As DataGridView
    Friend WithEvents closebtn As Button
    Friend WithEvents TabGuestcontrol As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents tabpage_viewguest As TabPage
    Friend WithEvents DGV_Guests As DataGridView
    Friend WithEvents Lbl_msgcontact As Label
    Friend WithEvents Ll_msggcountry As Label
    Friend WithEvents Lbl_msgguestid As Label
    Friend WithEvents Lbl_msgglastname As Label
    Friend WithEvents Country_cmbbx As ComboBox
    Friend WithEvents cmbbx_genderG As ComboBox
    Friend WithEvents nchildren_txtbx As TextBox
    Friend WithEvents glastname_txtbx As TextBox
    Friend WithEvents contact_txtbx As TextBox
    Friend WithEvents nadult_txtbx As TextBox
    Friend WithEvents Gemail_txtbx As TextBox
    Friend WithEvents gfirstname_txtbx As TextBox
    Friend WithEvents addnewguest_btn As Button
    Friend WithEvents clear_btn As Button
    Friend WithEvents Lblglastname As Label
    Friend WithEvents LglguestID As Label
    Friend WithEvents Lblgemail As Label
    Friend WithEvents Lblgcountry As Label
    Friend WithEvents Lblcontact As Label
    Friend WithEvents Lblnoofchildren As Label
    Friend WithEvents Lblnoofadults As Label
    Friend WithEvents LblgGender As Label
    Friend WithEvents Lblgfirstname As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Lbl_msggfirstname As Label
    Friend WithEvents Lbl_msgnadults As Label
    Friend WithEvents Lbl_msgggender As Label
    Friend WithEvents GuestID As DataGridViewTextBoxColumn
    Friend WithEvents Firstname As DataGridViewTextBoxColumn
    Friend WithEvents Lastname As DataGridViewTextBoxColumn
    Friend WithEvents Country As DataGridViewTextBoxColumn
    Friend WithEvents Phonenumber As DataGridViewTextBoxColumn
    Friend WithEvents Gender As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents guestid_cmbbx As ComboBox
    Friend WithEvents del_btn As Button
End Class
