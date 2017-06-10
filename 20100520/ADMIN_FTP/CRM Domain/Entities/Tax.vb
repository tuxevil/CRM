Public Class Tax

    Private mCode As String
    Private mName As String
    Private mAmount As Double
    Private mPercent As Double

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

    Public Property Amount() As Double
        Get
            Return mAmount
        End Get
        Set(ByVal value As Double)
            mAmount = value
        End Set
    End Property

    Public Property Percent() As Double
        Get
            Return mPercent
        End Get
        Set(ByVal value As Double)
            mPercent = value
        End Set
    End Property

End Class
