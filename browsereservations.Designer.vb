<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class browsereservations
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
        DGV_reservations = New DataGridView()
        Guestfirstname = New DataGridViewTextBoxColumn()
        guestlastname = New DataGridViewTextBoxColumn()
        roomno = New DataGridViewTextBoxColumn()
        roomtype = New DataGridViewTextBoxColumn()
        roombedcount = New DataGridViewTextBoxColumn()
        NumberofGuests = New DataGridViewTextBoxColumn()
        checkindate = New DataGridViewTextBoxColumn()
        noofdaysreserved = New DataGridViewTextBoxColumn()
        checkoutdate = New DataGridViewTextBoxColumn()
        roompricepernight = New DataGridViewTextBoxColumn()
        status = New DataGridViewTextBoxColumn()
        Totalamount = New DataGridViewTextBoxColumn()
        CType(DGV_reservations, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DGV_reservations
        ' 
        DGV_reservations.AllowUserToAddRows = False
        DGV_reservations.AllowUserToDeleteRows = False
        DGV_reservations.AllowUserToResizeColumns = False
        DGV_reservations.AllowUserToResizeRows = False
        DGV_reservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DGV_reservations.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DGV_reservations.BackgroundColor = SystemColors.Menu
        DGV_reservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_reservations.Columns.AddRange(New DataGridViewColumn() {Guestfirstname, guestlastname, roomno, roomtype, roombedcount, NumberofGuests, checkindate, noofdaysreserved, checkoutdate, roompricepernight, status, Totalamount})
        DGV_reservations.Location = New Point(12, 12)
        DGV_reservations.Name = "DGV_reservations"
        DGV_reservations.RowHeadersWidth = 51
        DGV_reservations.Size = New Size(673, 388)
        DGV_reservations.TabIndex = 1
        ' 
        ' Guestfirstname
        ' 
        Guestfirstname.DataPropertyName = "Firstname"
        Guestfirstname.HeaderText = "Guest Firstname"
        Guestfirstname.MinimumWidth = 6
        Guestfirstname.Name = "Guestfirstname"
        Guestfirstname.Width = 131
        ' 
        ' guestlastname
        ' 
        guestlastname.DataPropertyName = "Lastname"
        guestlastname.HeaderText = "Guest Lastname"
        guestlastname.MinimumWidth = 6
        guestlastname.Name = "guestlastname"
        guestlastname.Width = 130
        ' 
        ' roomno
        ' 
        roomno.DataPropertyName = "Roomnumber"
        roomno.HeaderText = "Room Number"
        roomno.MinimumWidth = 6
        roomno.Name = "roomno"
        roomno.Width = 125
        ' 
        ' roomtype
        ' 
        roomtype.DataPropertyName = "Roomtype"
        roomtype.HeaderText = "Room Type"
        roomtype.MinimumWidth = 6
        roomtype.Name = "roomtype"
        roomtype.Width = 104
        ' 
        ' roombedcount
        ' 
        roombedcount.DataPropertyName = "BedCount"
        roombedcount.HeaderText = "Bed Count"
        roombedcount.MinimumWidth = 6
        roombedcount.Name = "roombedcount"
        roombedcount.Width = 99
        ' 
        ' NumberofGuests
        ' 
        NumberofGuests.DataPropertyName = "NumberofGuests"
        NumberofGuests.HeaderText = "Number of Guests"
        NumberofGuests.MinimumWidth = 6
        NumberofGuests.Name = "NumberofGuests"
        NumberofGuests.Width = 105
        ' 
        ' checkindate
        ' 
        checkindate.DataPropertyName = "CheckInDate"
        checkindate.HeaderText = "Check In Date"
        checkindate.MinimumWidth = 6
        checkindate.Name = "checkindate"
        checkindate.Width = 90
        ' 
        ' noofdaysreserved
        ' 
        noofdaysreserved.DataPropertyName = "Numberofdaysreserved"
        noofdaysreserved.HeaderText = "No of days reserved"
        noofdaysreserved.MinimumWidth = 6
        noofdaysreserved.Name = "noofdaysreserved"
        noofdaysreserved.Width = 155
        ' 
        ' checkoutdate
        ' 
        checkoutdate.DataPropertyName = "CheckOutDate"
        checkoutdate.HeaderText = "Check Out Date"
        checkoutdate.MinimumWidth = 6
        checkoutdate.Name = "checkoutdate"
        checkoutdate.Width = 101
        ' 
        ' roompricepernight
        ' 
        roompricepernight.DataPropertyName = "Pricepernight"
        roompricepernight.HeaderText = "Price Per Night"
        roompricepernight.MinimumWidth = 6
        roompricepernight.Name = "roompricepernight"
        roompricepernight.Width = 124
        ' 
        ' status
        ' 
        status.DataPropertyName = "Status"
        status.HeaderText = "Status"
        status.MinimumWidth = 6
        status.Name = "status"
        status.Width = 78
        ' 
        ' Totalamount
        ' 
        Totalamount.DataPropertyName = "TotalAmount"
        Totalamount.HeaderText = "Total Amount"
        Totalamount.MinimumWidth = 6
        Totalamount.Name = "Totalamount"
        Totalamount.Width = 118
        ' 
        ' browsereservations
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(697, 421)
        Controls.Add(DGV_reservations)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Name = "browsereservations"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Double Click to select"
        CType(DGV_reservations, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DGV_reservations As DataGridView
    Friend WithEvents Guestfirstname As DataGridViewTextBoxColumn
    Friend WithEvents guestlastname As DataGridViewTextBoxColumn
    Friend WithEvents roomno As DataGridViewTextBoxColumn
    Friend WithEvents roomtype As DataGridViewTextBoxColumn
    Friend WithEvents roombedcount As DataGridViewTextBoxColumn
    Friend WithEvents NumberofGuests As DataGridViewTextBoxColumn
    Friend WithEvents checkindate As DataGridViewTextBoxColumn
    Friend WithEvents noofdaysreserved As DataGridViewTextBoxColumn
    Friend WithEvents checkoutdate As DataGridViewTextBoxColumn
    Friend WithEvents roompricepernight As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents Totalamount As DataGridViewTextBoxColumn
End Class
