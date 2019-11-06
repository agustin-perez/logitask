Imports LibreriaLogica
Imports System.Windows.Forms
''' <summary>
''' Clase encargada de mostrar una miniatura de una inspección con información resumida. Esta reacciona a eventos de Click con parámetros.
''' </summary>
Public Class TileDamage
    Private tupla As DataRow
    Private ventanaDatos As Panel
    ''' <summary>
    ''' Constructor específico que inicializa los getteos de datos sobre una tupla dada por parámetros.
    ''' </summary>
    ''' <param name="fila">Tupla conteniendo los datos a mostrar.</param>
    Public Sub New(fila As DataRow, ventanaDatos As Panel)
        Me.ventanaDatos = ventanaDatos
        Me.DoubleBuffered = True
        InitializeComponent()
        tupla = fila
        CargarNumeroDanio()
		CargarDesc()
		OpcGraficas()
	End Sub
    ''' <summary>
    ''' Subrutina encargada de cerrar el formulario para que la clase padre tome el evento y así realizar la accion necesaria.
    ''' </summary>
    Private Sub CargarDatosDamage() Handles Me.Click, img_icono.Click, lbl_desc.Click, lbl_numeroDanio.Click
        propiedadesVentanas.GetSingleton.CargarVentana(ventanaDatos, New DatosDamage(tupla))
        Me.BackColor = Drawing.Color.DimGray
    End Sub

    Private Sub ColorEnter() Handles Me.MouseEnter, img_icono.MouseEnter, lbl_desc.MouseEnter, lbl_numeroDanio.MouseEnter
        SuspendLayout()
        Me.BackColor = Drawing.Color.Gainsboro
        Cursor = Cursors.Hand
        ResumeLayout()
    End Sub

    Private Sub ColorLeave() Handles Me.MouseLeave, img_icono.MouseLeave, lbl_desc.MouseLeave, lbl_numeroDanio.MouseLeave
        SuspendLayout()
        Me.BackColor = Drawing.Color.DarkGray
        Cursor = Cursors.Default
        ResumeLayout()
    End Sub

    Public Sub Deseleccionar()
        Me.BackColor = Drawing.Color.DarkGray
    End Sub

    ''' <summary>
    ''' Subrutina encargada de rellenar el label de número de daño con los datos de la tupla.
    ''' </summary>
    Private Sub CargarNumeroDanio()
        lbl_numeroDanio.Text = ("#" + tupla.Field(Of Integer)(0).ToString)
    End Sub
	''' <summary>
	''' Subrutina encargada de rellenar el label de la descripción con los datos de la tupla.
	''' </summary>
	Private Sub CargarDesc()
		lbl_desc.Text = tupla.Field(Of String)(4)
	End Sub

	Private Sub OpcGraficas()
        Me.lbl_desc.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.lbl_numeroDanio.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
	End Sub
End Class