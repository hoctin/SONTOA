Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel
Imports System.IO

Public Class dataReceivedEventArgs
    Inherits EventArgs
    Private m_StringData As String

    Public Sub New(strData As String)
        Me.m_StringData = strData
    End Sub

    Public ReadOnly Property ReceivedData As String
        Get
            Return m_StringData
        End Get
    End Property

    Public ReadOnly Property value1 As String
        Get
            Return m_StringData
        End Get
    End Property
End Class

Public Class mySerial
    Private ReadThread As Thread
    Dim SPort As SerialPort
    Private syncContext As SynchronizationContext
    Public Event DataReceived(Sender As Object, ByVal e As dataReceivedEventArgs)

    Public Sub New(ByVal COMMPORT As String, ByVal BaudRate As Integer)
        Me.New(COMMPORT, BaudRate, Parity.None, 8, StopBits.One)
    End Sub

    Public Sub New(ByVal _COMMPORT As String, ByVal _BaudRate As Integer, ByVal _Parity As Parity, ByVal _DataBits As Integer, ByVal _StopBits As StopBits)
        SPort = New SerialPort
        With SPort
            .PortName = _COMMPORT
            .BaudRate = _BaudRate
            .Parity = _Parity
            .DataBits = _DataBits
            .StopBits = _StopBits
            .Handshake = Handshake.XOnXOff
            .DtrEnable = True
            .RtsEnable = True
            .NewLine = vbCrLf
        End With
        Me.syncContext = AsyncOperationManager.SynchronizationContext
        ReadThread = New Thread(AddressOf ReadPort)
    End Sub

    Public Sub OpenPort()
        If Not SPort.IsOpen Then
            Try
                SPort.Open()
                SPort.DiscardNull = True
                SPort.Encoding = System.Text.Encoding.ASCII
                ReadThread.Start()
            Catch ex As Exception
                logerrors(ex.ToString)
                MessageBox.Show("Không Tìm thấy cổng COM", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End If
    End Sub

    Public Sub ClosePort()
        Try
            If SPort.IsOpen Then
                'Thread.Sleep(100)
                'SPort.DiscardInBuffer()
                ReadThread.Abort()
                SPort.Close()
            End If
        Catch ex As Exception
            logerrors(ex.ToString)
        End Try
    End Sub
    Private Sub ReadPort()
        Do While SPort.IsOpen
            Dim ReceviceData As String = String.Empty
            Do While SPort.BytesToRead <> 0 And SPort.IsOpen And ReceviceData.Length < 5000
                Try
                    ReceviceData &= SPort.ReadExisting()
                    Thread.Sleep(10)
                Catch ex As Exception
                End Try
            Loop
            Dim temp As String = ReceviceData
            Dim temp1 As String = Trim(Mid(temp, 4, 7))
            If ReceviceData <> String.Empty And value1 <> temp1 And Integer.TryParse(temp1, New Integer()) Then
                value1 = temp1
                'raise event and provide data
                syncContext.Post(New SendOrPostCallback(AddressOf onDataReceived), value1)
            End If
            Thread.Sleep(50)
        Loop
    End Sub

    Private Sub onDataReceived(ByVal value1 As String)
        RaiseEvent DataReceived(Me, New dataReceivedEventArgs(value1))
    End Sub
End Class