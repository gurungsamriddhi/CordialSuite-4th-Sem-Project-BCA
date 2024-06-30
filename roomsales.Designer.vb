<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class roomsales
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
        Lbl_transaction = New Label()
        SuspendLayout()
        ' 
        ' Lbl_transaction
        ' 
        Lbl_transaction.AutoSize = True
        Lbl_transaction.BackColor = Color.Transparent
        Lbl_transaction.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_transaction.ForeColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Lbl_transaction.Location = New Point(470, 19)
        Lbl_transaction.Name = "Lbl_transaction"
        Lbl_transaction.Size = New Size(137, 31)
        Lbl_transaction.TabIndex = 25
        Lbl_transaction.Text = "Room Sales"
        Lbl_transaction.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' roomsales
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1077, 777)
        Controls.Add(Lbl_transaction)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "roomsales"
        Text = "Revenue"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_transaction As Label
End Class
