Imports LibreriaGrafica
''' <summary>
''' Clase encargada de instanciar las librerías y clases correspondientes del conjunto Logitask.
''' </summary>
Public Class Main
    ''' <summary>
    ''' Subrutina encargada de inicializar una instancia de la clase,
    ''' en conjunto con las diferentes instancias correspondientes de las demás librerías..
    ''' </summary>
    Public Sub New()
        InitializeComponent()
        Dim Login As New LoginVariable()
        Login.CambiarLogo(propiedadesVentanas.FertspaLogo.LogoAdmin)
        propiedadesVentanas.GetSingleton.CargarVentana(ventana, Login)
    End Sub

    Private Sub Finalizar() Handles ventana.ControlRemoved
        End
    End Sub
End Class
