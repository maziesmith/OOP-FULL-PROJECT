
Public Class clsExpMoves
    Private _ExpMoveID As Integer
    Private _ExpDate As Date
    Private _AccID As Integer
    Private _State As String
    Private _ExpDet As DataView
    Private _SubTotal As Double

    Public Property ExpMoveID As Integer
        Get
            Return _ExpMoveID
        End Get
        Set(value As Integer)
            _ExpMoveID = value
        End Set
    End Property

    Public Property ExpDate As Date
        Get
            Return _ExpDate
        End Get
        Set(value As Date)
            _ExpDate = value
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

    Public Property ExpDet As DataView
        Get
            Return _ExpDet
        End Get
        Set(value As DataView)
            _ExpDet = value
        End Set
    End Property

End Class
