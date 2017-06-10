Public Class frmReportFormat


    Private Sub SelectedFormatChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListFormats.SelectedIndexChanged
        Try
            If ListFormats.SelectedItems IsNot Nothing Then
                cmdAccept.Enabled = True
            Else
                cmdAccept.Enabled = False
            End If

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub ItemSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListFormats.MouseDoubleClick
        Try
            If ListFormats.SelectedItems IsNot Nothing Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub


    Public ReadOnly Property SelectedFormat() As Integer
        Get
            If ListFormats.SelectedItems IsNot Nothing Then
                Return CInt(ListFormats.SelectedItems(0).Tag)
            Else
                Return -1
            End If
        End Get
    End Property

    Public ReadOnly Property SelectedFileType() As String
        Get
            If ListFormats.SelectedItems IsNot Nothing Then
                Return ListFormats.SelectedItems(0).SubItems(0).Text & " (" & ListFormats.SelectedItems(0).SubItems(2).Text & ")|" & ListFormats.SelectedItems(0).SubItems(2).Text
            Else
                Return ""
            End If
        End Get
    End Property


    Private Sub frmReportFormat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            ListFormats.Items(5).Remove()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub
End Class