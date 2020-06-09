<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GuiaEjercicio3
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
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.Txt_Promedio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Ventas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(319, 547)
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
        Me.BtnSalir.Location = New System.Drawing.Point(463, 547)
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
        Me.Label2.Location = New System.Drawing.Point(235, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 26)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Almacenes"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_Ventas)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox1.Controls.Add(Me.Txt_Promedio)
        Me.GroupBox1.Controls.Add(Me.BtnCalcular)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(46, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 320)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Almacenes:"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Location = New System.Drawing.Point(290, 238)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(104, 44)
        Me.BtnLimpiar.TabIndex = 50
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalcular.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.Location = New System.Drawing.Point(101, 238)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(104, 44)
        Me.BtnCalcular.TabIndex = 49
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'Txt_Promedio
        '
        Me.Txt_Promedio.Location = New System.Drawing.Point(240, 70)
        Me.Txt_Promedio.Multiline = True
        Me.Txt_Promedio.Name = "Txt_Promedio"
        Me.Txt_Promedio.Size = New System.Drawing.Size(137, 28)
        Me.Txt_Promedio.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(103, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Promedio"
        '
        'Txt_Ventas
        '
        Me.Txt_Ventas.Location = New System.Drawing.Point(240, 148)
        Me.Txt_Ventas.Multiline = True
        Me.Txt_Ventas.Name = "Txt_Ventas"
        Me.Txt_Ventas.Size = New System.Drawing.Size(137, 28)
        Me.Txt_Ventas.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Ventas"
        '
        'GuiaEjercicio3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(594, 614)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GuiaEjercicio3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GuiaEjercicio3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents Txt_Promedio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_Ventas As TextBox
    Friend WithEvents Label1 As Label
End Class
