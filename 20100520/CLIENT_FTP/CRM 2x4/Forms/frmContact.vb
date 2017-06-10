Public Class frmContact

    Private Entity As Crm.Domain.Contact
    Private Entities As List(Of Domain.Contact)
    Private ListIndex As Integer

    Private SingleSource As Boolean
    Private EditionMode As Boolean
    Private CustomerCode As String

    Private WithEvents frmAreas As frmTypes
    Private WithEvents frmCargos As frmTypes

    Public Event SourceChanged(ByVal Customer As String)

    Private fromMain As Boolean

    Public Property ListDataSource() As List(Of Domain.Contact)
        Get
            Return Entities
        End Get
        Set(ByVal value As List(Of Domain.Contact))
            Entities = value
        End Set
    End Property

    Public Property DataSource() As Domain.Contact
        Get
            Return Entity
        End Get
        Set(ByVal value As Domain.Contact)
            Entity = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub


    Public Sub New(ByVal Title As String, ByVal Contact As Crm.Domain.Contact, Optional ByVal InEdition As Boolean = False)
        InitializeComponent()

        Try
            Me.Text = Title

            Entity = Contact
            SingleSource = True

            EditionMode = InEdition

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub New(ByVal Title As String, ByVal Contacts As List(Of Crm.Domain.Contact), ByVal Customer As String, ByVal fMain As Boolean)
        InitializeComponent()


        Try

            fromMain = True

            Me.Text = Title

            Entities = Contacts

            CustomerCode = Customer

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub New(ByVal Title As String, ByVal Contacts As List(Of Crm.Domain.Contact), ByVal Customer As String)
        InitializeComponent()


        Try
            Me.Text = Title

            Entities = Contacts

            CustomerCode = Customer

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    EditionMode = False

                    If Entity.Id <= 0 Then
                        Me.Close()
                    Else
                        DrawMe()
                    End If

                Case Keys.F10
                    SaveContact()

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            If fromMain Then
                If Entities Is Nothing Then
                    MsgBox("Cliente sin contactos", MsgBoxStyle.Information, "Atención")
                    Me.Close()
                    Exit Sub
                End If
            End If

            If fromMain Then
                If Entities.Count = 0 Then
                    MsgBox("Cliente sin contactos", MsgBoxStyle.Information, "Atención")
                    Me.Close()
                    Exit Sub
                End If
            End If

            DrawMe()

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try

    End Sub

    Private Sub DrawMe()
        Try

            cmbArea.DataSource = Domain.ContactRepository.GetAreas()
            cmbArea.DisplayMember = "NAME"
            cmbArea.ValueMember = "ID"


            If cmbArea.Items.Count <= 0 Then
                MsgBox("No existen areas de contactos", MsgBoxStyle.Information, "Atención")
                Me.Close()
                Exit Sub
            End If


            cmbCargo.DataSource = Domain.ContactRepository.GetCargos()
            cmbCargo.DisplayMember = "NAME"
            cmbCargo.ValueMember = "ID"


            If cmbCargo.Items.Count <= 0 Then
                MsgBox("No existen cargos de contactos", MsgBoxStyle.Information, "Atención")
                Me.Close()
                Exit Sub
            End If

            If EditionMode Then

                BrowserAdd.Visible = False
                BrowserDelete.Visible = False
                BrowserEdit.Visible = False
                BrowserFirst.Visible = False
                BrowserLast.Visible = False
                BrowserPrevious.Visible = False
                BrowserNext.Visible = False
                BrowserSearch.Visible = False
                BrowserList.Visible = False

                MenuFileAdd.Visible = False
                MenuFileDelete.Visible = False
                MenuFileEdit.Visible = False
                MenuEditArea.Visible = False
                MenueditCharge.Visible = False
                MenuEditCancel.Visible = True
                MenuEditSave.Visible = True
                MenuActionSendMail.Enabled = False

                cmbArea.Enabled = True
                cmbCargo.Enabled = True
                txtName.ReadOnly = False
                txtSurname.ReadOnly = False
                txtEmail.ReadOnly = False
                txtAlterMail.ReadOnly = False
                txtTel.ReadOnly = False
                txtFAX.ReadOnly = False
                dpFechaNacimiento.Enabled = True
                txtCUIT.ReadOnly = False
                txtNotes.ReadOnly = False

                cmdSave.Enabled = True

            Else


                If SingleSource Then

                    BrowserAdd.Visible = False
                    'BrowserDelete.Visible = Domain.SystemUser.Profile.CustomerRealEdit
                    BrowserEdit.Visible = Domain.SystemUser.Profile.CustomerRealEdit
                    BrowserFirst.Visible = False
                    BrowserLast.Visible = False
                    BrowserPrevious.Visible = False
                    BrowserNext.Visible = False
                    BrowserSearch.Visible = False
                    BrowserList.Visible = False

                    MenuFileAdd.Visible = False
                    'MenuFileDelete.Visible = Domain.SystemUser.Profile.CustomerRealEdit
                    MenuFileEdit.Visible = Domain.SystemUser.Profile.CustomerRealEdit
                    MenuEditArea.Visible = Domain.SystemUser.Profile.CustomerRealEdit
                    MenueditCharge.Visible = Domain.SystemUser.Profile.CustomerRealEdit
                    MenuEditCancel.Visible = False
                    MenuEditSave.Visible = False
                    MenuActionSendMail.Enabled = True

                Else

                    BrowserAdd.Visible = Domain.SystemUser.Profile.CustomerRealEdit
                    'BrowserDelete.Visible = Domain.SystemUser.Profile.CustomerRealEdit
                    BrowserEdit.Visible = Domain.SystemUser.Profile.CustomerRealEdit
                    BrowserFirst.Visible = True
                    BrowserLast.Visible = True
                    BrowserPrevious.Visible = True
                    BrowserNext.Visible = True
                    BrowserSearch.Visible = False
                    BrowserList.Visible = False

                    MenuFileAdd.Visible = Domain.SystemUser.Profile.CustomerRealEdit
                    'MenuFileDelete.Visible = Domain.SystemUser.Profile.CustomerRealEdit
                    MenuFileEdit.Visible = Domain.SystemUser.Profile.CustomerRealEdit
                    MenuEditArea.Visible = Domain.SystemUser.Profile.CustomerRealEdit
                    MenueditCharge.Visible = Domain.SystemUser.Profile.CustomerRealEdit
                    MenuEditCancel.Visible = False
                    MenuEditSave.Visible = False
                    MenuActionSendMail.Enabled = True

                    If Entity Is Nothing Then Entity = LoadContact()

                End If

                cmbArea.Enabled = False
                cmbCargo.Enabled = False
                txtName.ReadOnly = True
                txtSurname.ReadOnly = True
                txtEmail.ReadOnly = True
                txtAlterMail.ReadOnly = True
                txtTel.ReadOnly = True
                txtFAX.ReadOnly = True
                dpFechaNacimiento.Enabled = False
                txtCUIT.ReadOnly = True
                txtNotes.ReadOnly = True

                cmdSave.Enabled = False


            End If

            DrawContact()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DrawContact()
        Try

            If Entity Is Nothing Then Exit Try

            If cmbArea.Items IsNot Nothing Then
                If Entity.Area.Id <> 0 Then cmbArea.SelectedValue = Entity.Area.Id
            End If

            If cmbCargo.Items IsNot Nothing Then
                If Entity.Cargo.Id <> 0 Then cmbCargo.SelectedValue = Entity.Cargo.Id
            End If

            txtName.Text = Entity.Name
            txtSurname.Text = Entity.Surname
            txtEmail.Text = Entity.Email
            txtAlterMail.Text = Entity.AlterEmail
            txtTel.Text = Entity.Tel
            txtFAX.Text = Entity.Fax
            dpFechaNacimiento.Value = Entity.Birthday
            txtCUIT.Text = Entity.CUIT
            txtNotes.Text = Entity.Details

            cmbArea.Focus()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function LoadContact() As Domain.Contact
        Try
            If Entities.Count > ListIndex Then Return Entities(ListIndex)
        Catch ex As Exception
            Throw ex
        End Try

        Return Nothing

    End Function

    Private Sub BrowserFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserFirst.Click
        Try
            ListIndex = 0
            Entity = LoadContact()
            DrawContact()
        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub BrowserPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserPrevious.Click

        If ListIndex > 0 Then
            ListIndex = ListIndex - 1
            Entity = LoadContact()
            DrawContact()
        End If

    End Sub

    Private Sub BrowserNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserNext.Click
        If ListIndex < Entities.Count - 1 Then
            ListIndex = ListIndex + 1
            Entity = LoadContact()
            DrawContact()
        End If
    End Sub


    Private Sub BrowserLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserLast.Click
        ListIndex = Entities.Count - 1
        Entity = LoadContact()
        DrawContact()
    End Sub

    Private Sub MenuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuFileExit.Click
        Try
            Me.Close()
        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub MenuEditCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEditCancel.Click
        Try
            EditionMode = False

            If Entity.Id <= 0 And SingleSource Then
                Me.Close()
            Else
                DrawMe()
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub BrowserEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserEdit.Click
        Try
            EditionMode = True
            DrawMe()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub BrowserAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserAdd.Click, MenuFileAdd.Click
        Try
            EditionMode = True
            Entity = New Domain.Contact(CustomerCode, Domain.MainCompany.Id)
            DrawMe()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub Area_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbArea.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            cmbCargo.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub Cargo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCargo.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            txtName.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub Name_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            txtSurname.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub LastName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSurname.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            txtEmail.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub Mail_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmail.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If mailValid(sender) Then txtAlterMail.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub AlterMail_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlterMail.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If MailValid(sender) Then txtTel.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub Tel_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTel.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            txtFAX.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub Fax_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFAX.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            dpFechaNacimiento.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub BirdhtDay_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dpFechaNacimiento.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            txtCUIT.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub Cuit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCUIT.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If CuitValid() Then txtNotes.Focus()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub Details_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNotes.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            saveContact()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Function MailValid(ByVal sender As TextBox) As Boolean
        Dim MailModel As System.Text.RegularExpressions.Regex = Nothing

        Try
            MailModel = New System.Text.RegularExpressions.Regex("^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$", System.Text.RegularExpressions.RegexOptions.None)

            If sender.Text = "" Then Return True

            If Not MailModel.IsMatch(sender.Text) Then

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

    Private Sub SaveContact()
        Try
            If Not BindEntity Then Exit Sub


            Entity.Id = Domain.ContactRepository.Save(Entity)

            EditionMode = False

            DrawMe()

            RaiseEvent SourceChanged(CustomerCode)

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Function BindEntity() As Boolean
        Try

            If Entity.CompanyId = 0 Then Entity.CompanyId = Domain.MainCompany.Id
            If Entity.CustomerCode = "" Then Entity.CustomerCode = CustomerCode

            Entity.Area = cmbArea.SelectedItem
            If Entity.Area Is Nothing Then Entity.Area = New Domain.Contact.ContactArea

            Entity.Cargo = cmbCargo.SelectedItem
            If Entity.Cargo Is Nothing Then Entity.Cargo = New Domain.Contact.ContactCargo

            Entity.Name = txtName.Text
            Entity.Surname = txtSurname.Text
            Entity.Email = txtEmail.Text
            Entity.AlterEmail = txtAlterMail.Text
            Entity.Birthday = dpFechaNacimiento.Value
            Entity.CUIT = txtCUIT.Text
            Entity.Details = txtNotes.Text

            Return True

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Function

    Private Sub MenuEditSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEditSave.Click, cmdSave.Click
        Try

            SaveContact()
        Catch ex As Exception
            frmError.ShowException(ex)
        End Try

    End Sub

    Private Sub EditAreas(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEditArea.Click
        Try

            frmAreas = New frmTypes("AREAS DE CONTACTOS", Domain.ContactRepository.GetTableAreas())
            frmAreas.Show()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub EditCargos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenueditCharge.Click
        Try

            frmCargos = New frmTypes("CARGOS DE CONTACTOS", Domain.ContactRepository.GetTableCargos())
            frmCargos.Show()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub frmAreas_CodeChanged(ByVal Code As Integer) Handles frmAreas.CodeChanged

        Try
            If Domain.ContactRepository.GetCargoById(Code) Is Nothing Then
                frmAreas.CodeValid = 1
            Else
                frmAreas.CodeValid = -1
            End If

        Catch ex As Exception
            frmAreas.CodeValid = -1
        End Try
    End Sub

    Private Sub frmAreas_SourceChanged(ByVal Code As Integer, ByVal Name As String, ByVal Description As String, ByVal Otherdetails As String) Handles frmAreas.SourceChanged

        Try
            Domain.ContactRepository.SaveArea(Code, Name, Description, Otherdetails)

            frmAreas.DataSource = Domain.ContactRepository.GetTableAreas()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Private Sub frmCargos_CodeChanged(ByVal Code As Integer) Handles frmCargos.CodeChanged

        Try
            If Domain.ContactRepository.GetCargoById(Code) Is Nothing Then
                frmCargos.CodeValid = 1
            Else
                frmCargos.CodeValid = -1
            End If

        Catch ex As Exception
            frmCargos.CodeValid = -1
        End Try
    End Sub

    Private Sub frmCargos_SourceChanged(ByVal Code As Integer, ByVal Name As String, ByVal Description As String, ByVal Otherdetails As String) Handles frmCargos.SourceChanged

        Try
            Domain.ContactRepository.SaveCargo(Code, Name, Description, Otherdetails)

            frmCargos.DataSource = Domain.ContactRepository.GetTableCargos()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub MenuActionSendMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuActionSendMail.Click
        Try

            Process.Start("mailto:" & txtEmail.Text & " &subject= &body=Estimado " & txtName.Text & " " & txtSurname.Text & ":")

        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub BrowserDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserDelete.Click

    End Sub
End Class