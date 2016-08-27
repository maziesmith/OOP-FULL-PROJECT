
Public Class clsInComeMoves
    Private _InComeMoveID As Integer
    Private _InComeDate As Date
    Private _AccID As Integer
    Private _SubTotal As Double
    Private _State As Integer
    Private _InComeDet As DataView

    Public Property InComeMoveID As Integer
        Get
            Return _InComeMoveID
        End Get
        Set(value As Integer)
            _InComeMoveID = value
        End Set
    End Property

    Public Property InComeDate As Date
        Get
            Return _InComeDate
        End Get
        Set(value As Date)
            _InComeDate = value
        End Set
    End Property

    Public Property AccID As Integer
        Get
            Return _AccID
        End Get
        Set(value As Integer)
            _AccID = value
        End Set
    End Property

    Public Property SubTotal As Double
        Get
            Return _SubTotal
        End Get
        Set(value As Double)
            _SubTotal = value
        End Set
    End Property

    Public Property State As String
        Get
            Return _State
        End Get
        Set(value As String)
            _State = value
        End Set
    End Property

    Public Property InComeDet As DataView
        Get
            Return _InComeDet
        End Get
        Set(value As DataView)
            _InComeDet = value
        End Set
    End Property

End Class
