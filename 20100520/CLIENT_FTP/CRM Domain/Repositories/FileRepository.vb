Public Class FileRepository

    Private Shared Query As String
    Private Shared tb As DataTable


    Public Shared Function Save(ByVal Link As String, Optional ByVal Customer As String = "", Optional ByVal Task As Integer = 0) As Integer
        Dim fileinfo As System.IO.FileInfo
        Dim FileData() As Byte
        Dim ShortName As String

        Try
            fileinfo = New System.IO.FileInfo(Link)

            If Not fileinfo.Exists Then Throw New Exception("No se encuentra el archivo " & Link)

            FileData = BinaryFile(Link)

            ShortName = fileinfo.Name

            If ShortName.EndsWith(fileinfo.Extension) Then ShortName = Mid(ShortName, 1, Len(ShortName) - Len(fileinfo.Extension))

            Insert(ShortName, Replace(fileinfo.Extension, ".", ""), FileData, Customer, Task)

            Return True

        Catch ex As Exception
            Throw ex
        Finally
            fileinfo = Nothing
            FileData = Nothing
        End Try

    End Function


    Private Shared Function BinaryFile(ByVal Link As String) As Byte()
        Dim FileStream As System.IO.FileStream
        Dim Data() As Byte

        Try

            FileStream = New System.IO.FileStream(Link, IO.FileMode.Open)

            Data = New Byte(FileStream.Length) {}

            FileStream.Read(Data, 0, Convert.ToInt32(Data.Length))

            FileStream.Close()

            Return Data

        Catch ex As Exception
            Throw ex
        Finally
            FileStream = Nothing

        End Try
    End Function


    Private Shared Function Insert(ByVal Name As String, ByVal Extension As String, ByVal Data As Byte(), Optional ByVal Customer As String = "", Optional ByVal Task As Integer = 0) As Integer
        Dim FileId As Integer
        Dim Actions As List(Of Action)
        Dim Action As Action

        Try

            FileId = InsertFile(Name, Extension, Data)

            Actions = New List(Of Action)

            Action = GetActionAsignFile(Customer, Task, FileId)

            If Action Is Nothing Then Return 0

            Actions.Add(Action)

            ActionHandler.Save(Actions)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Shared Function InsertFile(ByVal Name As String, ByVal Extension As String, ByVal Data As Byte()) As Integer

        Try
            Dim FileParameters(0 To 2) As SqlClient.SqlParameter

            FileParameters(0) = New SqlClient.SqlParameter("@NAME", Name)
            FileParameters(1) = New SqlClient.SqlParameter("@EXTENSION", Extension)
            FileParameters(2) = New SqlClient.SqlParameter("@DATA", Data)

            Return Database.ExecuteSpCommand(SystemCompany.Database & ".dbo.sp_InsertFile", FileParameters)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Shared Function GetActionAsignFile(ByVal Customer As String, ByVal Task As Integer, ByVal FileId As Integer) As Action
        Dim Action As Action

        Try
            Action = New Action(MainCompany.Id, SystemUser)

            Action.ObjectType = SystemEntities(3)
            Action.sqlType = CommandType.StoredProcedure
            Action.sqlName = SystemCompany.Database & ".dbo.sp_AsignFileToCustomer"
            Action.Parameters = FileParameters(Customer, Task, FileId)
            Action.InitDate = Now()
            Action.Admin = Action.User
            Action.Status = 1

            Action.Admin = New User


            Return Action

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Shared Function FileParameters(ByVal Customer As String, ByVal Task As Integer, ByVal FileId As Integer) As SqlClient.SqlParameter()
        Dim Parameters(0 To 3) As SqlClient.SqlParameter

        Try
            Parameters(0) = New SqlClient.SqlParameter("@COMPANY", SqlDbType.Int) With {.Value = MainCompany.Id}
            Parameters(1) = New SqlClient.SqlParameter("@CUSTOMER", SqlDbType.VarChar) With {.Value = Customer}
            Parameters(2) = New SqlClient.SqlParameter("@TASK", SqlDbType.Int) With {.Value = Task}
            Parameters(3) = New SqlClient.SqlParameter("@ATTACHMENT", SqlDbType.Int) With {.Value = FileId}

            Return Parameters

        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Public Shared Function GetByCustomer(ByVal CustomerCode As String) As List(Of Attachment)
        Dim List As List(Of Attachment)
        Dim Entity As Attachment
        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("AttachByCst"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<company>", MainCompany.Id), New QueryHandler.Parameter("<customer>", CustomerCode)})

            tb = Database.GetData(Query)

            List = New List(Of Attachment)

            If tb Is Nothing Then Return List

            If tb.Rows Is Nothing Then Return List

            For Each row As DataRow In tb.Rows

                Entity = New Attachment

                Entity.Id = row.Item("ID")
                Entity.Name = row.Item("Name")
                Entity.Extension = row.Item("EXTENSION")

                If Entity IsNot Nothing Then List.Add(Entity)

            Next

            Return List

        Catch ex As Exception
            Return New List(Of Attachment)
        End Try
    End Function


    Public Shared Sub ShowFile(ByVal Id As Integer)
        Dim Data() As Byte
        Dim FileInfo As System.IO.FileInfo
        Dim FileStream As System.IO.FileStream
        Dim FileName As String
        Try

            Query = QueryHandler.FormatQuery(QueryHandler.GetQuery("AttachById"), New QueryHandler.Parameter() {New QueryHandler.Parameter("<ownerdatabase>", SystemCompany.Database), New QueryHandler.Parameter("<id>", Id)})

            tb = Database.GetData(Query)

            If tb Is Nothing Then Throw New Exception("No se encontró el archivo solicitado")

            If tb.Rows Is Nothing Then Throw New Exception("No se encontró el archivo solicitado")

            Data = tb.Rows(0).Item(1)

            FileName = (tb.Rows(0).Item(0) & "." & tb.Rows(0).Item(2))

            FileInfo = New System.IO.FileInfo(FileName)

            If FileInfo.Exists Then FileInfo.Delete()

            FileStream = New System.IO.FileStream(FileName, IO.FileMode.Create)

            FileStream.Write(Data, 0, Convert.ToInt32(Data.Length))

            FileStream.Close()

            FileInfo = New System.IO.FileInfo(FileName)

            If FileInfo.Exists Then Process.Start(FileInfo.Name)

        Catch ex As Exception
            Throw ex

        Finally
            FileInfo = Nothing
            FileStream = Nothing
        End Try
    End Sub

End Class
