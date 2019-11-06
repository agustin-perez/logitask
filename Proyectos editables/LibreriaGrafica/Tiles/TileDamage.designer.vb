Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TileDamage
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
        Me.lbl_numeroDanio = New System.Windows.Forms.Label()
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.img_icono = New System.Windows.Forms.PictureBox()
        CType(Me.img_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_numeroDanio
        '
        Me.lbl_numeroDanio.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numeroDanio.Location = New System.Drawing.Point(75, 9)
        Me.lbl_numeroDanio.Name = "lbl_numeroDanio"
        Me.lbl_numeroDanio.Size = New System.Drawing.Size(38, 23)
        Me.lbl_numeroDanio.TabIndex = 2
        Me.lbl_numeroDanio.Text = "#0"
        '
        'lbl_desc
        '
        Me.lbl_desc.AutoEllipsis = True
        Me.lbl_desc.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc.Location = New System.Drawing.Point(75, 48)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(193, 23)
        Me.lbl_desc.TabIndex = 3
        Me.lbl_desc.Text = "Descripción del daño"
        Me.lbl_desc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'img_icono
        '
        Me.img_icono.Image = Global.LibreriaGrafica.My.Resources.Images.damage
        Me.img_icono.Location = New System.Drawing.Point(-1, 0)
        Me.img_icono.Name = "img_icono"
        Me.img_icono.Size = New System.Drawing.Size(70, 80)
        Me.img_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_icono.TabIndex = 1
        Me.img_icono.TabStop = False
        '
        'TileDamage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(280, 80)
        Me.Controls.Add(Me.lbl_desc)
        Me.Controls.Add(Me.lbl_numeroDanio)
        Me.Controls.Add(Me.img_icono)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(280, 80)
        Me.MinimumSize = New System.Drawing.Size(280, 80)
        Me.Name = "TileDamage"
        CType(Me.img_icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents img_icono As PictureBox
    Friend WithEvents lbl_numeroDanio As Label
    Friend WithEvents lbl_desc As Label
End Class
