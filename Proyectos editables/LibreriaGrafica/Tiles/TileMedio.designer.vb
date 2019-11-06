Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TileMedio
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
        Me.lbl_coche = New System.Windows.Forms.Label()
        Me.lbl_matricula = New System.Windows.Forms.Label()
        Me.lbl_cant = New System.Windows.Forms.Label()
        Me.img_icono = New System.Windows.Forms.PictureBox()
        CType(Me.img_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_coche
        '
        Me.lbl_coche.Location = New System.Drawing.Point(95, 9)
        Me.lbl_coche.Name = "lbl_coche"
        Me.lbl_coche.Size = New System.Drawing.Size(63, 13)
        Me.lbl_coche.TabIndex = 0
        Me.lbl_coche.Text = "Coche"
        '
        'lbl_matricula
        '
        Me.lbl_matricula.Location = New System.Drawing.Point(95, 68)
        Me.lbl_matricula.Name = "lbl_matricula"
        Me.lbl_matricula.Size = New System.Drawing.Size(63, 13)
        Me.lbl_matricula.TabIndex = 3
        Me.lbl_matricula.Text = "AAA-1234"
        '
        'lbl_cant
        '
        Me.lbl_cant.Location = New System.Drawing.Point(164, 68)
        Me.lbl_cant.Name = "lbl_cant"
        Me.lbl_cant.Size = New System.Drawing.Size(98, 13)
        Me.lbl_cant.TabIndex = 4
        Me.lbl_cant.Text = "Capacidad: N"
        Me.lbl_cant.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'img_icono
        '
        Me.img_icono.Image = Global.LibreriaGrafica.My.Resources.Images.loteEmbarcado
        Me.img_icono.Location = New System.Drawing.Point(-1, 0)
        Me.img_icono.Name = "img_icono"
        Me.img_icono.Size = New System.Drawing.Size(90, 90)
        Me.img_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_icono.TabIndex = 1
        Me.img_icono.TabStop = False
        '
        'TileMedio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(280, 90)
        Me.Controls.Add(Me.lbl_cant)
        Me.Controls.Add(Me.lbl_matricula)
        Me.Controls.Add(Me.img_icono)
        Me.Controls.Add(Me.lbl_coche)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(280, 90)
        Me.MinimumSize = New System.Drawing.Size(280, 90)
        Me.Name = "TileMedio"
        Me.Text = "TileLote"
        CType(Me.img_icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_coche As Label
    Friend WithEvents img_icono As PictureBox
    Friend WithEvents lbl_matricula As Label
    Friend WithEvents lbl_cant As Label
End Class
