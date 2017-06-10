Public Class TaskRepository

    Private Shared Query As String
    Private Shared tb As DataTable

    Public Shared Function GetCodes(ByVal user As Integer) As List(Of Integer)
        Dim List As List(Of Integer)

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TaskCodes"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<user>", user), New QueryHandler.Parameter("<company>", MainCompany.Id)})

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

    Public Shared Function GetAll(ByVal User As Integer, Optional ByVal Field As String = "", Optional ByVal value As String = "", Optional ByVal IncludeStructure As Boolean = False) As DataSet
        Dim ds As DataSet
        Dim tb As DataTable

        Try

            ds = New DataSet

            If IncludeStructure Then
                Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TaskHeaders"))

                tb = Database.GetData(Query)

                tb.TableName = "Structure"

                If tb IsNot Nothing Then ds.Tables.Add(tb)

            End If

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TasksSearch"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<user>", SystemUser.Id)})

            If Field <> "" Then Query = Query & " AND " & Field & " LIKE '" & value & "%' ORDER BY " & Field

            tb = Database.GetData(Query)

            tb.TableName = "Data"

            If tb IsNot Nothing Then ds.Tables.Add(tb)

            Return ds

        Catch ex As Exception
            Return Nothing
        End Try


    End Function

    Public Shared Function GetById(ByVal Id As Integer) As Task
        Dim tb As DataTable

        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TaskByCode"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<task>", Id)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return Nothing

            If tb.Rows Is Nothing Then Return Nothing

            If tb.Rows.Count = 0 Then Return Nothing

            Return GetTask(tb.Rows(0))

        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Public Shared Function GetPendingTask() As List(Of Task)
        Dim List As List(Of Task)
        Dim Task As Task
        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("PendingTasks"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<user>", SystemUser.Id), New QueryHandler.Parameter("<company>", MainCompany.Id)})

            tb = Database.GetData(Query)

            List = New List(Of Task)

            If tb Is Nothing Then Return List

            If tb.Rows Is Nothing Then Return List

            If tb.Rows.Count = 0 Then Return List

            For Each row As DataRow In tb.Rows

                Task = GetTask(row)

                If Task IsNot Nothing Then List.Add(Task)

            Next

            Return List

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Shared Function GetByCustomer(ByVal CustomerCode As String, ByVal PotentialCustomer As Boolean) As List(Of Task)
        Dim List As List(Of Task)
        Dim Task As Task
        Try

            List = New List(Of Task)

            If PotentialCustomer Then
                Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TasksByCustomer"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<company>", MainCompany.Id), New QueryHandler.Parameter("<entitytype>", 4), New QueryHandler.Parameter("<entitycode>", CustomerCode)})
            Else
                Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TasksByCustomer"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<company>", MainCompany.Id), New QueryHandler.Parameter("<entitytype>", 1), New QueryHandler.Parameter("<entitycode>", CustomerCode)})
            End If

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return List

            If tb.Rows Is Nothing Then Return List

            If tb.Rows.Count = 0 Then Return List

            For Each row As DataRow In tb.Rows

                Task = GetById(row.Item(0))

                If Task IsNot Nothing Then List.Add(Task)

            Next

            Return List

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
            If row.Item("COMPANYID") IsNot DBNull.Value Then task.CompanyId = row.Item("COMPANYID")
            If row.Item("INTERNALTYPE") IsNot DBNull.Value Then task.InternalType = row.Item("INTERNALTYPE")
            If row.Item("OWNER") IsNot DBNull.Value Then
                If row.Item("OWNER") <> 0 Then task.Owner = UserRepository.GetById(row.Item("OWNER"))
            End If
            If row.Item("IDUSER") IsNot DBNull.Value Then
                If row.Item("IDUSER") <> 0 Then task.User = UserRepository.GetById(row.Item("IDUSER"))
            End If
            If row.Item("ADMIN") IsNot DBNull.Value Then
                If row.Item("ADMIN") <> 0 Then task.Admin = UserRepository.GetById(row.Item("ADMIN"))
            End If
            If row.Item("USERPROFILE") IsNot DBNull.Value Then
                If row.Item("USERPROFILE") <> 0 Then task.UserProfile = ProfileRepository.GetById(row.Item("USERPROFILE"))
            End If

            If row.Item("DETAIL") IsNot DBNull.Value Then task.Detail = row.Item("DETAIL")
            If row.Item("OWNERDETAIL") IsNot DBNull.Value Then task.OwnerDetail = row.Item("OWNERDETAIL")
            If row.Item("TASKTYPE") IsNot DBNull.Value Then
                If row.Item("TASKTYPE") <> 0 Then task.Type = GetTypeById(row.Item("TASKTYPE"))
            End If
            If row.Item("PRIORITY") IsNot DBNull.Value Then
                If row.Item("PRIORITY") <> 0 Then task.Priority = GetPriorityById(row.Item("PRIORITY"))
            End If

            If row.Item("STATUS") IsNot DBNull.Value Then
                If row.Item("STATUS") <> 0 Then task.State = GetStateById(row.Item("STATUS"))
            End If

            If row.Item("SystemDate") IsNot DBNull.Value Then task.SystemDate = row.Item("SystemDate")
            If row.Item("Initdate") IsNot DBNull.Value Then task.Initdate = row.Item("Initdate")
            If row.Item("InitTime") IsNot DBNull.Value Then task.InitTime = Format(row.Item("InitTime"), "hh:mm")
            If row.Item("Firstdate") IsNot DBNull.Value Then task.Firstdate = row.Item("Firstdate")
            If row.Item("Lastdate") IsNot DBNull.Value Then task.Lastdate = row.Item("Lastdate")

            task.Events = TaskEventRepository.GetByTask(task.Id)

            task.Entities = TaskEntityRepository.GetByTask(task.Id)

            Return task

        Catch ex As Exception
            Return Nothing

        End Try

    End Function

    Public Shared Function AddEntity(ByVal TaskId As Integer, ByVal EntityType As Integer, ByVal EntityCode As String) As Boolean
        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("AddEntityTask"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<task>", TaskId), New QueryHandler.Parameter("<entitytype>", EntityType), New QueryHandler.Parameter("<entitycode>", EntityCode)})

            Return Database.ExecuteCommand(Query)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function RemoveEntity(ByVal TaskId As Integer, ByVal EntityType As Integer, ByVal EntityCode As String) As Boolean
        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("DelEntityTask"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<task>", TaskId), New QueryHandler.Parameter("<entitytype>", EntityType), New QueryHandler.Parameter("<entitycode>", EntityCode)})

            Return Database.ExecuteCommand(Query)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function GetTypeById(ByVal Id As Integer) As Task.TaskType

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TaskTypeById"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<type>", Id)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return Nothing

            If tb.Rows Is Nothing Then Return Nothing

            If tb.Rows.Count = 0 Then Return Nothing

            Return GetTaskType(tb.Rows(0))

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function GetTypes() As List(Of Task.TaskType)
        Dim List As List(Of Task.TaskType)
        Dim TaskType As Task.TaskType

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TaskTypes"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            tb = Database.GetData(Query)

            List = New List(Of Task.TaskType)

            If tb Is Nothing Then Return List

            If tb.Rows Is Nothing Then Return List

            For Each row As DataRow In tb.Rows

                TaskType = GetTaskType(row)

                If TaskType IsNot Nothing Then List.Add(TaskType)

            Next

            Return List

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function GetAllTypes(Optional ByVal Field As String = "", Optional ByVal value As String = "", Optional ByVal IncludeStructure As Boolean = False) As DataSet
        Dim ds As DataSet
        Dim tb As DataTable

        Try

            ds = New DataSet

            If IncludeStructure Then
                Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TypeHeaders"))

                tb = Database.GetData(Query)

                tb.TableName = "Structure"

                If tb IsNot Nothing Then ds.Tables.Add(tb)

            End If

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TaskTypes"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            If Field <> "" Then Query = Query & " WHERE " & Field & " LIKE '" & value & "%' ORDER BY " & Field

            tb = Database.GetData(Query)

            tb.TableName = "Data"

            If tb IsNot Nothing Then ds.Tables.Add(tb)

            Return ds

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Shared Function GetTableTypes() As DataTable
        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TaskTypes"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            Return Database.GetData(Query)

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Shared Function GetTaskType(ByVal row As DataRow) As Task.TaskType
        Dim TaskType As Task.TaskType

        Try

            If row Is Nothing Then Return Nothing

            TaskType = New Task.TaskType

            If row.Item("ID") IsNot DBNull.Value Then TaskType.Id = row.Item("ID")
            If row.Item("NAME") IsNot DBNull.Value Then TaskType.Name = row.Item("NAME")
            If row.Item("DESCRIPTION") IsNot DBNull.Value Then TaskType.Description = row.Item("DESCRIPTION")

            Return TaskType

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function SaveType(ByVal Code As Integer, ByVal Name As String, ByVal Description As String, ByVal Otherdetails As String) As Integer
        Dim SaveAction As Domain.Action
        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("SaveTaskTypes"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<code>", Code), New QueryHandler.Parameter("<name>", Name), New QueryHandler.Parameter("<description>", Description), New QueryHandler.Parameter("<otherdetails>", Otherdetails)})

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

    Public Shared Function GetPriorityById(ByVal Id As Integer) As Task.TaskPriority

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TaskPrtyById"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<priority>", Id)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return Nothing

            If tb.Rows Is Nothing Then Return Nothing

            If tb.Rows.Count = 0 Then Return Nothing

            Return GetTaskPriority(tb.Rows(0))

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function GetPriorities() As List(Of Task.TaskPriority)
        Dim List As List(Of Task.TaskPriority)
        Dim TaskPriority As Task.TaskPriority

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TaskPrties"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            tb = Database.GetData(Query)

            List = New List(Of Task.TaskPriority)

            If tb Is Nothing Then Return List

            If tb.Rows Is Nothing Then Return List

            For Each row As DataRow In tb.Rows

                TaskPriority = GetTaskPriority(row)

                If TaskPriority IsNot Nothing Then List.Add(TaskPriority)

            Next

            Return List

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function GetTablePriorities() As DataTable
        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TaskPrties"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            Return Database.GetData(Query)

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Shared Function GetTaskPriority(ByVal row As DataRow) As Task.TaskPriority
        Dim TaskPriority As Task.TaskPriority

        Try

            If row Is Nothing Then Return Nothing

            TaskPriority = New Task.TaskPriority

            If row.Item("ID") IsNot DBNull.Value Then TaskPriority.Id = row.Item("ID")
            If row.Item("NAME") IsNot DBNull.Value Then TaskPriority.Name = row.Item("NAME")
            If row.Item("DESCRIPTION") IsNot DBNull.Value Then TaskPriority.Description = row.Item("DESCRIPTION")

            Return TaskPriority

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function SavePriority(ByVal Code As Integer, ByVal Name As String, ByVal Description As String, ByVal Otherdetails As String) As Integer
        Dim SaveAction As Domain.Action
        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("SaveTaskPrty"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<code>", Code), New QueryHandler.Parameter("<name>", Name), New QueryHandler.Parameter("<description>", Description), New QueryHandler.Parameter("<otherdetails>", Otherdetails)})

            SaveAction = New Domain.Action(MainCompany.Id, SystemUser)
            SaveAction.ObjectType = SystemEntities(1)
            SaveAction.sqlType = CommandType.Text
            SaveAction.SqlString = Query
            'SaveAction.Priority = SysActionPrioritys("INSERT")
            SaveAction.InitDate = Now()
            SaveAction.Admin = SaveAction.User
            SaveAction.Status = 1

            ActionHandler.Save(SaveAction)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function GetStateById(ByVal Id As Integer) As Task.TaskState

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TaskStateById"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<state>", Id)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return Nothing

            If tb.Rows Is Nothing Then Return Nothing

            If tb.Rows.Count = 0 Then Return Nothing

            Return GetTaskState(tb.Rows(0))

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function GetStates(ByVal Id As Integer) As List(Of Task.TaskState)
        Dim List As List(Of Task.TaskState)
        Dim TaskState As Task.TaskState

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TaskStates"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<taskState>", Id)})

            tb = Database.GetData(Query)

            List = New List(Of Task.TaskState)

            If tb Is Nothing Then Return List

            If tb.Rows Is Nothing Then Return List

            For Each row As DataRow In tb.Rows

                TaskState = GetTaskState(row)

                If TaskState IsNot Nothing Then List.Add(TaskState)

            Next

            Return List

        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Shared Function GetAllStates(Optional ByVal Field As String = "", Optional ByVal value As String = "", Optional ByVal IncludeStructure As Boolean = False) As DataSet
        Dim ds As DataSet
        Dim tb As DataTable

        Try

            ds = New DataSet

            If IncludeStructure Then
                Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TStateHeaders"))

                tb = Database.GetData(Query)

                tb.TableName = "Structure"

                If tb IsNot Nothing Then ds.Tables.Add(tb)

            End If

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TaskStates"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            If Field <> "" Then Query = Query & " WHERE " & Field & " LIKE '" & value & "%' ORDER BY " & Field

            tb = Database.GetData(Query)

            tb.TableName = "Data"

            If tb IsNot Nothing Then ds.Tables.Add(tb)

            Return ds

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Shared Function GetTableStates() As DataTable
        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("TaskStates"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            Return Database.GetData(Query)

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Shared Function GetTaskState(ByVal row As DataRow) As Task.TaskState
        Dim TaskState As Task.TaskState

        Try

            If row Is Nothing Then Return Nothing

            TaskState = New Task.TaskState

            If row.Item("ID") IsNot DBNull.Value Then TaskState.Id = row.Item("ID")
            If row.Item("NAME") IsNot DBNull.Value Then TaskState.Name = row.Item("NAME")
            If row.Item("DESCRIPTION") IsNot DBNull.Value Then TaskState.Description = row.Item("DESCRIPTION")

            Return TaskState

        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Public Shared Function Save(ByVal Entity As Task, Optional ByVal OriginalEntity As Task = Nothing) As Integer

        Try
            If Entity.Id <= 0 Then
                Insert(Entity)
            Else
                Update(Entity, OriginalEntity)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Private Shared Function Insert(ByVal Entity As Task) As Integer
        Dim Action As Action

        Try
            Action = GetActionInsertTask(Entity)


            Entity.Id = ActionHandler.Save(Action)

            If Entity.Id <> 0 Then

                For Each TaskEntity As TaskEntity In Entity.Entities

                    AddEntity(Entity.Id, TaskEntity.Type.Id, TaskEntity.Code)

                Next

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Private Shared Function Update(ByVal Entity As Task, ByVal OriginalEntity As Task) As Integer
        Dim Actions As List(Of Action)
        Dim Action As Action

        Try
            Actions = New List(Of Action)

            Action = GetActionUpdateTask(Entity, OriginalEntity)
            If Action Is Nothing Then Return 0

            Actions.Add(Action)

            ActionHandler.Save(Actions)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Shared Function GetActionInsertTask(ByVal Entity As Task) As Action
        Dim Action As Action

        Try
            Action = New Action(MainCompany.Id, SystemUser)

            Action.ObjectType = SystemEntities(2)
            Action.FinalObject = EntityHandler.Serialize(Entity)
            Action.sqlType = CommandType.StoredProcedure
            Action.sqlName = SystemCompany.Database & ".dbo.sp_InsertTask"
            Action.Parameters = TaskParameters(Entity)
            'Action.Type = SysActiontypes("INSERT")
            Action.InitDate = Now()
            Action.Admin = Action.User
            Action.Status = 1

            Return Action

        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Private Shared Function GetActionUpdateTask(ByVal Entity As Task, ByVal OriginalEntity As Task) As Action
        Dim Action As Action

        Try
            Action = New Action(MainCompany.Id, SystemUser)
            Action.ObjectType = SystemEntities(1)
            Action.OriginalObject = EntityHandler.Serialize(OriginalEntity)
            Action.FinalObject = EntityHandler.Serialize(Entity)
            Action.sqlType = CommandType.StoredProcedure
            Action.sqlName = SystemCompany.Database & ".dbo.sp_UpdateTask"
            Action.Parameters = TaskParameters(Entity)
            'Action.Type = SysActiontypes("UPDATE")
            Action.InitDate = Now()
            Action.Admin = Action.User
            Action.Status = 1

            Return Action

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Shared Function TaskParameters(ByVal Entity As Task) As SqlClient.SqlParameter()

        Dim Parameters() As SqlClient.SqlParameter

        Try
            ReDim Parameters(0 To 6)

            Parameters(0) = New SqlClient.SqlParameter("@ID", SqlDbType.Int) With {.Value = Entity.Id}
            Parameters(1) = New SqlClient.SqlParameter("@INTERNALTYPE", SqlDbType.Int) With {.Value = Entity.InternalType}
            Parameters(2) = New SqlClient.SqlParameter("@DETAIL", SqlDbType.VarChar) With {.Value = Entity.Detail}
            Parameters(3) = New SqlClient.SqlParameter("@OWNERDETAIL", SqlDbType.VarChar) With {.Value = Entity.OwnerDetail}
            Parameters(4) = New SqlClient.SqlParameter("@COMPANYID", SqlDbType.Int) With {.Value = Entity.CompanyId}
            Parameters(5) = New SqlClient.SqlParameter("@Initdate", SqlDbType.DateTime) With {.Value = Format(Entity.Initdate, "yyyy/MM/dd")}
            Parameters(6) = New SqlClient.SqlParameter("@InitTime", SqlDbType.DateTime) With {.Value = Format(Entity.InitTime, "hh:mm")}

            If Entity.State IsNot Nothing Then
                ReDim Preserve Parameters(0 To UBound(Parameters) + 1)
                Parameters(UBound(Parameters)) = New SqlClient.SqlParameter("@STATE", SqlDbType.Int) With {.Value = Entity.State.Id}
            End If

            If Entity.Owner IsNot Nothing Then
                ReDim Preserve Parameters(0 To UBound(Parameters) + 1)
                Parameters(UBound(Parameters)) = New SqlClient.SqlParameter("@OWNER", SqlDbType.Int) With {.Value = Entity.Owner.Id}
            End If

            If Entity.User IsNot Nothing Then
                ReDim Preserve Parameters(0 To UBound(Parameters) + 1)
                Parameters(UBound(Parameters)) = New SqlClient.SqlParameter("@USER", SqlDbType.Int) With {.Value = Entity.User.Id}
            End If

            If Entity.Admin IsNot Nothing Then
                ReDim Preserve Parameters(0 To UBound(Parameters) + 1)
                Parameters(UBound(Parameters)) = New SqlClient.SqlParameter("@ADMIN", SqlDbType.Int) With {.Value = Entity.Admin.Id}
            End If

            If Entity.UserProfile IsNot Nothing Then
                ReDim Preserve Parameters(0 To UBound(Parameters) + 1)
                Parameters(UBound(Parameters)) = New SqlClient.SqlParameter("@USERPROFILE", SqlDbType.Int) With {.Value = Entity.UserProfile.Id}
            End If

            If Entity.Type IsNot Nothing Then
                ReDim Preserve Parameters(0 To UBound(Parameters) + 1)
                Parameters(UBound(Parameters)) = New SqlClient.SqlParameter("@TASKTYPE", SqlDbType.Int) With {.Value = Entity.Type.Id}
            End If

            If Entity.Priority IsNot Nothing Then
                ReDim Preserve Parameters(0 To UBound(Parameters) + 1)
                Parameters(UBound(Parameters)) = New SqlClient.SqlParameter("@TASKPRIORITY", SqlDbType.Int) With {.Value = Entity.Priority.Id}
            End If

            If Entity.Action IsNot Nothing Then
                ReDim Preserve Parameters(0 To UBound(Parameters) + 1)
                Parameters(UBound(Parameters)) = New SqlClient.SqlParameter("@ACTION", SqlDbType.Int) With {.Value = Entity.Action.Id}
            End If

            Return Parameters

        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Public Shared Function CancelTask(ByVal IdTask As Integer) As Integer
        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("UpdateTaskState"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<state>", 3), New QueryHandler.Parameter("<task>", IdTask)})

            Return Database.ExecuteCommand(Query)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function CloseTask(ByVal IdTask As Integer) As Integer
        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("UpdateTaskState"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<state>", 2), New QueryHandler.Parameter("<task>", IdTask)})

            Return Database.ExecuteCommand(Query)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
