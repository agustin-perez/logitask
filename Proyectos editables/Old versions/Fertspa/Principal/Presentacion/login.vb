Public Class login
	Dim trans As New usuario(12345678, 12345678, "Transportista")
	Dim opPuerto As New usuario(11111111, 12345678, "Operario Puerto")
	Dim opPatio As New usuario(22222222, 12345678, "Operario Patio")
	Public usuarios As New List(Of usuario)
	Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Datos.conectarDB()
		rRolFeedback.Text = "✖"
		rRolFeedback.ForeColor = Color.Red
		rCedulaFeedback.Text = "✖"
		rCedulaFeedback.ForeColor = Color.Red
		rNombreFeedback.Text = "✖"
		rNombreFeedback.ForeColor = Color.Red
		rApellidoFeedback.Text = "✖"
		rApellidoFeedback.ForeColor = Color.Red
		rContraFeedback.Text = "✖"
		rContraFeedback.ForeColor = Color.Red
		rContraFeedback.Visible = True
		iContraFeedback.Text = "✖"
		iContraFeedback.ForeColor = Color.Red
		iContraFeedback.Visible = True
	End Sub


	Private Sub ingresarButton_Click(sender As Object, e As EventArgs) Handles IngresarButton.Click
#Region "ingresar usuario Logica"
		'For Each element In usuarios
		'	If Convert.ToInt32(ingresarCedulaTextBox.Text) = element.cedula Then
		'		If ingresarContraTextBox.Text = element.contrasenia Then
		'			Dim rol As String
		'			rol = element.rol
		'			Select Case rol
		'				Case "Transportista"
		'					'transportista.Visible = True
		'					MsgBox("Bienvenido Transportista!!!")
		'					Me.Close()
		'					Exit For
		'				Case "Operario Patio"
		'					'operarioPatio.Visible = True
		'					MsgBox("Bienvenido operario del patio!!!")
		'					Me.Close()
		'					Exit For
		'				Case "Operario Puerto"
		'					operarioPuerto.Visible = True
		'					MsgBox("Bienvenido operario del puerto!!!")
		'					Me.Close()
		'					Exit For
		'			End Select
		'		Else
		'			MsgBox("Contraseña equivocada")
		'			Exit For
		'		End If
		'	Else
		'	End If
		'Next
#End Region
		If (iCedulaFeedback.Text = "✓" And iContraFeedback.Text = "✓") Then

			Dim cedula As String = iCedulaTextBox.Text.ToString()
			Dim contrasenia As String = iContraTextBox.Text.ToString()
			If cedula = "12345678" And contrasenia = "admin" Then
				Dim admin As New administrador
				admin.Show()
				MsgBox("Bienvenido Administrador")
				Datos.setUser(cedula)
				Me.Close()
			End If
			Datos.ingresarUsuario(cedula, contrasenia)

		Else
			MsgBox("Verifique los errores")
		End If
	End Sub

	Private Sub cedulaTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles rCedulaTextBox.KeyDown
		If e.KeyCode = Keys.Space Then 'suprime la tecla espacio en el campo de usuario
			e.SuppressKeyPress = True
		End If
	End Sub

	Private Sub contraTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles rContraTextBox.KeyDown
		If e.KeyCode = Keys.Space Then 'suprime la tecla espacio en el campo de contraseña
			e.SuppressKeyPress = True   'e es un parametro que se pasa y representa a la tecla que
			'esta presionada el SUPPRESSKEYPRESS hace lo que dice el nombre.
		End If
	End Sub

	Private Sub registrarButton_Click(sender As Object, e As EventArgs) Handles registrarButton.Click
		If rCedulaFeedback.Text = "✓" And rContraFeedback.Text = "✓" And rRolFeedback.Text = "✓" And
		rNombreFeedback.Text = "✓" And rApellidoFeedback.Text = "✓" Then
			'aca se declariaría un usuario como objeto con los datos obtenidos de lo que lleno el usuario
			Dim cedula As String = rCedulaTextBox.Text.ToString()
			Dim contrasenia As String = rContraTextBox.Text.ToString()
			Dim rol As String = rRolComboBox.SelectedItem.ToString()
			Dim nombre As String = rNombreTextBox.Text.ToString()
			Dim apellido As String = rApellidoTextBox.Text.ToString()
			Logica.registrarUsuario(cedula, contrasenia, rol, nombre, apellido)
#Region "Registrar usuario logico"
			'For Each element In usuarios
			'    If Convert.ToInt32(cedulaTextBox.Text) = element.cedula Then
			'        MsgBox("cedula ya usada")
			'        contraTextBox.Text = ""
			'        cedulaTextBox.Text = ""
			'        rolBox.SelectedItem = Nothing
			'        Exit For
			'    ElseIf cedulaTextBox.TextLength = 8 Then
			'        Dim ced As Integer
			'        Dim contra As String
			'        Dim rol As String
			'        ced = Convert.ToInt32(cedulaTextBox.Text)
			'        contra = contraTextBox.Text
			'        rol = rolBox.SelectedItem
			'        Dim usuario As New usuario(ced, contra, rol)
			'        usuarios.Add(usuario)
			'        MsgBox("usuario agregado correctamente")
			'        Exit For
			'    Else
			'        MsgBox("cantidad de digitos erronea")
			'    End If

			'Next
#End Region
		Else
			MsgBox("Verifique los errores")
		End If
	End Sub
	Private Sub usuarioTextBox_Enter(sender As Object, e As EventArgs) Handles rCedulaTextBox.Enter
		If rCedulaTextBox.Text = "Cedula" Then
			rCedulaTextBox.Text = ""
			rCedulaTextBox.ForeColor = Color.FromArgb(35, 35, 35)
		End If
		Me.AcceptButton = registrarButton
	End Sub

	Private Sub usuarioTextBox_Leave(sender As Object, e As EventArgs) Handles rCedulaTextBox.Leave
		If rCedulaTextBox.Text = "" Then
			rCedulaTextBox.Text = "Cedula"
			rCedulaTextBox.ForeColor = Color.Silver
		End If
	End Sub

	Private Sub contraTextBox_Enter(sender As Object, e As EventArgs) Handles rContraTextBox.Enter
		If rContraTextBox.Text = "Contraseña" Then
			rContraTextBox.PasswordChar = "•"
			rContraTextBox.Text = ""
			rContraTextBox.ForeColor = Color.FromArgb(35, 35, 35)
		End If
		Me.AcceptButton = registrarButton
	End Sub

	Private Sub contraTextBox_Leave(sender As Object, e As EventArgs) Handles rContraTextBox.Leave
		If rContraTextBox.Text = "" Or rContraTextBox.Text = "Contraseña" Then
			rContraTextBox.PasswordChar = Nothing
			rContraTextBox.Text = "Contraseña"
			rContraTextBox.ForeColor = Color.Silver
			rContraFeedback.Visible = True
			rContraFeedback.Text = "✖"
			rContraFeedback.ForeColor = Color.Red
		ElseIf rContraTextBox.TextLength >= 8 Then
			rContraFeedback.Visible = True
			rContraFeedback.ForeColor = Color.Green
			rContraFeedback.Text = "✓"

		End If

	End Sub

	Private Sub usuarioTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rCedulaTextBox.KeyPress

		'Pasa todas las letras y simbolos existentes a numeros

		'97 - 122 = letras simples
		'65 - 90  = letras mayusculas
		'48 - 57  = numeros


		If Asc(e.KeyChar) <> 8 Then 'si no es el char 8 (es un char especial) 
			If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'y no es un numero evaluando si es menor a 48 o mayor a 57
				e.Handled = True 'ignora el input y no aparece en pantalla
			End If
		End If
	End Sub

	Private Sub rolBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles rRolComboBox.SelectedValueChanged
		'el evento checkea que el valor de la lista haya cambiado y no se puede seleccionar uno vacio
		'asi que no hay forma de que quede vacio
		If rRolComboBox.SelectedItem <> Nothing Then
			rRolFeedback.Visible = True
			rRolFeedback.ForeColor = Color.Green
			rRolFeedback.Text = "✓"
		Else
			rRolFeedback.Visible = True
			rRolFeedback.ForeColor = Color.Red
			rRolFeedback.Text = "✖"
		End If
	End Sub

	Private Sub cedulaFeedback_MouseEnter(sender As Object, e As EventArgs) Handles rCedulaFeedback.MouseEnter
		If rCedulaFeedback.Text = "✓" Then
			registrarInfoLabel.ForeColor = Color.Green
			registrarInfoLabel.Text = "Correcto"
			registrarInfoLabel.Visible = True
		Else
			registrarInfoLabel.ForeColor = Color.Red
			registrarInfoLabel.Text = "Cantidad de digitos Erronea"
			registrarInfoLabel.Visible = True
		End If
	End Sub

	Private Sub cedulaFeedback_MouseLeave(sender As Object, e As EventArgs) Handles rCedulaFeedback.MouseLeave
		registrarInfoLabel.Visible = False
	End Sub

	Private Sub usuarioTextBox_TextChanged(sender As Object, e As EventArgs) Handles rCedulaTextBox.TextChanged
		If rCedulaTextBox.Text.Length = 8 Then
			rCedulaFeedback.Visible = True
			rCedulaFeedback.ForeColor = Color.Green
			rCedulaFeedback.Text = "✓"
		Else
			rCedulaFeedback.Visible = True
			rCedulaFeedback.ForeColor = Color.Red
			rCedulaFeedback.Text = "✖"
		End If
	End Sub

	Private Sub contraTextBox_TextChanged(sender As Object, e As EventArgs) Handles rContraTextBox.TextChanged
		If rContraTextBox.Text = "" Or rContraTextBox.TextLength < 8 Then
			rContraFeedback.Visible = True
			rContraFeedback.ForeColor = Color.Red
			rContraFeedback.Text = "✖"
		ElseIf rContraTextBox.Text = "Contraseña" Then
			rContraFeedback.Visible = True
			rContraFeedback.ForeColor = Color.Red
			rContraFeedback.Text = "✖"
		Else
			rContraFeedback.Visible = True
			rContraFeedback.ForeColor = Color.Green
			rContraFeedback.Text = "✓"
		End If
	End Sub

	Private Sub contraFeedback_MouseEnter(sender As Object, e As EventArgs) Handles rContraFeedback.MouseEnter
		If rContraFeedback.Text = "✓" Then
			registrarInfoLabel.ForeColor = Color.Green
			registrarInfoLabel.Text = "Correcto"
			registrarInfoLabel.Visible = True
		ElseIf rContraTextBox.Text = "" Then
			registrarInfoLabel.ForeColor = Color.Red
			registrarInfoLabel.Text = "Campo de contraseña vacio"
			registrarInfoLabel.Visible = True
		Else
			registrarInfoLabel.ForeColor = Color.Red
			registrarInfoLabel.Text = "8 Digitos mínimos"
			registrarInfoLabel.Visible = True
		End If
	End Sub

	Private Sub contraFeedback_MouseLeave(sender As Object, e As EventArgs) Handles rContraFeedback.MouseLeave
		registrarInfoLabel.Visible = False
	End Sub

	Private Sub ingresarCedulaTextBox_Enter(sender As Object, e As EventArgs) Handles iCedulaTextBox.Enter
		If iCedulaTextBox.Text = "Cedula" Then
			iCedulaTextBox.Text = ""
			iCedulaTextBox.ForeColor = Color.FromArgb(35, 35, 35)
		End If
		Me.AcceptButton = IngresarButton
	End Sub

	Private Sub ingresarCedulaTextBox_Leave(sender As Object, e As EventArgs) Handles iCedulaTextBox.Leave
		If iCedulaTextBox.Text = "" Then
			iCedulaTextBox.Text = "Cedula"
			iCedulaTextBox.ForeColor = Color.Silver
		End If
	End Sub

	Private Sub ingresarContraTextBox_Enter(sender As Object, e As EventArgs) Handles iContraTextBox.Enter
		If iContraTextBox.Text = "Contraseña" Then
			iContraTextBox.PasswordChar = "•"
			iContraTextBox.Text = ""
			iContraTextBox.ForeColor = Color.FromArgb(35, 35, 35)
		End If
		Me.AcceptButton = IngresarButton
	End Sub

	Private Sub ingresarContraTextBox_Leave(sender As Object, e As EventArgs) Handles iContraTextBox.Leave
		If iContraTextBox.Text = "" Or iContraTextBox.Text = "Contraseña" Then
			iContraTextBox.PasswordChar = Nothing
			iContraTextBox.Text = "Contraseña"
			iContraTextBox.ForeColor = Color.Silver
			iContraFeedback.Visible = True
			iContraFeedback.Text = "✖"
			iContraFeedback.ForeColor = Color.Red
		ElseIf iContraTextBox.TextLength >= 8 Then
			iContraFeedback.Visible = True
			iContraFeedback.ForeColor = Color.Green
			iContraFeedback.Text = "✓"

		End If
	End Sub

	Private Sub rolFeedback_MouseEnter(sender As Object, e As EventArgs) Handles rRolFeedback.MouseEnter
		If rRolFeedback.Text = "✖" Then
			registrarInfoLabel.Text = "Campo de rol no seleccionado"
		End If

	End Sub

	Private Sub rolFeedback_MouseLeave(sender As Object, e As EventArgs) Handles rRolFeedback.MouseLeave

	End Sub

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

	Private Sub nombreFeedback_MouseLeave(sender As Object, e As EventArgs) Handles rNombreFeedback.MouseLeave
		registrarInfoLabel.Visible = False
	End Sub

	Private Sub nombreFeedback_MouseEnter(sender As Object, e As EventArgs) Handles rNombreFeedback.MouseEnter
		If rNombreFeedback.Text = "✓" Then
			registrarInfoLabel.ForeColor = Color.Green
			registrarInfoLabel.Text = "Correcto"
			registrarInfoLabel.Visible = True
		ElseIf rNombreTextBox.Text = "Nombre" Then
			registrarInfoLabel.ForeColor = Color.Red
			registrarInfoLabel.Text = "'Nombre' no es valido"
			registrarInfoLabel.Visible = True
		ElseIf rNombreTextBox.Text = "" Then
			registrarInfoLabel.ForeColor = Color.Red
			registrarInfoLabel.Text = "Campo de nombre vacio"
			registrarInfoLabel.Visible = True
		End If
	End Sub

	Private Sub apellidoFeedback_MouseEnter(sender As Object, e As EventArgs) Handles rApellidoFeedback.MouseEnter
		If rApellidoFeedback.Text = "✓" Then
			registrarInfoLabel.ForeColor = Color.Green
			registrarInfoLabel.Text = "Correcto"
			registrarInfoLabel.Visible = True
		ElseIf rApellidoTextBox.Text = "Apellido" Then
			registrarInfoLabel.ForeColor = Color.Red
			registrarInfoLabel.Text = "'Apellido' no es valido"
			registrarInfoLabel.Visible = True
		ElseIf rApellidoTextBox.Text = "" Then
			registrarInfoLabel.ForeColor = Color.Red
			registrarInfoLabel.Text = "Campo de apellido vacio"
			registrarInfoLabel.Visible = True
		End If
	End Sub

	Private Sub apellidoFeedback_MouseLeave(sender As Object, e As EventArgs) Handles rApellidoFeedback.MouseLeave
		registrarInfoLabel.Visible = False
	End Sub

	Private Sub nombreTextBox_Enter(sender As Object, e As EventArgs) Handles rNombreTextBox.Enter
		If rNombreTextBox.Text = "Nombre" Then
			rNombreTextBox.Text = ""
			rNombreTextBox.ForeColor = Color.FromArgb(35, 35, 35)
		End If
		Me.AcceptButton = registrarButton
	End Sub

	Private Sub apellidoTextBox_Enter(sender As Object, e As EventArgs) Handles rApellidoTextBox.Enter
		If rApellidoTextBox.Text = "Apellido" Then
			rApellidoTextBox.Text = ""
			rApellidoTextBox.ForeColor = Color.FromArgb(35, 35, 35)
		End If
		Me.AcceptButton = registrarButton
	End Sub

	Private Sub nombreTextBox_Leave(sender As Object, e As EventArgs) Handles rNombreTextBox.Leave
		If rNombreTextBox.Text = "" Then
			rNombreTextBox.Text = "Nombre"
			rNombreTextBox.ForeColor = Color.Silver
		End If
		If rNombreTextBox.Text = "Nombre" Then
			rNombreFeedback.Visible = True
			rNombreFeedback.ForeColor = Color.Red
			rNombreFeedback.Text = "✖"
		End If
	End Sub

	Private Sub apellidoTextBox_Leave(sender As Object, e As EventArgs) Handles rApellidoTextBox.Leave
		If rApellidoTextBox.Text = "" Then
			rApellidoTextBox.Text = "Apellido"
			rApellidoTextBox.ForeColor = Color.Silver
		End If
		If rApellidoTextBox.Text = "Apellido" Then
			rApellidoFeedback.Visible = True
			rApellidoFeedback.ForeColor = Color.Red
			rApellidoFeedback.Text = "✖"
		End If
	End Sub

	Private Sub nombreTextBox_TextChanged(sender As Object, e As EventArgs) Handles rNombreTextBox.TextChanged
		If rNombreTextBox.Text <> "" Then
			rNombreFeedback.Visible = True
			rNombreFeedback.ForeColor = Color.Green
			rNombreFeedback.Text = "✓"
		ElseIf rNombreTextBox.Text = "Nombre" Then
			rNombreFeedback.Visible = True
			rNombreFeedback.ForeColor = Color.Red
			rNombreFeedback.Text = "✖"
		Else
			rNombreFeedback.Visible = True
			rNombreFeedback.ForeColor = Color.Red
			rNombreFeedback.Text = "✖"
		End If
	End Sub

	Private Sub apellidoTextBox_TextChanged(sender As Object, e As EventArgs) Handles rApellidoTextBox.TextChanged
		If rApellidoTextBox.Text <> "" Then
			rApellidoFeedback.Visible = True
			rApellidoFeedback.ForeColor = Color.Green
			rApellidoFeedback.Text = "✓"
		ElseIf rApellidoTextBox.Text = "Apellido" Then
			rApellidoFeedback.Visible = True
			rApellidoFeedback.ForeColor = Color.Red
			rApellidoFeedback.Text = "✖"
		Else
			rApellidoFeedback.Visible = True
			rApellidoFeedback.ForeColor = Color.Red
			rApellidoFeedback.Text = "✖"
		End If
	End Sub

	Private Sub nombreTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rNombreTextBox.KeyPress
		'Pasa todas las letras y simbolos existentes a numeros

		'97 - 122 = letras simples
		'65 - 90  = letras mayusculas
		'48 - 57  = numeros


		If Asc(e.KeyChar) <> 8 Then 'si no es el char 8 (es un char especial) 
			If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'y no es un numero evaluando si es menor a 48 o mayor a 57
			Else
				e.Handled = True
			End If
		End If
	End Sub

	Private Sub apellidoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rApellidoTextBox.KeyPress
		If Asc(e.KeyChar) <> 8 Then 'si no es el char 8 (es un char especial) 
			If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'y no es un numero evaluando si es menor a 48 o mayor a 57
			Else
				e.Handled = True
			End If
		End If
	End Sub

	Private Sub ingresarCedulaTextBox_TextChanged(sender As Object, e As EventArgs) Handles iCedulaTextBox.TextChanged
		If iCedulaTextBox.Text.Length = 8 Then
			iCedulaFeedback.Visible = True
			iCedulaFeedback.ForeColor = Color.Green
			iCedulaFeedback.Text = "✓"
		Else
			iCedulaFeedback.Visible = True
			iCedulaFeedback.ForeColor = Color.Red
			iCedulaFeedback.Text = "✖"
		End If
	End Sub

	Private Sub ingresarContraTextBox_TextChanged(sender As Object, e As EventArgs) Handles iContraTextBox.TextChanged
		If iContraTextBox.Text = "" Or iContraTextBox.TextLength < 8 Then
			iContraFeedback.Visible = True
			iContraFeedback.ForeColor = Color.Red
			iContraFeedback.Text = "✖"
		Else
			iContraFeedback.Visible = True
			iContraFeedback.ForeColor = Color.Green
			iContraFeedback.Text = "✓"
		End If
	End Sub

	Private Sub ingresarCedulaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles iCedulaTextBox.KeyPress
		'Pasa todas las letras y simbolos existentes a numeros

		'97 - 122 = letras simples
		'65 - 90  = letras mayusculas
		'48 - 57  = numeros


		If Asc(e.KeyChar) <> 8 Then 'si no es el char 8 (es un char especial) 
			If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'y no es un numero evaluando si es menor a 48 o mayor a 57
				e.Handled = True 'ignora el input y no aparece en pantalla
			End If
		End If
	End Sub

	Private Sub iContraFeedback_MouseEnter(sender As Object, e As EventArgs) Handles iContraFeedback.MouseEnter
		If iContraFeedback.Text = "✓" Then
			ingresarInfoLabel.ForeColor = Color.Green
			ingresarInfoLabel.Text = "Correcto"
			ingresarInfoLabel.Visible = True
		ElseIf iContraTextBox.Text = "" Then
			ingresarInfoLabel.ForeColor = Color.Red
			ingresarInfoLabel.Text = "Campo de contraseña vacio"
			ingresarInfoLabel.Visible = True
		Else
			ingresarInfoLabel.ForeColor = Color.Red
			ingresarInfoLabel.Text = "8 Digitos mínimos"
			ingresarInfoLabel.Visible = True
		End If
	End Sub

	Private Sub iContraFeedback_MouseLeave(sender As Object, e As EventArgs) Handles iContraFeedback.MouseLeave
		ingresarInfoLabel.Visible = False
	End Sub

	Private Sub iCedulaFeedback_MouseEnter(sender As Object, e As EventArgs) Handles iCedulaFeedback.MouseEnter
		If iCedulaFeedback.Text = "✓" Then
			ingresarInfoLabel.ForeColor = Color.Green
			ingresarInfoLabel.Text = "Correcto"
			ingresarInfoLabel.Visible = True
		ElseIf icedulaTextBox.Text = "" Then
			ingresarInfoLabel.ForeColor = Color.Red
			ingresarInfoLabel.Text = "Campo cedula vacio"
			ingresarInfoLabel.Visible = True
		Else
			ingresarInfoLabel.ForeColor = Color.Red
			ingresarInfoLabel.Text = "Cantidad de digitos Erronea"
			ingresarInfoLabel.Visible = True
		End If
	End Sub

	Private Sub iCedulaFeedback_MouseLeave(sender As Object, e As EventArgs) Handles iCedulaFeedback.MouseLeave
		ingresarInfoLabel.Visible = False
	End Sub

	Private Sub rRolComboBox_Enter(sender As Object, e As EventArgs) Handles rRolComboBox.Enter
		Me.AcceptButton = registrarButton
	End Sub

	Private Sub IngresarButton_MouseDown(sender As Object, e As MouseEventArgs) Handles IngresarButton.MouseDown
		IngresarButton.BackColor = Color.FromArgb(143, 141, 141)
	End Sub

	Private Sub registrarButton_MouseDown(sender As Object, e As MouseEventArgs) Handles registrarButton.MouseDown
		registrarButton.BackColor = Color.FromArgb(143, 141, 141)
	End Sub

	Private Sub IngresarButton_MouseUp(sender As Object, e As MouseEventArgs) Handles IngresarButton.MouseUp
		IngresarButton.BackColor = Color.White
	End Sub

	Private Sub registrarButton_MouseUp(sender As Object, e As MouseEventArgs) Handles registrarButton.MouseUp
		registrarButton.BackColor = Color.White
	End Sub
End Class
