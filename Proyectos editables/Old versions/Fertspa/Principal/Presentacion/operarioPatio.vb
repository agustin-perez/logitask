Public Class operarioPatio
	Private Sub operarioPatio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Datos.conectarDB()
		Datos.setCodigoLote()
		Datos.setCodigoInsp()
		Datos.insertIniciales()
	End Sub

	Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
		Me.Close()
	End Sub
	Private Sub displayOFF()
		For Each c As Control In Me.Controls
			If TypeOf (c) Is Panel Then
				c.Visible = False
			End If
		Next
		topBarPanel.Visible = True
		TabPanel.Visible = True
	End Sub

	Private Sub tabOFF()
		For Each c As Control In TabPanel.Controls
			If TypeOf (c) Is Button Then
				c.Visible = False
			End If
		Next
	End Sub

	Private Sub salirButton_Click(sender As Object, e As EventArgs) Handles salirButton.Click
		Dim opcion As Integer = MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNoCancel)
		If opcion = DialogResult.No Or opcion = DialogResult.Cancel Then
			Return
		ElseIf opcion = DialogResult.Yes Then
			Me.Close()
		End If
	End Sub

	Private Sub atrasButton_Click(sender As Object, e As EventArgs) Handles atrasButton.Click
		tabOFF()
		displayOFF()
		inspeccionButton.Visible = True
		salirButton.Visible = True
		ubicarMenuButton.Visible = True
	End Sub

	Private Sub zonaButton_Click(sender As Object, e As EventArgs)
		displayOFF()
		tabOFF()
		realizarButton.Visible = True
		verZonasButton.Visible = True
		atrasButton.Visible = True
	End Sub

	Private Sub verZonasButton_Click(sender As Object, e As EventArgs) Handles verZonasButton.Click
		displayOFF()
		verZonasPanel.Visible = True
	End Sub
	Private Sub realizarInspeccionButton_Click(sender As Object, e As EventArgs) Handles realizarInspeccionButton.Click
		displayOFF()
		realizarInspeccionPanel.Visible = True
		Datos.poblarVerVehiculosEnLoteTransportado()
		datosInspeccionPanel.Visible = False
	End Sub

	Private Sub continuarButton_Click(sender As Object, e As EventArgs)
		Dim index As Integer
		Dim vin As String
		index = vehiculosSInspeccionDGV.CurrentCell.RowIndex
		Dim selectedRow As DataGridViewRow
		selectedRow = vehiculosSInspeccionDGV.Rows(index)
		vin = selectedRow.Cells(0).Value

	End Sub

	Private Sub vehiculosSInspeccionDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles vehiculosSInspeccionDGV.CellClick
		Dim index As Integer
		Dim vin As String
		index = vehiculosSInspeccionDGV.CurrentCell.RowIndex
		Dim selectedRow As DataGridViewRow
		selectedRow = vehiculosSInspeccionDGV.Rows(index)
		vin = selectedRow.Cells(0).Value
		Dim dt As DataTable = Datos.buscarInspeccion(vin) 'retorna la inspeccion primera del vehiculo
		datosInspeccionPanel.Visible = True
		numeroInspeccionLabel.Text = "Inspeccion Nº : " & dt.Rows(0).Item(0).ToString()
		lugarLabel.Text = "Lugar : " & dt.Rows(0).Item(2).ToString()
		fechaInspeccionLabel.Text = "Fecha : " & dt.Rows(0).Item(3).ToString()
		If dt.Rows(0).Item(1).ToString = "no" And dt.Rows(0).Item(4).ToString() = "no" Then
			dañoinspeccionPictureBox.Visible = False
			evidenciaDettalleLabel.Visible = False
			danioRichTextBox.Visible = False
			danioLabel.Text = "Este vehiculo no posee daño alguno"
			danioLabel.ForeColor = Color.Red
		ElseIf dt.Rows(0).Item(4) <> "no" Then
			danioRichTextBox.Text = dt.Rows(0).Item(4).ToString
			If dt.Rows(0).Item(1).ToString <> "no" Then
				dañoinspeccionPictureBox.ImageLocation = dt.Rows(0).Item(1).ToString
			Else
				evidenciaDettalleLabel.Text = "¡Evidencia no subida!"
			End If
		End If
	End Sub

	Private Sub ingresarDañoButton_Click(sender As Object, e As EventArgs) Handles ingresarDañoButton.Click
		Dim index As Integer
		Dim vin As String
		index = vehiculosSInspeccionDGV.CurrentCell.RowIndex
		Dim selectedRow As DataGridViewRow
		selectedRow = vehiculosSInspeccionDGV.Rows(index)
		vin = selectedRow.Cells(0).Value
		Dim rutaImagen As String = imagenOFD.FileName.ToString()

		Logica.ingresarDaño2(descDañoRichTextBox.Text, vin, rutaImagen)
	End Sub

	Private Sub cambiosNoButton_Click(sender As Object, e As EventArgs) Handles cambiosNoButton.Click
		Dim opcion As Integer = MessageBox.Show("El vehiculo se va a marcar como listo sin daños ¿Desea proseguir?", "Salir", MessageBoxButtons.YesNoCancel)
		If opcion = DialogResult.No Or opcion = DialogResult.Cancel Then
			Return
		ElseIf opcion = DialogResult.Yes Then
			Dim index As Integer
			Dim vin As String
			index = vehiculosSInspeccionDGV.CurrentCell.RowIndex
			Dim selectedRow As DataGridViewRow
			selectedRow = vehiculosSInspeccionDGV.Rows(index)
			vin = selectedRow.Cells(0).Value
			Logica.vhListoPartir2(vin)
		End If
	End Sub

	Private Sub inspeccionButton_Click(sender As Object, e As EventArgs) Handles inspeccionButton.Click
		tabOFF()
		atrasButton.Visible = True
		realizarInspeccionButton.Visible = True
		verInspeccionButton.Visible = True
	End Sub

	Private Sub ubicarMenuButton_Click(sender As Object, e As EventArgs) Handles ubicarMenuButton.Click
		tabOFF()
		ubicarButton.Visible = True
		verZonasButton.Visible = True
		atrasButton.Visible = True
	End Sub

	Private Sub cambiosSiButton_Click(sender As Object, e As EventArgs) Handles cambiosSiButton.Click
		Dim opcion As Integer = MessageBox.Show("¿Desea agregar un daño nuevo?", "Salir", MessageBoxButtons.YesNoCancel)
		If opcion = DialogResult.No Or opcion = DialogResult.Cancel Then
			Return
		ElseIf opcion = DialogResult.Yes Then
			displayOFF()
			dañosPanel.Visible = True
		End If
	End Sub

	Private Sub evidenciaButton_Click(sender As Object, e As EventArgs) Handles evidenciaButton.Click
		Logica.cargarEvidencia()
	End Sub
End Class