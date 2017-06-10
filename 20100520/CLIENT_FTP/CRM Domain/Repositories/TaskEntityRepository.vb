Public Class TaskEntityRepository

    Private Shared Query As String
    Private Shared tb As DataTable

    Public Shared Function GetByTask(ByVal IdTask As Integer) As List(Of TaskEntity)
        Dim List As List(Of TaskEntity)
        Dim Entity As TaskEntity

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TaskEntByTask"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<task>", IdTask)})

            tb = Database.GetData(Query)

            List = New List(Of TaskEntity)

            If tb Is Nothing Then Return List

            If tb.Rows Is Nothing Then Return List

            If tb.Rows.Count = 0 Then Return List

            For Each row As DataRow In tb.Rows

                Entity = GetTaskentity(row)

                If Entity IsNot Nothing Then List.Add(Entity)

            Next

            Return List

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Shared Function GetTaskentity(ByVal row As DataRow) As TaskEntity
        Dim TaskEntity As TaskEntity

        Try

            If row Is Nothing Then Return Nothing

            TaskEntity = New TaskEntity

            If row.Item("ID") IsNot DBNull.Value Then TaskEntity.Id = row.Item("ID")
            If row.Item("IDTASK") IsNot DBNull.Value Then TaskEntity.IdTask = row.Item("IDTASK")
            If row.Item("ENTITYTYPE") IsNot DBNull.Value Then  TaskEntity.Type = SystemEntities(CStr(row.Item("ENTITYTYPE")))
            If row.Item("ENTITYCODE") IsNot DBNull.Value Then TaskEntity.Code = row.Item("ENTITYCODE")

            Return TaskEntity

        Catch ex As Exception
            Return Nothing

        End Try

    End Function

End Class
