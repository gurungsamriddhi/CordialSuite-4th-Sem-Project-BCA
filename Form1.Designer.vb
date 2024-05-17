<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        txtuser = New TextBox()
        txtpassword = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 14F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(247, 80)
        Label1.Margin = New Padding(3, 2, 3, 2)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 23)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 14F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(247, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 23)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' txtuser
        ' 
        txtuser.Font = New Font("Segoe UI", 14F)
        txtuser.Location = New Point(380, 80)
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(100, 32)
        txtuser.TabIndex = 2
        ' 
        ' txtpassword
        ' 
        txtpassword.Font = New Font("Segoe UI", 14F)
        txtpassword.Location = New Point(380, 162)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(100, 32)
        txtpassword.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Tahoma", 14F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(405, 229)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 32)
        Button1.TabIndex = 4
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        ClientSize = New Size(829, 402)
        Controls.Add(Button1)
        Controls.Add(txtpassword)
        Controls.Add(txtuser)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = Color.Transparent
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Button1 As Button
End Class
