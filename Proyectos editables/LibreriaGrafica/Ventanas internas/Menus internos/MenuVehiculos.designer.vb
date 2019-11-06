Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuVehiculos
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
        Me.VentanaLista = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.buscarQR = New System.Windows.Forms.Button()
        Me.buscarVIN = New System.Windows.Forms.Button()
        Me.vin = New System.Windows.Forms.TextBox()
        Me.btn_reload = New System.Windows.Forms.Button()
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'VentanaLista
        '
        Me.VentanaLista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VentanaLista.AutoScroll = True
        Me.VentanaLista.Location = New System.Drawing.Point(0, 48)
        Me.VentanaLista.Name = "VentanaLista"
        Me.VentanaLista.Size = New System.Drawing.Size(801, 524)
        Me.VentanaLista.TabIndex = 3
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
        Me.lbl_title.Size = New System.Drawing.Size(328, 50)
        Me.lbl_title.TabIndex = 4
        Me.lbl_title.Text = "Vehículos"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btn_add.Location = New System.Drawing.Point(748, 578)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(40, 40)
        Me.btn_add.TabIndex = 5
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'buscarQR
        '
        Me.buscarQR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buscarQR.BackColor = System.Drawing.Color.DarkGray
        Me.buscarQR.FlatAppearance.BorderSize = 0
        Me.buscarQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buscarQR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscarQR.Location = New System.Drawing.Point(534, 12)
        Me.buscarQR.Name = "buscarQR"
        Me.buscarQR.Size = New System.Drawing.Size(124, 30)
        Me.buscarQR.TabIndex = 8
        Me.buscarQR.Text = "Buscar por QR"
        Me.buscarQR.UseVisualStyleBackColor = False
        '
        'buscarVIN
        '
        Me.buscarVIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buscarVIN.BackColor = System.Drawing.Color.DarkGray
        Me.buscarVIN.FlatAppearance.BorderSize = 0
        Me.buscarVIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buscarVIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscarVIN.Location = New System.Drawing.Point(664, 12)
        Me.buscarVIN.Name = "buscarVIN"
        Me.buscarVIN.Size = New System.Drawing.Size(124, 30)
        Me.buscarVIN.TabIndex = 7
        Me.buscarVIN.Text = "Buscar por VIN"
        Me.buscarVIN.UseVisualStyleBackColor = False
        '
        'vin
        '
        Me.vin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vin.Location = New System.Drawing.Point(333, 16)
        Me.vin.MaxLength = 17
        Me.vin.Name = "vin"
        Me.vin.Size = New System.Drawing.Size(195, 22)
        Me.vin.TabIndex = 6
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
        Me.btn_reload.Location = New System.Drawing.Point(702, 578)
        Me.btn_reload.Name = "btn_reload"
        Me.btn_reload.Size = New System.Drawing.Size(40, 40)
        Me.btn_reload.TabIndex = 9
        Me.btn_reload.UseVisualStyleBackColor = False
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
        Me.errorLabel.Location = New System.Drawing.Point(12, 577)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(684, 38)
        Me.errorLabel.TabIndex = 16
        Me.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 630)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.btn_reload)
        Me.Controls.Add(Me.buscarQR)
        Me.Controls.Add(Me.buscarVIN)
        Me.Controls.Add(Me.vin)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.VentanaLista)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuVehiculos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VentanaLista As FlowLayoutPanel
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_add As Button
    Friend WithEvents buscarQR As Button
    Friend WithEvents buscarVIN As Button
    Friend WithEvents vin As TextBox
    Friend WithEvents btn_reload As Button
    Friend WithEvents errorLabel As Label
End Class
