Imports System.Data.Odbc
Imports System.Data.OleDb
Imports System.IO
Imports System.Text

Public Class operarioPuerto
	Dim currentCodigoLote As Integer = 0
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		displayOFF()
		Datos.conectarDB()
		poblarVerVehiculo()
		vehiculoObjeto()
		setCodigoLote()
		setCodigoInsp()
		Datos.insertIniciales()
		poblarVerLote()
#Region "dt"
		'dt = New DataTable
#End Region
	End Sub
	Private Sub setCodigoLote()
		Datos.setCodigoLote()
	End Sub

	Private Sub setCodigoInsp()
		Datos.setCodigoInsp()
	End Sub
	Private Sub poblarVerVehiculo()
		Datos.poblarVerVehiculo()
	End Sub
	Private Sub poblarVerLote()
		Datos.poblarVerLote()
	End Sub
	Private Sub poblarVehiculoSLote()
		Datos.poblarVehiculoSLote(vehiculoSLoteDGV)
	End Sub
	Public Sub vehiculoObjeto()
		poblarVerVehiculo()
		For Each row As DataGridViewRow In verVehiculosDGV.Rows
			If Not row.IsNewRow Then
				Dim VIN As String = row.Cells(0).Value.ToString
				Dim marca As String = row.Cells(1).Value.ToString
				Dim modelo As String = row.Cells(2).Value.ToString
				Dim anio As Integer = row.Cells(3).Value.ToString
				Dim color As String = row.Cells(4).Value.ToString
				Dim tipo As String = row.Cells(5).Value.ToString
				Dim codigoLote As String = row.Cells(6).Value.ToString
				Dim listo As String = row.Cells(7).Value.ToString
				Logica.vehiculoObjeto(VIN, marca, modelo, anio, color, tipo, codigoLote, listo)
			End If
		Next
	End Sub

	Private Sub verLoteButton_Click(sender As Object, e As EventArgs) Handles verLoteButton.Click 'oculta y muestra botones
		vehiculoButton.Visible = False
		verLoteButton.Visible = False
		cLoteButton.Visible = True
		verLotesButton.Visible = True
		atrasButton.Visible = True
		salirButton.Visible = False
		inspeccionButton.Visible = False
		modificarLoteButton.Visible = True
		If eleccionPanel.Visible = True Then
			currentCodigoLote = 0
		End If
		poblarVerLote()
		'     infoLoteButton.Visible = True
	End Sub

	Private Sub atrasButton_Click(sender As Object, e As EventArgs) Handles atrasButton.Click 'oculta y muestra botones
		If dañosPanel.Visible = True Then
			crearLotePanel.Visible = True
			imagenOFD.FileName = Nothing
			evidenciaLabel.Text = "ningún archivo selecccionado"
			evidenciaButton.ForeColor = Color.Red
		End If
		If realizarInspeccionPanel.Visible = True Then
			Dim opcion As Integer = MessageBox.Show("Si sale ahora perdera todo su progreso, ¿Esta seguro que desea salir?", "FERTSPA", MessageBoxButtons.YesNo)
			If opcion = DialogResult.Yes Then
				mainMenu()
				displayOFF()
			Else
				Return
			End If
		End If
		If eleccionPanel.Visible = True Then
			Dim opcion As Integer = MessageBox.Show("Si sale ahora perdera todo su progreso, ¿Esta seguro que desea salir?", "FERTSPA", MessageBoxButtons.YesNo)
			If opcion = DialogResult.Yes Then
				modificarLotePanel.Visible = True
				eleccionPanel.Visible = False
				currentCodigoLote = Nothing
			Else
				Return
			End If
		End If
		mainMenu() 'Esconde y muestra todos los botones necesarios para que se vea el menu principal 
		displayOFF() 'Esconde todo lo que se muestra en el display de la derecha (Donde van los paneles)
	End Sub

	Private Sub vehiculoButton_Click(sender As Object, e As EventArgs) Handles vehiculoButton.Click 'oculta y muestra botones
		vehiculoButton.Visible = False
		verLoteButton.Visible = False
		registrarVehiculoButton.Visible = True
		atrasButton.Visible = True
		salirButton.Visible = False
		verVehiculoButton.Visible = True
		inspeccionButton.Visible = False
	End Sub

	Private Sub registrarAButton_Click(sender As Object, e As EventArgs) Handles registrarVehiculoButton.Click
		ingresarVehiculoPanel.Visible = True
		verVehiculosPanel.Visible = False
	End Sub

	Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
		Dim opcion As Integer = MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNoCancel)
		If opcion = DialogResult.No Or opcion = DialogResult.Cancel Then
			Return
		ElseIf opcion = DialogResult.Yes Then
			Me.Close()
		End If
	End Sub

	Private Sub cerrar_MouseEnter(sender As Object, e As EventArgs) Handles cerrar.MouseEnter
		cerrar.ForeColor = Color.FromArgb(85, 85, 85) 'Animacion de botones
	End Sub

	Private Sub cerrar_MouseLeave(sender As Object, e As EventArgs) Handles cerrar.MouseLeave
		cerrar.ForeColor = Color.FromArgb(35, 35, 35) 'Animacion de botones
	End Sub

	Public Sub displayOFF()
		ingresarVehiculoPanel.Visible = False
		realizarInspeccionPanel.Visible = False
		crearLotePanel.Visible = False
		dañosPanel.Visible = False
		verLotesPanel.Visible = False
		verVehiculosPanel.Visible = False
		verInspeccionPanel.Visible = False
		modificarLotePanel.Visible = False
		eleccionPanel.Visible = False
	End Sub

	Private Sub salirButton_Click(sender As Object, e As EventArgs) Handles salirButton.Click
		Dim opcion As Integer = MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNoCancel)
		If opcion = DialogResult.No Or opcion = DialogResult.Cancel Then
			Return
		ElseIf opcion = DialogResult.Yes Then
			Me.Close()
		End If

	End Sub

	Private Sub ingresarVehiculoButton_Click(sender As Object, e As EventArgs) Handles ingresarVehiculoButton.Click
		Dim VIN As String = Nothing
		Dim marca As String = Nothing
		Dim modelo As String = Nothing
		Dim anio As Integer = Nothing
		Dim color As String = Nothing
		Dim tipo As String = Nothing

		If vinTextBox.TextLength = 17 Then
			VIN = vinTextBox.Text
			If marcaTextBox.Text <> Nothing And modeloTextBox.Text <> Nothing And anioTextBox.Text <> Nothing And colorTextBox.Text <> Nothing And tipoComboBox.SelectedItem <> Nothing Then
				'si no estan vacios hace esto
				marca = marcaTextBox.Text
				modelo = modeloTextBox.Text
				anio = Convert.ToInt32(anioTextBox.Text)
				color = colorTextBox.Text
				tipo = tipoComboBox.SelectedItem
				Dim opcion As Integer = MessageBox.Show("¿Desea crear el vehiculo?", "Confirmar", MessageBoxButtons.YesNo)
				If opcion = DialogResult.No Then
					MsgBox("vehiculo no creado")
				ElseIf opcion = DialogResult.Yes Then
					'realizarInspeccionPanel.Visible = True
					Logica.ingresarVehiculo(VIN, marca, modelo, anio, color, tipo)
					vehiculoObjeto()
					vinTextBox.Text = Nothing
					marcaTextBox.Text = Nothing
					modeloTextBox.Text = Nothing
					anioTextBox.Text = Nothing
					colorTextBox.Text = Nothing
					tipoComboBox.SelectedItem = Nothing
					generarQRCheckBox.Checked = False
				End If
			Else
				'si alguno de los 5 campos está vacio
				MsgBox("Campos vacíos")
			End If
		Else
			MsgBox("VIN incorrecto")
		End If
	End Sub

	Private Sub anioTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles anioTextBox.KeyPress
		definirContenidoTextbox(2, e)
	End Sub

	Private Sub verVehiculoButton_Click(sender As Object, e As EventArgs)
		displayOFF()
	End Sub

	Private Sub cLoteButton_Click(sender As Object, e As EventArgs) Handles cLoteButton.Click
		displayOFF()
		crearLotePanel.Visible = True
        If eleccionPanel.Visible = True Then
            currentCodigoLote = 0
        End If
        setCodigoLote()
        Datos.poblarVehiculoSLote(vehiculoSLoteDGV)
	End Sub

	Private Sub dañadoButton_Click(sender As Object, e As EventArgs) Handles dañadoButton.Click
		displayOFF()
		dañosPanel.Visible = True

	End Sub

	Private Sub listoButton_Click(sender As Object, e As EventArgs) Handles listoButton.Click
		Dim index As Integer
		Dim vin As String
		index = verVehiculosSInspeccionDGV.CurrentCell.RowIndex
		Dim selectedRow As DataGridViewRow
		selectedRow = verVehiculosSInspeccionDGV.Rows(index)
		vin = selectedRow.Cells(0).Value
        Logica.vhListoPartir(vin)
    End Sub

	Public Sub mainMenu()
		vehiculoButton.Visible = True
		verLoteButton.Visible = True
		'Lote button
		cLoteButton.Visible = False
		verLotesButton.Visible = False
		atrasButton.Visible = False
		modificarLoteButton.Visible = False
		'registrarA but236; 20ton
		registrarVehiculoButton.Visible = False
		verVehiculoButton.Visible = False
		salirButton.Visible = True
		'Inspeccion button
		inspeccionButton.Visible = True
		realizarInspeccionButton.Visible = False
		verInspeccionButton.Visible = False
		'menu 

		vinTextBox.Text = ""
		nombreLoteTextbox.Text = ""
		modeloTextBox.Text = ""
		marcaTextBox.Text = ""
		descLoteRichTextBox.Text = ""
		descDañoRichTextBox.Text = ""
		colorTextBox.Text = ""
		anioTextBox.Text = ""
		descLoteRichTextBox.Text = ""
		nombreLoteTextbox.Text = ""
	End Sub

#Region " Mover la ventana "

	' Codigo para poder mover la ventana

	Public MoveForm As Boolean
	Public MoveForm_MousePosition As Point

	Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
	topBarPanel.MouseDown

		If e.Button = MouseButtons.Left Then
			MoveForm = True
			'Me.Cursor = Cursors.NoMove2D
			MoveForm_MousePosition = e.Location
		End If

	End Sub

	Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
	topBarPanel.MouseMove

		If MoveForm Then
			Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
		End If

	End Sub

	Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
	topBarPanel.MouseUp

		If e.Button = MouseButtons.Left Then
			MoveForm = False
			Me.Cursor = Cursors.Default
		End If

	End Sub

#End Region


	Private Sub verLotesButton_Click(sender As Object, e As EventArgs) Handles verLotesButton.Click
		displayOFF()
		verLotesPanel.Visible = True
	End Sub

	Private Sub ingresarDañoButton_Click(sender As Object, e As EventArgs) Handles ingresarDañoButton.Click
		Dim index As Integer
		Dim vin As String
		index = verVehiculosSInspeccionDGV.CurrentCell.RowIndex
		Dim selectedRow As DataGridViewRow
		selectedRow = verVehiculosSInspeccionDGV.Rows(index)
		vin = selectedRow.Cells(0).Value
		Dim rutaImagen As String = imagenOFD.FileName.ToString()

		Logica.ingresarDaño(descDañoRichTextBox.Text, vin, rutaImagen)
    End Sub

	Private Sub verVehiculoButton_Click_1(sender As Object, e As EventArgs) Handles verVehiculoButton.Click
		displayOFF()
		verVehiculosPanel.Visible = True
		poblarVerLote()
		poblarVerVehiculo()

	End Sub

	Private Sub colorTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles colorTextBox.KeyPress
		definirContenidoTextbox(1, e)
	End Sub

#Region " El mejor metodo de la vida "

	Private Sub definirContenidoTextbox(type As Integer, e As KeyPressEventArgs)

		'Pasa todas las letras y simbolos existentes a numeros

		'97 - 122 = letras simples
		'65 - 90  = letras mayusculas
		'48 - 57  = numeros

		If type = 1 Then 'SOLO LETRAS
			If Asc(e.KeyChar) <> 8 Then 'si no es el char 8 (es un char especial) 
				If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 122 Then 'y no es una letra simple o mayuscula evaluando si es menor a 97 o mayor a 122
					MessageBox.Show("No se pueden insertar signos, espacios en blanco o numeros")
					e.Handled = True 'ignora el input y no aparece en pantalla
				End If
			End If

		ElseIf type = 2 Then 'SOLO NUMEROS
			If Asc(e.KeyChar) <> 8 Then 'si no es el char 8 (es un char especial) 
				If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'y no es un numero evaluando si es menor a 48 o mayor a 57
					MessageBox.Show("No se pueden insertar signos, espacios en blanco o letras")
					e.Handled = True 'ignora el input y no aparece en pantalla
				End If
			End If

		ElseIf type = 3 Then 'LETRAS Y NUMEROS, NO SIMBOLOS
			If Asc(e.KeyChar) <> 8 Then 'si no es el char 8 (es un char especial) 
				If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 122 Then 'y no es un numero o letra evaluando si es menor a 48 o mayor a 122
					MessageBox.Show("No se pueden insertar signos ni espacios en blanco")
					e.Handled = True 'ignora el input y no aparece en pantalla
				End If
			End If
		End If
	End Sub
#End Region

	Private Sub vinTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles vinTextBox.KeyPress
		definirContenidoTextbox(3, e)
	End Sub

	Private Sub modeloTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles modeloTextBox.KeyPress
		definirContenidoTextbox(1, e)
	End Sub

	Private Sub marcaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles marcaTextBox.KeyPress
		definirContenidoTextbox(1, e)
	End Sub

	Private Sub nombreLoteTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nombreLoteTextbox.KeyPress
		definirContenidoTextbox(1, e)
	End Sub

	Private Sub eliminarVehiculoButton_Click(sender As Object, e As EventArgs)
		Dim index As Integer
		Try
			index = verVehiculosDGV.CurrentCell.RowIndex
			verVehiculosDGV.Rows.RemoveAt(index)
		Catch ex As Exception
			MsgBox("Columna no seleccionada")
		End Try
	End Sub

	Private Sub eliminarLoteButton_Click(sender As Object, e As EventArgs) Handles eliminarLoteButton.Click
		Dim index As Integer
		Dim codigoLote As Integer
		Try
			index = verLotesDGV.CurrentCell.RowIndex
			Dim selectedRow As DataGridViewRow
			selectedRow = verLotesDGV.Rows(index)
			codigoLote = selectedRow.Cells(0).Value
			Datos.eliminarLote(codigoLote, index)
			verLotesDGV.Rows.RemoveAt(index)
			MsgBox("Lote Eliminado")
		Catch ex As Exception
			MsgBox("Columna no seleccionada")
		End Try
	End Sub

	Private Sub CrearLoteButton_Click(sender As Object, e As EventArgs) Handles CrearLoteButton.Click
		If nombreLoteTextbox.Text <> "" And descLoteRichTextBox.Text <> "" Then
			CrearLoteButton.Enabled = False
			finalizarLoteButton.Visible = True
			finalizarLoteButton.Enabled = False
			atrasButton.Visible = False
			Logica.CrearLote(nombreLoteTextbox.Text, descLoteRichTextBox.Text)
			atrasButton.Visible = True
			elegirAutosDeLoteLabel.Visible = True
		Else
			MsgBox("Campos vacios")
		End If
	End Sub

	Private Sub finalizarLoteButton_Click(sender As Object, e As EventArgs) Handles finalizarLoteButton.Click
		MsgBox("Lote creado correctamente")
		finalizarLoteButton.Visible = False
		CrearLoteButton.Enabled = True
		elegirAutosDeLoteLabel.Visible = False
		displayOFF()
		mainMenu()
	End Sub

	Private Sub vehiculoSLoteDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles vehiculoSLoteDGV.CellClick
		If CrearLoteButton.Enabled = False Then 'EVALUA QUE EL USUARIO LE HAYA DADO AL BOTON CREAR LOTE ASEGURANDOSE DE QUE LAS VARIABLES DEL LOTE ESTEN INSTANCIADAS
			Dim index As Integer
			Dim vin As String
			index = e.RowIndex
			Dim selectedRow As DataGridViewRow
			selectedRow = vehiculoSLoteDGV.Rows(index)
			vin = selectedRow.Cells(0).Value.ToString()
			Logica.seleccionarVehiculoListo(vin, index)
		Else
			MsgBox("Primero debes rellenar los campos y crear el lote.")
		End If
	End Sub

	Private Sub inspeccionButton_Click(sender As Object, e As EventArgs) Handles inspeccionButton.Click
		atrasButton.Visible = True
		salirButton.Visible = False
		vehiculoButton.Visible = False
		verLoteButton.Visible = False
		inspeccionButton.Visible = False

		realizarInspeccionButton.Visible = True
		verInspeccionButton.Visible = True
	End Sub

	Private Sub realizarInspeccionButton_Click(sender As Object, e As EventArgs) Handles realizarInspeccionButton.Click
		displayOFF()
		Datos.poblarVerVehiculoSInspeccion()
		realizarInspeccionPanel.Visible = True
        atrasButton.Visible = True
        setCodigoInsp()
    End Sub

	Private Sub verInspeccionButton_Click(sender As Object, e As EventArgs) Handles verInspeccionButton.Click
		displayOFF()
		Datos.poblarVerInspecciones()
		verInspeccionPanel.Visible = True
		atrasButton.Visible = True
	End Sub

	Private Sub verVehiculosSInspeccionDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles verVehiculosSInspeccionDGV.CellClick
		listoButton.Enabled = True
		dañadoButton.Enabled = True
	End Sub

	Private Sub ingresarVehiculoPanel_VisibleChanged(sender As Object, e As EventArgs) Handles ingresarVehiculoPanel.VisibleChanged
		If ingresarVehiculoPanel.Visible = False Then
			vinTextBox.Text = ""
			marcaTextBox.Text = ""
			modeloTextBox.Text = ""
			colorTextBox.Text = ""
			anioTextBox.Text = ""
			tipoComboBox.SelectedItem = Nothing
		End If
	End Sub

	Private Sub evidenciaButton_Click(sender As Object, e As EventArgs) Handles evidenciaButton.Click
		Logica.cargarEvidencia()
	End Sub

	Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click
		Dim vin
		If vinABuscarTextBox.Text = "" Then
			MsgBox("Campos Vacios")
		Else
			If vinABuscarTextBox.TextLength = 17 Then
				vin = vinABuscarTextBox.Text.ToString()
				Datos.buscarVin(vin)
			Else
				MsgBox("Vin demasiado corto, 17 digitos necesarios.")
			End If
		End If
	End Sub

	Private Sub actualizarVerVehiculo_Click(sender As Object, e As EventArgs) Handles actualizarVerVehiculo.Click
		Datos.poblarVerVehiculo()
	End Sub

	Private Sub qrSFD_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles qrSFD.FileOk
		Try
			Dim img As New Bitmap(codigoQRpictureBox.Image)
			img.Save(qrSFD.FileName, Imaging.ImageFormat.Png)
		Catch ex As Exception
			MsgBox(ex)
		End Try
	End Sub

	Private Sub importarCSVButton_Click(sender As Object, e As EventArgs) Handles importarCSVButton.Click
		Dim dt As New DataTable
		dt.Columns.Add("VIN", GetType(String))
		dt.Columns.Add("Marca", GetType(String))
		dt.Columns.Add("Modelo", GetType(String))
		dt.Columns.Add("Anio", GetType(Integer))
		dt.Columns.Add("Color", GetType(String))
		dt.Columns.Add("Tipo", GetType(String))
		Dim fName As String = ""
		If (importarCSVOFD.ShowDialog() = Windows.Forms.DialogResult.OK) Then
			fName = importarCSVOFD.FileName
		Else
			Exit Sub
			MsgBox("Ningún archivo seelccionado.")
		End If
		Dim rutaCSV As String = fName
		Dim TextLine As String = ""
		Dim SplitLine() As String

		If System.IO.File.Exists(fName) = True Then
			Dim objReader As New System.IO.StreamReader(rutaCSV, Encoding.ASCII)
			Dim index As Integer = 0
			Do While objReader.Peek() <> -1
				If index >= 0 Then
					Try
						TextLine = objReader.ReadLine().ToString()
						SplitLine = Split(TextLine, ";")
						dt.Rows.Add(SplitLine)
					Catch ex As Exception
						MsgBox("Error en el archivo")
					End Try
				Else
                    TextLine = objReader.ReadLine()
                End If
				index = index + 1
			Loop
			If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    If dt.Rows(i).Item(0) <> Nothing And dt.Rows(i).Item(1) <> Nothing And dt.Rows(i).Item(2) <> Nothing And dt.Rows(i).Item(3) <> Nothing And dt.Rows(i).Item(4) <> Nothing And dt.Rows(i).Item(5) <> Nothing Then
                        If dt.Rows(i).Item(0).Length = 17 Then
                            If IsNumeric(dt.Rows(i).Item(0)) Then
                                Dim vin As String = dt.Rows(i).Item(0)
                                Dim marca As String = dt.Rows(i).Item(1)
                                Dim modelo As String = dt.Rows(i).Item(2)
                                Dim anio As Integer = Convert.ToInt32(dt.Rows(i).Item(3))
                                Dim color As String = dt.Rows(i).Item(4)
                                Dim tipo As String = dt.Rows(i).Item(5)
                                Datos.ingresarVehiculo(vin, marca, modelo, anio, color, tipo)
                            Else
                                MsgBox("Atributo año en mal formato del vehiculo: " + dt.Rows(i).Item(0))
                            End If
                        Else
                            MsgBox("El vin: " + dt.Rows(i).Item(0) + " no es de 17 digitos")
                        End If
                    Else
                        MsgBox("Campos vacios, compruebe el archivo e intentelo nuevamente.")
                    End If
                Next
            End If
		Else
			MsgBox("File Does Not Exist")
		End If
	End Sub

	Private Sub modificarLoteButton_Click(sender As Object, e As EventArgs) Handles modificarLoteButton.Click
		displayOFF()
		modificarLotePanel.Visible = True
		atrasButton.Visible = True
		Datos.poblarModificarLote()
	End Sub

	Private Sub elegirButton_Click(sender As Object, e As EventArgs) Handles elegirButton.Click
		Dim index As Integer
		Dim codigoLote As Integer
		Try
			index = modificarLoteDGV.CurrentCell.RowIndex
			Dim selectedRow As DataGridViewRow
			selectedRow = modificarLoteDGV.Rows(index)
			codigoLote = Convert.ToInt32(selectedRow.Cells(0).Value)
			currentCodigoLote = codigoLote
			MsgBox("Lote elegido.")
			Datos.poblarVerVehiculosEnLote(codigoLote)
			Datos.poblarVehiculoSLote(vehiculoCInpseccionDGV)
			eleccionPanel.Visible = True
		Catch ex As Exception
			MsgBox("Columna no seleccionada")
			MsgBox(ex.ToString)
		End Try
	End Sub

	Private Sub eleccionDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles vehiculoEnLoteDGV.CellClick
		'eliminar del lote un vehiculo
		Dim index As Integer
		Dim vin As String
		index = e.RowIndex
		Dim selectedRow As DataGridViewRow
		selectedRow = vehiculoEnLoteDGV.Rows(index)
		vin = selectedRow.Cells(0).Value.ToString()
		Datos.eliminarVehiculoDeLote(vin, currentCodigoLote)
	End Sub

	Private Sub vehiculoCInpseccionDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles vehiculoCInpseccionDGV.CellClick
		'ingresar un vehiculo al lote
		Dim index As Integer
		Dim vin As String
		index = e.RowIndex
		Dim selectedRow As DataGridViewRow
		selectedRow = vehiculoCInpseccionDGV.Rows(index)
		vin = selectedRow.Cells(0).Value.ToString()
		Datos.ingresarVehiculoEnLote(vin, currentCodigoLote)
	End Sub

	Private Sub finalizarModButton_Click(sender As Object, e As EventArgs) Handles finalizarModButton.Click
		Dim opcion As Integer = MessageBox.Show("¿Desea finalizar la modificación?", "Salir", MessageBoxButtons.YesNoCancel)
		If opcion = DialogResult.No Or opcion = DialogResult.Cancel Then
			Return
		ElseIf opcion = DialogResult.Yes Then
			currentCodigoLote = 0
			eleccionPanel.Visible = False
			modificarLotePanel.Visible = True
		End If
	End Sub

	Private Sub clicker(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
		If e.Button = MouseButtons.Right Then
			'do nothing
		Else
			MsgBox("No se puede hacer click derecho")
		End If

	End Sub

End Class
