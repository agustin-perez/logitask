Imports System.Windows.Forms
Imports LibreriaLogica
Imports System.Drawing
Public Class propiedadesVentanas
    Private logos(7) As Drawing.Bitmap
    Private Cfg As Boolean
    Private cancelarInspec As Boolean
    Private textoSize As Single
    Private menuOptionChanged As Boolean
    Private Shared NightMode As Boolean
    Private Shared instancia As propiedadesVentanas
    Private accionVolver As Form

    Public Sub New()
        textoSize = 11
        NightMode = False
        Cfg = False
    End Sub

    Public Shared Function GetSingleton() As propiedadesVentanas
        If (instancia Is Nothing) Then
            instancia = New propiedadesVentanas
        End If
        Return instancia
    End Function
    ''' <summary>
    ''' Subrutina encargada de cargar el logo principal del Login.
    ''' </summary>
    Public Function CargarLogo(IDLogo As FertspaLogo)
        logos(0) = My.Resources.Images.logofertspa
        logos(1) = My.Resources.Images.logitaskTransportista
        logos(2) = My.Resources.Images.logitaskDriver
        logos(3) = My.Resources.Images.logitaskTransportadora
        logos(4) = My.Resources.Images.logitaskOperador
        logos(5) = My.Resources.Images.logitaskOperator
        logos(6) = My.Resources.Images.logitaskAdmin
        Return logos(IDLogo)
    End Function

    ''' <summary>
    ''' Enum encargado de dar un ID de Logo. (Los que se repiten es porque ya existen en el idioma restante)
    ''' Orden: 1.Español, 2.Inglés, 3.Portugués
    ''' </summary>>
    Public Enum FertspaLogo
        LogoStudios = 0
        LogoTransportista = 1
        LogoDriver = 2
        LogoTransportadora = 3
        LogoOperador = 4
        LogoOperator = 5
        LogoAdmin = 6
    End Enum
    ''' <summary>
    ''' Subrutina encargada de cargar ventanas interiormente al panel enviado por parámetros.
    ''' </summary>
    ''' <param name="ventana">Panel al que se le cargará la ventana.</param>
    ''' <param name="formInterno">Ventana interna que se cargará en ventana.</param>
    Public Sub CargarVentana(ventana As Panel, formInterno As Form)
        ventana.Controls.Clear() 'Borra todo el contenido de la lista de controles del panel.
        formInterno.TopLevel = False 'Evita que la ventana se muestre como control de nivel superior, ya que no es soportado por un panel.
        formInterno.Dock = DockStyle.Fill 'Ancla el form interno al panel para que cuando se cambie el tamaño de la ventana, éste cambie dinámicamente junto al nuevo tamaño.
        formInterno.Size = ventana.Size 'Setea el tamaño de la ventana que se va a cargar, al tamaño del panel.
        ventana.Controls.Add(formInterno) 'Luego de que el form cumple con los requisitos del panel, se agrega el mismo al panel.
        formInterno.Show() 'Muestra el control interno.
    End Sub

    Public Function DecodificarImagen(dato As Byte()) As Bitmap
        Try
            Dim secuenciaDeBytes As New IO.MemoryStream(dato)
            Dim imagen As New Bitmap(secuenciaDeBytes)
            secuenciaDeBytes.Close()
            Return imagen
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ImagenToBytes(imagen As Bitmap) As Byte() 'PASAR A FUNCIONES ESPECÍFICAS, EN LÓGICA.
        Try
            Dim array As Byte()
            Dim secuenciaDeBytes As New System.IO.MemoryStream
            imagen.Save(secuenciaDeBytes, imagen.RawFormat)
            array = secuenciaDeBytes.ToArray
            secuenciaDeBytes.Close()
            Return array
        Catch ex As Exception
            Dim nullByte(0) As Byte
            Return nullByte
        End Try
    End Function

    Public Sub SizeTextoGeneral(controles As Control.ControlCollection, Optional excepcion As Object = vbNull)
        Dim fuente As New Font("Segoe UI Light", textoSize, FontStyle.Regular)
        For Each var As Control In controles
            If var IsNot excepcion Then
                var.Font = fuente
            End If
        Next
    End Sub

    Public Sub OcultarControles(controles As Control.ControlCollection, excepcion As Object)
        For Each var In controles
            If var IsNot excepcion Then
                var.Hide()
            End If
        Next
    End Sub

    Public Sub MostrarControles(controles As Control.ControlCollection, excepcion As Object)
        For Each var In controles
            If var IsNot excepcion Then
                var.Show()
            End If
        Next
    End Sub

    Public Property CancelarInspeccion() As Boolean
        Get
            Return cancelarInspec
        End Get
        Set(value As Boolean)
            cancelarInspec = value
        End Set
    End Property

    Public Property TextoSizeGral() As Single
        Get
            Return textoSize
        End Get
        Set(ByVal value As Single)
            textoSize = value
        End Set
    End Property

    Public Property CheckConfig() As Boolean 'Chequea si hubo cambio en configuraciones al aplicar cambios
        Get
            Return Cfg
        End Get
        Set(ByVal value As Boolean)
            Cfg = value
        End Set
    End Property

    Public Property ModoNocturno() As Boolean
        Get
            Return NightMode
        End Get
        Set(ByVal value As Boolean)
            NightMode = value
        End Set
    End Property

    Public Function ColorBackBotones() As Color
        If NightMode Then
            Return Color.FromArgb(65, 65, 66)
        End If
        Return Color.Silver
    End Function

    Public Function ColorTextoInput() As Color
        If NightMode Then
            Return Color.LightGray
        End If
        Return Color.DarkGray
    End Function

    Public Function ColorForeBotones() As Color
        If NightMode Then
            Return Color.White
        End If
        Return Color.Black
    End Function

    Public Function ColorFondo() As Color
        If NightMode Then
            Return Color.FromArgb(15, 15, 16)
        End If
        Return Color.White
    End Function

    Public Function ColorPanelesMenu() As Color
        If NightMode Then
            Return Color.FromArgb(40, 40, 41)
        End If
        Return Color.Gainsboro
    End Function

    Public Function ColorForeLabels() As Color
        If NightMode Then
            Return Color.White
        End If
        Return Color.Black
    End Function

    Public Function ColorBackTextbox() As Color
        If NightMode Then
            Return Color.FromArgb(55, 55, 56)
        End If
        Return Color.White
    End Function

    Public Function CfgLogo() As Image
        If NightMode Then
            Return My.Resources.Images.cfgLogoWhite
        End If
        Return My.Resources.Images.cfgLogoBlack
    End Function

    Public Function FuenteTitulos() As Font
        Return New Font("Segoe UI Semilight", propiedadesVentanas.GetSingleton.TextoSizeGral + 2, FontStyle.Regular)
    End Function

    Public Function FuenteSubTitulo() As Font
        Return New Font("Segoe UI Light", propiedadesVentanas.GetSingleton.TextoSizeGral, FontStyle.Regular)
    End Function

    Public Function FuenteEstandarBotones() As Font
        Return New Font("Segoe UI Light", 11, FontStyle.Regular)
    End Function

    Public Function SizeEstandarBotones() As Size
        Dim sizeBoton As Size
        sizeBoton.Height = 30
        sizeBoton.Width = 124
        Return sizeBoton
    End Function

	Public Function ConfigBoton()
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            ''traduce al ingles
            Dim menu As New WeakReference(New MenuVariable)
            menu.Target.Opcion(New configRed, My.Resources.EN_UK.ConfigBoton_configRed) 'Configuración de Red
            menu.Target.Opcion(New configGrafica, My.Resources.EN_UK.ConfigBoton_configGrafica) 'Configuración grafica
            menu.Target.Opcion(New configIdioma, My.Resources.EN_UK.ConfigBoton_lenguaje) 'Lenguaje
            menu.Target.Opcion(New acercaDe, My.Resources.EN_UK.ConfigBoton_acercaDe) 'Acerca De
            If DatosSesion.GetSingleton.UserLogged IsNot Nothing Then
                menu.Target.Opcion(New cambioPass, My.Resources.EN_UK.ConfigBoton_cambiarPass) 'Cambio de contraseña
            End If
            menu.Target.cambiarTitulo(My.Resources.EN_UK.ConfigBoton_configTitle) 'Configuración
            menu.Target.VentanaDefault(0)
            Return menu.Target
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            ''traduce al español
            Dim menu As New WeakReference(New MenuVariable)
            menu.Target.Opcion(New configRed, My.Resources.ES_LA.ConfigBoton_configRed) 'Configuración de Red
            menu.Target.Opcion(New configGrafica, My.Resources.ES_LA.ConfigBoton_configGrafica) 'Configuración grafica
            menu.Target.Opcion(New configIdioma, My.Resources.ES_LA.ConfigBoton_lenguaje) 'Lenguaje
            menu.Target.Opcion(New acercaDe, My.Resources.ES_LA.ConfigBoton_acercaDe) 'Acerca De
            If DatosSesion.GetSingleton.UserLogged IsNot Nothing Then
                menu.Target.Opcion(New cambioPass, My.Resources.ES_LA.ConfigBoton_cambiarPass) 'Cambio de contraseña
            End If
            menu.Target.cambiarTitulo(My.Resources.ES_LA.ConfigBoton_configTitle) 'Configuración
            menu.Target.VentanaDefault(0)
            Return menu.Target
        Else
            ''traduce al portugues
            Dim menu As New WeakReference(New MenuVariable)
            menu.Target.Opcion(New configRed, My.Resources.PT_BR.ConfigBoton_configRed) 'Configuración de Red
            menu.Target.Opcion(New configGrafica, My.Resources.PT_BR.ConfigBoton_configGrafica) 'Configuración grafica
            menu.Target.Opcion(New configIdioma, My.Resources.PT_BR.ConfigBoton_lenguaje) 'Lenguaje
            menu.Target.Opcion(New acercaDe, My.Resources.PT_BR.ConfigBoton_acercaDe) 'Acerca De
            If DatosSesion.GetSingleton.UserLogged IsNot Nothing Then
                menu.Target.Opcion(New cambioPass, My.Resources.PT_BR.ConfigBoton_cambiarPass) 'Cambio de contraseña
            End If
            menu.Target.cambiarTitulo(My.Resources.PT_BR.ConfigBoton_configTitle) 'Configuración
            menu.Target.VentanaDefault(0)
            Return menu.Target
        End If
    End Function

    Public Sub CambiarImagenTipo(control As PictureBox, tipo As String, color As String, cambiarImagen As Boolean, Optional label As Control = Nothing)
        Select Case tipo
            Case "A"
                control.Image = My.Resources.Images.autoEstandar
                If label IsNot Nothing Then
                    'AGREGAR CONFIG DE IDIOMAS
                    If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                        ''traduce al ingles
                        label.Text = My.Resources.EN_UK.CambiarImagenTipo_StandardCar
                    ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                        ''traduce al español
                        label.Text = My.Resources.ES_LA.CambiarImagenTipo_StandardCar
                    Else
                        ''traduce al portugues
                        label.Text = My.Resources.PT_BR.CambiarImagenTipo_StandardCar
                    End If
                    'label.Text = "Auto estándar"
                End If
            Case "C"
                control.Image = My.Resources.Images.camion
                If label IsNot Nothing Then
                    'AGREGAR CONFIG DE IDIOMAS
                    If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                        ''traduce al ingles
                        label.Text = My.Resources.EN_UK.CambiarImagenTipo_Truck
                    ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                        ''traduce al español
                        label.Text = My.Resources.ES_LA.CambiarImagenTipo_Truck
                    Else
                        ''traduce al portugues
                        label.Text = My.Resources.PT_BR.CambiarImagenTipo_Truck
                    End If
                    'label.Text = "Camión"
                End If
            Case "S"
                control.Image = My.Resources.Images.suv
                If label IsNot Nothing Then
                    'AGREGAR CONFIG DE IDIOMAS  
                    label.Text = "SUV"
                End If
            Case "V"
                control.Image = My.Resources.Images.van
                If label IsNot Nothing Then
                    'AGREGAR CONFIG DE IDIOMAS  
                    label.Text = "Van"
                End If
            Case "M"
                control.Image = My.Resources.Images.miniVan
                If label IsNot Nothing Then
                    'AGREGAR CONFIG DE IDIOMAS  
                    label.Text = "Minivan"
                End If
        End Select
        If cambiarImagen Then
            Dim instanciaFunciones As New FuncionesEspecificas
            instanciaFunciones.CambiarColor(control, color)
        End If
    End Sub

    Public Property VentanaVolver() As Form
        Get
            Return accionVolver
        End Get
        Set(value As Form)
            accionVolver = value
        End Set
    End Property

    Public Property CambioOpcionMenu() As Boolean
        Get
            Return menuOptionChanged
        End Get
        Set(value As Boolean)
            menuOptionChanged = value
        End Set
    End Property
End Class