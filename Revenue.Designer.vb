<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Revenue
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
        Panel1 = New Panel()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button5 = New Button()
        combobxperiod = New ComboBox()
        LblgGender = New Label()
        closebtn = New Button()
        logoutbtn = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(combobxperiod)
        Panel1.Controls.Add(LblgGender)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(192, 709)
        Panel1.TabIndex = 24
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Button1.FlatAppearance.BorderColor = SystemColors.Control
        Button1.FlatAppearance.BorderSize = 2
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Tahoma", 10.8F)
        Button1.ForeColor = SystemColors.Window
        Button1.Location = New Point(8, 188)
        Button1.Name = "Button1"
        Button1.Size = New Size(166, 40)
        Button1.TabIndex = 27
        Button1.Text = "Total Income"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Button2.FlatAppearance.BorderColor = SystemColors.Control
        Button2.FlatAppearance.BorderSize = 2
        Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Tahoma", 10.8F)
        Button2.ForeColor = SystemColors.Window
        Button2.Location = New Point(8, 325)
        Button2.Name = "Button2"
        Button2.Size = New Size(166, 40)
        Button2.TabIndex = 26
        Button2.Text = "Total Transaction"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Button3.FlatAppearance.BorderColor = SystemColors.Control
        Button3.FlatAppearance.BorderSize = 2
        Button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Tahoma", 10.8F)
        Button3.ForeColor = SystemColors.Window
        Button3.Location = New Point(8, 280)
        Button3.Name = "Button3"
        Button3.Size = New Size(166, 40)
        Button3.TabIndex = 25
        Button3.Text = "Profit/Loss"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Button5.FlatAppearance.BorderColor = SystemColors.Control
        Button5.FlatAppearance.BorderSize = 2
        Button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Tahoma", 10.8F)
        Button5.ForeColor = SystemColors.Window
        Button5.Location = New Point(8, 233)
        Button5.Name = "Button5"
        Button5.RightToLeft = RightToLeft.No
        Button5.Size = New Size(166, 40)
        Button5.TabIndex = 23
        Button5.Text = "Total Expenses"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' combobxperiod
        ' 
        combobxperiod.BackColor = SystemColors.ControlLightLight
        combobxperiod.FlatStyle = FlatStyle.Flat
        combobxperiod.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        combobxperiod.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        combobxperiod.FormattingEnabled = True
        combobxperiod.ItemHeight = 23
        combobxperiod.Items.AddRange(New Object() {"Today", "Yesterday", "This Week", "This Month", "This Year"})
        combobxperiod.Location = New Point(8, 36)
        combobxperiod.Name = "combobxperiod"
        combobxperiod.Size = New Size(180, 31)
        combobxperiod.TabIndex = 22
        ' 
        ' LblgGender
        ' 
        LblgGender.AutoSize = True
        LblgGender.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblgGender.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        LblgGender.Location = New Point(8, 11)
        LblgGender.Name = "LblgGender"
        LblgGender.Size = New Size(108, 23)
        LblgGender.TabIndex = 21
        LblgGender.Text = "Select Period"
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.Transparent
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(219), CByte(215), CByte(210))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        closebtn.Location = New Point(884, 7)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(58, 48)
        closebtn.TabIndex = 28
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
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
        logoutbtn.ForeColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        logoutbtn.Location = New Point(778, 7)
        logoutbtn.Name = "logoutbtn"
        logoutbtn.Size = New Size(100, 48)
        logoutbtn.TabIndex = 49
        logoutbtn.Text = "Log Out"
        logoutbtn.TextAlign = ContentAlignment.MiddleLeft
        logoutbtn.UseVisualStyleBackColor = False
        ' 
        ' Revenue
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(948, 709)
        Controls.Add(logoutbtn)
        Controls.Add(closebtn)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Revenue"
        Text = "Revenue"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents combobxperiod As ComboBox
    Friend WithEvents LblgGender As Label
    Friend WithEvents closebtn As Button
    Friend WithEvents logoutbtn As Button
End Class
