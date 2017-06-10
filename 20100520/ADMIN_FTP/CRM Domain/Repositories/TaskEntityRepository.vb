Public Class TaskEntityRepository


    Public Shared Function GetByTask(ByVal IdTask As Integer) As List(Of TaskEntity)
        Dim List As List(Of TaskEntity)
        Dim TaskEntity As TaskEntity

        List = New List(Of TaskEntity)

        TaskEntity = New TaskEntity
        TaskEntity.IdTask = IdTask
        TaskEntity.Type = SystemEntities("1")
        TaskEntity.Code = "010001"
        List.Add(TaskEntity)

        TaskEntity = New TaskEntity
        TaskEntity.IdTask = IdTask
        TaskEntity.Type = SystemEntities(2)
        TaskEntity.Code = 1
        List.Add(TaskEntity)

        Return List

    End Function

End Class
