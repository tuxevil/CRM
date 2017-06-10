Public Class Licence

    Private mName As String
    Private mVersion As String
    Private mTango As String
    Private mKey As String
    Private mConnections As Integer
    Private mContactMail As String

    Public Property Name() As String
        Get
            Return mName
        End Get
        Set(ByVal value As String)
            mName = value
        End Set
    End Property

    Public Property Version() As String
        Get
            Return mVersion
        End Get
        Set(ByVal value As String)
            mVersion = value
        End Set
    End Property

    Public Property Tango() As String
        Get
            Return mTango
        End Get
        Set(ByVal value As String)
            mTango = value
        End Set
    End Property

    Public Property Key() As String
        Get
            Return mKey
        End Get
        Set(ByVal value As String)
            mKey = value
        End Set
    End Property

    Public Property Connections() As Integer
        Get
            Return mConnections
        End Get
        Set(ByVal value As Integer)
            mConnections = value
        End Set
    End Property

    Public Property ContactMail() As String
        Get
            Return mContactMail
        End Get
        Set(ByVal value As String)
            mContactMail = value
        End Set
    End Property

End Class
