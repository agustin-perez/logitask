Imports System.Windows.Forms
Imports LibreriaLogica
Public Class TileLugar
    Private tupla As DataRow
    Private opcion As Int16
    ''' <summary>e
    ''' Constructor específico que inicializa los getteos de datos sobre una tupla dada por parámetros.
    ''' </summary>
    ''' <param name="fila">Tupla conteniendo los datos a mostrar.</param>
    ''' <param name="accion">Tipo de acción que desencadena el click sobre el tile. Administrado por un Enum.</param>
    Public Sub New(fila As DataRow, accion As TileActionOnClick)
        InitializeComponent()
        Me.DoubleBuffered = True
        tupla = fila
        CargarID()
        CargarNombre()
		CargarCapacidad()
		OpcGraficas()
	End Sub

    Public Enum TileActionOnClick As Integer
        Detalles
    End Enum

    Private Sub CargarID()
        lbl_idlugar.Text = tupla.Field(Of Integer)(0)
    End Sub

    Private Sub CargarNombre()
        lbl_nombre.Text = tupla.Field(Of String)(1)
    End Sub

    Private Sub CargarCapacidad()
        lbl_capacidad.Text = tupla.Field(Of Short)(3).ToString
    End Sub

    Private Sub ReturnTuplaTemp() Handles Me.Click, lbl_idlugar.Click, lbl_capacidad.Click, lbl_nombre.Click, icono.Click
        DatosSesion.GetSingleton.TuplaTemporal = tupla
        Me.BackColor = Drawing.Color.SlateGray
    End Sub

    Private Sub ColorEnter() Handles Me.MouseEnter, icono.MouseEnter, lbl_capacidad.MouseEnter, lbl_idlugar.MouseEnter, lbl_nombre.MouseEnter
        SuspendLayout()
        Me.BackColor = Drawing.Color.Gainsboro
        Cursor = Cursors.Hand
        ResumeLayout()
    End Sub

    Private Sub ColorLeave() Handles Me.MouseLeave, icono.MouseLeave, lbl_capacidad.MouseLeave, lbl_idlugar.MouseLeave, lbl_nombre.MouseLeave
        SuspendLayout()
        Me.BackColor = Drawing.Color.DarkGray
        Cursor = Cursors.Default
        ResumeLayout()
    End Sub

	Private Sub OpcGraficas()
        Me.lbl_capacidad.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.lbl_idlugar.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		Me.lbl_nombre.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
	End Sub
End Class