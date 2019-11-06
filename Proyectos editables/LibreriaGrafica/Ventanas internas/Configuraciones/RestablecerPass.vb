Imports LibreriaLogica
Public Class RestablecerPass
    Public Sub New()
        InitializeComponent()
        traducirControles()
        OpcGraficas()
    End Sub


    Private Sub traducirControles()
		If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            ''traduce al ingles
			lbl_title.Text = My.Resources.EN_UK.RestablecerPass_lbltitle
			lbl_subtitle.Text= My.Resources.EN_UK.RestablecerPass_lblsubtitle
			lbl_username.text= My.Resources.EN_UK.RestablecerPass_lblusername
			btn_solicitar.Text = My.Resources.EN_UK.RestablecerPass_btnSolicitar
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            ''traduce al español
            lbl_title.Text = My.Resources.ES_LA.RestablecerPass_lbltitle
			lbl_subtitle.Text= My.Resources.ES_LA.RestablecerPass_lblsubtitle
			lbl_username.text= My.Resources.ES_LA.RestablecerPass_lblusername
			btn_solicitar.Text = My.Resources.ES_LA.RestablecerPass_btnSolicitar
        Else
            ''traduce al portugues
            lbl_title.Text = My.Resources.PT_BR.RestablecerPass_lbltitle
			lbl_subtitle.Text= My.Resources.PT_BR.RestablecerPass_lblsubtitle
			lbl_username.text= My.Resources.PT_BR.RestablecerPass_lblusername
			btn_solicitar.Text = My.Resources.PT_BR.RestablecerPass_btnSolicitar
        End If
	End Sub

	Private Sub OpcGraficas()
        Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        btn_solicitar.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
		btn_solicitar.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
		lbl_subtitle.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		lbl_title.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		lbl_username.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
    End Sub
End Class