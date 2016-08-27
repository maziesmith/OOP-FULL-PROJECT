Public Class frmOOP
    Dim acc As New u

    Private Sub SendData()
        acc.AccID = txtAccID.Text
        acc.AccName = txtAccName.Text
        acc.StartBal = txtStarBal.Text

    End Sub
    Private Sub BindText()
        acc.BindData()
        txtAccID.Text = acc.AccID
        txtAccName.Text = acc.AccName
        txtStarBal.Text = acc.StartBal

    End Sub

    Private Sub frmOOP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        acc.frm = Me

        grdAccounts.DataSource = acc.AllAcc
        txtPosition.Text = acc.ShowPosition

        BindText()
    End Sub

    
    Private Sub grdAccounts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdAccounts.CellClick
        txtPosition.Text = acc.ShowPosition
        BindText()
    End Sub

    
    Private Sub btnNew_Click_1(sender As Object, e As EventArgs) Handles btnNew.Click
        acc.Clear()
        txtPosition.BackColor = Color.White
    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        SendData()
        acc.AddRecord()
        acc.save()
        frmOOP_Load(Nothing, Nothing)
    End Sub

    Private Sub btnEdit_Click_1(sender As Object, e As EventArgs) Handles btnEdit.Click
        SendData()
        acc.UpdateRecord()
        frmOOP_Load(Nothing, Nothing)
    End Sub

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("are you sure", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SendData()
            acc.deleteRecord()
            frmOOP_Load(Nothing, Nothing)
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnMoveFirst_Click_1(sender As Object, e As EventArgs) Handles btnMoveFirst.Click
        acc.MoveFirst()
        txtPosition.Text = acc.ShowPosition
        BindText()
    End Sub

    Private Sub btnMovePre_Click_1(sender As Object, e As EventArgs) Handles btnMovePre.Click
        acc.MovePre()
        txtPosition.Text = acc.ShowPosition
        BindText()
    End Sub

    Private Sub btnMoveNext_Click_1(sender As Object, e As EventArgs) Handles btnMoveNext.Click
        acc.MoveNext()
        txtPosition.Text = acc.ShowPosition
        BindText()
    End Sub

    Private Sub btnMoveEnd_Click_1(sender As Object, e As EventArgs) Handles btnMoveEnd.Click
        acc.MoveLast()
        txtPosition.Text = acc.ShowPosition
        BindText()
    End Sub

    Private Sub ToolStripTextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp

        acc.SearchGRD(grdAccounts, txtSearch.Text)
    End Sub

    Private Sub txtPosition_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPosition.KeyUp

    End Sub
End Class