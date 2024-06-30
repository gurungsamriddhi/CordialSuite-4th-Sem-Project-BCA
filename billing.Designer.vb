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
        Lbl_billing = New Label()
        SuspendLayout()
        ' 
        ' Lbl_billing
        ' 
        Lbl_billing.AutoSize = True
        Lbl_billing.BackColor = Color.Transparent
        Lbl_billing.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_billing.ForeColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Lbl_billing.Location = New Point(502, 19)
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
        ClientSize = New Size(1077, 777)
        Controls.Add(Lbl_billing)
        FormBorderStyle = FormBorderStyle.None
        Name = "billing"
        Text = "billing"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Lbl_billing As Label
End Class
