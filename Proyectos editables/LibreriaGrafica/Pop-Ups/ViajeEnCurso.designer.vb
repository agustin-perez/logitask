Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViajeEnCurso
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
        Me.components = New System.ComponentModel.Container()
        Me.ventana = New System.Windows.Forms.Panel()
        Me.lbl_tiempo = New System.Windows.Forms.Label()
        Me.btn_finalizar = New System.Windows.Forms.Button()
        Me.usuario = New System.Windows.Forms.Label()
        Me.coche = New System.Windows.Forms.Label()
        Me.lbl_Lote = New System.Windows.Forms.Label()
        Me.lbl_vehiculos = New System.Windows.Forms.Label()
        Me.btn_centrar = New System.Windows.Forms.Button()
        Me.timerRelojPrincipal = New System.Windows.Forms.Timer(Me.components)
        Me.btn_zoomOut = New System.Windows.Forms.Button()
        Me.btn_zoomIn = New System.Windows.Forms.Button()
        Me.panel_data = New System.Windows.Forms.Panel()
        Me.lbl_destino = New System.Windows.Forms.Label()
        Me.updateMap = New System.Windows.Forms.Timer(Me.components)
        Me.updateDBLocation = New System.Windows.Forms.Timer(Me.components)
        Me.MapCenter = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_horareal = New System.Windows.Forms.Label()
        Me.clk_sistema = New System.Windows.Forms.Timer(Me.components)
        Me.panel_data.SuspendLayout()
        Me.SuspendLayout()
        '
        'ventana
        '
        Me.ventana.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ventana.Location = New System.Drawing.Point(0, 0)
        Me.ventana.Name = "ventana"
        Me.ventana.Size = New System.Drawing.Size(804, 462)
        Me.ventana.TabIndex = 0
        '
        'lbl_tiempo
        '
        Me.lbl_tiempo.BackColor = System.Drawing.Color.DarkGray
        Me.lbl_tiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_tiempo.Font = New System.Drawing.Font("Segoe UI Light", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tiempo.ForeColor = System.Drawing.Color.Black
        Me.lbl_tiempo.Location = New System.Drawing.Point(12, 9)
        Me.lbl_tiempo.Name = "lbl_tiempo"
        Me.lbl_tiempo.Size = New System.Drawing.Size(236, 53)
        Me.lbl_tiempo.TabIndex = 1
        Me.lbl_tiempo.Text = "HH:MM:SS"
        Me.lbl_tiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_finalizar
        '
        Me.btn_finalizar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_finalizar.BackColor = System.Drawing.Color.DarkGray
        Me.btn_finalizar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_finalizar.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_finalizar.ForeColor = System.Drawing.Color.Black
        Me.btn_finalizar.Location = New System.Drawing.Point(12, 405)
        Me.btn_finalizar.Name = "btn_finalizar"
        Me.btn_finalizar.Size = New System.Drawing.Size(780, 40)
        Me.btn_finalizar.TabIndex = 2
        Me.btn_finalizar.Text = "Finalizar viaje"
        Me.btn_finalizar.UseVisualStyleBackColor = False
        '
        'usuario
        '
        Me.usuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.usuario.AutoEllipsis = True
        Me.usuario.BackColor = System.Drawing.Color.Transparent
        Me.usuario.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usuario.ForeColor = System.Drawing.Color.Black
        Me.usuario.Location = New System.Drawing.Point(2, 0)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(229, 37)
        Me.usuario.TabIndex = 5
        Me.usuario.Text = "Usuario NaN"
        Me.usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'coche
        '
        Me.coche.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.coche.AutoEllipsis = True
        Me.coche.BackColor = System.Drawing.Color.Transparent
        Me.coche.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coche.ForeColor = System.Drawing.Color.Black
        Me.coche.Location = New System.Drawing.Point(-1, 37)
        Me.coche.Name = "coche"
        Me.coche.Size = New System.Drawing.Size(193, 37)
        Me.coche.TabIndex = 6
        Me.coche.Text = "Coche N"
        Me.coche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_Lote
        '
        Me.lbl_Lote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Lote.AutoEllipsis = True
        Me.lbl_Lote.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Lote.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Lote.ForeColor = System.Drawing.Color.Black
        Me.lbl_Lote.Location = New System.Drawing.Point(-1, 74)
        Me.lbl_Lote.Name = "lbl_Lote"
        Me.lbl_Lote.Size = New System.Drawing.Size(111, 37)
        Me.lbl_Lote.TabIndex = 7
        Me.lbl_Lote.Text = "Lote N"
        Me.lbl_Lote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_vehiculos
        '
        Me.lbl_vehiculos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_vehiculos.AutoEllipsis = True
        Me.lbl_vehiculos.BackColor = System.Drawing.Color.Transparent
        Me.lbl_vehiculos.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vehiculos.ForeColor = System.Drawing.Color.Black
        Me.lbl_vehiculos.Location = New System.Drawing.Point(-1, 110)
        Me.lbl_vehiculos.Name = "lbl_vehiculos"
        Me.lbl_vehiculos.Size = New System.Drawing.Size(229, 37)
        Me.lbl_vehiculos.TabIndex = 8
        Me.lbl_vehiculos.Text = "N/N vehículos"
        Me.lbl_vehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_centrar
        '
        Me.btn_centrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_centrar.BackColor = System.Drawing.Color.DarkGray
        Me.btn_centrar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_centrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_centrar.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_centrar.ForeColor = System.Drawing.Color.Black
        Me.btn_centrar.Location = New System.Drawing.Point(652, 359)
        Me.btn_centrar.Name = "btn_centrar"
        Me.btn_centrar.Size = New System.Drawing.Size(140, 40)
        Me.btn_centrar.TabIndex = 10
        Me.btn_centrar.Text = "Centrar mapa"
        Me.btn_centrar.UseVisualStyleBackColor = False
        '
        'timerRelojPrincipal
        '
        Me.timerRelojPrincipal.Interval = 1000
        '
        'btn_zoomOut
        '
        Me.btn_zoomOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_zoomOut.AutoEllipsis = True
        Me.btn_zoomOut.BackColor = System.Drawing.Color.DarkGray
        Me.btn_zoomOut.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_zoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_zoomOut.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_zoomOut.ForeColor = System.Drawing.Color.Black
        Me.btn_zoomOut.Location = New System.Drawing.Point(744, 313)
        Me.btn_zoomOut.Name = "btn_zoomOut"
        Me.btn_zoomOut.Size = New System.Drawing.Size(48, 40)
        Me.btn_zoomOut.TabIndex = 11
        Me.btn_zoomOut.Text = " -"
        Me.btn_zoomOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_zoomOut.UseVisualStyleBackColor = False
        '
        'btn_zoomIn
        '
        Me.btn_zoomIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_zoomIn.AutoEllipsis = True
        Me.btn_zoomIn.BackColor = System.Drawing.Color.DarkGray
        Me.btn_zoomIn.Enabled = False
        Me.btn_zoomIn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_zoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_zoomIn.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_zoomIn.ForeColor = System.Drawing.Color.Black
        Me.btn_zoomIn.Location = New System.Drawing.Point(744, 267)
        Me.btn_zoomIn.Name = "btn_zoomIn"
        Me.btn_zoomIn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_zoomIn.Size = New System.Drawing.Size(48, 40)
        Me.btn_zoomIn.TabIndex = 12
        Me.btn_zoomIn.Text = " +"
        Me.btn_zoomIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_zoomIn.UseVisualStyleBackColor = False
        '
        'panel_data
        '
        Me.panel_data.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panel_data.BackColor = System.Drawing.Color.DarkGray
        Me.panel_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_data.Controls.Add(Me.lbl_destino)
        Me.panel_data.Controls.Add(Me.usuario)
        Me.panel_data.Controls.Add(Me.coche)
        Me.panel_data.Controls.Add(Me.lbl_Lote)
        Me.panel_data.Controls.Add(Me.lbl_vehiculos)
        Me.panel_data.Location = New System.Drawing.Point(12, 202)
        Me.panel_data.Name = "panel_data"
        Me.panel_data.Size = New System.Drawing.Size(236, 197)
        Me.panel_data.TabIndex = 13
        '
        'lbl_destino
        '
        Me.lbl_destino.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_destino.AutoEllipsis = True
        Me.lbl_destino.BackColor = System.Drawing.Color.Transparent
        Me.lbl_destino.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_destino.ForeColor = System.Drawing.Color.Black
        Me.lbl_destino.Location = New System.Drawing.Point(-1, 147)
        Me.lbl_destino.Name = "lbl_destino"
        Me.lbl_destino.Size = New System.Drawing.Size(229, 37)
        Me.lbl_destino.TabIndex = 9
        Me.lbl_destino.Text = "Destino nombreLugar"
        Me.lbl_destino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'updateMap
        '
        Me.updateMap.Interval = 500
        '
        'updateDBLocation
        '
        Me.updateDBLocation.Interval = 8000
        '
        'MapCenter
        '
        Me.MapCenter.Interval = 10000
        '
        'lbl_horareal
        '
        Me.lbl_horareal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_horareal.BackColor = System.Drawing.Color.DarkGray
        Me.lbl_horareal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_horareal.Font = New System.Drawing.Font("Segoe UI Light", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_horareal.ForeColor = System.Drawing.Color.Black
        Me.lbl_horareal.Location = New System.Drawing.Point(556, 9)
        Me.lbl_horareal.Name = "lbl_horareal"
        Me.lbl_horareal.Size = New System.Drawing.Size(236, 53)
        Me.lbl_horareal.TabIndex = 14
        Me.lbl_horareal.Text = "HH:MM:SS"
        Me.lbl_horareal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'clk_sistema
        '
        Me.clk_sistema.Interval = 1000
        '
        'ViajeEnCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(804, 462)
        Me.Controls.Add(Me.lbl_horareal)
        Me.Controls.Add(Me.btn_zoomIn)
        Me.Controls.Add(Me.btn_zoomOut)
        Me.Controls.Add(Me.btn_centrar)
        Me.Controls.Add(Me.btn_finalizar)
        Me.Controls.Add(Me.lbl_tiempo)
        Me.Controls.Add(Me.panel_data)
        Me.Controls.Add(Me.ventana)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ViajeEnCurso"
        Me.Text = "ViajeEnCurso"
        Me.panel_data.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_tiempo As Label
    Friend WithEvents btn_finalizar As Button
    Friend WithEvents usuario As Label
    Friend WithEvents coche As Label
    Friend WithEvents lbl_Lote As Label
    Friend WithEvents lbl_vehiculos As Label
    Friend WithEvents btn_centrar As Button
    Friend WithEvents timerRelojPrincipal As Timer
    Friend WithEvents btn_zoomOut As Button
    Friend WithEvents btn_zoomIn As Button
    Friend WithEvents panel_data As Panel
    Friend WithEvents ventana As Panel
    Friend WithEvents updateMap As Timer
    Friend WithEvents updateDBLocation As Timer
    Friend WithEvents MapCenter As Timer
    Friend WithEvents lbl_destino As Label
    Friend WithEvents lbl_horareal As Label
    Friend WithEvents clk_sistema As Timer
End Class
