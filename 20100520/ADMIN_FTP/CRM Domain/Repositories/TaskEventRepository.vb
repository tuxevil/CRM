Public Class TaskEventRepository


    Public Shared Function GetByTask(ByVal IdTask As Integer) As List(Of TaskEvent)
        Dim List As List(Of TaskEvent)
        List = New List(Of TaskEvent)

        For Counter = 1 To 5
            Dim TaskEvent As TaskEvent = New TaskEvent
            TaskEvent.EventDate = Format(Now, "s")
            TaskEvent.Detail = "Detalle del evento " & Counter
            List.Add(TaskEvent)
        Next

        Return List

    End Function
End Class
