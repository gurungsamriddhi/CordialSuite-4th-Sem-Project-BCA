Public Class Viewemployee
    Private Sub efirstname_txtbx_TextChanged(sender As Object, e As EventArgs) Handles efirstname_txtbx.TextChanged

    End Sub

    Private Sub elastname_txtbx_TextChanged(sender As Object, e As EventArgs) Handles elastname_txtbx.TextChanged

    End Sub

    Private Sub cmbbx_gendere_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbx_gendere.SelectedIndexChanged

    End Sub

    Private Sub EmployeeiD_txtbx_TextChanged(sender As Object, e As EventArgs) Handles EmployeeiD_txtbx.TextChanged

    End Sub

    Private Sub Eemail_txtbx_TextChanged(sender As Object, e As EventArgs) Handles Eemail_txtbx.TextChanged

    End Sub

    Private Sub AddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles AddressTextBox.TextChanged

    End Sub

    Private Sub job_txtbx_TextChanged(sender As Object, e As EventArgs) Handles job_txtbx.TextChanged

    End Sub

    Private Sub salary_txtbx_TextChanged(sender As Object, e As EventArgs) Handles salary_txtbx.TextChanged

    End Sub

    Private Sub Econtact_txtbx_TextChanged(sender As Object, e As EventArgs) Handles Econtact_txtbx.TextChanged

    End Sub

    Private Sub editEMP_btn_Click(sender As Object, e As EventArgs) Handles editEMP_btn.Click
        ' Check if all fields are empty
        If String.IsNullOrWhiteSpace(efirstname_txtbx.Text) AndAlso
           String.IsNullOrWhiteSpace(elastname_txtbx.Text) AndAlso
           String.IsNullOrWhiteSpace(EmployeeiD_txtbx.Text) AndAlso
           String.IsNullOrWhiteSpace(Eemail_txtbx.Text) AndAlso
           cmbbx_gendere.SelectedIndex = -1 AndAlso
           String.IsNullOrWhiteSpace(AddressTextBox.Text) AndAlso
           String.IsNullOrWhiteSpace(job_txtbx.Text) AndAlso
           String.IsNullOrWhiteSpace(salary_txtbx.Text) AndAlso
           String.IsNullOrWhiteSpace(Econtact_txtbx.Text) Then

            MessageBox.Show("Please fill in all necessary details.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if any necessary details are missing
        If String.IsNullOrWhiteSpace(efirstname_txtbx.Text) Then
            MessageBox.Show("Please enter the employee's first name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(elastname_txtbx.Text) Then
            MessageBox.Show("Please enter the employee's last name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(EmployeeiD_txtbx.Text) Then
            MessageBox.Show("Please enter the employee's ID.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(Eemail_txtbx.Text) Then
            MessageBox.Show("Please enter the employee's email.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbbx_gendere.SelectedIndex = -1 Then
            MessageBox.Show("Please select the employee's gender.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(AddressTextBox.Text) Then
            MessageBox.Show("Please enter the employee's address.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(job_txtbx.Text) Then
            MessageBox.Show("Please enter the employee's job title.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(salary_txtbx.Text) Then
            MessageBox.Show("Please enter the employee's salary.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(Econtact_txtbx.Text) Then
            MessageBox.Show("Please enter the employee's contact number.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if the contact number is exactly 10 digits
        If Econtact_txtbx.Text.Length <> 10 OrElse Not IsNumeric(Econtact_txtbx.Text) Then
            MessageBox.Show("Contact number must be exactly 10 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Add code here to handle the editing of the employee details
        MessageBox.Show("Employee details can be edited now.", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Dispose()
        End
    End Sub
End Class
