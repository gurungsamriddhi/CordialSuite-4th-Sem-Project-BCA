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
        Panel1 = New Panel()
        close_Btn = New Button()
        Labeladminname = New Label()
        Lbl_currentadmin = New Label()
        logoutbtn = New Button()
        statusbtn = New Button()
        transactionbtn = New Button()
        viewempbtn = New Button()
        roomsbtn = New Button()
        viewguestbtn = New Button()
        Pnl_diffpanel.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Pnl_diffpanel
        ' 
        Pnl_diffpanel.BackColor = SystemColors.Control
        Pnl_diffpanel.Controls.Add(Panel1)
        Pnl_diffpanel.Dock = DockStyle.Right
        Pnl_diffpanel.Location = New Point(245, 0)
        Pnl_diffpanel.Name = "Pnl_diffpanel"
        Pnl_diffpanel.Size = New Size(1037, 792)
        Pnl_diffpanel.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Panel1.Controls.Add(close_Btn)
        Panel1.Controls.Add(Labeladminname)
        Panel1.Controls.Add(Lbl_currentadmin)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1037, 60)
        Panel1.TabIndex = 14
        ' 
        ' close_Btn
        ' 
        close_Btn.BackColor = Color.Transparent
        close_Btn.FlatAppearance.BorderColor = Color.White
        close_Btn.FlatAppearance.BorderSize = 2
        close_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        close_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        close_Btn.FlatStyle = FlatStyle.Flat
        close_Btn.Font = New Font("Lucida Fax", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        close_Btn.ForeColor = SystemColors.Window
        close_Btn.Location = New Point(982, 6)
        close_Btn.Name = "close_Btn"
        close_Btn.Size = New Size(43, 42)
        close_Btn.TabIndex = 25
        close_Btn.Text = "X"
        close_Btn.UseVisualStyleBackColor = False
        ' 
        ' Labeladminname
        ' 
        Labeladminname.AutoSize = True
        Labeladminname.BackColor = Color.Transparent
        Labeladminname.FlatStyle = FlatStyle.Flat
        Labeladminname.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        Labeladminname.ForeColor = SystemColors.Window
        Labeladminname.Location = New Point(155, 15)
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
        Lbl_currentadmin.Location = New Point(11, 15)
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
        logoutbtn.Location = New Point(61, 690)
        logoutbtn.Name = "logoutbtn"
        logoutbtn.Size = New Size(119, 48)
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
        statusbtn.Location = New Point(20, 186)
        statusbtn.Name = "statusbtn"
        statusbtn.Size = New Size(205, 45)
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
        transactionbtn.Location = New Point(20, 418)
        transactionbtn.Name = "transactionbtn"
        transactionbtn.Size = New Size(205, 45)
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
        viewempbtn.Location = New Point(20, 306)
        viewempbtn.Name = "viewempbtn"
        viewempbtn.Size = New Size(205, 45)
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
        roomsbtn.Location = New Point(20, 365)
        roomsbtn.Name = "roomsbtn"
        roomsbtn.Size = New Size(205, 45)
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
        viewguestbtn.Location = New Point(20, 246)
        viewguestbtn.Name = "viewguestbtn"
        viewguestbtn.Size = New Size(205, 45)
        viewguestbtn.TabIndex = 3
        viewguestbtn.Text = "View Guest"
        viewguestbtn.UseVisualStyleBackColor = False
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        ClientSize = New Size(1282, 792)
        Controls.Add(logoutbtn)
        Controls.Add(transactionbtn)
        Controls.Add(Pnl_diffpanel)
        Controls.Add(roomsbtn)
        Controls.Add(viewempbtn)
        Controls.Add(statusbtn)
        Controls.Add(viewguestbtn)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "AdminDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminDashboard"
        Pnl_diffpanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents close_Btn As Button
End Class
