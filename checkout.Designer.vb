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
        Panelgco = New Panel()
        closebtn = New Button()
        Lblgcheckout = New Label()
        DGV_guestcheckout = New DataGridView()
        checkout_btn = New Button()
        Panelgco.SuspendLayout()
        CType(DGV_guestcheckout, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panelgco
        ' 
        Panelgco.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Panelgco.Controls.Add(closebtn)
        Panelgco.Controls.Add(Lblgcheckout)
        Panelgco.Dock = DockStyle.Top
        Panelgco.Location = New Point(0, 0)
        Panelgco.Name = "Panelgco"
        Panelgco.Size = New Size(829, 50)
        Panelgco.TabIndex = 22
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = SystemColors.ControlLightLight
        closebtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 12F, FontStyle.Bold)
        closebtn.Location = New Point(770, 8)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(47, 34)
        closebtn.TabIndex = 26
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Lblgcheckout
        ' 
        Lblgcheckout.AutoSize = True
        Lblgcheckout.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblgcheckout.ForeColor = SystemColors.ControlLightLight
        Lblgcheckout.Location = New Point(321, 9)
        Lblgcheckout.Name = "Lblgcheckout"
        Lblgcheckout.Size = New Size(187, 28)
        Lblgcheckout.TabIndex = 10
        Lblgcheckout.Text = "GUEST CHECK-OUT"
        ' 
        ' DGV_guestcheckout
        ' 
        DGV_guestcheckout.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_guestcheckout.Location = New Point(51, 94)
        DGV_guestcheckout.Name = "DGV_guestcheckout"
        DGV_guestcheckout.RowHeadersWidth = 51
        DGV_guestcheckout.Size = New Size(722, 354)
        DGV_guestcheckout.TabIndex = 23
        ' 
        ' checkout_btn
        ' 
        checkout_btn.BackColor = SystemColors.ControlLightLight
        checkout_btn.FlatAppearance.BorderSize = 0
        checkout_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        checkout_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        checkout_btn.FlatStyle = FlatStyle.Flat
        checkout_btn.Font = New Font("Calisto MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        checkout_btn.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        checkout_btn.Location = New Point(362, 495)
        checkout_btn.Name = "checkout_btn"
        checkout_btn.Size = New Size(132, 42)
        checkout_btn.TabIndex = 24
        checkout_btn.Text = "Check Out"
        checkout_btn.UseVisualStyleBackColor = False
        ' 
        ' checkout
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(829, 585)
        Controls.Add(checkout_btn)
        Controls.Add(DGV_guestcheckout)
        Controls.Add(Panelgco)
        FormBorderStyle = FormBorderStyle.None
        Name = "checkout"
        Text = "checkout"
        Panelgco.ResumeLayout(False)
        Panelgco.PerformLayout()
        CType(DGV_guestcheckout, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panelgco As Panel
    Friend WithEvents Lblgcheckout As Label
    Friend WithEvents closebtn As Button
    Friend WithEvents DGV_guestcheckout As DataGridView
    Friend WithEvents checkout_btn As Button
End Class
