<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class splash
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
        components = New ComponentModel.Container()
        Lbl_displayfp = New Label()
        closebtn = New Button()
        ProgressBarsplashscreen = New ProgressBar()
        Timer1 = New Timer(components)
        loading_txtbx = New TextBox()
        SuspendLayout()
        ' 
        ' Lbl_displayfp
        ' 
        Lbl_displayfp.AutoSize = True
        Lbl_displayfp.BackColor = Color.Transparent
        Lbl_displayfp.Font = New Font("Tahoma", 67.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_displayfp.ForeColor = SystemColors.Window
        Lbl_displayfp.Location = New Point(288, 315)
        Lbl_displayfp.Name = "Lbl_displayfp"
        Lbl_displayfp.Size = New Size(755, 138)
        Lbl_displayfp.TabIndex = 0
        Lbl_displayfp.Text = "CordialSuite"
        Lbl_displayfp.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.Transparent
        closebtn.FlatAppearance.BorderColor = Color.White
        closebtn.FlatAppearance.BorderSize = 2
        closebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(48), CByte(144), CByte(220))
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closebtn.ForeColor = SystemColors.Window
        closebtn.Location = New Point(1271, 4)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(42, 39)
        closebtn.TabIndex = 9
        closebtn.Text = "X"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' ProgressBarsplashscreen
        ' 
        ProgressBarsplashscreen.ForeColor = Color.Transparent
        ProgressBarsplashscreen.Location = New Point(1, 771)
        ProgressBarsplashscreen.Name = "ProgressBarsplashscreen"
        ProgressBarsplashscreen.Size = New Size(1316, 21)
        ProgressBarsplashscreen.Style = ProgressBarStyle.Continuous
        ProgressBarsplashscreen.TabIndex = 10
        ' 
        ' Timer1
        ' 
        ' 
        ' loading_txtbx
        ' 
        loading_txtbx.BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        loading_txtbx.BorderStyle = BorderStyle.None
        loading_txtbx.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        loading_txtbx.ForeColor = SystemColors.Window
        loading_txtbx.Location = New Point(1189, 734)
        loading_txtbx.Name = "loading_txtbx"
        loading_txtbx.Size = New Size(124, 31)
        loading_txtbx.TabIndex = 11
        loading_txtbx.Text = "%"
        ' 
        ' splash
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(114), CByte(175))
        ClientSize = New Size(1317, 792)
        Controls.Add(loading_txtbx)
        Controls.Add(ProgressBarsplashscreen)
        Controls.Add(closebtn)
        Controls.Add(Lbl_displayfp)
        ForeColor = Color.Transparent
        FormBorderStyle = FormBorderStyle.None
        Name = "splash"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CordialSuite"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_displayfp As Label
    Friend WithEvents closebtn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents loading_txtbx As TextBox
    Private WithEvents ProgressBarsplashscreen As ProgressBar


End Class
