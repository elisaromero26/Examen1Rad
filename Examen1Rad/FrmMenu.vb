Public Class FrmMenu
    Private Sub SUCURSALESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SUCURSALESToolStripMenuItem.Click
        FrmSucursales.ShowDialog()
    End Sub

    Private Sub EMPLEADOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EMPLEADOSToolStripMenuItem.Click
        FrmEmpleados.ShowDialog()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class