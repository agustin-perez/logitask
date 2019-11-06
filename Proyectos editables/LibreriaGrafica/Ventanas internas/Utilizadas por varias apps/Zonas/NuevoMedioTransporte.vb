Imports LibreriaLogica
Public Class NuevoMedioTransporte
	Private Sub NuevoMedioTransporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		traducirControles()
		opcGraficas()
	End Sub

	Private Sub traducirControles()
		If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
			''traduce al ingles
			lbl_title.Text = My.Resources.EN_UK.NuevoMedioTransporte_lbltitle
			lbl_numero.Text = My.Resources.EN_UK.NuevoMedioTransporte_lblnumero
			lbl_matricula.Text = My.Resources.EN_UK.NuevoMedioTransporte_lblmatricula
			lbl_capacidad.Text = My.Resources.EN_UK.NuevoMedioTransporte_lblcapacidad
			btn_save.Text = My.Resources.EN_UK.NuevoMedioTransporte_btnsave
		ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
			''traduce al español
			lbl_title.Text = My.Resources.ES_LA.NuevoMedioTransporte_lbltitle
			lbl_numero.Text = My.Resources.ES_LA.NuevoMedioTransporte_lblnumero
			lbl_matricula.Text = My.Resources.ES_LA.NuevoMedioTransporte_lblmatricula
			lbl_capacidad.Text = My.Resources.ES_LA.NuevoMedioTransporte_lblcapacidad
			btn_save.Text = My.Resources.ES_LA.NuevoMedioTransporte_btnsave
		Else
			''traduce al portugues
			lbl_title.Text = My.Resources.PT_BR.NuevoMedioTransporte_lbltitle
			lbl_numero.Text = My.Resources.PT_BR.NuevoMedioTransporte_lblnumero
			lbl_matricula.Text = My.Resources.PT_BR.NuevoMedioTransporte_lblmatricula
			lbl_capacidad.Text = My.Resources.PT_BR.NuevoMedioTransporte_lblcapacidad
			btn_save.Text = My.Resources.PT_BR.NuevoMedioTransporte_btnsave
		End If
	End Sub

	Private Sub opcGraficas()
		Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
		lbl_numero.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		lbl_title.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		lbl_matricula.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		lbl_capacidad.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		btn_save.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
		btn_save.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
	End Sub
End Class