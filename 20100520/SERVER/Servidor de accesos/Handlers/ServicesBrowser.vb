Public Class ServicesBrowser


    Public Shared Function Services() As List(Of String)
        Dim List As List(Of String)
        Dim Servs() As System.ServiceProcess.ServiceController

        Try
            List = New List(Of String)

            Servs = System.ServiceProcess.ServiceController.GetServices()

            For Each Srv As System.ServiceProcess.ServiceController In Servs
                List.Add(Srv.ServiceName)
            Next

            Servs = Nothing

            Return List

        Catch ex As Exception
            Return New List(Of String)
        End Try

    End Function

End Class
