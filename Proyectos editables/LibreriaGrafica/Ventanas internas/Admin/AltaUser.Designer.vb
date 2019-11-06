Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AltaUser
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
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_ape = New System.Windows.Forms.Label()
        Me.lbl_tel = New System.Windows.Forms.Label()
        Me.lbl_cell = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.txt_username = New System.Windows.Forms.MaskedTextBox()
        Me.txt_surname = New System.Windows.Forms.MaskedTextBox()
        Me.txt_name = New System.Windows.Forms.MaskedTextBox()
        Me.txt_tel = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cell = New System.Windows.Forms.MaskedTextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.icono = New System.Windows.Forms.PictureBox()
        CType(Me.icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_username
        '
        Me.lbl_username.AutoEllipsis = True
        Me.lbl_username.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(12, 9)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(188, 40)
        Me.lbl_username.TabIndex = 0
        Me.lbl_username.Text = "Nombre de usuario:"
        Me.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoEllipsis = True
        Me.lbl_pass.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pass.Location = New System.Drawing.Point(12, 49)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(140, 40)
        Me.lbl_pass.TabIndex = 1
        Me.lbl_pass.Text = "Contraseña:"
        Me.lbl_pass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_name
        '
        Me.lbl_name.AutoEllipsis = True
        Me.lbl_name.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(12, 89)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(140, 40)
        Me.lbl_name.TabIndex = 2
        Me.lbl_name.Text = "Nombre:"
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_ape
        '
        Me.lbl_ape.AutoEllipsis = True
        Me.lbl_ape.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ape.Location = New System.Drawing.Point(12, 129)
        Me.lbl_ape.Name = "lbl_ape"
        Me.lbl_ape.Size = New System.Drawing.Size(140, 40)
        Me.lbl_ape.TabIndex = 3
        Me.lbl_ape.Text = "Apellido:"
        Me.lbl_ape.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_tel
        '
        Me.lbl_tel.AutoEllipsis = True
        Me.lbl_tel.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tel.Location = New System.Drawing.Point(12, 203)
        Me.lbl_tel.Name = "lbl_tel"
        Me.lbl_tel.Size = New System.Drawing.Size(140, 40)
        Me.lbl_tel.TabIndex = 8
        Me.lbl_tel.Text = "Teléfono fijo: "
        Me.lbl_tel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_cell
        '
        Me.lbl_cell.AutoEllipsis = True
        Me.lbl_cell.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cell.Location = New System.Drawing.Point(12, 247)
        Me.lbl_cell.Name = "lbl_cell"
        Me.lbl_cell.Size = New System.Drawing.Size(140, 40)
        Me.lbl_cell.TabIndex = 9
        Me.lbl_cell.Text = "Móvil: "
        Me.lbl_cell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_guardar
        '
        Me.btn_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_guardar.BackColor = System.Drawing.Color.DarkGray
        Me.btn_guardar.FlatAppearance.BorderSize = 0
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.Location = New System.Drawing.Point(664, 408)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(124, 30)
        Me.btn_guardar.TabIndex = 7
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_username.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txt_username.Location = New System.Drawing.Point(206, 21)
        Me.txt_username.Mask = "????????????????"
        Me.txt_username.Name = "txt_username"
        Me.txt_username.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txt_username.Size = New System.Drawing.Size(210, 25)
        Me.txt_username.TabIndex = 1
        '
        'txt_surname
        '
        Me.txt_surname.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_surname.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_surname.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txt_surname.Location = New System.Drawing.Point(206, 141)
        Me.txt_surname.Mask = "????????????????????????????????????????????????????????????????"
        Me.txt_surname.Name = "txt_surname"
        Me.txt_surname.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txt_surname.Size = New System.Drawing.Size(210, 25)
        Me.txt_surname.TabIndex = 4
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_name.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txt_name.Location = New System.Drawing.Point(206, 101)
        Me.txt_name.Mask = "????????????????????????????????????????????????????????????????"
        Me.txt_name.Name = "txt_name"
        Me.txt_name.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txt_name.Size = New System.Drawing.Size(210, 25)
        Me.txt_name.TabIndex = 3
        '
        'txt_tel
        '
        Me.txt_tel.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tel.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tel.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txt_tel.Location = New System.Drawing.Point(206, 215)
        Me.txt_tel.Mask = "0-000-0000"
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txt_tel.Size = New System.Drawing.Size(210, 25)
        Me.txt_tel.TabIndex = 5
        '
        'txt_cell
        '
        Me.txt_cell.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_cell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cell.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cell.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txt_cell.Location = New System.Drawing.Point(206, 259)
        Me.txt_cell.Mask = "000-000-000"
        Me.txt_cell.Name = "txt_cell"
        Me.txt_cell.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txt_cell.Size = New System.Drawing.Size(210, 25)
        Me.txt_cell.TabIndex = 6
        '
        'txt_pass
        '
        Me.txt_pass.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pass.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.Location = New System.Drawing.Point(206, 60)
        Me.txt_pass.MaxLength = 32
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(210, 25)
        Me.txt_pass.TabIndex = 2
        Me.txt_pass.UseSystemPasswordChar = True
        '
        'icono
        '
        Me.icono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.icono.Image = Global.LibreriaGrafica.My.Resources.Images.IconoEmp
        Me.icono.Location = New System.Drawing.Point(596, 21)
        Me.icono.Name = "icono"
        Me.icono.Size = New System.Drawing.Size(192, 181)
        Me.icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icono.TabIndex = 12
        Me.icono.TabStop = False
        '
        'AltaUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_cell)
        Me.Controls.Add(Me.txt_tel)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_surname)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.icono)
        Me.Controls.Add(Me.lbl_cell)
        Me.Controls.Add(Me.lbl_tel)
        Me.Controls.Add(Me.lbl_ape)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.lbl_username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AltaUser"
        Me.Text = "AltaUser"
        CType(Me.icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_username As Label
    Friend WithEvents lbl_pass As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_ape As Label
    Friend WithEvents lbl_tel As Label
    Friend WithEvents lbl_cell As Label
    Friend WithEvents icono As PictureBox
    Friend WithEvents btn_guardar As Button
    Friend WithEvents txt_username As MaskedTextBox
    Friend WithEvents txt_surname As MaskedTextBox
    Friend WithEvents txt_name As MaskedTextBox
    Friend WithEvents txt_tel As MaskedTextBox
    Friend WithEvents txt_cell As MaskedTextBox
    Friend WithEvents txt_pass As TextBox
End Class
