Imports System.Data
Imports System.Data.SqlClient
Public Class frmAcc
    Dim Conn As New SqlConnection("Data Source=.; Initial Catalog=Expenses; Integrated Security=true;")
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Dim dv As New DataView
    Dim Cur As CurrencyManager
    Dim cmd As New SqlCommand

    Sub ss()
        Try
            ds = New DataSet
            da = New SqlDataAdapter("Select * from tblAccounts", Conn)
            da.Fill(ds, "tblAccounts")

            dv = New DataView(ds.Tables("tblAccounts"))

            grdAccounts.DataSource = dv

            txtAccID.DataBindings.Add("Text", dv, "AccID")
            txtAccName.DataBindings.Add("Text", dv, "AccName")
            txtStarBal.DataBindings.Add("Text", dv, "StartBal")
            Cur = CType(Me.BindingContext(dv), CurrencyManager)
            ShowPosition()
            grdAccounts.Columns(0).HeaderText = "كود الحساب"
            grdAccounts.Columns(1).HeaderText = "اسم الحساب"
            grdAccounts.Columns(2).HeaderText = "الرصيد"


        Catch
        End Try
    End Sub

    Private Sub frmAcc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ss()
    End Sub

    Private Sub btnMovePre_Click(sender As Object, e As EventArgs) Handles btnMovePre.Click
        Cur.Position -= 1
        ShowPosition()
    End Sub

    Private Sub btnMoveFirst_Click(sender As Object, e As EventArgs) Handles btnMoveFirst.Click
        Cur.Position = 0
        ShowPosition()
    End Sub

    Private Sub btnMoveNext_Click(sender As Object, e As EventArgs) Handles btnMoveNext.Click
        Cur.Position += 1
        ShowPosition()
    End Sub

    Private Sub btnMoveEnd_Click(sender As Object, e As EventArgs) Handles btnMoveEnd.Click
        Cur.Position = Cur.Count - 1
        ShowPosition()
    End Sub
    Sub ShowPosition()
        txtPosition.Text = Cur.Position + 1 & "من" & Cur.Count
    End Sub

    Private Sub grdAccounts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdAccounts.CellClick
        ShowPosition()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
                ctrl.BackColor = Color.GreenYellow

            End If
            txtPosition.Text = "add new"
        Next

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        cmd = New SqlCommand("Insert into tblAccounts values(@AccID ,@AccName ,@StartBal)", Conn)
        With cmd.Parameters
            .AddWithValue("@AccID", txtAccID.Text).DbType = DbType.Int32
            .AddWithValue("@AccName", txtAccName.Text).DbType = DbType.String
            .AddWithValue("@StartBal", txtStarBal.Text).DbType = DbType.Double

        End With
        Conn.Open()
        cmd.ExecuteNonQuery()
        Conn.Close()
        ss()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        cmd = New SqlCommand("UPDATE tblAccounts SET AccName=@AccName ,StartBal=@StartBal WHERE AccID=@AccID", Conn)
        With cmd.Parameters
            .AddWithValue("@AccName", txtAccName.Text).DbType = DbType.String
            .AddWithValue("@StartBal", txtStarBal.Text).DbType = DbType.Double
            .AddWithValue("@AccID", txtAccID.Text).DbType = DbType.Int32

        End With
        Conn.Open()
        cmd.ExecuteNonQuery()
        Conn.Close()
        ss()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        cmd = New SqlCommand("Delete from tblAccounts Where AccID=" & txtAccID.Text, Conn)
        Conn.Open()
        cmd.ExecuteNonQuery()
        Conn.Close()
        ss()

    End Sub

    Private Sub grdAccounts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdAccounts.CellContentClick

    End Sub

    Private Sub txtPosition_TextChanged(sender As Object, e As EventArgs) Handles txtPosition.TextChanged

    End Sub
End Class