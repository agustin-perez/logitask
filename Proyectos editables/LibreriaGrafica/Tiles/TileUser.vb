Imports System.Windows.Forms

Public Class TileUser
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
        OpcGraficas()
    End Sub

    Private Sub CargarUname()
        lbl_username.Text = tupla.Field(Of String)(0) 'PASAR A VISTAaaaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA 
    End Sub

    Private Sub CargarNombre()
        lbl_name.Text = tupla.Field(Of String)(2)
    End Sub

    Private Sub CargarSurname()
        lbl_surname.Text = tupla.Field(Of String)(3)
    End Sub

    Private Sub ColorEnter() Handles Me.MouseEnter, img_icono.MouseEnter, lbl_name.MouseEnter, lbl_surname.MouseEnter, lbl_username.MouseEnter
        SuspendLayout()
        If Not imChecked Then
            Me.BackColor = Drawing.Color.Gainsboro
            Cursor = Cursors.Hand
        End If
        ResumeLayout()
    End Sub

    Private Sub ColorLeave() Handles Me.MouseLeave, img_icono.MouseLeave, lbl_name.MouseLeave, lbl_surname.MouseLeave, lbl_username.MouseLeave
        SuspendLayout()
        If Not imChecked Then
            Me.BackColor = Drawing.Color.DarkGray
            Cursor = Cursors.Default
        End If
        ResumeLayout()
    End Sub

    Private Sub ClickHandler() Handles Me.Click, img_icono.Click, lbl_name.Click, lbl_surname.Click, lbl_username.Click
        Dim detalles As New WeakReference(New DatosUser(tupla))
        detalles.Target.Show()
    End Sub

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
        Me.lbl_name.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.lbl_surname.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Me.lbl_username.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
    End Sub
End Class