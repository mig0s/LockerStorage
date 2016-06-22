Public Class frmLogin

    Dim error_count As Integer = 0

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AccountTableAdapter1.Fill(Me.OrderDB2DataSet.account)
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim SearchAccount As orderDB2DataSet.accountRow
        Dim intFound As Integer = 0
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            error_count += 1
            MessageBox.Show("You have to fill the both fields! You did " + Str(error_count) + "/5 mistakes")
        Else
            For Each SearchAccount In OrderDB2DataSet.account.Rows
                If SearchAccount.username = txtUsername.Text Then
                    intFound = 1
                    Try
                        If SearchAccount.password = txtPassword.Text Then
                            If SearchAccount.role = "Staff" Then
                                MessageBox.Show("You're a staff member!")
                                Me.Hide()
                                frmMain.Show()
                            ElseIf SearchAccount.role = "Admin" Then
                                MessageBox.Show("You're an admin!")
                                Me.Hide()
                                frmAdmin.Show()
                            End If
                        Else
                            error_count += 1
                            MessageBox.Show("Invalid password! You did " + Str(error_count) + "/5 mistakes")
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            Next SearchAccount
            If intFound = 0 Then
                error_count += 1
                MessageBox.Show("Invalid username! You did " + Str(error_count) + "/5 mistakes")
            End If
        End If
        If error_count = 5 Then
            MessageBox.Show("Too many mistakes!")
            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frmAddRent.Show()
    End Sub
End Class