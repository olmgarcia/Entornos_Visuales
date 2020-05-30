<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _5_Ciclo_For
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_Ingresar = New System.Windows.Forms.TextBox()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Cmb_Division = New System.Windows.Forms.ComboBox()
        Me.Cmb_Multiplicacion = New System.Windows.Forms.ComboBox()
        Me.Cmb_Resta = New System.Windows.Forms.ComboBox()
        Me.Cmb_Suma = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_Ingresar)
        Me.GroupBox1.Controls.Add(Me.BtnIngresar)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(44, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 103)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar Valor"
        '
        'Txt_Ingresar
        '
        Me.Txt_Ingresar.Location = New System.Drawing.Point(113, 38)
        Me.Txt_Ingresar.Multiline = True
        Me.Txt_Ingresar.Name = "Txt_Ingresar"
        Me.Txt_Ingresar.Size = New System.Drawing.Size(124, 25)
        Me.Txt_Ingresar.TabIndex = 5
        '
        'BtnIngresar
        '
        Me.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIngresar.Location = New System.Drawing.Point(16, 38)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(84, 32)
        Me.BtnIngresar.TabIndex = 2
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnSalir)
        Me.GroupBox2.Controls.Add(Me.BtnCalcular)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(44, 151)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 109)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Location = New System.Drawing.Point(133, 37)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(88, 32)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalcular.Location = New System.Drawing.Point(15, 37)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(82, 32)
        Me.BtnCalcular.TabIndex = 3
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Cmb_Division)
        Me.GroupBox3.Controls.Add(Me.Cmb_Multiplicacion)
        Me.GroupBox3.Controls.Add(Me.Cmb_Resta)
        Me.GroupBox3.Controls.Add(Me.Cmb_Suma)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(44, 287)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(352, 216)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resultado"
        '
        'Cmb_Division
        '
        Me.Cmb_Division.FormattingEnabled = True
        Me.Cmb_Division.Location = New System.Drawing.Point(197, 158)
        Me.Cmb_Division.Name = "Cmb_Division"
        Me.Cmb_Division.Size = New System.Drawing.Size(132, 25)
        Me.Cmb_Division.TabIndex = 7
        Me.Cmb_Division.Text = "Mostrar Division"
        '
        'Cmb_Multiplicacion
        '
        Me.Cmb_Multiplicacion.FormattingEnabled = True
        Me.Cmb_Multiplicacion.Location = New System.Drawing.Point(16, 158)
        Me.Cmb_Multiplicacion.Name = "Cmb_Multiplicacion"
        Me.Cmb_Multiplicacion.Size = New System.Drawing.Size(141, 25)
        Me.Cmb_Multiplicacion.TabIndex = 6
        Me.Cmb_Multiplicacion.Text = "Mostrar Multiplicacion"
        '
        'Cmb_Resta
        '
        Me.Cmb_Resta.FormattingEnabled = True
        Me.Cmb_Resta.Location = New System.Drawing.Point(197, 65)
        Me.Cmb_Resta.Name = "Cmb_Resta"
        Me.Cmb_Resta.Size = New System.Drawing.Size(132, 25)
        Me.Cmb_Resta.TabIndex = 5
        Me.Cmb_Resta.Text = "Mostrar Resta"
        '
        'Cmb_Suma
        '
        Me.Cmb_Suma.FormattingEnabled = True
        Me.Cmb_Suma.Location = New System.Drawing.Point(15, 65)
        Me.Cmb_Suma.Name = "Cmb_Suma"
        Me.Cmb_Suma.Size = New System.Drawing.Size(142, 25)
        Me.Cmb_Suma.TabIndex = 1
        Me.Cmb_Suma.Text = "Mostrar Suma"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(194, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Division"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Multiplicacion "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(191, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Resta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Suma"
        '
        '_5_Ciclo_For
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(482, 524)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "_5_Ciclo_For"
        Me.Text = "Ciclo For"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Txt_Ingresar As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Cmb_Division As ComboBox
    Friend WithEvents Cmb_Multiplicacion As ComboBox
    Friend WithEvents Cmb_Resta As ComboBox
    Friend WithEvents Cmb_Suma As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
