Public Class SqlBrowser


    Public Shared Function SqlServers() As List(Of String)
        Dim List As List(Of String)
        Try
            Dim enumerator As System.Data.Sql.SqlDataSourceEnumerator = System.Data.Sql.SqlDataSourceEnumerator.Instance
            Dim servers As DataTable = enumerator.GetDataSources()

            If servers IsNot Nothing Then
                List = New List(Of String)

                For Each row As DataRow In servers.Rows

                    If row.Item("InstanceName").ToString <> "" Then List.Add(row.Item("ServerName").ToString() & "\" & row.Item("InstanceName").ToString())

                Next

                Return List

            Else

                Return Nothing

            End If

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Shared Function TestServerConnection(ByRef servername As String, ByRef user As String, ByRef password As String) As Boolean
        Try

            Return Database.TestConnection(servername, user, password)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function ServerDatabases(ByRef servername As String, ByRef user As String, ByRef password As String) As List(Of String)

        Dim Table As DataTable
        Dim List As List(Of String)

        Try

            Table = Database.Serverdatabases(servername, user, password)

            If Table Is Nothing Then Return Nothing

            List = New List(Of String)

            For Each row As DataRow In Table.Rows

                List.Add(row.Item("name"))

            Next

            Return List

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Shared Function CheckService(ByVal instance As String, ByVal machine As String) As Boolean

        Dim sc() As System.ServiceProcess.ServiceController
        Dim InstanceService As System.ServiceProcess.ServiceController = Nothing

        Try
            sc = System.ServiceProcess.ServiceController.GetServices()

            For Each service As System.ServiceProcess.ServiceController In sc
                If service.ServiceName.Contains(instance) Then
                    InstanceService = service
                    Exit For
                End If
            Next

            If InstanceService Is Nothing Then _
            Throw New Exception("No se encontró el servicio " & instance & ".")

            If InstanceService.Status <> System.ServiceProcess.ServiceControllerStatus.Running Then _
            Throw New Exception("El servicio " & instance & " no se encuentra activo.")

            Return True

        Catch ex As Exception
            Throw ex
        End Try
        


    End Function

End Class
