<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _3_Factura_Sencilla
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Txt_Total = New System.Windows.Forms.TextBox()
        Me.Txt_Impuesto = New System.Windows.Forms.TextBox()
        Me.Txt_Descuento = New System.Windows.Forms.TextBox()
        Me.Txt_Subtotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cbo_AplicaISV = New System.Windows.Forms.ComboBox()
        Me.Chk_AplicarISV = New System.Windows.Forms.CheckBox()
        Me.Cbo_AplicaDescuento = New System.Windows.Forms.ComboBox()
        Me.Txt_Cantidad = New System.Windows.Forms.TextBox()
        Me.Txt_PrecioUnitario = New System.Windows.Forms.TextBox()
        Me.Chk_AplicarDescuento = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(401, 537)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 15)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Realizado por: Olman Garcia"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Txt_Total)
        Me.GroupBox2.Controls.Add(Me.Txt_Impuesto)
        Me.GroupBox2.Controls.Add(Me.Txt_Descuento)
        Me.GroupBox2.Controls.Add(Me.Txt_Subtotal)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(28, 319)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(286, 218)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Factura"
        '
        'Txt_Total
        '
        Me.Txt_Total.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Total.Location = New System.Drawing.Point(138, 169)
        Me.Txt_Total.Name = "Txt_Total"
        Me.Txt_Total.Size = New System.Drawing.Size(100, 25)
        Me.Txt_Total.TabIndex = 9
        '
        'Txt_Impuesto
        '
        Me.Txt_Impuesto.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Impuesto.Location = New System.Drawing.Point(138, 123)
        Me.Txt_Impuesto.Name = "Txt_Impuesto"
        Me.Txt_Impuesto.Size = New System.Drawing.Size(100, 25)
        Me.Txt_Impuesto.TabIndex = 8
        '
        'Txt_Descuento
        '
        Me.Txt_Descuento.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Descuento.Location = New System.Drawing.Point(138, 76)
        Me.Txt_Descuento.Name = "Txt_Descuento"
        Me.Txt_Descuento.Size = New System.Drawing.Size(100, 25)
        Me.Txt_Descuento.TabIndex = 7
        '
        'Txt_Subtotal
        '
        Me.Txt_Subtotal.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Subtotal.Location = New System.Drawing.Point(138, 33)
        Me.Txt_Subtotal.Name = "Txt_Subtotal"
        Me.Txt_Subtotal.Size = New System.Drawing.Size(100, 25)
        Me.Txt_Subtotal.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "ISV "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Descuento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Subtotal"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(359, 220)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(110, 39)
        Me.BtnSalir.TabIndex = 15
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(359, 125)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(110, 39)
        Me.BtnNuevo.TabIndex = 14
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalcular.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.Location = New System.Drawing.Point(359, 60)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(110, 39)
        Me.BtnCalcular.TabIndex = 13
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cbo_AplicaISV)
        Me.GroupBox1.Controls.Add(Me.Chk_AplicarISV)
        Me.GroupBox1.Controls.Add(Me.Cbo_AplicaDescuento)
        Me.GroupBox1.Controls.Add(Me.Txt_Cantidad)
        Me.GroupBox1.Controls.Add(Me.Txt_PrecioUnitario)
        Me.GroupBox1.Controls.Add(Me.Chk_AplicarDescuento)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(27, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(287, 269)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Requeridos"
        '
        'Cbo_AplicaISV
        '
        Me.Cbo_AplicaISV.Enabled = False
        Me.Cbo_AplicaISV.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_AplicaISV.FormattingEnabled = True
        Me.Cbo_AplicaISV.Items.AddRange(New Object() {"15%", "17%"})
        Me.Cbo_AplicaISV.Location = New System.Drawing.Point(23, 232)
        Me.Cbo_AplicaISV.Name = "Cbo_AplicaISV"
        Me.Cbo_AplicaISV.Size = New System.Drawing.Size(115, 25)
        Me.Cbo_AplicaISV.TabIndex = 9
        '
        'Chk_AplicarISV
        '
        Me.Chk_AplicarISV.AutoSize = True
        Me.Chk_AplicarISV.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_AplicarISV.Location = New System.Drawing.Point(24, 197)
        Me.Chk_AplicarISV.Name = "Chk_AplicarISV"
        Me.Chk_AplicarISV.Size = New System.Drawing.Size(102, 21)
        Me.Chk_AplicarISV.TabIndex = 8
        Me.Chk_AplicarISV.Text = "Aplicar ISV"
        Me.Chk_AplicarISV.UseVisualStyleBackColor = True
        '
        'Cbo_AplicaDescuento
        '
        Me.Cbo_AplicaDescuento.Enabled = False
        Me.Cbo_AplicaDescuento.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_AplicaDescuento.FormattingEnabled = True
        Me.Cbo_AplicaDescuento.Items.AddRange(New Object() {"20%", "30%", "40%", "50%", "60%", "80%"})
        Me.Cbo_AplicaDescuento.Location = New System.Drawing.Point(24, 158)
        Me.Cbo_AplicaDescuento.Name = "Cbo_AplicaDescuento"
        Me.Cbo_AplicaDescuento.Size = New System.Drawing.Size(115, 25)
        Me.Cbo_AplicaDescuento.TabIndex = 7
        '
        'Txt_Cantidad
        '
        Me.Txt_Cantidad.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Cantidad.Location = New System.Drawing.Point(139, 80)
        Me.Txt_Cantidad.Name = "Txt_Cantidad"
        Me.Txt_Cantidad.Size = New System.Drawing.Size(100, 25)
        Me.Txt_Cantidad.TabIndex = 1
        '
        'Txt_PrecioUnitario
        '
        Me.Txt_PrecioUnitario.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PrecioUnitario.Location = New System.Drawing.Point(139, 29)
        Me.Txt_PrecioUnitario.Name = "Txt_PrecioUnitario"
        Me.Txt_PrecioUnitario.Size = New System.Drawing.Size(100, 25)
        Me.Txt_PrecioUnitario.TabIndex = 0
        '
        'Chk_AplicarDescuento
        '
        Me.Chk_AplicarDescuento.AutoSize = True
        Me.Chk_AplicarDescuento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chk_AplicarDescuento.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_AplicarDescuento.Location = New System.Drawing.Point(25, 123)
        Me.Chk_AplicarDescuento.Name = "Chk_AplicarDescuento"
        Me.Chk_AplicarDescuento.Size = New System.Drawing.Size(148, 21)
        Me.Chk_AplicarDescuento.TabIndex = 4
        Me.Chk_AplicarDescuento.Text = "Aplicar Descuento"
        Me.Chk_AplicarDescuento.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cantidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Precio Unitario"
        '
        '_3_Factura_Sencilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(577, 555)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "_3_Factura_Sencilla"
        Me.Text = "Factura Sencilla"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Txt_Total As TextBox
    Friend WithEvents Txt_Impuesto As TextBox
    Friend WithEvents Txt_Descuento As TextBox
    Friend WithEvents Txt_Subtotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Cbo_AplicaISV As ComboBox
    Friend WithEvents Chk_AplicarISV As CheckBox
    Friend WithEvents Cbo_AplicaDescuento As ComboBox
    Friend WithEvents Txt_Cantidad As TextBox
    Friend WithEvents Txt_PrecioUnitario As TextBox
    Friend WithEvents Chk_AplicarDescuento As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
