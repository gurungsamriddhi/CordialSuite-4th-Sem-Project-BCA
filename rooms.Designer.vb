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
        searchroom_txtbx = New TextBox()
        Rooms_DGV = New DataGridView()
        searchrooms_Btn = New Button()
        Panel1 = New Panel()
        close_Btn = New Button()
        closebtn = New Button()
        Lblviewg = New Label()
        CType(Rooms_DGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' searchroom_txtbx
        ' 
        searchroom_txtbx.BackColor = SystemColors.ControlLightLight
        searchroom_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchroom_txtbx.ForeColor = Color.Black
        searchroom_txtbx.Location = New Point(328, 111)
        searchroom_txtbx.Name = "searchroom_txtbx"
        searchroom_txtbx.Size = New Size(276, 38)
        searchroom_txtbx.TabIndex = 4
        ' 
        ' Rooms_DGV
        ' 
        Rooms_DGV.AllowUserToOrderColumns = True
        Rooms_DGV.BackgroundColor = SystemColors.ControlLight
        Rooms_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Rooms_DGV.Location = New Point(100, 182)
        Rooms_DGV.Name = "Rooms_DGV"
        Rooms_DGV.RowHeadersWidth = 51
        Rooms_DGV.Size = New Size(761, 454)
        Rooms_DGV.TabIndex = 6
        ' 
        ' searchrooms_Btn
        ' 
        searchrooms_Btn.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        searchrooms_Btn.FlatAppearance.BorderColor = SystemColors.Window
        searchrooms_Btn.FlatAppearance.BorderSize = 2
        searchrooms_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        searchrooms_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        searchrooms_Btn.FlatStyle = FlatStyle.Flat
        searchrooms_Btn.Font = New Font("Calisto MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        searchrooms_Btn.ForeColor = SystemColors.Window
        searchrooms_Btn.Location = New Point(610, 113)
        searchrooms_Btn.Name = "searchrooms_Btn"
        searchrooms_Btn.Size = New Size(100, 37)
        searchrooms_Btn.TabIndex = 7
        searchrooms_Btn.Text = "Search"
        searchrooms_Btn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        Panel1.Controls.Add(close_Btn)
        Panel1.Controls.Add(closebtn)
        Panel1.Controls.Add(Lblviewg)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(948, 57)
        Panel1.TabIndex = 44
        ' 
        ' close_Btn
        ' 
        close_Btn.BackColor = Color.Transparent
        close_Btn.FlatAppearance.BorderColor = Color.White
        close_Btn.FlatAppearance.BorderSize = 2
        close_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        close_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        close_Btn.FlatStyle = FlatStyle.Flat
        close_Btn.Font = New Font("Lucida Fax", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        close_Btn.ForeColor = SystemColors.Window
        close_Btn.Location = New Point(900, 5)
        close_Btn.Name = "close_Btn"
        close_Btn.Size = New Size(43, 42)
        close_Btn.TabIndex = 24
        close_Btn.Text = "X"
        close_Btn.UseVisualStyleBackColor = False
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = SystemColors.ControlLightLight
        closebtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(10), CByte(15), CByte(60))
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        closebtn.Location = New Point(431, 313)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(47, 35)
        closebtn.TabIndex = 23
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' Lblviewg
        ' 
        Lblviewg.AutoSize = True
        Lblviewg.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblviewg.ForeColor = SystemColors.Window
        Lblviewg.Location = New Point(377, 9)
        Lblviewg.Name = "Lblviewg"
        Lblviewg.Size = New Size(264, 31)
        Lblviewg.TabIndex = 23
        Lblviewg.Text = "ROOMS INFORMATION"
        ' 
        ' rooms
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(948, 750)
        Controls.Add(Panel1)
        Controls.Add(searchrooms_Btn)
        Controls.Add(Rooms_DGV)
        Controls.Add(searchroom_txtbx)
        FormBorderStyle = FormBorderStyle.None
        Name = "rooms"
        Text = "rooms"
        CType(Rooms_DGV, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents searchroom_txtbx As TextBox
    Friend WithEvents Rooms_DGV As DataGridView
    Friend WithEvents searchrooms_Btn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents close_Btn As Button
    Friend WithEvents closebtn As Button
    Friend WithEvents Lblviewg As Label
End Class
