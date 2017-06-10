Public Class TaskEntity

    Private mId As Integer
    Private mIdTask As Integer
    Private mType As SystemEntity
    Private mCode As String


    Public Property Id() As Integer
        Get
            Return mId
        End Get
        Set(ByVal value As Integer)
            mId = value
        End Set
    End Property

    Public Property IdTask() As Integer
        Get
            Return mIdTask
        End Get
        Set(ByVal value As Integer)
            mIdTask = value
        End Set
    End Property

    Public Property Type() As SystemEntity
        Get
            Return mType
        End Get
        Set(ByVal value As SystemEntity)
            mType = value
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
End Class
