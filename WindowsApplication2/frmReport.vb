Public Class frmReport

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OrderDB2DataSet.customer' table. You can move, or remove it, as needed.
        Me.customerTableAdapter.Fill(Me.OrderDB2DataSet.customer)
    End Sub

End Class