Imports LibreriaLogica
Imports System.Windows.Forms
Imports System.Drawing
''' <summary>
''' Clase encargada de mostrar la información detallada de un vehículo especificado desde una tupla por parámetros.
''' </summary>
Public Class DatosVehiculo
    Private tiposVehiculo As New List(Of String)
    Private inicialesTipo As New List(Of Char)
    Private tupla As DataRow
    Private QR As Bitmap
    Private longitud As Double
    Private latitud As Double
    Private mapa As New Mapa
    ''' <summary>
    ''' Constructor específico encargado de inicializar la instancia de la clase y tomar como parámetro una tupla conteniendo los datos del vehículo a mostrar los detalles.
    ''' </summary>
    ''' <param name="fila">Tupla conteniendo todos los datos del vehículo en cuestión.</param>
    Public Sub New(fila As DataRow)
        InitializeComponent()
        ListaInspec.SuspendLayout()
        tupla = fila
        CargarVIN()
        CargarMarca()
        CargarModelo()
        CargarYear()
        CargarColor()
        CargarTipoYColor()
        CargarInspecciones()
        TraducirControles()
        OpcGraficas()
        CargarLugar()
        If LoginVariable.GetSingleton.GetTipo <> LoginVariable.TipoAppEnum.Admin Then
            btn_delete.Hide()
            btn_edit.Hide()
            btn_save.Hide()
        End If
    End Sub

    Private Enum DatoSize As Int16
        ancho = 590
        alturaExpandida = 650
        alturaContraida = 250
    End Enum
    ''' <summary>
    ''' Subrutina encargada de extraer el campo de VIN (Vehicle Identification Number) de la tupla en cuestión.
    ''' </summary>
    Private Sub CargarVIN()
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            ''traduce al ingles
            Me.Text = (My.Resources.EN_UK.DatosVehiculo_info + tupla.Field(Of String)(0))
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            ''traduce al español
            Me.Text = (My.Resources.ES_LA.DatosVehiculo_info + tupla.Field(Of String)(0))
        Else
            ''traduce al portugues
            Me.Text = (My.Resources.PT_BR.DatosVehiculo_info + tupla.Field(Of String)(0))
        End If
        VIN.Text = tupla.Field(Of String)(0)
        DatosSesion.GetSingleton.VinTemp = VIN.Text
        CargarQR()
    End Sub
    Private Sub CargarQR()
        Dim generador As New FuncionesEspecificas
        QR = generador.GenerarVinQR(tupla.Field(Of String)(0))
        img_qr.Image = QR
    End Sub
    ''' <summary>
    ''' Subrutina encargada de extraer el campo de Marca de la tupla en cuestión.
    ''' </summary>
    Private Sub CargarMarca()
        txt_marca.Text = tupla.Field(Of String)(1)
    End Sub
    ''' <summary>
    ''' Subrutina encargada de extraer el campo de Modelo de la tupla en cuestión.
    ''' </summary>
    Private Sub CargarModelo()
        txt_modelo.Text = tupla.Field(Of String)(2)
    End Sub
    ''' <summary>
    ''' Subrutina encargada de extraer el campo de Año de la tupla en cuestión.
    ''' </summary>
    Private Sub CargarYear()
        Try
            txt_year.Text = tupla.Field(Of Date)(3).Year
        Catch ex As Exception
            txt_year.Text = tupla.Field(Of Short)(3)
        End Try
    End Sub
    ''' <summary>
    ''' Subrutina encargada de extraer el campo de Color de la tupla en cuestión.
    ''' </summary>
    Private Sub CargarColor()
        Dim texto As String = tupla.Field(Of String)(4)
        Dim capital As String = texto.Substring(0, 1).ToUpper
        Dim lowercase As String = texto.Substring(1).ToLower
        txt_color.Text = capital + lowercase
    End Sub

    Private Sub CargarLugar()
        If ConsultasDeLectura.GetSingleton.EsperandoEnPuerto(tupla.Field(Of String)(0)) Then
            img_transicion.Image = My.Resources.Images.esperaEnPuerto
            img_transicion.Show()
            listaLugar.Hide()
        ElseIf ConsultasDeLectura.GetSingleton.ListoPartir(tupla.Field(Of String)(0)) Then
            img_transicion.Image = My.Resources.Images.listoParaPartir
            img_transicion.Show()
            listaLugar.Hide()
        ElseIf ConsultasDeLectura.GetSingleton.EsperaPatio(tupla.Field(Of String)(0)) Then
            img_transicion.Image = My.Resources.Images.esperandoEnPatio
            img_transicion.Show()
            listaLugar.Hide()
        ElseIf ConsultasDeLectura.GetSingleton.EnSubZona(tupla.Field(Of String)(0)) Then
            img_transicion.Image = My.Resources.Images.vehiculoEnZona
            img_transicion.Show()
            listaLugar.Hide()
        End If
        If ConsultasDeLectura.GetSingleton.TransporteVehiculos(tupla.Field(Of String)(0)) > 0 Then
            listaLugar.Show()
            img_transicion.Hide()
            propiedadesVentanas.GetSingleton.CargarVentana(listaLugar, mapa)
            UpdateMap.Start()
        End If
    End Sub

    Private Sub GetCoordenadas()
        Try
            Dim consulta As String = ConsultasDeLectura.GetSingleton.GetCoordenadas(tupla.Field(Of String)(0))
            Dim separador() As String = consulta.Split(":")
            latitud = CType(separador(0), Double)
            longitud = CType(separador(1), Double)
        Catch ex As Exception
            MsgBox(My.Resources.ErrorCodes.ErrorEspecial, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub UpdateMap_Tick(sender As Object, e As EventArgs) Handles UpdateMap.Tick
        GetCoordenadas()
        mapa.SetCoordenadas(latitud, longitud)
        mapa.CentrarPorCoordenadas()
    End Sub

    Private Sub CargarTipoYColor()
        Dim tipo As String
        Try
            tipo = tupla.Field(Of String)(5)
        Catch ex As Exception
            tipo = tupla.Field(Of Char)(5)
        End Try
        Dim color As String = tupla.Field(Of String)(4)
        propiedadesVentanas.GetSingleton.CambiarImagenTipo(icono, tipo, color, True, txt_tipoVehiculo)
    End Sub

    Private Sub CargarInspecciones()
        Dim tabla As New WeakReference(New DataTable)
        Try
            tabla.Target = ConsultasDeLectura.GetSingleton.ListadoInspecciones(VIN.Text)
            If tabla.Target.Rows.Count > 0 Then
                ListaInspec.Controls.Clear()
                For var As Integer = 0 To tabla.Target.Rows.Count - 1
                    Dim tile As New WeakReference(New TileInspeccion(tabla.Target.Rows.Item(var), TileInspeccion.TileActionOnClick.detalles))
                    tile.Target.TopLevel = False
                    ListaInspec.Controls.Add(tile.Target)
                    tile.Target.Show()
                Next
            End If
            If ListaInspec.Controls.Count = 0 Then
                Dim lbl_vacio As New Label
                If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                    ''traduce al ingles
                    lbl_vacio.Text = My.Resources.EN_UK.DatosVehiculo_lblvacio
                ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                    ''traduce al español
                    lbl_vacio.Text = My.Resources.EN_UK.DatosVehiculo_lblvacio
                Else
                    ''traduce al portugues
                    lbl_vacio.Text = My.Resources.PT_BR.DatosVehiculo_lblvacio
                End If
                lbl_vacio.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
                lbl_vacio.Font = propiedadesVentanas.GetSingleton.FuenteEstandarBotones
                lbl_vacio.AutoEllipsis = True
                lbl_vacio.Width = ListaInspec.Width - 10
                lbl_vacio.Height = 50
                ListaInspec.Controls.Add(lbl_vacio)
                lbl_vacio.Show()
            End If
            ListaInspec.ResumeLayout()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click, Me.FormClosing
        ListaInspec.Dispose()
        Me.Finalize()
        Me.Dispose(True)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        ImprimirImagen("QR (VIN): " + tupla.Field(Of String)(0))
    End Sub

    Public Sub ImprimirImagen(nombre As String)
        Try
            qr_dataPrint.DocumentName = nombre
            qr_dataPrint.Print()
        Catch ex As Exception
            MsgBox(My.Resources.ErrorCodes.ErrorImpresionQR)
        End Try
    End Sub

    Private Sub qr_dataPrint_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles qr_dataPrint.PrintPage
        e.PageSettings.Margins = New Printing.Margins(0, 0, 0, 0)
        QR.SetResolution(50, 50)
        e.Graphics.DrawImage(QR, 0, 0)
    End Sub

    Private Sub LimpiarInspec()
        For var As Int32 = 0 To ListaInspec.Controls.Count - 1
            ListaInspec.Controls.Item(0).Dispose()
        Next
    End Sub

    Private Sub ReloadAction()
        ListaInspec.SuspendLayout()
        LimpiarInspec()
        If ListaInspec.Controls.Count = 0 Then
            CargarInspecciones()
        End If
        OpcGraficas()
    End Sub
    Private Sub btn_reload_Click(sender As Object, e As EventArgs) Handles btn_reload.Click
        ReloadAction()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim errormsg As Boolean
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            If MsgBox(My.Resources.EN_UK.DatosVehiculo_Delete, MsgBoxStyle.OkCancel, My.Resources.EN_UK.Alerta) = MsgBoxResult.Ok Then
                If Admin.GetSingleton.EliminarVehiculo(tupla.Field(Of String)(0)) Then
                    Me.Dispose()
                Else
                    errormsg = True
                End If
            End If
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            If MsgBox(My.Resources.ES_LA.DatosVehiculo_Delete, MsgBoxStyle.OkCancel, My.Resources.ES_LA.Alerta) = MsgBoxResult.Ok Then
                If Admin.GetSingleton.EliminarVehiculo(tupla.Field(Of String)(0)) Then
                    Me.Dispose()
                Else
                    errormsg = True
                End If
            End If
        Else
            If MsgBox(My.Resources.PT_BR.DatosVehiculo_Delete, MsgBoxStyle.OkCancel, My.Resources.PT_BR.Alerta) = MsgBoxResult.Ok Then
                If Admin.GetSingleton.EliminarVehiculo(tupla.Field(Of String)(0)) Then
                    Me.Dispose()
                Else
                    errormsg = True
                End If
            End If
        End If
        If errormsg Then
            MsgBox(My.Resources.ErrorCodes.ErrorDelete, MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub Btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        btn_edit.Hide()
        btn_save.Show()
        txt_tipoVehiculo.Hide()
        msk_color.Show()
        msk_color.Text = txt_color.Text
        msk_marca.Show()
        msk_marca.Text = txt_marca.Text
        msk_modelo.Show()
        msk_modelo.Text = txt_modelo.Text
        msk_release.Show()
        msk_release.Text = CType(txt_year.Text, Int16)
        btn_delete.Hide()
        btn_cancel.Show()
        cmb_tipo.Show()
        cmb_tipo.SelectedItem = cmb_tipo.Items(3)
    End Sub

    Private Sub SetearAlInicio(sender As MaskedTextBox, e As EventArgs) Handles msk_color.Click, msk_marca.Click, msk_modelo.Click, msk_release.Click
        sender.Select(0, 0)
    End Sub

    Private Sub BorrarAlClickear(sender As MaskedTextBox, e As EventArgs) Handles msk_color.Click, msk_marca.Click, msk_modelo.Click, msk_release.Click
        sender.Clear()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        btn_edit.Show()
        btn_save.Hide()
        txt_tipoVehiculo.Hide()
        msk_color.Hide()
        msk_marca.Hide()
        msk_modelo.Hide()
        msk_release.Hide()
        btn_delete.Show()
        btn_cancel.Hide()
        cmb_tipo.Hide()
    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If msk_color.Text <> "" And msk_marca.Text <> "" And msk_modelo.Text <> "" And msk_release.Text <> "" Then
                If Admin.GetSingleton.UpdatearVehiculo(VIN.Text, msk_marca.Text, msk_modelo.Text, Date.ParseExact(msk_release.Text, "yyyy", Globalization.DateTimeFormatInfo.InvariantInfo), msk_color.Text.ToLower, inicialesTipo(cmb_tipo.SelectedIndex)) Then
                    txt_color.Text = msk_color.Text
                    txt_marca.Text = msk_marca.Text
                    txt_modelo.Text = msk_modelo.Text
                    txt_year.Text = msk_release.Text
                    propiedadesVentanas.GetSingleton.CambiarImagenTipo(icono, inicialesTipo(cmb_tipo.SelectedIndex), msk_color.Text.ToLower, True, txt_tipoVehiculo)
                Else
                    MsgBox(My.Resources.ErrorCodes.ErrorEspecial, MsgBoxStyle.Critical, "Error")
                End If
            End If
        Catch ex As Exception
        End Try
        btn_edit.Show()
        btn_save.Hide()
        txt_tipoVehiculo.Hide()
        msk_color.Hide()
        msk_marca.Hide()
        msk_modelo.Hide()
        msk_release.Hide()
        btn_delete.Show()
        btn_cancel.Hide()
        cmb_tipo.Hide()
    End Sub

#Region "Propiedades ventana"
    Private Sub TraducirControles()
        inicialesTipo.Add("S")
        tiposVehiculo.Add("SUV")
        inicialesTipo.Add("V")
        tiposVehiculo.Add("VAN")
        inicialesTipo.Add("M")
        tiposVehiculo.Add("Minivan")
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            ''traduce al ingles
            inicialesTipo.Add("A")
            tiposVehiculo.Add("Standard car")
            inicialesTipo.Add("C")
            tiposVehiculo.Add("Truck")
            lblmarca.Text = My.Resources.EN_UK.DatosVehiculo_lblmarca
            lblcolor.Text = My.Resources.EN_UK.DatosVehiculo_lblcolor
            lblmodelo.Text = My.Resources.EN_UK.DatosVehiculo_lblmodelo
            lblyear.Text = My.Resources.EN_UK.DatosVehiculo_lblyear
            lbl_inspecctitle.Text = My.Resources.EN_UK.DatosVehiculo_lblinspecctitle
            lbl_location.Text = My.Resources.EN_UK.DatosVehiculo_lbllocation
            btn_print.Text = My.Resources.EN_UK.DatosVehiculo_btnprint
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            ''traduce al español
            inicialesTipo.Add("A")
            tiposVehiculo.Add("Auto estándar")
            inicialesTipo.Add("C")
            tiposVehiculo.Add("Camión")
            lblmarca.Text = My.Resources.ES_LA.DatosVehiculo_lblmarca
            lblcolor.Text = My.Resources.ES_LA.DatosVehiculo_lblcolor
            lblmodelo.Text = My.Resources.ES_LA.DatosVehiculo_lblmodelo
            lblyear.Text = My.Resources.ES_LA.DatosVehiculo_lblyear
            lbl_inspecctitle.Text = My.Resources.ES_LA.DatosVehiculo_lblinspecctitle
            lbl_location.Text = My.Resources.ES_LA.DatosVehiculo_lbllocation
            btn_print.Text = My.Resources.ES_LA.DatosVehiculo_btnprint
        Else
            ''traduce al portugues
            inicialesTipo.Add("A")
            tiposVehiculo.Add("Veículo padrão")
            inicialesTipo.Add("C")
            tiposVehiculo.Add("Caminhão")
            lblmarca.Text = My.Resources.PT_BR.DatosVehiculo_lblmarca
            lblcolor.Text = My.Resources.PT_BR.DatosVehiculo_lblcolor
            lblmodelo.Text = My.Resources.PT_BR.DatosVehiculo_lblmodelo
            lblyear.Text = My.Resources.PT_BR.DatosVehiculo_lblyear
            lbl_inspecctitle.Text = My.Resources.PT_BR.DatosVehiculo_lblinspecctitle
            lbl_location.Text = My.Resources.PT_BR.DatosVehiculo_lbllocation
            btn_print.Text = My.Resources.PT_BR.DatosVehiculo_btnprint
        End If
        cmb_tipo.Items.Add(tiposVehiculo.Item(0))
        cmb_tipo.Items.Add(tiposVehiculo.Item(1))
        cmb_tipo.Items.Add(tiposVehiculo.Item(2))
        cmb_tipo.Items.Add(tiposVehiculo.Item(3))
        cmb_tipo.Items.Add(tiposVehiculo.Item(4))
    End Sub

    Private Sub OpcGraficas()
        Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.VIN.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.msk_release.BackColor = propiedadesVentanas.GetSingleton.ColorBackTextbox
        Me.msk_color.BackColor = propiedadesVentanas.GetSingleton.ColorBackTextbox
        Me.msk_marca.BackColor = propiedadesVentanas.GetSingleton.ColorBackTextbox
        Me.msk_modelo.BackColor = propiedadesVentanas.GetSingleton.ColorBackTextbox
        Me.msk_color.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.msk_marca.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.msk_modelo.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.msk_release.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.cmb_tipo.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.cmb_tipo.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.txt_color.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.txt_marca.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.txt_modelo.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.txt_tipoVehiculo.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.txt_year.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.lblcolor.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.lblmarca.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.lblmodelo.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.lblyear.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.lbl_inspecctitle.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.lbl_location.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.VIN.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.txt_color.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.txt_marca.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.txt_modelo.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.txt_tipoVehiculo.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.txt_year.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        listaLugar.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        ListaInspec.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        btn_print.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
        btn_print.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
        atras.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
    End Sub
#End Region
End Class