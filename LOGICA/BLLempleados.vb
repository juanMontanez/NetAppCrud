Imports DATOS
Public Class BLLempleados
    Dim userDao As New UserDao()
    Public Function Login(user As String, pass As String) As Boolean
        Return userDao.login(user, pass)
    End Function

    Public Shared Function listarEmpleados(usuario As String)
        Dim ctx As New CrudAppEntities
        Dim datos = (From c In ctx.Empleados
                     Where c.usuario.Contains(usuario)).ToList()
        Return datos
    End Function

    Public Shared Function getInfoEmpleadoId(idEmpleado As Integer) As Empleados
        Dim ctx As New CrudAppEntities
        Dim empleado As Empleados = (From c In ctx.Empleados
                                     Where c.idEmpleado = idEmpleado
                                     Select c).SingleOrDefault
        Return empleado

    End Function
    Public Shared Function getIdEmpleado(usuario As String) As Integer
        Dim ctx As New CrudAppEntities
        Dim empleadoId As Integer = (From c In ctx.Empleados
                                     Where c.usuario = usuario
                                     Select c.idEmpleado).SingleOrDefault()
        Return empleadoId
    End Function

    Public Shared Function getInfoEmpleadoNombre(usuario As String, contra As String) As Integer
        Dim ctx As New CrudAppEntities
        Dim empleadoId As Integer = (From c In ctx.Empleados
                                     Where c.usuario = usuario And c.contraseña = contra
                                     Select c.idEmpleado).SingleOrDefault()
        Return empleadoId

    End Function
    Public Shared Function getInfoEmpleadoUsuarioContra(usuario As String, contra As String) As Empleados
        Dim ctx As New CrudAppEntities
        Dim empleadoCheck As Empleados = (From c In ctx.Empleados
                                          Where c.contraseña = contra And c.usuario = usuario
                                          Select c).SingleOrDefault()
        Return empleadoCheck

    End Function

    Public Shared Sub actualizarEmpleado(idEmpleado As Integer, usuario As String, contra As String,
                                         telefono As Integer, fechaAlta As Date, nombre As String, apellidos As String, cargo As String, email As String)
        Dim ctx As New CrudAppEntities
        Dim empleado As Empleados = (From c In ctx.Empleados
                                     Where c.idEmpleado = idEmpleado
                                     Select c).SingleOrDefault
        With empleado
            .usuario = usuario
            .contraseña = contra
            .telefono = telefono
            .fechaAlta = fechaAlta
            .nombre = nombre
            .apellidos = apellidos
            .cargo = cargo
            .email = email
        End With
        ctx.SaveChanges()
    End Sub

    Shared Sub insertarEmpleado(empleado As Empleados)
        Dim ctx As New CrudAppEntities
        ctx.Empleados.Add(empleado)
        ctx.SaveChanges()
    End Sub
    Shared Sub eliminarEmpleado(idEmpleado As Integer)
        Dim ctx As New CrudAppEntities
        Dim empleado As Empleados = (From c In ctx.Empleados
                                     Where c.idEmpleado = idEmpleado
                                     Select c).SingleOrDefault
        ctx.Empleados.Remove(empleado)
        ctx.SaveChanges()
    End Sub

End Class
