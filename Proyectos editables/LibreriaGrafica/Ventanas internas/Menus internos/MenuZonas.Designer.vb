<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuZonas
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.ventanaZonas = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_change = New System.Windows.Forms.Button()
        Me.btn_reload = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.ventana = New System.Windows.Forms.Panel()
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_title.AutoEllipsis = True
        Me.lbl_title.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Black
        Me.lbl_title.Location = New System.Drawing.Point(0, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lbl_title.Size = New System.Drawing.Size(802, 50)
        Me.lbl_title.TabIndex = 5
        Me.lbl_title.Text = "Zonas"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ventanaZonas
        '
        Me.ventanaZonas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ventanaZonas.AutoScroll = True
        Me.ventanaZonas.Location = New System.Drawing.Point(0, 48)
        Me.ventanaZonas.Name = "ventanaZonas"
        Me.ventanaZonas.Size = New System.Drawing.Size(802, 344)
        Me.ventanaZonas.TabIndex = 9
        '
        'btn_change
        '
        Me.btn_change.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_change.AutoSize = True
        Me.btn_change.BackColor = System.Drawing.Color.Transparent
        Me.btn_change.BackgroundImage = Global.LibreriaGrafica.My.Resources.Images.changeIcon
        Me.btn_change.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_change.FlatAppearance.BorderSize = 0
        Me.btn_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_change.Location = New System.Drawing.Point(748, 398)
        Me.btn_change.Name = "btn_change"
        Me.btn_change.Size = New System.Drawing.Size(40, 40)
        Me.btn_change.TabIndex = 10
        Me.btn_change.UseVisualStyleBackColor = False
        '
        'btn_reload
        '
        Me.btn_reload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reload.AutoSize = True
        Me.btn_reload.BackColor = System.Drawing.Color.Transparent
        Me.btn_reload.BackgroundImage = Global.LibreriaGrafica.My.Resources.Images.reloadIcon
        Me.btn_reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_reload.FlatAppearance.BorderSize = 0
        Me.btn_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reload.Location = New System.Drawing.Point(702, 398)
        Me.btn_reload.Name = "btn_reload"
        Me.btn_reload.Size = New System.Drawing.Size(40, 40)
        Me.btn_reload.TabIndex = 11
        Me.btn_reload.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_add.AutoSize = True
        Me.btn_add.BackColor = System.Drawing.Color.Transparent
        Me.btn_add.BackgroundImage = Global.LibreriaGrafica.My.Resources.Images.agregarIcon
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Location = New System.Drawing.Point(656, 398)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(40, 40)
        Me.btn_add.TabIndex = 12
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'ventana
        '
        Me.ventana.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ventana.Location = New System.Drawing.Point(0, 0)
        Me.ventana.Name = "ventana"
        Me.ventana.Size = New System.Drawing.Size(800, 450)
        Me.ventana.TabIndex = 13
        '
        'errorLabel
        '
        Me.errorLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.errorLabel.AutoEllipsis = True
        Me.errorLabel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.errorLabel.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorLabel.ForeColor = System.Drawing.Color.Red
        Me.errorLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.errorLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.errorLabel.Location = New System.Drawing.Point(12, 403)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(638, 38)
        Me.errorLabel.TabIndex = 17
        Me.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuZonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_reload)
        Me.Controls.Add(Me.btn_change)
        Me.Controls.Add(Me.ventanaZonas)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.ventana)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuZonas"
        Me.Text = "ListadoZonas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Windows.Forms.Label
    Friend WithEvents ventanaZonas As Windows.Forms.FlowLayoutPanel
    Friend WithEvents btn_change As Windows.Forms.Button
    Friend WithEvents btn_reload As Windows.Forms.Button
    Friend WithEvents btn_add As Windows.Forms.Button
    Friend WithEvents ventana As Windows.Forms.Panel
    Friend WithEvents errorLabel As Windows.Forms.Label
End Class
