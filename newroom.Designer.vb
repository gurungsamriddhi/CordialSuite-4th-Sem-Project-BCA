<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newroom
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
        closebtn = New Button()
        Lblnewg = New Label()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Paneluser = New Panel()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        guestpanel2 = New Panel()
        guestpanel1 = New Panel()
        Label1guests = New Label()
        inttotmg = New Label()
        inttotguests = New Label()
        maleg_label = New Label()
        femaleg_label = New Label()
        guest_totlabel = New Label()
        Panel1.SuspendLayout()
        Paneluser.SuspendLayout()
        guestpanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Panel1.Controls.Add(closebtn)
        Panel1.Controls.Add(Lblnewg)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 35)
        Panel1.TabIndex = 25
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = SystemColors.ControlLightLight
        closebtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        closebtn.Location = New Point(735, 5)
        closebtn.Margin = New Padding(3, 2, 3, 2)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(41, 26)
        closebtn.TabIndex = 23
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Lblnewg
        ' 
        Lblnewg.AutoSize = True
        Lblnewg.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblnewg.ForeColor = SystemColors.ControlLightLight
        Lblnewg.Location = New Point(336, 7)
        Lblnewg.Name = "Lblnewg"
        Lblnewg.Size = New Size(121, 21)
        Lblnewg.TabIndex = 23
        Lblnewg.Text = "ROOM UPDATE"
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
        Button3.Location = New Point(28, 155)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(128, 30)
        Button3.TabIndex = 28
        Button3.Text = "Delete Room"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button4.FlatAppearance.BorderColor = SystemColors.Control
        Button4.FlatAppearance.BorderSize = 2
        Button4.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Button4.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Tahoma", 10.8F)
        Button4.ForeColor = SystemColors.Control
        Button4.Location = New Point(28, 189)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(128, 30)
        Button4.TabIndex = 27
        Button4.Text = "Edit Room"
        Button4.UseVisualStyleBackColor = False
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
        Button5.Location = New Point(28, 120)
        Button5.Margin = New Padding(3, 2, 3, 2)
        Button5.Name = "Button5"
        Button5.RightToLeft = RightToLeft.No
        Button5.Size = New Size(128, 30)
        Button5.TabIndex = 26
        Button5.Text = "Add Room"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Paneluser
        ' 
        Paneluser.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Paneluser.Controls.Add(Button6)
        Paneluser.Controls.Add(Button7)
        Paneluser.Controls.Add(Button8)
        Paneluser.Dock = DockStyle.Left
        Paneluser.Location = New Point(0, 35)
        Paneluser.Margin = New Padding(3, 2, 3, 2)
        Paneluser.Name = "Paneluser"
        Paneluser.Size = New Size(168, 415)
        Paneluser.TabIndex = 29
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button6.FlatAppearance.BorderColor = SystemColors.Control
        Button6.FlatAppearance.BorderSize = 2
        Button6.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Button6.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Tahoma", 10.8F)
        Button6.ForeColor = SystemColors.Control
        Button6.Location = New Point(19, 163)
        Button6.Margin = New Padding(3, 2, 3, 2)
        Button6.Name = "Button6"
        Button6.Size = New Size(128, 30)
        Button6.TabIndex = 6
        Button6.Text = "Delete Room"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button7.FlatAppearance.BorderColor = SystemColors.Control
        Button7.FlatAppearance.BorderSize = 2
        Button7.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Button7.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Tahoma", 10.8F)
        Button7.ForeColor = SystemColors.Control
        Button7.Location = New Point(19, 197)
        Button7.Margin = New Padding(3, 2, 3, 2)
        Button7.Name = "Button7"
        Button7.Size = New Size(128, 30)
        Button7.TabIndex = 5
        Button7.Text = "Edit Rooms"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Button8.FlatAppearance.BorderColor = SystemColors.Control
        Button8.FlatAppearance.BorderSize = 2
        Button8.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Button8.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Tahoma", 10.8F)
        Button8.ForeColor = SystemColors.Control
        Button8.Location = New Point(19, 128)
        Button8.Margin = New Padding(3, 2, 3, 2)
        Button8.Name = "Button8"
        Button8.RightToLeft = RightToLeft.No
        Button8.Size = New Size(128, 30)
        Button8.TabIndex = 3
        Button8.Text = "Update Room"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' guestpanel2
        ' 
        guestpanel2.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        guestpanel2.BorderStyle = BorderStyle.Fixed3D
        guestpanel2.Location = New Point(336, 155)
        guestpanel2.Margin = New Padding(3, 2, 3, 2)
        guestpanel2.Name = "guestpanel2"
        guestpanel2.Size = New Size(239, 18)
        guestpanel2.TabIndex = 30
        ' 
        ' guestpanel1
        ' 
        guestpanel1.BackColor = SystemColors.ButtonHighlight
        guestpanel1.BorderStyle = BorderStyle.Fixed3D
        guestpanel1.Controls.Add(Label1guests)
        guestpanel1.Controls.Add(inttotmg)
        guestpanel1.Controls.Add(inttotguests)
        guestpanel1.Controls.Add(maleg_label)
        guestpanel1.Controls.Add(femaleg_label)
        guestpanel1.Controls.Add(guest_totlabel)
        guestpanel1.Location = New Point(336, 169)
        guestpanel1.Margin = New Padding(3, 2, 3, 2)
        guestpanel1.Name = "guestpanel1"
        guestpanel1.Size = New Size(239, 129)
        guestpanel1.TabIndex = 32
        ' 
        ' Label1guests
        ' 
        Label1guests.AutoSize = True
        Label1guests.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1guests.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Label1guests.Location = New Point(74, 14)
        Label1guests.Name = "Label1guests"
        Label1guests.Size = New Size(79, 19)
        Label1guests.TabIndex = 9
        Label1guests.Text = "New Room"
        ' 
        ' inttotmg
        ' 
        inttotmg.AutoSize = True
        inttotmg.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        inttotmg.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        inttotmg.Location = New Point(178, 86)
        inttotmg.Name = "inttotmg"
        inttotmg.Size = New Size(54, 17)
        inttotmg.TabIndex = 7
        inttotmg.Text = "Deluxe"
        ' 
        ' inttotguests
        ' 
        inttotguests.AutoSize = True
        inttotguests.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        inttotguests.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        inttotguests.Location = New Point(205, 50)
        inttotguests.Name = "inttotguests"
        inttotguests.Size = New Size(26, 17)
        inttotguests.TabIndex = 6
        inttotguests.Text = "10"
        ' 
        ' maleg_label
        ' 
        maleg_label.AutoSize = True
        maleg_label.FlatStyle = FlatStyle.Flat
        maleg_label.Font = New Font("Segoe UI", 9F)
        maleg_label.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        maleg_label.Location = New Point(3, 86)
        maleg_label.Name = "maleg_label"
        maleg_label.Size = New Size(66, 15)
        maleg_label.TabIndex = 5
        maleg_label.Text = "Room Type"
        ' 
        ' femaleg_label
        ' 
        femaleg_label.AutoSize = True
        femaleg_label.FlatStyle = FlatStyle.Flat
        femaleg_label.Font = New Font("Segoe UI", 9F)
        femaleg_label.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        femaleg_label.Location = New Point(3, 73)
        femaleg_label.Name = "femaleg_label"
        femaleg_label.Size = New Size(0, 15)
        femaleg_label.TabIndex = 4
        ' 
        ' guest_totlabel
        ' 
        guest_totlabel.AutoSize = True
        guest_totlabel.FlatStyle = FlatStyle.Flat
        guest_totlabel.Font = New Font("Segoe UI", 9F)
        guest_totlabel.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        guest_totlabel.Location = New Point(3, 50)
        guest_totlabel.Name = "guest_totlabel"
        guest_totlabel.Size = New Size(86, 15)
        guest_totlabel.TabIndex = 3
        guest_totlabel.Text = "Room Number"
        ' 
        ' newroom
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(guestpanel2)
        Controls.Add(guestpanel1)
        Controls.Add(Paneluser)
        Controls.Add(Button3)
        Controls.Add(Button4)
        Controls.Add(Button5)
        Controls.Add(Panel1)
        Name = "newroom"
        RightToLeftLayout = True
        Text = "newroom"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Paneluser.ResumeLayout(False)
        guestpanel1.ResumeLayout(False)
        guestpanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents closebtn As Button
    Friend WithEvents Lblnewg As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Paneluser As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents guestpanel2 As Panel
    Friend WithEvents guestpanel1 As Panel
    Friend WithEvents Label1guests As Label
    Friend WithEvents inttotmg As Label
    Friend WithEvents inttotguests As Label
    Friend WithEvents maleg_label As Label
    Friend WithEvents femaleg_label As Label
    Friend WithEvents guest_totlabel As Label
End Class
