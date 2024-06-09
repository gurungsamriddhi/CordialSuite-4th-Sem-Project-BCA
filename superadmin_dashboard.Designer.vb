<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class superadmin_dashboard
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
        Panel1 = New Panel()
        statusbtn = New Button()
        closebtn = New Button()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(statusbtn)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(231, 709)
        Panel1.TabIndex = 6
        ' 
        ' statusbtn
        ' 
        statusbtn.BackColor = Color.Transparent
        statusbtn.FlatAppearance.BorderColor = SystemColors.Window
        statusbtn.FlatAppearance.BorderSize = 2
        statusbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(219), CByte(215), CByte(210))
        statusbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(219), CByte(215), CByte(210))
        statusbtn.FlatStyle = FlatStyle.Flat
        statusbtn.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        statusbtn.ForeColor = SystemColors.Window
        statusbtn.Location = New Point(6, 153)
        statusbtn.Name = "statusbtn"
        statusbtn.Size = New Size(219, 47)
        statusbtn.TabIndex = 9
        statusbtn.Text = "Register New User"
        statusbtn.UseVisualStyleBackColor = False
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
        closebtn.TabIndex = 10
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Window
        Panel2.Location = New Point(3, 153)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(0, 0)
        Panel2.TabIndex = 10
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(231, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(940, 709)
        Panel3.TabIndex = 11
        ' 
        ' superadmin_dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        ClientSize = New Size(1171, 709)
        Controls.Add(Panel3)
        Controls.Add(closebtn)
        Controls.Add(Panel1)
        ForeColor = Color.Transparent
        FormBorderStyle = FormBorderStyle.None
        Name = "superadmin_dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Options"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents label1 As label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents closebtn As Button
    Friend WithEvents statusbtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
