<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class splay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Lbl_displayfp = New Label()
        closebtn = New Button()
        SuspendLayout()
        ' 
        ' Lbl_displayfp
        ' 
        Lbl_displayfp.AutoSize = True
        Lbl_displayfp.BackColor = Color.Transparent
        Lbl_displayfp.Font = New Font("Tahoma", 60F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_displayfp.ForeColor = SystemColors.Window
        Lbl_displayfp.Location = New Point(257, 273)
        Lbl_displayfp.Name = "Lbl_displayfp"
        Lbl_displayfp.Size = New Size(665, 121)
        Lbl_displayfp.TabIndex = 0
        Lbl_displayfp.Text = "CordialSuite"
        Lbl_displayfp.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.Transparent
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(219), CByte(215), CByte(210))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(219), CByte(215), CByte(210))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = SystemColors.Window
        closebtn.Location = New Point(1101, 12)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(58, 48)
        closebtn.TabIndex = 9
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' splay
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        ClientSize = New Size(1171, 709)
        Controls.Add(closebtn)
        Controls.Add(Lbl_displayfp)
        ForeColor = SystemColors.Control
        FormBorderStyle = FormBorderStyle.None
        Name = "splay"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CordialSuite"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_displayfp As Label
    Friend WithEvents closebtn As Button


End Class
