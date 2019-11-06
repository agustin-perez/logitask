Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InfoLote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InfoLote))
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.txt_responsable = New System.Windows.Forms.TextBox()
        Me.VIN = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.atras = New System.Windows.Forms.Button()
        Me.lbl_nro = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.vehiculosInspec = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbl_inspecctitle = New System.Windows.Forms.Label()
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.btn_atras = New System.Windows.Forms.Button()
        Me.txt_cant = New System.Windows.Forms.TextBox()
        Me.img_qr = New System.Windows.Forms.PictureBox()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.qr_dataPrint = New System.Drawing.Printing.PrintDocument()
        CType(Me.img_qr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_desc
        '
        Me.txt_desc.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_desc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_desc.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desc.Location = New System.Drawing.Point(381, 58)
        Me.txt_desc.Multiline = True
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.ReadOnly = True
        Me.txt_desc.Size = New System.Drawing.Size(281, 161)
        Me.txt_desc.TabIndex = 32
        Me.txt_desc.Text = "----"
        '
        'txt_responsable
        '
        Me.txt_responsable.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_responsable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_responsable.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_responsable.Location = New System.Drawing.Point(155, 68)
        Me.txt_responsable.Name = "txt_responsable"
        Me.txt_responsable.ReadOnly = True
        Me.txt_responsable.Size = New System.Drawing.Size(205, 20)
        Me.txt_responsable.TabIndex = 31
        Me.txt_responsable.Text = "----"
        '
        'VIN
        '
        Me.VIN.BackColor = System.Drawing.Color.Gainsboro
        Me.VIN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VIN.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VIN.Location = New System.Drawing.Point(169, -21)
        Me.VIN.Name = "VIN"
        Me.VIN.ReadOnly = True
        Me.VIN.Size = New System.Drawing.Size(294, 20)
        Me.VIN.TabIndex = 29
        Me.VIN.Text = "Vehicle Identification Number"
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nombre.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(155, 114)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.ReadOnly = True
        Me.txt_nombre.Size = New System.Drawing.Size(201, 20)
        Me.txt_nombre.TabIndex = 28
        Me.txt_nombre.Text = "----"
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
        Me.atras.Location = New System.Drawing.Point(119, -40)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(44, 47)
        Me.atras.TabIndex = 27
        Me.atras.Text = "←"
        Me.atras.UseVisualStyleBackColor = False
        '
        'lbl_nro
        '
        Me.lbl_nro.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nro.Location = New System.Drawing.Point(71, 18)
        Me.lbl_nro.Name = "lbl_nro"
        Me.lbl_nro.Size = New System.Drawing.Size(124, 30)
        Me.lbl_nro.TabIndex = 26
        Me.lbl_nro.Text = "Lote: #N"
        Me.lbl_nro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_name
        '
        Me.lbl_name.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(12, 109)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(124, 30)
        Me.lbl_name.TabIndex = 24
        Me.lbl_name.Text = "Nombre del lote:"
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_username
        '
        Me.lbl_username.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(12, 63)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(124, 30)
        Me.lbl_username.TabIndex = 23
        Me.lbl_username.Text = "Responsable:"
        Me.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'vehiculosInspec
        '
        Me.vehiculosInspec.AutoScroll = True
        Me.vehiculosInspec.Location = New System.Drawing.Point(-1, 263)
        Me.vehiculosInspec.Name = "vehiculosInspec"
        Me.vehiculosInspec.Size = New System.Drawing.Size(913, 289)
        Me.vehiculosInspec.TabIndex = 35
        '
        'lbl_inspecctitle
        '
        Me.lbl_inspecctitle.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inspecctitle.Location = New System.Drawing.Point(8, 225)
        Me.lbl_inspecctitle.Name = "lbl_inspecctitle"
        Me.lbl_inspecctitle.Size = New System.Drawing.Size(151, 30)
        Me.lbl_inspecctitle.TabIndex = 36
        Me.lbl_inspecctitle.Text = "Vehículos en el lote: "
        Me.lbl_inspecctitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_desc
        '
        Me.lbl_desc.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc.Location = New System.Drawing.Point(377, 18)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(124, 30)
        Me.lbl_desc.TabIndex = 37
        Me.lbl_desc.Text = "Descripción"
        Me.lbl_desc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_atras
        '
        Me.btn_atras.AutoEllipsis = True
        Me.btn_atras.BackColor = System.Drawing.Color.Transparent
        Me.btn_atras.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_atras.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_atras.FlatAppearance.BorderSize = 0
        Me.btn_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_atras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_atras.ForeColor = System.Drawing.Color.Black
        Me.btn_atras.Location = New System.Drawing.Point(12, 9)
        Me.btn_atras.Name = "btn_atras"
        Me.btn_atras.Size = New System.Drawing.Size(44, 47)
        Me.btn_atras.TabIndex = 38
        Me.btn_atras.Text = "←"
        Me.btn_atras.UseVisualStyleBackColor = False
        '
        'txt_cant
        '
        Me.txt_cant.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_cant.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cant.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cant.Location = New System.Drawing.Point(155, 230)
        Me.txt_cant.Name = "txt_cant"
        Me.txt_cant.ReadOnly = True
        Me.txt_cant.Size = New System.Drawing.Size(205, 20)
        Me.txt_cant.TabIndex = 39
        Me.txt_cant.Text = "----"
        '
        'img_qr
        '
        Me.img_qr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.img_qr.ImageLocation = ""
        Me.img_qr.Location = New System.Drawing.Point(688, 9)
        Me.img_qr.Name = "img_qr"
        Me.img_qr.Size = New System.Drawing.Size(210, 210)
        Me.img_qr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_qr.TabIndex = 22
        Me.img_qr.TabStop = False
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.BackColor = System.Drawing.Color.DarkGray
        Me.btn_print.FlatAppearance.BorderSize = 0
        Me.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_print.Location = New System.Drawing.Point(688, 225)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(210, 32)
        Me.btn_print.TabIndex = 40
        Me.btn_print.Text = "Imprimir"
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'qr_dataPrint
        '
        Me.qr_dataPrint.DocumentName = "QR: "
        Me.qr_dataPrint.OriginAtMargins = True
        '
        'InfoLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(910, 551)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.txt_cant)
        Me.Controls.Add(Me.btn_atras)
        Me.Controls.Add(Me.lbl_desc)
        Me.Controls.Add(Me.lbl_inspecctitle)
        Me.Controls.Add(Me.vehiculosInspec)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.txt_responsable)
        Me.Controls.Add(Me.VIN)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.lbl_nro)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.img_qr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InfoLote"
        Me.Text = "InfoLote"
        CType(Me.img_qr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_desc As TextBox
    Friend WithEvents txt_responsable As TextBox
    Friend WithEvents VIN As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents atras As Button
    Friend WithEvents lbl_nro As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_username As Label
    Friend WithEvents vehiculosInspec As FlowLayoutPanel
    Friend WithEvents lbl_inspecctitle As Label
    Friend WithEvents lbl_desc As Label
    Friend WithEvents btn_atras As Button
    Friend WithEvents txt_cant As TextBox
    Friend WithEvents img_qr As PictureBox
    Friend WithEvents btn_print As Button
    Friend WithEvents qr_dataPrint As Drawing.Printing.PrintDocument
End Class
