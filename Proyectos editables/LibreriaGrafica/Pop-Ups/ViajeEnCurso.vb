Imports System.Windows.Forms
Imports LibreriaLogica
Imports System.Threading
Imports System.Device.Location

Public Class ViajeEnCurso
    Private mapaActual As New Mapa()
#Region "Vars de reloj"
    Private segundo As UInt16
    Private minuto As UInt16
    Private hora As UInt16
    Private dia As UInt16

    Private segundoSistema As Int16
    Private minutoSistema As Int16
    Private horaSistema As Int16
#End Region
    Private medio As DataRow
    Private lote As DataRow
    Private user As String
    Private cantVehiculos As String
    Private gps As New GeoCoordinateWatcher
    Private latitudActual As Double
    Private longitudActual As Double
    Private tiempoEstimado As Date
    Private idembarque As Int32
    Private cantVehic As Int16
    Private lugardestino As DataRow

    Public Sub New(user As String, medio As DataRow, lote As DataRow, cantvehiculos As Int16, destino As DataRow)
        InitializeComponent()
#Region "Inicializaciones"
        OpcGraficas()
        Me.user = user
        Me.medio = medio
        Me.lote = lote
        Me.cantVehiculos = cantvehiculos
        timerRelojPrincipal.Start()
        segundoSistema = Date.Now.Second
        minutoSistema = Date.Now.Minute
        horaSistema = Date.Now.Hour
        clk_sistema.Start()
        updateMap.Start()
        updateDBLocation.Start()
        lugardestino = destino
        TraducirControles()
#End Region
        propiedadesVentanas.GetSingleton.CargarVentana(ventana, mapaActual)
        IniciarGPSupdate()
        btn_zoomOut.Enabled = True
        Me.Size = My.Computer.Screen.Bounds.Size
        InsertarInicio()
        cantVehic = cantvehiculos
    End Sub

    Private Sub InsertarInicio()
        Transportista.GetSingleton.DisparaEmbarque(lote.Field(Of Int32)(0), medio.Field(Of Int16)(0), DatosSesion.GetSingleton.UserLogged, (latitudActual.ToString & ", " & longitudActual.ToString))
        idembarque = Transportista.GetSingleton.GetIDEmbarqueActual
        Console.WriteLine(idembarque.ToString)
    End Sub

    Public Sub IniciarGPSupdate()
        Dim errorGps As Boolean
        Do
            Try
                AddHandler gps.PositionChanged, AddressOf GpsHandler
                gps.Start()
                errorGps = True
            Catch ex As Exception
                If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                    If MsgBox(My.Resources.EN_UK.ViajeEnCurso_errorGPS, MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                        errorGps = True
                        Me.Dispose()
                    End If
                ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                    If MsgBox(My.Resources.ES_LA.ViajeEnCurso_errorGPS, MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                        errorGps = True
                        Me.Dispose()
                    End If
                Else
                    If MsgBox(My.Resources.PT_BR.ViajeEnCurso_errorGPS, MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                        errorGps = True
                        Me.Dispose()
                    End If
                End If
            End Try
        Loop While Not errorGps
    End Sub

    Private Sub GpsHandler(ByVal sender As Object, ByVal e As GeoPositionChangedEventArgs(Of GeoCoordinate))
        latitudActual = e.Position.Location.Latitude
        longitudActual = e.Position.Location.Longitude
    End Sub

    Private Sub CheckZoomInBtn()
        btn_zoomIn.Enabled = mapaActual.IsZoomMax
    End Sub

    Private Sub CheckZoomOutBtn()
        btn_zoomOut.Enabled = mapaActual.IsZoomMinimum
    End Sub

    Private Sub Btn_centrar_Click(sender As Object, e As EventArgs) Handles btn_centrar.Click
        mapaActual.CentrarPorCoordenadas()
        CheckZoomInBtn()
        CheckZoomOutBtn()
    End Sub

    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click
        Transportista.GetSingleton.InsertarLlegadaEmbarque(lugardestino.Field(Of Integer)(0), idembarque)
        Me.Dispose()
    End Sub
    ''' <summary>
    ''' Función encargada de administrar el reloj que se mostrará al iniciar el viaje (error ± 0.001 ms).
    ''' </summary>
    ''' <param name="sender">Parámetro predeterminado de handler.</param>
    ''' <param name="e">Parámetro predeterminado de evento de handler.</param>
    Private Sub RelojReal_Timer(sender As Object, e As EventArgs) Handles clk_sistema.Tick
        segundoSistema += 1
        If (segundoSistema = 59) Then
            segundoSistema = 0
            If (minutoSistema = 59) Then
                minutoSistema = 0
                If (horaSistema = 23) Then
                    segundoSistema = 0
                    horaSistema = 0
                    minutoSistema = 0
                Else
                    horaSistema += 1
                End If
            Else
                minutoSistema += 1
            End If
        End If
        Dim segundoTemp As String = segundoSistema.ToString
        Dim minutoTemp As String = minutoSistema.ToString
        Dim horaTemp As String = horaSistema.ToString
        If segundoSistema < 10 Then
            segundoTemp = ("0" + segundoSistema.ToString)
        End If
        If minutoSistema < 10 Then
            minutoTemp = ("0" + minutoSistema.ToString)
        End If
        If horaSistema < 10 Then
            horaTemp = ("0" + horaSistema.ToString)
        End If
        lbl_horareal.Text = (horaTemp + ":" + minutoTemp + ":" + segundoTemp)
    End Sub

    ''' <summary>
    ''' Función encargada de administrar el reloj que se mostrará al iniciar el viaje (error ± 0.001 ms).
    ''' </summary>
    ''' <param name="sender">Parámetro predeterminado de handler.</param>
    ''' <param name="e">Parámetro predeterminado de evento de handler.</param>
    Private Sub TiempoTranscurrido(sender As Object, e As EventArgs) Handles timerRelojPrincipal.Tick
        segundo += 1
        If (segundo = 59) Then
            segundo = 0
            If (minuto = 59) Then
                minuto = 0
                If (hora = 23) Then
                    dia += 1
                    segundo = 0
                    hora = 0
                    minuto = 0
                Else
                    hora += 1
                End If
            Else
                minuto += 1
            End If
        End If
        Dim segundoTemp As String = segundo.ToString
        Dim minutoTemp As String = minuto.ToString
        Dim horaTemp As String = hora.ToString
        Dim diaTemp As String = dia.ToString
        If segundo < 10 Then
            segundoTemp = ("0" + segundo.ToString)
        End If
        If minuto < 10 Then
            minutoTemp = ("0" + minuto.ToString)
        End If
        If hora < 10 Then
            horaTemp = ("0" + hora.ToString)
        End If
        If dia < 10 Then
            diaTemp = ("0" + dia.ToString)
        End If
        lbl_tiempo.Text = (diaTemp + ":" + horaTemp + ":" + minutoTemp + ":" + segundoTemp)
    End Sub

    Private Sub Btn_zoomIn_Click(sender As Object, e As EventArgs) Handles btn_zoomIn.Click
        btn_zoomOut.Enabled = True
        mapaActual.Aumentar()
        CheckZoomInBtn()
    End Sub

    Private Sub Btn_zoomOut_Click(sender As Object, e As EventArgs) Handles btn_zoomOut.Click
        btn_zoomIn.Enabled = True
        mapaActual.Disminuir()
        CheckZoomOutBtn()
    End Sub

    Private Sub UpdateDBLocation_Tick(sender As Object, e As EventArgs) Handles updateDBLocation.Tick
        Transportista.GetSingleton.UpdateCoord((latitudActual.ToString & ": " & longitudActual.ToString), idembarque)
    End Sub

    Private Sub MapCenter_Tick(sender As Object, e As EventArgs) Handles MapCenter.Tick
        mapaActual.CentrarPorCoordenadas()
    End Sub

    Private Sub updateMap_Tick(sender As Object, e As EventArgs) Handles updateMap.Tick
        mapaActual.SetCoordenadas(latitudActual, longitudActual)
        mapaActual.SetGPSIcon()
    End Sub

    Private Sub TraducirControles()
        lbl_destino.Text = "→ " + lugardestino.Field(Of String)(1)
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            usuario.Text = My.Resources.EN_UK.ViajeEnCurso_Usuario + " " + user
            coche.Text = My.Resources.EN_UK.ViajeEnCurso_Coche + " " + medio.Field(Of Int16)(0).ToString
            lbl_vehiculos.Text = cantVehiculos.ToString + " " + My.Resources.EN_UK.ViajeEnCurso_Vehiculos
            lbl_Lote.Text = My.Resources.EN_UK.ViajeEnCurso_Lote + " " + lote.Field(Of Int32)(0).ToString
            lbl_vehiculos.Text = My.Resources.EN_UK.ViajeEnCurso_Vehiculos + " " + cantVehic.ToString + "/" + medio.Field(Of Int16)(2).ToString
            btn_finalizar.Text = My.Resources.EN_UK.ViajeEnCurso_FinalizarViaje
            btn_centrar.Text = My.Resources.EN_UK.ViajeEnCurso_btnCentrarMapa
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            usuario.Text = My.Resources.ES_LA.ViajeEnCurso_lblUsuario + " " + user
            coche.Text = My.Resources.ES_LA.ViajeEnCurso_lblCoche + " " + medio.Field(Of Int16)(0).ToString
            lbl_vehiculos.Text = cantVehiculos.ToString + " " + My.Resources.ES_LA.ViajeEnCurso_lblVehiculos
            lbl_vehiculos.Text = My.Resources.ES_LA.ViajeEnCurso_lblVehiculos + " " + cantVehic.ToString + "/" + medio.Field(Of Int16)(2).ToString
            lbl_Lote.Text = My.Resources.ES_LA.ViajeEnCurso_lblLote + " " + lote.Field(Of Int32)(0).ToString
            btn_finalizar.Text = My.Resources.ES_LA.ViajeEnCurso_FinalizarViaje
            btn_centrar.Text = My.Resources.ES_LA.ViajeEnCurso_btnCentrarMapa
        Else
            usuario.Text = My.Resources.PT_BR.ViajeEnCurso_Usuario + " " + user
            coche.Text = My.Resources.PT_BR.ViajeEnCurso_Coche + " " + medio.Field(Of Int16)(0).ToString
            lbl_vehiculos.Text = cantVehiculos.ToString + " " + My.Resources.PT_BR.ViajeEnCurso_Vehiculos
            lbl_Lote.Text = My.Resources.EN_UK.ViajeEnCurso_Lote + " " + lote.Field(Of Int32)(0).ToString
            lbl_vehiculos.Text = My.Resources.PT_BR.ViajeEnCurso_Vehiculos + " " + cantVehic.ToString + "/" + medio.Field(Of Int16)(2).ToString
            btn_finalizar.Text = My.Resources.PT_BR.ViajeEnCurso_FinalizarViaje
            btn_centrar.Text = My.Resources.PT_BR.ViajeEnCurso_btnCentrarMapa
        End If
    End Sub

    Private Sub OpcGraficas()
        Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.panel_data.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.ventana.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.usuario.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.coche.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.lbl_Lote.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.lbl_vehiculos.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.lbl_tiempo.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.lbl_tiempo.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.btn_centrar.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
        Me.btn_centrar.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
        Me.btn_zoomIn.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
        Me.btn_zoomIn.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
        Me.btn_zoomOut.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
        Me.btn_zoomOut.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
        Me.btn_finalizar.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
        Me.btn_finalizar.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
        Me.lbl_horareal.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.lbl_horareal.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
    End Sub
End Class