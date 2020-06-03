<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _7_EntregaMascarillas
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
        Me.Cmb_CantDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSolicitar = New System.Windows.Forms.Button()
        Me.Txt_CantDepartamentos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnEntregar = New System.Windows.Forms.Button()
        Me.Txt_CantMunicipios = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cmb_CantDepartamento)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnSolicitar)
        Me.GroupBox1.Controls.Add(Me.Txt_CantDepartamentos)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 296)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cantidad por Departamento"
        '
        'Cmb_CantDepartamento
        '
        Me.Cmb_CantDepartamento.FormattingEnabled = True
        Me.Cmb_CantDepartamento.Location = New System.Drawing.Point(116, 239)
        Me.Cmb_CantDepartamento.Name = "Cmb_CantDepartamento"
        Me.Cmb_CantDepartamento.Size = New System.Drawing.Size(194, 25)
        Me.Cmb_CantDepartamento.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cant por Departamento"
        '
        'BtnSolicitar
        '
        Me.BtnSolicitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSolicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSolicitar.Location = New System.Drawing.Point(116, 127)
        Me.BtnSolicitar.Name = "BtnSolicitar"
        Me.BtnSolicitar.Size = New System.Drawing.Size(97, 48)
        Me.BtnSolicitar.TabIndex = 2
        Me.BtnSolicitar.Text = "Solicitar"
        Me.BtnSolicitar.UseVisualStyleBackColor = False
        '
        'Txt_CantDepartamentos
        '
        Me.Txt_CantDepartamentos.Location = New System.Drawing.Point(186, 63)
        Me.Txt_CantDepartamentos.Multiline = True
        Me.Txt_CantDepartamentos.Name = "Txt_CantDepartamentos"
        Me.Txt_CantDepartamentos.Size = New System.Drawing.Size(124, 29)
        Me.Txt_CantDepartamentos.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad Departamentos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnEntregar)
        Me.GroupBox2.Controls.Add(Me.Txt_CantMunicipios)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(385, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(338, 297)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Destribucion"
        '
        'BtnEntregar
        '
        Me.BtnEntregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEntregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntregar.Location = New System.Drawing.Point(120, 128)
        Me.BtnEntregar.Name = "BtnEntregar"
        Me.BtnEntregar.Size = New System.Drawing.Size(97, 48)
        Me.BtnEntregar.TabIndex = 5
        Me.BtnEntregar.Text = "Entregar"
        Me.BtnEntregar.UseVisualStyleBackColor = False
        '
        'Txt_CantMunicipios
        '
        Me.Txt_CantMunicipios.Location = New System.Drawing.Point(188, 54)
        Me.Txt_CantMunicipios.Multiline = True
        Me.Txt_CantMunicipios.Name = "Txt_CantMunicipios"
        Me.Txt_CantMunicipios.Size = New System.Drawing.Size(124, 29)
        Me.Txt_CantMunicipios.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cantidad Municipios"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Location = New System.Drawing.Point(400, 452)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(97, 48)
        Me.BtnLimpiar.TabIndex = 6
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(626, 452)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(97, 48)
        Me.BtnSalir.TabIndex = 7
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'TxtStock
        '
        Me.TxtStock.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStock.Location = New System.Drawing.Point(599, 388)
        Me.TxtStock.Multiline = True
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(124, 29)
        Me.TxtStock.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(382, 400)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total Mascarillas a Entregar"
        '
        '_7_EntregaMascarillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(759, 530)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "_7_EntregaMascarillas"
        Me.Text = "Entrega Mascarillas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnSolicitar As Button
    Friend WithEvents Txt_CantDepartamentos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Cmb_CantDepartamento As ComboBox
    Friend WithEvents BtnEntregar As Button
    Friend WithEvents Txt_CantMunicipios As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents Label4 As Label
End Class
