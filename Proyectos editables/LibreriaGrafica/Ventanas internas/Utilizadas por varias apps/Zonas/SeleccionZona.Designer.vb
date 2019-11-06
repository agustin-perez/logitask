<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SeleccionZona
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.ventanaZonas = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbl_subtitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.lbl_title.TabIndex = 6
        Me.lbl_title.Text = "Movimiento de zona"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ventanaZonas
        '
        Me.ventanaZonas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ventanaZonas.AutoScroll = True
        Me.ventanaZonas.Location = New System.Drawing.Point(0, 81)
        Me.ventanaZonas.Name = "ventanaZonas"
        Me.ventanaZonas.Size = New System.Drawing.Size(800, 369)
        Me.ventanaZonas.TabIndex = 10
        '
        'lbl_subtitle
        '
        Me.lbl_subtitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_subtitle.AutoEllipsis = True
        Me.lbl_subtitle.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.lbl_subtitle.ForeColor = System.Drawing.Color.Red
        Me.lbl_subtitle.Location = New System.Drawing.Point(1, 49)
        Me.lbl_subtitle.Name = "lbl_subtitle"
        Me.lbl_subtitle.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lbl_subtitle.Size = New System.Drawing.Size(800, 29)
        Me.lbl_subtitle.TabIndex = 14
        Me.lbl_subtitle.Text = "Seleccione la zona a la que se va a mover el o los vehiculos"
        Me.lbl_subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SeleccionZona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_subtitle)
        Me.Controls.Add(Me.ventanaZonas)
        Me.Controls.Add(Me.lbl_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SeleccionZona"
        Me.Text = "MovimientoZona"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_title As Windows.Forms.Label
	Friend WithEvents ventanaZonas As Windows.Forms.FlowLayoutPanel
	Friend WithEvents lbl_subtitle As Windows.Forms.Label
End Class
