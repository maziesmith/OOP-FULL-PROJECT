Public Class clsOOP
    Private _AccID As Integer
    Private _AccName As String
    Private _StarBal As Integer

    Public Property AccID As Integer
        Get
            Return _AccID
        End Get
        Set(value As Integer)
            value = _AccID
        End Set
    End Property

    Public Property AccName As String
        Get
            Return Nothing
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property StarBal As Double
        Get
            Return Nothing
        End Get
        Set(value As Double)
        End Set
    End Property
End Class
