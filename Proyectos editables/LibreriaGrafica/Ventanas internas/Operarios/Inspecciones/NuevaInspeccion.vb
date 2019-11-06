Imports LibreriaLogica
Public Class NuevaInspeccion
    Private Sub NuevaInspeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SuspendLayout()
        OpcGraficas()
        cargar()
		Me.ResumeLayout()
		traducirControles()
	End Sub

    Public Sub cargar()
        Try
            Me.SuspendLayout()
            ventana_vehiculos.Controls.Clear()
            Dim tabla = ConsultasDeLectura.GetSingleton.ListadoVehiculos
            For var As Short = 0 To tabla.Rows.Count - 1
                Dim tile As New TileVehiculo(tabla.Rows.Item(var), TileVehiculo.TileActionOnClick.DisposeOnClick)
                tile.TopLevel = False
                tile.CambioImagen()
                ventana_vehiculos.Controls.Add(tile)
                tile.Show()
            Next
            propiedadesVentanas.GetSingleton.CancelarInspeccion = False
            Me.ResumeLayout()
        Catch ex As exception
        End Try
    End Sub

    Private Sub CargarInspeccion() Handles ventana_vehiculos.ControlRemoved
        If Not propiedadesVentanas.GetSingleton.CancelarInspeccion Then
            propiedadesVentanas.GetSingleton.OcultarControles(Me.Controls, ventana)
            Try
                Dim setupInspeccion As New DatosNuevaInspeccion()
                propiedadesVentanas.GetSingleton.CargarVentana(ventana, setupInspeccion)
                propiedadesVentanas.GetSingleton.VentanaVolver = Me
            Catch ex As Exception
				MsgBox("Error: " & My.Resources.ErrorCodes.ErrorEspecial) 'PASAR RECURSOS de error A PROYECTOS INDEPENDIENTES
			End Try
        End If
    End Sub

    Private Sub Resetear() Handles ventana.ControlRemoved
        propiedadesVentanas.GetSingleton.CancelarInspeccion = True
        btn_qr.Show()
        btn_vin.Show()
        txtb_vin.Show()
        ventana_vehiculos.Show()
        cargar()
    End Sub

    Private Sub vinInspec_Click(sender As Object, e As EventArgs) Handles btn_vin.Click

    End Sub

    Private Sub btn_qr_Click(sender As Object, e As EventArgs) Handles btn_qr.Click

    End Sub

    'AÑADIR HANDLER PARA DATOS DE INSPECCION DISPOSEADA

    'AÑADIR SUBRUTINA QUE VUELVA A CREAR ESTA CLASE DESDE DATOSINSPECCION

    Private Sub SetIdiomas()

    End Sub

	Private Sub OpcGraficas()
		Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
		btn_qr.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
		btn_qr.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
		btn_vin.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
		btn_vin.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
		txtb_vin.BackColor = propiedadesVentanas.GetSingleton.ColorBackTextbox
		txtb_vin.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
		ventana_vehiculos.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
	End Sub

	Private Sub traducirControles()
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            ''traduce al ingles
            btn_qr.Text = My.Resources.EN_UK.NuevaInspeccion_btnQR
            btn_vin.Text = My.Resources.EN_UK.NuevaInspeccion_btnVIN
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            ''traduce al español
            btn_qr.Text = My.Resources.ES_LA.NuevaInspeccion_btnQR
            btn_vin.Text = My.Resources.ES_LA.NuevaInspeccion_btnVIN
        Else
            ''traduce al portugues
            btn_qr.Text = My.Resources.PT_BR.NuevaInspeccion_btnQR
			btn_vin.Text = My.Resources.PT_BR.NuevaInspeccion_btnVIN
		End If
	End Sub
End Class