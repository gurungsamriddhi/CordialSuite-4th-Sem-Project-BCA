Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class SQLcontrol
    Public SQLCon As New SqlConnection With
    {.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CordialSuiteDB.mdf;"}
    Public SQLCmd As SqlCommand
    Public Function Hasconnection() As Boolean
        Try
            SQLCon.Open()
            SQLCon.Close()
            MsgBox("Hell world inside")


            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try
    End Function
End Class
