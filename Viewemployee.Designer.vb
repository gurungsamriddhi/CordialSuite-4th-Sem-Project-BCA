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
        DGV_viewemployee = New DataGridView()
        Panel1 = New Panel()
        close_Btn = New Button()
        closebtn = New Button()
        Lblviewg = New Label()
        edit_btn = New Button()
        logoutbtn = New Button()
        CType(DGV_viewemployee, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DGV_viewemployee
        ' 
        DGV_viewemployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_viewemployee.Location = New Point(36, 138)
        DGV_viewemployee.Name = "DGV_viewemployee"
        DGV_viewemployee.RowHeadersWidth = 51
        DGV_viewemployee.Size = New Size(873, 354)
        DGV_viewemployee.TabIndex = 62
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Panel1.Controls.Add(logoutbtn)
        Panel1.Controls.Add(close_Btn)
        Panel1.Controls.Add(closebtn)
        Panel1.Controls.Add(Lblviewg)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(948, 57)
        Panel1.TabIndex = 63
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
        close_Btn.Location = New Point(902, 3)
        close_Btn.Name = "close_Btn"
        close_Btn.Size = New Size(43, 42)
        close_Btn.TabIndex = 24
        close_Btn.Text = "X"
        close_Btn.UseVisualStyleBackColor = False
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = SystemColors.ControlLightLight
        closebtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        closebtn.Location = New Point(431, 313)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(47, 35)
        closebtn.TabIndex = 23
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Lblviewg
        ' 
        Lblviewg.AutoSize = True
        Lblviewg.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblviewg.ForeColor = SystemColors.Window
        Lblviewg.Location = New Point(377, 9)
        Lblviewg.Name = "Lblviewg"
        Lblviewg.Size = New Size(204, 31)
        Lblviewg.TabIndex = 23
        Lblviewg.Text = "VIEW EMPLOYEES"
        ' 
        ' edit_btn
        ' 
        edit_btn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        edit_btn.FlatAppearance.BorderColor = SystemColors.Window
        edit_btn.FlatAppearance.BorderSize = 2
        edit_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        edit_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        edit_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        edit_btn.FlatStyle = FlatStyle.Flat
        edit_btn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        edit_btn.ForeColor = SystemColors.ControlLightLight
        edit_btn.Location = New Point(399, 601)
        edit_btn.Name = "edit_btn"
        edit_btn.Size = New Size(143, 58)
        edit_btn.TabIndex = 64
        edit_btn.Text = "Edit"
        edit_btn.UseVisualStyleBackColor = False
        ' 
        ' logoutbtn
        ' 
        logoutbtn.BackColor = Color.Transparent
        logoutbtn.FlatAppearance.BorderColor = SystemColors.Window
        logoutbtn.FlatAppearance.BorderSize = 0
        logoutbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        logoutbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        logoutbtn.FlatStyle = FlatStyle.Flat
        logoutbtn.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        logoutbtn.ForeColor = SystemColors.Window
        logoutbtn.Location = New Point(796, 3)
        logoutbtn.Name = "logoutbtn"
        logoutbtn.Size = New Size(100, 51)
        logoutbtn.TabIndex = 65
        logoutbtn.Text = "Log Out"
        logoutbtn.TextAlign = ContentAlignment.MiddleLeft
        logoutbtn.UseVisualStyleBackColor = False
        ' 
        ' Viewemployee
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(948, 709)
        Controls.Add(edit_btn)
        Controls.Add(Panel1)
        Controls.Add(DGV_viewemployee)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Viewemployee"
        Text = "Viewemployee"
        CType(DGV_viewemployee, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents DGV_viewemployee As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents close_Btn As Button
    Friend WithEvents closebtn As Button
    Friend WithEvents Lblviewg As Label
    Friend WithEvents edit_btn As Button
    Friend WithEvents logoutbtn As Button
End Class
