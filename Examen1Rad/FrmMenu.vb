Public Class FrmMenu
    Private Sub SUCURSALESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SUCURSALESToolStripMenuItem.Click
        FrmSucursales.ShowDialog()
    End Sub

    Private Sub EMPLEADOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EMPLEADOSToolStripMenuItem.Click
        FrmEmpleados.ShowDialog()
    End Sub
End Class