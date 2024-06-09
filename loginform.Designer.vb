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
        SuspendLayout()
        ' 
        ' Lblusername
        ' 
        Lblusername.AutoSize = True
        Lblusername.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblusername.ForeColor = Color.White
        Lblusername.Location = New Point(108, 114)
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
        lblpassword.Location = New Point(108, 226)
        lblpassword.Name = "lblpassword"
        lblpassword.Size = New Size(97, 28)
        lblpassword.TabIndex = 1
        lblpassword.Text = "Password"
        ' 
        ' txtbxusername
        ' 
        txtbxusername.Font = New Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxusername.Location = New Point(108, 149)
        txtbxusername.Margin = New Padding(3, 4, 3, 4)
        txtbxusername.Name = "txtbxusername"
        txtbxusername.Size = New Size(359, 35)
        txtbxusername.TabIndex = 2
        ' 
        ' txtbxpassword
        ' 
        txtbxpassword.Font = New Font("Tahoma", 13.8F)
        txtbxpassword.Location = New Point(108, 258)
        txtbxpassword.Margin = New Padding(3, 4, 3, 4)
        txtbxpassword.Name = "txtbxpassword"
        txtbxpassword.Size = New Size(359, 35)
        txtbxpassword.TabIndex = 3
        txtbxpassword.UseSystemPasswordChar = True
        ' 
        ' Btnlogin
        ' 
        Btnlogin.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Btnlogin.FlatAppearance.BorderSize = 0
        Btnlogin.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Btnlogin.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Btnlogin.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btnlogin.ForeColor = SystemColors.ControlLightLight
        Btnlogin.Location = New Point(193, 363)
        Btnlogin.Margin = New Padding(3, 4, 3, 4)
        Btnlogin.Name = "Btnlogin"
        Btnlogin.Size = New Size(177, 51)
        Btnlogin.TabIndex = 4
        Btnlogin.Text = "Login"
        Btnlogin.UseVisualStyleBackColor = False
        ' 
        ' admin_btn
        ' 
        admin_btn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        admin_btn.FlatAppearance.BorderSize = 0
        admin_btn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        admin_btn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        admin_btn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        admin_btn.ForeColor = SystemColors.ControlLightLight
        admin_btn.Location = New Point(193, 422)
        admin_btn.Margin = New Padding(3, 4, 3, 4)
        admin_btn.Name = "admin_btn"
        admin_btn.Size = New Size(177, 51)
        admin_btn.TabIndex = 8
        admin_btn.Text = "Admin"
        admin_btn.UseVisualStyleBackColor = False
        ' 
        ' CheckBoxshowpw
        ' 
        CheckBoxshowpw.AutoSize = True
        CheckBoxshowpw.BackColor = Color.Transparent
        CheckBoxshowpw.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBoxshowpw.ForeColor = Color.White
        CheckBoxshowpw.Location = New Point(108, 300)
        CheckBoxshowpw.Name = "CheckBoxshowpw"
        CheckBoxshowpw.Size = New Size(170, 32)
        CheckBoxshowpw.TabIndex = 7
        CheckBoxshowpw.Text = "Show password"
        CheckBoxshowpw.UseVisualStyleBackColor = False
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.Transparent
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(219), CByte(215), CByte(210))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(219), CByte(215), CByte(210))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = SystemColors.Window
        closebtn.Location = New Point(475, 12)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(43, 42)
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
        Panel1.Size = New Size(23, 508)
        Panel1.TabIndex = 10
        ' 
        ' Loginform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        ClientSize = New Size(530, 508)
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
End Class
