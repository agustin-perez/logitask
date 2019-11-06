<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SeleccionarLote
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
        Me.ventanaLotes = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.i_viaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.btn_reload = New System.Windows.Forms.Button()
        Me.IconoVehiculo = New System.Windows.Forms.PictureBox()
        Me.cmb_destino = New System.Windows.Forms.ComboBox()
        Me.lbl_destino = New System.Windows.Forms.Label()
        Me.lbl_partida = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.IconoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ventanaLotes
        '
        Me.ventanaLotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ventanaLotes.AutoScroll = True
        Me.ventanaLotes.Location = New System.Drawing.Point(0, 48)
        Me.ventanaLotes.Name = "ventanaLotes"
        Me.ventanaLotes.Size = New System.Drawing.Size(800, 320)
        Me.ventanaLotes.TabIndex = 0
        '
        'lbl_title
        '
        Me.lbl_title.AutoEllipsis = True
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Black
        Me.lbl_title.Location = New System.Drawing.Point(12, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lbl_title.Size = New System.Drawing.Size(344, 30)
        Me.lbl_title.TabIndex = 5
        Me.lbl_title.Text = "Ahora, seleccione al menos un lote..."
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btn_next.TabIndex = 6
        Me.btn_next.Text = "Continuar →"
        Me.btn_next.UseVisualStyleBackColor = False
        '
        'i_viaje
        '
        Me.i_viaje.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.i_viaje.ToolTipTitle = "Información:"
        '
        'errorLabel
        '
        Me.errorLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.errorLabel.AutoEllipsis = True
        Me.errorLabel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.errorLabel.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorLabel.ForeColor = System.Drawing.Color.Red
        Me.errorLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.errorLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.errorLabel.Location = New System.Drawing.Point(607, 5)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(67, 40)
        Me.errorLabel.TabIndex = 17
        Me.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.btn_reload.TabIndex = 23
        Me.btn_reload.UseVisualStyleBackColor = False
        '
        'IconoVehiculo
        '
        Me.IconoVehiculo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconoVehiculo.Image = Global.LibreriaGrafica.My.Resources.Images.autoEstandar
        Me.IconoVehiculo.Location = New System.Drawing.Point(680, 5)
        Me.IconoVehiculo.Name = "IconoVehiculo"
        Me.IconoVehiculo.Size = New System.Drawing.Size(67, 40)
        Me.IconoVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconoVehiculo.TabIndex = 24
        Me.IconoVehiculo.TabStop = False
        '
        'cmb_destino
        '
        Me.cmb_destino.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_destino.FormattingEnabled = True
        Me.cmb_destino.Location = New System.Drawing.Point(634, 381)
        Me.cmb_destino.Name = "cmb_destino"
        Me.cmb_destino.Size = New System.Drawing.Size(154, 21)
        Me.cmb_destino.TabIndex = 25
        '
        'lbl_destino
        '
        Me.lbl_destino.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_destino.AutoEllipsis = True
        Me.lbl_destino.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lbl_destino.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_destino.ForeColor = System.Drawing.Color.Black
        Me.lbl_destino.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lbl_destino.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_destino.Location = New System.Drawing.Point(520, 371)
        Me.lbl_destino.Name = "lbl_destino"
        Me.lbl_destino.Size = New System.Drawing.Size(108, 35)
        Me.lbl_destino.TabIndex = 26
        Me.lbl_destino.Text = "Fije destino"
        Me.lbl_destino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_partida
        '
        Me.lbl_partida.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_partida.AutoEllipsis = True
        Me.lbl_partida.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lbl_partida.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_partida.ForeColor = System.Drawing.Color.Black
        Me.lbl_partida.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lbl_partida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_partida.Location = New System.Drawing.Point(13, 371)
        Me.lbl_partida.Name = "lbl_partida"
        Me.lbl_partida.Size = New System.Drawing.Size(108, 35)
        Me.lbl_partida.TabIndex = 28
        Me.lbl_partida.Text = "Fije partida"
        Me.lbl_partida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(127, 381)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(154, 21)
        Me.ComboBox1.TabIndex = 27
        '
        'SeleccionarLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_partida)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lbl_destino)
        Me.Controls.Add(Me.cmb_destino)
        Me.Controls.Add(Me.IconoVehiculo)
        Me.Controls.Add(Me.btn_reload)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.ventanaLotes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SeleccionarLote"
        Me.Text = "IniciarViaje"
        CType(Me.IconoVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ventanaLotes As Windows.Forms.FlowLayoutPanel
    Friend WithEvents lbl_title As Windows.Forms.Label
    Friend WithEvents btn_next As Windows.Forms.Button
    Friend WithEvents i_viaje As Windows.Forms.ToolTip
    Friend WithEvents errorLabel As Windows.Forms.Label
    Friend WithEvents btn_reload As Windows.Forms.Button
    Friend WithEvents IconoVehiculo As Windows.Forms.PictureBox
    Friend WithEvents cmb_destino As Windows.Forms.ComboBox
    Friend WithEvents lbl_destino As Windows.Forms.Label
    Friend WithEvents lbl_partida As Windows.Forms.Label
    Friend WithEvents ComboBox1 As Windows.Forms.ComboBox
End Class
