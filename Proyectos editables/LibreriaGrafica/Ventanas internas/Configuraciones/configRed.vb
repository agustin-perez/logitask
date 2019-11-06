Imports LibreriaLogica
Imports System.Windows.Forms
Public Class configRed
    Private Sub configRed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpcGraficas()
        lbl_connected.Hide()
        Me.KeyPreview = True
        VerificarConexion()
		ruta.Text = Settings.GetSingleton.RutaDsnCFG
		traducirControles()
	End Sub

    Private Sub Cambiar_Click(sender As Object, e As EventArgs) Handles cambiar.Click
        Try
            EntradaSalida.GetSingleton.BuscarDSN()
            ruta.Text = EntradaSalida.GetSingleton.RutaDsnCFG
        Catch ex As Exception
            If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                MsgBox(My.Resources.EN_UK.ConfigRed_error_lectura)
            ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                MsgBox(My.Resources.ES_LA.ConfigRed_error_lectura)
            Else
                ''Portugues
                MsgBox(My.Resources.PT_BR.ConfigRed_error_lectura)
            End If
            'MsgBox("Error al leer archivo", MsgBoxStyle.Critical, "Error de lectura")
        End Try
    End Sub

    Private Sub VerificarConexion()
        If EntradaSalida.GetSingleton.IsConnected Then
            lbl_connected.Show()
            conectar.Enabled = False
        End If
    End Sub

    Private Sub Connect()
        Try
            ConsultasPrincipales.GetSingleton.SetUserBBDD = usuario.Text
            ConsultasPrincipales.GetSingleton.SetPassBBDD = pass.Text
            ConsultasPrincipales.GetSingleton.ActivarConexion()
            VerificarConexion()
            Settings.GetSingleton.SetDatabaseUser = usuario.Text
            Settings.GetSingleton.SetDatabasePassword = pass.Text
            Settings.GetSingleton.RutaDsnCFG = EntradaSalida.GetSingleton.RutaDsnCFG
            EntradaSalida.GetSingleton.GuardarCFG()
        Catch ex As Exception
            MsgBox("Error: " + My.Resources.ErrorCodes.ErrorConexion, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Conectar_Click(sender As Object, e As EventArgs) Handles conectar.Click
        Cursor.Current = Cursors.WaitCursor
        Connect()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Conectar_Handler(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Connect()
        End If
    End Sub

	Private Sub OpcGraficas()
		Dim fuenteBoton = cambiar.Font
		propiedadesVentanas.GetSingleton.SizeTextoGeneral(Me.Controls)
		cambiar.Font = fuenteBoton
		conectar.Font = fuenteBoton
		Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
		lblruta.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		lbluser.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		lblpass.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		lbl_title.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		lblbbdd.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		lblinfo.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		ruta.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		usuario.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		pass.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels

		cambiar.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
		cambiar.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
		cambiar.Size = propiedadesVentanas.GetSingleton.SizeEstandarBotones
		cambiar.Font = propiedadesVentanas.GetSingleton.FuenteEstandarBotones

		conectar.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
		conectar.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
		conectar.Size = propiedadesVentanas.GetSingleton.SizeEstandarBotones
		conectar.Font = propiedadesVentanas.GetSingleton.FuenteEstandarBotones

		usuario.BackColor = propiedadesVentanas.GetSingleton.ColorBackTextbox
		pass.BackColor = propiedadesVentanas.GetSingleton.ColorBackTextbox
		lbl_connected.Hide()
	End Sub

	Private Sub traducirControles()
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            ''traduce al ingles
            lbl_title.Text = My.Resources.EN_UK.ConfigRed_lbltitle
            lblruta.Text = My.Resources.EN_UK.ConfigRed_lblruta
            lblinfo.Text = My.Resources.EN_UK.ConfigRed_lblinfo
            lblpass.Text = My.Resources.EN_UK.ConfigRed_lblpass
            lblbbdd.Text = My.Resources.EN_UK.ConfigRed_lblbbdd
            lbluser.Text = My.Resources.EN_UK.ConfigRed_lbluser
			cambiar.Text = My.Resources.EN_UK.ConfigRed_cambiar
			conectar.Text = My.Resources.EN_UK.ConfigRed_conectar
		ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            ''traduce al español
            lbl_title.Text = My.Resources.ES_LA.ConfigRed_lbltitle
            lblruta.Text = My.Resources.ES_LA.ConfigRed_lblruta
            lblinfo.Text = My.Resources.ES_LA.ConfigRed_lblinfo
            lblpass.Text = My.Resources.ES_LA.ConfigRed_lblpass
            lblbbdd.Text = My.Resources.ES_LA.ConfigRed_lblbbdd
            lbluser.Text = My.Resources.ES_LA.ConfigRed_lbluser
			cambiar.Text = My.Resources.ES_LA.ConfigRed_cambiar
			conectar.Text = My.Resources.ES_LA.ConfigRed_conectar
		Else
            ''traduce al portugues
            lbl_title.Text = My.Resources.PT_BR.ConfigRed_lbltitle
			lblruta.Text = My.Resources.PT_BR.ConfigRed_lblruta
			lblinfo.Text = My.Resources.PT_BR.ConfigRed_lblinfo
			lblpass.Text = My.Resources.PT_BR.ConfigRed_lblpass
			lblbbdd.Text = My.Resources.PT_BR.ConfigRed_lblbbdd
			lbluser.Text = My.Resources.PT_BR.ConfigRed_lbluser
			cambiar.Text = My.Resources.PT_BR.ConfigRed_cambiar
			conectar.Text = My.Resources.PT_BR.ConfigRed_conectar
		End If
	End Sub
End Class