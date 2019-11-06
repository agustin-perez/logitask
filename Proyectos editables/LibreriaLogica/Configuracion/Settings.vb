<Serializable()> Public Class Settings
    Private Shared instancia As Settings
    Private rutaDSN As String
    Private databaseUser As String
    Private databasePassword As String
    Private lang As LangEnum
    Private nightMode As Boolean

    Public Shared Function GetSingleton() As Settings
        If instancia Is Nothing Then
            instancia = New Settings
        End If
        Return instancia
    End Function

    Public Sub SetInstancia(instance As Settings)
        instancia = instance
    End Sub

    Public Enum LangEnum
        ES_LA = 0
        EN_UK = 1
        PT_BR = 2
    End Enum

    Public Sub SetupBD()
        Dim securityLayer As New Encriptacion
        ConsultasPrincipales.GetSingleton.SetUserBBDD = securityLayer.Base64Decode(databaseUser)
        ConsultasPrincipales.GetSingleton.SetPassBBDD = securityLayer.Base64Decode(databasePassword)
        EntradaSalida.GetSingleton.RutaDsnCFG = securityLayer.Base64Decode(rutaDSN)
        '  ConsultasPrincipales.GetSingleton.ActivarConexion()
    End Sub

    Public Property RutaDsnCFG() As String
        Get
            Dim securityLayer As New Encriptacion
            Return securityLayer.Base64Decode(rutaDSN)
        End Get
        Set(value As String)
            Dim securityLayer As New Encriptacion
            rutaDSN = securityLayer.Base64Encode(value)
        End Set
    End Property

    Public WriteOnly Property SetDatabaseUser() As String
        Set(value As String)
            Dim securityLayer As New Encriptacion
            databaseUser = securityLayer.Base64Encode(value)
        End Set
    End Property

    Public WriteOnly Property SetDatabasePassword() As String
        Set(value As String)
            Dim securityLayer As New Encriptacion
            databasePassword = securityLayer.Base64Encode(value)
        End Set
    End Property

    Public Property LangCFG() As LangEnum
        Get
            Return lang
        End Get
        Set(value As LangEnum)
            lang = value
        End Set
    End Property

    Public Property NightModeCFG() As Boolean
        Get
            Return nightMode
        End Get
        Set(value As Boolean)
            nightMode = value
        End Set
    End Property
End Class
