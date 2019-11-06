Imports LibreriaLogica
Public Class SeleccionarMedio
    Private Sub SeleccionarMedio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ventanaMedios.SuspendLayout()
        CargarMedios()
		TraducirControles()
		OpcGraficas()
	End Sub

    Private Sub CargarMedios()
        Try
            DatosSesion.GetSingleton.TileCheck = False
            Dim tabla = Transportista.GetSingleton.ListadoMediosTransporte
            For var As Short = 0 To tabla.Rows.Count - 1
                Dim tile As New TileMedio(tabla.Rows.Item(var))
                tile.TopLevel = False
                ventanaMedios.Controls.Add(tile)
                tile.Show()
            Next
            ventanaMedios.ResumeLayout()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LimpiarMedios()
        For var As Int32 = 0 To ventanaMedios.Controls.Count - 1
            ventanaMedios.Controls.Item(0).Dispose()
        Next
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        For Each var As TileMedio In ventanaMedios.Controls
            If var.IsChecked Then
                Dim Seleccion As New WeakReference(New SeleccionarLote(var.GetTupla))
                propiedadesVentanas.GetSingleton.OcultarControles(Me.Controls, ventana)
                propiedadesVentanas.GetSingleton.CargarVentana(ventana, Seleccion.Target)
                propiedadesVentanas.GetSingleton.VentanaVolver = Seleccion.Target
            End If
        Next
    End Sub

    Private Sub Reload()
        ventanaMedios.SuspendLayout()
        LimpiarMedios()
        ventanaMedios.Controls.Clear()
        CargarMedios()
        TraducirControles()
        OpcGraficas()
    End Sub

    Private Sub CerrarVentana() Handles ventana.ControlRemoved
        Reload()
        propiedadesVentanas.GetSingleton.MostrarControles(Me.Controls, ventana)
    End Sub

    Private Sub btn_reload_Click(sender As Object, e As EventArgs) Handles btn_reload.Click
        Reload()
    End Sub

    Private Sub TraducirControles()
		If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
			i_medio.SetToolTip(lbl_title, My.Resources.EN_UK.SeleccionarMedio_subtitulo)
			i_medio.ToolTipTitle = (My.Resources.EN_UK.SeleccionarMedio_informacion)
			lbl_title.Text = My.Resources.EN_UK.SeleccionarMedio_lbl_title
			btn_next.Text = My.Resources.EN_UK.SeleccionarMedio_btnNext
		ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
			i_medio.SetToolTip(lbl_title, My.Resources.ES_LA.SeleccionarMedio_subtitulo)
			i_medio.ToolTipTitle = (My.Resources.ES_LA.SeleccionarMedio_informacion)
			lbl_title.Text = My.Resources.ES_LA.SeleccionarMedio_lbl_title
			btn_next.Text = My.Resources.ES_LA.SeleccionarMedio_btnNext
		Else
			i_medio.SetToolTip(lbl_title, My.Resources.PT_BR.SeleccionarMedio_subtitulo)
			i_medio.ToolTipTitle = (My.Resources.PT_BR.SeleccionarMedio_informacion)
			lbl_title.Text = My.Resources.PT_BR.SeleccionarMedio_lbl_title
			btn_next.Text = My.Resources.PT_BR.SeleccionarMedio_btnNext
		End If
	End Sub

    Private Sub OpcGraficas()
        ventanaMedios.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        btn_next.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
        btn_next.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
    End Sub
End Class