Public Class ActionHandler

    Private Shared Query As String
    Private Shared tb As DataTable

    Public Shared Function GetById(ByVal Id As Integer) As Action
        Dim Query As String
        Dim tb As DataTable

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("ActionByCode"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<code>", Id)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return Nothing

            If tb.Rows Is Nothing Then Return Nothing

            Return GetAction(tb.Rows(0))

        Catch ex As Exception
            Return Nothing
        End Try


    End Function

    Public Shared Function GetByOwner(ByVal Owner As Integer) As List(Of Action)
       Dim List As List(Of Action)
        Dim Action As Action

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("ActionByCode"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<database>", MainCompany.Database), New QueryHandler.Parameter("<Owner>", Owner)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return Nothing

            List = New List(Of Action)

            If tb.Rows Is Nothing Then Return List

            For Each row As DataRow In tb.Rows

                Action = GetAction(row)
                If Action IsNot Nothing Then List.Add(Action)

            Next

            Return List

        Catch ex As Exception
            Return Nothing
        End Try


    End Function

    Private Shared Function GetAction(ByVal row As DataRow) As Action
        Dim action As Action

        Try
            If row Is Nothing Then Return Nothing

            action = New Action

            If row.Item("ID") IsNot DBNull.Value Then action.Id = row.Item("ID")
            If row.Item("IDOWNER") IsNot DBNull.Value Then action.IdOwner = row.Item("IDOWNER")
            If row.Item("IDDATABASE") IsNot DBNull.Value Then action.IdDatabase = row.Item("IDDATABASE")
            If row.Item("OBJECTTYPE") IsNot DBNull.Value Then action.ObjectType = SystemEntities(row.Item("OBJECTTYPE"))
            If row.Item("ORIGINALOBJECT") IsNot DBNull.Value And row.Item("ORIGINALOBJECT") <> "" Then action.OriginalObject = EntityHandler.Deserialize(action.ObjectType.ClassName, row.Item("ORIGINALOBJECT"))
            If row.Item("FINALOBJECT") IsNot DBNull.Value And row.Item("FINALOBJECT") <> "" Then action.FinalObject = EntityHandler.Deserialize(action.ObjectType.ClassName, row.Item("FINALOBJECT"))
            If row.Item("SQLSTRING") IsNot DBNull.Value Then action.SqlString = row.Item("SQLSTRING")
            If row.Item("TYPE") IsNot DBNull.Value Then action.Type = New Action.ActionType 'SysActiontypes(row.Item("TYPE"))
            If row.Item("IDUSER") IsNot DBNull.Value Then action.User = UserRepository.GetById(row.Item("IDUSER"))
            If row.Item("IDADMIN") IsNot DBNull.Value Then action.Admin = UserRepository.GetById(row.Item("IDADMIN"))
            If row.Item("INITDATE") IsNot DBNull.Value Then action.InitDate = row.Item("INITDATE")
            If row.Item("PROCESSDATE") IsNot DBNull.Value Then action.ProcessDate = row.Item("PROCESSDATE")
            If row.Item("STATUS") IsNot DBNull.Value Then action.Status = row.Item("STATUS")

            action.Parameters = GetActionParameters(action.Id)

            Return action

        Catch ex As Exception
            Return Nothing

        End Try
    End Function

    Private Shared Function GetActionParameters(ByVal ActionId As Integer) As SqlClient.SqlParameter()
        Dim Parameters() As SqlClient.SqlParameter
        Dim Counter As Integer

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("ActionParameter"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<action>", ActionId)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return Nothing

            If tb.Rows Is Nothing Then Return Nothing

            ReDim Parameters(0 To tb.Rows.Count - 1)

            For Each row As DataRow In tb.Rows

                Parameters(Counter) = New SqlClient.SqlParameter
                Parameters(Counter).ParameterName = row.Item(0)
                Parameters(Counter).DbType = row.Item(1)
                Parameters(Counter).Value = row.Item(2)

                Counter = Counter + 1

            Next

            Return Parameters

        Catch ex As Exception
            Return Nothing

        End Try
    End Function


    Public Shared Function Save(ByVal Actions As List(Of Action)) As Integer
        Dim Owner As Action

        Try

            If Actions Is Nothing Then Return 0

            If Actions.Count <= 0 Then Return 0

            Database.BeginTrans()

            Owner = Actions(0)

            Owner.Id = Insert(Owner)

            For Each Action As Action In Actions

                If Action IsNot Owner Then

                    Action.IdOwner = Owner.Id

                    Action.Id = Insert(Action)

                End If

            Next

            Database.CommitTrans()

            'Owner de la Accion puede Ejecutarla
            'de lo contrario se notifica al Owner
            'por sistema.

            If Owner.Status = 1 Then
                Execute(Actions)
            Else
                Notify(Owner)
            End If


        Catch ex As Exception
            Database.Rollback()
            Throw ex
        End Try

    End Function

    Public Shared Function Save(ByVal Action As Action) As Integer

        Try

            If Action Is Nothing Then Return 0

            Database.BeginTrans()

            Action.Id = Insert(Action)

            Database.CommitTrans()

            If Action.Status = 1 Then
                Execute(Action)
            Else
                Notify(Action)
            End If

        Catch ex As Exception
            Database.Rollback()
            Return 0
        End Try

    End Function

    Private Shared Function Insert(ByVal Entity As Action) As Integer
        Dim Id As Integer
        Dim CommandString As String
        Dim InsertParameters(0 To 12) As SqlClient.SqlParameter

        Try

            InsertParameters(0) = New SqlClient.SqlParameter("@OWNER", SqlDbType.Int) With {.Value = Entity.IdOwner}
            InsertParameters(1) = New SqlClient.SqlParameter("@IDDATABASE", SqlDbType.Int) With {.Value = MainCompany.Id}
            InsertParameters(2) = New SqlClient.SqlParameter("@IDOBJECT", SqlDbType.Int) With {.Value = 0}
            InsertParameters(3) = New SqlClient.SqlParameter("@OBJECTTYPE", SqlDbType.Int) With {.Value = Entity.ObjectType.Id}
            InsertParameters(4) = New SqlClient.SqlParameter("@ORIGINALOBJECT", SqlDbType.VarChar) With {.Value = Entity.OriginalObject}
            InsertParameters(5) = New SqlClient.SqlParameter("@FINALOBJECT", SqlDbType.VarChar) With {.Value = Entity.FinalObject}
            InsertParameters(6) = New SqlClient.SqlParameter("@SQLTYPE", SqlDbType.Int) With {.Value = Entity.sqlType}
            InsertParameters(7) = New SqlClient.SqlParameter("@SQLNAME", SqlDbType.VarChar) With {.Value = Entity.sqlName}
            InsertParameters(8) = New SqlClient.SqlParameter("@SQLSTRING", SqlDbType.VarChar) With {.Value = Entity.SqlString}
            InsertParameters(9) = New SqlClient.SqlParameter("@TYPE", SqlDbType.Int) With {.Value = 0} 'Entity.Type.Id}
            InsertParameters(10) = New SqlClient.SqlParameter("@USER", SqlDbType.Int) With {.Value = Entity.User.Id}
            InsertParameters(11) = New SqlClient.SqlParameter("@INITDATE", SqlDbType.DateTime) With {.Value = Format(Entity.InitDate, "yyyy/MM/dd")}
            InsertParameters(12) = New SqlClient.SqlParameter("@STATUS", SqlDbType.Int) With {.Value = Entity.Status}

            Id = Database.ExecuteSpCommand(SystemCompany.Database & ".dbo.InsertAction ", InsertParameters)

            For Each Parameter As SqlClient.SqlParameter In Entity.Parameters

                CommandString = ""
                CommandString = CommandString & "EXEC " & SystemCompany.Database & ".dbo.sp_InsertActionParameter "
                CommandString = CommandString & "@ID =" & Id & ", "
                CommandString = CommandString & "@NAME = '" & Parameter.ParameterName & "', "
                CommandString = CommandString & "@TYPE = " & Parameter.DbType & ", "
                CommandString = CommandString & "@VALUE = '" & Parameter.Value & "' "

                Database.ExecuteCommand(CommandString)

            Next

            Return Id

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function Execute(ByVal Actions As List(Of Action)) As Integer

        Try

            Database.BeginTrans()

            For Each Entity As Action In Actions

                If Entity.sqlType = CommandType.StoredProcedure Then
                    Database.ExecuteSpCommand(Entity.sqlName, Entity.Parameters)
                ElseIf Entity.sqlType = CommandType.Text Then
                    Database.ExecuteCommand(Replace(Entity.SqlString, Chr(166), "'"))
                End If

                Database.ExecuteSpCommand(SystemCompany.Database & ".dbo.sp_ActionProcessed", New SqlClient.SqlParameter() {New SqlClient.SqlParameter("@Action", Entity.Id)})

            Next



            Database.CommitTrans()

        Catch ex As Exception
            Database.Rollback()
            Throw ex
        End Try

    End Function

    Public Shared Function Execute(ByVal Action As Action) As Integer

        Try

            Database.BeginTrans()

            If Action.sqlType = CommandType.StoredProcedure Then
                Database.ExecuteSpCommand(Action.sqlName, GetParameters(Action.sqlParameters))
            ElseIf Action.sqlType = CommandType.Text Then
                Database.ExecuteCommand(Replace(Action.SqlString, Chr(166), "'"))
            End If

            Database.CommitTrans()

        Catch ex As Exception
            Database.Rollback()

        End Try

    End Function

    Private Shared Function GetParameters(ByVal ActionParameters As String) As SqlClient.SqlParameter()
        Dim Parameters() As SqlClient.SqlParameter
        Dim Parameter() As String
        Dim TextParameters() As String

        Try
            ActionParameters = Replace(ActionParameters, Chr(166), "'")
            TextParameters = Split(ActionParameters, "§")

            ReDim Parameters(0 To TextParameters.Length - 1)

            For Counter = 0 To TextParameters.Length - 1
                Parameter = Split(TextParameters(Counter), "=")
                Parameters(Counter) = New SqlClient.SqlParameter(Trim(Parameter(0)), Parameter(1))
                Console.WriteLine(Trim(Parameter(0)) & "=" & Parameter(1))
            Next

            Return Parameters

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Shared Function Notify(ByVal Entity As Action) As Boolean
        Dim Report As String

        Try

            Report = "El usuario " & Entity.User.FullName & " ha generado una solicitud de " '& Entity.Type.Description

            If Entity.Admin.Mail IsNot Nothing Then SmtpServer.SendMail(Entity.Admin.Mail, "SOLICITUD DE AUTORIZACION", Report)

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class
