Imports LibreriaLogica
Imports System.Windows.Forms
''' <summary>
''' Clase encargada de mostrar una miniatura de un vehículo con información resumida. Esta reacciona a eventos de Click con parámetros.
''' </summary>
Public Class TileVehiculo
    Implements IDisposable
    Private tupla As DataRow
    Private vin As String
    Private opcion As Int16
    Private confirmadoLote As Boolean
    ''' <summary>
    ''' Constructor específico que inicializa los getteos de datos sobre una tupla dada por parámetros.
    ''' </summary>
    ''' <param name="fila">Tupla conteniendo los datos a mostrar.</param>
    ''' <param name="accion">Tipo de acción que desencadena el click sobre el tile. Administrado por un Enum.</param>
    Public Sub New(fila As DataRow, accion As TileActionOnClick)
        InitializeComponent()
        Me.DoubleBuffered = True
        opcion = accion
        tupla = fila
        CargarVin()
        CargarMarca()
		CargarModelo()
		OpcGraficas()
	End Sub

    Private Sub CargarDatosVehiculo() Handles Me.Click, img_icono.Click, lbl_vin.Click, lbl_modelo.Click, lbl_marca.Click
        If opcion = 0 Then
            Dim detalles As New WeakReference(New DatosVehiculo(tupla))
            detalles.Target.Show()
        End If
        If opcion = 1 Then
            DatosSesion.GetSingleton.VinTemp = tupla.Field(Of String)(0)
            Me.Dispose()
        End If
        If opcion = 2 Then
            Me.Dispose()
        End If
    End Sub
    ''' <summary>
    ''' Enumerador encargado de administrar las acciones por parámetros.
    ''' </summary>
    Public Enum TileActionOnClick As Integer
        Detalles
        DisposeOnClick
        ConfirmarLote
    End Enum
    ''' <summary>
    ''' Subrutina encargada de rellenar el label de VIN (Vehicle Identification Number) con los datos de la tupla.
    ''' </summary>
    Private Sub CargarVin()
        lbl_vin.Text = tupla.Field(Of String)(0)
        vin = lbl_vin.Text
    End Sub
    ''' <summary>
    ''' Subrutina encargada de rellenar el label de marca con los datos de la tupla.
    ''' </summary>
    Private Sub CargarMarca()
        lbl_marca.Text = tupla.Field(Of String)(1)
    End Sub
    ''' <summary>
    ''' Subrutina encargada de rellenar el label de modelo con los datos de la tupla.
    ''' </summary>
    Private Sub CargarModelo()
        lbl_modelo.Text = tupla.Field(Of String)(2)
    End Sub

    Private Sub ColorEnter() Handles Me.MouseEnter, img_icono.MouseEnter, lbl_marca.MouseEnter, lbl_modelo.MouseEnter, lbl_vin.MouseEnter
        SuspendLayout()
        Me.BackColor = Drawing.Color.Gainsboro
        Cursor = Cursors.Hand
        ResumeLayout()
    End Sub

    Private Sub ColorLeave() Handles Me.MouseLeave, img_icono.MouseLeave, lbl_marca.MouseLeave, lbl_modelo.MouseLeave, lbl_vin.MouseLeave
        SuspendLayout()
        Me.BackColor = Drawing.Color.DarkGray
        Cursor = Cursors.Default
        ResumeLayout()
    End Sub

    Public Sub CambioImagen()
        Dim tipo As String
        Try
            tipo = tupla.Field(Of String)(5)
        Catch ex As Exception
            tipo = tupla.Field(Of Char)(5)
        End Try
        Dim color As String = tupla.Field(Of String)(4)
        propiedadesVentanas.GetSingleton.CambiarImagenTipo(img_icono, tipo, color, False)
    End Sub

    Public ReadOnly Property GetTupla() As DataRow
        Get
            Return tupla
        End Get
    End Property

    Public ReadOnly Property GetVin() As String
        Get
            Return vin
        End Get
    End Property

	Private Sub LiberarMemoria() Handles Me.Disposed
		img_icono.Dispose()
		tupla = Nothing
		Me.Finalize()
		Me.Dispose(True)
	End Sub

	Private Sub OpcGraficas()
        Me.lbl_marca.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.lbl_modelo.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		Me.lbl_vin.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
	End Sub
End Class