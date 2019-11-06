Imports System.Windows.Forms
Imports LibreriaGrafica
Imports LibreriaLogica
Public Class DatosNuevaInspeccion
    Private vinInterno As String
    Private numeroDamage As Integer = 1
    Public Sub New()
        InitializeComponent()
        OpcGraficas()
        traducirControles()
        vinInterno = DatosSesion.GetSingleton.VinTemp
        lbl_numeroInspec.Text = "#" & ConsultasDeLectura.GetSingleton.GetUltimaInspeccionVehiculo(vinInterno) + 1
    End Sub

    Private Sub btn_newDamage_Click(sender As Object, e As EventArgs) Handles btn_newDamage.Click
        Dim damage As New Damage(vinInterno)
        propiedadesVentanas.GetSingleton.OcultarControles(Me.Controls, ventana)
        propiedadesVentanas.GetSingleton.CargarVentana(ventana, damage)
        propiedadesVentanas.GetSingleton.VentanaVolver = Nothing
    End Sub

    Private Sub DamageClosed() Handles ventana.ControlRemoved
        ventana.Controls.Clear()
        propiedadesVentanas.GetSingleton.MostrarControles(Me.Controls, ventana)
        If numeroDamage <> Operarios.GetSingleton.GetDamageList Then
            contenedorVentana.Controls.Clear()
            Dim fecha As String = Format(Date.Now, "hh:mm:ss")
            If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                txt_damages.Text = (txt_damages.Text + Environment.NewLine + My.Resources.EN_UK.DatosInspeccion_daño + numeroDamage.ToString + " - " + fecha)
            ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                txt_damages.Text = (txt_damages.Text + Environment.NewLine + My.Resources.ES_LA.DatosInspeccion_daño + numeroDamage.ToString + " - " + fecha)
            Else
                ''Portugues
                txt_damages.Text = (txt_damages.Text + Environment.NewLine + My.Resources.PT_BR.DatosInspeccion_daño + numeroDamage.ToString + " - " + fecha)
            End If
            numeroDamage = Operarios.GetSingleton.GetDamageList
        End If
    End Sub

    Private Sub Btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Try
            Operarios.GetSingleton.GuardarInspeccion(vinInterno, DatosSesion.GetSingleton.LugarTemporal)
            Operarios.GetSingleton.MandarConsultasInspecc()
            If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                MsgBox(My.Resources.EN_UK.DatosInspeccion_guardadoExitoso, MsgBoxStyle.Information, My.Resources.EN_UK.Ready) ' PASAR A RECURSO
            ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                MsgBox(My.Resources.ES_LA.DatosInspeccion_guardadoExitoso, MsgBoxStyle.Information, My.Resources.ES_LA.Ready) ' PASAR A RECURSO
            Else
                MsgBox(My.Resources.PT_BR.DatosInspeccion_guardadoExitoso, MsgBoxStyle.Information, My.Resources.PT_BR.Ready) ' PASAR A RECURSO
            End If
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Error:" & My.Resources.ErrorCodes.ErrorConexion) 'Error de conexión
        End Try
    End Sub

    Private Sub DamageClosed(sender As Object, e As ControlEventArgs) Handles ventana.ControlRemoved
        propiedadesVentanas.GetSingleton.VentanaVolver = Me
    End Sub

    Private Sub OpcGraficas()
        Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        btn_guardar.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
        btn_guardar.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
        btn_newDamage.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
        btn_newDamage.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
        txt_damages.BackColor = Me.BackColor
        txt_damages.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        lbl_damageText.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        lbl_numeroInspec.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        lbl_titleInspec.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
    End Sub

    Private Sub traducirControles()
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            ''traduce al ingles
            lbl_damageText.Text = My.Resources.EN_UK.DatosInspeccion_lbldamagetext
            lbl_titleInspec.Text = My.Resources.EN_UK.DatosInspeccion_lbltitleinspec
            btn_guardar.Text = My.Resources.EN_UK.DatosInspeccion_btnguardar
            btn_newDamage.Text = My.Resources.EN_UK.DatosInspeccion_btnnewdamage
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            ''traduce al español
            lbl_damageText.Text = My.Resources.ES_LA.DatosInspeccion_lbldamagetext
            lbl_titleInspec.Text = My.Resources.ES_LA.DatosInspeccion_lbltitleinspec
            btn_guardar.Text = My.Resources.ES_LA.DatosInspeccion_btnguardar
            btn_newDamage.Text = My.Resources.ES_LA.DatosInspeccion_btnnewdamage
        Else
            ''traduce al portugues
            lbl_damageText.Text = My.Resources.PT_BR.DatosInspeccion_lbldamagetext
            lbl_titleInspec.Text = My.Resources.PT_BR.DatosInspeccion_lbltitleinspec
            btn_guardar.Text = My.Resources.PT_BR.DatosInspeccion_btnguardar
            btn_newDamage.Text = My.Resources.PT_BR.DatosInspeccion_btnnewdamage
        End If
    End Sub
End Class