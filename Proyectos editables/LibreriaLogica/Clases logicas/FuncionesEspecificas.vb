Imports System.Windows.Forms
Imports System.Drawing
Imports System.Text
Imports MessagingToolkit
Public Class FuncionesEspecificas
    Implements IDisposable

    Public Sub CalcularIntervaloFecha(ByRef lbl As Label, momento As Date)
        Dim year As Int32 = CType(DateDiff(DateInterval.Year, momento, Now), Int64) 'Recordar el cambio de dato en x86
        If year = 0 Then
            Dim mes As Int16 = CType(DateDiff(DateInterval.Month, momento, Now), Int16)
            If mes = 0 Then
                Dim dia As Int16 = CType(DateDiff(DateInterval.Day, momento, Now), Int16)
                If dia = 0 Then
                    Dim hora As Int16 = CType(DateDiff(DateInterval.Hour, momento, Now), Int16)
                    If hora = 0 Then
                        Dim minuto As Int16 = CType(DateDiff(DateInterval.Minute, momento, Now), Int16)
                        If minuto = 0 Then
                            lbl.Text = "Hace menos de 1m" 'PASAR A RECURSOS DE IDIOMA
                        Else
                            lbl.Text = "Hace " + minuto.ToString + "m"
                        End If
                    Else
                        lbl.Text = "Hace " + hora.ToString + "h"
                    End If
                Else
                    lbl.Text = "Hace " + dia.ToString + "d"
                End If
            Else
                lbl.Text = "Hace " + mes.ToString + " mes(es)"
            End If
        Else
            lbl.Text = "Hace " + year.ToString + " año(s)"
        End If
    End Sub

    Public Function GenerarVinQR(vin As String) As Bitmap
        Dim generador As New QRCode.Codec.QRCodeEncoder
        generador.QRCodeBackgroundColor = Drawing.Color.Transparent
        generador.QRCodeVersion = 3
        generador.QRCodeErrorCorrect = QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION.H
        Return generador.Encode(vin, Encoding.ASCII)
    End Function

    Public Function GenerarUrlQR(url As String) As Bitmap
        Dim generador As New QRCode.Codec.QRCodeEncoder
        generador.QRCodeBackgroundColor = Drawing.Color.Transparent
        generador.QRCodeVersion = 4
        generador.QRCodeErrorCorrect = QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION.H
        Return generador.Encode(url, Encoding.ASCII)
    End Function

    Public Function GenerarLoteQR(idlote As String) As Bitmap
        Dim generador As New QRCode.Codec.QRCodeEncoder
        generador.QRCodeBackgroundColor = Drawing.Color.Transparent
        generador.QRCodeVersion = 1
        generador.QRCodeErrorCorrect = QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION.H
        Return generador.Encode(idlote, Encoding.ASCII)
    End Function

    Public Function DecodeQR(imagen As Drawing.Bitmap) As String
        Dim decoder As New QRCode.Codec.QRCodeDecoder
        Return decoder.decode(New QRCode.Codec.Data.QRCodeBitmapImage(imagen))
    End Function

    Public Sub CambiarColor(ByRef control As PictureBox, color As String)
        Select Case color
#Region "Spanish"
            Case "negro"
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromArgb(0, 0, 0))
            Case "blanco"
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromArgb(247, 247, 247))
            Case "plata"
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromArgb(194, 194, 194))
            Case "gris"
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromArgb(138, 138, 138))
            Case "azul"
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromArgb(0, 0, 125))
            Case "rojo"
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromArgb(125, 0, 0))
            Case "beige"
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromArgb(237, 237, 213))
            Case "amarillo"
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromArgb(235, 212, 12))
            Case "dorado"
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromArgb(235, 212, 12))
            Case "oro"
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromArgb(235, 212, 12))
            Case "verde"
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromArgb(0, 100, 0))
            Case "violeta"
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromArgb(84, 0, 122))
            Case "naranja"
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromArgb(204, 112, 0))
#End Region
#Region "Portugues"
            Case "preto"
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromArgb(0, 0, 0))
            Case "branco"
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromArgb(247, 247, 247))
            Case "prateado"
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromArgb(194, 194, 194))
            Case "cinza"
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromArgb(138, 138, 138))
            Case "vermelho"
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromArgb(125, 0, 0))
            Case "bege"
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromArgb(237, 237, 213))
            Case "amarelo"
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromArgb(235, 212, 12))
            Case "dourado"
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromArgb(235, 212, 12))
            Case "roxo"
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromArgb(84, 0, 122))
            Case "laranja"
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromArgb(204, 112, 0))
#End Region
            Case Else
                control.Image = CambiarColorBitmap(New Bitmap(control.Image), Drawing.Color.FromName(color))
        End Select
    End Sub

    Public Function CambiarColorBitmap(imagen As Drawing.Bitmap, color As Drawing.Color)
        Dim imagenProcesada As Drawing.Bitmap
        imagenProcesada = imagen
        Dim r, g, b, a As Byte
        For x As Integer = 0 To imagenProcesada.Width - 1
            For y = 0 To imagenProcesada.Height - 1
                r = imagenProcesada.GetPixel(x, y).R
                g = imagenProcesada.GetPixel(x, y).G
                b = imagenProcesada.GetPixel(x, y).B
                a = imagenProcesada.GetPixel(x, y).A
                If r < 10 And g < 10 And b < 10 And a > 0 Then
                    imagenProcesada.SetPixel(x, y, color)
                End If
            Next
        Next
        Return imagenProcesada
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        Me.Finalize()
    End Sub
End Class
