Imports LOGICA
Public Class frmAddEmpleados
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            BLLempleados.insertarEmpleado(New Empleados() With
                {.usuario = usuarioTextBox.Text.Trim.ToUpper,
                 .contraseña = contraTextBox.Text.Trim,
                 .telefono = Convert.ToInt32(telefonoTextBox.Text.Trim),
                 .fechaAlta = fechaAltaDateTimePicker.Value,
                 .nombre = nombreTextBox.Text.Trim.ToUpper,
                 .apellidos = apellidosTextBox.Text.Trim.ToUpper,
                 .email = emailTextBox.Text.Trim.ToUpper,
                 .cargo = cargoTextBox.Text.Trim.ToUpper})
            MessageBox.Show("Empleado añadido correctamente", "Añadir empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al añadir al empleado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class