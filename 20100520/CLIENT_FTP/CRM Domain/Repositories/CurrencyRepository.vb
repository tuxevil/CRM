Public Class CurrencyRepository

    Private Shared Query As String


    Public Shared Function GetByCode(ByVal code As String) As Currency
        Dim tb As DataTable
        Dim Currency As Currency

        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CurrByCode"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<database>", MainCompany.Database), New QueryHandler.Parameter("<code>", code)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return Nothing

            If tb.Rows Is Nothing Then Return Nothing

            If tb.Rows.Count = 0 Then Return Nothing

            Currency = New Currency(tb.Rows(0).Item("CODE"), tb.Rows(0).Item("NAME"))

            Return Currency

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Shared Function GetAll(Optional ByVal Field As String = "", Optional ByVal value As String = "", Optional ByVal IncludeStructure As Boolean = False) As DataSet
        Dim ds As DataSet
        Dim tb As DataTable

        Try

            ds = New DataSet

            If IncludeStructure Then
                Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CurrHeaders"))

                tb = Database.GetData(Query)

                tb.TableName = "Structure"

                If tb IsNot Nothing Then ds.Tables.Add(tb)

            End If

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("Currencies"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<database>", MainCompany.Database)})

            If Field <> "" Then Query = Query & " WHERE " & Field & " LIKE '" & value & "%' ORDER BY " & Field

            tb = Database.GetData(Query)

            tb.TableName = "Data"

            If tb IsNot Nothing Then ds.Tables.Add(tb)

            Return ds

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Shared Function GetList() As List(Of Currency)
        Dim List As List(Of Currency)
        Dim tb As DataTable
        Dim Currency As Currency

        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("Currencies"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<database>", MainCompany.Database)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return Nothing

            If tb.Rows Is Nothing Then Return Nothing

            If tb.Rows.Count = 0 Then Return Nothing

            List = New List(Of Currency)

            For Each row As DataRow In tb.Rows

                If row.Item("CODE") IsNot DBNull.Value And row.Item("NAME") IsNot DBNull.Value Then

                    Currency = New Currency(row.Item("CODE"), row.Item("NAME"))
                    List.Add(Currency)

                End If

            Next

            Return List

        Catch ex As Exception
            Return Nothing
        End Try

    End Function
End Class
