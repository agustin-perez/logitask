Imports LibreriaLogica
Public Class cambioPass
    Public Sub New()
        InitializeComponent()
        traducirControles()
        OpcGraficas()
    End Sub

    Private Sub traducirControles()
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            ''traduce al ingles
            lbl_newPass.Text = My.Resources.EN_UK.CambioPass_lblnewPass
            lbl_oldPass.Text = My.Resources.EN_UK.CambioPass_lbloldPass
            lbl_title.Text = My.Resources.EN_UK.CambioPass_lbltitle
            btn_cambiar.Text = My.Resources.EN_UK.CambioPass_btnCambiar
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            ''traduce al español
            lbl_newPass.Text = My.Resources.ES_LA.CambioPass_lblnewPass
            lbl_oldPass.Text = My.Resources.ES_LA.CambioPass_lbloldPass
            lbl_title.Text = My.Resources.ES_LA.CambioPass_lbltitle
            btn_cambiar.Text = My.Resources.ES_LA.CambioPass_btnCambiar
        Else
            ''traduce al portugues
            lbl_newPass.Text = My.Resources.PT_BR.CambioPass_lblnewPass
            lbl_oldPass.Text = My.Resources.PT_BR.CambioPass_lbloldPass
            lbl_title.Text = My.Resources.PT_BR.CambioPass_lbltitle
            btn_cambiar.Text = My.Resources.PT_BR.CambioPass_btnCambiar
        End If
    End Sub

    Private Sub OpcGraficas()
        Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        lbl_title.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        lbl_newPass.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        lbl_oldPass.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        btn_cambiar.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
        btn_cambiar.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
    End Sub
End Class