Imports System.Data.Odbc
Public Class Datos
	Shared comando As New Odbc.OdbcCommand
	Shared conexion As New OdbcConnection
	Private Shared usuarioLogeado As String
	Public Property usuarioLogeadoProperty() As String
		Get
			Return usuarioLogeado
		End Get
		Set(ByVal value As String)
			usuarioLogeado = value
		End Set
	End Property

	Public Shared Sub insertIniciales()
		Dim sql As String
		Dim resultado As DataTable
		resultado = New DataTable
		sql = "SELECT nombreuser FROM usuario Where nombreuser = 'rexled'"
		conexion.Open()
		comando.Connection = conexion
		comando.CommandText = sql
		comando.ExecuteReader()
		Dim adaptador As New OdbcDataAdapter(sql, conexion)
		adaptador.Fill(resultado)
		conexion.Close()
		If resultado.Rows.Count <> 0 Then 'checkea si la datatable tiene columnas lo que quiere decir que existe el usuario rexled
			'no lo agrega
		Else
			'lo agrega

			conexion.Open()
			sql = "INSERT INTO usuario VALUES ('rexled','Roberto','Nuniez');"
			comando.Connection = conexion
			comando.CommandText = sql
			comando.ExecuteReader()
			conexion.Close()
			conexion.Open()
			sql = "INSERT INTO contrasenia_usuario VALUES ('rexled',1234567890);"
			comando.Connection = conexion
			comando.CommandText = sql
			comando.ExecuteReader()
			conexion.Close()
		End If
		resultado = New DataTable
		sql = "SELECT codigolote FROM lote Where codigolote = 0"
		conexion.Open()
		comando.Connection = conexion
		comando.CommandText = sql
		comando.ExecuteReader()
		conexion.Close()
		Dim adaptador2 = New OdbcDataAdapter(sql, conexion)
		adaptador2.Fill(resultado)
		If resultado.Rows.Count <> 0 Then 'checkea si la datatable tiene columnas 
			'no lo agrega
		Else
			'lo agrega
			conexion.Open()
			sql = "INSERT INTO lote values (0,'loteFicticio','Este es un lote ficticio','rexled')"
			comando.Connection = conexion
			comando.CommandText = sql
			comando.ExecuteReader()
			conexion.Close()
		End If
	End Sub

	Public Shared Sub vhListoPartir(codigoInspEnCurso As Integer, lugarEnCurso As String, fechaEnCurso As Date,
									dañoAnteriorEnCurso As String, vin As String)
		setCodigoInsp()
		Dim sql As String
		conexion.Open()
		sql = "insert into inspeccion values (" & codigoInspEnCurso & ",'" & "no','" & lugarEnCurso & "','" & fechaEnCurso & "','no" & "','" & dañoAnteriorEnCurso & "','" & vin & "');"
		comando.Connection = conexion
		comando.CommandText = sql
		comando.ExecuteReader()
		conexion.Close()
		conexion.Open()
		sql = "update vehiculo set listo = 'si' , estado = 'Inspeccionado'  where vin ='" & vin & "'"
		comando.Connection = conexion
		comando.CommandText = sql
		comando.ExecuteReader()
		conexion.Close()
		MsgBox("Vehiculo Inspeccionado")
		operarioPuerto.realizarInspeccionButton.PerformClick()
	End Sub

	Public Shared Sub vhListoPartir2(codigoInspEnCurso As Integer, lugarEnCurso As String, fechaEnCurso As Date,
									dañoAnteriorEnCurso As String, vin As String)
		setCodigoInsp()
		Dim sql As String
		conexion.Open()
		sql = "insert into inspeccion values (" & codigoInspEnCurso & ",'" & "no','" & lugarEnCurso & "','" & fechaEnCurso & "','no" & "','" & dañoAnteriorEnCurso & "','" & vin & "');"
		comando.Connection = conexion
		comando.CommandText = sql
		comando.ExecuteReader()
		conexion.Close()
		conexion.Open()
		sql = "update vehiculo set listo = 'si' , estado = 'Inspeccionado segunda'  where vin ='" & vin & "'"
		comando.Connection = conexion
		comando.CommandText = sql
		comando.ExecuteReader()
		conexion.Close()
		MsgBox("Vehiculo Inspeccionado")
		operarioPatio.realizarInspeccionButton.PerformClick()
	End Sub

	Public Shared Function getDañoAnterior(vin As String) As String
		conexion.Open()
		Dim datos As New DataTable()
		Dim sql As String
		sql = "select danioanterior from inspeccion where vin=" & vin
		Dim adaptador As New OdbcDataAdapter(sql, conexion)

		adaptador.Fill(datos)
		conexion.Close()
		Return datos.Rows(0).Item(0).ToString()
	End Function

	Public Shared Sub ingresarDaño(vin As String, codigoInsp As Integer,
								   lugar As String, fecha As Date, descDaño As String, dañoAnterior As String, imagen As String)
		Dim sql As String
		Dim resultado As DataTable
		Dim marca As String
		Dim modelo As String
		Dim anio As Integer
		Dim tipo As String
		Dim colorAuto As String

		resultado = New DataTable
		sql = "select * from vehiculo where vin ='" & vin & "'"
		Dim adaptador As New OdbcDataAdapter(sql, conexion)
		conexion.Open()
		comando.Connection = conexion
		comando.CommandText = sql
		comando.ExecuteReader()
		adaptador.Fill(resultado)
		conexion.Close()
		marca = Convert.ToString(resultado.Rows(0).Item(1))
		modelo = Convert.ToString(resultado.Rows(0).Item(2))
		anio = Convert.ToInt32(resultado.Rows(0).Item(3))
		tipo = Convert.ToString(resultado.Rows(0).Item(4))
		colorAuto = Convert.ToString(resultado.Rows(0).Item(5))

		conexion.Open()
		sql = "insert into inspeccion values (" & codigoInsp & ",'" & imagen & "','" & lugar & "','" & fecha & "','" & descDaño & "','" & dañoAnterior & "','" & vin & "');"
		comando.Connection = conexion
		comando.CommandText = sql
		comando.ExecuteReader()
		conexion.Close()
		conexion.Open()
		sql = "insert into danio values ('" & vin & "','" & descDaño & "');"
		comando.Connection = conexion
		comando.CommandText = sql
		comando.ExecuteReader()
		conexion.Close()
		conexion.Open()
		sql = "update vehiculo set listo = 'si' , estado = 'Inspeccionado' where vin ='" & vin & "'"
		comando.Connection = conexion
		comando.CommandText = sql
		comando.ExecuteReader()
		conexion.Close()
		operarioPuerto.mainMenu()
		operarioPuerto.displayOFF()
		operarioPuerto.imagenOFD.FileName = Nothing
		operarioPuerto.evidenciaLabel.ForeColor = Color.Red
		operarioPuerto.evidenciaLabel.Text = "Ningún archivo seleccionado"
		MsgBox("Daño añadido")
		MsgBox("Inspección Realizada")
	End Sub

	Public Shared Sub ingresarDaño2(vin As String, codigoInsp As Integer,
								   lugar As String, fecha As Date, descDaño As String, dañoAnterior As String, imagen As String)
		Dim sql As String
		Dim resultado As DataTable
		Dim marca As String
		Dim modelo As String
		Dim anio As Integer
		Dim tipo As String
		Dim colorAuto As String

		resultado = New DataTable
		sql = "select * from vehiculo where vin ='" & vin & "'"
		Dim adaptador As New OdbcDataAdapter(sql, conexion)
		conexion.Open()
		comando.Connection = conexion
		comando.CommandText = sql
		comando.ExecuteReader()
		adaptador.Fill(resultado)
		conexion.Close()
		marca = Convert.ToString(resultado.Rows(0).Item(1))
		modelo = Convert.ToString(resultado.Rows(0).Item(2))
		anio = Convert.ToInt32(resultado.Rows(0).Item(3))
		tipo = Convert.ToString(resultado.Rows(0).Item(4))
		colorAuto = Convert.ToString(resultado.Rows(0).Item(5))

		conexion.Open()
		sql = "insert into inspeccion values (" & codigoInsp & ",'" & imagen & "','" & lugar & "','" & fecha & "','" & descDaño & "','" & dañoAnterior & "','" & vin & "');"
		comando.Connection = conexion
		comando.CommandText = sql
		comando.ExecuteReader()
		conexion.Close()
		conexion.Open()
		sql = "insert into danio values ('" & vin & "','" & descDaño & "');"
		comando.Connection = conexion
		comando.CommandText = sql
		comando.ExecuteReader()
		conexion.Close()
		conexion.Open()
		sql = "update vehiculo set listo = 'si' , estado = 'Inspeccionado segunda' where vin ='" & vin & "'"
		comando.Connection = conexion
		comando.CommandText = sql
		comando.ExecuteReader()
		conexion.Close()
		operarioPuerto.mainMenu()
		operarioPuerto.displayOFF()
		operarioPuerto.imagenOFD.FileName = Nothing
		operarioPuerto.evidenciaLabel.ForeColor = Color.Red
		operarioPuerto.evidenciaLabel.Text = "Ningún archivo seleccionado"
		MsgBox("Daño añadido")
		MsgBox("Inspección Realizada")
	End Sub

	Public Shared Sub crearLote(codigoloteEnCurso As Integer, nombreLoteEnCurso As String, DescripcionLoteEnCurso As String)
		Dim sql As String
		conexion.Open()
		sql = "insert into lote values(" & codigoloteEnCurso & ",'" & nombreLoteEnCurso & "','" & DescripcionLoteEnCurso & "','" & usuarioLogeado & "');"
		comando.Connection = conexion
		comando.CommandText = sql
		comando.ExecuteReader()
		conexion.Close()
	End Sub

	Public Shared Sub seleccionarVehiculoListo(vin As String, codigoloteEnCurso As Integer)
		Dim sql As String
		conexion.Open()
		sql = "update vehiculo set codigolote =" & codigoloteEnCurso & ", estado = 'En lote' where vin ='" & vin & "';"
		comando.Connection = conexion
		comando.CommandText = sql
		comando.ExecuteReader()
		conexion.Close()
	End Sub

	Public Shared Sub eliminarLote(codigoLote As Integer, index As Integer)
		Dim sql As String
		conexion.Open()
		sql = "update vehiculo set codigolote = 0, estado = 'Inspeccionado' where codigolote=" & codigoLote & ";"
		comando.Connection = conexion
		comando.CommandText = sql
		comando.ExecuteReader()
		conexion.Close()
		conexion.Open()
		sql = "delete from lote where codigolote=" & codigoLote & ";"
		comando.Connection = conexion
		comando.CommandText = sql
		comando.ExecuteReader()
		conexion.Close()
	End Sub

	Public Shared Sub poblarVehiculoSLote(ByRef tabla As DataGridView)
		conexion.Open()
		Dim datos As New DataTable()
		Dim sql As String
		sql = "select vin,marca from vehiculo where codigolote =0 and listo = 'si'" 'Si esta listo y no tiene un lote (codigolote = 0)
		Dim adaptador As New OdbcDataAdapter(sql, conexion)

		adaptador.Fill(datos)
		'operarioPuerto.vehiculoSLoteDGV.DataSource = datos
		tabla.DataSource = datos
		conexion.Close()
	End Sub

	Public Shared Sub poblarVerLote()
		conexion.Open()
		Dim datos As New DataTable()
		Dim sql As String
		sql = "select * from lote where codigolote >0"

		Dim adaptador As New OdbcDataAdapter(sql, conexion)

		adaptador.Fill(datos)
		operarioPuerto.verLotesDGV.DataSource = datos
		conexion.Close()
	End Sub

	Public Shared Sub poblarVerVehiculosEnLoteTransportado()
		conexion.Open()
		Dim datos As New DataTable()
		Dim sql As String
		sql = "select * from vehiculo where codigolote >0 and estado = 'Transportado'"
		'sql = "select * from vehiculo where codigolote >0 and codigolote is in (select codigolote from
		'transporta where codigolote is not null);"
		Dim adaptador As New OdbcDataAdapter(sql, conexion)
		'		Select * From vehiculo Where codigolote > 0 And codigolote In
		'(select codigolote from transporta where codigolote Is Not null);
		adaptador.Fill(datos)
		operarioPatio.vehiculosSInspeccionDGV.DataSource = datos
		conexion.Close()
	End Sub
	Public Shared Sub poblarVerLoteTransportista()
		conexion.Open()
		Dim datos As New DataTable()
		Dim sql As String
		sql = "select codigolote,nombrelote,descripcion from lote where codigolote >0 and codigolote Not in (select codigolote from
		transporta where codigolote is not null);"

		Dim adaptador As New OdbcDataAdapter(sql, conexion)

		adaptador.Fill(datos)
		transportista.verLotesDGV.DataSource = datos
		conexion.Close()
	End Sub


	Public Shared Sub poblarVerViajes()
		conexion.Open()
		Dim datos As New DataTable()
		Dim sql As String
		sql = "select * from transporta"

		Dim adaptador As New OdbcDataAdapter(sql, conexion)

		adaptador.Fill(datos)
		transportista.verViajesDGV.DataSource = datos
		conexion.Close()
	End Sub

	Public Shared Sub poblarVerVehiculo() 'Puebla el DataGridView
		conexion.Open()
		Dim datos As New DataTable()
		Dim sql As String
		sql = "select * from vehiculo"

		Dim adaptador As New OdbcDataAdapter(sql, conexion)

		adaptador.Fill(datos)
		operarioPuerto.verVehiculosDGV.DataSource = datos
		conexion.Close()
	End Sub

	Public Shared Sub poblarVerInspecciones()
		conexion.Open()
		Dim datos As New DataTable()
		Dim sql As String
		sql = "select * from inspeccion"

		Dim adaptador As New OdbcDataAdapter(sql, conexion)

		adaptador.Fill(datos)
		operarioPuerto.verInspeccionesDGV.DataSource = datos
		conexion.Close()
	End Sub

	Public Shared Sub poblarVerVehiculoSInspeccion()
		conexion.Open()
		Dim datos As New DataTable()
		Dim sql As String
		sql = "select * from vehiculo where listo = 'no'"
		Try
			Dim adaptador As New OdbcDataAdapter(sql, conexion)
			adaptador.Fill(datos)
			operarioPuerto.verVehiculosSInspeccionDGV.DataSource = datos
		Catch ex As Exception
		End Try
		conexion.Close()
	End Sub

	Public Shared Sub setCodigoInsp()
		Dim datos As New DataTable()
		conexion.Open()
		Dim sql As String
		sql = "SELECT codigoinsp From inspeccion Where codigoinsp = (Select MAX(codigoinsp) From inspeccion)"
		comando.Connection = conexion
		comando.CommandText = sql
		comando.ExecuteReader()
		Dim adaptador As New OdbcDataAdapter(sql, conexion)
		adaptador.Fill(datos)
		conexion.Close()
		Logica.setCodigoInsp(datos)
	End Sub

	Public Shared Sub setCodigoLote()
		conexion.Open()
		Dim sql As String
		Dim datos As New DataTable()
		sql = "SELECT codigolote From lote Where codigolote = (Select MAX(codigolote) From lote)"
		comando.Connection = conexion
		comando.CommandText = sql
		comando.ExecuteReader()
		Dim adaptador As New OdbcDataAdapter(sql, conexion)
		adaptador.Fill(datos)
		conexion.Close()
		Logica.setCodigoLote(datos)
	End Sub

	Public Shared Sub ingresarVehiculo(vin As String, marca As String, modelo As String, anio As Integer, color As String,
									  tipo As String)
		Try
			Dim sql As String
			conexion.Open()
			sql = "insert into vehiculo values (" & "'" & vin & "'," & "'" & marca & "'," & "'" & modelo & "'," & anio & "," & "'" & color & "'," & "'" & tipo & "',0" & "," & "'no'" & ",'En Puerto');"
			comando.Connection = conexion
			comando.CommandText = sql
			comando.ExecuteReader()
			conexion.Close()
			Logica.generarQR(vin)
			operarioPuerto.vehiculoObjeto()
			MsgBox("Vehiculo Ingresado con VIN: " + vin)
		Catch ex As Exception
			MsgBox(ex.ToString)
			MsgBox("vehiculo no ingresado")
			conexion.Close()
		End Try
	End Sub

	Public Shared Sub buscarVin(vin As String)
		Dim sql As String
		Dim datos As New DataTable()
		Try
			conexion.Open()
			sql = "select * from vehiculo where vin='" & vin & "'"
			comando.Connection = conexion
			comando.CommandText = sql
			comando.ExecuteReader()
			Dim adapatador As New OdbcDataAdapter(sql, conexion)
			adapatador.Fill(datos)
			conexion.Close()
			If datos.Rows.Count = 0 Then
				MsgBox("Vehiculo no encontrado con el vin: " + vin)
				poblarVerVehiculo()
			Else
				operarioPuerto.verVehiculosDGV.DataSource = Nothing
				operarioPuerto.verVehiculosDGV.DataSource = datos
				MsgBox("Vehiculo encontrado")
			End If
		Catch ex As Exception
			MsgBox("Vehiculo no encontrado con el vin: " + vin)
		End Try
		conexion.Close()
	End Sub

	Public Shared Sub conectarDB()
		Dim conectar As String
		Try

			conectar = "FileDsn=D:\informix.dsn; UID=informix; PWD=informix;"

			conexion.ConnectionString = conectar
			conexion.Open()
			conexion.Close()
		Catch ex As Exception
			MsgBox(ex.ToString)
			MsgBox("Error al conectarse con la Base de Datos")
			conexion.Close()
			operarioPuerto.Close()
		End Try
	End Sub

	Public Shared Sub poblarModificarLote()
		conexion.Open()
		Dim datos As New DataTable()
		Dim sql As String
		sql = "select * from lote where codigolote >0"

		Dim adaptador As New OdbcDataAdapter(sql, conexion)

		adaptador.Fill(datos)
		operarioPuerto.modificarLoteDGV.DataSource = datos
		conexion.Close()
	End Sub
	Public Shared Sub poblarVerVehiculosEnLote(codigoLote As Integer)
		conexion.Open()
		Dim datos As New DataTable()
		Dim sql As String
		sql = "select vin,marca from vehiculo where codigolote =" & codigoLote

		Dim adaptador As New OdbcDataAdapter(sql, conexion)

		adaptador.Fill(datos)
		operarioPuerto.vehiculoEnLoteDGV.DataSource = datos
		conexion.Close()
	End Sub

	Public Shared Sub ingresarVehiculoEnLote(vin As String, codigoLote As Integer)
		Dim opcion As Integer = MessageBox.Show("Desea Ingresar el vehiculo con el vin:" & vin & "?", "Confirmar", MessageBoxButtons.YesNo)
		If opcion = DialogResult.Yes Then
			Dim sql As String
			conexion.Open()
			sql = "update vehiculo set codigolote =" & codigoLote & ", estado = 'En lote' where vin='" & vin & "';"
			comando.Connection = conexion
			comando.CommandText = sql
			comando.ExecuteReader()
			conexion.Close()
			poblarVehiculoSLote(operarioPuerto.vehiculoCInpseccionDGV)
			poblarVerVehiculosEnLote(codigoLote)
		Else

		End If
	End Sub

	Public Shared Sub eliminarVehiculoDeLote(vin As String, codigoLote As Integer)
		Dim opcion As Integer = MessageBox.Show("Desea eliminar el vehiculo con el vin:" & vin & "del lote ?", "Confirmar", MessageBoxButtons.YesNo)
		If opcion = DialogResult.Yes Then
			If operarioPuerto.vehiculoEnLoteDGV.RowCount = 1 Then
				MsgBox("El lote debe contener un vehiculo como mínimo. Ninguna operación se realizará")
			Else
				Dim sql As String
				conexion.Open()
				sql = "update vehiculo set codigolote = 0 , set estado = 'En puerto' where vin='" & vin & "';"
				comando.Connection = conexion
				comando.CommandText = sql
				comando.ExecuteReader()
				conexion.Close()
				poblarVehiculoSLote(operarioPuerto.vehiculoCInpseccionDGV)
				poblarVerVehiculosEnLote(codigoLote)
			End If
		Else

		End If
	End Sub
	Public Shared Sub ingresarUsuario(cedula As String, contrasenia As String)
		Dim sql As String
		Dim datos As New DataTable
		Dim datos2 As New DataTable
		Dim datos3 As New DataTable
		conexion.Open()
		sql = "select * from usuario where nombreuser ='" & cedula & "';"

		Dim adaptador As New OdbcDataAdapter(sql, conexion)

		adaptador.Fill(datos)
		conexion.Close()
		If datos.Rows.Count <> 0 Then
			conexion.Open()
			sql = "select contrasenia from contrasenia_usuario where nombreuser ='" & cedula & "';"

			adaptador = New OdbcDataAdapter(sql, conexion)
			adaptador.Fill(datos2)
			conexion.Close()
			If datos2.Rows(0).Item(0).ToString() = contrasenia Then
				conexion.Open()
				sql = "select tipoop from operario where nombreuser ='" & cedula & "';"

				adaptador = New OdbcDataAdapter(sql, conexion)
				adaptador.Fill(datos3)
				conexion.Close()
				If datos3.Rows.Count <> 0 Then
					If datos3.Rows(0).Item(0).ToString() = "Operario Puerto" Then
						'es op puerto
						'Dim operario As New operarioPuerto
						operarioPuerto.Show()
						MsgBox("Bienvenido Op Puerto " + cedula)
						usuarioLogeado = cedula
						login.Close()
					ElseIf datos3.Rows(0).Item(0).ToString() = "Operario Patio" Then
						'es op patio
						'Dim patio As New operarioPatio
						operarioPatio.Show()
						MsgBox("Bienvenido Op Patio " + cedula)
						usuarioLogeado = cedula
						login.Close()
					End If
				Else 'es transportista
					'Dim trans As New transportista
					transportista.Show()
					MsgBox("Bienvenido Transportista " + cedula)
					usuarioLogeado = cedula
					login.Close()
					End If
				Else
					MsgBox("Contraseña equivocada")
					login.iCedulaTextBox.Text = ""
					login.iContraTextBox.Text = ""
				End If
			Else
			MsgBox("No existe usuario con la cedula: " + cedula)
			login.iCedulaTextBox.Text = ""
			login.iContraTextBox.Text = ""
		End If
	End Sub

	Public Shared Sub setUser(user As String)
		usuarioLogeado = user
	End Sub

	Public Shared Sub registrarUsuario(cedula As String, contrasenia As String, rol As String,
									   nombre As String, apellido As String, vin As String)
		Dim sql As String
		Dim datos As New DataTable
		conexion.Open()
		sql = "select * from usuario where nombreuser ='" & cedula & "';"

		Dim adaptador As New OdbcDataAdapter(sql, conexion)

		adaptador.Fill(datos)
		conexion.Close()
		If datos.Rows.Count = 0 Then
			Try
				conexion.Open()
				sql = "insert into usuario values('" & cedula & "','" & nombre & "','" & apellido & "');"
				comando.Connection = conexion
				comando.CommandText = sql
				comando.ExecuteReader()
				conexion.Close()
				conexion.Open()
				sql = "insert into contrasenia_usuario values('" & cedula & "','" & contrasenia & "');"
				comando.Connection = conexion
				comando.CommandText = sql
				comando.ExecuteReader()
				conexion.Close()
				MsgBox("Usuario " + cedula + " ingresado.")
				Select Case rol.ToString()
					Case "Operario Puerto"
						conexion.Open()
						sql = "insert into operario values('" & cedula & "','" & rol & "');"
						comando.Connection = conexion
						comando.CommandText = sql
						comando.ExecuteReader()
						conexion.Close()
						login.rCedulaTextBox.Text = ""
						login.rContraTextBox.Text = ""
						login.rRolComboBox.SelectedItem = Nothing
						login.rNombreTextBox.Text = ""
						login.rApellidoTextBox.Text = ""
					Case "Operario Patio"
						conexion.Open()
						sql = "insert into operario values('" & cedula & "','" & rol & "');"
						comando.Connection = conexion
						comando.CommandText = sql
						comando.ExecuteReader()
						conexion.Close()
						login.rCedulaTextBox.Text = ""
						login.rContraTextBox.Text = ""
						login.rRolComboBox.SelectedItem = Nothing
						login.rNombreTextBox.Text = ""
						login.rApellidoTextBox.Text = ""
					Case "Transportista"
						conexion.Open()
						sql = "insert into transportista values('" & cedula & "','" & vin & "');"
						comando.Connection = conexion
						comando.CommandText = sql
						comando.ExecuteReader()
						conexion.Close()
						login.rCedulaTextBox.Text = ""
						login.rContraTextBox.Text = ""
						login.rRolComboBox.SelectedItem = Nothing
						login.rNombreTextBox.Text = ""
						login.rApellidoTextBox.Text = ""
				End Select
			Catch ex As Exception
				MsgBox("Usuario no registrado.")
				MsgBox(ex.Message)
			End Try
		Else
			MsgBox("Usuario existente con la cedula: " + cedula)
		End If
	End Sub


	Public Shared Sub finalizarViaje(lote As Integer, fechainicial As String, fechafinal As String)
		'Try
		conexion.Open()
		Dim datos As New DataTable
		Dim sql As String
		sql = "select vin from transportista where nombreuser=" & usuarioLogeado

		Dim adaptador As New OdbcDataAdapter(sql, conexion)

		adaptador.Fill(datos)
		conexion.Close()
		Dim vinDeTransportista As String
		vinDeTransportista = datos.Rows(0).Item(0).ToString
		conexion.Open()
		sql = "insert into transporta values('" & usuarioLogeado & "','" & vinDeTransportista & "'," & lote & ",'" & fechainicial & "','" & fechafinal & "');"
		comando.Connection = conexion
		comando.CommandText = sql
		comando.ExecuteReader()
		conexion.Close()
		Dim fechaLLegada = DateTime.ParseExact(fechafinal, "dd/MM/yyyy HH:mm:ss", Nothing)
		Dim fechaPartida = DateTime.ParseExact(fechainicial, "dd/MM/yyyy HH:mm:ss", Nothing)
		Dim span As TimeSpan = fechaLLegada.Subtract(fechaPartida)
		MsgBox("Lote entregado, tiempo transcurrido: " & span.Days & " dia/s, " & span.Hours & " horas, " & span.Minutes & " minutos, " & span.Seconds & " segundos.")
		conexion.Open()
		sql = "update vehiculo set estado = 'Transportado' where codigolote =" & lote
		comando.Connection = conexion
		comando.CommandText = sql
		comando.ExecuteReader()
		conexion.Close()
		'Catch ex As Exception
		'MsgBox(ex.Message)
		'End Try
	End Sub

	Public Shared Function buscarInspeccion(vin As String) As DataTable
		conexion.Open()
		Dim datos As New DataTable
		Dim sql As String
		sql = "select * from inspeccion where vin='" & vin & "'"

		Dim adaptador As New OdbcDataAdapter(sql, conexion)

		adaptador.Fill(datos)
		conexion.Close()
		Return datos
	End Function

End Class
