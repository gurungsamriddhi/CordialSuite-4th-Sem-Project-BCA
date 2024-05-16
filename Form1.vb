Imports Utility

Public Class Form1
    ' Declare Button1 with WithEvents keyword
    Private WithEvents Button1 As Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Instantiate Button1
        Button1 = New Button()
        ' Set properties for Button1
        Button1.Text = "Login"
        Button1.Location = New Point(50, 50)
        ' Add Button1 to the form controls
        Me.Controls.Add(Button1)
    End Sub

    ' Event handler for Button1 Click event
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username, password As String
        username = txtuser.Text
        password = txtpassword.Text
        If (username.Equals("admin") And password.Equals("admin")) Then
            MessageBox.Show("Login Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
