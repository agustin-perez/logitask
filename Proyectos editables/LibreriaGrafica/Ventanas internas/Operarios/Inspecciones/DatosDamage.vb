Imports System.Windows.Forms
Imports System
Imports LibreriaLogica
''' <summary>
''' Clase encargada de mostrar la información detallada de un vehículo especificado desde una tupla por parámetros.
''' </summary>
Public Class DatosDamage
    Implements IDisposable
    Private tupla As DataRow
    ''' <summary>
    ''' Constructor específico encargado de inicializar la instancia de la clase y tomar como parámetro una tupla conteniendo los datos del vehículo a mostrar los detalles.
    ''' </summary>
    ''' <param name="fila">Tupla conteniendo todos los datos del vehículo en cuestión.</param>
    Public Sub New(fila As DataRow)
        InitializeComponent()
        tupla = fila
        CargarNumeroDamage()
        CargarDesc()
		CargarImagen()
		traducirControles()
		OpcGraficas()
	End Sub
    ''' <summary>
    ''' Subrutina encargada de extraer el campo de numeroDamage de la tupla en cuestión.
    ''' </summary>
    Private Sub CargarNumeroDamage()
        Dim texto As String = tupla.Field(Of Integer)(0)
        Dim textoMostrar As String = texto.ToString
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            Me.Text = (My.Resources.EN_UK.DatosDamage_infoDaño + textoMostrar)
            numeroDamage.Text = ("#" + textoMostrar)
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            Me.Text = (My.Resources.ES_LA.DatosDamage_infoDaño + textoMostrar)
            numeroDamage.Text = ("#" + textoMostrar)
        Else
            ''Portugues
            Me.Text = (My.Resources.PT_BR.DatosDamage_infoDaño + textoMostrar)
            numeroDamage.Text = ("#" + textoMostrar)
        End If
        ''Me.Text = ("Información del Daño #" + textoMostrar)
        ''numeroDamage.Text = ("#" + textoMostrar)
    End Sub
    ''' <summary>
    ''' Subrutina encargada de extraer el campo de la descripción de la tupla en cuestión.
    ''' </summary>
    Private Sub CargarDesc()
        txt_desc.Text = tupla.Field(Of String)(4)
    End Sub
    ''' <summary>
    ''' Subrutina encargada de extraer la imagen de la tupla en cuestión.
    ''' </summary>
    Private Sub CargarImagen()
        If propiedadesVentanas.GetSingleton.DecodificarImagen(tupla.Field(Of Byte())(3)) Is Nothing Then
            foto.Image = My.Resources.Images.damage
        Else
            foto.Image = propiedadesVentanas.GetSingleton.DecodificarImagen(tupla.Field(Of Byte())(3))
        End If
    End Sub

	Private Sub Limpiar() Handles Me.Disposed
		Me.Finalize()
	End Sub

	Private Sub traducirControles()
		If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
			''traduce al ingles
			lbl_detalles.Text = My.Resources.EN_UK.DatosDamage_lbldetalles
		ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
			''traduce al español
			lbl_detalles.Text = My.Resources.ES_LA.DatosDamage_lbldetalles
		Else
			''traduce al portugues
			lbl_detalles.Text = My.Resources.PT_BR.DatosDamage_lbldetalles
		End If
	End Sub

	Private Sub OpcGraficas()
		Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
		numeroDamage.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		lbl_detalles.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		txt_desc.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        foto.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
    End Sub
End Class