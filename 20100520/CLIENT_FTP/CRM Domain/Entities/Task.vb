Public Class Task

    Private mId As Integer
    Private mCompanyId As Integer
    Private mInternalType As Integer
    Private mType As TaskType
    Private mPriority As TaskPriority

    Private mOwner As User
    Private mUser As User
    Private mAdmin As User
    Private mUserProfile As Profile

    Private mAction As Action

    Private mDetail As String
    Private mOwnerDetail As String

    Private mState As TaskState

    Private mSystemDate As Date
    Private mInitdate As Date
    Private mInitTime As Date
    Private mFirstDate As Date
    Private mLastDate As Date

    Private mEvents As List(Of TaskEvent)
    Private mEntities As List(Of Taskentity)


    Public Property Id() As Integer
        Get
            Return mId
        End Get
        Set(ByVal value As Integer)
            mId = value
        End Set
    End Property

    Public Property CompanyId() As Integer
        Get
            Return mCompanyId
        End Get
        Set(ByVal value As Integer)
            mCompanyId = value
        End Set
    End Property


    Public Property InternalType() As Integer
        Get
            Return mInternalType
        End Get
        Set(ByVal value As Integer)
            mInternalType = value
        End Set
    End Property

    Public Property Type() As TaskType
        Get
            Return mType
        End Get
        Set(ByVal value As TaskType)
            mType = value
        End Set
    End Property

    Public Property Priority() As TaskPriority
        Get
            Return mPriority
        End Get
        Set(ByVal value As TaskPriority)
            mPriority = value
        End Set
    End Property

    Public Property State() As TaskState
        Get
            Return mState
        End Get
        Set(ByVal value As TaskState)
            mState = value
        End Set
    End Property

    Public Property Owner() As User
        Get
            Return mOwner
        End Get
        Set(ByVal value As User)
            mOwner = value
        End Set
    End Property

    Public Property UserProfile() As Profile
        Get
            Return mUserProfile
        End Get
        Set(ByVal value As Profile)
            mUserProfile = value
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


    Public Property Action() As Action
        Get
            Return mAction
        End Get
        Set(ByVal value As Action)
            mAction = value
        End Set
    End Property


    Public Property Detail() As String
        Get
            Return mDetail
        End Get
        Set(ByVal value As String)
            mDetail = value
        End Set
    End Property

    Public Property OwnerDetail() As String
        Get
            Return mOwnerDetail
        End Get
        Set(ByVal value As String)
            mOwnerDetail = value
        End Set
    End Property

    Public Property SystemDate() As Date
        Get
            Return mSystemDate
        End Get
        Set(ByVal value As Date)
            mSystemDate = value
        End Set
    End Property

    Public Property Initdate() As Date
        Get
            Return mInitdate
        End Get
        Set(ByVal value As Date)
            mInitdate = value
        End Set
    End Property

    Public Property InitTime() As Date
        Get
            Return Format(mInitTime, "hh:mm")
        End Get
        Set(ByVal value As Date)
            mInitTime = value
        End Set
    End Property

    Public Property Firstdate() As Date
        Get
            Return mFirstDate
        End Get
        Set(ByVal value As Date)
            mFirstDate = value
        End Set
    End Property

    Public Property Lastdate() As Date
        Get
            Return mLastDate
        End Get
        Set(ByVal value As Date)
            mLastDate = value
        End Set
    End Property

    Public Property Events() As List(Of TaskEvent)
        Get
            Return mEvents
        End Get
        Set(ByVal value As List(Of TaskEvent))
            mEvents = value
        End Set
    End Property


    Public Property Entities() As List(Of TaskEntity)
        Get
            Return mEntities
        End Get
        Set(ByVal value As List(Of TaskEntity))
            mEntities = value
        End Set
    End Property


    Public Sub New()
        mSystemDate = "01/01/1800"
        mInitdate = "01/01/1800"
        mInitTime = "01/01/1800"
        mFirstDate = "01/01/1800"
        mLastDate = "01/01/1800"
        mAction = New Domain.Action
        mEvents = New List(Of TaskEvent)
        mEntities = New List(Of TaskEntity)
    End Sub








    Public Class TaskType

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

    Public Class TaskPriority

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

    Public Class TaskState

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
