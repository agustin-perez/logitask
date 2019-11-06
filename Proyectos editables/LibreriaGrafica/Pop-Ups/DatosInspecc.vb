Imports System.Windows.Forms
Imports LibreriaLogica
''' <summary>
''' Clase encargada de mostrar la información detallada de un vehículo especificado desde una tupla por parámetros.
''' </summary>
Public Class DatosInspecc
    Private tupla As DataRow
    Private nroInspeccion As Integer
    Private vin As String
    Private borrarLista As Boolean
    ''' <summary>
    ''' Constructor específico encargado de inicializar la instancia de la clase y tomar como parámetro una tupla conteniendo los datos del vehículo a mostrar los detalles.
    ''' </summary>
    ''' <param name="fila">Tupla conteniendo todos los datos del vehículo en cuestión.</param>
    Public Sub New(fila As DataRow)
        InitializeComponent()
        tupla = fila
		Try
			CargarNumeroInspec()
			CargarUsername()
			CargarLugar()
			CargarDate()
			vin = fila.Field(Of String)(1)
			CargarDamages()
		Catch ex As Exception
			MsgBox("Error: " & My.Resources.ErrorCodes.ErrorCargaBD) 'PASAR A CODIGO DE ERROR (pasado,saludos)
		End Try
		OpcGraficas()
		traducirControles()
	End Sub

    Private Enum DatoSize As Integer
        ancho = 590
        alturaExpandida = 650
        alturaContraida = 250
    End Enum

    Private Sub RecursosIcono()

    End Sub
    ''' <summary>
    ''' Subrutina encargada de extraer el campo de numeroInspec de la tupla en cuestión.
    ''' </summary>
    Private Sub CargarNumeroInspec()
        Dim texto As String = tupla.Field(Of Integer)(0)
        nroInspeccion = texto
		Dim textoMostrar As String = texto.ToString
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            ''traduce al ingles
            Me.Text = (My.Resources.EN_UK.DatosInspecc_info + textoMostrar)
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            ''traduce al español
            Me.Text = (My.Resources.ES_LA.DatosInspecc_info + textoMostrar)
        Else
            ''traduce al portugues
            Me.Text = (My.Resources.PT_BR.DatosInspecc_info + textoMostrar)
		End If
		'Me.Text = ("Información de la inspección #" + textoMostrar)
		numeroInspec.Text = ("#" + textoMostrar)
    End Sub
    ''' <summary>
    ''' Subrutina encargada de extraer el campo del Usuario responsable de la tupla en cuestión.
    ''' </summary>
    Private Sub CargarUsername()
        txt_username.Text = tupla.Field(Of String)(2)
    End Sub
    ''' <summary>
    ''' Subrutina encargada de extraer el campo de Lugar de la tupla en cuestión.
    ''' </summary>
    Private Sub CargarLugar()
        txt_place.Text = ConsultasDeLectura.GetSingleton.LugarPorId(tupla.Field(Of Integer)(3)) 'Cargamos el nombre del lugar
    End Sub
    ''' <summary>
    ''' Subrutina encargada de extraer el campo de la Fecha de la tupla en cuestión.
    ''' </summary>
    Private Sub CargarDate()
        txt_inspecDate.Text = tupla.Field(Of System.DateTime)(4)
    End Sub

    Private Sub CargarDatosDamage() Handles ListaDamage.ControlRemoved 'SACAR ESTA FUNCION
        ListaDamage.Controls.Item(0).Dispose()
        ListaDamage.Controls.Clear()
        Dim detalles As New WeakReference(New DatosDamage(ConsultasDeLectura.GetSingleton.ListadoDamagesByInspec(tupla.Field(Of Integer)(0), tupla.Field(Of String)(1)).Rows.Item(0)))
        detalles.Target.TopLevel = False
        detalles.Target.Dock = DockStyle.Fill
        detalles.Target.Size = ListaDamage.Size
        ListaDamage.Controls.Add(detalles.Target)
        detalles.Target.Show()
    End Sub

    Private Sub UpdatearBotones() Handles ventanaInspeccion.ControlAdded
        For Each var As TileDamage In ListaDamage.Controls
            var.Deseleccionar()
        Next
    End Sub

    Private Sub CargarDamages()
        Dim tabla As DataTable
        Try
            tabla = ConsultasDeLectura.GetSingleton.ListadoDamagesByInspec(nroInspeccion, vin)
            For var As Integer = 0 To tabla.Rows.Count - 1
                Dim tile As New WeakReference(New TileDamage(tabla.Rows.Item(var), ventanaInspeccion))
                tile.Target.TopLevel = False
                ListaDamage.Controls.Add(tile.Target)
                tile.Target.Show()
                lbl_vacio.Hide()
            Next
        Catch ex As Exception
            lbl_vacio.Show()
        End Try
    End Sub

	Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click, Me.FormClosing
		Me.Finalize()
		Me.Dispose(True)
	End Sub

	Private Sub traducirControles()
		If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
			''traduce al ingles
			lbl_user.Text = My.Resources.EN_UK.DatosInspecc_lbluser
			lbl_lug.Text = My.Resources.EN_UK.DatosInspecc_lbllug
			lbl_date.Text = My.Resources.EN_UK.DatosInspecc_lbldate
			lbl_damage.Text = My.Resources.EN_UK.DatosInspecc_lbldamage
			lbl_vacio.Text = My.Resources.EN_UK.DatosInspecc_lblvacio
		ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
			''traduce al español
			lbl_user.Text = My.Resources.ES_LA.DatosInspecc_lbluser
			lbl_lug.Text = My.Resources.ES_LA.DatosInspecc_lbllug
			lbl_date.Text = My.Resources.ES_LA.DatosInspecc_lbldate
			lbl_damage.Text = My.Resources.ES_LA.DatosInspecc_lbldamage
			lbl_vacio.Text = My.Resources.ES_LA.DatosInspecc_lblvacio
		Else
			''traduce al portugues
			lbl_user.Text = My.Resources.PT_BR.DatosInspecc_lbluser
			lbl_lug.Text = My.Resources.PT_BR.DatosInspecc_lbllug
			lbl_date.Text = My.Resources.PT_BR.DatosInspecc_lbldate
			lbl_damage.Text = My.Resources.PT_BR.DatosInspecc_lbldamage
			lbl_vacio.Text = My.Resources.PT_BR.DatosInspecc_lblvacio
		End If
	End Sub

	Private Sub OpcGraficas()
		Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.ventanaInspeccion.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.lbl_damage.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		Me.lbl_date.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		Me.lbl_lug.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		Me.lbl_user.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.lbl_vacio.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.txt_inspecDate.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.txt_place.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.txt_username.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Me.txt_inspecDate.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.txt_place.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.txt_username.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.ListaDamage.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        ventanaInspeccion.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        atras.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
	End Sub
End Class