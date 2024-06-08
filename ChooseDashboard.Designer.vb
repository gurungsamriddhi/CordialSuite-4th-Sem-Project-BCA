<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseDashboard
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
        closebtn = New Button()
        PanelLogin = New Panel()
        Paneloptions = New Panel()
        admindashboard_btn = New Button()
        Userdashboard_btn = New Button()
        Panel1 = New Panel()
        Paneloptions.SuspendLayout()
        SuspendLayout()
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.Transparent
        closebtn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        closebtn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = SystemColors.ControlLightLight
        closebtn.Location = New Point(840, 11)
        closebtn.Margin = New Padding(3, 2, 3, 2)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(41, 26)
        closebtn.TabIndex = 8
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' PanelLogin
        ' 
        PanelLogin.BackColor = SystemColors.ControlLightLight
        PanelLogin.Location = New Point(296, 229)
        PanelLogin.Margin = New Padding(3, 2, 3, 2)
        PanelLogin.Name = "PanelLogin"
        PanelLogin.Size = New Size(16, 52)
        PanelLogin.TabIndex = 11
        ' 
        ' Paneloptions
        ' 
        Paneloptions.BackColor = Color.Transparent
        Paneloptions.Controls.Add(admindashboard_btn)
        Paneloptions.Controls.Add(Userdashboard_btn)
        Paneloptions.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Paneloptions.Location = New Point(307, 169)
        Paneloptions.Margin = New Padding(3, 2, 3, 2)
        Paneloptions.Name = "Paneloptions"
        Paneloptions.Size = New Size(276, 112)
        Paneloptions.TabIndex = 9
        ' 
        ' admindashboard_btn
        ' 
        admindashboard_btn.FlatAppearance.BorderColor = SystemColors.Control
        admindashboard_btn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        admindashboard_btn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        admindashboard_btn.FlatStyle = FlatStyle.Flat
        admindashboard_btn.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        admindashboard_btn.ForeColor = SystemColors.ControlLightLight
        admindashboard_btn.Location = New Point(2, 60)
        admindashboard_btn.Margin = New Padding(3, 2, 3, 2)
        admindashboard_btn.Name = "admindashboard_btn"
        admindashboard_btn.Size = New Size(274, 50)
        admindashboard_btn.TabIndex = 1
        admindashboard_btn.Text = "Admin Dashboard"
        admindashboard_btn.UseVisualStyleBackColor = True
        ' 
        ' Userdashboard_btn
        ' 
        Userdashboard_btn.Dock = DockStyle.Top
        Userdashboard_btn.FlatAppearance.BorderColor = SystemColors.Control
        Userdashboard_btn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Userdashboard_btn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Userdashboard_btn.FlatStyle = FlatStyle.Flat
        Userdashboard_btn.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Userdashboard_btn.ForeColor = SystemColors.ControlLightLight
        Userdashboard_btn.Location = New Point(0, 0)
        Userdashboard_btn.Margin = New Padding(3, 2, 3, 2)
        Userdashboard_btn.Name = "Userdashboard_btn"
        Userdashboard_btn.Size = New Size(276, 50)
        Userdashboard_btn.TabIndex = 0
        Userdashboard_btn.Text = "User Dashboard"
        Userdashboard_btn.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLightLight
        Panel1.Location = New Point(296, 169)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(16, 52)
        Panel1.TabIndex = 12
        ' 
        ' ChooseDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        ClientSize = New Size(893, 439)
        Controls.Add(Panel1)
        Controls.Add(PanelLogin)
        Controls.Add(Paneloptions)
        Controls.Add(closebtn)
        FormBorderStyle = FormBorderStyle.None
        Name = "ChooseDashboard"
        Text = "ChooseDashboard"
        Paneloptions.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents closebtn As Button
    Friend WithEvents PanelLogin As Panel
    Friend WithEvents Paneloptions As Panel
    Friend WithEvents admindashboard_btn As Button
    Friend WithEvents Userdashboard_btn As Button
    Friend WithEvents Panel1 As Panel
End Class
