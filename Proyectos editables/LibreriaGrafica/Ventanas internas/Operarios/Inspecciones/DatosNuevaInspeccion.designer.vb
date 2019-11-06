Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DatosNuevaInspeccion
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
        Me.txt_damages = New System.Windows.Forms.TextBox()
        Me.btn_newDamage = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.ventana = New System.Windows.Forms.Panel()
        Me.lbl_damageText = New System.Windows.Forms.Label()
        Me.contenedorVentana = New System.Windows.Forms.Panel()
        Me.lbl_titleInspec = New System.Windows.Forms.Label()
        Me.lbl_numeroInspec = New System.Windows.Forms.Label()
        Me.contenedorVentana.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_damages
        '
        Me.txt_damages.BackColor = System.Drawing.Color.White
        Me.txt_damages.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_damages.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_damages.Location = New System.Drawing.Point(12, 146)
        Me.txt_damages.Multiline = True
        Me.txt_damages.Name = "txt_damages"
        Me.txt_damages.ReadOnly = True
        Me.txt_damages.Size = New System.Drawing.Size(310, 196)
        Me.txt_damages.TabIndex = 2
        '
        'btn_newDamage
        '
        Me.btn_newDamage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_newDamage.BackColor = System.Drawing.Color.DarkGray
        Me.btn_newDamage.FlatAppearance.BorderSize = 0
        Me.btn_newDamage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_newDamage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newDamage.Location = New System.Drawing.Point(12, 393)
        Me.btn_newDamage.Name = "btn_newDamage"
        Me.btn_newDamage.Size = New System.Drawing.Size(124, 30)
        Me.btn_newDamage.TabIndex = 6
        Me.btn_newDamage.Text = "Nuevo Daño"
        Me.btn_newDamage.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_guardar.BackColor = System.Drawing.Color.DarkGray
        Me.btn_guardar.FlatAppearance.BorderSize = 0
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.Location = New System.Drawing.Point(541, 393)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(124, 30)
        Me.btn_guardar.TabIndex = 7
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'ventana
        '
        Me.ventana.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ventana.Location = New System.Drawing.Point(0, 0)
        Me.ventana.Name = "ventana"
        Me.ventana.Size = New System.Drawing.Size(677, 435)
        Me.ventana.TabIndex = 12
        '
        'lbl_damageText
        '
        Me.lbl_damageText.Location = New System.Drawing.Point(3, 0)
        Me.lbl_damageText.Name = "lbl_damageText"
        Me.lbl_damageText.Size = New System.Drawing.Size(281, 51)
        Me.lbl_damageText.TabIndex = 0
        Me.lbl_damageText.Text = "Si el vehículo no dispone de daños, simplemente guarde la inspección." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'contenedorVentana
        '
        Me.contenedorVentana.Controls.Add(Me.lbl_damageText)
        Me.contenedorVentana.Location = New System.Drawing.Point(12, 70)
        Me.contenedorVentana.Name = "contenedorVentana"
        Me.contenedorVentana.Size = New System.Drawing.Size(653, 317)
        Me.contenedorVentana.TabIndex = 13
        '
        'lbl_titleInspec
        '
        Me.lbl_titleInspec.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titleInspec.Location = New System.Drawing.Point(12, 9)
        Me.lbl_titleInspec.Name = "lbl_titleInspec"
        Me.lbl_titleInspec.Size = New System.Drawing.Size(262, 29)
        Me.lbl_titleInspec.TabIndex = 14
        Me.lbl_titleInspec.Text = "Inspección a vehículo: VIN"
        '
        'lbl_numeroInspec
        '
        Me.lbl_numeroInspec.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numeroInspec.Location = New System.Drawing.Point(12, 38)
        Me.lbl_numeroInspec.Name = "lbl_numeroInspec"
        Me.lbl_numeroInspec.Size = New System.Drawing.Size(40, 29)
        Me.lbl_numeroInspec.TabIndex = 15
        Me.lbl_numeroInspec.Text = "#N"
        '
        'DatosNuevaInspeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(677, 435)
        Me.Controls.Add(Me.contenedorVentana)
        Me.Controls.Add(Me.lbl_numeroInspec)
        Me.Controls.Add(Me.lbl_titleInspec)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_newDamage)
        Me.Controls.Add(Me.txt_damages)
        Me.Controls.Add(Me.ventana)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DatosNuevaInspeccion"
        Me.contenedorVentana.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_damages As TextBox
    Friend WithEvents btn_newDamage As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents ventana As Panel
    Friend WithEvents lbl_damageText As Label
    Friend WithEvents contenedorVentana As Panel
    Friend WithEvents lbl_titleInspec As Label
    Friend WithEvents lbl_numeroInspec As Label
End Class
