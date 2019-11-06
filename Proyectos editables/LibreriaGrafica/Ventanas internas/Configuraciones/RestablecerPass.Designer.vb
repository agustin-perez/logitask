<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestablecerPass
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
		Me.lbl_title = New System.Windows.Forms.Label()
		Me.lbl_subtitle = New System.Windows.Forms.Label()
		Me.usernameTxtBox = New System.Windows.Forms.TextBox()
		Me.txt_userUnderscore = New System.Windows.Forms.Label()
		Me.lbl_username = New System.Windows.Forms.Label()
		Me.btn_solicitar = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'lbl_title
		'
		Me.lbl_title.AutoEllipsis = True
		Me.lbl_title.Dock = System.Windows.Forms.DockStyle.Top
		Me.lbl_title.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_title.ForeColor = System.Drawing.Color.Black
		Me.lbl_title.Location = New System.Drawing.Point(0, 0)
		Me.lbl_title.Name = "lbl_title"
		Me.lbl_title.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
		Me.lbl_title.Size = New System.Drawing.Size(800, 48)
		Me.lbl_title.TabIndex = 11
		Me.lbl_title.Text = "Solicitar cambio de contraseña"
		Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lbl_subtitle
		'
		Me.lbl_subtitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lbl_subtitle.AutoEllipsis = True
		Me.lbl_subtitle.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
		Me.lbl_subtitle.ForeColor = System.Drawing.Color.Black
		Me.lbl_subtitle.Location = New System.Drawing.Point(1, 55)
		Me.lbl_subtitle.Name = "lbl_subtitle"
		Me.lbl_subtitle.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
		Me.lbl_subtitle.Size = New System.Drawing.Size(787, 38)
		Me.lbl_subtitle.TabIndex = 16
		Me.lbl_subtitle.Text = "Si usted se ha olvidado de su contraseña esta ventana le mandará una solicitud al" &
	" administrador"
		Me.lbl_subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'usernameTxtBox
		'
		Me.usernameTxtBox.AllowDrop = True
		Me.usernameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.usernameTxtBox.BackColor = System.Drawing.Color.White
		Me.usernameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.usernameTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
		Me.usernameTxtBox.Location = New System.Drawing.Point(146, 178)
		Me.usernameTxtBox.MaxLength = 500
		Me.usernameTxtBox.Name = "usernameTxtBox"
		Me.usernameTxtBox.Size = New System.Drawing.Size(630, 17)
		Me.usernameTxtBox.TabIndex = 29
		Me.usernameTxtBox.WordWrap = False
		'
		'txt_userUnderscore
		'
		Me.txt_userUnderscore.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.txt_userUnderscore.Cursor = System.Windows.Forms.Cursors.Arrow
		Me.txt_userUnderscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
		Me.txt_userUnderscore.ForeColor = System.Drawing.Color.Black
		Me.txt_userUnderscore.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.txt_userUnderscore.Location = New System.Drawing.Point(143, 184)
		Me.txt_userUnderscore.Name = "txt_userUnderscore"
		Me.txt_userUnderscore.Size = New System.Drawing.Size(644, 20)
		Me.txt_userUnderscore.TabIndex = 30
		Me.txt_userUnderscore.Text = "_________________________________________________________________________________" &
	"______________________"
		'
		'lbl_username
		'
		Me.lbl_username.AutoSize = True
		Me.lbl_username.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
		Me.lbl_username.Location = New System.Drawing.Point(12, 184)
		Me.lbl_username.Name = "lbl_username"
		Me.lbl_username.Size = New System.Drawing.Size(124, 19)
		Me.lbl_username.TabIndex = 33
		Me.lbl_username.Text = "Nombre de usuario"
		'
		'btn_solicitar
		'
		Me.btn_solicitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btn_solicitar.AutoEllipsis = True
		Me.btn_solicitar.BackColor = System.Drawing.Color.DarkGray
		Me.btn_solicitar.Cursor = System.Windows.Forms.Cursors.Arrow
		Me.btn_solicitar.FlatAppearance.BorderSize = 0
		Me.btn_solicitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
		Me.btn_solicitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia
		Me.btn_solicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btn_solicitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
		Me.btn_solicitar.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.btn_solicitar.Location = New System.Drawing.Point(318, 334)
		Me.btn_solicitar.Name = "btn_solicitar"
		Me.btn_solicitar.Size = New System.Drawing.Size(136, 40)
		Me.btn_solicitar.TabIndex = 34
		Me.btn_solicitar.Text = "Solicitar Cambio"
		Me.btn_solicitar.UseVisualStyleBackColor = False
		'
		'RestablecerPass
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.btn_solicitar)
		Me.Controls.Add(Me.lbl_username)
		Me.Controls.Add(Me.usernameTxtBox)
		Me.Controls.Add(Me.txt_userUnderscore)
		Me.Controls.Add(Me.lbl_subtitle)
		Me.Controls.Add(Me.lbl_title)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "RestablecerPass"
		Me.Text = "RestablecerPass"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lbl_title As Windows.Forms.Label
	Friend WithEvents lbl_subtitle As Windows.Forms.Label
	Friend WithEvents usernameTxtBox As Windows.Forms.TextBox
	Friend WithEvents txt_userUnderscore As Windows.Forms.Label
	Friend WithEvents lbl_username As Windows.Forms.Label
	Friend WithEvents btn_solicitar As Windows.Forms.Button
End Class
