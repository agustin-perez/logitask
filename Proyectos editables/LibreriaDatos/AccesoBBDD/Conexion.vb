Imports System.Data.Odbc
''' <summary>
''' Clase encargada de administrar la conexión con la Base de Datos InformiX mediante Open Database Connectivity (ODBC).
''' </summary>
Public Class Conexion
    Private Shared conexionAbierta As Boolean
    Private Shared instancia As Conexion
    Private Shared conexion As New OdbcConnection
    Private DatosDSN As New DSN
    ''' <summary>
    ''' Función compartida encargada de cumplir el patrón singleton mediante una única instancia de la clase.
    ''' </summary>
    ''' <returns>Instancia de la clase.</returns>
    Public Shared Function GetSingleton() As Conexion
        If (instancia Is Nothing) Then
            instancia = New Conexion
        End If
        Return instancia
    End Function
    ''' <summary>
    ''' Subrutina encargada de crear el string con parámetros de la Base de Datos para activar su conexión. 
    ''' </summary>
    ''' <param name="RutaArchivoDSN">Ruta obtenida del OpenFileDialog.</param>
    ''' <param name="UserDatabase">Usuario de la base de datos obtenido de la librería gráfica.</param>
    ''' <param name="PassDatabase">Contraseña que pertenece al usuario de la base de datos obtenido de la librería gráfica.</param>
    Public Sub CrearConexion(RutaArchivoDSN As String, UserDatabase As String, PassDatabase As String)
        DatosDSN.RutaDSN = RutaArchivoDSN
        DatosDSN.PassDB = PassDatabase
        DatosDSN.UserBD = UserDatabase
        DatosDSN.GenerarString()
        Conectar()
    End Sub
    ''' <summary>
    ''' Subrutina encargada de cerrar una conexión activa o fallida con la base de datos.
    ''' </summary>
    Public Sub CerrarConexion()
        conexion.Close()
        conexionAbierta = False
    End Sub
    ''' <summary>
    ''' Función encargada de activar una conexión instanciada con la base de datos.
    ''' </summary>
    ''' <returns>Devuelve si se logró la conexión o no.</returns>
    Private Function Conectar() As Boolean
        conexion.ConnectionString = DatosDSN.StringGenerado
        Try
            conexion.Open()
            conexionAbierta = True
            Return True
        Catch ex As Exception
            CerrarConexion()
            conexionAbierta = False
        End Try
        Return False
    End Function
    ''' <summary>
    ''' Propiedad que devuelve la conexión instanciada en la clase.
    ''' </summary>
    ''' <returns>Conexión instanciada.</returns>
    Public ReadOnly Property ConexionInstanciada() As OdbcConnection
        Get
            Return conexion
        End Get
    End Property
    ''' <summary>
    ''' Propiedad encargada de informar si hay una conexión activa o no.
    ''' </summary>
    ''' <returns>Estado de la conexión.</returns>
    Public ReadOnly Property IsActive() As Boolean
        Get
            Return conexionAbierta
        End Get
    End Property
End Class
