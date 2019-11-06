Imports LibreriaLogica
Public Class EscanerQR
    Private instanciaFunciones As New FuncionesEspecificas
    Private mensaje As String
    Public Sub New()
        InitializeComponent()
		Inicializar()
		traducirControles()
		OpcGraficas()
	End Sub

	Public Sub Inicializar()
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            ''traduce al ingles
            Me.Text = My.Resources.EN_UK.EscanerQR_meText
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            ''traduce al español
            Me.Text = My.Resources.ES_LA.EscanerQR_meText
        Else
            ''traduce al portugues
            Me.Text = My.Resources.PT_BR.EscanerQR_meText
		End If
		'Me.Text = "Apunte al código QR y presione 'Escanear'"
		pantallaCamara.Start()
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_scan.Click
        Dim imagen As Drawing.Bitmap = pantallaCamara.Imagen
		Try
			mensaje = instanciaFunciones.DecodeQR(imagen)
            If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                ''traduce al ingles
                Me.Text = My.Resources.EN_UK.EscanerQR_codigoEscaneado
            ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                ''traduce al español
                Me.Text = My.Resources.ES_LA.EscanerQR_codigoEscaneado
            Else
                ''traduce al portugues
                Me.Text = My.Resources.PT_BR.EscanerQR_codigoEscaneado
			End If
			'Me.Text = "Código escaneado! Mensaje: " + mensaje
			pantallaCamara.Stop()
			Me.Dispose()
		Catch ex As Exception
            If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                ''traduce al ingles
                Me.Text = My.Resources.EN_UK.EscanerQR_errorEscaneo
            ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                ''traduce al español
                Me.Text = My.Resources.ES_LA.EscanerQR_errorEscaneo
            Else
                ''traduce al portugues
                Me.Text = My.Resources.PT_BR.EscanerQR_errorEscaneo
			End If
			'Me.Text = "QR no detectado, intente nuevamente"
		End Try
    End Sub

    Public ReadOnly Property GetDecodedContent() As String
        Get
            Return mensaje
        End Get
    End Property

	Private Sub LiberarRecursos() Handles Me.Disposed
		pantallaCamara.Stop()
		pantallaCamara.Dispose()
		GC.Collect()
	End Sub

	Private Sub traducirControles()
		If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
			''traduce al ingles
			btn_scan.Text = My.Resources.EN_UK.EscanerQR_btnscan
		ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
			''traduce al español
			btn_scan.Text = My.Resources.ES_LA.EscanerQR_btnscan
		Else
			''traduce al portugues
			btn_scan.Text = My.Resources.PT_BR.EscanerQR_btnscan
		End If
	End Sub

	Private Sub OpcGraficas()
		Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
		Me.btn_scan.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
		Me.btn_scan.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
	End Sub
End Class