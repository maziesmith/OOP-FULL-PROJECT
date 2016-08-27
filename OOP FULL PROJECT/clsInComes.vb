
Public Class clsInComes
    Private _InComeID As Integer
    Private _InComeName As String
    Private _InComeCost As Double
#Region "properties"

    Public Property InComeID As Integer
        Get
            Return _InComeID
        End Get
        Set(value As Integer)
            _InComeID = value
        End Set
    End Property

    Public Property InComeName As String
        Get
            Return _InComeName
        End Get
        Set(value As String)
            _InComeName = value
        End Set
    End Property

    Public Property InComeCost As Double
        Get
            Return _InComeCost
        End Get
        Set(value As Double)
            _InComeCost = value
        End Set
    End Property
#End Region
End Class
