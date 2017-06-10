Public Class TaskEventRepository


    Private Shared Query As String
    Private Shared tb As DataTable

    Public Shared Function GetByTask(ByVal IdTask As Integer) As List(Of TaskEvent)
        Dim List As List(Of TaskEvent)
        Dim Entity As TaskEvent

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TaskEventByTask"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<task>", IdTask)})

            tb = Database.GetData(Query)

            List = New List(Of TaskEvent)

            If tb Is Nothing Then Return List

            If tb.Rows Is Nothing Then Return List

            If tb.Rows.Count = 0 Then Return List

            For Each row As DataRow In tb.Rows

                Entity = GetTaskEvent(row)

                If Entity IsNot Nothing Then List.Add(Entity)

            Next

            Return List

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Shared Function GetTaskEvent(ByVal row As DataRow) As TaskEvent
        Dim TaskEvent As TaskEvent

        Try

            If row Is Nothing Then Return Nothing

            TaskEvent = New TaskEvent

            If row.Item("ID") IsNot DBNull.Value Then TaskEvent.Id = row.Item("ID")
            If row.Item("IDTASK") IsNot DBNull.Value Then TaskEvent.IdTask = row.Item("IDTASK")
            If row.Item("EVENTTYPE") IsNot DBNull.Value Then
                If row.Item("EVENTTYPE") <> 0 Then TaskEvent.Type = GetTypeById(row.Item("EVENTTYPE"))
            End If
            If row.Item("EventDATE") IsNot DBNull.Value Then TaskEvent.EventDate = row.Item("EventDATE")
            If row.Item("DETAIL") IsNot DBNull.Value Then TaskEvent.Detail = row.Item("DETAIL")
            If row.Item("USERID") IsNot DBNull.Value Then
                If row.Item("USERID") <> 0 Then TaskEvent.User = UserRepository.GetById(row.Item("USERID"))
            End If

            Return TaskEvent

        Catch ex As Exception
            Return Nothing

        End Try

    End Function

    Public Shared Function Save(ByVal TaskId As Integer, ByVal EventType As Integer, ByVal Details As String) As Boolean

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("AddEventTask"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<task>", TaskId), New QueryHandler.Parameter("<eventtype>", EventType), New QueryHandler.Parameter("<detail>", Details), New QueryHandler.Parameter("<user>", SystemUser.Id)})

            Return Database.ExecuteCommand(Query)

        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Public Shared Function GetTypeById(ByVal Id As Integer) As TaskEvent.EventType

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("EventTypeById"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<type>", Id)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return Nothing

            If tb.Rows Is Nothing Then Return Nothing

            If tb.Rows.Count = 0 Then Return Nothing

            Return GetEventType(tb.Rows(0))

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function GetAllEventTypes(Optional ByVal Field As String = "", Optional ByVal value As String = "", Optional ByVal IncludeStructure As Boolean = False) As DataSet
        Dim ds As DataSet
        Dim tb As DataTable

        Try

            ds = New DataSet

            If IncludeStructure Then
                Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("ETypeHeaders"))

                tb = Database.GetData(Query)

                tb.TableName = "Structure"

                If tb IsNot Nothing Then ds.Tables.Add(tb)

            End If

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("EventTypes"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            If Field <> "" Then Query = Query & " WHERE " & Field & " LIKE '" & value & "%' ORDER BY " & Field

            tb = Database.GetData(Query)

            tb.TableName = "Data"

            If tb IsNot Nothing Then ds.Tables.Add(tb)

            Return ds

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Shared Function GetTypes() As List(Of TaskEvent.EventType)
        Dim List As List(Of TaskEvent.EventType)
        Dim EventType As TaskEvent.EventType

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("EventTypes"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            tb = Database.GetData(Query)

            List = New List(Of TaskEvent.EventType)

            If tb Is Nothing Then Return List

            If tb.Rows Is Nothing Then Return List

            For Each row As DataRow In tb.Rows

                EventType = GetEventType(row)

                If EventType IsNot Nothing Then List.Add(EventType)

            Next

            Return List

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function GetTableTypes() As DataTable
        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("EventTypes"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            Return Database.GetData(Query)

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Shared Function GetEventType(ByVal row As DataRow) As TaskEvent.EventType
        Dim EventType As TaskEvent.EventType

        Try

            If row Is Nothing Then Return Nothing

            EventType = New TaskEvent.EventType

            If row.Item("ID") IsNot DBNull.Value Then EventType.Id = row.Item("ID")
            If row.Item("NAME") IsNot DBNull.Value Then EventType.Name = row.Item("NAME")
            If row.Item("DESCRIPTION") IsNot DBNull.Value Then EventType.Description = row.Item("DESCRIPTION")

            Return EventType

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function SaveType(ByVal Code As Integer, ByVal Name As String, ByVal Description As String, ByVal Otherdetails As String) As Integer
        Dim SaveAction As Domain.Action
        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("SaveEventTypes"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<code>", Code), New QueryHandler.Parameter("<name>", Name), New QueryHandler.Parameter("<description>", Description), New QueryHandler.Parameter("<otherdetails>", Otherdetails)})

            SaveAction = New Domain.Action(MainCompany.Id, SystemUser)
            SaveAction.ObjectType = SystemEntities(1)
            SaveAction.sqlType = CommandType.Text
            SaveAction.SqlString = Query
            'SaveAction.Type = SysActiontypes("INSERT")
            SaveAction.InitDate = Now()
            SaveAction.Admin = SaveAction.User
            SaveAction.Status = 1

            ActionHandler.Save(SaveAction)

        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
