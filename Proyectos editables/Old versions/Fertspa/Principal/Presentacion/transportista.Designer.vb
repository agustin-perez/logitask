<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class transportista
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transportista))
		Me.topBarPanel = New System.Windows.Forms.Panel()
		Me.cerrar = New System.Windows.Forms.Label()
		Me.mainLabel = New System.Windows.Forms.Label()
		Me.TabPanel = New System.Windows.Forms.Panel()
		Me.viajeButton = New System.Windows.Forms.Button()
		Me.registrarVehiculoButton = New System.Windows.Forms.Button()
		Me.verViajesButton = New System.Windows.Forms.Button()
		Me.cLoteButton = New System.Windows.Forms.Button()
		Me.verInspeccionButton = New System.Windows.Forms.Button()
		Me.realizarInspeccionButton = New System.Windows.Forms.Button()
		Me.salirButton = New System.Windows.Forms.Button()
		Me.verVehiculoButton = New System.Windows.Forms.Button()
		Me.atrasButton = New System.Windows.Forms.Button()
		Me.verLotesButton = New System.Windows.Forms.Button()
		Me.selecLotePanel = New System.Windows.Forms.Panel()
		Me.iniciarViajeButton = New System.Windows.Forms.Button()
		Me.verLotesDGVpanel = New System.Windows.Forms.Panel()
		Me.verLotesDGV = New System.Windows.Forms.DataGridView()
		Me.selecLoteText = New System.Windows.Forms.Label()
		Me.procesoViajePanel = New System.Windows.Forms.Panel()
		Me.tiempoTranscurridoLabel = New System.Windows.Forms.Label()
		Me.estadoLabel = New System.Windows.Forms.Label()
		Me.fechaInicioLabel = New System.Windows.Forms.Label()
		Me.nombreLoteLabel = New System.Windows.Forms.Label()
		Me.fechaDeInicioLabel = New System.Windows.Forms.Label()
		Me.estadoDeViajeLabel = New System.Windows.Forms.Label()
		Me.nombreDelLoteLabel = New System.Windows.Forms.Label()
		Me.finalizarViajeButton = New System.Windows.Forms.Button()
		Me.procesoViajeLabel = New System.Windows.Forms.Label()
		Me.tiempoTranscurridoTimer = New System.Windows.Forms.Timer(Me.components)
		Me.verViajesPanel = New System.Windows.Forms.Panel()
		Me.verViajesLabel = New System.Windows.Forms.Label()
		Me.verViajesDGV = New System.Windows.Forms.DataGridView()
		Me.topBarPanel.SuspendLayout()
		Me.TabPanel.SuspendLayout()
		Me.selecLotePanel.SuspendLayout()
		Me.verLotesDGVpanel.SuspendLayout()
		CType(Me.verLotesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.procesoViajePanel.SuspendLayout()
		Me.verViajesPanel.SuspendLayout()
		CType(Me.verViajesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.topBarPanel.TabIndex = 17
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
		Me.mainLabel.Size = New System.Drawing.Size(91, 15)
		Me.mainLabel.TabIndex = 2
		Me.mainLabel.Text = "Transportista"
		'
		'TabPanel
		'
		Me.TabPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.TabPanel.Controls.Add(Me.viajeButton)
		Me.TabPanel.Controls.Add(Me.registrarVehiculoButton)
		Me.TabPanel.Controls.Add(Me.verViajesButton)
		Me.TabPanel.Controls.Add(Me.cLoteButton)
		Me.TabPanel.Controls.Add(Me.verInspeccionButton)
		Me.TabPanel.Controls.Add(Me.realizarInspeccionButton)
		Me.TabPanel.Controls.Add(Me.salirButton)
		Me.TabPanel.Controls.Add(Me.verVehiculoButton)
		Me.TabPanel.Controls.Add(Me.atrasButton)
		Me.TabPanel.Controls.Add(Me.verLotesButton)
		Me.TabPanel.Location = New System.Drawing.Point(-5, 30)
		Me.TabPanel.Name = "TabPanel"
		Me.TabPanel.Size = New System.Drawing.Size(170, 500)
		Me.TabPanel.TabIndex = 3
		'
		'viajeButton
		'
		Me.viajeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.viajeButton.FlatAppearance.BorderSize = 0
		Me.viajeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.viajeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.viajeButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.viajeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.viajeButton.Location = New System.Drawing.Point(5, 44)
		Me.viajeButton.Name = "viajeButton"
		Me.viajeButton.Size = New System.Drawing.Size(166, 34)
		Me.viajeButton.TabIndex = 1
		Me.viajeButton.Text = "Viaje"
		Me.viajeButton.UseVisualStyleBackColor = False
		'
		'registrarVehiculoButton
		'
		Me.registrarVehiculoButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.registrarVehiculoButton.FlatAppearance.BorderSize = 0
		Me.registrarVehiculoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.registrarVehiculoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.registrarVehiculoButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.registrarVehiculoButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.registrarVehiculoButton.Location = New System.Drawing.Point(4, 40)
		Me.registrarVehiculoButton.Name = "registrarVehiculoButton"
		Me.registrarVehiculoButton.Size = New System.Drawing.Size(166, 34)
		Me.registrarVehiculoButton.TabIndex = 16
		Me.registrarVehiculoButton.Text = "Registrar Vehiculo"
		Me.registrarVehiculoButton.UseVisualStyleBackColor = False
		Me.registrarVehiculoButton.Visible = False
		'
		'verViajesButton
		'
		Me.verViajesButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.verViajesButton.FlatAppearance.BorderSize = 0
		Me.verViajesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.verViajesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.verViajesButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.verViajesButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.verViajesButton.Location = New System.Drawing.Point(5, 100)
		Me.verViajesButton.Name = "verViajesButton"
		Me.verViajesButton.Size = New System.Drawing.Size(166, 34)
		Me.verViajesButton.TabIndex = 0
		Me.verViajesButton.Text = "Ver Viajes"
		Me.verViajesButton.UseVisualStyleBackColor = False
		'
		'cLoteButton
		'
		Me.cLoteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.cLoteButton.FlatAppearance.BorderSize = 0
		Me.cLoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cLoteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.cLoteButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.cLoteButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.cLoteButton.Location = New System.Drawing.Point(6, 43)
		Me.cLoteButton.Name = "cLoteButton"
		Me.cLoteButton.Size = New System.Drawing.Size(165, 34)
		Me.cLoteButton.TabIndex = 12
		Me.cLoteButton.Text = "Crear Lote"
		Me.cLoteButton.UseVisualStyleBackColor = False
		Me.cLoteButton.Visible = False
		'
		'verInspeccionButton
		'
		Me.verInspeccionButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.verInspeccionButton.FlatAppearance.BorderSize = 0
		Me.verInspeccionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.verInspeccionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.verInspeccionButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.verInspeccionButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.verInspeccionButton.Location = New System.Drawing.Point(5, 100)
		Me.verInspeccionButton.Name = "verInspeccionButton"
		Me.verInspeccionButton.Size = New System.Drawing.Size(166, 34)
		Me.verInspeccionButton.TabIndex = 22
		Me.verInspeccionButton.Text = "Ver inspecciones"
		Me.verInspeccionButton.UseVisualStyleBackColor = False
		Me.verInspeccionButton.Visible = False
		'
		'realizarInspeccionButton
		'
		Me.realizarInspeccionButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.realizarInspeccionButton.FlatAppearance.BorderSize = 0
		Me.realizarInspeccionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.realizarInspeccionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.realizarInspeccionButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.realizarInspeccionButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.realizarInspeccionButton.Location = New System.Drawing.Point(5, 40)
		Me.realizarInspeccionButton.Name = "realizarInspeccionButton"
		Me.realizarInspeccionButton.Size = New System.Drawing.Size(166, 34)
		Me.realizarInspeccionButton.TabIndex = 21
		Me.realizarInspeccionButton.Text = "Realizar"
		Me.realizarInspeccionButton.UseVisualStyleBackColor = False
		Me.realizarInspeccionButton.Visible = False
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
		Me.salirButton.TabIndex = 19
		Me.salirButton.Text = "Salir"
		Me.salirButton.UseVisualStyleBackColor = False
		'
		'verVehiculoButton
		'
		Me.verVehiculoButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.verVehiculoButton.FlatAppearance.BorderSize = 0
		Me.verVehiculoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.verVehiculoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.verVehiculoButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.verVehiculoButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.verVehiculoButton.Location = New System.Drawing.Point(5, 100)
		Me.verVehiculoButton.Name = "verVehiculoButton"
		Me.verVehiculoButton.Size = New System.Drawing.Size(166, 34)
		Me.verVehiculoButton.TabIndex = 17
		Me.verVehiculoButton.Text = "Ver Vehiculos"
		Me.verVehiculoButton.UseVisualStyleBackColor = False
		Me.verVehiculoButton.Visible = False
		'
		'atrasButton
		'
		Me.atrasButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.atrasButton.FlatAppearance.BorderSize = 0
		Me.atrasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.atrasButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.atrasButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.atrasButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.atrasButton.Location = New System.Drawing.Point(0, 436)
		Me.atrasButton.Name = "atrasButton"
		Me.atrasButton.Size = New System.Drawing.Size(171, 34)
		Me.atrasButton.TabIndex = 6
		Me.atrasButton.Text = "Atras"
		Me.atrasButton.UseVisualStyleBackColor = False
		Me.atrasButton.Visible = False
		'
		'verLotesButton
		'
		Me.verLotesButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.verLotesButton.FlatAppearance.BorderSize = 0
		Me.verLotesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.verLotesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.verLotesButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.verLotesButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.verLotesButton.Location = New System.Drawing.Point(5, 100)
		Me.verLotesButton.Name = "verLotesButton"
		Me.verLotesButton.Size = New System.Drawing.Size(166, 49)
		Me.verLotesButton.TabIndex = 14
		Me.verLotesButton.Text = "Ver Lotes"
		Me.verLotesButton.UseVisualStyleBackColor = False
		Me.verLotesButton.Visible = False
		'
		'selecLotePanel
		'
		Me.selecLotePanel.Controls.Add(Me.iniciarViajeButton)
		Me.selecLotePanel.Controls.Add(Me.verLotesDGVpanel)
		Me.selecLotePanel.Controls.Add(Me.selecLoteText)
		Me.selecLotePanel.Location = New System.Drawing.Point(172, 35)
		Me.selecLotePanel.Name = "selecLotePanel"
		Me.selecLotePanel.Size = New System.Drawing.Size(616, 479)
		Me.selecLotePanel.TabIndex = 21
		Me.selecLotePanel.Visible = False
		'
		'iniciarViajeButton
		'
		Me.iniciarViajeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.iniciarViajeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.iniciarViajeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.iniciarViajeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.iniciarViajeButton.Location = New System.Drawing.Point(468, 444)
		Me.iniciarViajeButton.Name = "iniciarViajeButton"
		Me.iniciarViajeButton.Size = New System.Drawing.Size(75, 23)
		Me.iniciarViajeButton.TabIndex = 1
		Me.iniciarViajeButton.Text = "Iniciar"
		Me.iniciarViajeButton.UseVisualStyleBackColor = True
		'
		'verLotesDGVpanel
		'
		Me.verLotesDGVpanel.Controls.Add(Me.verLotesDGV)
		Me.verLotesDGVpanel.Location = New System.Drawing.Point(59, 95)
		Me.verLotesDGVpanel.Name = "verLotesDGVpanel"
		Me.verLotesDGVpanel.Size = New System.Drawing.Size(484, 343)
		Me.verLotesDGVpanel.TabIndex = 15
		'
		'verLotesDGV
		'
		Me.verLotesDGV.AllowUserToAddRows = False
		Me.verLotesDGV.AllowUserToDeleteRows = False
		Me.verLotesDGV.AllowUserToOrderColumns = True
		Me.verLotesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.verLotesDGV.Location = New System.Drawing.Point(0, 0)
		Me.verLotesDGV.Name = "verLotesDGV"
		Me.verLotesDGV.ReadOnly = True
		Me.verLotesDGV.Size = New System.Drawing.Size(484, 343)
		Me.verLotesDGV.TabIndex = 1
		'
		'selecLoteText
		'
		Me.selecLoteText.AutoSize = True
		Me.selecLoteText.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
		Me.selecLoteText.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.selecLoteText.Location = New System.Drawing.Point(199, 20)
		Me.selecLoteText.Name = "selecLoteText"
		Me.selecLoteText.Size = New System.Drawing.Size(217, 29)
		Me.selecLoteText.TabIndex = 13
		Me.selecLoteText.Text = "Comenzar un viaje:"
		'
		'procesoViajePanel
		'
		Me.procesoViajePanel.Controls.Add(Me.tiempoTranscurridoLabel)
		Me.procesoViajePanel.Controls.Add(Me.estadoLabel)
		Me.procesoViajePanel.Controls.Add(Me.fechaInicioLabel)
		Me.procesoViajePanel.Controls.Add(Me.nombreLoteLabel)
		Me.procesoViajePanel.Controls.Add(Me.fechaDeInicioLabel)
		Me.procesoViajePanel.Controls.Add(Me.estadoDeViajeLabel)
		Me.procesoViajePanel.Controls.Add(Me.nombreDelLoteLabel)
		Me.procesoViajePanel.Controls.Add(Me.finalizarViajeButton)
		Me.procesoViajePanel.Controls.Add(Me.procesoViajeLabel)
		Me.procesoViajePanel.Location = New System.Drawing.Point(172, 35)
		Me.procesoViajePanel.Name = "procesoViajePanel"
		Me.procesoViajePanel.Size = New System.Drawing.Size(616, 479)
		Me.procesoViajePanel.TabIndex = 22
		Me.procesoViajePanel.Visible = False
		'
		'tiempoTranscurridoLabel
		'
		Me.tiempoTranscurridoLabel.AutoSize = True
		Me.tiempoTranscurridoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tiempoTranscurridoLabel.Location = New System.Drawing.Point(404, 251)
		Me.tiempoTranscurridoLabel.Name = "tiempoTranscurridoLabel"
		Me.tiempoTranscurridoLabel.Size = New System.Drawing.Size(158, 20)
		Me.tiempoTranscurridoLabel.TabIndex = 20
		Me.tiempoTranscurridoLabel.Text = "Tiempo transucurrido"
		'
		'estadoLabel
		'
		Me.estadoLabel.AutoSize = True
		Me.estadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.estadoLabel.Location = New System.Drawing.Point(307, 251)
		Me.estadoLabel.Name = "estadoLabel"
		Me.estadoLabel.Size = New System.Drawing.Size(91, 20)
		Me.estadoLabel.TabIndex = 19
		Me.estadoLabel.Text = "En Proceso"
		'
		'fechaInicioLabel
		'
		Me.fechaInicioLabel.AutoSize = True
		Me.fechaInicioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fechaInicioLabel.Location = New System.Drawing.Point(316, 204)
		Me.fechaInicioLabel.Name = "fechaInicioLabel"
		Me.fechaInicioLabel.Size = New System.Drawing.Size(49, 20)
		Me.fechaInicioLabel.TabIndex = 18
		Me.fechaInicioLabel.Text = "00:00"
		'
		'nombreLoteLabel
		'
		Me.nombreLoteLabel.AutoSize = True
		Me.nombreLoteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.nombreLoteLabel.Location = New System.Drawing.Point(316, 155)
		Me.nombreLoteLabel.Name = "nombreLoteLabel"
		Me.nombreLoteLabel.Size = New System.Drawing.Size(66, 20)
		Me.nombreLoteLabel.TabIndex = 17
		Me.nombreLoteLabel.Text = "Ejemplo"
		'
		'fechaDeInicioLabel
		'
		Me.fechaDeInicioLabel.AutoSize = True
		Me.fechaDeInicioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fechaDeInicioLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.fechaDeInicioLabel.Location = New System.Drawing.Point(168, 204)
		Me.fechaDeInicioLabel.Name = "fechaDeInicioLabel"
		Me.fechaDeInicioLabel.Size = New System.Drawing.Size(135, 20)
		Me.fechaDeInicioLabel.TabIndex = 16
		Me.fechaDeInicioLabel.Text = "Fecha de inicio:"
		'
		'estadoDeViajeLabel
		'
		Me.estadoDeViajeLabel.AutoSize = True
		Me.estadoDeViajeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.estadoDeViajeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.estadoDeViajeLabel.Location = New System.Drawing.Point(221, 251)
		Me.estadoDeViajeLabel.Name = "estadoDeViajeLabel"
		Me.estadoDeViajeLabel.Size = New System.Drawing.Size(71, 20)
		Me.estadoDeViajeLabel.TabIndex = 14
		Me.estadoDeViajeLabel.Text = "Estado:"
		'
		'nombreDelLoteLabel
		'
		Me.nombreDelLoteLabel.AutoSize = True
		Me.nombreDelLoteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.nombreDelLoteLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.nombreDelLoteLabel.Location = New System.Drawing.Point(146, 155)
		Me.nombreDelLoteLabel.Name = "nombreDelLoteLabel"
		Me.nombreDelLoteLabel.Size = New System.Drawing.Size(146, 20)
		Me.nombreDelLoteLabel.TabIndex = 15
		Me.nombreDelLoteLabel.Text = "Nombre del Lote:"
		'
		'finalizarViajeButton
		'
		Me.finalizarViajeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.finalizarViajeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.finalizarViajeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.finalizarViajeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.finalizarViajeButton.Location = New System.Drawing.Point(128, 396)
		Me.finalizarViajeButton.Name = "finalizarViajeButton"
		Me.finalizarViajeButton.Size = New System.Drawing.Size(347, 48)
		Me.finalizarViajeButton.TabIndex = 1
		Me.finalizarViajeButton.Text = "Finalizar"
		Me.finalizarViajeButton.UseVisualStyleBackColor = True
		'
		'procesoViajeLabel
		'
		Me.procesoViajeLabel.AutoSize = True
		Me.procesoViajeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
		Me.procesoViajeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.procesoViajeLabel.Location = New System.Drawing.Point(204, 20)
		Me.procesoViajeLabel.Name = "procesoViajeLabel"
		Me.procesoViajeLabel.Size = New System.Drawing.Size(200, 29)
		Me.procesoViajeLabel.TabIndex = 13
		Me.procesoViajeLabel.Text = "Viaje en proceso:"
		'
		'tiempoTranscurridoTimer
		'
		Me.tiempoTranscurridoTimer.Enabled = True
		Me.tiempoTranscurridoTimer.Interval = 1000
		'
		'verViajesPanel
		'
		Me.verViajesPanel.Controls.Add(Me.verViajesDGV)
		Me.verViajesPanel.Controls.Add(Me.verViajesLabel)
		Me.verViajesPanel.Location = New System.Drawing.Point(172, 35)
		Me.verViajesPanel.Name = "verViajesPanel"
		Me.verViajesPanel.Size = New System.Drawing.Size(616, 479)
		Me.verViajesPanel.TabIndex = 21
		Me.verViajesPanel.Visible = False
		'
		'verViajesLabel
		'
		Me.verViajesLabel.AutoSize = True
		Me.verViajesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
		Me.verViajesLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.verViajesLabel.Location = New System.Drawing.Point(232, 10)
		Me.verViajesLabel.Name = "verViajesLabel"
		Me.verViajesLabel.Size = New System.Drawing.Size(118, 29)
		Me.verViajesLabel.TabIndex = 4
		Me.verViajesLabel.Text = "Ver viajes"
		'
		'verViajesDGV
		'
		Me.verViajesDGV.AllowUserToAddRows = False
		Me.verViajesDGV.AllowUserToDeleteRows = False
		Me.verViajesDGV.AllowUserToOrderColumns = True
		Me.verViajesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.verViajesDGV.Location = New System.Drawing.Point(11, 70)
		Me.verViajesDGV.Name = "verViajesDGV"
		Me.verViajesDGV.ReadOnly = True
		Me.verViajesDGV.Size = New System.Drawing.Size(587, 395)
		Me.verViajesDGV.TabIndex = 5
		'
		'transportista
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(800, 530)
		Me.Controls.Add(Me.verViajesPanel)
		Me.Controls.Add(Me.procesoViajePanel)
		Me.Controls.Add(Me.selecLotePanel)
		Me.Controls.Add(Me.topBarPanel)
		Me.Controls.Add(Me.TabPanel)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(800, 530)
		Me.MinimizeBox = False
		Me.MinimumSize = New System.Drawing.Size(800, 530)
		Me.Name = "transportista"
		Me.Text = "Transportista"
		Me.topBarPanel.ResumeLayout(False)
		Me.topBarPanel.PerformLayout()
		Me.TabPanel.ResumeLayout(False)
		Me.selecLotePanel.ResumeLayout(False)
		Me.selecLotePanel.PerformLayout()
		Me.verLotesDGVpanel.ResumeLayout(False)
		CType(Me.verLotesDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.procesoViajePanel.ResumeLayout(False)
		Me.procesoViajePanel.PerformLayout()
		Me.verViajesPanel.ResumeLayout(False)
		Me.verViajesPanel.PerformLayout()
		CType(Me.verViajesDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents topBarPanel As Panel
	Friend WithEvents cerrar As Label
	Friend WithEvents mainLabel As Label
	Friend WithEvents TabPanel As Panel
	Friend WithEvents viajeButton As Button
	Friend WithEvents registrarVehiculoButton As Button
	Friend WithEvents verViajesButton As Button
	Friend WithEvents cLoteButton As Button
	Friend WithEvents verInspeccionButton As Button
	Friend WithEvents realizarInspeccionButton As Button
	Friend WithEvents salirButton As Button
	Friend WithEvents verVehiculoButton As Button
	Friend WithEvents atrasButton As Button
	Friend WithEvents verLotesButton As Button
	Friend WithEvents selecLotePanel As Panel
	Friend WithEvents iniciarViajeButton As Button
	Friend WithEvents verLotesDGVpanel As Panel
	Friend WithEvents selecLoteText As Label
	Friend WithEvents verLotesDGV As DataGridView
	Friend WithEvents procesoViajePanel As Panel
	Friend WithEvents finalizarViajeButton As Button
	Friend WithEvents procesoViajeLabel As Label
	Friend WithEvents estadoLabel As Label
	Friend WithEvents fechaInicioLabel As Label
	Friend WithEvents nombreLoteLabel As Label
	Friend WithEvents fechaDeInicioLabel As Label
	Friend WithEvents estadoDeViajeLabel As Label
	Friend WithEvents nombreDelLoteLabel As Label
	Friend WithEvents tiempoTranscurridoLabel As Label
	Friend WithEvents tiempoTranscurridoTimer As Timer
	Friend WithEvents verViajesPanel As Panel
	Friend WithEvents verViajesDGV As DataGridView
	Friend WithEvents verViajesLabel As Label
End Class
