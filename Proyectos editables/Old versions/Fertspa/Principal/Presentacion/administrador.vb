Public Class administrador

	Private Sub administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'Select usuario.nombreuser,nombre,apellido,tipoop
		'From usuario Join operario
		'On usuario.nombreuser = operario.nombreuser

	End Sub

	Private Sub tabOFF()
		For Each c As Control In TabPanel.Controls
			If TypeOf (c) Is Button Then
				c.Visible = False
			End If
		Next
	End Sub

	Private Sub displayOFF()
		For Each c As Control In Me.Controls
			If TypeOf (c) Is Panel Then
				c.Visible = False
			End If
		Next
		TabPanel.Visible = True
		topBarPanel.Visible = True
	End Sub
	Private Sub vehiculosButton_Click(sender As Object, e As EventArgs) Handles vehiculosButton.Click
		displayOFF()
		vehiculosPanel.Visible = True
	End Sub

	Private Sub atrasButton_Click(sender As Object, e As EventArgs) Handles atrasButton.Click
		displayOFF()
	End Sub

	Private Sub actualizarVerVehiculo_Click(sender As Object, e As EventArgs) Handles actualizarVerVehiculo.Click

	End Sub

	Private Sub modificarButton_Click(sender As Object, e As EventArgs) Handles modificarVehiculoButton.Click
		modificarAutoPanel.Visible = True
	End Sub

	Private Sub agregarVehiculoButton_Click(sender As Object, e As EventArgs) Handles agregarVehiculoButton.Click
		ingresarVehiculoPanel.Visible = True
	End Sub

	Private Sub eliminarVehiculoButton_Click(sender As Object, e As EventArgs) Handles eliminarVehiculoButton.Click

	End Sub

	Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click

	End Sub

	Private Sub agregarUsuarioButton_Click(sender As Object, e As EventArgs) Handles agregarUsuarioButton.Click
		agregarUsuarioPanel.Visible = True
	End Sub

	Private Sub modificarSubZonaButton_Click(sender As Object, e As EventArgs) Handles modificarSubZonaButton.Click
		modificarSubZonaPanel.Visible = True
	End Sub

	Private Sub lotesButton_Click(sender As Object, e As EventArgs) Handles lotesButton.Click
		displayOFF()
		lotesPanel.Visible = True
	End Sub

	Private Sub viajesButton_Click(sender As Object, e As EventArgs) Handles viajesButton.Click
		viajesPanel.Visible = True
	End Sub

	Private Sub zonasButton_Click(sender As Object, e As EventArgs) Handles zonasButton.Click
		zonasPanel.Visible = True
	End Sub

	Private Sub usuariosButton_Click(sender As Object, e As EventArgs) Handles usuariosButton.Click
		usuariosPanel.Visible = True
	End Sub

	Private Sub inspeccionesButton_Click(sender As Object, e As EventArgs) Handles inspeccionesButton.Click
		inspeccionesPanel.Visible = True
	End Sub
End Class