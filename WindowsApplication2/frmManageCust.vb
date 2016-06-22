Public Class frmManageCust
    Private intRowPosition As Integer = 0

    Private Sub frmManageCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CustomerTableAdapter.Fill(Me.OrderDB2DataSet.customer)
        ShowCurrentRecord()
    End Sub

    Private Sub ShowCurrentRecord()
        If intRowPosition >= 0 Then
            txtID.Text = OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("custID").ToString()
            txtName.Text = OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("custName").ToString()
            txtCont.Text = OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("custContact").ToString()
            txtEmail.Text = OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("custEmail").ToString()
            txtDOB.Text = Format(OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("custDOB"), "dd-MMM-yyyy")
            txtDur.Text = OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("duration").ToString()
            txtLot.Text = OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("lotNum").ToString()
            txtNric.Text = OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("nric").ToString()
            txtAddr.Text = OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("address").ToString()
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
        If intRowPosition < (OrderDB2DataSet.Tables("customer").Rows.Count - 1) Then
            intRowPosition += 1
            Me.ShowCurrentRecord()
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        intRowPosition = OrderDB2DataSet.Tables("customer").Rows.Count - 1
        Me.ShowCurrentRecord()
    End Sub

    Private Sub RefreshTable()
        Me.CustomerTableAdapter.Fill(Me.OrderDB2DataSet.customer)
        Me.ShowCurrentRecord()
    End Sub
    
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If OrderDB2DataSet.Tables("customer").Rows.Count <> 0 Then
            OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("custID") = txtID.Text
            OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("custName") = txtName.Text
            OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("custContact") = txtCont.Text
            OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("custEmail") = txtEmail.Text
            OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("custDOB") = txtDOB.Text
            OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("duration") = txtDur.Text
            OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("lotNum") = txtLot.Text
            OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("nric") = txtNric.Text
            OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("address") = txtAddr.Text
            CustomerTableAdapter.Update(Me.OrderDB2DataSet.customer)
            OrderDB2DataSet.AcceptChanges()
            MessageBox.Show("Records Saved!")
            RefreshTable()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.CustomerTableAdapter.Fill(Me.OrderDB2DataSet.customer)
        Me.ShowCurrentRecord()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If OrderDB2DataSet.Tables("customer").Rows.Count <> 0 Then
            OrderDB2DataSet.Tables("customer").Rows(intRowPosition).Delete()
            intRowPosition -= 1
            Me.ShowCurrentRecord()

            CustomerTableAdapter.Update(Me.OrderDB2DataSet.customer)
            OrderDB2DataSet.AcceptChanges()
            MessageBox.Show("Customer Record Deleted!")
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmAddCust.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class