<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class configIdioma
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
        Me.eng = New System.Windows.Forms.RadioButton()
        Me.esp = New System.Windows.Forms.RadioButton()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.ptg = New System.Windows.Forms.RadioButton()
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'eng
        '
        Me.eng.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eng.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.eng.Location = New System.Drawing.Point(12, 94)
        Me.eng.Name = "eng"
        Me.eng.Size = New System.Drawing.Size(148, 37)
        Me.eng.TabIndex = 5
        Me.eng.TabStop = True
        Me.eng.Text = "English (UK)"
        Me.eng.UseVisualStyleBackColor = True
        '
        'esp
        '
        Me.esp.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.esp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.esp.Location = New System.Drawing.Point(12, 51)
        Me.esp.Name = "esp"
        Me.esp.Size = New System.Drawing.Size(148, 37)
        Me.esp.TabIndex = 4
        Me.esp.TabStop = True
        Me.esp.Text = "Español (LA)"
        Me.esp.UseVisualStyleBackColor = True
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
        Me.lbl_title.Text = "Idioma"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ptg
        '
        Me.ptg.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ptg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ptg.Location = New System.Drawing.Point(12, 137)
        Me.ptg.Name = "ptg"
        Me.ptg.Size = New System.Drawing.Size(148, 37)
        Me.ptg.TabIndex = 10
        Me.ptg.TabStop = True
        Me.ptg.Text = "Português (BR)"
        Me.ptg.UseVisualStyleBackColor = True
        '
        'errorLabel
        '
        Me.errorLabel.AutoEllipsis = True
        Me.errorLabel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.errorLabel.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorLabel.ForeColor = System.Drawing.Color.Red
        Me.errorLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.errorLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.errorLabel.Location = New System.Drawing.Point(12, 177)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(764, 38)
        Me.errorLabel.TabIndex = 17
        Me.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'configIdioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 588)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.ptg)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.eng)
        Me.Controls.Add(Me.esp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "configIdioma"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents eng As Windows.Forms.RadioButton
    Friend WithEvents esp As Windows.Forms.RadioButton
    Friend WithEvents lbl_title As Windows.Forms.Label
    Friend WithEvents ptg As Windows.Forms.RadioButton
    Friend WithEvents errorLabel As Windows.Forms.Label
End Class
