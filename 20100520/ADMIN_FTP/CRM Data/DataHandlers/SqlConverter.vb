Public Class SqlConverter

    Public Shared Function ConvertToDecimal(ByVal expression As Double) As String
        Dim sExpression As String

        Try
            sExpression = CStr(expression)
            sExpression = Replace(sExpression, ",", ".", , , CompareMethod.Text)

            Return sExpression

        Catch ex As Exception
            Return 0

        End Try

    End Function

End Class
