Imports System.Globalization

Public Class Admin
    ''' <summary>
    ''' Clase encargada de administrar la lógica de consultas y acceso a la Base de Datos de la aplicación SliferAdmin.
    ''' </summary>
    Private Shared instancia As Admin
    ''' <summary>
    ''' Función shared encargada de seguir devolver la instancia de la clase según el patrón singleton.
    ''' </summary>
    ''' <returns>Instancia de la clase.</returns>
    Public Shared Function GetSingleton() As Admin
        If instancia Is Nothing Then
            instancia = New Admin
        End If
        Return instancia
    End Function
    ''' <summary>
    ''' Subrutina encargada de realizar un insert por parámetros de un usuario nuevo.
    ''' </summary>
    ''' <param name="username">Nombre de usuario para el nuevo usuario.</param>
    ''' <param name="pass">Contraseña del usuario a encriptar.</param>
    ''' <param name="nombre">Nombre de la persona.</param>
    ''' <param name="apellido">Apellido de la persona.</param>
    ''' <param name="tel1">Teléfono de línea de la persona.</param>
    ''' <param name="tel2">Celular de la persona.</param>
    Public Sub AltaUsuario(username As String, pass As String, nombre As String, apellido As String, tel1 As String, tel2 As String)
        'Consulta para el usuario -----------------------------------------------------------------
        Dim passEncrypt As New Encriptacion
        pass = passEncrypt.SHA256(pass)
        Dim parametros As New ParametrosDeConsulta
        parametros.AgregarParametro(Of String)(username, DbType.String)
        parametros.AgregarParametro(Of String)(pass, DbType.String)
        parametros.AgregarParametro(Of String)(nombre, DbType.String)
        parametros.AgregarParametro(Of String)(apellido, DbType.String)
        Dim consulta As String = ("insert into empleado values (?, ?, ?, ?, 'f')")
        ConsultasDeEscritura.GetSingleton.InsertarPorParams(consulta, parametros.GetLista)

        'Consulta para el primer teléfono ---------------------------------------------------------
        If tel1 <> "" Then
            Dim consultaTel1 As String = ("insert into telefonosEmp values (?, ?)")
            Dim parametrosTel1 As New ParametrosDeConsulta
            parametrosTel1.AgregarParametro(Of String)(username, DbType.String)
            parametrosTel1.AgregarParametro(Of String)(tel1, DbType.String)
            ConsultasDeEscritura.GetSingleton.InsertarPorParams(consultaTel1, parametrosTel1.GetLista)
        End If

        'Consulta para el segundo teléfono --------------------------------------------------------
        If tel2 <> "" Then
            Dim consultaTel2 As String = ("insert into telefonosEmp values (?, ?)")
            Dim parametrosTel2 As New ParametrosDeConsulta
            parametrosTel2.AgregarParametro(Of String)(username, DbType.String)
            parametrosTel2.AgregarParametro(Of String)(tel2, DbType.String)
            ConsultasDeEscritura.GetSingleton.InsertarPorParams(consultaTel2, parametrosTel2.GetLista)
        End If
    End Sub
    ''' <summary>
    ''' Funcion encargada de "eliminar" (baja lógica) un vehículo dado su vin, en conexión con la Base de Datos.
    ''' </summary>
    ''' <param name="vin">Vin del vehículo a "eliminar".</param>
    ''' <returns>Resultado de la operación (fallido o correcto).</returns>
    Public Function EliminarVehiculo(vin As String) As Boolean
        Return ConsultasDeLectura.GetSingleton.ConsultaValor("execute procedure eliminarvehiculo('" & vin & "');")
    End Function
    ''' <summary>
    ''' Función encargada de modificar los datos de un vehículo dado su vin y sus atributos modificados.
    ''' </summary>
    ''' <param name="vin">Vin del vehículo a modificar.</param>
    ''' <param name="marca">Nueva marca del vehículo.</param>
    ''' <param name="modelo">Nuevo modelo del vehículo.</param>
    ''' <param name="release">Nueva fecha de lanzamiento del vehículo.</param>
    ''' <param name="color">Nuevo color del vehículo (Altamente recomendable utilizar colores conocidos para cambiar el color en listado).</param>
    ''' <param name="tipo">Tipo del vehículo según los parámetros especificados en el Diccionario de Datos.</param>
    ''' <returns>Resultado de la operación (fallido o correcto).</returns>
    Public Function UpdatearVehiculo(vin As String, marca As String, modelo As String, release As Date, color As String, tipo As Char) As Boolean
        Return ConsultasDeLectura.GetSingleton.ConsultaValor("execute procedure updatevehiculo('" & vin & "','" & marca & "','" & modelo & "','" & release.Year & "','" & color & "','" & tipo & "');")
    End Function
    Public Sub InsertarVehiculos(tupla As DataRow)
        Dim params As New ParametrosDeConsulta
        params.AgregarParametro(Of String)(tupla.Field(Of String)(0), DbType.String)
        params.AgregarParametro(Of String)(tupla.Field(Of String)(1), DbType.String)
        params.AgregarParametro(Of String)(tupla.Field(Of String)(2), DbType.String)
        params.AgregarParametro(Of Date)(DateTime.ParseExact(tupla.Field(Of Integer)(3), "yyyy", CultureInfo.InvariantCulture), DbType.Date)
        params.AgregarParametro(Of String)(tupla.Field(Of String)(4), DbType.String)
        params.AgregarParametro(Of Char)(tupla.Field(Of String)(5), DbType.String)
        ConsultasDeEscritura.GetSingleton.InsertarPorParams("insert into vehiculo (vin, marca, modelo, release, color, tipo) values (?,?,?,?,?,?);", params.GetLista)
    End Sub
End Class
