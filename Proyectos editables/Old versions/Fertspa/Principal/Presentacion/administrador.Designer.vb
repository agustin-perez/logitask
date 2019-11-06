<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class administrador
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer

	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar usando el Diseñador de Windows Forms.  
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(administrador))
		Me.topBarPanel = New System.Windows.Forms.Panel()
		Me.cerrar = New System.Windows.Forms.Label()
		Me.mainLabel = New System.Windows.Forms.Label()
		Me.TabPanel = New System.Windows.Forms.Panel()
		Me.inspeccionesButton = New System.Windows.Forms.Button()
		Me.usuariosButton = New System.Windows.Forms.Button()
		Me.zonasButton = New System.Windows.Forms.Button()
		Me.viajesButton = New System.Windows.Forms.Button()
		Me.vehiculosButton = New System.Windows.Forms.Button()
		Me.lotesButton = New System.Windows.Forms.Button()
		Me.atrasButton = New System.Windows.Forms.Button()
		Me.salirButton = New System.Windows.Forms.Button()
		Me.vehiculosPanel = New System.Windows.Forms.Panel()
		Me.ingresarVehiculoPanel = New System.Windows.Forms.Panel()
		Me.colorTextBox = New System.Windows.Forms.TextBox()
		Me.anioTextBox = New System.Windows.Forms.TextBox()
		Me.modeloTextBox = New System.Windows.Forms.TextBox()
		Me.marcaTextBox = New System.Windows.Forms.TextBox()
		Me.vinTextBox = New System.Windows.Forms.TextBox()
		Me.tipoComboBox = New System.Windows.Forms.ComboBox()
		Me.tipoLabel = New System.Windows.Forms.Label()
		Me.colorLabel = New System.Windows.Forms.Label()
		Me.anioLabel = New System.Windows.Forms.Label()
		Me.modeloLabel = New System.Windows.Forms.Label()
		Me.marcaLabel = New System.Windows.Forms.Label()
		Me.vinLabel = New System.Windows.Forms.Label()
		Me.modificarAutoPanel = New System.Windows.Forms.Panel()
		Me.colorMTextBox = New System.Windows.Forms.TextBox()
		Me.anioMTextBox = New System.Windows.Forms.TextBox()
		Me.modeloMTextBox = New System.Windows.Forms.TextBox()
		Me.marcaMTextBox = New System.Windows.Forms.TextBox()
		Me.vinMTextBox = New System.Windows.Forms.TextBox()
		Me.tipoMComboBox = New System.Windows.Forms.ComboBox()
		Me.tipoMLabel = New System.Windows.Forms.Label()
		Me.colorMLabel = New System.Windows.Forms.Label()
		Me.anioMLabel = New System.Windows.Forms.Label()
		Me.modeloMLabel = New System.Windows.Forms.Label()
		Me.marcaMLabel = New System.Windows.Forms.Label()
		Me.vinMLabel = New System.Windows.Forms.Label()
		Me.actualizarVerVehiculo = New System.Windows.Forms.Button()
		Me.BuscarButton = New System.Windows.Forms.Button()
		Me.ingresarVINLabel = New System.Windows.Forms.Label()
		Me.vinABuscarTextBox = New System.Windows.Forms.TextBox()
		Me.eliminarVehiculoButton = New System.Windows.Forms.Button()
		Me.agregarVehiculoButton = New System.Windows.Forms.Button()
		Me.modificarVehiculoButton = New System.Windows.Forms.Button()
		Me.verVehicuosDGV = New System.Windows.Forms.DataGridView()
		Me.vehiculosLabel = New System.Windows.Forms.Label()
		Me.lotesPanel = New System.Windows.Forms.Panel()
		Me.modificarLotesPanel = New System.Windows.Forms.Panel()
		Me.vehiculosInspeccionadosLabel = New System.Windows.Forms.Label()
		Me.vehiculosEnLoteLabel = New System.Windows.Forms.Label()
		Me.verVehiculosCInspeccionDGV = New System.Windows.Forms.DataGridView()
		Me.verVehiculosEnLoteDGV = New System.Windows.Forms.DataGridView()
		Me.agregarLotePanel = New System.Windows.Forms.Panel()
		Me.modificarLoteButton = New System.Windows.Forms.Button()
		Me.eliminarLoteButton = New System.Windows.Forms.Button()
		Me.agregarLoteButton = New System.Windows.Forms.Button()
		Me.lotesLabel = New System.Windows.Forms.Label()
		Me.verLotesLabel = New System.Windows.Forms.DataGridView()
		Me.viajesPanel = New System.Windows.Forms.Panel()
		Me.actualizarVerViajeButton = New System.Windows.Forms.Button()
		Me.modificarViajePanel = New System.Windows.Forms.Panel()
		Me.modificarViajeButton = New System.Windows.Forms.Button()
		Me.viajesLabel = New System.Windows.Forms.Label()
		Me.verViajesDGV = New System.Windows.Forms.DataGridView()
		Me.zonasPanel = New System.Windows.Forms.Panel()
		Me.modificarSubZonaPanel = New System.Windows.Forms.Panel()
		Me.modificarZonasPanel = New System.Windows.Forms.Panel()
		Me.agregarZonaPanel = New System.Windows.Forms.Panel()
		Me.modificarSubZonaButton = New System.Windows.Forms.Button()
		Me.eliminarZonaButton = New System.Windows.Forms.Button()
		Me.agregarZonaButton = New System.Windows.Forms.Button()
		Me.modificarZonaButton = New System.Windows.Forms.Button()
		Me.subZonasLabel = New System.Windows.Forms.Label()
		Me.zonaLabel = New System.Windows.Forms.Label()
		Me.zonasLabel = New System.Windows.Forms.Label()
		Me.verSubZonasDGV = New System.Windows.Forms.DataGridView()
		Me.verZonasDGV = New System.Windows.Forms.DataGridView()
		Me.usuariosPanel = New System.Windows.Forms.Panel()
		Me.agregarUsuarioPanel = New System.Windows.Forms.Panel()
		Me.rolComboBox = New System.Windows.Forms.ComboBox()
		Me.contraseniaLabel = New System.Windows.Forms.Label()
		Me.rolLabel = New System.Windows.Forms.Label()
		Me.apellidoLabel = New System.Windows.Forms.Label()
		Me.nombreLabel = New System.Windows.Forms.Label()
		Me.cedulaLabel = New System.Windows.Forms.Label()
		Me.contraseniaTextBox = New System.Windows.Forms.TextBox()
		Me.apellidoTextBox = New System.Windows.Forms.TextBox()
		Me.nombreTextBox = New System.Windows.Forms.TextBox()
		Me.cedulaTextBox = New System.Windows.Forms.TextBox()
		Me.modificarUsuarioPanel = New System.Windows.Forms.Panel()
		Me.rolMComboBox = New System.Windows.Forms.ComboBox()
		Me.contraseniaMLabel = New System.Windows.Forms.Label()
		Me.rolMLabel = New System.Windows.Forms.Label()
		Me.apellidoMLabel = New System.Windows.Forms.Label()
		Me.nombreMLabel = New System.Windows.Forms.Label()
		Me.cedulaMLabel = New System.Windows.Forms.Label()
		Me.contraseniaMTextBox = New System.Windows.Forms.TextBox()
		Me.apellidoMTextBox = New System.Windows.Forms.TextBox()
		Me.nombreMTextBox = New System.Windows.Forms.TextBox()
		Me.cedulaMTextBox = New System.Windows.Forms.TextBox()
		Me.modificarUsuariosButton = New System.Windows.Forms.Button()
		Me.agregarUsuarioButton = New System.Windows.Forms.Button()
		Me.eliminarUsuarioButton = New System.Windows.Forms.Button()
		Me.usuariosLabel = New System.Windows.Forms.Label()
		Me.verUsuariosDGV = New System.Windows.Forms.DataGridView()
		Me.inspeccionesPanel = New System.Windows.Forms.Panel()
		Me.agregarInspeccionPanel = New System.Windows.Forms.Panel()
		Me.eliminarInspeccionPanel = New System.Windows.Forms.Panel()
		Me.modificarInpseccionPanel = New System.Windows.Forms.Panel()
		Me.modificarInspeccionButton = New System.Windows.Forms.Button()
		Me.eliminarInspeccionButton = New System.Windows.Forms.Button()
		Me.agregarInspeccionButton = New System.Windows.Forms.Button()
		Me.verDañosPanel = New System.Windows.Forms.Panel()
		Me.numeroInspLabel = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.verSegundaInspeccion = New System.Windows.Forms.Button()
		Me.descDañoLabel = New System.Windows.Forms.Label()
		Me.inspeccionLabel = New System.Windows.Forms.Label()
		Me.evidenciaPictureBox = New System.Windows.Forms.PictureBox()
		Me.verDaniosButton = New System.Windows.Forms.Button()
		Me.inspeccionesLabel = New System.Windows.Forms.Label()
		Me.verInspeccionesDGV = New System.Windows.Forms.DataGridView()
		Me.topBarPanel.SuspendLayout()
		Me.TabPanel.SuspendLayout()
		Me.vehiculosPanel.SuspendLayout()
		Me.ingresarVehiculoPanel.SuspendLayout()
		Me.modificarAutoPanel.SuspendLayout()
		CType(Me.verVehicuosDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.lotesPanel.SuspendLayout()
		Me.modificarLotesPanel.SuspendLayout()
		CType(Me.verVehiculosCInspeccionDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.verVehiculosEnLoteDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.verLotesLabel, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.viajesPanel.SuspendLayout()
		CType(Me.verViajesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.zonasPanel.SuspendLayout()
		CType(Me.verSubZonasDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.verZonasDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.usuariosPanel.SuspendLayout()
		Me.agregarUsuarioPanel.SuspendLayout()
		Me.modificarUsuarioPanel.SuspendLayout()
		CType(Me.verUsuariosDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.inspeccionesPanel.SuspendLayout()
		Me.agregarInspeccionPanel.SuspendLayout()
		Me.eliminarInspeccionPanel.SuspendLayout()
		Me.verDañosPanel.SuspendLayout()
		CType(Me.evidenciaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.verInspeccionesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'topBarPanel
		'
		Me.topBarPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.topBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.topBarPanel.Controls.Add(Me.cerrar)
		Me.topBarPanel.Controls.Add(Me.mainLabel)
		Me.topBarPanel.Location = New System.Drawing.Point(-5, -3)
		Me.topBarPanel.Name = "topBarPanel"
		Me.topBarPanel.Size = New System.Drawing.Size(813, 36)
		Me.topBarPanel.TabIndex = 19
		'
		'cerrar
		'
		Me.cerrar.AutoSize = True
		Me.cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
		Me.cerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.cerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.cerrar.Location = New System.Drawing.Point(772, 0)
		Me.cerrar.Name = "cerrar"
		Me.cerrar.Size = New System.Drawing.Size(30, 31)
		Me.cerrar.TabIndex = 14
		Me.cerrar.Text = "×"
		'
		'mainLabel
		'
		Me.mainLabel.AutoSize = True
		Me.mainLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.mainLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.mainLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.mainLabel.Location = New System.Drawing.Point(12, 9)
		Me.mainLabel.Name = "mainLabel"
		Me.mainLabel.Size = New System.Drawing.Size(66, 15)
		Me.mainLabel.TabIndex = 2
		Me.mainLabel.Text = "Op. Patio"
		'
		'TabPanel
		'
		Me.TabPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.TabPanel.Controls.Add(Me.inspeccionesButton)
		Me.TabPanel.Controls.Add(Me.usuariosButton)
		Me.TabPanel.Controls.Add(Me.zonasButton)
		Me.TabPanel.Controls.Add(Me.viajesButton)
		Me.TabPanel.Controls.Add(Me.vehiculosButton)
		Me.TabPanel.Controls.Add(Me.lotesButton)
		Me.TabPanel.Controls.Add(Me.atrasButton)
		Me.TabPanel.Controls.Add(Me.salirButton)
		Me.TabPanel.Location = New System.Drawing.Point(-5, 30)
		Me.TabPanel.Name = "TabPanel"
		Me.TabPanel.Size = New System.Drawing.Size(170, 500)
		Me.TabPanel.TabIndex = 20
		'
		'inspeccionesButton
		'
		Me.inspeccionesButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.inspeccionesButton.FlatAppearance.BorderSize = 0
		Me.inspeccionesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.inspeccionesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.inspeccionesButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.inspeccionesButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.inspeccionesButton.Location = New System.Drawing.Point(5, 329)
		Me.inspeccionesButton.Name = "inspeccionesButton"
		Me.inspeccionesButton.Size = New System.Drawing.Size(166, 34)
		Me.inspeccionesButton.TabIndex = 18
		Me.inspeccionesButton.Text = "Inspecciones"
		Me.inspeccionesButton.UseVisualStyleBackColor = False
		'
		'usuariosButton
		'
		Me.usuariosButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.usuariosButton.FlatAppearance.BorderSize = 0
		Me.usuariosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.usuariosButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.usuariosButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.usuariosButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.usuariosButton.Location = New System.Drawing.Point(5, 273)
		Me.usuariosButton.Name = "usuariosButton"
		Me.usuariosButton.Size = New System.Drawing.Size(166, 34)
		Me.usuariosButton.TabIndex = 17
		Me.usuariosButton.Text = "Usuarios"
		Me.usuariosButton.UseVisualStyleBackColor = False
		'
		'zonasButton
		'
		Me.zonasButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.zonasButton.FlatAppearance.BorderSize = 0
		Me.zonasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.zonasButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.zonasButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.zonasButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.zonasButton.Location = New System.Drawing.Point(5, 215)
		Me.zonasButton.Name = "zonasButton"
		Me.zonasButton.Size = New System.Drawing.Size(166, 34)
		Me.zonasButton.TabIndex = 16
		Me.zonasButton.Text = "Zonas"
		Me.zonasButton.UseVisualStyleBackColor = False
		'
		'viajesButton
		'
		Me.viajesButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.viajesButton.FlatAppearance.BorderSize = 0
		Me.viajesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.viajesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.viajesButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.viajesButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.viajesButton.Location = New System.Drawing.Point(5, 157)
		Me.viajesButton.Name = "viajesButton"
		Me.viajesButton.Size = New System.Drawing.Size(166, 34)
		Me.viajesButton.TabIndex = 15
		Me.viajesButton.Text = "Viajes"
		Me.viajesButton.UseVisualStyleBackColor = False
		'
		'vehiculosButton
		'
		Me.vehiculosButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.vehiculosButton.FlatAppearance.BorderSize = 0
		Me.vehiculosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.vehiculosButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.vehiculosButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.vehiculosButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.vehiculosButton.Location = New System.Drawing.Point(5, 44)
		Me.vehiculosButton.Name = "vehiculosButton"
		Me.vehiculosButton.Size = New System.Drawing.Size(166, 34)
		Me.vehiculosButton.TabIndex = 1
		Me.vehiculosButton.Text = "Vehiculos"
		Me.vehiculosButton.UseVisualStyleBackColor = False
		'
		'lotesButton
		'
		Me.lotesButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.lotesButton.FlatAppearance.BorderSize = 0
		Me.lotesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lotesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.lotesButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.lotesButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.lotesButton.Location = New System.Drawing.Point(5, 100)
		Me.lotesButton.Name = "lotesButton"
		Me.lotesButton.Size = New System.Drawing.Size(166, 34)
		Me.lotesButton.TabIndex = 0
		Me.lotesButton.Text = "Lotes"
		Me.lotesButton.UseVisualStyleBackColor = False
		'
		'atrasButton
		'
		Me.atrasButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.atrasButton.FlatAppearance.BorderSize = 0
		Me.atrasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.atrasButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.atrasButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.atrasButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.atrasButton.Location = New System.Drawing.Point(5, 436)
		Me.atrasButton.Name = "atrasButton"
		Me.atrasButton.Size = New System.Drawing.Size(166, 34)
		Me.atrasButton.TabIndex = 6
		Me.atrasButton.Text = "Atras"
		Me.atrasButton.UseVisualStyleBackColor = False
		Me.atrasButton.Visible = False
		'
		'salirButton
		'
		Me.salirButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.salirButton.FlatAppearance.BorderSize = 0
		Me.salirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.salirButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.salirButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.salirButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.salirButton.Location = New System.Drawing.Point(5, 436)
		Me.salirButton.Name = "salirButton"
		Me.salirButton.Size = New System.Drawing.Size(166, 34)
		Me.salirButton.TabIndex = 14
		Me.salirButton.Text = "Salir"
		Me.salirButton.UseVisualStyleBackColor = False
		'
		'vehiculosPanel
		'
		Me.vehiculosPanel.Controls.Add(Me.ingresarVehiculoPanel)
		Me.vehiculosPanel.Controls.Add(Me.modificarAutoPanel)
		Me.vehiculosPanel.Controls.Add(Me.actualizarVerVehiculo)
		Me.vehiculosPanel.Controls.Add(Me.BuscarButton)
		Me.vehiculosPanel.Controls.Add(Me.ingresarVINLabel)
		Me.vehiculosPanel.Controls.Add(Me.vinABuscarTextBox)
		Me.vehiculosPanel.Controls.Add(Me.eliminarVehiculoButton)
		Me.vehiculosPanel.Controls.Add(Me.agregarVehiculoButton)
		Me.vehiculosPanel.Controls.Add(Me.modificarVehiculoButton)
		Me.vehiculosPanel.Controls.Add(Me.verVehicuosDGV)
		Me.vehiculosPanel.Controls.Add(Me.vehiculosLabel)
		Me.vehiculosPanel.Location = New System.Drawing.Point(172, 35)
		Me.vehiculosPanel.Name = "vehiculosPanel"
		Me.vehiculosPanel.Size = New System.Drawing.Size(616, 482)
		Me.vehiculosPanel.TabIndex = 25
		Me.vehiculosPanel.Visible = False
		'
		'ingresarVehiculoPanel
		'
		Me.ingresarVehiculoPanel.Controls.Add(Me.colorTextBox)
		Me.ingresarVehiculoPanel.Controls.Add(Me.anioTextBox)
		Me.ingresarVehiculoPanel.Controls.Add(Me.modeloTextBox)
		Me.ingresarVehiculoPanel.Controls.Add(Me.marcaTextBox)
		Me.ingresarVehiculoPanel.Controls.Add(Me.vinTextBox)
		Me.ingresarVehiculoPanel.Controls.Add(Me.tipoComboBox)
		Me.ingresarVehiculoPanel.Controls.Add(Me.tipoLabel)
		Me.ingresarVehiculoPanel.Controls.Add(Me.colorLabel)
		Me.ingresarVehiculoPanel.Controls.Add(Me.anioLabel)
		Me.ingresarVehiculoPanel.Controls.Add(Me.modeloLabel)
		Me.ingresarVehiculoPanel.Controls.Add(Me.marcaLabel)
		Me.ingresarVehiculoPanel.Controls.Add(Me.vinLabel)
		Me.ingresarVehiculoPanel.Location = New System.Drawing.Point(68, 384)
		Me.ingresarVehiculoPanel.Name = "ingresarVehiculoPanel"
		Me.ingresarVehiculoPanel.Size = New System.Drawing.Size(493, 95)
		Me.ingresarVehiculoPanel.TabIndex = 34
		'
		'colorTextBox
		'
		Me.colorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.colorTextBox.Location = New System.Drawing.Point(168, 63)
		Me.colorTextBox.MaxLength = 17
		Me.colorTextBox.Name = "colorTextBox"
		Me.colorTextBox.ShortcutsEnabled = False
		Me.colorTextBox.Size = New System.Drawing.Size(150, 20)
		Me.colorTextBox.TabIndex = 33
		'
		'anioTextBox
		'
		Me.anioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.anioTextBox.Location = New System.Drawing.Point(14, 63)
		Me.anioTextBox.MaxLength = 17
		Me.anioTextBox.Name = "anioTextBox"
		Me.anioTextBox.ShortcutsEnabled = False
		Me.anioTextBox.Size = New System.Drawing.Size(150, 20)
		Me.anioTextBox.TabIndex = 32
		'
		'modeloTextBox
		'
		Me.modeloTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.modeloTextBox.Location = New System.Drawing.Point(324, 20)
		Me.modeloTextBox.MaxLength = 17
		Me.modeloTextBox.Name = "modeloTextBox"
		Me.modeloTextBox.ShortcutsEnabled = False
		Me.modeloTextBox.Size = New System.Drawing.Size(150, 20)
		Me.modeloTextBox.TabIndex = 31
		'
		'marcaTextBox
		'
		Me.marcaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.marcaTextBox.Location = New System.Drawing.Point(168, 20)
		Me.marcaTextBox.MaxLength = 17
		Me.marcaTextBox.Name = "marcaTextBox"
		Me.marcaTextBox.ShortcutsEnabled = False
		Me.marcaTextBox.Size = New System.Drawing.Size(150, 20)
		Me.marcaTextBox.TabIndex = 30
		'
		'vinTextBox
		'
		Me.vinTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.vinTextBox.Location = New System.Drawing.Point(14, 20)
		Me.vinTextBox.MaxLength = 17
		Me.vinTextBox.Name = "vinTextBox"
		Me.vinTextBox.ShortcutsEnabled = False
		Me.vinTextBox.Size = New System.Drawing.Size(150, 20)
		Me.vinTextBox.TabIndex = 29
		'
		'tipoComboBox
		'
		Me.tipoComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
		Me.tipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.tipoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.tipoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.tipoComboBox.FormattingEnabled = True
		Me.tipoComboBox.Items.AddRange(New Object() {"Auto", "SUV", "Camión", "Van", "Minivan"})
		Me.tipoComboBox.Location = New System.Drawing.Point(327, 63)
		Me.tipoComboBox.Name = "tipoComboBox"
		Me.tipoComboBox.Size = New System.Drawing.Size(147, 21)
		Me.tipoComboBox.TabIndex = 24
		'
		'tipoLabel
		'
		Me.tipoLabel.AutoSize = True
		Me.tipoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
		Me.tipoLabel.Location = New System.Drawing.Point(324, 44)
		Me.tipoLabel.Name = "tipoLabel"
		Me.tipoLabel.Size = New System.Drawing.Size(36, 17)
		Me.tipoLabel.TabIndex = 23
		Me.tipoLabel.Text = "Tipo"
		'
		'colorLabel
		'
		Me.colorLabel.AutoSize = True
		Me.colorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
		Me.colorLabel.Location = New System.Drawing.Point(165, 43)
		Me.colorLabel.Name = "colorLabel"
		Me.colorLabel.Size = New System.Drawing.Size(41, 17)
		Me.colorLabel.TabIndex = 22
		Me.colorLabel.Text = "Color"
		'
		'anioLabel
		'
		Me.anioLabel.AutoSize = True
		Me.anioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
		Me.anioLabel.Location = New System.Drawing.Point(11, 43)
		Me.anioLabel.Name = "anioLabel"
		Me.anioLabel.Size = New System.Drawing.Size(36, 17)
		Me.anioLabel.TabIndex = 21
		Me.anioLabel.Text = "Anio"
		'
		'modeloLabel
		'
		Me.modeloLabel.AutoSize = True
		Me.modeloLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
		Me.modeloLabel.Location = New System.Drawing.Point(324, 0)
		Me.modeloLabel.Name = "modeloLabel"
		Me.modeloLabel.Size = New System.Drawing.Size(54, 17)
		Me.modeloLabel.TabIndex = 20
		Me.modeloLabel.Text = "Modelo"
		'
		'marcaLabel
		'
		Me.marcaLabel.AutoSize = True
		Me.marcaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
		Me.marcaLabel.Location = New System.Drawing.Point(165, 0)
		Me.marcaLabel.Name = "marcaLabel"
		Me.marcaLabel.Size = New System.Drawing.Size(47, 17)
		Me.marcaLabel.TabIndex = 19
		Me.marcaLabel.Text = "Marca"
		'
		'vinLabel
		'
		Me.vinLabel.AutoSize = True
		Me.vinLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
		Me.vinLabel.Location = New System.Drawing.Point(15, 0)
		Me.vinLabel.Name = "vinLabel"
		Me.vinLabel.Size = New System.Drawing.Size(30, 17)
		Me.vinLabel.TabIndex = 18
		Me.vinLabel.Text = "VIN"
		'
		'modificarAutoPanel
		'
		Me.modificarAutoPanel.Controls.Add(Me.colorMTextBox)
		Me.modificarAutoPanel.Controls.Add(Me.anioMTextBox)
		Me.modificarAutoPanel.Controls.Add(Me.modeloMTextBox)
		Me.modificarAutoPanel.Controls.Add(Me.marcaMTextBox)
		Me.modificarAutoPanel.Controls.Add(Me.vinMTextBox)
		Me.modificarAutoPanel.Controls.Add(Me.tipoMComboBox)
		Me.modificarAutoPanel.Controls.Add(Me.tipoMLabel)
		Me.modificarAutoPanel.Controls.Add(Me.colorMLabel)
		Me.modificarAutoPanel.Controls.Add(Me.anioMLabel)
		Me.modificarAutoPanel.Controls.Add(Me.modeloMLabel)
		Me.modificarAutoPanel.Controls.Add(Me.marcaMLabel)
		Me.modificarAutoPanel.Controls.Add(Me.vinMLabel)
		Me.modificarAutoPanel.Location = New System.Drawing.Point(68, 384)
		Me.modificarAutoPanel.Name = "modificarAutoPanel"
		Me.modificarAutoPanel.Size = New System.Drawing.Size(493, 95)
		Me.modificarAutoPanel.TabIndex = 35
		'
		'colorMTextBox
		'
		Me.colorMTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.colorMTextBox.Location = New System.Drawing.Point(168, 63)
		Me.colorMTextBox.MaxLength = 17
		Me.colorMTextBox.Name = "colorMTextBox"
		Me.colorMTextBox.ShortcutsEnabled = False
		Me.colorMTextBox.Size = New System.Drawing.Size(150, 20)
		Me.colorMTextBox.TabIndex = 33
		'
		'anioMTextBox
		'
		Me.anioMTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.anioMTextBox.Location = New System.Drawing.Point(14, 63)
		Me.anioMTextBox.MaxLength = 17
		Me.anioMTextBox.Name = "anioMTextBox"
		Me.anioMTextBox.ShortcutsEnabled = False
		Me.anioMTextBox.Size = New System.Drawing.Size(150, 20)
		Me.anioMTextBox.TabIndex = 32
		'
		'modeloMTextBox
		'
		Me.modeloMTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.modeloMTextBox.Location = New System.Drawing.Point(324, 20)
		Me.modeloMTextBox.MaxLength = 17
		Me.modeloMTextBox.Name = "modeloMTextBox"
		Me.modeloMTextBox.ShortcutsEnabled = False
		Me.modeloMTextBox.Size = New System.Drawing.Size(150, 20)
		Me.modeloMTextBox.TabIndex = 31
		'
		'marcaMTextBox
		'
		Me.marcaMTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.marcaMTextBox.Location = New System.Drawing.Point(168, 20)
		Me.marcaMTextBox.MaxLength = 17
		Me.marcaMTextBox.Name = "marcaMTextBox"
		Me.marcaMTextBox.ShortcutsEnabled = False
		Me.marcaMTextBox.Size = New System.Drawing.Size(150, 20)
		Me.marcaMTextBox.TabIndex = 30
		'
		'vinMTextBox
		'
		Me.vinMTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.vinMTextBox.Location = New System.Drawing.Point(14, 20)
		Me.vinMTextBox.MaxLength = 17
		Me.vinMTextBox.Name = "vinMTextBox"
		Me.vinMTextBox.ShortcutsEnabled = False
		Me.vinMTextBox.Size = New System.Drawing.Size(150, 20)
		Me.vinMTextBox.TabIndex = 29
		'
		'tipoMComboBox
		'
		Me.tipoMComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
		Me.tipoMComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.tipoMComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.tipoMComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.tipoMComboBox.FormattingEnabled = True
		Me.tipoMComboBox.Items.AddRange(New Object() {"Auto", "SUV", "Camión", "Van", "Minivan"})
		Me.tipoMComboBox.Location = New System.Drawing.Point(327, 63)
		Me.tipoMComboBox.Name = "tipoMComboBox"
		Me.tipoMComboBox.Size = New System.Drawing.Size(147, 21)
		Me.tipoMComboBox.TabIndex = 24
		'
		'tipoMLabel
		'
		Me.tipoMLabel.AutoSize = True
		Me.tipoMLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
		Me.tipoMLabel.Location = New System.Drawing.Point(324, 44)
		Me.tipoMLabel.Name = "tipoMLabel"
		Me.tipoMLabel.Size = New System.Drawing.Size(36, 17)
		Me.tipoMLabel.TabIndex = 23
		Me.tipoMLabel.Text = "Tipo"
		'
		'colorMLabel
		'
		Me.colorMLabel.AutoSize = True
		Me.colorMLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
		Me.colorMLabel.Location = New System.Drawing.Point(165, 43)
		Me.colorMLabel.Name = "colorMLabel"
		Me.colorMLabel.Size = New System.Drawing.Size(41, 17)
		Me.colorMLabel.TabIndex = 22
		Me.colorMLabel.Text = "Color"
		'
		'anioMLabel
		'
		Me.anioMLabel.AutoSize = True
		Me.anioMLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
		Me.anioMLabel.Location = New System.Drawing.Point(11, 43)
		Me.anioMLabel.Name = "anioMLabel"
		Me.anioMLabel.Size = New System.Drawing.Size(36, 17)
		Me.anioMLabel.TabIndex = 21
		Me.anioMLabel.Text = "Anio"
		'
		'modeloMLabel
		'
		Me.modeloMLabel.AutoSize = True
		Me.modeloMLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
		Me.modeloMLabel.Location = New System.Drawing.Point(324, 0)
		Me.modeloMLabel.Name = "modeloMLabel"
		Me.modeloMLabel.Size = New System.Drawing.Size(54, 17)
		Me.modeloMLabel.TabIndex = 20
		Me.modeloMLabel.Text = "Modelo"
		'
		'marcaMLabel
		'
		Me.marcaMLabel.AutoSize = True
		Me.marcaMLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
		Me.marcaMLabel.Location = New System.Drawing.Point(165, 0)
		Me.marcaMLabel.Name = "marcaMLabel"
		Me.marcaMLabel.Size = New System.Drawing.Size(47, 17)
		Me.marcaMLabel.TabIndex = 19
		Me.marcaMLabel.Text = "Marca"
		'
		'vinMLabel
		'
		Me.vinMLabel.AutoSize = True
		Me.vinMLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
		Me.vinMLabel.Location = New System.Drawing.Point(15, 0)
		Me.vinMLabel.Name = "vinMLabel"
		Me.vinMLabel.Size = New System.Drawing.Size(30, 17)
		Me.vinMLabel.TabIndex = 18
		Me.vinMLabel.Text = "VIN"
		'
		'actualizarVerVehiculo
		'
		Me.actualizarVerVehiculo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.actualizarVerVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.actualizarVerVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.actualizarVerVehiculo.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.actualizarVerVehiculo.Location = New System.Drawing.Point(137, 13)
		Me.actualizarVerVehiculo.Name = "actualizarVerVehiculo"
		Me.actualizarVerVehiculo.Size = New System.Drawing.Size(75, 23)
		Me.actualizarVerVehiculo.TabIndex = 28
		Me.actualizarVerVehiculo.Text = "Actualizar"
		Me.actualizarVerVehiculo.UseVisualStyleBackColor = True
		'
		'BuscarButton
		'
		Me.BuscarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.BuscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BuscarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.BuscarButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.BuscarButton.Location = New System.Drawing.Point(534, 14)
		Me.BuscarButton.Name = "BuscarButton"
		Me.BuscarButton.Size = New System.Drawing.Size(75, 23)
		Me.BuscarButton.TabIndex = 27
		Me.BuscarButton.Text = "Buscar"
		Me.BuscarButton.UseVisualStyleBackColor = True
		'
		'ingresarVINLabel
		'
		Me.ingresarVINLabel.AutoSize = True
		Me.ingresarVINLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.ingresarVINLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.ingresarVINLabel.Location = New System.Drawing.Point(307, 19)
		Me.ingresarVINLabel.Name = "ingresarVINLabel"
		Me.ingresarVINLabel.Size = New System.Drawing.Size(66, 13)
		Me.ingresarVINLabel.TabIndex = 26
		Me.ingresarVINLabel.Text = "Ingresar VIN"
		'
		'vinABuscarTextBox
		'
		Me.vinABuscarTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.vinABuscarTextBox.Location = New System.Drawing.Point(379, 16)
		Me.vinABuscarTextBox.MaxLength = 17
		Me.vinABuscarTextBox.Name = "vinABuscarTextBox"
		Me.vinABuscarTextBox.Size = New System.Drawing.Size(149, 20)
		Me.vinABuscarTextBox.TabIndex = 25
		'
		'eliminarVehiculoButton
		'
		Me.eliminarVehiculoButton.Enabled = False
		Me.eliminarVehiculoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.eliminarVehiculoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.eliminarVehiculoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.eliminarVehiculoButton.ForeColor = System.Drawing.Color.Black
		Me.eliminarVehiculoButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.eliminarVehiculoButton.Location = New System.Drawing.Point(96, 335)
		Me.eliminarVehiculoButton.Name = "eliminarVehiculoButton"
		Me.eliminarVehiculoButton.Size = New System.Drawing.Size(140, 36)
		Me.eliminarVehiculoButton.TabIndex = 11
		Me.eliminarVehiculoButton.Text = "Eliminar"
		Me.eliminarVehiculoButton.UseVisualStyleBackColor = True
		'
		'agregarVehiculoButton
		'
		Me.agregarVehiculoButton.Enabled = False
		Me.agregarVehiculoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.agregarVehiculoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.agregarVehiculoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.agregarVehiculoButton.ForeColor = System.Drawing.Color.Black
		Me.agregarVehiculoButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.agregarVehiculoButton.Location = New System.Drawing.Point(242, 335)
		Me.agregarVehiculoButton.Name = "agregarVehiculoButton"
		Me.agregarVehiculoButton.Size = New System.Drawing.Size(140, 36)
		Me.agregarVehiculoButton.TabIndex = 10
		Me.agregarVehiculoButton.Text = "Agregar"
		Me.agregarVehiculoButton.UseVisualStyleBackColor = True
		'
		'modificarVehiculoButton
		'
		Me.modificarVehiculoButton.Enabled = False
		Me.modificarVehiculoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.modificarVehiculoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.modificarVehiculoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.modificarVehiculoButton.ForeColor = System.Drawing.Color.Black
		Me.modificarVehiculoButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.modificarVehiculoButton.Location = New System.Drawing.Point(388, 335)
		Me.modificarVehiculoButton.Name = "modificarVehiculoButton"
		Me.modificarVehiculoButton.Size = New System.Drawing.Size(140, 36)
		Me.modificarVehiculoButton.TabIndex = 9
		Me.modificarVehiculoButton.Text = "Modificar"
		Me.modificarVehiculoButton.UseVisualStyleBackColor = True
		'
		'verVehicuosDGV
		'
		Me.verVehicuosDGV.AllowUserToAddRows = False
		Me.verVehicuosDGV.AllowUserToDeleteRows = False
		Me.verVehicuosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.verVehicuosDGV.Location = New System.Drawing.Point(3, 42)
		Me.verVehicuosDGV.Name = "verVehicuosDGV"
		Me.verVehicuosDGV.ReadOnly = True
		Me.verVehicuosDGV.Size = New System.Drawing.Size(610, 286)
		Me.verVehicuosDGV.TabIndex = 4
		'
		'vehiculosLabel
		'
		Me.vehiculosLabel.AutoSize = True
		Me.vehiculosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
		Me.vehiculosLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.vehiculosLabel.Location = New System.Drawing.Point(13, 8)
		Me.vehiculosLabel.Name = "vehiculosLabel"
		Me.vehiculosLabel.Size = New System.Drawing.Size(118, 29)
		Me.vehiculosLabel.TabIndex = 3
		Me.vehiculosLabel.Text = "Vehiculos"
		'
		'lotesPanel
		'
		Me.lotesPanel.Controls.Add(Me.modificarLotesPanel)
		Me.lotesPanel.Controls.Add(Me.agregarLotePanel)
		Me.lotesPanel.Controls.Add(Me.modificarLoteButton)
		Me.lotesPanel.Controls.Add(Me.eliminarLoteButton)
		Me.lotesPanel.Controls.Add(Me.agregarLoteButton)
		Me.lotesPanel.Controls.Add(Me.lotesLabel)
		Me.lotesPanel.Controls.Add(Me.verLotesLabel)
		Me.lotesPanel.Location = New System.Drawing.Point(172, 35)
		Me.lotesPanel.Name = "lotesPanel"
		Me.lotesPanel.Size = New System.Drawing.Size(616, 482)
		Me.lotesPanel.TabIndex = 35
		'
		'modificarLotesPanel
		'
		Me.modificarLotesPanel.Controls.Add(Me.vehiculosInspeccionadosLabel)
		Me.modificarLotesPanel.Controls.Add(Me.vehiculosEnLoteLabel)
		Me.modificarLotesPanel.Controls.Add(Me.verVehiculosCInspeccionDGV)
		Me.modificarLotesPanel.Controls.Add(Me.verVehiculosEnLoteDGV)
		Me.modificarLotesPanel.Location = New System.Drawing.Point(9, 43)
		Me.modificarLotesPanel.Name = "modificarLotesPanel"
		Me.modificarLotesPanel.Size = New System.Drawing.Size(592, 425)
		Me.modificarLotesPanel.TabIndex = 52
		'
		'vehiculosInspeccionadosLabel
		'
		Me.vehiculosInspeccionadosLabel.AutoSize = True
		Me.vehiculosInspeccionadosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.vehiculosInspeccionadosLabel.Location = New System.Drawing.Point(332, 38)
		Me.vehiculosInspeccionadosLabel.Name = "vehiculosInspeccionadosLabel"
		Me.vehiculosInspeccionadosLabel.Size = New System.Drawing.Size(155, 13)
		Me.vehiculosInspeccionadosLabel.TabIndex = 3
		Me.vehiculosInspeccionadosLabel.Text = "Vehiculos Inspeccionados"
		'
		'vehiculosEnLoteLabel
		'
		Me.vehiculosEnLoteLabel.AutoSize = True
		Me.vehiculosEnLoteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.vehiculosEnLoteLabel.Location = New System.Drawing.Point(22, 38)
		Me.vehiculosEnLoteLabel.Name = "vehiculosEnLoteLabel"
		Me.vehiculosEnLoteLabel.Size = New System.Drawing.Size(119, 13)
		Me.vehiculosEnLoteLabel.TabIndex = 2
		Me.vehiculosEnLoteLabel.Text = "Vehiculos en el lote"
		'
		'verVehiculosCInspeccionDGV
		'
		Me.verVehiculosCInspeccionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.verVehiculosCInspeccionDGV.Location = New System.Drawing.Point(332, 54)
		Me.verVehiculosCInspeccionDGV.Name = "verVehiculosCInspeccionDGV"
		Me.verVehiculosCInspeccionDGV.Size = New System.Drawing.Size(232, 331)
		Me.verVehiculosCInspeccionDGV.TabIndex = 1
		'
		'verVehiculosEnLoteDGV
		'
		Me.verVehiculosEnLoteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.verVehiculosEnLoteDGV.Location = New System.Drawing.Point(25, 54)
		Me.verVehiculosEnLoteDGV.Name = "verVehiculosEnLoteDGV"
		Me.verVehiculosEnLoteDGV.Size = New System.Drawing.Size(232, 331)
		Me.verVehiculosEnLoteDGV.TabIndex = 0
		'
		'agregarLotePanel
		'
		Me.agregarLotePanel.Location = New System.Drawing.Point(12, 293)
		Me.agregarLotePanel.Name = "agregarLotePanel"
		Me.agregarLotePanel.Size = New System.Drawing.Size(592, 174)
		Me.agregarLotePanel.TabIndex = 51
		'
		'modificarLoteButton
		'
		Me.modificarLoteButton.Enabled = False
		Me.modificarLoteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.modificarLoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.modificarLoteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.modificarLoteButton.ForeColor = System.Drawing.Color.Black
		Me.modificarLoteButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.modificarLoteButton.Location = New System.Drawing.Point(479, 178)
		Me.modificarLoteButton.Name = "modificarLoteButton"
		Me.modificarLoteButton.Size = New System.Drawing.Size(116, 36)
		Me.modificarLoteButton.TabIndex = 50
		Me.modificarLoteButton.Text = "Modificar"
		Me.modificarLoteButton.UseVisualStyleBackColor = True
		'
		'eliminarLoteButton
		'
		Me.eliminarLoteButton.Enabled = False
		Me.eliminarLoteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.eliminarLoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.eliminarLoteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.eliminarLoteButton.ForeColor = System.Drawing.Color.Black
		Me.eliminarLoteButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.eliminarLoteButton.Location = New System.Drawing.Point(479, 124)
		Me.eliminarLoteButton.Name = "eliminarLoteButton"
		Me.eliminarLoteButton.Size = New System.Drawing.Size(116, 36)
		Me.eliminarLoteButton.TabIndex = 49
		Me.eliminarLoteButton.Text = "Eliminar"
		Me.eliminarLoteButton.UseVisualStyleBackColor = True
		'
		'agregarLoteButton
		'
		Me.agregarLoteButton.Enabled = False
		Me.agregarLoteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.agregarLoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.agregarLoteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.agregarLoteButton.ForeColor = System.Drawing.Color.Black
		Me.agregarLoteButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.agregarLoteButton.Location = New System.Drawing.Point(479, 72)
		Me.agregarLoteButton.Name = "agregarLoteButton"
		Me.agregarLoteButton.Size = New System.Drawing.Size(116, 36)
		Me.agregarLoteButton.TabIndex = 48
		Me.agregarLoteButton.Text = "Agregar"
		Me.agregarLoteButton.UseVisualStyleBackColor = True
		'
		'lotesLabel
		'
		Me.lotesLabel.AutoSize = True
		Me.lotesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
		Me.lotesLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.lotesLabel.Location = New System.Drawing.Point(7, 7)
		Me.lotesLabel.Name = "lotesLabel"
		Me.lotesLabel.Size = New System.Drawing.Size(72, 29)
		Me.lotesLabel.TabIndex = 38
		Me.lotesLabel.Text = "Lotes"
		'
		'verLotesLabel
		'
		Me.verLotesLabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.verLotesLabel.Location = New System.Drawing.Point(12, 43)
		Me.verLotesLabel.Name = "verLotesLabel"
		Me.verLotesLabel.Size = New System.Drawing.Size(445, 217)
		Me.verLotesLabel.TabIndex = 0
		'
		'viajesPanel
		'
		Me.viajesPanel.Controls.Add(Me.actualizarVerViajeButton)
		Me.viajesPanel.Controls.Add(Me.modificarViajePanel)
		Me.viajesPanel.Controls.Add(Me.modificarViajeButton)
		Me.viajesPanel.Controls.Add(Me.viajesLabel)
		Me.viajesPanel.Controls.Add(Me.verViajesDGV)
		Me.viajesPanel.Location = New System.Drawing.Point(172, 35)
		Me.viajesPanel.Name = "viajesPanel"
		Me.viajesPanel.Size = New System.Drawing.Size(616, 482)
		Me.viajesPanel.TabIndex = 36
		'
		'actualizarVerViajeButton
		'
		Me.actualizarVerViajeButton.Enabled = False
		Me.actualizarVerViajeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.actualizarVerViajeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.actualizarVerViajeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.actualizarVerViajeButton.ForeColor = System.Drawing.Color.Black
		Me.actualizarVerViajeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.actualizarVerViajeButton.Location = New System.Drawing.Point(464, 4)
		Me.actualizarVerViajeButton.Name = "actualizarVerViajeButton"
		Me.actualizarVerViajeButton.Size = New System.Drawing.Size(64, 36)
		Me.actualizarVerViajeButton.TabIndex = 39
		Me.actualizarVerViajeButton.Text = "Actualizar"
		Me.actualizarVerViajeButton.UseVisualStyleBackColor = True
		'
		'modificarViajePanel
		'
		Me.modificarViajePanel.Location = New System.Drawing.Point(30, 335)
		Me.modificarViajePanel.Name = "modificarViajePanel"
		Me.modificarViajePanel.Size = New System.Drawing.Size(543, 129)
		Me.modificarViajePanel.TabIndex = 38
		'
		'modificarViajeButton
		'
		Me.modificarViajeButton.Enabled = False
		Me.modificarViajeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.modificarViajeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.modificarViajeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.modificarViajeButton.ForeColor = System.Drawing.Color.Black
		Me.modificarViajeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.modificarViajeButton.Location = New System.Drawing.Point(540, 278)
		Me.modificarViajeButton.Name = "modificarViajeButton"
		Me.modificarViajeButton.Size = New System.Drawing.Size(64, 36)
		Me.modificarViajeButton.TabIndex = 37
		Me.modificarViajeButton.Text = "Modificar"
		Me.modificarViajeButton.UseVisualStyleBackColor = True
		'
		'viajesLabel
		'
		Me.viajesLabel.AutoSize = True
		Me.viajesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
		Me.viajesLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.viajesLabel.Location = New System.Drawing.Point(7, 8)
		Me.viajesLabel.Name = "viajesLabel"
		Me.viajesLabel.Size = New System.Drawing.Size(79, 29)
		Me.viajesLabel.TabIndex = 36
		Me.viajesLabel.Text = "Viajes"
		'
		'verViajesDGV
		'
		Me.verViajesDGV.AllowUserToAddRows = False
		Me.verViajesDGV.AllowUserToDeleteRows = False
		Me.verViajesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.verViajesDGV.Location = New System.Drawing.Point(8, 43)
		Me.verViajesDGV.Name = "verViajesDGV"
		Me.verViajesDGV.ReadOnly = True
		Me.verViajesDGV.Size = New System.Drawing.Size(526, 271)
		Me.verViajesDGV.TabIndex = 6
		'
		'zonasPanel
		'
		Me.zonasPanel.Controls.Add(Me.modificarSubZonaPanel)
		Me.zonasPanel.Controls.Add(Me.modificarZonasPanel)
		Me.zonasPanel.Controls.Add(Me.agregarZonaPanel)
		Me.zonasPanel.Controls.Add(Me.modificarSubZonaButton)
		Me.zonasPanel.Controls.Add(Me.eliminarZonaButton)
		Me.zonasPanel.Controls.Add(Me.agregarZonaButton)
		Me.zonasPanel.Controls.Add(Me.modificarZonaButton)
		Me.zonasPanel.Controls.Add(Me.subZonasLabel)
		Me.zonasPanel.Controls.Add(Me.zonaLabel)
		Me.zonasPanel.Controls.Add(Me.zonasLabel)
		Me.zonasPanel.Controls.Add(Me.verSubZonasDGV)
		Me.zonasPanel.Controls.Add(Me.verZonasDGV)
		Me.zonasPanel.Location = New System.Drawing.Point(172, 35)
		Me.zonasPanel.Name = "zonasPanel"
		Me.zonasPanel.Size = New System.Drawing.Size(616, 482)
		Me.zonasPanel.TabIndex = 37
		'
		'modificarSubZonaPanel
		'
		Me.modificarSubZonaPanel.Location = New System.Drawing.Point(30, 339)
		Me.modificarSubZonaPanel.Name = "modificarSubZonaPanel"
		Me.modificarSubZonaPanel.Size = New System.Drawing.Size(543, 125)
		Me.modificarSubZonaPanel.TabIndex = 47
		'
		'modificarZonasPanel
		'
		Me.modificarZonasPanel.Location = New System.Drawing.Point(30, 339)
		Me.modificarZonasPanel.Name = "modificarZonasPanel"
		Me.modificarZonasPanel.Size = New System.Drawing.Size(543, 125)
		Me.modificarZonasPanel.TabIndex = 46
		'
		'agregarZonaPanel
		'
		Me.agregarZonaPanel.Location = New System.Drawing.Point(30, 339)
		Me.agregarZonaPanel.Name = "agregarZonaPanel"
		Me.agregarZonaPanel.Size = New System.Drawing.Size(543, 125)
		Me.agregarZonaPanel.TabIndex = 45
		'
		'modificarSubZonaButton
		'
		Me.modificarSubZonaButton.Enabled = False
		Me.modificarSubZonaButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.modificarSubZonaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.modificarSubZonaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.modificarSubZonaButton.ForeColor = System.Drawing.Color.Black
		Me.modificarSubZonaButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.modificarSubZonaButton.Location = New System.Drawing.Point(434, 293)
		Me.modificarSubZonaButton.Name = "modificarSubZonaButton"
		Me.modificarSubZonaButton.Size = New System.Drawing.Size(82, 36)
		Me.modificarSubZonaButton.TabIndex = 43
		Me.modificarSubZonaButton.Text = "Modificar"
		Me.modificarSubZonaButton.UseVisualStyleBackColor = True
		'
		'eliminarZonaButton
		'
		Me.eliminarZonaButton.Enabled = False
		Me.eliminarZonaButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.eliminarZonaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.eliminarZonaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.eliminarZonaButton.ForeColor = System.Drawing.Color.Black
		Me.eliminarZonaButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.eliminarZonaButton.Location = New System.Drawing.Point(184, 297)
		Me.eliminarZonaButton.Name = "eliminarZonaButton"
		Me.eliminarZonaButton.Size = New System.Drawing.Size(82, 36)
		Me.eliminarZonaButton.TabIndex = 41
		Me.eliminarZonaButton.Text = "Eliminar"
		Me.eliminarZonaButton.UseVisualStyleBackColor = True
		'
		'agregarZonaButton
		'
		Me.agregarZonaButton.Enabled = False
		Me.agregarZonaButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.agregarZonaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.agregarZonaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.agregarZonaButton.ForeColor = System.Drawing.Color.Black
		Me.agregarZonaButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.agregarZonaButton.Location = New System.Drawing.Point(8, 296)
		Me.agregarZonaButton.Name = "agregarZonaButton"
		Me.agregarZonaButton.Size = New System.Drawing.Size(82, 36)
		Me.agregarZonaButton.TabIndex = 40
		Me.agregarZonaButton.Text = "Agregar"
		Me.agregarZonaButton.UseVisualStyleBackColor = True
		'
		'modificarZonaButton
		'
		Me.modificarZonaButton.Enabled = False
		Me.modificarZonaButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.modificarZonaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.modificarZonaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.modificarZonaButton.ForeColor = System.Drawing.Color.Black
		Me.modificarZonaButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.modificarZonaButton.Location = New System.Drawing.Point(96, 296)
		Me.modificarZonaButton.Name = "modificarZonaButton"
		Me.modificarZonaButton.Size = New System.Drawing.Size(82, 36)
		Me.modificarZonaButton.TabIndex = 39
		Me.modificarZonaButton.Text = "Modificar"
		Me.modificarZonaButton.UseVisualStyleBackColor = True
		'
		'subZonasLabel
		'
		Me.subZonasLabel.AutoSize = True
		Me.subZonasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.subZonasLabel.Location = New System.Drawing.Point(357, 41)
		Me.subZonasLabel.Name = "subZonasLabel"
		Me.subZonasLabel.Size = New System.Drawing.Size(68, 13)
		Me.subZonasLabel.TabIndex = 38
		Me.subZonasLabel.Text = "Sub Zonas"
		'
		'zonaLabel
		'
		Me.zonaLabel.AutoSize = True
		Me.zonaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.zonaLabel.Location = New System.Drawing.Point(15, 41)
		Me.zonaLabel.Name = "zonaLabel"
		Me.zonaLabel.Size = New System.Drawing.Size(42, 13)
		Me.zonaLabel.TabIndex = 37
		Me.zonaLabel.Text = "Zonas"
		'
		'zonasLabel
		'
		Me.zonasLabel.AutoSize = True
		Me.zonasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
		Me.zonasLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.zonasLabel.Location = New System.Drawing.Point(7, 8)
		Me.zonasLabel.Name = "zonasLabel"
		Me.zonasLabel.Size = New System.Drawing.Size(79, 29)
		Me.zonasLabel.TabIndex = 36
		Me.zonasLabel.Text = "Zonas"
		'
		'verSubZonasDGV
		'
		Me.verSubZonasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.verSubZonasDGV.Location = New System.Drawing.Point(351, 57)
		Me.verSubZonasDGV.Name = "verSubZonasDGV"
		Me.verSubZonasDGV.Size = New System.Drawing.Size(258, 234)
		Me.verSubZonasDGV.TabIndex = 1
		'
		'verZonasDGV
		'
		Me.verZonasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.verZonasDGV.Location = New System.Drawing.Point(8, 57)
		Me.verZonasDGV.Name = "verZonasDGV"
		Me.verZonasDGV.Size = New System.Drawing.Size(258, 234)
		Me.verZonasDGV.TabIndex = 0
		'
		'usuariosPanel
		'
		Me.usuariosPanel.Controls.Add(Me.agregarUsuarioPanel)
		Me.usuariosPanel.Controls.Add(Me.modificarUsuarioPanel)
		Me.usuariosPanel.Controls.Add(Me.modificarUsuariosButton)
		Me.usuariosPanel.Controls.Add(Me.agregarUsuarioButton)
		Me.usuariosPanel.Controls.Add(Me.eliminarUsuarioButton)
		Me.usuariosPanel.Controls.Add(Me.usuariosLabel)
		Me.usuariosPanel.Controls.Add(Me.verUsuariosDGV)
		Me.usuariosPanel.Location = New System.Drawing.Point(172, 35)
		Me.usuariosPanel.Name = "usuariosPanel"
		Me.usuariosPanel.Size = New System.Drawing.Size(616, 482)
		Me.usuariosPanel.TabIndex = 38
		'
		'agregarUsuarioPanel
		'
		Me.agregarUsuarioPanel.Controls.Add(Me.rolComboBox)
		Me.agregarUsuarioPanel.Controls.Add(Me.contraseniaLabel)
		Me.agregarUsuarioPanel.Controls.Add(Me.rolLabel)
		Me.agregarUsuarioPanel.Controls.Add(Me.apellidoLabel)
		Me.agregarUsuarioPanel.Controls.Add(Me.nombreLabel)
		Me.agregarUsuarioPanel.Controls.Add(Me.cedulaLabel)
		Me.agregarUsuarioPanel.Controls.Add(Me.contraseniaTextBox)
		Me.agregarUsuarioPanel.Controls.Add(Me.apellidoTextBox)
		Me.agregarUsuarioPanel.Controls.Add(Me.nombreTextBox)
		Me.agregarUsuarioPanel.Controls.Add(Me.cedulaTextBox)
		Me.agregarUsuarioPanel.Location = New System.Drawing.Point(30, 335)
		Me.agregarUsuarioPanel.Name = "agregarUsuarioPanel"
		Me.agregarUsuarioPanel.Size = New System.Drawing.Size(543, 129)
		Me.agregarUsuarioPanel.TabIndex = 38
		'
		'rolComboBox
		'
		Me.rolComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
		Me.rolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.rolComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.rolComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.rolComboBox.FormattingEnabled = True
		Me.rolComboBox.Items.AddRange(New Object() {"Auto", "SUV", "Camión", "Van", "Minivan"})
		Me.rolComboBox.Location = New System.Drawing.Point(201, 95)
		Me.rolComboBox.Name = "rolComboBox"
		Me.rolComboBox.Size = New System.Drawing.Size(147, 21)
		Me.rolComboBox.TabIndex = 49
		'
		'contraseniaLabel
		'
		Me.contraseniaLabel.AutoSize = True
		Me.contraseniaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
		Me.contraseniaLabel.Location = New System.Drawing.Point(39, 76)
		Me.contraseniaLabel.Name = "contraseniaLabel"
		Me.contraseniaLabel.Size = New System.Drawing.Size(79, 17)
		Me.contraseniaLabel.TabIndex = 48
		Me.contraseniaLabel.Text = "contraseña"
		'
		'rolLabel
		'
		Me.rolLabel.AutoSize = True
		Me.rolLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
		Me.rolLabel.Location = New System.Drawing.Point(198, 76)
		Me.rolLabel.Name = "rolLabel"
		Me.rolLabel.Size = New System.Drawing.Size(29, 17)
		Me.rolLabel.TabIndex = 50
		Me.rolLabel.Text = "Rol"
		'
		'apellidoLabel
		'
		Me.apellidoLabel.AutoSize = True
		Me.apellidoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
		Me.apellidoLabel.Location = New System.Drawing.Point(351, 13)
		Me.apellidoLabel.Name = "apellidoLabel"
		Me.apellidoLabel.Size = New System.Drawing.Size(58, 17)
		Me.apellidoLabel.TabIndex = 47
		Me.apellidoLabel.Text = "Apellido"
		'
		'nombreLabel
		'
		Me.nombreLabel.AutoSize = True
		Me.nombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
		Me.nombreLabel.Location = New System.Drawing.Point(195, 13)
		Me.nombreLabel.Name = "nombreLabel"
		Me.nombreLabel.Size = New System.Drawing.Size(58, 17)
		Me.nombreLabel.TabIndex = 46
		Me.nombreLabel.Text = "Nombre"
		'
		'cedulaLabel
		'
		Me.cedulaLabel.AutoSize = True
		Me.cedulaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
		Me.cedulaLabel.Location = New System.Drawing.Point(39, 13)
		Me.cedulaLabel.Name = "cedulaLabel"
		Me.cedulaLabel.Size = New System.Drawing.Size(52, 17)
		Me.cedulaLabel.TabIndex = 45
		Me.cedulaLabel.Text = "Cedula"
		'
		'contraseniaTextBox
		'
		Me.contraseniaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.contraseniaTextBox.Location = New System.Drawing.Point(42, 96)
		Me.contraseniaTextBox.MaxLength = 17
		Me.contraseniaTextBox.Name = "contraseniaTextBox"
		Me.contraseniaTextBox.ShortcutsEnabled = False
		Me.contraseniaTextBox.Size = New System.Drawing.Size(150, 20)
		Me.contraseniaTextBox.TabIndex = 44
		'
		'apellidoTextBox
		'
		Me.apellidoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.apellidoTextBox.Location = New System.Drawing.Point(354, 36)
		Me.apellidoTextBox.MaxLength = 17
		Me.apellidoTextBox.Name = "apellidoTextBox"
		Me.apellidoTextBox.ShortcutsEnabled = False
		Me.apellidoTextBox.Size = New System.Drawing.Size(150, 20)
		Me.apellidoTextBox.TabIndex = 43
		'
		'nombreTextBox
		'
		Me.nombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.nombreTextBox.Location = New System.Drawing.Point(198, 36)
		Me.nombreTextBox.MaxLength = 17
		Me.nombreTextBox.Name = "nombreTextBox"
		Me.nombreTextBox.ShortcutsEnabled = False
		Me.nombreTextBox.Size = New System.Drawing.Size(150, 20)
		Me.nombreTextBox.TabIndex = 42
		'
		'cedulaTextBox
		'
		Me.cedulaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.cedulaTextBox.Location = New System.Drawing.Point(42, 36)
		Me.cedulaTextBox.MaxLength = 17
		Me.cedulaTextBox.Name = "cedulaTextBox"
		Me.cedulaTextBox.ShortcutsEnabled = False
		Me.cedulaTextBox.Size = New System.Drawing.Size(150, 20)
		Me.cedulaTextBox.TabIndex = 41
		'
		'modificarUsuarioPanel
		'
		Me.modificarUsuarioPanel.Controls.Add(Me.rolMComboBox)
		Me.modificarUsuarioPanel.Controls.Add(Me.contraseniaMLabel)
		Me.modificarUsuarioPanel.Controls.Add(Me.rolMLabel)
		Me.modificarUsuarioPanel.Controls.Add(Me.apellidoMLabel)
		Me.modificarUsuarioPanel.Controls.Add(Me.nombreMLabel)
		Me.modificarUsuarioPanel.Controls.Add(Me.cedulaMLabel)
		Me.modificarUsuarioPanel.Controls.Add(Me.contraseniaMTextBox)
		Me.modificarUsuarioPanel.Controls.Add(Me.apellidoMTextBox)
		Me.modificarUsuarioPanel.Controls.Add(Me.nombreMTextBox)
		Me.modificarUsuarioPanel.Controls.Add(Me.cedulaMTextBox)
		Me.modificarUsuarioPanel.Location = New System.Drawing.Point(30, 335)
		Me.modificarUsuarioPanel.Name = "modificarUsuarioPanel"
		Me.modificarUsuarioPanel.Size = New System.Drawing.Size(543, 129)
		Me.modificarUsuarioPanel.TabIndex = 39
		'
		'rolMComboBox
		'
		Me.rolMComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
		Me.rolMComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.rolMComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.rolMComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.rolMComboBox.FormattingEnabled = True
		Me.rolMComboBox.Items.AddRange(New Object() {"Auto", "SUV", "Camión", "Van", "Minivan"})
		Me.rolMComboBox.Location = New System.Drawing.Point(177, 85)
		Me.rolMComboBox.Name = "rolMComboBox"
		Me.rolMComboBox.Size = New System.Drawing.Size(147, 21)
		Me.rolMComboBox.TabIndex = 39
		'
		'contraseniaMLabel
		'
		Me.contraseniaMLabel.AutoSize = True
		Me.contraseniaMLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
		Me.contraseniaMLabel.Location = New System.Drawing.Point(15, 66)
		Me.contraseniaMLabel.Name = "contraseniaMLabel"
		Me.contraseniaMLabel.Size = New System.Drawing.Size(79, 17)
		Me.contraseniaMLabel.TabIndex = 38
		Me.contraseniaMLabel.Text = "contraseña"
		'
		'rolMLabel
		'
		Me.rolMLabel.AutoSize = True
		Me.rolMLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
		Me.rolMLabel.Location = New System.Drawing.Point(174, 66)
		Me.rolMLabel.Name = "rolMLabel"
		Me.rolMLabel.Size = New System.Drawing.Size(29, 17)
		Me.rolMLabel.TabIndex = 40
		Me.rolMLabel.Text = "Rol"
		'
		'apellidoMLabel
		'
		Me.apellidoMLabel.AutoSize = True
		Me.apellidoMLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
		Me.apellidoMLabel.Location = New System.Drawing.Point(327, 3)
		Me.apellidoMLabel.Name = "apellidoMLabel"
		Me.apellidoMLabel.Size = New System.Drawing.Size(58, 17)
		Me.apellidoMLabel.TabIndex = 37
		Me.apellidoMLabel.Text = "Apellido"
		'
		'nombreMLabel
		'
		Me.nombreMLabel.AutoSize = True
		Me.nombreMLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
		Me.nombreMLabel.Location = New System.Drawing.Point(171, 3)
		Me.nombreMLabel.Name = "nombreMLabel"
		Me.nombreMLabel.Size = New System.Drawing.Size(58, 17)
		Me.nombreMLabel.TabIndex = 36
		Me.nombreMLabel.Text = "Nombre"
		'
		'cedulaMLabel
		'
		Me.cedulaMLabel.AutoSize = True
		Me.cedulaMLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
		Me.cedulaMLabel.Location = New System.Drawing.Point(15, 3)
		Me.cedulaMLabel.Name = "cedulaMLabel"
		Me.cedulaMLabel.Size = New System.Drawing.Size(52, 17)
		Me.cedulaMLabel.TabIndex = 35
		Me.cedulaMLabel.Text = "Cedula"
		'
		'contraseniaMTextBox
		'
		Me.contraseniaMTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.contraseniaMTextBox.Location = New System.Drawing.Point(18, 86)
		Me.contraseniaMTextBox.MaxLength = 17
		Me.contraseniaMTextBox.Name = "contraseniaMTextBox"
		Me.contraseniaMTextBox.ShortcutsEnabled = False
		Me.contraseniaMTextBox.Size = New System.Drawing.Size(150, 20)
		Me.contraseniaMTextBox.TabIndex = 33
		'
		'apellidoMTextBox
		'
		Me.apellidoMTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.apellidoMTextBox.Location = New System.Drawing.Point(330, 26)
		Me.apellidoMTextBox.MaxLength = 17
		Me.apellidoMTextBox.Name = "apellidoMTextBox"
		Me.apellidoMTextBox.ShortcutsEnabled = False
		Me.apellidoMTextBox.Size = New System.Drawing.Size(150, 20)
		Me.apellidoMTextBox.TabIndex = 32
		'
		'nombreMTextBox
		'
		Me.nombreMTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.nombreMTextBox.Location = New System.Drawing.Point(174, 26)
		Me.nombreMTextBox.MaxLength = 17
		Me.nombreMTextBox.Name = "nombreMTextBox"
		Me.nombreMTextBox.ShortcutsEnabled = False
		Me.nombreMTextBox.Size = New System.Drawing.Size(150, 20)
		Me.nombreMTextBox.TabIndex = 31
		'
		'cedulaMTextBox
		'
		Me.cedulaMTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.cedulaMTextBox.Location = New System.Drawing.Point(18, 26)
		Me.cedulaMTextBox.MaxLength = 17
		Me.cedulaMTextBox.Name = "cedulaMTextBox"
		Me.cedulaMTextBox.ShortcutsEnabled = False
		Me.cedulaMTextBox.Size = New System.Drawing.Size(150, 20)
		Me.cedulaMTextBox.TabIndex = 30
		'
		'modificarUsuariosButton
		'
		Me.modificarUsuariosButton.Enabled = False
		Me.modificarUsuariosButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.modificarUsuariosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.modificarUsuariosButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.modificarUsuariosButton.ForeColor = System.Drawing.Color.Black
		Me.modificarUsuariosButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.modificarUsuariosButton.Location = New System.Drawing.Point(450, 176)
		Me.modificarUsuariosButton.Name = "modificarUsuariosButton"
		Me.modificarUsuariosButton.Size = New System.Drawing.Size(140, 36)
		Me.modificarUsuariosButton.TabIndex = 37
		Me.modificarUsuariosButton.Text = "Modificar"
		Me.modificarUsuariosButton.UseVisualStyleBackColor = True
		'
		'agregarUsuarioButton
		'
		Me.agregarUsuarioButton.Enabled = False
		Me.agregarUsuarioButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.agregarUsuarioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.agregarUsuarioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.agregarUsuarioButton.ForeColor = System.Drawing.Color.Black
		Me.agregarUsuarioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.agregarUsuarioButton.Location = New System.Drawing.Point(450, 42)
		Me.agregarUsuarioButton.Name = "agregarUsuarioButton"
		Me.agregarUsuarioButton.Size = New System.Drawing.Size(140, 36)
		Me.agregarUsuarioButton.TabIndex = 36
		Me.agregarUsuarioButton.Text = "Agregar"
		Me.agregarUsuarioButton.UseVisualStyleBackColor = True
		'
		'eliminarUsuarioButton
		'
		Me.eliminarUsuarioButton.Enabled = False
		Me.eliminarUsuarioButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.eliminarUsuarioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.eliminarUsuarioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.eliminarUsuarioButton.ForeColor = System.Drawing.Color.Black
		Me.eliminarUsuarioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.eliminarUsuarioButton.Location = New System.Drawing.Point(450, 107)
		Me.eliminarUsuarioButton.Name = "eliminarUsuarioButton"
		Me.eliminarUsuarioButton.Size = New System.Drawing.Size(140, 36)
		Me.eliminarUsuarioButton.TabIndex = 35
		Me.eliminarUsuarioButton.Text = "Eliminar"
		Me.eliminarUsuarioButton.UseVisualStyleBackColor = True
		'
		'usuariosLabel
		'
		Me.usuariosLabel.AutoSize = True
		Me.usuariosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
		Me.usuariosLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.usuariosLabel.Location = New System.Drawing.Point(3, 8)
		Me.usuariosLabel.Name = "usuariosLabel"
		Me.usuariosLabel.Size = New System.Drawing.Size(108, 29)
		Me.usuariosLabel.TabIndex = 35
		Me.usuariosLabel.Text = "Usuarios"
		'
		'verUsuariosDGV
		'
		Me.verUsuariosDGV.AllowUserToAddRows = False
		Me.verUsuariosDGV.AllowUserToDeleteRows = False
		Me.verUsuariosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.verUsuariosDGV.Location = New System.Drawing.Point(8, 43)
		Me.verUsuariosDGV.Name = "verUsuariosDGV"
		Me.verUsuariosDGV.ReadOnly = True
		Me.verUsuariosDGV.Size = New System.Drawing.Size(420, 271)
		Me.verUsuariosDGV.TabIndex = 5
		'
		'inspeccionesPanel
		'
		Me.inspeccionesPanel.Controls.Add(Me.agregarInspeccionPanel)
		Me.inspeccionesPanel.Controls.Add(Me.modificarInspeccionButton)
		Me.inspeccionesPanel.Controls.Add(Me.eliminarInspeccionButton)
		Me.inspeccionesPanel.Controls.Add(Me.agregarInspeccionButton)
		Me.inspeccionesPanel.Controls.Add(Me.verDañosPanel)
		Me.inspeccionesPanel.Controls.Add(Me.verDaniosButton)
		Me.inspeccionesPanel.Controls.Add(Me.inspeccionesLabel)
		Me.inspeccionesPanel.Controls.Add(Me.verInspeccionesDGV)
		Me.inspeccionesPanel.Location = New System.Drawing.Point(172, 35)
		Me.inspeccionesPanel.Name = "inspeccionesPanel"
		Me.inspeccionesPanel.Size = New System.Drawing.Size(616, 482)
		Me.inspeccionesPanel.TabIndex = 0
		'
		'agregarInspeccionPanel
		'
		Me.agregarInspeccionPanel.Controls.Add(Me.eliminarInspeccionPanel)
		Me.agregarInspeccionPanel.Location = New System.Drawing.Point(12, 308)
		Me.agregarInspeccionPanel.Name = "agregarInspeccionPanel"
		Me.agregarInspeccionPanel.Size = New System.Drawing.Size(578, 168)
		Me.agregarInspeccionPanel.TabIndex = 49
		'
		'eliminarInspeccionPanel
		'
		Me.eliminarInspeccionPanel.Controls.Add(Me.modificarInpseccionPanel)
		Me.eliminarInspeccionPanel.Location = New System.Drawing.Point(0, 0)
		Me.eliminarInspeccionPanel.Name = "eliminarInspeccionPanel"
		Me.eliminarInspeccionPanel.Size = New System.Drawing.Size(578, 168)
		Me.eliminarInspeccionPanel.TabIndex = 50
		'
		'modificarInpseccionPanel
		'
		Me.modificarInpseccionPanel.Location = New System.Drawing.Point(0, 0)
		Me.modificarInpseccionPanel.Name = "modificarInpseccionPanel"
		Me.modificarInpseccionPanel.Size = New System.Drawing.Size(578, 168)
		Me.modificarInpseccionPanel.TabIndex = 50
		'
		'modificarInspeccionButton
		'
		Me.modificarInspeccionButton.Enabled = False
		Me.modificarInspeccionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.modificarInspeccionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.modificarInspeccionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.modificarInspeccionButton.ForeColor = System.Drawing.Color.Black
		Me.modificarInspeccionButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.modificarInspeccionButton.Location = New System.Drawing.Point(378, 266)
		Me.modificarInspeccionButton.Name = "modificarInspeccionButton"
		Me.modificarInspeccionButton.Size = New System.Drawing.Size(116, 36)
		Me.modificarInspeccionButton.TabIndex = 48
		Me.modificarInspeccionButton.Text = "Modificar"
		Me.modificarInspeccionButton.UseVisualStyleBackColor = True
		'
		'eliminarInspeccionButton
		'
		Me.eliminarInspeccionButton.Enabled = False
		Me.eliminarInspeccionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.eliminarInspeccionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.eliminarInspeccionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.eliminarInspeccionButton.ForeColor = System.Drawing.Color.Black
		Me.eliminarInspeccionButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.eliminarInspeccionButton.Location = New System.Drawing.Point(256, 266)
		Me.eliminarInspeccionButton.Name = "eliminarInspeccionButton"
		Me.eliminarInspeccionButton.Size = New System.Drawing.Size(116, 36)
		Me.eliminarInspeccionButton.TabIndex = 47
		Me.eliminarInspeccionButton.Text = "Eliminar"
		Me.eliminarInspeccionButton.UseVisualStyleBackColor = True
		'
		'agregarInspeccionButton
		'
		Me.agregarInspeccionButton.Enabled = False
		Me.agregarInspeccionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.agregarInspeccionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.agregarInspeccionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.agregarInspeccionButton.ForeColor = System.Drawing.Color.Black
		Me.agregarInspeccionButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.agregarInspeccionButton.Location = New System.Drawing.Point(134, 266)
		Me.agregarInspeccionButton.Name = "agregarInspeccionButton"
		Me.agregarInspeccionButton.Size = New System.Drawing.Size(116, 36)
		Me.agregarInspeccionButton.TabIndex = 46
		Me.agregarInspeccionButton.Text = "Agregar"
		Me.agregarInspeccionButton.UseVisualStyleBackColor = True
		'
		'verDañosPanel
		'
		Me.verDañosPanel.Controls.Add(Me.numeroInspLabel)
		Me.verDañosPanel.Controls.Add(Me.Label1)
		Me.verDañosPanel.Controls.Add(Me.verSegundaInspeccion)
		Me.verDañosPanel.Controls.Add(Me.descDañoLabel)
		Me.verDañosPanel.Controls.Add(Me.inspeccionLabel)
		Me.verDañosPanel.Controls.Add(Me.evidenciaPictureBox)
		Me.verDañosPanel.Location = New System.Drawing.Point(12, 308)
		Me.verDañosPanel.Name = "verDañosPanel"
		Me.verDañosPanel.Size = New System.Drawing.Size(578, 168)
		Me.verDañosPanel.TabIndex = 45
		'
		'numeroInspLabel
		'
		Me.numeroInspLabel.AutoSize = True
		Me.numeroInspLabel.Location = New System.Drawing.Point(305, 27)
		Me.numeroInspLabel.Name = "numeroInspLabel"
		Me.numeroInspLabel.Size = New System.Drawing.Size(42, 13)
		Me.numeroInspLabel.TabIndex = 46
		Me.numeroInspLabel.Text = "numero"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(305, 63)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(61, 13)
		Me.Label1.TabIndex = 45
		Me.Label1.Text = "descripcion"
		'
		'verSegundaInspeccion
		'
		Me.verSegundaInspeccion.Enabled = False
		Me.verSegundaInspeccion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.verSegundaInspeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.verSegundaInspeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.verSegundaInspeccion.ForeColor = System.Drawing.Color.Black
		Me.verSegundaInspeccion.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.verSegundaInspeccion.Location = New System.Drawing.Point(479, 124)
		Me.verSegundaInspeccion.Name = "verSegundaInspeccion"
		Me.verSegundaInspeccion.Size = New System.Drawing.Size(82, 36)
		Me.verSegundaInspeccion.TabIndex = 44
		Me.verSegundaInspeccion.Text = "Ver Segunda"
		Me.verSegundaInspeccion.UseVisualStyleBackColor = True
		'
		'descDañoLabel
		'
		Me.descDañoLabel.AutoSize = True
		Me.descDañoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.descDañoLabel.Location = New System.Drawing.Point(169, 63)
		Me.descDañoLabel.Name = "descDañoLabel"
		Me.descDañoLabel.Size = New System.Drawing.Size(131, 13)
		Me.descDañoLabel.TabIndex = 40
		Me.descDañoLabel.Text = "Descripcion del daño:"
		'
		'inspeccionLabel
		'
		Me.inspeccionLabel.AutoSize = True
		Me.inspeccionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.inspeccionLabel.Location = New System.Drawing.Point(169, 27)
		Me.inspeccionLabel.Name = "inspeccionLabel"
		Me.inspeccionLabel.Size = New System.Drawing.Size(120, 13)
		Me.inspeccionLabel.TabIndex = 39
		Me.inspeccionLabel.Text = "Inspeccion Numero:"
		'
		'evidenciaPictureBox
		'
		Me.evidenciaPictureBox.Location = New System.Drawing.Point(6, 19)
		Me.evidenciaPictureBox.Name = "evidenciaPictureBox"
		Me.evidenciaPictureBox.Size = New System.Drawing.Size(144, 131)
		Me.evidenciaPictureBox.TabIndex = 38
		Me.evidenciaPictureBox.TabStop = False
		'
		'verDaniosButton
		'
		Me.verDaniosButton.Enabled = False
		Me.verDaniosButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.verDaniosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.verDaniosButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.verDaniosButton.ForeColor = System.Drawing.Color.Black
		Me.verDaniosButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.verDaniosButton.Location = New System.Drawing.Point(12, 266)
		Me.verDaniosButton.Name = "verDaniosButton"
		Me.verDaniosButton.Size = New System.Drawing.Size(116, 36)
		Me.verDaniosButton.TabIndex = 44
		Me.verDaniosButton.Text = "Ver Daños"
		Me.verDaniosButton.UseVisualStyleBackColor = True
		'
		'inspeccionesLabel
		'
		Me.inspeccionesLabel.AutoSize = True
		Me.inspeccionesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
		Me.inspeccionesLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.inspeccionesLabel.Location = New System.Drawing.Point(7, 6)
		Me.inspeccionesLabel.Name = "inspeccionesLabel"
		Me.inspeccionesLabel.Size = New System.Drawing.Size(155, 29)
		Me.inspeccionesLabel.TabIndex = 37
		Me.inspeccionesLabel.Text = "Inspecciones"
		'
		'verInspeccionesDGV
		'
		Me.verInspeccionesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.verInspeccionesDGV.Location = New System.Drawing.Point(12, 43)
		Me.verInspeccionesDGV.Name = "verInspeccionesDGV"
		Me.verInspeccionesDGV.Size = New System.Drawing.Size(578, 217)
		Me.verInspeccionesDGV.TabIndex = 2
		'
		'administrador
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 530)
		Me.Controls.Add(Me.lotesPanel)
		Me.Controls.Add(Me.inspeccionesPanel)
		Me.Controls.Add(Me.zonasPanel)
		Me.Controls.Add(Me.viajesPanel)
		Me.Controls.Add(Me.usuariosPanel)
		Me.Controls.Add(Me.vehiculosPanel)
		Me.Controls.Add(Me.TabPanel)
		Me.Controls.Add(Me.topBarPanel)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "administrador"
		Me.Text = "Administrador"
		Me.topBarPanel.ResumeLayout(False)
		Me.topBarPanel.PerformLayout()
		Me.TabPanel.ResumeLayout(False)
		Me.vehiculosPanel.ResumeLayout(False)
		Me.vehiculosPanel.PerformLayout()
		Me.ingresarVehiculoPanel.ResumeLayout(False)
		Me.ingresarVehiculoPanel.PerformLayout()
		Me.modificarAutoPanel.ResumeLayout(False)
		Me.modificarAutoPanel.PerformLayout()
		CType(Me.verVehicuosDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.lotesPanel.ResumeLayout(False)
		Me.lotesPanel.PerformLayout()
		Me.modificarLotesPanel.ResumeLayout(False)
		Me.modificarLotesPanel.PerformLayout()
		CType(Me.verVehiculosCInspeccionDGV, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.verVehiculosEnLoteDGV, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.verLotesLabel, System.ComponentModel.ISupportInitialize).EndInit()
		Me.viajesPanel.ResumeLayout(False)
		Me.viajesPanel.PerformLayout()
		CType(Me.verViajesDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.zonasPanel.ResumeLayout(False)
		Me.zonasPanel.PerformLayout()
		CType(Me.verSubZonasDGV, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.verZonasDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.usuariosPanel.ResumeLayout(False)
		Me.usuariosPanel.PerformLayout()
		Me.agregarUsuarioPanel.ResumeLayout(False)
		Me.agregarUsuarioPanel.PerformLayout()
		Me.modificarUsuarioPanel.ResumeLayout(False)
		Me.modificarUsuarioPanel.PerformLayout()
		CType(Me.verUsuariosDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.inspeccionesPanel.ResumeLayout(False)
		Me.inspeccionesPanel.PerformLayout()
		Me.agregarInspeccionPanel.ResumeLayout(False)
		Me.eliminarInspeccionPanel.ResumeLayout(False)
		Me.verDañosPanel.ResumeLayout(False)
		Me.verDañosPanel.PerformLayout()
		CType(Me.evidenciaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.verInspeccionesDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents topBarPanel As Panel
	Friend WithEvents cerrar As Label
	Friend WithEvents mainLabel As Label
	Friend WithEvents TabPanel As Panel
	Friend WithEvents lotesButton As Button
	Friend WithEvents atrasButton As Button
	Friend WithEvents salirButton As Button
	Friend WithEvents usuariosButton As Button
	Friend WithEvents zonasButton As Button
	Friend WithEvents viajesButton As Button
	Friend WithEvents vehiculosButton As Button
	Friend WithEvents vehiculosPanel As Panel
	Friend WithEvents verVehicuosDGV As DataGridView
	Friend WithEvents vehiculosLabel As Label
	Friend WithEvents modificarVehiculoButton As Button
	Friend WithEvents eliminarVehiculoButton As Button
	Friend WithEvents agregarVehiculoButton As Button
	Friend WithEvents tipoLabel As Label
	Friend WithEvents colorLabel As Label
	Friend WithEvents anioLabel As Label
	Friend WithEvents modeloLabel As Label
	Friend WithEvents marcaLabel As Label
	Friend WithEvents vinLabel As Label
	Friend WithEvents tipoComboBox As ComboBox
	Friend WithEvents BuscarButton As Button
	Friend WithEvents ingresarVINLabel As Label
	Friend WithEvents vinABuscarTextBox As TextBox
	Friend WithEvents actualizarVerVehiculo As Button
	Friend WithEvents colorTextBox As TextBox
	Friend WithEvents anioTextBox As TextBox
	Friend WithEvents modeloTextBox As TextBox
	Friend WithEvents marcaTextBox As TextBox
	Friend WithEvents vinTextBox As TextBox
	Friend WithEvents ingresarVehiculoPanel As Panel
	Friend WithEvents lotesPanel As Panel
	Friend WithEvents viajesPanel As Panel
	Friend WithEvents zonasPanel As Panel
	Friend WithEvents usuariosPanel As Panel
	Friend WithEvents usuariosLabel As Label
	Friend WithEvents verUsuariosDGV As DataGridView
	Friend WithEvents agregarUsuarioPanel As Panel
	Friend WithEvents modificarUsuariosButton As Button
	Friend WithEvents agregarUsuarioButton As Button
	Friend WithEvents eliminarUsuarioButton As Button
	Friend WithEvents modificarUsuarioPanel As Panel
	Friend WithEvents modificarAutoPanel As Panel
	Friend WithEvents colorMTextBox As TextBox
	Friend WithEvents anioMTextBox As TextBox
	Friend WithEvents modeloMTextBox As TextBox
	Friend WithEvents marcaMTextBox As TextBox
	Friend WithEvents vinMTextBox As TextBox
	Friend WithEvents tipoMComboBox As ComboBox
	Friend WithEvents tipoMLabel As Label
	Friend WithEvents colorMLabel As Label
	Friend WithEvents anioMLabel As Label
	Friend WithEvents modeloMLabel As Label
	Friend WithEvents marcaMLabel As Label
	Friend WithEvents vinMLabel As Label
	Friend WithEvents rolMComboBox As ComboBox
	Friend WithEvents contraseniaMLabel As Label
	Friend WithEvents rolMLabel As Label
	Friend WithEvents apellidoMLabel As Label
	Friend WithEvents nombreMLabel As Label
	Friend WithEvents cedulaMLabel As Label
	Friend WithEvents contraseniaMTextBox As TextBox
	Friend WithEvents apellidoMTextBox As TextBox
	Friend WithEvents nombreMTextBox As TextBox
	Friend WithEvents cedulaMTextBox As TextBox
	Friend WithEvents rolComboBox As ComboBox
	Friend WithEvents contraseniaLabel As Label
	Friend WithEvents rolLabel As Label
	Friend WithEvents apellidoLabel As Label
	Friend WithEvents nombreLabel As Label
	Friend WithEvents cedulaLabel As Label
	Friend WithEvents contraseniaTextBox As TextBox
	Friend WithEvents apellidoTextBox As TextBox
	Friend WithEvents nombreTextBox As TextBox
	Friend WithEvents cedulaTextBox As TextBox
	Friend WithEvents modificarViajeButton As Button
	Friend WithEvents viajesLabel As Label
	Friend WithEvents verViajesDGV As DataGridView
	Friend WithEvents actualizarVerViajeButton As Button
	Friend WithEvents modificarViajePanel As Panel
	Friend WithEvents subZonasLabel As Label
	Friend WithEvents zonaLabel As Label
	Friend WithEvents zonasLabel As Label
	Friend WithEvents verSubZonasDGV As DataGridView
	Friend WithEvents verZonasDGV As DataGridView
	Friend WithEvents inspeccionesButton As Button
	Friend WithEvents modificarSubZonaButton As Button
	Friend WithEvents eliminarZonaButton As Button
	Friend WithEvents agregarZonaButton As Button
	Friend WithEvents modificarZonaButton As Button
	Friend WithEvents agregarZonaPanel As Panel
	Friend WithEvents modificarSubZonaPanel As Panel
	Friend WithEvents modificarZonasPanel As Panel
	Friend WithEvents inspeccionesPanel As Panel
	Friend WithEvents inspeccionesLabel As Label
	Friend WithEvents verInspeccionesDGV As DataGridView
	Friend WithEvents verDañosPanel As Panel
	Friend WithEvents verSegundaInspeccion As Button
	Friend WithEvents descDañoLabel As Label
	Friend WithEvents inspeccionLabel As Label
	Friend WithEvents evidenciaPictureBox As PictureBox
	Friend WithEvents verDaniosButton As Button
	Friend WithEvents numeroInspLabel As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents modificarInspeccionButton As Button
	Friend WithEvents eliminarInspeccionButton As Button
	Friend WithEvents agregarInspeccionButton As Button
	Friend WithEvents agregarInspeccionPanel As Panel
	Friend WithEvents eliminarInspeccionPanel As Panel
	Friend WithEvents modificarInpseccionPanel As Panel
	Friend WithEvents modificarLotesPanel As Panel
	Friend WithEvents vehiculosInspeccionadosLabel As Label
	Friend WithEvents vehiculosEnLoteLabel As Label
	Friend WithEvents verVehiculosCInspeccionDGV As DataGridView
	Friend WithEvents verVehiculosEnLoteDGV As DataGridView
	Friend WithEvents agregarLotePanel As Panel
	Friend WithEvents modificarLoteButton As Button
	Friend WithEvents eliminarLoteButton As Button
	Friend WithEvents agregarLoteButton As Button
	Friend WithEvents lotesLabel As Label
	Friend WithEvents verLotesLabel As DataGridView
End Class
