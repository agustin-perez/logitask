<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DatosInspecc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatosInspecc))
        Me.lbl_lug = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.atras = New System.Windows.Forms.Button()
        Me.txt_inspecDate = New System.Windows.Forms.TextBox()
        Me.numeroInspec = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_place = New System.Windows.Forms.TextBox()
        Me.ListaDamage = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbl_damage = New System.Windows.Forms.Label()
        Me.icono = New System.Windows.Forms.PictureBox()
        Me.lbl_vacio = New System.Windows.Forms.Label()
        Me.ventanaInspeccion = New System.Windows.Forms.Panel()
        CType(Me.icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_lug
        '
        Me.lbl_lug.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lug.Location = New System.Drawing.Point(12, 82)
        Me.lbl_lug.Name = "lbl_lug"
        Me.lbl_lug.Size = New System.Drawing.Size(124, 30)
        Me.lbl_lug.TabIndex = 3
        Me.lbl_lug.Text = "Lugar:"
        Me.lbl_lug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_date
        '
        Me.lbl_date.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(12, 112)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(124, 59)
        Me.lbl_date.TabIndex = 6
        Me.lbl_date.Text = "Momento de realización:"
        Me.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_user
        '
        Me.lbl_user.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.Location = New System.Drawing.Point(12, 52)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(124, 30)
        Me.lbl_user.TabIndex = 10
        Me.lbl_user.Text = "Responsable: "
        Me.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'atras
        '
        Me.atras.AutoEllipsis = True
        Me.atras.BackColor = System.Drawing.Color.Transparent
        Me.atras.Cursor = System.Windows.Forms.Cursors.Default
        Me.atras.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.atras.FlatAppearance.BorderSize = 0
        Me.atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.atras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atras.ForeColor = System.Drawing.Color.Black
        Me.atras.Location = New System.Drawing.Point(0, 2)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(44, 47)
        Me.atras.TabIndex = 11
        Me.atras.Text = "←"
        Me.atras.UseVisualStyleBackColor = False
        '
        'txt_inspecDate
        '
        Me.txt_inspecDate.BackColor = System.Drawing.Color.White
        Me.txt_inspecDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_inspecDate.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_inspecDate.Location = New System.Drawing.Point(142, 131)
        Me.txt_inspecDate.Name = "txt_inspecDate"
        Me.txt_inspecDate.ReadOnly = True
        Me.txt_inspecDate.Size = New System.Drawing.Size(214, 20)
        Me.txt_inspecDate.TabIndex = 12
        Me.txt_inspecDate.Text = "----"
        '
        'numeroInspec
        '
        Me.numeroInspec.BackColor = System.Drawing.Color.White
        Me.numeroInspec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numeroInspec.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numeroInspec.Location = New System.Drawing.Point(50, 16)
        Me.numeroInspec.Name = "numeroInspec"
        Me.numeroInspec.ReadOnly = True
        Me.numeroInspec.Size = New System.Drawing.Size(294, 20)
        Me.numeroInspec.TabIndex = 13
        Me.numeroInspec.Text = "#N"
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.White
        Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_username.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(142, 57)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.ReadOnly = True
        Me.txt_username.Size = New System.Drawing.Size(214, 20)
        Me.txt_username.TabIndex = 14
        Me.txt_username.Text = "----"
        '
        'txt_place
        '
        Me.txt_place.BackColor = System.Drawing.Color.White
        Me.txt_place.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_place.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_place.Location = New System.Drawing.Point(142, 87)
        Me.txt_place.Name = "txt_place"
        Me.txt_place.ReadOnly = True
        Me.txt_place.Size = New System.Drawing.Size(214, 20)
        Me.txt_place.TabIndex = 15
        Me.txt_place.Text = "----"
        '
        'ListaDamage
        '
        Me.ListaDamage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaDamage.AutoScroll = True
        Me.ListaDamage.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.ListaDamage.Location = New System.Drawing.Point(0, 222)
        Me.ListaDamage.MinimumSize = New System.Drawing.Size(800, 90)
        Me.ListaDamage.Name = "ListaDamage"
        Me.ListaDamage.Size = New System.Drawing.Size(834, 107)
        Me.ListaDamage.TabIndex = 16
        '
        'lbl_damage
        '
        Me.lbl_damage.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_damage.Location = New System.Drawing.Point(12, 171)
        Me.lbl_damage.Name = "lbl_damage"
        Me.lbl_damage.Size = New System.Drawing.Size(124, 48)
        Me.lbl_damage.TabIndex = 17
        Me.lbl_damage.Text = "Daños"
        Me.lbl_damage.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'icono
        '
        Me.icono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.icono.Image = CType(resources.GetObject("icono.Image"), System.Drawing.Image)
        Me.icono.ImageLocation = ""
        Me.icono.Location = New System.Drawing.Point(604, 12)
        Me.icono.Name = "icono"
        Me.icono.Size = New System.Drawing.Size(200, 207)
        Me.icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icono.TabIndex = 0
        Me.icono.TabStop = False
        '
        'lbl_vacio
        '
        Me.lbl_vacio.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vacio.Location = New System.Drawing.Point(12, 228)
        Me.lbl_vacio.Name = "lbl_vacio"
        Me.lbl_vacio.Size = New System.Drawing.Size(407, 46)
        Me.lbl_vacio.TabIndex = 22
        Me.lbl_vacio.Text = "No se determinaron daños en esta inspección."
        Me.lbl_vacio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ventanaInspeccion
        '
        Me.ventanaInspeccion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ventanaInspeccion.Location = New System.Drawing.Point(0, 335)
        Me.ventanaInspeccion.Name = "ventanaInspeccion"
        Me.ventanaInspeccion.Size = New System.Drawing.Size(834, 276)
        Me.ventanaInspeccion.TabIndex = 23
        '
        'DatosInspecc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(834, 611)
        Me.Controls.Add(Me.ventanaInspeccion)
        Me.Controls.Add(Me.lbl_vacio)
        Me.Controls.Add(Me.lbl_damage)
        Me.Controls.Add(Me.txt_place)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.numeroInspec)
        Me.Controls.Add(Me.txt_inspecDate)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_lug)
        Me.Controls.Add(Me.icono)
        Me.Controls.Add(Me.ListaDamage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(850, 650)
        Me.MinimumSize = New System.Drawing.Size(850, 650)
        Me.Name = "DatosInspecc"
        Me.Text = "Información de la inspección #N"
        CType(Me.icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_lug As Windows.Forms.Label
    Friend WithEvents lbl_date As Windows.Forms.Label
    Friend WithEvents lbl_user As Windows.Forms.Label
    Friend WithEvents atras As Windows.Forms.Button
    Friend WithEvents txt_inspecDate As Windows.Forms.TextBox
    Friend WithEvents numeroInspec As Windows.Forms.TextBox
    Friend WithEvents txt_username As Windows.Forms.TextBox
    Friend WithEvents txt_place As Windows.Forms.TextBox
    Friend WithEvents icono As Windows.Forms.PictureBox
    Friend WithEvents ListaDamage As Windows.Forms.FlowLayoutPanel
    Friend WithEvents lbl_damage As Windows.Forms.Label
    Friend WithEvents lbl_vacio As Windows.Forms.Label
    Friend WithEvents ventanaInspeccion As Windows.Forms.Panel
End Class
