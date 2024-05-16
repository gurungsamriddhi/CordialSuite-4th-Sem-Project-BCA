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
        Login = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F)
        Label1.Location = New Point(260, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 20)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(260, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' txtuser
        ' 
        txtuser.Font = New Font("Segoe UI", 11F)
        txtuser.Location = New Point(369, 58)
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(100, 27)
        txtuser.TabIndex = 2
        ' 
        ' txtpassword
        ' 
        txtpassword.Font = New Font("Segoe UI", 11F)
        txtpassword.Location = New Point(369, 116)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(100, 27)
        txtpassword.TabIndex = 3
        ' 
        ' Login
        ' 
        Login.Font = New Font("Segoe UI", 12F)
        Login.Location = New Point(394, 165)
        Login.Name = "Login"
        Login.Size = New Size(75, 31)
        Login.TabIndex = 4
        Login.Text = "Login"
        Login.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.Disable
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Login)
        Controls.Add(txtpassword)
        Controls.Add(txtuser)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Login As Button
End Class
