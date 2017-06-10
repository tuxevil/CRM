Public Class ProfileRepository

    Private Shared Query As String
    Private Shared tb As DataTable

    Public Shared Function GetById(ByVal Id As Integer) As Profile

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("PrfById"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<profile>", Id)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Throw New Exception("No se puede acceder a la lista de perfiles")

            If tb.Rows Is Nothing Then Throw New Exception("No se puede acceder a la lista de perfiles")

            If tb.Rows.Count = 0 Then Throw New Exception("No se puede acceder a la lista de perfiles")

            Return GetProfile(tb.Rows(0))

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function GetByUser(ByVal User As Integer) As Profile

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("PflByUser"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<user>", User)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Throw New Exception("No se puede acceder a la lista de perfiles")

            If tb.Rows Is Nothing Then Throw New Exception("No se puede acceder a la lista de perfiles")

            If tb.Rows.Count = 0 Then Throw New Exception("No se puede acceder a la lista de perfiles")

            Return GetProfile(tb.Rows(0))

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function GetAll() As List(Of Profile)
        Dim List As List(Of Profile)
        Dim Entity As Profile
        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("Profiles"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            tb = Database.GetData(Query)

            List = New List(Of Profile)

            If tb Is Nothing Then Throw New Exception("No se puede acceder a la lista de perfiles")

            If tb.Rows Is Nothing Then Throw New Exception("No se puede acceder a la lista de perfiles")

            If tb.Rows.Count = 0 Then Return List

            For Each Row As DataRow In tb.Rows

                Entity = GetProfile(Row)
                '   MsgBox(Entity.CustomerRealViewTerms)

                List.Add(Entity)

            Next

            tb = Nothing

            Return List

        Catch ex As Exception
            Return Nothing
        End Try


    End Function

    Public Shared Function GetIdByName(ByVal name As String) As Integer
        Dim tb As DataTable

        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("PrfIdByCode"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<profile>", name)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return 0

            If tb.Rows Is Nothing Then Return 0

            If tb.Rows.Count = 0 Then Return 0

            Return tb.Rows(0).Item(0)

        Catch ex As Exception
            Return 0
        End Try

    End Function


    Private Shared Function GetProfile(ByVal row As DataRow) As Profile
        Dim Entity As Profile

        Try
            If row Is Nothing Then Return Nothing

            Entity = New Profile

            If row.Item("IDPROFILE") IsNot DBNull.Value Then Entity.Id = row.Item("IDPROFILE")
            If row.Item("PRFNAME") IsNot DBNull.Value Then Entity.Name = row.Item("PRFNAME")
            If row.Item("Description") IsNot DBNull.Value Then Entity.Description = row.Item("Description")
            If row.Item("CustomerRealViewGeneral") IsNot DBNull.Value Then Entity.CustomerRealViewGeneral = row.Item("CustomerRealViewGeneral")
            If row.Item("CustomerRealViewAdress") IsNot DBNull.Value Then Entity.CustomerRealViewAdress = row.Item("CustomerRealViewAdress")
            If row.Item("CustomerRealViewDelivery") IsNot DBNull.Value Then Entity.CustomerRealViewDelivery = row.Item("CustomerRealViewDelivery")
            If row.Item("CustomerRealViewTerms") IsNot DBNull.Value Then Entity.CustomerRealViewTerms = row.Item("CustomerRealViewTerms")
            'MsgBox(row.Item("CustomerRealViewTerms").ToString)
            If row.Item("CustomerRealViewContacts") IsNot DBNull.Value Then Entity.CustomerRealViewContacts = row.Item("CustomerRealViewContacts")
            If row.Item("CustomerRealViewAttachments") IsNot DBNull.Value Then Entity.CustomerRealViewAttachments = row.Item("CustomerRealViewAttachments")
            If row.Item("CustomerRealViewNotes") IsNot DBNull.Value Then Entity.CustomerRealViewNotes = row.Item("CustomerRealViewNotes")
            If row.Item("CustomerRealAdd") IsNot DBNull.Value Then Entity.CustomerRealAdd = row.Item("CustomerRealAdd")
            If row.Item("CustomerRealEdit") IsNot DBNull.Value Then Entity.CustomerRealEdit = row.Item("CustomerRealEdit")
            If row.Item("CustomerPotentialViewGeneral") IsNot DBNull.Value Then Entity.CustomerPotentialViewGeneral = row.Item("CustomerPotentialViewGeneral")
            If row.Item("CustomerPotentialViewAdress") IsNot DBNull.Value Then Entity.CustomerPotentialViewAdress = row.Item("CustomerPotentialViewAdress")
            If row.Item("CustomerPotentialViewDelivery") IsNot DBNull.Value Then Entity.CustomerPotentialViewDelivery = row.Item("CustomerPotentialViewDelivery")
            If row.Item("CustomerPotentialViewTerms") IsNot DBNull.Value Then Entity.CustomerPotentialViewTerms = row.Item("CustomerPotentialViewTerms")
            If row.Item("CustomerPotentialViewContacts") IsNot DBNull.Value Then Entity.CustomerPotentialViewContacts = row.Item("CustomerPotentialViewContacts")
            If row.Item("CustomerPotentialViewAttachments") IsNot DBNull.Value Then Entity.CustomerPotentialViewAttachments = row.Item("CustomerPotentialViewAttachments")
            If row.Item("CustomerPotentialViewNotes") IsNot DBNull.Value Then Entity.CustomerPotentialViewNotes = row.Item("CustomerPotentialViewNotes")
            If row.Item("CustomerPotentialAdd") IsNot DBNull.Value Then Entity.CustomerPotentialAdd = row.Item("CustomerPotentialAdd")
            If row.Item("CustomerPotentialEdit") IsNot DBNull.Value Then Entity.CustomerPotentialEdit = row.Item("CustomerPotentialEdit")
            If row.Item("Tasks") IsNot DBNull.Value Then Entity.Tasks = row.Item("Tasks")

            If row.Item("CustomerParameters") IsNot DBNull.Value Then Entity.CustomerParameters = row.Item("CustomerParameters")
            If row.Item("TaskParameters") IsNot DBNull.Value Then Entity.TaskParameters = row.Item("TaskParameters")


            Return Entity

        Catch ex As Exception
            Throw ex
        End Try

    End Function



    Public Shared Function Save(ByVal Entity As Profile) As Integer

        Try
            If Entity.Id <= 0 Then ' Profile no creado aún lo inserta, sino lo actualiza
                Insert(Entity)
            Else
                Update(Entity)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Private Shared Function Insert(ByVal Entity As Profile) As Integer
        Dim Actions As List(Of Action)
        Dim Action As Action

        Try
            Actions = New List(Of Action)

            Action = GetActionInsertProfile(Entity)

            Actions.Add(Action)

            ActionHandler.Save(Actions)

        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Private Shared Function Update(ByVal Entity As Profile) As Integer
        Dim Actions As List(Of Action)
        Dim Action As Action

        Try
            Actions = New List(Of Action)

            Action = GetActionUpdateProfile(Entity)
            If Action Is Nothing Then Return 0

            Actions.Add(Action)

            ActionHandler.Save(Actions)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Shared Function GetActionInsertProfile(ByVal Entity As Profile) As Action
        Dim Action As Action

        Try
            Action = New Action(SystemCompany.Id, New User)

            Action.ObjectType = SystemEntities(1)
            Action.FinalObject = EntityHandler.Serialize(Entity)
            Action.sqlType = CommandType.StoredProcedure
            Action.sqlName = SystemCompany.Database & ".dbo.sp_InsertProfile"
            Action.Parameters = ProfileParameters(Entity)
            'Action.Type = SysActiontypes("INSERT")
            Action.InitDate = Now()
            Action.Admin = Action.User
            Action.Status = 1

            Return Action

        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Private Shared Function GetActionUpdateProfile(ByVal Entity As Profile) As Action
        Dim Action As Action

        Try
            Action = New Action(SystemCompany.Id, New User)
            Action.ObjectType = SystemEntities(1)
            Action.FinalObject = EntityHandler.Serialize(Entity)
            Action.sqlType = CommandType.StoredProcedure
            Action.sqlName = SystemCompany.Database & ".dbo.sp_UpdateProfile"
            Action.Parameters = ProfileParameters(Entity)
            Action.Type = New Action.ActionType '   SysActiontypes("UPDATE")
            Action.InitDate = Now()
            Action.Admin = Action.User
            Action.Status = 1

            Return Action

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Shared Function ProfileParameters(ByVal Entity As Profile) As SqlClient.SqlParameter()

        Dim Parameters() As SqlClient.SqlParameter

        Try
            ReDim Parameters(0 To 22)

            Parameters(0) = New SqlClient.SqlParameter("@NAME", SqlDbType.VarChar) With {.Value = Entity.Name}
            Parameters(1) = New SqlClient.SqlParameter("@DESCRIPTION", SqlDbType.VarChar) With {.Value = Entity.Description}
            Parameters(2) = New SqlClient.SqlParameter("@CUSTOMERREALVIEWGENERAL", SqlDbType.Bit) With {.Value = Entity.CustomerRealViewGeneral}
            Parameters(3) = New SqlClient.SqlParameter("@CUSTOMERREALVIEWADRESS", SqlDbType.Bit) With {.Value = Entity.CustomerRealViewAdress}
            Parameters(4) = New SqlClient.SqlParameter("@CUSTOMERREALVIEWDELIVERY", SqlDbType.Bit) With {.Value = Entity.CustomerRealViewDelivery}
            Parameters(5) = New SqlClient.SqlParameter("@CUSTOMERREALVIEWTERMS", SqlDbType.Bit) With {.Value = Entity.CustomerRealViewTerms}
            Parameters(6) = New SqlClient.SqlParameter("@CUSTOMERREALVIEWCONTACTS", SqlDbType.Bit) With {.Value = Entity.CustomerRealViewContacts}
            Parameters(7) = New SqlClient.SqlParameter("@CUSTOMERREALVIEWATTACHMENTS", SqlDbType.Bit) With {.Value = Entity.CustomerRealViewAttachments}
            Parameters(8) = New SqlClient.SqlParameter("@CUSTOMERREALVIEWNOTES", SqlDbType.Bit) With {.Value = Entity.CustomerRealViewNotes}
            Parameters(9) = New SqlClient.SqlParameter("@CUSTOMERREALADD", SqlDbType.Bit) With {.Value = Entity.CustomerRealAdd}
            Parameters(10) = New SqlClient.SqlParameter("@CUSTOMERREALEDIT", SqlDbType.Bit) With {.Value = Entity.CustomerRealEdit}
            Parameters(11) = New SqlClient.SqlParameter("@CUSTOMERPOTENTIALVIEWGENERAL", SqlDbType.Bit) With {.Value = Entity.CustomerPotentialViewGeneral}
            Parameters(12) = New SqlClient.SqlParameter("@CUSTOMERPOTENTIALVIEWADRESS", SqlDbType.Bit) With {.Value = Entity.CustomerPotentialViewAdress}
            Parameters(13) = New SqlClient.SqlParameter("@CUSTOMERPOTENTIALVIEWDELIVERY", SqlDbType.Bit) With {.Value = Entity.CustomerPotentialViewDelivery}
            Parameters(14) = New SqlClient.SqlParameter("@CUSTOMERPOTENTIALVIEWTERMS", SqlDbType.Bit) With {.Value = Entity.CustomerPotentialViewTerms}
            Parameters(15) = New SqlClient.SqlParameter("@CUSTOMERPOTENTIALVIEWCONTACTS", SqlDbType.Bit) With {.Value = Entity.CustomerPotentialViewContacts}
            Parameters(16) = New SqlClient.SqlParameter("@CUSTOMERPOTENTIALVIEWATTACHMENTS", SqlDbType.Bit) With {.Value = Entity.CustomerPotentialViewAttachments}
            Parameters(17) = New SqlClient.SqlParameter("@CUSTOMERPOTENTIALVIEWNOTES", SqlDbType.Bit) With {.Value = Entity.CustomerPotentialViewNotes}
            Parameters(18) = New SqlClient.SqlParameter("@CUSTOMERPOTENTIALADD", SqlDbType.Bit) With {.Value = Entity.CustomerPotentialAdd}
            Parameters(19) = New SqlClient.SqlParameter("@CUSTOMERPOTENTIALEDIT", SqlDbType.Bit) With {.Value = Entity.CustomerPotentialEdit}
            Parameters(20) = New SqlClient.SqlParameter("@TASKS", SqlDbType.Bit) With {.Value = Entity.Tasks}

            Parameters(21) = New SqlClient.SqlParameter("@CUSTOMERPARAMETERS", SqlDbType.Bit) With {.Value = Entity.CustomerParameters}
            Parameters(22) = New SqlClient.SqlParameter("@TASKPARAMETERS", SqlDbType.Bit) With {.Value = Entity.TaskParameters}

            Return Parameters

        Catch ex As Exception
            Throw ex
        End Try

    End Function
End Class
