<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userdashboard
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
        Paneladmin = New Panel()
        Button6 = New Button()
        Button5 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Button4 = New Button()
        Panel = New Panel()
        Paneladmin.SuspendLayout()
        SuspendLayout()
        ' 
        ' Paneladmin
        ' 
        Paneladmin.BackColor = SystemColors.HighlightText
        Paneladmin.BorderStyle = BorderStyle.Fixed3D
        Paneladmin.Controls.Add(Button6)
        Paneladmin.Controls.Add(Button5)
        Paneladmin.Controls.Add(Button3)
        Paneladmin.Controls.Add(Button2)
        Paneladmin.Controls.Add(Button1)
        Paneladmin.Controls.Add(Button4)
        Paneladmin.Dock = DockStyle.Left
        Paneladmin.Location = New Point(0, 0)
        Paneladmin.Name = "Paneladmin"
        Paneladmin.Size = New Size(205, 585)
        Paneladmin.TabIndex = 0
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Button6.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Tahoma", 12F)
        Button6.ForeColor = SystemColors.Control
        Button6.Location = New Point(57, 116)
        Button6.Name = "Button6"
        Button6.Size = New Size(146, 40)
        Button6.TabIndex = 8
        Button6.Text = "Hotel Status"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Button5.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Tahoma", 12F)
        Button5.ForeColor = SystemColors.Control
        Button5.Location = New Point(57, 300)
        Button5.Name = "Button5"
        Button5.Size = New Size(146, 40)
        Button5.TabIndex = 7
        Button5.Text = "Check-out"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Button3.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Tahoma", 12F)
        Button3.ForeColor = SystemColors.Control
        Button3.Location = New Point(57, 208)
        Button3.Name = "Button3"
        Button3.Size = New Size(146, 40)
        Button3.TabIndex = 6
        Button3.Text = "Check-in"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Button2.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Tahoma", 12F)
        Button2.ForeColor = SystemColors.Control
        Button2.Location = New Point(57, 254)
        Button2.Name = "Button2"
        Button2.Size = New Size(146, 40)
        Button2.TabIndex = 5
        Button2.Text = "Rooms"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Button1.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Tahoma", 12F)
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(57, 346)
        Button1.Name = "Button1"
        Button1.Size = New Size(146, 40)
        Button1.TabIndex = 4
        Button1.Text = "Billing"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Button4.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Tahoma", 12F)
        Button4.ForeColor = SystemColors.Control
        Button4.Location = New Point(57, 162)
        Button4.Name = "Button4"
        Button4.Size = New Size(146, 40)
        Button4.TabIndex = 3
        Button4.Text = "Add Guest"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Panel
        ' 
        Panel.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Panel.BorderStyle = BorderStyle.Fixed3D
        Panel.Dock = DockStyle.Top
        Panel.Location = New Point(205, 0)
        Panel.Name = "Panel"
        Panel.Size = New Size(816, 51)
        Panel.TabIndex = 1
        ' 
        ' dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(1021, 585)
        Controls.Add(Panel)
        Controls.Add(Paneladmin)
        Name = "dashboard"
        Text = "Userdashboard"
        Paneladmin.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Paneladmin As Panel
    Friend WithEvents Panel As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
End Class
