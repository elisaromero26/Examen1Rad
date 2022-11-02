Public Class FrmLogin
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtuser.Clear()
        txtpassword.Clear()
        txtuser.Focus()
    End Sub
End Class