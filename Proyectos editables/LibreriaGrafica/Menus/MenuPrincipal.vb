Imports System.Windows.Forms
Imports LibreriaLogica
Public Class MenuPrincipal
    Private ventanasInternas As New List(Of Form)
    Private textoBotones() As String
    Private operario As Boolean

    Public Sub New()
        InitializeComponent()
        OpcGraficas()
		MensajeInicio()
		traducirControles()
	End Sub

    Private Sub CargarVentanaMenu(ventanaInterna As Form)
        propiedadesVentanas.GetSingleton.CargarVentana(ventana, ventanaInterna)
        propiedadesVentanas.GetSingleton.OcultarControles(Me.Controls, ventana)
    End Sub

	Private Sub MensajeInicio()
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            ''traduce al ingles
            lbl_welcome.Show()
            If Now.Hour >= 0 And Now.Hour < 12 Then
                lbl_welcome.Text = (My.Resources.EN_UK.LoginVariable_lbl_welcome_morning & " " & DatosSesion.GetSingleton.UserLogged)
            End If
            If Now.Hour >= 12 And Now.Hour < 20 Then
                lbl_welcome.Text = (My.Resources.EN_UK.LoginVariable_lbl_welcome_afternoon & " " & DatosSesion.GetSingleton.UserLogged)
            End If
            If Now.Hour >= 20 And Now.Hour <= 23 Then
                lbl_welcome.Text = (My.Resources.EN_UK.LoginVariable_lbl_welcome_night & " " & DatosSesion.GetSingleton.UserLogged)
            End If
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            ''traduce al español
            lbl_welcome.Show()
            If Now.Hour >= 0 And Now.Hour < 12 Then
                lbl_welcome.Text = (My.Resources.ES_LA.LoginVariable_lbl_welcome_morning & " " & DatosSesion.GetSingleton.UserLogged)
            End If
            If Now.Hour >= 12 And Now.Hour < 20 Then
                lbl_welcome.Text = (My.Resources.ES_LA.LoginVariable_lbl_welcome_afternoon & " " & DatosSesion.GetSingleton.UserLogged)
            End If
            If Now.Hour >= 20 And Now.Hour <= 23 Then
                lbl_welcome.Text = (My.Resources.ES_LA.LoginVariable_lbl_welcome_night & " " & DatosSesion.GetSingleton.UserLogged)
            End If
        Else
            ''traduce al portugues
            lbl_welcome.Show()
            If Now.Hour >= 0 And Now.Hour < 12 Then
                lbl_welcome.Text = (My.Resources.PT_BR.LoginVariable_lbl_welcome_morning & " " & DatosSesion.GetSingleton.UserLogged)
            End If
            If Now.Hour >= 12 And Now.Hour < 20 Then
                lbl_welcome.Text = (My.Resources.PT_BR.LoginVariable_lbl_welcome_afternoon & " " & DatosSesion.GetSingleton.UserLogged)
            End If
            If Now.Hour >= 20 And Now.Hour <= 23 Then
                lbl_welcome.Text = (My.Resources.PT_BR.LoginVariable_lbl_welcome_night & " " & DatosSesion.GetSingleton.UserLogged)
            End If
        End If
    End Sub

	Private Sub Mostrar() Handles ventana.ControlRemoved
        cerrarSesion.Show()
        titulo.Show()
        Config.Show()
        ventana.Controls.Clear()
        opciones.Show()
        MensajeInicio()
    End Sub

    Private Sub Config_Click(sender As Object, e As EventArgs) Handles Config.Click
        CargarVentanaMenu(propiedadesVentanas.GetSingleton.ConfigBoton)
    End Sub

    Public Sub CargarOpcion(ventana As Object, textoBoton As String)
        ventanasInternas.Add(ventana)
        Dim botonNuevo As New Button
        botonNuevo.FlatStyle = FlatStyle.Flat
        botonNuevo.FlatAppearance.BorderSize = 0
        botonNuevo.Width = 203
        botonNuevo.Height = 75
        botonNuevo.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
        botonNuevo.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
        botonNuevo.Text = textoBoton
        AddHandler botonNuevo.Click, AddressOf AccionBotones
        opciones.Controls.Add(botonNuevo)
    End Sub

    Private Sub AccionBotones(sender As Object, e As EventArgs)
        Try
            For var As Integer = 0 To opciones.Controls.Count - 1
                If CType(sender, Button) Is opciones.Controls.Item(var) Then
                    Dim menuVar = New WeakReference(New MenuVariable)
                    For varIn As Integer = 0 To ventanasInternas.Count - 1
                        menuVar.Target.Opcion(ventanasInternas(varIn), CType(opciones.Controls.Item(varIn), Button).Text)
                    Next
                    CargarVentanaMenu(menuVar.Target)
                    menuVar.Target.VentanaDefault(var)
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CerrarSesion_Click(sender As Object, e As EventArgs) Handles cerrarSesion.Click
        ventanasInternas.Clear()
        ventanasInternas = Nothing
        DatosSesion.GetSingleton.UserLogged = Nothing
        Me.Finalize()
        GC.Collect()
        Me.Dispose()
    End Sub

	Private Sub OpcGraficas()
		Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
		Config.Image = propiedadesVentanas.GetSingleton.CfgLogo
		cerrarSesion.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
		cerrarSesion.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
		cerrarSesion.Font = propiedadesVentanas.GetSingleton.FuenteEstandarBotones
		cerrarSesion.Size = propiedadesVentanas.GetSingleton.SizeEstandarBotones
        titulo.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        lbl_welcome.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
    End Sub

	Private Sub traducirControles()
		If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
			''traduce al ingles
			titulo.Text = My.Resources.EN_UK.MenuPrincipal_titulo
			cerrarSesion.Text = My.Resources.EN_UK.MenuPrincipal_cerrarSesion
		ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
			''traduce al español
			titulo.Text = My.Resources.ES_LA.MenuPrincipal_titulo
			cerrarSesion.Text = My.Resources.ES_LA.MenuPrincipal_cerrarSesion
		Else
			''traduce al portugues
			titulo.Text = My.Resources.PT_BR.MenuPrincipal_titulo
			cerrarSesion.Text = My.Resources.PT_BR.MenuPrincipal_cerrarSesion
		End If
	End Sub
End Class