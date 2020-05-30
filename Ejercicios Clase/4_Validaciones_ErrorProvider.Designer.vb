<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _4_Validaciones_ErrorProvider
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_Producto = New System.Windows.Forms.TextBox()
        Me.Txt_Cantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Precio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.BtnValidar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.errorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_Producto)
        Me.GroupBox1.Controls.Add(Me.Txt_Cantidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Txt_Precio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_Descripcion)
        Me.GroupBox1.Controls.Add(Me.lbl5)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(61, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 317)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PRODUCTO"
        '
        'Txt_Producto
        '
        Me.Txt_Producto.Location = New System.Drawing.Point(130, 41)
        Me.Txt_Producto.Multiline = True
        Me.Txt_Producto.Name = "Txt_Producto"
        Me.Txt_Producto.Size = New System.Drawing.Size(233, 25)
        Me.Txt_Producto.TabIndex = 6
        '
        'Txt_Cantidad
        '
        Me.Txt_Cantidad.Location = New System.Drawing.Point(130, 143)
        Me.Txt_Cantidad.Multiline = True
        Me.Txt_Cantidad.Name = "Txt_Cantidad"
        Me.Txt_Cantidad.Size = New System.Drawing.Size(136, 25)
        Me.Txt_Cantidad.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto"
        '
        'Txt_Precio
        '
        Me.Txt_Precio.Location = New System.Drawing.Point(130, 92)
        Me.Txt_Precio.Multiline = True
        Me.Txt_Precio.Name = "Txt_Precio"
        Me.Txt_Precio.Size = New System.Drawing.Size(136, 25)
        Me.Txt_Precio.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Precio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad"
        '
        'Txt_Descripcion
        '
        Me.Txt_Descripcion.Location = New System.Drawing.Point(130, 192)
        Me.Txt_Descripcion.Multiline = True
        Me.Txt_Descripcion.Name = "Txt_Descripcion"
        Me.Txt_Descripcion.Size = New System.Drawing.Size(233, 83)
        Me.Txt_Descripcion.TabIndex = 5
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Location = New System.Drawing.Point(26, 195)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(86, 17)
        Me.lbl5.TabIndex = 3
        Me.lbl5.Text = "Descripcion"
        '
        'BtnValidar
        '
        Me.BtnValidar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnValidar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValidar.Location = New System.Drawing.Point(101, 390)
        Me.BtnValidar.Name = "BtnValidar"
        Me.BtnValidar.Size = New System.Drawing.Size(82, 49)
        Me.BtnValidar.TabIndex = 10
        Me.BtnValidar.Text = "Validar"
        Me.BtnValidar.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(289, 390)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(82, 49)
        Me.BtnSalir.TabIndex = 12
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'errorValidacion
        '
        Me.errorValidacion.ContainerControl = Me
        '
        '_4_Validaciones_ErrorProvider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(596, 518)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnValidar)
        Me.Name = "_4_Validaciones_ErrorProvider"
        Me.Text = "Validaciones ErrorProvider"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txt_Producto As TextBox
    Friend WithEvents Txt_Cantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Precio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_Descripcion As TextBox
    Friend WithEvents lbl5 As Label
    Friend WithEvents BtnValidar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents errorValidacion As ErrorProvider
End Class
