Public Class AppMgr

    Private Shared WithEvents Socket As Domain.WinSockClient
    Private Shared Parameters() As String
    Private Shared Counter As Integer
    Private Shared WithEvents frmmain As frmMain
    Private Shared ServerParameters As String


    <STAThread()> _
    Public Shared Sub Main()

        Try

            frmError = New frmException

            If Not ValidateServer() Then
                MsgBox("Error en la validación de parámetros de Conexión." & vbNewLine & "El sistema finalizará", MsgBoxStyle.Critical)
                ShutDown()
                Exit Try
            End If

            Do While Domain.SystemCompany Is Nothing Or Counter < 100000
                Application.DoEvents()
                Counter = Counter + 1
            Loop

            If Domain.SystemCompany Is Nothing Then Throw New Exception("Error al inicializar la aplicación")

            If Domain.MainCompany Is Nothing Then Throw New Exception("Error al inicializar la aplicación")

            'If Domain.SystemLicence Is Nothing Then Throw New Exception("No se encontró la información de la licencia")

            If Domain.SmtpServer Is Nothing Then Throw New Exception("No se pudo inicializar el cliente de correo")

            If Domain.SystemEntities Is Nothing Then Throw New Exception("Error al inicializar las entidades de la aplicación")

            If Domain.SysObjectProperties Is Nothing Then Throw New Exception("Error al inicializar las entidades de la aplicación")

            If Domain.NetworkBrowser.NetAvaiable Then

                If Not Domain.SmtpServer.TestServer Then Throw New Exception("No se pudo inicializar el cliente de correo")
            Else
                ' Domain.SmtpServer.TestServer()
                ' Domain.SmtpServer.SendMail("primogenia@gmail.com", "Prueba de Crm 2x4", "Aqui body")

            End If

            'If Not Domain.Tango.ValidateKey Then
            '    ShutDown()
            '    Exit Try
            'End If

            If Not ValidateFolders() Then
                ShutDown()
                Exit Try
            End If

            Application.EnableVisualStyles()

            If Not ValidateUser() Then
                ShutDown()
                Exit Try
            End If

            If Not SelectCompany(Domain.SystemUser) Then
                MessageBox.Show("Error en la conexion a la base de Datos. Por favor revise los parámetros de configuración")
                ShutDown()
                Exit Try
            End If

            ' MsgBox("NewVersion 1.1", MsgBoxStyle.Information)
            frmmain = New frmMain()
            Application.Run(frmmain)

        Catch ex As Exception
            frmError.ShowException(ex, True, False)
            ShutDown()
        Finally
            frmError = Nothing
        End Try

    End Sub


    Private Shared Function ShutDown() As Boolean

        Try
            Socket.Terminate()

            Socket = Nothing



        Catch ex As Exception
            ex = Nothing

        Finally
            Application.Exit()
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
            Throw New Exception("No se pudo establecer la comunicación con el servidor de accesos" & vbCr & ex.ToString)

        End Try

    End Function

    Private Shared Function ValidateFolders() As Boolean

        Dim folder As System.IO.DirectoryInfo

        Try

            folder = New System.IO.DirectoryInfo(Application.UserAppDataPath)

            If folder.Exists Then
                folder = New System.IO.DirectoryInfo(Application.UserAppDataPath & "\Favoritos\")

                If folder.Exists Then
                    Return True
                Else
                    folder.Create()
                    Return True
                End If

            End If

        Catch ex As Exception
            Throw New Exception("Ocurrió un error al verificar a las carpetas de sistema." & vbCr & ex.ToString)
        End Try

    End Function

    Private Shared Function SelectCompany(ByVal User As Domain.User) As Boolean
        Dim Companies As frmCompanies

        Try
            Companies = New frmCompanies(User, Domain.CompanyRepository.GetByUser(User.Id))

            If Companies.ShowDialog = DialogResult.OK Then
                Domain.MainCompany = Companies.SelectedCompany
                Domain.SystemUser.Profile = Domain.ProfileRepository.GetByUser(Domain.SystemUser.Id, Domain.MainCompany.Id)
                Domain.SystemUser.FullDomain = Domain.ProfileRepository.FullUser(Domain.MainCompany.Id, Domain.SystemUser.Id, Domain.SystemUser.Profile.Id)
                Domain.SystemUser.ProfileOwner = Domain.ProfileRepository.ProfileOwner(Domain.MainCompany.Id, Domain.SystemUser.Id, Domain.SystemUser.Profile.Id)
                Return Domain.CompanyRepository.Validate(Domain.MainCompany)
            Else
                Return False
            End If

        Catch ex As Exception
            Throw New Exception("Ocurrió un error al recuperar la información de la empresa." & vbCrLf & ex.ToString)
        End Try

    End Function

    Private Shared Function SetParameters(ByVal Data As String) As Boolean

        Try

            If Data.StartsWith("Parameters: Invalid") Then Throw New Exception("El servidor de accesos no se encuentra correctamente configurado")

            If ServerParameters = Data Then Return True

            ServerParameters = Data

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

            If Login.ShowDialog = DialogResult.OK Then
                My.Settings.LastUser = Domain.SystemUser.NickName
                My.Settings.Save()
                Return True
            End If

        Catch ex As Exception
            Throw New Exception("Ocurrió un error al verificar el usuario." & vbCr & ex.ToString)
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

            If Data.StartsWith("Error: ") Then
                MsgBox(Data, MsgBoxStyle.Critical, "CRM 2x4")
                Throw New Exception()
            End If

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
