Public Class TaskTypeRepository

    Public Shared Function GetById(ByVal Id As Integer) As TaskType
        Dim TaskType As TaskType
        TaskType = New TaskType
        TaskType.Id = Id
        TaskType.Name = "TAREA TIPO " & Id

        Return TaskType

    End Function
End Class
