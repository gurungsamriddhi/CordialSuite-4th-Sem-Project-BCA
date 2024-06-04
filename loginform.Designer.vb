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
        PnlLogin = New Panel()
        CheckBoxshowpw = New CheckBox()
        Linktoregister = New LinkLabel()
        Linkforgotpw = New LinkLabel()
        closebtn = New Button()
        PnlLogin.SuspendLayout()
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
        ' txtbxusername
        ' 
        txtbxusername.Font = New Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxusername.Location = New Point(109, 122)
        txtbxusername.Margin = New Padding(3, 4, 3, 4)
        txtbxusername.Name = "txtbxusername"
        txtbxusername.Size = New Size(260, 35)
        txtbxusername.TabIndex = 2
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
        PnlLogin.BackColor = Color.LightCyan
        PnlLogin.BorderStyle = BorderStyle.Fixed3D
        PnlLogin.Controls.Add(CheckBoxshowpw)
        PnlLogin.Controls.Add(Linktoregister)
        PnlLogin.Controls.Add(Linkforgotpw)
        PnlLogin.Controls.Add(txtbxusername)
        PnlLogin.Controls.Add(Btnlogin)
        PnlLogin.Controls.Add(txtbxpassword)
        PnlLogin.Controls.Add(lblpassword)
        PnlLogin.Controls.Add(Lblusername)
        PnlLogin.Location = New Point(281, 68)
        PnlLogin.Name = "Panel1"
        PnlLogin.Size = New Size(459, 448)
        PnlLogin.TabIndex = 5
        ' 
        ' CheckBox1
        ' 
        CheckBoxshowpw.AutoSize = True
        CheckBoxshowpw.BackColor = Color.Transparent
        CheckBoxshowpw.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBoxshowpw.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        CheckBoxshowpw.Location = New Point(109, 246)
        CheckBoxshowpw.Name = "CheckBox1"
        CheckBoxshowpw.Size = New Size(136, 24)
        CheckBoxshowpw.TabIndex = 7
        CheckBoxshowpw.Text = "Show password"
        CheckBoxshowpw.UseVisualStyleBackColor = False
        ' 
        ' Linkregister
        ' 
        Linktoregister.ActiveLinkColor = Color.MidnightBlue
        Linktoregister.AutoSize = True
        Linktoregister.Font = New Font("Segoe UI", 9.0F)
        Linktoregister.LinkColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Linktoregister.Location = New Point(133, 396)
        Linktoregister.Name = "Linkregister"
        Linktoregister.Size = New Size(217, 20)
        Linktoregister.TabIndex = 6
        Linktoregister.TabStop = True
        Linktoregister.Text = "Don't have an account?Register"
        ' 
        ' Linkforgotpw
        ' 
        Linkforgotpw.ActiveLinkColor = Color.MidnightBlue
        Linkforgotpw.AutoSize = True
        Linkforgotpw.Font = New Font("Segoe UI", 9.0F)
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
        closebtn.Font = New Font("Lucida Fax", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        ClientSize = New Size(1021, 585)
        Controls.Add(closebtn)
        Controls.Add(PnlLogin)
        ForeColor = Color.Transparent
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Loginform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        PnlLogin.ResumeLayout(False)
        PnlLogin.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Lblusername As Label
    Friend WithEvents lblpassword As Label
    Friend WithEvents txtbxusername As TextBox
    Friend WithEvents txtbxpassword As TextBox
    Friend WithEvents Btnlogin As Button
    Friend WithEvents PnlLogin As Panel
    Friend WithEvents Linktoregister As LinkLabel
    Friend WithEvents Linkforgotpw As LinkLabel
    Friend WithEvents CheckBoxshowpw As CheckBox
    Friend WithEvents closebtn As Button
End Class
