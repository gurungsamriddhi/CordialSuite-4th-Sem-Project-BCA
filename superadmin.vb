Public Class superadmin
    Dim viewuserForm As New viewuser()
    Dim superadminName As String = "gurung_samriddhi"



    Public Sub Switchpanel(ByVal panel As Form, Optional ByVal showBackButton As Boolean = False)

        Pnl_dashboard.Controls.Clear()
        panel.TopLevel = False
        Pnl_dashboard.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            For Each frm As Form In Application.OpenForms.OfType(Of Form).ToList()
                If frm IsNot Loginform Then
                    frm.Hide()
                End If
            Next
            Loginform.Show()
            Loginform.txtbxusername.Clear()
            Loginform.txtbxpassword.Clear()
        End If
    End Sub


    Private Sub close_Btn_Click(sender As Object, e As EventArgs) Handles close_Btn.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub superadmindashboard_btn_Click(sender As Object, e As EventArgs) Handles superadmindashboard_btn.Click
        ' Display the default form in the pnl_dashboard when the dashboard button is clicked
        Dim defaultForm As New superadmindashboardform() ' Replace with your actual default form
        Switchpanel(defaultForm)
    End Sub

    Private Sub admindashboard_btn_Click(sender As Object, e As EventArgs) Handles admindashboard_btn.Click
        Me.Hide()

        ' Show admin dashboard form
        Dim admindashboardform As New Admin()
        admindashboardform.back_btn.Visible = True ' Make back button visible
        admindashboardform.Labeladminname.Text = superadminName
        admindashboardform.Show()
    End Sub

    Private Sub vieuser_btn_Click(sender As Object, e As EventArgs) Handles vieuser_btn.Click
        Switchpanel(viewuser)
    End Sub

    Private Sub register_btn_Click(sender As Object, e As EventArgs) Handles register_btn.Click
        Switchpanel(New Registerform())
    End Sub

    Private Sub superadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim defaultForm As New superadmindashboardform() ' Replace with your actual default form
        Switchpanel(defaultForm)
    End Sub

    Private Sub minimise_btn_Click(sender As Object, e As EventArgs) Handles minimise_btn.Click

        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
