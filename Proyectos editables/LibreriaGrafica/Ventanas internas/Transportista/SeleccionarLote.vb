Imports LibreriaLogica
Public Class SeleccionarLote
    Private tuplaMedio As DataRow
    Private cantidadExcedida As Boolean
    Private cantCochesMax As Int16
    Private contCoches As Int16
    Private tablaLugares As New DataTable
    Public Sub New(medio As DataRow) 'PASAR LA TUPLA ENTERA PARA CALCULAR LA CANTIDAD DE VEHICULOS MAXIMOS
        InitializeComponent()
        tuplaMedio = medio
        PararDibujado()
        DatosSesion.GetSingleton.TileCheck = False
        CargarLotesListos()
        TraducirControles()
        cantCochesMax = medio.Field(Of Int16)(2) 'MEDIDA PROVISORIA CAMBIAR POR LA TUPLA QUE HAY QUE PASAR
        errorLabel.Text = "0/" + cantCochesMax.ToString
        OpcGraficas()
        CargarDestino()
    End Sub

    Private Sub CargarDestino()
        tablaLugares = Transportista.GetSingleton.ListadoZonasPrincipales()
        For Each var As DataRow In tablaLugares.Rows
            cmb_destino.Items.Add(var.Field(Of String)(1))
        Next
    End Sub

    Private Sub PararDibujado()
        ventanaLotes.SuspendLayout()
    End Sub

    Private Sub ContinuarDibujado()
        ventanaLotes.ResumeLayout()
    End Sub

    Public Sub CargarLotesListos()
        Try
            Dim tabla As DataTable = ConsultasDeLectura.GetSingleton.ListadoLotes
            For var As Short = 0 To tabla.Rows.Count - 1
                Dim tile As New TileLote(tabla.Rows.Item(var), TileLote.TileActionOnClick.IniciarViaje)
                tile.TopLevel = False
                If tile.CantVehiculosNum <= cantCochesMax Then
                    ventanaLotes.Controls.Add(tile)
                    tile.Show()
                    tile.Check = False
                End If
            Next
            ContinuarDibujado()
            For Each var As TileLote In ventanaLotes.Controls
                var.CargarVehiculosEnLote()
                AddHandler var.Click, AddressOf AccionTile
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AccionTile(sender As TileLote, e As EventArgs)
        ventanaLotes.SuspendLayout()
        For Each var As TileLote In ventanaLotes.Controls
            If var.Check And var IsNot sender Then
                var.Uncheck()
            End If
        Next
        ventanaLotes.ResumeLayout()
        contCoches = 0
        errorLabel.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        sender.Check = True
        sender.BackColor = Drawing.Color.DimGray()
        cantidadExcedida = False
        contCoches = sender.CantVehiculosNum
        errorLabel.Text = contCoches.ToString + "/" + cantCochesMax.ToString
        If contCoches > cantCochesMax Then
            errorLabel.ForeColor = Drawing.Color.Red
            cantidadExcedida = True
        End If
    End Sub

    Private Sub LimpiarLotes()
        For var As Int32 = 0 To ventanaLotes.Controls.Count - 1
            ventanaLotes.Controls.Item(0).Dispose()
        Next
        ventanaLotes.Controls.Clear()
    End Sub

    Private Sub btn_reload_Click(sender As Object, e As EventArgs) Handles btn_reload.Click
        ventanaLotes.SuspendLayout()
        errorLabel.Text = "0" + "/" + cantCochesMax.ToString
        errorLabel.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
        LimpiarLotes()
        CargarLotesListos()
    End Sub

    Private Sub Btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        Dim errormsg As Boolean
        Dim tuplaLugar As DataRow = Transportista.GetSingleton.GetLugarPorNombre(cmb_destino.Text).Rows.Item(0)
        MsgBox(cmb_destino.Text)
        For Each var As TileLote In ventanaLotes.Controls
            If var.Check And Not cantidadExcedida And cmb_destino.SelectedItem IsNot Nothing Then
                Try
                    Dim viaje As New ViajeEnCurso(DatosSesion.GetSingleton.UserLogged, tuplaMedio, var.GetTupla, contCoches, tuplaLugar)
                    viaje.Show()
                    viaje.BringToFront()
                    propiedadesVentanas.GetSingleton.VentanaVolver = Nothing
                    DatosSesion.GetSingleton.TileCheck = False
                    Me.Dispose()
                    errormsg = False
                Catch ex As Exception
                End Try
            Else
                errormsg = True
            End If
        Next
        If errormsg Then
            If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                MsgBox(My.Resources.EN_UK.SeleccionarLote_errorcapacidad, MsgBoxStyle.Critical, "Error")
            ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                MsgBox(My.Resources.ES_LA.SeleccionarLote_errorcapacidad, MsgBoxStyle.Critical, "Error")
            Else
                MsgBox(My.Resources.PT_BR.SeleccionarLote_errorcapacidad, MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub

    Private Sub OpcGraficas()
		errorLabel.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        ventanaLotes.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
		btn_next.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
        btn_next.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
        lbl_destino.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
    End Sub

    ''' <summary>
    ''' Subrutina encargada de traducir los controles principales de esta instancia.
    ''' </summary>
    Private Sub TraducirControles()
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            lbl_title.Text = My.Resources.EN_UK.IniciarViaje_lbltitle
            btn_next.Text = My.Resources.EN_UK.IniciarViaje_btnNext
            i_viaje.ToolTipTitle = (My.Resources.EN_UK.IniciarViaje_informacion)
            i_viaje.SetToolTip(lbl_title, My.Resources.EN_UK.IniciarViaje_subtitulo)
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            lbl_title.Text = My.Resources.ES_LA.IniciarViaje_lbltitle
            btn_next.Text = My.Resources.ES_LA.IniciarViaje_btnNext
            i_viaje.ToolTipTitle = (My.Resources.ES_LA.IniciarViaje_informacion)
            i_viaje.SetToolTip(lbl_title, My.Resources.ES_LA.IniciarViaje_subtitulo)
        Else
            lbl_title.Text = My.Resources.PT_BR.IniciarViaje_lbltitle
            btn_next.Text = My.Resources.PT_BR.IniciarViaje_btnNext
            i_viaje.ToolTipTitle = (My.Resources.PT_BR.IniciarViaje_informacion)
            i_viaje.SetToolTip(lbl_title, My.Resources.PT_BR.IniciarViaje_subtitulo)
        End If
    End Sub
End Class