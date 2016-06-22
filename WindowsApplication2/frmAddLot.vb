Public Class frmAddLot
    Private intRowPosition As Integer = 0
    Private Sub frmAddLot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ItemsTableAdapter1.Fill(Me.OrderDB2DataSet.items)
        txtAvail.Text = ""
        txtCat.Text = ""
        txtDesc.Text = ""
        txtLoc.Text = ""
        txtID.Text = ""
        txtRate.Text = ""
        txtSize.Text = ""
        txtSupp.Text = ""
        intRowPosition = OrderDB2DataSet.Tables("customer").Rows.Count
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim newRow As DataRow = OrderDB2DataSet.Tables("items").NewRow
        newRow("available") = txtAvail.Text
        newRow("category") = txtCat.Text
        newRow("desc") = txtDesc.Text
        newRow("location") = txtLoc.Text
        newRow("num") = txtID.Text
        newRow("rate") = txtRate.Text
        newRow("size") = txtSize.Text
        newRow("supplier") = txtSupp.Text
        OrderDB2DataSet.Tables("items").Rows.Add(newRow)
        ItemsTableAdapter1.Update(Me.OrderDB2DataSet.items)
        OrderDB2DataSet.AcceptChanges()
        MessageBox.Show("Record Saved!")
        Me.ItemsTableAdapter1.Fill(Me.OrderDB2DataSet.items)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class