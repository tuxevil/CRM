Public Class CustomerRepository

    Private Shared Query As String
    Private Shared tb As DataTable
    Private lCount As Long

    Public Shared Function GetCodes(ByVal OwnerCustomers As Boolean, ByVal User As Integer, Optional ByVal AllCustomers As Boolean = False) As List(Of String)
        Dim List As List(Of String)

        Try
            ' MsgBox("Entra al GetCodes inc", MsgBoxStyle.Information)
            List = New List(Of String)

            ' MsgBox("OwnerCustomers=" & OwnerCustomers)
            ' MsgBox("AllCustomers =" & AllCustomers)

            If OwnerCustomers Then

                If Not AllCustomers Then
                    Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("UserCstPCodes"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<user>", User), New QueryHandler.Parameter("<company>", MainCompany.Id)})
                Else
                    Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CstPCodes"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<company>", MainCompany.Id)})
                End If

            Else

                If Not AllCustomers Then
                    Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("UserCstRCodes"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<database>", MainCompany.Database), New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<user>", User), New QueryHandler.Parameter("<company>", MainCompany.Id)})
                Else
                    Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CstRCodes"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<database>", MainCompany.Database)})
                End If

            End If

            tb = Database.GetData(Query)

            If tb Is Nothing Then
                'MsgBox("Err1:" & vbNewLine & Query)
                '   MsgBox("1: La consulta no arrojó resultados.")
                Return List
            End If


            If tb.Rows Is Nothing Then
                'MsgBox("Err2:" & vbNewLine & Query)
                '   MsgBox("2: La consulta no arrojó resultados.")
                Return List
            End If


            If tb.Rows.Count = 0 Then
                '  MsgBox("3: La consulta no arrojó resultados.")
                'MsgBox("Err3:" & vbNewLine & Query)
                Return List
            End If


            For Each row As DataRow In tb.Rows

                If row.Item("CODE") IsNot DBNull.Value Then List.Add(row.Item("CODE"))

            Next

            'MsgBox("Non Error:" & vbNewLine & Query)


            Return List

        Catch ex As Exception
            MsgBox("Error al intentar recuperar la información solicitada", MsgBoxStyle.Critical)
            Return New List(Of String)
        End Try

    End Function


    Public Shared Function GetAll(ByVal OwnerCustomer As Boolean, ByVal User As Integer, Optional ByVal AllCustomers As Boolean = False, Optional ByVal Field As String = "", Optional ByVal value As String = "", Optional ByVal IncludeStructure As Boolean = False) As DataSet
        Dim ds As DataSet
        Dim tb As DataTable

        Try

            ds = New DataSet

            If IncludeStructure Then
                Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CstHeaders"))

                tb = Database.GetData(Query)

                tb.TableName = "Structure"

                If tb IsNot Nothing Then ds.Tables.Add(tb)

            End If

            If OwnerCustomer Then
                If AllCustomers Then
                    Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("PCustomers"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<database>", MainCompany.Database), New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<user>", User), New QueryHandler.Parameter("<company>", MainCompany.Id)})

                    If Field <> "" Then Query = Query & " AND " & Field & " LIKE '" & value & "%' ORDER BY " & Field

                Else
                    Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("UserPCustomers"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<database>", MainCompany.Database), New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<user>", User), New QueryHandler.Parameter("<company>", MainCompany.Id)})

                    If Field <> "" Then Query = Query & " AND " & Field & " LIKE '" & value & "%' ORDER BY " & Field

                End If

            Else
                If AllCustomers Then
                    Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("RCustomers"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<database>", MainCompany.Database), New QueryHandler.Parameter("<company>", MainCompany.Id)})

                    If Field <> "" Then Query = Query & " WHERE " & Field & " LIKE '" & value & "%' ORDER BY " & Field

                Else
                    Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("UserRCustomers"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<database>", MainCompany.Database), New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<user>", User), New QueryHandler.Parameter("<company>", MainCompany.Id)})

                    If Field <> "" Then Query = Query & " AND " & Field & " LIKE '" & value & "%' ORDER BY " & Field

                End If

            End If

            tb = Database.GetData(Query)

            ' MsgBox(Query, MsgBoxStyle.Information)


            tb.TableName = "Data"

            If tb IsNot Nothing Then ds.Tables.Add(tb)

            Return ds

        Catch ex As Exception
            Return Nothing
        End Try

    End Function



    Public Shared Function GetByCode(ByVal code As String, Optional ByVal PotentialCustomer As Boolean = False) As Customer
        Dim tb As DataTable

        Try
            If Not PotentialCustomer Then

                Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CstRByCode"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<database>", MainCompany.Database), New QueryHandler.Parameter("<code>", code), New QueryHandler.Parameter("<company>", MainCompany.Id), New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            Else

                Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CstPByCode"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<database>", MainCompany.Database), New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<code>", code), New QueryHandler.Parameter("<company>", MainCompany.Id)})

            End If

            'MsgBox("PreqQuery", MsgBoxStyle.Critical)
            tb = Database.GetData(Query)


            If tb Is Nothing Then
                '     MsgBox("La consulta realizada no arrojó resultados.1", MsgBoxStyle.Critical)
                ' MsgBox(Query, MsgBoxStyle.Information)
                Return Nothing
            End If


            If tb.Rows Is Nothing Then
                '    MsgBox("La consulta realizada no arrojó resultados.2", MsgBoxStyle.Critical)
                'MsgBox(Query, MsgBoxStyle.Information)
                Return Nothing
            End If


            If tb.Rows.Count = 0 Then
                '   MsgBox("La consulta realizada no arrojó resultados.3", MsgBoxStyle.Critical)
                'MsgBox(Query, MsgBoxStyle.Information)
                Return Nothing
            End If

            '  MsgBox("PosQuery", MsgBoxStyle.Critical)
            Return GetCustomer(tb.Rows(0))

        Catch ex As Exception
            MsgBox("La consulta realizada no arrojó resultados.4", MsgBoxStyle.Critical)
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Private Shared Function GetCustomer(ByVal row As DataRow) As Customer
        Dim customer As Customer

        Try

            If row Is Nothing Then Return Nothing

            customer = New Customer

            If row.Item("ID") IsNot DBNull.Value Then customer.Id = row.Item("ID")
            If row.Item("CODE") IsNot DBNull.Value Then customer.Code = row.Item("CODE")
            If row.Item("TGCODE") IsNot DBNull.Value Then customer.TGCode = row.Item("TGCODE")
            If row.Item("POTENTIAL") IsNot DBNull.Value Then customer.Potential = row.Item("POTENTIAL")
            If row.Item("NAME") IsNot DBNull.Value Then customer.Name = row.Item("NAME")
            If row.Item("LEGALNAME") IsNot DBNull.Value Then customer.LegalName = row.Item("LEGALNAME")
            If row.Item("ADRESS") IsNot DBNull.Value Then customer.Adress = row.Item("ADRESS")
            If row.Item("DELIVERYADRESS") IsNot DBNull.Value Then customer.DeliveryAdress = row.Item("DELIVERYADRESS")
            If row.Item("ZIPCODE") IsNot DBNull.Value Then customer.ZipCode = row.Item("ZIPCODE")
            If row.Item("CITY") IsNot DBNull.Value Then customer.City = row.Item("CITY")
            If row.Item("HOURS") IsNot DBNull.Value Then customer.Hours = row.Item("HOURS")
            If row.Item("PHONE") IsNot DBNull.Value Then customer.Phone = row.Item("PHONE")
            If row.Item("FAX") IsNot DBNull.Value Then customer.Fax = row.Item("FAX")
            If row.Item("MAIL") IsNot DBNull.Value Then customer.Mail = row.Item("MAIL")
            If row.Item("WEB") IsNot DBNull.Value Then customer.Web = row.Item("WEB")
            If row.Item("BIRTHDAY") IsNot DBNull.Value Then customer.BirthDay = row.Item("BIRTHDAY")
            If row.Item("REGISTRATIONDATE") IsNot DBNull.Value Then customer.RegistrationDate = row.Item("REGISTRATIONDATE")
            If row.Item("TGDATE") IsNot DBNull.Value Then customer.TgDate = row.Item("TGDATE")
            If row.Item("UNREGISTRATIONDATE") IsNot DBNull.Value Then customer.UnRegistrationDate = row.Item("UNREGISTRATIONDATE")
            If row.Item("CLAUSE") IsNot DBNull.Value Then customer.Clause = row.Item("CLAUSE")
            If row.Item("CREDIT") IsNot DBNull.Value Then customer.Credit = row.Item("CREDIT")
            If row.Item("DISCOUNTPERCENT") IsNot DBNull.Value Then customer.DiscountPercent = row.Item("DISCOUNTPERCENT")
            If row.Item("CUIT") IsNot DBNull.Value Then customer.CUIT = row.Item("CUIT")
            If row.Item("IBNUMBER") IsNot DBNull.Value Then customer.IBNumber = row.Item("IBNUMBER")
            If row.Item("IVACATEGORY") IsNot DBNull.Value Then customer.IVACategory = row.Item("IVACATEGORY")
            If row.Item("IVACALC") IsNot DBNull.Value Then customer.IVACalc = row.Item("IVACALC")
            If row.Item("IVADETAIL") IsNot DBNull.Value Then customer.IVADetail = row.Item("IVADETAIL")
            If row.Item("IVAFREE") IsNot DBNull.Value Then customer.IVAFree = row.Item("IVAFREE")
            If row.Item("IVAFREEPERCENT") IsNot DBNull.Value Then customer.IVAFreePercent = row.Item("IVAFREEPERCENT")
            If row.Item("IVAPLUS") IsNot DBNull.Value Then customer.IVAPlus = row.Item("IVAPLUS")
            If row.Item("IVAEXCLUSIONPERCENT") IsNot DBNull.Value Then customer.IVAExclusionPercent = row.Item("IVAEXCLUSIONPERCENT")
            If row.Item("IBCALC") IsNot DBNull.Value Then customer.IBCALC = row.Item("IBCALC")
            If row.Item("IBBCALC") IsNot DBNull.Value Then customer.IBBCalc = row.Item("IBBCALC")
            If row.Item("IBBINTERNALTAX") IsNot DBNull.Value Then customer.IBBInternalTax = row.Item("IBBINTERNALTAX")
            If row.Item("INTERNALTAXCALC") IsNot DBNull.Value Then customer.InternalTaxCalc = row.Item("INTERNALTAXCALC")
            If row.Item("INTERNALTAXDETAIL") IsNot DBNull.Value Then customer.InternalTaxDetail = row.Item("INTERNALTAXDETAIL")
            If row.Item("INTERNALTAXPLUS") IsNot DBNull.Value Then customer.InternalTaxPlus = row.Item("INTERNALTAXPLUS")
            If row.Item("EXPORT") IsNot DBNull.Value Then customer.EXPORT = row.Item("EXPORT")
            If row.Item("IBTAXCODE") IsNot DBNull.Value Then customer.IBTax = TaxRepository.GetByCode(row.Item("CURRENCYCODE"))
            If row.Item("IBTAXADITIONALCODE") IsNot DBNull.Value Then customer.IBTaxAditional = TaxRepository.GetByCode(row.Item("IBTAXADITIONALCODE"))
            If row.Item("IBBTAXCODE") IsNot DBNull.Value Then customer.IBBTax = TaxRepository.GetByCode(row.Item("IBBTAXCODE"))
            If row.Item("NCTAXCODE") IsNot DBNull.Value Then customer.NCTax = TaxRepository.GetByCode(row.Item("NCTAXCODE"))
            If row.Item("CURRENCYCODE") IsNot DBNull.Value Then customer.Currency = CurrencyRepository.GetByCode(Math.Abs(CInt(row.Item("CURRENCYCODE"))))
            If row.Item("SALESTERMCODE") IsNot DBNull.Value Then customer.SalesTerm = SalesTermRepository.GetByCode(row.Item("SALESTERMCODE"))
            If row.Item("EMPLOYEECODE") IsNot DBNull.Value Then customer.Employee = EmployeeRepository.GetByCode(row.Item("EMPLOYEECODE"))
            If row.Item("GROUPCODE") IsNot DBNull.Value Then customer.Group = CustomerGroupRepository.GetByCode(row.Item("GROUPCODE"))
            If row.Item("STATECODE") IsNot DBNull.Value Then customer.State = StateRepository.GetByCode(row.Item("STATECODE"))
            If row.Item("ZONECODE") IsNot DBNull.Value Then customer.Zone = ZoneRepository.GetByCode(row.Item("ZONECODE"))
            If row.Item("TRANSPORTCODE") IsNot DBNull.Value Then customer.Transport = TransportRepository.GetByCode(row.Item("TRANSPORTCODE"))

            If customer.Potential Then
                If row.Item("NOTES") IsNot DBNull.Value Then customer.Notes = row.Item("NOTES")
            Else
                customer.Notes = GetNotes(customer.Code)
            End If

            customer.Attachments = FileRepository.GetByCustomer(customer.Code)

            customer.Contacts = ContactRepository.GetByCustomer(customer.Code)

            Return customer

        Catch ex As Exception
            Return Nothing

        End Try

    End Function

    Private Shared Function GetNotes(ByVal Code As String) As String
        Dim tb As DataTable

        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CstNotes"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<systemdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<database>", MainCompany.Database), New QueryHandler.Parameter("<code>", Code)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return ""

            If tb.Rows Is Nothing Then Return ""

            If tb.Rows.Count = 0 Then Return ""

            Return tb.Rows(0).Item(0)

        Catch ex As Exception
            Return ""
        End Try

    End Function

    Public Shared Function GetIdByCode(ByVal code As String) As Integer
        Dim tb As DataTable

        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CstIdByCode"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<database>", MainCompany.Database), New QueryHandler.Parameter("<code>", code)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return 0

            If tb.Rows Is Nothing Then Return 0

            If tb.Rows.Count = 0 Then Return 0

            Return tb.Rows(0).Item(0)

        Catch ex As Exception
            Return 0
        End Try

    End Function

    Public Shared Function Save(ByVal Entity As Customer, Optional ByVal OriginalEntity As Customer = Nothing) As Integer

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

    Public Shared Function NextPotentialCode() As String
        Dim tb As DataTable
        Dim iCode As Double

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("NextPCode"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return "P00001"

            If tb.Rows Is Nothing Then Return "P00001"

            If tb.Rows.Count = 0 Then Return "P00001"



            If tb.Rows(0).Item(0).ToString <> "" Then
                iCode = Val(Right(tb.Rows(0).Item(0), Len(tb.Rows(0).Item(0)) - 1))
            Else
                iCode = 0
            End If


            Return "P" & Right("00000" & CStr(iCode + 1), 5)

        Catch ex As Exception
            Return ""
        End Try

    End Function

    Private Shared Function Insert(ByVal Entity As Customer) As Integer
        Dim Actions As List(Of Action)
        Dim Action As Action

        Try
            Actions = New List(Of Action)

            If Entity.Potential Then
                Entity.Code = NextPotentialCode()

                If Entity.Code = "" Then

                    Throw New Exception("No se pudo obtener el próximo código de cliente")
                    Return 0

                End If

            End If

            Action = GetActionInsertCustomer(Entity)

            Actions.Add(Action)

            Action = GetActionBindCustomer(Entity.Code, SystemUser.Id, MainCompany.Id)

            Actions.Add(Action)

            ActionHandler.Save(Actions)

        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Private Shared Function Update(ByVal Entity As Customer, ByVal OriginalEntity As Customer) As Integer
        Dim Actions As List(Of Action)
        Dim Action As Action

        Try
            Actions = New List(Of Action)

            Action = GetActionUpdateCustomer(Entity, OriginalEntity)
            If Action Is Nothing Then Return 0

            Actions.Add(Action)

            ActionHandler.Save(Actions)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Shared Function GetActionInsertCustomer(ByVal Entity As Customer) As Action
        Dim Action As Action

        Try
            Action = New Action(MainCompany.Id, SystemUser)

            Action.ObjectType = SystemEntities(1)
            Action.FinalObject = EntityHandler.Serialize(Entity)
            Action.sqlType = CommandType.StoredProcedure
            If Entity.Potential Then
                Action.sqlName = SystemCompany.Database & ".dbo.sp_InsertCustomer"
            Else
                Action.sqlName = MainCompany.Database & ".dbo.sp_InsertCustomer"
            End If
            Action.Parameters = CustomerParameters(Entity)
            'Action.Type = SysActiontypes("INSERT")
            Action.InitDate = Now()
            Action.Admin = Action.User
            Action.Status = 1

            Return Action

        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Private Shared Function GetActionUpdateCustomer(ByVal Entity As Customer, ByVal OriginalEntity As Customer) As Action
        Dim Action As Action

        Try
            Action = New Action(MainCompany.Id, SystemUser)
            Action.ObjectType = SystemEntities(1)
            Action.OriginalObject = EntityHandler.Serialize(OriginalEntity)
            Action.FinalObject = EntityHandler.Serialize(Entity)
            Action.sqlType = CommandType.StoredProcedure
            If Entity.Potential Then
                Action.sqlName = "[" & SystemCompany.Database & "]" & ".dbo.sp_UpdateCustomer"
            Else
                Action.sqlName = "[" & MainCompany.Database & "]" & ".dbo.sp_UpdateCustomer"
            End If
            Action.Parameters = CustomerParameters(Entity)
            'Action.Type = SysActiontypes("UPDATE")
            Action.InitDate = Now()
            Action.Admin = Action.User
            Action.Status = 1

            Return Action

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Shared Function GetActionBindCustomer(ByVal CustomerCode As String, ByVal UserId As Integer, ByVal CompanyId As Integer) As Action
        Dim Action As Action

        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CstDomainAdd"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<company>", CompanyId), New QueryHandler.Parameter("<user>", UserId), New QueryHandler.Parameter("<customer>", CustomerCode)})

            Action = New Action(MainCompany.Id, SystemUser)
            Action.ObjectType = SystemEntities(1)
            Action.sqlType = CommandType.Text
            Action.SqlString = Query
            'Action.Type = SysActiontypes("UPDATE")
            Action.InitDate = Now()
            Action.Admin = Action.User
            Action.Status = 1

            Return Action

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Shared Function CustomerParameters(ByVal Entity As Customer) As SqlClient.SqlParameter()

        Dim Parameters() As SqlClient.SqlParameter

        Try
            ReDim Parameters(0 To 32)

            Parameters(0) = New SqlClient.SqlParameter("@CODE", SqlDbType.VarChar) With {.Value = Entity.Code}
            Parameters(1) = New SqlClient.SqlParameter("@NAME", SqlDbType.VarChar) With {.Value = Entity.Name}
            Parameters(2) = New SqlClient.SqlParameter("@LEGALNAME", SqlDbType.VarChar) With {.Value = Entity.LegalName}
            Parameters(3) = New SqlClient.SqlParameter("@ADRESS", SqlDbType.VarChar) With {.Value = Entity.Adress}
            Parameters(4) = New SqlClient.SqlParameter("@DELIVERYADRESS", SqlDbType.VarChar) With {.Value = Entity.DeliveryAdress}
            Parameters(5) = New SqlClient.SqlParameter("@ZIPCODE", SqlDbType.VarChar) With {.Value = Entity.ZipCode}
            Parameters(6) = New SqlClient.SqlParameter("@CITY", SqlDbType.VarChar) With {.Value = Entity.City}
            Parameters(7) = New SqlClient.SqlParameter("@HOURS", SqlDbType.VarChar) With {.Value = Entity.Hours}
            Parameters(8) = New SqlClient.SqlParameter("@PHONE", SqlDbType.VarChar) With {.Value = Entity.Phone}
            Parameters(9) = New SqlClient.SqlParameter("@FAX", SqlDbType.VarChar) With {.Value = Entity.Fax}
            Parameters(10) = New SqlClient.SqlParameter("@MAIL", SqlDbType.VarChar) With {.Value = Entity.Mail}
            Parameters(11) = New SqlClient.SqlParameter("@WEB", SqlDbType.VarChar) With {.Value = Entity.Web}
            Parameters(12) = New SqlClient.SqlParameter("@BIRTHDAY", SqlDbType.DateTime) With {.Value = Format(Entity.BirthDay, "yyyy/MM/dd")}
            Parameters(13) = New SqlClient.SqlParameter("@REGISTRATIONDATE", SqlDbType.DateTime) With {.Value = Format(Entity.RegistrationDate, "yyyy/MM/dd")}
            Parameters(14) = New SqlClient.SqlParameter("@CLAUSE", SqlDbType.Bit) With {.Value = Entity.Clause}
            Parameters(15) = New SqlClient.SqlParameter("@CREDIT", SqlDbType.Decimal) With {.Value = Entity.Credit}
            Parameters(16) = New SqlClient.SqlParameter("@DISCOUNTPERCENT", SqlDbType.Decimal) With {.Value = Entity.DiscountPercent}
            Parameters(17) = New SqlClient.SqlParameter("@CUIT", SqlDbType.VarChar) With {.Value = Entity.CUIT}
            Parameters(18) = New SqlClient.SqlParameter("@IBNUMBER", SqlDbType.VarChar) With {.Value = Entity.IBNumber}
            Parameters(19) = New SqlClient.SqlParameter("@IVACALC", SqlDbType.Bit) With {.Value = Entity.IVACalc}
            Parameters(20) = New SqlClient.SqlParameter("@IVADETAIL", SqlDbType.Bit) With {.Value = Entity.IVADetail}
            Parameters(21) = New SqlClient.SqlParameter("@IVAFREE", SqlDbType.Bit) With {.Value = Entity.IVAFree}
            Parameters(22) = New SqlClient.SqlParameter("@IVAFREEPERCENT", SqlDbType.Decimal) With {.Value = Entity.IVAFreePercent}
            Parameters(23) = New SqlClient.SqlParameter("@IVAPLUS", SqlDbType.Bit) With {.Value = Entity.IVAPlus}
            Parameters(24) = New SqlClient.SqlParameter("@IVAEXCLUSIONPERCENT", SqlDbType.Decimal) With {.Value = Entity.IVAExclusionPercent}
            Parameters(25) = New SqlClient.SqlParameter("@IBCALC", SqlDbType.Bit) With {.Value = Entity.IBCalc}
            Parameters(26) = New SqlClient.SqlParameter("@IBBCALC", SqlDbType.Bit) With {.Value = Entity.IBBCalc}
            Parameters(27) = New SqlClient.SqlParameter("@IBBINTERNALTAX", SqlDbType.Bit) With {.Value = Entity.IBBInternalTax}
            Parameters(28) = New SqlClient.SqlParameter("@INTERNALTAXCALC", SqlDbType.Bit) With {.Value = Entity.InternalTaxCalc}
            Parameters(29) = New SqlClient.SqlParameter("@INTERNALTAXDETAIL", SqlDbType.Bit) With {.Value = Entity.InternalTaxDetail}
            Parameters(30) = New SqlClient.SqlParameter("@INTERNALTAXPLUS", SqlDbType.Bit) With {.Value = Entity.InternalTaxPlus}
            Parameters(31) = New SqlClient.SqlParameter("@EXPORT", SqlDbType.Bit) With {.Value = Entity.Export}
            Parameters(32) = New SqlClient.SqlParameter("@COMPANY", SqlDbType.Int) With {.Value = MainCompany.Id}


            If Entity.IBTax IsNot Nothing Then
                ReDim Preserve Parameters(0 To UBound(Parameters) + 1)
                Parameters(UBound(Parameters)) = New SqlClient.SqlParameter("@IBTAXCODE", SqlDbType.VarChar) With {.Value = Entity.IBTax.Code}
            End If

            If Entity.IBTaxAditional IsNot Nothing Then
                ReDim Preserve Parameters(0 To UBound(Parameters) + 1)
                Parameters(UBound(Parameters)) = New SqlClient.SqlParameter("@IBTAXADITIONALCODE", SqlDbType.VarChar) With {.Value = Entity.IBTaxAditional.Code}
            End If

            If Entity.IBBTax IsNot Nothing Then
                ReDim Preserve Parameters(0 To UBound(Parameters) + 1)
                Parameters(UBound(Parameters)) = New SqlClient.SqlParameter("@IBBTAXCODE", SqlDbType.VarChar) With {.Value = Entity.IBBTax.Code}
            End If

            If Entity.NCTax IsNot Nothing Then
                ReDim Preserve Parameters(0 To UBound(Parameters) + 1)
                Parameters(UBound(Parameters)) = New SqlClient.SqlParameter("@NCTAXCODE", SqlDbType.VarChar) With {.Value = Entity.NCTax.Code}
            End If

            If Entity.Currency IsNot Nothing Then
                ReDim Preserve Parameters(0 To UBound(Parameters) + 1)
                Parameters(UBound(Parameters)) = New SqlClient.SqlParameter("@CURRENCYCODE", SqlDbType.VarChar) With {.Value = Entity.Currency.Code}
            End If

            If Entity.SalesTerm IsNot Nothing Then
                ReDim Preserve Parameters(0 To UBound(Parameters) + 1)
                Parameters(UBound(Parameters)) = New SqlClient.SqlParameter("@SALESTERMCODE", SqlDbType.VarChar) With {.Value = Entity.SalesTerm.Code}
            End If

            If Entity.Employee IsNot Nothing Then
                ReDim Preserve Parameters(0 To UBound(Parameters) + 1)
                Parameters(UBound(Parameters)) = New SqlClient.SqlParameter("@EMPLOYEECODE", SqlDbType.VarChar) With {.Value = Entity.Employee.Code}
            End If

            If Entity.Group IsNot Nothing Then
                ReDim Preserve Parameters(0 To UBound(Parameters) + 1)
                Parameters(UBound(Parameters)) = New SqlClient.SqlParameter("@GROUPCODE", SqlDbType.VarChar) With {.Value = Entity.Group.Code}
            End If

            If Entity.State IsNot Nothing Then
                ReDim Preserve Parameters(0 To UBound(Parameters) + 1)
                Parameters(UBound(Parameters)) = New SqlClient.SqlParameter("@STATECODE", SqlDbType.VarChar) With {.Value = Entity.State.Code}
            End If

            If Entity.Zone IsNot Nothing Then
                ReDim Preserve Parameters(0 To UBound(Parameters) + 1)
                Parameters(UBound(Parameters)) = New SqlClient.SqlParameter("@ZONECODE", SqlDbType.VarChar) With {.Value = Entity.Zone.Code}
            End If

            If Entity.Transport IsNot Nothing Then
                ReDim Preserve Parameters(0 To UBound(Parameters) + 1)
                Parameters(UBound(Parameters)) = New SqlClient.SqlParameter("@TRANSPORTCODE", SqlDbType.VarChar) With {.Value = Entity.Transport.Code}
            End If

            If Entity.Notes IsNot Nothing Then
                ReDim Preserve Parameters(0 To UBound(Parameters) + 1)
                Parameters(UBound(Parameters)) = New SqlClient.SqlParameter("@NOTES", SqlDbType.VarChar) With {.Value = Entity.Notes}
            End If

            Return Parameters

        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Public Shared Function SetPotentialToReal(ByVal customer As String, ByVal NewCode As String) As Boolean
        Dim Actions As List(Of Action)
        Dim Action As Action

        Try
            Actions = New List(Of Action)

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CstToTango"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<database>", MainCompany.Database), New QueryHandler.Parameter("<company>", MainCompany.Id), New QueryHandler.Parameter("<customer>", customer), New QueryHandler.Parameter("<newcode>", NewCode)})

            Action = New Action(MainCompany.Id, SystemUser)
            Action.ObjectType = SystemEntities(1)
            Action.sqlType = CommandType.Text
            Action.SqlString = Query
            Action.InitDate = Now()
            Action.Admin = Action.User
            Action.Status = 1

            Actions.Add(Action)

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("UpdatePCTgCst"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<database>", MainCompany.Database), New QueryHandler.Parameter("<company>", MainCompany.Id), New QueryHandler.Parameter("<customer>", customer), New QueryHandler.Parameter("<newcode>", NewCode)})

            Action = New Action(MainCompany.Id, SystemUser)
            Action.ObjectType = SystemEntities(1)
            Action.sqlType = CommandType.Text
            Action.SqlString = Query

            Actions.Add(Action)

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("UpdatePCAttachs"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<database>", MainCompany.Database), New QueryHandler.Parameter("<company>", MainCompany.Id), New QueryHandler.Parameter("<customer>", customer), New QueryHandler.Parameter("<newcode>", NewCode)})

            Action = New Action(MainCompany.Id, SystemUser)
            Action.ObjectType = SystemEntities(1)
            Action.sqlType = CommandType.Text
            Action.SqlString = Query

            Actions.Add(Action)

            Action = GetActionBindCustomer(NewCode, SystemUser.Id, MainCompany.Id)

            Actions.Add(Action)


            ActionHandler.Save(Actions)

        Catch ex As Exception
            Throw ex
        End Try
    End Function



    Public Shared Function GetCancelReassonById(ByVal Id As Integer) As Customer.CustomerDeleteReasson

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CnlReassonById"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<reasson>", Id)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Return Nothing

            If tb.Rows Is Nothing Then Return Nothing

            If tb.Rows.Count = 0 Then Return Nothing

            Return GetCancelReasson(tb.Rows(0))

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function GetCancelReassons() As List(Of Customer.CustomerDeleteReasson)
        Dim List As List(Of Customer.CustomerDeleteReasson)
        Dim CancelReasson As Customer.CustomerDeleteReasson

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CnlReassons"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            tb = Database.GetData(Query)

            List = New List(Of Customer.CustomerDeleteReasson)

            If tb Is Nothing Then Return List

            If tb.Rows Is Nothing Then Return List

            For Each row As DataRow In tb.Rows

                CancelReasson = GetCancelReasson(row)

                If CancelReasson IsNot Nothing Then List.Add(CancelReasson)

            Next

            Return List

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function GetTableCancelReassons() As DataTable
        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CnlReassons"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            Return Database.GetData(Query)

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function GetAllCancelReassons(Optional ByVal Field As String = "", Optional ByVal value As String = "", Optional ByVal IncludeStructure As Boolean = False) As DataSet
        Dim ds As DataSet
        Dim tb As DataTable

        Try

            ds = New DataSet

            If IncludeStructure Then
                Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("ReassonHeaders"))

                tb = Database.GetData(Query)

                tb.TableName = "Structure"

                If tb IsNot Nothing Then ds.Tables.Add(tb)

            End If

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CnlReassons"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database)})

            If Field <> "" Then Query = Query & " WHERE " & Field & " LIKE '" & value & "%' ORDER BY " & Field

            tb = Database.GetData(Query)

            tb.TableName = "Data"

            If tb IsNot Nothing Then ds.Tables.Add(tb)

            Return ds

        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Private Shared Function GetCancelReasson(ByVal row As DataRow) As Customer.CustomerDeleteReasson
        Dim TaskCancelReasson As Customer.CustomerDeleteReasson

        Try

            If row Is Nothing Then Return Nothing

            TaskCancelReasson = New Customer.CustomerDeleteReasson

            If row.Item("ID") IsNot DBNull.Value Then TaskCancelReasson.Id = row.Item("ID")
            If row.Item("NAME") IsNot DBNull.Value Then TaskCancelReasson.Name = row.Item("NAME")
            If row.Item("DESCRIPTION") IsNot DBNull.Value Then TaskCancelReasson.Description = row.Item("DESCRIPTION")

            Return TaskCancelReasson

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function SaveCancelReasson(ByVal Code As Integer, ByVal Name As String, ByVal Description As String, ByVal Otherdetails As String) As Integer
        Dim SaveAction As Domain.Action
        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("SaveCnlReasson"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<code>", Code), New QueryHandler.Parameter("<name>", Name), New QueryHandler.Parameter("<description>", Description), New QueryHandler.Parameter("<otherdetails>", Otherdetails)})

            SaveAction = New Domain.Action(MainCompany.Id, SystemUser)
            SaveAction.ObjectType = SystemEntities(1)
            SaveAction.sqlType = CommandType.Text
            SaveAction.SqlString = Query
            'SaveAction.CancelReasson = SysActionCancelReassons("INSERT")
            SaveAction.InitDate = Now()
            SaveAction.Admin = SaveAction.User
            SaveAction.Status = 1

            ActionHandler.Save(SaveAction)

        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Shared Function CustomerDeleted(ByVal PotentialCustomer As Boolean, ByVal CustomerCode As String) As Integer
        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CustomerDeleted"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<code>", CustomerCode), New QueryHandler.Parameter("<potential>", Math.Abs(CInt(PotentialCustomer))), New QueryHandler.Parameter("<company>", MainCompany.Id)})

            Return Database.GetData(Query).Rows(0).Item(0)

        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Shared Function CustomerToDelete(ByVal PotentialCustomer As Boolean, ByVal CustomerCode As String, ByVal CancelDate As Date, ByVal ReassonCode As Integer) As Boolean

        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CustomertoDel"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<code>", CustomerCode), New QueryHandler.Parameter("<potential>", Math.Abs(CInt(PotentialCustomer))), New QueryHandler.Parameter("<date>", Format(CancelDate, "yyyy/MM/dd")), New QueryHandler.Parameter("<reasson>", ReassonCode), New QueryHandler.Parameter("<user>", SystemUser.Id), New QueryHandler.Parameter("<company>", MainCompany.Id)})

            Database.ExecuteCommand(Query)

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function CustomersDeletedToConfirm() As DataTable
        Try
            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("CstToConfirmDel"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<database>", MainCompany.Database), New QueryHandler.Parameter("<company>", MainCompany.Id)})

            Return Database.GetData(Query)

        Catch ex As Exception
            Throw ex
        End Try

    End Function
End Class
