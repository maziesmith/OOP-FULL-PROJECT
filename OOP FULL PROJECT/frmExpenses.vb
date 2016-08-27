Public Class frmExpenses
    Dim exp As New clsExpenses

    Private Sub SendData()
        exp.ExpensesID = txtExpID.Text
        exp.ExpensesName = txtExpName.Text
        exp.ExpensesCost = txtExpCost.Text

    End Sub
    Private Sub BindText()
        exp.BindData()
        txtExpID.Text = exp.ExpensesID
        txtExpName.Text = exp.ExpensesName
        txtExpCost.Text = exp.ExpensesCost

    End Sub

    Private Sub frmExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        exp.frm = Me
        grdExp.DataSource = exp.AllExp
        txtPosition.Text = exp.ShowPosition
        BindText()
    End Sub
    Private Sub Format()
        Dim Columns() As String = {"ExpensesID", "ExpensesName", "ExpensesCost"}
        Dim Values() As String = {"الكود", "اسم الحساب", "رصيد البداية"}
      
    End Sub

    Private Sub grdExp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdExp.CellClick
        txtPosition.Text = exp.ShowPosition

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        exp.Clear()
        txtPosition.BackColor = Color.White
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        SendData()
        exp.AddRecord()
        exp.save()
        frmExpenses_Load(Nothing, Nothing)

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        SendData()
        exp.UpdateRecord()
        frmExpenses_Load(Nothing, Nothing)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("are you sure", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SendData()
            exp.deleteRecord()
            frmExpenses_Load(Nothing, Nothing)
        End If


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnMoveFirst_Click(sender As Object, e As EventArgs) Handles btnMoveFirst.Click
        exp.MoveFirst()
        txtPosition.Text = exp.ShowPosition
        BindText()
    End Sub

    Private Sub btnMovePre_Click(sender As Object, e As EventArgs) Handles btnMovePre.Click
        exp.MovePre()
        txtPosition.Text = exp.ShowPosition
        BindText()
    End Sub

    Private Sub btnMoveNext_Click(sender As Object, e As EventArgs) Handles btnMoveNext.Click
        exp.MoveNext()
        txtPosition.Text = exp.ShowPosition
        BindText()
    End Sub

    Private Sub btnMoveEnd_Click(sender As Object, e As EventArgs) Handles btnMoveEnd.Click
        exp.MoveLast()
        txtPosition.Text = exp.ShowPosition
        BindText()

    End Sub

    Private Sub txtPosition_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPosition.KeyUp
        exp.SearchGRD(grdExp, txtSearch.Text)
    End Sub
End Class