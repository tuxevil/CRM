Public Class frmCustomer

    Private WithEvents frmNewCustomer As frmEditionCustomer
    Private WithEvents frmCustomerSearch As frmSearch
    Private WithEvents frmContacts As frmContact
    Private WithEvents frmTasks As frmTask


    Private Customer As Crm.Domain.Customer
    Private Codes As List(Of String) = Nothing
    Private ListIndex As Integer
    Private PotentialCustomer As Boolean

    Private mSourceType As SourceType
    Private lCount As Long

    Private Deshabilitado As Boolean = False

    Public Enum SourceType As Integer
        SingleEntity
        MultipleEntity
    End Enum

    Public Property DataSource() As List(Of String)
        Get
            Return Codes
        End Get
        Set(ByVal value As List(Of String))
            Codes = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
        'MsgBox("Clientes salta initialize parametros:1")

    End Sub

    Public Sub New(ByVal Potential As Boolean)
        InitializeComponent()

        Try

            Codes = Domain.CustomerRepository.GetCodes(Potential, Domain.SystemUser.Id, Domain.SystemUser.FullDomain)

            lCount = Codes.Count
            ' MsgBox("Cuenta Clientes:" & vbTab & Codes.Count)

            PotentialCustomer = Potential

            mSourceType = SourceType.MultipleEntity

            If lCount = 0 Then
                If Potential Then
                    If Domain.SystemUser.FullDomain Then
                        MsgBox("No se encuentran clientes potenciales relacionados.", MsgBoxStyle.Information)
                    Else
                        MsgBox("Usuario Restringido. No se encuentran clientes potenciales relacionados.", MsgBoxStyle.Information)
                    End If

                Else
                    If Domain.SystemUser.FullDomain Then
                        MsgBox("No se encuentran clientes relacionados.", MsgBoxStyle.Information)
                    Else
                        MsgBox("Usuario Restringido. No se encuentran clientes relacionados.", MsgBoxStyle.Information)
                    End If
                End If

          
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub New(ByVal CustomerCode As String, Optional ByVal PotentialCustomer As Boolean = False)
        InitializeComponent()

        Try
            Customer = Domain.CustomerRepository.GetByCode(CustomerCode, PotentialCustomer)

            mSourceType = SourceType.SingleEntity

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub New(ByVal CustomerSource As Domain.Customer)
        InitializeComponent()

        Try

            Customer = CustomerSource

            mSourceType = SourceType.SingleEntity

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub New(ByVal Potential As Boolean, ByVal CustomerCode As String)
        InitializeComponent()

        Try

            Customer = Domain.CustomerRepository.GetByCode(CustomerCode, Potential)

            mSourceType = SourceType.SingleEntity

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            DrawControls()

            LoadCustomer()

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try

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

            If PotentialCustomer Then
                BrowserAdd.Visible = Domain.SystemUser.Profile.CustomerPotentialAdd
                MenuFileAdd.Visible = Domain.SystemUser.Profile.CustomerPotentialAdd
                BrowserEdit.Visible = Domain.SystemUser.Profile.CustomerPotentialEdit

                tbAdress.Visible = Domain.SystemUser.Profile.CustomerPotentialViewAdress
                tbDelivery.Visible = Domain.SystemUser.Profile.CustomerPotentialViewDelivery
                tbTerms.Visible = Domain.SystemUser.Profile.CustomerPotentialViewTerms
                tbNotes.Visible = Domain.SystemUser.Profile.CustomerPotentialViewNotes
                tbContacts.Visible = Domain.SystemUser.Profile.CustomerPotentialViewContacts
                tbAttachment.Visible = Domain.SystemUser.Profile.CustomerPotentialViewAttachments
                MenuActionsAddAttachment.Enabled = Domain.SystemUser.Profile.CustomerPotentialViewAttachments
            Else
                BrowserAdd.Visible = Domain.SystemUser.Profile.CustomerRealAdd
                MenuFileAdd.Visible = Domain.SystemUser.Profile.CustomerRealAdd
                BrowserEdit.Visible = Domain.SystemUser.Profile.CustomerRealEdit

                tbAdress.Visible = Domain.SystemUser.Profile.CustomerRealViewAdress
                tbDelivery.Visible = Domain.SystemUser.Profile.CustomerRealViewDelivery
                tbTerms.Visible = Domain.SystemUser.Profile.CustomerRealViewTerms
                tbNotes.Visible = Domain.SystemUser.Profile.CustomerRealViewNotes
                tbContacts.Visible = Domain.SystemUser.Profile.CustomerRealViewContacts
                tbAttachment.Visible = Domain.SystemUser.Profile.CustomerRealViewAttachments
                MenuActionsAddAttachment.Enabled = Domain.SystemUser.Profile.CustomerRealViewAttachments
            End If

            If mSourceType = SourceType.SingleEntity Then
                MenuFile.Visible = False
                Browser.Visible = False
                MenuSearch.Visible = False
            Else
                MenuFile.Visible = True
                Browser.Visible = True
                MenuSearch.Visible = True
            End If


        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try

    End Sub

    Private Sub DrawMe()
        Try

            Me.Controls.Remove(Me.pnlTerms)
            Me.Controls.Remove(Me.pnlBasic)
            Me.Controls.Remove(Me.pnlDelivery)
            Me.Controls.Remove(Me.pnlAdress)
            Me.Controls.Remove(Me.pnlNotes)
            Me.Controls.Remove(Me.pnlContacts)
            Me.Controls.Remove(Me.pnlAttachments)

            


            If Customer IsNot Nothing Then

                If Customer.UnRegistrationDate.Year = 1800 Then
                    Deshabilitado = False
                Else
                    Deshabilitado = True
                    lblTitle.Text = lblTitle.Text & " (Inhabilitado)"
                End If

                If Customer.Potential Then

                    MenuActionPotentialCustomersToReal.Visible = Domain.SystemUser.Profile.CustomerRealAdd
                    lblTitle.BackColor = Color.Orchid

                    Me.Text = "Clientes Potenciales  (Total " & lCount & ")"

                Else

                    MenuActionPotentialCustomersToReal.Visible = False
                    lblTitle.BackColor = Color.Gray
                    Me.Text = "Clientes (Total " & lCount & ")"



                End If

            End If

            GotoModules(tbGeneral, System.EventArgs.Empty)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GotoModules(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbAdress.Click, tbDelivery.Click, tbGeneral.Click, tbNotes.Click, tbTerms.Click, tbContacts.Click, tbAttachment.Click, tbTask.Click

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

            Case tbContacts.Name
                panel = pnlContacts

            Case tbAttachment.Name
                panel = pnlAttachments

            Case tbTask.Name
                panel = pnlTasks

        End Select

        If panel IsNot Nothing Then
            frmSplit.Panel2.Controls.Add(panel)
            panel.Dock = DockStyle.Fill
            sender.checked = True
            BindPanel(panel)
        End If

    End Sub

    Private Sub BindPanel(ByVal panel As Panel)

        Dim Item As ListViewItem
        Dim FileGroup As ListViewGroup

        lblTitle.Text = ""
        If Customer.Code <> "" Then lblTitle.Text = Customer.Code & " - " & Customer.LegalName

        ClearPanel(panel)

        Select Case panel.Name

            Case pnlBasic.Name
                txtCode.Text = Customer.Code
                txtLegalName.Text = Customer.LegalName
                txtName.Text = Customer.Name
                If Customer.Group IsNot Nothing Then
                    txtGroupCode.Text = Customer.Group.Code
                    txtGroupName.Text = Customer.Group.Name
                End If


            Case pnlAdress.Name
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

            Case pnlDelivery.Name
                txtDeliveryAdress.Text = Customer.DeliveryAdress
                If Customer.Transport IsNot Nothing Then
                    txtTranspCode.Text = Customer.Transport.Code
                    txtTranspName.Text = Customer.Transport.Name
                    txtHours.Text = Customer.Hours
                End If

            Case pnlTerms.Name
                txtCuit.Text = Customer.CUIT
                txtIBNumber.Text = Customer.IBNumber
                If Customer.Currency IsNot Nothing Then txtCurrencyName.Text = Customer.Currency.Name
                txtDiscount.Text = Customer.DiscountPercent
                If Customer.SalesTerm IsNot Nothing Then
                    txtSalesTermsCode.Text = Customer.SalesTerm.Code
                    txtSalesTermsName.Text = Customer.SalesTerm.Name
                End If
                If Customer.Employee IsNot Nothing Then
                    txtEmployeeCode.Text = Customer.Employee.Code
                    txtEmployeeName.Text = Customer.Employee.Name
                End If
                txtIVACategory.Text = Customer.IVACategory
                chkIVAFree.Checked = Customer.IVAFree
                chkIVAPlus.Checked = Customer.IVAPlus
                txtIVAFreePercent.Text = Customer.IVAFreePercent
                txtIVAExclusionPercent.Text = Customer.IVAExclusionPercent
                If Customer.NCTax IsNot Nothing Then txtNCTaxCode.Text = Customer.NCTax.Code
                chkIBCalc.Checked = Customer.IBBCalc
                If Customer.IBTax IsNot Nothing Then txtIBTaxCode.Text = Customer.IBTax.Code
                If Customer.IBTaxAditional IsNot Nothing Then txtIBTaxAditionalCode.Text = Customer.IBTaxAditional.Code
                chkInternalTaxCalc.Checked = Customer.InternalTaxCalc
                chkInternalTaxDetail.Checked = Customer.InternalTaxDetail
                chkInternalTaxPlus.Checked = Customer.InternalTaxPlus
                chkIBBCalc.Checked = Customer.IBBCalc
                If Customer.IBBTax IsNot Nothing Then txtIBBTaxCode.Text = Customer.IBBTax.Code

            Case pnlNotes.Name
                txtNotes.Text = Customer.Notes

            Case pnlAttachments.Name
                FileList.Clear()
                FileList.Groups.Clear()

                FileList.View = View.LargeIcon

                If Customer.Attachments Is Nothing Then Exit Sub
                For Each File As Domain.Attachment In Customer.Attachments

                    Item = FileList.Items.Add(CStr(File.Id), File.Name, 0)
                    Item.SubItems.Add(File.Extension)

                    FileGroup = FileList.Groups(File.Extension.ToUpper)

                    If FileGroup Is Nothing Then FileList.Groups.Add(New ListViewGroup(File.Extension.ToUpper, File.Extension.ToUpper))

                    Item.Group = FileList.Groups(File.Extension.ToUpper)

                    Item.Tag = CStr(File.Id)

                Next

            Case pnlContacts.Name

                GridContacts.Rows.Clear()

                If Customer.Contacts Is Nothing Then Exit Sub

                For Each Contact As Domain.Contact In Customer.Contacts
                    If Contact.Area Is Nothing Then Contact.Area = New Domain.Contact.ContactArea
                    If Contact.Cargo Is Nothing Then Contact.Cargo = New Domain.Contact.ContactCargo

                    GridContacts.Rows.Add(Contact.Id, Contact.Area.Name, Contact.Cargo.Name, Contact.Name, Contact.Surname, Contact.Tel, Contact.Fax, Contact.Email, Contact.AlterEmail, Format(Contact.Birthday, "dd/MM/yyyy"))

                Next

            Case pnlTasks.Name
                Dim Tasks As List(Of Domain.Task)

                GridTaks.Rows.Clear()

                Tasks = Domain.TaskRepository.GetByCustomer(Customer.Code, PotentialCustomer)

                If Tasks Is Nothing Then Exit Sub

                For Each Task As Domain.Task In Tasks
                    If Task.User Is Nothing Then Task.User = New Domain.User
                    If Task.Priority Is Nothing Then Task.Priority = New Domain.Task.TaskPriority
                    If Task.State Is Nothing Then Task.State = New Domain.Task.TaskState

                    GridTaks.Rows.Add(Task.Id, Format(Task.Initdate, "dd/MM/yyyy"), Format(Task.Lastdate, "dd/MM/yyyy"), Task.Type.Name, Task.State.Name, Task.User.NickName, Task.Priority.Name)

                Next

        End Select

    End Sub


    Private Sub ClearPanel(ByVal panel As Panel)
        Dim txt As TextBox = Nothing

        For Each ctrl As Control In panel.Controls
            txt = TryCast(ctrl, TextBox)
            If txt IsNot Nothing Then txt.Text = ""
        Next

    End Sub

    Private Sub LoadCustomer(Optional ByVal CustomerCode As String = "")

        Try

            If mSourceType = SourceType.MultipleEntity Then

                If CustomerCode <> "" Then

                    Customer = Crm.Domain.CustomerRepository.GetByCode(CustomerCode, PotentialCustomer)
                    If Customer Is Nothing Then Customer = New Domain.Customer

                Else

                    If Codes.Count > 0 Then

                        If ListIndex >= Codes.Count Then ListIndex = Codes.Count - 1

                        Customer = Crm.Domain.CustomerRepository.GetByCode(Codes(ListIndex), PotentialCustomer)

                    Else

                        Customer = New Domain.Customer

                    End If

                End If

            End If

        Catch ex As Exception
            Throw ex
        Finally
            If Customer Is Nothing Then Customer = New Domain.Customer
            DrawMe()
        End Try

    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape : Me.Close()

            End Select

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub BrowserIconsSize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserMenuViewLargeIcons.Click, BrowserMenuViewSmallIcons.Click
        Dim IScale As ToolStripItemImageScaling = ToolStripItemImageScaling.None

        Try
            BrowserMenuViewLargeIcons.Checked = Not BrowserMenuViewLargeIcons.Checked
            BrowserMenuViewSmallIcons.Checked = Not BrowserMenuViewSmallIcons.Checked

            If BrowserMenuViewSmallIcons.Checked Then IScale = ToolStripItemImageScaling.SizeToFit

            For Each item As ToolStripItem In Browser.Items
                item.ImageScaling = IScale
            Next

        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub BrowserFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserFirst.Click, MenuSearchFirst.Click
        Try
            ListIndex = 0
            LoadCustomer()

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub BrowserPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserPrevious.Click, MenuSearchPrevious.Click

        If ListIndex > 0 Then
            ListIndex = ListIndex - 1
            LoadCustomer()
        End If

    End Sub

    Private Sub BrowserNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserNext.Click, MenuSearchNext.Click
        If ListIndex < Codes.Count - 1 Then
            ListIndex = ListIndex + 1
            LoadCustomer()
        End If
    End Sub


    Private Sub BrowserLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserLast.Click, MenuSearchLast.Click
        ListIndex = Codes.Count - 1
        LoadCustomer()
    End Sub

    Private Sub BrowserAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserAdd.Click, MenuFileAdd.Click
        Try
            frmNewCustomer = New frmEditionCustomer(New Crm.Domain.Customer, PotentialCustomer)
            frmNewCustomer.Show()

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try

    End Sub

    Private Sub BrowserEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserEdit.Click, MenuFileEdit.Click
        Try
            frmNewCustomer = New frmEditionCustomer(Customer, PotentialCustomer)
            frmNewCustomer.Show()

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try

    End Sub

    Private Sub MenuActionsAddAttachment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuActionsAddAttachment.Click
        Dim Browser As OpenFileDialog

        Try
            Browser = New OpenFileDialog

            Browser.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            Browser.Multiselect = True
            Browser.Filter = "Todos los archivos (*.*)|*.*"

            Browser.ShowDialog()

            If Browser.FileNames.Length > 0 Then

                For Counter = 0 To Browser.FileNames.Length - 1

                    Domain.FileRepository.Save(Browser.FileNames(Counter), Customer.Code, 0)

                Next

            End If

            LoadCustomer(Customer.Code)

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub

    Private Sub FileList_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles FileList.MouseDoubleClick
        Try

            If FileList.SelectedItems Is Nothing Then Exit Sub

            If FileList.SelectedItems(0) Is Nothing Then Exit Sub

            Domain.FileRepository.ShowFile(CInt(FileList.SelectedItems(0).Tag))

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub FileList_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FileList.KeyDown
        Try

            If FileList.SelectedItems Is Nothing Then Exit Sub

            If FileList.SelectedItems(0) Is Nothing Then Exit Sub

            Domain.FileRepository.ShowFile(CInt(FileList.SelectedItems(0).Tag))

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub NewCustomerAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles frmNewCustomer.FormClosed
        Try

            Codes = Domain.CustomerRepository.GetCodes(PotentialCustomer, Domain.SystemUser.Id, Domain.SystemUser.FullDomain)

            LoadCustomer()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub BrowserSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserSearch.Click, MenuSearchByKey.Click
        Dim Customers As DataSet

        Try
            Customers = Domain.CustomerRepository.GetAll(PotentialCustomer, Domain.SystemUser.Id, Domain.SystemUser.FullDomain, , , True)

            frmCustomerSearch = New frmSearch("CLIENTES", Customers, "")
            frmCustomerSearch.ShowDialog()

            If frmCustomerSearch.SelectedValue IsNot Nothing Then LoadCustomer(frmCustomerSearch.SelectedValue)

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub BrowserRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserRefresh.Click
        Try

            Codes = Domain.CustomerRepository.GetCodes(PotentialCustomer, Domain.SystemUser.Id, Domain.SystemUser.FullDomain)

            LoadCustomer(Customer.Code)

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub frmCustomerSearch_ParametersChanged(ByVal Field As String, ByVal value As Object) Handles frmCustomerSearch.ParametersChanged
        Dim Customers As DataSet

        Try
            Customers = Domain.CustomerRepository.GetAll(PotentialCustomer, Domain.SystemUser.Id, Domain.SystemUser.FullDomain, Field, value, False)

            frmCustomerSearch.DataSource = Customers

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub MenuActionsAddContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuActionsAddContact.Click
        Dim frm As frmContact
        Try

            frm = New frmContact("Contactos - " & Customer.Name, New Domain.Contact(Customer.Code, Domain.MainCompany.Id), True)
            'frm.Show()
            frm.ShowDialog()



            LoadCustomer(Customer.Code)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ContactSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridContacts.CellMouseDoubleClick
        Dim Contact As Domain.Contact
        Try

            Contact = Domain.ContactRepository.GetById(CInt(GridContacts.Rows(e.RowIndex).Cells(0).Value))

            If Contact Is Nothing Then Exit Sub

            frmContacts = New frmContact("Contactos - " & Customer.Name, Contact, False)
            frmContacts.Show()

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub TaskSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridTaks.CellMouseDoubleClick

        Try

            frmTasks = New frmTask(CInt(GridTaks.Rows(e.RowIndex).Cells(0).Value))
            frmTasks.Show()

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub MenuFileClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuFileClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub MenuActionsAddTask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuActionsAddTask.Click
        Dim frm As frmEditionTask
        Dim task As Domain.Task
        Dim taskEntity As Domain.TaskEntity
        Try
            task = New Domain.Task

            If task.Entities Is Nothing Then task.Entities = New List(Of Domain.TaskEntity)

            taskEntity = New Domain.TaskEntity

            If PotentialCustomer Then

                taskEntity.Type = Domain.SystemEntities(CStr(4))

            Else

                taskEntity.Type = Domain.SystemEntities(CStr(1))

            End If

            taskEntity.Code = Customer.Code

            task.Entities.Add(TaskEntity)

            frm = New frmEditionTask(task)
            frm.Show()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub MenuActionPotentialCustomersToReal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuActionPotentialCustomersToReal.Click
        Dim frm As frmCustomersToTango
        Try

            frm = New frmCustomersToTango(Customer.Code)
            frm.ShowDialog()

            If mSourceType = SourceType.SingleEntity Then
                Me.Close()
            Else
                Codes = Domain.CustomerRepository.GetCodes(PotentialCustomer, Domain.SystemUser.Id, Domain.SystemUser.FullDomain)

                LoadCustomer()

            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub lblTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub chkIBBInternalTax_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIBBInternalTax.CheckedChanged

    End Sub
End Class