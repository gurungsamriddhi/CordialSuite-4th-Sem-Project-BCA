<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class billing
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
        Pnl_billing = New Panel()
        closebtn = New Button()
        Lblbilling = New Label()
        Pnl_billing.SuspendLayout()
        SuspendLayout()
        ' 
        ' Pnl_billing
        ' 
        Pnl_billing.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Pnl_billing.Controls.Add(closebtn)
        Pnl_billing.Controls.Add(Lblbilling)
        Pnl_billing.Dock = DockStyle.Top
        Pnl_billing.Location = New Point(0, 0)
        Pnl_billing.Name = "Pnl_billing"
        Pnl_billing.Size = New Size(820, 50)
        Pnl_billing.TabIndex = 1
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = SystemColors.ControlLightLight
        closebtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 12F, FontStyle.Bold)
        closebtn.Location = New Point(761, 8)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(47, 34)
        closebtn.TabIndex = 25
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Lblbilling
        ' 
        Lblbilling.AutoSize = True
        Lblbilling.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lblbilling.ForeColor = SystemColors.ControlLightLight
        Lblbilling.Location = New Point(373, 13)
        Lblbilling.Name = "Lblbilling"
        Lblbilling.Size = New Size(82, 24)
        Lblbilling.TabIndex = 1
        Lblbilling.Text = "BILLING"
        ' 
        ' billing
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(820, 585)
        Controls.Add(Pnl_billing)
        FormBorderStyle = FormBorderStyle.None
        Name = "billing"
        Text = "billing"
        Pnl_billing.ResumeLayout(False)
        Pnl_billing.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Pnl_billing As Panel
    Friend WithEvents Lblbilling As Label
    Friend WithEvents closebtn As Button
End Class
