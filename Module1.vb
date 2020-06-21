Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Module Module1
    Public conhi As New SqlConnection
    Public comhi As New SqlCommand
    '
    'DB DATA
    Public odahi As New SqlDataAdapter
    Public odthi As New DataTable
    '

    Public odrhi As SqlDataReader
    Public odshi As New DataSet
    Public str As String
    Public strcon As String
    Public builderhi As SqlCommandBuilder
End Module
