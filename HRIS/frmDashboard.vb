Public Class frmDashboard
    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        pnMid.Controls.Clear()
        Dim frmEmployeeInfo As New frmEmployeeInfo
        frmEmployeeInfo.TopLevel = False
        pnMid.Controls.Add(frmEmployeeInfo)
        frmEmployeeInfo.Dock = DockStyle.Fill
        frmEmployeeInfo.Show()

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click

        'If frmEmployeeInfo IsNot Nothing AndAlso pnMid.Controls.Contains(frmEmployeeInfo) Then
        '    pnMid.Controls.Remove(frmEmployeeInfo)
        '    frmEmployeeInfo.Dispose()
        '    frmEmployeeInfo = Nothing
        'End If
        pnMid.Controls.Clear()

        Dim frmHome As New frmHome
        frmHome.TopLevel = False
        pnMid.Controls.Add(frmHome)
        frmHome.Dock = DockStyle.Fill
        frmHome.Show()

    End Sub

    Private Sub btnTraining_Click(sender As Object, e As EventArgs) Handles btnTraining.Click
        pnMid.Controls.Clear()

        Dim frmTrainingRecord As New frmTrainingRecord
        frmTrainingRecord.TopLevel = False
        pnMid.Controls.Add(frmTrainingRecord)
        frmTrainingRecord.Dock = DockStyle.Fill
        frmTrainingRecord.Show()

    End Sub

    Private Sub btnTime_Click(sender As Object, e As EventArgs) Handles btnTime.Click
        frmEmployeeInfo.Hide()

    End Sub
End Class