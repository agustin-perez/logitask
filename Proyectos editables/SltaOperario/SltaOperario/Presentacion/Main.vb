Imports LibreriaGrafica
Imports LibreriaLogica
''' <summary>
''' Clase principal del ejecutable SliferOperators, encargada de cargar todas las librerías necesarias y ejecutarlas.
''' </summary>
Public Class Main
    ''' <summary>
    ''' Subrutina encargada de inicializar una instancia de la clase.
    ''' </summary>
    Public Sub New()
        InitializeComponent()
        Dim Login As New LoginVariable()
        Login.CambiarLogo(propiedadesVentanas.FertspaLogo.LogoOperador)
        propiedadesVentanas.GetSingleton.CargarVentana(ventana, Login)
    End Sub
End Class