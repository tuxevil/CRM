Friend Class AppMgr

    Public Shared WithEvents frmException As frmException
    Private Shared WithEvents Socket As Domain.WinSockClient
    Private Shared Parameters() As String
    Private Shared Counter As Integer
    Private Shared WithEvents frmmain As frmMain


    <STAThread()> _
    Public Shared Sub Main()

        Try
            If Not ValidateServer() Then
                MsgBox("Error en la validación del Servidor." & vbNewLine & "Verifique el estado de los puertos de conexión" & vbNewLine & "del sistema. ", MsgBoxStyle.Critical)
                ShutDown()
                Exit Sub
            End If

            Do While Domain.SystemCompany Is Nothing Or Counter < 100000
                Application.DoEvents()
                Counter = Counter + 1
            Loop

            If Domain.SystemCompany Is Nothing Then
                ShutDown()
                Exit Sub
            End If

            Application.EnableVisualStyles()

            If Not ValidateUser() Then
                ShutDown()
                Exit Sub
            End If

            frmException = New frmException

            frmmain = New frmMain()
            Application.Run(frmmain)

        Catch ex As Exception
            ShutDown()
        End Try

    End Sub


    Private Shared Function ShutDown() As Boolean

        Try

            Socket.Terminate()

            Socket = Nothing

            Application.Exit()

        Catch ex As Exception
            ex = Nothing

        End Try

    End Function

    Private Shared Function ValidateServer() As Boolean

        Dim ServerProcesses() As Process
        Dim ServerProcess As Process

        Try

            ServerProcesses = Process.GetProcessesByName("Servidor de accesos")

            If ServerProcesses.Length = 0 Then

                ServerProcess = Process.Start("Servidor de accesos")

            Else
                ServerProcess = ServerProcesses.First

            End If

            If ServerProcess Is Nothing Then ServerProcess = Process.Start("Servidor de accesos")

            Socket = New Domain.WinSockClient(8050)

            Socket.Connect()

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Private Shared Function SetParameters(ByVal Data As String) As Boolean

        Try

            If Data.StartsWith("Parameters: Invalid") Then Throw New Exception("El servidor de accesos no se encuentra correctamente configurado")

            Data = Mid(Data, 13, 10000)
            Parameters = Split(Data, ",")

            If Not Domain.StartUp(Parameters(0), Parameters(1), Parameters(2), Parameters(3), Parameters(4), Parameters(6), Parameters(5)) Then Throw New Exception("Ocurrió un error al iniciar la comunicación con el servidor")

            Return True

        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Private Shared Function ValidateUser() As Boolean

        Dim Login As frmLogin

        Try
            Login = New frmLogin

            If Login.ShowDialog = DialogResult.OK Then Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Shared Sub Socket_ConnectionTerminated() Handles Socket.ConnectionTerminated

        Try
            ShutDown()

        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Shared Sub Socket_ReceiptData(ByVal Data As String) Handles Socket.ReceiptData

        Try

            If Data Is Nothing Then Exit Sub

            If Data = "" Then Exit Sub

            If Data.StartsWith("Parameters: ") Then SetParameters(Data)

            If Data.StartsWith("Error: ") Then Throw New Exception()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Shared Sub frmmain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles frmmain.FormClosed
        Try
            ShutDown()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
