<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoMedioTransporte
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
        Me.txt_numero = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_numero = New System.Windows.Forms.Label()
        Me.txt_matricula = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_matricula = New System.Windows.Forms.Label()
        Me.lbl_capacidad = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.lbl_title.TabIndex = 10
        Me.lbl_title.Text = "Ingresar medio de transporte"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_numero
        '
        Me.txt_numero.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numero.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txt_numero.Location = New System.Drawing.Point(167, 53)
        Me.txt_numero.Mask = "LLLLLLLLLLLLLLLL"
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txt_numero.Size = New System.Drawing.Size(266, 25)
        Me.txt_numero.TabIndex = 26
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoEllipsis = True
        Me.lbl_numero.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.lbl_numero.ForeColor = System.Drawing.Color.Black
        Me.lbl_numero.Location = New System.Drawing.Point(12, 48)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lbl_numero.Size = New System.Drawing.Size(108, 29)
        Me.lbl_numero.TabIndex = 25
        Me.lbl_numero.Text = "Número"
        Me.lbl_numero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_matricula
        '
        Me.txt_matricula.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_matricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_matricula.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matricula.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txt_matricula.Location = New System.Drawing.Point(167, 84)
        Me.txt_matricula.Mask = "LLLLLLLLLLLLLLLL"
        Me.txt_matricula.Name = "txt_matricula"
        Me.txt_matricula.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txt_matricula.Size = New System.Drawing.Size(266, 25)
        Me.txt_matricula.TabIndex = 28
        '
        'lbl_matricula
        '
        Me.lbl_matricula.AutoEllipsis = True
        Me.lbl_matricula.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.lbl_matricula.ForeColor = System.Drawing.Color.Black
        Me.lbl_matricula.Location = New System.Drawing.Point(12, 77)
        Me.lbl_matricula.Name = "lbl_matricula"
        Me.lbl_matricula.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lbl_matricula.Size = New System.Drawing.Size(117, 29)
        Me.lbl_matricula.TabIndex = 27
        Me.lbl_matricula.Text = "Matricula"
        Me.lbl_matricula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_capacidad
        '
        Me.lbl_capacidad.AutoEllipsis = True
        Me.lbl_capacidad.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.lbl_capacidad.ForeColor = System.Drawing.Color.Black
        Me.lbl_capacidad.Location = New System.Drawing.Point(12, 106)
        Me.lbl_capacidad.Name = "lbl_capacidad"
        Me.lbl_capacidad.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lbl_capacidad.Size = New System.Drawing.Size(108, 29)
        Me.lbl_capacidad.TabIndex = 29
        Me.lbl_capacidad.Text = "Capacidad"
        Me.lbl_capacidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btn_save.TabIndex = 38
        Me.btn_save.Text = "Guardar"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(167, 115)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(266, 20)
        Me.NumericUpDown1.TabIndex = 39
        '
        'NuevoMedioTransporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.lbl_capacidad)
        Me.Controls.Add(Me.txt_matricula)
        Me.Controls.Add(Me.lbl_matricula)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.lbl_numero)
        Me.Controls.Add(Me.lbl_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NuevoMedioTransporte"
        Me.Text = "NuevoMedioTransporte"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Windows.Forms.Label
	Friend WithEvents txt_numero As Windows.Forms.MaskedTextBox
	Friend WithEvents lbl_numero As Windows.Forms.Label
	Friend WithEvents txt_matricula As Windows.Forms.MaskedTextBox
	Friend WithEvents lbl_matricula As Windows.Forms.Label
    Friend WithEvents lbl_capacidad As Windows.Forms.Label
    Friend WithEvents btn_save As Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As Windows.Forms.NumericUpDown
End Class
