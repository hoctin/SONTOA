Imports System.Data.OleDb
Module Common
    Private strcon As String = "Provider = Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & "E:\Quan ly can\Sys\Data.mdb"
    Dim tables As DataTableCollection
    Public ds As DataSet
    Public da As OleDbDataAdapter
    Public con As OleDbConnection
    Public value As String = ""
    Public value1 As String = ""
    Public timeFrom As Date
    Public timeTo As Date
    Public flag As Boolean = True
    Public hangton As Boolean = False
    Public Sub connectdb()
        Try
            con = New OleDb.OleDbConnection(strcon)
            con.Open()
        Catch ex As Exception
            logerrors(ex.ToString)
        End Try
    End Sub
    Public Sub disconnectdb()
        Try
            If con.State = ConnectionState.Open Then
                con.Dispose()
            End If
        Catch ex As Exception
            logerrors(ex.ToString)
        End Try
    End Sub

End Module
