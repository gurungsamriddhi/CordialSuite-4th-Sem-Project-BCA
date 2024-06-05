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
        PanelLogin = New Panel()
        PanelRegister = New Panel()
        Paneloptions = New Panel()
        User_Dashboard = New Button()
        Admin_Dashboard = New Button()
        closebtn = New Button()
        Lblnewg = New Label()
        Panel2 = New Panel()
        Paneloptions.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelLogin
        ' 
        PanelLogin.BackColor = SystemColors.ControlLightLight
        PanelLogin.Location = New Point(48, 172)
        PanelLogin.Margin = New Padding(3, 2, 3, 2)
        PanelLogin.Name = "PanelLogin"
        PanelLogin.Size = New Size(16, 50)
        PanelLogin.TabIndex = 8
        ' 
        ' PanelRegister
        ' 
        PanelRegister.BackColor = SystemColors.ControlLightLight
        PanelRegister.Location = New Point(48, 117)
        PanelRegister.Margin = New Padding(3, 2, 3, 2)
        PanelRegister.Name = "PanelRegister"
        PanelRegister.Size = New Size(16, 50)
        PanelRegister.TabIndex = 7
        ' 
        ' Paneloptions
        ' 
        Paneloptions.BackColor = Color.Transparent
        Paneloptions.Controls.Add(User_Dashboard)
        Paneloptions.Controls.Add(Admin_Dashboard)
        Paneloptions.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Paneloptions.Location = New Point(61, 117)
        Paneloptions.Margin = New Padding(3, 2, 3, 2)
        Paneloptions.Name = "Paneloptions"
        Paneloptions.Size = New Size(276, 104)
        Paneloptions.TabIndex = 6
        ' 
        ' User_Dashboard
        ' 
        User_Dashboard.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        User_Dashboard.FlatAppearance.BorderColor = SystemColors.Control
        User_Dashboard.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        User_Dashboard.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        User_Dashboard.FlatStyle = FlatStyle.Flat
        User_Dashboard.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        User_Dashboard.ForeColor = SystemColors.ControlLightLight
        User_Dashboard.Location = New Point(3, 55)
        User_Dashboard.Margin = New Padding(3, 2, 3, 2)
        User_Dashboard.Name = "User_Dashboard"
        User_Dashboard.Size = New Size(274, 50)
        User_Dashboard.TabIndex = 1
        User_Dashboard.Text = "User Dashboard"
        User_Dashboard.UseVisualStyleBackColor = False
        ' 
        ' Admin_Dashboard
        ' 
        Admin_Dashboard.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Admin_Dashboard.Dock = DockStyle.Top
        Admin_Dashboard.FlatAppearance.BorderColor = SystemColors.Control
        Admin_Dashboard.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Admin_Dashboard.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Admin_Dashboard.FlatStyle = FlatStyle.Flat
        Admin_Dashboard.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Admin_Dashboard.ForeColor = SystemColors.ControlLightLight
        Admin_Dashboard.Location = New Point(0, 0)
        Admin_Dashboard.Margin = New Padding(3, 2, 3, 2)
        Admin_Dashboard.Name = "Admin_Dashboard"
        Admin_Dashboard.Size = New Size(276, 50)
        Admin_Dashboard.TabIndex = 0
        Admin_Dashboard.Text = "Admin Dashboard"
        Admin_Dashboard.UseVisualStyleBackColor = False
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = SystemColors.ControlLightLight
        closebtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        closebtn.Location = New Point(812, 11)
        closebtn.Margin = New Padding(3, 2, 3, 2)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(41, 26)
        closebtn.TabIndex = 23
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Lblnewg
        ' 
        Lblnewg.AutoSize = True
        Lblnewg.BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        Lblnewg.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblnewg.ForeColor = Color.White
        Lblnewg.Location = New Point(101, 28)
        Lblnewg.Name = "Lblnewg"
        Lblnewg.Size = New Size(174, 21)
        Lblnewg.TabIndex = 23
        Lblnewg.Text = "CHOOSE DASHBOARD"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightCyan
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Paneloptions)
        Panel2.Controls.Add(Lblnewg)
        Panel2.Controls.Add(PanelRegister)
        Panel2.Controls.Add(PanelLogin)
        Panel2.Location = New Point(246, 51)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(402, 337)
        Panel2.TabIndex = 5
        ' 
        ' ChooseDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        ClientSize = New Size(877, 400)
        Controls.Add(closebtn)
        Controls.Add(Panel2)
        Location = New Point(246, 51)
        Name = "ChooseDashboard"
        Text = "ChooseDashboard"
        Paneloptions.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents closebtn As Button
    Friend WithEvents PanelLogin As Panel
    Friend WithEvents PanelRegister As Panel
    Friend WithEvents Paneloptions As Panel
    Friend WithEvents User_Dashboard As Button
    Friend WithEvents Admin_Dashboard As Button
    Friend WithEvents Lblnewg As Label
    Friend WithEvents Panel2 As Panel
End Class
