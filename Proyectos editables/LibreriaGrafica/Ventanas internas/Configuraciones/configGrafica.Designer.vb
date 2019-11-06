Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class configGrafica
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbltma = New System.Windows.Forms.Label()
        Me.opcClaro = New System.Windows.Forms.RadioButton()
        Me.opcNight = New System.Windows.Forms.RadioButton()
        Me.applyTema = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbltma
        '
        Me.lbltma.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbltma.Location = New System.Drawing.Point(12, 48)
        Me.lbltma.Name = "lbltma"
        Me.lbltma.Size = New System.Drawing.Size(59, 37)
        Me.lbltma.TabIndex = 0
        Me.lbltma.Text = "Tema:"
        Me.lbltma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'opcClaro
        '
        Me.opcClaro.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opcClaro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.opcClaro.Location = New System.Drawing.Point(77, 51)
        Me.opcClaro.Name = "opcClaro"
        Me.opcClaro.Size = New System.Drawing.Size(148, 37)
        Me.opcClaro.TabIndex = 1
        Me.opcClaro.TabStop = True
        Me.opcClaro.Text = "Claro"
        Me.opcClaro.UseVisualStyleBackColor = True
        '
        'opcNight
        '
        Me.opcNight.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opcNight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.opcNight.Location = New System.Drawing.Point(77, 82)
        Me.opcNight.Name = "opcNight"
        Me.opcNight.Size = New System.Drawing.Size(148, 37)
        Me.opcNight.TabIndex = 2
        Me.opcNight.TabStop = True
        Me.opcNight.Text = "Modo nocturno"
        Me.opcNight.UseVisualStyleBackColor = True
        '
        'applyTema
        '
        Me.applyTema.AutoEllipsis = True
        Me.applyTema.BackColor = System.Drawing.SystemColors.ControlDark
        Me.applyTema.FlatAppearance.BorderSize = 0
        Me.applyTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.applyTema.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.applyTema.Location = New System.Drawing.Point(12, 125)
        Me.applyTema.Name = "applyTema"
        Me.applyTema.Size = New System.Drawing.Size(124, 30)
        Me.applyTema.TabIndex = 3
        Me.applyTema.Text = "Aplicar"
        Me.applyTema.UseVisualStyleBackColor = False
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
        Me.lbl_title.Size = New System.Drawing.Size(788, 48)
        Me.lbl_title.TabIndex = 9
        Me.lbl_title.Text = "Configuración gráfica"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'errorLabel
        '
        Me.errorLabel.AutoEllipsis = True
        Me.errorLabel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.errorLabel.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorLabel.ForeColor = System.Drawing.Color.Red
        Me.errorLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.errorLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.errorLabel.Location = New System.Drawing.Point(142, 124)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(646, 30)
        Me.errorLabel.TabIndex = 18
        Me.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'configGrafica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 588)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.applyTema)
        Me.Controls.Add(Me.opcNight)
        Me.Controls.Add(Me.opcClaro)
        Me.Controls.Add(Me.lbltma)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "configGrafica"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbltma As Label
    Friend WithEvents opcClaro As RadioButton
    Friend WithEvents opcNight As RadioButton
    Friend WithEvents applyTema As Button
    Friend WithEvents lbl_title As Label
    Friend WithEvents errorLabel As Label
End Class
