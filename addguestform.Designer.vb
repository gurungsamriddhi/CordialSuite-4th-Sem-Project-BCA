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
        pnlguestlist = New Panel()
        DataGridViewGuestlist = New DataGridView()
        Panel1 = New Panel()
        logoutbtn = New Button()
        closebtn = New Button()
        Lblguestlist = New Label()
        searchtxtbx = New TextBox()
        searchbtn = New Button()
        Pnloptions = New Panel()
        newguest_btn = New Button()
        guestlistbtn = New Button()
        pnlguestlist.SuspendLayout()
        CType(DataGridViewGuestlist, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Pnloptions.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlguestlist
        ' 
        pnlguestlist.BackColor = SystemColors.Control
        pnlguestlist.Controls.Add(DataGridViewGuestlist)
        pnlguestlist.Controls.Add(Panel1)
        pnlguestlist.Controls.Add(searchtxtbx)
        pnlguestlist.Controls.Add(searchbtn)
        pnlguestlist.Dock = DockStyle.Fill
        pnlguestlist.Location = New Point(176, 0)
        pnlguestlist.Name = "pnlguestlist"
        pnlguestlist.Size = New Size(772, 750)
        pnlguestlist.TabIndex = 1
        ' 
        ' DataGridViewGuestlist
        ' 
        DataGridViewGuestlist.AllowUserToOrderColumns = True
        DataGridViewGuestlist.BackgroundColor = SystemColors.ControlLight
        DataGridViewGuestlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewGuestlist.Location = New Point(56, 189)
        DataGridViewGuestlist.Name = "DataGridViewGuestlist"
        DataGridViewGuestlist.RowHeadersWidth = 51
        DataGridViewGuestlist.Size = New Size(676, 461)
        DataGridViewGuestlist.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Panel1.Controls.Add(logoutbtn)
        Panel1.Controls.Add(closebtn)
        Panel1.Controls.Add(Lblguestlist)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(772, 50)
        Panel1.TabIndex = 4
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
        logoutbtn.Location = New Point(620, 2)
        logoutbtn.Name = "logoutbtn"
        logoutbtn.Size = New Size(100, 47)
        logoutbtn.TabIndex = 48
        logoutbtn.Text = "Log Out"
        logoutbtn.TextAlign = ContentAlignment.MiddleLeft
        logoutbtn.UseVisualStyleBackColor = False
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.Transparent
        closebtn.FlatAppearance.BorderColor = Color.White
        closebtn.FlatAppearance.BorderSize = 2
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = SystemColors.Window
        closebtn.Location = New Point(726, 3)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(43, 42)
        closebtn.TabIndex = 12
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Lblguestlist
        ' 
        Lblguestlist.AutoSize = True
        Lblguestlist.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblguestlist.ForeColor = SystemColors.ControlLightLight
        Lblguestlist.Location = New Point(331, 9)
        Lblguestlist.Name = "Lblguestlist"
        Lblguestlist.Size = New Size(136, 31)
        Lblguestlist.TabIndex = 1
        Lblguestlist.Text = "GUEST LIST"
        ' 
        ' searchtxtbx
        ' 
        searchtxtbx.BackColor = SystemColors.ControlLightLight
        searchtxtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchtxtbx.ForeColor = Color.Black
        searchtxtbx.Location = New Point(241, 121)
        searchtxtbx.Name = "searchtxtbx"
        searchtxtbx.Size = New Size(240, 38)
        searchtxtbx.TabIndex = 3
        ' 
        ' searchbtn
        ' 
        searchbtn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        searchbtn.FlatAppearance.BorderColor = SystemColors.Window
        searchbtn.FlatAppearance.BorderSize = 2
        searchbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        searchbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        searchbtn.FlatStyle = FlatStyle.Flat
        searchbtn.Font = New Font("Calisto MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        searchbtn.ForeColor = SystemColors.Window
        searchbtn.Location = New Point(515, 123)
        searchbtn.Name = "searchbtn"
        searchbtn.Size = New Size(100, 37)
        searchbtn.TabIndex = 2
        searchbtn.Text = "Search"
        searchbtn.UseVisualStyleBackColor = False
        ' 
        ' Pnloptions
        ' 
        Pnloptions.BackColor = SystemColors.ButtonFace
        Pnloptions.BorderStyle = BorderStyle.Fixed3D
        Pnloptions.Controls.Add(newguest_btn)
        Pnloptions.Controls.Add(guestlistbtn)
        Pnloptions.Dock = DockStyle.Left
        Pnloptions.Font = New Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Pnloptions.Location = New Point(0, 0)
        Pnloptions.Name = "Pnloptions"
        Pnloptions.Size = New Size(176, 750)
        Pnloptions.TabIndex = 0
        ' 
        ' newguest_btn
        ' 
        newguest_btn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        newguest_btn.FlatAppearance.BorderColor = SystemColors.Window
        newguest_btn.FlatAppearance.BorderSize = 2
        newguest_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        newguest_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        newguest_btn.FlatStyle = FlatStyle.Flat
        newguest_btn.Font = New Font("Segoe UI Emoji", 10.8F, FontStyle.Bold)
        newguest_btn.ForeColor = SystemColors.Window
        newguest_btn.Location = New Point(0, 318)
        newguest_btn.Name = "newguest_btn"
        newguest_btn.Size = New Size(176, 38)
        newguest_btn.TabIndex = 1
        newguest_btn.Text = "Add New Guest"
        newguest_btn.UseVisualStyleBackColor = False
        ' 
        ' guestlistbtn
        ' 
        guestlistbtn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        guestlistbtn.FlatAppearance.BorderColor = SystemColors.Window
        guestlistbtn.FlatAppearance.BorderSize = 2
        guestlistbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        guestlistbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        guestlistbtn.FlatStyle = FlatStyle.Flat
        guestlistbtn.Font = New Font("Segoe UI Emoji", 10.8F, FontStyle.Bold)
        guestlistbtn.ForeColor = SystemColors.Window
        guestlistbtn.Location = New Point(0, 263)
        guestlistbtn.Name = "guestlistbtn"
        guestlistbtn.Size = New Size(176, 38)
        guestlistbtn.TabIndex = 0
        guestlistbtn.Text = "Guest List"
        guestlistbtn.UseVisualStyleBackColor = False
        ' 
        ' addguestform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(948, 750)
        Controls.Add(pnlguestlist)
        Controls.Add(Pnloptions)
        FormBorderStyle = FormBorderStyle.None
        Name = "addguestform"
        Text = "addguestform"
        pnlguestlist.ResumeLayout(False)
        pnlguestlist.PerformLayout()
        CType(DataGridViewGuestlist, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Pnloptions.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnlguestlist As Panel
    Friend WithEvents Pnloptions As Panel
    Friend WithEvents newguest_btn As Button
    Friend WithEvents guestlistbtn As Button
    Friend WithEvents searchtxtbx As TextBox
    Friend WithEvents searchbtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lblguestlist As Label
    Friend WithEvents DataGridViewGuestlist As DataGridView
    Friend WithEvents closebtn As Button
    Friend WithEvents logoutbtn As Button
End Class
