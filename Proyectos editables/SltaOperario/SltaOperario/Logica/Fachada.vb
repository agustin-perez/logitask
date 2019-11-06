Imports System.Data.Odbc
Imports System.Text
Imports System.Security.Cryptography
Public Class Fachada
    Private Shared instancia As Fachada
    Private rutaCFG As String


    Private query As New Odbc.OdbcCommand
    Private lector As Odbc.OdbcDataReader
    Private configs(5) As String

    Public Shared Function GetSingleton() As Fachada
        If (instancia Is Nothing) Then
            instancia = New Fachada
        End If
        Return instancia
    End Function



    Private Function Hashear(dato As String) As String
        Dim textEncode As New UnicodeEncoding()
        Dim bytes() As Byte = textEncode.GetBytes(dato)
        Dim algoritmo As New SHA256Managed()
        Dim hash() As Byte = algoritmo.ComputeHash(bytes)
        Return Convert.ToBase64String(hash)
    End Function

    Public Function ConsultaTabla(queryText As String)
        Dim tabla As New DataTable
        Dim adapter As New OdbcDataAdapter(queryText, Conexion())
        Try
            adapter.Fill(tabla)
        Catch ex As Exception
            MsgBox("No existe ningún dato según el criterio de búsqueda", MsgBoxStyle.Information, "No se encontró nada")
            Return tabla
        End Try
        Return tabla
    End Function

    Public Function ConsultaLogin(user As String, pass As String) As Boolean
        hashPass = Hashear(pass)
        Dim consulta As String = ("select username from empleado where username = """ + user + """ AND pass = """ + hashPass + """")
        query.Connection = Conexion()
        query.CommandText = consulta
        Try
            lector = query.ExecuteReader()
        Catch ex As Exception
            MsgBox("Error de lectura, verifique Red", MsgBoxStyle.Information, "Error al leer Base de Datos")
        End Try

        If (lector.HasRows) Then
            Return True
            lector.Close()
        End If
        lector.Close()
        Return False
    End Function

    Public Function ConsultaVehiculos() As DataTable
        Dim consulta As String = ("select * from vehiculo")
        Return ConsultaTabla(consulta)
    End Function

    Public Function ConsultaVin(vin As String) As DataTable
        Dim consulta As String = ("select * from vehiculo where vin = """ + vin + """")
        Return ConsultaTabla(consulta)
    End Function

    Public Sub ActivarConexion()
        If (Not conexionBD.getSingleton.Conectar(bbddstring)) Then
            Throw New Exception
        End If
    End Sub

    Public Function Conexion() As System.Data.Odbc.OdbcConnection
        Return conexionBD.getSingleton.GetConexion
    End Function

    Public Sub SetDSN()
        dsn = accesoArchivo.getSingleton.RutaAbrir(".dsn", "Archivos de conexion de ODBC", "dsn")
    End Sub

    Public Function StringBBDD() As String
        Return bbddstring
    End Function

    Public Function GetRutaArchivo(nombreArchivo As String, nombreTipoDeDato As String, extension As String) As String
        Return accesoArchivo.getSingleton.RutaAbrir(nombreArchivo, nombreTipoDeDato, extension)
    End Function

    Public Function SetRutaGuardar(nombreArchivo As String, nombreTipoDeDato As String, extension As String) As String
        Return accesoArchivo.getSingleton.RutaGuardar(nombreArchivo, nombreTipoDeDato, extension)
    End Function

    Public Function AbrirArchivo(ruta As String) As String()
        Return accesoArchivo.getSingleton.Abrir(ruta)
    End Function

    Public Function GuardarArchivo(dato() As String, ruta As String) As Boolean
        Try
            accesoArchivo.getSingleton.Guardar(dato, ruta)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub GettearConfiguraciones()
        configs(0) = dsn
        configs(1) = informixUser
        configs(2) = informixPass
        If (propiedadesVentanas.GetSingleton.Estilo) Then
            configs(3) = "true"
        Else
            configs(3) = "false"
        End If
    End Sub

    Public Sub SetearConfiguraciones(datos() As String)
        dsn = datos(0)
        informixUser = datos(1)
        informixPass = datos(2)
        If (datos(3) = "true") Then
            propiedadesVentanas.GetSingleton.Estilo = True
        Else
            propiedadesVentanas.GetSingleton.Estilo = False
        End If
    End Sub

    Public Property ConfigsArray() As String()
        Get
            Return configs
        End Get
        Set(ByVal value() As String)
            configs = value
        End Set
    End Property

    Public Property RutaCFGInicio() As String
        Get
            Return rutaCFG
        End Get
        Set(ByVal value As String)
            rutaCFG = value
        End Set
    End Property

    Public Property RutaDSN() As String
        Get
            Return dsn
        End Get
        Set(ByVal value As String)
            dsn = value
        End Set
    End Property

    Public Property User() As String
        Get
            Return informixUser
        End Get
        Set(ByVal value As String)
            informixUser = value
        End Set
    End Property

    Public Property Pass() As String
        Get
            Return informixPass
        End Get
        Set(ByVal value As String)
            informixPass = value
        End Set
    End Property

End Class
