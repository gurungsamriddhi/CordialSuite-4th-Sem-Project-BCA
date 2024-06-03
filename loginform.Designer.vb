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
        txtbxuser = New TextBox()
        txtbxpassword = New TextBox()
        Btnlogin = New Button()
        Panel1 = New Panel()
        CheckBox1 = New CheckBox()
        Linkregister = New LinkLabel()
        Linkforgotpw = New LinkLabel()
        closebtn = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Lblusername
        ' 
        Lblusername.AutoSize = True
        Lblusername.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblusername.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Lblusername.Location = New Point(109, 93)
        Lblusername.Margin = New Padding(3)
        Lblusername.Name = "Lblusername"
        Lblusername.Size = New Size(87, 23)
        Lblusername.TabIndex = 0
        Lblusername.Text = "Username"
        ' 
        ' lblpassword
        ' 
        lblpassword.AutoSize = True
        lblpassword.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        lblpassword.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        lblpassword.Location = New Point(109, 178)
        lblpassword.Name = "lblpassword"
        lblpassword.Size = New Size(82, 23)
        lblpassword.TabIndex = 1
        lblpassword.Text = "Password"
        ' 
        ' txtbxuser
        ' 
        txtbxuser.Font = New Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxuser.Location = New Point(109, 122)
        txtbxuser.Margin = New Padding(3, 4, 3, 4)
        txtbxuser.Name = "txtbxuser"
        txtbxuser.Size = New Size(260, 35)
        txtbxuser.TabIndex = 2
        ' 
        ' txtbxpassword
        ' 
        txtbxpassword.Font = New Font("Tahoma", 13.8F)
        txtbxpassword.Location = New Point(109, 204)
        txtbxpassword.Margin = New Padding(3, 4, 3, 4)
        txtbxpassword.Name = "txtbxpassword"
        txtbxpassword.Size = New Size(260, 35)
        txtbxpassword.TabIndex = 3
        txtbxpassword.TextAlign = HorizontalAlignment.Center
        ' 
        ' Btnlogin
        ' 
        Btnlogin.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Btnlogin.FlatAppearance.BorderSize = 0
        Btnlogin.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Btnlogin.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Btnlogin.FlatStyle = FlatStyle.Flat
        Btnlogin.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btnlogin.ForeColor = SystemColors.ControlLightLight
        Btnlogin.Location = New Point(173, 295)
        Btnlogin.Margin = New Padding(3, 4, 3, 4)
        Btnlogin.Name = "Btnlogin"
        Btnlogin.Size = New Size(128, 45)
        Btnlogin.TabIndex = 4
        Btnlogin.Text = "Login"
        Btnlogin.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightCyan
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Linkregister)
        Panel1.Controls.Add(Linkforgotpw)
        Panel1.Controls.Add(txtbxuser)
        Panel1.Controls.Add(Btnlogin)
        Panel1.Controls.Add(txtbxpassword)
        Panel1.Controls.Add(lblpassword)
        Panel1.Controls.Add(Lblusername)
        Panel1.Location = New Point(281, 68)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(459, 448)
        Panel1.TabIndex = 5
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox1.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        CheckBox1.Location = New Point(109, 246)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(136, 24)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "Show password"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Linkregister
        ' 
        Linkregister.ActiveLinkColor = Color.MidnightBlue
        Linkregister.AutoSize = True
        Linkregister.Font = New Font("Segoe UI", 9F)
        Linkregister.LinkColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Linkregister.Location = New Point(133, 396)
        Linkregister.Name = "Linkregister"
        Linkregister.Size = New Size(217, 20)
        Linkregister.TabIndex = 6
        Linkregister.TabStop = True
        Linkregister.Text = "Don't have an account?Register"
        ' 
        ' Linkforgotpw
        ' 
        Linkforgotpw.ActiveLinkColor = Color.MidnightBlue
        Linkforgotpw.AutoSize = True
        Linkforgotpw.Font = New Font("Segoe UI", 9F)
        Linkforgotpw.LinkColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Linkforgotpw.Location = New Point(173, 366)
        Linkforgotpw.Name = "Linkforgotpw"
        Linkforgotpw.Size = New Size(125, 20)
        Linkforgotpw.TabIndex = 5
        Linkforgotpw.TabStop = True
        Linkforgotpw.Text = "Forgot Password?"
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.Transparent
        closebtn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        closebtn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = SystemColors.ControlLightLight
        closebtn.Location = New Point(962, 12)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(47, 34)
        closebtn.TabIndex = 6
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Loginform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        ClientSize = New Size(1021, 585)
        Controls.Add(closebtn)
        Controls.Add(Panel1)
        ForeColor = Color.Transparent
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Loginform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Lblusername As Label
    Friend WithEvents lblpassword As Label
    Friend WithEvents txtbxuser As TextBox
    Friend WithEvents txtbxpassword As TextBox
    Friend WithEvents Btnlogin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Linkregister As LinkLabel
    Friend WithEvents Linkforgotpw As LinkLabel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents closebtn As Button
End Class
