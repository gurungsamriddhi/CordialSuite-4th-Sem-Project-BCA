<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Pnl_diffpanel = New Panel()
        closebtn = New Button()
        Labeladminname = New Label()
        Lbl_currentadmin = New Label()
        logoutbtn = New Button()
        statusbtn = New Button()
        transactionbtn = New Button()
        viewempbtn = New Button()
        roomsbtn = New Button()
        viewguestbtn = New Button()
        Pnl_diffpanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Pnl_diffpanel
        ' 
        Pnl_diffpanel.BackColor = SystemColors.Control
        Pnl_diffpanel.Controls.Add(closebtn)
        Pnl_diffpanel.Dock = DockStyle.Right
        Pnl_diffpanel.Location = New Point(223, 0)
        Pnl_diffpanel.Name = "Pnl_diffpanel"
        Pnl_diffpanel.Size = New Size(948, 709)
        Pnl_diffpanel.TabIndex = 1
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.Transparent
        closebtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        closebtn.FlatAppearance.BorderSize = 2
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        closebtn.Location = New Point(902, 3)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(43, 42)
        closebtn.TabIndex = 13
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Labeladminname
        ' 
        Labeladminname.AutoSize = True
        Labeladminname.BackColor = Color.Transparent
        Labeladminname.FlatStyle = FlatStyle.Flat
        Labeladminname.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        Labeladminname.ForeColor = SystemColors.Window
        Labeladminname.Location = New Point(52, 36)
        Labeladminname.Name = "Labeladminname"
        Labeladminname.Size = New Size(124, 27)
        Labeladminname.TabIndex = 11
        Labeladminname.Text = "adminname"
        Labeladminname.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Lbl_currentadmin
        ' 
        Lbl_currentadmin.AutoSize = True
        Lbl_currentadmin.BackColor = Color.Transparent
        Lbl_currentadmin.FlatStyle = FlatStyle.Flat
        Lbl_currentadmin.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        Lbl_currentadmin.ForeColor = SystemColors.Window
        Lbl_currentadmin.Location = New Point(38, 9)
        Lbl_currentadmin.Name = "Lbl_currentadmin"
        Lbl_currentadmin.Size = New Size(138, 27)
        Lbl_currentadmin.TabIndex = 10
        Lbl_currentadmin.Text = "Current User:"
        Lbl_currentadmin.TextAlign = ContentAlignment.TopCenter
        ' 
        ' logoutbtn
        ' 
        logoutbtn.BackColor = Color.Transparent
        logoutbtn.FlatAppearance.BorderColor = SystemColors.Window
        logoutbtn.FlatAppearance.BorderSize = 2
        logoutbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        logoutbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        logoutbtn.FlatStyle = FlatStyle.Flat
        logoutbtn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        logoutbtn.ForeColor = SystemColors.Window
        logoutbtn.Location = New Point(27, 656)
        logoutbtn.Name = "logoutbtn"
        logoutbtn.Size = New Size(179, 41)
        logoutbtn.TabIndex = 9
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
        statusbtn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        statusbtn.ForeColor = SystemColors.Window
        statusbtn.Location = New Point(12, 188)
        statusbtn.Name = "statusbtn"
        statusbtn.Size = New Size(193, 45)
        statusbtn.TabIndex = 8
        statusbtn.Text = "Hotel Status"
        statusbtn.UseVisualStyleBackColor = False
        ' 
        ' transactionbtn
        ' 
        transactionbtn.BackColor = Color.Transparent
        transactionbtn.FlatAppearance.BorderColor = SystemColors.Window
        transactionbtn.FlatAppearance.BorderSize = 2
        transactionbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        transactionbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        transactionbtn.FlatStyle = FlatStyle.Flat
        transactionbtn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        transactionbtn.ForeColor = SystemColors.Window
        transactionbtn.Location = New Point(13, 392)
        transactionbtn.Name = "transactionbtn"
        transactionbtn.Size = New Size(193, 45)
        transactionbtn.TabIndex = 7
        transactionbtn.Text = "Transaction"
        transactionbtn.UseVisualStyleBackColor = False
        ' 
        ' viewempbtn
        ' 
        viewempbtn.BackColor = Color.Transparent
        viewempbtn.FlatAppearance.BorderColor = SystemColors.Window
        viewempbtn.FlatAppearance.BorderSize = 2
        viewempbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        viewempbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        viewempbtn.FlatStyle = FlatStyle.Flat
        viewempbtn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        viewempbtn.ForeColor = SystemColors.Window
        viewempbtn.Location = New Point(13, 290)
        viewempbtn.Name = "viewempbtn"
        viewempbtn.Size = New Size(193, 45)
        viewempbtn.TabIndex = 6
        viewempbtn.Text = "View Employee"
        viewempbtn.UseVisualStyleBackColor = False
        ' 
        ' roomsbtn
        ' 
        roomsbtn.BackColor = Color.Transparent
        roomsbtn.FlatAppearance.BorderColor = SystemColors.Window
        roomsbtn.FlatAppearance.BorderSize = 2
        roomsbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        roomsbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        roomsbtn.FlatStyle = FlatStyle.Flat
        roomsbtn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        roomsbtn.ForeColor = SystemColors.Window
        roomsbtn.Location = New Point(13, 341)
        roomsbtn.Name = "roomsbtn"
        roomsbtn.Size = New Size(193, 45)
        roomsbtn.TabIndex = 5
        roomsbtn.Text = "Rooms"
        roomsbtn.UseVisualStyleBackColor = False
        ' 
        ' viewguestbtn
        ' 
        viewguestbtn.BackColor = Color.Transparent
        viewguestbtn.FlatAppearance.BorderColor = SystemColors.Window
        viewguestbtn.FlatAppearance.BorderSize = 2
        viewguestbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        viewguestbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        viewguestbtn.FlatStyle = FlatStyle.Flat
        viewguestbtn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        viewguestbtn.ForeColor = SystemColors.Window
        viewguestbtn.Location = New Point(12, 239)
        viewguestbtn.Name = "viewguestbtn"
        viewguestbtn.Size = New Size(194, 45)
        viewguestbtn.TabIndex = 3
        viewguestbtn.Text = "View Guest"
        viewguestbtn.UseVisualStyleBackColor = False
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        ClientSize = New Size(1171, 709)
        Controls.Add(logoutbtn)
        Controls.Add(Labeladminname)
        Controls.Add(transactionbtn)
        Controls.Add(Pnl_diffpanel)
        Controls.Add(roomsbtn)
        Controls.Add(viewempbtn)
        Controls.Add(Lbl_currentadmin)
        Controls.Add(statusbtn)
        Controls.Add(viewguestbtn)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "AdminDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminDashboard"
        Pnl_diffpanel.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Pnl_diffpanel As Panel
    Friend WithEvents Labeladminname As Label
    Friend WithEvents Lbl_currentadmin As Label
    Friend WithEvents logoutbtn As Button
    Friend WithEvents statusbtn As Button
    Friend WithEvents transactionbtn As Button
    Friend WithEvents viewempbtn As Button
    Friend WithEvents roomsbtn As Button
    Friend WithEvents viewguestbtn As Button
    Friend WithEvents closebtn As Button
End Class
