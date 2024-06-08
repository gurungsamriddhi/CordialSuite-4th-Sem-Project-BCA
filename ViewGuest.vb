Public Class ViewGuest
    Public Sub editguest_btn_Click(sender As Object, e As EventArgs) Handles editguest_btn.Click
        ' Check if all necessary text boxes are filled
        If String.IsNullOrWhiteSpace(gfirstname_txtbx.Text) AndAlso
           String.IsNullOrWhiteSpace(glastname_txtbx.Text) AndAlso
           String.IsNullOrWhiteSpace(GuestID_txtbx.Text) AndAlso
           String.IsNullOrWhiteSpace(Gemail_txtbx.Text) AndAlso
           cmbbx_genderG.SelectedIndex = -1 AndAlso
           Country_cmbbx.SelectedIndex = -1 AndAlso
           String.IsNullOrWhiteSpace(checkin_txtbx.Text) AndAlso
           String.IsNullOrWhiteSpace(checkout_txtbx.Text) AndAlso
           String.IsNullOrWhiteSpace(contact_txtbx.Text) Then

            MessageBox.Show("Please fill in all necessary detail.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if any necessary details are missing
        If String.IsNullOrWhiteSpace(gfirstname_txtbx.Text) OrElse
           String.IsNullOrWhiteSpace(glastname_txtbx.Text) OrElse
           String.IsNullOrWhiteSpace(GuestID_txtbx.Text) OrElse
           String.IsNullOrWhiteSpace(Gemail_txtbx.Text) OrElse
           cmbbx_genderG.SelectedIndex = -1 OrElse
           Country_cmbbx.SelectedIndex = -1 OrElse
           String.IsNullOrWhiteSpace(checkin_txtbx.Text) OrElse
           String.IsNullOrWhiteSpace(checkout_txtbx.Text) OrElse
           String.IsNullOrWhiteSpace(contact_txtbx.Text) Then

            MessageBox.Show("Please fill all the necessary details.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If String.IsNullOrWhiteSpace(gfirstname_txtbx.Text) Then
            MessageBox.Show("Please enter the guest's first name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(glastname_txtbx.Text) Then
            MessageBox.Show("Please enter the guest's last name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(GuestID_txtbx.Text) Then
            MessageBox.Show("Please enter the guest's ID.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(Gemail_txtbx.Text) Then
            MessageBox.Show("Please enter the guest's email.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbbx_genderG.SelectedIndex = -1 Then
            MessageBox.Show("Please select the guest's gender.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Country_cmbbx.SelectedIndex = -1 Then
            MessageBox.Show("Please select the guest's country.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(checkin_txtbx.Text) Then
            MessageBox.Show("Please enter the check-in date.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(checkout_txtbx.Text) Then
            MessageBox.Show("Please enter the check-out date.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(contact_txtbx.Text) Then
            MessageBox.Show("Please enter the contact number.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if the contact number is exactly 10 digits
        If contact_txtbx.Text.Length <> 10 OrElse Not IsNumeric(contact_txtbx.Text) Then
            MessageBox.Show("Contact number must be exactly 10 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Add code here to handle the editing of the guest details
        MessageBox.Show("Guest details can be edited now.", "Edit Guest", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Dispose()
        End
    End Sub

    Private Sub gfirstname_txtbx_TextChanged(sender As Object, e As EventArgs) Handles gfirstname_txtbx.TextChanged
    End Sub

    Private Sub glastname_txtbx_TextChanged(sender As Object, e As EventArgs) Handles glastname_txtbx.TextChanged

    End Sub

    Private Sub cmbbx_genderG_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbx_genderG.SelectedIndexChanged

    End Sub

    Private Sub GuestID_txtbx_TextChanged(sender As Object, e As EventArgs) Handles GuestID_txtbx.TextChanged

    End Sub

    Private Sub Gemail_txtbx_TextChanged(sender As Object, e As EventArgs) Handles Gemail_txtbx.TextChanged

    End Sub

    Private Sub Country_cmbbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Country_cmbbx.SelectedIndexChanged

    End Sub

    Private Sub checkin_txtbx_TextChanged(sender As Object, e As EventArgs) Handles checkin_txtbx.TextChanged

    End Sub

    Private Sub checkout_txtbx_TextChanged(sender As Object, e As EventArgs) Handles checkout_txtbx.TextChanged

    End Sub

    Private Sub contact_txtbx_TextChanged(sender As Object, e As EventArgs) Handles contact_txtbx.TextChanged

    End Sub

    Private Sub ViewGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
