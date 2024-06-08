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
        cmbbx_gendere = New ComboBox()
        salary_txtbx = New TextBox()
        elastname_txtbx = New TextBox()
        Econtact_txtbx = New TextBox()
        job_txtbx = New TextBox()
        Eemail_txtbx = New TextBox()
        EmployeeiD_txtbx = New TextBox()
        efirstname_txtbx = New TextBox()
        Lblglastname = New Label()
        LglempiD = New Label()
        Lblgemail = New Label()
        Lblgaddress = New Label()
        Lblcontact = New Label()
        Salary = New Label()
        jobbtn = New Label()
        LblgGender = New Label()
        Lblgfirstname = New Label()
        AddressTextBox = New TextBox()
        editEMP_btn = New Button()
        Panel1 = New Panel()
        closebtn = New Button()
        Lblviewemp = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmbbx_gendere
        ' 
        cmbbx_gendere.BackColor = SystemColors.ScrollBar
        cmbbx_gendere.FlatStyle = FlatStyle.Flat
        cmbbx_gendere.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbbx_gendere.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        cmbbx_gendere.FormattingEnabled = True
        cmbbx_gendere.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cmbbx_gendere.Location = New Point(73, 177)
        cmbbx_gendere.Margin = New Padding(3, 2, 3, 2)
        cmbbx_gendere.Name = "cmbbx_gendere"
        cmbbx_gendere.Size = New Size(140, 27)
        cmbbx_gendere.TabIndex = 58
        ' 
        ' salary_txtbx
        ' 
        salary_txtbx.BackColor = SystemColors.ControlLightLight
        salary_txtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        salary_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        salary_txtbx.Location = New Point(200, 312)
        salary_txtbx.Margin = New Padding(3, 2, 3, 2)
        salary_txtbx.Name = "salary_txtbx"
        salary_txtbx.Size = New Size(112, 26)
        salary_txtbx.TabIndex = 57
        ' 
        ' elastname_txtbx
        ' 
        elastname_txtbx.BackColor = SystemColors.ControlLightLight
        elastname_txtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        elastname_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        elastname_txtbx.Location = New Point(367, 103)
        elastname_txtbx.Margin = New Padding(3, 2, 3, 2)
        elastname_txtbx.Name = "elastname_txtbx"
        elastname_txtbx.Size = New Size(199, 26)
        elastname_txtbx.TabIndex = 56
        ' 
        ' Econtact_txtbx
        ' 
        Econtact_txtbx.BackColor = SystemColors.ControlLightLight
        Econtact_txtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Econtact_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Econtact_txtbx.Location = New Point(370, 312)
        Econtact_txtbx.Margin = New Padding(3, 2, 3, 2)
        Econtact_txtbx.Name = "Econtact_txtbx"
        Econtact_txtbx.Size = New Size(196, 26)
        Econtact_txtbx.TabIndex = 55
        ' 
        ' job_txtbx
        ' 
        job_txtbx.BackColor = SystemColors.ControlLightLight
        job_txtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        job_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        job_txtbx.Location = New Point(73, 312)
        job_txtbx.Margin = New Padding(3, 2, 3, 2)
        job_txtbx.Name = "job_txtbx"
        job_txtbx.Size = New Size(98, 26)
        job_txtbx.TabIndex = 54
        ' 
        ' Eemail_txtbx
        ' 
        Eemail_txtbx.BackColor = SystemColors.ControlLightLight
        Eemail_txtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Eemail_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Eemail_txtbx.Location = New Point(73, 246)
        Eemail_txtbx.Margin = New Padding(3, 2, 3, 2)
        Eemail_txtbx.Name = "Eemail_txtbx"
        Eemail_txtbx.Size = New Size(199, 26)
        Eemail_txtbx.TabIndex = 53
        ' 
        ' EmployeeiD_txtbx
        ' 
        EmployeeiD_txtbx.BackColor = SystemColors.ControlLightLight
        EmployeeiD_txtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        EmployeeiD_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        EmployeeiD_txtbx.Location = New Point(370, 177)
        EmployeeiD_txtbx.Margin = New Padding(3, 2, 3, 2)
        EmployeeiD_txtbx.Name = "EmployeeiD_txtbx"
        EmployeeiD_txtbx.Size = New Size(196, 26)
        EmployeeiD_txtbx.TabIndex = 52
        ' 
        ' efirstname_txtbx
        ' 
        efirstname_txtbx.BackColor = SystemColors.ControlLightLight
        efirstname_txtbx.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        efirstname_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        efirstname_txtbx.Location = New Point(73, 103)
        efirstname_txtbx.Margin = New Padding(3, 2, 3, 2)
        efirstname_txtbx.Name = "efirstname_txtbx"
        efirstname_txtbx.Size = New Size(199, 26)
        efirstname_txtbx.TabIndex = 51
        ' 
        ' Lblglastname
        ' 
        Lblglastname.AutoSize = True
        Lblglastname.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblglastname.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblglastname.Location = New Point(367, 84)
        Lblglastname.Name = "Lblglastname"
        Lblglastname.Size = New Size(75, 19)
        Lblglastname.TabIndex = 50
        Lblglastname.Text = "Last Name"
        ' 
        ' LglempiD
        ' 
        LglempiD.AutoSize = True
        LglempiD.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LglempiD.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        LglempiD.Location = New Point(367, 158)
        LglempiD.Name = "LglempiD"
        LglempiD.Size = New Size(83, 19)
        LglempiD.TabIndex = 49
        LglempiD.Text = "EmployeeID"
        ' 
        ' Lblgemail
        ' 
        Lblgemail.AutoSize = True
        Lblgemail.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblgemail.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblgemail.Location = New Point(73, 227)
        Lblgemail.Name = "Lblgemail"
        Lblgemail.Size = New Size(43, 19)
        Lblgemail.TabIndex = 48
        Lblgemail.Text = "Email"
        ' 
        ' Lblgaddress
        ' 
        Lblgaddress.AutoSize = True
        Lblgaddress.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblgaddress.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblgaddress.Location = New Point(370, 226)
        Lblgaddress.Name = "Lblgaddress"
        Lblgaddress.Size = New Size(58, 19)
        Lblgaddress.TabIndex = 47
        Lblgaddress.Text = "Address"
        ' 
        ' Lblcontact
        ' 
        Lblcontact.AutoSize = True
        Lblcontact.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblcontact.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblcontact.Location = New Point(370, 293)
        Lblcontact.Name = "Lblcontact"
        Lblcontact.Size = New Size(81, 19)
        Lblcontact.TabIndex = 46
        Lblcontact.Text = "Contact no."
        ' 
        ' Salary
        ' 
        Salary.AutoSize = True
        Salary.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Salary.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Salary.Location = New Point(200, 293)
        Salary.Name = "Salary"
        Salary.Size = New Size(48, 19)
        Salary.TabIndex = 45
        Salary.Text = "Salary"
        ' 
        ' jobbtn
        ' 
        jobbtn.AutoSize = True
        jobbtn.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        jobbtn.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        jobbtn.Location = New Point(73, 293)
        jobbtn.Name = "jobbtn"
        jobbtn.Size = New Size(63, 19)
        jobbtn.TabIndex = 44
        jobbtn.Text = "Job Title"
        ' 
        ' LblgGender
        ' 
        LblgGender.AutoSize = True
        LblgGender.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblgGender.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        LblgGender.Location = New Point(73, 158)
        LblgGender.Name = "LblgGender"
        LblgGender.Size = New Size(54, 19)
        LblgGender.TabIndex = 43
        LblgGender.Text = "Gender"
        ' 
        ' Lblgfirstname
        ' 
        Lblgfirstname.AutoSize = True
        Lblgfirstname.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblgfirstname.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Lblgfirstname.Location = New Point(73, 84)
        Lblgfirstname.Name = "Lblgfirstname"
        Lblgfirstname.Size = New Size(77, 19)
        Lblgfirstname.TabIndex = 42
        Lblgfirstname.Text = "First Name"
        ' 
        ' AddressTextBox
        ' 
        AddressTextBox.BackColor = SystemColors.ControlLightLight
        AddressTextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AddressTextBox.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        AddressTextBox.Location = New Point(370, 246)
        AddressTextBox.Margin = New Padding(3, 2, 3, 2)
        AddressTextBox.Name = "AddressTextBox"
        AddressTextBox.Size = New Size(196, 26)
        AddressTextBox.TabIndex = 59
        ' 
        ' editEMP_btn
        ' 
        editEMP_btn.BackColor = SystemColors.ControlLightLight
        editEMP_btn.FlatAppearance.BorderColor = SystemColors.ButtonShadow
        editEMP_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        editEMP_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        editEMP_btn.FlatStyle = FlatStyle.Flat
        editEMP_btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        editEMP_btn.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        editEMP_btn.Location = New Point(292, 372)
        editEMP_btn.Margin = New Padding(3, 2, 3, 2)
        editEMP_btn.Name = "editEMP_btn"
        editEMP_btn.Size = New Size(93, 31)
        editEMP_btn.TabIndex = 60
        editEMP_btn.Text = "Edit"
        editEMP_btn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Panel1.Controls.Add(closebtn)
        Panel1.Controls.Add(Lblviewemp)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(632, 44)
        Panel1.TabIndex = 61
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = SystemColors.ControlLightLight
        closebtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        closebtn.Location = New Point(588, 7)
        closebtn.Margin = New Padding(3, 2, 3, 2)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(41, 26)
        closebtn.TabIndex = 23
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Lblviewemp
        ' 
        Lblviewemp.AutoSize = True
        Lblviewemp.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblviewemp.ForeColor = SystemColors.ControlLightLight
        Lblviewemp.Location = New Point(252, 12)
        Lblviewemp.Name = "Lblviewemp"
        Lblviewemp.Size = New Size(129, 21)
        Lblviewemp.TabIndex = 23
        Lblviewemp.Text = "VIEW EMPLOYEE"
        ' 
        ' Viewemployee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(632, 450)
        Controls.Add(Panel1)
        Controls.Add(editEMP_btn)
        Controls.Add(AddressTextBox)
        Controls.Add(cmbbx_gendere)
        Controls.Add(salary_txtbx)
        Controls.Add(elastname_txtbx)
        Controls.Add(Econtact_txtbx)
        Controls.Add(job_txtbx)
        Controls.Add(Eemail_txtbx)
        Controls.Add(EmployeeiD_txtbx)
        Controls.Add(efirstname_txtbx)
        Controls.Add(Lblglastname)
        Controls.Add(LglempiD)
        Controls.Add(Lblgemail)
        Controls.Add(Lblgaddress)
        Controls.Add(Lblcontact)
        Controls.Add(Salary)
        Controls.Add(jobbtn)
        Controls.Add(LblgGender)
        Controls.Add(Lblgfirstname)
        FormBorderStyle = FormBorderStyle.None
        Name = "Viewemployee"
        Text = "Viewemployee"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbbx_gendere As ComboBox
    Friend WithEvents salary_txtbx As TextBox
    Friend WithEvents elastname_txtbx As TextBox
    Friend WithEvents Econtact_txtbx As TextBox
    Friend WithEvents job_txtbx As TextBox
    Friend WithEvents Eemail_txtbx As TextBox
    Friend WithEvents EmployeeiD_txtbx As TextBox
    Friend WithEvents efirstname_txtbx As TextBox
    Friend WithEvents Lblglastname As Label
    Friend WithEvents LglempiD As Label
    Friend WithEvents Lblgemail As Label
    Friend WithEvents Lblgaddress As Label
    Friend WithEvents Lblcontact As Label
    Friend WithEvents Salary As Label
    Friend WithEvents jobbtn As Label
    Friend WithEvents LblgGender As Label
    Friend WithEvents Lblgfirstname As Label
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents editEMP_btn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents closebtn As Button
    Friend WithEvents Lblviewemp As Label
End Class
