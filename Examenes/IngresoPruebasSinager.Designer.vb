<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresoPruebasSinager
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Txt_Edad = New System.Windows.Forms.TextBox()
        Me.Cmb_Deptos = New System.Windows.Forms.ComboBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Chk_Positivo = New System.Windows.Forms.CheckBox()
        Me.Chk_Negativo = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.His = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Dgb_Historial = New System.Windows.Forms.DataGridView()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.Txt_Municipio = New System.Windows.Forms.TextBox()
        Me.Cmb_Estado = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_Recuperados = New System.Windows.Forms.TextBox()
        Me.Txt_Activo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_Muertos = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgb_Historial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(304, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingreso de Pruebas Realizadas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Edad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Departamento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Municipio:"
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Nombre.Location = New System.Drawing.Point(212, 103)
        Me.Txt_Nombre.Multiline = True
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(200, 25)
        Me.Txt_Nombre.TabIndex = 9
        '
        'Txt_Edad
        '
        Me.Txt_Edad.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Edad.Location = New System.Drawing.Point(212, 144)
        Me.Txt_Edad.Multiline = True
        Me.Txt_Edad.Name = "Txt_Edad"
        Me.Txt_Edad.Size = New System.Drawing.Size(70, 22)
        Me.Txt_Edad.TabIndex = 10
        '
        'Cmb_Deptos
        '
        Me.Cmb_Deptos.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Deptos.FormattingEnabled = True
        Me.Cmb_Deptos.Items.AddRange(New Object() {"Seleccione un Departamento", "Atlántida", "Choluteca", "Colón", "Comayagua", "Copán", "Cortés", "El Paraíso", "Francisco Morazán", "Gracias a Dios", "Intibucá", "Islas de la Bahía", "La Paz", "Lempira", "Ocotepeque", "Olancho: Juticalpa", "Santa Bárbara", "Valle", "Yoro"})
        Me.Cmb_Deptos.Location = New System.Drawing.Point(212, 193)
        Me.Cmb_Deptos.Name = "Cmb_Deptos"
        Me.Cmb_Deptos.Size = New System.Drawing.Size(200, 25)
        Me.Cmb_Deptos.TabIndex = 15
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(749, 548)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(104, 50)
        Me.BtnSalir.TabIndex = 16
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 19)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Resultados de Prueba:"
        '
        'Chk_Positivo
        '
        Me.Chk_Positivo.AutoSize = True
        Me.Chk_Positivo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Positivo.Location = New System.Drawing.Point(31, 346)
        Me.Chk_Positivo.Name = "Chk_Positivo"
        Me.Chk_Positivo.Size = New System.Drawing.Size(81, 23)
        Me.Chk_Positivo.TabIndex = 18
        Me.Chk_Positivo.Text = "Positivo"
        Me.Chk_Positivo.UseVisualStyleBackColor = True
        '
        'Chk_Negativo
        '
        Me.Chk_Negativo.AutoSize = True
        Me.Chk_Negativo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Negativo.Location = New System.Drawing.Point(29, 385)
        Me.Chk_Negativo.Name = "Chk_Negativo"
        Me.Chk_Negativo.Size = New System.Drawing.Size(89, 23)
        Me.Chk_Negativo.TabIndex = 19
        Me.Chk_Negativo.Text = "Negativo"
        Me.Chk_Negativo.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(208, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 19)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Estados del Paciente"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(52, 489)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 19)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Breve Descripcion:"
        '
        'Txt_Descripcion
        '
        Me.Txt_Descripcion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Descripcion.Location = New System.Drawing.Point(56, 521)
        Me.Txt_Descripcion.Multiline = True
        Me.Txt_Descripcion.Name = "Txt_Descripcion"
        Me.Txt_Descripcion.Size = New System.Drawing.Size(372, 77)
        Me.Txt_Descripcion.TabIndex = 25
        '
        'His
        '
        Me.His.AutoSize = True
        Me.His.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.His.Location = New System.Drawing.Point(462, 94)
        Me.His.Name = "His"
        Me.His.Size = New System.Drawing.Size(72, 19)
        Me.His.TabIndex = 27
        Me.His.Text = "Historial:"
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Location = New System.Drawing.Point(466, 548)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(104, 50)
        Me.BtnAgregar.TabIndex = 28
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Dgb_Historial
        '
        Me.Dgb_Historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgb_Historial.Location = New System.Drawing.Point(444, 129)
        Me.Dgb_Historial.Name = "Dgb_Historial"
        Me.Dgb_Historial.Size = New System.Drawing.Size(536, 308)
        Me.Dgb_Historial.TabIndex = 29
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Location = New System.Drawing.Point(613, 548)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(104, 50)
        Me.BtnLimpiar.TabIndex = 30
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'Txt_Municipio
        '
        Me.Txt_Municipio.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Municipio.Location = New System.Drawing.Point(212, 246)
        Me.Txt_Municipio.Multiline = True
        Me.Txt_Municipio.Name = "Txt_Municipio"
        Me.Txt_Municipio.Size = New System.Drawing.Size(200, 22)
        Me.Txt_Municipio.TabIndex = 31
        '
        'Cmb_Estado
        '
        Me.Cmb_Estado.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Estado.FormattingEnabled = True
        Me.Cmb_Estado.Items.AddRange(New Object() {"Activo", "Recuperado", "Muerto"})
        Me.Cmb_Estado.Location = New System.Drawing.Point(212, 346)
        Me.Cmb_Estado.Name = "Cmb_Estado"
        Me.Cmb_Estado.Size = New System.Drawing.Size(149, 27)
        Me.Cmb_Estado.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(453, 452)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 19)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Recuperados"
        '
        'Txt_Recuperados
        '
        Me.Txt_Recuperados.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Recuperados.Location = New System.Drawing.Point(457, 486)
        Me.Txt_Recuperados.Multiline = True
        Me.Txt_Recuperados.Name = "Txt_Recuperados"
        Me.Txt_Recuperados.Size = New System.Drawing.Size(128, 22)
        Me.Txt_Recuperados.TabIndex = 34
        '
        'Txt_Activo
        '
        Me.Txt_Activo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Activo.Location = New System.Drawing.Point(627, 486)
        Me.Txt_Activo.Multiline = True
        Me.Txt_Activo.Name = "Txt_Activo"
        Me.Txt_Activo.Size = New System.Drawing.Size(128, 22)
        Me.Txt_Activo.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(623, 452)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 19)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Activo"
        '
        'Txt_Muertos
        '
        Me.Txt_Muertos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Muertos.Location = New System.Drawing.Point(795, 486)
        Me.Txt_Muertos.Multiline = True
        Me.Txt_Muertos.Name = "Txt_Muertos"
        Me.Txt_Muertos.Size = New System.Drawing.Size(128, 22)
        Me.Txt_Muertos.TabIndex = 38
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(791, 452)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 19)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Muertos"
        '
        'IngresoPruebasSinager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 630)
        Me.Controls.Add(Me.Txt_Muertos)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Txt_Activo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Txt_Recuperados)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Cmb_Estado)
        Me.Controls.Add(Me.Txt_Municipio)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.Dgb_Historial)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.His)
        Me.Controls.Add(Me.Txt_Descripcion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Chk_Negativo)
        Me.Controls.Add(Me.Chk_Positivo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Cmb_Deptos)
        Me.Controls.Add(Me.Txt_Edad)
        Me.Controls.Add(Me.Txt_Nombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "IngresoPruebasSinager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Positivo"
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgb_Historial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_Nombre As TextBox
    Friend WithEvents Txt_Edad As TextBox
    Friend WithEvents Cmb_Deptos As ComboBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Chk_Positivo As CheckBox
    Friend WithEvents Chk_Negativo As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_Descripcion As TextBox
    Friend WithEvents His As Label
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Dgb_Historial As DataGridView
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents Txt_Municipio As TextBox
    Friend WithEvents Cmb_Estado As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_Recuperados As TextBox
    Friend WithEvents Txt_Muertos As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Txt_Activo As TextBox
    Friend WithEvents Label10 As Label
End Class
