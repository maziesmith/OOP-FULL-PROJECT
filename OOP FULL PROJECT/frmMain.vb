Public Class frmMain

    Private Sub الحساباتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الحساباتToolStripMenuItem.Click
        frmOOP.Show()
        frmOOP.MdiParent = Me

    End Sub

    Private Sub البياناتالاساسيةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles البياناتالاساسيةToolStripMenuItem.Click

    End Sub

    Private Sub frmMain_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        MsgBox("dd")

    End Sub

    Private Sub جهاتالصرفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles جهاتالصرفToolStripMenuItem.Click
        frmExpenses.Show()
        frmExpenses.MdiParent = Me

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmBack.Show()
        frmBack.MdiParent = Me
    End Sub
End Class