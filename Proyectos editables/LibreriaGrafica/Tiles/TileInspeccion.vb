Imports System.Windows.Forms
Imports LibreriaLogica
''' <summary>
''' Clase encargada de mostrar una miniatura de una inspección con información resumida. Esta reacciona a eventos de Click con parámetros.
''' </summary>
Public Class TileInspeccion
    Private tupla As DataRow
    Private accion As Int16
    ''' <summary>
    ''' Constructor específico que inicializa los getteos de datos sobre una tupla dada por parámetros.
    ''' </summary>
    ''' <param name="fila">Tupla conteniendo los datos a mostrar.</param>
    Public Sub New(fila As DataRow, accion As TileActionOnClick)
        InitializeComponent()
        Me.DoubleBuffered = True
        tupla = fila
        Me.accion = accion
        CargarNumeroInspec()
        CargarAutor()
		CargarFecha()
		OpcGraficas()
	End Sub
    ''' <summary>
    ''' Enumerador encargado de administrar las acciones por parámetros.
    ''' </summary>
    Public Enum TileActionOnClick As Int16
        detalles
    End Enum
    ''' <summary>
    ''' Subrutina encargada de cambiar el recurso de ícono a rojo si tiene daño, o negro si no tiene.
    ''' </summary>
    Private Sub RecursosIconos()
        'sadffffSAAAAAAAAAAAAAAAAAAAAAAAA



    End Sub
    ''' <summary>
    ''' Subrutina encargada de rellenar el label de número de inspección con los datos de la tupla.
    ''' </summary>
    Private Sub CargarNumeroInspec()
        lbl_inspec.Text = ("#" + tupla.Field(Of Integer)(0).ToString)
    End Sub
    ''' <summary>
    ''' Subrutina encargada de rellenar el label del autor con los datos de la tupla.
    ''' </summary>
    Private Sub CargarAutor()
        lbl_autor.Text = tupla.Field(Of String)(2)
    End Sub
    ''' <summary>
    ''' Subrutina encargada de rellenar el label de Fecha con los datos de la tupla.
    ''' </summary>
    Private Sub CargarFecha()
        Using calculo As New FuncionesEspecificas
            calculo.CalcularIntervaloFecha(lbl_date, tupla.Field(Of Date)(4))
        End Using
    End Sub

    Private Sub ColorEnter() Handles Me.MouseEnter, img_icono.MouseEnter, lbl_autor.MouseEnter, lbl_date.MouseEnter, lbl_inspec.MouseEnter
        SuspendLayout()
        Me.BackColor = Drawing.Color.Gainsboro
        Cursor = Cursors.Hand
        ResumeLayout()
    End Sub

    Private Sub ColorLeave() Handles Me.MouseLeave, img_icono.MouseLeave, lbl_autor.MouseLeave, lbl_date.MouseLeave, lbl_inspec.MouseLeave
        SuspendLayout()
        Me.BackColor = Drawing.Color.DarkGray
        Cursor = Cursors.Default
        ResumeLayout()
    End Sub

	Private Sub CargarDatosVehiculo() Handles Me.Click, img_icono.Click, lbl_autor.Click, lbl_date.Click, lbl_inspec.Click
		If accion = 0 Then
			Dim ventana As New DatosInspecc(tupla)
			ventana.Show()
		End If
	End Sub

	Private Sub OpcGraficas()
        Me.lbl_autor.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.lbl_date.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		Me.lbl_inspec.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
	End Sub
End Class