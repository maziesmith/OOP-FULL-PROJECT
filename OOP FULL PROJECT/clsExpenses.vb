
Public Class clsExpenses
    Inherits clsDbConnect
    Private _ExpensesID As Integer
    Private _ExpensesName As String
    Private _ExpensesCost As Double
#Region "Properties"
    Public Property ExpensesID As Integer
        Get
            Return _ExpensesID
        End Get
        Set(value As Integer)
            _ExpensesID = value
        End Set
    End Property

    Public Property ExpensesName As String
        Get
            Return _ExpensesName
        End Get
        Set(value As String)
            _ExpensesName = value
        End Set
    End Property

    Public Property ExpensesCost As Double
        Get
            Return _ExpensesCost
        End Get
        Set(value As Double)
            _ExpensesCost = value
        End Set
    End Property
#End Region

    Public Function AllExp()
        Return FillDataSet("Select * from tblExpenses")
    End Function

    Public Overrides Sub BindData()
        If cur.Count > 0 Then
            ExpensesID = cur.Current("ExpensesID")
            ExpensesName = cur.Current("ExpensesName")
            ExpensesCost = cur.Current("ExpensesCost")
        End If
        
    End Sub

    Public Sub AddRecord()
        Dim SL As New SortedList
        SL.Add("@ExpensesID", ExpensesID)
        SL.Add("@ExpensesName", ExpensesName)
        SL.Add("@ExpensesCost", ExpensesCost)

        add("Insert into tblExpenses values(@ExpensesID ,@ExpensesName ,@ExpensesCost)", SL)
    End Sub
    Public Sub UpdateRecord()
        Dim SL As New SortedList
        SL.Add("@ExpensesID", ExpensesID)
        SL.Add("@ExpensesName", ExpensesName)
        SL.Add("@StartBal", ExpensesCost)
        update("UPDATE tblExpenses SET ExpensesName=@ExpensesName ,ExpensesCost=@ExpensesCost WHERE ExpensesID=@ExpensesID", SL)
    End Sub
    Public Sub deleteRecord()
        delete("Delete from tblExpenses Where ExpensesID=" & ExpensesID)
    End Sub

End Class
