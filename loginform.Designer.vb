<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginform
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
        Lblusername = New Label()
        lblpassword = New Label()
        txtbxusername = New TextBox()
        txtbxpassword = New TextBox()
        Btnlogin = New Button()
        admin_btn = New Button()
        CheckBoxshowpw = New CheckBox()
        closebtn = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        minimise_btn = New Button()
        SuspendLayout()
        ' 
        ' Lblusername
        ' 
        Lblusername.AutoSize = True
        Lblusername.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblusername.ForeColor = Color.White
        Lblusername.Location = New Point(149, 162)
        Lblusername.Margin = New Padding(3)
        Lblusername.Name = "Lblusername"
        Lblusername.Size = New Size(104, 28)
        Lblusername.TabIndex = 0
        Lblusername.Text = "Username"
        ' 
        ' lblpassword
        ' 
        lblpassword.AutoSize = True
        lblpassword.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblpassword.ForeColor = Color.White
        lblpassword.Location = New Point(149, 268)
        lblpassword.Name = "lblpassword"
        lblpassword.Size = New Size(97, 28)
        lblpassword.TabIndex = 1
        lblpassword.Text = "Password"
        ' 
        ' txtbxusername
        ' 
        txtbxusername.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxusername.Location = New Point(149, 197)
        txtbxusername.Margin = New Padding(3, 4, 3, 4)
        txtbxusername.Name = "txtbxusername"
        txtbxusername.Size = New Size(359, 38)
        txtbxusername.TabIndex = 2
        ' 
        ' txtbxpassword
        ' 
        txtbxpassword.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxpassword.Location = New Point(149, 300)
        txtbxpassword.Margin = New Padding(3, 4, 3, 4)
        txtbxpassword.Name = "txtbxpassword"
        txtbxpassword.Size = New Size(359, 38)
        txtbxpassword.TabIndex = 3
        txtbxpassword.UseSystemPasswordChar = True
        ' 
        ' Btnlogin
        ' 
        Btnlogin.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Btnlogin.FlatAppearance.BorderColor = Color.White
        Btnlogin.FlatAppearance.BorderSize = 2
        Btnlogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Btnlogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Btnlogin.FlatStyle = FlatStyle.Flat
        Btnlogin.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btnlogin.ForeColor = SystemColors.ControlLightLight
        Btnlogin.Location = New Point(224, 415)
        Btnlogin.Margin = New Padding(3, 4, 3, 4)
        Btnlogin.Name = "Btnlogin"
        Btnlogin.Size = New Size(183, 45)
        Btnlogin.TabIndex = 4
        Btnlogin.Text = "Login"
        Btnlogin.UseVisualStyleBackColor = False
        ' 
        ' admin_btn
        ' 
        admin_btn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        admin_btn.FlatAppearance.BorderColor = Color.White
        admin_btn.FlatAppearance.BorderSize = 2
        admin_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        admin_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        admin_btn.FlatStyle = FlatStyle.Flat
        admin_btn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        admin_btn.ForeColor = SystemColors.ControlLightLight
        admin_btn.Location = New Point(224, 474)
        admin_btn.Margin = New Padding(3, 4, 3, 4)
        admin_btn.Name = "admin_btn"
        admin_btn.Size = New Size(183, 45)
        admin_btn.TabIndex = 8
        admin_btn.Text = "Super Admin"
        admin_btn.UseVisualStyleBackColor = False
        ' 
        ' CheckBoxshowpw
        ' 
        CheckBoxshowpw.AutoSize = True
        CheckBoxshowpw.BackColor = Color.Transparent
        CheckBoxshowpw.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBoxshowpw.ForeColor = Color.White
        CheckBoxshowpw.Location = New Point(149, 342)
        CheckBoxshowpw.Name = "CheckBoxshowpw"
        CheckBoxshowpw.Size = New Size(170, 32)
        CheckBoxshowpw.TabIndex = 7
        CheckBoxshowpw.Text = "Show password"
        CheckBoxshowpw.UseVisualStyleBackColor = False
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.Transparent
        closebtn.FlatAppearance.BorderSize = 2
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = SystemColors.Window
        closebtn.Location = New Point(578, 4)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(42, 39)
        closebtn.TabIndex = 8
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Window
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(23, 539)
        Panel1.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Window
        Label1.Location = New Point(149, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(197, 31)
        Label1.TabIndex = 14
        Label1.Text = "ACCOUNT LOGIN"
        ' 
        ' minimise_btn
        ' 
        minimise_btn.BackColor = Color.Transparent
        minimise_btn.FlatAppearance.BorderColor = Color.White
        minimise_btn.FlatAppearance.BorderSize = 2
        minimise_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        minimise_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        minimise_btn.FlatStyle = FlatStyle.Flat
        minimise_btn.Font = New Font("Perpetua Titling MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        minimise_btn.ForeColor = SystemColors.Window
        minimise_btn.Location = New Point(530, 4)
        minimise_btn.Name = "minimise_btn"
        minimise_btn.Size = New Size(42, 39)
        minimise_btn.TabIndex = 28
        minimise_btn.Text = "-"
        minimise_btn.UseVisualStyleBackColor = False
        ' 
        ' Loginform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        ClientSize = New Size(627, 539)
        Controls.Add(minimise_btn)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(admin_btn)
        Controls.Add(closebtn)
        Controls.Add(CheckBoxshowpw)
        Controls.Add(Btnlogin)
        Controls.Add(txtbxusername)
        Controls.Add(txtbxpassword)
        Controls.Add(lblpassword)
        Controls.Add(Lblusername)
        ForeColor = Color.Transparent
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Loginform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lblusername As Label
    Friend WithEvents lblpassword As Label
    Friend WithEvents txtbxusername As TextBox
    Friend WithEvents txtbxpassword As TextBox
    Friend WithEvents Btnlogin As Button
    Friend WithEvents CheckBoxshowpw As CheckBox
    Friend WithEvents closebtn As Button
    Friend WithEvents admin_btn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents minimise_btn As Button
End Class
