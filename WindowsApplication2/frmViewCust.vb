Public Class frmViewCust

    Private intRowPosition As Integer = 0

    Private Sub frmViewCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OrderDB2DataSet.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter1.Fill(Me.OrderDB2DataSet.customer)
        ShowCurrentRecord()
    End Sub

    Private Sub ShowCurrentRecord()
        If intRowPosition >= 0 Then
            lblID.Text = OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("custID").ToString()
            lblName.Text = OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("custName").ToString()
            lblCont.Text = OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("custContact").ToString()
            lblEmail.Text = OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("custEmail").ToString()
            lblDOB.Text = Format(OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("custDOB"), "dd-MMM-yyyy")
            lblDur.Text = OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("duration").ToString()
            lblNric.Text = OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("nric").ToString()
            lblLot.Text = OrderDB2DataSet.Tables("customer").Rows(intRowPosition)("lotNum").ToString()
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

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmManageCust.Show()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.CustomerTableAdapter1.Fill(Me.OrderDB2DataSet.customer)
        ShowCurrentRecord()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmMain.Show()
    End Sub
End Class
