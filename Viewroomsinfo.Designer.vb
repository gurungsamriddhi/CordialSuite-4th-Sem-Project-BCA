<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Viewroomsinfo
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Lbl_viewrooms = New Label()
        TabControlrooms = New TabControl()
        TabPageviewrooms = New TabPage()
        DGV_Rooms = New DataGridView()
        roomid = New DataGridViewTextBoxColumn()
        roomnumber = New DataGridViewTextBoxColumn()
        roomtype = New DataGridViewTextBoxColumn()
        bedcount = New DataGridViewTextBoxColumn()
        roomstatus = New DataGridViewTextBoxColumn()
        pricepernight = New DataGridViewTextBoxColumn()
        lbl_anykeyword = New Label()
        searchrooms_txtbx = New TextBox()
        TabPagemanagerooms = New TabPage()
        clear_btn = New Button()
        Lbl_msgroomstatus = New Label()
        roomstatus_cmbbx = New ComboBox()
        Lbl_roomstatus = New Label()
        Lbl_msgpricepernight = New Label()
        Lbl_msgbedcount = New Label()
        Lbl_msgroomtype = New Label()
        Lbl_msgroomno = New Label()
        updateroom_btn = New Button()
        Lbl_roomid = New Label()
        Lbl_roomidshow = New Label()
        bedcount_cmbbx = New ComboBox()
        Lbl_bedcount = New Label()
        Lbl_roomtype = New Label()
        roomtype_cmbbx = New ComboBox()
        Lbl_pricepernight = New Label()
        pricepernight_txtbx = New TextBox()
        Lbl_roomnumber = New Label()
        roomnumber_txtbx = New TextBox()
        TabControlrooms.SuspendLayout()
        TabPageviewrooms.SuspendLayout()
        CType(DGV_Rooms, ComponentModel.ISupportInitialize).BeginInit()
        TabPagemanagerooms.SuspendLayout()
        SuspendLayout()
        ' 
        ' Lbl_viewrooms
        ' 
        Lbl_viewrooms.AutoSize = True
        Lbl_viewrooms.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_viewrooms.ForeColor = Color.FromArgb(CByte(32), CByte(114), CByte(170))
        Lbl_viewrooms.Location = New Point(486, 9)
        Lbl_viewrooms.Name = "Lbl_viewrooms"
        Lbl_viewrooms.Size = New Size(98, 31)
        Lbl_viewrooms.TabIndex = 23
        Lbl_viewrooms.Text = "ROOMS"
        ' 
        ' TabControlrooms
        ' 
        TabControlrooms.Alignment = TabAlignment.Bottom
        TabControlrooms.Anchor = AnchorStyles.None
        TabControlrooms.Controls.Add(TabPageviewrooms)
        TabControlrooms.Controls.Add(TabPagemanagerooms)
        TabControlrooms.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControlrooms.Location = New Point(12, 54)
        TabControlrooms.Name = "TabControlrooms"
        TabControlrooms.SelectedIndex = 0
        TabControlrooms.Size = New Size(1053, 711)
        TabControlrooms.TabIndex = 46
        ' 
        ' TabPageviewrooms
        ' 
        TabPageviewrooms.Controls.Add(DGV_Rooms)
        TabPageviewrooms.Controls.Add(lbl_anykeyword)
        TabPageviewrooms.Controls.Add(searchrooms_txtbx)
        TabPageviewrooms.Location = New Point(4, 4)
        TabPageviewrooms.Name = "TabPageviewrooms"
        TabPageviewrooms.Padding = New Padding(3)
        TabPageviewrooms.Size = New Size(1045, 670)
        TabPageviewrooms.TabIndex = 0
        TabPageviewrooms.Text = "View Rooms"
        TabPageviewrooms.UseVisualStyleBackColor = True
        ' 
        ' DGV_Rooms
        ' 
        DGV_Rooms.AllowUserToAddRows = False
        DGV_Rooms.AllowUserToDeleteRows = False
        DGV_Rooms.Anchor = AnchorStyles.None
        DGV_Rooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV_Rooms.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DGV_Rooms.BackgroundColor = SystemColors.Menu
        DGV_Rooms.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DGV_Rooms.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DGV_Rooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_Rooms.Columns.AddRange(New DataGridViewColumn() {roomid, roomnumber, roomtype, bedcount, roomstatus, pricepernight})
        DGV_Rooms.Location = New Point(31, 118)
        DGV_Rooms.Name = "DGV_Rooms"
        DGV_Rooms.ReadOnly = True
        DGV_Rooms.RowHeadersWidth = 51
        DGV_Rooms.Size = New Size(991, 515)
        DGV_Rooms.TabIndex = 12
        ' 
        ' roomid
        ' 
        roomid.DataPropertyName = "roomID"
        roomid.HeaderText = "Room ID"
        roomid.MinimumWidth = 6
        roomid.Name = "roomid"
        roomid.ReadOnly = True
        ' 
        ' roomnumber
        ' 
        roomnumber.DataPropertyName = "Roomnumber"
        roomnumber.HeaderText = "Room Number"
        roomnumber.MinimumWidth = 6
        roomnumber.Name = "roomnumber"
        roomnumber.ReadOnly = True
        ' 
        ' roomtype
        ' 
        roomtype.DataPropertyName = "Roomtype"
        roomtype.HeaderText = "Room Type"
        roomtype.MinimumWidth = 6
        roomtype.Name = "roomtype"
        roomtype.ReadOnly = True
        ' 
        ' bedcount
        ' 
        bedcount.DataPropertyName = "BedCount"
        bedcount.HeaderText = "Bed Count"
        bedcount.MinimumWidth = 6
        bedcount.Name = "bedcount"
        bedcount.ReadOnly = True
        ' 
        ' roomstatus
        ' 
        roomstatus.DataPropertyName = "RoomStatus"
        roomstatus.HeaderText = "Room Status"
        roomstatus.MinimumWidth = 6
        roomstatus.Name = "roomstatus"
        roomstatus.ReadOnly = True
        ' 
        ' pricepernight
        ' 
        pricepernight.DataPropertyName = "Pricepernight"
        pricepernight.HeaderText = "Price Per Night"
        pricepernight.MinimumWidth = 6
        pricepernight.Name = "pricepernight"
        pricepernight.ReadOnly = True
        ' 
        ' lbl_anykeyword
        ' 
        lbl_anykeyword.Anchor = AnchorStyles.None
        lbl_anykeyword.AutoSize = True
        lbl_anykeyword.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_anykeyword.ForeColor = SystemColors.ActiveCaptionText
        lbl_anykeyword.Location = New Point(271, 46)
        lbl_anykeyword.Name = "lbl_anykeyword"
        lbl_anykeyword.Size = New Size(131, 25)
        lbl_anykeyword.TabIndex = 11
        lbl_anykeyword.Text = "Any Keyword:"
        ' 
        ' searchrooms_txtbx
        ' 
        searchrooms_txtbx.BorderStyle = BorderStyle.FixedSingle
        searchrooms_txtbx.Location = New Point(408, 32)
        searchrooms_txtbx.Multiline = True
        searchrooms_txtbx.Name = "searchrooms_txtbx"
        searchrooms_txtbx.Size = New Size(358, 49)
        searchrooms_txtbx.TabIndex = 2
        ' 
        ' TabPagemanagerooms
        ' 
        TabPagemanagerooms.Controls.Add(clear_btn)
        TabPagemanagerooms.Controls.Add(Lbl_msgroomstatus)
        TabPagemanagerooms.Controls.Add(roomstatus_cmbbx)
        TabPagemanagerooms.Controls.Add(Lbl_roomstatus)
        TabPagemanagerooms.Controls.Add(Lbl_msgpricepernight)
        TabPagemanagerooms.Controls.Add(Lbl_msgbedcount)
        TabPagemanagerooms.Controls.Add(Lbl_msgroomtype)
        TabPagemanagerooms.Controls.Add(Lbl_msgroomno)
        TabPagemanagerooms.Controls.Add(updateroom_btn)
        TabPagemanagerooms.Controls.Add(Lbl_roomid)
        TabPagemanagerooms.Controls.Add(Lbl_roomidshow)
        TabPagemanagerooms.Controls.Add(bedcount_cmbbx)
        TabPagemanagerooms.Controls.Add(Lbl_bedcount)
        TabPagemanagerooms.Controls.Add(Lbl_roomtype)
        TabPagemanagerooms.Controls.Add(roomtype_cmbbx)
        TabPagemanagerooms.Controls.Add(Lbl_pricepernight)
        TabPagemanagerooms.Controls.Add(pricepernight_txtbx)
        TabPagemanagerooms.Controls.Add(Lbl_roomnumber)
        TabPagemanagerooms.Controls.Add(roomnumber_txtbx)
        TabPagemanagerooms.Location = New Point(4, 4)
        TabPagemanagerooms.Name = "TabPagemanagerooms"
        TabPagemanagerooms.Padding = New Padding(3)
        TabPagemanagerooms.Size = New Size(1045, 670)
        TabPagemanagerooms.TabIndex = 1
        TabPagemanagerooms.Text = "Manage Rooms"
        TabPagemanagerooms.UseVisualStyleBackColor = True
        ' 
        ' clear_btn
        ' 
        clear_btn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        clear_btn.FlatAppearance.BorderColor = SystemColors.Window
        clear_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        clear_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        clear_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        clear_btn.FlatStyle = FlatStyle.Flat
        clear_btn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        clear_btn.ForeColor = SystemColors.ControlLightLight
        clear_btn.Location = New Point(555, 605)
        clear_btn.Name = "clear_btn"
        clear_btn.Size = New Size(127, 49)
        clear_btn.TabIndex = 103
        clear_btn.Text = "Clear"
        clear_btn.UseVisualStyleBackColor = False
        ' 
        ' Lbl_msgroomstatus
        ' 
        Lbl_msgroomstatus.AutoSize = True
        Lbl_msgroomstatus.Font = New Font("Segoe UI", 10.2F)
        Lbl_msgroomstatus.ForeColor = Color.Red
        Lbl_msgroomstatus.Location = New Point(355, 463)
        Lbl_msgroomstatus.Name = "Lbl_msgroomstatus"
        Lbl_msgroomstatus.Size = New Size(0, 23)
        Lbl_msgroomstatus.TabIndex = 102
        ' 
        ' roomstatus_cmbbx
        ' 
        roomstatus_cmbbx.FormattingEnabled = True
        roomstatus_cmbbx.Items.AddRange(New Object() {"Available ", "Unavailable", "In-Maintenance"})
        roomstatus_cmbbx.Location = New Point(351, 421)
        roomstatus_cmbbx.Name = "roomstatus_cmbbx"
        roomstatus_cmbbx.Size = New Size(345, 36)
        roomstatus_cmbbx.TabIndex = 101
        ' 
        ' Lbl_roomstatus
        ' 
        Lbl_roomstatus.AutoSize = True
        Lbl_roomstatus.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_roomstatus.ForeColor = Color.Black
        Lbl_roomstatus.Location = New Point(355, 393)
        Lbl_roomstatus.Name = "Lbl_roomstatus"
        Lbl_roomstatus.Size = New Size(126, 28)
        Lbl_roomstatus.TabIndex = 100
        Lbl_roomstatus.Text = "Room Status"
        ' 
        ' Lbl_msgpricepernight
        ' 
        Lbl_msgpricepernight.AutoSize = True
        Lbl_msgpricepernight.Font = New Font("Segoe UI", 10.2F)
        Lbl_msgpricepernight.ForeColor = Color.Red
        Lbl_msgpricepernight.Location = New Point(355, 570)
        Lbl_msgpricepernight.Name = "Lbl_msgpricepernight"
        Lbl_msgpricepernight.Size = New Size(0, 23)
        Lbl_msgpricepernight.TabIndex = 99
        ' 
        ' Lbl_msgbedcount
        ' 
        Lbl_msgbedcount.AutoSize = True
        Lbl_msgbedcount.Font = New Font("Segoe UI", 10.2F)
        Lbl_msgbedcount.ForeColor = Color.Red
        Lbl_msgbedcount.Location = New Point(357, 357)
        Lbl_msgbedcount.Name = "Lbl_msgbedcount"
        Lbl_msgbedcount.Size = New Size(0, 23)
        Lbl_msgbedcount.TabIndex = 98
        ' 
        ' Lbl_msgroomtype
        ' 
        Lbl_msgroomtype.AutoSize = True
        Lbl_msgroomtype.Font = New Font("Segoe UI", 10.2F)
        Lbl_msgroomtype.ForeColor = Color.Red
        Lbl_msgroomtype.Location = New Point(357, 255)
        Lbl_msgroomtype.Name = "Lbl_msgroomtype"
        Lbl_msgroomtype.Size = New Size(0, 23)
        Lbl_msgroomtype.TabIndex = 97
        ' 
        ' Lbl_msgroomno
        ' 
        Lbl_msgroomno.AutoSize = True
        Lbl_msgroomno.Font = New Font("Segoe UI", 10.2F)
        Lbl_msgroomno.ForeColor = Color.Red
        Lbl_msgroomno.Location = New Point(357, 149)
        Lbl_msgroomno.Name = "Lbl_msgroomno"
        Lbl_msgroomno.Size = New Size(0, 23)
        Lbl_msgroomno.TabIndex = 96
        ' 
        ' updateroom_btn
        ' 
        updateroom_btn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        updateroom_btn.FlatAppearance.BorderColor = SystemColors.Window
        updateroom_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        updateroom_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        updateroom_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        updateroom_btn.FlatStyle = FlatStyle.Flat
        updateroom_btn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        updateroom_btn.ForeColor = SystemColors.ControlLightLight
        updateroom_btn.Location = New Point(357, 605)
        updateroom_btn.Name = "updateroom_btn"
        updateroom_btn.Size = New Size(127, 49)
        updateroom_btn.TabIndex = 94
        updateroom_btn.Text = "Update"
        updateroom_btn.UseVisualStyleBackColor = False
        ' 
        ' Lbl_roomid
        ' 
        Lbl_roomid.AutoSize = True
        Lbl_roomid.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_roomid.ForeColor = Color.Red
        Lbl_roomid.Location = New Point(352, 25)
        Lbl_roomid.Name = "Lbl_roomid"
        Lbl_roomid.Size = New Size(0, 28)
        Lbl_roomid.TabIndex = 83
        ' 
        ' Lbl_roomidshow
        ' 
        Lbl_roomidshow.AutoSize = True
        Lbl_roomidshow.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_roomidshow.ForeColor = Color.Black
        Lbl_roomidshow.Location = New Point(455, 25)
        Lbl_roomidshow.Name = "Lbl_roomidshow"
        Lbl_roomidshow.Size = New Size(0, 28)
        Lbl_roomidshow.TabIndex = 82
        ' 
        ' bedcount_cmbbx
        ' 
        bedcount_cmbbx.FormattingEnabled = True
        bedcount_cmbbx.Items.AddRange(New Object() {"Single", "Double ", "Triple"})
        bedcount_cmbbx.Location = New Point(352, 315)
        bedcount_cmbbx.Name = "bedcount_cmbbx"
        bedcount_cmbbx.Size = New Size(345, 36)
        bedcount_cmbbx.TabIndex = 81
        ' 
        ' Lbl_bedcount
        ' 
        Lbl_bedcount.AutoSize = True
        Lbl_bedcount.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_bedcount.ForeColor = Color.Black
        Lbl_bedcount.Location = New Point(354, 287)
        Lbl_bedcount.Name = "Lbl_bedcount"
        Lbl_bedcount.Size = New Size(108, 28)
        Lbl_bedcount.TabIndex = 80
        Lbl_bedcount.Text = "Bed Count"
        ' 
        ' Lbl_roomtype
        ' 
        Lbl_roomtype.AutoSize = True
        Lbl_roomtype.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_roomtype.ForeColor = Color.Black
        Lbl_roomtype.Location = New Point(352, 185)
        Lbl_roomtype.Name = "Lbl_roomtype"
        Lbl_roomtype.Size = New Size(120, 28)
        Lbl_roomtype.TabIndex = 78
        Lbl_roomtype.Text = "Room Type "
        ' 
        ' roomtype_cmbbx
        ' 
        roomtype_cmbbx.FormattingEnabled = True
        roomtype_cmbbx.Items.AddRange(New Object() {"AC", "NON-AC"})
        roomtype_cmbbx.Location = New Point(352, 213)
        roomtype_cmbbx.Name = "roomtype_cmbbx"
        roomtype_cmbbx.Size = New Size(345, 36)
        roomtype_cmbbx.TabIndex = 77
        ' 
        ' Lbl_pricepernight
        ' 
        Lbl_pricepernight.AutoSize = True
        Lbl_pricepernight.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_pricepernight.ForeColor = Color.Black
        Lbl_pricepernight.Location = New Point(353, 494)
        Lbl_pricepernight.Name = "Lbl_pricepernight"
        Lbl_pricepernight.Size = New Size(148, 28)
        Lbl_pricepernight.TabIndex = 76
        Lbl_pricepernight.Text = "Price Per Night"
        ' 
        ' pricepernight_txtbx
        ' 
        pricepernight_txtbx.BackColor = SystemColors.ControlLightLight
        pricepernight_txtbx.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pricepernight_txtbx.ForeColor = SystemColors.ControlText
        pricepernight_txtbx.Location = New Point(350, 522)
        pricepernight_txtbx.Multiline = True
        pricepernight_txtbx.Name = "pricepernight_txtbx"
        pricepernight_txtbx.Size = New Size(345, 41)
        pricepernight_txtbx.TabIndex = 75
        ' 
        ' Lbl_roomnumber
        ' 
        Lbl_roomnumber.AutoSize = True
        Lbl_roomnumber.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Lbl_roomnumber.ForeColor = Color.Black
        Lbl_roomnumber.Location = New Point(353, 74)
        Lbl_roomnumber.Name = "Lbl_roomnumber"
        Lbl_roomnumber.Size = New Size(146, 28)
        Lbl_roomnumber.TabIndex = 74
        Lbl_roomnumber.Text = "Room Number"
        ' 
        ' roomnumber_txtbx
        ' 
        roomnumber_txtbx.BackColor = SystemColors.ControlLightLight
        roomnumber_txtbx.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        roomnumber_txtbx.ForeColor = SystemColors.ControlText
        roomnumber_txtbx.Location = New Point(352, 102)
        roomnumber_txtbx.Multiline = True
        roomnumber_txtbx.Name = "roomnumber_txtbx"
        roomnumber_txtbx.Size = New Size(345, 41)
        roomnumber_txtbx.TabIndex = 73
        ' 
        ' Viewroomsinfo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1077, 777)
        Controls.Add(TabControlrooms)
        Controls.Add(Lbl_viewrooms)
        FormBorderStyle = FormBorderStyle.None
        Name = "Viewroomsinfo"
        StartPosition = FormStartPosition.CenterScreen
        Text = "rooms"
        TabControlrooms.ResumeLayout(False)
        TabPageviewrooms.ResumeLayout(False)
        TabPageviewrooms.PerformLayout()
        CType(DGV_Rooms, ComponentModel.ISupportInitialize).EndInit()
        TabPagemanagerooms.ResumeLayout(False)
        TabPagemanagerooms.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents searchrooms_Btn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents close_Btn As Button
    Friend WithEvents closebtn As Button
    Friend WithEvents Lbl_viewrooms As Label
    Friend WithEvents logoutbtn As Button
    Friend WithEvents TabControlrooms As TabControl
    Friend WithEvents TabPageviewrooms As TabPage
    Friend WithEvents DGV_Rooms As DataGridView
    Friend WithEvents roomid As DataGridViewTextBoxColumn
    Friend WithEvents roomnumber As DataGridViewTextBoxColumn
    Friend WithEvents roomtype As DataGridViewTextBoxColumn
    Friend WithEvents bedcount As DataGridViewTextBoxColumn
    Friend WithEvents roomstatus As DataGridViewTextBoxColumn
    Friend WithEvents pricepernight As DataGridViewTextBoxColumn
    Friend WithEvents lbl_anykeyword As Label
    Friend WithEvents searchrooms_txtbx As TextBox
    Friend WithEvents TabPagemanagerooms As TabPage
    Friend WithEvents clear_btn As Button
    Friend WithEvents Lbl_msgroomstatus As Label
    Private WithEvents roomstatus_cmbbx As ComboBox
    Friend WithEvents Lbl_roomstatus As Label
    Friend WithEvents Lbl_msgpricepernight As Label
    Friend WithEvents Lbl_msgbedcount As Label
    Friend WithEvents Lbl_msgroomtype As Label
    Friend WithEvents Lbl_msgroomno As Label
    Friend WithEvents updateroom_btn As Button
    Friend WithEvents Lbl_roomid As Label
    Friend WithEvents Lbl_roomidshow As Label
    Friend WithEvents bedcount_cmbbx As ComboBox
    Friend WithEvents Lbl_bedcount As Label
    Friend WithEvents Lbl_roomtype As Label
    Friend WithEvents roomtype_cmbbx As ComboBox
    Friend WithEvents Lbl_pricepernight As Label
    Friend WithEvents pricepernight_txtbx As TextBox
    Friend WithEvents Lbl_roomnumber As Label
    Friend WithEvents roomnumber_txtbx As TextBox
End Class
