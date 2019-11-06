<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaMedioTransporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.icono = New System.Windows.Forms.PictureBox()
        Me.btn_crear = New System.Windows.Forms.Button()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.tipoBox = New System.Windows.Forms.ComboBox()
        Me.txt_color = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_color = New System.Windows.Forms.Label()
        Me.txt_anio = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_anio = New System.Windows.Forms.Label()
        Me.txt_modelo = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_modelo = New System.Windows.Forms.Label()
        Me.txt_marca = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_marca = New System.Windows.Forms.Label()
        Me.txt_VIN = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_VIN = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        CType(Me.icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'icono
        '
        Me.icono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.icono.Image = Global.LibreriaGrafica.My.Resources.Images.flatbedCargado
        Me.icono.Location = New System.Drawing.Point(596, 18)
        Me.icono.Name = "icono"
        Me.icono.Size = New System.Drawing.Size(192, 181)
        Me.icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icono.TabIndex = 53
        Me.icono.TabStop = False
        '
        'btn_crear
        '
        Me.btn_crear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_crear.BackColor = System.Drawing.Color.DarkGray
        Me.btn_crear.FlatAppearance.BorderSize = 0
        Me.btn_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_crear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_crear.Location = New System.Drawing.Point(664, 414)
        Me.btn_crear.Name = "btn_crear"
        Me.btn_crear.Size = New System.Drawing.Size(124, 30)
        Me.btn_crear.TabIndex = 52
        Me.btn_crear.Text = "Crear"
        Me.btn_crear.UseVisualStyleBackColor = False
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoEllipsis = True
        Me.lbl_tipo.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.lbl_tipo.ForeColor = System.Drawing.Color.Black
        Me.lbl_tipo.Location = New System.Drawing.Point(12, 207)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lbl_tipo.Size = New System.Drawing.Size(101, 29)
        Me.lbl_tipo.TabIndex = 51
        Me.lbl_tipo.Text = "Tipo"
        Me.lbl_tipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tipoBox
        '
        Me.tipoBox.FormattingEnabled = True
        Me.tipoBox.Items.AddRange(New Object() {"Auto", "Camión", "SUV", "Van", "MiniVan"})
        Me.tipoBox.Location = New System.Drawing.Point(127, 214)
        Me.tipoBox.Name = "tipoBox"
        Me.tipoBox.Size = New System.Drawing.Size(266, 21)
        Me.tipoBox.TabIndex = 50
        '
        'txt_color
        '
        Me.txt_color.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_color.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_color.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txt_color.Location = New System.Drawing.Point(127, 183)
        Me.txt_color.Mask = "LLLLLLLLLLLLLLLL"
        Me.txt_color.Name = "txt_color"
        Me.txt_color.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txt_color.Size = New System.Drawing.Size(266, 25)
        Me.txt_color.TabIndex = 49
        '
        'lbl_color
        '
        Me.lbl_color.AutoEllipsis = True
        Me.lbl_color.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.lbl_color.ForeColor = System.Drawing.Color.Black
        Me.lbl_color.Location = New System.Drawing.Point(12, 178)
        Me.lbl_color.Name = "lbl_color"
        Me.lbl_color.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lbl_color.Size = New System.Drawing.Size(109, 29)
        Me.lbl_color.TabIndex = 48
        Me.lbl_color.Text = "Color"
        Me.lbl_color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_anio
        '
        Me.txt_anio.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_anio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_anio.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_anio.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txt_anio.Location = New System.Drawing.Point(127, 152)
        Me.txt_anio.Mask = "LLLLLLLLLLLLLLLL"
        Me.txt_anio.Name = "txt_anio"
        Me.txt_anio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txt_anio.Size = New System.Drawing.Size(266, 25)
        Me.txt_anio.TabIndex = 47
        '
        'lbl_anio
        '
        Me.lbl_anio.AutoEllipsis = True
        Me.lbl_anio.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.lbl_anio.ForeColor = System.Drawing.Color.Black
        Me.lbl_anio.Location = New System.Drawing.Point(12, 147)
        Me.lbl_anio.Name = "lbl_anio"
        Me.lbl_anio.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lbl_anio.Size = New System.Drawing.Size(109, 29)
        Me.lbl_anio.TabIndex = 46
        Me.lbl_anio.Text = "Año"
        Me.lbl_anio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_modelo
        '
        Me.txt_modelo.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_modelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_modelo.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_modelo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txt_modelo.Location = New System.Drawing.Point(127, 121)
        Me.txt_modelo.Mask = "LLLLLLLLLLLLLLLL"
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txt_modelo.Size = New System.Drawing.Size(266, 25)
        Me.txt_modelo.TabIndex = 45
        '
        'lbl_modelo
        '
        Me.lbl_modelo.AutoEllipsis = True
        Me.lbl_modelo.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.lbl_modelo.ForeColor = System.Drawing.Color.Black
        Me.lbl_modelo.Location = New System.Drawing.Point(12, 116)
        Me.lbl_modelo.Name = "lbl_modelo"
        Me.lbl_modelo.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lbl_modelo.Size = New System.Drawing.Size(109, 29)
        Me.lbl_modelo.TabIndex = 44
        Me.lbl_modelo.Text = "Modelo"
        Me.lbl_modelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_marca
        '
        Me.txt_marca.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_marca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_marca.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_marca.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txt_marca.Location = New System.Drawing.Point(127, 90)
        Me.txt_marca.Mask = "LLLLLLLLLLLLLLLL"
        Me.txt_marca.Name = "txt_marca"
        Me.txt_marca.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txt_marca.Size = New System.Drawing.Size(266, 25)
        Me.txt_marca.TabIndex = 43
        '
        'lbl_marca
        '
        Me.lbl_marca.AutoEllipsis = True
        Me.lbl_marca.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.lbl_marca.ForeColor = System.Drawing.Color.Black
        Me.lbl_marca.Location = New System.Drawing.Point(12, 85)
        Me.lbl_marca.Name = "lbl_marca"
        Me.lbl_marca.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lbl_marca.Size = New System.Drawing.Size(109, 29)
        Me.lbl_marca.TabIndex = 42
        Me.lbl_marca.Text = "Marca"
        Me.lbl_marca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_VIN
        '
        Me.txt_VIN.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_VIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_VIN.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_VIN.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txt_VIN.Location = New System.Drawing.Point(127, 59)
        Me.txt_VIN.Mask = "LLLLLLLLLLLLLLLL"
        Me.txt_VIN.Name = "txt_VIN"
        Me.txt_VIN.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txt_VIN.Size = New System.Drawing.Size(266, 25)
        Me.txt_VIN.TabIndex = 41
        '
        'lbl_VIN
        '
        Me.lbl_VIN.AutoEllipsis = True
        Me.lbl_VIN.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.lbl_VIN.ForeColor = System.Drawing.Color.Black
        Me.lbl_VIN.Location = New System.Drawing.Point(12, 54)
        Me.lbl_VIN.Name = "lbl_VIN"
        Me.lbl_VIN.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lbl_VIN.Size = New System.Drawing.Size(109, 29)
        Me.lbl_VIN.TabIndex = 40
        Me.lbl_VIN.Text = "VIN"
        Me.lbl_VIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_title
        '
        Me.lbl_title.AutoEllipsis = True
        Me.lbl_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_title.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Black
        Me.lbl_title.Location = New System.Drawing.Point(0, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lbl_title.Size = New System.Drawing.Size(800, 50)
        Me.lbl_title.TabIndex = 39
        Me.lbl_title.Text = "Vehiculo de transportista"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AltaMedioTransporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.icono)
        Me.Controls.Add(Me.btn_crear)
        Me.Controls.Add(Me.lbl_tipo)
        Me.Controls.Add(Me.tipoBox)
        Me.Controls.Add(Me.txt_color)
        Me.Controls.Add(Me.lbl_color)
        Me.Controls.Add(Me.txt_anio)
        Me.Controls.Add(Me.lbl_anio)
        Me.Controls.Add(Me.txt_modelo)
        Me.Controls.Add(Me.lbl_modelo)
        Me.Controls.Add(Me.txt_marca)
        Me.Controls.Add(Me.lbl_marca)
        Me.Controls.Add(Me.txt_VIN)
        Me.Controls.Add(Me.lbl_VIN)
        Me.Controls.Add(Me.lbl_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AltaMedioTransporte"
        Me.Text = "AltaMedioTransporte"
        CType(Me.icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents icono As Windows.Forms.PictureBox
    Friend WithEvents btn_crear As Windows.Forms.Button
    Friend WithEvents lbl_tipo As Windows.Forms.Label
    Friend WithEvents tipoBox As Windows.Forms.ComboBox
    Friend WithEvents txt_color As Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_color As Windows.Forms.Label
    Friend WithEvents txt_anio As Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_anio As Windows.Forms.Label
    Friend WithEvents txt_modelo As Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_modelo As Windows.Forms.Label
    Friend WithEvents txt_marca As Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_marca As Windows.Forms.Label
    Friend WithEvents txt_VIN As Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_VIN As Windows.Forms.Label
    Friend WithEvents lbl_title As Windows.Forms.Label
End Class
