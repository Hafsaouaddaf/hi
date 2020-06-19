Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strcon = "Data Source=DESKTOP-CCQJNK1;Initial Catalog=H_I ;Integrated Security=True"
        comhi = New SqlCommand(str)
        conhi = New SqlConnection
        conhi.ConnectionString = strcon
        conhi.Open()
        If conhi.State = ConnectionState.Open Then
            MsgBox("Vous  êtes  connectés", 0 + 64, "connecté")
        End If
        odahi = New SqlDataAdapter(comhi)
        comhi.Connection = conhi
    End Sub
End Class
