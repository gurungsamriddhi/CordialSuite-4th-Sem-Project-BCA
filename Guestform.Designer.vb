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
        Tabpage_addnewguest = New TabPage()
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        Lbl_msgggender = New Label()
        Lbl_msgnadults = New Label()
        Lbl_msggfirstname = New Label()
        Lbl_msgcontactno = New Label()
        Lbl_msggcountry = New Label()
        Lbl_msgguestid = New Label()
        Lbl_msgglastname = New Label()
        Country_cmbbx = New ComboBox()
        cmbbx_genderG = New ComboBox()
        TextBox2 = New TextBox()
        glastname_txtbx = New TextBox()
        contact_txtbx = New TextBox()
        TextBox5 = New TextBox()
        Gemail_txtbx = New TextBox()
        gfirstname_txtbx = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        Lbl_lastname = New Label()
        Lbl_guestid = New Label()
        Lbl_email = New Label()
        Lbl_country = New Label()
        Lbl_contactno = New Label()
        Lbl_nchildren = New Label()
        Lbl_nadults = New Label()
        Lbl_gender = New Label()
        Lbl_firstname = New Label()
        Panel_guest = New Panel()
        closebtn = New Button()
        Lblguestlist = New Label()
        pnlguestlist.SuspendLayout()
        TabGuestcontrol.SuspendLayout()
        tabpage_viewguest.SuspendLayout()
        CType(DGV_Guests, ComponentModel.ISupportInitialize).BeginInit()
        Tabpage_addnewguest.SuspendLayout()
        Panel_guest.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlguestlist
        ' 
        pnlguestlist.BackColor = SystemColors.Control
        pnlguestlist.Controls.Add(TabGuestcontrol)
        pnlguestlist.Controls.Add(Panel_guest)
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
        TabGuestcontrol.Controls.Add(tabpage_viewguest)
        TabGuestcontrol.Controls.Add(Tabpage_addnewguest)
        TabGuestcontrol.Location = New Point(23, 78)
        TabGuestcontrol.Name = "TabGuestcontrol"
        TabGuestcontrol.SelectedIndex = 0
        TabGuestcontrol.Size = New Size(899, 651)
        TabGuestcontrol.TabIndex = 6
        ' 
        ' tabpage_viewguest
        ' 
        tabpage_viewguest.Controls.Add(TextBox1)
        tabpage_viewguest.Controls.Add(DGV_Guests)
        tabpage_viewguest.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        DGV_Guests.Location = New Point(22, 126)
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
        ' Tabpage_addnewguest
        ' 
        Tabpage_addnewguest.Controls.Add(Button1)
        Tabpage_addnewguest.Controls.Add(ComboBox1)
        Tabpage_addnewguest.Controls.Add(Lbl_msgggender)
        Tabpage_addnewguest.Controls.Add(Lbl_msgnadults)
        Tabpage_addnewguest.Controls.Add(Lbl_msggfirstname)
        Tabpage_addnewguest.Controls.Add(Lbl_msgcontactno)
        Tabpage_addnewguest.Controls.Add(Lbl_msggcountry)
        Tabpage_addnewguest.Controls.Add(Lbl_msgguestid)
        Tabpage_addnewguest.Controls.Add(Lbl_msgglastname)
        Tabpage_addnewguest.Controls.Add(Country_cmbbx)
        Tabpage_addnewguest.Controls.Add(cmbbx_genderG)
        Tabpage_addnewguest.Controls.Add(TextBox2)
        Tabpage_addnewguest.Controls.Add(glastname_txtbx)
        Tabpage_addnewguest.Controls.Add(contact_txtbx)
        Tabpage_addnewguest.Controls.Add(TextBox5)
        Tabpage_addnewguest.Controls.Add(Gemail_txtbx)
        Tabpage_addnewguest.Controls.Add(gfirstname_txtbx)
        Tabpage_addnewguest.Controls.Add(Button2)
        Tabpage_addnewguest.Controls.Add(Button3)
        Tabpage_addnewguest.Controls.Add(Lbl_lastname)
        Tabpage_addnewguest.Controls.Add(Lbl_guestid)
        Tabpage_addnewguest.Controls.Add(Lbl_email)
        Tabpage_addnewguest.Controls.Add(Lbl_country)
        Tabpage_addnewguest.Controls.Add(Lbl_contactno)
        Tabpage_addnewguest.Controls.Add(Lbl_nchildren)
        Tabpage_addnewguest.Controls.Add(Lbl_nadults)
        Tabpage_addnewguest.Controls.Add(Lbl_gender)
        Tabpage_addnewguest.Controls.Add(Lbl_firstname)
        Tabpage_addnewguest.Location = New Point(4, 4)
        Tabpage_addnewguest.Name = "Tabpage_addnewguest"
        Tabpage_addnewguest.Padding = New Padding(3)
        Tabpage_addnewguest.Size = New Size(891, 618)
        Tabpage_addnewguest.TabIndex = 2
        Tabpage_addnewguest.Text = "Add New Guest"
        Tabpage_addnewguest.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Button1.FlatAppearance.BorderColor = SystemColors.Window
        Button1.FlatAppearance.BorderSize = 2
        Button1.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(381, 531)
        Button1.Name = "Button1"
        Button1.Size = New Size(127, 49)
        Button1.TabIndex = 88
        Button1.Text = "Update"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.ControlLight
        ComboBox1.FlatStyle = FlatStyle.Flat
        ComboBox1.Font = New Font("Segoe UI", 13.8F)
        ComboBox1.ForeColor = Color.Black
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Male", "Female", "Others"})
        ComboBox1.Location = New Point(496, 180)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(187, 39)
        ComboBox1.TabIndex = 87
        ' 
        ' Lbl_msgggender
        ' 
        Lbl_msgggender.AutoSize = True
        Lbl_msgggender.BackColor = Color.Transparent
        Lbl_msgggender.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_msgggender.ForeColor = Color.Red
        Lbl_msgggender.Location = New Point(121, 222)
        Lbl_msgggender.Name = "Lbl_msgggender"
        Lbl_msgggender.Size = New Size(0, 23)
        Lbl_msgggender.TabIndex = 86
        ' 
        ' Lbl_msgnadults
        ' 
        Lbl_msgnadults.AutoSize = True
        Lbl_msgnadults.BackColor = Color.Transparent
        Lbl_msgnadults.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_msgnadults.ForeColor = Color.Red
        Lbl_msgnadults.Location = New Point(121, 477)
        Lbl_msgnadults.Name = "Lbl_msgnadults"
        Lbl_msgnadults.Size = New Size(0, 23)
        Lbl_msgnadults.TabIndex = 85
        ' 
        ' Lbl_msggfirstname
        ' 
        Lbl_msggfirstname.AutoSize = True
        Lbl_msggfirstname.BackColor = Color.Transparent
        Lbl_msggfirstname.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_msggfirstname.ForeColor = Color.Red
        Lbl_msggfirstname.Location = New Point(121, 111)
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
        Lbl_msgcontactno.Location = New Point(496, 477)
        Lbl_msgcontactno.Name = "Lbl_msgcontactno"
        Lbl_msgcontactno.Size = New Size(0, 23)
        Lbl_msgcontactno.TabIndex = 83
        ' 
        ' Lbl_msggcountry
        ' 
        Lbl_msggcountry.AutoSize = True
        Lbl_msggcountry.BackColor = Color.Transparent
        Lbl_msggcountry.ForeColor = Color.Red
        Lbl_msggcountry.Location = New Point(493, 329)
        Lbl_msggcountry.Name = "Lbl_msggcountry"
        Lbl_msggcountry.Size = New Size(0, 20)
        Lbl_msggcountry.TabIndex = 82
        ' 
        ' Lbl_msgguestid
        ' 
        Lbl_msgguestid.AutoSize = True
        Lbl_msgguestid.BackColor = Color.Transparent
        Lbl_msgguestid.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_msgguestid.ForeColor = Color.Red
        Lbl_msgguestid.Location = New Point(496, 221)
        Lbl_msgguestid.Name = "Lbl_msgguestid"
        Lbl_msgguestid.Size = New Size(0, 23)
        Lbl_msgguestid.TabIndex = 81
        ' 
        ' Lbl_msgglastname
        ' 
        Lbl_msgglastname.AutoSize = True
        Lbl_msgglastname.BackColor = Color.Transparent
        Lbl_msgglastname.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_msgglastname.ForeColor = Color.Red
        Lbl_msgglastname.Location = New Point(496, 111)
        Lbl_msgglastname.Name = "Lbl_msgglastname"
        Lbl_msgglastname.Size = New Size(0, 23)
        Lbl_msgglastname.TabIndex = 80
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
        Country_cmbbx.Location = New Point(493, 295)
        Country_cmbbx.Name = "Country_cmbbx"
        Country_cmbbx.Size = New Size(282, 39)
        Country_cmbbx.TabIndex = 79
        ' 
        ' cmbbx_genderG
        ' 
        cmbbx_genderG.BackColor = SystemColors.ControlLight
        cmbbx_genderG.FlatStyle = FlatStyle.Flat
        cmbbx_genderG.Font = New Font("Segoe UI", 13.8F)
        cmbbx_genderG.ForeColor = Color.Black
        cmbbx_genderG.FormattingEnabled = True
        cmbbx_genderG.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cmbbx_genderG.Location = New Point(121, 180)
        cmbbx_genderG.Name = "cmbbx_genderG"
        cmbbx_genderG.Size = New Size(172, 39)
        cmbbx_genderG.TabIndex = 78
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ControlLightLight
        TextBox2.Font = New Font("Segoe UI", 13.8F)
        TextBox2.ForeColor = Color.Black
        TextBox2.Location = New Point(301, 436)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(149, 38)
        TextBox2.TabIndex = 77
        ' 
        ' glastname_txtbx
        ' 
        glastname_txtbx.BackColor = SystemColors.ControlLightLight
        glastname_txtbx.Font = New Font("Segoe UI", 13.8F)
        glastname_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        glastname_txtbx.Location = New Point(493, 70)
        glastname_txtbx.Name = "glastname_txtbx"
        glastname_txtbx.Size = New Size(282, 38)
        glastname_txtbx.TabIndex = 76
        ' 
        ' contact_txtbx
        ' 
        contact_txtbx.BackColor = SystemColors.ControlLightLight
        contact_txtbx.Font = New Font("Segoe UI", 13.8F)
        contact_txtbx.ForeColor = Color.Black
        contact_txtbx.Location = New Point(494, 431)
        contact_txtbx.Name = "contact_txtbx"
        contact_txtbx.Size = New Size(281, 38)
        contact_txtbx.TabIndex = 75
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = SystemColors.ControlLightLight
        TextBox5.Font = New Font("Segoe UI", 13.8F)
        TextBox5.ForeColor = Color.Black
        TextBox5.Location = New Point(119, 436)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(139, 38)
        TextBox5.TabIndex = 74
        ' 
        ' Gemail_txtbx
        ' 
        Gemail_txtbx.BackColor = SystemColors.ControlLightLight
        Gemail_txtbx.Font = New Font("Segoe UI", 13.8F)
        Gemail_txtbx.ForeColor = Color.Black
        Gemail_txtbx.Location = New Point(115, 296)
        Gemail_txtbx.Name = "Gemail_txtbx"
        Gemail_txtbx.Size = New Size(285, 38)
        Gemail_txtbx.TabIndex = 73
        ' 
        ' gfirstname_txtbx
        ' 
        gfirstname_txtbx.BackColor = SystemColors.ControlLightLight
        gfirstname_txtbx.Font = New Font("Segoe UI", 13.8F)
        gfirstname_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        gfirstname_txtbx.Location = New Point(121, 70)
        gfirstname_txtbx.Name = "gfirstname_txtbx"
        gfirstname_txtbx.Size = New Size(282, 38)
        gfirstname_txtbx.TabIndex = 72
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Button2.FlatAppearance.BorderColor = SystemColors.Window
        Button2.FlatAppearance.BorderSize = 2
        Button2.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(222, 531)
        Button2.Name = "Button2"
        Button2.Size = New Size(127, 49)
        Button2.TabIndex = 71
        Button2.Text = "Add "
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.FlatAppearance.BorderColor = SystemColors.Window
        Button3.FlatAppearance.BorderSize = 2
        Button3.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Button3.ForeColor = SystemColors.ControlLightLight
        Button3.Location = New Point(544, 531)
        Button3.Name = "Button3"
        Button3.Size = New Size(127, 49)
        Button3.TabIndex = 70
        Button3.Text = "Clear"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Lbl_lastname
        ' 
        Lbl_lastname.AutoSize = True
        Lbl_lastname.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Lbl_lastname.ForeColor = Color.Black
        Lbl_lastname.Location = New Point(490, 39)
        Lbl_lastname.Name = "Lbl_lastname"
        Lbl_lastname.Size = New Size(108, 28)
        Lbl_lastname.TabIndex = 69
        Lbl_lastname.Text = "Last Name"
        ' 
        ' Lbl_guestid
        ' 
        Lbl_guestid.AutoSize = True
        Lbl_guestid.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Lbl_guestid.ForeColor = Color.Black
        Lbl_guestid.Location = New Point(493, 149)
        Lbl_guestid.Name = "Lbl_guestid"
        Lbl_guestid.Size = New Size(91, 28)
        Lbl_guestid.TabIndex = 68
        Lbl_guestid.Text = "Guest ID"
        ' 
        ' Lbl_email
        ' 
        Lbl_email.AutoSize = True
        Lbl_email.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Lbl_email.ForeColor = Color.Black
        Lbl_email.Location = New Point(115, 270)
        Lbl_email.Name = "Lbl_email"
        Lbl_email.Size = New Size(60, 28)
        Lbl_email.TabIndex = 67
        Lbl_email.Text = "Email"
        ' 
        ' Lbl_country
        ' 
        Lbl_country.AutoSize = True
        Lbl_country.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Lbl_country.ForeColor = Color.Black
        Lbl_country.Location = New Point(490, 264)
        Lbl_country.Name = "Lbl_country"
        Lbl_country.Size = New Size(85, 28)
        Lbl_country.TabIndex = 66
        Lbl_country.Text = "Country"
        ' 
        ' Lbl_contactno
        ' 
        Lbl_contactno.AutoSize = True
        Lbl_contactno.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Lbl_contactno.ForeColor = Color.Black
        Lbl_contactno.Location = New Point(494, 400)
        Lbl_contactno.Name = "Lbl_contactno"
        Lbl_contactno.Size = New Size(116, 28)
        Lbl_contactno.TabIndex = 65
        Lbl_contactno.Text = "Contact no."
        ' 
        ' Lbl_nchildren
        ' 
        Lbl_nchildren.AutoSize = True
        Lbl_nchildren.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Lbl_nchildren.ForeColor = Color.Black
        Lbl_nchildren.Location = New Point(295, 405)
        Lbl_nchildren.Name = "Lbl_nchildren"
        Lbl_nchildren.Size = New Size(151, 28)
        Lbl_nchildren.TabIndex = 64
        Lbl_nchildren.Text = "No. of Children"
        ' 
        ' Lbl_nadults
        ' 
        Lbl_nadults.AutoSize = True
        Lbl_nadults.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Lbl_nadults.ForeColor = Color.Black
        Lbl_nadults.Location = New Point(116, 405)
        Lbl_nadults.Name = "Lbl_nadults"
        Lbl_nadults.Size = New Size(133, 28)
        Lbl_nadults.TabIndex = 63
        Lbl_nadults.Text = "No. of Adults"
        ' 
        ' Lbl_gender
        ' 
        Lbl_gender.AutoSize = True
        Lbl_gender.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Lbl_gender.ForeColor = Color.Black
        Lbl_gender.Location = New Point(121, 149)
        Lbl_gender.Name = "Lbl_gender"
        Lbl_gender.Size = New Size(79, 28)
        Lbl_gender.TabIndex = 62
        Lbl_gender.Text = "Gender"
        ' 
        ' Lbl_firstname
        ' 
        Lbl_firstname.AutoSize = True
        Lbl_firstname.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Lbl_firstname.ForeColor = Color.Black
        Lbl_firstname.Location = New Point(118, 39)
        Lbl_firstname.Name = "Lbl_firstname"
        Lbl_firstname.Size = New Size(110, 28)
        Lbl_firstname.TabIndex = 61
        Lbl_firstname.Text = "First Name"
        ' 
        ' Panel_guest
        ' 
        Panel_guest.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Panel_guest.Controls.Add(closebtn)
        Panel_guest.Controls.Add(Lblguestlist)
        Panel_guest.Dock = DockStyle.Top
        Panel_guest.Location = New Point(0, 0)
        Panel_guest.Name = "Panel_guest"
        Panel_guest.Size = New Size(948, 50)
        Panel_guest.TabIndex = 4
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
        ' Guestform
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(948, 750)
        Controls.Add(pnlguestlist)
        FormBorderStyle = FormBorderStyle.None
        Name = "Guestform"
        Text = "addguestform"
        pnlguestlist.ResumeLayout(False)
        TabGuestcontrol.ResumeLayout(False)
        tabpage_viewguest.ResumeLayout(False)
        tabpage_viewguest.PerformLayout()
        CType(DGV_Guests, ComponentModel.ISupportInitialize).EndInit()
        Tabpage_addnewguest.ResumeLayout(False)
        Tabpage_addnewguest.PerformLayout()
        Panel_guest.ResumeLayout(False)
        Panel_guest.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnlguestlist As Panel
    Friend WithEvents searchbtn As Button
    Friend WithEvents Panel_guest As Panel
    Friend WithEvents Lblguestlist As Label
    Friend WithEvents DataGridViewGuestlist As DataGridView
    Friend WithEvents closebtn As Button
    Friend WithEvents TabGuestcontrol As TabControl
    Friend WithEvents tabpage_viewguest As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DGV_Guests As DataGridView
    Friend WithEvents GuestID As DataGridViewTextBoxColumn
    Friend WithEvents Firstname As DataGridViewTextBoxColumn
    Friend WithEvents Lastname As DataGridViewTextBoxColumn
    Friend WithEvents Country As DataGridViewTextBoxColumn
    Friend WithEvents Phonenumber As DataGridViewTextBoxColumn
    Friend WithEvents Gender As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Tabpage_addnewguest As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Lbl_msgggender As Label
    Friend WithEvents Lbl_msgnadults As Label
    Friend WithEvents Lbl_msggfirstname As Label
    Friend WithEvents Lbl_msgcontactno As Label
    Friend WithEvents Lbl_msggcountry As Label
    Friend WithEvents Lbl_msgguestid As Label
    Friend WithEvents Lbl_msgglastname As Label
    Friend WithEvents Country_cmbbx As ComboBox
    Friend WithEvents cmbbx_genderG As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents glastname_txtbx As TextBox
    Friend WithEvents contact_txtbx As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Gemail_txtbx As TextBox
    Friend WithEvents gfirstname_txtbx As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Lbl_lastname As Label
    Friend WithEvents Lbl_guestid As Label
    Friend WithEvents Lbl_email As Label
    Friend WithEvents Lbl_country As Label
    Friend WithEvents Lbl_contactno As Label
    Friend WithEvents Lbl_nchildren As Label
    Friend WithEvents Lbl_nadults As Label
    Friend WithEvents Lbl_gender As Label
    Friend WithEvents Lbl_firstname As Label
End Class
