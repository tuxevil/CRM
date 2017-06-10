Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.Text
Imports System.IO

Public Class WinSockClient

    Private Stm As Stream
    Private mHostIP As String
    Private mHostPort As String
    Private tcpClnt As TcpClient
    Private tcpThd As Thread
    Private mLastData As String

    Public Event ConnectionTerminated()
    Public Event ReceiptData(ByVal Data As String)

    Public Property HostIp() As String
        Get
            HostIp = mHostIP
        End Get
        Set(ByVal Value As String)
            mHostIP = Value
        End Set
    End Property

    Public Property HostPort() As String
        Get
            HostPort = mHostPort
        End Get
        Set(ByVal Value As String)
            mHostPort = Value
        End Set
    End Property

    Public Sub Connect()

        tcpClnt = New TcpClient()

        tcpClnt.Connect(mHostIP, mHostPort)

        Stm = tcpClnt.GetStream()

        tcpThd = New Thread(AddressOf ReadSocket)

        tcpThd.Start()

    End Sub


    Public Sub SendData(ByVal Datos As String)

        Dim WriteBuffer() As Byte

        WriteBuffer = Encoding.ASCII.GetBytes(Datos)

        If Not (Stm Is Nothing) Then

            Stm.Write(WriteBuffer, 0, WriteBuffer.Length)

        End If

    End Sub

    Private Sub ReadSocket()
        Dim Reader As String
        Dim DataStart As Integer = 0
        Dim DataEnd As Integer = 0
        Dim ReadBuffer() As Byte

        While True

            Try

                ReadBuffer = New Byte(1000) {}

                Stm.Read(ReadBuffer, 0, ReadBuffer.Length)


                Reader = Encoding.ASCII.GetString(ReadBuffer, 0, ReadBuffer.Length)

                DataStart = InStr(Reader, "<")

                DataEnd = InStr(Reader, ">")

                mLastData = Mid(Reader, DataStart + 1, DataEnd - DataStart - 1)

                RaiseEvent ReceiptData(mLastData)

            Catch ex As Exception

                Exit While

            End Try

        End While

        RaiseEvent ConnectionTerminated()

    End Sub

    Public Sub New()
    End Sub

    Public Sub New(ByVal Port As String)
        Try

            mHostIP = System.Net.Dns.GetHostName()
            mHostPort = Port
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub New(ByVal Ip As String, ByVal Port As String)
        Try
            mHostIP = Ip
            mHostPort = Port

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub Terminate()
        Try
            tcpClnt.Close()

            tcpThd.Abort()

        Catch ex As Exception
            Throw ex
        Finally

            Stm = Nothing

            tcpClnt = Nothing

            tcpThd = Nothing

        End Try
    End Sub

    Public ReadOnly Property LastData() As String
        Get
            Return mLastData
        End Get
    End Property

End Class