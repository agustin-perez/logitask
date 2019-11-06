<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class acercaDe
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
        Me.link_git = New System.Windows.Forms.LinkLabel()
        Me.webview = New System.Windows.Forms.WebBrowser()
        Me.link_pag = New System.Windows.Forms.LinkLabel()
        Me.link_letra = New System.Windows.Forms.LinkLabel()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.lbl_copyright = New System.Windows.Forms.Label()
        Me.logoPrincipal = New System.Windows.Forms.PictureBox()
        CType(Me.logoPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'link_git
        '
        Me.link_git.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.link_git.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_git.LinkColor = System.Drawing.Color.Black
        Me.link_git.Location = New System.Drawing.Point(247, 470)
        Me.link_git.Name = "link_git"
        Me.link_git.Size = New System.Drawing.Size(47, 23)
        Me.link_git.TabIndex = 4
        Me.link_git.TabStop = True
        Me.link_git.Text = "GitLab"
        '
        'webview
        '
        Me.webview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webview.Location = New System.Drawing.Point(-1, -3)
        Me.webview.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webview.Name = "webview"
        Me.webview.Size = New System.Drawing.Size(786, 545)
        Me.webview.TabIndex = 5
        '
        'link_pag
        '
        Me.link_pag.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.link_pag.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_pag.LinkColor = System.Drawing.Color.Black
        Me.link_pag.Location = New System.Drawing.Point(135, 470)
        Me.link_pag.Name = "link_pag"
        Me.link_pag.Size = New System.Drawing.Size(106, 23)
        Me.link_pag.TabIndex = 6
        Me.link_pag.TabStop = True
        Me.link_pag.Text = "Fertspa Studios"
        '
        'link_letra
        '
        Me.link_letra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.link_letra.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_letra.LinkColor = System.Drawing.Color.Black
        Me.link_letra.Location = New System.Drawing.Point(12, 470)
        Me.link_letra.Name = "link_letra"
        Me.link_letra.Size = New System.Drawing.Size(117, 23)
        Me.link_letra.TabIndex = 7
        Me.link_letra.TabStop = True
        Me.link_letra.Text = "Letra del proyecto"
        '
        'lbl_title
        '
        Me.lbl_title.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_title.Font = New System.Drawing.Font("Segoe UI Light", 18.0!)
        Me.lbl_title.ForeColor = System.Drawing.Color.Black
        Me.lbl_title.Location = New System.Drawing.Point(9, 386)
        Me.lbl_title.MaximumSize = New System.Drawing.Size(511, 42)
        Me.lbl_title.MinimumSize = New System.Drawing.Size(511, 42)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(511, 42)
        Me.lbl_title.TabIndex = 11
        Me.lbl_title.Text = "Sistema de logística y trazabilidad automotriz"
        '
        'lbl_desc
        '
        Me.lbl_desc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_desc.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.lbl_desc.ForeColor = System.Drawing.Color.Black
        Me.lbl_desc.Location = New System.Drawing.Point(12, 428)
        Me.lbl_desc.MaximumSize = New System.Drawing.Size(364, 39)
        Me.lbl_desc.MinimumSize = New System.Drawing.Size(364, 39)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(364, 39)
        Me.lbl_desc.TabIndex = 12
        Me.lbl_desc.Text = "Proyecto de pasaje de grado - EMT " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Escuela superior de informática" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl_copyright
        '
        Me.lbl_copyright.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_copyright.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.lbl_copyright.ForeColor = System.Drawing.Color.Black
        Me.lbl_copyright.Location = New System.Drawing.Point(12, 496)
        Me.lbl_copyright.MinimumSize = New System.Drawing.Size(434, 23)
        Me.lbl_copyright.Name = "lbl_copyright"
        Me.lbl_copyright.Size = New System.Drawing.Size(567, 46)
        Me.lbl_copyright.TabIndex = 13
        Me.lbl_copyright.Text = "© 2019 - Fertspa Studios: Guillermo Acquistapace, Franco Dalmaso, Ivo Méndez, Jea" &
    "n Paul Sullcaray, Agustín Perez"
        '
        'logoPrincipal
        '
        Me.logoPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.logoPrincipal.Image = Global.LibreriaGrafica.My.Resources.Images.logofertspa
        Me.logoPrincipal.Location = New System.Drawing.Point(138, 12)
        Me.logoPrincipal.Name = "logoPrincipal"
        Me.logoPrincipal.Size = New System.Drawing.Size(490, 236)
        Me.logoPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logoPrincipal.TabIndex = 8
        Me.logoPrincipal.TabStop = False
        '
        'acercaDe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 541)
        Me.Controls.Add(Me.lbl_copyright)
        Me.Controls.Add(Me.lbl_desc)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.logoPrincipal)
        Me.Controls.Add(Me.link_letra)
        Me.Controls.Add(Me.link_git)
        Me.Controls.Add(Me.link_pag)
        Me.Controls.Add(Me.webview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "acercaDe"
        CType(Me.logoPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents link_git As Windows.Forms.LinkLabel
    Friend WithEvents webview As Windows.Forms.WebBrowser
    Friend WithEvents link_pag As Windows.Forms.LinkLabel
    Friend WithEvents link_letra As Windows.Forms.LinkLabel
    Friend WithEvents logoPrincipal As Windows.Forms.PictureBox
    Friend WithEvents lbl_title As Windows.Forms.Label
    Friend WithEvents lbl_desc As Windows.Forms.Label
    Friend WithEvents lbl_copyright As Windows.Forms.Label
End Class
