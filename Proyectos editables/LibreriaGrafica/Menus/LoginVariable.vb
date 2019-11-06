Imports LibreriaLogica
Imports System.Windows.Forms
Public Class LoginVariable
    Private Shared instancia As LoginVariable
    Private ventanasInternas As New List(Of Form)
    Private textoBotones As New List(Of String)
    Private userSelected As Boolean
    Private passSelected As Boolean
    Private tipo As TipoAppEnum
    Private yaConectado As Boolean

    Public Shared Function GetSingleton() As LoginVariable
        If (instancia Is Nothing) Then
            instancia = New LoginVariable
        End If
        Return instancia
    End Function

    Public Sub New()
        InitializeComponent()
        InicializarClase()
    End Sub

    Public Sub CambiarLogo(logo As propiedadesVentanas.FertspaLogo)
        Me.logo.Image = propiedadesVentanas.GetSingleton.CargarLogo(logo)
    End Sub

    Public Sub InicializarClase()
        ReadCFGFile()
        Limpiar()
        Fuentes()
        propiedadesVentanas.GetSingleton.ModoNocturno = Settings.GetSingleton.NightModeCFG
        SetIdiomas()
        OpcGraficas()
        lbl_status.Text = "Offline"
        lbl_status.ForeColor = Drawing.Color.Red
        Ingresar.Enabled = False
        errorLabel.Hide()
        clk_connection.Start()
    End Sub

    Public Sub AppReset()
        Limpiar()
        InstanciarVentanas()
    End Sub

    Public Enum TipoAppEnum As Int16
        Admin = 0
        Puerto = 1
        Patio = 2
        Transportista = 3
    End Enum

    Public Sub InstanciarVentanas()
        Select Case tipo
            Case 0 'Admin enum
                If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                    textoBotones.Add(My.Resources.EN_UK.LoginVariable_vehiculos) 'vehiculos
                    textoBotones.Add(My.Resources.EN_UK.LoginVariable_lotes) 'lotes
                    textoBotones.Add(My.Resources.EN_UK.LoginVariable_inspecciones) 'inspecciones
                    textoBotones.Add(My.Resources.EN_UK.LoginVariable_zonas) 'zonas
                    textoBotones.Add(My.Resources.EN_UK.LoginVariable_iniciarViaje) 'iniciar viaje
                    textoBotones.Add(My.Resources.EN_UK.LoginVariable_usuarios) 'usuarios
                    textoBotones.Add(My.Resources.EN_UK.LoginVariable_importarCSV) 'importar desde CSV
                ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                    textoBotones.Add(My.Resources.ES_LA.LoginVariable_vehiculos) 'vehiculos
                    textoBotones.Add(My.Resources.ES_LA.LoginVariable_lotes) 'lotes
                    textoBotones.Add(My.Resources.ES_LA.LoginVariable_inspecciones) 'inspecciones
                    textoBotones.Add(My.Resources.ES_LA.LoginVariable_zonas) 'zonas
                    textoBotones.Add(My.Resources.ES_LA.LoginVariable_iniciarViaje) 'iniciar viaje
                    textoBotones.Add(My.Resources.ES_LA.LoginVariable_usuarios) 'usuarios
                    textoBotones.Add(My.Resources.ES_LA.LoginVariable_importarCSV) 'importar desde CSV
                Else
                    ''Portugues
                    textoBotones.Add(My.Resources.PT_BR.LoginVariable_vehiculos) 'vehiculos
                    textoBotones.Add(My.Resources.PT_BR.LoginVariable_lotes) 'lotes
                    textoBotones.Add(My.Resources.PT_BR.LoginVariable_inspecciones) 'inspecciones
                    textoBotones.Add(My.Resources.PT_BR.LoginVariable_zonas) 'zonas
                    textoBotones.Add(My.Resources.PT_BR.LoginVariable_iniciarViaje) 'iniciar viaje
                    textoBotones.Add(My.Resources.PT_BR.LoginVariable_usuarios) 'usuarios
                    textoBotones.Add(My.Resources.PT_BR.LoginVariable_importarCSV) 'importar desde CSV

                End If
                ventanasInternas.Add(New MenuVehiculos)
                ventanasInternas.Add(New MenuLotes(TileLote.TileActionOnClick.Detalles))
                ventanasInternas.Add(New NuevaInspeccion)
                ventanasInternas.Add(New MenuZonas)
                ventanasInternas.Add(New SeleccionarMedio)
                ventanasInternas.Add(New AltaUser)
                ventanasInternas.Add(New ImportarVehiculos)
            Case 1 'Puerto enum
                If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                    textoBotones.Add(My.Resources.EN_UK.LoginVariable_vehiculos)
                    textoBotones.Add(My.Resources.EN_UK.LoginVariable_lotes)
                    textoBotones.Add(My.Resources.EN_UK.LoginVariable_inspecciones)

                ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                    textoBotones.Add(My.Resources.ES_LA.LoginVariable_vehiculos)
                    textoBotones.Add(My.Resources.ES_LA.LoginVariable_lotes)
                    textoBotones.Add(My.Resources.ES_LA.LoginVariable_inspecciones)
                Else
                    ''Portugues
                    textoBotones.Add(My.Resources.PT_BR.LoginVariable_vehiculos)
                    textoBotones.Add(My.Resources.PT_BR.LoginVariable_lotes)
                    textoBotones.Add(My.Resources.PT_BR.LoginVariable_inspecciones)
                End If
                ventanasInternas.Add(New MenuVehiculos)
                ventanasInternas.Add(New MenuLotes(TileLote.TileActionOnClick.Detalles))
                ventanasInternas.Add(New NuevaInspeccion)
            Case 2 'Patio enum
                If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                    textoBotones.Add(My.Resources.EN_UK.LoginVariable_vehiculos)
                    textoBotones.Add(My.Resources.EN_UK.LoginVariable_lotes)
                    textoBotones.Add(My.Resources.EN_UK.LoginVariable_inspecciones)
                    textoBotones.Add(My.Resources.EN_UK.LoginVariable_zonas)
                ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                    textoBotones.Add(My.Resources.ES_LA.LoginVariable_vehiculos)
                    textoBotones.Add(My.Resources.ES_LA.LoginVariable_lotes)
                    textoBotones.Add(My.Resources.ES_LA.LoginVariable_inspecciones)
                    textoBotones.Add(My.Resources.ES_LA.LoginVariable_zonas)
                Else
                    ''Portugues
                    textoBotones.Add(My.Resources.PT_BR.LoginVariable_vehiculos)
                    textoBotones.Add(My.Resources.PT_BR.LoginVariable_lotes)
                    textoBotones.Add(My.Resources.PT_BR.LoginVariable_inspecciones)
                    textoBotones.Add(My.Resources.PT_BR.LoginVariable_zonas)
                End If
                ventanasInternas.Add(New MenuVehiculos)
                ventanasInternas.Add(New MenuLotes(TileLote.TileActionOnClick.Detalles))
                ventanasInternas.Add(New NuevaInspeccion)
                ventanasInternas.Add(New MenuZonas)
            Case 3 'Driver enum
                If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                    textoBotones.Add(My.Resources.EN_UK.LoginVariable_vehiculos)
                    textoBotones.Add(My.Resources.EN_UK.LoginVariable_lotes)
                    textoBotones.Add(My.Resources.EN_UK.LoginVariable_iniciarViaje)
                ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                    textoBotones.Add(My.Resources.ES_LA.LoginVariable_vehiculos)
                    textoBotones.Add(My.Resources.ES_LA.LoginVariable_lotes)
                    textoBotones.Add(My.Resources.ES_LA.LoginVariable_iniciarViaje)
                Else
                    ''Portugues
                    textoBotones.Add(My.Resources.PT_BR.LoginVariable_vehiculos)
                    textoBotones.Add(My.Resources.PT_BR.LoginVariable_lotes)
                    textoBotones.Add(My.Resources.PT_BR.LoginVariable_iniciarViaje)
                End If
                ventanasInternas.Add(New MenuVehiculos)
                ventanasInternas.Add(New MenuLotes(TileLote.TileActionOnClick.Detalles))
                ventanasInternas.Add(New SeleccionarMedio)
        End Select
    End Sub

    Private Sub VerificarRol(username As String)
        tipo = ConsultasPrincipales.GetSingleton.VerificarRol(username)
    End Sub

    Private Sub Limpiar()
        user.Clear()
        pass.Clear()
        pass.UseSystemPasswordChar = False
        userSelected = False
        passSelected = False
        ventana.Controls.Clear()
        ventanasInternas.Clear()
        ventanasInternas = Nothing
        textoBotones.Clear()
        textoBotones = Nothing
        ventanasInternas = New List(Of Form)
        textoBotones = New List(Of String)
        SetIdiomas()
        OpcGraficas()
    End Sub

    Private Function Verificar() As Boolean
        If (user.Text <> "" And pass.Text <> "") Then
            Try
                If ConsultasPrincipales.GetSingleton.ConsultaLogin(user.Text, pass.Text) Then
                    errorLabel.Hide()
                    Return True
                Else
                    errorLabel.Show()
                End If
            Catch ex As Exception
                errorLabel.Hide()
                If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                    MsgBox(My.Resources.EN_UK.LoginVariable_errorRed & My.Resources.ErrorCodes.ErrorConexion, MsgBoxStyle.Critical, My.Resources.EN_UK.LoginVariable_errorRedTitle)
                ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                    MsgBox(My.Resources.ES_LA.LoginVariable_errorRed & My.Resources.ErrorCodes.ErrorConexion, MsgBoxStyle.Critical, My.Resources.ES_LA.LoginVariable_errorRedTitle)
                Else
                    MsgBox(My.Resources.PT_BR.LoginVariable_errorRed & My.Resources.ErrorCodes.ErrorConexion, MsgBoxStyle.Critical, My.Resources.PT_BR.LoginVariable_errorRedTitle)
                End If
            End Try
        Else
            If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                MsgBox(My.Resources.EN_UK.LoginVariable_vacio & My.Resources.ErrorCodes.ErrorConexion, MsgBoxStyle.Critical, My.Resources.EN_UK.LoginVariable_vaciotitle)
            ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                MsgBox(My.Resources.ES_LA.LoginVariable_vacio & My.Resources.ErrorCodes.ErrorConexion, MsgBoxStyle.Critical, My.Resources.ES_LA.LoginVariable_vaciotitle)
            Else
                MsgBox(My.Resources.PT_BR.LoginVariable_vacio & My.Resources.ErrorCodes.ErrorConexion, MsgBoxStyle.Critical, My.Resources.PT_BR.LoginVariable_vaciotitle)
            End If
        End If
        Return False
    End Function

    Private Sub CargarOpciones()
        Dim menuPrincip = New WeakReference(New MenuPrincipal)
        propiedadesVentanas.GetSingleton.CargarVentana(ventana, menuPrincip.Target)
        For var As Integer = 0 To ventanasInternas.Count - 1
            menuPrincip.Target.CargarOpcion(ventanasInternas.Item(var), textoBotones.Item(var))
        Next
    End Sub

    Private Sub ReadCFGFile()
        Try
            EntradaSalida.GetSingleton.CargarCFG()
            EntradaSalida.GetSingleton.ConectarBD()
            SetIdiomas()
        Catch ex As Exception
            If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                lbl_status.Text = My.Resources.EN_UK.LoginVariable_ErrorConexion
            ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                lbl_status.Text = My.Resources.ES_LA.LoginVariable_ErrorConexion
            Else
                lbl_status.Text = My.Resources.PT_BR.LoginVariable_ErrorConexion
            End If
            lbl_status.ForeColor = Drawing.Color.DarkRed
            Ingresar.Enabled = False
        End Try
    End Sub

    Private Sub Recargarme() Handles ventana.ControlRemoved
        Mostrar()
        Limpiar()
    End Sub

    Private Sub AccionIngresar()
        If (Verificar()) Then
            VerificarRol(user.Text)
            DatosSesion.GetSingleton.UserLogged = user.Text
            InstanciarVentanas()
            CargarOpciones()
            ContenedorControles.Hide()
        Else
            errorLabel.Show()
        End If
    End Sub

    Private Sub Ingresar_Click(sender As Object, e As EventArgs) Handles Ingresar.Click
        AccionIngresar()
    End Sub

    Private Sub Config_Click(sender As Object, e As EventArgs) Handles Config.Click
        propiedadesVentanas.GetSingleton.CargarVentana(ventana, propiedadesVentanas.GetSingleton.ConfigBoton)
        Ocultar()
    End Sub

    Private Sub Ocultar()
        propiedadesVentanas.GetSingleton.OcultarControles(Me.Controls, ventana)
    End Sub

    Private Sub Mostrar()
        clk_connection.Start()
        clk_connection.InitializeLifetimeService()
        ContenedorControles.Show()
        errorLabel.Hide()
        Fuentes()
        OpcGraficas()
    End Sub

    Private Sub Restablecer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles restablecer.LinkClicked
        MsgBox("En construcción hasta que se termine APP admin.", MsgBoxStyle.Information, "Advertencia")
        'EL ADMIN LO VA A APROBAR Y EL USER SE LE VA A MOSTRAR UNA VENTANA PARA CAMBIAR DE CONTRASEÑA  
        Dim restablecer As New WeakReference(New RestablecerPass)
        propiedadesVentanas.GetSingleton.OcultarControles(Me.Controls, ventana)
        propiedadesVentanas.GetSingleton.CargarVentana(ventana, restablecer.Target)
    End Sub

    Private Sub AtrasHover() Handles Config.MouseEnter
        Config.BackColor = Drawing.Color.Transparent
    End Sub

    Private Sub AtrasLeave() Handles Config.MouseLeave
        Config.BackColor = Drawing.Color.Transparent
    End Sub

    Private Sub UserGotSelected() Handles user.GotFocus
        If Not userSelected Then
            user.Clear()
            user.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        End If
        userSelected = True
    End Sub

    Private Sub PassGotSelected() Handles pass.GotFocus
        If Not passSelected Then
            pass.Clear()
            pass.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
            pass.UseSystemPasswordChar = True
        End If
        passSelected = True
    End Sub

    Private Sub UpdateNetworkStatus()
        If EntradaSalida.GetSingleton.IsConnected Then
            lbl_status.Text = "Online"
            lbl_status.ForeColor = Drawing.Color.ForestGreen
            Ingresar.Enabled = True
        Else
            lbl_status.Text = "Offline"
                lbl_status.ForeColor = Drawing.Color.Red
                Ingresar.Enabled = False
            End If
    End Sub

    Private Sub clk_connection_Tick(sender As Object, e As EventArgs) Handles clk_connection.Tick
        UpdateNetworkStatus()
    End Sub

    Public ReadOnly Property GetTipo() As TipoAppEnum
        Get
            Return tipo
        End Get
    End Property
#Region "Gráfica"
    Private Sub SetIdiomas()
        If (Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA) Then
            user.Text = My.Resources.ES_LA.UserName
            pass.Text = My.Resources.ES_LA.Pass
            restablecer.Text = My.Resources.ES_LA.ResetPass
            Ingresar.Text = My.Resources.ES_LA.ButtonLogin
            errorLabel.Text = My.Resources.ES_LA.ErrorMsg
        End If
        If (Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK) Then
            user.Text = My.Resources.EN_UK.UserName
            pass.Text = My.Resources.EN_UK.Pass
            restablecer.Text = My.Resources.EN_UK.ResetPass
            Ingresar.Text = My.Resources.EN_UK.ButtonLogin
            errorLabel.Text = My.Resources.EN_UK.ErrorMsg
        End If
        If (Settings.GetSingleton.LangCFG = Settings.LangEnum.PT_BR) Then
            user.Text = My.Resources.PT_BR.UserName
            pass.Text = My.Resources.PT_BR.Pass
            restablecer.Text = My.Resources.PT_BR.ResetPass
            Ingresar.Text = My.Resources.PT_BR.ButtonLogin
            errorLabel.Text = My.Resources.PT_BR.ErrorMsg
        End If
    End Sub

    Private Sub Fuentes()
        Dim configFuente = Config.Font
        Dim fuenteUser = user.Font
        Dim fuentePass = pass.Font
        propiedadesVentanas.GetSingleton.SizeTextoGeneral(Me.Controls, ventana)
        Config.Font = configFuente
        user.Font = fuenteUser
        pass.Font = fuentePass
    End Sub

    Private Sub OpcGraficas()
        Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        Config.Image = propiedadesVentanas.GetSingleton.CfgLogo
        user.ForeColor = propiedadesVentanas.GetSingleton.ColorTextoInput
        pass.ForeColor = propiedadesVentanas.GetSingleton.ColorTextoInput
        user.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        pass.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        txt_userUnderscore.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        txt_passUnderscore.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        Ingresar.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
        Ingresar.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
        Ingresar.Font = propiedadesVentanas.GetSingleton.FuenteEstandarBotones
        Ingresar.Size = propiedadesVentanas.GetSingleton.SizeEstandarBotones
    End Sub
#End Region
End Class