<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Form
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Logout = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button1.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(39, 38)
        Button1.Name = "Button1"
        Button1.Size = New Size(149, 31)
        Button1.TabIndex = 0
        Button1.Text = "Hotel Status"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button2.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Button2.ForeColor = SystemColors.Control
        Button2.Location = New Point(39, 106)
        Button2.Name = "Button2"
        Button2.Size = New Size(149, 31)
        Button2.TabIndex = 1
        Button2.Text = "View Guest"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button3.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Button3.ForeColor = SystemColors.Control
        Button3.Location = New Point(39, 167)
        Button3.Name = "Button3"
        Button3.Size = New Size(149, 31)
        Button3.TabIndex = 2
        Button3.Text = "View Employee"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button4.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Button4.ForeColor = SystemColors.Control
        Button4.Location = New Point(39, 228)
        Button4.Name = "Button4"
        Button4.Size = New Size(149, 31)
        Button4.TabIndex = 3
        Button4.Text = "Room Update"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Button5.ForeColor = SystemColors.Control
        Button5.Location = New Point(39, 292)
        Button5.Name = "Button5"
        Button5.Size = New Size(149, 31)
        Button5.TabIndex = 4
        Button5.Text = "Button5"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Logout
        ' 
        Logout.Location = New Point(66, 356)
        Logout.Name = "Logout"
        Logout.Size = New Size(149, 31)
        Logout.TabIndex = 5
        Logout.Text = "Button6"
        Logout.UseVisualStyleBackColor = True
        ' 
        ' Admin_Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(800, 450)
        Controls.Add(Logout)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Admin_Form"
        Text = "Form3"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Logout As Button
End Class
