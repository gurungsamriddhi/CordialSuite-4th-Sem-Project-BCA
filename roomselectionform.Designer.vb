<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class roomselectionform
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DGV_Rooms = New DataGridView()
        roomid = New DataGridViewTextBoxColumn()
        roomnumber = New DataGridViewTextBoxColumn()
        roomtype = New DataGridViewTextBoxColumn()
        bedcount = New DataGridViewTextBoxColumn()
        roomstatus = New DataGridViewTextBoxColumn()
        pricepernight = New DataGridViewTextBoxColumn()
        confirmSelection_btn = New Button()
        CType(DGV_Rooms, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        DGV_Rooms.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DGV_Rooms.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        DGV_Rooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_Rooms.Columns.AddRange(New DataGridViewColumn() {roomid, roomnumber, roomtype, bedcount, roomstatus, pricepernight})
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Window
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        DGV_Rooms.DefaultCellStyle = DataGridViewCellStyle4
        DGV_Rooms.Location = New Point(12, 61)
        DGV_Rooms.Name = "DGV_Rooms"
        DGV_Rooms.ReadOnly = True
        DGV_Rooms.RowHeadersWidth = 51
        DGV_Rooms.Size = New Size(673, 348)
        DGV_Rooms.TabIndex = 13
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
        ' confirmSelection_btn
        ' 
        confirmSelection_btn.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        confirmSelection_btn.Location = New Point(294, 12)
        confirmSelection_btn.Name = "confirmSelection_btn"
        confirmSelection_btn.Size = New Size(113, 43)
        confirmSelection_btn.TabIndex = 14
        confirmSelection_btn.Text = "Confirm "
        confirmSelection_btn.UseVisualStyleBackColor = True
        ' 
        ' roomselectionform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(697, 421)
        Controls.Add(confirmSelection_btn)
        Controls.Add(DGV_Rooms)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Name = "roomselectionform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Double Click to select a room"
        CType(DGV_Rooms, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DGV_Rooms As DataGridView
    Friend WithEvents roomid As DataGridViewTextBoxColumn
    Friend WithEvents roomnumber As DataGridViewTextBoxColumn
    Friend WithEvents roomtype As DataGridViewTextBoxColumn
    Friend WithEvents bedcount As DataGridViewTextBoxColumn
    Friend WithEvents roomstatus As DataGridViewTextBoxColumn
    Friend WithEvents pricepernight As DataGridViewTextBoxColumn
    Friend WithEvents confirmSelection_btn As Button
End Class
