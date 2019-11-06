Imports System.Windows.Forms
Imports LibreriaLogica
Public Class MenuLotes
    Private cargado As Boolean
    Private accion As TileLote.TileActionOnClick

    Public Sub New(accionEnum As TileLote.TileActionOnClick)
        InitializeComponent()
        ventanaLotes.SuspendLayout()
        accion = accionEnum
        OpcGraficas()
		CargarLotes()
		traducirControles()
	End Sub

    Public Sub CargarLotes()
        Try
            Dim tabla = ConsultasDeLectura.GetSingleton.ListadoLotes
            For var As Short = 0 To tabla.Rows.Count - 1
                Dim tile As New TileLote(tabla.Rows.Item(var), accion)
                tile.TopLevel = False
                ventanaLotes.Controls.Add(tile)
                tile.Show()
            Next
            ventanaLotes.ResumeLayout()
            cargado = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LimpiarLotes()
        For var As Int32 = 0 To ventanaLotes.Controls.Count - 1
            ventanaLotes.Controls.Item(0).Dispose()
        Next
    End Sub

    Private Sub ReloadAction()
        ventanaLotes.SuspendLayout()
        LimpiarLotes()
        If ventanaLotes.Controls.Count = 0 Then
            CargarLotes()
        End If
        OpcGraficas()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        propiedadesVentanas.GetSingleton.CargarVentana(ventana, New NuevoLote)
        ventanaLotes.Hide()
        btn_add.Hide()
        btn_reload.Hide()
        btn_loteListo.Hide()
        cargado = False
    End Sub

    Private Sub Restablecer() Handles ventana.ControlRemoved
        ventanaLotes.Show()
        btn_add.Show()
        btn_reload.Show()
        btn_loteListo.Show()
        ReloadAction()
    End Sub

    Private Sub OpcGraficas()
        Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        ventanaLotes.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        lbl_title.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
    End Sub

	Private Sub btn_reload_Click(sender As Object, e As EventArgs) Handles btn_reload.Click
		ReloadAction()
		OpcGraficas()
	End Sub

	Private Sub traducirControles()
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            ''traduce al ingles
            lbl_title.Text = My.Resources.EN_UK.MenuLotes_lbltitle
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            ''traduce al español
            lbl_title.Text = My.Resources.ES_LA.MenuLotes_lbltitle
        Else
            ''traduce al portugues
            lbl_title.Text = My.Resources.PT_BR.MenuLotes_lbltitle
		End If
	End Sub
End Class