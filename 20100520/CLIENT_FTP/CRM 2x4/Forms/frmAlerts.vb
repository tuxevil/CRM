Public Class frmAlerts

    Private Alerts As List(Of Domain.Alert)

    Public Sub New()
        InitializeComponent()

        Try
            Alerts = Domain.AlertRepository.GetAllAlerts(Domain.SystemUser.Id, Domain.SystemUser.Profile.Id)

            DrawMe()

        Catch ex As Exception

            Throw ex

        End Try

    End Sub

    Private Sub DrawMe()

        Try
            GridAlerts.Rows.Clear()

            For Each Alert As Domain.Alert In Alerts

                GridAlerts.Rows.Add(Alert.Id, Alert.Active, Alert.Initdate, Alert.ExecuteDate, Alert.Subject, Alert.Detail)

            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExitForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuFileExit.Click

        Try

            Me.Close()

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

    Private Sub CellChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridAlerts.CellContentClick
        Try

            If e.ColumnIndex <> 1 Then Exit Sub

            If GridAlerts.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 1 Then

                Domain.AlertRepository.DiscardAlert(GridAlerts.Rows(e.RowIndex).Cells(0).Value)

                GridAlerts.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0

            Else

                Domain.AlertRepository.RestoreAlert(GridAlerts.Rows(e.RowIndex).Cells(0).Value)

                GridAlerts.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 1

            End If



        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode

                Case Keys.Escape
                    Me.Close()

            End Select

        Catch ex As Exception
            frmError.ShowException(ex)
        End Try
    End Sub

End Class