Public Class Task

    Private mId As Integer
    Private mInternalType As Integer
    Private mType As TaskType
    Private mCreator As User
    Private mResponsibleProfile As Profile
    Private mResponsibleUser As User
    Private mAdmin As User
    Private mDetail As String

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

    Public Property Creator() As User
        Get
            Return mCreator
        End Get
        Set(ByVal value As User)
            mCreator = value
        End Set
    End Property

    Public Property ResponsibleProfile() As Profile
        Get
            Return mResponsibleProfile
        End Get
        Set(ByVal value As Profile)
            mResponsibleProfile = value
        End Set
    End Property

    Public Property ResponsibleUser() As User
        Get
            Return mResponsibleUser
        End Get
        Set(ByVal value As User)
            mResponsibleUser = value
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

    Public Property Detail() As String
        Get
            Return mDetail
        End Get
        Set(ByVal value As String)
            mDetail = value
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
        mEvents = New List(Of TaskEvent)
        mEntities = New List(Of TaskEntity)
    End Sub


End Class
