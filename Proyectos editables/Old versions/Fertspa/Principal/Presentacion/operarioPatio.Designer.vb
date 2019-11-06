<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class operarioPatio
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(operarioPatio))
		Me.TabPanel = New System.Windows.Forms.Panel()
		Me.realizarButton = New System.Windows.Forms.Button()
		Me.ubicarMenuButton = New System.Windows.Forms.Button()
		Me.ubicarButton = New System.Windows.Forms.Button()
		Me.verZonasButton = New System.Windows.Forms.Button()
		Me.verInspeccionButton = New System.Windows.Forms.Button()
		Me.realizarInspeccionButton = New System.Windows.Forms.Button()
		Me.inspeccionButton = New System.Windows.Forms.Button()
		Me.atrasButton = New System.Windows.Forms.Button()
		Me.salirButton = New System.Windows.Forms.Button()
		Me.topBarPanel = New System.Windows.Forms.Panel()
		Me.cerrar = New System.Windows.Forms.Label()
		Me.mainLabel = New System.Windows.Forms.Label()
		Me.verInspeccionPanel = New System.Windows.Forms.Panel()
		Me.verInspeccionLabel = New System.Windows.Forms.Label()
		Me.verInspeccionesDGV = New System.Windows.Forms.DataGridView()
		Me.ubicarPanel = New System.Windows.Forms.Panel()
		Me.zonaLabel = New System.Windows.Forms.Label()
		Me.vehiculoLabel = New System.Windows.Forms.Label()
		Me.zonaAUbicarDGV = New System.Windows.Forms.DataGridView()
		Me.vehiculoAUbicarDGV = New System.Windows.Forms.DataGridView()
		Me.ubicarLabel = New System.Windows.Forms.Label()
		Me.verZonasPanel = New System.Windows.Forms.Panel()
		Me.verZonasDGV = New System.Windows.Forms.DataGridView()
		Me.verZonasLabel = New System.Windows.Forms.Label()
		Me.realizarInspeccionPanel = New System.Windows.Forms.Panel()
		Me.cambiosPanel = New System.Windows.Forms.Panel()
		Me.cambiosNoButton = New System.Windows.Forms.Button()
		Me.cambiosSiButton = New System.Windows.Forms.Button()
		Me.cambiosLabel = New System.Windows.Forms.Label()
		Me.datosInspeccionPanel = New System.Windows.Forms.Panel()
		Me.evidenciaDettalleLabel = New System.Windows.Forms.Label()
		Me.danioLabel = New System.Windows.Forms.Label()
		Me.danioRichTextBox = New System.Windows.Forms.RichTextBox()
		Me.fechaInspeccionLabel = New System.Windows.Forms.Label()
		Me.lugarLabel = New System.Windows.Forms.Label()
		Me.dañoinspeccionPictureBox = New System.Windows.Forms.PictureBox()
		Me.numeroInspeccionLabel = New System.Windows.Forms.Label()
		Me.inspeccionDeVehiculo = New System.Windows.Forms.Label()
		Me.elegirVehiculoLabel = New System.Windows.Forms.Label()
		Me.realizarInspLabel = New System.Windows.Forms.Label()
		Me.vehiculosSInspeccionDGV = New System.Windows.Forms.DataGridView()
		Me.dañosPanel = New System.Windows.Forms.Panel()
		Me.evidenciaLabel = New System.Windows.Forms.Label()
		Me.evidenciaButton = New System.Windows.Forms.Button()
		Me.ingresarDañoButton = New System.Windows.Forms.Button()
		Me.descDañoRichTextBox = New System.Windows.Forms.RichTextBox()
		Me.descDañoLabel = New System.Windows.Forms.Label()
		Me.añadirDañosLabel = New System.Windows.Forms.Label()
		Me.imagenOFD = New System.Windows.Forms.OpenFileDialog()
		Me.TabPanel.SuspendLayout()
		Me.topBarPanel.SuspendLayout()
		Me.verInspeccionPanel.SuspendLayout()
		CType(Me.verInspeccionesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ubicarPanel.SuspendLayout()
		CType(Me.zonaAUbicarDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.vehiculoAUbicarDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.verZonasPanel.SuspendLayout()
		CType(Me.verZonasDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.realizarInspeccionPanel.SuspendLayout()
		Me.cambiosPanel.SuspendLayout()
		Me.datosInspeccionPanel.SuspendLayout()
		CType(Me.dañoinspeccionPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.vehiculosSInspeccionDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.dañosPanel.SuspendLayout()
		Me.SuspendLayout()
		'
		'TabPanel
		'
		Me.TabPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.TabPanel.Controls.Add(Me.realizarButton)
		Me.TabPanel.Controls.Add(Me.ubicarMenuButton)
		Me.TabPanel.Controls.Add(Me.ubicarButton)
		Me.TabPanel.Controls.Add(Me.verZonasButton)
		Me.TabPanel.Controls.Add(Me.verInspeccionButton)
		Me.TabPanel.Controls.Add(Me.realizarInspeccionButton)
		Me.TabPanel.Controls.Add(Me.inspeccionButton)
		Me.TabPanel.Controls.Add(Me.atrasButton)
		Me.TabPanel.Controls.Add(Me.salirButton)
		Me.TabPanel.Location = New System.Drawing.Point(-5, 30)
		Me.TabPanel.Name = "TabPanel"
		Me.TabPanel.Size = New System.Drawing.Size(170, 500)
		Me.TabPanel.TabIndex = 4
		'
		'realizarButton
		'
		Me.realizarButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.realizarButton.FlatAppearance.BorderSize = 0
		Me.realizarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.realizarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.realizarButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.realizarButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.realizarButton.Location = New System.Drawing.Point(3, 44)
		Me.realizarButton.Name = "realizarButton"
		Me.realizarButton.Size = New System.Drawing.Size(166, 34)
		Me.realizarButton.TabIndex = 17
		Me.realizarButton.Text = "Inspeccion"
		Me.realizarButton.UseVisualStyleBackColor = False
		Me.realizarButton.Visible = False
		'
		'ubicarMenuButton
		'
		Me.ubicarMenuButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.ubicarMenuButton.FlatAppearance.BorderSize = 0
		Me.ubicarMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ubicarMenuButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.ubicarMenuButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.ubicarMenuButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.ubicarMenuButton.Location = New System.Drawing.Point(5, 100)
		Me.ubicarMenuButton.Name = "ubicarMenuButton"
		Me.ubicarMenuButton.Size = New System.Drawing.Size(166, 34)
		Me.ubicarMenuButton.TabIndex = 19
		Me.ubicarMenuButton.Text = "Ubicar"
		Me.ubicarMenuButton.UseVisualStyleBackColor = False
		'
		'ubicarButton
		'
		Me.ubicarButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.ubicarButton.FlatAppearance.BorderSize = 0
		Me.ubicarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ubicarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.ubicarButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.ubicarButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.ubicarButton.Location = New System.Drawing.Point(3, 44)
		Me.ubicarButton.Name = "ubicarButton"
		Me.ubicarButton.Size = New System.Drawing.Size(166, 34)
		Me.ubicarButton.TabIndex = 20
		Me.ubicarButton.Text = "Ubicar"
		Me.ubicarButton.UseVisualStyleBackColor = False
		Me.ubicarButton.Visible = False
		'
		'verZonasButton
		'
		Me.verZonasButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.verZonasButton.FlatAppearance.BorderSize = 0
		Me.verZonasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.verZonasButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.verZonasButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.verZonasButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.verZonasButton.Location = New System.Drawing.Point(5, 100)
		Me.verZonasButton.Name = "verZonasButton"
		Me.verZonasButton.Size = New System.Drawing.Size(166, 34)
		Me.verZonasButton.TabIndex = 18
		Me.verZonasButton.Text = "Ver Zonas"
		Me.verZonasButton.UseVisualStyleBackColor = False
		Me.verZonasButton.Visible = False
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
		Me.verInspeccionButton.TabIndex = 16
		Me.verInspeccionButton.Text = "Ver Inspecciones"
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
		Me.realizarInspeccionButton.Location = New System.Drawing.Point(5, 44)
		Me.realizarInspeccionButton.Name = "realizarInspeccionButton"
		Me.realizarInspeccionButton.Size = New System.Drawing.Size(166, 34)
		Me.realizarInspeccionButton.TabIndex = 15
		Me.realizarInspeccionButton.Text = "Realizar"
		Me.realizarInspeccionButton.UseVisualStyleBackColor = False
		Me.realizarInspeccionButton.Visible = False
		'
		'inspeccionButton
		'
		Me.inspeccionButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.inspeccionButton.FlatAppearance.BorderSize = 0
		Me.inspeccionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.inspeccionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
		Me.inspeccionButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.inspeccionButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.inspeccionButton.Location = New System.Drawing.Point(5, 44)
		Me.inspeccionButton.Name = "inspeccionButton"
		Me.inspeccionButton.Size = New System.Drawing.Size(166, 34)
		Me.inspeccionButton.TabIndex = 1
		Me.inspeccionButton.Text = "Inspeccion"
		Me.inspeccionButton.UseVisualStyleBackColor = False
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
		'topBarPanel
		'
		Me.topBarPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.topBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.topBarPanel.Controls.Add(Me.cerrar)
		Me.topBarPanel.Controls.Add(Me.mainLabel)
		Me.topBarPanel.Location = New System.Drawing.Point(-5, -3)
		Me.topBarPanel.Name = "topBarPanel"
		Me.topBarPanel.Size = New System.Drawing.Size(813, 36)
		Me.topBarPanel.TabIndex = 18
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
		'verInspeccionPanel
		'
		Me.verInspeccionPanel.Controls.Add(Me.verInspeccionLabel)
		Me.verInspeccionPanel.Controls.Add(Me.verInspeccionesDGV)
		Me.verInspeccionPanel.Location = New System.Drawing.Point(172, 35)
		Me.verInspeccionPanel.Name = "verInspeccionPanel"
		Me.verInspeccionPanel.Size = New System.Drawing.Size(616, 482)
		Me.verInspeccionPanel.TabIndex = 23
		Me.verInspeccionPanel.Visible = False
		'
		'verInspeccionLabel
		'
		Me.verInspeccionLabel.AutoSize = True
		Me.verInspeccionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
		Me.verInspeccionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.verInspeccionLabel.Location = New System.Drawing.Point(203, 5)
		Me.verInspeccionLabel.Name = "verInspeccionLabel"
		Me.verInspeccionLabel.Size = New System.Drawing.Size(198, 29)
		Me.verInspeccionLabel.TabIndex = 2
		Me.verInspeccionLabel.Text = "Ver inspecciones"
		'
		'verInspeccionesDGV
		'
		Me.verInspeccionesDGV.AllowUserToAddRows = False
		Me.verInspeccionesDGV.AllowUserToDeleteRows = False
		Me.verInspeccionesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.verInspeccionesDGV.Location = New System.Drawing.Point(6, 39)
		Me.verInspeccionesDGV.Name = "verInspeccionesDGV"
		Me.verInspeccionesDGV.ReadOnly = True
		Me.verInspeccionesDGV.Size = New System.Drawing.Size(603, 437)
		Me.verInspeccionesDGV.TabIndex = 1
		'
		'ubicarPanel
		'
		Me.ubicarPanel.Controls.Add(Me.zonaLabel)
		Me.ubicarPanel.Controls.Add(Me.vehiculoLabel)
		Me.ubicarPanel.Controls.Add(Me.zonaAUbicarDGV)
		Me.ubicarPanel.Controls.Add(Me.vehiculoAUbicarDGV)
		Me.ubicarPanel.Controls.Add(Me.ubicarLabel)
		Me.ubicarPanel.Location = New System.Drawing.Point(172, 35)
		Me.ubicarPanel.Name = "ubicarPanel"
		Me.ubicarPanel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ubicarPanel.Size = New System.Drawing.Size(616, 482)
		Me.ubicarPanel.TabIndex = 3
		Me.ubicarPanel.Visible = False
		'
		'zonaLabel
		'
		Me.zonaLabel.AutoSize = True
		Me.zonaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.zonaLabel.Location = New System.Drawing.Point(409, 107)
		Me.zonaLabel.Name = "zonaLabel"
		Me.zonaLabel.Size = New System.Drawing.Size(115, 13)
		Me.zonaLabel.TabIndex = 7
		Me.zonaLabel.Text = "Seleccione la zona"
		'
		'vehiculoLabel
		'
		Me.vehiculoLabel.AutoSize = True
		Me.vehiculoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
		Me.vehiculoLabel.Location = New System.Drawing.Point(83, 107)
		Me.vehiculoLabel.Name = "vehiculoLabel"
		Me.vehiculoLabel.Size = New System.Drawing.Size(136, 13)
		Me.vehiculoLabel.TabIndex = 6
		Me.vehiculoLabel.Text = "Seleccione el vehiculo"
		'
		'zonaAUbicarDGV
		'
		Me.zonaAUbicarDGV.AllowUserToAddRows = False
		Me.zonaAUbicarDGV.AllowUserToDeleteRows = False
		Me.zonaAUbicarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.zonaAUbicarDGV.Location = New System.Drawing.Point(355, 123)
		Me.zonaAUbicarDGV.Name = "zonaAUbicarDGV"
		Me.zonaAUbicarDGV.Size = New System.Drawing.Size(228, 339)
		Me.zonaAUbicarDGV.TabIndex = 5
		'
		'vehiculoAUbicarDGV
		'
		Me.vehiculoAUbicarDGV.AllowUserToAddRows = False
		Me.vehiculoAUbicarDGV.AllowUserToDeleteRows = False
		Me.vehiculoAUbicarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.vehiculoAUbicarDGV.Location = New System.Drawing.Point(37, 125)
		Me.vehiculoAUbicarDGV.Name = "vehiculoAUbicarDGV"
		Me.vehiculoAUbicarDGV.Size = New System.Drawing.Size(228, 339)
		Me.vehiculoAUbicarDGV.TabIndex = 4
		'
		'ubicarLabel
		'
		Me.ubicarLabel.AutoSize = True
		Me.ubicarLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
		Me.ubicarLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.ubicarLabel.Location = New System.Drawing.Point(208, 5)
		Me.ubicarLabel.Name = "ubicarLabel"
		Me.ubicarLabel.Size = New System.Drawing.Size(182, 29)
		Me.ubicarLabel.TabIndex = 3
		Me.ubicarLabel.Text = "Ubicar Vehiculo"
		'
		'verZonasPanel
		'
		Me.verZonasPanel.Controls.Add(Me.verZonasDGV)
		Me.verZonasPanel.Controls.Add(Me.verZonasLabel)
		Me.verZonasPanel.Location = New System.Drawing.Point(172, 35)
		Me.verZonasPanel.Name = "verZonasPanel"
		Me.verZonasPanel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.verZonasPanel.Size = New System.Drawing.Size(616, 482)
		Me.verZonasPanel.TabIndex = 4
		Me.verZonasPanel.Visible = False
		'
		'verZonasDGV
		'
		Me.verZonasDGV.AllowUserToAddRows = False
		Me.verZonasDGV.AllowUserToDeleteRows = False
		Me.verZonasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.verZonasDGV.Location = New System.Drawing.Point(6, 39)
		Me.verZonasDGV.Name = "verZonasDGV"
		Me.verZonasDGV.ReadOnly = True
		Me.verZonasDGV.Size = New System.Drawing.Size(603, 437)
		Me.verZonasDGV.TabIndex = 4
		'
		'verZonasLabel
		'
		Me.verZonasLabel.AutoSize = True
		Me.verZonasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
		Me.verZonasLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.verZonasLabel.Location = New System.Drawing.Point(243, 5)
		Me.verZonasLabel.Name = "verZonasLabel"
		Me.verZonasLabel.Size = New System.Drawing.Size(122, 29)
		Me.verZonasLabel.TabIndex = 3
		Me.verZonasLabel.Text = "Ver Zonas"
		'
		'realizarInspeccionPanel
		'
		Me.realizarInspeccionPanel.Controls.Add(Me.cambiosPanel)
		Me.realizarInspeccionPanel.Controls.Add(Me.datosInspeccionPanel)
		Me.realizarInspeccionPanel.Controls.Add(Me.elegirVehiculoLabel)
		Me.realizarInspeccionPanel.Controls.Add(Me.realizarInspLabel)
		Me.realizarInspeccionPanel.Controls.Add(Me.vehiculosSInspeccionDGV)
		Me.realizarInspeccionPanel.Location = New System.Drawing.Point(172, 35)
		Me.realizarInspeccionPanel.Name = "realizarInspeccionPanel"
		Me.realizarInspeccionPanel.Size = New System.Drawing.Size(616, 482)
		Me.realizarInspeccionPanel.TabIndex = 5
		Me.realizarInspeccionPanel.Visible = False
		'
		'cambiosPanel
		'
		Me.cambiosPanel.Controls.Add(Me.cambiosNoButton)
		Me.cambiosPanel.Controls.Add(Me.cambiosSiButton)
		Me.cambiosPanel.Controls.Add(Me.cambiosLabel)
		Me.cambiosPanel.Location = New System.Drawing.Point(6, 415)
		Me.cambiosPanel.Name = "cambiosPanel"
		Me.cambiosPanel.Size = New System.Drawing.Size(600, 60)
		Me.cambiosPanel.TabIndex = 11
		'
		'cambiosNoButton
		'
		Me.cambiosNoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.cambiosNoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cambiosNoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.cambiosNoButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.cambiosNoButton.Location = New System.Drawing.Point(406, 12)
		Me.cambiosNoButton.Name = "cambiosNoButton"
		Me.cambiosNoButton.Size = New System.Drawing.Size(153, 41)
		Me.cambiosNoButton.TabIndex = 10
		Me.cambiosNoButton.Text = "No"
		Me.cambiosNoButton.UseVisualStyleBackColor = True
		'
		'cambiosSiButton
		'
		Me.cambiosSiButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.cambiosSiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cambiosSiButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.cambiosSiButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.cambiosSiButton.Location = New System.Drawing.Point(231, 12)
		Me.cambiosSiButton.Name = "cambiosSiButton"
		Me.cambiosSiButton.Size = New System.Drawing.Size(153, 41)
		Me.cambiosSiButton.TabIndex = 9
		Me.cambiosSiButton.Text = "Si"
		Me.cambiosSiButton.UseVisualStyleBackColor = True
		'
		'cambiosLabel
		'
		Me.cambiosLabel.AutoSize = True
		Me.cambiosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
		Me.cambiosLabel.ForeColor = System.Drawing.Color.Red
		Me.cambiosLabel.Location = New System.Drawing.Point(13, 21)
		Me.cambiosLabel.Name = "cambiosLabel"
		Me.cambiosLabel.Size = New System.Drawing.Size(183, 20)
		Me.cambiosLabel.TabIndex = 8
		Me.cambiosLabel.Text = "Hay cambios en el auto?"
		'
		'datosInspeccionPanel
		'
		Me.datosInspeccionPanel.Controls.Add(Me.evidenciaDettalleLabel)
		Me.datosInspeccionPanel.Controls.Add(Me.danioLabel)
		Me.datosInspeccionPanel.Controls.Add(Me.danioRichTextBox)
		Me.datosInspeccionPanel.Controls.Add(Me.fechaInspeccionLabel)
		Me.datosInspeccionPanel.Controls.Add(Me.lugarLabel)
		Me.datosInspeccionPanel.Controls.Add(Me.dañoinspeccionPictureBox)
		Me.datosInspeccionPanel.Controls.Add(Me.numeroInspeccionLabel)
		Me.datosInspeccionPanel.Controls.Add(Me.inspeccionDeVehiculo)
		Me.datosInspeccionPanel.Location = New System.Drawing.Point(6, 233)
		Me.datosInspeccionPanel.Name = "datosInspeccionPanel"
		Me.datosInspeccionPanel.Size = New System.Drawing.Size(603, 173)
		Me.datosInspeccionPanel.TabIndex = 10
		'
		'evidenciaDettalleLabel
		'
		Me.evidenciaDettalleLabel.AutoSize = True
		Me.evidenciaDettalleLabel.Location = New System.Drawing.Point(454, 4)
		Me.evidenciaDettalleLabel.Name = "evidenciaDettalleLabel"
		Me.evidenciaDettalleLabel.Size = New System.Drawing.Size(54, 13)
		Me.evidenciaDettalleLabel.TabIndex = 15
		Me.evidenciaDettalleLabel.Text = "Evidencia"
		'
		'danioLabel
		'
		Me.danioLabel.AutoSize = True
		Me.danioLabel.Location = New System.Drawing.Point(239, 21)
		Me.danioLabel.Name = "danioLabel"
		Me.danioLabel.Size = New System.Drawing.Size(36, 13)
		Me.danioLabel.TabIndex = 14
		Me.danioLabel.Text = "Daño:"
		'
		'danioRichTextBox
		'
		Me.danioRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.danioRichTextBox.Location = New System.Drawing.Point(289, 21)
		Me.danioRichTextBox.Name = "danioRichTextBox"
		Me.danioRichTextBox.Size = New System.Drawing.Size(139, 127)
		Me.danioRichTextBox.TabIndex = 13
		Me.danioRichTextBox.Text = ""
		'
		'fechaInspeccionLabel
		'
		Me.fechaInspeccionLabel.AutoSize = True
		Me.fechaInspeccionLabel.Location = New System.Drawing.Point(12, 110)
		Me.fechaInspeccionLabel.Name = "fechaInspeccionLabel"
		Me.fechaInspeccionLabel.Size = New System.Drawing.Size(43, 13)
		Me.fechaInspeccionLabel.TabIndex = 12
		Me.fechaInspeccionLabel.Text = "Fecha :"
		'
		'lugarLabel
		'
		Me.lugarLabel.AutoSize = True
		Me.lugarLabel.Location = New System.Drawing.Point(12, 73)
		Me.lugarLabel.Name = "lugarLabel"
		Me.lugarLabel.Size = New System.Drawing.Size(40, 13)
		Me.lugarLabel.TabIndex = 11
		Me.lugarLabel.Text = "Lugar :"
		'
		'dañoinspeccionPictureBox
		'
		Me.dañoinspeccionPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.dañoinspeccionPictureBox.Location = New System.Drawing.Point(450, 21)
		Me.dañoinspeccionPictureBox.Name = "dañoinspeccionPictureBox"
		Me.dañoinspeccionPictureBox.Size = New System.Drawing.Size(139, 131)
		Me.dañoinspeccionPictureBox.TabIndex = 10
		Me.dañoinspeccionPictureBox.TabStop = False
		'
		'numeroInspeccionLabel
		'
		Me.numeroInspeccionLabel.AutoSize = True
		Me.numeroInspeccionLabel.Location = New System.Drawing.Point(12, 36)
		Me.numeroInspeccionLabel.Name = "numeroInspeccionLabel"
		Me.numeroInspeccionLabel.Size = New System.Drawing.Size(80, 13)
		Me.numeroInspeccionLabel.TabIndex = 9
		Me.numeroInspeccionLabel.Text = "Inspeccion Nº :"
		'
		'inspeccionDeVehiculo
		'
		Me.inspeccionDeVehiculo.AutoSize = True
		Me.inspeccionDeVehiculo.ForeColor = System.Drawing.Color.Red
		Me.inspeccionDeVehiculo.Location = New System.Drawing.Point(3, 0)
		Me.inspeccionDeVehiculo.Name = "inspeccionDeVehiculo"
		Me.inspeccionDeVehiculo.Size = New System.Drawing.Size(119, 13)
		Me.inspeccionDeVehiculo.TabIndex = 7
		Me.inspeccionDeVehiculo.Text = "Inspeccion del vehiculo"
		'
		'elegirVehiculoLabel
		'
		Me.elegirVehiculoLabel.AutoSize = True
		Me.elegirVehiculoLabel.ForeColor = System.Drawing.Color.Red
		Me.elegirVehiculoLabel.Location = New System.Drawing.Point(3, 70)
		Me.elegirVehiculoLabel.Name = "elegirVehiculoLabel"
		Me.elegirVehiculoLabel.Size = New System.Drawing.Size(156, 13)
		Me.elegirVehiculoLabel.TabIndex = 5
		Me.elegirVehiculoLabel.Text = "Elige el vehiculo a inspeccionar"
		'
		'realizarInspLabel
		'
		Me.realizarInspLabel.AutoSize = True
		Me.realizarInspLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
		Me.realizarInspLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.realizarInspLabel.Location = New System.Drawing.Point(193, 7)
		Me.realizarInspLabel.Name = "realizarInspLabel"
		Me.realizarInspLabel.Size = New System.Drawing.Size(223, 29)
		Me.realizarInspLabel.TabIndex = 4
		Me.realizarInspLabel.Text = "Realizar Inspeccion"
		'
		'vehiculosSInspeccionDGV
		'
		Me.vehiculosSInspeccionDGV.AllowUserToAddRows = False
		Me.vehiculosSInspeccionDGV.AllowUserToDeleteRows = False
		Me.vehiculosSInspeccionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.vehiculosSInspeccionDGV.Location = New System.Drawing.Point(6, 95)
		Me.vehiculosSInspeccionDGV.Name = "vehiculosSInspeccionDGV"
		Me.vehiculosSInspeccionDGV.ReadOnly = True
		Me.vehiculosSInspeccionDGV.Size = New System.Drawing.Size(359, 122)
		Me.vehiculosSInspeccionDGV.TabIndex = 0
		'
		'dañosPanel
		'
		Me.dañosPanel.Controls.Add(Me.evidenciaLabel)
		Me.dañosPanel.Controls.Add(Me.evidenciaButton)
		Me.dañosPanel.Controls.Add(Me.ingresarDañoButton)
		Me.dañosPanel.Controls.Add(Me.descDañoRichTextBox)
		Me.dañosPanel.Controls.Add(Me.descDañoLabel)
		Me.dañosPanel.Controls.Add(Me.añadirDañosLabel)
		Me.dañosPanel.Location = New System.Drawing.Point(172, 35)
		Me.dañosPanel.Name = "dañosPanel"
		Me.dañosPanel.Size = New System.Drawing.Size(616, 482)
		Me.dañosPanel.TabIndex = 25
		Me.dañosPanel.Visible = False
		'
		'evidenciaLabel
		'
		Me.evidenciaLabel.AutoSize = True
		Me.evidenciaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
		Me.evidenciaLabel.ForeColor = System.Drawing.Color.Red
		Me.evidenciaLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.evidenciaLabel.Location = New System.Drawing.Point(428, 389)
		Me.evidenciaLabel.Name = "evidenciaLabel"
		Me.evidenciaLabel.Size = New System.Drawing.Size(172, 13)
		Me.evidenciaLabel.TabIndex = 15
		Me.evidenciaLabel.Text = "Ningun archivo seleccionado"
		'
		'evidenciaButton
		'
		Me.evidenciaButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.evidenciaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.evidenciaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.evidenciaButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.evidenciaButton.Location = New System.Drawing.Point(318, 379)
		Me.evidenciaButton.Name = "evidenciaButton"
		Me.evidenciaButton.Size = New System.Drawing.Size(104, 33)
		Me.evidenciaButton.TabIndex = 14
		Me.evidenciaButton.Text = "Subir evidencia"
		Me.evidenciaButton.UseVisualStyleBackColor = True
		'
		'ingresarDañoButton
		'
		Me.ingresarDañoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.ingresarDañoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ingresarDañoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.ingresarDañoButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.ingresarDañoButton.Location = New System.Drawing.Point(208, 379)
		Me.ingresarDañoButton.Name = "ingresarDañoButton"
		Me.ingresarDañoButton.Size = New System.Drawing.Size(89, 33)
		Me.ingresarDañoButton.TabIndex = 13
		Me.ingresarDañoButton.Text = "Ingresar"
		Me.ingresarDañoButton.UseVisualStyleBackColor = True
		'
		'descDañoRichTextBox
		'
		Me.descDañoRichTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
		Me.descDañoRichTextBox.Location = New System.Drawing.Point(81, 113)
		Me.descDañoRichTextBox.Name = "descDañoRichTextBox"
		Me.descDañoRichTextBox.Size = New System.Drawing.Size(425, 219)
		Me.descDañoRichTextBox.TabIndex = 2
		Me.descDañoRichTextBox.Text = ""
		'
		'descDañoLabel
		'
		Me.descDañoLabel.AutoSize = True
		Me.descDañoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
		Me.descDañoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.descDañoLabel.Location = New System.Drawing.Point(77, 81)
		Me.descDañoLabel.Name = "descDañoLabel"
		Me.descDañoLabel.Size = New System.Drawing.Size(429, 20)
		Me.descDañoLabel.TabIndex = 1
		Me.descDañoLabel.Text = "Describa el/los daño/s que tiene el vehículo detalladamente:"
		'
		'añadirDañosLabel
		'
		Me.añadirDañosLabel.AutoSize = True
		Me.añadirDañosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
		Me.añadirDañosLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.añadirDañosLabel.Location = New System.Drawing.Point(222, 20)
		Me.añadirDañosLabel.Name = "añadirDañosLabel"
		Me.añadirDañosLabel.Size = New System.Drawing.Size(163, 29)
		Me.añadirDañosLabel.TabIndex = 0
		Me.añadirDañosLabel.Text = "Añadir Daños:"
		'
		'imagenOFD
		'
		Me.imagenOFD.Filter = """Imagen(.jpg;.png;.bmp|*.jpg;*.png;*.bmp"""
		'
		'operarioPatio
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 530)
		Me.Controls.Add(Me.dañosPanel)
		Me.Controls.Add(Me.realizarInspeccionPanel)
		Me.Controls.Add(Me.verZonasPanel)
		Me.Controls.Add(Me.ubicarPanel)
		Me.Controls.Add(Me.verInspeccionPanel)
		Me.Controls.Add(Me.topBarPanel)
		Me.Controls.Add(Me.TabPanel)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximumSize = New System.Drawing.Size(800, 530)
		Me.MinimumSize = New System.Drawing.Size(800, 530)
		Me.Name = "operarioPatio"
		Me.Text = "Operario Patio"
		Me.TabPanel.ResumeLayout(False)
		Me.topBarPanel.ResumeLayout(False)
		Me.topBarPanel.PerformLayout()
		Me.verInspeccionPanel.ResumeLayout(False)
		Me.verInspeccionPanel.PerformLayout()
		CType(Me.verInspeccionesDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ubicarPanel.ResumeLayout(False)
		Me.ubicarPanel.PerformLayout()
		CType(Me.zonaAUbicarDGV, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.vehiculoAUbicarDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.verZonasPanel.ResumeLayout(False)
		Me.verZonasPanel.PerformLayout()
		CType(Me.verZonasDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.realizarInspeccionPanel.ResumeLayout(False)
		Me.realizarInspeccionPanel.PerformLayout()
		Me.cambiosPanel.ResumeLayout(False)
		Me.cambiosPanel.PerformLayout()
		Me.datosInspeccionPanel.ResumeLayout(False)
		Me.datosInspeccionPanel.PerformLayout()
		CType(Me.dañoinspeccionPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.vehiculosSInspeccionDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.dañosPanel.ResumeLayout(False)
		Me.dañosPanel.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents TabPanel As Panel
	Friend WithEvents inspeccionButton As Button
	Friend WithEvents atrasButton As Button
	Friend WithEvents salirButton As Button
	Friend WithEvents topBarPanel As Panel
	Friend WithEvents cerrar As Label
	Friend WithEvents mainLabel As Label
	Friend WithEvents verInspeccionButton As Button
	Friend WithEvents realizarInspeccionButton As Button
	Friend WithEvents verInspeccionPanel As Panel
	Friend WithEvents verInspeccionLabel As Label
	Friend WithEvents verInspeccionesDGV As DataGridView
	Friend WithEvents ubicarPanel As Panel
	Friend WithEvents realizarButton As Button
	Friend WithEvents verZonasButton As Button
	Friend WithEvents verZonasPanel As Panel
	Friend WithEvents ubicarLabel As Label
	Friend WithEvents verZonasLabel As Label
	Friend WithEvents zonaAUbicarDGV As DataGridView
	Friend WithEvents vehiculoAUbicarDGV As DataGridView
	Friend WithEvents zonaLabel As Label
	Friend WithEvents vehiculoLabel As Label
	Friend WithEvents verZonasDGV As DataGridView
	Friend WithEvents realizarInspeccionPanel As Panel
	Friend WithEvents realizarInspLabel As Label
	Friend WithEvents vehiculosSInspeccionDGV As DataGridView
	Friend WithEvents elegirVehiculoLabel As Label
	Friend WithEvents inspeccionDeVehiculo As Label
	Friend WithEvents numeroInspeccionLabel As Label
	Friend WithEvents datosInspeccionPanel As Panel
	Friend WithEvents dañoinspeccionPictureBox As PictureBox
	Friend WithEvents lugarLabel As Label
	Friend WithEvents fechaInspeccionLabel As Label
	Friend WithEvents evidenciaDettalleLabel As Label
	Friend WithEvents danioLabel As Label
	Friend WithEvents danioRichTextBox As RichTextBox
	Friend WithEvents cambiosPanel As Panel
	Friend WithEvents cambiosLabel As Label
	Friend WithEvents cambiosNoButton As Button
	Friend WithEvents cambiosSiButton As Button
	Friend WithEvents dañosPanel As Panel
	Friend WithEvents evidenciaLabel As Label
	Friend WithEvents evidenciaButton As Button
	Friend WithEvents ingresarDañoButton As Button
	Friend WithEvents descDañoRichTextBox As RichTextBox
	Friend WithEvents descDañoLabel As Label
	Friend WithEvents añadirDañosLabel As Label
	Friend WithEvents ubicarMenuButton As Button
	Friend WithEvents ubicarButton As Button
	Friend WithEvents imagenOFD As OpenFileDialog
End Class
