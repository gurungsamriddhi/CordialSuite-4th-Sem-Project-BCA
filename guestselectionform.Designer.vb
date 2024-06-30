<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class guestselectionform
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DGV_Guests = New DataGridView()
        CType(DGV_Guests, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DGV_Guests
        ' 
        DGV_Guests.AllowUserToAddRows = False
        DGV_Guests.AllowUserToDeleteRows = False
        DGV_Guests.Anchor = AnchorStyles.None
        DGV_Guests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DGV_Guests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DGV_Guests.BackgroundColor = SystemColors.Menu
        DGV_Guests.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DGV_Guests.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DGV_Guests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_Guests.Location = New Point(20, 41)
        DGV_Guests.Name = "DGV_Guests"
        DGV_Guests.ReadOnly = True
        DGV_Guests.RowHeadersWidth = 51
        DGV_Guests.Size = New Size(655, 351)
        DGV_Guests.TabIndex = 1
        ' 
        ' guestselectionform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(697, 421)
        Controls.Add(DGV_Guests)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Name = "guestselectionform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Double Click to select a guest"
        CType(DGV_Guests, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DGV_Guests As DataGridView
End Class
