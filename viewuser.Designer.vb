<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewuser
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DGV_users = New DataGridView()
        searchusers_txtbx = New TextBox()
        searchusers_btn = New Button()
        Panel1 = New Panel()
        closebtn = New Button()
        Lblguestlist = New Label()
        Tabcontrolusers = New TabControl()
        TabPageViewUser = New TabPage()
        Label1 = New Label()
        update_deletetabpage = New TabPage()
        Lbl_msgpassword = New Label()
        Lbl_msgusername = New Label()
        Lbl_msgusertype = New Label()
        UD_usernametxtbx = New TextBox()
        UD_passwordtxtbx = New TextBox()
        UD_usertypecmbbx = New ComboBox()
        deluser_Btn = New Button()
        updateuser_Btn = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        CType(DGV_users, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Tabcontrolusers.SuspendLayout()
        TabPageViewUser.SuspendLayout()
        update_deletetabpage.SuspendLayout()
        SuspendLayout()
        ' 
        ' DGV_users
        ' 
        DGV_users.AllowUserToAddRows = False
        DGV_users.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.Window
        DGV_users.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DGV_users.Anchor = AnchorStyles.None
        DGV_users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV_users.BackgroundColor = SystemColors.MenuBar
        DGV_users.BorderStyle = BorderStyle.None
        DGV_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_users.GridColor = SystemColors.Menu
        DGV_users.Location = New Point(32, 146)
        DGV_users.Name = "DGV_users"
        DGV_users.ReadOnly = True
        DGV_users.RowHeadersWidth = 51
        DGV_users.Size = New Size(782, 446)
        DGV_users.TabIndex = 6
        ' 
        ' searchusers_txtbx
        ' 
        searchusers_txtbx.Anchor = AnchorStyles.None
        searchusers_txtbx.BackColor = SystemColors.ControlLightLight
        searchusers_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchusers_txtbx.ForeColor = Color.Black
        searchusers_txtbx.Location = New Point(303, 83)
        searchusers_txtbx.Name = "searchusers_txtbx"
        searchusers_txtbx.Size = New Size(285, 38)
        searchusers_txtbx.TabIndex = 7
        ' 
        ' searchusers_btn
        ' 
        searchusers_btn.Anchor = AnchorStyles.None
        searchusers_btn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        searchusers_btn.FlatAppearance.BorderColor = SystemColors.Window
        searchusers_btn.FlatAppearance.BorderSize = 2
        searchusers_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        searchusers_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        searchusers_btn.FlatStyle = FlatStyle.Flat
        searchusers_btn.Font = New Font("Calisto MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        searchusers_btn.ForeColor = SystemColors.Window
        searchusers_btn.Location = New Point(622, 78)
        searchusers_btn.Name = "searchusers_btn"
        searchusers_btn.Size = New Size(112, 43)
        searchusers_btn.TabIndex = 8
        searchusers_btn.Text = "Search"
        searchusers_btn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Panel1.Controls.Add(closebtn)
        Panel1.Controls.Add(Lblguestlist)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(948, 58)
        Panel1.TabIndex = 9
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
        closebtn.Location = New Point(897, 3)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(48, 48)
        closebtn.TabIndex = 12
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Lblguestlist
        ' 
        Lblguestlist.AutoSize = True
        Lblguestlist.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblguestlist.ForeColor = SystemColors.ControlLightLight
        Lblguestlist.Location = New Point(402, 12)
        Lblguestlist.Name = "Lblguestlist"
        Lblguestlist.Size = New Size(147, 31)
        Lblguestlist.TabIndex = 1
        Lblguestlist.Text = "VIEW USERS"
        ' 
        ' Tabcontrolusers
        ' 
        Tabcontrolusers.Alignment = TabAlignment.Bottom
        Tabcontrolusers.Anchor = AnchorStyles.None
        Tabcontrolusers.Controls.Add(TabPageViewUser)
        Tabcontrolusers.Controls.Add(update_deletetabpage)
        Tabcontrolusers.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Tabcontrolusers.Location = New Point(31, 80)
        Tabcontrolusers.Name = "Tabcontrolusers"
        Tabcontrolusers.SelectedIndex = 0
        Tabcontrolusers.Size = New Size(872, 646)
        Tabcontrolusers.TabIndex = 10
        ' 
        ' TabPageViewUser
        ' 
        TabPageViewUser.Controls.Add(Label1)
        TabPageViewUser.Controls.Add(DGV_users)
        TabPageViewUser.Controls.Add(searchusers_txtbx)
        TabPageViewUser.Controls.Add(searchusers_btn)
        TabPageViewUser.Location = New Point(4, 4)
        TabPageViewUser.Name = "TabPageViewUser"
        TabPageViewUser.Padding = New Padding(3)
        TabPageViewUser.Size = New Size(864, 610)
        TabPageViewUser.TabIndex = 0
        TabPageViewUser.Text = "Search User"
        TabPageViewUser.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(303, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 25)
        Label1.TabIndex = 9
        Label1.Text = "Username :"
        ' 
        ' update_deletetabpage
        ' 
        update_deletetabpage.Controls.Add(Lbl_msgpassword)
        update_deletetabpage.Controls.Add(Lbl_msgusername)
        update_deletetabpage.Controls.Add(Lbl_msgusertype)
        update_deletetabpage.Controls.Add(UD_usernametxtbx)
        update_deletetabpage.Controls.Add(UD_passwordtxtbx)
        update_deletetabpage.Controls.Add(UD_usertypecmbbx)
        update_deletetabpage.Controls.Add(deluser_Btn)
        update_deletetabpage.Controls.Add(updateuser_Btn)
        update_deletetabpage.Controls.Add(Label4)
        update_deletetabpage.Controls.Add(Label3)
        update_deletetabpage.Controls.Add(Label2)
        update_deletetabpage.Location = New Point(4, 4)
        update_deletetabpage.Name = "update_deletetabpage"
        update_deletetabpage.Padding = New Padding(3)
        update_deletetabpage.Size = New Size(864, 610)
        update_deletetabpage.TabIndex = 1
        update_deletetabpage.Text = "Update and Delete User"
        update_deletetabpage.UseVisualStyleBackColor = True
        ' 
        ' Lbl_msgpassword
        ' 
        Lbl_msgpassword.AutoSize = True
        Lbl_msgpassword.ForeColor = Color.Red
        Lbl_msgpassword.Location = New Point(323, 367)
        Lbl_msgpassword.Name = "Lbl_msgpassword"
        Lbl_msgpassword.Size = New Size(404, 23)
        Lbl_msgpassword.TabIndex = 28
        Lbl_msgpassword.Text = "Password must contain atleat one special character!"
        ' 
        ' Lbl_msgusername
        ' 
        Lbl_msgusername.AutoSize = True
        Lbl_msgusername.ForeColor = Color.Red
        Lbl_msgusername.Location = New Point(323, 283)
        Lbl_msgusername.Name = "Lbl_msgusername"
        Lbl_msgusername.Size = New Size(357, 23)
        Lbl_msgusername.TabIndex = 27
        Lbl_msgusername.Text = "Username already exists ,try adding numbers!"
        ' 
        ' Lbl_msgusertype
        ' 
        Lbl_msgusertype.AutoSize = True
        Lbl_msgusertype.ForeColor = Color.Red
        Lbl_msgusertype.Location = New Point(323, 198)
        Lbl_msgusertype.Name = "Lbl_msgusertype"
        Lbl_msgusertype.Size = New Size(130, 23)
        Lbl_msgusertype.TabIndex = 26
        Lbl_msgusertype.Text = "Select usertype!"
        ' 
        ' UD_usernametxtbx
        ' 
        UD_usernametxtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UD_usernametxtbx.ForeColor = Color.Black
        UD_usernametxtbx.Location = New Point(323, 242)
        UD_usernametxtbx.Name = "UD_usernametxtbx"
        UD_usernametxtbx.Size = New Size(293, 38)
        UD_usernametxtbx.TabIndex = 25
        ' 
        ' UD_passwordtxtbx
        ' 
        UD_passwordtxtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UD_passwordtxtbx.ForeColor = Color.Black
        UD_passwordtxtbx.Location = New Point(323, 326)
        UD_passwordtxtbx.Name = "UD_passwordtxtbx"
        UD_passwordtxtbx.Size = New Size(293, 38)
        UD_passwordtxtbx.TabIndex = 24
        ' 
        ' UD_usertypecmbbx
        ' 
        UD_usertypecmbbx.BackColor = SystemColors.ControlLightLight
        UD_usertypecmbbx.FlatStyle = FlatStyle.System
        UD_usertypecmbbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UD_usertypecmbbx.ForeColor = Color.Black
        UD_usertypecmbbx.FormattingEnabled = True
        UD_usertypecmbbx.Items.AddRange(New Object() {"Admin", "User"})
        UD_usertypecmbbx.Location = New Point(323, 156)
        UD_usertypecmbbx.Name = "UD_usertypecmbbx"
        UD_usertypecmbbx.Size = New Size(293, 39)
        UD_usertypecmbbx.TabIndex = 23
        ' 
        ' deluser_Btn
        ' 
        deluser_Btn.BackColor = Color.Red
        deluser_Btn.FlatAppearance.BorderColor = SystemColors.Window
        deluser_Btn.FlatAppearance.BorderSize = 2
        deluser_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(204), CByte(0), CByte(0))
        deluser_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(204), CByte(0), CByte(0))
        deluser_Btn.FlatStyle = FlatStyle.Flat
        deluser_Btn.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        deluser_Btn.ForeColor = SystemColors.Window
        deluser_Btn.Location = New Point(473, 498)
        deluser_Btn.Name = "deluser_Btn"
        deluser_Btn.Size = New Size(219, 54)
        deluser_Btn.TabIndex = 13
        deluser_Btn.Text = "Delete"
        deluser_Btn.UseVisualStyleBackColor = False
        ' 
        ' updateuser_Btn
        ' 
        updateuser_Btn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        updateuser_Btn.FlatAppearance.BorderColor = SystemColors.Window
        updateuser_Btn.FlatAppearance.BorderSize = 2
        updateuser_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        updateuser_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        updateuser_Btn.FlatStyle = FlatStyle.Flat
        updateuser_Btn.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        updateuser_Btn.ForeColor = SystemColors.Window
        updateuser_Btn.Location = New Point(188, 498)
        updateuser_Btn.Name = "updateuser_Btn"
        updateuser_Btn.Size = New Size(219, 54)
        updateuser_Btn.TabIndex = 12
        updateuser_Btn.Text = "Update"
        updateuser_Btn.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label4.Location = New Point(188, 167)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 28)
        Label4.TabIndex = 2
        Label4.Text = "Usertype :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.Location = New Point(194, 336)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 28)
        Label3.TabIndex = 1
        Label3.Text = "Password :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label2.Location = New Point(188, 252)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 28)
        Label2.TabIndex = 0
        Label2.Text = "Username :"
        ' 
        ' viewuser
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(948, 750)
        Controls.Add(Tabcontrolusers)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Name = "viewuser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Search User"
        CType(DGV_users, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Tabcontrolusers.ResumeLayout(False)
        TabPageViewUser.ResumeLayout(False)
        TabPageViewUser.PerformLayout()
        update_deletetabpage.ResumeLayout(False)
        update_deletetabpage.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DGV_users As DataGridView
    Friend WithEvents searchusers_txtbx As TextBox
    Friend WithEvents searchusers_btn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents closebtn As Button
    Friend WithEvents Lblguestlist As Label
    Friend WithEvents Tabcontrolusers As TabControl
    Friend WithEvents TabPageViewUser As TabPage
    Friend WithEvents update_deletetabpage As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents updateuser_Btn As Button
    Friend WithEvents deluser_Btn As Button
    Friend WithEvents UD_usertypecmbbx As ComboBox
    Friend WithEvents UD_usernametxtbx As TextBox
    Friend WithEvents UD_passwordtxtbx As TextBox
    Friend WithEvents Lbl_msgusertype As Label
    Friend WithEvents Lbl_msgpassword As Label
    Friend WithEvents Lbl_msgusername As Label
End Class
