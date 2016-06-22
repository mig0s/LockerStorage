Public Class frmViewRent

    Private Sub frmViewRent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAddr.Text = frmAddRent.txtAddr.Text
        lblCont.Text = frmAddRent.txtCont.Text
        lblDob.Text = frmAddRent.txtDOB.Text
        lblDur.Text = frmAddRent.txtDur.Text
        lblEmail.Text = frmAddRent.txtEmail.Text
        lblID.Text = frmAddRent.txtID.Text
        lblLot.Text = frmAddRent.txtLot.Text
        lblName.Text = frmAddRent.txtName.Text
        lblNric.Text = frmAddRent.txtNric.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmAddRent.Close()
        frmLogin.Show()
    End Sub
End Class