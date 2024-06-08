<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Viewemployee
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
        editEMP_btn = New Button()
        Pnl_Viewemployee = New Panel()
        closebtn = New Button()
        Lblviewemp = New Label()
        DGV_viewemployee = New DataGridView()
        Pnl_Viewemployee.SuspendLayout()
        CType(DGV_viewemployee, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' editEMP_btn
        ' 
        editEMP_btn.BackColor = SystemColors.ControlLightLight
        editEMP_btn.FlatAppearance.BorderColor = SystemColors.ButtonShadow
        editEMP_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        editEMP_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        editEMP_btn.FlatStyle = FlatStyle.Flat
        editEMP_btn.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        editEMP_btn.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        editEMP_btn.Location = New Point(380, 501)
        editEMP_btn.Name = "editEMP_btn"
        editEMP_btn.Size = New Size(106, 41)
        editEMP_btn.TabIndex = 60
        editEMP_btn.Text = "Edit"
        editEMP_btn.UseVisualStyleBackColor = False
        ' 
        ' Pnl_Viewemployee
        ' 
        Pnl_Viewemployee.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Pnl_Viewemployee.Controls.Add(closebtn)
        Pnl_Viewemployee.Controls.Add(Lblviewemp)
        Pnl_Viewemployee.Dock = DockStyle.Top
        Pnl_Viewemployee.Location = New Point(0, 0)
        Pnl_Viewemployee.Name = "Pnl_Viewemployee"
        Pnl_Viewemployee.Size = New Size(820, 50)
        Pnl_Viewemployee.TabIndex = 61
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = SystemColors.ControlLightLight
        closebtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold)
        closebtn.Location = New Point(761, 9)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(47, 35)
        closebtn.TabIndex = 23
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Lblviewemp
        ' 
        Lblviewemp.AutoSize = True
        Lblviewemp.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblviewemp.ForeColor = SystemColors.ControlLightLight
        Lblviewemp.Location = New Point(329, 11)
        Lblviewemp.Name = "Lblviewemp"
        Lblviewemp.Size = New Size(162, 28)
        Lblviewemp.TabIndex = 23
        Lblviewemp.Text = "VIEW EMPLOYEE"
        ' 
        ' DGV_viewemployee
        ' 
        DGV_viewemployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_viewemployee.Location = New Point(49, 115)
        DGV_viewemployee.Name = "DGV_viewemployee"
        DGV_viewemployee.RowHeadersWidth = 51
        DGV_viewemployee.Size = New Size(722, 354)
        DGV_viewemployee.TabIndex = 62
        ' 
        ' Viewemployee
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(820, 585)
        Controls.Add(DGV_viewemployee)
        Controls.Add(Pnl_Viewemployee)
        Controls.Add(editEMP_btn)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Viewemployee"
        Text = "Viewemployee"
        Pnl_Viewemployee.ResumeLayout(False)
        Pnl_Viewemployee.PerformLayout()
        CType(DGV_viewemployee, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents editEMP_btn As Button
    Friend WithEvents Pnl_Viewemployee As Panel
    Friend WithEvents closebtn As Button
    Friend WithEvents Lblviewemp As Label
    Friend WithEvents DGV_viewemployee As DataGridView
End Class
