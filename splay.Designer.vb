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
        SuspendLayout()
        ' 
        ' Lbl_displayfp
        ' 
        Lbl_displayfp.AutoSize = True
        Lbl_displayfp.BackColor = Color.Transparent
        Lbl_displayfp.Font = New Font("Tahoma", 55.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_displayfp.ForeColor = SystemColors.ControlLightLight
        Lbl_displayfp.Location = New Point(231, 210)
        Lbl_displayfp.Name = "Lbl_displayfp"
        Lbl_displayfp.Size = New Size(612, 111)
        Lbl_displayfp.TabIndex = 0
        Lbl_displayfp.Text = "CordialSuite"
        Lbl_displayfp.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' splay
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        ClientSize = New Size(1021, 585)
        Controls.Add(Lbl_displayfp)
        ForeColor = SystemColors.Control
        Name = "splay"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CordialSuite"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_displayfp As Label


End Class
