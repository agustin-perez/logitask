Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Damage
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
        Me.lbl_damage = New System.Windows.Forms.Label()
        Me.btn_img = New System.Windows.Forms.Button()
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.btn_listo = New System.Windows.Forms.Button()
        Me.pic_imagen = New System.Windows.Forms.PictureBox()
        Me.lbl_ruta = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        CType(Me.pic_imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_damage
        '
        Me.lbl_damage.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_damage.ForeColor = System.Drawing.Color.Black
        Me.lbl_damage.Location = New System.Drawing.Point(7, 9)
        Me.lbl_damage.Name = "lbl_damage"
        Me.lbl_damage.Size = New System.Drawing.Size(181, 23)
        Me.lbl_damage.TabIndex = 0
        Me.lbl_damage.Text = "Nuevo daño"
        '
        'btn_img
        '
        Me.btn_img.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_img.FlatAppearance.BorderSize = 0
        Me.btn_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_img.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_img.ForeColor = System.Drawing.Color.Black
        Me.btn_img.Location = New System.Drawing.Point(12, 246)
        Me.btn_img.Name = "btn_img"
        Me.btn_img.Size = New System.Drawing.Size(124, 30)
        Me.btn_img.TabIndex = 1
        Me.btn_img.Text = "Añadir imagen"
        Me.btn_img.UseVisualStyleBackColor = False
        '
        'lbl_desc
        '
        Me.lbl_desc.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc.ForeColor = System.Drawing.Color.Black
        Me.lbl_desc.Location = New System.Drawing.Point(9, 45)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(160, 23)
        Me.lbl_desc.TabIndex = 2
        Me.lbl_desc.Text = "Descripcion"
        '
        'btn_listo
        '
        Me.btn_listo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_listo.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_listo.FlatAppearance.BorderSize = 0
        Me.btn_listo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_listo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_listo.ForeColor = System.Drawing.Color.Black
        Me.btn_listo.Location = New System.Drawing.Point(465, 442)
        Me.btn_listo.Name = "btn_listo"
        Me.btn_listo.Size = New System.Drawing.Size(124, 30)
        Me.btn_listo.TabIndex = 4
        Me.btn_listo.Text = "Listo"
        Me.btn_listo.UseVisualStyleBackColor = False
        '
        'pic_imagen
        '
        Me.pic_imagen.Location = New System.Drawing.Point(294, 71)
        Me.pic_imagen.Name = "pic_imagen"
        Me.pic_imagen.Size = New System.Drawing.Size(276, 169)
        Me.pic_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_imagen.TabIndex = 5
        Me.pic_imagen.TabStop = False
        '
        'lbl_ruta
        '
        Me.lbl_ruta.AutoEllipsis = True
        Me.lbl_ruta.ForeColor = System.Drawing.Color.Black
        Me.lbl_ruta.Location = New System.Drawing.Point(142, 255)
        Me.lbl_ruta.Name = "lbl_ruta"
        Me.lbl_ruta.Size = New System.Drawing.Size(428, 18)
        Me.lbl_ruta.TabIndex = 6
        Me.lbl_ruta.Text = "-"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.BackColor = System.Drawing.Color.White
        Me.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_descripcion.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descripcion.ForeColor = System.Drawing.Color.Black
        Me.txt_descripcion.Location = New System.Drawing.Point(12, 71)
        Me.txt_descripcion.MaxLength = 30000
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(276, 169)
        Me.txt_descripcion.TabIndex = 3
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_cancelar.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_cancelar.FlatAppearance.BorderSize = 0
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Location = New System.Drawing.Point(12, 442)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(124, 30)
        Me.btn_cancelar.TabIndex = 7
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'Damage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(601, 484)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.lbl_ruta)
        Me.Controls.Add(Me.pic_imagen)
        Me.Controls.Add(Me.btn_listo)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.lbl_desc)
        Me.Controls.Add(Me.btn_img)
        Me.Controls.Add(Me.lbl_damage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Damage"
        Me.Text = "Agregar daño a la inspección"
        CType(Me.pic_imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_damage As Label
    Friend WithEvents btn_img As Button
    Friend WithEvents lbl_desc As Label
    Friend WithEvents btn_listo As Button
    Friend WithEvents pic_imagen As PictureBox
    Friend WithEvents lbl_ruta As Label
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents btn_cancelar As Button
End Class
