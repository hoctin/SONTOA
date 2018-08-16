Imports System.IO

Module Log
    Public Function logerrors(ByVal [error] As String)
        Dim filename As String = "Log_" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt"

        Dim filepath As String = "E:\Quan ly can\Sys Log\" & filename

        If File.Exists(filepath) Then
            Using stwriter As New StreamWriter(filepath, True)
                stwriter.WriteLine("-------------------START-------------" + DateTime.Now)
                stwriter.WriteLine(Convert.ToString("Page :"))
                stwriter.WriteLine([error])
                stwriter.WriteLine("-------------------END-------------" + DateTime.Now)
                stwriter.Close()
            End Using
        Else
            Dim stwriter As StreamWriter = File.CreateText(filepath)
            stwriter.WriteLine("-------------------START-------------" + DateTime.Now)
            stwriter.WriteLine(Convert.ToString("Page :"))
            stwriter.WriteLine([error])
            stwriter.WriteLine("-------------------END-------------" + DateTime.Now)
            stwriter.Close()
        End If
        Return [error]
    End Function

End Module
