Imports System.Drawing
Imports GMap.NET
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers
Public Class Mapa
    Private marcadorIcono As Bitmap = My.Resources.Images.marcadorMaps
    Private enTransporte As Boolean
    Private zoomInMax As Boolean
    Private zoomOutMax As Boolean

    Public Sub New()
        InitializeComponent()
        ventanaMapa.MapProvider = MapProviders.GoogleMapProvider.Instance
        GMaps.Instance.Mode = AccessMode.ServerOnly
        ventanaMapa.PolygonsEnabled = True
        ventanaMapa.RoutesEnabled = True
        ventanaMapa.CanDragMap = True
        ventanaMapa.Zoom = 18
        ventanaMapa.ShowCenter = False
    End Sub
    Public Sub SetCoordenadas(lat As Double, longitud As Double)
        Try
            ventanaMapa.Overlays.Clear()
            ventanaMapa.Position = New PointLatLng(lat, longitud)
            Dim capa = New GMapOverlay("Capa")
            Dim marcador = New GMarkerGoogle(ventanaMapa.Position, marcadorIcono)
            capa.Markers.Add(marcador)
            ventanaMapa.Overlays.Add(capa)
        Catch ex As Exception
        End Try
    End Sub
    Public Sub CentrarPorCoordenadas()
        Try
            ventanaMapa.Position = ventanaMapa.Overlays.Item(0).Markers.Item(0).Position
            ventanaMapa.Zoom = 18
            zoomInMax = False
            zoomOutMax = True
        Catch ex As Exception
        End Try
    End Sub

    Public Sub SetGPSIcon()
        enTransporte = True
        marcadorIcono = My.Resources.Images.marcadorGPS
    End Sub

    Public Sub Aumentar()
        If ventanaMapa.Zoom < 18Then
            ventanaMapa.Zoom += 1
            zoomInMax = True
        Else
            zoomInMax = False
        End If
    End Sub

    Public Sub Disminuir()
        If ventanaMapa.Zoom > 4 Then
            ventanaMapa.Zoom -= 1
            zoomOutMax = True
        Else
            zoomOutMax = False

        End If
    End Sub

    Public ReadOnly Property IsZoomMax() As Boolean
        Get
            Return zoomInMax
        End Get
    End Property

    Public ReadOnly Property IsZoomMinimum() As Boolean
        Get
            Return zoomOutMax
        End Get
    End Property
End Class