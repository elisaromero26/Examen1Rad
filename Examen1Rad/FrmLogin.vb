Public Class FrmLogin
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtuser.Clear()
        txtpassword.Clear()
        txtuser.Focus()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If txtuser.Text = "" Or txtpassword.Text = "" Then
            MessageBox.Show("DEBE LLENAR LOS CAMPOS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtuser.Clear()
            txtpassword.Clear()
            txtuser.Focus()
        Else
            Dim con As New SqlClient.SqlConnection(My.Settings.Examen1RAD)
            con.Open()
            Dim reader As SqlClient.SqlDataReader
            Dim cmd As New SqlClient.SqlCommand("select *from Usuarios where idusuario = '" & txtuser.Text & " ' and contraseña ='" & txtpassword.Text & "'", con)
            reader = cmd.ExecuteReader

            If reader.Read Then
                If reader.Item("activo") = True Then
                    VariablesPublicas.idusuario = reader.Item("idusuario")
                    VariablesPublicas.nivelacceso = reader.Item("nivelacceso")
                    VariablesPublicas.nombreusuario = reader.Item("NombreCompleto")
                    Me.Dispose()
                    FrmMenu.ShowDialog()
                Else
                    MessageBox.Show("Usuario Inactivo")
                End If
            Else
                MessageBox.Show("Usuario o Contraseña Incorrecto")
            End If
        End If
    End Sub
End Class