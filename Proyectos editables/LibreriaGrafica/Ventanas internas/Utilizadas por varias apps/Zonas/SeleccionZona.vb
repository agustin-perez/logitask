Imports LibreriaLogica
''' <summary>
''' Clase encargada de seleccionar zonas para su movimiento.
''' </summary>
Public Class SeleccionZona
	Private tabla As New DataTable
	Private Sub SeleccionZona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Cargar()
		traducirControles()
		OpcGraficas()
	End Sub
    ''' <summary>
    ''' Subrutina encargada de cargar todas las zonas.
    ''' </summary>
    Private Sub Cargar()
        Try
            tabla = ConsultasDeLectura.GetSingleton.ListadoLugares
            For Each row As DataRow In tabla.Rows
                Dim zona As New WeakReference(New TileLugar(row, TileLugar.TileActionOnClick.Detalles))
                zona.Target.TopLevel = False
                ventanaZonas.Controls.Add(zona.Target)
                zona.Target.Show()
            Next
            lbl_subtitle.Text = "Mostradas: " & ventanaZonas.Controls.Count.ToString & " zonas..." & Environment.NewLine & "Seleccione la zona a la que se va a mover el o los vehiculos"
            ventanaZonas.Update()
        Catch ex As Exception
            lbl_subtitle.Text = "Error al cargar las zonas"
        End Try
    End Sub

    Public Sub ReloadAction()
        lbl_subtitle.Text = "Cargando..."
        LimpiarZonas()
        If ventanaZonas.Controls.Count = 0 Then
            Cargar()
        End If
        OpcGraficas()
    End Sub

    Private Sub LimpiarZonas()
        For var As Int32 = 0 To ventanaZonas.Controls.Count - 1
            ventanaZonas.Controls.Item(0).Dispose()
        Next
    End Sub

    Private Sub traducirControles()
		If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
			''traduce al ingles
			lbl_title.Text = My.Resources.EN_UK.SeleccionVehiculo_lbltitle
			lbl_subtitle.Text = My.Resources.EN_UK.SeleccionVehiculo_lblsubtitle
		ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
			''traduce al español
			lbl_title.Text = My.Resources.ES_LA.SeleccionVehiculo_lbltitle
			lbl_subtitle.Text = My.Resources.ES_LA.SeleccionVehiculo_lblsubtitle
		Else
			''traduce al portugues
			lbl_title.Text = My.Resources.PT_BR.SeleccionVehiculo_lbltitle
			lbl_subtitle.Text = My.Resources.PT_BR.SeleccionVehiculo_lblsubtitle
		End If
	End Sub

	Private Sub OpcGraficas()
        Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        ventanaZonas.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        lbl_title.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		lbl_subtitle.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
	End Sub
End Class
