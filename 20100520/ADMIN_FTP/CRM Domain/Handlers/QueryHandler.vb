Public Class QueryHandler

    Public Shared Function FormatQuery(ByVal Query As String, ByVal ParamArray Parameters() As Parameter) As String

        Dim Parameter As Parameter

        Try

            For Counter = 0 To Parameters.Length - 1

                Parameter = Parameters(Counter)

                If Parameter.Name = "<database>" Then
                    Query = Replace(Query, Parameter.Name, "[" & Parameter.Value & "]")
                Else
                    Query = Replace(Query, Parameter.Name, Parameter.Value)
                End If

            Next

            Return Query

        Catch ex As Exception
            Return ""

        End Try

    End Function


    Public Shared Function GetQuery(ByVal Code As String) As String
        Dim QString As String
        Dim sResult As String

        Try

            QString = ""
            QString = QString & "SELECT STRING "
            QString = QString & "FROM " & SystemCompany.Database & ".dbo.queries "
            QString = QString & "WHERE UPPER(CODE) = '" & Code.ToUpper & "'"

            sResult = Encrypter.DecryptString(Database.GetData(QString).Rows(0).Item("STRING"))

            Return sResult

        Catch ex As Exception

            ' MsgBox(ex.Message)
            Return ""

        End Try

    End Function













    Public Class Parameter

        Private mName As String
        Private mValue As String

        Public Property Name() As String
            Get
                Return mName
            End Get
            Set(ByVal value As String)
                mName = value
            End Set
        End Property

        Public Property Value() As String
            Get
                Return mValue
            End Get
            Set(ByVal value As String)
                mValue = value
            End Set
        End Property

        Public Sub New()
        End Sub

        Public Sub New(ByVal name As String, ByVal value As String)
            mName = name
            mValue = value
        End Sub

    End Class


End Class
