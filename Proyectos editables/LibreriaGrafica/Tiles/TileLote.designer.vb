Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TileLote
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
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_cant = New System.Windows.Forms.Label()
        Me.img_icono = New System.Windows.Forms.PictureBox()
        CType(Me.img_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_id
        '
        Me.lbl_id.Location = New System.Drawing.Point(95, 9)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(63, 13)
        Me.lbl_id.TabIndex = 0
        Me.lbl_id.Text = "ID"
        '
        'lbl_user
        '
        Me.lbl_user.Location = New System.Drawing.Point(199, 9)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(69, 13)
        Me.lbl_user.TabIndex = 2
        Me.lbl_user.Text = "Responsable"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.Location = New System.Drawing.Point(95, 68)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(63, 13)
        Me.lbl_nombre.TabIndex = 3
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_cant
        '
        Me.lbl_cant.Location = New System.Drawing.Point(199, 68)
        Me.lbl_cant.Name = "lbl_cant"
        Me.lbl_cant.Size = New System.Drawing.Size(63, 13)
        Me.lbl_cant.TabIndex = 4
        Me.lbl_cant.Text = "N/N"
        '
        'img_icono
        '
        Me.img_icono.Image = Global.LibreriaGrafica.My.Resources.Images.flatbedCargado
        Me.img_icono.Location = New System.Drawing.Point(-1, 0)
        Me.img_icono.Name = "img_icono"
        Me.img_icono.Size = New System.Drawing.Size(90, 90)
        Me.img_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_icono.TabIndex = 1
        Me.img_icono.TabStop = False
        '
        'TileLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(280, 90)
        Me.Controls.Add(Me.lbl_cant)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.img_icono)
        Me.Controls.Add(Me.lbl_id)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(280, 90)
        Me.MinimumSize = New System.Drawing.Size(280, 90)
        Me.Name = "TileLote"
        Me.Text = "TileLote"
        CType(Me.img_icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_id As Label
    Friend WithEvents img_icono As PictureBox
    Friend WithEvents lbl_user As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_cant As Label
End Class
