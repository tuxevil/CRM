Imports System
Imports System.Threading
Imports System.Net.Sockets
Imports System.IO
Imports System.Text

Public Class WinSockHandler


    Private Shared WithEvents Socket As WinSockServer

    Public Shared Function StartServer(ByVal message As String)

        Try

            Socket = New WinSockServer(message)

            Socket.LstPort = 8050

            Socket.Listen()

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function ReStartServer(ByVal message As String) As Boolean

        Try
            Socket.FirstMessage = message

            Socket.SendData(message)

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Shared Function StopServer() As Boolean

        Try

            Socket.Close()

            Socket.Terminate()

            Socket = Nothing

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Shared Sub Socket_NewConnection(ByVal IDTerminal As System.Net.IPEndPoint) Handles Socket.NewConnection
        Try



        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Shared Sub Socket_ReceiptData(ByVal IDTerminal As System.Net.IPEndPoint) Handles Socket.ReceiptData

        'Dim Data As String = ""
        'Dim Response As String = ""

        'Try

        '    Data = Socket.GetData(IDTerminal)

        '    If Request.Contains(Data) Then Response = Request(Data).ToString

        '    If Response <> "" Then Socket.SendData(IDTerminal, Response)

        'Catch ex As Exception
        '    Throw ex
        'End Try

    End Sub
End Class
