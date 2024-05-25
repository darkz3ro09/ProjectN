Public Class frmLogin
    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        pnRegister.Visible = True
        pnLogin.Visible = False

    End Sub

    Private Sub btnReLogin_Click(sender As Object, e As EventArgs) Handles btnReLogin.Click
        pnRegister.Visible = False
        pnLogin.Visible = True
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        frmDashboard.Show()
        Me.Hide()

    End Sub
End Class
