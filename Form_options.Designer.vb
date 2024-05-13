<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_options
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
        Panel_options = New Panel()
        Exit_btn = New Button()
        Login_btn = New Button()
        Register_btn = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel_options.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel_options
        ' 
        Panel_options.BackColor = Color.Transparent
        Panel_options.Controls.Add(Exit_btn)
        Panel_options.Controls.Add(Login_btn)
        Panel_options.Controls.Add(Register_btn)
        Panel_options.Location = New Point(314, 152)
        Panel_options.Name = "Panel_options"
        Panel_options.Size = New Size(315, 225)
        Panel_options.TabIndex = 0
        ' 
        ' Exit_btn
        ' 
        Exit_btn.FlatAppearance.BorderSize = 0
        Exit_btn.FlatStyle = FlatStyle.Flat
        Exit_btn.Font = New Font("Tahoma", 18F, FontStyle.Bold)
        Exit_btn.ForeColor = SystemColors.Control
        Exit_btn.Location = New Point(0, 169)
        Exit_btn.Name = "Exit_btn"
        Exit_btn.Size = New Size(315, 66)
        Exit_btn.TabIndex = 2
        Exit_btn.Text = "   Exit"
        Exit_btn.UseVisualStyleBackColor = True
        ' 
        ' Login_btn
        ' 
        Login_btn.FlatAppearance.BorderSize = 0
        Login_btn.FlatStyle = FlatStyle.Flat
        Login_btn.Font = New Font("Tahoma", 18F, FontStyle.Bold)
        Login_btn.ForeColor = SystemColors.Control
        Login_btn.Location = New Point(0, 84)
        Login_btn.Name = "Login_btn"
        Login_btn.Size = New Size(315, 69)
        Login_btn.TabIndex = 1
        Login_btn.Text = "   Log in"
        Login_btn.UseVisualStyleBackColor = True
        ' 
        ' Register_btn
        ' 
        Register_btn.FlatAppearance.BorderSize = 0
        Register_btn.FlatStyle = FlatStyle.Flat
        Register_btn.Font = New Font("Tahoma", 18F, FontStyle.Bold)
        Register_btn.ForeColor = SystemColors.Control
        Register_btn.Location = New Point(0, 3)
        Register_btn.Name = "Register_btn"
        Register_btn.Size = New Size(312, 66)
        Register_btn.TabIndex = 0
        Register_btn.Text = "    Register"
        Register_btn.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(947, 19)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.Location = New Point(314, 152)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(21, 69)
        Panel2.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.Control
        Panel3.Location = New Point(314, 321)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(21, 66)
        Panel3.TabIndex = 3
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.Control
        Panel4.Location = New Point(314, 236)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(21, 69)
        Panel4.TabIndex = 4
        ' 
        ' Form_options
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        ClientSize = New Size(947, 536)
        Controls.Add(Panel3)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Panel_options)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form_options"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Options"
        Panel_options.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel_options As Panel
    Friend WithEvents Register_btn As Button
    Friend WithEvents Exit_btn As Button
    Friend WithEvents Login_btn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
End Class
