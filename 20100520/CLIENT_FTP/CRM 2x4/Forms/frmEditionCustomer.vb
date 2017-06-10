Public Class frmEditionCustomer

    Private OriginalCustomer As Crm.Domain.Customer
    Private Customer As Crm.Domain.Customer

    Private EditionCanceled As Boolean

    Private WithEvents frmGroups As frmSearch
    Private WithEvents frmStates As frmSearch
    Private WithEvents frmZones As frmSearch
    Private WithEvents frmTransports As frmSearch
    Private WithEvents frmCurrency As frmSearch
    Private WithEvents frmSalesTerms As frmSearch
    Private WithEvents frmEmployee As frmSearch
    Private WithEvents frmTaxes As frmSearch

    Public Sub New(ByVal CustomerSource As Crm.Domain.Customer, Optional ByVal Potential As Boolean = False)
        InitializeComponent()


        Try

            OriginalCustomer = CustomerSource
            Customer = CustomerSource

            Customer.Potential = Potential

            If Customer.Potential Then
                tbAdress.Visible = Domain.SystemUser.Profile.CustomerPotentialViewAdress
                tbDelivery.Visible = Domain.SystemUser.Profile.CustomerPotentialViewDelivery
                tbTerms.Visible = Domain.SystemUser.Profile.CustomerPotentialViewTerms
                tbNotes.Visible = Domain.SystemUser.Profile.CustomerPotentialViewNotes

            Else
                tbAdress.Visible = Domain.SystemUser.Profile.CustomerRealViewAdress
                tbDelivery.Visible = Domain.SystemUser.Profile.CustomerRealViewDelivery
                tbTerms.Visible = Domain.SystemUser.Profile.CustomerRealViewTerms
                tbNotes.Visible = Domain.SystemUser.Profile.CustomerRealViewNotes

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            DrawMe()

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try

    End Sub


    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            EditionCanceled = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DrawMe()

        Try

            DrawControls()

            Me.Controls.Remove(pnlBasic)
            Me.Controls.Remove(pnlAdress)
            Me.Controls.Remove(pnlDelivery)
            Me.Controls.Remove(pnlTerms)
            Me.Controls.Remove(pnlNotes)

            GotoModules(tbGeneral, System.EventArgs.Empty)

            BindControls()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GotoModules(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbAdress.Click, tbDelivery.Click, tbGeneral.Click, tbNotes.Click, tbTerms.Click

        Dim panel As Panel = Nothing

        frmSplit.Panel2.Controls.Clear()

        For Each Button As ToolStripButton In tsCustomer.Items
            Button.Checked = False
        Next

        Select Case sender.Name

            Case tbGeneral.Name
                panel = pnlBasic

            Case tbAdress.Name
                panel = pnlAdress

            Case tbDelivery.Name
                panel = pnlDelivery

            Case tbTerms.Name
                panel = pnlTerms

            Case tbNotes.Name
                panel = pnlNotes

        End Select

        If panel IsNot Nothing Then
            frmSplit.Panel2.Controls.Add(panel)
            panel.Dock = DockStyle.Fill
            sender.checked = True
        End If

    End Sub

    Private Sub DrawControls()
        Dim Pnl As Panel
        Dim Lbl As Label = Nothing
        Dim Txt As TextBox = Nothing
        Dim Chk As CheckBox

        Try
            For Each FormControl As Control In Me.Controls
                Pnl = TryCast(FormControl, Panel)

                If Pnl IsNot Nothing Then

                    For Each Control As Control In Pnl.Controls

                        Lbl = TryCast(Control, Label)
                        If Lbl IsNot Nothing Then
                            If Lbl.Tag <> "" Then
                                Lbl.Text = Crm.Domain.SystemObjectsRepository.GetPropertyDisplayName(Lbl.Tag, Lbl.Text)
                                Lbl.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                            End If
                        End If
                    Next

                    For Each Control As Control In Pnl.Controls
                        Txt = TryCast(Control, TextBox)
                        If Txt IsNot Nothing Then
                            If Txt.Tag <> "" Then
                                Txt.MaxLength = Crm.Domain.SystemObjectsRepository.GetPropertyLen(Txt.Tag, Txt.MaxLength)
                            End If
                        End If
                    Next

                    For Each Control As Control In Pnl.Controls
                        Chk = TryCast(Control, CheckBox)
                        If Chk IsNot Nothing Then
                            If Chk.Tag <> "" Then
                                Chk.Text = Crm.Domain.SystemObjectsRepository.GetPropertyDisplayName(Chk.Tag, Chk.Text)
                            End If
                        End If
                    Next


                End If

            Next

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try

    End Sub

    Private Sub BindControls()
        Try

            txtCode.Text = Customer.Code
            If Not Customer.Potential Then
                If Customer.Id <> 0 Then
                    txtCode.ReadOnly = True
                    txtCode.TabStop = False
                End If
            Else
                txtCode.ReadOnly = True
                txtCode.TabStop = False
            End If


            txtLegalName.Text = Customer.LegalName
            txtName.Text = Customer.Name
            If Customer.Group IsNot Nothing Then
                txtGroupCode.Text = Customer.Group.Code
                txtGroupName.Text = Customer.Group.Name
            End If
            txtAdress.Text = Customer.Adress
            txtZipCode.Text = Customer.ZipCode
            txtCity.Text = Customer.City
            If Customer.State IsNot Nothing Then
                txtStateCode.Text = Customer.State.Code
                txtStateName.Text = Customer.State.Name
            End If
            If Customer.Zone IsNot Nothing Then
                txtZoneCode.Text = Customer.Zone.Code
                txtZoneName.Text = Customer.Zone.Name
            End If
            txtPhone.Text = Customer.Phone
            txtFax.Text = Customer.Fax
            txtMail.Text = Customer.Mail
            txtWeb.Text = Customer.Web
            txtDeliveryAdress.Text = Customer.DeliveryAdress
            If Customer.Transport IsNot Nothing Then
                txtTranspCode.Text = Customer.Transport.Code
                txtTranspName.Text = Customer.Transport.Name
                txtHours.Text = Customer.Hours
            End If
            txtCuit.Text = Customer.CUIT
            txtIBNumber.Text = Customer.IBNumber
            If Customer.Currency IsNot Nothing Then
                txtCurrencyCode.Text = Customer.Currency.Code
                txtCurrencyName.Text = Customer.Currency.Name
            End If
            txtDiscount.Text = Customer.DiscountPercent
            If Customer.SalesTerm IsNot Nothing Then
                txtSalesTermsCode.Text = Customer.SalesTerm.Code
                txtSalesTermsName.Text = Customer.SalesTerm.Name
            End If
            If Customer.Employee IsNot Nothing Then
                txtEmployeeCode.Text = Customer.Employee.Code
                txtEmployeeName.Text = Customer.Employee.Name
            End If

            chkIVACalc.Checked = Customer.IVACalc
            chkIVADetail.Checked = Customer.IVADetail
            chkIVAPlus.Checked = Customer.IVAPlus
            chkIVAFree.Checked = Customer.IVAFree
            txtIvaFreePercent.Text = Customer.IVAFreePercent
            txtIvaExclusionPercent.Text = Customer.IVAExclusionPercent
            If Customer.NCTax IsNot Nothing Then txtNCTaxCode.Text = Customer.NCTax.Code
            chkInternalTaxCalc.Checked = Customer.InternalTaxCalc
            chkInternalTaxDetail.Checked = Customer.InternalTaxDetail
            chkInternalTaxPlus.Checked = Customer.InternalTaxPlus

            chkIBCalc.Checked = Customer.IBCalc
            If Customer.IBTax IsNot Nothing Then txtIBTaxCode.Text = Customer.IBTax.Code
            If Customer.IBTaxAditional IsNot Nothing Then txtIBTaxCode.Text = Customer.IBTaxAditional.Code

            chkIBBCalc.Checked = Customer.IBBCalc
            chkIBBInternalTax.Checked = Customer.IBBInternalTax
            chkIBBCalc.Checked = Customer.IBBCalc
            If Customer.IBBTax IsNot Nothing Then txtIBBTaxCode.Text = Customer.IBBTax.Code

            txtNotes.Text = Customer.Notes

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try

    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    EditionCanceled = True
                    Me.Close()

                Case Keys.F10 : SaveEntity()

            End Select

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub Code_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If CodeValid() Then txtLegalName.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub LegalName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLegalName.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            txtName.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub Name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            txtGroupCode.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub GroupCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGroupCode.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If GroupCodeValid() Then

                If pnlAdress.Visible Then

                    GotoModules(tbAdress, System.EventArgs.Empty)

                    txtAdress.Focus()

                    Exit Sub
                Else

                    If pnlDelivery.Visible Then

                        GotoModules(tbDelivery, System.EventArgs.Empty)

                        txtDeliveryAdress.Focus()

                        Exit Sub
                    Else

                        If pnlTerms.Visible Then

                            GotoModules(tbTerms, System.EventArgs.Empty)

                            txtCuit.Focus()

                            Exit Sub
                        Else

                            If pnlNotes.Visible Then

                                GotoModules(tbNotes, System.EventArgs.Empty)

                                txtNotes.Focus()

                                Exit Sub

                            Else

                                SaveEntity()

                            End If

                        End If

                    End If

                End If

            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub Address_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAdress.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            txtCity.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub City_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCity.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            txtZipCode.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub ZipCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtZipCode.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            txtStateCode.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub State_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStateCode.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If StateValid() Then txtZoneCode.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub Zone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtZoneCode.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If ZoneValid() Then txtPhone.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub Phone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPhone.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            txtFax.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub Fax_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFax.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            txtMail.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub Mail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMail.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If MailValid() Then txtWeb.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub Web_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtWeb.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If WebValid() Then

                If pnlDelivery.Visible Then

                    GotoModules(tbDelivery, System.EventArgs.Empty)

                    txtDeliveryAdress.Focus()

                    Exit Sub

                Else

                    If pnlTerms.Visible Then

                        GotoModules(tbTerms, System.EventArgs.Empty)

                        txtCuit.Focus()

                        Exit Sub

                    Else

                        If pnlNotes.Visible Then

                            GotoModules(tbNotes, System.EventArgs.Empty)

                            txtNotes.Focus()

                            Exit Sub

                        Else

                            SaveEntity()

                        End If

                    End If

                End If

            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub DeliveryAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDeliveryAdress.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            txtHours.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub Hours_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHours.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            txtTranspCode.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub TransportCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTranspCode.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If TransportValid() Then

                If pnlTerms.Visible Then

                    GotoModules(tbTerms, System.EventArgs.Empty)

                    txtCuit.Focus()

                    Exit Sub

                Else

                    If pnlNotes.Visible Then

                        GotoModules(tbNotes, System.EventArgs.Empty)

                        txtNotes.Focus()

                        Exit Sub

                    Else

                        SaveEntity()

                    End If

                End If

            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub

    Private Sub CUIT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuit.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If CUITValid() Then txtIBNumber.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub IBNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIBNumber.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            txtCurrencyCode.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub CurrencyCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCurrencyCode.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If CurrencyValid() Then txtDiscount.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub Discount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiscount.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If NumberValid(sender) Then txtSalesTermsCode.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub SalesTerms_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSalesTermsCode.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If SalesTermsValid() Then txtEmployeeCode.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub EmployeeCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmployeeCode.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If EmployeeValid() Then chkIVACalc.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub IVACalc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkIVACalc.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If chkIVACalc.Checked Then
                chkIVADetail.Focus()
            Else
                chkIVAFree.Focus()
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub IVADetail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkIVADetail.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If chkIVACalc.Checked Then
                chkIVAPlus.Focus()
            Else
                chkIVAFree.Focus()
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub IVAPlus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkIVAPlus.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            chkIVAFree.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub IVAFree_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkIVAFree.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If chkIVAFree.Checked Then
                txtIvaFreePercent.Focus()
            Else
                If chkIVACalc.Checked Then
                    txtIvaExclusionPercent.Focus()
                Else
                    txtNCTaxCode.Focus()
                End If
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub IVAFreePercent_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIvaFreePercent.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If NumberValid(sender) Then

                If txtIvaExclusionPercent.Enabled Then
                    txtIvaExclusionPercent.Focus()
                Else
                    If txtNCTaxCode.Enabled Then
                        txtNCTaxCode.Focus()
                    Else
                        chkIBCalc.Focus()
                    End If
                End If

            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub IvaExclusionPercent_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIvaExclusionPercent.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If NumberValid(sender) Then

                If txtNCTaxCode.Enabled Then
                    txtNCTaxCode.Focus()
                Else
                    chkIBCalc.Focus()
                End If
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub NCTaxCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNCTaxCode.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If TaxValid(sender) Then chkIBCalc.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub IBCalc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkIBCalc.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If chkIBCalc.Checked Then
                txtIBTaxCode.Focus()
            Else
                chkInternalTaxCalc.Focus()
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub IBTaxCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIBTaxCode.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If TaxValid(sender) Then txtIBAditionalTaxCode.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub IBAditionalTaxCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIBAditionalTaxCode.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If TaxValid(sender) Then chkInternalTaxCalc.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub InternalTaxCalc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkInternalTaxCalc.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If chkInternalTaxCalc.Checked Then
                chkInternalTaxDetail.Focus()
            Else
                chkIBBCalc.Focus()
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub InternalTaxDetail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkInternalTaxDetail.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            chkInternalTaxPlus.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub InternalTaxPlus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkInternalTaxPlus.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            chkIBBCalc.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub IBBCalc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkIBBCalc.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If chkIBBCalc.Checked Then
                chkIBBInternalTax.Focus()
            Else
                If pnlNotes.Visible Then

                    GotoModules(tbNotes, System.EventArgs.Empty)

                    txtNotes.Focus()

                    Exit Sub

                End If

            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub IBBInternalTax_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkIBBInternalTax.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            txtIBBTaxCode.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub IBBTaxCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIBBTaxCode.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If TaxValid(sender) Then

                If pnlNotes.Visible Then

                    GotoModules(tbNotes, System.EventArgs.Empty)

                    txtNotes.Focus()

                    Exit Sub

                End If

            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub Code_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCode.Validating
        Try
            If EditionCanceled Then Exit Sub

            e.Cancel = Not CodeValid()

        Catch ex As Exception
            frmError.ShowException(ex)
            e.Cancel = True
        End Try

    End Sub

    Private Sub LegalName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtLegalName.Validating
        Try
            If EditionCanceled Then Exit Sub

            e.Cancel = Not LegalNameValid()

        Catch ex As Exception
            frmError.ShowException(ex)
            e.Cancel = True
        End Try

    End Sub

    Private Sub GroupValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtGroupCode.Validating
        Try
            If EditionCanceled Then Exit Sub

            e.Cancel = Not LegalNameValid()

        Catch ex As Exception
            frmError.ShowException(ex)
            e.Cancel = True
        End Try

    End Sub

    Private Sub StateValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtStateCode.Validating
        Try
            If EditionCanceled Then Exit Sub

            e.Cancel = Not StateValid()

        Catch ex As Exception
            frmError.ShowException(ex)
            e.Cancel = True
        End Try

    End Sub

    Private Sub ZoneValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtZoneCode.Validating
        Try
            If EditionCanceled Then Exit Sub

            e.Cancel = Not ZoneValid()

        Catch ex As Exception
            frmError.ShowException(ex)
            e.Cancel = True
        End Try

    End Sub

    Private Sub MailValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMail.Validating
        Try
            If EditionCanceled Then Exit Sub

            e.Cancel = Not MailValid()

        Catch ex As Exception
            frmError.ShowException(ex)
            e.Cancel = True
        End Try

    End Sub

    Private Sub WebValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtWeb.Validating
        Try
            If EditionCanceled Then Exit Sub

            e.Cancel = Not WebValid()

        Catch ex As Exception
            frmError.ShowException(ex)
            e.Cancel = True
        End Try

    End Sub

    Private Sub TransportValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTranspCode.Validating
        Try
            If EditionCanceled Then Exit Sub

            e.Cancel = Not TransportValid()

        Catch ex As Exception
            frmError.ShowException(ex)
            e.Cancel = True
        End Try

    End Sub


    Private Sub CUITValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCuit.Validating
        Try
            If EditionCanceled Then Exit Sub

            e.Cancel = Not CUITValid()

        Catch ex As Exception
            frmError.ShowException(ex)
            e.Cancel = True
        End Try

    End Sub

    Private Sub CurrencyValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCurrencyCode.Validating
        Try
            If EditionCanceled Then Exit Sub

            e.Cancel = Not CurrencyValid()

        Catch ex As Exception
            frmError.ShowException(ex)
            e.Cancel = True
        End Try

    End Sub

    Private Sub SalesTermsValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSalesTermsCode.Validating
        Try
            If EditionCanceled Then Exit Sub

            e.Cancel = Not SalesTermsValid()

        Catch ex As Exception
            frmError.ShowException(ex)
            e.Cancel = True
        End Try

    End Sub

    Private Sub EmployeeValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmployeeCode.Validating
        Try
            If EditionCanceled Then Exit Sub

            e.Cancel = Not EmployeeValid()

        Catch ex As Exception
            frmError.ShowException(ex)
            e.Cancel = True
        End Try

    End Sub

    Private Sub TaxValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIBTaxCode.Validating, txtIBAditionalTaxCode.Validating, txtIBBTaxCode.Validating, txtNCTaxCode.Validating
        Try
            If EditionCanceled Then Exit Sub

            e.Cancel = Not TaxValid(sender)

        Catch ex As Exception
            frmError.ShowException(ex)
            e.Cancel = True
        End Try

    End Sub

    Private Sub Number_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIvaFreePercent.Validating, txtIvaExclusionPercent.Validating, txtDiscount.Validating
        Try

            If EditionCanceled Then Exit Sub

            e.Cancel = Not NumberValid(sender)

        Catch ex As Exception
            frmError.ShowException(ex)
            e.Cancel = True
        End Try

    End Sub




    Private Function CodeValid() As Boolean
        Dim Obj As Domain.Customer

        Try
            If txtCode.ReadOnly Then Return True

            If txtCode.Text = "" Then
                MsgBox("CAMPO OBLIGATORIO", MsgBoxStyle.Exclamation, "Atención")
                txtCode.Focus()
                Return False
            End If

            If txtCode.Text = New String("0", Len(txtCode.Text)) Then
                MsgBox("CODIGO INVALIDO", MsgBoxStyle.Exclamation, "Atención")
                txtCode.Focus()
                Return False
            End If

            If txtCode.Text.StartsWith("P") And Not Customer.Potential Then
                MsgBox("CODIGO RESERVADO PARA CLIENTES POTENCIALES", MsgBoxStyle.Exclamation, "Atención")
                txtCode.Focus()
                Return False
            End If

            Obj = Domain.CustomerRepository.GetByCode(txtCode.Text, Customer.Potential)

            If Obj Is Nothing Then Return True

            If Obj.Id <> 0 Then
                MsgBox("CODIGO EXISTENTE", MsgBoxStyle.Exclamation, "Atención")
                txtCode.SelectAll()
                Return False
            End If

            Return True

        Catch ex As Exception
            frmError.ShowException(ex)
            Return False
        Finally
            Obj = Nothing
        End Try

    End Function

    Private Function LegalNameValid() As Boolean
        Try

            If txtLegalName.Text = "" Then
                MsgBox("CAMPO OBLIGATORIO", MsgBoxStyle.Exclamation, "Atención")
                txtLegalName.Focus()
                Return False
            End If

            If txtName.Text = "" Then txtName.Text = txtLegalName.Text

            Return True

        Catch ex As Exception
            frmError.ShowException(ex)
            Return False
        End Try
    End Function

    Private Function GroupCodeValid() As Boolean
        Dim SearchPattern As String
        Dim group As Crm.Domain.CustomerGroup
        Dim Groups As DataSet = Nothing

        Try
            If txtGroupCode.Text = "" Then Return True

            SearchPattern = txtGroupCode.Text

            group = Crm.Domain.CustomerGroupRepository.GetByCode(SearchPattern)

            If group IsNot Nothing Then
                txtGroupCode.Text = group.Code
                txtGroupName.Text = group.Name
                Return True
            End If

            Groups = Crm.Domain.CustomerGroupRepository.GetAll(, , True)

            frmGroups = New frmSearch("GRUPOS EMPRESARIOS", Groups, SearchPattern)
            frmGroups.ShowDialog()

            If frmGroups.SelectedValue IsNot Nothing Then
                group = Crm.Domain.CustomerGroupRepository.GetByCode(frmGroups.SelectedValue)
                If group IsNot Nothing Then
                    txtGroupCode.Text = group.Code
                    txtGroupName.Text = group.Name
                    Return True
                End If
            End If


        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Function

    Private Function StateValid() As Boolean
        Dim SearchPattern As String
        Dim State As Crm.Domain.State
        Dim States As DataSet = Nothing

        Try
            If txtStateCode.Text = "" Then
                MsgBox("CAMPO OBLIGATORIO", MsgBoxStyle.Exclamation, "Atención")
                txtStateCode.Focus()
                Return False
            End If

            SearchPattern = txtStateCode.Text

            State = Crm.Domain.StateRepository.GetByCode(SearchPattern)

            If State IsNot Nothing Then
                txtStateCode.Text = State.Code
                txtStateName.Text = State.Name
                Return True
            End If

            States = Crm.Domain.StateRepository.GetAll(, , True)

            frmStates = New frmSearch("PROVINCIAS / PAISES", States, SearchPattern)
            frmStates.ShowDialog()

            If frmStates.SelectedValue IsNot Nothing Then
                State = Crm.Domain.StateRepository.GetByCode(frmStates.SelectedValue)
                If State IsNot Nothing Then
                    txtStateCode.Text = State.Code
                    txtGroupName.Text = State.Name
                    Return True
                End If
            End If


        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Function

    Private Function ZoneValid() As Boolean
        Dim SearchPattern As String
        Dim Zone As Crm.Domain.Zone
        Dim Zones As DataSet = Nothing

        Try
            If txtZoneCode.Text = "" Then
                MsgBox("CAMPO OBLIGATORIO", MsgBoxStyle.Exclamation, "Atención")
                txtZoneCode.Focus()
                Return False
            End If

            SearchPattern = txtZoneCode.Text

            Zone = Crm.Domain.ZoneRepository.GetByCode(SearchPattern)

            If Zone IsNot Nothing Then
                txtZoneCode.Text = Zone.Code
                txtZoneName.Text = Zone.Name
                Return True
            End If

            Zones = Crm.Domain.ZoneRepository.GetAll(, , True)

            frmZones = New frmSearch("ZONAS", Zones, SearchPattern)
            frmZones.ShowDialog()

            If frmZones.SelectedValue IsNot Nothing Then
                Zone = Crm.Domain.ZoneRepository.GetByCode(frmZones.SelectedValue)
                If Zone IsNot Nothing Then
                    txtZoneCode.Text = Zone.Code
                    txtZoneName.Text = Zone.Name
                    Return True
                End If
            End If


        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Function

    Private Function MailValid() As Boolean
        Dim MailModel As System.Text.RegularExpressions.Regex = Nothing

        Try
            MailModel = New System.Text.RegularExpressions.Regex("^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$", System.Text.RegularExpressions.RegexOptions.None)

            If txtMail.Text = "" Then Return True

            If Not MailModel.IsMatch(txtMail.Text) Then

                If MsgBox("Mail inválido. Confirma?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENCIÓN") <> MsgBoxResult.Yes Then
                    Return False
                Else
                    Return True
                End If
            Else
                Return True
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
            Return False
        End Try

    End Function

    Private Function WebValid() As Boolean
        Dim WebModel As System.Text.RegularExpressions.Regex = Nothing

        Try
            WebModel = New System.Text.RegularExpressions.Regex("^[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)( [a-zA-Z0-9\-\.\?\,\'\/\\\+&%\$#_]*)?$", System.Text.RegularExpressions.RegexOptions.None)

            If txtWeb.Text = "" Then Return True


            If Not WebModel.IsMatch(txtWeb.Text) Then

                If MsgBox("Web inválida. Confirma?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENCIÓN") <> MsgBoxResult.Yes Then
                    Return False
                Else
                    Return True
                End If
            Else
                Return True
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
            Return False
        End Try

    End Function

    Private Function TransportValid() As Boolean
        Dim SearchPattern As String
        Dim Transport As Crm.Domain.Transport
        Dim Transports As DataSet = Nothing

        Try
            If txtTranspCode.Text = "" Then Return True

            SearchPattern = txtTranspCode.Text

            Transport = Crm.Domain.TransportRepository.GetByCode(SearchPattern)

            If Transport IsNot Nothing Then
                txtTranspCode.Text = Transport.Code
                txtTranspName.Text = Transport.Name
                Return True
            End If

            Transports = Crm.Domain.TransportRepository.GetAll(, , True)

            frmTransports = New frmSearch("TRANSPORTES", Transports, SearchPattern)
            frmTransports.ShowDialog()

            If frmTransports.SelectedValue IsNot Nothing Then
                Transport = Crm.Domain.TransportRepository.GetByCode(frmTransports.SelectedValue)
                If Transport IsNot Nothing Then
                    txtTranspCode.Text = Transport.Code
                    txtTranspName.Text = Transport.Name
                    Return True
                End If
            End If


        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Function

    Private Function CUITValid() As Boolean
        Dim CUITModel As System.Text.RegularExpressions.Regex = Nothing

        Try
            CUITModel = New System.Text.RegularExpressions.Regex("[0-9][0-9]\-[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]\-[0-9]$", System.Text.RegularExpressions.RegexOptions.None)

            If txtCuit.Text = "" Then Return True

            If Not CUITModel.IsMatch(txtCuit.Text) Then

                If MsgBox("CUIT inválido. Confirma?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENCIÓN") <> MsgBoxResult.Yes Then
                    Return False
                Else
                    Return True
                End If
            Else
                Return True
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
            Return False
        End Try
    End Function

    Private Function CurrencyValid() As Boolean
        Dim SearchPattern As String
        Dim Currency As Crm.Domain.Currency
        Dim Currencies As DataSet = Nothing

        Try
            If txtCurrencyCode.Text = "" Then
                MsgBox("CAMPO OBLIGATORIO", MsgBoxStyle.Exclamation, "Atención")
                txtCurrencyCode.Focus()
                Return False
            End If

            SearchPattern = txtCurrencyCode.Text

            Currency = Crm.Domain.CurrencyRepository.GetByCode(SearchPattern)

            If Currency IsNot Nothing Then
                txtCurrencyCode.Text = Currency.Code
                txtCurrencyName.Text = Currency.Name
                Return True
            End If

            Currencies = Crm.Domain.CurrencyRepository.GetAll(, , True)

            frmCurrency = New frmSearch("MONEDAS", Currencies, SearchPattern)
            frmCurrency.ShowDialog()

            If frmCurrency.SelectedValue IsNot Nothing Then
                Currency = Crm.Domain.CurrencyRepository.GetByCode(frmCurrency.SelectedValue)
                If Currency IsNot Nothing Then
                    txtCurrencyCode.Text = Currency.Code
                    txtCurrencyName.Text = Currency.Name
                    Return True
                End If
            End If


        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Function

    Private Function SalesTermsValid() As Boolean
        Dim SearchPattern As String
        Dim SalesTerm As Crm.Domain.SalesTerm
        Dim SalesTerms As DataSet = Nothing

        Try
            If txtSalesTermsCode.Text = "" Then
                MsgBox("CAMPO OBLIGATORIO", MsgBoxStyle.Exclamation, "Atención")
                txtSalesTermsCode.Focus()
                Return False
            End If

            SearchPattern = txtSalesTermsCode.Text

            SalesTerm = Crm.Domain.SalesTermRepository.GetByCode(SearchPattern)

            If SalesTerm IsNot Nothing Then
                txtSalesTermsCode.Text = SalesTerm.Code
                txtSalesTermsName.Text = SalesTerm.Name
                Return True
            End If

            SalesTerms = Crm.Domain.SalesTermRepository.GetAll(, , True)

            frmSalesTerms = New frmSearch("CONDICIONES DE VENTA", SalesTerms, SearchPattern)
            frmSalesTerms.ShowDialog()

            If frmSalesTerms.SelectedValue IsNot Nothing Then
                SalesTerm = Crm.Domain.SalesTermRepository.GetByCode(frmSalesTerms.SelectedValue)
                If SalesTerm IsNot Nothing Then
                    txtSalesTermsCode.Text = SalesTerm.Code
                    txtSalesTermsName.Text = SalesTerm.Name
                    Return True
                End If
            End If


        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Function

    Private Function EmployeeValid() As Boolean
        Dim SearchPattern As String
        Dim Employee As Crm.Domain.Employee
        Dim Employees As DataSet = Nothing

        Try
            If txtEmployeeCode.Text = "" Then Return True

            SearchPattern = txtEmployeeCode.Text

            Employee = Crm.Domain.EmployeeRepository.GetByCode(SearchPattern)

            If Employee IsNot Nothing Then
                txtEmployeeCode.Text = Employee.Code
                txtEmployeeName.Text = Employee.Name
                Return True
            End If

            Employees = Crm.Domain.EmployeeRepository.GetAll(, , True)

            frmEmployee = New frmSearch("VENDEDORES", Employees, SearchPattern)
            frmEmployee.ShowDialog()

            If frmEmployee.SelectedValue IsNot Nothing Then
                Employee = Crm.Domain.EmployeeRepository.GetByCode(frmEmployee.SelectedValue)
                If Employee IsNot Nothing Then
                    txtEmployeeCode.Text = Employee.Code
                    txtEmployeeName.Text = Employee.Name
                    Return True
                End If
            End If


        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Function

    Private Function TaxValid(ByVal sender As TextBox) As Boolean
        Dim SearchPattern As String
        Dim Tax As Crm.Domain.Tax
        Dim Taxes As DataSet = Nothing

        Try
            If sender.Text = "" Then Return True

            SearchPattern = sender.Text

            Tax = Crm.Domain.TaxRepository.GetByCode(SearchPattern)

            If Tax IsNot Nothing Then
                sender.Text = Tax.Code
                Return TaxCodeValid(sender)
            End If

            Taxes = Crm.Domain.TaxRepository.GetAll(, , True)

            frmTaxes = New frmSearch("ALICUOTAS", Taxes, SearchPattern)
            frmTaxes.ShowDialog()

            If frmTaxes.SelectedValue IsNot Nothing Then
                Tax = Crm.Domain.TaxRepository.GetByCode(frmTaxes.SelectedValue)
                If Tax IsNot Nothing Then
                    sender.Text = Tax.Code
                    Return TaxCodeValid(sender)
                End If
            End If


        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Function

    Private Function TaxCodeValid(ByVal sender As TextBox) As Boolean
        Try

            If sender.Text = "" Then Return True

            Select Case sender.Name
                Case txtIBTaxCode.Name
                    If Val(sender.Text) < 51 Or Val(sender.Text) > 80 Then Throw New Exception("EL CODIGO DE ALICUOTA DEBE ESTAR ENTRE 51 Y 80")

                Case txtIBAditionalTaxCode.Name
                    If Val(sender.Text) < 51 Or Val(sender.Text) > 80 Then Throw New Exception("EL CODIGO DE ALICUOTA DEBE ESTAR ENTRE 51 Y 80")

                Case txtIBBTaxCode.Name
                    If Val(sender.Text) < 51 Or Val(sender.Text) > 80 Then Throw New Exception("EL CODIGO DE ALICUOTA DEBE ESTAR ENTRE 51 Y 80")

                Case Else
                    Return True

            End Select

            Select Case sender.Name
                Case txtIBTaxCode.Name
                    If txtIBTaxCode.Text = txtIBAditionalTaxCode.Text Then Throw New Exception("IMPOSIBLE INGRESAR CODIGOS DE ALICUOTAS RESPETIDOS PARA INGRESOS BRUTOS")
                    If txtIBTaxCode.Text = txtIBBTaxCode.Text Then Throw New Exception("IMPOSIBLE INGRESAR CODIGOS DE ALICUOTAS RESPETIDOS PARA INGRESOS BRUTOS")

                Case txtIBAditionalTaxCode.Name
                    If txtIBAditionalTaxCode.Text = txtIBTaxCode.Text Then Throw New Exception("IMPOSIBLE INGRESAR CODIGOS DE ALICUOTAS RESPETIDOS PARA INGRESOS BRUTOS")
                    If txtIBAditionalTaxCode.Text = txtIBBTaxCode.Text Then Throw New Exception("IMPOSIBLE INGRESAR CODIGOS DE ALICUOTAS RESPETIDOS PARA INGRESOS BRUTOS")

                Case txtIBBTaxCode.Name
                    If txtIBBTaxCode.Text = txtIBTaxCode.Text Then Throw New Exception("IMPOSIBLE INGRESAR CODIGOS DE ALICUOTAS RESPETIDOS PARA INGRESOS BRUTOS")
                    If txtIBBTaxCode.Text = txtIBAditionalTaxCode.Text Then Throw New Exception("IMPOSIBLE INGRESAR CODIGOS DE ALICUOTAS RESPETIDOS PARA INGRESOS BRUTOS")

            End Select

            Return True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Atención")
            sender.Text = ""
        End Try
    End Function


    Private Function NumberValid(ByVal sender As TextBox) As Boolean
        Try

            If sender.Text = "" Then
                sender.Text = 0
                Return True
            End If

            If Not IsNumeric(sender.Text) Then
                MsgBox("Solo puede ingresar caracteres numéricos", MsgBoxStyle.Exclamation, "ATENCIÓN")
                sender.Focus()
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Function














    Private Sub CancelEdition(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserCancel.Click
        Try

            EditionCanceled = True

            Me.Close()

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try

    End Sub


    Private Sub chkIVACalc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIVACalc.CheckedChanged
        Try
            chkIVADetail.Enabled = chkIVACalc.Checked
            chkIVAPlus.Enabled = chkIVACalc.Checked
            txtIvaExclusionPercent.Enabled = chkIVACalc.Checked

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try
    End Sub

    Private Sub chkIVAFree_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIVAFree.CheckedChanged
        Try
            txtIvaFreePercent.Enabled = chkIVAFree.Checked

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try
    End Sub

    Private Sub chkInternalTaxCalc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInternalTaxCalc.CheckedChanged
        Try
            chkInternalTaxDetail.Enabled = chkInternalTaxCalc.Checked
            chkInternalTaxPlus.Enabled = chkInternalTaxCalc.Checked

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try
    End Sub

    Private Sub chkIBCalc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIBCalc.CheckedChanged
        Try
            txtIBTaxCode.Enabled = chkIBCalc.Checked
            txtIBAditionalTaxCode.Enabled = chkIBCalc.Checked

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try

    End Sub
    Private Sub chkIBBCalc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIBBCalc.CheckedChanged

        Try
            chkIBBInternalTax.Enabled = chkIBBCalc.Checked
            txtIBBTaxCode.Enabled = chkIBBCalc.Checked

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try

    End Sub

    Private Sub chkIVACalc_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkIVACalc.EnabledChanged, chkIVADetail.EnabledChanged, chkIVAPlus.EnabledChanged, chkIVAFree.EnabledChanged, chkInternalTaxCalc.EnabledChanged, chkInternalTaxDetail.EnabledChanged, chkInternalTaxPlus.EnabledChanged, chkIBBCalc.EnabledChanged
        Try
            If Not sender.Enabled Then sender.checked = False

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try

    End Sub

    Private Sub txtNCTaxCode_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNCTaxCode.EnabledChanged, txtIvaExclusionPercent.EnabledChanged, txtIvaFreePercent.EnabledChanged
        Try
            If Not sender.enabled Then sender.text = "0"

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try

    End Sub

    Private Sub Taxes_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIBAditionalTaxCode.EnabledChanged, txtIBTaxCode.EnabledChanged, txtIBBTaxCode.EnabledChanged
        Try
            If Not sender.enabled Then sender.text = ""

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try

    End Sub



    Private Sub BrowserAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserAccept.Click
        Try

            SaveEntity()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub

    Private Function SaveEntity() As Boolean
        Try
            If Not Bindentity() Then Exit Try

            Domain.CustomerRepository.Save(Customer, OriginalCustomer)

            Me.Close()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Function

    Private Function Bindentity() As Boolean

        Try
            If Not Customer.Potential Then
                If txtCode.Text = "" Then
                    GotoModules(tbGeneral, System.EventArgs.Empty)
                    MsgBox("CAMPO OBLIGATORIO", MsgBoxStyle.Exclamation, "Atención")
                    txtCode.Focus()
                    Return False
                End If
            End If

            If txtLegalName.Text = "" Then
                GotoModules(tbGeneral, System.EventArgs.Empty)
                MsgBox("CAMPO OBLIGATORIO", MsgBoxStyle.Exclamation, "Atención")
                txtLegalName.Focus()
                Return False
            End If

            If txtStateCode.Text = "" Then
                If pnlAdress.Visible Then GotoModules(tbAdress, System.EventArgs.Empty)
                MsgBox("CAMPO OBLIGATORIO: PROVINCIA", MsgBoxStyle.Exclamation, "Atención")
                txtStateCode.Focus()
                Return False
            End If

            If txtZoneCode.Text = "" Then
                If pnlAdress.Visible Then GotoModules(tbAdress, System.EventArgs.Empty)
                MsgBox("CAMPO OBLIGATORIO: ZONA", MsgBoxStyle.Exclamation, "Atención")
                txtZoneCode.Focus()
                Return False
            End If

            If txtSalesTermsCode.Text = "" Then
                If pnlTerms.Visible Then GotoModules(tbTerms, System.EventArgs.Empty)
                MsgBox("CAMPO OBLIGATORIO: CONDICION DE VENTA", MsgBoxStyle.Exclamation, "Atención")
                txtSalesTermsCode.Focus()
                Return False
            End If

            Customer.Code = txtCode.Text

            Customer.LegalName = txtLegalName.Text
            Customer.Name = txtName.Text
            If Customer.Group Is Nothing Then Customer.Group = New Crm.Domain.CustomerGroup
            Customer.Group.Code = txtGroupCode.Text
            Customer.Group.Name = txtGroupName.Text

            Customer.Adress = txtAdress.Text
            Customer.ZipCode = txtZipCode.Text
            Customer.City = txtCity.Text
            If Customer.State Is Nothing Then Customer.State = New Crm.Domain.State
            Customer.State.Code = txtStateCode.Text
            Customer.State.Name = txtStateName.Text
            If Customer.Zone Is Nothing Then Customer.Zone = New Crm.Domain.Zone
            Customer.Zone.Code = txtZoneCode.Text
            Customer.Zone.Name = txtZoneName.Text
            Customer.Phone = txtPhone.Text
            Customer.Fax = txtFax.Text
            Customer.Mail = txtMail.Text
            Customer.Web = txtWeb.Text

            Customer.DeliveryAdress = txtDeliveryAdress.Text
            Customer.Hours = txtHours.Text
            If Customer.Transport Is Nothing Then Customer.Transport = New Crm.Domain.Transport
            Customer.Transport.Code = txtTranspCode.Text
            Customer.Transport.Name = txtTranspName.Text

            Customer.CUIT = txtCuit.Text
            Customer.IBNumber = txtIBNumber.Text
            Customer.DiscountPercent = txtDiscount.Text
            If Customer.Currency Is Nothing Then Customer.Currency = New Crm.Domain.Currency
            Customer.Currency.Code = txtCurrencyCode.Text
            Customer.Currency.Name = txtCurrencyName.Text

            If Customer.SalesTerm Is Nothing Then Customer.SalesTerm = New Crm.Domain.SalesTerm
            Customer.SalesTerm.Code = txtSalesTermsCode.Text
            Customer.SalesTerm.Name = txtSalesTermsName.Text

            If Customer.Employee Is Nothing Then Customer.Employee = New Crm.Domain.Employee
            Customer.Employee.Code = txtEmployeeCode.Text
            Customer.Employee.Name = txtEmployeeName.Text


            Customer.IVACalc = chkIVACalc.Checked
            Customer.IVADetail = chkIVADetail.Checked
            Customer.IVAPlus = chkIVAPlus.Checked
            Customer.IVAFree = chkIVAFree.Checked
            Customer.IVAFreePercent = txtIvaFreePercent.Text
            Customer.IVAExclusionPercent = txtIvaExclusionPercent.Text

            If Customer.NCTax Is Nothing Then Customer.NCTax = New Domain.Tax
            Customer.NCTax.Code = txtNCTaxCode.Text
            Customer.InternalTaxCalc = chkInternalTaxCalc.Checked
            Customer.InternalTaxDetail = chkInternalTaxDetail.Checked
            Customer.InternalTaxPlus = chkInternalTaxPlus.Checked
            Customer.IBCalc = chkIBCalc.Checked

            If Customer.IBTax Is Nothing Then Customer.IBTax = New Domain.Tax
            Customer.IBTax.Code = txtIBTaxCode.Text


            If Customer.IBTaxAditional Is Nothing Then Customer.IBTaxAditional = New Domain.Tax
            Customer.IBTaxAditional.Code = txtIBAditionalTaxCode.Text
            Customer.IBBCalc = chkIBBCalc.Checked
            Customer.IBBInternalTax = chkIBBInternalTax.Checked
            Customer.IBBCalc = chkIBBCalc.Checked

            If Customer.IBBTax Is Nothing Then Customer.IBBTax = New Domain.Tax
            Customer.IBBTax.Code = txtIBTaxCode.Text

            Customer.Notes = txtNotes.Text

            Return True

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
            Return False
        End Try

    End Function






    Private Sub frmGroups_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmGroups.ParametersChanged
        Dim Groups As DataSet = Nothing

        Try
            Groups = Domain.CustomerGroupRepository.GetAll(Field, value, False)

            frmGroups.DataSource = Groups

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub frmStates_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmStates.ParametersChanged
        Dim States As DataSet = Nothing

        Try
            States = Domain.StateRepository.GetAll(Field, value, False)

            frmStates.DataSource = States

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub frmZones_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmZones.ParametersChanged
        Dim Zones As DataSet = Nothing

        Try
            Zones = Domain.ZoneRepository.GetAll(Field, value, False)

            frmZones.DataSource = Zones

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub frmTransports_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmTransports.ParametersChanged
        Dim Transports As DataSet = Nothing

        Try
            Transports = Domain.TransportRepository.GetAll(Field, value, False)

            frmTransports.DataSource = Transports

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub frmCurrency_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmCurrency.ParametersChanged
        Dim Currencies As DataSet = Nothing

        Try
            Currencies = Domain.CurrencyRepository.GetAll(Field, value, False)

            frmCurrency.DataSource = Currencies

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub frmSalesTerms_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmSalesTerms.ParametersChanged
        Dim SalesTerms As DataSet = Nothing

        Try
            SalesTerms = Domain.SalesTermRepository.GetAll(Field, value, False)

            frmSalesTerms.DataSource = SalesTerms

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

    Private Sub frmTaxes_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmTaxes.ParametersChanged
        Dim Taxes As DataSet = Nothing

        Try
            Taxes = Domain.TaxRepository.GetAll(Field, value, False)

            frmTaxes.DataSource = Taxes

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub CheckBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIVAPlus.Enter, chkIVAFree.Enter, chkIVADetail.Enter, chkIVACalc.Enter, chkInternalTaxPlus.Enter, chkInternalTaxDetail.Enter, chkInternalTaxCalc.Enter, chkIBCalc.Enter, chkIBBInternalTax.Enter, chkIBBCalc.Enter
        Try

            sender.Backcolor = System.Drawing.SystemColors.ControlLight

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub CheckBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIVAPlus.Leave, chkIVAFree.Leave, chkIVADetail.Leave, chkIVACalc.Leave, chkInternalTaxPlus.Leave, chkInternalTaxDetail.Leave, chkInternalTaxCalc.Leave, chkIBCalc.Leave, chkIBBInternalTax.Leave, chkIBBCalc.Leave
        Try

            sender.Backcolor = System.Drawing.SystemColors.Control

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub


    Private Sub MenuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuFileExit.Click
        Try
            Me.Close()
        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub Code_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged
        Try

            If Not Customer.Potential Then Exit Sub

            If (Not txtCode.Text.StartsWith("P")) Then
                txtCode.Text = "P" & txtCode.Text
                txtCode.SelectionStart = txtCode.TextLength
            End If

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub
End Class