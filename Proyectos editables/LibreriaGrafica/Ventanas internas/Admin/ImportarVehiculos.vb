Imports LibreriaLogica
Imports System.Windows.Forms
Public Class ImportarVehiculos
    Private tablaCsv As DataTable
    Private vehiculoRepetido As Boolean

    Private Sub ImportarVehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		OpcGraficas()
		traducirControles()
	End Sub

    Private Sub btn_cargar_Click(sender As Object, e As EventArgs) Handles btn_cargar.Click
        Try
            ventanaVehiculos.Controls.Clear()
            tablaCsv = EntradaSalida.GetSingleton.CargarCSV
            lbl_ruta.Text = EntradaSalida.GetSingleton.RutaActual
            CargarPanel()
        Catch ex As Exception
            MsgBox("Error: " + My.Resources.ErrorCodes.ErrorImportarVehiculos)

        End Try
    End Sub

    Private Sub CargarPanel()
        Try
            For Each fila As DataRow In tablaCsv.Rows
                Dim tile As New TileVehiculo(fila, TileVehiculo.TileActionOnClick.detalles)
                tile.TopLevel = False
                tile.CambioImagen()
                If Not VerificarExistencia() Then
                    ventanaVehiculos.Controls.Add(tile)
                    tile.Show()
                Else
                    vehiculoRepetido = True
                End If
            Next
            If vehiculoRepetido Then
                If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
                    MsgBox(My.Resources.EN_UK.ImportarVehiculos_Error_duplicados_en_BBDD)
                ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
                    MsgBox(My.Resources.ES_LA.ImportarVehiculos_Error_duplicados_en_BBDD)
                Else
                    ''Portugues
                    MsgBox(My.Resources.PT_BR.ImportarVehiculos_Error_duplicados_en_BBDD)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: " + My.Resources.ErrorCodes.ErrorCsv)
        End Try
    End Sub

    Private Function VerificarExistencia() As Boolean
        Return False
    End Function

	Private Sub OpcGraficas()
		Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
		btn_cargar.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
		btn_cargar.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
		btn_cargarBD.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
		btn_cargarBD.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
	End Sub

	Private Sub traducirControles()
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            ''traduce al ingles
            btn_cargar.Text = My.Resources.EN_UK.ImportarVehiculos_btn_cargar
            btn_cargarBD.Text = My.Resources.EN_UK.ImportarVehiculos_btn_cargarBD
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            ''traduce al español
            btn_cargar.Text = My.Resources.ES_LA.ImportarVehiculos_btn_cargar
            btn_cargarBD.Text = My.Resources.ES_LA.ImportarVehiculos_btn_cargarBD
        Else
            ''traduce al portugues
            btn_cargar.Text = My.Resources.PT_BR.ImportarVehiculos_btn_cargar
			btn_cargarBD.Text = My.Resources.PT_BR.ImportarVehiculos_btn_cargarBD
		End If
	End Sub

    Private Sub btn_cargarBD_Click(sender As Object, e As EventArgs) Handles btn_cargarBD.Click
        For Each var As TileVehiculo In ventanaVehiculos.Controls
            Admin.GetSingleton.InsertarVehiculos(var.GetTupla)
        Next
    End Sub
End Class