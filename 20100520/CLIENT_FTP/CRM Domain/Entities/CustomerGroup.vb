Public Class CustomerGroup

    Private mId As Integer
    Private mCode As String
    Private mName As String

    Public Property Id() As Integer
        Get
            Return mId
        End Get
        Set(ByVal value As Integer)
            mId = value
        End Set
    End Property

    Public Property Code() As String
        Get
            Return mCode
        End Get
        Set(ByVal value As String)
            mCode = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return mName
        End Get
        Set(ByVal value As String)
            mName = value
        End Set
    End Property

End Class
