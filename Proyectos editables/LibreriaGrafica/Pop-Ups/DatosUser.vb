Imports LibreriaLogica
Public Class DatosUser
    Private tupla As DataRow
    ''' <summary>
    ''' Constructor específico encargado de inicializar la instancia de la clase y tomar como parámetro una tupla conteniendo los datos del vehículo a mostrar los detalles.
    ''' </summary>
    ''' <param name="fila">Tupla conteniendo todos los datos del vehículo en cuestión.</param>
    Public Sub New(fila As DataRow)
        InitializeComponent()
        tupla = fila
        OpcGraficas()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

    End Sub
    'username 0, contraseña 1, NOMBRe 2, apellido 3
    Private Sub traducirControles()
        If Settings.GetSingleton.LangCFG = Settings.LangEnum.EN_UK Then
            ''traduce al ingles
            '  lbl_apellido.Text = My.Resources.EN_UK.DatosUser_lblApellido
            '  lbl_movil.Text = My.Resources.EN_UK.DatosUser_lbl
        ElseIf Settings.GetSingleton.LangCFG = Settings.LangEnum.ES_LA Then
            ''traduce al español

        Else
            ''traduce al portugues

        End If
    End Sub
    Private Sub OpcGraficas()
        Me.BackColor = propiedadesVentanas.GetSingleton.ColorFondo
        lbl_apellido.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        lbl_movil.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        lbl_newpass.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        lbl_nombre.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        lbl_telfijo.ForeColor = propiedadesVentanas.GetSingleton.ColorForeLabels
        btn_edit.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
        btn_edit.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
        btn_save.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
        btn_save.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
        btn_delete.BackColor = propiedadesVentanas.GetSingleton.ColorBackBotones
        btn_delete.ForeColor = propiedadesVentanas.GetSingleton.ColorForeBotones
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

    End Sub
End Class