Public Class CompanyRepository

    Private Shared Query As String
    Private Shared tb As DataTable


    Public Shared Function GetByUser(ByVal Id As Integer) As List(Of Company)
        Dim List As List(Of Company)
        Dim Entity As Company

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CompaniesByUser"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<dictionarydatabase>", DictionaryDatabase), New QueryHandler.Parameter("<user>", Id)})

            tb = Database.GetData(Query)

            List = New List(Of Company)

            If tb Is Nothing Then Return List

            If tb.Rows Is Nothing Then Return List

            For Each row As DataRow In tb.Rows

                Entity = GetCompany(row)

                If Entity IsNot Nothing Then List.Add(Entity)

            Next

            Return List

        Catch ex As Exception
            Throw ex

        End Try

    End Function


    Public Shared Function GetAll() As List(Of Company)
        Dim List As List(Of Company)
        Dim Entity As Company

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("Companies"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<dictionarydatabase>", DictionaryDatabase)})

            tb = Database.GetData(Query)

            List = New List(Of Company)

            If tb Is Nothing Then Return List

            If tb.Rows Is Nothing Then Return List

            For Each row As DataRow In tb.Rows

                Entity = GetCompany(row)

                If Entity IsNot Nothing Then List.Add(Entity)

            Next

            Return List

        Catch ex As Exception
            Throw ex

        End Try

    End Function

    Public Shared Function TgCompanies() As List(Of Company)
        Dim List As List(Of Company)
        Dim Entity As Company

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TgCompanies"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<dictionarydatabase>", DictionaryDatabase)})

            tb = Database.GetData(Query)

            List = New List(Of Company)

            If tb Is Nothing Then Return List

            If tb.Rows Is Nothing Then Return List

            For Each row As DataRow In tb.Rows

                Entity = GetCompany(row)

                If Entity IsNot Nothing Then List.Add(Entity)

            Next

            Return List

        Catch ex As Exception
            Throw ex

        End Try

    End Function

    Public Shared Function GetById(ByVal Id As Integer) As Company

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CompanyById"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<dictionarydatabase>", DictionaryDatabase), New QueryHandler.Parameter("<Id>", Id)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return Nothing

            If tb.Rows Is Nothing Then Return Nothing

            If tb.Rows.Count = 0 Then Return Nothing

            Return GetCompany(tb.Rows(0))

        Catch ex As Exception
            Throw ex

        End Try

    End Function

    Private Shared Function GetCompany(ByVal row As DataRow) As Company
        Dim Entity As Company

        Try
            If row Is Nothing Then Return Nothing

            Entity = New Company

            If row.Item("ID") IsNot DBNull.Value Then Entity.Id = row.Item("ID")
            If row.Item("TANGOID") IsNot DBNull.Value Then Entity.TangoId = row.Item("TANGOID")
            If row.Item("NAME") IsNot DBNull.Value Then Entity.Name = row.Item("NAME")
            If row.Item("DBNAME") IsNot DBNull.Value Then Entity.Database = row.Item("DBNAME")
            If row.Item("DBTYPE") IsNot DBNull.Value Then Entity.DBType = row.Item("DBTYPE")
            Entity.User = MainCompany.User
            Entity.Password = MainCompany.Password

            Return Entity

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function Validate(ByVal Entity As Company) As Boolean

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("DbValidation"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<database>", Entity.Database)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return False

            If tb.Rows Is Nothing Then Return False

            If tb.Rows.Count = 0 Then Return False

            If tb.Rows(0).Item(0) = 0 Then Return True

        Catch ex As Exception
            Throw ex
        End Try


    End Function

    Public Shared Function AddCompany(ByVal TangoId As Integer, ByVal CompanyDb As String) As Boolean

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("AddCompany"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<company>", TangoId), New QueryHandler.Parameter("<database>", CompanyDb)})

            database.ExecuteCommand(Query)

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function
End Class
