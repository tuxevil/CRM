Public Class ZoneRepository


    Private Shared Query As String

    Public Shared Function GetByCode(ByVal code As String) As Zone
        Dim tb As DataTable

        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("ZonByCode"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<database>", MainCompany.Database), New QueryHandler.Parameter("<code>", code)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return Nothing

            If tb.Rows Is Nothing Then Return Nothing

            If tb.Rows.Count = 0 Then Return Nothing

            Return GetZone(tb.Rows(0))

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
                Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("ZonesHeaders"))

                tb = Database.GetData(Query)

                tb.TableName = "Structure"

                If tb IsNot Nothing Then ds.Tables.Add(tb)

            End If

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("Zones"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<database>", MainCompany.Database)})

            If Field <> "" Then Query = Query & " WHERE " & Field & " LIKE '" & value & "%' ORDER BY " & Field

            tb = Database.GetData(Query)

            tb.TableName = "Data"

            If tb IsNot Nothing Then ds.Tables.Add(tb)

            Return ds

        Catch ex As Exception
            Return Nothing
        End Try


    End Function

    Private Shared Function GetZone(ByVal row As DataRow) As Zone
        Dim Zone As Zone

        Try

            If row Is Nothing Then Return Nothing

            Zone = New Zone

            If row.Item("CODE") IsNot DBNull.Value Then Zone.Code = row.Item("CODE")
            If row.Item("NAME") IsNot DBNull.Value Then Zone.Name = row.Item("NAME")

            Return Zone

        Catch ex As Exception
            Return Nothing

        End Try

    End Function

End Class
