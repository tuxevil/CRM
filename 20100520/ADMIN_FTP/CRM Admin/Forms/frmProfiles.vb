Public Class frmProfiles

    Private Profiles As List(Of Domain.Profile)
    Private Profile As Domain.Profile
    Private ListIndex As Integer

    Private EditionCanceled As Boolean

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal ProfileList As List(Of Domain.Profile))

        InitializeComponent()

        Profiles = ProfileList

    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            LoadProfile()

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try

    End Sub


    Private Sub LoadProfile(Optional ByVal CustomerCode As String = "")


        Try

            If Profiles.Count = 0 Then Profile = New Domain.Profile

            If Profiles.Count > ListIndex Then Profile = Profiles(ListIndex)

            DrawMe()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DrawMe(Optional ByVal EditionMode As Boolean = False)
        Dim ItemNode As TreeNode
        Dim ParentNode As TreeNode

        Try

            For Each node As TreeNode In tvPermissions.Nodes

                node.ImageIndex = 0
                node.SelectedImageIndex = 0
                node.Collapse()
            Next


            If Profile Is Nothing Then Exit Try

            txtName.Text = Profile.Name
            txtDescription.Text = Profile.Description

            'Dibuja el candado cerrado o abierto según valor true False
            If Profile.CustomerRealViewGeneral Then

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerReal").Nodes("NodeCustomerRealView").Nodes("NodeCustomerRealViewGeneral")

                ItemNode.ImageIndex = 1
                ItemNode.SelectedImageIndex = 1

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 1
                    ParentNode.SelectedImageIndex = 1

                    ParentNode = ParentNode.Parent

                Loop

            Else

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerReal").Nodes("NodeCustomerRealView").Nodes("NodeCustomerRealViewGeneral")

                ItemNode.ImageIndex = 0
                ItemNode.SelectedImageIndex = 0

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 0
                    ParentNode.SelectedImageIndex = 0

                    ParentNode = ParentNode.Parent

                Loop

            End If

            If Profile.CustomerRealViewAdress Then

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerReal").Nodes("NodeCustomerRealView").Nodes("NodeCustomerRealViewAdress")


                ItemNode.ImageIndex = 1
                ItemNode.SelectedImageIndex = 1

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 1
                    ParentNode.SelectedImageIndex = 1

                    ParentNode = ParentNode.Parent

                Loop

            Else

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerReal").Nodes("NodeCustomerRealView").Nodes("NodeCustomerRealViewAdress")


                ItemNode.ImageIndex = 0
                ItemNode.SelectedImageIndex = 0

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 0
                    ParentNode.SelectedImageIndex = 0

                    ParentNode = ParentNode.Parent

                Loop


            End If

            If Profile.CustomerRealViewDelivery Then

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerReal").Nodes("NodeCustomerRealView").Nodes("NodeCustomerRealViewDelivery")

                ItemNode.ImageIndex = 1
                ItemNode.SelectedImageIndex = 1

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 1
                    ParentNode.SelectedImageIndex = 1

                    ParentNode = ParentNode.Parent

                Loop

            Else

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerReal").Nodes("NodeCustomerRealView").Nodes("NodeCustomerRealViewDelivery")

                ItemNode.ImageIndex = 0
                ItemNode.SelectedImageIndex = 0

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 0
                    ParentNode.SelectedImageIndex = 0

                    ParentNode = ParentNode.Parent

                Loop

            End If

            If Profile.CustomerRealViewTerms Then

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerReal").Nodes("NodeCustomerRealView").Nodes("NodeCustomerRealViewTerms")

                ItemNode.ImageIndex = 1
                ItemNode.SelectedImageIndex = 1

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 1
                    ParentNode.SelectedImageIndex = 1

                    ParentNode = ParentNode.Parent

                Loop

            Else

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerReal").Nodes("NodeCustomerRealView").Nodes("NodeCustomerRealViewTerms")

                ItemNode.ImageIndex = 0
                ItemNode.SelectedImageIndex = 0

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 0
                    ParentNode.SelectedImageIndex = 0

                    ParentNode = ParentNode.Parent

                Loop

            End If

            If Profile.CustomerRealViewContacts Then

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerReal").Nodes("NodeCustomerRealView").Nodes("NodeCustomerRealViewContacts")

                ItemNode.ImageIndex = 1
                ItemNode.SelectedImageIndex = 1

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 1
                    ParentNode.SelectedImageIndex = 1

                    ParentNode = ParentNode.Parent

                Loop
            Else

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerReal").Nodes("NodeCustomerRealView").Nodes("NodeCustomerRealViewContacts")

                ItemNode.ImageIndex = 0
                ItemNode.SelectedImageIndex = 0

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 0
                    ParentNode.SelectedImageIndex = 0

                    ParentNode = ParentNode.Parent

                Loop


            End If

            If Profile.CustomerRealViewAttachments Then

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerReal").Nodes("NodeCustomerRealView").Nodes("NodeCustomerRealViewAttachments")

                ItemNode.ImageIndex = 1
                ItemNode.SelectedImageIndex = 1

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 1
                    ParentNode.SelectedImageIndex = 1

                    ParentNode = ParentNode.Parent

                Loop

            Else

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerReal").Nodes("NodeCustomerRealView").Nodes("NodeCustomerRealViewAttachments")

                ItemNode.ImageIndex = 0
                ItemNode.SelectedImageIndex = 0

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 0
                    ParentNode.SelectedImageIndex = 0

                    ParentNode = ParentNode.Parent

                Loop

            End If

            If Profile.CustomerRealViewNotes Then

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerReal").Nodes("NodeCustomerRealView").Nodes("NodeCustomerRealViewNotes")

                ItemNode.ImageIndex = 1
                ItemNode.SelectedImageIndex = 1

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 1
                    ParentNode.SelectedImageIndex = 1

                    ParentNode = ParentNode.Parent

                Loop

            Else

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerReal").Nodes("NodeCustomerRealView").Nodes("NodeCustomerRealViewNotes")

                ItemNode.ImageIndex = 0
                ItemNode.SelectedImageIndex = 0

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 0
                    ParentNode.SelectedImageIndex = 0

                    ParentNode = ParentNode.Parent

                Loop


            End If

            If Profile.CustomerRealAdd Then

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerReal").Nodes("NodeCustomerRealAdd")

                ItemNode.ImageIndex = 1
                ItemNode.SelectedImageIndex = 1

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 1
                    ParentNode.SelectedImageIndex = 1

                    ParentNode = ParentNode.Parent

                Loop

            Else

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerReal").Nodes("NodeCustomerRealAdd")

                ItemNode.ImageIndex = 0
                ItemNode.SelectedImageIndex = 0

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 0
                    ParentNode.SelectedImageIndex = 0

                    ParentNode = ParentNode.Parent

                Loop

            End If

            If Profile.CustomerRealEdit Then

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerReal").Nodes("NodeCustomerRealEdit")

                ItemNode.ImageIndex = 1
                ItemNode.SelectedImageIndex = 1

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 1
                    ParentNode.SelectedImageIndex = 1

                    ParentNode = ParentNode.Parent

                Loop

            Else

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerReal").Nodes("NodeCustomerRealEdit")

                ItemNode.ImageIndex = 0
                ItemNode.SelectedImageIndex = 0

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 0
                    ParentNode.SelectedImageIndex = 0

                    ParentNode = ParentNode.Parent

                Loop


            End If


            If Profile.CustomerPotentialViewGeneral Then

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerPotential").Nodes("NodeCustomerPotentialView").Nodes("NodeCustomerPotentialViewGeneral")

                ItemNode.ImageIndex = 1
                ItemNode.SelectedImageIndex = 1

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 1
                    ParentNode.SelectedImageIndex = 1

                    ParentNode = ParentNode.Parent

                Loop

            Else

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerPotential").Nodes("NodeCustomerPotentialView").Nodes("NodeCustomerPotentialViewGeneral")

                ItemNode.ImageIndex = 0
                ItemNode.SelectedImageIndex = 0

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 0
                    ParentNode.SelectedImageIndex = 0

                    ParentNode = ParentNode.Parent

                Loop

            End If

            If Profile.CustomerPotentialViewAdress Then

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerPotential").Nodes("NodeCustomerPotentialView").Nodes("NodeCustomerPotentialViewAdress")


                ItemNode.ImageIndex = 1
                ItemNode.SelectedImageIndex = 1

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 1
                    ParentNode.SelectedImageIndex = 1

                    ParentNode = ParentNode.Parent

                Loop

            Else

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerPotential").Nodes("NodeCustomerPotentialView").Nodes("NodeCustomerPotentialViewAdress")


                ItemNode.ImageIndex = 0
                ItemNode.SelectedImageIndex = 0

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 0
                    ParentNode.SelectedImageIndex = 0

                    ParentNode = ParentNode.Parent

                Loop

            End If

            If Profile.CustomerPotentialViewDelivery Then

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerPotential").Nodes("NodeCustomerPotentialView").Nodes("NodeCustomerPotentialViewDelivery")

                ItemNode.ImageIndex = 1
                ItemNode.SelectedImageIndex = 1

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 1
                    ParentNode.SelectedImageIndex = 1

                    ParentNode = ParentNode.Parent

                Loop

            Else

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerPotential").Nodes("NodeCustomerPotentialView").Nodes("NodeCustomerPotentialViewDelivery")

                ItemNode.ImageIndex = 0
                ItemNode.SelectedImageIndex = 0

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 0
                    ParentNode.SelectedImageIndex = 0

                    ParentNode = ParentNode.Parent

                Loop

            End If

            If Profile.CustomerPotentialViewTerms Then

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerPotential").Nodes("NodeCustomerPotentialView").Nodes("NodeCustomerPotentialViewTerms")

                ItemNode.ImageIndex = 1
                ItemNode.SelectedImageIndex = 1

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 1
                    ParentNode.SelectedImageIndex = 1

                    ParentNode = ParentNode.Parent

                Loop

            Else

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerPotential").Nodes("NodeCustomerPotentialView").Nodes("NodeCustomerPotentialViewTerms")

                ItemNode.ImageIndex = 0
                ItemNode.SelectedImageIndex = 0

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 0
                    ParentNode.SelectedImageIndex = 0

                    ParentNode = ParentNode.Parent

                Loop

            End If

            If Profile.CustomerPotentialViewContacts Then

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerPotential").Nodes("NodeCustomerPotentialView").Nodes("NodeCustomerPotentialViewContacts")

                ItemNode.ImageIndex = 1
                ItemNode.SelectedImageIndex = 1

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 1
                    ParentNode.SelectedImageIndex = 1

                    ParentNode = ParentNode.Parent

                Loop

            Else

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerPotential").Nodes("NodeCustomerPotentialView").Nodes("NodeCustomerPotentialViewContacts")

                ItemNode.ImageIndex = 0
                ItemNode.SelectedImageIndex = 0

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 0
                    ParentNode.SelectedImageIndex = 0

                    ParentNode = ParentNode.Parent

                Loop

            End If

            If Profile.CustomerPotentialViewAttachments Then

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerPotential").Nodes("NodeCustomerPotentialView").Nodes("NodeCustomerPotentialViewAttachments")

                ItemNode.ImageIndex = 1
                ItemNode.SelectedImageIndex = 1

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 1
                    ParentNode.SelectedImageIndex = 1

                    ParentNode = ParentNode.Parent

                Loop

            Else

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerPotential").Nodes("NodeCustomerPotentialView").Nodes("NodeCustomerPotentialViewAttachments")

                ItemNode.ImageIndex = 0
                ItemNode.SelectedImageIndex = 0

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 0
                    ParentNode.SelectedImageIndex = 0

                    ParentNode = ParentNode.Parent

                Loop


            End If

            If Profile.CustomerPotentialViewNotes Then

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerPotential").Nodes("NodeCustomerPotentialView").Nodes("NodeCustomerPotentialViewNotes")

                ItemNode.ImageIndex = 1
                ItemNode.SelectedImageIndex = 1

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 1
                    ParentNode.SelectedImageIndex = 1

                    ParentNode = ParentNode.Parent

                Loop

            Else

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerPotential").Nodes("NodeCustomerPotentialView").Nodes("NodeCustomerPotentialViewNotes")

                ItemNode.ImageIndex = 0
                ItemNode.SelectedImageIndex = 0

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 0
                    ParentNode.SelectedImageIndex = 0

                    ParentNode = ParentNode.Parent

                Loop


            End If

            If Profile.CustomerPotentialAdd Then

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerPotential").Nodes("NodeCustomerPotentialAdd")

                ItemNode.ImageIndex = 1
                ItemNode.SelectedImageIndex = 1

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 1
                    ParentNode.SelectedImageIndex = 1

                    ParentNode = ParentNode.Parent

                Loop

            Else

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerPotential").Nodes("NodeCustomerPotentialAdd")

                ItemNode.ImageIndex = 0
                ItemNode.SelectedImageIndex = 0

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 0
                    ParentNode.SelectedImageIndex = 0

                    ParentNode = ParentNode.Parent

                Loop

            End If

            If Profile.CustomerPotentialEdit Then

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerPotential").Nodes("NodeCustomerPotentialEdit")

                ItemNode.ImageIndex = 1
                ItemNode.SelectedImageIndex = 1

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 1
                    ParentNode.SelectedImageIndex = 1

                    ParentNode = ParentNode.Parent

                Loop

            Else

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerPotential").Nodes("NodeCustomerPotentialEdit")

                ItemNode.ImageIndex = 0
                ItemNode.SelectedImageIndex = 0

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 0
                    ParentNode.SelectedImageIndex = 0

                    ParentNode = ParentNode.Parent

                Loop

            End If


            If Profile.Tasks Then

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("Nodetask")

                ItemNode.ImageIndex = 1
                ItemNode.SelectedImageIndex = 1

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 1
                    ParentNode.SelectedImageIndex = 1

                    ParentNode = ParentNode.Parent

                Loop

            Else

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("Nodetask")

                ItemNode.ImageIndex = 0
                ItemNode.SelectedImageIndex = 0

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 0
                    ParentNode.SelectedImageIndex = 0

                    ParentNode = ParentNode.Parent

                Loop

            End If


            If Profile.CustomerParameters Then

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeParGen")

                ItemNode.ImageIndex = 1
                ItemNode.SelectedImageIndex = 1

                ParentNode = ItemNode.Parent

                Do While ParentNode IsNot Nothing

                    ParentNode.ImageIndex = 1
                    ParentNode.SelectedImageIndex = 1

                    ParentNode = ParentNode.Parent

                Loop

            Else

                ItemNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeParGen")

                ItemNode.ImageIndex = 0
                ItemNode.SelectedImageIndex = 0

                ParentNode = ItemNode.Parent


                'Do While ParentNode IsNot Nothing

                '    ParentNode.ImageIndex = 0
                '    ParentNode.SelectedImageIndex = 0

                '    ParentNode = ParentNode.Parent

                'Loop

            End If




            If EditionMode Then

                EditionCanceled = False
                BrowserAccept.Visible = True
                BrowserCancel.Visible = True

                BrowserAdd.Visible = False
                BrowserEdit.Visible = False
                BrowserFirst.Visible = False
                BrowserLast.Visible = False
                BrowserNext.Visible = False
                BrowserPrevious.Visible = False

                MenuEditionSave.Visible = True
                MenuEditionCancel.Visible = True

                MenuEditionAdd.Visible = False
                MenuEditionEdit.Visible = False

                txtDescription.ReadOnly = False
                tvPermissions.ContextMenuStrip = PermissionsMenu

                If Profile.Id = 0 Then txtName.ReadOnly = False

            Else

                BrowserAccept.Visible = False
                BrowserCancel.Visible = False

                BrowserAdd.Visible = True
                BrowserEdit.Visible = True
                BrowserFirst.Visible = True
                BrowserLast.Visible = True
                BrowserNext.Visible = True
                BrowserPrevious.Visible = True

                MenuEditionSave.Visible = False
                MenuEditionCancel.Visible = False

                MenuEditionAdd.Visible = True
                MenuEditionEdit.Visible = True

                txtName.ReadOnly = True
                txtDescription.ReadOnly = True
                tvPermissions.ContextMenuStrip = Nothing

            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub ExpandNode(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles tvPermissions.BeforeExpand

        Try

            If e.Node.ImageIndex = 0 Then
                e.Cancel = True
                Exit Try
            End If

        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    If EditionCanceled Then
                        Me.Close()
                    Else
                        CancelEdition()
                    End If

                Case Keys.F10 : If BrowserAccept.Visible Then SaveProfile()

            End Select

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub BrowserFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserFirst.Click
        Try
            ListIndex = 0
            LoadProfile()

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub BrowserPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserPrevious.Click

        If ListIndex > 0 Then
            ListIndex = ListIndex - 1
            LoadProfile()
        End If

    End Sub

    Private Sub BrowserNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserNext.Click
        If ListIndex < Profiles.Count - 1 Then
            ListIndex = ListIndex + 1
            LoadProfile()
        End If
    End Sub


    Private Sub BrowserLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserLast.Click
        ListIndex = Profiles.Count - 1
        LoadProfile()
    End Sub

    Private Sub BrowserAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserAdd.Click, MenuEditionAdd.Click
        Try

            Profile = New Domain.Profile
            DrawMe(True)

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try

    End Sub

    Private Sub BrowserEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserEdit.Click, MenuEditionEdit.Click
        Try
            DrawMe(True)

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try

    End Sub

    Private Sub BrowserAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserAccept.Click, MenuEditionSave.Click
        Try

            SaveProfile()

            Profiles = Domain.ProfileRepository.GetAll


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BrowserCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserCancel.Click, MenuEditionCancel.Click
        Try

            CancelEdition()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Function SaveProfile() As Boolean
        Try
            If Not BindEntity Then Exit Try
            'Pasa objeto PROFILE a espacio de nombres domain y le pide que lo salve
            Domain.ProfileRepository.Save(Profile)

            MsgBox("Perfil actualizado.", MsgBoxStyle.Information)

            DrawMe()

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function BindEntity() As Boolean
        Dim CustomerNode As TreeNode
        Try
            'Trae de formulario los valores y lo asigna a objeto local
            ' "Profile" actualizandolo

            If Not NameValid() Then Return False

            If Profile Is Nothing Then Profile = New Domain.Profile

            Profile.Name = txtName.Text
            Profile.Description = txtDescription.Text

            CustomerNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerReal").Nodes("NodeCustomerRealView")
            Profile.CustomerRealViewGeneral = CBool(CustomerNode.Nodes("NodeCustomerRealViewGeneral").ImageIndex)
            Profile.CustomerRealViewAdress = CBool(CustomerNode.Nodes("NodeCustomerRealViewAdress").ImageIndex)
            Profile.CustomerRealViewDelivery = CBool(CustomerNode.Nodes("NodeCustomerRealViewDelivery").ImageIndex)
            Profile.CustomerRealViewTerms = CBool(CustomerNode.Nodes("NodeCustomerRealViewTerms").ImageIndex)
            Profile.CustomerRealViewContacts = CBool(CustomerNode.Nodes("NodeCustomerRealViewContacts").ImageIndex)
            Profile.CustomerRealViewAttachments = CBool(CustomerNode.Nodes("NodeCustomerRealViewAttachments").ImageIndex)
            Profile.CustomerRealViewNotes = CBool(CustomerNode.Nodes("NodeCustomerRealViewNotes").ImageIndex)

            CustomerNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerReal")
            Profile.CustomerRealAdd = CBool(CustomerNode.Nodes("NodeCustomerRealAdd").ImageIndex)
            Profile.CustomerRealEdit = CBool(CustomerNode.Nodes("NodeCustomerRealEdit").ImageIndex)


            CustomerNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerPotential").Nodes("NodeCustomerPotentialView")
            Profile.CustomerPotentialViewGeneral = CBool(CustomerNode.Nodes("NodeCustomerPotentialViewGeneral").ImageIndex)
            Profile.CustomerPotentialViewAdress = CBool(CustomerNode.Nodes("NodeCustomerPotentialViewAdress").ImageIndex)
            Profile.CustomerPotentialViewDelivery = CBool(CustomerNode.Nodes("NodeCustomerPotentialViewDelivery").ImageIndex)
            Profile.CustomerPotentialViewTerms = CBool(CustomerNode.Nodes("NodeCustomerPotentialViewTerms").ImageIndex)
            Profile.CustomerPotentialViewContacts = CBool(CustomerNode.Nodes("NodeCustomerPotentialViewContacts").ImageIndex)
            Profile.CustomerPotentialViewAttachments = CBool(CustomerNode.Nodes("NodeCustomerPotentialViewAttachments").ImageIndex)
            Profile.CustomerPotentialViewNotes = CBool(CustomerNode.Nodes("NodeCustomerPotentialViewNotes").ImageIndex)

            CustomerNode = tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeCustomer").Nodes("NodeCustomerPotential")
            Profile.CustomerPotentialAdd = CBool(CustomerNode.Nodes("NodeCustomerPotentialAdd").ImageIndex)
            Profile.CustomerPotentialEdit = CBool(CustomerNode.Nodes("NodeCustomerPotentialEdit").ImageIndex)

            Profile.Tasks = CBool(tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeTask").ImageIndex)

            Profile.CustomerParameters = CBool(tvPermissions.Nodes("NodeRoot").Nodes("NodeEntity").Nodes("NodeParGen").ImageIndex)


            Return True

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CancelEdition() As Boolean
        Try

            EditionCanceled = True
            LoadProfile()
            DrawMe()

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub PermissionsMenu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles PermissionsMenu.Opening
        Dim Node As TreeNode
        Try

            If tvPermissions.SelectedNode Is Nothing Then
                e.Cancel = True
                Exit Try
            End If

            For Each Button As ToolStripMenuItem In PermissionsMenu.Items
                Button.Enabled = False
            Next

            Node = tvPermissions.SelectedNode()

            If Node.ImageIndex = 0 Then
                If Node.Tag = "Item" Then
                    PermissionsMenuEnabledNode.Enabled = True
                Else
                    PermissionsMenuEnabledNodes.Enabled = True
                End If
            Else
                If Node.Tag = "Item" Then
                    PermissionsMenuDisableNode.Enabled = True
                Else
                    PermissionsMenuDisableNodes.Enabled = True
                End If
            End If

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub EnableNodes(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermissionsMenuEnabledNodes.Click
        Dim Node As TreeNode

        Try

            If tvPermissions.SelectedNode Is Nothing Then Exit Try

            Node = tvPermissions.SelectedNode()

            EnableNodes(Node)

            Node.ExpandAll()

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub


    Private Sub EnableNodes(ByVal Node As TreeNode)

        Try
            Node.ImageIndex = 1
            Node.SelectedImageIndex = 1

            For Each ChildNode As TreeNode In Node.Nodes

                EnableNodes(ChildNode)

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Private Sub DisableNodes(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermissionsMenuDisableNodes.Click
        Dim Node As TreeNode

        Try

            If tvPermissions.SelectedNode Is Nothing Then Exit Try

            Node = tvPermissions.SelectedNode()

            DisableNodes(Node)

            Node.Collapse()

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub DisableNodes(ByVal Node As TreeNode)
        Try

            Node.ImageIndex = 0
            Node.SelectedImageIndex = 0

            For Each ChildNode As TreeNode In Node.Nodes

                DisableNodes(ChildNode)

            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PermissionsMenuEnabledNode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermissionsMenuEnabledNode.Click
        Dim Node As TreeNode

        Try

            If tvPermissions.SelectedNode Is Nothing Then Exit Try

            Node = tvPermissions.SelectedNode()

            Node.ImageIndex = 1
            Node.SelectedImageIndex = 1

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub PermissionsMenuDisableNode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermissionsMenuDisableNode.Click
        Dim Node As TreeNode

        Try

            If tvPermissions.SelectedNode Is Nothing Then Exit Try

            Node = tvPermissions.SelectedNode()

            Node.ImageIndex = 0
            Node.SelectedImageIndex = 0

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MenuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuFileExit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            If NameValid() Then txtDescription.Focus()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Description_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescription.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub

            tvPermissions.Focus()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Function NameValid() As Boolean
        Dim Id As Integer

        Try
            If txtName.ReadOnly Then Return True

            If txtName.Text = "" Then
                MsgBox("CAMPO OBLIGATORIO", MsgBoxStyle.Exclamation, "Atención")
                txtName.Focus()
                Return False
            End If

            Id = Admin.Domain.ProfileRepository.GetIdByName(txtName.Text)

            If Id <> 0 Then
                MsgBox("PERFIL EXISTENTE", MsgBoxStyle.Exclamation, "Atención")
                txtName.SelectAll()
                Return False
            End If

            Return True

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try

    End Function

    Private Sub Name_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtName.Validating
        Try
            If EditionCanceled Then Exit Sub

            e.Cancel = Not NameValid()

        Catch ex As Exception
            MsgBox(ex.ToString)
            e.Cancel = True
        End Try

    End Sub

    Private Sub tvPermissions_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvPermissions.AfterSelect

    End Sub
End Class