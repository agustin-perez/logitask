Imports LibreriaGrafica
Imports LibreriaLogica
Public Class Damage
    Private fotoAconvertir As Drawing.Bitmap
    Private vinInterno As String

    Public Sub New(vin As String)
        InitializeComponent()
        vinInterno = vin
		OpcGraficas()
		traducirControles()
	End Sub

    Private Sub btn_listo_Click(sender As Object, e As EventArgs) Handles btn_listo.Click
        Try
            If txt_descripcion.Lines.Count = 0 Then
                ''MsgBox("Debe ingresar algo en la descripción")
                If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                    MsgBox(My.Resources.EN_UK.Damage_descripcion_vacio)
                ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                    MsgBox(My.Resources.ES_LA.Damage_descripcion_vacio)
                Else
                    ''Portugues
                    MsgBox(My.Resources.PT_BR.Damage_descripcion_vacio)
                End If
            Else
                Operarios.GetSingleton.Damages(vinInterno, propiedadesVentanas.GetSingleton.ImagenToBytes(pic_imagen.Image), txt_descripcion.Text)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error: " + My.Resources.ErrorCodes.ErrorEscaneo)
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_img_Click(sender As Object, e As EventArgs) Handles btn_img.Click
        Try
            Dim path As String = EntradaSalida.GetSingleton.CargarImagen()
            Dim foto As New Drawing.Bitmap(path)
            fotoAconvertir = foto
            pic_imagen.Image = foto
            lbl_ruta.Text = path
        Catch ex As Exception
            MsgBox("Error: " & My.Resources.ErrorCodes.ErrorCargarImg, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Fuentes()
        propiedadesVentanas.GetSingleton.SizeTextoGeneral(Me.Controls, New Object)
    End Sub

	Private Sub OpcGraficas()
		Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
		btn_img.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
		btn_img.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
		btn_img.Size = propiedadesVentanas.GetSingleton.SizeEstandarBotones
		btn_img.Font = propiedadesVentanas.GetSingleton.FuenteEstandarBotones
		btn_listo.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
		btn_listo.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
		btn_listo.Size = propiedadesVentanas.GetSingleton.SizeEstandarBotones
		btn_listo.Font = propiedadesVentanas.GetSingleton.FuenteEstandarBotones
		btn_cancelar.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
		btn_cancelar.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
		btn_cancelar.Size = propiedadesVentanas.GetSingleton.SizeEstandarBotones
		btn_cancelar.Font = propiedadesVentanas.GetSingleton.FuenteEstandarBotones
		lbl_ruta.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		lbl_damage.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		lbl_desc.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		pic_imagen.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
		txt_descripcion.BackColor = propiedadesVentanas.GetSingleton.ColorBackTextbox
		txt_descripcion.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
	End Sub

    Private Sub traducirControles()
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            ''traduce al ingles
            lbl_damage.Text = My.Resources.EN_UK.Damage_lbldamage
            lbl_desc.Text = My.Resources.EN_UK.Damage_lbldesc
            btn_cancelar.Text = My.Resources.EN_UK.Damage_btncancelar
            btn_img.Text = My.Resources.EN_UK.Damage_btnimg
            btn_listo.Text = My.Resources.EN_UK.Damage_btnlisto
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            ''traduce al español
            lbl_damage.Text = My.Resources.ES_LA.Damage_lbldamage
            lbl_desc.Text = My.Resources.ES_LA.Damage_lbldesc
            btn_cancelar.Text = My.Resources.ES_LA.Damage_btncancelar
            btn_img.Text = My.Resources.ES_LA.Damage_btnimg
            btn_listo.Text = My.Resources.ES_LA.Damage_btnlisto
        Else
            ''traduce al portugues
            lbl_damage.Text = My.Resources.PT_BR.Damage_lbldamage
            lbl_desc.Text = My.Resources.PT_BR.Damage_lbldesc
            btn_cancelar.Text = My.Resources.PT_BR.Damage_btncancelar
            btn_img.Text = My.Resources.PT_BR.Damage_btnimg
            btn_listo.Text = My.Resources.PT_BR.Damage_btnlisto
        End If
    End Sub
End Class