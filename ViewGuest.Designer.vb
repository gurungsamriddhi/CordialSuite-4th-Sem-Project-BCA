<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewGuest
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
        Country_cmbbx = New ComboBox()
        cmbbx_genderG = New ComboBox()
        checkout_txtbx = New TextBox()
        glastname_txtbx = New TextBox()
        contact_txtbx = New TextBox()
        checkin_txtbx = New TextBox()
        Gemail_txtbx = New TextBox()
        GuestID_txtbx = New TextBox()
        gfirstname_txtbx = New TextBox()
        editguest_btn = New Button()
        Lblglastname = New Label()
        LglguestID = New Label()
        Lblgemail = New Label()
        Lblgcountry = New Label()
        Lblcontact = New Label()
        Checkoutlb = New Label()
        checkinbtn = New Label()
        LblgGender = New Label()
        Lblgfirstname = New Label()
        Panel1 = New Panel()
        closebtn = New Button()
        Lblviewg = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
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
        Country_cmbbx.Location = New Point(509, 350)
        Country_cmbbx.Name = "Country_cmbbx"
        Country_cmbbx.Size = New Size(223, 31)
        Country_cmbbx.TabIndex = 41
        ' 
        ' cmbbx_genderG
        ' 
        cmbbx_genderG.BackColor = SystemColors.ControlLightLight
        cmbbx_genderG.FlatStyle = FlatStyle.Flat
        cmbbx_genderG.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbbx_genderG.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        cmbbx_genderG.FormattingEnabled = True
        cmbbx_genderG.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cmbbx_genderG.Location = New Point(170, 258)
        cmbbx_genderG.Name = "cmbbx_genderG"
        cmbbx_genderG.Size = New Size(159, 31)
        cmbbx_genderG.TabIndex = 40
        ' 
        ' checkout_txtbx
        ' 
        checkout_txtbx.BackColor = SystemColors.ControlLightLight
        checkout_txtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        checkout_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        checkout_txtbx.Location = New Point(315, 438)
        checkout_txtbx.Name = "checkout_txtbx"
        checkout_txtbx.Size = New Size(127, 30)
        checkout_txtbx.TabIndex = 39
        ' 
        ' glastname_txtbx
        ' 
        glastname_txtbx.BackColor = SystemColors.ControlLightLight
        glastname_txtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        glastname_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        glastname_txtbx.Location = New Point(506, 159)
        glastname_txtbx.Name = "glastname_txtbx"
        glastname_txtbx.Size = New Size(227, 30)
        glastname_txtbx.TabIndex = 38
        ' 
        ' contact_txtbx
        ' 
        contact_txtbx.BackColor = SystemColors.ControlLightLight
        contact_txtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        contact_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        contact_txtbx.Location = New Point(509, 438)
        contact_txtbx.Name = "contact_txtbx"
        contact_txtbx.Size = New Size(223, 30)
        contact_txtbx.TabIndex = 37
        ' 
        ' checkin_txtbx
        ' 
        checkin_txtbx.BackColor = SystemColors.ControlLightLight
        checkin_txtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        checkin_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        checkin_txtbx.Location = New Point(170, 438)
        checkin_txtbx.Name = "checkin_txtbx"
        checkin_txtbx.Size = New Size(111, 30)
        checkin_txtbx.TabIndex = 36
        ' 
        ' Gemail_txtbx
        ' 
        Gemail_txtbx.BackColor = SystemColors.ControlLightLight
        Gemail_txtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Gemail_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Gemail_txtbx.Location = New Point(170, 350)
        Gemail_txtbx.Name = "Gemail_txtbx"
        Gemail_txtbx.Size = New Size(227, 30)
        Gemail_txtbx.TabIndex = 35
        ' 
        ' GuestID_txtbx
        ' 
        GuestID_txtbx.BackColor = SystemColors.ControlLightLight
        GuestID_txtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GuestID_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        GuestID_txtbx.Location = New Point(509, 258)
        GuestID_txtbx.Name = "GuestID_txtbx"
        GuestID_txtbx.Size = New Size(223, 30)
        GuestID_txtbx.TabIndex = 34
        ' 
        ' gfirstname_txtbx
        ' 
        gfirstname_txtbx.BackColor = SystemColors.ControlLightLight
        gfirstname_txtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gfirstname_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        gfirstname_txtbx.Location = New Point(170, 159)
        gfirstname_txtbx.Name = "gfirstname_txtbx"
        gfirstname_txtbx.Size = New Size(227, 30)
        gfirstname_txtbx.TabIndex = 33
        ' 
        ' editguest_btn
        ' 
        editguest_btn.BackColor = SystemColors.ControlLightLight
        editguest_btn.FlatAppearance.BorderColor = SystemColors.ButtonShadow
        editguest_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        editguest_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        editguest_btn.FlatStyle = FlatStyle.Flat
        editguest_btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        editguest_btn.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        editguest_btn.Location = New Point(408, 535)
        editguest_btn.Name = "editguest_btn"
        editguest_btn.Size = New Size(106, 41)
        editguest_btn.TabIndex = 32
        editguest_btn.Text = "Edit"
        editguest_btn.UseVisualStyleBackColor = False
        ' 
        ' Lblglastname
        ' 
        Lblglastname.AutoSize = True
        Lblglastname.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblglastname.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblglastname.Location = New Point(506, 134)
        Lblglastname.Name = "Lblglastname"
        Lblglastname.Size = New Size(91, 23)
        Lblglastname.TabIndex = 30
        Lblglastname.Text = "Last Name"
        ' 
        ' LglguestID
        ' 
        LglguestID.AutoSize = True
        LglguestID.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LglguestID.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        LglguestID.Location = New Point(506, 233)
        LglguestID.Name = "LglguestID"
        LglguestID.Size = New Size(76, 23)
        LglguestID.TabIndex = 29
        LglguestID.Text = "Guest ID"
        ' 
        ' Lblgemail
        ' 
        Lblgemail.AutoSize = True
        Lblgemail.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblgemail.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblgemail.Location = New Point(170, 325)
        Lblgemail.Name = "Lblgemail"
        Lblgemail.Size = New Size(51, 23)
        Lblgemail.TabIndex = 28
        Lblgemail.Text = "Email"
        ' 
        ' Lblgcountry
        ' 
        Lblgcountry.AutoSize = True
        Lblgcountry.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblgcountry.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblgcountry.Location = New Point(509, 323)
        Lblgcountry.Name = "Lblgcountry"
        Lblgcountry.Size = New Size(73, 23)
        Lblgcountry.TabIndex = 27
        Lblgcountry.Text = "Country"
        ' 
        ' Lblcontact
        ' 
        Lblcontact.AutoSize = True
        Lblcontact.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblcontact.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblcontact.Location = New Point(509, 413)
        Lblcontact.Name = "Lblcontact"
        Lblcontact.Size = New Size(99, 23)
        Lblcontact.TabIndex = 26
        Lblcontact.Text = "Contact no."
        ' 
        ' Checkoutlb
        ' 
        Checkoutlb.AutoSize = True
        Checkoutlb.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Checkoutlb.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Checkoutlb.Location = New Point(315, 413)
        Checkoutlb.Name = "Checkoutlb"
        Checkoutlb.Size = New Size(130, 23)
        Checkoutlb.TabIndex = 25
        Checkoutlb.Text = "Check-out Date"
        ' 
        ' checkinbtn
        ' 
        checkinbtn.AutoSize = True
        checkinbtn.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        checkinbtn.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        checkinbtn.Location = New Point(170, 413)
        checkinbtn.Name = "checkinbtn"
        checkinbtn.Size = New Size(118, 23)
        checkinbtn.TabIndex = 24
        checkinbtn.Text = "Check-in Date"
        ' 
        ' LblgGender
        ' 
        LblgGender.AutoSize = True
        LblgGender.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblgGender.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        LblgGender.Location = New Point(170, 233)
        LblgGender.Name = "LblgGender"
        LblgGender.Size = New Size(66, 23)
        LblgGender.TabIndex = 23
        LblgGender.Text = "Gender"
        ' 
        ' Lblgfirstname
        ' 
        Lblgfirstname.AutoSize = True
        Lblgfirstname.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblgfirstname.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblgfirstname.Location = New Point(170, 134)
        Lblgfirstname.Name = "Lblgfirstname"
        Lblgfirstname.Size = New Size(93, 23)
        Lblgfirstname.TabIndex = 22
        Lblgfirstname.Text = "First Name"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Panel1.Controls.Add(closebtn)
        Panel1.Controls.Add(Lblviewg)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(948, 54)
        Panel1.TabIndex = 42
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
        Lblviewg.Location = New Point(419, 9)
        Lblviewg.Name = "Lblviewg"
        Lblviewg.Size = New Size(148, 31)
        Lblviewg.TabIndex = 23
        Lblviewg.Text = "VIEW GUEST"
        ' 
        ' ViewGuest
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(948, 709)
        Controls.Add(Panel1)
        Controls.Add(Country_cmbbx)
        Controls.Add(cmbbx_genderG)
        Controls.Add(checkout_txtbx)
        Controls.Add(glastname_txtbx)
        Controls.Add(contact_txtbx)
        Controls.Add(checkin_txtbx)
        Controls.Add(Gemail_txtbx)
        Controls.Add(GuestID_txtbx)
        Controls.Add(gfirstname_txtbx)
        Controls.Add(editguest_btn)
        Controls.Add(Lblglastname)
        Controls.Add(LglguestID)
        Controls.Add(Lblgemail)
        Controls.Add(Lblgcountry)
        Controls.Add(Lblcontact)
        Controls.Add(Checkoutlb)
        Controls.Add(checkinbtn)
        Controls.Add(LblgGender)
        Controls.Add(Lblgfirstname)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "ViewGuest"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ViewGuest"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Country_cmbbx As ComboBox
    Friend WithEvents cmbbx_genderG As ComboBox
    Friend WithEvents checkout_txtbx As TextBox
    Friend WithEvents glastname_txtbx As TextBox
    Friend WithEvents contact_txtbx As TextBox
    Friend WithEvents checkin_txtbx As TextBox
    Friend WithEvents Gemail_txtbx As TextBox
    Friend WithEvents GuestID_txtbx As TextBox
    Friend WithEvents gfirstname_txtbx As TextBox
    Friend WithEvents editguest_btn As Button
    Friend WithEvents Lblglastname As Label
    Friend WithEvents LglguestID As Label
    Friend WithEvents Lblgemail As Label
    Friend WithEvents Lblgcountry As Label
    Friend WithEvents Lblcontact As Label
    Friend WithEvents Checkoutlb As Label
    Friend WithEvents checkinbtn As Label
    Friend WithEvents LblgGender As Label
    Friend WithEvents Lblgfirstname As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents closebtn As Button
    Friend WithEvents Lblviewg As Label
End Class
