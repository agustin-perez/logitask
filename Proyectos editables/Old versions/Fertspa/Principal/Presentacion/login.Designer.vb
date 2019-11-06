<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
		Me.mainLabel = New System.Windows.Forms.Label()
		Me.rContraTextBox = New System.Windows.Forms.TextBox()
		Me.rRolComboBox = New System.Windows.Forms.ComboBox()
		Me.registrarInfoLabel = New System.Windows.Forms.Label()
		Me.registrarButton = New System.Windows.Forms.Button()
		Me.IngresarButton = New System.Windows.Forms.Button()
		Me.Splitter1 = New System.Windows.Forms.Splitter()
		Me.registrarsePanel = New System.Windows.Forms.Panel()
		Me.rApellidoFeedback = New System.Windows.Forms.Label()
		Me.rNombreFeedback = New System.Windows.Forms.Label()
		Me.rApellidoTextBox = New System.Windows.Forms.TextBox()
		Me.rNombreTextBox = New System.Windows.Forms.TextBox()
		Me.rRolFeedback = New System.Windows.Forms.Label()
		Me.rCedulaFeedback = New System.Windows.Forms.Label()
		Me.rContraFeedback = New System.Windows.Forms.Label()
		Me.rolLabel = New System.Windows.Forms.Label()
		Me.rCedulaTextBox = New System.Windows.Forms.TextBox()
		Me.registrarseLabel = New System.Windows.Forms.Label()
		Me.topPanel = New System.Windows.Forms.Panel()
		Me.cerrar = New System.Windows.Forms.Label()
		Me.ingresarPanel = New System.Windows.Forms.Panel()
		Me.ingresarInfoLabel = New System.Windows.Forms.Label()
		Me.iContraFeedback = New System.Windows.Forms.Label()
		Me.iCedulaFeedback = New System.Windows.Forms.Label()
		Me.ingresarLabel = New System.Windows.Forms.Label()
		Me.iContraTextBox = New System.Windows.Forms.TextBox()
		Me.iCedulaTextBox = New System.Windows.Forms.TextBox()
		Me.separador = New System.Windows.Forms.PictureBox()
		Me.registrarsePanel.SuspendLayout()
		Me.topPanel.SuspendLayout()
		Me.ingresarPanel.SuspendLayout()
		CType(Me.separador, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'mainLabel
		'
		Me.mainLabel.AutoSize = True
		Me.mainLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
		Me.mainLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.mainLabel.Location = New System.Drawing.Point(12, 9)
		Me.mainLabel.Name = "mainLabel"
		Me.mainLabel.Size = New System.Drawing.Size(43, 15)
		Me.mainLabel.TabIndex = 2
		Me.mainLabel.Text = "Login"
		'
		'rContraTextBox
		'
		Me.rContraTextBox.BackColor = System.Drawing.Color.White
		Me.rContraTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rContraTextBox.ForeColor = System.Drawing.Color.Silver
		Me.rContraTextBox.Location = New System.Drawing.Point(42, 131)
		Me.rContraTextBox.MaxLength = 15
		Me.rContraTextBox.Name = "rContraTextBox"
		Me.rContraTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.rContraTextBox.ShortcutsEnabled = False
		Me.rContraTextBox.Size = New System.Drawing.Size(222, 26)
		Me.rContraTextBox.TabIndex = 1
		Me.rContraTextBox.Text = "Contraseña"
		'
		'rRolComboBox
		'
		Me.rRolComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
		Me.rRolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.rRolComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.rRolComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rRolComboBox.ForeColor = System.Drawing.Color.Black
		Me.rRolComboBox.FormattingEnabled = True
		Me.rRolComboBox.Items.AddRange(New Object() {"Transportista", "Operario Patio", "Operario Puerto"})
		Me.rRolComboBox.Location = New System.Drawing.Point(42, 287)
		Me.rRolComboBox.Name = "rRolComboBox"
		Me.rRolComboBox.Size = New System.Drawing.Size(222, 26)
		Me.rRolComboBox.TabIndex = 4
		'
		'registrarInfoLabel
		'
		Me.registrarInfoLabel.AutoSize = True
		Me.registrarInfoLabel.Font = New System.Drawing.Font("Segoe UI Symbol", 10.0!)
		Me.registrarInfoLabel.ForeColor = System.Drawing.Color.Red
		Me.registrarInfoLabel.Location = New System.Drawing.Point(77, 318)
		Me.registrarInfoLabel.Name = "registrarInfoLabel"
		Me.registrarInfoLabel.Size = New System.Drawing.Size(141, 19)
		Me.registrarInfoLabel.TabIndex = 10
		Me.registrarInfoLabel.Text = "Campo Usuario Vacio"
		Me.registrarInfoLabel.Visible = False
		'
		'registrarButton
		'
		Me.registrarButton.BackColor = System.Drawing.Color.White
		Me.registrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.registrarButton.Location = New System.Drawing.Point(99, 354)
		Me.registrarButton.Name = "registrarButton"
		Me.registrarButton.Size = New System.Drawing.Size(99, 33)
		Me.registrarButton.TabIndex = 5
		Me.registrarButton.Text = "Registrar"
		Me.registrarButton.UseVisualStyleBackColor = False
		'
		'IngresarButton
		'
		Me.IngresarButton.BackColor = System.Drawing.Color.White
		Me.IngresarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.IngresarButton.ForeColor = System.Drawing.Color.Black
		Me.IngresarButton.Location = New System.Drawing.Point(104, 354)
		Me.IngresarButton.Name = "IngresarButton"
		Me.IngresarButton.Size = New System.Drawing.Size(99, 33)
		Me.IngresarButton.TabIndex = 8
		Me.IngresarButton.Text = "Ingresar"
		Me.IngresarButton.UseVisualStyleBackColor = False
		'
		'Splitter1
		'
		Me.Splitter1.Location = New System.Drawing.Point(0, 0)
		Me.Splitter1.Name = "Splitter1"
		Me.Splitter1.Size = New System.Drawing.Size(3, 491)
		Me.Splitter1.TabIndex = 14
		Me.Splitter1.TabStop = False
		'
		'registrarsePanel
		'
		Me.registrarsePanel.BackColor = System.Drawing.Color.Transparent
		Me.registrarsePanel.Controls.Add(Me.rApellidoFeedback)
		Me.registrarsePanel.Controls.Add(Me.rNombreFeedback)
		Me.registrarsePanel.Controls.Add(Me.rApellidoTextBox)
		Me.registrarsePanel.Controls.Add(Me.rNombreTextBox)
		Me.registrarsePanel.Controls.Add(Me.rRolFeedback)
		Me.registrarsePanel.Controls.Add(Me.rCedulaFeedback)
		Me.registrarsePanel.Controls.Add(Me.rContraFeedback)
		Me.registrarsePanel.Controls.Add(Me.rolLabel)
		Me.registrarsePanel.Controls.Add(Me.rCedulaTextBox)
		Me.registrarsePanel.Controls.Add(Me.registrarseLabel)
		Me.registrarsePanel.Controls.Add(Me.registrarButton)
		Me.registrarsePanel.Controls.Add(Me.rRolComboBox)
		Me.registrarsePanel.Controls.Add(Me.registrarInfoLabel)
		Me.registrarsePanel.Controls.Add(Me.rContraTextBox)
		Me.registrarsePanel.Location = New System.Drawing.Point(37, 51)
		Me.registrarsePanel.Name = "registrarsePanel"
		Me.registrarsePanel.Size = New System.Drawing.Size(310, 415)
		Me.registrarsePanel.TabIndex = 15
		'
		'rApellidoFeedback
		'
		Me.rApellidoFeedback.AutoSize = True
		Me.rApellidoFeedback.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rApellidoFeedback.ForeColor = System.Drawing.Color.Red
		Me.rApellidoFeedback.Location = New System.Drawing.Point(270, 218)
		Me.rApellidoFeedback.Name = "rApellidoFeedback"
		Me.rApellidoFeedback.Size = New System.Drawing.Size(20, 22)
		Me.rApellidoFeedback.TabIndex = 21
		Me.rApellidoFeedback.Text = "!"
		Me.rApellidoFeedback.Visible = False
		'
		'rNombreFeedback
		'
		Me.rNombreFeedback.AutoSize = True
		Me.rNombreFeedback.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rNombreFeedback.ForeColor = System.Drawing.Color.Red
		Me.rNombreFeedback.Location = New System.Drawing.Point(270, 175)
		Me.rNombreFeedback.Name = "rNombreFeedback"
		Me.rNombreFeedback.Size = New System.Drawing.Size(20, 22)
		Me.rNombreFeedback.TabIndex = 20
		Me.rNombreFeedback.Text = "!"
		Me.rNombreFeedback.Visible = False
		'
		'rApellidoTextBox
		'
		Me.rApellidoTextBox.BackColor = System.Drawing.Color.White
		Me.rApellidoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rApellidoTextBox.ForeColor = System.Drawing.Color.Silver
		Me.rApellidoTextBox.Location = New System.Drawing.Point(42, 216)
		Me.rApellidoTextBox.MaxLength = 15
		Me.rApellidoTextBox.Name = "rApellidoTextBox"
		Me.rApellidoTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.rApellidoTextBox.ShortcutsEnabled = False
		Me.rApellidoTextBox.Size = New System.Drawing.Size(222, 26)
		Me.rApellidoTextBox.TabIndex = 3
		Me.rApellidoTextBox.Text = "Apellido"
		'
		'rNombreTextBox
		'
		Me.rNombreTextBox.BackColor = System.Drawing.Color.White
		Me.rNombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rNombreTextBox.ForeColor = System.Drawing.Color.Silver
		Me.rNombreTextBox.Location = New System.Drawing.Point(42, 173)
		Me.rNombreTextBox.MaxLength = 15
		Me.rNombreTextBox.Name = "rNombreTextBox"
		Me.rNombreTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.rNombreTextBox.ShortcutsEnabled = False
		Me.rNombreTextBox.Size = New System.Drawing.Size(222, 26)
		Me.rNombreTextBox.TabIndex = 2
		Me.rNombreTextBox.Text = "Nombre"
		'
		'rRolFeedback
		'
		Me.rRolFeedback.AutoSize = True
		Me.rRolFeedback.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rRolFeedback.ForeColor = System.Drawing.Color.Red
		Me.rRolFeedback.Location = New System.Drawing.Point(267, 290)
		Me.rRolFeedback.Name = "rRolFeedback"
		Me.rRolFeedback.Size = New System.Drawing.Size(23, 22)
		Me.rRolFeedback.TabIndex = 17
		Me.rRolFeedback.Text = "✖"
		'
		'rCedulaFeedback
		'
		Me.rCedulaFeedback.AutoSize = True
		Me.rCedulaFeedback.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rCedulaFeedback.ForeColor = System.Drawing.Color.Red
		Me.rCedulaFeedback.Location = New System.Drawing.Point(270, 83)
		Me.rCedulaFeedback.Name = "rCedulaFeedback"
		Me.rCedulaFeedback.Size = New System.Drawing.Size(20, 22)
		Me.rCedulaFeedback.TabIndex = 16
		Me.rCedulaFeedback.Text = "!"
		Me.rCedulaFeedback.Visible = False
		'
		'rContraFeedback
		'
		Me.rContraFeedback.AutoSize = True
		Me.rContraFeedback.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rContraFeedback.ForeColor = System.Drawing.Color.Red
		Me.rContraFeedback.Location = New System.Drawing.Point(270, 133)
		Me.rContraFeedback.Name = "rContraFeedback"
		Me.rContraFeedback.Size = New System.Drawing.Size(20, 22)
		Me.rContraFeedback.TabIndex = 15
		Me.rContraFeedback.Text = "!"
		Me.rContraFeedback.Visible = False
		'
		'rolLabel
		'
		Me.rolLabel.AutoSize = True
		Me.rolLabel.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rolLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.rolLabel.Location = New System.Drawing.Point(39, 255)
		Me.rolLabel.Name = "rolLabel"
		Me.rolLabel.Size = New System.Drawing.Size(39, 25)
		Me.rolLabel.TabIndex = 14
		Me.rolLabel.Text = "Rol"
		'
		'rCedulaTextBox
		'
		Me.rCedulaTextBox.BackColor = System.Drawing.Color.White
		Me.rCedulaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rCedulaTextBox.ForeColor = System.Drawing.Color.Silver
		Me.rCedulaTextBox.Location = New System.Drawing.Point(42, 81)
		Me.rCedulaTextBox.MaxLength = 8
		Me.rCedulaTextBox.Name = "rCedulaTextBox"
		Me.rCedulaTextBox.ShortcutsEnabled = False
		Me.rCedulaTextBox.Size = New System.Drawing.Size(222, 26)
		Me.rCedulaTextBox.TabIndex = 0
		Me.rCedulaTextBox.Text = "Cedula"
		'
		'registrarseLabel
		'
		Me.registrarseLabel.AutoSize = True
		Me.registrarseLabel.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.registrarseLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.registrarseLabel.Location = New System.Drawing.Point(39, 34)
		Me.registrarseLabel.Name = "registrarseLabel"
		Me.registrarseLabel.Size = New System.Drawing.Size(105, 25)
		Me.registrarseLabel.TabIndex = 13
		Me.registrarseLabel.Text = "Registrarse"
		'
		'topPanel
		'
		Me.topPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.topPanel.Controls.Add(Me.cerrar)
		Me.topPanel.Controls.Add(Me.mainLabel)
		Me.topPanel.Location = New System.Drawing.Point(0, 0)
		Me.topPanel.Name = "topPanel"
		Me.topPanel.Size = New System.Drawing.Size(738, 33)
		Me.topPanel.TabIndex = 16
		'
		'cerrar
		'
		Me.cerrar.AutoSize = True
		Me.cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
		Me.cerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.cerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.cerrar.Location = New System.Drawing.Point(707, -1)
		Me.cerrar.Name = "cerrar"
		Me.cerrar.Size = New System.Drawing.Size(30, 31)
		Me.cerrar.TabIndex = 15
		Me.cerrar.Text = "×"
		'
		'ingresarPanel
		'
		Me.ingresarPanel.BackColor = System.Drawing.Color.Transparent
		Me.ingresarPanel.Controls.Add(Me.ingresarInfoLabel)
		Me.ingresarPanel.Controls.Add(Me.iContraFeedback)
		Me.ingresarPanel.Controls.Add(Me.iCedulaFeedback)
		Me.ingresarPanel.Controls.Add(Me.ingresarLabel)
		Me.ingresarPanel.Controls.Add(Me.iContraTextBox)
		Me.ingresarPanel.Controls.Add(Me.iCedulaTextBox)
		Me.ingresarPanel.Controls.Add(Me.IngresarButton)
		Me.ingresarPanel.Location = New System.Drawing.Point(390, 51)
		Me.ingresarPanel.Name = "ingresarPanel"
		Me.ingresarPanel.Size = New System.Drawing.Size(310, 414)
		Me.ingresarPanel.TabIndex = 17
		'
		'ingresarInfoLabel
		'
		Me.ingresarInfoLabel.AutoSize = True
		Me.ingresarInfoLabel.Font = New System.Drawing.Font("Segoe UI Symbol", 10.0!)
		Me.ingresarInfoLabel.ForeColor = System.Drawing.Color.Red
		Me.ingresarInfoLabel.Location = New System.Drawing.Point(83, 318)
		Me.ingresarInfoLabel.Name = "ingresarInfoLabel"
		Me.ingresarInfoLabel.Size = New System.Drawing.Size(141, 19)
		Me.ingresarInfoLabel.TabIndex = 22
		Me.ingresarInfoLabel.Text = "Campo Usuario Vacio"
		Me.ingresarInfoLabel.Visible = False
		'
		'iContraFeedback
		'
		Me.iContraFeedback.AutoSize = True
		Me.iContraFeedback.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.iContraFeedback.ForeColor = System.Drawing.Color.Red
		Me.iContraFeedback.Location = New System.Drawing.Point(277, 131)
		Me.iContraFeedback.Name = "iContraFeedback"
		Me.iContraFeedback.Size = New System.Drawing.Size(20, 22)
		Me.iContraFeedback.TabIndex = 23
		Me.iContraFeedback.Text = "!"
		Me.iContraFeedback.Visible = False
		'
		'iCedulaFeedback
		'
		Me.iCedulaFeedback.AutoSize = True
		Me.iCedulaFeedback.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.iCedulaFeedback.ForeColor = System.Drawing.Color.Red
		Me.iCedulaFeedback.Location = New System.Drawing.Point(277, 83)
		Me.iCedulaFeedback.Name = "iCedulaFeedback"
		Me.iCedulaFeedback.Size = New System.Drawing.Size(20, 22)
		Me.iCedulaFeedback.TabIndex = 22
		Me.iCedulaFeedback.Text = "!"
		Me.iCedulaFeedback.Visible = False
		'
		'ingresarLabel
		'
		Me.ingresarLabel.AutoSize = True
		Me.ingresarLabel.BackColor = System.Drawing.Color.Transparent
		Me.ingresarLabel.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ingresarLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.ingresarLabel.Location = New System.Drawing.Point(47, 34)
		Me.ingresarLabel.Name = "ingresarLabel"
		Me.ingresarLabel.Size = New System.Drawing.Size(81, 25)
		Me.ingresarLabel.TabIndex = 18
		Me.ingresarLabel.Text = "Ingresar"
		'
		'iContraTextBox
		'
		Me.iContraTextBox.BackColor = System.Drawing.Color.White
		Me.iContraTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.iContraTextBox.ForeColor = System.Drawing.Color.Silver
		Me.iContraTextBox.Location = New System.Drawing.Point(49, 129)
		Me.iContraTextBox.MaxLength = 15
		Me.iContraTextBox.Name = "iContraTextBox"
		Me.iContraTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.iContraTextBox.ShortcutsEnabled = False
		Me.iContraTextBox.Size = New System.Drawing.Size(222, 26)
		Me.iContraTextBox.TabIndex = 7
		Me.iContraTextBox.Text = "Contraseña"
		'
		'iCedulaTextBox
		'
		Me.iCedulaTextBox.BackColor = System.Drawing.Color.White
		Me.iCedulaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.iCedulaTextBox.ForeColor = System.Drawing.Color.Silver
		Me.iCedulaTextBox.Location = New System.Drawing.Point(49, 79)
		Me.iCedulaTextBox.MaxLength = 8
		Me.iCedulaTextBox.Name = "iCedulaTextBox"
		Me.iCedulaTextBox.ShortcutsEnabled = False
		Me.iCedulaTextBox.Size = New System.Drawing.Size(222, 26)
		Me.iCedulaTextBox.TabIndex = 6
		Me.iCedulaTextBox.Text = "Cedula"
		'
		'separador
		'
		Me.separador.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
		Me.separador.Location = New System.Drawing.Point(366, 75)
		Me.separador.Name = "separador"
		Me.separador.Size = New System.Drawing.Size(2, 360)
		Me.separador.TabIndex = 18
		Me.separador.TabStop = False
		'
		'login
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(738, 491)
		Me.Controls.Add(Me.separador)
		Me.Controls.Add(Me.ingresarPanel)
		Me.Controls.Add(Me.topPanel)
		Me.Controls.Add(Me.registrarsePanel)
		Me.Controls.Add(Me.Splitter1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "login"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Login"
		Me.registrarsePanel.ResumeLayout(False)
		Me.registrarsePanel.PerformLayout()
		Me.topPanel.ResumeLayout(False)
		Me.topPanel.PerformLayout()
		Me.ingresarPanel.ResumeLayout(False)
		Me.ingresarPanel.PerformLayout()
		CType(Me.separador, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents mainLabel As Label
    Friend WithEvents rContraTextBox As TextBox
    Friend WithEvents rRolComboBox As ComboBox
    Friend WithEvents registrarInfoLabel As Label
    Friend WithEvents registrarButton As Button
    Friend WithEvents IngresarButton As Button
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents registrarsePanel As Panel
    Friend WithEvents registrarseLabel As Label
    Friend WithEvents rCedulaTextBox As TextBox
    Friend WithEvents rolLabel As Label
    Friend WithEvents topPanel As Panel
    Friend WithEvents rRolFeedback As Label
    Friend WithEvents rCedulaFeedback As Label
    Friend WithEvents rContraFeedback As Label
    Friend WithEvents ingresarPanel As Panel
    Friend WithEvents iContraTextBox As TextBox
    Friend WithEvents iCedulaTextBox As TextBox
    Friend WithEvents ingresarLabel As Label
    Friend WithEvents separador As PictureBox
    Friend WithEvents cerrar As Label
	Friend WithEvents rApellidoTextBox As TextBox
	Friend WithEvents rNombreTextBox As TextBox
	Friend WithEvents rApellidoFeedback As Label
	Friend WithEvents rNombreFeedback As Label
	Friend WithEvents iContraFeedback As Label
	Friend WithEvents iCedulaFeedback As Label
	Friend WithEvents ingresarInfoLabel As Label
End Class
