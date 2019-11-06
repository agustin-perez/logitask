<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionarMedio
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
        Me.components = New System.ComponentModel.Container()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.ventanaMedios = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.i_medio = New System.Windows.Forms.ToolTip(Me.components)
        Me.ventana = New System.Windows.Forms.Panel()
        Me.btn_reload = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoEllipsis = True
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Black
        Me.lbl_title.Location = New System.Drawing.Point(12, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lbl_title.Size = New System.Drawing.Size(464, 32)
        Me.lbl_title.TabIndex = 6
        Me.lbl_title.Text = "Primero, seleccione un medio de transporte"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ventanaMedios
        '
        Me.ventanaMedios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ventanaMedios.AutoScroll = True
        Me.ventanaMedios.Location = New System.Drawing.Point(0, 48)
        Me.ventanaMedios.Name = "ventanaMedios"
        Me.ventanaMedios.Size = New System.Drawing.Size(800, 358)
        Me.ventanaMedios.TabIndex = 19
        '
        'btn_next
        '
        Me.btn_next.BackColor = System.Drawing.Color.DarkGray
        Me.btn_next.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_next.FlatAppearance.BorderSize = 0
        Me.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_next.Location = New System.Drawing.Point(0, 409)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(800, 41)
        Me.btn_next.TabIndex = 20
        Me.btn_next.Text = "Continuar →"
        Me.btn_next.UseVisualStyleBackColor = False
        '
        'i_medio
        '
        Me.i_medio.ToolTipTitle = "Información: "
        '
        'ventana
        '
        Me.ventana.AutoScroll = True
        Me.ventana.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ventana.Location = New System.Drawing.Point(0, 0)
        Me.ventana.Name = "ventana"
        Me.ventana.Size = New System.Drawing.Size(800, 450)
        Me.ventana.TabIndex = 21
        '
        'btn_reload
        '
        Me.btn_reload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reload.AutoSize = True
        Me.btn_reload.BackColor = System.Drawing.Color.Transparent
        Me.btn_reload.BackgroundImage = Global.LibreriaGrafica.My.Resources.Images.reloadIcon
        Me.btn_reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_reload.FlatAppearance.BorderSize = 0
        Me.btn_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reload.Location = New System.Drawing.Point(753, 5)
        Me.btn_reload.Name = "btn_reload"
        Me.btn_reload.Size = New System.Drawing.Size(40, 40)
        Me.btn_reload.TabIndex = 22
        Me.btn_reload.UseVisualStyleBackColor = False
        '
        'SeleccionarMedio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_reload)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.ventanaMedios)
        Me.Controls.Add(Me.ventana)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SeleccionarMedio"
        Me.Text = "SeleccionarMedio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Windows.Forms.Label
    Friend WithEvents ventanaMedios As Windows.Forms.FlowLayoutPanel
    Friend WithEvents btn_next As Windows.Forms.Button
    Friend WithEvents i_medio As Windows.Forms.ToolTip
    Friend WithEvents ventana As Windows.Forms.Panel
    Friend WithEvents btn_reload As Windows.Forms.Button
End Class
