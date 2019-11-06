Imports System.Windows.Forms
Imports LibreriaLogica
Public Class AltaUser
    Private Sub AltaUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		OpcGraficas()
		traducirControles()
	End Sub

    Private Sub Btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Try
            InsertarDatos(txt_tel.MaskCompleted, txt_cell.MaskCompleted)
            txt_cell.Clear()
            txt_name.Clear()
            txt_pass.Clear()
            txt_surname.Clear()
            txt_tel.Clear()
            txt_username.Clear()
            If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                MsgBox(My.Resources.EN_UK.AltaUser_usuario_ingresado)
            ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                MsgBox(My.Resources.ES_LA.AltaUser_usuario_ingresado)
            Else
                ''Portugues
                MsgBox(My.Resources.PT_BR.AltaUser_usuario_ingresado)
            End If
        Catch ex As Exception
            If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                MsgBox(My.Resources.EN_UK.AltaUser_usuario_vacios_duplicado)
            ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                MsgBox(My.Resources.ES_LA.AltaUser_usuario_vacios_duplicado)
            Else
                ''Portugues
                MsgBox(My.Resources.PT_BR.AltaUser_usuario_vacios_duplicado)
            End If
        End Try
    End Sub

    Private Sub InsertarDatos(tel1 As Boolean, tel2 As Boolean)
        DesactivarMascara()
        If tel1 = False Then
            Admin.GetSingleton.AltaUsuario(txt_username.Text, txt_pass.Text, txt_name.Text, txt_surname.Text, "", txt_cell.Text)
        End If
        If tel2 = False Then
            Admin.GetSingleton.AltaUsuario(txt_username.Text, txt_pass.Text, txt_name.Text, txt_surname.Text, txt_tel.Text, "")
        End If
        If tel1 And tel2 Then
            Admin.GetSingleton.AltaUsuario(txt_username.Text, txt_pass.Text, txt_name.Text, txt_surname.Text, txt_tel.Text, txt_cell.Text)
        End If
        ActivarMascara()
    End Sub

    Private Sub DesactivarMascara()
        txt_name.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        txt_surname.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        txt_username.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        txt_tel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        txt_cell.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
    End Sub

    Private Sub ActivarMascara()
        txt_name.TextMaskFormat = MaskFormat.IncludePromptAndLiterals
        txt_surname.TextMaskFormat = MaskFormat.IncludePromptAndLiterals
        txt_username.TextMaskFormat = MaskFormat.IncludePromptAndLiterals
        txt_tel.TextMaskFormat = MaskFormat.IncludePromptAndLiterals
        txt_cell.TextMaskFormat = MaskFormat.IncludePromptAndLiterals
    End Sub

    Private Sub SetearAlInicio(sender As MaskedTextBox, e As EventArgs) Handles txt_cell.Click, txt_name.Click, txt_surname.Click, txt_tel.Click, txt_username.Click
        sender.Select(0, 0)
    End Sub

    Private Sub OpcGraficas()
		Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
		lbl_ape.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		lbl_cell.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		lbl_name.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		lbl_pass.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		lbl_tel.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		lbl_username.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		btn_guardar.Size = propiedadesVentanas.GetSingleton.SizeEstandarBotones
		btn_guardar.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
		btn_guardar.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
		txt_cell.BackColor = propiedadesVentanas.GetSingleton.ColorBackTextbox
		txt_cell.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		txt_name.BackColor = propiedadesVentanas.GetSingleton.ColorBackTextbox
		txt_name.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		txt_pass.BackColor = propiedadesVentanas.GetSingleton.ColorBackTextbox
		txt_pass.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		txt_surname.BackColor = propiedadesVentanas.GetSingleton.ColorBackTextbox
		txt_surname.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		txt_tel.BackColor = propiedadesVentanas.GetSingleton.ColorBackTextbox
		txt_tel.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		txt_username.BackColor = propiedadesVentanas.GetSingleton.ColorBackTextbox
		txt_username.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
	End Sub

	Private Sub traducirControles()
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            ''traduce al ingles
            lbl_username.Text = My.Resources.EN_UK.AltaUser_lbl_username
            lbl_pass.Text = My.Resources.EN_UK.AltaUser_lbl_pass
            lbl_name.Text = My.Resources.EN_UK.AltaUser_lbl_name
            lbl_ape.Text = My.Resources.EN_UK.AltaUser_lbl_ape
            lbl_tel.Text = My.Resources.EN_UK.AltaUser_lbl_tel
            lbl_cell.Text = My.Resources.EN_UK.AltaUser_lbl_tel
            btn_guardar.Text = My.Resources.EN_UK.AltaUser_btn_guardar
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            ''traduce al español
            lbl_username.Text = My.Resources.ES_LA.AltaUser_lbl_username
            lbl_pass.Text = My.Resources.ES_LA.AltaUser_lbl_pass
            lbl_name.Text = My.Resources.ES_LA.AltaUser_lbl_name
            lbl_ape.Text = My.Resources.ES_LA.AltaUser_lbl_ape
            lbl_tel.Text = My.Resources.ES_LA.AltaUser_lbl_tel
            lbl_cell.Text = My.Resources.ES_LA.AltaUser_lbl_tel
            btn_guardar.Text = My.Resources.ES_LA.AltaUser_btn_guardar
        Else
            ''traduce al portugues
            lbl_username.Text = My.Resources.PT_BR.AltaUser_lbl_username
			lbl_pass.Text = My.Resources.PT_BR.AltaUser_lbl_pass
			lbl_name.Text = My.Resources.PT_BR.AltaUser_lbl_name
			lbl_ape.Text = My.Resources.PT_BR.AltaUser_lbl_ape
			lbl_tel.Text = My.Resources.PT_BR.AltaUser_lbl_tel
			lbl_cell.Text = My.Resources.PT_BR.AltaUser_lbl_tel
			btn_guardar.Text = My.Resources.PT_BR.AltaUser_btn_guardar
		End If
	End Sub
End Class