<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newguestform
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
        clearbtn = New Button()
        newguestbtn = New Button()
        gfirstnametxtbx = New TextBox()
        GuestIDtxtbx = New TextBox()
        emailtxtbx = New TextBox()
        nadulttxtbx = New TextBox()
        contacttxtbx = New TextBox()
        glastnametxtbx = New TextBox()
        nchildrentxtbx = New TextBox()
        combobxgender = New ComboBox()
        Combobxcountry = New ComboBox()
        Lblglastname = New Label()
        Lblgfirstname = New Label()
        Panel1 = New Panel()
        Lblnewg = New Label()
        closebtn = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' LblgGender
        ' 
        LblgGender.AutoSize = True
        LblgGender.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblgGender.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        LblgGender.Location = New Point(55, 173)
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
        Lblnoofadults.Location = New Point(55, 353)
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
        Lblnoofchildren.Location = New Point(200, 353)
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
        Lblcontact.Location = New Point(394, 353)
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
        Lblgcountry.Location = New Point(394, 264)
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
        Lblgemail.Location = New Point(55, 265)
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
        LglguestID.Location = New Point(391, 173)
        LglguestID.Name = "LglguestID"
        LglguestID.Size = New Size(76, 23)
        LglguestID.TabIndex = 8
        LglguestID.Text = "Guest ID"
        ' 
        ' clearbtn
        ' 
        clearbtn.BackColor = SystemColors.ControlLightLight
        clearbtn.FlatAppearance.BorderColor = SystemColors.ButtonShadow
        clearbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        clearbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        clearbtn.FlatStyle = FlatStyle.Flat
        clearbtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        clearbtn.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        clearbtn.Location = New Point(213, 458)
        clearbtn.Name = "clearbtn"
        clearbtn.Size = New Size(101, 41)
        clearbtn.TabIndex = 10
        clearbtn.Text = "Clear"
        clearbtn.UseVisualStyleBackColor = False
        ' 
        ' newguestbtn
        ' 
        newguestbtn.BackColor = SystemColors.ControlLightLight
        newguestbtn.FlatAppearance.BorderColor = SystemColors.ButtonShadow
        newguestbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        newguestbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        newguestbtn.FlatStyle = FlatStyle.Flat
        newguestbtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        newguestbtn.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        newguestbtn.Location = New Point(344, 458)
        newguestbtn.Name = "newguestbtn"
        newguestbtn.Size = New Size(199, 41)
        newguestbtn.TabIndex = 11
        newguestbtn.Text = "Add New Guest"
        newguestbtn.UseVisualStyleBackColor = False
        ' 
        ' gfirstnametxtbx
        ' 
        gfirstnametxtbx.BackColor = SystemColors.ControlLightLight
        gfirstnametxtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gfirstnametxtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        gfirstnametxtbx.Location = New Point(55, 100)
        gfirstnametxtbx.Name = "gfirstnametxtbx"
        gfirstnametxtbx.Size = New Size(227, 30)
        gfirstnametxtbx.TabIndex = 12
        ' 
        ' GuestIDtxtbx
        ' 
        GuestIDtxtbx.BackColor = SystemColors.ControlLightLight
        GuestIDtxtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GuestIDtxtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        GuestIDtxtbx.Location = New Point(394, 199)
        GuestIDtxtbx.Name = "GuestIDtxtbx"
        GuestIDtxtbx.Size = New Size(224, 30)
        GuestIDtxtbx.TabIndex = 14
        ' 
        ' emailtxtbx
        ' 
        emailtxtbx.BackColor = SystemColors.ControlLightLight
        emailtxtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emailtxtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        emailtxtbx.Location = New Point(55, 291)
        emailtxtbx.Name = "emailtxtbx"
        emailtxtbx.Size = New Size(227, 30)
        emailtxtbx.TabIndex = 15
        ' 
        ' nadulttxtbx
        ' 
        nadulttxtbx.BackColor = SystemColors.ControlLightLight
        nadulttxtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nadulttxtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        nadulttxtbx.Location = New Point(55, 379)
        nadulttxtbx.Name = "nadulttxtbx"
        nadulttxtbx.Size = New Size(111, 30)
        nadulttxtbx.TabIndex = 16
        ' 
        ' contacttxtbx
        ' 
        contacttxtbx.BackColor = SystemColors.ControlLightLight
        contacttxtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        contacttxtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        contacttxtbx.Location = New Point(394, 379)
        contacttxtbx.Name = "contacttxtbx"
        contacttxtbx.Size = New Size(224, 30)
        contacttxtbx.TabIndex = 17
        ' 
        ' glastnametxtbx
        ' 
        glastnametxtbx.BackColor = SystemColors.ControlLightLight
        glastnametxtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        glastnametxtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        glastnametxtbx.Location = New Point(391, 100)
        glastnametxtbx.Name = "glastnametxtbx"
        glastnametxtbx.Size = New Size(227, 30)
        glastnametxtbx.TabIndex = 18
        ' 
        ' nchildrentxtbx
        ' 
        nchildrentxtbx.BackColor = SystemColors.ControlLightLight
        nchildrentxtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nchildrentxtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        nchildrentxtbx.Location = New Point(200, 379)
        nchildrentxtbx.Name = "nchildrentxtbx"
        nchildrentxtbx.Size = New Size(127, 30)
        nchildrentxtbx.TabIndex = 19
        ' 
        ' combobxgender
        ' 
        combobxgender.BackColor = SystemColors.ControlLightLight
        combobxgender.FlatStyle = FlatStyle.Flat
        combobxgender.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        combobxgender.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        combobxgender.FormattingEnabled = True
        combobxgender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        combobxgender.Location = New Point(55, 199)
        combobxgender.Name = "combobxgender"
        combobxgender.Size = New Size(159, 31)
        combobxgender.TabIndex = 20
        ' 
        ' Combobxcountry
        ' 
        Combobxcountry.BackColor = SystemColors.ControlLightLight
        Combobxcountry.DropDownHeight = 200
        Combobxcountry.DropDownWidth = 100
        Combobxcountry.FlatStyle = FlatStyle.Flat
        Combobxcountry.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Combobxcountry.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Combobxcountry.FormattingEnabled = True
        Combobxcountry.IntegralHeight = False
        Combobxcountry.Items.AddRange(New Object() {"Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "The Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo, Democratic Republic of the", "Congo, Republic of the", "Costa Rica", "Côte d’Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor (Timor-Leste)", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "The Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, North", "Korea, South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia, Federated States of", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar (Burma)", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "Sudan", "Sudan, South", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe", ""})
        Combobxcountry.Location = New Point(394, 290)
        Combobxcountry.Name = "Combobxcountry"
        Combobxcountry.Size = New Size(224, 31)
        Combobxcountry.TabIndex = 21
        ' 
        ' Lblglastname
        ' 
        Lblglastname.AutoSize = True
        Lblglastname.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblglastname.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblglastname.Location = New Point(391, 74)
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
        Lblgfirstname.Location = New Point(55, 74)
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
        Panel1.Size = New Size(659, 47)
        Panel1.TabIndex = 22
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
        ' closebtn
        ' 
        closebtn.BackColor = SystemColors.ControlLightLight
        closebtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 12F, FontStyle.Bold)
        closebtn.Location = New Point(600, 7)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(47, 34)
        closebtn.TabIndex = 23
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' newguestform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(659, 538)
        Controls.Add(Panel1)
        Controls.Add(Combobxcountry)
        Controls.Add(combobxgender)
        Controls.Add(nchildrentxtbx)
        Controls.Add(glastnametxtbx)
        Controls.Add(contacttxtbx)
        Controls.Add(nadulttxtbx)
        Controls.Add(emailtxtbx)
        Controls.Add(GuestIDtxtbx)
        Controls.Add(gfirstnametxtbx)
        Controls.Add(newguestbtn)
        Controls.Add(clearbtn)
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
        Name = "newguestform"
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
    Friend WithEvents clearbtn As Button
    Friend WithEvents newguestbtn As Button
    Friend WithEvents gfirstnametxtbx As TextBox
    Friend WithEvents GuestIDtxtbx As TextBox
    Friend WithEvents emailtxtbx As TextBox
    Friend WithEvents nadulttxtbx As TextBox
    Friend WithEvents contacttxtbx As TextBox
    Friend WithEvents glastnametxtbx As TextBox
    Friend WithEvents nchildrentxtbx As TextBox
    Friend WithEvents combobxgender As ComboBox
    Friend WithEvents Combobxcountry As ComboBox
    Friend WithEvents Lblglastname As Label
    Friend WithEvents Lblgfirstname As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lblnewg As Label
    Friend WithEvents closebtn As Button
End Class
