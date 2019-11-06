Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class configRed
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
		Me.lblruta = New System.Windows.Forms.Label()
		Me.ruta = New System.Windows.Forms.Label()
		Me.cambiar = New System.Windows.Forms.Button()
		Me.lbluser = New System.Windows.Forms.Label()
		Me.lblpass = New System.Windows.Forms.Label()
		Me.lbl_title = New System.Windows.Forms.Label()
		Me.lblbbdd = New System.Windows.Forms.Label()
		Me.usuario = New System.Windows.Forms.TextBox()
		Me.pass = New System.Windows.Forms.TextBox()
		Me.lblinfo = New System.Windows.Forms.Label()
		Me.conectar = New System.Windows.Forms.Button()
		Me.lbl_connected = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'lblruta
		'
		Me.lblruta.AutoSize = True
		Me.lblruta.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblruta.Location = New System.Drawing.Point(36, 41)
		Me.lblruta.Name = "lblruta"
		Me.lblruta.Size = New System.Drawing.Size(45, 21)
		Me.lblruta.TabIndex = 0
		Me.lblruta.Text = "Ruta:"
		'
		'ruta
		'
		Me.ruta.AutoSize = True
		Me.ruta.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ruta.Location = New System.Drawing.Point(87, 41)
		Me.ruta.Name = "ruta"
		Me.ruta.Size = New System.Drawing.Size(16, 21)
		Me.ruta.TabIndex = 1
		Me.ruta.Text = "-"
		'
		'cambiar
		'
		Me.cambiar.AutoEllipsis = True
		Me.cambiar.BackColor = System.Drawing.Color.DarkGray
		Me.cambiar.FlatAppearance.BorderSize = 0
		Me.cambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cambiar.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cambiar.Location = New System.Drawing.Point(40, 72)
		Me.cambiar.Name = "cambiar"
		Me.cambiar.Size = New System.Drawing.Size(124, 30)
		Me.cambiar.TabIndex = 2
		Me.cambiar.Text = "Cambiar"
		Me.cambiar.UseVisualStyleBackColor = False
		'
		'lbluser
		'
		Me.lbluser.AutoSize = True
		Me.lbluser.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbluser.Location = New System.Drawing.Point(36, 145)
		Me.lbluser.Name = "lbluser"
		Me.lbluser.Size = New System.Drawing.Size(67, 21)
		Me.lbluser.TabIndex = 3
		Me.lbluser.Text = "Usuario:"
		'
		'lblpass
		'
		Me.lblpass.AutoSize = True
		Me.lblpass.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblpass.Location = New System.Drawing.Point(36, 182)
		Me.lblpass.Name = "lblpass"
		Me.lblpass.Size = New System.Drawing.Size(92, 21)
		Me.lblpass.TabIndex = 4
		Me.lblpass.Text = "Contraseña:"
		'
		'lbl_title
		'
		Me.lbl_title.AutoSize = True
		Me.lbl_title.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_title.Location = New System.Drawing.Point(9, 9)
		Me.lbl_title.Name = "lbl_title"
		Me.lbl_title.Size = New System.Drawing.Size(100, 21)
		Me.lbl_title.TabIndex = 5
		Me.lbl_title.Text = "Archivo DSN:"
		'
		'lblbbdd
		'
		Me.lblbbdd.AutoSize = True
		Me.lblbbdd.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblbbdd.Location = New System.Drawing.Point(9, 113)
		Me.lblbbdd.Name = "lblbbdd"
		Me.lblbbdd.Size = New System.Drawing.Size(111, 21)
		Me.lblbbdd.TabIndex = 6
		Me.lblbbdd.Text = "Base de Datos:"
		'
		'usuario
		'
		Me.usuario.BackColor = System.Drawing.Color.White
		Me.usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.usuario.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.usuario.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
		Me.usuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.usuario.Location = New System.Drawing.Point(151, 146)
		Me.usuario.Name = "usuario"
		Me.usuario.Size = New System.Drawing.Size(213, 25)
		Me.usuario.TabIndex = 10
		'
		'pass
		'
		Me.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pass.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pass.Location = New System.Drawing.Point(151, 183)
		Me.pass.Name = "pass"
		Me.pass.Size = New System.Drawing.Size(213, 25)
		Me.pass.TabIndex = 11
		Me.pass.UseSystemPasswordChar = True
		'
		'lblinfo
		'
		Me.lblinfo.AutoSize = True
		Me.lblinfo.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblinfo.Location = New System.Drawing.Point(10, 218)
		Me.lblinfo.Name = "lblinfo"
		Me.lblinfo.Size = New System.Drawing.Size(639, 13)
		Me.lblinfo.TabIndex = 12
		Me.lblinfo.Text = "Sin estos datos no se podrá conectar con el servidor y no podrá acceder a los dat" &
	"os de la empresa. Si tiene dudas consulte a un técnico."
		'
		'conectar
		'
		Me.conectar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.conectar.AutoEllipsis = True
		Me.conectar.BackColor = System.Drawing.Color.DarkGray
		Me.conectar.Cursor = System.Windows.Forms.Cursors.Arrow
		Me.conectar.FlatAppearance.BorderSize = 0
		Me.conectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.conectar.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.conectar.Location = New System.Drawing.Point(652, 546)
		Me.conectar.Name = "conectar"
		Me.conectar.Size = New System.Drawing.Size(124, 30)
		Me.conectar.TabIndex = 13
		Me.conectar.Text = "Conectar"
		Me.conectar.UseVisualStyleBackColor = False
		'
		'lbl_connected
		'
		Me.lbl_connected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.lbl_connected.BackColor = System.Drawing.Color.Transparent
		Me.lbl_connected.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_connected.ForeColor = System.Drawing.Color.ForestGreen
		Me.lbl_connected.Location = New System.Drawing.Point(12, 555)
		Me.lbl_connected.Name = "lbl_connected"
		Me.lbl_connected.Size = New System.Drawing.Size(100, 23)
		Me.lbl_connected.TabIndex = 14
		Me.lbl_connected.Text = "Conectado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		'
		'configRed
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(788, 588)
		Me.Controls.Add(Me.lbl_connected)
		Me.Controls.Add(Me.conectar)
		Me.Controls.Add(Me.lblinfo)
		Me.Controls.Add(Me.pass)
		Me.Controls.Add(Me.usuario)
		Me.Controls.Add(Me.lblbbdd)
		Me.Controls.Add(Me.lbl_title)
		Me.Controls.Add(Me.lblpass)
		Me.Controls.Add(Me.lbluser)
		Me.Controls.Add(Me.cambiar)
		Me.Controls.Add(Me.ruta)
		Me.Controls.Add(Me.lblruta)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "configRed"
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblruta As Label
    Friend WithEvents ruta As Label
    Friend WithEvents cambiar As Button
    Friend WithEvents lbluser As Label
    Friend WithEvents lblpass As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents lblbbdd As Label
    Friend WithEvents usuario As TextBox
    Friend WithEvents pass As TextBox
    Friend WithEvents lblinfo As Label
    Friend WithEvents conectar As Button
    Friend WithEvents lbl_connected As Label
End Class
