Public Class Action


    Private mId As Integer
    Private mIdOwner As Integer
    Private mIdDatabase As Integer
    Private mObjectType As SystemEntity
    Private mOriginalObject As Object
    Private mFinalObject As Object
    Private mSqlType As CommandType
    Private mSqlName As String
    Private mSqlString As String
    Private mSqlParameters As String
    Private mType As ActionType
    Private mUser As User
    Private mAdmin As User
    Private mInitDate As Date
    Private mProcessDate As Date
    Private mStatus As Integer

    Private mParameters() As SqlClient.SqlParameter

    Public Property Id() As Integer
        Get
            Return mId
        End Get
        Set(ByVal value As Integer)
            mId = value
        End Set
    End Property

    Public Property IdOwner() As Integer
        Get
            Return mIdOwner
        End Get
        Set(ByVal value As Integer)
            mIdOwner = value
        End Set
    End Property

    Public Property IdDatabase() As Integer
        Get
            Return mIdDatabase
        End Get
        Set(ByVal value As Integer)
            mIdDatabase = value
        End Set
    End Property

    Public Property ObjectType() As SystemEntity
        Get
            Return mObjectType
        End Get
        Set(ByVal value As SystemEntity)
            mObjectType = value
        End Set
    End Property

    Public Property OriginalObject() As Object
        Get
            Return mOriginalObject
        End Get
        Set(ByVal value As Object)
            mOriginalObject = value
        End Set
    End Property

    Public Property FinalObject() As Object
        Get
            Return mFinalObject
        End Get
        Set(ByVal value As Object)
            mFinalObject = value
        End Set
    End Property

    Public Property sqlType() As CommandType
        Get
            Return mSqlType
        End Get
        Set(ByVal value As CommandType)
            mSqlType = value
        End Set
    End Property

    Public Property sqlName() As String
        Get
            Return mSqlName
        End Get
        Set(ByVal value As String)
            mSqlName = value
        End Set
    End Property

    Public Property SqlString() As String
        Get
            Return mSqlString
        End Get
        Set(ByVal value As String)
            mSqlString = value
        End Set
    End Property

    Public Property sqlParameters() As String
        Get
            Return mSqlParameters
        End Get
        Set(ByVal value As String)
            mSqlParameters = value
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

    Public Property Admin() As User
        Get
            Return mAdmin
        End Get
        Set(ByVal value As User)
            mAdmin = value
        End Set
    End Property

    Public Property InitDate() As Date
        Get
            Return mInitDate
        End Get
        Set(ByVal value As Date)
            mInitDate = value
        End Set
    End Property

    Public Property ProcessDate() As Date
        Get
            Return mProcessDate
        End Get
        Set(ByVal value As Date)
            mProcessDate = value
        End Set
    End Property

    Public Property Status() As Integer
        Get
            Return mStatus
        End Get
        Set(ByVal value As Integer)
            mStatus = value
        End Set
    End Property

    Public Property Type() As ActionType
        Get
            Return mType
        End Get
        Set(ByVal value As ActionType)
            mType = value
        End Set
    End Property


    Public Class ActionType

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

    Public Property Parameters() As SqlClient.SqlParameter()
        Get
            Return mParameters
        End Get
        Set(ByVal value As SqlClient.SqlParameter())
            mParameters = value
        End Set
    End Property

    Public Sub New()
        Try
            mInitDate = "01/01/1800"
            mProcessDate = "01/01/1800"
        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Public Sub New(ByVal IdDatabase As Integer, ByVal user As User)
        Try
            mIdDatabase = IdDatabase
            mUser = user
            mInitDate = "01/01/1800"
            mProcessDate = "01/01/1800"
        Catch ex As Exception
            ex = Nothing
        End Try

    End Sub

End Class
