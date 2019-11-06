<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class operarioPuerto
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(operarioPuerto))
		Me.TabPanel = New System.Windows.Forms.Panel()
		Me.modificarLoteButton = New System.Windows.Forms.Button()
		Me.vehiculoButton = New System.Windows.Forms.Button()
		Me.registrarVehiculoButton = New System.Windows.Forms.Button()
		Me.verLoteButton = New System.Windows.Forms.Button()
		Me.cLoteButton = New System.Windows.Forms.Button()
		Me.verInspeccionButton = New System.Windows.Forms.Button()
		Me.realizarInspeccionButton = New System.Windows.Forms.Button()
		Me.inspeccionButton = New System.Windows.Forms.Button()
		Me.salirButton = New System.Windows.Forms.Button()
		Me.verVehiculoButton = New System.Windows.Forms.Button()
		Me.atrasButton = New System.Windows.Forms.Button()
		Me.verLotesButton = New System.Windows.Forms.Button()
		Me.ingresarVehiculoPanel = New System.Windows.Forms.Panel()
		Me.importarCSVButton = New System.Windows.Forms.Button()
		Me.codigoQRpictureBox = New System.Windows.Forms.PictureBox()
		Me.generarQRCheckBox = New System.Windows.Forms.CheckBox()
		Me.registrarVehiculoLabel = New System.Windows.Forms.Label()
		Me.ingresarVehiculoButton = New System.Windows.Forms.Button()
		Me.tipoComboBox = New System.Windows.Forms.ComboBox()
		Me.vinLabel = New System.Windows.Forms.Label()
		Me.tipoLabel = New System.Windows.Forms.Label()
		Me.colorTextBox = New System.Windows.Forms.TextBox()
		Me.vinTextBox = New System.Windows.Forms.TextBox()
		Me.anioTextBox = New System.Windows.Forms.TextBox()
		Me.colorLabel = New System.Windows.Forms.Label()
		Me.lblMarcaAuto = New System.Windows.Forms.Label()
		Me.modeloTextBox = New System.Windows.Forms.TextBox()
		Me.marcaTextBox = New System.Windows.Forms.TextBox()
		Me.añoLabel = New System.Windows.Forms.Label()
		Me.modeloLabel = New System.Windows.Forms.Label()
		Me.topBarPanel = New System.Windows.Forms.Panel()
		Me.cerrar = New System.Windows.Forms.Label()
		Me.mainLabel = New System.Windows.Forms.Label()
		Me.estadoDeVehiculoLabel = New System.Windows.Forms.Label()
		Me.listoButton = New System.Windows.Forms.Button()
		Me.dañadoButton = New System.Windows.Forms.Button()
		Me.realizarInspeccionPanel = New System.Windows.Forms.Panel()
		Me.seleccionarVehiculoInspeccionLabel = New System.Windows.Forms.Label()
		Me.verVehiculosSInspeccionDGV = New System.Windows.Forms.DataGridView()
		Me.añadirDañosLabel = New System.Windows.Forms.Label()
		Me.descDañoLabel = New System.Windows.Forms.Label()
		Me.descDañoRichTextBox = New System.Windows.Forms.RichTextBox()
		Me.ingresarDañoButton = New System.Windows.Forms.Button()
		Me.dañosPanel = New System.Windows.Forms.Panel()
		Me.evidenciaLabel = New System.Windows.Forms.Label()
		Me.evidenciaButton = New System.Windows.Forms.Button()
		Me.crearLotePanel = New System.Windows.Forms.Panel()
		Me.elegirAutosDeLoteLabel = New System.Windows.Forms.Label()
		Me.finalizarLoteButton = New System.Windows.Forms.Button()
		Me.vehiculosListaLabel = New System.Windows.Forms.Label()
		Me.vehiculoSLoteDGVpanel = New System.Windows.Forms.Panel()
		Me.vehiculoSLoteDGV = New System.Windows.Forms.DataGridView()
		Me.descLoteRichTextBox = New System.Windows.Forms.RichTextBox()
		Me.crearLoteLabel = New System.Windows.Forms.Label()
		Me.CrearLoteButton = New System.Windows.Forms.Button()
		Me.nombreLoteLabel = New System.Windows.Forms.Label()
		Me.nombreLoteTextbox = New System.Windows.Forms.TextBox()
		Me.descripcionLoteLabel = New System.Windows.Forms.Label()
		Me.verLotesText = New System.Windows.Forms.Label()
		Me.verLotesDGVpanel = New System.Windows.Forms.Panel()
		Me.verLotesDGV = New System.Windows.Forms.DataGridView()
		Me.verLotesPanel = New System.Windows.Forms.Panel()
		Me.eliminarLoteButton = New System.Windows.Forms.Button()
		Me.verVehiculosLabel = New System.Windows.Forms.Label()
		Me.verVehiculosDGVpanel = New System.Windows.Forms.Panel()
		Me.verVehiculosDGV = New System.Windows.Forms.DataGridView()
		Me.verVehiculosPanel = New System.Windows.Forms.Panel()
		Me.actualizarVerVehiculo = New System.Windows.Forms.Button()
		Me.BuscarButton = New System.Windows.Forms.Button()
		Me.ingresarVINLabel = New System.Windows.Forms.Label()
		Me.vinABuscarTextBox = New System.Windows.Forms.TextBox()
		Me.verInspeccionPanel = New System.Windows.Forms.Panel()
		Me.verInspeccionLabel = New System.Windows.Forms.Label()
		Me.verInspeccionesDGV = New System.Windows.Forms.DataGridView()
		Me.imagenOFD = New System.Windows.Forms.OpenFileDialog()
		Me.qrSFD = New System.Windows.Forms.SaveFileDialog()
		Me.importarCSVOFD = New System.Windows.Forms.OpenFileDialog()
		Me.modificarLotePanel = New System.Windows.Forms.Panel()
		Me.modificarLoteLabel = New System.Windows.Forms.Label()
		Me.elegirButton = New System.Windows.Forms.Button()
		Me.modificarLoteDGV = New System.Windows.Forms.DataGridView()
		Me.eleccionPanel = New System.Windows.Forms.Panel()
		Me.finalizarModButton = New System.Windows.Forms.Button()
		Me.vehiculosInspeccionadosLabel = New System.Windows.Forms.Label()
		Me.vehiculosEnLoteLabel = New System.Windows.Forms.Label()
		Me.vehiculoCInpseccionDGV = New System.Windows.Forms.DataGridView()
		Me.vehiculoEnLoteDGV = New System.Windows.Forms.DataGridView()
		Me.TabPanel.SuspendLayout()
		Me.ingresarVehiculoPanel.SuspendLayout()
		CType(Me.codigoQRpictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.topBarPanel.SuspendLayout()
		Me.realizarInspeccionPanel.SuspendLayout()
		CType(Me.verVehiculosSInspeccionDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.dañosPanel.SuspendLayout()
		Me.crearLotePanel.SuspendLayout()
		Me.vehiculoSLoteDGVpanel.SuspendLayout()
		CType(Me.vehiculoSLoteDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.verLotesDGVpanel.SuspendLayout()
		CType(Me.verLotesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.verLotesPanel.SuspendLayout()
		Me.verVehiculosDGVpanel.SuspendLayout()
		CType(Me.verVehiculosDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.verVehiculosPanel.SuspendLayout()
		Me.verInspeccionPanel.SuspendLayout()
		CType(Me.verInspeccionesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.modificarLotePanel.SuspendLayout()
		CType(Me.modificarLoteDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.eleccionPanel.SuspendLayout()
		CType(Me.vehiculoCInpseccionDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.vehiculoEnLoteDGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'TabPanel
		'
		Me.TabPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.TabPanel.Controls.Add(Me.modificarLoteButton)
		Me.TabPanel.Controls.Add(Me.vehiculoButton)
		Me.TabPanel.Controls.Add(Me.registrarVehiculoButton)
		Me.TabPanel.Controls.Add(Me.verLoteButton)
		Me.TabPanel.Controls.Add(Me.cLoteButton)
		Me.TabPanel.Controls.Add(Me.verInspeccionButton)
		Me.TabPanel.Controls.Add(Me.realizarInspeccionButton)
		Me.TabPanel.Controls.Add(Me.inspeccionButton)
		Me.TabPanel.Controls.Add(Me.salirButton)
		Me.TabPanel.Controls.Add(Me.verVehiculoButton)
		Me.TabPanel.Controls.Add(Me.atrasButton)
		Me.TabPanel.Controls.Add(Me.verLotesButton)
		resources.ApplyResources(Me.TabPanel, "TabPanel")
		Me.TabPanel.Name = "TabPanel"
		'
		'modificarLoteButton
		'
		Me.modificarLoteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.modificarLoteButton.FlatAppearance.BorderSize = 0
		resources.ApplyResources(Me.modificarLoteButton, "modificarLoteButton")
		Me.modificarLoteButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.modificarLoteButton.Name = "modificarLoteButton"
		Me.modificarLoteButton.UseVisualStyleBackColor = False
		'
		'vehiculoButton
		'
		Me.vehiculoButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.vehiculoButton.FlatAppearance.BorderSize = 0
		resources.ApplyResources(Me.vehiculoButton, "vehiculoButton")
		Me.vehiculoButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.vehiculoButton.Name = "vehiculoButton"
		Me.vehiculoButton.UseVisualStyleBackColor = False
		'
		'registrarVehiculoButton
		'
		Me.registrarVehiculoButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.registrarVehiculoButton.FlatAppearance.BorderSize = 0
		resources.ApplyResources(Me.registrarVehiculoButton, "registrarVehiculoButton")
		Me.registrarVehiculoButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.registrarVehiculoButton.Name = "registrarVehiculoButton"
		Me.registrarVehiculoButton.UseVisualStyleBackColor = False
		'
		'verLoteButton
		'
		Me.verLoteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.verLoteButton.FlatAppearance.BorderSize = 0
		resources.ApplyResources(Me.verLoteButton, "verLoteButton")
		Me.verLoteButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.verLoteButton.Name = "verLoteButton"
		Me.verLoteButton.UseVisualStyleBackColor = False
		'
		'cLoteButton
		'
		Me.cLoteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.cLoteButton.FlatAppearance.BorderSize = 0
		resources.ApplyResources(Me.cLoteButton, "cLoteButton")
		Me.cLoteButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.cLoteButton.Name = "cLoteButton"
		Me.cLoteButton.UseVisualStyleBackColor = False
		'
		'verInspeccionButton
		'
		Me.verInspeccionButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.verInspeccionButton.FlatAppearance.BorderSize = 0
		resources.ApplyResources(Me.verInspeccionButton, "verInspeccionButton")
		Me.verInspeccionButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.verInspeccionButton.Name = "verInspeccionButton"
		Me.verInspeccionButton.UseVisualStyleBackColor = False
		'
		'realizarInspeccionButton
		'
		Me.realizarInspeccionButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.realizarInspeccionButton.FlatAppearance.BorderSize = 0
		resources.ApplyResources(Me.realizarInspeccionButton, "realizarInspeccionButton")
		Me.realizarInspeccionButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.realizarInspeccionButton.Name = "realizarInspeccionButton"
		Me.realizarInspeccionButton.UseVisualStyleBackColor = False
		'
		'inspeccionButton
		'
		Me.inspeccionButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.inspeccionButton.FlatAppearance.BorderSize = 0
		resources.ApplyResources(Me.inspeccionButton, "inspeccionButton")
		Me.inspeccionButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.inspeccionButton.Name = "inspeccionButton"
		Me.inspeccionButton.UseVisualStyleBackColor = False
		'
		'salirButton
		'
		Me.salirButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.salirButton.FlatAppearance.BorderSize = 0
		resources.ApplyResources(Me.salirButton, "salirButton")
		Me.salirButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.salirButton.Name = "salirButton"
		Me.salirButton.UseVisualStyleBackColor = False
		'
		'verVehiculoButton
		'
		Me.verVehiculoButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.verVehiculoButton.FlatAppearance.BorderSize = 0
		resources.ApplyResources(Me.verVehiculoButton, "verVehiculoButton")
		Me.verVehiculoButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.verVehiculoButton.Name = "verVehiculoButton"
		Me.verVehiculoButton.UseVisualStyleBackColor = False
		'
		'atrasButton
		'
		Me.atrasButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.atrasButton.FlatAppearance.BorderSize = 0
		resources.ApplyResources(Me.atrasButton, "atrasButton")
		Me.atrasButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.atrasButton.Name = "atrasButton"
		Me.atrasButton.UseVisualStyleBackColor = False
		'
		'verLotesButton
		'
		Me.verLotesButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.verLotesButton.FlatAppearance.BorderSize = 0
		resources.ApplyResources(Me.verLotesButton, "verLotesButton")
		Me.verLotesButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.verLotesButton.Name = "verLotesButton"
		Me.verLotesButton.UseVisualStyleBackColor = False
		'
		'ingresarVehiculoPanel
		'
		Me.ingresarVehiculoPanel.Controls.Add(Me.importarCSVButton)
		Me.ingresarVehiculoPanel.Controls.Add(Me.codigoQRpictureBox)
		Me.ingresarVehiculoPanel.Controls.Add(Me.generarQRCheckBox)
		Me.ingresarVehiculoPanel.Controls.Add(Me.registrarVehiculoLabel)
		Me.ingresarVehiculoPanel.Controls.Add(Me.ingresarVehiculoButton)
		Me.ingresarVehiculoPanel.Controls.Add(Me.tipoComboBox)
		Me.ingresarVehiculoPanel.Controls.Add(Me.vinLabel)
		Me.ingresarVehiculoPanel.Controls.Add(Me.tipoLabel)
		Me.ingresarVehiculoPanel.Controls.Add(Me.colorTextBox)
		Me.ingresarVehiculoPanel.Controls.Add(Me.vinTextBox)
		Me.ingresarVehiculoPanel.Controls.Add(Me.anioTextBox)
		Me.ingresarVehiculoPanel.Controls.Add(Me.colorLabel)
		Me.ingresarVehiculoPanel.Controls.Add(Me.lblMarcaAuto)
		Me.ingresarVehiculoPanel.Controls.Add(Me.modeloTextBox)
		Me.ingresarVehiculoPanel.Controls.Add(Me.marcaTextBox)
		Me.ingresarVehiculoPanel.Controls.Add(Me.añoLabel)
		Me.ingresarVehiculoPanel.Controls.Add(Me.modeloLabel)
		resources.ApplyResources(Me.ingresarVehiculoPanel, "ingresarVehiculoPanel")
		Me.ingresarVehiculoPanel.Name = "ingresarVehiculoPanel"
		'
		'importarCSVButton
		'
		Me.importarCSVButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		resources.ApplyResources(Me.importarCSVButton, "importarCSVButton")
		Me.importarCSVButton.Name = "importarCSVButton"
		Me.importarCSVButton.UseVisualStyleBackColor = True
		'
		'codigoQRpictureBox
		'
		resources.ApplyResources(Me.codigoQRpictureBox, "codigoQRpictureBox")
		Me.codigoQRpictureBox.Name = "codigoQRpictureBox"
		Me.codigoQRpictureBox.TabStop = False
		'
		'generarQRCheckBox
		'
		resources.ApplyResources(Me.generarQRCheckBox, "generarQRCheckBox")
		Me.generarQRCheckBox.Name = "generarQRCheckBox"
		Me.generarQRCheckBox.UseVisualStyleBackColor = True
		'
		'registrarVehiculoLabel
		'
		resources.ApplyResources(Me.registrarVehiculoLabel, "registrarVehiculoLabel")
		Me.registrarVehiculoLabel.Name = "registrarVehiculoLabel"
		'
		'ingresarVehiculoButton
		'
		Me.ingresarVehiculoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		resources.ApplyResources(Me.ingresarVehiculoButton, "ingresarVehiculoButton")
		Me.ingresarVehiculoButton.Name = "ingresarVehiculoButton"
		Me.ingresarVehiculoButton.UseVisualStyleBackColor = True
		'
		'tipoComboBox
		'
		Me.tipoComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
		Me.tipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		resources.ApplyResources(Me.tipoComboBox, "tipoComboBox")
		Me.tipoComboBox.FormattingEnabled = True
		Me.tipoComboBox.Items.AddRange(New Object() {resources.GetString("tipoComboBox.Items"), resources.GetString("tipoComboBox.Items1"), resources.GetString("tipoComboBox.Items2"), resources.GetString("tipoComboBox.Items3"), resources.GetString("tipoComboBox.Items4")})
		Me.tipoComboBox.Name = "tipoComboBox"
		'
		'vinLabel
		'
		resources.ApplyResources(Me.vinLabel, "vinLabel")
		Me.vinLabel.Name = "vinLabel"
		'
		'tipoLabel
		'
		resources.ApplyResources(Me.tipoLabel, "tipoLabel")
		Me.tipoLabel.Name = "tipoLabel"
		'
		'colorTextBox
		'
		resources.ApplyResources(Me.colorTextBox, "colorTextBox")
		Me.colorTextBox.Name = "colorTextBox"
		Me.colorTextBox.ShortcutsEnabled = False
		'
		'vinTextBox
		'
		resources.ApplyResources(Me.vinTextBox, "vinTextBox")
		Me.vinTextBox.Name = "vinTextBox"
		Me.vinTextBox.ShortcutsEnabled = False
		'
		'anioTextBox
		'
		resources.ApplyResources(Me.anioTextBox, "anioTextBox")
		Me.anioTextBox.Name = "anioTextBox"
		Me.anioTextBox.ShortcutsEnabled = False
		'
		'colorLabel
		'
		resources.ApplyResources(Me.colorLabel, "colorLabel")
		Me.colorLabel.Name = "colorLabel"
		'
		'lblMarcaAuto
		'
		resources.ApplyResources(Me.lblMarcaAuto, "lblMarcaAuto")
		Me.lblMarcaAuto.Name = "lblMarcaAuto"
		'
		'modeloTextBox
		'
		resources.ApplyResources(Me.modeloTextBox, "modeloTextBox")
		Me.modeloTextBox.Name = "modeloTextBox"
		Me.modeloTextBox.ShortcutsEnabled = False
		'
		'marcaTextBox
		'
		resources.ApplyResources(Me.marcaTextBox, "marcaTextBox")
		Me.marcaTextBox.Name = "marcaTextBox"
		Me.marcaTextBox.ShortcutsEnabled = False
		'
		'añoLabel
		'
		resources.ApplyResources(Me.añoLabel, "añoLabel")
		Me.añoLabel.Name = "añoLabel"
		'
		'modeloLabel
		'
		resources.ApplyResources(Me.modeloLabel, "modeloLabel")
		Me.modeloLabel.Name = "modeloLabel"
		'
		'topBarPanel
		'
		Me.topBarPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.topBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.topBarPanel.Controls.Add(Me.cerrar)
		Me.topBarPanel.Controls.Add(Me.mainLabel)
		resources.ApplyResources(Me.topBarPanel, "topBarPanel")
		Me.topBarPanel.Name = "topBarPanel"
		'
		'cerrar
		'
		resources.ApplyResources(Me.cerrar, "cerrar")
		Me.cerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.cerrar.Name = "cerrar"
		'
		'mainLabel
		'
		resources.ApplyResources(Me.mainLabel, "mainLabel")
		Me.mainLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.mainLabel.Name = "mainLabel"
		'
		'estadoDeVehiculoLabel
		'
		resources.ApplyResources(Me.estadoDeVehiculoLabel, "estadoDeVehiculoLabel")
		Me.estadoDeVehiculoLabel.Name = "estadoDeVehiculoLabel"
		'
		'listoButton
		'
		resources.ApplyResources(Me.listoButton, "listoButton")
		Me.listoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.listoButton.ForeColor = System.Drawing.Color.Black
		Me.listoButton.Name = "listoButton"
		Me.listoButton.UseVisualStyleBackColor = True
		'
		'dañadoButton
		'
		resources.ApplyResources(Me.dañadoButton, "dañadoButton")
		Me.dañadoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.dañadoButton.ForeColor = System.Drawing.Color.Black
		Me.dañadoButton.Name = "dañadoButton"
		Me.dañadoButton.UseVisualStyleBackColor = True
		'
		'realizarInspeccionPanel
		'
		Me.realizarInspeccionPanel.Controls.Add(Me.seleccionarVehiculoInspeccionLabel)
		Me.realizarInspeccionPanel.Controls.Add(Me.verVehiculosSInspeccionDGV)
		Me.realizarInspeccionPanel.Controls.Add(Me.dañadoButton)
		Me.realizarInspeccionPanel.Controls.Add(Me.listoButton)
		Me.realizarInspeccionPanel.Controls.Add(Me.estadoDeVehiculoLabel)
		resources.ApplyResources(Me.realizarInspeccionPanel, "realizarInspeccionPanel")
		Me.realizarInspeccionPanel.Name = "realizarInspeccionPanel"
		'
		'seleccionarVehiculoInspeccionLabel
		'
		resources.ApplyResources(Me.seleccionarVehiculoInspeccionLabel, "seleccionarVehiculoInspeccionLabel")
		Me.seleccionarVehiculoInspeccionLabel.ForeColor = System.Drawing.Color.Red
		Me.seleccionarVehiculoInspeccionLabel.Name = "seleccionarVehiculoInspeccionLabel"
		'
		'verVehiculosSInspeccionDGV
		'
		Me.verVehiculosSInspeccionDGV.AllowUserToAddRows = False
		Me.verVehiculosSInspeccionDGV.AllowUserToDeleteRows = False
		Me.verVehiculosSInspeccionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		resources.ApplyResources(Me.verVehiculosSInspeccionDGV, "verVehiculosSInspeccionDGV")
		Me.verVehiculosSInspeccionDGV.Name = "verVehiculosSInspeccionDGV"
		Me.verVehiculosSInspeccionDGV.ReadOnly = True
		'
		'añadirDañosLabel
		'
		resources.ApplyResources(Me.añadirDañosLabel, "añadirDañosLabel")
		Me.añadirDañosLabel.Name = "añadirDañosLabel"
		'
		'descDañoLabel
		'
		resources.ApplyResources(Me.descDañoLabel, "descDañoLabel")
		Me.descDañoLabel.Name = "descDañoLabel"
		'
		'descDañoRichTextBox
		'
		resources.ApplyResources(Me.descDañoRichTextBox, "descDañoRichTextBox")
		Me.descDañoRichTextBox.Name = "descDañoRichTextBox"
		'
		'ingresarDañoButton
		'
		Me.ingresarDañoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		resources.ApplyResources(Me.ingresarDañoButton, "ingresarDañoButton")
		Me.ingresarDañoButton.Name = "ingresarDañoButton"
		Me.ingresarDañoButton.UseVisualStyleBackColor = True
		'
		'dañosPanel
		'
		Me.dañosPanel.Controls.Add(Me.evidenciaLabel)
		Me.dañosPanel.Controls.Add(Me.evidenciaButton)
		Me.dañosPanel.Controls.Add(Me.ingresarDañoButton)
		Me.dañosPanel.Controls.Add(Me.descDañoRichTextBox)
		Me.dañosPanel.Controls.Add(Me.descDañoLabel)
		Me.dañosPanel.Controls.Add(Me.añadirDañosLabel)
		resources.ApplyResources(Me.dañosPanel, "dañosPanel")
		Me.dañosPanel.Name = "dañosPanel"
		'
		'evidenciaLabel
		'
		resources.ApplyResources(Me.evidenciaLabel, "evidenciaLabel")
		Me.evidenciaLabel.ForeColor = System.Drawing.Color.Red
		Me.evidenciaLabel.Name = "evidenciaLabel"
		'
		'evidenciaButton
		'
		Me.evidenciaButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		resources.ApplyResources(Me.evidenciaButton, "evidenciaButton")
		Me.evidenciaButton.Name = "evidenciaButton"
		Me.evidenciaButton.UseVisualStyleBackColor = True
		'
		'crearLotePanel
		'
		Me.crearLotePanel.Controls.Add(Me.elegirAutosDeLoteLabel)
		Me.crearLotePanel.Controls.Add(Me.finalizarLoteButton)
		Me.crearLotePanel.Controls.Add(Me.vehiculosListaLabel)
		Me.crearLotePanel.Controls.Add(Me.vehiculoSLoteDGVpanel)
		Me.crearLotePanel.Controls.Add(Me.descLoteRichTextBox)
		Me.crearLotePanel.Controls.Add(Me.crearLoteLabel)
		Me.crearLotePanel.Controls.Add(Me.CrearLoteButton)
		Me.crearLotePanel.Controls.Add(Me.nombreLoteLabel)
		Me.crearLotePanel.Controls.Add(Me.nombreLoteTextbox)
		Me.crearLotePanel.Controls.Add(Me.descripcionLoteLabel)
		resources.ApplyResources(Me.crearLotePanel, "crearLotePanel")
		Me.crearLotePanel.Name = "crearLotePanel"
		'
		'elegirAutosDeLoteLabel
		'
		resources.ApplyResources(Me.elegirAutosDeLoteLabel, "elegirAutosDeLoteLabel")
		Me.elegirAutosDeLoteLabel.ForeColor = System.Drawing.Color.Red
		Me.elegirAutosDeLoteLabel.Name = "elegirAutosDeLoteLabel"
		'
		'finalizarLoteButton
		'
		resources.ApplyResources(Me.finalizarLoteButton, "finalizarLoteButton")
		Me.finalizarLoteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.finalizarLoteButton.Name = "finalizarLoteButton"
		Me.finalizarLoteButton.UseVisualStyleBackColor = True
		'
		'vehiculosListaLabel
		'
		resources.ApplyResources(Me.vehiculosListaLabel, "vehiculosListaLabel")
		Me.vehiculosListaLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.vehiculosListaLabel.Name = "vehiculosListaLabel"
		'
		'vehiculoSLoteDGVpanel
		'
		Me.vehiculoSLoteDGVpanel.Controls.Add(Me.vehiculoSLoteDGV)
		resources.ApplyResources(Me.vehiculoSLoteDGVpanel, "vehiculoSLoteDGVpanel")
		Me.vehiculoSLoteDGVpanel.Name = "vehiculoSLoteDGVpanel"
		'
		'vehiculoSLoteDGV
		'
		Me.vehiculoSLoteDGV.AllowUserToAddRows = False
		Me.vehiculoSLoteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		resources.ApplyResources(Me.vehiculoSLoteDGV, "vehiculoSLoteDGV")
		Me.vehiculoSLoteDGV.Name = "vehiculoSLoteDGV"
		Me.vehiculoSLoteDGV.ReadOnly = True
		'
		'descLoteRichTextBox
		'
		resources.ApplyResources(Me.descLoteRichTextBox, "descLoteRichTextBox")
		Me.descLoteRichTextBox.Name = "descLoteRichTextBox"
		'
		'crearLoteLabel
		'
		resources.ApplyResources(Me.crearLoteLabel, "crearLoteLabel")
		Me.crearLoteLabel.Name = "crearLoteLabel"
		'
		'CrearLoteButton
		'
		Me.CrearLoteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		resources.ApplyResources(Me.CrearLoteButton, "CrearLoteButton")
		Me.CrearLoteButton.Name = "CrearLoteButton"
		Me.CrearLoteButton.UseVisualStyleBackColor = True
		'
		'nombreLoteLabel
		'
		resources.ApplyResources(Me.nombreLoteLabel, "nombreLoteLabel")
		Me.nombreLoteLabel.Name = "nombreLoteLabel"
		'
		'nombreLoteTextbox
		'
		resources.ApplyResources(Me.nombreLoteTextbox, "nombreLoteTextbox")
		Me.nombreLoteTextbox.Name = "nombreLoteTextbox"
		'
		'descripcionLoteLabel
		'
		resources.ApplyResources(Me.descripcionLoteLabel, "descripcionLoteLabel")
		Me.descripcionLoteLabel.Name = "descripcionLoteLabel"
		'
		'verLotesText
		'
		resources.ApplyResources(Me.verLotesText, "verLotesText")
		Me.verLotesText.Name = "verLotesText"
		'
		'verLotesDGVpanel
		'
		Me.verLotesDGVpanel.Controls.Add(Me.verLotesDGV)
		resources.ApplyResources(Me.verLotesDGVpanel, "verLotesDGVpanel")
		Me.verLotesDGVpanel.Name = "verLotesDGVpanel"
		'
		'verLotesDGV
		'
		Me.verLotesDGV.AllowUserToAddRows = False
		Me.verLotesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		resources.ApplyResources(Me.verLotesDGV, "verLotesDGV")
		Me.verLotesDGV.Name = "verLotesDGV"
		Me.verLotesDGV.ReadOnly = True
		'
		'verLotesPanel
		'
		Me.verLotesPanel.Controls.Add(Me.eliminarLoteButton)
		Me.verLotesPanel.Controls.Add(Me.verLotesDGVpanel)
		Me.verLotesPanel.Controls.Add(Me.verLotesText)
		resources.ApplyResources(Me.verLotesPanel, "verLotesPanel")
		Me.verLotesPanel.Name = "verLotesPanel"
		'
		'eliminarLoteButton
		'
		Me.eliminarLoteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		resources.ApplyResources(Me.eliminarLoteButton, "eliminarLoteButton")
		Me.eliminarLoteButton.Name = "eliminarLoteButton"
		Me.eliminarLoteButton.UseVisualStyleBackColor = True
		'
		'verVehiculosLabel
		'
		resources.ApplyResources(Me.verVehiculosLabel, "verVehiculosLabel")
		Me.verVehiculosLabel.Name = "verVehiculosLabel"
		'
		'verVehiculosDGVpanel
		'
		Me.verVehiculosDGVpanel.Controls.Add(Me.verVehiculosDGV)
		resources.ApplyResources(Me.verVehiculosDGVpanel, "verVehiculosDGVpanel")
		Me.verVehiculosDGVpanel.Name = "verVehiculosDGVpanel"
		'
		'verVehiculosDGV
		'
		Me.verVehiculosDGV.AllowUserToAddRows = False
		Me.verVehiculosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		resources.ApplyResources(Me.verVehiculosDGV, "verVehiculosDGV")
		Me.verVehiculosDGV.Name = "verVehiculosDGV"
		Me.verVehiculosDGV.ReadOnly = True
		'
		'verVehiculosPanel
		'
		Me.verVehiculosPanel.Controls.Add(Me.actualizarVerVehiculo)
		Me.verVehiculosPanel.Controls.Add(Me.BuscarButton)
		Me.verVehiculosPanel.Controls.Add(Me.ingresarVINLabel)
		Me.verVehiculosPanel.Controls.Add(Me.vinABuscarTextBox)
		Me.verVehiculosPanel.Controls.Add(Me.verVehiculosDGVpanel)
		Me.verVehiculosPanel.Controls.Add(Me.verVehiculosLabel)
		resources.ApplyResources(Me.verVehiculosPanel, "verVehiculosPanel")
		Me.verVehiculosPanel.Name = "verVehiculosPanel"
		'
		'actualizarVerVehiculo
		'
		Me.actualizarVerVehiculo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		resources.ApplyResources(Me.actualizarVerVehiculo, "actualizarVerVehiculo")
		Me.actualizarVerVehiculo.Name = "actualizarVerVehiculo"
		Me.actualizarVerVehiculo.UseVisualStyleBackColor = True
		'
		'BuscarButton
		'
		Me.BuscarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		resources.ApplyResources(Me.BuscarButton, "BuscarButton")
		Me.BuscarButton.Name = "BuscarButton"
		Me.BuscarButton.UseVisualStyleBackColor = True
		'
		'ingresarVINLabel
		'
		resources.ApplyResources(Me.ingresarVINLabel, "ingresarVINLabel")
		Me.ingresarVINLabel.Name = "ingresarVINLabel"
		'
		'vinABuscarTextBox
		'
		resources.ApplyResources(Me.vinABuscarTextBox, "vinABuscarTextBox")
		Me.vinABuscarTextBox.Name = "vinABuscarTextBox"
		'
		'verInspeccionPanel
		'
		Me.verInspeccionPanel.Controls.Add(Me.verInspeccionLabel)
		Me.verInspeccionPanel.Controls.Add(Me.verInspeccionesDGV)
		resources.ApplyResources(Me.verInspeccionPanel, "verInspeccionPanel")
		Me.verInspeccionPanel.Name = "verInspeccionPanel"
		'
		'verInspeccionLabel
		'
		resources.ApplyResources(Me.verInspeccionLabel, "verInspeccionLabel")
		Me.verInspeccionLabel.Name = "verInspeccionLabel"
		'
		'verInspeccionesDGV
		'
		Me.verInspeccionesDGV.AllowUserToAddRows = False
		Me.verInspeccionesDGV.AllowUserToDeleteRows = False
		Me.verInspeccionesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		resources.ApplyResources(Me.verInspeccionesDGV, "verInspeccionesDGV")
		Me.verInspeccionesDGV.Name = "verInspeccionesDGV"
		Me.verInspeccionesDGV.ReadOnly = True
		'
		'imagenOFD
		'
		resources.ApplyResources(Me.imagenOFD, "imagenOFD")
		'
		'qrSFD
		'
		resources.ApplyResources(Me.qrSFD, "qrSFD")
		'
		'importarCSVOFD
		'
		resources.ApplyResources(Me.importarCSVOFD, "importarCSVOFD")
		Me.importarCSVOFD.InitialDirectory = "archivo"
		'
		'modificarLotePanel
		'
		Me.modificarLotePanel.Controls.Add(Me.modificarLoteLabel)
		Me.modificarLotePanel.Controls.Add(Me.elegirButton)
		Me.modificarLotePanel.Controls.Add(Me.modificarLoteDGV)
		resources.ApplyResources(Me.modificarLotePanel, "modificarLotePanel")
		Me.modificarLotePanel.Name = "modificarLotePanel"
		'
		'modificarLoteLabel
		'
		resources.ApplyResources(Me.modificarLoteLabel, "modificarLoteLabel")
		Me.modificarLoteLabel.Name = "modificarLoteLabel"
		'
		'elegirButton
		'
		Me.elegirButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		resources.ApplyResources(Me.elegirButton, "elegirButton")
		Me.elegirButton.Name = "elegirButton"
		Me.elegirButton.UseVisualStyleBackColor = True
		'
		'modificarLoteDGV
		'
		Me.modificarLoteDGV.AllowUserToAddRows = False
		Me.modificarLoteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		resources.ApplyResources(Me.modificarLoteDGV, "modificarLoteDGV")
		Me.modificarLoteDGV.Name = "modificarLoteDGV"
		Me.modificarLoteDGV.ReadOnly = True
		'
		'eleccionPanel
		'
		Me.eleccionPanel.Controls.Add(Me.finalizarModButton)
		Me.eleccionPanel.Controls.Add(Me.vehiculosInspeccionadosLabel)
		Me.eleccionPanel.Controls.Add(Me.vehiculosEnLoteLabel)
		Me.eleccionPanel.Controls.Add(Me.vehiculoCInpseccionDGV)
		Me.eleccionPanel.Controls.Add(Me.vehiculoEnLoteDGV)
		resources.ApplyResources(Me.eleccionPanel, "eleccionPanel")
		Me.eleccionPanel.Name = "eleccionPanel"
		'
		'finalizarModButton
		'
		Me.finalizarModButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		resources.ApplyResources(Me.finalizarModButton, "finalizarModButton")
		Me.finalizarModButton.Name = "finalizarModButton"
		Me.finalizarModButton.UseVisualStyleBackColor = True
		'
		'vehiculosInspeccionadosLabel
		'
		resources.ApplyResources(Me.vehiculosInspeccionadosLabel, "vehiculosInspeccionadosLabel")
		Me.vehiculosInspeccionadosLabel.Name = "vehiculosInspeccionadosLabel"
		'
		'vehiculosEnLoteLabel
		'
		resources.ApplyResources(Me.vehiculosEnLoteLabel, "vehiculosEnLoteLabel")
		Me.vehiculosEnLoteLabel.Name = "vehiculosEnLoteLabel"
		'
		'vehiculoCInpseccionDGV
		'
		Me.vehiculoCInpseccionDGV.AllowUserToAddRows = False
		Me.vehiculoCInpseccionDGV.AllowUserToDeleteRows = False
		Me.vehiculoCInpseccionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.vehiculoCInpseccionDGV.Cursor = System.Windows.Forms.Cursors.Arrow
		resources.ApplyResources(Me.vehiculoCInpseccionDGV, "vehiculoCInpseccionDGV")
		Me.vehiculoCInpseccionDGV.Name = "vehiculoCInpseccionDGV"
		Me.vehiculoCInpseccionDGV.ReadOnly = True
		Me.vehiculoCInpseccionDGV.RowHeadersVisible = False
		'
		'vehiculoEnLoteDGV
		'
		Me.vehiculoEnLoteDGV.AllowUserToAddRows = False
		Me.vehiculoEnLoteDGV.AllowUserToDeleteRows = False
		Me.vehiculoEnLoteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		resources.ApplyResources(Me.vehiculoEnLoteDGV, "vehiculoEnLoteDGV")
		Me.vehiculoEnLoteDGV.Name = "vehiculoEnLoteDGV"
		Me.vehiculoEnLoteDGV.ReadOnly = True
		Me.vehiculoEnLoteDGV.RowHeadersVisible = False
		'
		'operarioPuerto
		'
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.Controls.Add(Me.dañosPanel)
		Me.Controls.Add(Me.crearLotePanel)
		Me.Controls.Add(Me.ingresarVehiculoPanel)
		Me.Controls.Add(Me.verVehiculosPanel)
		Me.Controls.Add(Me.realizarInspeccionPanel)
		Me.Controls.Add(Me.eleccionPanel)
		Me.Controls.Add(Me.modificarLotePanel)
		Me.Controls.Add(Me.verLotesPanel)
		Me.Controls.Add(Me.verInspeccionPanel)
		Me.Controls.Add(Me.topBarPanel)
		Me.Controls.Add(Me.TabPanel)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.MaximizeBox = False
		Me.Name = "operarioPuerto"
		Me.TabPanel.ResumeLayout(False)
		Me.ingresarVehiculoPanel.ResumeLayout(False)
		Me.ingresarVehiculoPanel.PerformLayout()
		CType(Me.codigoQRpictureBox, System.ComponentModel.ISupportInitialize).EndInit()
		Me.topBarPanel.ResumeLayout(False)
		Me.topBarPanel.PerformLayout()
		Me.realizarInspeccionPanel.ResumeLayout(False)
		Me.realizarInspeccionPanel.PerformLayout()
		CType(Me.verVehiculosSInspeccionDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.dañosPanel.ResumeLayout(False)
		Me.dañosPanel.PerformLayout()
		Me.crearLotePanel.ResumeLayout(False)
		Me.crearLotePanel.PerformLayout()
		Me.vehiculoSLoteDGVpanel.ResumeLayout(False)
		CType(Me.vehiculoSLoteDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.verLotesDGVpanel.ResumeLayout(False)
		CType(Me.verLotesDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.verLotesPanel.ResumeLayout(False)
		Me.verLotesPanel.PerformLayout()
		Me.verVehiculosDGVpanel.ResumeLayout(False)
		CType(Me.verVehiculosDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.verVehiculosPanel.ResumeLayout(False)
		Me.verVehiculosPanel.PerformLayout()
		Me.verInspeccionPanel.ResumeLayout(False)
		Me.verInspeccionPanel.PerformLayout()
		CType(Me.verInspeccionesDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.modificarLotePanel.ResumeLayout(False)
		Me.modificarLotePanel.PerformLayout()
		CType(Me.modificarLoteDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.eleccionPanel.ResumeLayout(False)
		Me.eleccionPanel.PerformLayout()
		CType(Me.vehiculoCInpseccionDGV, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.vehiculoEnLoteDGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents TabPanel As Panel
	Friend WithEvents vehiculoButton As Button
	Friend WithEvents verLoteButton As Button
	Friend WithEvents atrasButton As Button
	Friend WithEvents verLotesButton As Button
	Friend WithEvents cLoteButton As Button
	Friend WithEvents registrarVehiculoButton As Button
	Friend WithEvents topBarPanel As Panel
	Friend WithEvents mainLabel As Label
	Friend WithEvents cerrar As Label
	Friend WithEvents verVehiculoButton As Button
	Friend WithEvents salirButton As Button
	Friend WithEvents lblMarcaAuto As Label
	Friend WithEvents modeloLabel As Label
	Friend WithEvents añoLabel As Label
	Friend WithEvents colorLabel As Label
	Friend WithEvents vinLabel As Label
	Friend WithEvents tipoLabel As Label
	Friend WithEvents vinTextBox As TextBox
	Friend WithEvents marcaTextBox As TextBox
	Friend WithEvents modeloTextBox As TextBox
	Friend WithEvents anioTextBox As TextBox
	Friend WithEvents colorTextBox As TextBox
	Friend WithEvents tipoComboBox As ComboBox
	Friend WithEvents ingresarVehiculoButton As Button
	Friend WithEvents ingresarVehiculoPanel As Panel
	Friend WithEvents registrarVehiculoLabel As Label
	Friend WithEvents estadoDeVehiculoLabel As Label
	Friend WithEvents listoButton As Button
	Friend WithEvents dañadoButton As Button
	Friend WithEvents realizarInspeccionPanel As Panel
	Friend WithEvents añadirDañosLabel As Label
	Friend WithEvents descDañoLabel As Label
	Friend WithEvents descDañoRichTextBox As RichTextBox
	Friend WithEvents ingresarDañoButton As Button
	Friend WithEvents dañosPanel As Panel
	Friend WithEvents crearLotePanel As Panel
	Friend WithEvents descLoteRichTextBox As RichTextBox
	Friend WithEvents crearLoteLabel As Label
	Friend WithEvents CrearLoteButton As Button
	Friend WithEvents nombreLoteLabel As Label
	Friend WithEvents nombreLoteTextbox As TextBox
	Friend WithEvents descripcionLoteLabel As Label
	Friend WithEvents vehiculosListaLabel As Label
	Friend WithEvents vehiculoSLoteDGVpanel As Panel
	Friend WithEvents verLotesText As Label
	Friend WithEvents verLotesDGVpanel As Panel
	Friend WithEvents verLotesPanel As Panel
	Friend WithEvents verVehiculosLabel As Label
	Friend WithEvents verVehiculosDGVpanel As Panel
	Friend WithEvents verVehiculosPanel As Panel
	Friend WithEvents vehiculoSLoteDGV As DataGridView
	Friend WithEvents verLotesDGV As DataGridView
	Friend WithEvents verVehiculosDGV As DataGridView
	Friend WithEvents eliminarLoteButton As Button
	Friend WithEvents finalizarLoteButton As Button
	Friend WithEvents seleccionarVehiculoInspeccionLabel As Label
	Friend WithEvents verVehiculosSInspeccionDGV As DataGridView
	Friend WithEvents inspeccionButton As Button
	Friend WithEvents verInspeccionButton As Button
	Friend WithEvents realizarInspeccionButton As Button
	Friend WithEvents verInspeccionPanel As Panel
	Friend WithEvents verInspeccionLabel As Label
	Friend WithEvents verInspeccionesDGV As DataGridView
	Friend WithEvents evidenciaButton As Button
	Friend WithEvents evidenciaLabel As Label
	Friend WithEvents imagenOFD As OpenFileDialog
    Friend WithEvents vinABuscarTextBox As TextBox
    Friend WithEvents BuscarButton As Button
    Friend WithEvents ingresarVINLabel As Label
    Friend WithEvents actualizarVerVehiculo As Button
	Friend WithEvents qrSFD As SaveFileDialog
	Friend WithEvents generarQRCheckBox As CheckBox
	Friend WithEvents codigoQRpictureBox As PictureBox
	Friend WithEvents importarCSVButton As Button
	Friend WithEvents importarCSVOFD As OpenFileDialog
    Friend WithEvents modificarLoteButton As Button
    Friend WithEvents modificarLotePanel As Panel
    Friend WithEvents elegirButton As Button
    Friend WithEvents modificarLoteLabel As Label
    Friend WithEvents modificarLoteDGV As DataGridView
    Friend WithEvents eleccionPanel As Panel
    Friend WithEvents vehiculoEnLoteDGV As DataGridView
	Friend WithEvents vehiculosEnLoteLabel As Label
	Friend WithEvents vehiculoCInpseccionDGV As DataGridView
	Friend WithEvents vehiculosInspeccionadosLabel As Label
	Friend WithEvents finalizarModButton As Button
    Friend WithEvents elegirAutosDeLoteLabel As Label
End Class
