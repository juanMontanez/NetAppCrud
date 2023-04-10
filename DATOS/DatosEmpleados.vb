Imports System.Data.SqlClient

Public Class DatosEmpleados
    Public Shared Function obtenerdatos(ByVal sqlquery As String) As DataTable
        Dim conex As New SqlConnection(My.Settings.cadena)
        Dim adapter As New SqlDataAdapter
        Dim dt As New DataTable
        dt.Locale = System.Globalization.CultureInfo.InvariantCulture
        Try
            conex.Open()
            Dim comand As New SqlCommand(sqlquery, conex)
            comand.Connection = conex
            adapter.SelectCommand = comand
            adapter.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message, "Error")
        End Try
        Return dt
        conex.Close()
    End Function
End Class
