Imports LibreriaLogica
Public Class MenuZonas
    Private cargado As Boolean
    Private accionTile As TileLugar.TileActionOnClick
    Private Sub ListadoZonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpcGraficas()
        CargarZonas()
        traducirControles()
	End Sub

    Public Sub TipoAccion(accion As TileLugar.TileActionOnClick)
        Me.accionTile = accion
    End Sub

    'AL DAR CLICK EN TILE HANDLEA DISPOSE Y CARGA LOS TILES DE LA SUBZONA EN EL VENTANAZONAS, CAMBIANDO EL TÍTULO A SUBZONAS DE: NOMBRE
    Private Sub CargarZonas()
        Try
            ventanaZonas.Controls.Clear()
            GC.Collect()
            Dim tabla = ConsultasDeLectura.GetSingleton.ListadoLugares
            For var As Short = 0 To tabla.Rows.Count - 1
                Dim tile As New TileLugar(tabla.Rows.Item(var), accionTile)
                tile.TopLevel = False
                ventanaZonas.Controls.Add(tile)
                tile.Show()
            Next
            cargado = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CargarDetalles() Handles ventanaZonas.ControlRemoved

    End Sub

    Private Sub ReloadAction()
        errorLabel.Hide()
        LimpiarVehiculos()
        If ventanaZonas.Controls.Count = 0 Then
            CargarZonas()
        End If
        OpcGraficas()
    End Sub

    Private Sub LimpiarVehiculos()
        For var As Int32 = 0 To ventanaZonas.Controls.Count - 1
            ventanaZonas.Controls.Item(0).Dispose()
        Next
    End Sub

    Private Sub btn_change_Click(sender As Object, e As EventArgs) Handles btn_change.Click
        Dim Movimiento As New WeakReference(New SeleccionZona)
        propiedadesVentanas.GetSingleton.CargarVentana(ventana, Movimiento.Target)
        propiedadesVentanas.GetSingleton.VentanaVolver = Movimiento.Target
        propiedadesVentanas.GetSingleton.OcultarControles(Me.Controls, ventana)
    End Sub

    Private Sub VentanaCerrada() Handles ventana.ControlRemoved
        propiedadesVentanas.GetSingleton.MostrarControles(Me.Controls, ventana)
        ventana.Controls.Clear()
    End Sub

    Private Sub btn_reload_Click(sender As Object, e As EventArgs) Handles btn_reload.Click
        ReloadAction()
    End Sub

    Private Sub OpcGraficas()
		Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
		ventanaZonas.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
		lbl_title.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
	End Sub

    Private Sub traducirControles()
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            ''traduce al ingles
            lbl_title.Text = My.Resources.EN_UK.ListadoZonas_lbltitle
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            ''traduce al español
            lbl_title.Text = My.Resources.ES_LA.ListadoZonas_lbltitle
        Else
            ''traduce al portugues
            lbl_title.Text = My.Resources.PT_BR.ListadoZonas_lbltitle
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        'CHEQUEAR LA CAPACIDAD!!!!!!!!!!!!!!
    End Sub
End Class