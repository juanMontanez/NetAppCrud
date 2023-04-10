Public Class BLLtrabajosRealizados
    Shared Sub insertarTrealizado(trabajo As TrabajosRealizados)
        Dim ctx As New CrudAppEntities
        ctx.TrabajosRealizados.Add(trabajo)
        ctx.SaveChanges()
    End Sub

End Class
