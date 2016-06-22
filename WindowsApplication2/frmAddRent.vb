Public Class frmAddRent
    Private intRowPosition As Integer = 0
    Private Sub frmAddCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CustomerTableAdapter.Fill(Me.OrderDB2DataSet.customer)

        txtCont.Text = ""
        txtDOB.Text = ""
        txtEmail.Text = ""
        txtID.Text = ""
        txtName.Text = ""
        txtDur.Text = ""
        txtAddr.Text = ""
        txtLot.Text = ""
        txtNric.Text = ""

        intRowPosition = OrderDB2DataSet.Tables("customer").Rows.Count
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim newRow As DataRow = OrderDB2DataSet.Tables("customer").NewRow
            newRow("custID") = txtID.Text
            newRow("custName") = txtName.Text
            newRow("custContact") = txtCont.Text
            newRow("custEmail") = txtEmail.Text
            newRow("custDOB") = txtDOB.Text
            newRow("duration") = txtDur.Text
            newRow("lotNum") = txtLot.Text
            newRow("nric") = txtNric.Text
            newRow("address") = txtAddr.Text
            OrderDB2DataSet.Tables("customer").Rows.Add(newRow)
            CustomerTableAdapter.Update(Me.OrderDB2DataSet.customer)
            OrderDB2DataSet.AcceptChanges()
            MessageBox.Show("Record Saved!")
            Me.CustomerTableAdapter.Fill(Me.OrderDB2DataSet.customer)
            Me.Hide()
            frmViewRent.Show()
        Catch ex As Exception
            MessageBox.Show("Something is wrong! " + ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmLogin.Show()
    End Sub
End Class