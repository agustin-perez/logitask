Imports LibreriaLogica
Imports LibreriaGrafica
Imports System.Drawing

Public Class InfoLote
    Private tupla As DataRow
    Private QR As Bitmap
    ''' <summary>
    ''' Constructor específico encargado de inicializar la instancia de la clase y tomar como parámetro una tupla conteniendo los datos del vehículo a mostrar los detalles.
    ''' </summary>
    ''' <param name="fila">Tupla conteniendo todos los datos del vehículo en cuestión.</param>
    Public Sub New(fila As DataRow)
        'AGREGAR DINÁMICA DE INSTANCIA CON MENU VARIABLE PARA MOSTRAR LOS DATOS EN EL FLOWPANEL.
        InitializeComponent()
        tupla = fila
        CargarID()
        CargarNombre()
        CargarNumeros()
        CargarResponsable()
		CargarDesc()
		traducirControles()
		OpcGraficas()
	End Sub

	Private Sub CargarID()
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            ''traduce al ingles
            lbl_nro.Text = (My.Resources.EN_UK.InfoLote_nrolote + tupla.Field(Of Integer)(0).ToString)
            Text = (My.Resources.EN_UK.InfoLote_info + tupla.Field(Of Integer)(0).ToString)
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            ''traduce al español
            lbl_nro.Text = (My.Resources.ES_LA.InfoLote_nrolote + tupla.Field(Of Integer)(0).ToString)
            Text = (My.Resources.ES_LA.InfoLote_info + tupla.Field(Of Integer)(0).ToString)
        Else
            ''traduce al portugues
            lbl_nro.Text = (My.Resources.PT_BR.InfoLote_nrolote + tupla.Field(Of Integer)(0).ToString)
			Text = (My.Resources.PT_BR.InfoLote_info + tupla.Field(Of Integer)(0).ToString)
		End If
		'lbl_nro.Text = ("Lote: #" + tupla.Field(Of Integer)(0).ToString)
		'Text = ("Información del lote: #" + tupla.Field(Of Integer)(0).ToString)
		CargarQR()
	End Sub

	Private Sub CargarQR()
        Dim generador As New FuncionesEspecificas
        QR = generador.GenerarVinQR(tupla.Field(Of Integer)(0).ToString)
        img_qr.Image = QR
    End Sub

    Private Sub CargarNombre()
        txt_nombre.Text = tupla.Item(2)
    End Sub

    Private Sub CargarNumeros()
        Dim vehiculosEnlote As Int32 = ConsultasDeLectura.GetSingleton.VehiculosPorLote(tupla.Field(Of Integer)(0).ToString)
		Dim vehiculosMax As Int32 = ConsultasDeLectura.GetSingleton.MaxVehiculosLote
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            ''traduce al ingles
            txt_cant.Text = (vehiculosEnlote.ToString + "/" + vehiculosMax.ToString + "" + My.Resources.EN_UK.Funcion_main_vehiculos) 'Considerar idiomas acá
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            ''traduce al español
            txt_cant.Text = (vehiculosEnlote.ToString + "/" + vehiculosMax.ToString + "" + My.Resources.ES_LA.Funcion_main_vehiculos) 'Considerar idiomas acá
        Else
            ''traduce al portugues
            txt_cant.Text = (vehiculosEnlote.ToString + "/" + vehiculosMax.ToString + "" + My.Resources.PT_BR.Funcion_main_vehiculos) 'Considerar idiomas acá
		End If
		'txt_cant.Text = (vehiculosEnlote.ToString + "/" + vehiculosMax.ToString + " vehículos") 'Considerar idiomas acá
		If vehiculosEnlote > 0 Then
            CargarVehiculos()
        End If
    End Sub

    Private Sub CargarResponsable()
        txt_responsable.Text = tupla.Field(Of String)(1)
    End Sub

    Private Sub CargarDesc()
        txt_desc.Text = tupla.Field(Of String)(3)
    End Sub

    Private Sub CargarVehiculos()
        Try
            vehiculosInspec.Controls.Clear()
            Dim tabla = ConsultasDeLectura.GetSingleton.VehiculosDeLote(tupla.Item(0))
            For var As Short = 0 To tabla.Rows.Count - 1
                Dim tile As New TileVehiculo(tabla.Rows.Item(var), TileVehiculo.TileActionOnClick.Detalles)
                tile.TopLevel = False
                tile.CambioImagen()
                vehiculosInspec.Controls.Add(tile)
                tile.Show()
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_atras_Click(sender As Object, e As EventArgs) Handles btn_atras.Click
        GC.Collect()
        Me.Dispose()
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        ImprimirImagen("QR (ID): " + tupla.Field(Of Integer)(0).ToString)
    End Sub

    Public Sub ImprimirImagen(nombre As String)
        Try
            qr_dataPrint.DocumentName = nombre
            qr_dataPrint.Print()
        Catch ex As Exception
			MsgBox("Error: " & My.Resources.ErrorCodes.ErrorImpresionQR)
		End Try
    End Sub

	Private Sub qr_dataPrint_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles qr_dataPrint.PrintPage
		e.PageSettings.Margins = New Printing.Margins(0, 0, 0, 0)
		QR.SetResolution(50, 50)
		e.Graphics.DrawImage(QR, 0, 0)
	End Sub

	Private Sub traducirControles()
		If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
			''traduce al ingles
			lbl_desc.Text = My.Resources.EN_UK.InfoLote_lbldesc
			lbl_inspecctitle.Text = My.Resources.EN_UK.InfoLote_lbl_inspecctitle
			lbl_name.Text = My.Resources.EN_UK.InfoLote_lblname
			lbl_username.Text = My.Resources.EN_UK.InfoLote_lblusername
			btn_print.Text = My.Resources.EN_UK.InfoLote_btnprint
		ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
			''traduce al español
			lbl_desc.Text = My.Resources.ES_LA.InfoLote_lbldesc
			lbl_inspecctitle.Text = My.Resources.ES_LA.InfoLote_lbl_inspecctitle
			lbl_name.Text = My.Resources.ES_LA.InfoLote_lblname
			lbl_username.Text = My.Resources.ES_LA.InfoLote_lblusername
			btn_print.Text = My.Resources.ES_LA.InfoLote_btnprint
		Else
			''traduce al portugues
			lbl_desc.Text = My.Resources.PT_BR.InfoLote_lbldesc
			lbl_inspecctitle.Text = My.Resources.PT_BR.InfoLote_lbl_inspecctitle
			lbl_name.Text = My.Resources.PT_BR.InfoLote_lblname
			lbl_username.Text = My.Resources.PT_BR.InfoLote_lblusername
			btn_print.Text = My.Resources.PT_BR.InfoLote_btnprint
		End If
	End Sub

	Private Sub OpcGraficas()
        Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.txt_cant.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.txt_desc.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.txt_nombre.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.txt_responsable.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.txt_cant.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.txt_desc.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.txt_nombre.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.txt_responsable.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        vehiculosInspec.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        btn_print.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
		btn_print.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
		atras.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
	End Sub
End Class