Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NuevoLote
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
        Me.ventanaNoConfirmados = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.ventanaConfirmados = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbl_confirmados = New System.Windows.Forms.Label()
        Me.lbl_addtitle = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_deshacer = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.panelRelleno = New System.Windows.Forms.Panel()
        Me.lbl_nroLote = New System.Windows.Forms.Label()
        Me.msk_testimado = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_testimado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ventanaNoConfirmados
        '
        Me.ventanaNoConfirmados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ventanaNoConfirmados.AutoScroll = True
        Me.ventanaNoConfirmados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ventanaNoConfirmados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ventanaNoConfirmados.Location = New System.Drawing.Point(12, 57)
        Me.ventanaNoConfirmados.Name = "ventanaNoConfirmados"
        Me.ventanaNoConfirmados.Size = New System.Drawing.Size(305, 338)
        Me.ventanaNoConfirmados.TabIndex = 0
        '
        'lbl_nombre
        '
        Me.lbl_nombre.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.ForeColor = System.Drawing.Color.Black
        Me.lbl_nombre.Location = New System.Drawing.Point(12, 9)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(61, 20)
        Me.lbl_nombre.TabIndex = 1
        Me.lbl_nombre.Text = "Nombre"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(79, 11)
        Me.txt_nombre.MaxLength = 64
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(230, 20)
        Me.txt_nombre.TabIndex = 2
        '
        'lbl_desc
        '
        Me.lbl_desc.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc.ForeColor = System.Drawing.Color.Black
        Me.lbl_desc.Location = New System.Drawing.Point(319, 34)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(93, 20)
        Me.lbl_desc.TabIndex = 3
        Me.lbl_desc.Text = "Descripción"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_descripcion.Location = New System.Drawing.Point(323, 57)
        Me.txt_descripcion.MaxLength = 30000
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(574, 115)
        Me.txt_descripcion.TabIndex = 4
        '
        'ventanaConfirmados
        '
        Me.ventanaConfirmados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ventanaConfirmados.AutoScroll = True
        Me.ventanaConfirmados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ventanaConfirmados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ventanaConfirmados.Location = New System.Drawing.Point(323, 198)
        Me.ventanaConfirmados.Name = "ventanaConfirmados"
        Me.ventanaConfirmados.Size = New System.Drawing.Size(574, 197)
        Me.ventanaConfirmados.TabIndex = 5
        '
        'lbl_confirmados
        '
        Me.lbl_confirmados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_confirmados.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_confirmados.ForeColor = System.Drawing.Color.Black
        Me.lbl_confirmados.Location = New System.Drawing.Point(319, 175)
        Me.lbl_confirmados.Name = "lbl_confirmados"
        Me.lbl_confirmados.Size = New System.Drawing.Size(577, 20)
        Me.lbl_confirmados.TabIndex = 6
        Me.lbl_confirmados.Text = "Vehiculos confirmados"
        '
        'lbl_addtitle
        '
        Me.lbl_addtitle.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_addtitle.ForeColor = System.Drawing.Color.Black
        Me.lbl_addtitle.Location = New System.Drawing.Point(12, 34)
        Me.lbl_addtitle.Name = "lbl_addtitle"
        Me.lbl_addtitle.Size = New System.Drawing.Size(297, 20)
        Me.lbl_addtitle.TabIndex = 7
        Me.lbl_addtitle.Text = "Seleccione los vehiculos a agregar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_cancelar.BackColor = System.Drawing.Color.DarkGray
        Me.btn_cancelar.FlatAppearance.BorderSize = 0
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Location = New System.Drawing.Point(12, 401)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(124, 30)
        Me.btn_cancelar.TabIndex = 8
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_deshacer
        '
        Me.btn_deshacer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_deshacer.BackColor = System.Drawing.Color.DarkGray
        Me.btn_deshacer.Enabled = False
        Me.btn_deshacer.FlatAppearance.BorderSize = 0
        Me.btn_deshacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deshacer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deshacer.Location = New System.Drawing.Point(323, 401)
        Me.btn_deshacer.Name = "btn_deshacer"
        Me.btn_deshacer.Size = New System.Drawing.Size(124, 30)
        Me.btn_deshacer.TabIndex = 9
        Me.btn_deshacer.Text = "Deshacer"
        Me.btn_deshacer.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.BackColor = System.Drawing.Color.DarkGray
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(773, 401)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(124, 30)
        Me.btn_save.TabIndex = 10
        Me.btn_save.Text = "Guardar"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'panelRelleno
        '
        Me.panelRelleno.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panelRelleno.Location = New System.Drawing.Point(142, 401)
        Me.panelRelleno.Name = "panelRelleno"
        Me.panelRelleno.Size = New System.Drawing.Size(175, 30)
        Me.panelRelleno.TabIndex = 11
        '
        'lbl_nroLote
        '
        Me.lbl_nroLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_nroLote.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nroLote.ForeColor = System.Drawing.Color.Black
        Me.lbl_nroLote.Location = New System.Drawing.Point(774, 9)
        Me.lbl_nroLote.Name = "lbl_nroLote"
        Me.lbl_nroLote.Size = New System.Drawing.Size(123, 20)
        Me.lbl_nroLote.TabIndex = 12
        Me.lbl_nroLote.Text = "Lote: #N"
        Me.lbl_nroLote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'msk_testimado
        '
        Me.msk_testimado.Location = New System.Drawing.Point(516, 9)
        Me.msk_testimado.Mask = "00/00/0000 00:00"
        Me.msk_testimado.Name = "msk_testimado"
        Me.msk_testimado.Size = New System.Drawing.Size(152, 20)
        Me.msk_testimado.TabIndex = 30
        Me.msk_testimado.ValidatingType = GetType(Date)
        '
        'lbl_testimado
        '
        Me.lbl_testimado.AutoEllipsis = True
        Me.lbl_testimado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lbl_testimado.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_testimado.ForeColor = System.Drawing.Color.Black
        Me.lbl_testimado.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lbl_testimado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_testimado.Location = New System.Drawing.Point(318, 1)
        Me.lbl_testimado.Name = "lbl_testimado"
        Me.lbl_testimado.Size = New System.Drawing.Size(192, 35)
        Me.lbl_testimado.TabIndex = 29
        Me.lbl_testimado.Text = "Fecha estimada de llegada"
        Me.lbl_testimado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NuevoLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(909, 443)
        Me.Controls.Add(Me.msk_testimado)
        Me.Controls.Add(Me.lbl_testimado)
        Me.Controls.Add(Me.lbl_nroLote)
        Me.Controls.Add(Me.panelRelleno)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_deshacer)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.lbl_addtitle)
        Me.Controls.Add(Me.lbl_confirmados)
        Me.Controls.Add(Me.ventanaConfirmados)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.lbl_desc)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.ventanaNoConfirmados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NuevoLote"
        Me.Text = "NuevoLote"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ventanaNoConfirmados As FlowLayoutPanel
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents lbl_desc As Label
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents ventanaConfirmados As FlowLayoutPanel
    Friend WithEvents lbl_confirmados As Label
    Friend WithEvents lbl_addtitle As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_deshacer As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents panelRelleno As Panel
    Friend WithEvents lbl_nroLote As Label
    Friend WithEvents msk_testimado As MaskedTextBox
    Friend WithEvents lbl_testimado As Label
End Class
