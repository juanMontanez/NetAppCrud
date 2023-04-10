Imports System.Data.SqlClient
Imports COMUN
Public Class UserDao
    Inherits ConnectionToSql
    Public Function login(user As String, pass As String) As Boolean
        'Utilizamos la instrucción Using para que se liberen los recursos de forma automática
        'después de que el código dentro del bloque Using se ejecute.
        Using connection = getConnection()
            Try
                'Abrimos la conexión
                connection.Open()
            Catch ex As Exception
                MsgBox(ex.Message, "Error al acceder a la base de datos", MsgBoxStyle.Critical)
            End Try
            'Utilizamos otro bloque using para introducir la sentencia
            'Podemos definir la sentencia SQL en un String
            'Dim sql As String = "SELECT * FROM USER WHERE usuario=@user and contraseña=@pass"
            'Y establecemos por pararemtro la sentecia sql y la conexion a la hora de instanciar el objeto command
            'Using command As New SqlCommand(sql, connection)
            Using command = New SqlCommand()
                command.Connection = connection
                'Establecemos la sentencia con parametros
                command.CommandText = "SELECT * FROM empleados WHERE usuario=@user and contraseña=@pass"
                    'Asignamos valores a los parametros @user y @pass que serán introducidos al llamar a la función login
                    command.Parameters.AddWithValue("@user", user)
                    command.Parameters.AddWithValue("@pass", pass)
                    'Especificamos el tipo de comando
                    command.CommandType = CommandType.Text
                    'Definimos la variable lector el cual leera el resultado de la consulta
                    Dim reader = command.ExecuteReader()
                'Si el lector tiene filas, la consulta se ejecutó correctamente y devolverá true
                If reader.HasRows Then
                    'Mientras el lector lea las filas, agregamos los valores de la columna a las propiedades del modulo
                    While reader.Read()
                        'Al asignar los valores le indicamos la posición () de la comlumna de la tabla, empezando por 0 la primera
                        ActiveUser.idEmpleado = reader.GetInt32(0)
                        ActiveUser.usuario = reader.GetString(1)
                        ActiveUser.nombre = reader.GetString(5)
                        ActiveUser.apellidos = reader.GetString(6)
                        ActiveUser.cargo = reader.GetString(7)
                        ActiveUser.email = reader.GetString(8)
                    End While
                    'Eliminamos el objeto reader
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
                'No es necesario cerrar la conexión o limpiar el sqlcomand ya que el bloque Using se encarga de ello
            End Using
        End Using
    End Function
End Class
