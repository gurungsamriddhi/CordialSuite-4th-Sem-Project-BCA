<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class superadmin_dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Pnl_diffform = New Panel()
        Panel1 = New Panel()
        lbl_superadminname = New Label()
        Lbl_currentadmin = New Label()
        closebtn = New Button()
        Panel2 = New Panel()
        logoutbtn = New Button()
        statusbtn = New Button()
        Button1 = New Button()
        Button2 = New Button()
        admindashb_btn = New Button()
        Pnl_diffform.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Pnl_diffform
        ' 
        Pnl_diffform.BackColor = SystemColors.Control
        Pnl_diffform.Controls.Add(Panel1)
        Pnl_diffform.Controls.Add(closebtn)
        Pnl_diffform.Controls.Add(Panel2)
        Pnl_diffform.Controls.Add(logoutbtn)
        Pnl_diffform.Dock = DockStyle.Right
        Pnl_diffform.Location = New Point(252, 0)
        Pnl_diffform.Name = "Pnl_diffform"
        Pnl_diffform.Size = New Size(948, 750)
        Pnl_diffform.TabIndex = 6
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Panel1.Controls.Add(lbl_superadminname)
        Panel1.Controls.Add(Lbl_currentadmin)
        Panel1.Location = New Point(0, 68)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(948, 99)
        Panel1.TabIndex = 15
        ' 
        ' lbl_superadminname
        ' 
        lbl_superadminname.AutoSize = True
        lbl_superadminname.BackColor = Color.Transparent
        lbl_superadminname.FlatStyle = FlatStyle.Flat
        lbl_superadminname.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        lbl_superadminname.ForeColor = SystemColors.Window
        lbl_superadminname.Location = New Point(155, 30)
        lbl_superadminname.Name = "lbl_superadminname"
        lbl_superadminname.Size = New Size(177, 27)
        lbl_superadminname.TabIndex = 11
        lbl_superadminname.Text = "superadminname"
        lbl_superadminname.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Lbl_currentadmin
        ' 
        Lbl_currentadmin.AutoSize = True
        Lbl_currentadmin.BackColor = Color.Transparent
        Lbl_currentadmin.FlatStyle = FlatStyle.Flat
        Lbl_currentadmin.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        Lbl_currentadmin.ForeColor = SystemColors.Window
        Lbl_currentadmin.Location = New Point(11, 30)
        Lbl_currentadmin.Name = "Lbl_currentadmin"
        Lbl_currentadmin.Size = New Size(138, 27)
        Lbl_currentadmin.TabIndex = 10
        Lbl_currentadmin.Text = "Current User:"
        Lbl_currentadmin.TextAlign = ContentAlignment.TopCenter
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.Transparent
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(219), CByte(215), CByte(210))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        closebtn.Location = New Point(887, 3)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(58, 48)
        closebtn.TabIndex = 10
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Window
        Panel2.Location = New Point(3, 153)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(0, 0)
        Panel2.TabIndex = 10
        ' 
        ' logoutbtn
        ' 
        logoutbtn.BackColor = Color.Transparent
        logoutbtn.FlatAppearance.BorderColor = SystemColors.Control
        logoutbtn.FlatAppearance.BorderSize = 2
        logoutbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        logoutbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        logoutbtn.FlatStyle = FlatStyle.Flat
        logoutbtn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        logoutbtn.ForeColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        logoutbtn.Location = New Point(756, 6)
        logoutbtn.Name = "logoutbtn"
        logoutbtn.Size = New Size(125, 45)
        logoutbtn.TabIndex = 10
        logoutbtn.Text = "Log Out"
        logoutbtn.UseVisualStyleBackColor = False
        ' 
        ' statusbtn
        ' 
        statusbtn.BackColor = Color.Transparent
        statusbtn.FlatAppearance.BorderColor = SystemColors.Window
        statusbtn.FlatAppearance.BorderSize = 2
        statusbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        statusbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        statusbtn.FlatStyle = FlatStyle.Flat
        statusbtn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        statusbtn.ForeColor = SystemColors.Window
        statusbtn.Location = New Point(16, 220)
        statusbtn.Name = "statusbtn"
        statusbtn.Size = New Size(205, 45)
        statusbtn.TabIndex = 9
        statusbtn.Text = "Register New User"
        statusbtn.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderColor = SystemColors.Window
        Button1.FlatAppearance.BorderSize = 2
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.Window
        Button1.Location = New Point(16, 282)
        Button1.Name = "Button1"
        Button1.Size = New Size(205, 45)
        Button1.TabIndex = 11
        Button1.Text = "View Users"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderColor = SystemColors.Window
        Button2.FlatAppearance.BorderSize = 2
        Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.Window
        Button2.Location = New Point(16, 344)
        Button2.Name = "Button2"
        Button2.Size = New Size(205, 45)
        Button2.TabIndex = 12
        Button2.Text = "Update and Delete"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' admindashb_btn
        ' 
        admindashb_btn.BackColor = Color.Transparent
        admindashb_btn.FlatAppearance.BorderColor = SystemColors.Window
        admindashb_btn.FlatAppearance.BorderSize = 2
        admindashb_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        admindashb_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        admindashb_btn.FlatStyle = FlatStyle.Flat
        admindashb_btn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        admindashb_btn.ForeColor = SystemColors.Window
        admindashb_btn.Location = New Point(16, 409)
        admindashb_btn.Name = "admindashb_btn"
        admindashb_btn.Size = New Size(205, 45)
        admindashb_btn.TabIndex = 13
        admindashb_btn.Text = "Admin Dashboard"
        admindashb_btn.UseVisualStyleBackColor = False
        ' 
        ' superadmin_dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        ClientSize = New Size(1200, 750)
        Controls.Add(admindashb_btn)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(statusbtn)
        Controls.Add(Pnl_diffform)
        ForeColor = Color.Transparent
        FormBorderStyle = FormBorderStyle.None
        Name = "superadmin_dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Options"
        Pnl_diffform.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents label1 As label
    Friend WithEvents Pnl_diffform As Panel
    Friend WithEvents closebtn As Button
    Friend WithEvents statusbtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents logoutbtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents admindashb_btn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_superadminname As Label
    Friend WithEvents Lbl_currentadmin As Label
End Class
