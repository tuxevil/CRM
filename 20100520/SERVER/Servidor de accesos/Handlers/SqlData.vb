Imports System.Data
Imports System.Data.SqlClient

Public Class SqlData

    Private Connection As SqlConnection
    Private Command As SqlCommand
    Private Transaction As SqlTransaction


    Public WriteOnly Property CommandString() As String
        Set(ByVal value As String)
            Command.CommandText = value
        End Set
    End Property

    Public Sub New()
        Try
            Connection = New SqlConnection
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub New(ByVal ConnectionString As String)
        Try
            Connection = New SqlConnection
            Command = New SqlCommand()
            Command.Connection = Connection
            Connection.ConnectionString = ConnectionString

        Catch Exc As Exception
            Throw Exc
        End Try

    End Sub

    Public Function TestConnection(ByRef servername As String, ByRef user As String, ByRef password As String) As Boolean

        Dim TestCnn As SqlConnection

        Try
            TestCnn = New SqlConnection

            TestCnn.ConnectionString = "Server=" & servername & ";Database=master;User ID=" & user & ";Password=" & password & ";Trusted_Connection=False;"

            TestCnn.Open()

            TestCnn.Close()

            TestCnn = Nothing

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Serverdatabases(ByRef servername As String, ByRef user As String, ByRef password As String) As DataTable

        Dim TestCnn As SqlConnection
        Dim cmd As SqlCommand
        Dim Adapter As SqlDataAdapter
        Dim Table As DataTable

        Try

            TestCnn = New SqlConnection("Server=" & servername & ";Database=master;User ID=" & user & ";Password=" & password & ";Trusted_Connection=False;")

            cmd = New SqlCommand("SELECT * FROM SYSDATABASES", TestCnn)

            TestCnn.Open()

            Table = New DataTable

            Adapter = New SqlDataAdapter(cmd)

            Adapter.Fill(Table)

            TestCnn.Close()

            cmd = Nothing

            TestCnn = Nothing

            Return Table

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Sub OpenDb()
        Try
            Select Case Connection.State
                Case 0
                    Connection.Open()
            End Select
        Catch exc As SqlException
            Throw (New Exception("Error al intentar conectar a la base de datos." & vbCrLf & "Detail: " & exc.Message))
        End Try
    End Sub

    Public Sub CloseDb()
        Try
            Connection.Close()
        Catch exc As SqlException
            exc = Nothing
        End Try
    End Sub

    Public Function GetSpData(ByVal spName As String, Optional ByVal Parameters() As SqlParameter = Nothing) As DataTable
        Dim Adapter As SqlDataAdapter
        Dim Table As DataTable

        Try
            Command.CommandText = spName
            Command.CommandType = CommandType.StoredProcedure
            If Parameters IsNot Nothing Then
                AddParameters(Parameters)
            Else
                ClearParameters()
            End If
            Table = New DataTable
            Adapter = New SqlDataAdapter(Command)
            Adapter.Fill(Table)

            Return Table

        Catch exc As Exception
            Return Nothing

        Finally
            ClearParameters()

        End Try

    End Function

    Public Function GetData(ByVal CommandString As String) As DataTable
        Dim Adapter As SqlDataAdapter
        Dim Table As DataTable

        Try
            Command.CommandText = CommandString
            Command.CommandType = CommandType.Text

            Table = New DataTable
            Adapter = New SqlDataAdapter(Command)
            Adapter.Fill(Table)

            Return Table

        Catch exc As Exception
            Return Nothing

        Finally
            ClearParameters()

        End Try

    End Function


    Public Function ExecuteSpCommand(ByVal spName As String, Optional ByVal Parameters() As SqlParameter = Nothing) As Integer

        Dim Output As SqlParameter

        If spName = "" Then Throw New Exception("Debe especificar el nombre del procedimiento almacenado que se ejecutará")

        Try
            Command.CommandText = spName
            Command.CommandType = CommandType.StoredProcedure

            If Parameters IsNot Nothing Then
                AddParameters(Parameters)
            Else
                ClearParameters()
            End If

            Output = New SqlParameter("@Output", SqlDbType.Int)
            Output.Direction = ParameterDirection.ReturnValue

            Command.Parameters.Add(Output)

            Command.ExecuteNonQuery()

            Return Output.Value

        Catch sqlEx As SqlException
            Throw New Exception("Ocurrió un error durante la ejecución de la instrucción: " & sqlEx.Message, sqlEx.InnerException)

        Catch ex As Exception
            Throw New Exception("Ocurrió un error al intentar realizar esta operación", ex.InnerException)

        Finally
            ClearParameters()

        End Try

    End Function

    Public Function ExecuteCommand(ByVal CommandString As String) As Integer

        Try
            Command.CommandText = CommandString
            Command.CommandType = CommandType.Text
            Command.Transaction = Transaction

            Command.ExecuteNonQuery()

            Return Command.ExecuteNonQuery()

        Catch sqlEx As SqlException
            Throw New Exception("Ocurrió un error durante la ejecución de la instrucción: " & sqlEx.Message, sqlEx.InnerException)

        Catch ex As Exception
            Throw New Exception("Ocurrió un error al intentar realizar esta operación", ex.InnerException)

        Finally
            ClearParameters()

        End Try

    End Function

    Public Function BeginTrans() As Boolean
        Try
            Transaction = Connection.BeginTransaction()
            BeginTrans = True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CommitTrans() As Boolean
        Try
            If Transaction IsNot Nothing Then Transaction.Commit()
            CommitTrans = True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Rollback() As Boolean
        Try
            If Transaction IsNot Nothing Then Transaction.Rollback()
            Rollback = True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub AddParameters(ByVal mParameter() As SqlParameter)
        ClearParameters()
        Command.Parameters.AddRange(mParameter)
    End Sub

    Public Sub ClearParameters()
        Command.Parameters.Clear()
    End Sub

    Public ReadOnly Property State() As ConnectionState
        Get
            Return Connection.State
        End Get
    End Property


    Public Property CnnString() As String
        Get
            Return Connection.ConnectionString
        End Get
        Set(ByVal value As String)
            Connection.Close()
            Connection.ConnectionString = value
            Connection.Open()
        End Set
    End Property
End Class
