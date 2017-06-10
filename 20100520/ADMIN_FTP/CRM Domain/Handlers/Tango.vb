Public Class Tango

    Private Shared tgLog As HardLockServer.LogOn

    Public Shared Function Login(ByVal user As String, ByVal password As String) As Boolean

        Try
            If Logon(TgKey, user, password) Then Return True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            If Logon(BaKey, user, password) Then Return True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Shared Function Logon(ByVal Key As String, ByVal user As String, ByVal password As String) As Boolean
        Dim tgException As String = ""

        Try

            tgLog = CreateObject("HardLockServer.LogOn")

            If Not tgLog.LogSystemUserEx(Key, user, password, "", tgException) Then

                Throw New Exception(tgException)

            Else

                SystemUser = Domain.UserRepository.GetByNick(user)
                tgLog.DropInterface()
                tgLog = Nothing
                Return True

            End If

        Catch ex As Exception
            Throw ex

        End Try

    End Function

End Class
