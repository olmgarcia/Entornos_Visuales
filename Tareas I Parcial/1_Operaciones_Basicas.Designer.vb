<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _1_Operaciones_Basicas
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
        Me.TxtDivision = New System.Windows.Forms.TextBox()
        Me.TxtMultiplicacion = New System.Windows.Forms.TextBox()
        Me.TxtResta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSuma = New System.Windows.Forms.TextBox()
        Me.TxtNumero2 = New System.Windows.Forms.TextBox()
        Me.TxtNumero1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtDivision
        '
        Me.TxtDivision.Location = New System.Drawing.Point(499, 267)
        Me.TxtDivision.Name = "TxtDivision"
        Me.TxtDivision.Size = New System.Drawing.Size(135, 20)
        Me.TxtDivision.TabIndex = 72
        '
        'TxtMultiplicacion
        '
        Me.TxtMultiplicacion.Location = New System.Drawing.Point(499, 221)
        Me.TxtMultiplicacion.Name = "TxtMultiplicacion"
        Me.TxtMultiplicacion.Size = New System.Drawing.Size(135, 20)
        Me.TxtMultiplicacion.TabIndex = 71
        '
        'TxtResta
        '
        Me.TxtResta.Location = New System.Drawing.Point(172, 267)
        Me.TxtResta.Name = "TxtResta"
        Me.TxtResta.Size = New System.Drawing.Size(135, 20)
        Me.TxtResta.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(364, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 22)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Multiplicacion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(364, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 22)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Division"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 22)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Resta"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSalir.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(368, 368)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(124, 53)
        Me.BtnSalir.TabIndex = 66
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLimpiar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Location = New System.Drawing.Point(187, 366)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(127, 54)
        Me.BtnLimpiar.TabIndex = 65
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 22)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Suma "
        '
        'TxtSuma
        '
        Me.TxtSuma.Location = New System.Drawing.Point(173, 223)
        Me.TxtSuma.Name = "TxtSuma"
        Me.TxtSuma.Size = New System.Drawing.Size(135, 20)
        Me.TxtSuma.TabIndex = 63
        '
        'TxtNumero2
        '
        Me.TxtNumero2.Location = New System.Drawing.Point(172, 117)
        Me.TxtNumero2.Name = "TxtNumero2"
        Me.TxtNumero2.Size = New System.Drawing.Size(136, 20)
        Me.TxtNumero2.TabIndex = 62
        '
        'TxtNumero1
        '
        Me.TxtNumero1.Location = New System.Drawing.Point(171, 59)
        Me.TxtNumero1.Name = "TxtNumero1"
        Me.TxtNumero1.Size = New System.Drawing.Size(138, 20)
        Me.TxtNumero1.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 22)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Numero 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 22)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Numero 1"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCalcular.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.Location = New System.Drawing.Point(29, 362)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(115, 59)
        Me.BtnCalcular.TabIndex = 58
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        '_1_Operaciones_Basicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(661, 481)
        Me.Controls.Add(Me.TxtDivision)
        Me.Controls.Add(Me.TxtMultiplicacion)
        Me.Controls.Add(Me.TxtResta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtSuma)
        Me.Controls.Add(Me.TxtNumero2)
        Me.Controls.Add(Me.TxtNumero1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Name = "_1_Operaciones_Basicas"
        Me.Text = "Operaciones Basicas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtDivision As TextBox
    Friend WithEvents TxtMultiplicacion As TextBox
    Friend WithEvents TxtResta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtSuma As TextBox
    Friend WithEvents TxtNumero2 As TextBox
    Friend WithEvents TxtNumero1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCalcular As Button
End Class
