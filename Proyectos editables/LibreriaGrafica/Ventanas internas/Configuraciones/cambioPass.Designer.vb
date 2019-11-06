<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cambioPass
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
		Me.oldPassTxtBox = New System.Windows.Forms.TextBox()
		Me.txt_userUnderscore = New System.Windows.Forms.Label()
		Me.newPassTxtBox = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btn_cambiar = New System.Windows.Forms.Button()
		Me.lbl_oldPass = New System.Windows.Forms.Label()
		Me.lbl_newPass = New System.Windows.Forms.Label()
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
		Me.lbl_title.TabIndex = 10
		Me.lbl_title.Text = "Cambio de contraseña"
		Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'oldPassTxtBox
		'
		Me.oldPassTxtBox.AllowDrop = True
		Me.oldPassTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.oldPassTxtBox.BackColor = System.Drawing.Color.White
		Me.oldPassTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.oldPassTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
		Me.oldPassTxtBox.Location = New System.Drawing.Point(147, 120)
		Me.oldPassTxtBox.MaxLength = 500
		Me.oldPassTxtBox.Name = "oldPassTxtBox"
		Me.oldPassTxtBox.Size = New System.Drawing.Size(630, 17)
		Me.oldPassTxtBox.TabIndex = 27
		Me.oldPassTxtBox.WordWrap = False
		'
		'txt_userUnderscore
		'
		Me.txt_userUnderscore.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.txt_userUnderscore.Cursor = System.Windows.Forms.Cursors.Arrow
		Me.txt_userUnderscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
		Me.txt_userUnderscore.ForeColor = System.Drawing.Color.Black
		Me.txt_userUnderscore.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.txt_userUnderscore.Location = New System.Drawing.Point(144, 126)
		Me.txt_userUnderscore.Name = "txt_userUnderscore"
		Me.txt_userUnderscore.Size = New System.Drawing.Size(644, 20)
		Me.txt_userUnderscore.TabIndex = 28
		Me.txt_userUnderscore.Text = "_________________________________________________________________________________" &
	"______________________"
		'
		'newPassTxtBox
		'
		Me.newPassTxtBox.AllowDrop = True
		Me.newPassTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.newPassTxtBox.BackColor = System.Drawing.Color.White
		Me.newPassTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.newPassTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
		Me.newPassTxtBox.Location = New System.Drawing.Point(136, 217)
		Me.newPassTxtBox.MaxLength = 500
		Me.newPassTxtBox.Name = "newPassTxtBox"
		Me.newPassTxtBox.Size = New System.Drawing.Size(630, 17)
		Me.newPassTxtBox.TabIndex = 29
		Me.newPassTxtBox.WordWrap = False
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Arrow
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
		Me.Label1.ForeColor = System.Drawing.Color.Black
		Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.Label1.Location = New System.Drawing.Point(133, 223)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(644, 20)
		Me.Label1.TabIndex = 30
		Me.Label1.Text = "_________________________________________________________________________________" &
	"______________________"
		'
		'btn_cambiar
		'
		Me.btn_cambiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btn_cambiar.AutoEllipsis = True
		Me.btn_cambiar.BackColor = System.Drawing.Color.DarkGray
		Me.btn_cambiar.Cursor = System.Windows.Forms.Cursors.Arrow
		Me.btn_cambiar.FlatAppearance.BorderSize = 0
		Me.btn_cambiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
		Me.btn_cambiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia
		Me.btn_cambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btn_cambiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
		Me.btn_cambiar.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.btn_cambiar.Location = New System.Drawing.Point(339, 376)
		Me.btn_cambiar.Name = "btn_cambiar"
		Me.btn_cambiar.Size = New System.Drawing.Size(136, 40)
		Me.btn_cambiar.TabIndex = 31
		Me.btn_cambiar.Text = "Cambiar"
		Me.btn_cambiar.UseVisualStyleBackColor = False
		'
		'lbl_oldPass
		'
		Me.lbl_oldPass.AutoSize = True
		Me.lbl_oldPass.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
		Me.lbl_oldPass.Location = New System.Drawing.Point(12, 126)
		Me.lbl_oldPass.Name = "lbl_oldPass"
		Me.lbl_oldPass.Size = New System.Drawing.Size(115, 19)
		Me.lbl_oldPass.TabIndex = 32
		Me.lbl_oldPass.Text = "Contraseña Actual"
		'
		'lbl_newPass
		'
		Me.lbl_newPass.AutoSize = True
		Me.lbl_newPass.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
		Me.lbl_newPass.Location = New System.Drawing.Point(12, 222)
		Me.lbl_newPass.Name = "lbl_newPass"
		Me.lbl_newPass.Size = New System.Drawing.Size(116, 19)
		Me.lbl_newPass.TabIndex = 33
		Me.lbl_newPass.Text = "Contraseña Nueva"
		'
		'cambioPass
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.lbl_newPass)
		Me.Controls.Add(Me.lbl_oldPass)
		Me.Controls.Add(Me.btn_cambiar)
		Me.Controls.Add(Me.newPassTxtBox)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.oldPassTxtBox)
		Me.Controls.Add(Me.txt_userUnderscore)
		Me.Controls.Add(Me.lbl_title)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "cambioPass"
		Me.Text = "cambioPass"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lbl_title As Windows.Forms.Label
	Friend WithEvents oldPassTxtBox As Windows.Forms.TextBox
	Friend WithEvents txt_userUnderscore As Windows.Forms.Label
	Friend WithEvents newPassTxtBox As Windows.Forms.TextBox
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents btn_cambiar As Windows.Forms.Button
	Friend WithEvents lbl_oldPass As Windows.Forms.Label
	Friend WithEvents lbl_newPass As Windows.Forms.Label
End Class
