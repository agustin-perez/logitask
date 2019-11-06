Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TileVehiculo
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
        Me.lbl_vin = New System.Windows.Forms.Label()
        Me.lbl_marca = New System.Windows.Forms.Label()
        Me.lbl_modelo = New System.Windows.Forms.Label()
        Me.img_icono = New System.Windows.Forms.PictureBox()
        CType(Me.img_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_vin
        '
        Me.lbl_vin.AutoEllipsis = True
        Me.lbl_vin.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vin.Location = New System.Drawing.Point(97, 9)
        Me.lbl_vin.Name = "lbl_vin"
        Me.lbl_vin.Size = New System.Drawing.Size(165, 31)
        Me.lbl_vin.TabIndex = 0
        Me.lbl_vin.Text = "VINABCD1234567890"
        '
        'lbl_marca
        '
        Me.lbl_marca.AutoEllipsis = True
        Me.lbl_marca.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_marca.Location = New System.Drawing.Point(97, 58)
        Me.lbl_marca.Name = "lbl_marca"
        Me.lbl_marca.Size = New System.Drawing.Size(85, 23)
        Me.lbl_marca.TabIndex = 1
        Me.lbl_marca.Text = "Marca"
        Me.lbl_marca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_modelo
        '
        Me.lbl_modelo.AutoEllipsis = True
        Me.lbl_modelo.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_modelo.Location = New System.Drawing.Point(188, 58)
        Me.lbl_modelo.Name = "lbl_modelo"
        Me.lbl_modelo.Size = New System.Drawing.Size(74, 23)
        Me.lbl_modelo.TabIndex = 2
        Me.lbl_modelo.Text = "Modelo"
        Me.lbl_modelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'img_icono
        '
        Me.img_icono.Image = Global.LibreriaGrafica.My.Resources.Images.autoEstandar
        Me.img_icono.Location = New System.Drawing.Point(1, 0)
        Me.img_icono.Name = "img_icono"
        Me.img_icono.Size = New System.Drawing.Size(90, 90)
        Me.img_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_icono.TabIndex = 3
        Me.img_icono.TabStop = False
        '
        'TileVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(280, 90)
        Me.Controls.Add(Me.img_icono)
        Me.Controls.Add(Me.lbl_modelo)
        Me.Controls.Add(Me.lbl_marca)
        Me.Controls.Add(Me.lbl_vin)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(280, 90)
        Me.MinimumSize = New System.Drawing.Size(280, 90)
        Me.Name = "TileVehiculo"
        Me.Text = "TileVehiculo"
        CType(Me.img_icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_vin As Windows.Forms.Label
    Friend WithEvents lbl_marca As Windows.Forms.Label
    Friend WithEvents lbl_modelo As Windows.Forms.Label
    Friend WithEvents img_icono As Windows.Forms.PictureBox
End Class
