Public Class Tango

    Private Shared tgLog As HardLockServer.LogOn
    Private Shared tgInfo As HardLockServer.LogOn


    Public Shared Function ValidateKey() As Boolean
        Dim ValidKey As String = ""

        Try

            tgInfo = CreateObject("HardLockServer.LogOn")

            ValidKey = tgInfo.GetClientAppsList(TgKey)

            Return True

        Catch ex As Exception
            Throw ex
        Finally
            tgInfo.DropInterface()
            tgInfo = Nothing
        End Try

    End Function

    Public Shared Function Login(ByVal user As String, ByVal password As String) As Boolean
        Try
            'tgLog = CreateObject("HardLockServer.LogOn")

            'Logon(TgKey, user, password)

            'If Trim(tgLog.LicenseInfo.Version) <> Trim(SystemLicence.Tango) Then Throw New Exception("La versión de Tango (" & tgLog.LicenseInfo.Version & ") no coincide con la versión del CRM")

            ''If tgLog.LicenseInfo.CuotasActivadas Then Throw New Exception("No se encontró la información de la cuota. Por favor comuníquese con su proveedor")

            If UserRepository.SystemUserExists(user) <= 0 Then Throw New Exception("El usuario no se encuentra habilitado para el CRM")

            SystemUser = Domain.UserRepository.GetByNick(user)

            Return True

        Catch ex As Exception
            Throw ex
        Finally
            'tgLog.DropInterface()
            tgLog = Nothing
        End Try
    End Function

    Private Shared Function Logon(ByVal Key As String, ByVal user As String, ByVal password As String) As Boolean
        Dim tgException As String = ""

        Try

            If Not tgLog.LogSystemUserEx(Key, user, password, "", tgException) Then Throw New Exception(tgException)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class
