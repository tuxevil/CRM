Public Class frmAccessServer

    Private mStatus As Boolean

    Private WithEvents ServerTimer As Timers.Timer
    Private WithEvents SqlController As ServiceProcess.ServiceController
    Private WithEvents TangoController As ServiceProcess.ServiceController

    Private Const WM_MDIMAXIMIZE As Long = &H225


    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ExMsg As String = ""

        Try
            Me.WindowState = FormWindowState.Minimized
            Me.Visible = False
            IconTray.Icon = Me.Icon
            IconTray.Visible = True

            IconTray.ShowBalloonTip(2000, "Servidor de accesos", "El servidor de accesos se está iniciando ...", ToolTipIcon.Info)

        Catch ex As Exception
            MsgBox("Error al intentar procesar la instrucción." & vbCrLf & "Detail: " & ex.Message, MsgBoxStyle.Critical, "Informe de errores")
            ex = Nothing

        End Try

        Try

            WinSockHandler.StartServer(ServerMessage(0))

            Database = New SqlData

            RunVerification()


        Catch ex As Exception

            If ex.InnerException IsNot Nothing Then

                If ex.InnerException.Message = "Application" Then

                    ExMsg = ex.Message
                Else
                    ExMsg = "Ocurrió un error al verificar el estado del servicio" & vbCrLf & ex.Message
                End If

            Else
                ExMsg = "Ocurrió un error al verificar el estado del servicio" & vbCrLf & ex.Message
            End If

            IconTray.ShowBalloonTip(5000, "Servidor de accesos", ExMsg, ToolTipIcon.Error)

            WinSockHandler.ReStartServer(ServerMessage(2, ExMsg))

        Finally

            ServerMenuNewWindow.Enabled = mStatus

            ServerTimer = New Timers.Timer(60000)
            ServerTimer.Start()

        End Try

    End Sub

    Private Sub RunVerification()
        Dim ExMsg As String = ""

        Try
            mStatus = False

            If Not ValidateSettings() Then Throw New Exception("El servidor de accesos no se encuentra correctamente configurado." & vbCr & "Por favor verifique los parámetros e inténtelo nuevamente", New Exception("Application"))

            SqlController = New ServiceProcess.ServiceController(My.Settings.SqlService)

            If SqlController Is Nothing Then Throw New Exception("El servidor de accesos no se encuentra correctamente configurado." & vbCr & "Por favor verifique el nombre del servicio SQL e inténtelo nuevamente")

            If SqlController.Status <> ServiceProcess.ServiceControllerStatus.Running Then Throw New Exception("El servicio SQL no está ejecutandose correctamente." & vbCr & "Por favor verifiquelo e inténtelo nuevamente")

            TangoController = New ServiceProcess.ServiceController(My.Settings.TangoService)

            If TangoController Is Nothing Then Throw New Exception("El servicio de Tango no se encuentra correctamente configurado." & vbCr & "Por favor verifique el nombre del servicio e inténtelo nuevamente")

            If TangoController.Status <> ServiceProcess.ServiceControllerStatus.Running Then Throw New Exception("El servicio de Tango no está ejecutandose correctamente." & vbCr & "Por favor verifiquelo e inténtelo nuevamente")

            If Database.State <> ConnectionState.Closed Then Database.CloseDb()

            If Database.TestConnection(My.Settings.ServerInstance, My.Settings.ServerUser, My.Settings.ServerPassword) = False Then Throw New Exception("No se puede conectar al servidor de datos." & vbCr & "Por favor verifiquelo e inténtelo nuevamente")

            Database.CnnString = "Server=" & My.Settings.ServerInstance & ";Database=master;User ID=" & My.Settings.ServerUser & ";Password=" & My.Settings.ServerPassword & ";Trusted_Connection=False;Application Name='CRM 2x4'"

            Database.OpenDb()

            If Database.State <> ConnectionState.Open Then Database.OpenDb()

            mStatus = True

            IconTray.Icon = My.Resources.Icon

            WinSockHandler.ReStartServer(ServerMessage(1))

        Catch ex As Exception

            If ex.InnerException IsNot Nothing Then

                If ex.InnerException.Message = "Application" Then

                    ExMsg = ex.Message
                Else
                    ExMsg = "Ocurrió un error al verificar el estado del servicio" & vbCrLf & ex.Message
                End If

            Else
                ExMsg = "Ocurrió un error al verificar el estado del servicio" & vbCrLf & ex.Message
            End If

            IconTray.Icon = My.Resources.IconError

            IconTray.ShowBalloonTip(5000, "Servidor de accesos", ExMsg, ToolTipIcon.Error)

            WinSockHandler.ReStartServer(ServerMessage(2, ExMsg))

        End Try

    End Sub

    Public Function ValidateSettings() As Boolean

        Try

            If My.Settings.ServerName = "" Then Return False
            If My.Settings.ServerInstance = "" Then Return False
            If My.Settings.ServerUser = "" Then Return False
            If My.Settings.DbDictionary = "" Then Return False
            If My.Settings.DbOwner = "" Then Return False
            If My.Settings.SqlService = "" Then Return False
            If My.Settings.TangoService = "" Then Return False

            Return True

        Catch ex As Exception
            Throw New Exception("Ocurrió un error al verificar los parámetros de configuración del servicio" & vbCrLf & ex.Message)
        End Try

    End Function

    Private Sub ServerTimer_Elapsed(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs) Handles ServerTimer.Elapsed
        Dim ExMsg As String = ""

        Try

            RunVerification()

        Catch ex As Exception


            If ex.InnerException IsNot Nothing Then

                If ex.InnerException.Message = "Application" Then

                    ExMsg = ex.Message
                Else
                    ExMsg = "Ocurrió un error al verificar el estado del servicio" & vbCrLf & ex.Message
                End If

            Else
                ExMsg = "Ocurrió un error al verificar el estado del servicio" & vbCrLf & ex.Message

            End If

            IconTray.ShowBalloonTip(5000, "Servidor de accesos", ExMsg, ToolTipIcon.Error)

            WinSockHandler.ReStartServer(ServerMessage(2, ExMsg))


        End Try

    End Sub

    Private Sub ServerConfig(ByVal sender As Object, ByVal e As System.EventArgs) Handles ServerMenuConfig.Click
        Dim frmConfig As frmServerConfig

        Try

            If UserWindows.Length > 0 Then
                MsgBox("Debe cerrar todas las ventanas antes de configurar la estación de trabajo", MsgBoxStyle.Information, "Servidor de accesos")
                Exit Try
            End If

            frmConfig = New frmServerConfig
            If frmConfig.ShowDialog() <> DialogResult.OK Then Exit Try

            My.Settings.Reload()

            WinSockHandler.ReStartServer(ServerMessage(1))

            RunVerification()

            ServerMenuNewWindow.Enabled = mStatus

        Catch ex As Exception
            IconTray.ShowBalloonTip(500, "Servidor de accesos", "Ocurrió un error inesperado" & vbCrLf & ex.Message, ToolTipIcon.Error)
        End Try
    End Sub

    Private Sub ServerExit(ByVal sender As Object, ByVal e As System.EventArgs) Handles ServerMenuExit.Click

        Try

            If ServerMenuWindows.Visible Then

                If MsgBox("Todas las ventanas abiertas se cerrarán. " & vbCrLf & "Desea continuar? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Servidor de accesos") = MsgBoxResult.No Then Exit Try

            End If

            CloseWindows(Nothing, System.EventArgs.Empty)

            Database.CloseDb()

            Database = Nothing

            ServerTimer = Nothing

            SqlController = Nothing

            TangoController = Nothing

            WinSockHandler.StopServer()

            Me.Close()

        Catch ex As Exception
            IconTray.ShowBalloonTip(500, "Servidor de accesos", "Ocurrió un error al detener el servicio" & vbCrLf & ex.Message, ToolTipIcon.Error)
        End Try

    End Sub

    Private Sub ServerNewWindow(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServerMenuNewWindow.Click
        Try

            OpenNewWindow()

        Catch ex As Exception
            IconTray.ShowBalloonTip(500, "Servidor de accesos", "Ocurrió un error al detener el servicio" & vbCrLf & ex.Message, Windows.Forms.ToolTipIcon.Error)
        End Try

    End Sub

    Private Sub IconTray_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles IconTray.MouseDoubleClick
        Try

            If ServerMenuNewWindow.Enabled Then OpenNewWindow()

        Catch ex As Exception
            IconTray.ShowBalloonTip(500, "Servidor de accesos", "Ocurrió un error al detener el servicio" & vbCrLf & ex.Message, Windows.Forms.ToolTipIcon.Error)
        End Try

    End Sub

    Private Sub OpenNewWindow()
        Dim Window As Process
        Dim Args As String

        Try
            Args = My.Settings.ServerInstance & " " & My.Settings.ServerUser & " " & My.Settings.ServerPassword & " " & My.Settings.DbDictionary & " " & " " & " " & My.Settings.DbOwner & " " & My.Settings.DefaultDatabase

            Window = Process.Start(UserProcess, Args)
            IconTray.ShowBalloonTip(500, "Servidor de accesos", "Conexión establecida bd:" & vbTab & My.Settings.DefaultDatabase, Windows.Forms.ToolTipIcon.Info)

        Catch ex As Exception
            IconTray.ShowBalloonTip(500, "Servidor de accesos", "Ocurrió un error al detener el servicio" & vbCrLf & ex.Message, Windows.Forms.ToolTipIcon.Error)
        End Try

    End Sub

    Private Function UserWindows() As Process()
        Try

            Return Process.GetProcessesByName(UserProcess)

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Sub CloseWindows(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServerMenuCloseWindows.Click
        Dim Windows() As Process

        Try
            Windows = UserWindows()

            If Windows.Length > 0 Then

                If MsgBox("Todas las ventanas del CRM se cerrarán. Desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Servidor de accesos") <> MsgBoxResult.Yes Then Exit Try

            End If

            For Each window As Process In Windows

                window.Kill()

            Next

        Catch ex As Exception
            IconTray.ShowBalloonTip(500, "Servidor de accesos", "Ocurrió un error al detener el servicio" & vbCrLf & ex.Message, ToolTipIcon.Error)
        End Try

    End Sub

    Private Sub DrawMenu(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ServerMenu.Opening
        Dim Windows() As Process
        Dim WindowMenu As ToolStripMenuItem

        Try

            If mStatus = True Then
                Windows = UserWindows()

                If UserWindows.Length <= 0 Then
                    ServerMenuCloseWindows.Visible = False
                    ServerMenuWindows.Visible = False
                    Exit Try

                End If

                ServerMenuCloseWindows.Visible = True
                ServerMenuWindows.Visible = True

                ServerMenuWindows.DropDownItems.Clear()

                For Each Window As Process In Windows

                    WindowMenu = ServerMenuWindows.DropDownItems.Add(Window.MainWindowTitle, Nothing, AddressOf WindowMenuClick)
                    WindowMenu.Tag = Window.Id

                Next

            Else
                ServerMenuNewWindow.Enabled = False
                ServerMenuCloseWindows.Visible = False
                ServerMenuWindows.Visible = False

            End If

        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub WindowMenuClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            AppActivate(sender.text)

        Catch ex As Exception
            IconTray.ShowBalloonTip(500, "Servidor de accesos", "Ocurrió un error al detener el servicio" & vbCrLf & ex.Message, ToolTipIcon.Error)
        End Try

    End Sub

    Private Function ServerMessage(ByVal MessageType As Integer, Optional ByVal messageText As String = "") As String
        Try

            Select Case MessageType
                Case 0 : Return ""
                Case 1 : Return "<Parameters: " & My.Settings.ServerInstance & ", " & My.Settings.ServerInstance & ", " & My.Settings.ServerUser & ", " & My.Settings.ServerPassword & ", " & My.Settings.DbDictionary & ", " & My.Settings.DbOwner & ", " & My.Settings.DefaultDatabase & ">"
                Case 2 : Return "<Error: " & messageText & ">"
            End Select

            Return ""

        Catch ex As Exception
            Return ""
        End Try

    End Function

End Class