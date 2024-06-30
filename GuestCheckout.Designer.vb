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
        Lbl_checkout = New Label()
        DataGridView1 = New DataGridView()
        checkout_btn = New Button()
        searchkeyword_txtbx = New TextBox()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.Menu
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(31, 136)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1014, 517)
        DataGridView1.TabIndex = 25
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
        checkout_btn.Location = New Point(455, 684)
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
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(281, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 25)
        Label1.TabIndex = 118
        Label1.Text = "Any Keyword:"
        ' 
        ' GuestCheckout
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1077, 777)
        Controls.Add(Label1)
        Controls.Add(searchkeyword_txtbx)
        Controls.Add(checkout_btn)
        Controls.Add(DataGridView1)
        Controls.Add(Lbl_checkout)
        FormBorderStyle = FormBorderStyle.None
        Name = "GuestCheckout"
        Text = "GuestCheckout"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_checkout As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents checkout_btn As Button
    Friend WithEvents searchkeyword_txtbx As TextBox
    Friend WithEvents Label1 As Label
End Class
