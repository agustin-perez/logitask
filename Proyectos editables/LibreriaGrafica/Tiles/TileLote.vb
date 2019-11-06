Imports LibreriaLogica
Imports System.Windows.Forms
Public Class TileLote
    Private tupla As DataRow
    Private imchecked As Boolean
    Private vehiculosEnlote As Int32
    Private opcion As Int16
    ''' <summary>
    ''' Constructor específico qu inicializa los getteos de datos sobre una tupla dada por parámetros.
    ''' </summary>
    ''' <param name="fila">Tupla conteniendo los datos a mostrar.</param>
    ''' <param name="accion">Tipo de acción que desencadena el click sobre el tile. Administrado por un Enum.</param>
    Public Sub New(fila As DataRow, accion As TileActionOnClick)
        InitializeComponent()
        Me.DoubleBuffered = True
        opcion = accion
        tupla = fila
        CargarID()
        CargarNombre()
		CargarResponsable()
		OpcGraficas()
	End Sub
    ''' <summary>
    ''' Enumerador encargado de administrar las acciones por parámetros.
    ''' </summary>
    Public Enum TileActionOnClick As Integer
        Detalles
        IniciarViaje
    End Enum

    Public Sub CargarVehiculosEnLote()
        vehiculosEnlote = ConsultasDeLectura.GetSingleton.VehiculosPorLote(tupla.Field(Of Integer)(0))
        CargarNumeros()
    End Sub

    Public Sub CargarDatosVehiculo() Handles Me.Click, img_icono.Click, lbl_cant.Click, lbl_id.Click, lbl_nombre.Click, lbl_user.Click
        If opcion = 0 Then
            Dim detalles As New InfoLote(tupla)
            detalles.Show()
        End If
    End Sub

    Public Sub Uncheck()
        imchecked = False
        OpcGraficas()
    End Sub

    Private Sub CargarID()
        lbl_id.Text = tupla.Field(Of Integer)(0).ToString
    End Sub

    Private Sub CargarNombre()
        lbl_nombre.Text = tupla.Field(Of String)(2)
    End Sub

    Private Sub CargarNumeros()
        Dim vehiculosMax As Int32 = ConsultasDeLectura.GetSingleton.MaxVehiculosLote
        lbl_cant.Text = (vehiculosEnlote.ToString + "/" + vehiculosMax.ToString)
    End Sub

    Private Sub CargarResponsable()
        lbl_user.Text = tupla.Field(Of String)(1)
    End Sub

    Private Sub ColorEnter() Handles Me.MouseEnter, img_icono.MouseEnter, lbl_cant.MouseEnter, lbl_id.MouseEnter, lbl_nombre.MouseEnter, lbl_user.MouseEnter
        SuspendLayout()
        If Not imchecked Then
            Me.BackColor = Drawing.Color.Gainsboro
            Cursor = Cursors.Hand
        End If
        ResumeLayout()
    End Sub

    Private Sub ColorLeave() Handles Me.MouseLeave, img_icono.MouseLeave, lbl_cant.MouseLeave, lbl_id.MouseLeave, lbl_nombre.MouseLeave, lbl_user.MouseLeave
        SuspendLayout()
        If Not imchecked Then
            Me.BackColor = Drawing.Color.DarkGray
            Cursor = Cursors.Default
        End If
        ResumeLayout()
    End Sub

    Public ReadOnly Property GetTupla() As DataRow
        Get
            Return tupla
        End Get
    End Property

    Public Property Check() As Boolean
        Get
            Return imchecked
        End Get
        Set(value As Boolean)
            imchecked = value
        End Set
    End Property

    Public ReadOnly Property CantVehiculos() As String
        Get
            Return lbl_cant.Text
        End Get
    End Property

	Public ReadOnly Property CantVehiculosNum() As Int32
		Get
			Return vehiculosEnlote
		End Get
	End Property
    Private Sub OpcGraficas()
        Me.BackColor = Drawing.Color.DarkGray
        Me.lbl_cant.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.lbl_id.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.lbl_nombre.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.lbl_user.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
    End Sub
End Class