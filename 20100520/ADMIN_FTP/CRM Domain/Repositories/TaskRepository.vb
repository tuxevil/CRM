Public Class TaskRepository

    Private Shared Query As String

    Public Shared Function GetCodes(ByVal WhereCondition As String) As List(Of Integer)

        Dim tb As DataTable
        Dim List As List(Of Integer)

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TaskCodes"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            If WhereCondition <> "" Then Query = Query & "WHERE " & WhereCondition

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return Nothing

            If tb.Rows Is Nothing Then Return Nothing

            List = New List(Of Integer)

            If tb.Rows.Count = 0 Then Return List

            For Each row As DataRow In tb.Rows

                If row.Item("ID") IsNot DBNull.Value Then List.Add(row.Item("ID"))

            Next

            Return List

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Shared Function GetById(ByVal Id As Integer) As Task
        Dim tb As DataTable

        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TaskByCode"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<code>", Id)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return Nothing

            If tb.Rows Is Nothing Then Return Nothing

            If tb.Rows.Count = 0 Then Return Nothing

            Return GetTask(tb.Rows(0))

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Shared Function GetTask(ByVal row As DataRow) As Task
        Dim task As Task

        Try

            If row Is Nothing Then Return Nothing

            task = New Task

            If row.Item("ID") IsNot DBNull.Value Then task.Id = row.Item("ID")
            If row.Item("InternalType") IsNot DBNull.Value Then task.InternalType = row.Item("InternalType")
            If row.Item("TASKTYPE") IsNot DBNull.Value Then task.Type = TaskTypeRepository.GetById(row.Item("TASKTYPE"))
            If row.Item("Creator") IsNot DBNull.Value Then task.Creator = UserRepository.GetById(row.Item("Creator"))
            If row.Item("ResponsibleProfile") IsNot DBNull.Value And row.Item("ResponsibleProfile") <> 0 Then task.ResponsibleProfile = ProfileRepository.GetById(row.Item("ResponsibleProfile"))
            'If row.Item("Admin") IsNot DBNull.Value And row.Item("Admin") <> 0 Then task.ResponsibleUser = UserRepository.GetById(row.Item("Admin"))
            If row.Item("Detail") IsNot DBNull.Value Then task.Detail = row.Item("Detail")

            task.EVENTS = TaskEventRepository.GetByTask(task.Id)

            task.Entities = TaskEntityRepository.GetByTask(task.Id)

            Return task

        Catch ex As Exception
            Return Nothing

        End Try

    End Function

End Class
