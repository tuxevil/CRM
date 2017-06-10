Public Class frmDeleteCustomer

    Private WithEvents frmSearchCustomer As frmSearch
    Private WithEvents frmSearchReassons As frmSearch

    Private PotentialCustomer As Boolean

    Public Sub New(Optional ByVal Potential As Boolean = False)
        InitializeComponent()
        PotentialCustomer = Potential
    End Sub

    Public Sub New(ByVal CustomerCode As String, Optional ByVal Potential As Boolean = False)
        InitializeComponent()
        txtCode.Text = CustomerCode
        PotentialCustomer = Potential
    End Sub

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            CancelDate.Value = Now()

            cmbReasson.DataSource = Domain.CustomerRepository.GetCancelReassons
            cmbReasson.DisplayMember = "Name"
            cmbReasson.ValueMember = "Id"

            If cmbReasson.Items.Count <= 0 Then
                MsgBox("No existen motivos de baja", MsgBoxStyle.Information, "Atención")
                Me.Close()
            End If

            txtCode.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
            Me.Close()
        End Try
    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode

                Case Keys.Escape
                    txtCode.ReadOnly = True
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
                    Me.Close()

                Case Keys.F10
                    StartProcess()
                    Me.Close()
            End Select
        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub Code_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If CodeValid() Then CancelDate.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub CancelDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CancelDate.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            cmbReasson.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub cmbReasson_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbReasson.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            StartProcess()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub Code_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCode.Validating
        Try

            CodeValid()

        Catch ex As Exception
            frmError.ShowException(ex)
            e.Cancel = True
        End Try

    End Sub

    Private Function CodeValid() As Boolean
        Dim SearchPattern As String
        Dim Customer As Crm.Domain.Customer
        Dim Customers As DataSet = Nothing

        Try

            If txtCode.ReadOnly Then Return True

            SearchPattern = txtCode.Text

            Customer = Crm.Domain.CustomerRepository.GetByCode(SearchPattern, PotentialCustomer)

            If Customer IsNot Nothing Then
                If Domain.CustomerRepository.CustomerDeleted(PotentialCustomer, Customer.Code) > 0 Then
                    MsgBox("Cliente eliminado", MsgBoxStyle.Information, "Atención")
                    Customer = Nothing
                    txtCode.Text = ""
                    txtLegalName.Text = ""
                    Exit Try
                Else
                    txtCode.Text = Customer.Code
                    txtLegalName.Text = Customer.Name
                    Return True
                End If
            End If

            Customers = Crm.Domain.CustomerRepository.GetAll(PotentialCustomer, Domain.SystemUser.Id, Domain.SystemUser.FullDomain, , , True)

            frmSearchCustomer = New frmSearch("CLIENTES", Customers, SearchPattern)
            frmSearchCustomer.ShowDialog()

            If frmSearchCustomer.SelectedValue IsNot Nothing Then
                Customer = Crm.Domain.CustomerRepository.GetByCode(frmSearchCustomer.SelectedValue, PotentialCustomer)
                If Customer IsNot Nothing Then
                    If Domain.CustomerRepository.CustomerDeleted(PotentialCustomer, Customer.Code) > 0 Then
                        MsgBox("Cliente eliminado", MsgBoxStyle.Information, "Atención")
                        Customer = Nothing
                        txtCode.Text = ""
                        txtLegalName.Text = ""
                        Exit Try
                    Else
                        txtCode.Text = Customer.Code
                        txtLegalName.Text = Customer.Name
                        Return True
                    End If
                End If
            End If


        Catch ex As Exception
            frmError.ShowException(ex)
        Finally
            Customer = Nothing
            Customers = Nothing
            frmSearchCustomer = Nothing
        End Try

    End Function

    Private Sub StartProcess()
        Try

            If Not CodeValid() Then Exit Try

            If cmbReasson.SelectedItem Is Nothing Then Exit Try

            Domain.CustomerRepository.CustomerToDelete(PotentialCustomer, txtCode.Text, CancelDate.Value, cmbReasson.SelectedValue)

            txtCode.Focus()

            txtCode.Text = ""
            txtLegalName.Text = ""

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub BrowserCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserCancel.Click, MenuFileExit.Click
        Try
            txtCode.ReadOnly = True
            Me.Close()
        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub MenuProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuProcess.Click, BrowserAccept.Click
        Try
            StartProcess()
        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub

End Class