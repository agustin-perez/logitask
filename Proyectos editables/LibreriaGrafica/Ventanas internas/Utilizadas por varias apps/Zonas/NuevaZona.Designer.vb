<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaZona
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.lbl_capacidad = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.chk_subzona = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_title.AutoEllipsis = True
        Me.lbl_title.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Black
        Me.lbl_title.Location = New System.Drawing.Point(0, -1)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lbl_title.Size = New System.Drawing.Size(802, 50)
        Me.lbl_title.TabIndex = 7
        Me.lbl_title.Text = "Creación de zonas"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoEllipsis = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.lbl_nombre.ForeColor = System.Drawing.Color.Black
        Me.lbl_nombre.Location = New System.Drawing.Point(12, 49)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lbl_nombre.Size = New System.Drawing.Size(115, 29)
        Me.lbl_nombre.TabIndex = 15
        Me.lbl_nombre.Text = "Nombre"
        Me.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_username.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txt_username.Location = New System.Drawing.Point(133, 54)
        Me.txt_username.Mask = "LLLLLLLLLLLLLLLL"
        Me.txt_username.Name = "txt_username"
        Me.txt_username.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txt_username.Size = New System.Drawing.Size(343, 25)
        Me.txt_username.TabIndex = 16
        '
        'lbl_desc
        '
        Me.lbl_desc.AutoEllipsis = True
        Me.lbl_desc.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.lbl_desc.ForeColor = System.Drawing.Color.Black
        Me.lbl_desc.Location = New System.Drawing.Point(12, 112)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lbl_desc.Size = New System.Drawing.Size(115, 29)
        Me.lbl_desc.TabIndex = 17
        Me.lbl_desc.Text = "Descripción"
        Me.lbl_desc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_capacidad
        '
        Me.lbl_capacidad.AutoEllipsis = True
        Me.lbl_capacidad.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.lbl_capacidad.ForeColor = System.Drawing.Color.Black
        Me.lbl_capacidad.Location = New System.Drawing.Point(12, 80)
        Me.lbl_capacidad.Name = "lbl_capacidad"
        Me.lbl_capacidad.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lbl_capacidad.Size = New System.Drawing.Size(115, 29)
        Me.lbl_capacidad.TabIndex = 19
        Me.lbl_capacidad.Text = "Capacidad"
        Me.lbl_capacidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_descripcion
        '
        Me.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_descripcion.Location = New System.Drawing.Point(133, 112)
        Me.txt_descripcion.MaxLength = 30000
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(343, 144)
        Me.txt_descripcion.TabIndex = 21
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.BackColor = System.Drawing.Color.DarkGray
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(664, 408)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(124, 30)
        Me.btn_save.TabIndex = 22
        Me.btn_save.Text = "Guardar"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(133, 86)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(343, 20)
        Me.NumericUpDown1.TabIndex = 23
        '
        'chk_subzona
        '
        Me.chk_subzona.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_subzona.Location = New System.Drawing.Point(133, 262)
        Me.chk_subzona.Name = "chk_subzona"
        Me.chk_subzona.Size = New System.Drawing.Size(51, 24)
        Me.chk_subzona.TabIndex = 25
        Me.chk_subzona.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_subzona.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(133, 306)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(343, 21)
        Me.ComboBox1.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(115, 48)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Zona a la que pertenece"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(115, 29)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Subzona"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NuevaZona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.chk_subzona)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.lbl_capacidad)
        Me.Controls.Add(Me.lbl_desc)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NuevaZona"
        Me.Text = "NuevaZona"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Windows.Forms.Label
	Friend WithEvents lbl_nombre As Windows.Forms.Label
	Friend WithEvents txt_username As Windows.Forms.MaskedTextBox
	Friend WithEvents lbl_desc As Windows.Forms.Label
    Friend WithEvents lbl_capacidad As Windows.Forms.Label
    Friend WithEvents txt_descripcion As Windows.Forms.TextBox
    Friend WithEvents btn_save As Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As Windows.Forms.NumericUpDown
    Friend WithEvents chk_subzona As Windows.Forms.CheckBox
    Friend WithEvents ComboBox1 As Windows.Forms.ComboBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
End Class
