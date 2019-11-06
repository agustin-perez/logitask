Imports System.Windows.Forms
Imports System.Data.Odbc
Imports LibreriaDatos
Public Class ConsultasPrincipales
    Private Shared Instancia As ConsultasPrincipales
    Private UserBBDD As String
    Private PassBBDD As String
    Private query As New OdbcCommand
    Private lector As OdbcDataReader

    Public Shared Function GetSingleton() As ConsultasPrincipales
        If (Instancia Is Nothing) Then
            Instancia = New ConsultasPrincipales
        End If
        Return Instancia
    End Function

    Public Enum TipoAppEnum As Int16
        Admin = 0
        Puerto = 1
        Patio = 2
        Transportista = 3
    End Enum

    Public Function ActivarConexion() 'ANTES DE LLAMAR A ESTA SUBRUTINA SETEAR USER Y PASS EN LAS PROPERTIES 
        Try
            If Not Conexion.GetSingleton.IsActive Then
                Conexion.GetSingleton.CrearConexion(EntradaSalida.GetSingleton.RutaDsnCFG, UserBBDD, PassBBDD)
                query.Connection = Conexion.GetSingleton.ConexionInstanciada
                Return True
            End If
        Catch ex As exception
        End Try
        Return False
    End Function

    Public Function VerificarRol(user As String) As TipoAppEnum
        Return CType(ConsultasDeLectura.GetSingleton.ConsultaValor("execute procedure verificarrol('" + user + "')"), Int16)
    End Function

    Public Function ConsultaLogin(user As String, pass As String) As Boolean
        Dim hasheo As New Encriptacion
        Dim passHasheada As String = hasheo.SHA256(pass)
        If ConsultasDeLectura.GetSingleton.ConsultaValor("execute procedure consultalogin('" + user + "', '" + passHasheada + "');") Then
            Return True
        End If
        Return False
    End Function

    Public Function SolicitarPassChange(oldpass As String, newpass As String) As Boolean
        Dim hash As New Encriptacion
        If ConsultasDeLectura.GetSingleton.ConsultaValor("execute procedure cambiarpass('" & DatosSesion.GetSingleton.UserLogged & "','" & hash.SHA256(oldpass) & "','" & hash.SHA256(newpass) & "';") Then
            Return True
        End If
        Return False
    End Function

    Public Property SetUserBBDD() As String
        Get
            Return UserBBDD
        End Get
        Set(ByVal value As String)
            UserBBDD = value
        End Set
    End Property

    Public Property SetPassBBDD() As String
        Get
            Return PassBBDD
        End Get
        Set(ByVal value As String)
            PassBBDD = value
        End Set
    End Property
End Class
