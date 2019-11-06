Imports LibreriaLogica
Public Class MovimientoZona
	Private tabla As New DataTable
	Private Sub MovimientoZona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		traducirControles()
		OpcGraficas()
	End Sub

	Private Sub Cargar()
		'USAR CONSULTA DE LECTURA NUEVA PARA LOS VEHICULOS QUE ESTEN EN EL PATIO
		'
		Try
			tabla = ConsultasDeLectura.GetSingleton.ListadoVehiculosEnLugar 'listado en lugar no comprobado
			For Each row As DataRow In tabla.Rows
				Dim vehiculo As New WeakReference(New TileVehiculo(row, TileVehiculo.TileActionOnClick.Detalles))
				vehiculo.Target.TopLevel = False
				vehiculo.Target.CambioImagen()
				ventanaVehiculos.Controls.Add(vehiculo.Target)
				vehiculo.Target.Show()
			Next
			ventanaVehiculos.ResumeLayout()
			ventanaVehiculos.Update()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub listoClick()

	End Sub

	Private Sub btn_ready_Click(sender As Object, e As EventArgs) Handles btn_ready.Click
		listoClick()
	End Sub

	Private Sub traducirControles()
		If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
			''traduce al ingles
			lbl_title.Text = My.Resources.EN_UK.SeleccionVehiculo_lbltitle
			lbl_subtitle.Text = My.Resources.EN_UK.SeleccionVehiculo_lblsubtitle
			btn_ready.Text = My.Resources.EN_UK.SeleccionVehiculo_btnready
		ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
			''traduce al español
			lbl_title.Text = My.Resources.ES_LA.SeleccionVehiculo_lbltitle
			lbl_subtitle.Text = My.Resources.ES_LA.SeleccionVehiculo_lblsubtitle
			btn_ready.Text = My.Resources.ES_LA.SeleccionVehiculo_btnready
		Else
			''traduce al portugues
			lbl_title.Text = My.Resources.PT_BR.SeleccionVehiculo_lbltitle
			lbl_subtitle.Text = My.Resources.PT_BR.SeleccionVehiculo_lblsubtitle
			btn_ready.Text = My.Resources.PT_BR.SeleccionVehiculo_btnready
		End If
	End Sub

	Private Sub OpcGraficas()
		Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        ventanaVehiculos.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        lbl_title.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		lbl_subtitle.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
	End Sub

End Class