Imports LOGICA
Public Class frmModificarEmpleados
    Public Sub login()
        Try
            If Not BLLempleados.getInfoEmpleadoUsuarioContra(Me.nombreLoginTextBox.Text.Trim.ToUpper, Me.contraLoginTextBox.Text.Trim) Is Nothing Then
                checkPanel.Visible = False
                DatosEmpleadoPanel.Visible = True
                DatosEmpleadoPanel.BringToFront()
                Dim empleado As Empleados = BLLempleados.getInfoEmpleadoUsuarioContra(Me.nombreLoginTextBox.Text.Trim.ToUpper, Me.contraLoginTextBox.Text.Trim)
                With empleado
                    Me.usuarioTextBox.Text = .usuario
                    Me.contraTextBox.Text = .contraseña
                    Me.telefonoTextBox.Text = .telefono
                    Me.fechaAltaDateTimePicker.Value = .fechaAlta
                    Me.nombreTextBox.Text = .nombre
                    Me.apellidosTextBox.Text = .apellidos
                    Me.emailTextBox.Text = .email
                    Me.cargoTextBox.Text = .cargo
                End With
            Else
                MsgBox("Credenciales incorrectas", MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ocurrio un error al procesar la petición de la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmModificarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatosEmpleadoPanel.Visible = False
    End Sub
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        login()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim id As Integer = BLLempleados.getInfoEmpleadoNombre(nombreLoginTextBox.Text.Trim.ToUpper, contraLoginTextBox.Text.Trim)
            BLLempleados.actualizarEmpleado(id, Me.usuarioTextBox.Text.Trim.ToUpper, Me.contraTextBox.Text.Trim, Convert.ToInt32(telefonoTextBox.Text.Trim.ToUpper),
                                            Me.fechaAltaDateTimePicker.Value, Me.nombreTextBox.Text.Trim.ToUpper, Me.apellidosTextBox.Text.Trim.ToUpper,
                                            Me.emailTextBox.Text.Trim.ToUpper, Me.cargoTextBox.Text.Trim.ToUpper)
            'MessageBox.Show("Empleado modificado correctamente", "Modificar empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Dim dialog As Dialog1
            modEmpleadoDialog.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al modificar al empleado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class