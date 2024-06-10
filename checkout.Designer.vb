<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkout
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
        DGV_guestcheckout = New DataGridView()
        Panel1 = New Panel()
        Button1 = New Button()
        closebtn = New Button()
        Lblviewg = New Label()
        checkout_btn = New Button()
        CType(DGV_guestcheckout, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DGV_guestcheckout
        ' 
        DGV_guestcheckout.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_guestcheckout.Location = New Point(67, 124)
        DGV_guestcheckout.Name = "DGV_guestcheckout"
        DGV_guestcheckout.RowHeadersWidth = 51
        DGV_guestcheckout.Size = New Size(818, 445)
        DGV_guestcheckout.TabIndex = 23
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(closebtn)
        Panel1.Controls.Add(Lblviewg)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(948, 54)
        Panel1.TabIndex = 45
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderColor = Color.White
        Button1.FlatAppearance.BorderSize = 2
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Lucida Fax", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.Window
        Button1.Location = New Point(902, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(43, 42)
        Button1.TabIndex = 45
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
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
        Lblviewg.Location = New Point(391, 9)
        Lblviewg.Name = "Lblviewg"
        Lblviewg.Size = New Size(220, 31)
        Lblviewg.TabIndex = 23
        Lblviewg.Text = "GUEST CHECK-OUT"
        Lblviewg.TextAlign = ContentAlignment.MiddleCenter
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
        checkout_btn.Location = New Point(418, 616)
        checkout_btn.Name = "checkout_btn"
        checkout_btn.Size = New Size(143, 58)
        checkout_btn.TabIndex = 46
        checkout_btn.Text = "Check Out"
        checkout_btn.UseVisualStyleBackColor = False
        ' 
        ' checkout
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(948, 750)
        Controls.Add(checkout_btn)
        Controls.Add(Panel1)
        Controls.Add(DGV_guestcheckout)
        FormBorderStyle = FormBorderStyle.None
        Name = "checkout"
        Text = "checkout"
        CType(DGV_guestcheckout, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents DGV_guestcheckout As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents closebtn As Button
    Friend WithEvents Lblviewg As Label
    Friend WithEvents checkout_btn As Button
End Class
