Imports LibreriaDatos
''' <summary>
''' Clase encargada de administrar la lógica de consultas y acceso a la Base de Datos de la aplicación SliferOperators.
''' </summary>
Public Class Operarios
    Private Shared instancia As Operarios
    Private consultaInspeccion As String
    Private parametrosDamages As New List(Of ParametrosDeConsulta)
    Private paramsDamage As ParametrosDeConsulta
    Private paramsInspecc As ParametrosDeConsulta
    Private ReadOnly consultaDamage As String = ("insert into damage (numeroinspec, VIN, imagen, descripcion) values (?, ?, ?, ?);")
    Private ReadOnly consultaInspecc As String = ("insert into inspeccion (VIN, username, lugar, fecha) values (?, ?, ?,current);")
    ''' <summary>
    ''' Función compartida encargada de cumplir el patrón singleton mediante una única instancia de la clase.
    ''' </summary>
    ''' <returns>Instancia de la clase.</returns>
    Public Shared Function GetSingleton() As Operarios
        If instancia Is Nothing Then
            instancia = New Operarios
        End If
        Return instancia
    End Function
    ''' <summary>
    ''' Consulta encargada de consultar los ID de los diferentes lugares (puerto, patio, etc) que están albergados en la Base de Datos.
    ''' </summary>
    ''' <returns>Tabla conteniendo un select de todos los ID de lugares.</returns>
    Public Function ConsultaLugares() As DataTable
        Return ConsultasDeLectura.GetSingleton.ConsultaTabla("select idlugar from lugar")
    End Function
    ''' <summary>
    ''' Función encargada de devolver el nombre de un lugar según su ID para el listado de inspecciones, etc.
    ''' </summary>
    ''' <param name="idlugar">ID del lugar a consultar su nombre.</param>
    ''' <returns></returns>
    Public Function ConsultaNombreLugar(idlugar As Integer) As String
        Dim resultado As DataRow
        resultado = ConsultasDeLectura.GetSingleton.ConsultaValor("select nombre from lugar where idlugar = '" + idlugar + "'")
        Return resultado.Item(0)
    End Function

    Public Function VerificarInspeccion()
        Return vbNull
    End Function

    Public Sub ConsultaOperarios(username As String)
        DatosSesion.GetSingleton.TipoOperario = ConsultasDeLectura.GetSingleton.ConsultaValor("execute procedure consultaoperariotipo('" + username + "');")
    End Sub

    'AGREGAR DOC XML

    Public Sub GuardarVehiculoLote(vin As String, idlote As Integer)
        Dim paramsVLote As New ParametrosDeConsulta
        paramsVLote.AgregarParametro(Of String)(vin, DbType.String)
        paramsVLote.AgregarParametro(Of Integer)(idlote, DbType.Int32)
        ConsultasDeEscritura.GetSingleton.InsertarPorParams("insert into vehiculosEnLote values(?, ?, 'F');", paramsVLote.GetLista)
    End Sub

    Public Sub GuardarLote(username As String, nombre As String, descripcion As String, llegadaestimada As DateTime)
        Dim paramsLote As New ParametrosDeConsulta
        paramsLote.AgregarParametro(Of String)(username, DbType.String)
        paramsLote.AgregarParametro(Of String)(nombre, DbType.String)
        paramsLote.AgregarParametro(Of String)(descripcion, DbType.String)
        paramsLote.AgregarParametro(Of Date)(llegadaestimada, DbType.DateTime)
        ConsultasDeEscritura.GetSingleton.InsertarPorParams("insert into lote (username, nombre, descripcion, llegadaestimada) values (?, ?, ?, ?);", paramsLote.GetLista)
    End Sub

    Public Function GetIdLote() As Int32
        Return ConsultasDeLectura.GetSingleton.ConsultaValor("execute procedure obtenerultimolote();")
    End Function

    Public Function ChequeoLote(vin As String) As Boolean
        Return ConsultasDeLectura.GetSingleton.ConsultaValor("execute procedure checkvehiculolote('" + vin + "');")
    End Function
    ''' <summary>
    ''' Función encargada de consultar a la Base de Datos el número de inspección autosumado para agregar a la clave primaria de una nueva inspección en ConsultaLugares().
    ''' </summary>
    ''' <param name="vin">VIN del vehículo a consultar su número de inspecciones.</param>
    ''' <returns>Número de inspecciones si la Base de Datos devuelve algo, si da excepción (indicador de que no se pudo realizar la autosuma), devuelve cero, indicando que es su primera inspección.</returns>
    Public Function GetNumeroInspecc(vin As String) As Integer
        Try
            Dim conteo As Integer = ConsultasDeLectura.GetSingleton.ConsultaValor("select max(numeroinspec) from inspeccion where vin = '" + vin + "';")
            conteo += 1
            Return conteo
        Catch ex As Exception
            Return 0
        End Try
    End Function
    ''' <summary>
    ''' Subrutina encargada de guardar una inspección en la Base de Datos.
    ''' </summary>
    ''' <param name="vin">VIN del vehículo (parte de la primary key).</param>
    ''' <param name="lugar">Lugar donde fue realizada la inspección. Quedará determinado según el Admin</param>
    Public Sub GuardarInspeccion(vin As String, lugar As Integer)
        If Not DatosSesion.GetSingleton.IsOperarioApp Then
            'ConsultasDeLectura.GetSingleton
            lugar = 1 'UTILIZAR FLUJO DE VEHÍCULO POR FAVOR, ESTO ES PARA QUE NO EXPLOTE
        End If
        paramsInspecc = New ParametrosDeConsulta
        paramsInspecc.AgregarParametro(Of String)(vin, DbType.String)
        paramsInspecc.AgregarParametro(Of String)(DatosSesion.GetSingleton.UserLogged, DbType.String)
        paramsInspecc.AgregarParametro(Of Integer)(lugar, DbType.Int32)
    End Sub
    ''' <summary>
    ''' Subrutina encargada de agregar consultas listas con los daños a una lista de consultas y parámetros de esta clase.
    ''' </summary>
    ''' <param name="vin">VIN del vehículo (parte de la primary key).</param>
    ''' <param name="imagen">Imagen del daño.</param>
    ''' <param name="descripcion">Descripción del daño.</param>
    Public Sub Damages(vin As String, imagen As Byte(), descripcion As String)
        paramsDamage = New ParametrosDeConsulta
        paramsDamage.AgregarParametro(Of Integer)(ConsultasDeLectura.GetSingleton.GetUltimaInspeccion() + 1, DbType.Int32)
        paramsDamage.AgregarParametro(Of String)(vin, DbType.String)
        paramsDamage.AgregarParametro(Of Byte())(imagen, DbType.Binary)
        paramsDamage.AgregarParametro(Of String)(descripcion, DbType.String)
        parametrosDamages.Add(paramsDamage)
    End Sub
    ''' <summary>
    ''' Subrutina encargada de enviar las listas con consultas y parámetros a la clase ConsultasDeEscritura, para enviarlas a la Base de Datos.
    ''' </summary>
    Public Sub MandarConsultasInspecc()
        ConsultasDeEscritura.GetSingleton.InsertarPorParams(consultaInspecc, paramsInspecc.GetLista)
        For Each var As ParametrosDeConsulta In parametrosDamages
            If parametrosDamages.Count > 0 Then
                ConsultasDeEscritura.GetSingleton.InsertarPorParams(consultaDamage, var.GetLista)
            End If
        Next
        parametrosDamages.Clear()
        paramsInspecc.GetLista.Clear()
    End Sub
    ''' <summary>
    ''' Función en construcción !!!!!!!!!!!!!!!!!
    ''' </summary>
    ''' <param name="vin"></param>
    ''' <returns></returns>
    Public Function ListadoFlujo(vin As String)
        ' Dim consulta As String("")
        Return vbNull
    End Function

    Public ReadOnly Property GetDamageList() As Int32
        Get
            Return parametrosDamages.Count
        End Get
    End Property
End Class
