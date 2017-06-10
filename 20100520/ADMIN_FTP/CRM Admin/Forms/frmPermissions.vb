Public Class frmPermissions

    Private WithEvents frmDomain As frmDomain

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal companies As List(Of Domain.Company), ByVal profiles As List(Of Domain.Profile))
        InitializeComponent()

        Dim CompanyNode As TreeNode
        Dim UserNode As TreeNode
        Dim ProfileNode As TreeNode

        Dim Users As List(Of Domain.User)

        Try

            If companies.Count <= 0 Then Throw New Exception("No existen empresas")

            If profiles.Count <= 0 Then Throw New Exception("No existen perfiles")

            tvCompanies.Nodes(0).Nodes.Clear()

            For Each entity As Domain.Company In companies

                CompanyNode = tvCompanies.Nodes(0).Nodes.Add(entity.Name)
                CompanyNode.Name = "NodeCompany"
                CompanyNode.Tag = entity.Id

                Users = Domain.UserRepository.GetByCompany(entity.Id)

                For Each User As User In Users

                    UserNode = CompanyNode.Nodes.Add(User.NickName)
                    UserNode.Name = "NodeUser_" & User.NickName
                    UserNode.ImageIndex = 1
                    UserNode.SelectedImageIndex = 1
                    UserNode.Tag = User.TangoId

                    ProfileNode = UserNode.Nodes.Add(User.Profile.Name)
                    ProfileNode.Name = "NodeProfile"
                    ProfileNode.ImageIndex = 2
                    ProfileNode.SelectedImageIndex = 2
                    ProfileNode.Tag = User.Profile.Id

                Next

            Next

            ProfileList.DataSource = profiles
            ProfileList.DisplayMember = "Name"
            ProfileList.ValueMember = "Id"

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DragProfile(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles tvCompanies.DragEnter
        Try
            If (e.Data.GetDataPresent(DataFormats.StringFormat)) Then
                e.Effect = DragDropEffects.All
            Else
                e.Effect = DragDropEffects.None
            End If

        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub DropProfile(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles tvCompanies.DragDrop
        Dim Node As TreeNode
        Dim ProfileNode As TreeNode
        Dim s As String
        Dim Prf As Domain.Profile

        Try
            s = e.Data.GetData(DataFormats.StringFormat, False)

            If s = "" Then Exit Try

            Prf = Domain.ProfileRepository.GetById(Val(s))

            If Prf Is Nothing Then Exit Try

            Node = tvCompanies.GetNodeAt(tvCompanies.PointToClient(New System.Drawing.Point(e.X, e.Y)))

            If Node Is Nothing Then Exit Try

            If Not Node.Name.StartsWith("NodeUser") Then Exit Try

            If Node.GetNodeCount(True) > 0 Then Node.Nodes.Clear()

            ProfileNode = Node.Nodes.Add(Prf.Name)
            ProfileNode.Tag = Prf.Id
            ProfileNode.ImageIndex = 2
            ProfileNode.SelectedImageIndex = 2

            Node.ExpandAll()


        Catch ex As Exception
            MsgBox("Ocurrio un error al crear el acceso directo" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")

        End Try

    End Sub

    Private Sub ProfileList_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ProfileList.MouseDown
        Try

            If ProfileList.SelectedItem Is Nothing Then Exit Sub
            DoDragDrop(ProfileList.SelectedValue.ToString, DragDropEffects.Copy)

        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub MenuActionsAddTask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuActionsAddTask.Click
        Dim Node As TreeNode
        Dim ProfileNode As TreeNode
        Dim Prf As Domain.Profile

        Try
            If ProfileList.SelectedItem Is Nothing Then Exit Try

            Prf = ProfileList.SelectedItem

            If Prf Is Nothing Then Exit Try

            Node = tvCompanies.SelectedNode

            If Node Is Nothing Then Exit Try

            If Not Node.Name.StartsWith("NodeUser") Then Exit Try

            If Node.GetNodeCount(True) > 0 Then Node.Nodes.Clear()

            ProfileNode = Node.Nodes.Add(Prf.Name)
            ProfileNode.Tag = Prf.Id
            ProfileNode.ImageIndex = 2
            ProfileNode.SelectedImageIndex = 2

            Node.ExpandAll()

        Catch ex As Exception
            MsgBox("Ocurrio un error al crear el acceso directo" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")

        End Try
    End Sub

    Private Sub TreeMenu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TreeMenu.Opening
        Dim UserMenu As ToolStripMenuItem
        Dim Users As List(Of Domain.User)

        Try

            If tvCompanies.SelectedNode Is Nothing Then
                e.Cancel = True
                Exit Sub
            End If

            If tvCompanies.SelectedNode.Name = "NodeCompany" Then

                TreeMenuDeleteuser.Visible = False

                TreeMenuUserDomain.Visible = False

                TreeMenuUserProfileOwner.Visible = False

                TreeMenuAddUser.Visible = True

                TreeMenuAddUser.DropDownItems.Clear()

                Users = Domain.UserRepository.TangoUsers()

                For Each entity As Domain.User In Users

                    If Not tvCompanies.SelectedNode.Nodes.ContainsKey("NodeUser_" & entity.NickName) Then

                        UserMenu = TreeMenuAddUser.DropDownItems.Add(entity.NickName, Nothing, AddressOf AddUser)
                        UserMenu.Tag = entity.TangoId

                    End If

                Next

                Exit Sub

            End If

            If tvCompanies.SelectedNode.Name.StartsWith("NodeUser") Then

                TreeMenuDeleteuser.Visible = True

                TreeMenuUserDomain.Visible = True

                TreeMenuUserProfileOwner.Visible = True

                TreeMenuUserDomainAbs.Checked = Domain.UserRepository.FullUser(CInt(tvCompanies.SelectedNode.Parent.Tag), CInt(tvCompanies.SelectedNode.Tag), CInt(tvCompanies.SelectedNode.Nodes(0).Tag))

                TreeMenuUserProfileOwner.Checked = Domain.UserRepository.ProfileOwner(CInt(tvCompanies.SelectedNode.Parent.Tag), CInt(tvCompanies.SelectedNode.Tag), CInt(tvCompanies.SelectedNode.Nodes(0).Tag))

                TreeMenuAddUser.Visible = False

                TreeMenuUserDomainDefine.Enabled = Not TreeMenuUserDomainAbs.Checked

                Exit Sub

            End If

            e.Cancel = True

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub AddUser(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim UserNode As TreeNode
        Dim ProfileNode As TreeNode
        Dim Profile As Domain.Profile

        Try

            If tvCompanies.SelectedNode Is Nothing Then Exit Try

            If tvCompanies.SelectedNode.Name <> "NodeCompany" Then Exit Try

            If ProfileList.Items.Count <= 0 Then Throw New Exception("No existen perfiles")

            Profile = ProfileList.Items(0)

            If Not tvCompanies.SelectedNode.Nodes.ContainsKey("NodeUser_" & sender.text) Then

                UserNode = tvCompanies.SelectedNode.Nodes.Add(sender.text)
                UserNode.Name = "NodeUser_" & sender.text
                UserNode.ImageIndex = 1
                UserNode.SelectedImageIndex = 1
                UserNode.Tag = sender.tag

                ProfileNode = UserNode.Nodes.Add(Profile.Name)
                ProfileNode.Tag = Profile.Id
                ProfileNode.ImageIndex = 2
                ProfileNode.SelectedImageIndex = 2

                UserNode.ExpandAll()

            End If

            Save()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TreeMenuDeleteuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeMenuDeleteuser.Click
        Try

            If tvCompanies.SelectedNode Is Nothing Then Exit Try

            If Not tvCompanies.SelectedNode.Name.StartsWith("NodeUser") Then Exit Try

            If MsgBox("Seguro desea eliminar el usuario seleccionado", MsgBoxStyle.YesNo, "Administración...") = MsgBoxResult.Yes Then


                tvCompanies.SelectedNode.Remove()
                Save()

            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CloseForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuFileExit.Click
        Try
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Function Save() As Boolean
        Dim user As Domain.User

        Try

            UserRepository.BeginProcess()

            For Each CompanyNode As TreeNode In tvCompanies.Nodes(0).Nodes


                For Each UserNode As TreeNode In CompanyNode.Nodes

                    user = Domain.UserRepository.Save(UserNode.Tag)

                    If user IsNot Nothing Then

                        If UserNode.Nodes.Count > 0 Then Domain.UserRepository.SaveProfile(CompanyNode.Tag, user.Id, UserNode.Nodes(0).Tag)

                    End If

                Next

            Next

            UserRepository.CommitProcess()

        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Private Sub TreeMenuUserDomainDefine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeMenuUserDomainDefine.Click
        Dim Customers As DataSet
        Dim User As Domain.User

        Try

            If tvCompanies.SelectedNode Is Nothing Then Exit Try

            If Not tvCompanies.SelectedNode.Name.StartsWith("NodeUser") Then Exit Try

            User = Domain.UserRepository.GetByTangoId(CInt(tvCompanies.SelectedNode.Tag))

            If User Is Nothing Then Exit Try

            'Si no existe lo guarda, sino lo actualiza
            Domain.UserRepository.SaveProfile(CInt(tvCompanies.SelectedNode.Parent.Tag), User.Id, CInt(tvCompanies.SelectedNode.Nodes(0).Tag))
            'Se pone como false el fulluser
            Domain.UserRepository.SaveFullUser(User.Id, CInt(tvCompanies.SelectedNode.Parent.Tag), CInt(tvCompanies.SelectedNode.Nodes(0).Tag), False)

            Customers = CustomerRepository.GetDomain(User.Id, CInt(tvCompanies.SelectedNode.Parent.Tag), , True)

            frmDomain = New frmDomain(tvCompanies.SelectedNode.Text, tvCompanies.SelectedNode.Parent.Text, Customers, "", User.Id, CInt(tvCompanies.SelectedNode.Parent.Tag))
            frmDomain.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TreeMenuUserDomainAbs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeMenuUserDomainAbs.Click
        Dim User As Domain.User
        Try

            If tvCompanies.SelectedNode Is Nothing Then Exit Try

            If Not tvCompanies.SelectedNode.Name.StartsWith("NodeUser") Then Exit Try

            User = Domain.UserRepository.GetByTangoId(CInt(tvCompanies.SelectedNode.Tag))

            If User Is Nothing Then Exit Try

            Domain.UserRepository.SaveProfile(CInt(tvCompanies.SelectedNode.Parent.Tag), User.Id, CInt(tvCompanies.SelectedNode.Nodes(0).Tag))

            Domain.UserRepository.SaveFullUser(User.Id, CInt(tvCompanies.SelectedNode.Parent.Tag), CInt(tvCompanies.SelectedNode.Nodes(0).Tag), Not TreeMenuUserDomainAbs.Checked)

            TreeMenuUserDomainAbs.Checked = Not TreeMenuUserDomainAbs.Checked

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub frmDomain_ParametersChanged(ByVal WhereCondition As String) Handles frmDomain.ParametersChanged
        Dim User As Domain.User

        Try
            User = Domain.UserRepository.GetByTangoId(CInt(tvCompanies.SelectedNode.Tag))

            If User Is Nothing Then Exit Try

            frmDomain.DataSource = CustomerRepository.GetDomain(User.Id, CInt(tvCompanies.SelectedNode.Parent.Tag), WhereCondition, False)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub ProfileOwnerChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeMenuUserProfileOwner.Click
        Try

            If tvCompanies.SelectedNode Is Nothing Then Exit Try

            If Not tvCompanies.SelectedNode.Name.StartsWith("NodeUser") Then Exit Try

            Domain.UserRepository.SaveProfile(CInt(tvCompanies.SelectedNode.Parent.Tag), CInt(tvCompanies.SelectedNode.Tag), CInt(tvCompanies.SelectedNode.Nodes(0).Tag))

            Domain.UserRepository.SaveProfileOwner(CInt(tvCompanies.SelectedNode.Tag), CInt(tvCompanies.SelectedNode.Parent.Tag), CInt(tvCompanies.SelectedNode.Nodes(0).Tag), Not TreeMenuUserProfileOwner.Checked)

            TreeMenuUserProfileOwner.Checked = Not TreeMenuUserProfileOwner.Checked

            tvCompanies.SelectedNode.Checked = TreeMenuUserProfileOwner.Checked

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub tvCompanies_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvCompanies.AfterSelect

    End Sub
End Class