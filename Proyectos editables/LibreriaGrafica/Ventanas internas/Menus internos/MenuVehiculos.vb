Imports System.Windows.Forms
Imports LibreriaLogica
Public Class MenuVehiculos
    Implements IDisposable
    Private tabla As New DataTable
    Private WithEvents lectorQr As EscanerQR
    Private escanerAbierto As Boolean
    Private Sub ListadoVehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VentanaLista.SuspendLayout()
        OpcGraficas()
        Cargar()
        Me.DoubleBuffered = True
		errorLabel.Hide()
		traducirControles()
	End Sub

    Public Sub Cargar()
        Try
            tabla = ConsultasDeLectura.GetSingleton.ListadoVehiculos
            For Each row As DataRow In tabla.Rows
                Dim vehiculo As New WeakReference(New TileVehiculo(row, TileVehiculo.TileActionOnClick.Detalles))
                vehiculo.Target.TopLevel = False
                vehiculo.Target.CambioImagen()
                VentanaLista.Controls.Add(vehiculo.Target)
                vehiculo.Target.Show()
            Next
            VentanaLista.ResumeLayout()
            VentanaLista.Update()
        Catch ex As Exception
        End Try
    End Sub

	Private Sub BusqVIN_Click(sender As Object, e As EventArgs) Handles buscarVIN.Click
		AccionBusqueda(vin.Text)
	End Sub

	Private Sub AccionBusqueda(vinSolicitado As String)
		Try
			Dim tileBusqueda As New TileVehiculo(ConsultasDeLectura.GetSingleton.BusquedaVin(vinSolicitado).Rows.Item(0), 0)
			If tileBusqueda.GetVin IsNot Nothing Then
				tileBusqueda.TopLevel = False
				VentanaLista.Controls.Clear()
				VentanaLista.Controls.Add(tileBusqueda)
				tileBusqueda.Show()
				Dim infoBusqueda As New DatosVehiculo(tileBusqueda.GetTupla)
				infoBusqueda.Show()
				errorLabel.Hide()
			Else
				Throw New Exception
			End If
		Catch ex As Exception
			If vinSolicitado IsNot Nothing Then
				If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                    errorLabel.Text = (My.Resources.EN_UK.MenuVehiculos_error_encontrar_vin)
                ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                    errorLabel.Text = (My.Resources.ES_LA.MenuVehiculos_error_encontrar_vin)
                Else
                    ''Portugues
                    errorLabel.Text = (My.Resources.PT_BR.MenuVehiculos_error_encontrar_vin)
                End If
			Else
				'errorLabel.Text = ("Error de escaneo")
				If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
					errorLabel.Text = (My.Resources.EN_UK.MenuVehicuos_error_escaneo)
				ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
					errorLabel.Text = (My.Resources.ES_LA.MenuVehicuos_error_escaneo)
				Else
					''Portugues
					errorLabel.Text = (My.Resources.PT_BR.MenuVehicuos_error_escaneo)
				End If
				ReloadAction()
			End If
			errorLabel.Show()
		End Try
	End Sub

	Private Sub BuscarQR_Click(sender As Object, e As EventArgs) Handles buscarQR.Click
		If Not escanerAbierto Then
			lectorQr = New EscanerQR
			lectorQr.Inicializar()
			lectorQr.Show()
			lectorQr.BringToFront()
			escanerAbierto = True
		Else
			lectorQr.BringToFront()
		End If
	End Sub

	Private Sub ResultadoQr() Handles lectorQr.Disposed
		escanerAbierto = False
		AccionBusqueda(lectorQr.GetDecodedContent)
		vin.Text = lectorQr.GetDecodedContent
	End Sub

	Private Sub btn_reload_Click(sender As Object, e As EventArgs) Handles btn_reload.Click
		ReloadAction()
	End Sub

	Private Sub ReloadAction()
		errorLabel.Hide()
		vin.Clear()
		VentanaLista.SuspendLayout()
		LimpiarVehiculos()
		If VentanaLista.Controls.Count = 0 Then
			Cargar()
		End If
		OpcGraficas()
	End Sub

	Private Sub LimpiarVehiculos()
		For var As Int32 = 0 To VentanaLista.Controls.Count - 1
			VentanaLista.Controls.Item(0).Dispose()
		Next
	End Sub

	Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
		''VENTANA NUEVO VEHICULO
	End Sub

	Private Sub Redraw() Handles Me.GotFocus
		VentanaLista.SuspendLayout()
		Cargar()
	End Sub

	Private Sub OpcGraficas()
		Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
		VentanaLista.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
		lbl_title.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		buscarQR.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
		buscarQR.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
		buscarVIN.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
		buscarVIN.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
		vin.BackColor = propiedadesVentanas.GetSingleton.ColorBackTextbox
	End Sub
	Private Sub traducirControles()
		If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
			''traduce al ingles
			lbl_title.Text = My.Resources.EN_UK.MenuVehiculos_lbltitle
			buscarQR.Text = My.Resources.EN_UK.MenuVehiculos_buscarQR
			buscarVIN.Text = My.Resources.EN_UK.MenuVehiculos_buscarVIN
		ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
			''traduce al español
			lbl_title.Text = My.Resources.ES_LA.MenuVehiculos_lbltitle
			buscarQR.Text = My.Resources.ES_LA.MenuVehiculos_buscarQR
			buscarVIN.Text = My.Resources.ES_LA.MenuVehiculos_buscarVIN
		Else
			''traduce al portugues
			lbl_title.Text = My.Resources.PT_BR.MenuVehiculos_lbltitle
			buscarQR.Text = My.Resources.PT_BR.MenuVehiculos_buscarQR
			buscarVIN.Text = My.Resources.PT_BR.MenuVehiculos_buscarVIN
		End If
	End Sub
End Class