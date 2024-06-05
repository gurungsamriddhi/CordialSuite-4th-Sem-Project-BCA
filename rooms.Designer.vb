<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rooms
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
        Panel1 = New Panel()
        closebtn = New Button()
        Lblroominfo = New Label()
        searchroom_txtbx = New TextBox()
        searchroom_btn = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        Panel1.Controls.Add(closebtn)
        Panel1.Controls.Add(Lblroominfo)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(829, 50)
        Panel1.TabIndex = 0
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = SystemColors.ControlLightLight
        closebtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 12F, FontStyle.Bold)
        closebtn.Location = New Point(770, 8)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(47, 34)
        closebtn.TabIndex = 27
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Lblroominfo
        ' 
        Lblroominfo.AutoSize = True
        Lblroominfo.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lblroominfo.ForeColor = SystemColors.ControlLightLight
        Lblroominfo.Location = New Point(314, 13)
        Lblroominfo.Name = "Lblroominfo"
        Lblroominfo.Size = New Size(200, 24)
        Lblroominfo.TabIndex = 1
        Lblroominfo.Text = "ROOM INFORMATION"
        ' 
        ' searchroom_txtbx
        ' 
        searchroom_txtbx.BackColor = SystemColors.ControlLightLight
        searchroom_txtbx.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchroom_txtbx.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        searchroom_txtbx.Location = New Point(289, 94)
        searchroom_txtbx.Name = "searchroom_txtbx"
        searchroom_txtbx.Size = New Size(234, 31)
        searchroom_txtbx.TabIndex = 4
        ' 
        ' searchroom_btn
        ' 
        searchroom_btn.BackColor = SystemColors.ControlLightLight
        searchroom_btn.FlatAppearance.BorderSize = 0
        searchroom_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        searchroom_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        searchroom_btn.FlatStyle = FlatStyle.Flat
        searchroom_btn.Font = New Font("Calisto MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        searchroom_btn.ForeColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        searchroom_btn.Location = New Point(556, 94)
        searchroom_btn.Name = "searchroom_btn"
        searchroom_btn.Size = New Size(100, 31)
        searchroom_btn.TabIndex = 5
        searchroom_btn.Text = "Search"
        searchroom_btn.UseVisualStyleBackColor = False
        ' 
        ' rooms
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(829, 585)
        Controls.Add(searchroom_btn)
        Controls.Add(searchroom_txtbx)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "rooms"
        Text = "rooms"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lblroominfo As Label
    Friend WithEvents closebtn As Button
    Friend WithEvents searchroom_txtbx As TextBox
    Friend WithEvents searchroom_btn As Button
End Class
