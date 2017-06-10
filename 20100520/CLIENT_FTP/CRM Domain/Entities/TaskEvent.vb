Public Class TaskEvent

    Private mId As Integer
    Private mIdTask As Integer
    Private mType As EventType

    Private mEventDate As Date
    Private mDetail As String
    Private mUser As User

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

    Public Property Type() As EventType
        Get
            Return mType
        End Get
        Set(ByVal value As EventType)
            mType = value
        End Set
    End Property

    Public Property EventDate() As Date
        Get
            Return Format(mEventDate, "dd/MM/yyyy")
        End Get
        Set(ByVal value As Date)
            mEventDate = value
        End Set
    End Property

    Public ReadOnly Property EventTime() As Date
        Get
            Return Format(mEventDate, "hh:mm")
        End Get
    End Property


    Public Property Detail() As String
        Get
            Return mdetail
        End Get
        Set(ByVal value As String)
            mDetail = value
        End Set
    End Property

    Public Property User() As User
        Get
            Return mUser
        End Get
        Set(ByVal value As User)
            mUser = value
        End Set
    End Property

    Public Sub New()
        mType = New EventType
    End Sub


    Public Class EventType

        Private mId As Integer
        Private mName As String
        Private mDescription As String

        Public Property Id() As Integer
            Get
                Return mId
            End Get
            Set(ByVal value As Integer)
                mId = value
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

        Public Property Description() As String
            Get
                Return mDescription
            End Get
            Set(ByVal value As String)
                mDescription = value
            End Set
        End Property

    End Class

End Class
