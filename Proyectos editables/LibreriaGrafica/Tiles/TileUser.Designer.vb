<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TileUser
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
        Me.lbl_surname = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.img_icono = New System.Windows.Forms.PictureBox()
        Me.lbl_username = New System.Windows.Forms.Label()
        CType(Me.img_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_surname
        '
        Me.lbl_surname.Location = New System.Drawing.Point(164, 68)
        Me.lbl_surname.Name = "lbl_surname"
        Me.lbl_surname.Size = New System.Drawing.Size(98, 13)
        Me.lbl_surname.TabIndex = 8
        Me.lbl_surname.Text = "Apellido"
        Me.lbl_surname.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_name
        '
        Me.lbl_name.Location = New System.Drawing.Point(95, 68)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(63, 13)
        Me.lbl_name.TabIndex = 7
        Me.lbl_name.Text = "Nombre"
        '
        'img_icono
        '
        Me.img_icono.Image = Global.LibreriaGrafica.My.Resources.Images.IconoEmp
        Me.img_icono.Location = New System.Drawing.Point(-1, 0)
        Me.img_icono.Name = "img_icono"
        Me.img_icono.Size = New System.Drawing.Size(90, 90)
        Me.img_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_icono.TabIndex = 6
        Me.img_icono.TabStop = False
        '
        'lbl_username
        '
        Me.lbl_username.Location = New System.Drawing.Point(95, 9)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(63, 13)
        Me.lbl_username.TabIndex = 5
        Me.lbl_username.Text = "Username"
        '
        'TileUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(280, 90)
        Me.Controls.Add(Me.lbl_surname)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.img_icono)
        Me.Controls.Add(Me.lbl_username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(280, 90)
        Me.MinimumSize = New System.Drawing.Size(280, 90)
        Me.Name = "TileUser"
        Me.Text = "rrr"
        CType(Me.img_icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_surname As Windows.Forms.Label
    Friend WithEvents lbl_name As Windows.Forms.Label
    Friend WithEvents img_icono As Windows.Forms.PictureBox
    Friend WithEvents lbl_username As Windows.Forms.Label
End Class
