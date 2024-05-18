<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginform
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
        Label1.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(279, 147)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 24)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(279, 307)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 24)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' txtuser
        ' 
        txtuser.Font = New Font("Segoe UI", 14F)
        txtuser.Location = New Point(397, 260)
        txtuser.Margin = New Padding(3, 4, 3, 4)
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(260, 39)
        txtuser.TabIndex = 2
        ' 
        ' txtpassword
        ' 
        txtpassword.Font = New Font("Segoe UI", 14F)
        txtpassword.Location = New Point(397, 307)
        txtpassword.Margin = New Padding(3, 4, 3, 4)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(260, 39)
        txtpassword.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Tahoma", 14F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(451, 377)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(108, 43)
        Button1.TabIndex = 4
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' loginform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(7), CByte(46))
        ClientSize = New Size(947, 536)
        Controls.Add(Button1)
        Controls.Add(txtpassword)
        Controls.Add(txtuser)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = Color.Transparent
        Margin = New Padding(3, 4, 3, 4)
        Name = "loginform"
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
