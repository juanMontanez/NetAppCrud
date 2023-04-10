Imports LOGICA
Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim empleados As New BLLempleados()
        Try
            Dim login = empleados.Login(txtUsuario.Text.Trim.ToUpper, txtContra.Text.Trim)
            If login Then
                frmPrincipal.Show()
                Me.Hide()
                txtContra.Clear()
                txtUsuario.Clear()
                txtUsuario.Focus()
            Else
                MessageBox.Show("Por favor asegúrese de que el usuario y la contraseña son correctos", "Credenciales Incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtContra.Clear()
                txtUsuario.Clear()
                txtUsuario.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al acceder a la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class