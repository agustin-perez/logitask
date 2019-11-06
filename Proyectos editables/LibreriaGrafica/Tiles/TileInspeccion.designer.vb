Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TileInspeccion
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
        Me.img_icono = New System.Windows.Forms.PictureBox()
        Me.lbl_inspec = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_autor = New System.Windows.Forms.Label()
        CType(Me.img_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'img_icono
        '
        Me.img_icono.Image = Global.LibreriaGrafica.My.Resources.Images.inspeccionIcon
        Me.img_icono.Location = New System.Drawing.Point(-1, 0)
        Me.img_icono.Name = "img_icono"
        Me.img_icono.Size = New System.Drawing.Size(90, 90)
        Me.img_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_icono.TabIndex = 1
        Me.img_icono.TabStop = False
        '
        'lbl_inspec
        '
        Me.lbl_inspec.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_inspec.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inspec.Location = New System.Drawing.Point(230, 9)
        Me.lbl_inspec.Name = "lbl_inspec"
        Me.lbl_inspec.Size = New System.Drawing.Size(38, 23)
        Me.lbl_inspec.TabIndex = 2
        Me.lbl_inspec.Text = "#0"
        '
        'lbl_date
        '
        Me.lbl_date.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(99, 58)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(169, 23)
        Me.lbl_date.TabIndex = 3
        Me.lbl_date.Text = "01/01/2000 00:00:00"
        Me.lbl_date.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lbl_autor
        '
        Me.lbl_autor.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_autor.Location = New System.Drawing.Point(99, 8)
        Me.lbl_autor.Name = "lbl_autor"
        Me.lbl_autor.Size = New System.Drawing.Size(100, 23)
        Me.lbl_autor.TabIndex = 4
        Me.lbl_autor.Text = "Username"
        Me.lbl_autor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TileInspeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(280, 90)
        Me.Controls.Add(Me.lbl_autor)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_inspec)
        Me.Controls.Add(Me.img_icono)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(280, 90)
        Me.MinimumSize = New System.Drawing.Size(280, 90)
        Me.Name = "TileInspeccion"
        Me.Text = "TileInspeccion"
        CType(Me.img_icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents img_icono As PictureBox
    Friend WithEvents lbl_inspec As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_autor As Label
End Class
