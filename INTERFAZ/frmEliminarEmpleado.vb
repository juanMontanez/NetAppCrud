Imports LOGICA, COMUN
Public Class frmEliminarEmpleado
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If ActiveUser.usuario <> Me.usuarioComboBox.Text Then
                Dim idEmpleado As Integer = BLLempleados.getIdEmpleado(Me.usuarioComboBox.Text)
                Dim empleadoSelecionado As Empleados = BLLempleados.getInfoEmpleadoId(idEmpleado)
                Console.WriteLine("Empleado selecionado " + empleadoSelecionado.nombre)
                modalEliminarEmpleado.lblNombre.Text = empleadoSelecionado.nombre
                modalEliminarEmpleado.lblApellidos.Text = empleadoSelecionado.apellidos
                modalEliminarEmpleado.lblCargo.Text = empleadoSelecionado.cargo
                modalEliminarEmpleado.idEmpleado = empleadoSelecionado.idEmpleado
                modalEliminarEmpleado.lblEmail.Text = empleadoSelecionado.email
                modalEliminarEmpleado.ShowDialog()
                'If MessageBox.Show("¿Estás seguro de que desea eliminar a " + Me.usuarioComboBox.Text.TrimEnd + " ?", "Atención",
                'MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                'BLLempleados.eliminarEmpleado(idEmpleado)
                'End If
            Else
                MessageBox.Show("No se puede eliminar el usuario activo", "Eliminar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al eliminar el empleado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmEliminarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EmpleadosSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.EmpleadosSet.Empleados)

    End Sub
    'Añadimos el evento keyPress del comboBox y le establecemos la propieda handled a true para que no sea editable
    Private Sub usuarioComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles usuarioComboBox.KeyPress
        e.Handled = True
    End Sub

    Private Sub nombreTextBox_TextChanged(sender As Object, e As EventArgs) Handles nombreTextBox.TextChanged
        Console.WriteLine(nombreTextBox.Text.Trim.ToUpper)
        Dim index As Integer
        index = usuarioComboBox.FindString(nombreTextBox.Text.Trim.ToUpper)
        usuarioComboBox.SelectedIndex = index
    End Sub
End Class