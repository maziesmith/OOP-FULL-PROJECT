<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grdAccounts = New System.Windows.Forms.DataGridView()
        Me.btnMovePre = New System.Windows.Forms.Button()
        Me.btnMoveNext = New System.Windows.Forms.Button()
        Me.btnMoveFirst = New System.Windows.Forms.Button()
        Me.btnMoveEnd = New System.Windows.Forms.Button()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.txtAccID = New System.Windows.Forms.TextBox()
        Me.txtAccName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStarBal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.grdAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdAccounts
        '
        Me.grdAccounts.AllowUserToAddRows = False
        Me.grdAccounts.AllowUserToDeleteRows = False
        Me.grdAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdAccounts.Location = New System.Drawing.Point(12, 172)
        Me.grdAccounts.Name = "grdAccounts"
        Me.grdAccounts.ReadOnly = True
        Me.grdAccounts.Size = New System.Drawing.Size(513, 221)
        Me.grdAccounts.TabIndex = 0
        '
        'btnMovePre
        '
        Me.btnMovePre.Location = New System.Drawing.Point(370, 42)
        Me.btnMovePre.Name = "btnMovePre"
        Me.btnMovePre.Size = New System.Drawing.Size(75, 23)
        Me.btnMovePre.TabIndex = 1
        Me.btnMovePre.Text = "<"
        Me.btnMovePre.UseVisualStyleBackColor = True
        '
        'btnMoveNext
        '
        Me.btnMoveNext.Location = New System.Drawing.Point(102, 40)
        Me.btnMoveNext.Name = "btnMoveNext"
        Me.btnMoveNext.Size = New System.Drawing.Size(75, 23)
        Me.btnMoveNext.TabIndex = 2
        Me.btnMoveNext.Text = ">"
        Me.btnMoveNext.UseVisualStyleBackColor = True
        '
        'btnMoveFirst
        '
        Me.btnMoveFirst.Location = New System.Drawing.Point(451, 42)
        Me.btnMoveFirst.Name = "btnMoveFirst"
        Me.btnMoveFirst.Size = New System.Drawing.Size(75, 23)
        Me.btnMoveFirst.TabIndex = 3
        Me.btnMoveFirst.Text = "<<"
        Me.btnMoveFirst.UseVisualStyleBackColor = True
        '
        'btnMoveEnd
        '
        Me.btnMoveEnd.Location = New System.Drawing.Point(21, 39)
        Me.btnMoveEnd.Name = "btnMoveEnd"
        Me.btnMoveEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnMoveEnd.TabIndex = 4
        Me.btnMoveEnd.Text = ">>"
        Me.btnMoveEnd.UseVisualStyleBackColor = True
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(198, 42)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(161, 20)
        Me.txtPosition.TabIndex = 5
        Me.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(476, 76)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(31, 13)
        Me.label.TabIndex = 6
        Me.label.Text = "الكود"
        '
        'txtAccID
        '
        Me.txtAccID.Location = New System.Drawing.Point(308, 73)
        Me.txtAccID.Name = "txtAccID"
        Me.txtAccID.Size = New System.Drawing.Size(142, 20)
        Me.txtAccID.TabIndex = 7
        '
        'txtAccName
        '
        Me.txtAccName.Location = New System.Drawing.Point(308, 110)
        Me.txtAccName.Name = "txtAccName"
        Me.txtAccName.Size = New System.Drawing.Size(142, 20)
        Me.txtAccName.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(476, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "الاسم"
        '
        'txtStarBal
        '
        Me.txtStarBal.Location = New System.Drawing.Point(308, 136)
        Me.txtStarBal.Name = "txtStarBal"
        Me.txtStarBal.Size = New System.Drawing.Size(142, 20)
        Me.txtStarBal.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(476, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "الرصيد"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(198, 12)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(447, 13)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 14
        Me.btnNew.Text = "سجل جديد"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(279, 13)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "تعديل"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(366, 13)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "إضافة"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmAcc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 395)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtStarBal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAccName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAccID)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.btnMoveEnd)
        Me.Controls.Add(Me.btnMoveFirst)
        Me.Controls.Add(Me.btnMoveNext)
        Me.Controls.Add(Me.btnMovePre)
        Me.Controls.Add(Me.grdAccounts)
        Me.Name = "frmAcc"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "الحسابات"
        CType(Me.grdAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdAccounts As System.Windows.Forms.DataGridView
    Friend WithEvents btnMovePre As System.Windows.Forms.Button
    Friend WithEvents btnMoveNext As System.Windows.Forms.Button
    Friend WithEvents btnMoveFirst As System.Windows.Forms.Button
    Friend WithEvents btnMoveEnd As System.Windows.Forms.Button
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents txtAccID As System.Windows.Forms.TextBox
    Friend WithEvents txtAccName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtStarBal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
End Class
