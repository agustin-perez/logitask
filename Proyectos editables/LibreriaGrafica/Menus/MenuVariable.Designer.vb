Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuVariable
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
        Me.atras = New System.Windows.Forms.Button()
        Me.ventana = New System.Windows.Forms.Panel()
        Me.opcionesTop = New System.Windows.Forms.Panel()
        Me.opcionesTitle = New System.Windows.Forms.Label()
        Me.opciones = New System.Windows.Forms.FlowLayoutPanel()
        Me.opcionesTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'atras
        '
        Me.atras.AutoEllipsis = True
        Me.atras.BackColor = System.Drawing.Color.Transparent
        Me.atras.Cursor = System.Windows.Forms.Cursors.Default
        Me.atras.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.atras.FlatAppearance.BorderSize = 0
        Me.atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.atras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atras.ForeColor = System.Drawing.Color.Black
        Me.atras.Location = New System.Drawing.Point(0, 0)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(45, 50)
        Me.atras.TabIndex = 1
        Me.atras.Text = "←"
        Me.atras.UseVisualStyleBackColor = False
        '
        'ventana
        '
        Me.ventana.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ventana.AutoScroll = True
        Me.ventana.AutoSize = True
        Me.ventana.BackColor = System.Drawing.Color.Transparent
        Me.ventana.Location = New System.Drawing.Point(230, -1)
        Me.ventana.Name = "ventana"
        Me.ventana.Size = New System.Drawing.Size(782, 683)
        Me.ventana.TabIndex = 4
        '
        'opcionesTop
        '
        Me.opcionesTop.BackColor = System.Drawing.Color.Gainsboro
        Me.opcionesTop.Controls.Add(Me.atras)
        Me.opcionesTop.Controls.Add(Me.opcionesTitle)
        Me.opcionesTop.Location = New System.Drawing.Point(0, 0)
        Me.opcionesTop.Name = "opcionesTop"
        Me.opcionesTop.Size = New System.Drawing.Size(230, 50)
        Me.opcionesTop.TabIndex = 5
        '
        'opcionesTitle
        '
        Me.opcionesTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.opcionesTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opcionesTitle.ForeColor = System.Drawing.Color.White
        Me.opcionesTitle.Location = New System.Drawing.Point(50, 0)
        Me.opcionesTitle.Name = "opcionesTitle"
        Me.opcionesTitle.Size = New System.Drawing.Size(180, 50)
        Me.opcionesTitle.TabIndex = 0
        Me.opcionesTitle.Text = "Seleccione una opción"
        Me.opcionesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'opciones
        '
        Me.opciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.opciones.AutoScroll = True
        Me.opciones.BackColor = System.Drawing.Color.Gainsboro
        Me.opciones.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.opciones.Location = New System.Drawing.Point(0, 50)
        Me.opciones.Margin = New System.Windows.Forms.Padding(0)
        Me.opciones.Name = "opciones"
        Me.opciones.Size = New System.Drawing.Size(230, 632)
        Me.opciones.TabIndex = 2
        '
        'MenuVariable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1011, 680)
        Me.Controls.Add(Me.opciones)
        Me.Controls.Add(Me.opcionesTop)
        Me.Controls.Add(Me.ventana)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "MenuVariable"
        Me.Text = "Ejemplo "
        Me.opcionesTop.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ventana As Panel
    Friend WithEvents opcionesTop As Panel
    Friend WithEvents opcionesTitle As Label
    Friend WithEvents atras As Button
    Friend WithEvents opciones As FlowLayoutPanel
End Class
