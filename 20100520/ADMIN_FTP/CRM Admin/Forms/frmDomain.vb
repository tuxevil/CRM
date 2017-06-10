Public Class frmDomain

    Private mDataSource As DataSet
    Private mSelectedItem As Object
    Private mSelectedValue As String
    Private mSearchPattern As String

    Private IdUser As Integer
    Private IdCompany As Integer

    Private OnDraw As Boolean

    Public Event ParametersChanged(ByVal WhereCondition As String)

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal User As String, ByVal Company As String, ByVal Source As DataSet, ByVal SearchPattern As String, ByVal UserId As Integer, ByVal CompanyId As Integer)
        InitializeComponent()

        Try
            lblTitle.Text = "USUARIO " & User
            Me.Text = "EMPRESA " & Company

            mDataSource = Source

            mSearchPattern = SearchPattern

            IdUser = UserId
            IdCompany = CompanyId

        Catch ex As Exception
            mDataSource = Nothing

        End Try

    End Sub

    Public Property DataSource() As DataSet
        Get
            Return mDataSource
        End Get
        Set(ByVal value As DataSet)
            mDataSource = value
            If Not ShowList() Then Me.Close()
        End Set
    End Property

    Public ReadOnly Property SelectedItem() As Object
        Get
            Return mSelectedItem
        End Get
    End Property

    Public ReadOnly Property SelectedValue() As String
        Get
            Return mSelectedValue
        End Get
    End Property

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

            txtCriteria.Text = mSearchPattern

        Catch ex As Exception
            MsgBox("Ocurrió un error al recuperar la información solicitada", MsgBoxStyle.Exclamation, Application.ProductName)

        End Try

    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If mSelectedItem Is Nothing Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        Catch ex As Exception
            Me.DialogResult = Windows.Forms.DialogResult.None
            mSelectedItem = Nothing
            mSelectedValue = Nothing

        End Try

    End Sub

    Private Function ShowList() As Boolean
        Dim itmX As ListViewItem
        Dim ColX As ColumnHeader
        Dim Value As Object
        Try
            OnDraw = True

            lvRows.Items.Clear()

            If mDataSource.Tables.Contains("Structure") Then

                lvRows.Columns.Clear()
                cmbField.Items.Clear()

                If mDataSource Is Nothing Then Return False

                For Each field As DataRow In mDataSource.Tables("Structure").Rows

                    ColX = lvRows.Columns.Add(field.Item(1))

                    ColX.Name = field.Item(2)

                    ColX.Width = CInt(field.Item(3))

                    lvRows.CheckBoxes = True

                    cmbField.Items.Add(ColX)

                    cmbField.DisplayMember = "Text"
                    cmbField.ValueMember = "Index"

                Next

                If cmbField.Items.Count > 0 Then cmbField.SelectedIndex = 0

            End If

            If mDataSource.Tables.Contains("Data") Then


                lvRows.ListViewItemSorter = Nothing

                For Each item As DataRow In mDataSource.Tables("Data").Rows

                    If item.Item(1) Is DBNull.Value Then
                        Value = ""
                    Else
                        Value = item.Item(1)
                    End If

                    itmX = lvRows.Items.Add(Value)

                    For Counter = 2 To lvRows.Columns.Count - 1
                        If item.Item(Counter) Is DBNull.Value Then
                            Value = ""
                        Else
                            Value = item.Item(Counter)
                        End If

                        itmX.SubItems.Add(Value)

                    Next Counter

                    itmX.Checked = item.Item(0)

                Next item

            End If

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

            If lvRows.Items.Count > 0 Then

                Item = lvRows.Items(0)

                If Not Item Is Nothing Then

                    lvRows.HideSelection = False
                    Item.EnsureVisible()
                    Item.Selected = True

                Else

                    lvRows.HideSelection = True

                End If

            End If

            Return True

        Catch ex As Exception
            Throw ex
            Return False

        End Try

    End Function

    Private Sub cmdAddFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddFilter.Click
        Dim FieldName As String = ""
        Try

            If txtCriteria.Text = "" Or cmbField.SelectedItem Is Nothing Then Exit Try

            FieldName = cmbField.SelectedItem.text

            If FieldName.EndsWith("*") Then FieldName = Mid(FieldName, 1, Len(FieldName) - 2)

            GridCriteria.Rows.Add(cmbField.SelectedItem.Name, FieldName, txtCriteria.Text)

            RaiseEvent ParametersChanged(GetCondition)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Function GetCondition() As String
        Dim Query As String

        Try
            Query = ""

            For Each row As DataGridViewRow In GridCriteria.Rows
                Query = Query & " AND " & row.Cells(0).Value & " = '" & row.Cells(2).Value & "' "
            Next

            Return Query

        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub cmbField_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbField.SelectedValueChanged
        Try
            txtCriteria.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cmdSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelectAll.Click
        Try

            For Each row As ListViewItem In lvRows.Items

                row.Checked = True

            Next
        Catch ex As Exception

        End Try

    End Sub


    Private Sub cmdUnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnSelectAll.Click
        Try

            For Each row As ListViewItem In lvRows.Items

                row.Checked = False

            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SortRows(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvRows.ColumnClick
        Try
            For Each col As ColumnHeader In lvRows.Columns

                If col.Text.EndsWith("*") Then col.Text = Mid(col.Text, 1, Len(col.Text) - 2)

            Next

            cmbField.SelectedItem = lvRows.Columns(e.Column)

            lvRows.Columns(e.Column).Text = lvRows.Columns(e.Column).Text & " *"

        Catch ex As Exception
            ex = Nothing

        End Try

    End Sub

    Private Sub RemoveFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterMenuRemoveFilter.Click

        Try

            If GridCriteria.SelectedRows IsNot Nothing Then
                GridCriteria.Rows.Remove(GridCriteria.SelectedRows(0))
                RaiseEvent ParametersChanged(GetCondition)
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub RemoveAllFilters(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterMenuRemoveAll.Click
        Try

            GridCriteria.Rows.Clear()
            RaiseEvent ParametersChanged(GetCondition)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DomainChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lvRows.ItemChecked
        Try

            If Not OnDraw Then UserRepository.SaveDomain(IdUser, IdCompany, e.Item.Text, e.Item.Checked)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class