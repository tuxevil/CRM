Public Class ReportRepository

    Private Shared Query As String
    Private Shared tb As DataTable


    Public Shared Function TaskList(ByVal UserFrom As String, ByVal UserTo As String, ByVal DateFrom As Date, ByVal DateTo As Date, ByVal TypeFrom As String, ByVal TypeTo As String, ByVal StateFrom As String, ByVal StateTo As String) As DataTable

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("RptTaskList"), New QueryHandler.Parameter() { _
                                             New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), _
                                             New QueryHandler.Parameter("<company>", MainCompany.Id), _
                                             New QueryHandler.Parameter("<userfrom>", UserFrom), _
                                             New QueryHandler.Parameter("<userto>", UserTo), _
                                             New QueryHandler.Parameter("<datefrom>", Format(DateFrom, "yyyy-MM-dd")), _
                                             New QueryHandler.Parameter("<dateto>", Format(DateTo, "yyyy-MM-dd")), _
                                             New QueryHandler.Parameter("<typefrom>", TypeFrom), _
                                             New QueryHandler.Parameter("<typeto>", TypeTo), _
                                             New QueryHandler.Parameter("<statefrom>", StateFrom), _
                                             New QueryHandler.Parameter("<stateto>", StateTo)})

            Return Database.GetData(Query)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Public Shared Function EventList(ByVal UserFrom As String, ByVal UserTo As String, ByVal DateFrom As Date, ByVal DateTo As Date, ByVal TypeFrom As String, ByVal TypeTo As String, ByVal StateFrom As String, ByVal StateTo As String, ByVal EventFrom As String, ByVal EventTo As String) As DataTable

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("RptEventList"), New QueryHandler.Parameter() { _
                                             New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), _
                                             New QueryHandler.Parameter("<company>", MainCompany.Id), _
                                             New QueryHandler.Parameter("<userfrom>", UserFrom), _
                                             New QueryHandler.Parameter("<userto>", UserTo), _
                                             New QueryHandler.Parameter("<datefrom>", Format(DateFrom, "yyyy-MM-dd")), _
                                             New QueryHandler.Parameter("<dateto>", Format(DateTo, "yyyy-MM-dd")), _
                                             New QueryHandler.Parameter("<typefrom>", TypeFrom), _
                                             New QueryHandler.Parameter("<typeto>", TypeTo), _
                                             New QueryHandler.Parameter("<statefrom>", StateFrom), _
                                             New QueryHandler.Parameter("<stateto>", StateTo), _
                                             New QueryHandler.Parameter("<eventfrom>", EventFrom), _
                                             New QueryHandler.Parameter("<eventto>", EventTo)})

            Return Database.GetData(Query)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function



    Public Shared Function TaskDetails(ByVal UserFrom As String, ByVal UserTo As String, ByVal DateFrom As Date, ByVal DateTo As Date, ByVal TypeFrom As String, ByVal TypeTo As String, ByVal StateFrom As String, ByVal StateTo As String) As DataTable

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("RptTaskDetails"), New QueryHandler.Parameter() { _
                                             New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), _
                                             New QueryHandler.Parameter("<company>", MainCompany.Id), _
                                             New QueryHandler.Parameter("<userfrom>", UserFrom), _
                                             New QueryHandler.Parameter("<userto>", UserTo), _
                                             New QueryHandler.Parameter("<datefrom>", Format(DateFrom, "yyyy-MM-dd")), _
                                             New QueryHandler.Parameter("<dateto>", Format(DateTo, "yyyy-MM-dd")), _
                                             New QueryHandler.Parameter("<typefrom>", TypeFrom), _
                                             New QueryHandler.Parameter("<typeto>", TypeTo), _
                                             New QueryHandler.Parameter("<statefrom>", StateFrom), _
                                             New QueryHandler.Parameter("<stateto>", StateTo)})

            Return Database.GetData(Query)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Public Shared Function PotentialCustomersEntry(ByVal UserFrom As String, ByVal UserTo As String, ByVal DateFrom As Date, ByVal DateTo As Date, ByVal CustomerFrom As String, ByVal CustomerTo As String) As DataTable

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("RptPCstEntry"), New QueryHandler.Parameter() { _
                                             New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), _
                                             New QueryHandler.Parameter("<company>", MainCompany.Id), _
                                             New QueryHandler.Parameter("<userfrom>", UserFrom), _
                                             New QueryHandler.Parameter("<userto>", UserTo), _
                                             New QueryHandler.Parameter("<datefrom>", Format(DateFrom, "yyyy-MM-dd")), _
                                             New QueryHandler.Parameter("<dateto>", Format(DateTo, "yyyy-MM-dd")), _
                                             New QueryHandler.Parameter("<customerfrom>", CustomerFrom), _
                                             New QueryHandler.Parameter("<customerto>", CustomerTo)})

            Return Database.GetData(Query)

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Shared Function PotentialCustomersToTango(ByVal UserFrom As String, ByVal UserTo As String, ByVal DateFrom As Date, ByVal DateTo As Date, ByVal CustomerFrom As String, ByVal CustomerTo As String, ByVal TangoFrom As Date, ByVal TangoTo As Date) As DataTable

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("RptCrmToTango"), New QueryHandler.Parameter() { _
                                             New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), _
                                             New QueryHandler.Parameter("<company>", MainCompany.Id), _
                                             New QueryHandler.Parameter("<userfrom>", UserFrom), _
                                             New QueryHandler.Parameter("<userto>", UserTo), _
                                             New QueryHandler.Parameter("<datefrom>", Format(DateFrom, "yyyy-MM-dd")), _
                                             New QueryHandler.Parameter("<dateto>", Format(DateTo, "yyyy-MM-dd")), _
                                             New QueryHandler.Parameter("<tangofrom>", Format(TangoFrom, "yyyy-MM-dd")), _
                                             New QueryHandler.Parameter("<tangoto>", Format(TangoTo, "yyyy-MM-dd")), _
                                             New QueryHandler.Parameter("<customerfrom>", CustomerFrom), _
                                             New QueryHandler.Parameter("<customerto>", CustomerTo)})

            Return Database.GetData(Query)

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Shared Function CustomersDeleted(ByVal PotentialCustomers As Boolean, ByVal UserFrom As String, ByVal UserTo As String, ByVal DateFrom As Date, ByVal DateTo As Date, ByVal CustomerFrom As String, ByVal CustomerTo As String, ByVal ReassonFrom As Integer, ByVal ReassonTo As Integer, ByVal ProcessedActions As Boolean, ByVal NotProcessedActions As Boolean) As DataTable

        Try

            If PotentialCustomers Then
                Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("RptRCstDeleted"), New QueryHandler.Parameter() { _
                                                 New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), _
                                                 New QueryHandler.Parameter("<company>", MainCompany.Id), _
                                                 New QueryHandler.Parameter("<userfrom>", UserFrom), _
                                                 New QueryHandler.Parameter("<userto>", UserTo), _
                                                 New QueryHandler.Parameter("<datefrom>", Format(DateFrom, "yyyy-MM-dd")), _
                                                 New QueryHandler.Parameter("<dateto>", Format(DateTo, "yyyy-MM-dd")), _
                                                 New QueryHandler.Parameter("<customerfrom>", CustomerFrom), _
                                                 New QueryHandler.Parameter("<customerto>", CustomerTo), _
                                                 New QueryHandler.Parameter("<reassonfrom>", ReassonFrom), _
                                                 New QueryHandler.Parameter("<reassonto>", ReassonTo), _
                                                 New QueryHandler.Parameter("<statusprocessed>", Val(ProcessedActions)), _
                                                 New QueryHandler.Parameter("<statusnotprocessed>", Val(Not NotProcessedActions))})

            Else
                Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("RptRCstDeleted"), New QueryHandler.Parameter() { _
                                                 New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), _
                                                 New QueryHandler.Parameter("<database>", MainCompany.Database), _
                                                 New QueryHandler.Parameter("<company>", MainCompany.Id), _
                                                 New QueryHandler.Parameter("<userfrom>", UserFrom), _
                                                 New QueryHandler.Parameter("<userto>", UserTo), _
                                                 New QueryHandler.Parameter("<datefrom>", Format(DateFrom, "yyyy-MM-dd")), _
                                                 New QueryHandler.Parameter("<dateto>", Format(DateTo, "yyyy-MM-dd")), _
                                                 New QueryHandler.Parameter("<customerfrom>", CustomerFrom), _
                                                 New QueryHandler.Parameter("<customerto>", CustomerTo), _
                                                 New QueryHandler.Parameter("<reassonfrom>", ReassonFrom), _
                                                 New QueryHandler.Parameter("<reassonto>", ReassonTo), _
                                                 New QueryHandler.Parameter("<statusprocessed>", Val(ProcessedActions)), _
                                                 New QueryHandler.Parameter("<statusnotprocessed>", Val(Not NotProcessedActions))})

            End If

            Return Database.GetData(Query)

        Catch ex As Exception
            Return Nothing
        End Try

    End Function




    Public Shared Function CustomersList(ByVal PotentialCustomers As Boolean, ByVal CustomerFrom As String, ByVal CustomerTo As String, ByVal ZoneFrom As String, ByVal ZoneTo As String, ByVal StateFrom As String, ByVal StateTo As String, ByVal EmployeeFrom As String, ByVal EmployeeTo As String) As DataTable

        Try

            If PotentialCustomers Then
                Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("RptPCstList"), New QueryHandler.Parameter() { _
                                                 New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), _
                                                 New QueryHandler.Parameter("<database>", MainCompany.Database), _
                                                 New QueryHandler.Parameter("<company>", MainCompany.Id), _
                                                 New QueryHandler.Parameter("<customerfrom>", CustomerFrom), _
                                                 New QueryHandler.Parameter("<customerto>", CustomerTo), _
                                                 New QueryHandler.Parameter("<zonefrom>", ZoneFrom), _
                                                 New QueryHandler.Parameter("<zoneto>", ZoneTo), _
                                                 New QueryHandler.Parameter("<statefrom>", StateFrom), _
                                                 New QueryHandler.Parameter("<stateto>", StateTo), _
                                                 New QueryHandler.Parameter("<employeefrom>", EmployeeFrom), _
                                                 New QueryHandler.Parameter("<employeeto>", EmployeeTo)})

            Else
                Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("RptRCstList"), New QueryHandler.Parameter() { _
                                                 New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), _
                                                 New QueryHandler.Parameter("<database>", MainCompany.Database), _
                                                 New QueryHandler.Parameter("<company>", MainCompany.Id), _
                                                 New QueryHandler.Parameter("<customerfrom>", CustomerFrom), _
                                                 New QueryHandler.Parameter("<customerto>", CustomerTo), _
                                                 New QueryHandler.Parameter("<zonefrom>", ZoneFrom), _
                                                 New QueryHandler.Parameter("<zoneto>", ZoneTo), _
                                                 New QueryHandler.Parameter("<statefrom>", StateFrom), _
                                                 New QueryHandler.Parameter("<stateto>", StateTo), _
                                                 New QueryHandler.Parameter("<employeefrom>", EmployeeFrom), _
                                                 New QueryHandler.Parameter("<employeeto>", EmployeeTo)})
            End If

            Return Database.GetData(Query)

        Catch ex As Exception
            Return Nothing
        End Try

    End Function


End Class
