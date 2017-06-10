Public Class Profile

    Private mId As Integer
    Private mName As String
    Private mDescription As String

    Private mCustomerRealViewGeneral As Boolean
    Private mCustomerRealViewAdress As Boolean
    Private mCustomerRealViewDelivery As Boolean
    Private mCustomerRealViewTerms As Boolean
    Private mCustomerRealViewNotes As Boolean
    Private mCustomerRealViewContacts As Boolean
    Private mCustomerRealViewAttachments As Boolean
    Private mCustomerRealAdd As Boolean
    Private mCustomerRealEdit As Boolean

    Private mCustomerPotentialViewGeneral As Boolean
    Private mCustomerPotentialViewAdress As Boolean
    Private mCustomerPotentialViewDelivery As Boolean
    Private mCustomerPotentialViewTerms As Boolean
    Private mCustomerPotentialViewNotes As Boolean
    Private mCustomerPotentialViewContacts As Boolean
    Private mCustomerPotentialViewAttachments As Boolean
    Private mCustomerPotentialAdd As Boolean
    Private mCustomerPotentialEdit As Boolean

    Private mTasks As Boolean

    Private mCustomerParameters As Boolean
    Private mTaskParameters As Boolean

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

    Public Property CustomerRealViewGeneral() As Boolean
        Get
            Return mCustomerRealViewGeneral
        End Get
        Set(ByVal value As Boolean)
            mCustomerRealViewGeneral = value
        End Set
    End Property

    Public Property CustomerRealViewAdress() As Boolean
        Get
            Return mCustomerRealViewAdress
        End Get
        Set(ByVal value As Boolean)
            mCustomerRealViewAdress = value
        End Set
    End Property

    Public Property CustomerRealViewDelivery() As Boolean
        Get
            Return mCustomerRealViewDelivery
        End Get
        Set(ByVal value As Boolean)
            mCustomerRealViewDelivery = value
        End Set
    End Property

    Public Property CustomerRealViewTerms() As Boolean
        Get
            Return mCustomerRealViewTerms
        End Get
        Set(ByVal value As Boolean)
            mCustomerRealViewTerms = value
        End Set
    End Property

    Public Property CustomerRealViewNotes() As Boolean
        Get
            Return mCustomerRealViewNotes
        End Get
        Set(ByVal value As Boolean)
            mCustomerRealViewNotes = value
        End Set
    End Property

    Public Property CustomerRealViewContacts() As Boolean
        Get
            Return mCustomerRealViewContacts
        End Get
        Set(ByVal value As Boolean)
            mCustomerRealViewContacts = value
        End Set
    End Property

    Public Property CustomerRealViewAttachments() As Boolean
        Get
            Return mCustomerRealViewAttachments
        End Get
        Set(ByVal value As Boolean)
            mCustomerRealViewAttachments = value
        End Set
    End Property

    Public Property CustomerRealAdd() As Boolean
        Get
            Return mCustomerRealAdd
        End Get
        Set(ByVal value As Boolean)
            mCustomerRealAdd = value
        End Set
    End Property

    Public Property CustomerRealEdit() As Boolean
        Get
            Return mCustomerRealEdit
        End Get
        Set(ByVal value As Boolean)
            mCustomerRealEdit = value
        End Set
    End Property


    Public Property CustomerPotentialViewGeneral() As Boolean
        Get
            Return mCustomerPotentialViewGeneral
        End Get
        Set(ByVal value As Boolean)
            mCustomerPotentialViewGeneral = value
        End Set
    End Property

    Public Property CustomerPotentialViewAdress() As Boolean
        Get
            Return mCustomerPotentialViewAdress
        End Get
        Set(ByVal value As Boolean)
            mCustomerPotentialViewAdress = value
        End Set
    End Property

    Public Property CustomerPotentialViewDelivery() As Boolean
        Get
            Return mCustomerPotentialViewDelivery
        End Get
        Set(ByVal value As Boolean)
            mCustomerPotentialViewDelivery = value
        End Set
    End Property

    Public Property CustomerPotentialViewTerms() As Boolean
        Get
            Return mCustomerPotentialViewTerms
        End Get
        Set(ByVal value As Boolean)
            mCustomerPotentialViewTerms = value
        End Set
    End Property

    Public Property CustomerPotentialViewNotes() As Boolean
        Get
            Return mCustomerPotentialViewNotes
        End Get
        Set(ByVal value As Boolean)
            mCustomerPotentialViewNotes = value
        End Set
    End Property

    Public Property CustomerPotentialViewContacts() As Boolean
        Get
            Return mCustomerPotentialViewContacts
        End Get
        Set(ByVal value As Boolean)
            mCustomerPotentialViewContacts = value
        End Set
    End Property

    Public Property CustomerPotentialViewAttachments() As Boolean
        Get
            Return mCustomerPotentialViewAttachments
        End Get
        Set(ByVal value As Boolean)
            mCustomerPotentialViewAttachments = value
        End Set
    End Property

    Public Property CustomerPotentialAdd() As Boolean
        Get
            Return mCustomerPotentialAdd
        End Get
        Set(ByVal value As Boolean)
            mCustomerPotentialAdd = value
        End Set
    End Property

    Public Property CustomerPotentialEdit() As Boolean
        Get
            Return mCustomerPotentialEdit
        End Get
        Set(ByVal value As Boolean)
            mCustomerPotentialEdit = value
        End Set
    End Property

    Public Property Tasks() As Boolean
        Get
            Return mTasks
        End Get
        Set(ByVal value As Boolean)
            mTasks = value
        End Set
    End Property
    Public Property CustomerParameters() As Boolean
        Get
            Return mCustomerParameters
        End Get
        Set(ByVal value As Boolean)
            mCustomerParameters = value
        End Set
    End Property
    Public Property TaskParameters() As Boolean

        Get
            Return mTaskParameters
        End Get
        Set(ByVal value As Boolean)
            mTaskParameters = value
        End Set

    End Property
End Class
