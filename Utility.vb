
Module Utility

    Public Sub LoadForm(form As Form, container As Control)
            ' Check if the container already has a form loaded
            If container.Controls.Count > 0 Then
                Dim existingForm As Form = TryCast(container.Controls(0), Form)
                If existingForm IsNot Nothing Then
                    existingForm.Close()
                    existingForm.Dispose()
                End If
                container.Controls.RemoveAt(0) ' Remove the existing form
            End If

            form.TopLevel = False
            form.FormBorderStyle = FormBorderStyle.None
            form.Dock = DockStyle.Fill
            container.Controls.Add(form)
            form.Show()
        End Sub



End Module
