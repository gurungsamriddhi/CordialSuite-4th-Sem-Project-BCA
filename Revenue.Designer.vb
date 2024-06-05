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
        combobxperiod = New ComboBox()
        LblgGender = New Label()
        Panel1 = New Panel()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button5 = New Button()
        closebtn = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' combobxperiod
        ' 
        combobxperiod.BackColor = SystemColors.ControlLightLight
        combobxperiod.FlatStyle = FlatStyle.Flat
        combobxperiod.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        combobxperiod.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        combobxperiod.FormattingEnabled = True
        combobxperiod.ItemHeight = 19
        combobxperiod.Items.AddRange(New Object() {"Today", "Yesterday", "This Week", "This Month", "This Year"})
        combobxperiod.Location = New Point(7, 27)
        combobxperiod.Margin = New Padding(3, 2, 3, 2)
        combobxperiod.Name = "combobxperiod"
        combobxperiod.Size = New Size(158, 27)
        combobxperiod.TabIndex = 22
        ' 
        ' LblgGender
        ' 
        LblgGender.AutoSize = True
        LblgGender.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblgGender.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        LblgGender.Location = New Point(7, 8)
        LblgGender.Name = "LblgGender"
        LblgGender.Size = New Size(91, 19)
        LblgGender.TabIndex = 21
        LblgGender.Text = "Select Period"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(combobxperiod)
        Panel1.Controls.Add(LblgGender)
        Panel1.Location = New Point(2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(168, 450)
        Panel1.TabIndex = 23
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button1.FlatAppearance.BorderColor = SystemColors.Control
        Button1.FlatAppearance.BorderSize = 2
        Button1.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Button1.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Tahoma", 10.8F)
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(20, 141)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 30)
        Button1.TabIndex = 27
        Button1.Text = "Total Income"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button2.FlatAppearance.BorderColor = SystemColors.Control
        Button2.FlatAppearance.BorderSize = 2
        Button2.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Button2.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Tahoma", 10.8F)
        Button2.ForeColor = SystemColors.Control
        Button2.Location = New Point(12, 279)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(145, 30)
        Button2.TabIndex = 26
        Button2.Text = "Total Transaction"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button3.FlatAppearance.BorderColor = SystemColors.Control
        Button3.FlatAppearance.BorderSize = 2
        Button3.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Button3.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Tahoma", 10.8F)
        Button3.ForeColor = SystemColors.Control
        Button3.Location = New Point(20, 210)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(128, 30)
        Button3.TabIndex = 25
        Button3.Text = "Profit/Loss"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button5.FlatAppearance.BorderColor = SystemColors.Control
        Button5.FlatAppearance.BorderSize = 2
        Button5.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Button5.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Tahoma", 10.8F)
        Button5.ForeColor = SystemColors.Control
        Button5.Location = New Point(20, 175)
        Button5.Margin = New Padding(3, 2, 3, 2)
        Button5.Name = "Button5"
        Button5.RightToLeft = RightToLeft.No
        Button5.Size = New Size(128, 30)
        Button5.TabIndex = 23
        Button5.Text = "Total Expenses"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        closebtn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        closebtn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = SystemColors.ControlLightLight
        closebtn.Location = New Point(747, 6)
        closebtn.Margin = New Padding(3, 2, 3, 2)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(41, 26)
        closebtn.TabIndex = 24
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Revenue
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(closebtn)
        Controls.Add(Panel1)
        Name = "Revenue"
        Text = "Revenue"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents combobxperiod As ComboBox
    Friend WithEvents LblgGender As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents closebtn As Button
End Class
