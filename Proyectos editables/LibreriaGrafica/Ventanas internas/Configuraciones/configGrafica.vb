Imports System.Drawing
Imports System.Windows.Forms
Imports LibreriaLogica
Public Class configGrafica
    Public Sub New()
        InitializeComponent()
		OpcGraficas()
        TraducirControles()
        If DatosSesion.GetSingleton.UserLogged = Nothing Then
            opcClaro.Enabled = True
            opcNight.Enabled = True
        Else
            opcClaro.Enabled = False
            opcNight.Enabled = False
            errorLabel.Text = "El tema solo se podrá cambiar en el login"
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles opcClaro.CheckedChanged
        applyTema.Enabled = True
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles opcNight.CheckedChanged
        applyTema.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles applyTema.Click
        MsgBox("Sección en construcción, puede que partes de la interfaz se vean erróneas", MsgBoxStyle.Information, "Advertencia")
        If (opcClaro.Checked) Then
            propiedadesVentanas.GetSingleton.ModoNocturno = False
        Else
            propiedadesVentanas.GetSingleton.ModoNocturno = True
        End If
        propiedadesVentanas.GetSingleton.CheckConfig = True
        Settings.GetSingleton.NightModeCFG = propiedadesVentanas.GetSingleton.ModoNocturno
        AplicarCambios()
    End Sub

    Private Sub AplicarCambios()
        EntradaSalida.GetSingleton.GuardarCFG()
        propiedadesVentanas.GetSingleton.CheckConfig = True
        Me.Dispose()
    End Sub
#Region "Propiedades gráficas"
    Private Sub OpcGraficas()
        applyTema.Enabled = False
        Dim fuenteBotones = applyTema.Font
        propiedadesVentanas.GetSingleton.SizeTextoGeneral(Me.Controls)
        applyTema.Font = fuenteBotones
        Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        lbl_title.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        lbltma.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        opcClaro.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        opcNight.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        applyTema.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
    End Sub
    Private Sub TraducirControles()
        'NO ME MATES, PERO EL TITULO XD FRANQUILLO
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            ''traduce al ingles
            lbl_title.Text = My.Resources.EN_UK.ConfigGrafica_lbltitle
            lbltma.Text = My.Resources.EN_UK.ConfigGrafica_lbltma
            opcClaro.Text = My.Resources.EN_UK.ConfigGrafica_opcClaro
            opcNight.Text = My.Resources.EN_UK.ConfigGrafica_opcNight
            applyTema.Text = My.Resources.EN_UK.ConfigGrafica_applyTma
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            ''traduce al español
            lbl_title.Text = My.Resources.ES_LA.ConfigGrafica_lbltitle
            lbltma.Text = My.Resources.ES_LA.ConfigGrafica_lbltma
            opcClaro.Text = My.Resources.ES_LA.ConfigGrafica_opcClaro
            opcNight.Text = My.Resources.ES_LA.ConfigGrafica_opcNight
            applyTema.Text = My.Resources.ES_LA.ConfigGrafica_applyTma
        Else
            ''traduce al portugues
            lbl_title.Text = My.Resources.PT_BR.ConfigGrafica_lbltitle
            lbltma.Text = My.Resources.PT_BR.ConfigGrafica_lbltma
            opcClaro.Text = My.Resources.PT_BR.ConfigGrafica_opcClaro
            opcNight.Text = My.Resources.PT_BR.ConfigGrafica_opcNight
            applyTema.Text = My.Resources.PT_BR.ConfigGrafica_applyTma
        End If
    End Sub
#End Region
End Class