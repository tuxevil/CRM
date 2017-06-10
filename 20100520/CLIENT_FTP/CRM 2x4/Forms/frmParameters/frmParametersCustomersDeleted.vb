Public Class frmParametersCustomersDeleted

    Private WithEvents frmViewer As frmReportViewer
    Private WithEvents frmUser As frmSearch
    Private WithEvents frmCustomer As frmSearch
    Private WithEvents frmReasson As frmSearch

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

            dt = Domain.ReportRepository.CustomersDeleted(optPotentialCustomer.Checked, txtUserFrom.Text, txtUserTo.Text, DateFrom.Value, DateTo.Value, txtCustomerFrom.Text, txtCustomerTo.Text, CInt(txtReassonFrom.Text), CInt(txtReassonTo.Text), chkStatusProcessed.Checked, chkStatusNotProcessed.Checked)

            Rpt = New RptPCstDeleted
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

        End Try
    End Sub

    Private Function ValidateForm() As Boolean

        Try

            If txtUserFrom.Text = "" Then
                txtUserFrom.Focus()
                Exit Function
            End If

            If txtUserTo.Text = "" Then
                txtUserTo.Focus()
                Exit Function
            End If

            If txtCustomerFrom.Text = "" Then
                txtCustomerFrom.Focus()
                Exit Function
            End If

            If txtCustomerTo.Text = "" Then
                txtCustomerTo.Focus()
                Exit Function
            End If

            If txtReassonFrom.Text = "" Then
                txtReassonFrom.Focus()
                Exit Function
            End If

            If txtReassonTo.Text = "" Then
                txtReassonTo.Focus()
                Exit Function
            End If

            If chkStatusNotProcessed.CheckState <> CheckState.Checked And chkStatusProcessed.CheckState <> CheckState.Checked Then
                MsgBox("Debe seleccionar al menos un estado", MsgBoxStyle.Information, "Atención")
                chkStatusProcessed.Focus()
                Exit Function
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub EnableForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuReportListByUser.Click, MenuReportListByDate.Click, MenuReportListByReasson.Click, MenuReportListByStatus.Click

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

    Private Sub txtUserFrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserFrom.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then txtUserFrom_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub txtUserTo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserTo.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then txtUserTo_Validating(Nothing, Nothing)
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

    Private Sub DateFrom_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateFrom.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then DateFrom_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub DateTo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateTo.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then DateTo_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub txtReassonFrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtReassonFrom.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then txtReassonFrom_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub txtReassonTo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtReassonTo.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then txtReassonTo_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub chkStatusProcessed_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkStatusProcessed.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then chkStatusProcessed_Validating(Nothing, Nothing)
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub chkStatusNotProcessed_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkStatusNotProcessed.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then chkStatusNotProcessed_Validating(Nothing, Nothing)
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
            txtUserFrom.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub txtUserFrom_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUserFrom.Validating
        Dim SearchPattern As String
        Dim User As Domain.User
        Dim Users As DataSet

        Try

            If Not txtUserFrom.Enabled Then Exit Try

            SearchPattern = txtUserFrom.Text

            If txtUserFrom.Text = "" Then SearchPattern = 0

            If Not IsNumeric(txtUserFrom.Text) Then SearchPattern = 0

            User = Domain.UserRepository.GetByCode(CInt(SearchPattern))

            If User IsNot Nothing Then
                txtUserFrom.Text = User.Id
                txtUserNameFrom.Text = User.NickName
                txtUserTo.Focus()
                Exit Try
            End If

            txtUserFrom.Text = ""
            txtUserNameFrom.Text = ""

            Users = Domain.UserRepository.GetAll(, , True)


            frmUser = New frmSearch("USUARIOS", Users, SearchPattern)
            frmUser.ShowDialog()

            If frmUser.SelectedValue IsNot Nothing Then
                User = Crm.Domain.UserRepository.GetByCode(frmUser.SelectedValue)
                If User IsNot Nothing Then
                    txtUserFrom.Text = User.Id
                    txtUserNameFrom.Text = User.NickName
                    txtUserTo.Focus()
                    Exit Try
                End If
            End If


        Catch ex As Exception
            frmError.ShowException(ex)
        Finally
            User = Nothing
            Users = Nothing
        End Try
    End Sub


    Private Sub txtUserTo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUserTo.Validating
        Dim SearchPattern As String
        Dim User As Domain.User
        Dim Users As DataSet

        Try

            If Not txtUserTo.Enabled Then Exit Try

            SearchPattern = txtUserTo.Text

            If txtUserTo.Text = "" Then SearchPattern = 0

            If Not IsNumeric(txtUserTo.Text) Then SearchPattern = 0

            User = Domain.UserRepository.GetByCode(CInt(SearchPattern))

            If User IsNot Nothing Then
                txtUserTo.Text = User.Id
                txtUserNameTo.Text = User.NickName
                DateFrom.Focus()
                Exit Try
            End If

            txtUserTo.Text = ""
            txtUserNameTo.Text = ""

            Users = Domain.UserRepository.GetAll(, , True)


            frmUser = New frmSearch("USUARIOS", Users, SearchPattern)
            frmUser.ShowDialog()

            If frmUser.SelectedValue IsNot Nothing Then
                User = Crm.Domain.UserRepository.GetByCode(frmUser.SelectedValue)
                If User IsNot Nothing Then
                    txtUserTo.Text = User.Id
                    txtUserNameTo.Text = User.NickName
                    DateFrom.Focus()
                    Exit Try
                End If
            End If


        Catch ex As Exception
            frmError.ShowException(ex)
        Finally
            User = Nothing
            Users = Nothing
        End Try
    End Sub

    Private Sub DateFrom_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DateFrom.Validating
        Try
            If Not IsDate(DateFrom.Text) Then
                MsgBox("Debe ingresar una fecha válida", MsgBoxStyle.Information, "Atención")
                Exit Try
            End If

            DateTo.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub DateTo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DateTo.Validating
        Try
            If Not IsDate(DateTo.Text) Then
                MsgBox("Debe ingresar una fecha válida", MsgBoxStyle.Information, "Atención")
                Exit Try
            End If

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
                txtReassonFrom.Focus()
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
                    txtReassonFrom.Focus()
                End If
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        Finally
            Customer = Nothing
            Customers = Nothing
        End Try
    End Sub



    Private Sub txtReassonFrom_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtReassonFrom.Validating
        Dim SearchPattern As String
        Dim Reasson As Domain.Customer.CustomerDeleteReasson
        Dim Reassons As DataSet

        Try

            If Not txtReassonFrom.Enabled Then Exit Try

            SearchPattern = txtReassonFrom.Text

            If txtReassonFrom.Text = "" Then SearchPattern = 0

            If Not IsNumeric(txtReassonFrom.Text) Then SearchPattern = 0

            Reasson = Domain.CustomerRepository.GetCancelReassonById(CInt(SearchPattern))

            If Reasson IsNot Nothing Then
                txtReassonFrom.Text = Reasson.Id
                txtReassonNameFrom.Text = Reasson.Name
                txtReassonTo.Focus()
                Exit Try
            End If

            txtReassonFrom.Text = ""
            txtReassonNameFrom.Text = ""

            Reassons = Domain.CustomerRepository.GetAllCancelReassons(, , True)

            frmReasson = New frmSearch("MOTIVOS DE BAJA", Reassons, SearchPattern)
            frmReasson.ShowDialog()

            If frmReasson.SelectedValue IsNot Nothing Then
                Reasson = Domain.CustomerRepository.GetCancelReassonById(CInt(frmReasson.SelectedValue))
                If Reasson IsNot Nothing Then
                    txtReassonFrom.Text = Reasson.Id
                    txtReassonNameFrom.Text = Reasson.Name
                    txtReassonTo.Focus()
                    Exit Try
                End If
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        Finally
            Reasson = Nothing
            Reassons = Nothing
        End Try
    End Sub

    Private Sub txtReassonTo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtReassonTo.Validating
        Dim SearchPattern As String
        Dim Reasson As Domain.Customer.CustomerDeleteReasson
        Dim Reassons As DataSet

        Try

            If Not txtReassonTo.Enabled Then Exit Try

            SearchPattern = txtReassonTo.Text

            If txtReassonTo.Text = "" Then SearchPattern = 0

            If Not IsNumeric(txtReassonTo.Text) Then SearchPattern = 0

            Reasson = Domain.CustomerRepository.GetCancelReassonById(CInt(SearchPattern))

            If Reasson IsNot Nothing Then
                txtReassonTo.Text = Reasson.Id
                txtReassonNameTo.Text = Reasson.Name
                chkStatusProcessed.Focus()
                Exit Try
            End If

            txtReassonTo.Text = ""
            txtReassonNameTo.Text = ""

            Reassons = Domain.CustomerRepository.GetAllCancelReassons(, , True)

            frmReasson = New frmSearch("MOTIVOS DE BAJA", Reassons, SearchPattern)
            frmReasson.ShowDialog()

            If frmReasson.SelectedValue IsNot Nothing Then
                Reasson = Domain.CustomerRepository.GetCancelReassonById(CInt(frmReasson.SelectedValue))
                If Reasson IsNot Nothing Then
                    txtReassonTo.Text = Reasson.Id
                    txtReassonNameTo.Text = Reasson.Name
                    chkStatusNotProcessed.Focus()
                    Exit Try
                End If
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        Finally
            Reasson = Nothing
            Reassons = Nothing
        End Try
    End Sub

    Private Sub chkStatusProcessed_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles chkStatusProcessed.Validating
        Try
            chkStatusNotProcessed.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub chkStatusNotProcessed_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles chkStatusNotProcessed.Validating
        Try
            ShowReport()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub frmUser_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmUser.ParametersChanged
        Dim Users As DataSet = Nothing

        Try
            Users = Domain.UserRepository.GetAll(Field, value, False)

            frmUser.DataSource = Users

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub frmPotentialCustomer_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmCustomer.ParametersChanged
        Dim Customers As DataSet

        Try
            Customers = Domain.CustomerRepository.GetAll(optPotentialCustomer.Checked, Domain.SystemUser.Id, Domain.SystemUser.FullDomain, Field, value, False)

            frmCustomer.DataSource = Customers

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub

    Private Sub frmReasson_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmReasson.ParametersChanged
        Dim Reassons As DataSet = Nothing

        Try
            Reassons = Domain.CustomerRepository.GetAllCancelReassons(Field, value, False)

            frmReasson.DataSource = Reassons

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

End Class