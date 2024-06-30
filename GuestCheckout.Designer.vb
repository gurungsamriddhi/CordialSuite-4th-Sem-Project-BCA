<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuestCheckout
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
        Lbl_checkout = New Label()
        checkout_btn = New Button()
        searchkeyword_txtbx = New TextBox()
        Lbl_anykeyword = New Label()
        DGV_Checkout = New DataGridView()
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
        CType(DGV_Checkout, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Lbl_checkout
        ' 
        Lbl_checkout.AutoSize = True
        Lbl_checkout.BackColor = Color.Transparent
        Lbl_checkout.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_checkout.ForeColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Lbl_checkout.Location = New Point(455, 21)
        Lbl_checkout.Name = "Lbl_checkout"
        Lbl_checkout.Size = New Size(220, 31)
        Lbl_checkout.TabIndex = 24
        Lbl_checkout.Text = "GUEST CHECK-OUT"
        Lbl_checkout.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' checkout_btn
        ' 
        checkout_btn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        checkout_btn.FlatAppearance.BorderColor = SystemColors.Window
        checkout_btn.FlatAppearance.BorderSize = 2
        checkout_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        checkout_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        checkout_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        checkout_btn.FlatStyle = FlatStyle.Flat
        checkout_btn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        checkout_btn.ForeColor = SystemColors.ControlLightLight
        checkout_btn.Location = New Point(498, 707)
        checkout_btn.Name = "checkout_btn"
        checkout_btn.Size = New Size(161, 58)
        checkout_btn.TabIndex = 116
        checkout_btn.Text = "Check Out"
        checkout_btn.UseVisualStyleBackColor = False
        ' 
        ' searchkeyword_txtbx
        ' 
        searchkeyword_txtbx.Anchor = AnchorStyles.None
        searchkeyword_txtbx.BackColor = SystemColors.ControlLightLight
        searchkeyword_txtbx.BorderStyle = BorderStyle.FixedSingle
        searchkeyword_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchkeyword_txtbx.ForeColor = Color.Black
        searchkeyword_txtbx.Location = New Point(418, 72)
        searchkeyword_txtbx.Multiline = True
        searchkeyword_txtbx.Name = "searchkeyword_txtbx"
        searchkeyword_txtbx.Size = New Size(324, 47)
        searchkeyword_txtbx.TabIndex = 117
        ' 
        ' Lbl_anykeyword
        ' 
        Lbl_anykeyword.Anchor = AnchorStyles.None
        Lbl_anykeyword.AutoSize = True
        Lbl_anykeyword.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_anykeyword.ForeColor = SystemColors.ActiveCaptionText
        Lbl_anykeyword.Location = New Point(281, 79)
        Lbl_anykeyword.Name = "Lbl_anykeyword"
        Lbl_anykeyword.Size = New Size(131, 25)
        Lbl_anykeyword.TabIndex = 118
        Lbl_anykeyword.Text = "Any Keyword:"
        ' 
        ' DGV_Checkout
        ' 
        DGV_Checkout.AllowUserToAddRows = False
        DGV_Checkout.AllowUserToDeleteRows = False
        DGV_Checkout.AllowUserToResizeColumns = False
        DGV_Checkout.AllowUserToResizeRows = False
        DGV_Checkout.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DGV_Checkout.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DGV_Checkout.BackgroundColor = SystemColors.Menu
        DGV_Checkout.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_Checkout.Columns.AddRange(New DataGridViewColumn() {Guestfirstname, guestlastname, roomno, roomtype, roombedcount, NumberofGuests, checkindate, noofdaysreserved, checkoutdate, roompricepernight, status, Totalamount})
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DGV_Checkout.DefaultCellStyle = DataGridViewCellStyle1
        DGV_Checkout.Location = New Point(45, 151)
        DGV_Checkout.Name = "DGV_Checkout"
        DGV_Checkout.RowHeadersWidth = 51
        DGV_Checkout.Size = New Size(996, 537)
        DGV_Checkout.TabIndex = 119
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
        ' GuestCheckout
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1077, 777)
        Controls.Add(DGV_Checkout)
        Controls.Add(Lbl_anykeyword)
        Controls.Add(searchkeyword_txtbx)
        Controls.Add(checkout_btn)
        Controls.Add(Lbl_checkout)
        FormBorderStyle = FormBorderStyle.None
        Name = "GuestCheckout"
        Text = "GuestCheckout"
        CType(DGV_Checkout, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_checkout As Label
    Friend WithEvents checkout_btn As Button
    Friend WithEvents searchkeyword_txtbx As TextBox
    Friend WithEvents Lbl_anykeyword As Label
    Friend WithEvents DGV_Checkout As DataGridView
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
