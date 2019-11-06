<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginVariable
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
        Me.components = New System.ComponentModel.Container()
        Me.restablecer = New System.Windows.Forms.LinkLabel()
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.Config = New System.Windows.Forms.Button()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.user = New System.Windows.Forms.TextBox()
        Me.ventana = New System.Windows.Forms.Panel()
        Me.Ingresar = New System.Windows.Forms.Button()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.ContenedorControles = New System.Windows.Forms.Panel()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.txt_userUnderscore = New System.Windows.Forms.Label()
        Me.txt_passUnderscore = New System.Windows.Forms.Label()
        Me.clk_connection = New System.Windows.Forms.Timer(Me.components)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContenedorControles.SuspendLayout()
        Me.SuspendLayout()
        '
        'restablecer
        '
        Me.restablecer.ActiveLinkColor = System.Drawing.SystemColors.MenuHighlight
        Me.restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.restablecer.AutoEllipsis = True
        Me.restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.restablecer.DisabledLinkColor = System.Drawing.Color.Blue
        Me.restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.restablecer.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.restablecer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.restablecer.LinkColor = System.Drawing.SystemColors.MenuHighlight
        Me.restablecer.Location = New System.Drawing.Point(12, 400)
        Me.restablecer.Name = "restablecer"
        Me.restablecer.Size = New System.Drawing.Size(244, 41)
        Me.restablecer.TabIndex = 4
        Me.restablecer.TabStop = True
        Me.restablecer.Text = "----------"
        Me.restablecer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.restablecer.VisitedLinkColor = System.Drawing.SystemColors.MenuHighlight
        '
        'errorLabel
        '
        Me.errorLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.errorLabel.AutoEllipsis = True
        Me.errorLabel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.errorLabel.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorLabel.ForeColor = System.Drawing.Color.Red
        Me.errorLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.errorLabel.Location = New System.Drawing.Point(12, 362)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(414, 41)
        Me.errorLabel.TabIndex = 15
        Me.errorLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Config
        '
        Me.Config.BackColor = System.Drawing.Color.Transparent
        Me.Config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Config.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Config.FlatAppearance.BorderSize = 0
        Me.Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Config.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Config.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Config.Location = New System.Drawing.Point(15, 12)
        Me.Config.Name = "Config"
        Me.Config.Size = New System.Drawing.Size(36, 35)
        Me.Config.TabIndex = 0
        Me.Config.UseVisualStyleBackColor = False
        '
        'pass
        '
        Me.pass.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pass.BackColor = System.Drawing.Color.White
        Me.pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.pass.Location = New System.Drawing.Point(3, 336)
        Me.pass.MaxLength = 150
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(699, 17)
        Me.pass.TabIndex = 2
        Me.pass.UseSystemPasswordChar = True
        '
        'user
        '
        Me.user.AllowDrop = True
        Me.user.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.user.BackColor = System.Drawing.Color.White
        Me.user.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.user.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.user.Location = New System.Drawing.Point(3, 288)
        Me.user.MaxLength = 500
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(699, 17)
        Me.user.TabIndex = 1
        Me.user.WordWrap = False
        '
        'ventana
        '
        Me.ventana.BackColor = System.Drawing.Color.Transparent
        Me.ventana.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ventana.Location = New System.Drawing.Point(0, 0)
        Me.ventana.Name = "ventana"
        Me.ventana.Size = New System.Drawing.Size(714, 450)
        Me.ventana.TabIndex = 23
        '
        'Ingresar
        '
        Me.Ingresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ingresar.AutoEllipsis = True
        Me.Ingresar.BackColor = System.Drawing.Color.DarkGray
        Me.Ingresar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Ingresar.FlatAppearance.BorderSize = 0
        Me.Ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ingresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Ingresar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Ingresar.Location = New System.Drawing.Point(578, 408)
        Me.Ingresar.Name = "Ingresar"
        Me.Ingresar.Size = New System.Drawing.Size(124, 30)
        Me.Ingresar.TabIndex = 3
        Me.Ingresar.Text = "------------"
        Me.Ingresar.UseVisualStyleBackColor = False
        '
        'logo
        '
        Me.logo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.logo.Location = New System.Drawing.Point(15, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(687, 259)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 24
        Me.logo.TabStop = False
        '
        'ContenedorControles
        '
        Me.ContenedorControles.BackColor = System.Drawing.Color.Transparent
        Me.ContenedorControles.Controls.Add(Me.user)
        Me.ContenedorControles.Controls.Add(Me.pass)
        Me.ContenedorControles.Controls.Add(Me.lbl_status)
        Me.ContenedorControles.Controls.Add(Me.txt_userUnderscore)
        Me.ContenedorControles.Controls.Add(Me.txt_passUnderscore)
        Me.ContenedorControles.Controls.Add(Me.Config)
        Me.ContenedorControles.Controls.Add(Me.Ingresar)
        Me.ContenedorControles.Controls.Add(Me.restablecer)
        Me.ContenedorControles.Controls.Add(Me.logo)
        Me.ContenedorControles.Controls.Add(Me.errorLabel)
        Me.ContenedorControles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContenedorControles.Location = New System.Drawing.Point(0, 0)
        Me.ContenedorControles.Name = "ContenedorControles"
        Me.ContenedorControles.Size = New System.Drawing.Size(714, 450)
        Me.ContenedorControles.TabIndex = 25
        '
        'lbl_status
        '
        Me.lbl_status.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_status.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_status.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.ForeColor = System.Drawing.Color.Black
        Me.lbl_status.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_status.Location = New System.Drawing.Point(270, 408)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(288, 27)
        Me.lbl_status.TabIndex = 27
        Me.lbl_status.Text = "------"
        Me.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_userUnderscore
        '
        Me.txt_userUnderscore.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_userUnderscore.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_userUnderscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_userUnderscore.ForeColor = System.Drawing.Color.Black
        Me.txt_userUnderscore.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_userUnderscore.Location = New System.Drawing.Point(0, 294)
        Me.txt_userUnderscore.Name = "txt_userUnderscore"
        Me.txt_userUnderscore.Size = New System.Drawing.Size(714, 20)
        Me.txt_userUnderscore.TabIndex = 26
        Me.txt_userUnderscore.Text = "_________________________________________________________________________________" &
    "______________________"
        '
        'txt_passUnderscore
        '
        Me.txt_passUnderscore.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_passUnderscore.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_passUnderscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_passUnderscore.ForeColor = System.Drawing.Color.Black
        Me.txt_passUnderscore.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_passUnderscore.Location = New System.Drawing.Point(0, 342)
        Me.txt_passUnderscore.Name = "txt_passUnderscore"
        Me.txt_passUnderscore.Size = New System.Drawing.Size(714, 20)
        Me.txt_passUnderscore.TabIndex = 25
        Me.txt_passUnderscore.Text = "_________________________________________________________________________________" &
    "_______________________"
        '
        'clk_connection
        '
        Me.clk_connection.Enabled = True
        Me.clk_connection.Interval = 1500
        '
        'LoginVariable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 450)
        Me.Controls.Add(Me.ContenedorControles)
        Me.Controls.Add(Me.ventana)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginVariable"
        Me.Text = "LoginVariable"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContenedorControles.ResumeLayout(False)
        Me.ContenedorControles.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents restablecer As Windows.Forms.LinkLabel
    Friend WithEvents errorLabel As Windows.Forms.Label
    Friend WithEvents Config As Windows.Forms.Button
    Friend WithEvents pass As Windows.Forms.TextBox
    Friend WithEvents user As Windows.Forms.TextBox
    Friend WithEvents ventana As Windows.Forms.Panel
    Friend WithEvents Ingresar As Windows.Forms.Button
    Friend WithEvents logo As Windows.Forms.PictureBox
    Friend WithEvents ContenedorControles As Windows.Forms.Panel
    Friend WithEvents txt_passUnderscore As Windows.Forms.Label
    Friend WithEvents txt_userUnderscore As Windows.Forms.Label
    Friend WithEvents lbl_status As Windows.Forms.Label
    Friend WithEvents clk_connection As Windows.Forms.Timer
End Class
