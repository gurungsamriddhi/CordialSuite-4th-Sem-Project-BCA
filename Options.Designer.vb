<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Options
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
        Paneloptions = New Panel()
        Exit_btn = New Button()
        Login_btn = New Button()
        Register_btn = New Button()
        PanelExit = New Panel()
        Paneldesign1 = New Panel()
        PanelRegister = New Panel()
        PanelLogin = New Panel()
        Paneloptions.SuspendLayout()
        SuspendLayout()
        ' 
        ' Paneloptions
        ' 
        Paneloptions.BackColor = Color.Transparent
        Paneloptions.Controls.Add(Exit_btn)
        Paneloptions.Controls.Add(Login_btn)
        Paneloptions.Controls.Add(Register_btn)
        Paneloptions.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Paneloptions.Location = New Point(379, 168)
        Paneloptions.Name = "Paneloptions"
        Paneloptions.Size = New Size(316, 211)
        Paneloptions.TabIndex = 0
        ' 
        ' Exit_btn
        ' 
        Exit_btn.AutoSize = True
        Exit_btn.FlatAppearance.BorderColor = SystemColors.Control
        Exit_btn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Exit_btn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Exit_btn.FlatStyle = FlatStyle.Flat
        Exit_btn.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        Exit_btn.ForeColor = SystemColors.ControlLightLight
        Exit_btn.Location = New Point(0, 145)
        Exit_btn.Name = "Exit_btn"
        Exit_btn.Size = New Size(316, 66)
        Exit_btn.TabIndex = 2
        Exit_btn.Text = "Exit"
        Exit_btn.UseVisualStyleBackColor = True
        ' 
        ' Login_btn
        ' 
        Login_btn.FlatAppearance.BorderColor = SystemColors.Control
        Login_btn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Login_btn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Login_btn.FlatStyle = FlatStyle.Flat
        Login_btn.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        Login_btn.ForeColor = SystemColors.ControlLightLight
        Login_btn.Location = New Point(3, 73)
        Login_btn.Name = "Login_btn"
        Login_btn.Size = New Size(313, 66)
        Login_btn.TabIndex = 1
        Login_btn.Text = "Log in"
        Login_btn.UseVisualStyleBackColor = True
        ' 
        ' Register_btn
        ' 
        Register_btn.Dock = DockStyle.Top
        Register_btn.FlatAppearance.BorderColor = SystemColors.Control
        Register_btn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        Register_btn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        Register_btn.FlatStyle = FlatStyle.Flat
        Register_btn.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Register_btn.ForeColor = SystemColors.ControlLightLight
        Register_btn.Location = New Point(0, 0)
        Register_btn.Name = "Register_btn"
        Register_btn.Size = New Size(316, 66)
        Register_btn.TabIndex = 0
        Register_btn.Text = "Register"
        Register_btn.UseVisualStyleBackColor = True
        ' 
        ' PanelExit
        ' 
        PanelExit.BackColor = SystemColors.ControlLightLight
        PanelExit.Location = New Point(364, 313)
        PanelExit.Name = "PanelExit"
        PanelExit.Size = New Size(18, 66)
        PanelExit.TabIndex = 3
        ' 
        ' Paneldesign1
        ' 
        Paneldesign1.BackColor = SystemColors.ControlLightLight
        Paneldesign1.Dock = DockStyle.Top
        Paneldesign1.Location = New Point(0, 0)
        Paneldesign1.Name = "Paneldesign1"
        Paneldesign1.Size = New Size(1021, 21)
        Paneldesign1.TabIndex = 1
        ' 
        ' PanelRegister
        ' 
        PanelRegister.BackColor = SystemColors.ControlLightLight
        PanelRegister.Location = New Point(364, 168)
        PanelRegister.Name = "PanelRegister"
        PanelRegister.Size = New Size(18, 66)
        PanelRegister.TabIndex = 2
        ' 
        ' PanelLogin
        ' 
        PanelLogin.BackColor = SystemColors.ControlLightLight
        PanelLogin.Location = New Point(364, 241)
        PanelLogin.Name = "PanelLogin"
        PanelLogin.Size = New Size(18, 66)
        PanelLogin.TabIndex = 4
        ' 
        ' Options
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        ClientSize = New Size(1021, 585)
        Controls.Add(PanelExit)
        Controls.Add(PanelLogin)
        Controls.Add(PanelRegister)
        Controls.Add(Paneldesign1)
        Controls.Add(Paneloptions)
        ForeColor = Color.Transparent
        Name = "Options"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Options"
        Paneloptions.ResumeLayout(False)
        Paneloptions.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Paneloptions As Panel
    Friend WithEvents Register_btn As Button
    Friend WithEvents Exit_btn As Button
    Friend WithEvents Login_btn As Button
    Friend WithEvents Paneldesign1 As Panel
    Friend WithEvents PanelExit As Panel
    Friend WithEvents PanelRegister As Panel
    Friend WithEvents PanelLogin As Panel
    Friend WithEvents label1 As label
End Class
