Public Class frmCustomersDeleted

    Private CustomersDeleted As DataTable


    Public Sub New()
        InitializeComponent()

        Try
            CustomersDeleted = Domain.CustomerRepository.CustomersDeletedToConfirm()

            DrawMe()

        Catch ex As Exception

            Throw ex

        End Try

    End Sub

    Private Sub DrawMe()

        Try
            GridCustomers.Rows.Clear()

            If CustomersDeleted Is Nothing Then Exit Sub

            For Each row As DataRow In CustomersDeleted.Rows

                GridCustomers.Rows.Add(False, row.Item(0), row.Item(1), row.Item(2), row.Item(3), row.Item(4), row.Item(5))

            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class