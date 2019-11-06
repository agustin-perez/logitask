Imports System.Drawing
Imports System.Windows.Forms
Imports LibreriaLogica
Public Class MenuVariable
    Private ventanasInternas As New List(Of Form)
    Private windowReloadIndex As Short

    Private Sub MenuVariable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		OpcGraficas()
		traducirControles()
	End Sub

    Private Sub CargarVentanaMenu(ventanaInterna As Form)
        propiedadesVentanas.GetSingleton.CargarVentana(ventana, ventanaInterna)
    End Sub

    Private Sub Recargar() Handles ventana.SizeChanged
        If DatosSesion.GetSingleton.ReloadListado Then
            CargarVentanaMenu(ventanasInternas(windowReloadIndex))
            ventanasInternas(windowReloadIndex).Width += 1
            DatosSesion.GetSingleton.ReloadListado = False
        End If
    End Sub

    Private Sub LimpiarVentana()
        ventana.Controls.Clear()
    End Sub

    Private Sub Atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        If propiedadesVentanas.GetSingleton.VentanaVolver IsNot Nothing Then
            propiedadesVentanas.GetSingleton.VentanaVolver.Dispose()
            propiedadesVentanas.GetSingleton.VentanaVolver = Nothing
        Else
            LimpiarMemoria()
        End If
    End Sub

    Private Sub Volver_Handler(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            LimpiarMemoria()
        End If
    End Sub

    Private Sub LimpiarMemoria()
        ventana.Controls.Clear()
        ventanasInternas.Clear()
        opciones.Controls.Clear()
        Me.Dispose()
    End Sub

    Private Sub Actualizar(sender As Object, e As EventArgs) Handles ventana.ControlRemoved
        Try
            propiedadesVentanas.GetSingleton.VentanaVolver.Dispose()
        Catch ex As Exception
        End Try
        If propiedadesVentanas.GetSingleton.CheckConfig Then
            propiedadesVentanas.GetSingleton.CheckConfig = False
            LimpiarMemoria()
        End If
    End Sub

    Public Sub CambiarTitulo(titulo As String)
        opcionesTitle.Text = titulo
    End Sub

    Public Sub VentanaDefault(posArrVentana As Integer)
        CargarVentanaMenu(ventanasInternas.Item(posArrVentana))
        opcionesTitle.Text = opciones.Controls.Item(posArrVentana).Text
    End Sub

    Public Sub Opcion(ventana As Form, textoBoton As String)
        ventanasInternas.Add(ventana)
        Dim botonNuevo As New Button
        botonNuevo.FlatStyle = FlatStyle.Flat
        botonNuevo.FlatAppearance.BorderSize = 0
        botonNuevo.Width = 230
        botonNuevo.Height = 40
        botonNuevo.Margin = New Padding(0, 0, 0, 0)
        botonNuevo.Font = propiedadesVentanas.GetSingleton.FuenteEstandarBotones
        botonNuevo.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
        botonNuevo.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
        botonNuevo.Text = textoBoton
        AddHandler botonNuevo.Click, AddressOf AccionBotones
        opciones.Controls.Add(botonNuevo)
        botonNuevo.Show()
    End Sub

    Private Sub AccionBotones(sender As Object, e As EventArgs)
        For var As Short = 0 To opciones.Controls.Count - 1
            If CType(sender, Button) Is opciones.Controls.Item(var) Then
                CargarVentanaMenu(ventanasInternas(var))
                opcionesTitle.Text = CType(sender, Button).Text
                windowReloadIndex = var
            End If
        Next
    End Sub

    Private Sub AtrasHover() Handles atras.MouseEnter
        atras.BackColor = Color.Gainsboro
    End Sub

    Private Sub AtrasLeave() Handles atras.MouseLeave
        atras.BackColor = Color.Transparent
    End Sub

	Private Sub OpcGraficas()
		Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo 'Asignamos color al fondo
		Me.opciones.BackColor = propiedadesVentanas.GetSingleton.ColorPanelesMenu 'Asignamos color a las barras de opciones
		Me.opcionesTop.BackColor = propiedadesVentanas.GetSingleton.ColorPanelesMenu 'Asignamos color a la barra superior izquierda de título
		Me.opcionesTitle.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels 'Asignamos color de texto
		Me.atras.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
		opcionesTitle.Font = propiedadesVentanas.GetSingleton.FuenteSubTitulo
	End Sub

	Private Sub traducirControles()
		If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
			''traduce al ingles
			opcionesTitle.Text = My.Resources.EN_UK.MenuVariable_lblSeleccionar
		ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
			''traduce al español
			opcionesTitle.Text = My.Resources.ES_LA.MenuVariable_lblSeleccionar
		Else
			''traduce al portugues
			opcionesTitle.Text = My.Resources.PT_BR.MenuVariable_lblSeleccionar
		End If
	End Sub
End Class
