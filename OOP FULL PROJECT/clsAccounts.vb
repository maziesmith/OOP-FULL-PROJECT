
Public Class u
    Inherits clsDbConnect
    Private _AccID As Integer
    Private _AccName As String
    Private _StartBal As Double
#Region "properties"
    Public Property AccID As Integer
        Get
            Return _AccID
        End Get
        Set(value As Integer)
            _AccID = value
        End Set
    End Property

    Public Property AccName As String
        Get
            Return _AccName
        End Get
        Set(value As String)
            _AccName = value
        End Set
    End Property

    Public Property StartBal As Double
        Get
            Return _StartBal
        End Get
        Set(value As Double)
            _StartBal = value
        End Set
    End Property
#End Region

    Public Function AllAcc()
        Return FillDataSet("Select * from tblAccounts")
    End Function

    Public Overrides Sub BindData()
        AccID = cur.Current("AccID")
        AccName = cur.Current("AccName")
        StartBal = cur.Current("StartBal")
    End Sub
    Public Sub AddRecord()
        Dim SL As New SortedList
        SL.Add("@AccID", AccID)
        SL.Add("@AccName", AccName)
        SL.Add("@StartBal", StartBal)

        add("Insert into tblAccounts values(@AccID ,@AccName ,@StartBal)", SL)
    End Sub
    Public Sub UpdateRecord()
        Dim SL As New SortedList
        SL.Add("@AccID", AccID)
        SL.Add("@AccName", AccName)
        SL.Add("@StartBal", StartBal)
        update("UPDATE tblAccounts SET AccName=@AccName ,StartBal=@StartBal WHERE AccID=@AccID", SL)
    End Sub
    Public Sub deleteRecord()
        delete("Delete from tblAccounts Where AccID=" & AccID)
    End Sub
End Class
