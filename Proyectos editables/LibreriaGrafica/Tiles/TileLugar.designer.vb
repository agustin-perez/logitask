Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TileLugar
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
        Me.lbl_idlugar = New System.Windows.Forms.Label()
        Me.lbl_capacidad = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.icono = New System.Windows.Forms.PictureBox()
        CType(Me.icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_idlugar
        '
        Me.lbl_idlugar.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idlugar.Location = New System.Drawing.Point(225, 9)
        Me.lbl_idlugar.Name = "lbl_idlugar"
        Me.lbl_idlugar.Size = New System.Drawing.Size(43, 30)
        Me.lbl_idlugar.TabIndex = 1
        Me.lbl_idlugar.Text = "#0"
        '
        'lbl_capacidad
        '
        Me.lbl_capacidad.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_capacidad.Location = New System.Drawing.Point(96, 9)
        Me.lbl_capacidad.Name = "lbl_capacidad"
        Me.lbl_capacidad.Size = New System.Drawing.Size(77, 30)
        Me.lbl_capacidad.TabIndex = 2
        Me.lbl_capacidad.Text = "Capacidad"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.Location = New System.Drawing.Point(96, 51)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(172, 30)
        Me.lbl_nombre.TabIndex = 3
        Me.lbl_nombre.Text = "Nombre"
        Me.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'icono
        '
        Me.icono.Image = Global.LibreriaGrafica.My.Resources.Images.zonaView
        Me.icono.Location = New System.Drawing.Point(0, 0)
        Me.icono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.icono.Name = "icono"
        Me.icono.Size = New System.Drawing.Size(90, 90)
        Me.icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icono.TabIndex = 0
        Me.icono.TabStop = False
        '
        'TileLugar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(280, 90)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_capacidad)
        Me.Controls.Add(Me.lbl_idlugar)
        Me.Controls.Add(Me.icono)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(280, 90)
        Me.MinimumSize = New System.Drawing.Size(280, 90)
        Me.Name = "TileLugar"
        Me.Text = "7"
        CType(Me.icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents icono As PictureBox
    Friend WithEvents lbl_idlugar As Label
    Friend WithEvents lbl_capacidad As Label
    Friend WithEvents lbl_nombre As Label
End Class
