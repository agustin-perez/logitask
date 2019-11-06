<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DatosDamage
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
        Me.lbl_detalles = New System.Windows.Forms.Label()
        Me.numeroDamage = New System.Windows.Forms.TextBox()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.foto = New System.Windows.Forms.PictureBox()
        CType(Me.foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_detalles
        '
        Me.lbl_detalles.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_detalles.Location = New System.Drawing.Point(12, 52)
        Me.lbl_detalles.Name = "lbl_detalles"
        Me.lbl_detalles.Size = New System.Drawing.Size(124, 30)
        Me.lbl_detalles.TabIndex = 1
        Me.lbl_detalles.Text = "Detalles: "
        Me.lbl_detalles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numeroDamage
        '
        Me.numeroDamage.BackColor = System.Drawing.Color.White
        Me.numeroDamage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numeroDamage.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numeroDamage.Location = New System.Drawing.Point(16, 12)
        Me.numeroDamage.Name = "numeroDamage"
        Me.numeroDamage.ReadOnly = True
        Me.numeroDamage.Size = New System.Drawing.Size(294, 20)
        Me.numeroDamage.TabIndex = 0
        Me.numeroDamage.Text = "#N"
        '
        'txt_desc
        '
        Me.txt_desc.BackColor = System.Drawing.Color.White
        Me.txt_desc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_desc.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desc.Location = New System.Drawing.Point(16, 85)
        Me.txt_desc.MaxLength = 256
        Me.txt_desc.Multiline = True
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.ReadOnly = True
        Me.txt_desc.Size = New System.Drawing.Size(410, 220)
        Me.txt_desc.TabIndex = 2
        Me.txt_desc.Text = "----"
        '
        'foto
        '
        Me.foto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.foto.Image = Global.LibreriaGrafica.My.Resources.Images.damage
        Me.foto.ImageLocation = ""
        Me.foto.Location = New System.Drawing.Point(432, 12)
        Me.foto.Name = "foto"
        Me.foto.Size = New System.Drawing.Size(287, 293)
        Me.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.foto.TabIndex = 0
        Me.foto.TabStop = False
        '
        'DatosDamage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(730, 325)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.numeroDamage)
        Me.Controls.Add(Me.lbl_detalles)
        Me.Controls.Add(Me.foto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DatosDamage"
        Me.Text = "Información del daño #N"
        CType(Me.foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_detalles As Windows.Forms.Label
    Friend WithEvents numeroDamage As Windows.Forms.TextBox
    Friend WithEvents txt_desc As Windows.Forms.TextBox
    Friend WithEvents foto As Windows.Forms.PictureBox
End Class
