Imports System.Globalization

Public Class Transportista
    Private Shared instancia As Transportista
    Private embarqueQuery As String = ("insert into embarque (idlote, numerocoche, username, ubicacion) values(?, ?, ?, ?)")

    Public Shared Function GetSingleton() As Transportista
        If instancia Is Nothing Then
            instancia = New Transportista
        End If
        Return instancia
    End Function

    Public Function ListadoMediosTransporte() As DataTable
        Dim consulta As String = ("select * from mediostransporte") 'PASAR A VISTA
        Return ConsultasDeLectura.GetSingleton.ConsultaTabla(consulta)
    End Function

    Public Sub DisparaEmbarque(idlote As Int32, numerocoche As Int32, username As String, ubicacion As String)
        Dim paramsConsulta As New ParametrosDeConsulta
        paramsConsulta.AgregarParametro(Of Int32)(idlote, DbType.Int32)
        paramsConsulta.AgregarParametro(Of Int32)(numerocoche, DbType.Int32)
        paramsConsulta.AgregarParametro(Of String)(username, DbType.String)
        paramsConsulta.AgregarParametro(Of String)(idlote, DbType.String)
        ConsultasDeEscritura.GetSingleton.InsertarPorParams(embarqueQuery, paramsConsulta.GetLista)
    End Sub

    Public Sub UpdateCoord(coordenadas As String, idembarque As Int32)
        ConsultasDeLectura.GetSingleton.ConsultaValor("execute procedure actualizarcoordenadas('" & coordenadas & "','" & idembarque & "');")
    End Sub

    Public Function GetIDEmbarqueActual() As Integer
        Return ConsultasDeLectura.GetSingleton.ConsultaValor("execute procedure obtenerultimoembarque()")
    End Function

    Public Function ListadoZonasPrincipales() As DataTable
        Return ConsultasDeLectura.GetSingleton.ConsultaTabla("select * from lugar where idlugar not in (select idsub from sublugar);")
    End Function

    Public Function GetLugarPorNombre(nombre As String) As DataTable
        Return ConsultasDeLectura.GetSingleton.ConsultaTabla("select * from lugar where idlugar not in (select idsub from sublugar) and nombre ='" & nombre & "';")
    End Function

    Public Sub InsertarLlegadaEmbarque(idlugar As Integer, idembarque As Integer)
        Dim params As New ParametrosDeConsulta
        params.AgregarParametro(Of Integer)(idlugar, DbType.Int32)
        params.AgregarParametro(Of Integer)(idembarque, DbType.Int32)
        ConsultasDeEscritura.GetSingleton.InsertarPorParams("insert into lugardestinoembarque (idlugar, idembarque, llegada) values (?, ?, current)", params.GetLista)
    End Sub
End Class
