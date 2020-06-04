<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Area
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
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnRectangulo = New System.Windows.Forms.Button()
        Me.BtnCirculo = New System.Windows.Forms.Button()
        Me.BtnCuadrado = New System.Windows.Forms.Button()
        Me.BtnTriangulo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(476, 474)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(104, 44)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(332, 474)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(104, 44)
        Me.BtnRegresar.TabIndex = 3
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'BtnRectangulo
        '
        Me.BtnRectangulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnRectangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRectangulo.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRectangulo.Location = New System.Drawing.Point(367, 305)
        Me.BtnRectangulo.Name = "BtnRectangulo"
        Me.BtnRectangulo.Size = New System.Drawing.Size(213, 43)
        Me.BtnRectangulo.TabIndex = 16
        Me.BtnRectangulo.Text = "Rectangulo"
        Me.BtnRectangulo.UseVisualStyleBackColor = False
        '
        'BtnCirculo
        '
        Me.BtnCirculo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCirculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCirculo.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCirculo.Location = New System.Drawing.Point(49, 305)
        Me.BtnCirculo.Name = "BtnCirculo"
        Me.BtnCirculo.Size = New System.Drawing.Size(213, 43)
        Me.BtnCirculo.TabIndex = 15
        Me.BtnCirculo.Text = "Circulo"
        Me.BtnCirculo.UseVisualStyleBackColor = False
        '
        'BtnCuadrado
        '
        Me.BtnCuadrado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCuadrado.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCuadrado.Location = New System.Drawing.Point(367, 190)
        Me.BtnCuadrado.Name = "BtnCuadrado"
        Me.BtnCuadrado.Size = New System.Drawing.Size(213, 43)
        Me.BtnCuadrado.TabIndex = 14
        Me.BtnCuadrado.Text = "Cuadrado"
        Me.BtnCuadrado.UseVisualStyleBackColor = False
        '
        'BtnTriangulo
        '
        Me.BtnTriangulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnTriangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTriangulo.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTriangulo.Location = New System.Drawing.Point(49, 190)
        Me.BtnTriangulo.Name = "BtnTriangulo"
        Me.BtnTriangulo.Size = New System.Drawing.Size(213, 43)
        Me.BtnTriangulo.TabIndex = 13
        Me.BtnTriangulo.Text = "Triangulo"
        Me.BtnTriangulo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Calcular Area "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 18)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Seleccione la opcion que desee!!"
        '
        'Frm_Area
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(628, 545)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRectangulo)
        Me.Controls.Add(Me.BtnCirculo)
        Me.Controls.Add(Me.BtnCuadrado)
        Me.Controls.Add(Me.BtnTriangulo)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Area"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Area"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnRectangulo As Button
    Friend WithEvents BtnCirculo As Button
    Friend WithEvents BtnCuadrado As Button
    Friend WithEvents BtnTriangulo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
