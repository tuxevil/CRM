Public Class frmSearch

    Private mDataSource As DataSet
    Private mSelectedItem As Object
    Private mSelectedValue As String
    Private mSearchPattern As String

    Public Event ParametersChanged(ByVal Field As String, ByVal value As Object)

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal Title As String, ByVal Source As DataSet, ByVal SearchPattern As String)
        InitializeComponent()

        Try
            lblTitle.Text = Title
            Me.Text = Title

            mDataSource = Source

            mSearchPattern = SearchPattern

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

            lvRows.Items.Clear()

            If mDataSource.Tables.Contains("Structure") Then

                lvRows.Columns.Clear()
                cmbField.Items.Clear()

                If mDataSource Is Nothing Then Return False

                For Each field As DataRow In mDataSource.Tables("Structure").Rows

                    ColX = lvRows.Columns.Add(field.Item(1))

                    ColX.Name = field.Item(2)

                    ColX.Width = CInt(field.Item(3))

                    cmbField.Items.Add(ColX)

                    cmbField.DisplayMember = "Text"
                    cmbField.ValueMember = "Index"

                Next

                If cmbField.Items.Count > 0 Then cmbField.SelectedIndex = 0

            End If

            If mDataSource.Tables.Contains("Data") Then


                lvRows.ListViewItemSorter = Nothing

                lvRows.BeginUpdate()

                For Each item As DataRow In mDataSource.Tables("Data").Rows

                    If item.Item(0) Is DBNull.Value Then
                        Value = ""
                    Else
                        Value = item.Item(0)
                    End If


                    itmX = lvRows.Items.Add(Value)

                    For Counter = 1 To lvRows.Columns.Count - 1
                        If item.Item(Counter) Is DBNull.Value Then
                            Value = ""
                        Else
                            Value = item.Item(Counter)
                        End If

                        itmX.SubItems.Add(Value)

                    Next Counter

                Next item

                lvRows.EndUpdate()

            End If

            Return ShowItem()

        Catch ex As Exception
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

    Private Sub ShowHide_Panel(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btHide.Click
        Try
            mainSplit.Panel1Collapsed = Not (btHide.Checked)
        Catch ex As Exception
            ex = Nothing

        End Try

    End Sub

    Private Sub PanelOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msPanelOptions.Click
        Try
            If mainSplit.Panel1Collapsed Then mainSplit.Panel1Collapsed = False

        Catch ex As Exception
            ex = Nothing

        End Try
    End Sub

    Private Sub PanelOptions_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mainSplit.Panel1.MouseHover
        Try
            If mainSplit.Panel1Collapsed Then mainSplit.Panel1Collapsed = False

        Catch ex As Exception
            ex = Nothing

        End Try

    End Sub

    Private Sub PanelOptions_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mainSplit.Panel2.Mousehover, pnlCriteria.MouseHover, lvRows.MouseHover, lblTitle.MouseHover, txtCriteria.MouseHover, cmbField.MouseHover
        Try
            If Not (btHide.Checked) Then mainSplit.Panel1Collapsed = True

        Catch ex As Exception
            ex = Nothing

        End Try

    End Sub


    Private Sub Criteria_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriteria.TextChanged
        Try
            If chkIncremental.Checked Then RaiseEvent ParametersChanged(cmbField.SelectedItem.Name, Replace(txtCriteria.Text, "'", "''"))

        Catch ex As Exception
            ex = Nothing

        End Try

    End Sub

    Private Sub Criteria_Accepted(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCriteria.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then RaiseEvent ParametersChanged(cmbField.SelectedItem.Name, txtCriteria.Text)

        Catch ex As Exception
            ex = Nothing

        End Try

    End Sub


    Private Sub ItemSelectedByMouse(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvRows.MouseDoubleClick, lvRows.MouseDoubleClick
        Try
            If lvRows.SelectedItems Is Nothing Then Exit Sub

            mSelectedItem = lvRows.SelectedItems(0)

            mSelectedValue = lvRows.SelectedItems(0).Text

            Me.Close()

        Catch ex As Exception
            mSelectedItem = Nothing
            mSelectedValue = Nothing

        End Try

    End Sub

    Private Sub ItemSelectedByKey(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvRows.KeyDown
        Try
            If lvRows.SelectedItems Is Nothing Then Exit Sub

            If e.KeyCode <> Keys.Enter Then Exit Sub

            mSelectedItem = lvRows.SelectedItems(0)

            mSelectedValue = lvRows.SelectedItems(0).Text

            Me.Close()

        Catch ex As Exception
            mSelectedItem = Nothing
            mSelectedValue = Nothing

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

    Private Sub cmbField_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbField.SelectedValueChanged
        Try
            txtCriteria.Text = ""
        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

End Class