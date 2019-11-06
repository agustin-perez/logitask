Public Class transportista

	Dim isTransportando As Boolean = False

	Private Sub transportista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'       MyBase.ControlBox = False
		'      MyBase.Text = String.Empty


		Datos.conectarDB()
		poblarVerLote()
	End Sub

#Region " Mover la ventana "

	' Codigo para poder mover la ventana

	Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    topBarPanel.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    topBarPanel.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    topBarPanel.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub
#End Region

#Region " closeTab "
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Dim opcion As Integer = MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNoCancel)
        If opcion = DialogResult.No Or opcion = DialogResult.Cancel Then
            Return
        ElseIf opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub cerrar_MouseEnter(sender As Object, e As EventArgs) Handles cerrar.MouseEnter
        cerrar.ForeColor = Color.FromArgb(85, 85, 85) 'Animacion de botones
    End Sub

    Private Sub cerrar_MouseLeave(sender As Object, e As EventArgs) Handles cerrar.MouseLeave
        cerrar.ForeColor = Color.FromArgb(35, 35, 35) 'Animacion de botones
    End Sub
#End Region


	Private Sub viajeButton_Click(sender As Object, e As EventArgs) Handles viajeButton.Click 'oculta y muestra botones
		If isTransportando = False Then
			viajeButton.Visible = False
			atrasButton.Visible = True
			verViajesButton.Visible = False
			salirButton.Visible = False
			selecLotePanel.Visible = True
			procesoViajePanel.Visible = False
			poblarVerLote()
		Else
			viajeButton.Visible = False
			atrasButton.Visible = True
			verViajesButton.Visible = False
			salirButton.Visible = False
			selecLotePanel.Visible = False
			procesoViajePanel.Visible = True

		End If




	End Sub

	Private Sub salirButton_Click(sender As Object, e As EventArgs) Handles salirButton.Click
        Dim opcion As Integer = MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNoCancel)
        If opcion = DialogResult.No Or opcion = DialogResult.Cancel Then
            Return
        ElseIf opcion = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub atrasButton_Click(sender As Object, e As EventArgs) Handles atrasButton.Click 'oculta y muestra botones
        mainMenu() 'Esconde y muestra todos los botones necesarios para que se vea el menu principal 
        displayOFF() 'Esconde todo lo que se muestra en el display de la derecha (Donde van los paneles)
    End Sub

    Public Sub mainMenu()
        viajeButton.Visible = True
        verViajesButton.Visible = True
        'Lote button
        cLoteButton.Visible = False
        verLotesButton.Visible = False
        atrasButton.Visible = False
        '      infoLoteButton.Visible = False
        'registrarA button
        registrarVehiculoButton.Visible = False
        verVehiculoButton.Visible = False
        salirButton.Visible = True
        'Inspeccion button
        realizarInspeccionButton.Visible = False
        verInspeccionButton.Visible = False
        'menu 

        displayOFF()
    End Sub

    Public Sub displayOFF()
        selecLotePanel.Visible = False
		procesoViajePanel.Visible = False
		verViajesPanel.Visible = False
	End Sub

    Public Sub poblarVerLote()
		Datos.poblarVerLoteTransportista() 'Ver lote minimalista es similar a verLote excepto que muestra solo nombre y desc
		verLotesDGV.AutoResizeColumns() 'Fitea las columnas para que entre todo
    End Sub

	Private Sub iniciarViajeButton_Click(sender As Object, e As EventArgs) Handles iniciarViajeButton.Click
		If isTransportando = False Then
			Dim index As Integer
			Try
				index = verLotesDGV.CurrentCell.RowIndex
				Dim selectedrow As DataGridViewRow
				selectedrow = verLotesDGV.Rows(index)
				Dim result As Integer = MessageBox.Show("comenzar el viaje con el lote: " + selectedrow.Cells(0).Value.ToString(), "viaje", MessageBoxButtons.YesNoCancel)
				If result = DialogResult.Yes Then
					Dim loteATransportar As String = selectedrow.Cells(0).Value.ToString()
					MsgBox("viaje comenzado. dirijase al destino.")
					Logica.comenzarViaje(loteATransportar)
					'enviar fecha y hora de partida + user a la bd

					tiempoTranscurridoTimer.Start()
					tiempoTranscurridoLabel.Text = DateTime.Now
					nombreLoteLabel.Text = "Lote " + loteATransportar
					viajeButton.Visible = False
					atrasButton.Visible = True
					verViajesButton.Visible = False
					salirButton.Visible = False
					selecLotePanel.Visible = False
					procesoViajePanel.Visible = True
					isTransportando = True
				End If
			Catch ex As Exception
				MsgBox("columna no seleccionada")
			End Try
		End If
	End Sub

	Private Sub finalizarViajeButton_Click(sender As Object, e As EventArgs) Handles finalizarViajeButton.Click
		Dim fechallegada As DateTime
		fechallegada = DateTime.Now()
		Logica.finalizarViaje(fechallegada)
		' Setea el vehiculo como entregado
		isTransportando = False
		tiempoTranscurridoTimer.Stop()
		mainMenu()
	End Sub

	Private Sub tiempoTranscurridoTimer_Tick(sender As Object, e As EventArgs) Handles tiempoTranscurridoTimer.Tick
		tiempoTranscurridoLabel.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
	End Sub

	Private Sub verViajesButton_Click(sender As Object, e As EventArgs) Handles verViajesButton.Click
		Datos.poblarVerViajes()
		displayOFF()
		verViajesPanel.Visible = True
	End Sub
End Class