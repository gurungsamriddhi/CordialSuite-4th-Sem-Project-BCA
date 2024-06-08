<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newguest_form
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
        LblgGender = New Label()
        Lblnoofadults = New Label()
        Lblnoofchildren = New Label()
        Lblcontact = New Label()
        Lblgcountry = New Label()
        Lblgemail = New Label()
        LglguestID = New Label()
        clear_btn = New Button()
        addnewguest_btn = New Button()
        gfirstname_txtbx = New TextBox()
        GuestID_txtbx = New TextBox()
        Gemail_txtbx = New TextBox()
        nadult_txtbx = New TextBox()
        contact_txtbx = New TextBox()
        glastname_txtbx = New TextBox()
        nchildren_txtbx = New TextBox()
        cmbbx_genderG = New ComboBox()
        Country_cmbbx = New ComboBox()
        Lblglastname = New Label()
        Lblgfirstname = New Label()
        Panel1 = New Panel()
        closebtn = New Button()
        Lblnewg = New Label()
        Lbl_msggfirstname = New Label()
        Lbl_msgglastname = New Label()
        Lbl_msgggender = New Label()
        Lbl_msgguestid = New Label()
        Lbl_msggemail = New Label()
        Ll_msggcountry = New Label()
        Lbl_msgnadults = New Label()
        labl_msgnchildren = New Label()
        Lbl_msgcontact = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' LblgGender
        ' 
        LblgGender.AutoSize = True
        LblgGender.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblgGender.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        LblgGender.Location = New Point(56, 186)
        LblgGender.Name = "LblgGender"
        LblgGender.Size = New Size(66, 23)
        LblgGender.TabIndex = 2
        LblgGender.Text = "Gender"
        ' 
        ' Lblnoofadults
        ' 
        Lblnoofadults.AutoSize = True
        Lblnoofadults.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblnoofadults.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblnoofadults.Location = New Point(56, 370)
        Lblnoofadults.Name = "Lblnoofadults"
        Lblnoofadults.Size = New Size(111, 23)
        Lblnoofadults.TabIndex = 3
        Lblnoofadults.Text = "No. of Adults"
        ' 
        ' Lblnoofchildren
        ' 
        Lblnoofchildren.AutoSize = True
        Lblnoofchildren.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblnoofchildren.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblnoofchildren.Location = New Point(201, 370)
        Lblnoofchildren.Name = "Lblnoofchildren"
        Lblnoofchildren.Size = New Size(127, 23)
        Lblnoofchildren.TabIndex = 4
        Lblnoofchildren.Text = "No. of Children"
        ' 
        ' Lblcontact
        ' 
        Lblcontact.AutoSize = True
        Lblcontact.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblcontact.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblcontact.Location = New Point(395, 370)
        Lblcontact.Name = "Lblcontact"
        Lblcontact.Size = New Size(99, 23)
        Lblcontact.TabIndex = 5
        Lblcontact.Text = "Contact no."
        ' 
        ' Lblgcountry
        ' 
        Lblgcountry.AutoSize = True
        Lblgcountry.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblgcountry.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblgcountry.Location = New Point(395, 277)
        Lblgcountry.Name = "Lblgcountry"
        Lblgcountry.Size = New Size(73, 23)
        Lblgcountry.TabIndex = 6
        Lblgcountry.Text = "Country"
        ' 
        ' Lblgemail
        ' 
        Lblgemail.AutoSize = True
        Lblgemail.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblgemail.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblgemail.Location = New Point(56, 278)
        Lblgemail.Name = "Lblgemail"
        Lblgemail.Size = New Size(51, 23)
        Lblgemail.TabIndex = 7
        Lblgemail.Text = "Email"
        ' 
        ' LglguestID
        ' 
        LglguestID.AutoSize = True
        LglguestID.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LglguestID.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        LglguestID.Location = New Point(392, 186)
        LglguestID.Name = "LglguestID"
        LglguestID.Size = New Size(76, 23)
        LglguestID.TabIndex = 8
        LglguestID.Text = "Guest ID"
        ' 
        ' clear_btn
        ' 
        clear_btn.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        clear_btn.FlatAppearance.BorderColor = SystemColors.ButtonShadow
        clear_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        clear_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        clear_btn.FlatStyle = FlatStyle.Flat
        clear_btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        clear_btn.ForeColor = SystemColors.ControlLightLight
        clear_btn.Location = New Point(214, 471)
        clear_btn.Name = "clear_btn"
        clear_btn.Size = New Size(101, 41)
        clear_btn.TabIndex = 10
        clear_btn.Text = "Clear"
        clear_btn.UseVisualStyleBackColor = False
        ' 
        ' addnewguest_btn
        ' 
        addnewguest_btn.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        addnewguest_btn.FlatAppearance.BorderColor = SystemColors.ButtonShadow
        addnewguest_btn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        addnewguest_btn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        addnewguest_btn.FlatStyle = FlatStyle.Flat
        addnewguest_btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addnewguest_btn.ForeColor = SystemColors.ControlLightLight
        addnewguest_btn.Location = New Point(349, 471)
        addnewguest_btn.Name = "addnewguest_btn"
        addnewguest_btn.Size = New Size(106, 41)
        addnewguest_btn.TabIndex = 11
        addnewguest_btn.Text = "Add "
        addnewguest_btn.UseVisualStyleBackColor = False
        ' 
        ' gfirstname_txtbx
        ' 
        gfirstname_txtbx.BackColor = SystemColors.ControlLightLight
        gfirstname_txtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gfirstname_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        gfirstname_txtbx.Location = New Point(56, 113)
        gfirstname_txtbx.Name = "gfirstname_txtbx"
        gfirstname_txtbx.Size = New Size(227, 30)
        gfirstname_txtbx.TabIndex = 12
        ' 
        ' GuestID_txtbx
        ' 
        GuestID_txtbx.BackColor = SystemColors.ControlLightLight
        GuestID_txtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GuestID_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        GuestID_txtbx.Location = New Point(395, 212)
        GuestID_txtbx.Name = "GuestID_txtbx"
        GuestID_txtbx.Size = New Size(224, 30)
        GuestID_txtbx.TabIndex = 14
        ' 
        ' Gemail_txtbx
        ' 
        Gemail_txtbx.BackColor = SystemColors.ControlLightLight
        Gemail_txtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Gemail_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Gemail_txtbx.Location = New Point(56, 304)
        Gemail_txtbx.Name = "Gemail_txtbx"
        Gemail_txtbx.Size = New Size(227, 30)
        Gemail_txtbx.TabIndex = 15
        ' 
        ' nadult_txtbx
        ' 
        nadult_txtbx.BackColor = SystemColors.ControlLightLight
        nadult_txtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nadult_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        nadult_txtbx.Location = New Point(56, 396)
        nadult_txtbx.Name = "nadult_txtbx"
        nadult_txtbx.Size = New Size(111, 30)
        nadult_txtbx.TabIndex = 16
        ' 
        ' contact_txtbx
        ' 
        contact_txtbx.BackColor = SystemColors.ControlLightLight
        contact_txtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        contact_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        contact_txtbx.Location = New Point(395, 396)
        contact_txtbx.Name = "contact_txtbx"
        contact_txtbx.Size = New Size(224, 30)
        contact_txtbx.TabIndex = 17
        ' 
        ' glastname_txtbx
        ' 
        glastname_txtbx.BackColor = SystemColors.ControlLightLight
        glastname_txtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        glastname_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        glastname_txtbx.Location = New Point(392, 113)
        glastname_txtbx.Name = "glastname_txtbx"
        glastname_txtbx.Size = New Size(227, 30)
        glastname_txtbx.TabIndex = 18
        ' 
        ' nchildren_txtbx
        ' 
        nchildren_txtbx.BackColor = SystemColors.ControlLightLight
        nchildren_txtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nchildren_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        nchildren_txtbx.Location = New Point(201, 396)
        nchildren_txtbx.Name = "nchildren_txtbx"
        nchildren_txtbx.Size = New Size(127, 30)
        nchildren_txtbx.TabIndex = 19
        ' 
        ' cmbbx_genderG
        ' 
        cmbbx_genderG.BackColor = SystemColors.ControlLightLight
        cmbbx_genderG.FlatStyle = FlatStyle.Flat
        cmbbx_genderG.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbbx_genderG.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        cmbbx_genderG.FormattingEnabled = True
        cmbbx_genderG.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cmbbx_genderG.Location = New Point(56, 212)
        cmbbx_genderG.Name = "cmbbx_genderG"
        cmbbx_genderG.Size = New Size(159, 31)
        cmbbx_genderG.TabIndex = 20
        ' 
        ' Country_cmbbx
        ' 
        Country_cmbbx.BackColor = SystemColors.ControlLightLight
        Country_cmbbx.DropDownHeight = 200
        Country_cmbbx.DropDownWidth = 100
        Country_cmbbx.FlatStyle = FlatStyle.Flat
        Country_cmbbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Country_cmbbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Country_cmbbx.FormattingEnabled = True
        Country_cmbbx.IntegralHeight = False
        Country_cmbbx.Items.AddRange(New Object() {"Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "The Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo, Democratic Republic of the", "Congo, Republic of the", "Costa Rica", "Côte d’Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor (Timor-Leste)", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "The Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, North", "Korea, South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia, Federated States of", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar (Burma)", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "Sudan", "Sudan, South", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe", ""})
        Country_cmbbx.Location = New Point(395, 303)
        Country_cmbbx.Name = "Country_cmbbx"
        Country_cmbbx.Size = New Size(224, 31)
        Country_cmbbx.TabIndex = 21
        ' 
        ' Lblglastname
        ' 
        Lblglastname.AutoSize = True
        Lblglastname.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblglastname.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblglastname.Location = New Point(392, 87)
        Lblglastname.Name = "Lblglastname"
        Lblglastname.Size = New Size(91, 23)
        Lblglastname.TabIndex = 9
        Lblglastname.Text = "Last Name"
        ' 
        ' Lblgfirstname
        ' 
        Lblgfirstname.AutoSize = True
        Lblgfirstname.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblgfirstname.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblgfirstname.Location = New Point(56, 87)
        Lblgfirstname.Name = "Lblgfirstname"
        Lblgfirstname.Size = New Size(93, 23)
        Lblgfirstname.TabIndex = 1
        Lblgfirstname.Text = "First Name"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Panel1.Controls.Add(closebtn)
        Panel1.Controls.Add(Lblnewg)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(662, 47)
        Panel1.TabIndex = 22
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = SystemColors.ControlLightLight
        closebtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 12F, FontStyle.Bold)
        closebtn.Location = New Point(603, 7)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(47, 34)
        closebtn.TabIndex = 23
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Lblnewg
        ' 
        Lblnewg.AutoSize = True
        Lblnewg.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblnewg.ForeColor = SystemColors.ControlLightLight
        Lblnewg.Location = New Point(268, 9)
        Lblnewg.Name = "Lblnewg"
        Lblnewg.Size = New Size(122, 28)
        Lblnewg.TabIndex = 23
        Lblnewg.Text = "NEW GUEST"
        ' 
        ' Lbl_msggfirstname
        ' 
        Lbl_msggfirstname.AutoSize = True
        Lbl_msggfirstname.BackColor = Color.Transparent
        Lbl_msggfirstname.ForeColor = Color.Red
        Lbl_msggfirstname.Location = New Point(59, 146)
        Lbl_msggfirstname.Name = "Lbl_msggfirstname"
        Lbl_msggfirstname.Size = New Size(0, 20)
        Lbl_msggfirstname.TabIndex = 23
        ' 
        ' Lbl_msgglastname
        ' 
        Lbl_msgglastname.AutoSize = True
        Lbl_msgglastname.BackColor = Color.Transparent
        Lbl_msgglastname.ForeColor = Color.Red
        Lbl_msgglastname.Location = New Point(392, 146)
        Lbl_msgglastname.Name = "Lbl_msgglastname"
        Lbl_msgglastname.Size = New Size(0, 20)
        Lbl_msgglastname.TabIndex = 24
        ' 
        ' Lbl_msgggender
        ' 
        Lbl_msgggender.AutoSize = True
        Lbl_msgggender.BackColor = Color.Transparent
        Lbl_msgggender.ForeColor = Color.Red
        Lbl_msgggender.Location = New Point(56, 246)
        Lbl_msgggender.Name = "Lbl_msgggender"
        Lbl_msgggender.Size = New Size(0, 20)
        Lbl_msgggender.TabIndex = 25
        ' 
        ' Lbl_msgguestid
        ' 
        Lbl_msgguestid.AutoSize = True
        Lbl_msgguestid.BackColor = Color.Transparent
        Lbl_msgguestid.ForeColor = Color.Red
        Lbl_msgguestid.Location = New Point(395, 245)
        Lbl_msgguestid.Name = "Lbl_msgguestid"
        Lbl_msgguestid.Size = New Size(0, 20)
        Lbl_msgguestid.TabIndex = 26
        ' 
        ' Lbl_msggemail
        ' 
        Lbl_msggemail.AutoSize = True
        Lbl_msggemail.BackColor = Color.Transparent
        Lbl_msggemail.ForeColor = Color.Red
        Lbl_msggemail.Location = New Point(59, 337)
        Lbl_msggemail.Name = "Lbl_msggemail"
        Lbl_msggemail.Size = New Size(0, 20)
        Lbl_msggemail.TabIndex = 27
        ' 
        ' Ll_msggcountry
        ' 
        Ll_msggcountry.AutoSize = True
        Ll_msggcountry.BackColor = Color.Transparent
        Ll_msggcountry.ForeColor = Color.Red
        Ll_msggcountry.Location = New Point(395, 337)
        Ll_msggcountry.Name = "Ll_msggcountry"
        Ll_msggcountry.Size = New Size(0, 20)
        Ll_msggcountry.TabIndex = 28
        ' 
        ' Lbl_msgnadults
        ' 
        Lbl_msgnadults.AutoSize = True
        Lbl_msgnadults.BackColor = Color.Transparent
        Lbl_msgnadults.ForeColor = Color.Red
        Lbl_msgnadults.Location = New Point(53, 416)
        Lbl_msgnadults.Name = "Lbl_msgnadults"
        Lbl_msgnadults.Size = New Size(0, 20)
        Lbl_msgnadults.TabIndex = 29
        ' 
        ' labl_msgnchildren
        ' 
        labl_msgnchildren.AutoSize = True
        labl_msgnchildren.BackColor = Color.Transparent
        labl_msgnchildren.ForeColor = Color.Red
        labl_msgnchildren.Location = New Point(201, 429)
        labl_msgnchildren.Name = "labl_msgnchildren"
        labl_msgnchildren.Size = New Size(0, 20)
        labl_msgnchildren.TabIndex = 30
        ' 
        ' Lbl_msgcontact
        ' 
        Lbl_msgcontact.AutoSize = True
        Lbl_msgcontact.BackColor = Color.Transparent
        Lbl_msgcontact.ForeColor = Color.Red
        Lbl_msgcontact.Location = New Point(395, 429)
        Lbl_msgcontact.Name = "Lbl_msgcontact"
        Lbl_msgcontact.Size = New Size(0, 20)
        Lbl_msgcontact.TabIndex = 31
        ' 
        ' newguest_form
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(662, 585)
        Controls.Add(Lbl_msgcontact)
        Controls.Add(labl_msgnchildren)
        Controls.Add(Lbl_msgnadults)
        Controls.Add(Ll_msggcountry)
        Controls.Add(Lbl_msggemail)
        Controls.Add(Lbl_msgguestid)
        Controls.Add(Lbl_msgggender)
        Controls.Add(Lbl_msgglastname)
        Controls.Add(Lbl_msggfirstname)
        Controls.Add(Panel1)
        Controls.Add(Country_cmbbx)
        Controls.Add(cmbbx_genderG)
        Controls.Add(nchildren_txtbx)
        Controls.Add(glastname_txtbx)
        Controls.Add(contact_txtbx)
        Controls.Add(nadult_txtbx)
        Controls.Add(Gemail_txtbx)
        Controls.Add(GuestID_txtbx)
        Controls.Add(gfirstname_txtbx)
        Controls.Add(addnewguest_btn)
        Controls.Add(clear_btn)
        Controls.Add(Lblglastname)
        Controls.Add(LglguestID)
        Controls.Add(Lblgemail)
        Controls.Add(Lblgcountry)
        Controls.Add(Lblcontact)
        Controls.Add(Lblnoofchildren)
        Controls.Add(Lblnoofadults)
        Controls.Add(LblgGender)
        Controls.Add(Lblgfirstname)
        FormBorderStyle = FormBorderStyle.None
        Name = "newguest_form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "addguest"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LblgGender As Label
    Friend WithEvents Lblnoofadults As Label
    Friend WithEvents Lblnoofchildren As Label
    Friend WithEvents Lblcontact As Label
    Friend WithEvents Lblgcountry As Label
    Friend WithEvents Lblgemail As Label
    Friend WithEvents LglguestID As Label
    Friend WithEvents clear_btn As Button
    Friend WithEvents addnewguest_btn As Button
    Friend WithEvents gfirstname_txtbx As TextBox
    Friend WithEvents GuestID_txtbx As TextBox
    Friend WithEvents Gemail_txtbx As TextBox
    Friend WithEvents nadult_txtbx As TextBox
    Friend WithEvents contact_txtbx As TextBox
    Friend WithEvents glastname_txtbx As TextBox
    Friend WithEvents nchildren_txtbx As TextBox
    Friend WithEvents cmbbx_genderG As ComboBox
    Friend WithEvents Country_cmbbx As ComboBox
    Friend WithEvents Lblglastname As Label
    Friend WithEvents Lblgfirstname As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lblnewg As Label
    Friend WithEvents closebtn As Button
    Friend WithEvents Lbl_msggfirstname As Label
    Friend WithEvents Lbl_msgglastname As Label
    Friend WithEvents Lbl_msgggender As Label
    Friend WithEvents Lbl_msgguestid As Label
    Friend WithEvents Lbl_msggemail As Label
    Friend WithEvents Ll_msggcountry As Label
    Friend WithEvents Lbl_msgnadults As Label
    Friend WithEvents labl_msgnchildren As Label
    Friend WithEvents Lbl_msgcontact As Label
End Class
