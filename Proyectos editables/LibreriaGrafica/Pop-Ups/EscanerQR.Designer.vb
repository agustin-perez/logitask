<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EscanerQR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EscanerQR))
        Me.btn_scan = New System.Windows.Forms.Button()
        Me.pantallaCamara = New WebCAM.WebCam()
        Me.SuspendLayout()
        '
        'btn_scan
        '
        Me.btn_scan.BackColor = System.Drawing.Color.DarkGray
        Me.btn_scan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_scan.FlatAppearance.BorderSize = 0
        Me.btn_scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_scan.Location = New System.Drawing.Point(0, 291)
        Me.btn_scan.Name = "btn_scan"
        Me.btn_scan.Size = New System.Drawing.Size(394, 36)
        Me.btn_scan.TabIndex = 1
        Me.btn_scan.Text = "Escanear"
        Me.btn_scan.UseVisualStyleBackColor = False
        '
        'pantallaCamara
        '
        Me.pantallaCamara.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pantallaCamara.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pantallaCamara.Imagen = Nothing
        Me.pantallaCamara.Location = New System.Drawing.Point(-3, -3)
        Me.pantallaCamara.MilisegundosCaptura = 2
        Me.pantallaCamara.MinimumSize = New System.Drawing.Size(400, 300)
        Me.pantallaCamara.Name = "pantallaCamara"
        Me.pantallaCamara.Size = New System.Drawing.Size(400, 300)
        Me.pantallaCamara.TabIndex = 2
        Me.pantallaCamara.AllowDrop = False
        Me.pantallaCamara.Enabled = False
        '
        'EscanerQR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 327)
        Me.Controls.Add(Me.btn_scan)
        Me.Controls.Add(Me.pantallaCamara)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(410, 366)
        Me.MinimumSize = New System.Drawing.Size(410, 366)
        Me.Name = "EscanerQR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EscanerQR"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_scan As Windows.Forms.Button
    Friend WithEvents pantallaCamara As WebCAM.WebCam
End Class
