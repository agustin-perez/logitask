Public Class DatosSesion
    Private Shared instancia As DatosSesion
    Private Operario As Boolean
    Private Admin As Boolean
    Private lugarTemp As Int32
    Private UserLoggeado As String
    Private IsOperario As Boolean
    Private tuplaTemp As DataRow
    Private StringTemp As String
    Private vinTemporal As String
    Private numeroTemporal As Integer
    Private listaReload As Boolean
    Private tileChecked As Boolean

    Public Shared Function GetSingleton() As DatosSesion
        If instancia Is Nothing Then
            instancia = New DatosSesion
        End If
        Return instancia
    End Function

    Public Enum IDLugarOperario
        Puerto = 1
        Patio = 2
    End Enum

    Public Property NumeroTemp() As Integer
        Get
            Return numeroTemporal
        End Get
        Set(ByVal value As Integer)
            numeroTemporal = value
        End Set
    End Property

    Public Property VinTemp() As String
        Get
            Return vinTemporal
        End Get
        Set(value As String)
            vinTemporal = value
        End Set
    End Property

    Public Property UserLogged() As String
        Get
            Return UserLoggeado
        End Get
        Set(value As String)
            UserLoggeado = value
        End Set
    End Property

    Public Property StringTemporal() As String
        Get
            Return StringTemp
        End Get
        Set(ByVal value As String)
            StringTemp = value
        End Set
    End Property

    Public Property LugarTemporal() As String
        Get
            Return lugarTemp
        End Get
        Set(ByVal value As String)
            lugarTemp = value
        End Set
    End Property

    Public Property IsOperarioApp() As Boolean
        Get
            Return IsOperario
        End Get
        Set(value As Boolean)
            IsOperario = value
        End Set
    End Property

    Public Property IsAdminApp() As Boolean
        Get
            Return Admin
        End Get
        Set(value As Boolean)
            Admin = value
        End Set
    End Property

    Public Property TipoOperario() As Boolean
        Get
            Return Operario
        End Get
        Set(ByVal value As Boolean)
            Operario = value
            If Operario Then
                lugarTemp = IDLugarOperario.Patio
            Else
                lugarTemp = IDLugarOperario.Puerto
            End If
        End Set
    End Property

    Public Property TuplaTemporal() As DataRow
        Get
            Return tuplaTemp
        End Get
        Set(ByVal value As DataRow)
            tuplaTemp = value
        End Set
    End Property

    Public Property ReloadListado() As Boolean
        Get
            Return listaReload
        End Get
        Set(value As Boolean)
            listaReload = value
        End Set
    End Property

    Public Property TileCheck() As Boolean
        Get
            Return tileChecked
        End Get
        Set(value As Boolean)
            tileChecked = value
        End Set
    End Property
End Class
