Imports LibreriaDatos
Public Class EntradaSalida
    Private RutaDSN As String
    Private configs(6) As String
    Private reader As New Cargar
    Private writer As New Guardar
    Private rutaTemp As String
    Private Shared Instancia As EntradaSalida

    Public Shared Function GetSingleton() As EntradaSalida
        If (Instancia Is Nothing) Then
            Instancia = New EntradaSalida
        End If
        Return Instancia
    End Function

    Public Function BuscarDSN()
        RutaDSN = reader.ObtenerRuta("", "Database connection file", "dsn")
        Return RutaDSN
    End Function

    Public Sub GuardarCFG()
        If IsConnected() Then
            writer.EscribirSerializable(Settings.GetSingleton)
        End If
    End Sub

    Public Sub CargarCFG()
        Settings.GetSingleton.SetInstancia(reader.CargarSerializable(Of Settings))
        Settings.GetSingleton.SetupBD()
    End Sub

    Public Sub ConectarBD()
        ConsultasPrincipales.GetSingleton.ActivarConexion()
    End Sub

    Public Function CargarCSV() As DataTable
        Dim cargador As New Cargar
        rutaTemp = cargador.RutaTemp
        Return cargador.ImportarCSV()
    End Function

    Public Function IsConnected() As Boolean
        If Conexion.GetSingleton.IsActive Then
            Return True
        End If
        Return False
    End Function

    Public Function CargarImagen() As String
        Dim cargador As New Cargar
        Return cargador.ObtenerRuta("", "Archivos de imagen", "jpg")
    End Function

    Public ReadOnly Property RutaActual() As String
        Get
            Return rutaTemp
        End Get
    End Property

    Public Property RutaDsnCFG() As String
        Get
            Return RutaDSN
        End Get
        Set(value As String)
            RutaDSN = value
        End Set
    End Property
End Class
