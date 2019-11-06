<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuMediosTransporte
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
        Me.ventanaMedios = New System.Windows.Forms.FlowLayoutPanel()
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
        Me.lbl_title.TabIndex = 11
        Me.lbl_title.Text = "Medios de transporte"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ventanaMedios
        '
        Me.ventanaMedios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ventanaMedios.AutoScroll = True
        Me.ventanaMedios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ventanaMedios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ventanaMedios.Location = New System.Drawing.Point(-2, 52)
        Me.ventanaMedios.Name = "ventanaMedios"
        Me.ventanaMedios.Size = New System.Drawing.Size(802, 400)
        Me.ventanaMedios.TabIndex = 29
        '
        'MenuMediosTransporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ventanaMedios)
        Me.Controls.Add(Me.lbl_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuMediosTransporte"
        Me.Text = "ListadoMediosTransporte"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_title As Windows.Forms.Label
	Friend WithEvents ventanaMedios As Windows.Forms.FlowLayoutPanel
End Class
