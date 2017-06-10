Public Class AlertRepository

    Private Shared Query As String
    Private Shared tb As DataTable



    Public Shared Function SaveAlert(ByVal Entity As Alert) As Boolean
        Dim Parameters As SqlClient.SqlParameter()
        Dim Action As Action
        Try

            If Entity Is Nothing Then Return False

            ReDim Parameters(0 To 5)
            Parameters(0) = New SqlClient.SqlParameter("@COMPANY", SqlDbType.Int) With {.Value = MainCompany.Id}
            If Entity.Profile IsNot Nothing Then
                Parameters(1) = New SqlClient.SqlParameter("@PROFILE", SqlDbType.Int) With {.Value = Entity.Profile.Id}
            Else
                Parameters(1) = New SqlClient.SqlParameter("@PROFILE", SqlDbType.Int) With {.Value = 0}
            End If
            Parameters(2) = New SqlClient.SqlParameter("@USER", SqlDbType.Int) With {.Value = SystemUser.Id}
            Parameters(3) = New SqlClient.SqlParameter("@SUBJECT", SqlDbType.VarChar) With {.Value = Entity.Subject}
            Parameters(4) = New SqlClient.SqlParameter("@DETAILS", SqlDbType.VarChar) With {.Value = Entity.Detail}
            Parameters(5) = New SqlClient.SqlParameter("@INITDATE", SqlDbType.DateTime) With {.Value = Format(Entity.Initdate, "yyyy/MM/dd hh:mm:ss tt")}

            Action = New Action(MainCompany.Id, SystemUser)
            Action.ObjectType = SystemEntities(1)
            Action.sqlType = CommandType.StoredProcedure
            Action.sqlName = SystemCompany.Database & ".dbo.sp_InsertAlert"
            Action.Parameters = Parameters
            Action.InitDate = Now()
            Action.Admin = Action.User
            Action.Status = 1

            ActionHandler.Save(Action)

        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Shared Function GetAlerts(ByVal UserId As Integer, ByVal ProfileId As Integer) As List(Of Alert)
        Dim List As List(Of Alert)
        Dim Entity As Alert
        Try

            List = New List(Of Alert)

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("UserAlerts"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<user>", UserId), New QueryHandler.Parameter("<profile>", ProfileId), New QueryHandler.Parameter("<company>", MainCompany.Id)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return List

            If tb.Rows Is Nothing Then Return List

            List = New List(Of Alert)

            If tb.Rows.Count = 0 Then Return List

            For Each row As DataRow In tb.Rows

                Entity = GetAlert(row)

                If Entity IsNot Nothing Then List.Add(Entity)

            Next

            Return List

        Catch ex As Exception
            Return New List(Of Alert)
        End Try

    End Function

    Public Shared Function GetAlertById(ByVal AlertId As Integer) As Alert
        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("AlertById"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<alert>", AlertId)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return Nothing

            If tb.Rows Is Nothing Then Return Nothing

            If tb.Rows.Count = 0 Then Return Nothing

            Return GetAlert(tb.Rows(0))

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Shared Function GetAllAlerts(ByVal UserId As Integer, ByVal ProfileId As Integer) As List(Of Alert)
        Dim List As List(Of Alert)
        Dim Entity As Alert
        Try

            List = New List(Of Alert)

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("AlertByUser"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<user>", UserId), New QueryHandler.Parameter("<profile>", ProfileId), New QueryHandler.Parameter("<company>", MainCompany.Id)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return List

            If tb.Rows Is Nothing Then Return List

            List = New List(Of Alert)

            If tb.Rows.Count = 0 Then Return List

            For Each row As DataRow In tb.Rows

                Entity = GetAlert(row)

                If Entity IsNot Nothing Then List.Add(Entity)

            Next

            Return List

        Catch ex As Exception
            Return New List(Of Alert)
        End Try

    End Function

    Private Shared Function GetAlert(ByVal row As DataRow) As Alert
        Dim Alert As Alert

        Try
            If row Is Nothing Then Return Nothing

            Alert = New Alert

            If row.Item("ID") IsNot DBNull.Value Then Alert.Id = row.Item("ID")
            If row.Item("COMPANY") IsNot DBNull.Value Then Alert.CompanyId = row.Item("COMPANY")
            'If row.Item("IDUSER") IsNot DBNull.Value Then Alert.User = row.Item("IDUSER")
            'If row.Item("PROFILE") IsNot DBNull.Value Then Alert.Profile = row.Item("PROFILE")
            If row.Item("SUBJECT") IsNot DBNull.Value Then Alert.Subject = row.Item("SUBJECT")
            If row.Item("DETAIL") IsNot DBNull.Value Then Alert.Detail = row.Item("DETAIL")
            If row.Item("Initdate") IsNot DBNull.Value Then Alert.Initdate = row.Item("Initdate")
            If row.Item("EXECUTEDATE") IsNot DBNull.Value Then Alert.ExecuteDate = row.Item("EXECUTEDATE")
            If row.Item("ACTIVE") IsNot DBNull.Value Then Alert.Active = row.Item("ACTIVE")

            Alert.User = SystemUser
            Alert.Profile = SystemUser.Profile

            Return Alert

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function TimeTypes() As List(Of Alert.TimeType)
        Dim List As List(Of Alert.TimeType)
        Dim Entity As Alert.TimeType
        Try

            List = New List(Of Alert.TimeType)

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("AlertTimeTypes"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return List

            If tb.Rows Is Nothing Then Return List

            List = New List(Of Alert.TimeType)

            If tb.Rows.Count = 0 Then Return List

            For Each row As DataRow In tb.Rows

                Entity = New Alert.TimeType

                If row.Item("ID") IsNot DBNull.Value Then Entity.Id = row.Item("ID")
                If row.Item("NAME") IsNot DBNull.Value Then Entity.Name = row.Item("NAME")
                If row.Item("MINUTES") IsNot DBNull.Value Then Entity.Minutes = row.Item("MINUTES")

                If Entity IsNot Nothing Then List.Add(Entity)

            Next

            Return List

        Catch ex As Exception
            Return New List(Of Alert.TimeType)
        End Try
    End Function

    Public Shared Function DiscardAlert(ByVal AlertId As Integer) As Integer
        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("DiscardAlert"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<alert>", AlertId)})

            Return Database.ExecuteCommand(Query)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function RestoreAlert(ByVal AlertId As Integer) As Integer
        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("RestoreAlert"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<alert>", AlertId)})

            Return Database.ExecuteCommand(Query)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function SuspendAlert(ByVal AlertId As Integer, ByVal Minutes As Integer, ByVal TimeType As Integer) As Integer
        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("SuspendAlert"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<alert>", AlertId), New QueryHandler.Parameter("<minutes>", Minutes), New QueryHandler.Parameter("<timetype>", TimeType)})

            Return Database.ExecuteCommand(Query)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
