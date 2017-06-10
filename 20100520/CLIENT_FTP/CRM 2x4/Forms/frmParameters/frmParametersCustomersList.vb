Public Class frmParametersCustomersList

    Private WithEvents frmViewer As frmReportViewer
    Private WithEvents frmZone As frmSearch
    Private WithEvents frmCustomer As frmSearch
    Private WithEvents frmState As frmSearch
    Private WithEvents frmEmployee As frmSearch

    Private GroupField As String
    Private GroupName As String

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            DrawMe(False)

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub DrawMe(ByVal FormEnabled As Boolean)
        Dim GBox As GroupBox
        Dim TBox As TextBox

        Try
            optRealCustomer.Focus()

            For Each Ctrl As Control In Me.Controls

                GBox = TryCast(Ctrl, GroupBox)

                If GBox IsNot Nothing Then

                    GBox.Enabled = FormEnabled

                    For Each ChildCtrl As Control In GBox.Controls

                        TBox = TryCast(ChildCtrl, TextBox)

                        If TBox IsNot Nothing Then TBox.Text = ""

                    Next

                End If

            Next

            MenuReportList.Enabled = Not FormEnabled

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode

                Case Keys.Escape
                    If Not MenuReportList.Enabled Then
                        DrawMe(False)
                    Else
                        Me.Close()
                    End If

                Case Keys.F10
                    ShowReport()

            End Select

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub ShowReport()
        Dim dt As DataTable
        Dim Rpt As CrystalDecisions.CrystalReports.Engine.ReportClass
        Dim FieldDef As CrystalDecisions.CrystalReports.Engine.FieldDefinition

        Try

            If Not ValidateForm() Then Exit Try

            dt = Domain.ReportRepository.CustomersList(optPotentialCustomer.Checked, txtCustomerFrom.Text, txtCustomerTo.Text, _
                                                       txtZoneFrom.Text, txtZoneTo.Text, _
                                                       txtStateFrom.Text, txtStateTo.Text, _
                                                       txtEmployeeFrom.Text, txtEmployeeTo.Text)

            Rpt = New RptCstList
            Rpt.SetDataSource(dt)

            Rpt.DataDefinition.FormulaFields("COMPANYNAME").Text = "'" & Domain.MainCompany.Name & "'"
            Rpt.DataDefinition.FormulaFields("USEROWNER").Text = "'" & Domain.SystemUser.NickName & "'"
            Rpt.DataDefinition.FormulaFields("REPORTTITLE").Text = "'" & Me.Text & "'"

            FieldDef = Rpt.Database.Tables.Item(0).Fields.Item(GroupField)

            Rpt.DataDefinition.Groups.Item(0).ConditionField = FieldDef

            Rpt.DataDefinition.FormulaFields("GROUPNAME").Text = "'" & GroupName & "'"

            Rpt.Refresh()

            Me.Hide()

            frmViewer = New frmReportViewer(Rpt, dt, Me.Text)
            frmViewer.Show()

        Catch ex As Exception

            DrawMe(False)

            Me.Show()

            Throw ex

        Finally
            'revisar si hay que matar el Rpt

        End Try
    End Sub

    Private Function ValidateForm() As Boolean

        Try

            If txtCustomerFrom.Text = "" Then
                txtCustomerFrom.Focus()
                Exit Function
            End If

            If txtCustomerTo.Text = "" Then
                txtCustomerTo.Focus()
                Exit Function
            End If

            If txtZoneFrom.Text = "" Then
                txtZoneFrom.Focus()
                Exit Function
            End If

            If txtZoneTo.Text = "" Then
                txtZoneTo.Focus()
                Exit Function
            End If

            If txtStateFrom.Text = "" Then
                txtStateFrom.Focus()
                Exit Function
            End If

            If txtStateTo.Text = "" Then
                txtStateTo.Focus()
                Exit Function
            End If

            If txtEmployeeFrom.Text = "" Then
                txtEmployeeFrom.Focus()
                Exit Function
            End If

            If txtEmployeeTo.Text = "" Then
                txtEmployeeTo.Focus()
                Exit Function
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub EnableForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuReportListByEmployee.Click, MenuReportListByState.Click, MenuReportListByZone.Click

        Try
            GroupField = sender.tag

            GroupName = UCase(Mid(sender.Text, 5, 100))

            DrawMe(True)

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub MenuReportCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuReportCancel.Click
        Try
            If Not MenuReportList.Enabled Then
                DrawMe(False)
            Else
                Me.Close()
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub ViewerClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles frmViewer.FormClosed
        Try

            DrawMe(False)

            Me.Show()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub optRealCustomer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles optRealCustomer.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then optRealCustomer_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub optPotentialCustomer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles optPotentialCustomer.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then optPotentialCustomer_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub txtCustomerFrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCustomerFrom.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then txtCustomerFrom_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub txtCustomerTo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCustomerTo.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then txtCustomerTo_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub txtZoneFrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtZoneFrom.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then txtZoneFrom_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub txtZoneTo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtZoneTo.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then txtZoneTo_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub txtStateFrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStateFrom.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then txtStateFrom_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub txtStateTo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStateTo.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then txtStateTo_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub


    Private Sub txtEmployeeFrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmployeeFrom.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then txtEmployeeFrom_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub txtEmployeeTo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmployeeTo.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then txtEmployeeTo_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub optRealCustomer_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles optRealCustomer.Validating
        Try
            optPotentialCustomer.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub optPotentialCustomer_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles optPotentialCustomer.Validating
        Try
            txtCustomerFrom.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub txtCustomerFrom_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCustomerFrom.Validating
        Dim SearchPattern As String
        Dim Customer As Domain.Customer
        Dim Customers As DataSet

        Try

            If Not txtCustomerFrom.Enabled Then Exit Try

            SearchPattern = txtCustomerFrom.Text

            Customer = Domain.CustomerRepository.GetByCode(SearchPattern, optPotentialCustomer.Checked)

            If Customer IsNot Nothing Then
                txtCustomerFrom.Text = Customer.Code
                txtCustomerNameFrom.Text = Customer.Name
                txtCustomerTo.Focus()
                Exit Try
            End If

            txtCustomerFrom.Text = ""
            txtCustomerNameFrom.Text = ""

            Customers = Domain.CustomerRepository.GetAll(optPotentialCustomer.Checked, Domain.SystemUser.Id, Domain.SystemUser.FullDomain, , , True)
            frmCustomer = New frmSearch("CLIENTES", Customers, SearchPattern)
            frmCustomer.ShowDialog()

            If frmCustomer.SelectedValue IsNot Nothing Then
                Customer = Domain.CustomerRepository.GetByCode(frmCustomer.SelectedValue, optPotentialCustomer.Checked)
                If Customer IsNot Nothing Then
                    txtCustomerFrom.Text = Customer.Code
                    txtCustomerNameFrom.Text = Customer.Name
                    txtCustomerTo.Focus()
                    Exit Try
                End If
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        Finally
            Customer = Nothing
            Customers = Nothing
        End Try
    End Sub

    Private Sub txtCustomerTo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCustomerTo.Validating
        Dim SearchPattern As String
        Dim Customer As Domain.Customer
        Dim Customers As DataSet

        Try

            If Not txtCustomerTo.Enabled Then Exit Try

            SearchPattern = txtCustomerTo.Text

            Customer = Domain.CustomerRepository.GetByCode(SearchPattern, optPotentialCustomer.Checked)

            If Customer IsNot Nothing Then
                txtCustomerTo.Text = Customer.Code
                txtCustomerNameTo.Text = Customer.Name
                txtZoneFrom.Focus()
                Exit Try
            End If

            txtCustomerTo.Text = ""
            txtCustomerNameTo.Text = ""

            Customers = Domain.CustomerRepository.GetAll(optPotentialCustomer.Checked, Domain.SystemUser.Id, Domain.SystemUser.FullDomain, , , True)
            frmCustomer = New frmSearch("CLIENTES", Customers, SearchPattern)
            frmCustomer.ShowDialog()

            If frmCustomer.SelectedValue IsNot Nothing Then
                Customer = Domain.CustomerRepository.GetByCode(frmCustomer.SelectedValue, optPotentialCustomer.Checked)
                If Customer IsNot Nothing Then
                    txtCustomerTo.Text = Customer.Code
                    txtCustomerNameTo.Text = Customer.Name
                    txtZoneFrom.Focus()
                End If
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        Finally
            Customer = Nothing
            Customers = Nothing
        End Try
    End Sub

    Private Sub txtZoneFrom_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtZoneFrom.Validating
        Dim SearchPattern As String
        Dim Zone As Domain.Zone
        Dim Zones As DataSet

        Try

            If Not txtZoneFrom.Enabled Then Exit Try

            SearchPattern = txtZoneFrom.Text

            Zone = Domain.ZoneRepository.GetByCode(SearchPattern)

            If Zone IsNot Nothing Then
                txtZoneFrom.Text = Zone.Code
                txtZoneNameFrom.Text = Zone.Name
                txtZoneTo.Focus()
                Exit Try
            End If

            txtZoneFrom.Text = ""
            txtZoneNameFrom.Text = ""

            Zones = Domain.ZoneRepository.GetAll(, , True)


            frmZone = New frmSearch("ZONAS", Zones, SearchPattern)
            frmZone.ShowDialog()

            If frmZone.SelectedValue IsNot Nothing Then
                Zone = Crm.Domain.ZoneRepository.GetByCode(frmZone.SelectedValue)
                If Zone IsNot Nothing Then
                    txtZoneFrom.Text = Zone.Code
                    txtZoneNameFrom.Text = Zone.Name
                    txtZoneTo.Focus()
                    Exit Try
                End If
            End If


        Catch ex As Exception
            frmError.ShowException(ex)
        Finally
            Zone = Nothing
            Zones = Nothing
        End Try
    End Sub


    Private Sub txtZoneTo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtZoneTo.Validating
        Dim SearchPattern As String
        Dim Zone As Domain.Zone
        Dim Zones As DataSet

        Try

            If Not txtZoneTo.Enabled Then Exit Try

            SearchPattern = txtZoneTo.Text

            Zone = Domain.ZoneRepository.GetByCode(SearchPattern)

            If Zone IsNot Nothing Then
                txtZoneTo.Text = Zone.Code
                txtZoneNameTo.Text = Zone.Name
                txtStateFrom.Focus()
                Exit Try
            End If

            txtZoneTo.Text = ""
            txtZoneNameTo.Text = ""

            Zones = Domain.ZoneRepository.GetAll(, , True)


            frmZone = New frmSearch("ZONAS", Zones, SearchPattern)
            frmZone.ShowDialog()

            If frmZone.SelectedValue IsNot Nothing Then
                Zone = Crm.Domain.ZoneRepository.GetByCode(frmZone.SelectedValue)
                If Zone IsNot Nothing Then
                    txtZoneTo.Text = Zone.Code
                    txtZoneNameTo.Text = Zone.Name
                    txtStateFrom.Focus()
                    Exit Try
                End If
            End If


        Catch ex As Exception
            frmError.ShowException(ex)
        Finally
            Zone = Nothing
            Zones = Nothing
        End Try
    End Sub

    Private Sub txtStateFrom_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtStateFrom.Validating
        Dim SearchPattern As String
        Dim State As Domain.State
        Dim States As DataSet

        Try

            If Not txtStateFrom.Enabled Then Exit Try

            SearchPattern = txtStateFrom.Text

            State = Domain.StateRepository.GetByCode(SearchPattern)

            If State IsNot Nothing Then
                txtStateFrom.Text = State.Code
                txtStateNameFrom.Text = State.Name
                txtStateTo.Focus()
                Exit Try
            End If

            txtStateFrom.Text = ""
            txtStateNameFrom.Text = ""

            States = Domain.StateRepository.GetAll(, , True)

            frmState = New frmSearch("PROVINCIAS", States, SearchPattern)
            frmState.ShowDialog()

            If frmState.SelectedValue IsNot Nothing Then
                State = Domain.StateRepository.GetByCode(frmState.SelectedValue)
                If State IsNot Nothing Then
                    txtStateFrom.Text = State.Code
                    txtStateNameFrom.Text = State.Name
                    txtStateTo.Focus()
                    Exit Try
                End If
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        Finally
            State = Nothing
            States = Nothing
        End Try
    End Sub

    Private Sub txtStateTo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtStateTo.Validating
        Dim SearchPattern As String
        Dim State As Domain.State
        Dim States As DataSet

        Try

            If Not txtStateTo.Enabled Then Exit Try

            SearchPattern = txtStateTo.Text

            State = Domain.StateRepository.GetByCode(SearchPattern)

            If State IsNot Nothing Then
                txtStateTo.Text = State.Code
                txtStateNameTo.Text = State.Name
                txtEmployeeFrom.Focus()
                Exit Try
            End If

            txtStateTo.Text = ""
            txtStateNameTo.Text = ""

            States = Domain.StateRepository.GetAll(, , True)

            frmState = New frmSearch("PROVINCIAS", States, SearchPattern)
            frmState.ShowDialog()

            If frmState.SelectedValue IsNot Nothing Then
                State = Domain.StateRepository.GetByCode(frmState.SelectedValue)
                If State IsNot Nothing Then
                    txtStateTo.Text = State.Code
                    txtStateNameTo.Text = State.Name
                    txtEmployeeFrom.Focus()
                    Exit Try
                End If
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        Finally
            State = Nothing
            States = Nothing
        End Try
    End Sub


    Private Sub txtEmployeeFrom_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmployeeFrom.Validating
        Dim SearchPattern As String
        Dim Employee As Domain.Employee
        Dim Employees As DataSet

        Try

            If Not txtEmployeeFrom.Enabled Then Exit Try

            SearchPattern = txtEmployeeFrom.Text

            Employee = Domain.EmployeeRepository.GetByCode(SearchPattern)

            If Employee IsNot Nothing Then
                txtEmployeeFrom.Text = Employee.Code
                txtEmployeeNameFrom.Text = Employee.Name
                txtEmployeeTo.Focus()
                Exit Try
            End If

            txtEmployeeFrom.Text = ""
            txtEmployeeNameFrom.Text = ""

            Employees = Domain.EmployeeRepository.GetAll(, , True)

            frmEmployee = New frmSearch("VENDEDORES", Employees, SearchPattern)
            frmEmployee.ShowDialog()

            If frmEmployee.SelectedValue IsNot Nothing Then
                Employee = Domain.EmployeeRepository.GetByCode(frmEmployee.SelectedValue)
                If Employee IsNot Nothing Then
                    txtEmployeeFrom.Text = Employee.Code
                    txtEmployeeNameFrom.Text = Employee.Name
                    txtEmployeeTo.Focus()
                    Exit Try
                End If
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        Finally
            Employee = Nothing
            Employees = Nothing
        End Try
    End Sub

    Private Sub txtEmployeeTo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmployeeTo.Validating
        Dim SearchPattern As String
        Dim Employee As Domain.Employee
        Dim Employees As DataSet

        Try

            If Not txtEmployeeTo.Enabled Then Exit Try

            SearchPattern = txtEmployeeTo.Text

            Employee = Domain.EmployeeRepository.GetByCode(SearchPattern)

            If Employee IsNot Nothing Then
                txtEmployeeTo.Text = Employee.Code
                txtEmployeeNameTo.Text = Employee.Name
                ShowReport()
                Exit Try
            End If

            txtEmployeeTo.Text = ""
            txtEmployeeNameTo.Text = ""

            Employees = Domain.EmployeeRepository.GetAll(, , True)

            frmEmployee = New frmSearch("VENDEDORES", Employees, SearchPattern)
            frmEmployee.ShowDialog()

            If frmEmployee.SelectedValue IsNot Nothing Then
                Employee = Domain.EmployeeRepository.GetByCode(frmEmployee.SelectedValue)
                If Employee IsNot Nothing Then
                    txtEmployeeTo.Text = Employee.Code
                    txtEmployeeNameTo.Text = Employee.Name
                    ShowReport()
                    Exit Try
                End If
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        Finally
            Employee = Nothing
            Employees = Nothing
        End Try
    End Sub


    Private Sub frmZone_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmZone.ParametersChanged
        Dim Zones As DataSet = Nothing

        Try
            Zones = Domain.ZoneRepository.GetAll(Field, value, False)

            frmZone.DataSource = Zones

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub frmCustomer_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmCustomer.ParametersChanged
        Dim Customers As DataSet

        Try
            Customers = Domain.CustomerRepository.GetAll(optPotentialCustomer.Checked, Domain.SystemUser.Id, Domain.SystemUser.FullDomain, Field, value, False)

            frmCustomer.DataSource = Customers

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub

    Private Sub frmState_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmState.ParametersChanged
        Dim States As DataSet = Nothing

        Try
            States = Domain.StateRepository.GetAll(Field, value, False)

            frmState.DataSource = States

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub frmEmployee_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmEmployee.ParametersChanged
        Dim Employees As DataSet = Nothing

        Try
            Employees = Domain.EmployeeRepository.GetAll(Field, value, False)

            frmEmployee.DataSource = Employees

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

End Class