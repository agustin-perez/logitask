Imports System.Data.Odbc
''' <summary>
''' Clase encargada de administrar las consultas de escritura en la Base de Datos.
''' </summary>
Public Class ConsultasDeEscritura
    Private Shared Instancia As ConsultasDeEscritura
    Private query As New OdbcCommand
    Private lector As OdbcDataReader
    ''' <summary>
    ''' Función compartida encargada de cumplir el patrón singleton mediante una única instancia de la clase.
    ''' </summary>
    ''' <returns>Instancia de la clase.</returns>
    Public Shared Function GetSingleton() As ConsultasDeEscritura
        If (Instancia Is Nothing) Then
            Instancia = New ConsultasDeEscritura
        End If
        Return Instancia
    End Function
    ''' <summary>
    ''' Subrutina encargada de enviar una consulta a la Base de Datos con una lista de parámetros adaptada a la consulta (especialmente para datos complejos), y para evitar ataques de SQL Injection.
    ''' </summary>
    ''' <param name="consulta">String conteniendo la consulta SQL.</param>
    ''' <param name="lista">Lista de parámetros ADAPTADA a la consulta SQL.</param>
    Public Sub InsertarPorParams(consulta As String, lista As List(Of OdbcParameter))
        query.Connection = LibreriaDatos.Conexion.GetSingleton.ConexionInstanciada
        query.CommandText = consulta
        For Each var As OdbcParameter In lista
            query.Parameters.Add(var)
        Next
        Try
            query.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        query.Parameters.Clear()
    End Sub
End Class
