Imports System
Imports System.Threading
Imports System.Net.Sockets
Imports System.IO
Imports System.Text

Public Class WinSockServer

    Private Structure ClientInfo

        Public Socket As Socket

        Public Thread As Thread

        Public LastData As String

    End Structure

    Private mFirstMessage As String

    Private LocalHost As String = System.Net.Dns.GetHostName

    Private LocalAddresses() As Net.IPAddress = System.Net.Dns.GetHostAddresses(LocalHost)

    Private LocalIP As System.Net.IPAddress = LocalAddresses(0)

    Private tcpLsn As TcpListener

    Private Clients As New Hashtable()

    Private tcpThd As Thread

    Private IDActualClient As Net.IPEndPoint

    Private mLstPort As String


    Public Event NewConnection(ByVal IDTerminal As Net.IPEndPoint)

    Public Event ReceiptData(ByVal IDTerminal As Net.IPEndPoint)

    Public Event ConnectionTerminated(ByVal IDTerminal As Net.IPEndPoint)

    Property LstPort() As String
        Get
            LstPort = mLstPort
        End Get
        Set(ByVal Value As String)
            mLstPort = Value
        End Set
    End Property

    Public Sub Listen()

        tcpLsn = New TcpListener(LocalIP, mLstPort)

        tcpLsn.Start()

        tcpThd = New Thread(AddressOf WaitForClient)

        tcpThd.Start()

    End Sub

    Public Function GetData(ByVal IDClient As Net.IPEndPoint) As String

        Dim ClientInfo As ClientInfo

        ClientInfo = Clients(IDClient)

        Return ClientInfo.LastData

    End Function

    Public Sub Close(ByVal IDClient As Net.IPEndPoint)

        Dim ClientInfo As ClientInfo

        ClientInfo = Clients(IDClient)

        ClientInfo.Socket.Close()

    End Sub

    Public Sub Close()

        Dim ClientInfo As ClientInfo

        For Each ClientInfo In Clients.Values

            Close(ClientInfo.Socket.RemoteEndPoint)

        Next

    End Sub

    Public Sub SendData(ByVal IDClient As Net.IPEndPoint, ByVal Data As String)

        Dim ClientInfo As ClientInfo

        ClientInfo = Clients(IDClient)

        ClientInfo.Socket.Send(Encoding.ASCII.GetBytes(Data))

    End Sub

    Public Sub SendData(ByVal Datos As String)

        For Each ClientInfo In Clients.Values

            SendData(ClientInfo.Socket.RemoteEndPoint, Datos)

        Next

    End Sub

    Private Sub WaitForClient()

        Dim ActualClientInfo As ClientInfo = Nothing

        With ActualClientInfo

            While True

                .Socket = tcpLsn.AcceptSocket()

                IDActualClient = .Socket.RemoteEndPoint

                .Thread = New Thread(AddressOf ReadSocket)

                SyncLock Me

                    Clients.Add(IDActualClient, ActualClientInfo)

                End SyncLock

                If mFirstMessage <> "" Then .Socket.Send(Encoding.ASCII.GetBytes(mFirstMessage))

                RaiseEvent NewConnection(IDActualClient)

                .Thread.Start()

            End While

        End With

    End Sub

    Private Sub ReadSocket()

        Dim IDReal As Net.IPEndPoint

        Dim DataByte() As Byte

        Dim ActualClientInfo As ClientInfo

        Dim Ret As Integer = 0

        IDReal = IDActualClient

        ActualClientInfo = Clients(IDReal)

        With ActualClientInfo

            While True

                If .Socket.Connected Then

                    DataByte = New Byte(10000) {}

                    Try

                        Ret = .Socket.Receive(DataByte, DataByte.Length, SocketFlags.None)

                        If Ret > 0 Then

                            .LastData = Encoding.ASCII.GetString(DataByte)

                            Clients(IDReal) = ActualClientInfo

                            RaiseEvent ReceiptData(IDReal)

                        Else

                            RaiseEvent ConnectionTerminated(IDReal)

                            Exit While

                        End If

                    Catch ex As Exception

                        If Not .Socket.Connected Then

                            RaiseEvent ConnectionTerminated(IDReal)

                            Exit While

                        End If

                    End Try

                End If

            End While

            Call CloseThread(IDReal)

        End With

    End Sub

    Private Sub CloseThread(ByVal IDCliente As Net.IPEndPoint)

        Dim ActualClientInfo As ClientInfo

        ActualClientInfo = Clients(IDCliente)

        Try

            ActualClientInfo.Thread.Abort()

        Catch e As Exception

            SyncLock Me

                If Clients IsNot Nothing Then Clients.Remove(IDCliente)

            End SyncLock

        End Try

    End Sub


    Public Sub Terminate()

        Try

            tcpThd.Abort()

            tcpLsn.Stop()

            Clients.Clear()

        Catch ex As Exception
            ex = Nothing

        Finally
            LocalHost = Nothing

            LocalAddresses = Nothing

            LocalIP = Nothing

            tcpLsn = Nothing

            Clients = Nothing

            tcpThd = Nothing

            IDActualClient = Nothing

            mLstPort = Nothing

        End Try


    End Sub

    Public Sub New()

    End Sub


    Public Sub New(ByVal message As String)
        mFirstMessage = message
    End Sub

    Public Property FirstMessage() As String
        Get
            Return mFirstMessage
        End Get
        Set(ByVal value As String)
            mFirstMessage = value
        End Set
    End Property

End Class
