''' <summary>
''' Clase encargada de administrar el archivo de conexión con Base de Datos (Database Source Name).   
''' </summary>
Public Class DSN
    Private ruta As String
    Private databaseUser As String
    Private databasePass As String
    Private bbddString As String
    ''' <summary>
    ''' Subrutina encargada de generar el String necesario para la conexión con la Base de Datos.
    ''' </summary>
    Public Sub GenerarString()
        bbddString = "FileDsn=" + ruta + "; UID=" + databaseUser + "; PWD=" + databasePass
    End Sub
    ''' <summary>
    ''' Property encargada de getear o setear la ruta del archivo DSN mediante un OpenFileDialog de la librería gráfica.
    ''' </summary>
    ''' <returns>Ruta del archivo DSN.</returns>
    Public Property RutaDSN() As String
        Get
            Return ruta
        End Get
        Set(ByVal value As String)
            ruta = value
        End Set
    End Property
    ''' <summary>
    ''' Propiedad encargada de getear o setear el usuario de la Base de Datos mediante la librería gráfica.
    ''' </summary>
    ''' <returns>Usuario de la Base de Datos.</returns>
    Public Property UserBD() As String
        Get
            Return databaseUser
        End Get
        Set(ByVal value As String)
            databaseUser = value
        End Set
    End Property
    ''' <summary>
    ''' Propiedad de solo lectura que setea el usuario de la Base de Datos obtenido mediante la librería gráfica.
    ''' </summary>
    Public WriteOnly Property PassDB() As String
        Set(ByVal value As String)
            databasePass = value
        End Set
    End Property
    ''' <summary>
    ''' Propiedad encargada de tomar el String de conexión a la Base de Datos generado en esta clase.
    ''' </summary>
    ''' <returns>String generado de conexión con la Base de Datos.</returns>
    Public ReadOnly Property StringGenerado() As String
        Get
            Return bbddString
        End Get
    End Property
End Class
