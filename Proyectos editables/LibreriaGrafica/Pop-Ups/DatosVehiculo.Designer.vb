Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DatosVehiculo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatosVehiculo))
        Me.lblmodelo = New System.Windows.Forms.Label()
        Me.lblyear = New System.Windows.Forms.Label()
        Me.lblcolor = New System.Windows.Forms.Label()
        Me.lblmarca = New System.Windows.Forms.Label()
        Me.atras = New System.Windows.Forms.Button()
        Me.icono = New System.Windows.Forms.PictureBox()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.VIN = New System.Windows.Forms.TextBox()
        Me.txt_marca = New System.Windows.Forms.TextBox()
        Me.txt_modelo = New System.Windows.Forms.TextBox()
        Me.txt_color = New System.Windows.Forms.TextBox()
        Me.txt_tipoVehiculo = New System.Windows.Forms.TextBox()
        Me.ListaInspec = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbl_inspecctitle = New System.Windows.Forms.Label()
        Me.lbl_location = New System.Windows.Forms.Label()
        Me.btn_reload = New System.Windows.Forms.Button()
        Me.img_qr = New System.Windows.Forms.PictureBox()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.qr_dataPrint = New System.Drawing.Printing.PrintDocument()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.msk_marca = New System.Windows.Forms.MaskedTextBox()
        Me.msk_modelo = New System.Windows.Forms.MaskedTextBox()
        Me.msk_release = New System.Windows.Forms.MaskedTextBox()
        Me.msk_color = New System.Windows.Forms.MaskedTextBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.info = New System.Windows.Forms.ToolTip(Me.components)
        Me.img_transicion = New System.Windows.Forms.PictureBox()
        Me.UpdateMap = New System.Windows.Forms.Timer(Me.components)
        Me.listaLugar = New System.Windows.Forms.Panel()
        CType(Me.icono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_qr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_transicion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblmodelo
        '
        Me.lblmodelo.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodelo.Location = New System.Drawing.Point(12, 82)
        Me.lblmodelo.Name = "lblmodelo"
        Me.lblmodelo.Size = New System.Drawing.Size(124, 30)
        Me.lblmodelo.TabIndex = 3
        Me.lblmodelo.Text = "Modelo:"
        Me.lblmodelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblyear
        '
        Me.lblyear.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblyear.Location = New System.Drawing.Point(12, 112)
        Me.lblyear.Name = "lblyear"
        Me.lblyear.Size = New System.Drawing.Size(124, 30)
        Me.lblyear.TabIndex = 6
        Me.lblyear.Text = "Año:"
        Me.lblyear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcolor
        '
        Me.lblcolor.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcolor.Location = New System.Drawing.Point(12, 142)
        Me.lblcolor.Name = "lblcolor"
        Me.lblcolor.Size = New System.Drawing.Size(124, 30)
        Me.lblcolor.TabIndex = 8
        Me.lblcolor.Text = "Color:"
        Me.lblcolor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblmarca
        '
        Me.lblmarca.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmarca.Location = New System.Drawing.Point(12, 52)
        Me.lblmarca.Name = "lblmarca"
        Me.lblmarca.Size = New System.Drawing.Size(124, 30)
        Me.lblmarca.TabIndex = 10
        Me.lblmarca.Text = "Marca:"
        Me.lblmarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.atras.Location = New System.Drawing.Point(0, 2)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(44, 47)
        Me.atras.TabIndex = 11
        Me.atras.Text = "←"
        Me.atras.UseVisualStyleBackColor = False
        '
        'icono
        '
        Me.icono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.icono.Image = CType(resources.GetObject("icono.Image"), System.Drawing.Image)
        Me.icono.ImageLocation = ""
        Me.icono.Location = New System.Drawing.Point(451, 12)
        Me.icono.Name = "icono"
        Me.icono.Size = New System.Drawing.Size(200, 200)
        Me.icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icono.TabIndex = 0
        Me.icono.TabStop = False
        '
        'txt_year
        '
        Me.txt_year.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_year.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_year.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_year.Location = New System.Drawing.Point(142, 121)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.ReadOnly = True
        Me.txt_year.Size = New System.Drawing.Size(214, 20)
        Me.txt_year.TabIndex = 12
        Me.txt_year.Text = "----"
        '
        'VIN
        '
        Me.VIN.BackColor = System.Drawing.Color.Gainsboro
        Me.VIN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VIN.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VIN.Location = New System.Drawing.Point(50, 16)
        Me.VIN.Name = "VIN"
        Me.VIN.ReadOnly = True
        Me.VIN.Size = New System.Drawing.Size(246, 20)
        Me.VIN.TabIndex = 13
        Me.VIN.Text = "Vehicle Identification Number"
        '
        'txt_marca
        '
        Me.txt_marca.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_marca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_marca.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_marca.Location = New System.Drawing.Point(142, 61)
        Me.txt_marca.Name = "txt_marca"
        Me.txt_marca.ReadOnly = True
        Me.txt_marca.Size = New System.Drawing.Size(214, 20)
        Me.txt_marca.TabIndex = 14
        Me.txt_marca.Text = "----"
        '
        'txt_modelo
        '
        Me.txt_modelo.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_modelo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_modelo.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_modelo.Location = New System.Drawing.Point(142, 91)
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.ReadOnly = True
        Me.txt_modelo.Size = New System.Drawing.Size(214, 20)
        Me.txt_modelo.TabIndex = 15
        Me.txt_modelo.Text = "----"
        '
        'txt_color
        '
        Me.txt_color.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_color.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_color.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_color.Location = New System.Drawing.Point(142, 151)
        Me.txt_color.Name = "txt_color"
        Me.txt_color.ReadOnly = True
        Me.txt_color.Size = New System.Drawing.Size(214, 20)
        Me.txt_color.TabIndex = 16
        Me.txt_color.Text = "----"
        '
        'txt_tipoVehiculo
        '
        Me.txt_tipoVehiculo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_tipoVehiculo.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_tipoVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_tipoVehiculo.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tipoVehiculo.Location = New System.Drawing.Point(451, 223)
        Me.txt_tipoVehiculo.Name = "txt_tipoVehiculo"
        Me.txt_tipoVehiculo.ReadOnly = True
        Me.txt_tipoVehiculo.Size = New System.Drawing.Size(200, 20)
        Me.txt_tipoVehiculo.TabIndex = 17
        Me.txt_tipoVehiculo.Text = "----"
        Me.txt_tipoVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ListaInspec
        '
        Me.ListaInspec.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaInspec.AutoScroll = True
        Me.ListaInspec.Location = New System.Drawing.Point(539, 300)
        Me.ListaInspec.Name = "ListaInspec"
        Me.ListaInspec.Size = New System.Drawing.Size(318, 223)
        Me.ListaInspec.TabIndex = 19
        '
        'lbl_inspecctitle
        '
        Me.lbl_inspecctitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_inspecctitle.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inspecctitle.Location = New System.Drawing.Point(542, 267)
        Me.lbl_inspecctitle.Name = "lbl_inspecctitle"
        Me.lbl_inspecctitle.Size = New System.Drawing.Size(96, 30)
        Me.lbl_inspecctitle.TabIndex = 20
        Me.lbl_inspecctitle.Text = "Inspecciones"
        Me.lbl_inspecctitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_location
        '
        Me.lbl_location.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_location.Location = New System.Drawing.Point(12, 267)
        Me.lbl_location.Name = "lbl_location"
        Me.lbl_location.Size = New System.Drawing.Size(96, 30)
        Me.lbl_location.TabIndex = 23
        Me.lbl_location.Text = "Ubicación"
        Me.lbl_location.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btn_reload.Location = New System.Drawing.Point(817, 529)
        Me.btn_reload.Name = "btn_reload"
        Me.btn_reload.Size = New System.Drawing.Size(40, 40)
        Me.btn_reload.TabIndex = 24
        Me.btn_reload.UseVisualStyleBackColor = False
        '
        'img_qr
        '
        Me.img_qr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.img_qr.Location = New System.Drawing.Point(657, 12)
        Me.img_qr.Name = "img_qr"
        Me.img_qr.Size = New System.Drawing.Size(200, 200)
        Me.img_qr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_qr.TabIndex = 25
        Me.img_qr.TabStop = False
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.BackColor = System.Drawing.Color.DarkGray
        Me.btn_print.FlatAppearance.BorderSize = 0
        Me.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_print.Location = New System.Drawing.Point(657, 218)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(200, 32)
        Me.btn_print.TabIndex = 26
        Me.btn_print.Text = "Imprimir"
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'qr_dataPrint
        '
        Me.qr_dataPrint.DocumentName = "QR: "
        Me.qr_dataPrint.OriginAtMargins = True
        '
        'btn_edit
        '
        Me.btn_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_edit.AutoSize = True
        Me.btn_edit.BackColor = System.Drawing.Color.Transparent
        Me.btn_edit.BackgroundImage = Global.LibreriaGrafica.My.Resources.Images.editIcon
        Me.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_edit.FlatAppearance.BorderSize = 0
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Location = New System.Drawing.Point(771, 529)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(40, 40)
        Me.btn_edit.TabIndex = 27
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.AutoSize = True
        Me.btn_delete.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete.BackgroundImage = Global.LibreriaGrafica.My.Resources.Images.deleteIcon
        Me.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Location = New System.Drawing.Point(725, 529)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(40, 40)
        Me.btn_delete.TabIndex = 28
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.AutoSize = True
        Me.btn_save.BackColor = System.Drawing.Color.Transparent
        Me.btn_save.BackgroundImage = Global.LibreriaGrafica.My.Resources.Images.checkIcon
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Location = New System.Drawing.Point(771, 529)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(40, 40)
        Me.btn_save.TabIndex = 6
        Me.btn_save.UseVisualStyleBackColor = False
        Me.btn_save.Visible = False
        '
        'cmb_tipo
        '
        Me.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Location = New System.Drawing.Point(451, 223)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(200, 21)
        Me.cmb_tipo.TabIndex = 5
        Me.cmb_tipo.Visible = False
        '
        'msk_marca
        '
        Me.msk_marca.BackColor = System.Drawing.Color.Gainsboro
        Me.msk_marca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.msk_marca.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.msk_marca.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msk_marca.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.msk_marca.Location = New System.Drawing.Point(142, 57)
        Me.msk_marca.Mask = "????????????????????????????????????????????????????????????????"
        Me.msk_marca.Name = "msk_marca"
        Me.msk_marca.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.msk_marca.Size = New System.Drawing.Size(214, 25)
        Me.msk_marca.TabIndex = 1
        Me.msk_marca.Visible = False
        '
        'msk_modelo
        '
        Me.msk_modelo.BackColor = System.Drawing.Color.Gainsboro
        Me.msk_modelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.msk_modelo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.msk_modelo.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msk_modelo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.msk_modelo.Location = New System.Drawing.Point(142, 87)
        Me.msk_modelo.Mask = "????????????????????????????????????????????????????????????????"
        Me.msk_modelo.Name = "msk_modelo"
        Me.msk_modelo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.msk_modelo.Size = New System.Drawing.Size(214, 25)
        Me.msk_modelo.TabIndex = 2
        Me.msk_modelo.Visible = False
        '
        'msk_release
        '
        Me.msk_release.BackColor = System.Drawing.Color.Gainsboro
        Me.msk_release.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.msk_release.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.msk_release.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msk_release.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.msk_release.Location = New System.Drawing.Point(142, 117)
        Me.msk_release.Mask = "0000"
        Me.msk_release.Name = "msk_release"
        Me.msk_release.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.msk_release.Size = New System.Drawing.Size(214, 25)
        Me.msk_release.TabIndex = 3
        Me.msk_release.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.msk_release.Visible = False
        '
        'msk_color
        '
        Me.msk_color.BackColor = System.Drawing.Color.Gainsboro
        Me.msk_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.msk_color.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.msk_color.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msk_color.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.msk_color.Location = New System.Drawing.Point(142, 147)
        Me.msk_color.Mask = "????????????????????????????????"
        Me.msk_color.Name = "msk_color"
        Me.msk_color.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.msk_color.Size = New System.Drawing.Size(214, 25)
        Me.msk_color.TabIndex = 4
        Me.msk_color.Visible = False
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.AutoSize = True
        Me.btn_cancel.BackColor = System.Drawing.Color.Transparent
        Me.btn_cancel.BackgroundImage = Global.LibreriaGrafica.My.Resources.Images.deleteIcon
        Me.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Location = New System.Drawing.Point(725, 529)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(40, 40)
        Me.btn_cancel.TabIndex = 29
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'info
        '
        Me.info.ToolTipTitle = "Informacion"
        '
        'img_transicion
        '
        Me.img_transicion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.img_transicion.Location = New System.Drawing.Point(12, 300)
        Me.img_transicion.Name = "img_transicion"
        Me.img_transicion.Size = New System.Drawing.Size(521, 269)
        Me.img_transicion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_transicion.TabIndex = 30
        Me.img_transicion.TabStop = False
        '
        'UpdateMap
        '
        Me.UpdateMap.Interval = 2000
        '
        'listaLugar
        '
        Me.listaLugar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.listaLugar.Location = New System.Drawing.Point(12, 300)
        Me.listaLugar.Name = "listaLugar"
        Me.listaLugar.Size = New System.Drawing.Size(521, 269)
        Me.listaLugar.TabIndex = 31
        '
        'DatosVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(869, 581)
        Me.Controls.Add(Me.listaLugar)
        Me.Controls.Add(Me.msk_color)
        Me.Controls.Add(Me.msk_release)
        Me.Controls.Add(Me.msk_modelo)
        Me.Controls.Add(Me.msk_marca)
        Me.Controls.Add(Me.cmb_tipo)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_reload)
        Me.Controls.Add(Me.lbl_location)
        Me.Controls.Add(Me.lbl_inspecctitle)
        Me.Controls.Add(Me.ListaInspec)
        Me.Controls.Add(Me.txt_tipoVehiculo)
        Me.Controls.Add(Me.txt_color)
        Me.Controls.Add(Me.txt_modelo)
        Me.Controls.Add(Me.txt_marca)
        Me.Controls.Add(Me.VIN)
        Me.Controls.Add(Me.txt_year)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.lblmarca)
        Me.Controls.Add(Me.lblcolor)
        Me.Controls.Add(Me.lblyear)
        Me.Controls.Add(Me.lblmodelo)
        Me.Controls.Add(Me.icono)
        Me.Controls.Add(Me.img_qr)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.img_transicion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(885, 620)
        Me.Name = "DatosVehiculo"
        Me.Text = "Información del vehículo: ABC"
        CType(Me.icono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_qr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_transicion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents icono As Windows.Forms.PictureBox
    Friend WithEvents lblmodelo As Windows.Forms.Label
    Friend WithEvents lblyear As Windows.Forms.Label
    Friend WithEvents lblcolor As Windows.Forms.Label
    Friend WithEvents lblmarca As Windows.Forms.Label
    Friend WithEvents atras As Windows.Forms.Button
    Friend WithEvents txt_year As Windows.Forms.TextBox
    Friend WithEvents VIN As Windows.Forms.TextBox
    Friend WithEvents txt_marca As Windows.Forms.TextBox
    Friend WithEvents txt_modelo As Windows.Forms.TextBox
    Friend WithEvents txt_color As Windows.Forms.TextBox
    Friend WithEvents txt_tipoVehiculo As Windows.Forms.TextBox
    Friend WithEvents ListaInspec As Windows.Forms.FlowLayoutPanel
    Friend WithEvents lbl_inspecctitle As Windows.Forms.Label
    Friend WithEvents lbl_location As Label
    Friend WithEvents btn_reload As Button
    Friend WithEvents img_qr As PictureBox
    Friend WithEvents btn_print As Button
    Friend WithEvents qr_dataPrint As Drawing.Printing.PrintDocument
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents msk_marca As MaskedTextBox
    Friend WithEvents msk_modelo As MaskedTextBox
    Friend WithEvents msk_release As MaskedTextBox
    Friend WithEvents msk_color As MaskedTextBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents info As ToolTip
    Friend WithEvents img_transicion As PictureBox
    Friend WithEvents UpdateMap As Timer
    Friend WithEvents listaLugar As Panel
End Class
