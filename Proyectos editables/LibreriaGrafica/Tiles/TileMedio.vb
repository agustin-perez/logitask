Imports LibreriaLogica
Imports System.Windows.Forms
Public Class TileMedio
    Private tupla As DataRow
    Private imChecked As Boolean
    Private opcion As Int16
    ''' <summary>
    ''' Constructor específico qu inicializa los getteos de datos sobre una tupla dada por parámetros.
    ''' </summary>
    ''' <param name="fila">Tupla conteniendo los datos a mostrar.</param>
    Public Sub New(fila As DataRow)
        InitializeComponent()
        Me.DoubleBuffered = True
        tupla = fila
        CargarCoche()
        CargarCapacidad()
		CargarMatricula()
		OpcGraficas()
	End Sub

    Private Sub CargarCoche()
        lbl_coche.Text = tupla.Field(Of Short)(0).ToString
    End Sub

    Private Sub CargarMatricula()
        lbl_matricula.Text = tupla.Field(Of String)(1)
    End Sub

    Private Sub CargarCapacidad()
        lbl_cant.Text = tupla.Field(Of Short)(2)
    End Sub

    Private Sub ColorEnter() Handles Me.MouseEnter, img_icono.MouseEnter, lbl_cant.MouseEnter, lbl_coche.MouseEnter, lbl_matricula.MouseEnter
        SuspendLayout()
        If Not imChecked Then
            Me.BackColor = Drawing.Color.Gainsboro
            Cursor = Cursors.Hand
        End If
        ResumeLayout()
    End Sub

    Private Sub ColorLeave() Handles Me.MouseLeave, img_icono.MouseLeave, lbl_cant.MouseLeave, lbl_coche.MouseLeave, lbl_matricula.MouseLeave
        SuspendLayout()
        If Not imChecked Then
            Me.BackColor = Drawing.Color.DarkGray
            Cursor = Cursors.Default
        End If
        ResumeLayout()
    End Sub

    Private Sub ClickHandler() Handles Me.Click, img_icono.Click, lbl_cant.Click, lbl_coche.Click, lbl_matricula.Click
        If Not DatosSesion.GetSingleton.TileCheck Then
            DatosSesion.GetSingleton.TileCheck = True
            Me.BackColor = Drawing.Color.DimGray
            imChecked = True
        ElseIf imChecked Then
            imChecked = False
            DatosSesion.GetSingleton.TileCheck = False
        End If
    End Sub

    Public ReadOnly Property GetTupla() As DataRow
        Get
            Return tupla
        End Get
    End Property

    Public ReadOnly Property GetNroCoche() As Int16
        Get
            Return tupla.Field(Of Short)(0)
        End Get
    End Property

	Public ReadOnly Property IsChecked() As Boolean
		Get
			Return imChecked
		End Get
	End Property

    Private Sub OpcGraficas()
        Me.lbl_cant.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.lbl_coche.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		Me.lbl_matricula.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
	End Sub
End Class