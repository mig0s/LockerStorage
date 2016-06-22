Public Class frmManageUser
    Private intRowPosition As Integer = 0

    Private Sub frmManageCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AccountTableAdapter1.Fill(Me.OrderDB2DataSet.account)
        ShowCurrentRecord()
    End Sub

    Private Sub ShowCurrentRecord()
        If intRowPosition >= 0 Then
            txtUsername.Text = OrderDB2DataSet.Tables("account").Rows(intRowPosition)("username").ToString()
            txtPassword.Text = OrderDB2DataSet.Tables("account").Rows(intRowPosition)("password").ToString()
            txtRole.Text = OrderDB2DataSet.Tables("account").Rows(intRowPosition)("role").ToString()
        End If
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        intRowPosition = 0
        ShowCurrentREcord()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If intRowPosition > 0 Then
            intRowPosition -= 1
            Me.ShowCurrentRecord()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If intRowPosition < (OrderDB2DataSet.Tables("account").Rows.Count - 1) Then
            intRowPosition += 1
            Me.ShowCurrentRecord()
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        intRowPosition = OrderDB2DataSet.Tables("account").Rows.Count - 1
        Me.ShowCurrentRecord()
    End Sub

    Private Sub RefreshTable()
        Me.AccountTableAdapter1.Fill(Me.OrderDB2DataSet.account)
        Me.ShowCurrentRecord()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If OrderDB2DataSet.Tables("account").Rows.Count <> 0 Then
            OrderDB2DataSet.Tables("account").Rows(intRowPosition)("username") = txtUsername.Text
            OrderDB2DataSet.Tables("account").Rows(intRowPosition)("password") = txtPassword.Text
            OrderDB2DataSet.Tables("account").Rows(intRowPosition)("role") = txtRole.Text
            AccountTableAdapter1.Update(Me.OrderDB2DataSet.account)
            OrderDB2DataSet.AcceptChanges()
            MessageBox.Show("Records Saved!")
            RefreshTable()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.AccountTableAdapter1.Fill(Me.OrderDB2DataSet.account)
        Me.ShowCurrentRecord()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If OrderDB2DataSet.Tables("account").Rows.Count <> 0 Then
            OrderDB2DataSet.Tables("account").Rows(intRowPosition).Delete()
            intRowPosition -= 1
            Me.ShowCurrentRecord()

            AccountTableAdapter1.Update(Me.OrderDB2DataSet.account)
            OrderDB2DataSet.AcceptChanges()
            MessageBox.Show("User Record Deleted!")
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmAddUser.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class