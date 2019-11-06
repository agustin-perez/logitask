Imports System.Data.Odbc
''' <summary>
''' Clase encargada de crear parámetros para una consulta compleja que lo requiera.
''' </summary>
Public Class ParametrosDeConsulta
    ''' <summary>
    ''' Lista de los parámetros.
    ''' </summary>
    Private params As New List(Of OdbcParameter)
    Private querytext As String
    ''' <summary>
    ''' Subrutina encargada de agregar parámetros a la lista.
    ''' </summary>
    ''' <typeparam name="T">Tipo de valor a ser agregado en el parámetro.</typeparam>
    ''' <param name="valor">Dato que albergará el parámetro.</param>
    ''' <param name="tipo">Tipo de DataBaseType que tendrá el valor en cuestión.</param>
    Public Sub AgregarParametro(Of T)(valor As T, tipo As DbType)
        Dim param As New OdbcParameter
        param.DbType = tipo
        param.Value = valor
        params.Add(param)
    End Sub
    ''' <summary>
    ''' Propiedad encargada de devolver el texto de la consulta.
    ''' </summary>
    ''' <returns>Texto de consulta.</returns>
    Public ReadOnly Property GetQueryText As String
        Get
            Return querytext
        End Get
    End Property
    ''' <summary>
    ''' Propiedad que devuelve la lista.
    ''' </summary>
    ''' <returns>Lista de parámetros.</returns>
    Public ReadOnly Property GetLista() As List(Of OdbcParameter)
        Get
            Return params
        End Get
    End Property
End Class
