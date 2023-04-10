Imports System.Data.SqlClient

'utilizamos la palabra clave MustInherit para indicar que será una clase abstracta
Public MustInherit Class ConnectionToSql
    Private connectionString As String
    Protected Sub New()
        'Establecemos la cadena de conexión a la base de datos, la podemos crear en la configuración
        'del proyecto y acceder a ella
        connectionString = My.Settings.cadena
        'Tambien podemos definir la cadena de conexión directamente
        'Con el atributo integrated security=true le indicamos que accederemos con las credenciales de Windows
        'connectionString = "Server=PRACTICASINFORM\SQLEXPRESS; DataBase=CrudApp; Integrated Security=true"
        'Si ulizamos Entity Framework la cadena de conexión sera:
        'connectionString = "Data Source=PRACTICASINFORM\SQLEXPRESS;Initial Catalog=CrudApp;Integrated Security=True"
    End Sub
    'Creamos un método protegido para establecer la conexión
    Protected Function getConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function

End Class
