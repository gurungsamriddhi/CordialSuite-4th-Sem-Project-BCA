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
        Panel1 = New Panel()
        close_btn = New Button()
        closebtn = New Button()
        Lbl_billing = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Panel1.Controls.Add(close_btn)
        Panel1.Controls.Add(closebtn)
        Panel1.Controls.Add(Lbl_billing)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1077, 54)
        Panel1.TabIndex = 44
        ' 
        ' close_btn
        ' 
        close_btn.BackColor = Color.Transparent
        close_btn.FlatAppearance.BorderColor = Color.White
        close_btn.FlatAppearance.BorderSize = 2
        close_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        close_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        close_btn.FlatStyle = FlatStyle.Flat
        close_btn.Font = New Font("Lucida Fax", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        close_btn.ForeColor = SystemColors.Window
        close_btn.Location = New Point(1031, 3)
        close_btn.Name = "close_btn"
        close_btn.Size = New Size(43, 42)
        close_btn.TabIndex = 25
        close_btn.Text = "X"
        close_btn.UseVisualStyleBackColor = False
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
        ' Lbl_billing
        ' 
        Lbl_billing.AutoSize = True
        Lbl_billing.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_billing.ForeColor = SystemColors.Window
        Lbl_billing.Location = New Point(424, 12)
        Lbl_billing.Name = "Lbl_billing"
        Lbl_billing.Size = New Size(101, 31)
        Lbl_billing.TabIndex = 23
        Lbl_billing.Text = "BILLING"
        Lbl_billing.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' billing
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1077, 792)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "billing"
        Text = "billing"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents closebtn As Button
    Friend WithEvents Lbl_billing As Label
    Friend WithEvents close_btn As Button
End Class
