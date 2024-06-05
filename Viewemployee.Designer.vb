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
        Panel1 = New Panel()
        closebtn = New Button()
        Lblnewg = New Label()
        combobxgender = New ComboBox()
        glastnametxtbx = New TextBox()
        contacttxtbx = New TextBox()
        emailtxtbx = New TextBox()
        GuestIDtxtbx = New TextBox()
        gfirstnametxtbx = New TextBox()
        newguestbtn = New Button()
        clearbtn = New Button()
        Lblglastname = New Label()
        LglguestID = New Label()
        Lblgemail = New Label()
        Lblcontact = New Label()
        LblgGender = New Label()
        Lblgfirstname = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Panel1.Controls.Add(closebtn)
        Panel1.Controls.Add(Lblnewg)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(561, 35)
        Panel1.TabIndex = 24
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = SystemColors.ControlLightLight
        closebtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        closebtn.Location = New Point(525, 5)
        closebtn.Margin = New Padding(3, 2, 3, 2)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(41, 26)
        closebtn.TabIndex = 23
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Lblnewg
        ' 
        Lblnewg.AutoSize = True
        Lblnewg.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblnewg.ForeColor = SystemColors.ControlLightLight
        Lblnewg.Location = New Point(234, 7)
        Lblnewg.Name = "Lblnewg"
        Lblnewg.Size = New Size(129, 21)
        Lblnewg.TabIndex = 23
        Lblnewg.Text = "VIEW EMPLOYEE"
        ' 
        ' combobxgender
        ' 
        combobxgender.BackColor = SystemColors.ControlLightLight
        combobxgender.FlatStyle = FlatStyle.Flat
        combobxgender.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        combobxgender.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        combobxgender.FormattingEnabled = True
        combobxgender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        combobxgender.Location = New Point(34, 130)
        combobxgender.Margin = New Padding(3, 2, 3, 2)
        combobxgender.Name = "combobxgender"
        combobxgender.Size = New Size(140, 27)
        combobxgender.TabIndex = 58
        ' 
        ' glastnametxtbx
        ' 
        glastnametxtbx.BackColor = SystemColors.ControlLightLight
        glastnametxtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        glastnametxtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        glastnametxtbx.Location = New Point(328, 56)
        glastnametxtbx.Margin = New Padding(3, 2, 3, 2)
        glastnametxtbx.Name = "glastnametxtbx"
        glastnametxtbx.Size = New Size(199, 26)
        glastnametxtbx.TabIndex = 57
        ' 
        ' contacttxtbx
        ' 
        contacttxtbx.BackColor = SystemColors.ControlLightLight
        contacttxtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        contacttxtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        contacttxtbx.Location = New Point(331, 199)
        contacttxtbx.Margin = New Padding(3, 2, 3, 2)
        contacttxtbx.Name = "contacttxtbx"
        contacttxtbx.Size = New Size(196, 26)
        contacttxtbx.TabIndex = 56
        ' 
        ' emailtxtbx
        ' 
        emailtxtbx.BackColor = SystemColors.ControlLightLight
        emailtxtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emailtxtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        emailtxtbx.Location = New Point(34, 199)
        emailtxtbx.Margin = New Padding(3, 2, 3, 2)
        emailtxtbx.Name = "emailtxtbx"
        emailtxtbx.Size = New Size(199, 26)
        emailtxtbx.TabIndex = 55
        ' 
        ' GuestIDtxtbx
        ' 
        GuestIDtxtbx.BackColor = SystemColors.ControlLightLight
        GuestIDtxtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GuestIDtxtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        GuestIDtxtbx.Location = New Point(331, 130)
        GuestIDtxtbx.Margin = New Padding(3, 2, 3, 2)
        GuestIDtxtbx.Name = "GuestIDtxtbx"
        GuestIDtxtbx.Size = New Size(196, 26)
        GuestIDtxtbx.TabIndex = 54
        ' 
        ' gfirstnametxtbx
        ' 
        gfirstnametxtbx.BackColor = SystemColors.ControlLightLight
        gfirstnametxtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gfirstnametxtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        gfirstnametxtbx.Location = New Point(34, 56)
        gfirstnametxtbx.Margin = New Padding(3, 2, 3, 2)
        gfirstnametxtbx.Name = "gfirstnametxtbx"
        gfirstnametxtbx.Size = New Size(199, 26)
        gfirstnametxtbx.TabIndex = 53
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
        newguestbtn.Location = New Point(287, 325)
        newguestbtn.Margin = New Padding(3, 2, 3, 2)
        newguestbtn.Name = "newguestbtn"
        newguestbtn.Size = New Size(174, 31)
        newguestbtn.TabIndex = 52
        newguestbtn.Text = "Add New Employee"
        newguestbtn.UseVisualStyleBackColor = False
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
        clearbtn.Location = New Point(105, 325)
        clearbtn.Margin = New Padding(3, 2, 3, 2)
        clearbtn.Name = "clearbtn"
        clearbtn.Size = New Size(155, 31)
        clearbtn.TabIndex = 51
        clearbtn.Text = "Delete Employee"
        clearbtn.UseVisualStyleBackColor = False
        ' 
        ' Lblglastname
        ' 
        Lblglastname.AutoSize = True
        Lblglastname.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblglastname.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblglastname.Location = New Point(328, 37)
        Lblglastname.Name = "Lblglastname"
        Lblglastname.Size = New Size(75, 19)
        Lblglastname.TabIndex = 50
        Lblglastname.Text = "Last Name"
        ' 
        ' LglguestID
        ' 
        LglguestID.AutoSize = True
        LglguestID.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LglguestID.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        LglguestID.Location = New Point(328, 111)
        LglguestID.Name = "LglguestID"
        LglguestID.Size = New Size(87, 19)
        LglguestID.TabIndex = 49
        LglguestID.Text = "Employee ID"
        ' 
        ' Lblgemail
        ' 
        Lblgemail.AutoSize = True
        Lblgemail.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblgemail.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblgemail.Location = New Point(34, 180)
        Lblgemail.Name = "Lblgemail"
        Lblgemail.Size = New Size(43, 19)
        Lblgemail.TabIndex = 48
        Lblgemail.Text = "Email"
        ' 
        ' Lblcontact
        ' 
        Lblcontact.AutoSize = True
        Lblcontact.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblcontact.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblcontact.Location = New Point(331, 180)
        Lblcontact.Name = "Lblcontact"
        Lblcontact.Size = New Size(81, 19)
        Lblcontact.TabIndex = 46
        Lblcontact.Text = "Contact no."
        ' 
        ' LblgGender
        ' 
        LblgGender.AutoSize = True
        LblgGender.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblgGender.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        LblgGender.Location = New Point(34, 111)
        LblgGender.Name = "LblgGender"
        LblgGender.Size = New Size(54, 19)
        LblgGender.TabIndex = 45
        LblgGender.Text = "Gender"
        ' 
        ' Lblgfirstname
        ' 
        Lblgfirstname.AutoSize = True
        Lblgfirstname.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblgfirstname.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblgfirstname.Location = New Point(34, 37)
        Lblgfirstname.Name = "Lblgfirstname"
        Lblgfirstname.Size = New Size(77, 19)
        Lblgfirstname.TabIndex = 44
        Lblgfirstname.Text = "First Name"
        ' 
        ' Viewemployee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(561, 365)
        Controls.Add(combobxgender)
        Controls.Add(glastnametxtbx)
        Controls.Add(contacttxtbx)
        Controls.Add(emailtxtbx)
        Controls.Add(GuestIDtxtbx)
        Controls.Add(gfirstnametxtbx)
        Controls.Add(newguestbtn)
        Controls.Add(clearbtn)
        Controls.Add(Lblglastname)
        Controls.Add(LglguestID)
        Controls.Add(Lblgemail)
        Controls.Add(Lblcontact)
        Controls.Add(LblgGender)
        Controls.Add(Lblgfirstname)
        Controls.Add(Panel1)
        Name = "Viewemployee"
        Text = "Viewemployee"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents closebtn As Button
    Friend WithEvents Lblnewg As Label
    Friend WithEvents combobxgender As ComboBox
    Friend WithEvents glastnametxtbx As TextBox
    Friend WithEvents contacttxtbx As TextBox
    Friend WithEvents emailtxtbx As TextBox
    Friend WithEvents GuestIDtxtbx As TextBox
    Friend WithEvents gfirstnametxtbx As TextBox
    Friend WithEvents newguestbtn As Button
    Friend WithEvents clearbtn As Button
    Friend WithEvents Lblglastname As Label
    Friend WithEvents LglguestID As Label
    Friend WithEvents Lblgemail As Label
    Friend WithEvents Lblcontact As Label
    Friend WithEvents LblgGender As Label
    Friend WithEvents Lblgfirstname As Label
End Class
