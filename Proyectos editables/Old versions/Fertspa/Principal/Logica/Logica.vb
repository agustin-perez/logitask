Imports System.IO
Imports System.Text

Public Class Logica
	Shared vehiculos As New List(Of vehiculo)
	Shared inspecciones As New List(Of Inspeccion)
	Shared listaDaños As New List(Of Danio)
	Shared codigoloteEnCurso As Integer = 0
	Shared nombreLoteEnCurso As String
	Shared codigoInspEnCurso As Integer = 0
	Shared lugarEnCurso As String = "Puerto de Montevideo"
	Shared dañoAnteriorEnCurso As String
	Shared fechaDateEnCurso As Date = Date.Today()
	Shared fechaEnCurso As String = Convert.ToString(fechaDateEnCurso)
	Shared descripcionLoteEnCurso As String
	Shared qrGenerado As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
	Shared fechaViajeInicial As DateTime
	Shared loteATransportar As Integer

	Public Shared Sub ingresarVehiculo(vin As String, marca As String, modelo As String, anio As Integer, color As String, tipo As String)
		Datos.ingresarVehiculo(vin, marca, modelo, anio, color, tipo)
	End Sub

	Public Shared Sub vhListoPartir(vin As String)
		Dim codigoInsp As Integer = codigoInspEnCurso + 1
		Dim lugar As String = "Puerto de Montevideo"
		Dim fechaDate As Date = Date.Today()
		Dim fecha As String = Convert.ToString(fechaDate)
		Dim descDaño As String = ""
		Dim dañoAnterior = dañoAnteriorEnCurso
		Datos.setCodigoInsp()
		Datos.vhListoPartir(codigoInsp, lugar,
							fecha, dañoAnterior, vin)
	End Sub

	Public Shared Sub vhListoPartir2(vin As String)
		Dim codigoInsp As Integer = codigoInspEnCurso + 1
		Dim lugar As String = "Patio"
		Dim fechaDate As Date = Date.Today()
		Dim fecha As String = Convert.ToString(fechaDate)
		Dim descDaño As String = ""
		Dim dañoAnterior = Datos.getDañoAnterior(vin)
		Datos.setCodigoInsp()
		Datos.vhListoPartir2(codigoInsp, lugar,
							fecha, dañoAnterior, vin)
	End Sub
	Public Shared Sub ingresarDaño(descDañoText As String, vin As String, ruta As String)
		' Si deja añadir el daño: 
		If descDañoText <> "" And operarioPuerto.evidenciaLabel.Text = "Imágen Seleccionada" Then
			Dim codigoInsp As Integer = codigoInspEnCurso + 1
			Dim lugar As String = "Puerto de Montevideo"
			Dim fechaDate As Date = Date.Today()
			Dim fecha As String = Convert.ToString(fechaDate)
			Dim descDaño As String
			Dim dañoAnterior = dañoAnteriorEnCurso
			Dim rutaImagen As String
			If ruta = "" Or ruta = Nothing Then
				rutaImagen = "no"
			Else
				rutaImagen = ruta
			End If
			For Each Danio In listaDaños
				If vin = Danio.vinProperty Then
					dañoAnteriorEnCurso = Danio.descripcionProperty
				Else
					dañoAnteriorEnCurso = "no"
				End If
			Next
			descDaño = descDañoText
			Try
				Datos.setCodigoInsp()
				Datos.ingresarDaño(vin, codigoInsp, lugar, fecha, descDaño, dañoAnterior, rutaImagen)
			Catch ex As Exception
				MsgBox("Error en la Base de datos, es recomendable reiniciar la aplicación")
			End Try
		ElseIf operarioPatio.evidenciaLabel.Text = "ningún archivo selecccionado" Then
			MsgBox("El campo de descripción no puede estar vacio")
		Else
			MsgBox("Se debe subir evidencia")
		End If
	End Sub

	Public Shared Sub ingresarDaño2(descDañoText As String, vin As String, ruta As String)
		' Si deja añadir el daño: 
		If descDañoText <> "" And operarioPatio.evidenciaLabel.Text = "Imágen Seleccionada" Then
			Dim codigoInsp As Integer = codigoInspEnCurso + 1
			Dim lugar As String = "Patio"
			Dim fechaDate As Date = Date.Today()
			Dim fecha As String = Convert.ToString(fechaDate)
			Dim descDaño As String
			Dim dañoAnterior As String = Datos.getDañoAnterior(vin)
			Dim rutaImagen As String
			If ruta = "" Or ruta = Nothing Then
				rutaImagen = "no"
			Else
				rutaImagen = ruta
			End If
			descDaño = descDañoText
			Try
				Datos.setCodigoInsp()
				Datos.ingresarDaño2(vin, codigoInsp, lugar, fecha, descDaño, dañoAnterior, rutaImagen)
			Catch ex As Exception
				MsgBox("Error en la Base de datos, es recomendable reiniciar la aplicación")
			End Try
		ElseIf operarioPatio.evidenciaLabel.Text = "ningun archivo selecccionado" Then
			MsgBox("Se debe subir evidencia")
		Else
			MsgBox("El campo de descripción no puede estar vacio")
		End If
	End Sub

	Public Shared Sub CrearLote(nombreLote As String, descLote As String)
		codigoloteEnCurso = codigoloteEnCurso + 1
		nombreLoteEnCurso = nombreLote
		descripcionLoteEnCurso = descLote
		Datos.crearLote(codigoloteEnCurso, nombreLoteEnCurso, descripcionLoteEnCurso)
	End Sub

	Public Shared Sub seleccionarVehiculoListo(vin As String, index As Integer)
		Dim opcion As Integer = MessageBox.Show("Desea Ingresar el vehiculo con el vin:" & vin & " al lote " & codigoloteEnCurso, "Confirmar", MessageBoxButtons.YesNo)
		If opcion = DialogResult.Yes Then
			Datos.seleccionarVehiculoListo(vin, codigoloteEnCurso)
			operarioPuerto.vehiculoSLoteDGV.Rows.RemoveAt(index)
			MsgBox("Vehiculo Ingresado")
			operarioPuerto.finalizarLoteButton.Enabled = True
		Else

		End If
	End Sub
	Public Shared Sub vehiculoObjeto(vin As String, marca As String, modelo As String, anio As Integer, color As String,
									 tipo As String, codigoLote As Integer, listo As String)
		Dim vehiculo As New vehiculo(vin, marca, modelo, anio, color, tipo, codigoLote, listo)
		vehiculos.Add(vehiculo)
	End Sub

	Public Shared Sub setCodigoInsp(datos As DataTable)
		Try '' SI NO HAY LOTES CHECKEANDO EL VALOR 0 METIENDOLO EN UNA TABLA
			codigoInspEnCurso = Convert.ToInt32(datos.Rows(0).Item(0))

		Catch ex As Exception
			codigoInspEnCurso = 0
		End Try
	End Sub

	Public Shared Function getCodigoInsp() As Integer
		Return codigoInspEnCurso
	End Function

	Public Shared Sub setCodigoLote(datos As DataTable)
		Try '' SI NO HAY LOTES CHECKEANDO EL VALOR 0 METIENDOLO EN UNA TABLA
			codigoloteEnCurso = Convert.ToInt32(datos.Rows(0).Item(0))
		Catch ex As Exception
			codigoloteEnCurso = 0
		End Try
	End Sub

	Public Shared Sub generarQR(vin As String)
		If operarioPuerto.generarQRCheckBox.Checked = True Then
			Try
				operarioPuerto.codigoQRpictureBox.Image = qrGenerado.Encode(vin)
				MsgBox("Codigo QR generado correctamente. Guarde el codigo")
				operarioPuerto.qrSFD.ShowDialog()
			Catch ex As Exception
				MsgBox(ex)
			End Try
		End If
	End Sub

	Public Shared Sub cargarEvidencia()
		operarioPuerto.imagenOFD = New OpenFileDialog
		Dim appPath As String = IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Danios\"
		If Directory.Exists(appPath) = False Then
			IO.Directory.CreateDirectory(appPath)
		End If
		If operarioPuerto.imagenOFD.ShowDialog = DialogResult.OK Then
			Try
				operarioPuerto.evidenciaLabel.Text = "Imágen Seleccionada"
				operarioPuerto.evidenciaLabel.ForeColor = Color.Green
				Dim nombreArchivo As String = operarioPuerto.imagenOFD.SafeFileName
				Dim rutaArchivo As String = operarioPuerto.imagenOFD.FileName
				Dim codigoinsp As Integer = codigoInspEnCurso + 1
				File.Copy(rutaArchivo, appPath + "DanioInspeccion" + codigoinsp.ToString + ".jpg")
				operarioPuerto.imagenOFD.FileName = appPath + nombreArchivo
			Catch ex As Exception
				MsgBox("No se pudo abrir el archivo" + ex.Message)
			End Try
		Else
			operarioPuerto.imagenOFD.Dispose()
		End If
	End Sub

	Public Shared Sub cargarEvidencia2()
		operarioPatio.imagenOFD = New OpenFileDialog
		Dim appPath As String = IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Danios\"
		If Directory.Exists(appPath) = False Then
			IO.Directory.CreateDirectory(appPath)
		End If
		If operarioPatio.imagenOFD.ShowDialog = DialogResult.OK Then
			Try
				operarioPatio.evidenciaLabel.Text = "Imágen Seleccionada"
				operarioPatio.evidenciaLabel.ForeColor = Color.Green
				Dim nombreArchivo As String = operarioPatio.imagenOFD.SafeFileName
				Dim rutaArchivo As String = operarioPatio.imagenOFD.FileName
				Dim codigoinsp As Integer = codigoInspEnCurso + 1
				File.Copy(rutaArchivo, appPath + "DanioInspeccion" + codigoinsp + ".jpg")
				operarioPatio.imagenOFD.FileName = appPath + nombreArchivo
			Catch ex As Exception
				MsgBox("No se pudo abrir el archivo" + ex.Message)
			End Try
		Else
			operarioPatio.imagenOFD.Dispose()
		End If
	End Sub


	Public Shared Sub ingresarUsuario()

	End Sub

	Public Shared Sub registrarUsuario(cedula As String, contrasenia As String, rol As String,
									   nombre As String, apellido As String)
		Dim vin As String = ""
		If rol = "Transportista" Then
			Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
			Dim r As New Random
			Dim sb As New StringBuilder
			For i As Integer = 1 To 17
				Dim idx As Integer = r.Next(0, 35)
				sb.Append(s.Substring(idx, 1))
			Next
			Console.WriteLine(sb.ToString())
			vin = sb.ToString()
		End If

		Datos.registrarUsuario(cedula, contrasenia, rol, nombre, apellido, vin)
	End Sub

	Public Shared Sub comenzarViaje(lote As String)
		fechaViajeInicial = DateTime.Now
		transportista.fechaInicioLabel.Text = fechaViajeInicial.ToString("dd/MM/yyyy HH:mm:ss")
		loteATransportar = Convert.ToInt32(lote)
	End Sub

	Public Shared Sub finalizarViaje(fechallegada As DateTime)
		'loteATransportar
		'fechaViajeInicial
		fechallegada.ToString("dd/MM/yyyy HH:mm:ss")
		fechaViajeInicial.ToString("dd/MM/yyyy HH:mm:ss")
		Datos.finalizarViaje(loteATransportar, fechaViajeInicial, fechallegada)
	End Sub
End Class
