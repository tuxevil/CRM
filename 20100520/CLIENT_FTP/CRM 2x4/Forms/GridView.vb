Public Class GridView

    Private CellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Private mFilered As Boolean
    Private mFilteredColumn As Integer

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        CellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        CellStyle.BackColor = System.Drawing.SystemColors.Control
        CellStyle.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'CellStyle.ForeColor = System.Drawing.SystemColors.ControlText ' Modificado por el siguiente
        CellStyle.ForeColor = Color.Black
        CellStyle.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        'CellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText ' remplazada por la siguiente linea
        CellStyle.SelectionForeColor = Color.Gray ' remplazada por la siguiente linea

        CellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BackgroundColor = System.Drawing.SystemColors.Control
        Me.BorderStyle = Windows.Forms.BorderStyle.None
        Me.DefaultCellStyle = CellStyle
        Me.GridColor = System.Drawing.SystemColors.Control
        Me.ReadOnly = True
        Me.RowHeadersVisible = False
        Me.RowTemplate.DividerHeight = 5
        Me.RowTemplate.Height = 30
        Me.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        If Me.ColumnHeadersVisible Then
            Me.ContextMenuStrip = GridViewMenu
        Else
            Me.ContextMenuStrip = Nothing
        End If

    End Sub

    Private Sub GridViewMenu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridViewMenu.Opening
        Try
            If Me.SortedColumn IsNot Nothing Then
                mFilteredColumn = Me.SortedColumn.Index
            Else
                mFilteredColumn = 0
            End If

            GridViewMenuUnFilter.Enabled = mFilered

            GridViewMenuFilter.Text = "Filtrar " & Me.Columns(mFilteredColumn).HeaderText

        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub FilterEqual(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridViewMenuFilterEqualText.KeyDown
        Dim CellValue As String
        Try

            If e.KeyCode = 13 Then

                mFilered = True

                For Each row As DataGridViewRow In Me.Rows
                    If row.Visible Then
                        CellValue = CStr(row.Cells(mFilteredColumn).Value)
                        If CellValue Is Nothing Then GoTo NextRow
                        If CellValue = GridViewMenuFilterEqualText.Text Then
                            row.Visible = True
                        Else
                            row.Visible = False
                        End If
                    End If
NextRow:
                Next

                ClearFilterText()

            End If

        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub FilterNotEqual(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridViewMenuFilterNotEqualText.KeyDown
        Dim CellValue As String
        Try

            If e.KeyCode = 13 Then

                mFilered = True

                For Each row As DataGridViewRow In Me.Rows
                    If row.Visible Then
                        CellValue = CStr(row.Cells(mFilteredColumn).Value)
                        If CellValue Is Nothing Then GoTo NextRow
                        If CellValue <> GridViewMenuFilterNotEqualText.Text Then
                            row.Visible = True
                        Else
                            row.Visible = False
                        End If
                    End If
NextRow:
                Next

                ClearFilterText()

            End If

        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub FilterContains(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridViewMenuFilterContainsText.KeyDown
        Dim CellValue As String
        Try

            If e.KeyCode = 13 Then

                mFilered = True

                For Each row As DataGridViewRow In Me.Rows
                    If row.Visible Then
                        CellValue = CStr(row.Cells(mFilteredColumn).Value)
                        If CellValue Is Nothing Then GoTo NextRow
                        If CellValue.Contains(GridViewMenuFilterContainsText.Text) Then
                            row.Visible = True
                        Else
                            row.Visible = False
                        End If
                    End If
NextRow:
                Next

                ClearFilterText()

            End If

        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub FilterNotContains(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridViewMenuFilterNotContainsText.KeyDown
        Dim CellValue As String
        Try

            If e.KeyCode = 13 Then

                mFilered = True

                For Each row As DataGridViewRow In Me.Rows
                    If row.Visible Then
                        CellValue = CStr(row.Cells(mFilteredColumn).Value)
                        If CellValue Is Nothing Then GoTo NextRow
                        If Not CellValue.Contains(GridViewMenuFilterNotContainsText.Text) Then
                            row.Visible = True
                        Else
                            row.Visible = False
                        End If
                    End If
NextRow:
                Next


                ClearFilterText()

            End If

        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub FilterGreater(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridViewMenuFilterGreaterText.KeyDown
        Dim CellValue As String
        Try

            If e.KeyCode = 13 Then

                mFilered = True

                For Each row As DataGridViewRow In Me.Rows
                    If row.Visible Then
                        CellValue = CStr(row.Cells(mFilteredColumn).Value)
                        If CellValue Is Nothing Then GoTo NextRow
                        If CellValue > GridViewMenuFilterGreaterText.Text Then
                            row.Visible = True
                        Else
                            row.Visible = False
                        End If
                    End If
NextRow:
                Next


                ClearFilterText()

            End If

        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub FilterSmaller(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridViewMenuFilterSmallerText.KeyDown
        Dim CellValue As String
        Try

            If e.KeyCode = 13 Then

                mFilered = True

                For Each row As DataGridViewRow In Me.Rows
                    If row.Visible Then
                        CellValue = CStr(row.Cells(mFilteredColumn).Value)
                        If CellValue Is Nothing Then GoTo NextRow
                        If CellValue < GridViewMenuFilterSmallerText.Text Then
                            row.Visible = True
                        Else
                            row.Visible = False
                        End If
                    End If
NextRow:
                Next


                ClearFilterText()

            End If

        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

    Private Sub UnFilter(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridViewMenuUnFilter.Click
        Try
            mFilered = False
            GridViewMenuUnFilter.Enabled = False

            For Each row As DataGridViewRow In Me.Rows
                row.Visible = True
            Next

            ClearFilterText()

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Protected Sub ClearFilterText()
        Try
            GridViewMenuFilterContainsText.Text = ""
            GridViewMenuFilterNotContainsText.Text = ""
            GridViewMenuFilterEqualText.Text = ""
            GridViewMenuFilterNotEqualText.Text = ""
            GridViewMenuFilterGreaterText.Text = ""
            GridViewMenuFilterSmallerText.Text = ""

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub
End Class
