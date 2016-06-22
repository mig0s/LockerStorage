Public Class frmViewUsers
    Private intRowPosition As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmAdmin.Show()
    End Sub
    Private Sub ShowCurrentRecord()
        If intRowPosition >= 0 Then
            lblPassword.Text = OrderDB2DataSet.Tables("account").Rows(intRowPosition)("password").ToString()
            lblUsername.Text = OrderDB2DataSet.Tables("account").Rows(intRowPosition)("username").ToString()
            lblRole.Text = OrderDB2DataSet.Tables("account").Rows(intRowPosition)("role").ToString()
        End If
    End Sub

    Private Sub frmViewUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AccountTableAdapter1.Fill(Me.OrderDB2DataSet.account)
        ShowCurrentRecord()
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

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.AccountTableAdapter1.Fill(Me.OrderDB2DataSet.account)
        ShowCurrentRecord()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmManageUser.Show()
    End Sub
End Class