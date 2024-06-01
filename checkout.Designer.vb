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
        Lblgcheckout = New Label()
        Panelgco.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panelgco
        ' 
        Panelgco.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Panelgco.Controls.Add(Lblgcheckout)
        Panelgco.Dock = DockStyle.Top
        Panelgco.Location = New Point(0, 0)
        Panelgco.Name = "Panelgco"
        Panelgco.Size = New Size(829, 47)
        Panelgco.TabIndex = 22
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
        ' checkout
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(829, 585)
        Controls.Add(Panelgco)
        FormBorderStyle = FormBorderStyle.None
        Name = "checkout"
        Text = "checkout"
        Panelgco.ResumeLayout(False)
        Panelgco.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panelgco As Panel
    Friend WithEvents Lblgcheckout As Label
End Class
