Imports System.Data
Imports System.Data.SqlClient
Public Class clsDbConnect
    Implements Interface1

    Private conn As New SqlConnection("Data Source=.; Initial Catalog=Expenses; Integrated Security=true;")
    Private ds As New DataSet
    Private da As New SqlDataAdapter
    Private dv As New DataView
    Protected cur As CurrencyManager
    Private cmd As New SqlCommand
    Public frm As Form

    Sub New()
        Try
            conn = New SqlConnection("Data Source=.; Initial Catalog=Expenses; Integrated Security=true;")
            conn.Open()

        Catch ex As SqlException
            MsgBox(ex.Message)
            End
        Finally
            conn.Close()
        End Try
    End Sub
    Public Function FillDataSet(SQL As String) As DataView
        Try
            ds = New DataSet
            da = New SqlDataAdapter(SQL, conn)
            da.Fill(ds, 0)
            dv = New DataView(ds.Tables(0))
            cur = CType(frm.BindingContext(dv), CurrencyManager)


        Catch ex As Exception

        End Try
        Return dv
    End Function

    Public Function ShowPosition() As String
        If cur.Count > 0 Then
            Return cur.Position + 1 & "من" & cur.Count
        Else : Return ""
        End If

    End Function

    Public Sub MoveLast()
        cur.Position = cur.Count - 1
        ShowPosition()
    End Sub

    Public Sub MovePre()
        cur.Position -= 1
        ShowPosition()
    End Sub

    Public Sub MoveNext()
        cur.Position += 1
        ShowPosition()
    End Sub

    Public Sub MoveFirst()
        cur.Position = 0
        ShowPosition()
    End Sub

    Public Function Clear()
        For Each ctrl As Control In frm.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
                ctrl.BackColor = Color.LightCyan

            End If

        Next
        Return "add new"
    End Function
    Public Sub save()
        For Each ctrl As Control In frm.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
                ctrl.BackColor = Color.White

            End If

        Next

    End Sub

    Public Sub FormatGRD(Columns() As String, VALUES() As String, grd As DataGridView)
        For i As Integer = 0 To Columns.Count - 1
            grd.Columns(i).HeaderText = VALUES(i)
        Next
    End Sub

    Public Overridable Sub BindData()

    End Sub

    
    Public Function add(SQL As String, SL As SortedList) As String Implements Interface1.add
        Try
            cmd = New SqlCommand(SQL, conn)
            For i As Integer = 0 To SL.Count - 1
                cmd.Parameters.AddWithValue(SL.GetKey(i).ToString, SL.GetByIndex(i).ToString)
            Next
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            Return "complete"
        Catch ex As SqlException
            Return (ex.Message)

        End Try
    End Function

    Public Function delete(SQL As String) As String Implements Interface1.delete
        Try
            cmd = New SqlCommand(SQL, conn)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            Return "complete"
        Catch ex As SqlException
            Return (ex.Message)

        End Try

    End Function

    Public Function update(SQL As String, SL As SortedList) As String Implements Interface1.update
        Try
            cmd = New SqlCommand(SQL, conn)
            For i As Integer = 0 To SL.Count - 1
                cmd.Parameters.AddWithValue(SL.GetKey(i).ToString, SL.GetByIndex(i).ToString)
            Next
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            Return "complete"
        Catch ex As SqlException
            Return (ex.Message)

        End Try

    End Function

    Public Sub SearchGRD(grd As DataGridView, txtSearch As String)


        For i As Integer = 0 To grd.RowCount - 2
            If grd.Rows(i).Cells(1).Value.ToString.Contains(txtSearch) Then
                grd.ClearSelection()
                grd.Rows(i).Selected = True
            End If
        Next
    End Sub
End Class
