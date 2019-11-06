Imports LibreriaDatos
Imports System.Data.Odbc
Public Class ConsultasDeLectura
    Inherits ConsultasPrincipales
    Private Shared instancia As ConsultasDeLectura
    Private query As New OdbcCommand
    Private lector As OdbcDataReader

    Public Overloads Shared Function GetSingleton() As ConsultasDeLectura
        If (instancia Is Nothing) Then
            instancia = New ConsultasDeLectura
        End If
        Return instancia
    End Function

    Public Function ListadoVehiculos() As DataTable
        Dim consulta As String = ("select * from vehiculo where bajalogica = 'F';")
        Return ConsultaTabla(consulta)
    End Function

	Public Function ListadoLugares() As DataTable
        Dim consulta As String = ("select * from lugar where bajalogica = 'F';") 'select lugar.idlugar, lugar.nombre, lugar.descripcion, lugar.capacidad from lugar left join sublugar on lugar.idlugar != sublugar.idsub;")
        Return ConsultaTabla(consulta)
	End Function

	Public Function ListadoVehiculosEnLugar() As DataTable
        Dim consulta As String = ("select * from vehiculo where VIN in (select VIN from subLugarVehiculo where bajalogica = 'F') and bajalogica = 'F';") 'COMPROBAR SI ESTA CORRECTO
        Return ConsultaTabla(consulta)
	End Function

	Public Function ListadoDamagesByVIN(vin As String) As DataTable
        Dim consulta As String = ("select * from damage where vin = '" + vin + "' and bajalogica = 'F';")
        Return ConsultaTabla(consulta)
    End Function

    Public Function ListadoDamagesByInspec(nroInspec As Integer, vin As String) As DataTable
        Dim consulta As String = ("select * from damage where numeroInspec = '" + nroInspec.ToString + "' and vin = '" + vin + "' and bajalogica = 'F';")
        Return ConsultaTabla(consulta)
    End Function

    Public Function BusquedaVin(vin As String) As DataTable
        Dim consulta As String = ("select * from vehiculo where vin = '" + vin + "' and bajalogica = 'F';")
        Return ConsultaTabla(consulta)
    End Function

    Public Function ListadoInspecciones(vin As String) As DataTable
        Dim consulta As String = ("select * from inspeccion where vin = '" + vin + "';")
        Return ConsultaTabla(consulta)
    End Function

    Public Function GetUltimaInspeccion() As Int32
        Dim consulta As String = ("execute procedure obtenerultimainspeccion();")
        Return ConsultaValor(consulta)
    End Function

    Public Function LugarPorId(id As Integer) As String
        Dim consulta As String = ("execute procedure lugarporid('" + id.ToString + "');")
        Return ConsultaValor(consulta)
    End Function

    Public Function ListadoLotes()
        Dim consulta As String = ("select * from lote where bajalogica = 'F';")
        Return ConsultaTabla(consulta)
    End Function

    Public Function ListadoLotesListos()

    End Function

    Public Function GetUltimaInspeccionVehiculo(vin As String)
        Return ConsultaValor("select count(*) from inspeccion where vin = '" & vin & "';")
    End Function

    Public Function MaxVehiculosLote()
        Dim consulta As String = ("execute procedure cantidadvehiculosmaxlote();")
        Return ConsultaValor(consulta)
    End Function

    Public Function VehiculosPorLote(id As Int32)
        Dim consulta As String = ("execute procedure cantidadvehiculosporlote('" + id.ToString + "');")
        Return ConsultaValor(consulta)
    End Function

    Public Function VehiculosDeLote(idlote As Int32)
        Dim consulta As String = ("select * from vehiculo left join vehiculosenlote on vehiculo.vin = vehiculosenlote.vin
		where vehiculosenlote.idlote = '" + idlote.ToString + "' and vehiculo.bajalogica = 'F' and vehiculosenlote.bajalogica = 'F';")
        Return ConsultaTabla(consulta)
    End Function

    Public Function EsperandoEnPuerto(vin As String)
        Return ConsultaValor("execute procedure flujoesperapuerto('" & vin & "');")
    End Function

    Public Function ListoPartir(vin As String)
        Return ConsultaValor("execute procedure flujopartir('" & vin & "');")
    End Function

    Public Function EsperaPatio(vin As String)
        Return ConsultaValor("execute procedure flujoesperapatio('" & vin & "');")
    End Function

    Public Function EnSubZona(vin As String)
        Return ConsultaValor("execute procedure flujosubzona('" & vin & "');")
    End Function

    Public Function GetCoordenadas(vin As String)
        Return ConsultaValor("select ubicacion from embarque where idlote in (select idlote from vehiculosenlote where vin = '" & vin & "') and idembarque in (select max(idembarque) from embarque);")
    End Function

    Public Function TransporteVehiculos(vin As String) As Integer
        Return ConsultaValor("select count(ubicacion) from embarque where idlote in (select idlote from vehiculosenlote where vin = '" & vin & "') and idembarque in (select max(idembarque) from embarque);")
    End Function

    Public Function VehiculoRepetido() As Boolean
        '''''''''''''''''USAR PROCEDURE NUEVOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO HOJOOOOOOOOOOOOOOOO NEIN NIET NICHEVO 
    End Function

    Public Function HoraDatabase()
        'SIN TERMINAR (SELECT CURRENT FROM TABLA)
        Return vbNull
    End Function

    Public Function ConsultaTabla(queryText As String) As DataTable
        Try
            Dim datosConsulta As New DataTable
            Dim socketDatos As New OdbcDataAdapter(queryText, Conexion.GetSingleton.ConexionInstanciada)
            socketDatos.Fill(datosConsulta)
            Return datosConsulta
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ConsultaValor(consulta As String)
        Try
            query.Connection = Conexion.GetSingleton.ConexionInstanciada
            query.CommandText = consulta
            Return query.ExecuteScalar
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
