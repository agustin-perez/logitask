Imports LibreriaLogica
Imports LibreriaGrafica
Imports System.Windows.Forms

Public Class NuevoLote
    Private arrayVehiculos As New List(Of TileVehiculo)
    Private IsCancelar As Boolean
    Private tituloPrincipal As String
    Private textoBotones As String

    Private Sub NuevoLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CargarVehiculos()
		If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
			lbl_nroLote.Text = (My.Resources.EN_UK.InfoLote_nrolote + Operarios.GetSingleton.GetIdLote.ToString)
		ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
			lbl_nroLote.Text = (My.Resources.ES_LA.InfoLote_nrolote + Operarios.GetSingleton.GetIdLote.ToString)
		Else
			''Portugues
			lbl_nroLote.Text = (My.Resources.PT_BR.InfoLote_nrolote + Operarios.GetSingleton.GetIdLote.ToString)
		End If
        txt_nombre.Text = Nothing
        txt_descripcion.Text = Nothing
		traducirControles()
		OpcGraficas()
	End Sub

    Private Sub CargarVehiculos()
        ventanaNoConfirmados.Controls.Clear()
        ventanaConfirmados.Controls.Clear()
        arrayVehiculos.Clear()
        Dim tabla = ConsultasDeLectura.GetSingleton.ListadoVehiculos
        Try
            For var As Short = 0 To tabla.Rows.Count - 1
                If Operarios.GetSingleton.ChequeoLote(tabla.Rows.Item(var).Item(0)) Then
                    Dim tile As New TileVehiculo(tabla.Rows.Item(var), TileVehiculo.TileActionOnClick.ConfirmarLote)
                    tile.TopLevel = False
                    tile.CambioImagen()
                    ventanaNoConfirmados.Controls.Add(tile)
                    tile.Show()
                    arrayVehiculos.Add(New TileVehiculo(tabla.Rows.Item(var), TileVehiculo.TileActionOnClick.Detalles))
                End If
            Next
            If ventanaNoConfirmados.Controls.Count = 0 Then
                Dim labelEmpty As New Label
                labelEmpty.Font = propiedadesVentanas.GetSingleton.FuenteSubTitulo
                labelEmpty.BackColor = Drawing.Color.Transparent
                labelEmpty.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
                ''labelEmpty.Text = "No hay vehículos para añadir a lotes, estos no están inspeccionados o ya se encuentran en un lote."
                If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                    labelEmpty.Text = My.Resources.EN_UK.NuevoLote_EmptyVehicle
                ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                    labelEmpty.Text = My.Resources.ES_LA.NuevoLote_EmptyVehicle
                Else
                    ''Portugues
                    labelEmpty.Text = My.Resources.PT_BR.NuevoLote_EmptyVehicle
				End If
				labelEmpty.Width = ventanaConfirmados.Width
                labelEmpty.Height = 200
                ventanaNoConfirmados.Controls.Add(labelEmpty)
                labelEmpty.Show()
                lbl_nroLote.Text = " "
            End If
        Catch ex As Exception 'AÑADIR ESTO A LISTADOVEHICULOS
			MsgBox("Error: " & My.Resources.ErrorCodes.ErrorConexion)
		End Try
    End Sub

    Private Sub ConfirmarVehiculo() Handles ventanaNoConfirmados.ControlRemoved
        If Not IsCancelar Then
            Dim existeVehiculo As Boolean
            For Each var In arrayVehiculos
                For Each subVar In ventanaNoConfirmados.Controls.OfType(Of TileVehiculo)
                    If subVar.GetVin = var.GetVin Then
                        existeVehiculo = True
                    End If
                Next
                If Not existeVehiculo Then
                    var.TopLevel = False
                    var.CambioImagen()
                    ventanaConfirmados.Controls.Add(var)
                    var.Show()
                    btn_deshacer.Enabled = True
                End If
                existeVehiculo = False
            Next
        End If
    End Sub

    Private Sub Deshacer()
        Dim controlRemovido As TileVehiculo
        Try
            controlRemovido = ventanaConfirmados.Controls.Item(ventanaConfirmados.Controls.OfType(Of TileVehiculo).Count - 1)
            Dim copiaControl As New TileVehiculo(controlRemovido.GetTupla, TileVehiculo.TileActionOnClick.ConfirmarLote)
            ventanaConfirmados.Controls.Remove(controlRemovido)
            copiaControl.TopLevel = False
            ventanaNoConfirmados.Controls.Add(copiaControl) 'Se copia el control para evitar que se haga dispose al control instanciado
            copiaControl.Show()
        Catch ex As Exception
            btn_deshacer.Enabled = False
        End Try
        If ventanaConfirmados.Controls.Count = 0 Then
            btn_deshacer.Enabled = False
        End If
    End Sub

    Private Sub CtrlButton(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.Control And ventanaConfirmados.Name = Me.ActiveControl.Name Then
            Deshacer()
        End If
    End Sub

    Private Sub Btn_deshacer_Click(sender As Object, e As EventArgs) Handles btn_deshacer.Click
        Deshacer()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If (lbl_nombre.Text IsNot Nothing) And (lbl_desc.Text IsNot Nothing) And (ventanaConfirmados.Controls.Count > 0) Then
            Try
                Operarios.GetSingleton.GuardarLote(DatosSesion.GetSingleton.UserLogged, txt_nombre.Text, txt_descripcion.Text, msk_testimado.Text)
                Dim idLote As Int32 = Operarios.GetSingleton.GetIdLote()
                For Each var As TileVehiculo In ventanaConfirmados.Controls.OfType(Of TileVehiculo)
                    Operarios.GetSingleton.GuardarVehiculoLote(var.GetTupla.Item(0), idLote)
                Next
                ''MsgBox("Se guardó todo")
                If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                    MsgBox(My.Resources.EN_UK.Guardado)
                ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                    MsgBox(My.Resources.ES_LA.Guardado)
                Else
                    ''Portugues
                    MsgBox(My.Resources.PT_BR.Guardado)
				End If
				Me.Dispose()
            Catch ex As System.Data.Odbc.OdbcException
				MsgBox(My.Resources.ErrorCodes.ErrorEspecial)
			End Try
        Else
            ''MsgBox("CAMPOS VACIOS") 'PASAR A ASTERISCOS ROJOS DE CAMPOS OBLIGATORIOS
            If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                MsgBox(My.Resources.EN_UK.CamposVacios & "Error: " & My.Resources.ErrorCodes.ErrorCamposVacios)
            ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
				MsgBox(My.Resources.ES_LA.CamposVacios & "Error: " & My.Resources.ErrorCodes.ErrorCamposVacios)
			Else
				''Portugues
				MsgBox(My.Resources.PT_BR.CamposVacios & "Error: " & My.Resources.ErrorCodes.ErrorCamposVacios)
			End If
		End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        GC.Collect()
        Me.Dispose()
    End Sub

    Public Property TituloPrincip() As String
        Get
            Return tituloPrincipal
        End Get
        Set(value As String)
            tituloPrincipal = value
        End Set
    End Property

	Public Property TituloBotones() As String
		Get
			Return textoBotones
		End Get
		Set(value As String)
			textoBotones = value
		End Set
	End Property

	Private Sub traducirControles()
		If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
			''traduce al ingles
			lbl_nombre.Text = My.Resources.EN_UK.NuevoLote_lblnombre
			lbl_desc.Text = My.Resources.EN_UK.NuevoLote_lbldesc
			lbl_confirmados.Text = My.Resources.EN_UK.NuevoLote_lblconfirmados
			lbl_addtitle.Text = My.Resources.EN_UK.NuevoLote_lbladdtitle
			lbl_nroLote.Text = My.Resources.EN_UK.NuevoLote_lblnrolote
			btn_cancelar.Text = My.Resources.EN_UK.NuevoLote_btncancelar
			btn_deshacer.Text = My.Resources.EN_UK.NuevoLote_btndeshacer
			btn_save.Text = My.Resources.EN_UK.NuevoLote_btnsave
		ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
			''traduce al español
			lbl_nombre.Text = My.Resources.ES_LA.NuevoLote_lblnombre
			lbl_desc.Text = My.Resources.ES_LA.NuevoLote_lbldesc
			lbl_confirmados.Text = My.Resources.ES_LA.NuevoLote_lblconfirmados
			lbl_addtitle.Text = My.Resources.ES_LA.NuevoLote_lbladdtitle
			lbl_nroLote.Text = My.Resources.ES_LA.NuevoLote_lblnrolote
			btn_cancelar.Text = My.Resources.ES_LA.NuevoLote_btncancelar
			btn_deshacer.Text = My.Resources.ES_LA.NuevoLote_btndeshacer
			btn_save.Text = My.Resources.ES_LA.NuevoLote_btnsave
		Else
			''traduce al portugues
			lbl_nombre.Text = My.Resources.PT_BR.NuevoLote_lblnombre
			lbl_desc.Text = My.Resources.PT_BR.NuevoLote_lbldesc
			lbl_confirmados.Text = My.Resources.PT_BR.NuevoLote_lblconfirmados
			lbl_addtitle.Text = My.Resources.PT_BR.NuevoLote_lbladdtitle
			lbl_nroLote.Text = My.Resources.PT_BR.NuevoLote_lblnrolote
			btn_cancelar.Text = My.Resources.PT_BR.NuevoLote_btncancelar
			btn_deshacer.Text = My.Resources.PT_BR.NuevoLote_btndeshacer
			btn_save.Text = My.Resources.PT_BR.NuevoLote_btnsave
		End If
	End Sub

    Private Sub OpcGraficas()
        Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        lbl_addtitle.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        lbl_confirmados.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        lbl_desc.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        lbl_nombre.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        lbl_nroLote.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        ventanaConfirmados.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        ventanaNoConfirmados.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        btn_cancelar.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
        btn_cancelar.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
        btn_deshacer.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
        btn_deshacer.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
        btn_save.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
        btn_save.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
    End Sub
End Class