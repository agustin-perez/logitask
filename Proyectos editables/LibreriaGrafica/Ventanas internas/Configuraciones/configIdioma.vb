Imports LibreriaLogica
Public Class configIdioma
    Private Sub ConfigTexto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TraducirControles()
        OpcGraficas()
        If DatosSesion.GetSingleton.UserLogged = Nothing Then
            eng.Enabled = True
            esp.Enabled = True
            ptg.Enabled = True
        Else
            eng.Enabled = False
            esp.Enabled = False
            ptg.Enabled = False
            errorLabel.Text = "El idioma solo se podrá cambiar en el login"
        End If
    End Sub

    Private Sub Esp_CheckedChanged(sender As Object, e As EventArgs) Handles esp.CheckedChanged
        Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA
        AplicarCambios()
    End Sub

    Private Sub Eng_CheckedChanged(sender As Object, e As EventArgs) Handles eng.CheckedChanged
        Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK
        AplicarCambios()
    End Sub

    Private Sub Ptg_CheckedChanged(sender As Object, e As EventArgs) Handles ptg.CheckedChanged
        Settings.GetSingleton.LangCFG = Settings.LangEnum.PT_BR
        AplicarCambios()
    End Sub

    Private Sub AplicarCambios()
        EntradaSalida.GetSingleton.GuardarCFG()
        propiedadesVentanas.GetSingleton.CheckConfig = True
        Me.Dispose()
    End Sub

    Private Sub TraducirControles()
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            lbl_title.Text = My.Resources.EN_UK.ConfigIdioma_lbltitle
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            lbl_title.Text = My.Resources.ES_LA.ConfigIdioma_lbltitle
        Else
            lbl_title.Text = My.Resources.PT_BR.ConfigIdioma_lbltitle
        End If
    End Sub

    Private Sub OpcGraficas()
        Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        esp.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        eng.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        ptg.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		lbl_title.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
    End Sub
End Class