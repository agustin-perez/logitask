Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Config = New System.Windows.Forms.Button()
        Me.titulo = New System.Windows.Forms.Label()
        Me.ventana = New System.Windows.Forms.Panel()
        Me.opciones = New System.Windows.Forms.FlowLayoutPanel()
        Me.cerrarSesion = New System.Windows.Forms.Button()
        Me.lbl_welcome = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Config
        '
        Me.Config.BackColor = System.Drawing.Color.Transparent
        Me.Config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Config.FlatAppearance.BorderSize = 0
        Me.Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Config.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Config.Location = New System.Drawing.Point(11, 12)
        Me.Config.Name = "Config"
        Me.Config.Size = New System.Drawing.Size(36, 35)
        Me.Config.TabIndex = 12
        Me.Config.UseVisualStyleBackColor = False
        '
        'titulo
        '
        Me.titulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.titulo.Font = New System.Drawing.Font("Segoe UI Semilight", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo.Location = New System.Drawing.Point(2, 0)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(776, 67)
        Me.titulo.TabIndex = 0
        Me.titulo.Text = "Menú Principal"
        Me.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ventana
        '
        Me.ventana.AutoScroll = True
        Me.ventana.BackColor = System.Drawing.Color.Transparent
        Me.ventana.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ventana.Location = New System.Drawing.Point(0, 0)
        Me.ventana.Name = "ventana"
        Me.ventana.Size = New System.Drawing.Size(780, 508)
        Me.ventana.TabIndex = 1
        '
        'opciones
        '
        Me.opciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.opciones.Cursor = System.Windows.Forms.Cursors.Default
        Me.opciones.Location = New System.Drawing.Point(12, 67)
        Me.opciones.Name = "opciones"
        Me.opciones.Size = New System.Drawing.Size(756, 384)
        Me.opciones.TabIndex = 0
        '
        'cerrarSesion
        '
        Me.cerrarSesion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cerrarSesion.AutoEllipsis = True
        Me.cerrarSesion.BackColor = System.Drawing.Color.DarkGray
        Me.cerrarSesion.FlatAppearance.BorderSize = 0
        Me.cerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cerrarSesion.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrarSesion.Location = New System.Drawing.Point(644, 466)
        Me.cerrarSesion.Name = "cerrarSesion"
        Me.cerrarSesion.Size = New System.Drawing.Size(124, 30)
        Me.cerrarSesion.TabIndex = 0
        Me.cerrarSesion.Text = "Cerrar sesión"
        Me.cerrarSesion.UseVisualStyleBackColor = False
        '
        'lbl_welcome
        '
        Me.lbl_welcome.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_welcome.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_welcome.Location = New System.Drawing.Point(12, 463)
        Me.lbl_welcome.Name = "lbl_welcome"
        Me.lbl_welcome.Size = New System.Drawing.Size(282, 34)
        Me.lbl_welcome.TabIndex = 13
        Me.lbl_welcome.Text = "Buenos días, Username"
        Me.lbl_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 508)
        Me.Controls.Add(Me.lbl_welcome)
        Me.Controls.Add(Me.cerrarSesion)
        Me.Controls.Add(Me.Config)
        Me.Controls.Add(Me.opciones)
        Me.Controls.Add(Me.titulo)
        Me.Controls.Add(Me.ventana)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuPrincipal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Config As Button
    Friend WithEvents titulo As Label
    Friend WithEvents ventana As Panel
    Friend WithEvents cerrarSesion As Button
    Friend WithEvents opciones As FlowLayoutPanel
    Friend WithEvents lbl_welcome As Label
End Class
