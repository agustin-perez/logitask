Imports System.Text
Imports System.Security.Cryptography
''' <summary>
''' Clase encargada de administrar la seguridad a nivel de telecomunicaciones dentro del paquete SliferLogistics.
''' </summary>
Public Class Encriptacion
    Private textEncode As New UnicodeEncoding
    Private bytes() As Byte
    Private algoritmo As New SHA256Managed
    Private hash() As Byte
    Private resultado As String
    ''' <summary>
    ''' Función de encriptación de un único sentido según el algoritmo SHA256 pasado por Base64.
    ''' </summary>
    ''' <param name="dato">String a ser encriptado.</param>
    ''' <returns>Cadena de 44 caracteres de largo encriptada, con pérdida de datos.</returns>
    Public Function SHA256(dato As String) As String
        Try
            bytes = textEncode.GetBytes(dato)
            hash = algoritmo.ComputeHash(bytes)
            Return Convert.ToBase64String(hash)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    ''' <summary>
    ''' Función encargada de encodear en Base64.
    ''' </summary>
    ''' <param name="dato">String a ser encodeado.</param>
    ''' <returns>Cadena de n caracteres encriptada según el algoritmo Base64, de doble vía.</returns>
    Public Function Base64Encode(dato As String) As String
        Try
            bytes = Encoding.ASCII.GetBytes(dato)
            Return Convert.ToBase64String(bytes)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    ''' <summary>
    ''' Función encargada de desencodear un String en Base64.
    ''' </summary>
    ''' <param name="dato">Dato encodeado a ser desencodeado.</param>
    ''' <returns>Cadena de n caracteres en formato ASCII.</returns>
    Public Function Base64Decode(dato As String) As String
        Try
            bytes = System.Convert.FromBase64String(dato)
            Return Encoding.ASCII.GetString(bytes)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
