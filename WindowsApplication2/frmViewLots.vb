Public Class frmViewLots
    Private intRowPosition As Integer = 0

    Private Sub ShowCurrentRecord()
        If intRowPosition >= 0 Then
            lblAvail.Text = OrderDB2DataSet.Tables("items").Rows(intRowPosition)("available").ToString()
            lblCat.Text = OrderDB2DataSet.Tables("items").Rows(intRowPosition)("category").ToString()
            lblDesc.Text = OrderDB2DataSet.Tables("items").Rows(intRowPosition)("desc").ToString()
            lblLoc.Text = OrderDB2DataSet.Tables("items").Rows(intRowPosition)("location").ToString()
            lblNum.Text = OrderDB2DataSet.Tables("items").Rows(intRowPosition)("num").ToString()
            lblRate.Text = OrderDB2DataSet.Tables("items").Rows(intRowPosition)("rate").ToString()
            lblSize.Text = OrderDB2DataSet.Tables("items").Rows(intRowPosition)("size").ToString()
            lblSupp.Text = OrderDB2DataSet.Tables("items").Rows(intRowPosition)("supplier").ToString()
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

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmManageLots.Show()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.ItemsTableAdapter1.Fill(Me.OrderDB2DataSet.items)
        ShowCurrentRecord()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub frmViewLots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ItemsTableAdapter1.Fill(Me.OrderDB2DataSet.items)
        ShowCurrentRecord()
    End Sub
End Class