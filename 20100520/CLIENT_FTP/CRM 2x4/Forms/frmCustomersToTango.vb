Public Class frmCustomersToTango

    Private WithEvents frmSearchCustomer As frmSearch

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal CustomerCode As String)
        InitializeComponent()
        txtCode.Text = CustomerCode
    End Sub

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

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
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
                    Me.Close()

                Case Keys.F10
                    StartProcess()
                    Me.Close()
            End Select
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Code_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If CodeValid() Then txtNewCode.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub NewCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNewCode.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If NewCodeValid() Then StartProcess()

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

            SearchPattern = txtCode.Text

            Customer = Crm.Domain.CustomerRepository.GetByCode(SearchPattern, True)

            If Customer IsNot Nothing Then
                txtCode.Text = Customer.Code
                txtLegalName.Text = Customer.Name
                Return True
            End If

            Customers = Crm.Domain.CustomerRepository.GetAll(True, Domain.SystemUser.Id, Domain.SystemUser.FullDomain, , , True)

            frmSearchCustomer = New frmSearch("CLIENTES POTENCIALES", Customers, SearchPattern)
            frmSearchCustomer.ShowDialog()

            If frmSearchCustomer.SelectedValue IsNot Nothing Then
                Customer = Crm.Domain.CustomerRepository.GetByCode(frmSearchCustomer.SelectedValue, True)
                If Customer IsNot Nothing Then
                    txtCode.Text = Customer.Code
                    txtLegalName.Text = Customer.Name
                    Return True
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

    Private Function NewCodeValid() As Boolean
        Dim Id As Integer

        Try
            If txtNewCode.Text = "" Then
                MsgBox("CAMPO OBLIGATORIO", MsgBoxStyle.Exclamation, "Atención")
                txtNewCode.Focus()
                Return False
            End If

            If txtNewCode.Text = New String("0", Len(txtNewCode.Text)) Then
                MsgBox("CODIGO INVALIDO", MsgBoxStyle.Exclamation, "Atención")
                txtNewCode.Focus()
                Return False
            End If

            If txtNewCode.Text.StartsWith("P") Then
                MsgBox("CODIGO RESERVADO PARA CLIENTES POTENCIALES", MsgBoxStyle.Exclamation, "Atención")
                txtNewCode.Focus()
                Return False
            End If

            Id = Domain.CustomerRepository.GetIdByCode(txtNewCode.Text)

            If Id <> 0 Then
                MsgBox("CODIGO EXISTENTE", MsgBoxStyle.Exclamation, "Atención")
                txtNewCode.SelectAll()
                Return False
            End If

            Return True

        Catch ex As Exception
            frmError.ShowException(ex)
            Return False
        End Try

    End Function

    Private Sub StartProcess()
        Try

            If Not CodeValid() Then Exit Try

            If Not NewCodeValid() Then Exit Try

            Domain.CustomerRepository.SetPotentialToReal(txtCode.Text, txtNewCode.Text)

            txtCode.Focus()

            txtCode.Text = ""
            txtLegalName.Text = ""
            txtNewCode.Text = ""

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub BrowserCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserCancel.Click, MenuFileExit.Click
        Try
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