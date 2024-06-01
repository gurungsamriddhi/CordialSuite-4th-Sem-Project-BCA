<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addguestform
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
        paneladdg = New Panel()
        Panel1 = New Panel()
        Lblguestlist = New Label()
        searchtxtbx = New TextBox()
        searchbtn = New Button()
        Paneladdgform = New Panel()
        newguestbtn = New Button()
        guestlistbtn = New Button()
        paneladdg.SuspendLayout()
        Panel1.SuspendLayout()
        Paneladdgform.SuspendLayout()
        SuspendLayout()
        ' 
        ' paneladdg
        ' 
        paneladdg.BackColor = SystemColors.Control
        paneladdg.Controls.Add(Panel1)
        paneladdg.Controls.Add(searchtxtbx)
        paneladdg.Controls.Add(searchbtn)
        paneladdg.Dock = DockStyle.Fill
        paneladdg.Location = New Point(158, 0)
        paneladdg.Name = "paneladdg"
        paneladdg.Size = New Size(671, 585)
        paneladdg.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Panel1.Controls.Add(Lblguestlist)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(671, 50)
        Panel1.TabIndex = 4
        ' 
        ' Lblguestlist
        ' 
        Lblguestlist.AutoSize = True
        Lblguestlist.Font = New Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lblguestlist.ForeColor = SystemColors.ControlLightLight
        Lblguestlist.Location = New Point(268, 11)
        Lblguestlist.Name = "Lblguestlist"
        Lblguestlist.Size = New Size(134, 28)
        Lblguestlist.TabIndex = 1
        Lblguestlist.Text = "GUEST LIST"
        ' 
        ' searchtxtbx
        ' 
        searchtxtbx.BackColor = SystemColors.ControlLightLight
        searchtxtbx.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchtxtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        searchtxtbx.Location = New Point(196, 78)
        searchtxtbx.Name = "searchtxtbx"
        searchtxtbx.Size = New Size(234, 31)
        searchtxtbx.TabIndex = 3
        ' 
        ' searchbtn
        ' 
        searchbtn.BackColor = SystemColors.ControlLightLight
        searchbtn.FlatAppearance.BorderSize = 0
        searchbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        searchbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        searchbtn.FlatStyle = FlatStyle.Flat
        searchbtn.Font = New Font("Calisto MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        searchbtn.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        searchbtn.Location = New Point(451, 78)
        searchbtn.Name = "searchbtn"
        searchbtn.Size = New Size(100, 31)
        searchbtn.TabIndex = 2
        searchbtn.Text = "Search"
        searchbtn.UseVisualStyleBackColor = False
        ' 
        ' Paneladdgform
        ' 
        Paneladdgform.BackColor = SystemColors.ControlLight
        Paneladdgform.Controls.Add(newguestbtn)
        Paneladdgform.Controls.Add(guestlistbtn)
        Paneladdgform.Dock = DockStyle.Left
        Paneladdgform.Location = New Point(0, 0)
        Paneladdgform.Name = "Paneladdgform"
        Paneladdgform.Size = New Size(158, 585)
        Paneladdgform.TabIndex = 0
        ' 
        ' newguestbtn
        ' 
        newguestbtn.BackColor = SystemColors.ControlLightLight
        newguestbtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        newguestbtn.FlatAppearance.BorderSize = 0
        newguestbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        newguestbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        newguestbtn.FlatStyle = FlatStyle.Flat
        newguestbtn.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        newguestbtn.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        newguestbtn.Location = New Point(0, 248)
        newguestbtn.Name = "newguestbtn"
        newguestbtn.Size = New Size(158, 36)
        newguestbtn.TabIndex = 1
        newguestbtn.Text = "Add New Guest"
        newguestbtn.UseVisualStyleBackColor = False
        ' 
        ' guestlistbtn
        ' 
        guestlistbtn.BackColor = SystemColors.ControlLightLight
        guestlistbtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        guestlistbtn.FlatAppearance.BorderSize = 0
        guestlistbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        guestlistbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        guestlistbtn.FlatStyle = FlatStyle.Flat
        guestlistbtn.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        guestlistbtn.ForeColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        guestlistbtn.Location = New Point(0, 197)
        guestlistbtn.Name = "guestlistbtn"
        guestlistbtn.Size = New Size(158, 31)
        guestlistbtn.TabIndex = 0
        guestlistbtn.Text = "Guest List"
        guestlistbtn.UseVisualStyleBackColor = False
        ' 
        ' addguestform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(829, 585)
        Controls.Add(paneladdg)
        Controls.Add(Paneladdgform)
        FormBorderStyle = FormBorderStyle.None
        Name = "addguestform"
        Text = "addguestform"
        paneladdg.ResumeLayout(False)
        paneladdg.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Paneladdgform.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents paneladdg As Panel
    Friend WithEvents Paneladdgform As Panel
    Friend WithEvents newguestbtn As Button
    Friend WithEvents guestlistbtn As Button
    Friend WithEvents searchtxtbx As TextBox
    Friend WithEvents searchbtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lblguestlist As Label
End Class
