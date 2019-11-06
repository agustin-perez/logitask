<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mapa
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
        Me.ventanaMapa = New GMap.NET.WindowsForms.GMapControl()
        Me.SuspendLayout()
        '
        'ventanaMapa
        '
        Me.ventanaMapa.Bearing = 0!
        Me.ventanaMapa.CanDragMap = True
        Me.ventanaMapa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ventanaMapa.EmptyTileColor = System.Drawing.Color.Navy
        Me.ventanaMapa.GrayScaleMode = False
        Me.ventanaMapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.ventanaMapa.LevelsKeepInMemmory = 5
        Me.ventanaMapa.Location = New System.Drawing.Point(0, 0)
        Me.ventanaMapa.MarkersEnabled = True
        Me.ventanaMapa.MaxZoom = 18
        Me.ventanaMapa.MinZoom = 4
        Me.ventanaMapa.MouseWheelZoomEnabled = True
        Me.ventanaMapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.ventanaMapa.Name = "ventanaMapa"
        Me.ventanaMapa.NegativeMode = False
        Me.ventanaMapa.PolygonsEnabled = True
        Me.ventanaMapa.RetryLoadTile = 0
        Me.ventanaMapa.RoutesEnabled = True
        Me.ventanaMapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.ventanaMapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ventanaMapa.ShowTileGridLines = False
        Me.ventanaMapa.Size = New System.Drawing.Size(800, 450)
        Me.ventanaMapa.TabIndex = 0
        Me.ventanaMapa.Zoom = 0R
        '
        'Mapa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ventanaMapa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Mapa"
        Me.Text = "Mapa"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ventanaMapa As GMap.NET.WindowsForms.GMapControl
End Class
