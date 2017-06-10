Imports System
Imports System.Collections.Generic
Imports System.Net
Imports System.Runtime.InteropServices

Public NotInheritable Class NetworkBrowser

    Public Shared Function NetworkComputers() As List(Of String)
        Const MAX_PREFERRED_LENGTH As Integer = -1
        Const SV_TYPE_WORKSTATION As Integer = 1
        Const SV_TYPE_SERVER As Integer = 2
        Dim netComputers As New List(Of String)()
        Dim buffer As IntPtr = IntPtr.Zero
        Dim tmpBuffer As IntPtr = IntPtr.Zero
        Dim sizeofINFO As Integer = Marshal.SizeOf(GetType(SERVER_INFO_100))
        Dim entriesRead As Integer = 0
        Dim totalEntries As Integer = 0
        Dim resHandle As Integer = 0

        Try
            Dim ret As Integer = Win32.NetServerEnum(Nothing, 100, buffer, MAX_PREFERRED_LENGTH, entriesRead, totalEntries, _
              SV_TYPE_WORKSTATION Or SV_TYPE_SERVER, Nothing, resHandle)
            If ret = 0 Then
                Dim i As Integer = 0
                While i < totalEntries
                    tmpBuffer = New IntPtr(DirectCast(CInt(buffer), Integer) + (i * sizeofINFO))
                    Dim svrInfo As SERVER_INFO_100 = DirectCast(Marshal.PtrToStructure(tmpBuffer, GetType(SERVER_INFO_100)), SERVER_INFO_100)
                    netComputers.Add(svrInfo.sv100_name.ToUpper())
                    System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
                End While
            End If
        Finally
            Win32.NetApiBufferFree(buffer)
        End Try
        Return netComputers
    End Function

    Public Shared ReadOnly Property ComputersConnected() As Boolean
        Get
            Try
                Dim computerName As String = Dns.GetHostEntry(Dns.GetHostName()).HostName.ToUpper()
                Dim computersName As List(Of String) = NetworkComputers()
                computersName.Remove(computerName)
                Return computersName.Count > 0
            Catch ex As Exception
                Return 0
            End Try
        End Get
    End Property

    Private Declare Function IsNetworkAlive Lib "SENSAPI.DLL" (ByRef lpdwFlags As Long) As Long
    Const NETWORK_ALIVE_AOL = &H4
    Const NETWORK_ALIVE_LAN = &H1
    Const NETWORK_ALIVE_WAN = &H2

    Public Shared Function NetAvaiable() As Boolean
        Dim Ret As Long
        Try

            If Ret = NETWORK_ALIVE_WAN Then Return True

        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class

