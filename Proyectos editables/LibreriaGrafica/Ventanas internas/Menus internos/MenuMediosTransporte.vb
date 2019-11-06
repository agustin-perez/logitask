Imports LibreriaLogica
Public Class MenuMediosTransporte
	Private Sub ListadoMediosTransporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		traducirControles()
		opcGraficas()
	End Sub

	Private Sub traducirControles()
		If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
			''traduce al ingles
			lbl_title.Text = My.Resources.EN_UK.ListadoMediosTransporte_lbltitle

		ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
			''traduce al español
			lbl_title.Text = My.Resources.ES_LA.ListadoMediosTransporte_lbltitle

		Else
			''traduce al portugues
			lbl_title.Text = My.Resources.PT_BR.ListadoMediosTransporte_lbltitle

		End If
	End Sub

	Private Sub opcGraficas()
		Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
		lbl_title.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		ventanaMedios.BackColor = propiedadesVentanas.GetSingleton.ColorPanelesMenu
	End Sub
End Class