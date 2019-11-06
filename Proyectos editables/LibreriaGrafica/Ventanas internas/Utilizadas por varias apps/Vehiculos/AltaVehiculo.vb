Imports LibreriaLogica
Public Class AltaVehiculo
	Private Sub AltaVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		traducirControles()
		opcGraficas()
	End Sub

	Private Sub traducirControles()
		If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
			''traduce al ingles
			lbl_title.Text = My.Resources.EN_UK.AltaVehiculo_lbltitle
			lbl_VIN.Text = My.Resources.EN_UK.AltaVehiculo_lblvin
			lbl_marca.Text = My.Resources.EN_UK.AltaVehiculo_lblmarca
			lbl_modelo.Text = My.Resources.EN_UK.AltaVehiculo_lblmodelo
			lbl_color.Text = My.Resources.EN_UK.AltaVehiculo_lblcolor
			lbl_anio.Text = My.Resources.EN_UK.AltaVehiculo_lblanio
			lbl_tipo.Text = My.Resources.EN_UK.AltaVehiculo_lbltipo
		ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
			''traduce al español
			lbl_title.Text = My.Resources.ES_LA.AltaVehiculo_lbltitle
			lbl_VIN.Text = My.Resources.ES_LA.AltaVehiculo_lblvin
			lbl_marca.Text = My.Resources.ES_LA.AltaVehiculo_lblmarca
			lbl_modelo.Text = My.Resources.ES_LA.AltaVehiculo_lblmodelo
			lbl_color.Text = My.Resources.ES_LA.AltaVehiculo_lblcolor
			lbl_anio.Text = My.Resources.ES_LA.AltaVehiculo_lblanio
			lbl_tipo.Text = My.Resources.ES_LA.AltaVehiculo_lbltipo
		Else
			''traduce al portugues
			lbl_title.Text = My.Resources.PT_BR.AltaVehiculo_lbltitle
			lbl_VIN.Text = My.Resources.PT_BR.AltaVehiculo_lblvin
			lbl_marca.Text = My.Resources.PT_BR.AltaVehiculo_lblmarca
			lbl_modelo.Text = My.Resources.PT_BR.AltaVehiculo_lblmodelo
			lbl_color.Text = My.Resources.PT_BR.AltaVehiculo_lblcolor
			lbl_anio.Text = My.Resources.PT_BR.AltaVehiculo_lblanio
			lbl_tipo.Text = My.Resources.PT_BR.AltaVehiculo_lbltipo
		End If
	End Sub

    Private Sub opcGraficas()
        Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        lbl_title.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        lbl_VIN.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        lbl_tipo.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        lbl_anio.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        lbl_color.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        lbl_marca.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        lbl_modelo.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        btn_crear.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
        btn_crear.ForeColor = propiedadesVentanas.GetSingleton.ColorBackBotones
    End Sub
End Class