Public Class SystemObjectsRepository

    Private Shared Query As String
    Private Shared tb As DataTable

    Public Shared Function SmtpServer() As SmtpHandler
        Dim smtp As SmtpHandler

        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("SmtpServer"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return New SmtpHandler("", "", "", "", False, False)

            If tb.Rows Is Nothing Then Return New SmtpHandler("", "", "", "", False, False)

            If tb.Rows.Count = 0 Then Return New SmtpHandler("", "", "", "", False, False)

            smtp = New SmtpHandler(tb.Rows(0).Item("host"), _
                                   tb.Rows(0).Item("port"), _
                                   tb.Rows(0).Item("serveruser"), _
                                   Encrypter.DecryptString(tb.Rows(0).Item("serverpassword")), _
                                   tb.Rows(0).Item("UseSSL"), _
                                   tb.Rows(0).Item("UseSPA"))

            Return smtp

        Catch ex As Exception
            Return New SmtpHandler("", "", "", "", False, False)
        End Try


    End Function


    Public Shared Function SystemEntities() As List(Of SystemEntity)
        Dim List As List(Of SystemEntity)
        Dim Entity As SystemEntity

        Try


            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("SysEntities"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            tb = Database.GetData(Query)

            List = New List(Of SystemEntity)

            If tb Is Nothing Then Return List

            If tb.Rows Is Nothing Then Return List

            List.Add(New SystemEntity)

            For Each row As DataRow In tb.Rows

                Entity = New SystemEntity

                Entity.Id = row.Item("ID")
                Entity.Name = row.Item("Name")
                Entity.ClassName = row.Item("ClassName")
                Entity.UserName = row.Item("UserName")

                If Entity IsNot Nothing Then List.Add(Entity)

            Next

            Return List

        Catch ex As Exception
            Return New List(Of SystemEntity)

        End Try

    End Function


    Public Shared Function ObjectsProperties() As Collection
        Dim List As Collection
        Dim ObjectProperty As ObjectProperty

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("ObjProp"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            tb = Database.GetData(Query)

            List = New Collection

            If tb Is Nothing Then Return List

            If tb.Rows Is Nothing Then Return List

            For Each row As DataRow In tb.Rows

                ObjectProperty = New ObjectProperty

                ObjectProperty.Id = row.Item("ID")
                ObjectProperty.Code = row.Item("CODE")
                ObjectProperty.SysObject = row.Item("SYSOBJECT")
                ObjectProperty.Field = row.Item("FIELD")
                ObjectProperty.Name = row.Item("Name")
                ObjectProperty.DisplayName = row.Item("DisplayName")
                ObjectProperty.Len = row.Item("len")

                If ObjectProperty IsNot Nothing Then List.Add(ObjectProperty, ObjectProperty.Code)

            Next

            Return List

        Catch ex As Exception
            Return New Collection

        End Try
    End Function

    Public Shared Function GetPropertyDisplayName(ByVal SysProp As String, Optional ByVal LabelText As String = "") As String
        Dim Text() As String = Nothing
        Dim Code As String

        Try
            Text = Split(SysProp, "/")

            Code = Text(Text.Length - 2) & "/" & Text(Text.Length - 1)

            Return SysObjectProperties(Code).DisplayName

        Catch ex As Exception
            Return LabelText
        End Try

    End Function

    Public Shared Function GetPropertyField(ByVal SysProp As String, Optional ByVal LabelText As String = "") As String
        Dim Text() As String = Nothing
        Dim Code As String

        Try
            Text = Split(SysProp, "/")

            Code = Text(Text.Length - 2) & "/" & Text(Text.Length - 1)

            Return SysObjectProperties(Code).Field

        Catch ex As Exception
            Return LabelText
        End Try

    End Function

    Public Shared Function GetPropertyLen(ByVal SysProp As String, Optional ByVal TextLen As Integer = 0) As Integer
        Dim Text() As String = Nothing
        Dim Code As String

        Try
            Text = Split(SysProp, "/")

            Code = Text(Text.Length - 2) & "/" & Text(Text.Length - 1)

            Return SysObjectProperties(Code).Len

        Catch ex As Exception
            Return TextLen
        End Try

    End Function


    Public Shared Function GetLicence() As Licence

        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("Licence"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Throw New Exception("No se encontró la información de la licencia")

            If tb.Rows Is Nothing Then Throw New Exception("No se encontró la información de la licencia")

            If tb.Rows.Count = 0 Then Throw New Exception("No se encontró la información de la licencia")

            Return EntityHandler.Deserialize("Licence", Encrypter.DecryptString(tb.Rows(0).Item(0)))

        Catch ex As Exception
            Throw New Exception("No se encontró la información de la licencia" & vbCrLf & ex.ToString)
        End Try

    End Function



    Public Shared Function CurrentConnections() As Integer

        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("Connections"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ApplicationName>", SystemLicence.Name)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Throw New Exception("No se encontró la información de la licencia")

            If tb.Rows Is Nothing Then Throw New Exception("No se encontró la información de la licencia")

            If tb.Rows.Count = 0 Then Throw New Exception("No se encontró la información de la licencia")

            Return CInt(tb.Rows(0).Item(0))

        Catch ex As Exception
            Throw New Exception("No se encontró la información de la licencia" & vbCrLf & ex.ToString)
        End Try

    End Function
End Class
