Public Class ContactRepository

    Private Shared tb As DataTable
    Private Shared Query As String

    Public Shared Function GetById(ByVal Id As Integer) As Contact

        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("ContactById"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<contact>", Id)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return Nothing

            If tb.Rows Is Nothing Then Return Nothing

            If tb.Rows.Count = 0 Then Return Nothing

            Return GetContact(tb.Rows(0))

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Shared Function GetByCustomer(ByVal Customer As String) As List(Of Contact)
        Dim List As List(Of Contact)
        Dim Contact As Contact
        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CstContacts"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<company>", MainCompany.Id), New QueryHandler.Parameter("<customer>", Customer)})

            tb = Database.GetData(Query)

            List = New List(Of Contact)

            If tb Is Nothing Then Return List

            If tb.Rows Is Nothing Then Return List

            If tb.Rows.Count = 0 Then Return List

            For Each row As DataRow In tb.Rows

                Contact = GetContact(row)

                If Contact IsNot Nothing Then List.Add(Contact)

            Next


            Return List

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Shared Function GetContact(ByVal row As DataRow) As Contact
        Dim Contact As Contact

        Try

            If row Is Nothing Then Return Nothing

            Contact = New Contact

            If row.Item("ID") IsNot DBNull.Value Then Contact.Id = row.Item("ID")
            If row.Item("COMPANY") IsNot DBNull.Value Then Contact.CompanyId = row.Item("COMPANY")
            If row.Item("CUSTOMER") IsNot DBNull.Value Then Contact.CustomerCode = row.Item("CUSTOMER")
            If row.Item("NAME") IsNot DBNull.Value Then Contact.Name = row.Item("NAME")
            If row.Item("SURNAME") IsNot DBNull.Value Then Contact.Surname = row.Item("SURNAME")
            If row.Item("TEL") IsNot DBNull.Value Then Contact.Tel = row.Item("TEL")
            If row.Item("FAX") IsNot DBNull.Value Then Contact.Fax = row.Item("FAX")
            If row.Item("BirthDate") IsNot DBNull.Value Then Contact.Birthday = row.Item("BirthDate")
            If row.Item("Email") IsNot DBNull.Value Then Contact.Email = row.Item("Email")
            If row.Item("AlterEmail") IsNot DBNull.Value Then Contact.AlterEmail = row.Item("AlterEmail")
            If row.Item("CUIT") IsNot DBNull.Value Then Contact.CUIT = row.Item("CUIT")
            If row.Item("Hobbies") IsNot DBNull.Value Then Contact.Hobbies = row.Item("Hobbies")
            If row.Item("Details") IsNot DBNull.Value Then Contact.Details = row.Item("Details")

            If row.Item("AREA") IsNot DBNull.Value Then Contact.Area = GetAreaById(CInt(row.Item("AREA")))

            If row.Item("CARGO") IsNot DBNull.Value Then Contact.Cargo = GetCargoById(CInt(row.Item("CARGO")))

            Return Contact

        Catch ex As Exception
            Return Nothing

        End Try

    End Function

    Public Shared Function Save(ByVal Entity As Contact, Optional ByVal OriginalEntity As Contact = Nothing) As Integer

        Try
            If Entity.Id <= 0 Then
                Return Insert(Entity)
            Else
                Return Update(Entity, OriginalEntity)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Private Shared Function Insert(ByVal Entity As Contact) As Integer
        Dim Actions As List(Of Action)
        Dim Action As Action

        Try
            Actions = New List(Of Action)

            Action = GetActionInsertContact(Entity)

            Actions.Add(Action)

            Return ActionHandler.Save(Actions)

        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Private Shared Function Update(ByVal Entity As Contact, ByVal OriginalEntity As Contact) As Integer
        Dim Actions As List(Of Action)
        Dim Action As Action

        Try
            Actions = New List(Of Action)

            Action = GetActionUpdateContact(Entity, OriginalEntity)
            If Action Is Nothing Then Return 0

            Actions.Add(Action)

            ActionHandler.Save(Actions)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Shared Function GetActionInsertContact(ByVal Entity As Contact) As Action
        Dim Action As Action

        Try
            Action = New Action(MainCompany.Id, SystemUser)

            Action.ObjectType = SystemEntities(1)
            Action.FinalObject = EntityHandler.Serialize(Entity)
            Action.sqlType = CommandType.StoredProcedure
            Action.sqlName = SystemCompany.Database & ".dbo.sp_InsertContact"
            Action.Parameters = ContactParameters(Entity)
            'Action.Type = SysActiontypes("INSERT")
            Action.InitDate = Now()
            Action.Admin = Action.User
            Action.Status = 1

            Return Action

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Shared Function GetActionUpdateContact(ByVal Entity As Contact, ByVal OriginalEntity As Contact) As Action
        Dim Action As Action

        Try
            Action = New Action(MainCompany.Id, SystemUser)
            Action.ObjectType = SystemEntities(1)
            Action.OriginalObject = EntityHandler.Serialize(OriginalEntity)
            Action.FinalObject = EntityHandler.Serialize(Entity)
            Action.sqlType = CommandType.StoredProcedure
            Action.sqlName = SystemCompany.Database & ".dbo.sp_UpdateContact"
            Action.Parameters = ContactParameters(Entity)
            'Action.Type = SysActiontypes("UPDATE")
            Action.InitDate = Now()
            Action.Admin = Action.User
            Action.Status = 1

            Return Action

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Shared Function ContactParameters(ByVal Entity As Contact) As SqlClient.SqlParameter()

        Dim Parameters() As SqlClient.SqlParameter

        Try
            ReDim Parameters(0 To 12)

            Parameters(0) = New SqlClient.SqlParameter("@ID", SqlDbType.Int) With {.Value = Entity.Id}
            Parameters(1) = New SqlClient.SqlParameter("@COMPANY", SqlDbType.Int) With {.Value = Entity.CompanyId}
            Parameters(2) = New SqlClient.SqlParameter("@CUSTOMER", SqlDbType.VarChar) With {.Value = Entity.CustomerCode}
            Parameters(3) = New SqlClient.SqlParameter("@NAME", SqlDbType.VarChar) With {.Value = Entity.Name}
            Parameters(4) = New SqlClient.SqlParameter("@SURNAME", SqlDbType.VarChar) With {.Value = Entity.Surname}
            Parameters(5) = New SqlClient.SqlParameter("@TEL", SqlDbType.VarChar) With {.Value = Entity.Tel}
            Parameters(6) = New SqlClient.SqlParameter("@FAX", SqlDbType.VarChar) With {.Value = Entity.Fax}
            Parameters(7) = New SqlClient.SqlParameter("@Birthdate", SqlDbType.DateTime) With {.Value = Format(Entity.Birthday, "yyyy/MM/dd")}
            Parameters(8) = New SqlClient.SqlParameter("@Email", SqlDbType.VarChar) With {.Value = Entity.Email}
            Parameters(9) = New SqlClient.SqlParameter("@AlterEmail", SqlDbType.VarChar) With {.Value = Entity.AlterEmail}
            Parameters(10) = New SqlClient.SqlParameter("@CUIT", SqlDbType.VarChar) With {.Value = Entity.CUIT}
            Parameters(11) = New SqlClient.SqlParameter("@Hobbies", SqlDbType.VarChar) With {.Value = Entity.Hobbies}
            Parameters(12) = New SqlClient.SqlParameter("@Details", SqlDbType.VarChar) With {.Value = Entity.Details}

            If Entity.Area IsNot Nothing Then
                ReDim Preserve Parameters(0 To UBound(Parameters) + 1)
                Parameters(UBound(Parameters)) = New SqlClient.SqlParameter("@AREA", SqlDbType.Int) With {.Value = Entity.Area.Id}
            End If

            If Entity.Cargo IsNot Nothing Then
                ReDim Preserve Parameters(0 To UBound(Parameters) + 1)
                Parameters(UBound(Parameters)) = New SqlClient.SqlParameter("@CARGO", SqlDbType.Int) With {.Value = Entity.Cargo.Id}
            End If


            Return Parameters

        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Public Shared Function GetAreas() As List(Of Contact.ContactArea)
        Dim List As List(Of Contact.ContactArea)
        Dim Area As Contact.ContactArea

        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("ContactAreas"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            tb = Database.GetData(Query)

            List = New List(Of Contact.ContactArea)

            If tb Is Nothing Then Return List

            If tb.Rows Is Nothing Then Return List

            If tb.Rows.Count = 0 Then Return List

            For Each row As DataRow In tb.Rows

                Area = New Contact.ContactArea

                Area.Id = row.Item("ID")
                Area.Name = row.Item("NAME")
                Area.Description = row.Item("DescripTion")

                If Area IsNot Nothing Then List.Add(Area)
            Next


            Return List

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function GetTableAreas() As DataTable

        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("ContactAreas"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            Return Database.GetData(Query)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function SaveArea(ByVal Code As Integer, ByVal Name As String, ByVal Description As String, ByVal Otherdetails As String) As Integer
        Dim SaveAction As Domain.Action
        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("SaveArea"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<code>", Code), New QueryHandler.Parameter("<name>", Name), New QueryHandler.Parameter("<description>", Description), New QueryHandler.Parameter("<otherdetails>", Otherdetails)})

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

    Public Shared Function GetCargos() As List(Of Contact.ContactCargo)
        Dim List As List(Of Contact.ContactCargo)
        Dim Cargo As Contact.ContactCargo

        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("ContactCargos"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            tb = Database.GetData(Query)

            List = New List(Of Contact.ContactCargo)

            If tb Is Nothing Then Return List

            If tb.Rows Is Nothing Then Return List

            If tb.Rows.Count = 0 Then Return List

            For Each row As DataRow In tb.Rows

                Cargo = New Contact.ContactCargo

                Cargo.Id = row.Item("ID")
                Cargo.Name = row.Item("Name")
                Cargo.Description = row.Item("Description")

                If Cargo IsNot Nothing Then List.Add(Cargo)
            Next


            Return List

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function GetTableCargos() As DataTable

        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("ContactCargos"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            Return Database.GetData(Query)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function SaveCargo(ByVal Code As Integer, ByVal Name As String, ByVal Description As String, ByVal Otherdetails As String) As Integer
        Dim SaveAction As Domain.Action
        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("SaveCargo"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<code>", Code), New QueryHandler.Parameter("<name>", Name), New QueryHandler.Parameter("<description>", Description), New QueryHandler.Parameter("<otherdetails>", Otherdetails)})

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

    Public Shared Function GetAreaById(ByVal Id As Integer) As Contact.ContactArea
        Dim Area As Contact.ContactArea

        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("AreaById"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<area>", Id)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return Nothing

            If tb.Rows Is Nothing Then Return Nothing

            If tb.Rows.Count = 0 Then Return Nothing

            Area = New Contact.ContactArea

            Area.Id = tb.Rows(0).Item("ID")
            Area.Name = tb.Rows(0).Item("NAME")
            Area.Description = tb.Rows(0).Item("DESCRIPTION")

            Return Area

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function GetCargoById(ByVal Id As Integer) As Contact.ContactCargo
        Dim Cargo As Contact.ContactCargo

        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CargoById"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<cargo>", Id)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return Nothing

            If tb.Rows Is Nothing Then Return Nothing

            If tb.Rows.Count = 0 Then Return Nothing

            Cargo = New Contact.ContactCargo

            Cargo.Id = tb.Rows(0).Item("ID")
            Cargo.Name = tb.Rows(0).Item("Name")
            Cargo.Description = tb.Rows(0).Item("Description")

            Return Cargo

        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
