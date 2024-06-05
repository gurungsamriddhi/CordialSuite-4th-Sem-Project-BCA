Imports System.Data.SqlClient
Public Class Newguestform
    'Dim con As New sqlconnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\uSer\OneDrive\Documents\CordialSuiteDB.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub newguestbtn_Click(sender As Object, e As EventArgs) Handles newguestbtn.Click

    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
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