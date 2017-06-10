Public Class TaskEvent

    Private mEventDate As Date
    Private mDetail As String

    Public Property EventDate() As Date
        Get
            Return Format(mEventDate, "d")
        End Get
        Set(ByVal value As Date)
            mEventDate = value
        End Set
    End Property

    Public ReadOnly Property EventTime() As Date
        Get
            Return Format(mEventDate, "t")
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

End Class
