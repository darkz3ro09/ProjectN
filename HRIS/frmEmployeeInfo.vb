Public Class frmEmployeeInfo
    Private Sub opt4_CheckedChanged(sender As Object, e As EventArgs) Handles opt4.CheckedChanged
        txtOthers.Enabled = True
        txtOthers.Focus()
    End Sub

    Private Sub opt1_CheckedChanged(sender As Object, e As EventArgs) Handles opt1.CheckedChanged
        txtOthers.Enabled = False
    End Sub

    Private Sub opt2_CheckedChanged(sender As Object, e As EventArgs) Handles opt2.CheckedChanged
        txtOthers.Enabled = False
    End Sub

    Private Sub opt3_CheckedChanged(sender As Object, e As EventArgs) Handles opt3.CheckedChanged
        txtOthers.Enabled = False
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Label49_Click(sender As Object, e As EventArgs) Handles Label49.Click

    End Sub
End Class