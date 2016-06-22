Public Class frmManageLots
    Private intRowPosition As Integer = 0

    Private Sub frmManageCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ItemsTableAdapter1.Fill(Me.OrderDB2DataSet.items)
        ShowCurrentRecord()
    End Sub

    Private Sub ShowCurrentRecord()
        If intRowPosition >= 0 Then
            txtAvail.Text = orderDB2DataSet.Tables("items").Rows(intRowPosition)("available").ToString()
            txtCat.Text = orderDB2DataSet.Tables("items").Rows(intRowPosition)("category").ToString()
            txtDesc.Text = orderDB2DataSet.Tables("items").Rows(intRowPosition)("desc").ToString()
            txtLoc.Text = orderDB2DataSet.Tables("items").Rows(intRowPosition)("location").ToString()
            txtID.Text = orderDB2DataSet.Tables("items").Rows(intRowPosition)("num").ToString()
            txtRate.Text = orderDB2DataSet.Tables("items").Rows(intRowPosition)("rate").ToString()
            txtSize.Text = orderDB2DataSet.Tables("items").Rows(intRowPosition)("size").ToString()
            txtSupp.Text = orderDB2DataSet.Tables("items").Rows(intRowPosition)("supplier").ToString()
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
        If intRowPosition < (OrderDB2DataSet.Tables("items").Rows.Count - 1) Then
            intRowPosition += 1
            Me.ShowCurrentRecord()
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        intRowPosition = OrderDB2DataSet.Tables("items").Rows.Count - 1
        Me.ShowCurrentRecord()
    End Sub

    Private Sub RefreshTable()
        Me.ItemsTableAdapter1.Fill(Me.OrderDB2DataSet.items)
        Me.ShowCurrentRecord()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If OrderDB2DataSet.Tables("items").Rows.Count <> 0 Then
            OrderDB2DataSet.Tables("items").Rows(intRowPosition)("available") = txtAvail.Text
            OrderDB2DataSet.Tables("items").Rows(intRowPosition)("category") = txtCat.Text
            OrderDB2DataSet.Tables("items").Rows(intRowPosition)("desc") = txtDesc.Text
            OrderDB2DataSet.Tables("items").Rows(intRowPosition)("location") = txtLoc.Text
            OrderDB2DataSet.Tables("items").Rows(intRowPosition)("num") = txtID.Text
            OrderDB2DataSet.Tables("items").Rows(intRowPosition)("rate") = txtRate.Text
            OrderDB2DataSet.Tables("items").Rows(intRowPosition)("size") = txtSize.Text
            OrderDB2DataSet.Tables("items").Rows(intRowPosition)("supplier") = txtSupp.Text
            ItemsTableAdapter1.Update(Me.OrderDB2DataSet.items)
            OrderDB2DataSet.AcceptChanges()
            MessageBox.Show("Records Saved!")
            RefreshTable()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs)
        Me.ItemsTableAdapter1.Fill(Me.OrderDB2DataSet.items)
        Me.ShowCurrentRecord()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If OrderDB2DataSet.Tables("items").Rows.Count <> 0 Then
            OrderDB2DataSet.Tables("items").Rows(intRowPosition).Delete()
            intRowPosition -= 1
            Me.ShowCurrentRecord()

            ItemsTableAdapter1.Update(Me.OrderDB2DataSet.items)
            OrderDB2DataSet.AcceptChanges()
            MessageBox.Show("items Record Deleted!")
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmAddLot.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class