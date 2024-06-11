<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Updateroom
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
        Paneluser = New Panel()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        guestpanel2 = New Panel()
        Panel1 = New Panel()
        Lblnewg = New Label()
        guestpanel1 = New Panel()
        Label1guests = New Label()
        inttotmg = New Label()
        inttotguests = New Label()
        maleg_label = New Label()
        femaleg_label = New Label()
        guest_totlabel = New Label()
        Panel2 = New Panel()
        close_Btn = New Button()
        closebtn = New Button()
        Lblviewg = New Label()
        logoutbtn = New Button()
        Paneluser.SuspendLayout()
        guestpanel2.SuspendLayout()
        Panel1.SuspendLayout()
        guestpanel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Paneluser
        ' 
        Paneluser.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Paneluser.Controls.Add(Button6)
        Paneluser.Controls.Add(Button7)
        Paneluser.Controls.Add(Button8)
        Paneluser.Dock = DockStyle.Left
        Paneluser.ForeColor = Color.CornflowerBlue
        Paneluser.Location = New Point(0, 0)
        Paneluser.Name = "Paneluser"
        Paneluser.Size = New Size(192, 709)
        Paneluser.TabIndex = 30
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.FlatAppearance.BorderColor = SystemColors.Window
        Button6.FlatAppearance.BorderSize = 2
        Button6.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Tahoma", 10.8F)
        Button6.ForeColor = SystemColors.Window
        Button6.Location = New Point(12, 281)
        Button6.Name = "Button6"
        Button6.Size = New Size(167, 40)
        Button6.TabIndex = 6
        Button6.Text = "Delete Room"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Transparent
        Button7.FlatAppearance.BorderColor = SystemColors.Window
        Button7.FlatAppearance.BorderSize = 2
        Button7.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button7.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Tahoma", 10.8F)
        Button7.ForeColor = SystemColors.Window
        Button7.Location = New Point(12, 327)
        Button7.Name = "Button7"
        Button7.Size = New Size(167, 40)
        Button7.TabIndex = 5
        Button7.Text = "Edit Rooms"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Transparent
        Button8.FlatAppearance.BorderColor = SystemColors.Window
        Button8.FlatAppearance.BorderSize = 2
        Button8.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button8.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Tahoma", 10.8F)
        Button8.ForeColor = SystemColors.Window
        Button8.Location = New Point(12, 235)
        Button8.Name = "Button8"
        Button8.RightToLeft = RightToLeft.No
        Button8.Size = New Size(167, 40)
        Button8.TabIndex = 3
        Button8.Text = "Update Room"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' guestpanel2
        ' 
        guestpanel2.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        guestpanel2.BorderStyle = BorderStyle.Fixed3D
        guestpanel2.Controls.Add(Panel1)
        guestpanel2.Location = New Point(322, 153)
        guestpanel2.Name = "guestpanel2"
        guestpanel2.Size = New Size(273, 23)
        guestpanel2.TabIndex = 33
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Panel1.Controls.Add(Lblnewg)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(269, 47)
        Panel1.TabIndex = 26
        ' 
        ' Lblnewg
        ' 
        Lblnewg.AutoSize = True
        Lblnewg.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblnewg.ForeColor = SystemColors.ControlLightLight
        Lblnewg.Location = New Point(384, 9)
        Lblnewg.Name = "Lblnewg"
        Lblnewg.Size = New Size(151, 28)
        Lblnewg.TabIndex = 23
        Lblnewg.Text = "ROOM UPDATE"
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
        guestpanel1.Location = New Point(322, 172)
        guestpanel1.Name = "guestpanel1"
        guestpanel1.Size = New Size(273, 171)
        guestpanel1.TabIndex = 34
        ' 
        ' Label1guests
        ' 
        Label1guests.AutoSize = True
        Label1guests.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1guests.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Label1guests.Location = New Point(85, 19)
        Label1guests.Name = "Label1guests"
        Label1guests.Size = New Size(96, 23)
        Label1guests.TabIndex = 9
        Label1guests.Text = "New Room"
        ' 
        ' inttotmg
        ' 
        inttotmg.AutoSize = True
        inttotmg.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        inttotmg.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        inttotmg.Location = New Point(203, 115)
        inttotmg.Name = "inttotmg"
        inttotmg.Size = New Size(69, 21)
        inttotmg.TabIndex = 7
        inttotmg.Text = "Deluxe"
        ' 
        ' inttotguests
        ' 
        inttotguests.AutoSize = True
        inttotguests.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        inttotguests.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        inttotguests.Location = New Point(234, 67)
        inttotguests.Name = "inttotguests"
        inttotguests.Size = New Size(32, 21)
        inttotguests.TabIndex = 6
        inttotguests.Text = "10"
        ' 
        ' maleg_label
        ' 
        maleg_label.AutoSize = True
        maleg_label.FlatStyle = FlatStyle.Flat
        maleg_label.Font = New Font("Segoe UI", 9F)
        maleg_label.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        maleg_label.Location = New Point(3, 115)
        maleg_label.Name = "maleg_label"
        maleg_label.Size = New Size(84, 20)
        maleg_label.TabIndex = 5
        maleg_label.Text = "Room Type"
        ' 
        ' femaleg_label
        ' 
        femaleg_label.AutoSize = True
        femaleg_label.FlatStyle = FlatStyle.Flat
        femaleg_label.Font = New Font("Segoe UI", 9F)
        femaleg_label.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        femaleg_label.Location = New Point(3, 97)
        femaleg_label.Name = "femaleg_label"
        femaleg_label.Size = New Size(0, 20)
        femaleg_label.TabIndex = 4
        ' 
        ' guest_totlabel
        ' 
        guest_totlabel.AutoSize = True
        guest_totlabel.FlatStyle = FlatStyle.Flat
        guest_totlabel.Font = New Font("Segoe UI", 9F)
        guest_totlabel.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        guest_totlabel.Location = New Point(3, 67)
        guest_totlabel.Name = "guest_totlabel"
        guest_totlabel.Size = New Size(107, 20)
        guest_totlabel.TabIndex = 3
        guest_totlabel.Text = "Room Number"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Panel2.Controls.Add(logoutbtn)
        Panel2.Controls.Add(close_Btn)
        Panel2.Controls.Add(closebtn)
        Panel2.Controls.Add(Lblviewg)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(192, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(756, 57)
        Panel2.TabIndex = 44
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
        close_Btn.Location = New Point(710, 6)
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
        Lblviewg.Location = New Point(335, 15)
        Lblviewg.Name = "Lblviewg"
        Lblviewg.Size = New Size(101, 31)
        Lblviewg.TabIndex = 23
        Lblviewg.Text = "UPDATE"
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
        logoutbtn.Location = New Point(604, 3)
        logoutbtn.Name = "logoutbtn"
        logoutbtn.Size = New Size(100, 51)
        logoutbtn.TabIndex = 49
        logoutbtn.Text = "Log Out"
        logoutbtn.TextAlign = ContentAlignment.MiddleLeft
        logoutbtn.UseVisualStyleBackColor = False
        ' 
        ' Updateroom
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(948, 709)
        Controls.Add(Panel2)
        Controls.Add(guestpanel2)
        Controls.Add(guestpanel1)
        Controls.Add(Paneluser)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Updateroom"
        Text = "Updateroom"
        Paneluser.ResumeLayout(False)
        guestpanel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        guestpanel1.ResumeLayout(False)
        guestpanel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lblnewg As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents close_Btn As Button
    Friend WithEvents closebtn As Button
    Friend WithEvents Lblviewg As Label
    Friend WithEvents logoutbtn As Button
End Class
