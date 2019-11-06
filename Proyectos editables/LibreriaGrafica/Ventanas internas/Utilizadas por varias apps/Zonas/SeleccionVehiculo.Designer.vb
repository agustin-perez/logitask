<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MovimientoZona
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
		Me.ventanaVehiculos = New System.Windows.Forms.FlowLayoutPanel()
		Me.lbl_title = New System.Windows.Forms.Label()
		Me.btn_ready = New System.Windows.Forms.Button()
		Me.lbl_subtitle = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'ventanaVehiculos
		'
		Me.ventanaVehiculos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ventanaVehiculos.AutoScroll = True
		Me.ventanaVehiculos.Location = New System.Drawing.Point(12, 92)
		Me.ventanaVehiculos.Name = "ventanaVehiculos"
		Me.ventanaVehiculos.Size = New System.Drawing.Size(776, 309)
		Me.ventanaVehiculos.TabIndex = 11
		'
		'lbl_title
		'
		Me.lbl_title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lbl_title.AutoEllipsis = True
		Me.lbl_title.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_title.ForeColor = System.Drawing.Color.Black
		Me.lbl_title.Location = New System.Drawing.Point(-1, -1)
		Me.lbl_title.Name = "lbl_title"
		Me.lbl_title.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
		Me.lbl_title.Size = New System.Drawing.Size(802, 50)
		Me.lbl_title.TabIndex = 12
		Me.lbl_title.Text = "Seleccion de vehiculo"
		Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'btn_ready
		'
		Me.btn_ready.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btn_ready.BackColor = System.Drawing.Color.DarkGray
		Me.btn_ready.FlatAppearance.BorderSize = 0
		Me.btn_ready.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btn_ready.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_ready.Location = New System.Drawing.Point(664, 408)
		Me.btn_ready.Name = "btn_ready"
		Me.btn_ready.Size = New System.Drawing.Size(124, 30)
		Me.btn_ready.TabIndex = 14
		Me.btn_ready.Text = "Listo"
		Me.btn_ready.UseVisualStyleBackColor = False
		'
		'lbl_subtitle
		'
		Me.lbl_subtitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lbl_subtitle.AutoEllipsis = True
		Me.lbl_subtitle.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
		Me.lbl_subtitle.ForeColor = System.Drawing.Color.Red
		Me.lbl_subtitle.Location = New System.Drawing.Point(-2, 59)
		Me.lbl_subtitle.Name = "lbl_subtitle"
		Me.lbl_subtitle.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
		Me.lbl_subtitle.Size = New System.Drawing.Size(787, 38)
		Me.lbl_subtitle.TabIndex = 15
		Me.lbl_subtitle.Text = "Seleccione el o los vehiculos a mover y a continuación clickea en el boton ""listo" &
	""""
		Me.lbl_subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'MovimientoZona
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.lbl_subtitle)
		Me.Controls.Add(Me.btn_ready)
		Me.Controls.Add(Me.lbl_title)
		Me.Controls.Add(Me.ventanaVehiculos)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "MovimientoZona"
		Me.Text = "Seleccion de vehiculos"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents ventanaVehiculos As Windows.Forms.FlowLayoutPanel
	Friend WithEvents lbl_title As Windows.Forms.Label
	Friend WithEvents btn_ready As Windows.Forms.Button
	Friend WithEvents lbl_subtitle As Windows.Forms.Label
End Class
