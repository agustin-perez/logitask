Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuLotes
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
        Me.ventanaLotes = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.ventana = New System.Windows.Forms.Panel()
        Me.btn_reload = New System.Windows.Forms.Button()
        Me.btn_loteListo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ventanaLotes
        '
        Me.ventanaLotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ventanaLotes.AutoScroll = True
        Me.ventanaLotes.Location = New System.Drawing.Point(0, 48)
        Me.ventanaLotes.Name = "ventanaLotes"
        Me.ventanaLotes.Size = New System.Drawing.Size(801, 344)
        Me.ventanaLotes.TabIndex = 7
        '
        'lbl_title
        '
        Me.lbl_title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_title.AutoEllipsis = True
        Me.lbl_title.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Black
        Me.lbl_title.Location = New System.Drawing.Point(-1, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lbl_title.Size = New System.Drawing.Size(558, 50)
        Me.lbl_title.TabIndex = 8
        Me.lbl_title.Text = "Lotes"
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
        Me.btn_add.Location = New System.Drawing.Point(748, 398)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(40, 40)
        Me.btn_add.TabIndex = 9
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'ventana
        '
        Me.ventana.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ventana.Location = New System.Drawing.Point(0, 48)
        Me.ventana.Name = "ventana"
        Me.ventana.Size = New System.Drawing.Size(801, 402)
        Me.ventana.TabIndex = 10
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
        Me.btn_reload.Location = New System.Drawing.Point(656, 398)
        Me.btn_reload.Name = "btn_reload"
        Me.btn_reload.Size = New System.Drawing.Size(40, 40)
        Me.btn_reload.TabIndex = 10
        Me.btn_reload.UseVisualStyleBackColor = False
        '
        'btn_loteListo
        '
        Me.btn_loteListo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_loteListo.AutoSize = True
        Me.btn_loteListo.BackColor = System.Drawing.Color.Transparent
        Me.btn_loteListo.BackgroundImage = Global.LibreriaGrafica.My.Resources.Images.checkIcon
        Me.btn_loteListo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_loteListo.FlatAppearance.BorderSize = 0
        Me.btn_loteListo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_loteListo.Location = New System.Drawing.Point(702, 398)
        Me.btn_loteListo.Name = "btn_loteListo"
        Me.btn_loteListo.Size = New System.Drawing.Size(40, 40)
        Me.btn_loteListo.TabIndex = 11
        Me.btn_loteListo.UseVisualStyleBackColor = False
        '
        'MenuLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_loteListo)
        Me.Controls.Add(Me.btn_reload)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.ventanaLotes)
        Me.Controls.Add(Me.ventana)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuLotes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ventanaLotes As FlowLayoutPanel
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_add As Button
    Friend WithEvents ventana As Panel
    Friend WithEvents btn_reload As Button
    Friend WithEvents btn_loteListo As Button
End Class
