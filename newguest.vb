Imports System.Data.SqlClient
<<<<<<< HEAD
Public Class Newguestform
=======



Public Class Newguest_form
>>>>>>> master
    'Dim con As New sqlconnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\uSer\OneDrive\Documents\CordialSuiteDB.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Newguestbtn_Click(sender As Object, e As EventArgs) Handles addnewguest_btn.Click

    End Sub

    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Dispose()
        End

    End Sub

    Private Sub gfirstnametxtbx_TextChanged(sender As Object, e As EventArgs) Handles gfirstnametxtbx.TextChanged

    End Sub

    Private Sub glastnametxtbx_TextChanged(sender As Object, e As EventArgs) Handles glastnametxtbx.TextChanged

    End Sub

    Private Sub combobxgender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobxgender.SelectedIndexChanged

    End Sub
End Class