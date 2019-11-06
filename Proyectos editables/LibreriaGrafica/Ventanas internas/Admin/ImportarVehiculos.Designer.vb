Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImportarVehiculos
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
        Me.ventanaVehiculos = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_cargar = New System.Windows.Forms.Button()
        Me.lbl_ruta = New System.Windows.Forms.Label()
        Me.btn_cargarBD = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ventanaVehiculos
        '
        Me.ventanaVehiculos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ventanaVehiculos.AutoScroll = True
        Me.ventanaVehiculos.Location = New System.Drawing.Point(0, 49)
        Me.ventanaVehiculos.Name = "ventanaVehiculos"
        Me.ventanaVehiculos.Size = New System.Drawing.Size(799, 401)
        Me.ventanaVehiculos.TabIndex = 0
        '
        'btn_cargar
        '
        Me.btn_cargar.BackColor = System.Drawing.Color.DarkGray
        Me.btn_cargar.FlatAppearance.BorderSize = 0
        Me.btn_cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cargar.Location = New System.Drawing.Point(12, 12)
        Me.btn_cargar.Name = "btn_cargar"
        Me.btn_cargar.Size = New System.Drawing.Size(124, 30)
        Me.btn_cargar.TabIndex = 14
        Me.btn_cargar.Text = "Seleccionar archivo"
        Me.btn_cargar.UseVisualStyleBackColor = False
        '
        'lbl_ruta
        '
        Me.lbl_ruta.AutoEllipsis = True
        Me.lbl_ruta.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ruta.Location = New System.Drawing.Point(142, 12)
        Me.lbl_ruta.Name = "lbl_ruta"
        Me.lbl_ruta.Size = New System.Drawing.Size(516, 30)
        Me.lbl_ruta.TabIndex = 15
        Me.lbl_ruta.Text = "-"
        Me.lbl_ruta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_cargarBD
        '
        Me.btn_cargarBD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cargarBD.BackColor = System.Drawing.Color.DarkGray
        Me.btn_cargarBD.FlatAppearance.BorderSize = 0
        Me.btn_cargarBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cargarBD.Location = New System.Drawing.Point(664, 12)
        Me.btn_cargarBD.Name = "btn_cargarBD"
        Me.btn_cargarBD.Size = New System.Drawing.Size(124, 30)
        Me.btn_cargarBD.TabIndex = 16
        Me.btn_cargarBD.Text = "Ingresar al sistema"
        Me.btn_cargarBD.UseVisualStyleBackColor = False
        '
        'ImportarVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_cargarBD)
        Me.Controls.Add(Me.lbl_ruta)
        Me.Controls.Add(Me.btn_cargar)
        Me.Controls.Add(Me.ventanaVehiculos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ImportarVehiculos"
        Me.Text = "ImportarVehiculos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ventanaVehiculos As FlowLayoutPanel
    Friend WithEvents btn_cargar As Button
    Friend WithEvents lbl_ruta As Label
    Friend WithEvents btn_cargarBD As Button
End Class
