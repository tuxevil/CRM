Public Class frmExportWord

    Private PanelIndex As Integer

    Private Panels As List(Of Panel)


    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Panels = New List(Of Panel)
            Panels.Add(pnl1)
            Panels.Add(pnl4)

            DrawMe()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub DrawMe()
        Dim pnl As Panel

        Try
            pnlMain.Controls.Clear()

            pnl = Panels(PanelIndex)

            pnlMain.Controls.Add(pnl)

            pnl.Dock = DockStyle.Fill

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub cmdPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrevious.Click
        Try
            If PanelIndex > 0 Then
                PanelIndex = PanelIndex - 1
                DrawMe()
            End If

            cmdPrevious.Enabled = PanelIndex > 0

            If PanelIndex < Panels.Count - 1 Then
                cmdNext.Text = "&Siguiente >"
            Else
                cmdNext.Text = "&Terminar"
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        Try

            If Not ValidatePanel() Then Exit Sub

            If PanelIndex < Panels.Count - 1 Then
                PanelIndex = PanelIndex + 1
                DrawMe()
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

            cmdPrevious.Enabled = PanelIndex > 0

            If PanelIndex < Panels.Count - 1 Then
                cmdNext.Text = "&Siguiente >"
            Else
                cmdNext.Text = "&Terminar"
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Try
            Me.Close()
        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Function ValidatePanel() As Boolean
        Dim fileInfo As System.IO.FileInfo

        Try
            Select Case pnlMain.Controls(0).Name

                Case "pnl1"
                    Return True

                Case "pnl2"

                Case "pnl3"

                Case "pnl4"
                    If Not pnl4chkSaveFile.Checked Then Return True

                    If pnl4txtFile.Text = "" Then
                        MsgBox("Debe seleccionar un archivo", MsgBoxStyle.Information, "Atención")
                        Return False
                    End If

                    fileInfo = New System.IO.FileInfo(pnl4txtFile.Text)

                    If fileInfo.Extension <> ".doc" Then
                        MsgBox("El archivo seleccionado no es un documento de Microsoft Word", MsgBoxStyle.Information, "Atención")
                        Return False
                    End If

                    Return True


                Case "pnl5"
                    Return True

            End Select

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub BrowseFiles(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnl4cmdBrowse.Click
        Dim Browser As SaveFileDialog
        Try

            Browser = New SaveFileDialog
            Browser.Filter = "Archivos de Microsoft Word (*.doc)|*.doc"

            If Browser.ShowDialog() = Windows.Forms.DialogResult.OK Then pnl4txtFile.Text = Browser.FileName

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub pnl4chkSaveFile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnl4chkSaveFile.CheckedChanged
        Try
            pnl4txtFile.Enabled = pnl4chkSaveFile.Checked
            pnl4cmdBrowse.Enabled = pnl4chkSaveFile.Checked

            If Not pnl4chkSaveFile.Checked Then
                Panels.Remove(pnl5)
                cmdNext.Text = "&Terminar"
            Else
                If Not Panels.Contains(pnl5) Then Panels.Add(pnl5)
                cmdNext.Text = "&Siguiente >"
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Public ReadOnly Property SaveAsFile() As String
        Get
            Return pnl4txtFile.Text
        End Get
    End Property

    Public ReadOnly Property RunApplication() As Boolean
        Get
            If pnl4txtFile.Text = "" Then
                Return True
            Else
                Return pnl5chkOpenFile.Checked
            End If
        End Get
    End Property

End Class