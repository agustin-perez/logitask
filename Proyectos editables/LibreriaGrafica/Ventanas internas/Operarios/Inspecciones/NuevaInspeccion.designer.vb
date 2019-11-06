Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NuevaInspeccion
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
        Me.btn_qr = New System.Windows.Forms.Button()
        Me.btn_vin = New System.Windows.Forms.Button()
        Me.txtb_vin = New System.Windows.Forms.TextBox()
        Me.ventana_vehiculos = New System.Windows.Forms.FlowLayoutPanel()
        Me.ventana = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btn_qr
        '
        Me.btn_qr.BackColor = System.Drawing.Color.DarkGray
        Me.btn_qr.FlatAppearance.BorderSize = 0
        Me.btn_qr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_qr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_qr.Location = New System.Drawing.Point(12, 12)
        Me.btn_qr.Name = "btn_qr"
        Me.btn_qr.Size = New System.Drawing.Size(175, 30)
        Me.btn_qr.TabIndex = 6
        Me.btn_qr.Text = "Inspeccionar desde QR"
        Me.btn_qr.UseVisualStyleBackColor = False
        '
        'btn_vin
        '
        Me.btn_vin.BackColor = System.Drawing.Color.DarkGray
        Me.btn_vin.FlatAppearance.BorderSize = 0
        Me.btn_vin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_vin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vin.Location = New System.Drawing.Point(193, 12)
        Me.btn_vin.Name = "btn_vin"
        Me.btn_vin.Size = New System.Drawing.Size(175, 30)
        Me.btn_vin.TabIndex = 7
        Me.btn_vin.Text = "Inspeccionar desde VIN"
        Me.btn_vin.UseVisualStyleBackColor = False
        '
        'txtb_vin
        '
        Me.txtb_vin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_vin.Location = New System.Drawing.Point(374, 16)
        Me.txtb_vin.MaxLength = 17
        Me.txtb_vin.Name = "txtb_vin"
        Me.txtb_vin.Size = New System.Drawing.Size(195, 22)
        Me.txtb_vin.TabIndex = 8
        '
        'ventana_vehiculos
        '
        Me.ventana_vehiculos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ventana_vehiculos.AutoScroll = True
        Me.ventana_vehiculos.Location = New System.Drawing.Point(0, 49)
        Me.ventana_vehiculos.Name = "ventana_vehiculos"
        Me.ventana_vehiculos.Size = New System.Drawing.Size(800, 402)
        Me.ventana_vehiculos.TabIndex = 9
        '
        'ventana
        '
        Me.ventana.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ventana.AutoScroll = True
        Me.ventana.AutoSize = True
        Me.ventana.BackColor = System.Drawing.Color.Transparent
        Me.ventana.Location = New System.Drawing.Point(0, 0)
        Me.ventana.Name = "ventana"
        Me.ventana.Size = New System.Drawing.Size(800, 450)
        Me.ventana.TabIndex = 0
        '
        'NuevaInspeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ventana_vehiculos)
        Me.Controls.Add(Me.txtb_vin)
        Me.Controls.Add(Me.btn_vin)
        Me.Controls.Add(Me.btn_qr)
        Me.Controls.Add(Me.ventana)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NuevaInspeccion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_qr As Button
    Friend WithEvents btn_vin As Button
    Friend WithEvents txtb_vin As TextBox
    Friend WithEvents ventana_vehiculos As FlowLayoutPanel
    Friend WithEvents ventana As Panel
End Class
