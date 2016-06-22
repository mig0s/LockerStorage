Public Class frmAddUser
    Private intRowPosition As Integer = 0
    Private Sub frmAddCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AccountTableAdapter1.Fill(Me.OrderDB2DataSet.account)

        txtRole.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""

        intRowPosition = OrderDB2DataSet.Tables("account").Rows.Count
    End Sub
    Private Sub ShowCurrentRecord()
        If intRowPosition >= 0 Then
            txtUsername.Text = OrderDB2DataSet.Tables("account").Rows(intRowPosition)("username").ToString()
            txtPassword.Text = OrderDB2DataSet.Tables("account").Rows(intRowPosition)("password").ToString()
            txtRole.Text = OrderDB2DataSet.Tables("account").Rows(intRowPosition)("role").ToString()
        End If
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim newRow As DataRow = OrderDB2DataSet.Tables("account").NewRow
        newRow("username") = txtUsername.Text
        newRow("password") = txtPassword.Text
        newRow("role") = txtRole.Text
        OrderDB2DataSet.Tables("account").Rows.Add(newRow)
        AccountTableAdapter1.Update(Me.OrderDB2DataSet.account)
        OrderDB2DataSet.AcceptChanges()
        MessageBox.Show("Record Saved!")
        Me.AccountTableAdapter1.Fill(Me.OrderDB2DataSet.account)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class