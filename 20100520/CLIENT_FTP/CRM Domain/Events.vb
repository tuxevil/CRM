Public Module Events

    Public TgKey As String = "000114/001" '"030359/002"

    Public SystemLicence As Licence
    Public SystemUser As User
    Public MainCompany As Company
    Public SystemCompany As Company
    Public Database As Crm.Data.SqlData
    Public SmtpServer As SmtpHandler
    Public SystemEntities As List(Of SystemEntity)
    Public SysObjectProperties As Collection
    Public SysActiontypes As Collection
    Public DictionaryDatabase As String

    Public Function StartUp(ByVal ServerName As String, ByVal ServerInstance As String, ByVal ServerUser As String, ByVal ServerPassword As String, ByVal dbDictionary As String, ByVal dbMainCompany As String, ByVal dbOwner As String) As Boolean

        Try

            Database = New Crm.Data.SqlData("Server=" & Trim(ServerName) & ";Database=master;User ID=" & Trim(ServerUser) & ";Password=" & Trim(ServerPassword) & ";Trusted_Connection=False;Application Name='CRM 2x4'")

            Database.OpenDb()

            MainCompany = New Company With {.Database = Trim(dbMainCompany)}

            SystemCompany = New Company With {.Database = Trim(dbOwner)}

            DictionaryDatabase = dbDictionary

            SystemLicence = SystemObjectsRepository.GetLicence()

            TgKey = SystemLicence.Key

            SmtpServer = SystemObjectsRepository.SmtpServer()

            SystemEntities = SystemObjectsRepository.SystemEntities()

            SysObjectProperties = SystemObjectsRepository.ObjectsProperties()

            SysObjectProperties = New Collection

            Return True

        Catch ex As Exception
            Throw ex
            Return False
        End Try

    End Function



    Private Sub ValidateLicence()

        Try

            SystemLicence = SystemObjectsRepository.GetLicence()

            TgKey = SystemLicence.Key

            If SystemObjectsRepository.CurrentConnections >= SystemLicence.Connections Then Throw New Exception("Todas las licencias se encuentran en uso.")

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

End Module
