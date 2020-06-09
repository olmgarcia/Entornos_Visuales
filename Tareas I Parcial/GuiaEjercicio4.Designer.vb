<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuiaEjercicio4
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
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbNumeros = New System.Windows.Forms.ComboBox()
        Me.Txt_NumPares = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_NumImpares = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_NumPositivos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_TotalNumeros = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnAnalizar = New System.Windows.Forms.Button()
        Me.Txt_CantNumeros = New System.Windows.Forms.TextBox()
        Me.Txt_NumNegativos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(355, 504)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(104, 44)
        Me.BtnRegresar.TabIndex = 7
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(499, 504)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(104, 44)
        Me.BtnSalir.TabIndex = 6
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(206, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 26)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Identificar Numeros"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(75, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Ingrese un Numero"
        '
        'CmbNumeros
        '
        Me.CmbNumeros.FormattingEnabled = True
        Me.CmbNumeros.Location = New System.Drawing.Point(258, 387)
        Me.CmbNumeros.Name = "CmbNumeros"
        Me.CmbNumeros.Size = New System.Drawing.Size(167, 21)
        Me.CmbNumeros.TabIndex = 34
        '
        'Txt_NumPares
        '
        Me.Txt_NumPares.Location = New System.Drawing.Point(258, 158)
        Me.Txt_NumPares.Multiline = True
        Me.Txt_NumPares.Name = "Txt_NumPares"
        Me.Txt_NumPares.Size = New System.Drawing.Size(167, 21)
        Me.Txt_NumPares.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Numeros Pares" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Txt_NumImpares
        '
        Me.Txt_NumImpares.Location = New System.Drawing.Point(258, 203)
        Me.Txt_NumImpares.Multiline = True
        Me.Txt_NumImpares.Name = "Txt_NumImpares"
        Me.Txt_NumImpares.Size = New System.Drawing.Size(167, 21)
        Me.Txt_NumImpares.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(75, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 17)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Numeros Impares"
        '
        'Txt_NumPositivos
        '
        Me.Txt_NumPositivos.Location = New System.Drawing.Point(258, 246)
        Me.Txt_NumPositivos.Multiline = True
        Me.Txt_NumPositivos.Name = "Txt_NumPositivos"
        Me.Txt_NumPositivos.Size = New System.Drawing.Size(167, 21)
        Me.Txt_NumPositivos.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(75, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 17)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Numeros Positivos"
        '
        'Txt_TotalNumeros
        '
        Me.Txt_TotalNumeros.Location = New System.Drawing.Point(258, 337)
        Me.Txt_TotalNumeros.Multiline = True
        Me.Txt_TotalNumeros.Name = "Txt_TotalNumeros"
        Me.Txt_TotalNumeros.Size = New System.Drawing.Size(167, 21)
        Me.Txt_TotalNumeros.TabIndex = 44
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(94, 456)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 17)
        Me.Label7.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(75, 337)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 17)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Suma Total de Digitos"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Location = New System.Drawing.Point(477, 269)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(104, 44)
        Me.BtnLimpiar.TabIndex = 47
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnAnalizar
        '
        Me.BtnAnalizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnAnalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAnalizar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnalizar.Location = New System.Drawing.Point(477, 180)
        Me.BtnAnalizar.Name = "BtnAnalizar"
        Me.BtnAnalizar.Size = New System.Drawing.Size(104, 44)
        Me.BtnAnalizar.TabIndex = 46
        Me.BtnAnalizar.Text = "Analizar"
        Me.BtnAnalizar.UseVisualStyleBackColor = False
        '
        'Txt_CantNumeros
        '
        Me.Txt_CantNumeros.Location = New System.Drawing.Point(258, 118)
        Me.Txt_CantNumeros.Multiline = True
        Me.Txt_CantNumeros.Name = "Txt_CantNumeros"
        Me.Txt_CantNumeros.Size = New System.Drawing.Size(167, 21)
        Me.Txt_CantNumeros.TabIndex = 48
        '
        'Txt_NumNegativos
        '
        Me.Txt_NumNegativos.Location = New System.Drawing.Point(258, 292)
        Me.Txt_NumNegativos.Multiline = True
        Me.Txt_NumNegativos.Name = "Txt_NumNegativos"
        Me.Txt_NumNegativos.Size = New System.Drawing.Size(167, 21)
        Me.Txt_NumNegativos.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(75, 292)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 17)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Numeros Negativos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 387)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 17)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Listado de Numeros"
        '
        'GuiaEjercicio4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(635, 587)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txt_NumNegativos)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Txt_CantNumeros)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnAnalizar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Txt_TotalNumeros)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Txt_NumPositivos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txt_NumImpares)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txt_NumPares)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbNumeros)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GuiaEjercicio4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GuiaEjercicio4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbNumeros As ComboBox
    Friend WithEvents Txt_NumPares As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_NumImpares As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_NumPositivos As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_TotalNumeros As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnAnalizar As Button
    Friend WithEvents Txt_CantNumeros As TextBox
    Friend WithEvents Txt_NumNegativos As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
End Class
