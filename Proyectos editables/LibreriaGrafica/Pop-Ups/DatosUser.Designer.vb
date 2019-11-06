<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosUser
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
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.atras = New System.Windows.Forms.Button()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.icono = New System.Windows.Forms.PictureBox()
        Me.txt_cell = New System.Windows.Forms.MaskedTextBox()
        Me.txt_tel = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_newpass = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.lbl_telfijo = New System.Windows.Forms.Label()
        Me.lbl_movil = New System.Windows.Forms.Label()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        CType(Me.icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.Color.White
        Me.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_name.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(142, 53)
        Me.txt_name.MaxLength = 64
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(214, 20)
        Me.txt_name.TabIndex = 25
        Me.txt_name.Text = "----"
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.White
        Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_username.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(51, 12)
        Me.txt_username.MaxLength = 16
        Me.txt_username.Name = "txt_username"
        Me.txt_username.ReadOnly = True
        Me.txt_username.Size = New System.Drawing.Size(305, 20)
        Me.txt_username.TabIndex = 24
        Me.txt_username.Text = "Username"
        '
        'txt_apellido
        '
        Me.txt_apellido.BackColor = System.Drawing.Color.White
        Me.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_apellido.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_apellido.Location = New System.Drawing.Point(142, 84)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.ReadOnly = True
        Me.txt_apellido.Size = New System.Drawing.Size(214, 20)
        Me.txt_apellido.TabIndex = 23
        Me.txt_apellido.Text = "----"
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
        Me.atras.Location = New System.Drawing.Point(1, -2)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(44, 47)
        Me.atras.TabIndex = 22
        Me.atras.Text = "←"
        Me.atras.UseVisualStyleBackColor = False
        '
        'lbl_apellido
        '
        Me.lbl_apellido.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apellido.Location = New System.Drawing.Point(12, 79)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(124, 30)
        Me.lbl_apellido.TabIndex = 21
        Me.lbl_apellido.Text = "Apellido"
        Me.lbl_apellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'icono
        '
        Me.icono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.icono.Image = Global.LibreriaGrafica.My.Resources.Images.IconoEmp
        Me.icono.ImageLocation = ""
        Me.icono.Location = New System.Drawing.Point(588, 12)
        Me.icono.Name = "icono"
        Me.icono.Size = New System.Drawing.Size(200, 207)
        Me.icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icono.TabIndex = 18
        Me.icono.TabStop = False
        '
        'txt_cell
        '
        Me.txt_cell.BackColor = System.Drawing.Color.White
        Me.txt_cell.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cell.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cell.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txt_cell.Location = New System.Drawing.Point(142, 146)
        Me.txt_cell.Mask = "000-000-000"
        Me.txt_cell.Name = "txt_cell"
        Me.txt_cell.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txt_cell.Size = New System.Drawing.Size(214, 18)
        Me.txt_cell.TabIndex = 35
        '
        'txt_tel
        '
        Me.txt_tel.BackColor = System.Drawing.Color.White
        Me.txt_tel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_tel.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tel.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txt_tel.Location = New System.Drawing.Point(142, 116)
        Me.txt_tel.Mask = "0-000-0000"
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txt_tel.Size = New System.Drawing.Size(214, 18)
        Me.txt_tel.TabIndex = 34
        '
        'lbl_newpass
        '
        Me.lbl_newpass.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_newpass.Location = New System.Drawing.Point(12, 190)
        Me.lbl_newpass.Name = "lbl_newpass"
        Me.lbl_newpass.Size = New System.Drawing.Size(124, 25)
        Me.lbl_newpass.TabIndex = 38
        Me.lbl_newpass.Text = "Contraseña nueva"
        Me.lbl_newpass.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lbl_newpass.Visible = False
        '
        'lbl_nombre
        '
        Me.lbl_nombre.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.Location = New System.Drawing.Point(12, 48)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(124, 30)
        Me.lbl_nombre.TabIndex = 39
        Me.lbl_nombre.Text = "Nombre"
        Me.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_pass
        '
        Me.txt_pass.BackColor = System.Drawing.Color.White
        Me.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_pass.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.Location = New System.Drawing.Point(142, 197)
        Me.txt_pass.MaxLength = 32
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(214, 18)
        Me.txt_pass.TabIndex = 29
        Me.txt_pass.Text = "----"
        Me.txt_pass.UseSystemPasswordChar = True
        Me.txt_pass.Visible = False
        '
        'lbl_telfijo
        '
        Me.lbl_telfijo.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telfijo.Location = New System.Drawing.Point(12, 109)
        Me.lbl_telfijo.Name = "lbl_telfijo"
        Me.lbl_telfijo.Size = New System.Drawing.Size(124, 30)
        Me.lbl_telfijo.TabIndex = 40
        Me.lbl_telfijo.Text = "Teléfono fijo"
        Me.lbl_telfijo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_movil
        '
        Me.lbl_movil.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_movil.Location = New System.Drawing.Point(12, 139)
        Me.lbl_movil.Name = "lbl_movil"
        Me.lbl_movil.Size = New System.Drawing.Size(124, 30)
        Me.lbl_movil.TabIndex = 41
        Me.lbl_movil.Text = "Móvil"
        Me.lbl_movil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_edit
        '
        Me.btn_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_edit.AutoSize = True
        Me.btn_edit.BackColor = System.Drawing.Color.Transparent
        Me.btn_edit.BackgroundImage = Global.LibreriaGrafica.My.Resources.Images.editIcon
        Me.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_edit.FlatAppearance.BorderSize = 0
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Location = New System.Drawing.Point(748, 398)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(40, 40)
        Me.btn_edit.TabIndex = 42
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.AutoSize = True
        Me.btn_save.BackColor = System.Drawing.Color.Transparent
        Me.btn_save.BackgroundImage = Global.LibreriaGrafica.My.Resources.Images.checkIcon
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Location = New System.Drawing.Point(748, 398)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(40, 40)
        Me.btn_save.TabIndex = 43
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.AutoSize = True
        Me.btn_delete.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete.BackgroundImage = Global.LibreriaGrafica.My.Resources.Images.deleteIcon
        Me.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Location = New System.Drawing.Point(702, 398)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(40, 40)
        Me.btn_delete.TabIndex = 44
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'DatosUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.lbl_movil)
        Me.Controls.Add(Me.lbl_telfijo)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_newpass)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_cell)
        Me.Controls.Add(Me.txt_tel)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.icono)
        Me.Controls.Add(Me.btn_save)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "DatosUser"
        Me.Text = "Datos del usuario USERNAME"
        CType(Me.icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_name As Windows.Forms.TextBox
    Friend WithEvents txt_username As Windows.Forms.TextBox
    Friend WithEvents txt_apellido As Windows.Forms.TextBox
    Friend WithEvents atras As Windows.Forms.Button
    Friend WithEvents lbl_apellido As Windows.Forms.Label
    Friend WithEvents icono As Windows.Forms.PictureBox
    Friend WithEvents txt_cell As Windows.Forms.MaskedTextBox
    Friend WithEvents txt_tel As Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_newpass As Windows.Forms.Label
    Friend WithEvents lbl_nombre As Windows.Forms.Label
    Friend WithEvents txt_pass As Windows.Forms.TextBox
    Friend WithEvents lbl_telfijo As Windows.Forms.Label
    Friend WithEvents lbl_movil As Windows.Forms.Label
    Friend WithEvents btn_edit As Windows.Forms.Button
    Friend WithEvents btn_save As Windows.Forms.Button
    Friend WithEvents btn_delete As Windows.Forms.Button
End Class
