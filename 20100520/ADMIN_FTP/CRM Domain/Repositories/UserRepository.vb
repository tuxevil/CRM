Public Class UserRepository

    Private Shared Query As String
    Private Shared tb As DataTable


    Public Shared Function GetByNick(ByVal nick As String) As User

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("UserByNick"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<dictionarydatabase>", DictionaryDatabase), New QueryHandler.Parameter("<user>", nick)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Throw New Exception("No se puede acceder a la lista de usuarios")

            If tb.Rows Is Nothing Then Throw New Exception("Usuario incorrecto o sin perfil asociado")

            If tb.Rows.Count = 0 Then Throw New Exception("Usuario incorrecto o sin perfil asociado")

            Return GetUser(tb.Rows(0))

        Catch ex As Exception
            Throw ex
        End Try



    End Function

    Public Shared Function GetById(ByVal Id As Integer) As User

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("UserById"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<dictionarydatabase>", DictionaryDatabase), New QueryHandler.Parameter("<user>", Id)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Throw New Exception("No se puede acceder a la lista de usuarios")

            If tb.Rows Is Nothing Then Throw New Exception("Usuario incorrecto o sin perfil asociado")

            If tb.Rows.Count = 0 Then Throw New Exception("Usuario incorrecto o sin perfil asociado")

            Return GetUser(tb.Rows(0))

        Catch ex As Exception
            Throw ex
        End Try


    End Function

    Public Shared Function GetByTangoId(ByVal Id As Integer) As User

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("UserByTgId"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<dictionarydatabase>", DictionaryDatabase), New QueryHandler.Parameter("<user>", Id)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Throw New Exception("No se puede acceder a la lista de usuarios")

            If tb.Rows Is Nothing Then Throw New Exception("Usuario incorrecto o sin perfil asociado")

            If tb.Rows.Count = 0 Then Throw New Exception("Usuario incorrecto o sin perfil asociado")

            Return GetUser(tb.Rows(0))

        Catch ex As Exception
            Throw ex
        End Try


    End Function

    Public Shared Function GetByCompany(ByVal Id As Integer) As List(Of User)
        Dim Entity As User
        Dim List As List(Of User)

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CmpByUser"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<dictionarydatabase>", DictionaryDatabase), New QueryHandler.Parameter("<company>", Id)})

            tb = Database.GetData(Query)

            List = New List(Of User)

            If tb Is Nothing Then Return List

            If tb.Rows Is Nothing Then Return List

            If tb.Rows.Count = 0 Then Return List

            For Each Row As DataRow In tb.Rows

                Entity = GetUser(Row)

                If Entity IsNot Nothing Then

                    Entity.Profile = New Profile
                    If Row.Item("IDPROFILE") IsNot DBNull.Value Then Entity.Profile.Id = Row.Item("IDPROFILE")
                    If Row.Item("PRFNAME") IsNot DBNull.Value Then Entity.Profile.Name = Row.Item("PRFNAME")

                    List.Add(Entity)

                End If

            Next

            Return List

        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Public Shared Function TangoUsers() As List(Of User)
        Dim Entity As User
        Dim List As List(Of User)

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TangoUsers"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<dictionarydatabase>", DictionaryDatabase)})

            tb = Database.GetData(Query)

            List = New List(Of User)

            If tb Is Nothing Then Return List

            If tb.Rows Is Nothing Then Return List

            If tb.Rows.Count = 0 Then Return List

            For Each Row As DataRow In tb.Rows

                Entity = GetUser(Row)

                If Entity IsNot Nothing Then List.Add(Entity)

            Next

            Return List

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function BeginProcess() As Boolean
        Try

            '
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("RestartProfile"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            Database.BeginTrans()

            Database.ExecuteCommand(Query)


        Catch ex As Exception
            Database.Rollback()
            Throw ex
        End Try
    End Function

    Public Shared Function CommitProcess() As Boolean
        Try

            Database.CommitTrans()

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function Save(ByVal IdUser As Integer) As User
        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("InsertUser"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<dictionarydatabase>", DictionaryDatabase), New QueryHandler.Parameter("<user>", IdUser)})

            Database.ExecuteCommand(Query)

            Return GetByTangoId(IdUser)

        Catch ex As Exception
            Database.Rollback()
            Throw ex

        End Try
    End Function

    Public Shared Function SaveProfile(ByVal CompanyId As Integer, ByVal UserId As Integer, ByVal ProfileId As Integer) As Boolean
        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("SaveUserPrf"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<company>", CompanyId), New QueryHandler.Parameter("<user>", UserId), New QueryHandler.Parameter("<profile>", ProfileId)})

            Database.ExecuteCommand(Query)

            Return True

        Catch ex As Exception
            Database.Rollback()
            Throw ex

        End Try
    End Function

    Public Shared Function SaveFullUser(ByVal UserId As Integer, ByVal CompanyId As Integer, ByVal ProfileId As Integer, ByVal FullUser As Boolean) As Boolean
        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("SaveFullUser"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<company>", CompanyId), New QueryHandler.Parameter("<user>", UserId), New QueryHandler.Parameter("<profile>", ProfileId), New QueryHandler.Parameter("<fulldomain>", CInt(FullUser))})

            Database.ExecuteCommand(Query)

            Return True

        Catch ex As Exception
            Database.Rollback()
            Throw ex

        End Try
    End Function

    Public Shared Function SaveProfileOwner(ByVal UserId As Integer, ByVal CompanyId As Integer, ByVal ProfileId As Integer, ByVal ProfileOwner As Boolean) As Boolean
        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("SavePrfOwner"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<company>", CompanyId), New QueryHandler.Parameter("<user>", UserId), New QueryHandler.Parameter("<profile>", ProfileId), New QueryHandler.Parameter("<profileowner>", CInt(ProfileOwner))})

            Database.ExecuteCommand(Query)

            Return True

        Catch ex As Exception
            Database.Rollback()
            Throw ex

        End Try
    End Function

    Public Shared Function FullUser(ByVal companyID As Integer, ByVal UserId As Integer, ByVal ProfileId As Integer) As Boolean
        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("FullUser"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<company>", companyID), New QueryHandler.Parameter("<user>", UserId), New QueryHandler.Parameter("<profile>", ProfileId)})

            Return Database.GetData(Query).Rows(0).Item(0)

        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Shared Function ProfileOwner(ByVal companyID As Integer, ByVal UserId As Integer, ByVal ProfileId As Integer) As Boolean
        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("ProfileOwner"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<company>", companyID), New QueryHandler.Parameter("<user>", UserId), New QueryHandler.Parameter("<profile>", ProfileId)})

            Return Database.GetData(Query).Rows(0).Item(0)

        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Shared Function GetUser(ByVal row As DataRow) As User
        Dim Entity As User

        Try
            If row Is Nothing Then Return Nothing

            Entity = New User

            If row.Item("ID") IsNot DBNull.Value Then Entity.Id = row.Item("ID")
            If row.Item("TANGOID") IsNot DBNull.Value Then Entity.TangoId = row.Item("TANGOID")
            If row.Item("NICKNAME") IsNot DBNull.Value Then Entity.NickName = row.Item("NICKNAME")
            If row.Item("FULLNAME") IsNot DBNull.Value Then Entity.FullName = row.Item("FULLNAME")
            If row.Item("MAIL") IsNot DBNull.Value Then Entity.Mail = row.Item("MAIL")


            Return Entity

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function SaveDomain(ByVal userId As Integer, ByVal CompanyId As Integer, ByVal Customer As String, ByVal AddCustomer As Boolean) As Boolean
        Try

            If AddCustomer Then
                Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CstDomainAdd"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<company>", CompanyId), New QueryHandler.Parameter("<user>", userId), New QueryHandler.Parameter("<customer>", Customer)})
            Else
                Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CstDomainRemove"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<company>", CompanyId), New QueryHandler.Parameter("<user>", userId), New QueryHandler.Parameter("<customer>", Customer)})
            End If

            Database.ExecuteCommand(Query)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
