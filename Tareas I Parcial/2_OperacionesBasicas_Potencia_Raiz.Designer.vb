<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _2_OperacionesBasicas_Potencia_Raiz
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
        Me.chkMultiplicacion = New System.Windows.Forms.CheckBox()
        Me.chkpotencia = New System.Windows.Forms.CheckBox()
        Me.chkSuma = New System.Windows.Forms.CheckBox()
        Me.chkraiz = New System.Windows.Forms.CheckBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.chkResta = New System.Windows.Forms.CheckBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.chkdivision = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtResultado = New System.Windows.Forms.TextBox()
        Me.TxtNumero2 = New System.Windows.Forms.TextBox()
        Me.TxtNumero1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkMultiplicacion
        '
        Me.chkMultiplicacion.AutoSize = True
        Me.chkMultiplicacion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMultiplicacion.Location = New System.Drawing.Point(428, 145)
        Me.chkMultiplicacion.Name = "chkMultiplicacion"
        Me.chkMultiplicacion.Size = New System.Drawing.Size(123, 23)
        Me.chkMultiplicacion.TabIndex = 50
        Me.chkMultiplicacion.Text = "Multiplicacion"
        Me.chkMultiplicacion.UseVisualStyleBackColor = True
        '
        'chkpotencia
        '
        Me.chkpotencia.AutoSize = True
        Me.chkpotencia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkpotencia.Location = New System.Drawing.Point(428, 258)
        Me.chkpotencia.Name = "chkpotencia"
        Me.chkpotencia.Size = New System.Drawing.Size(85, 23)
        Me.chkpotencia.TabIndex = 53
        Me.chkpotencia.Text = "Potencia"
        Me.chkpotencia.UseVisualStyleBackColor = True
        '
        'chkSuma
        '
        Me.chkSuma.AutoSize = True
        Me.chkSuma.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSuma.Location = New System.Drawing.Point(428, 79)
        Me.chkSuma.Name = "chkSuma"
        Me.chkSuma.Size = New System.Drawing.Size(65, 23)
        Me.chkSuma.TabIndex = 48
        Me.chkSuma.Text = "Suma"
        Me.chkSuma.UseVisualStyleBackColor = True
        '
        'chkraiz
        '
        Me.chkraiz.AutoSize = True
        Me.chkraiz.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkraiz.Location = New System.Drawing.Point(428, 217)
        Me.chkraiz.Name = "chkraiz"
        Me.chkraiz.Size = New System.Drawing.Size(58, 23)
        Me.chkraiz.TabIndex = 52
        Me.chkraiz.Text = "Raiz"
        Me.chkraiz.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSalir.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(407, 336)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(124, 53)
        Me.BtnSalir.TabIndex = 47
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'chkResta
        '
        Me.chkResta.AutoSize = True
        Me.chkResta.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResta.Location = New System.Drawing.Point(428, 115)
        Me.chkResta.Name = "chkResta"
        Me.chkResta.Size = New System.Drawing.Size(68, 23)
        Me.chkResta.TabIndex = 49
        Me.chkResta.Text = "Resta"
        Me.chkResta.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLimpiar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Location = New System.Drawing.Point(231, 335)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(127, 54)
        Me.BtnLimpiar.TabIndex = 46
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'chkdivision
        '
        Me.chkdivision.AutoSize = True
        Me.chkdivision.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkdivision.Location = New System.Drawing.Point(428, 183)
        Me.chkdivision.Name = "chkdivision"
        Me.chkdivision.Size = New System.Drawing.Size(83, 23)
        Me.chkdivision.TabIndex = 51
        Me.chkdivision.Text = "Division"
        Me.chkdivision.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(78, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 22)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Resultado"
        '
        'TxtResultado
        '
        Me.TxtResultado.Location = New System.Drawing.Point(212, 197)
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.Size = New System.Drawing.Size(135, 20)
        Me.TxtResultado.TabIndex = 44
        '
        'TxtNumero2
        '
        Me.TxtNumero2.Location = New System.Drawing.Point(211, 140)
        Me.TxtNumero2.Name = "TxtNumero2"
        Me.TxtNumero2.Size = New System.Drawing.Size(136, 20)
        Me.TxtNumero2.TabIndex = 43
        '
        'TxtNumero1
        '
        Me.TxtNumero1.Location = New System.Drawing.Point(210, 82)
        Me.TxtNumero1.Name = "TxtNumero1"
        Me.TxtNumero1.Size = New System.Drawing.Size(138, 20)
        Me.TxtNumero1.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 22)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Numero 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 22)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Numero 1"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCalcular.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.Location = New System.Drawing.Point(68, 336)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(115, 59)
        Me.BtnCalcular.TabIndex = 39
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        '_2_OperacionesBasicas_Potencia_Raiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(612, 479)
        Me.Controls.Add(Me.chkMultiplicacion)
        Me.Controls.Add(Me.chkpotencia)
        Me.Controls.Add(Me.chkSuma)
        Me.Controls.Add(Me.chkraiz)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.chkResta)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.chkdivision)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtResultado)
        Me.Controls.Add(Me.TxtNumero2)
        Me.Controls.Add(Me.TxtNumero1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Name = "_2_OperacionesBasicas_Potencia_Raiz"
        Me.Text = "Operaciones Aritmeticas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkMultiplicacion As CheckBox
    Friend WithEvents chkpotencia As CheckBox
    Friend WithEvents chkSuma As CheckBox
    Friend WithEvents chkraiz As CheckBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents chkResta As CheckBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents chkdivision As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtResultado As TextBox
    Friend WithEvents TxtNumero2 As TextBox
    Friend WithEvents TxtNumero1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCalcular As Button
End Class
