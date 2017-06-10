Public Class frmCompanies

    Private WithEvents frmDomain As frmDomain
    Private mDataSource As List(Of Domain.Company)
    Private OnDraw As Boolean

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal companies As List(Of Domain.Company))
        InitializeComponent()

        Try

            mDataSource = companies

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try

            Select Case e.KeyCode
                Case Keys.Escape : Me.Close()

            End Select
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar procesar la instrucción" & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Informe de errores")
        End Try
    End Sub


    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            If mDataSource Is Nothing Then
                MsgBox("Ocurrió un error al recuperar la información solicitada", MsgBoxStyle.Exclamation, Application.ProductName)
                Me.Close()
                Exit Sub
            End If

            If Not (ShowList()) Then
                MsgBox("Ocurrió un error al recuperar la información solicitada", MsgBoxStyle.Exclamation, Application.ProductName)
                Me.Close()
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Ocurrió un error al recuperar la información solicitada", MsgBoxStyle.Exclamation, Application.ProductName)

        End Try

    End Sub

    Private Function ShowList() As Boolean
        Dim itmX As ListViewItem
        Try
            OnDraw = True

            ListCompanies.Items.Clear()

            For Each company As Domain.Company In mDataSource

                itmX = ListCompanies.Items.Add(company.Name)

                itmX.SubItems.Add(company.Database)

                itmX.SubItems.Add(company.TangoId)

                itmX.SubItems.Add(company.Id)

                itmX.SubItems.Add(company.TangoId)

                If company.Id > 0 Then
                    itmX.Checked = True
                    itmX.ImageKey = "CompanyEnabled"
                Else
                    itmX.Checked = False
                    itmX.ImageKey = "CompanyDisabled"
                End If

            Next company

            OnDraw = False

            Return ShowItem()

        Catch ex As Exception
            OnDraw = False
            Return False
        End Try

    End Function

    Private Function ShowItem() As Boolean
        Dim Item As ListViewItem

        Try

            If ListCompanies.Items.Count > 0 Then

                Item = ListCompanies.Items(0)

                If Not Item Is Nothing Then

                    ListCompanies.HideSelection = False
                    Item.EnsureVisible()
                    Item.Selected = True

                Else

                    ListCompanies.HideSelection = True

                End If

            End If

            Return True

        Catch ex As Exception
            Throw ex
            Return False

        End Try

    End Function

    Private Sub cmdViewList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            ListCompanies.View = View.Details

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub cmdViewIcons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            ListCompanies.View = View.LargeIcon

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub CompanyMenuEnable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanyMenuEnable.Click
        Dim Item As ListViewItem
        Try

            If ListCompanies.SelectedItems Is Nothing Then Exit Try
            Item = ListCompanies.SelectedItems(0)

            CompanyRepository.AddCompany(CInt(Item.SubItems(2).Text), Item.Text)

            Item.Checked = True
            Item.ImageKey = "CompanyEnabled"
            Item.SubItems(3).Text = 1

            MsgBox("Empresa habilitada", MsgBoxStyle.Information)


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CompanyMenu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CompanyMenu.Opening
        Try

            If ListCompanies.SelectedItems Is Nothing Then Exit Try

            If ListCompanies.SelectedItems(0).Checked Then
                e.Cancel = True
                Exit Try
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ListCompanies_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListCompanies.SelectedIndexChanged

    End Sub
End Class