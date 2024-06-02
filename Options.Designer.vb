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
        Login_btn = New Button()
        Register_btn = New Button()
        PanelRegister = New Panel()
        PanelLogin = New Panel()
        closebtn = New Button()
        Paneloptions.SuspendLayout()
        SuspendLayout()
        ' 
        ' Paneloptions
        ' 
        Paneloptions.BackColor = Color.Transparent
        Paneloptions.Controls.Add(Login_btn)
        Paneloptions.Controls.Add(Register_btn)
        Paneloptions.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Paneloptions.Location = New Point(360, 223)
        Paneloptions.Name = "Paneloptions"
        Paneloptions.Size = New Size(316, 139)
        Paneloptions.TabIndex = 0
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
        ' PanelRegister
        ' 
        PanelRegister.BackColor = SystemColors.ControlLightLight
        PanelRegister.Location = New Point(345, 223)
        PanelRegister.Name = "PanelRegister"
        PanelRegister.Size = New Size(18, 66)
        PanelRegister.TabIndex = 2
        ' 
        ' PanelLogin
        ' 
        PanelLogin.BackColor = SystemColors.ControlLightLight
        PanelLogin.Location = New Point(345, 296)
        PanelLogin.Name = "PanelLogin"
        PanelLogin.Size = New Size(18, 66)
        PanelLogin.TabIndex = 4
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.Transparent
        closebtn.FlatAppearance.MouseDownBackColor = SystemColors.GrayText
        closebtn.FlatAppearance.MouseOverBackColor = SystemColors.GrayText
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = SystemColors.ControlLightLight
        closebtn.Location = New Point(962, 12)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(47, 34)
        closebtn.TabIndex = 5
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Options
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        ClientSize = New Size(1021, 585)
        Controls.Add(closebtn)
        Controls.Add(PanelLogin)
        Controls.Add(PanelRegister)
        Controls.Add(Paneloptions)
        ForeColor = Color.Transparent
        FormBorderStyle = FormBorderStyle.None
        Name = "Options"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Options"
        Paneloptions.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Paneloptions As Panel
    Friend WithEvents Register_btn As Button
    Friend WithEvents Login_btn As Button
    Friend WithEvents PanelRegister As Panel
    Friend WithEvents PanelLogin As Panel
    Friend WithEvents label1 As label
    Friend WithEvents closebtn As Button
End Class
