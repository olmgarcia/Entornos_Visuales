<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Area
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
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRectangulo = New System.Windows.Forms.Button()
        Me.BtnCirculo = New System.Windows.Forms.Button()
        Me.BtnCuadrado = New System.Windows.Forms.Button()
        Me.BtnTriangulo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(553, 471)
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
        Me.BtnRegresar.Location = New System.Drawing.Point(409, 471)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(104, 44)
        Me.BtnRegresar.TabIndex = 3
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(695, 35)
        Me.Panel1.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(287, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Calcular Area "
        '
        'BtnRectangulo
        '
        Me.BtnRectangulo.Location = New System.Drawing.Point(386, 281)
        Me.BtnRectangulo.Name = "BtnRectangulo"
        Me.BtnRectangulo.Size = New System.Drawing.Size(213, 43)
        Me.BtnRectangulo.TabIndex = 16
        Me.BtnRectangulo.Text = "Rectangulo"
        Me.BtnRectangulo.UseVisualStyleBackColor = True
        '
        'BtnCirculo
        '
        Me.BtnCirculo.Location = New System.Drawing.Point(68, 281)
        Me.BtnCirculo.Name = "BtnCirculo"
        Me.BtnCirculo.Size = New System.Drawing.Size(213, 43)
        Me.BtnCirculo.TabIndex = 15
        Me.BtnCirculo.Text = "Circulo"
        Me.BtnCirculo.UseVisualStyleBackColor = True
        '
        'BtnCuadrado
        '
        Me.BtnCuadrado.Location = New System.Drawing.Point(386, 166)
        Me.BtnCuadrado.Name = "BtnCuadrado"
        Me.BtnCuadrado.Size = New System.Drawing.Size(213, 43)
        Me.BtnCuadrado.TabIndex = 14
        Me.BtnCuadrado.Text = "Cuadrado"
        Me.BtnCuadrado.UseVisualStyleBackColor = True
        '
        'BtnTriangulo
        '
        Me.BtnTriangulo.Location = New System.Drawing.Point(68, 166)
        Me.BtnTriangulo.Name = "BtnTriangulo"
        Me.BtnTriangulo.Size = New System.Drawing.Size(213, 43)
        Me.BtnTriangulo.TabIndex = 13
        Me.BtnTriangulo.Text = "Triangulo"
        Me.BtnTriangulo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 372)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Label2"
        '
        'Frm_Area
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(695, 538)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnRectangulo)
        Me.Controls.Add(Me.BtnCirculo)
        Me.Controls.Add(Me.BtnCuadrado)
        Me.Controls.Add(Me.BtnTriangulo)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Name = "Frm_Area"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Area"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnRectangulo As Button
    Friend WithEvents BtnCirculo As Button
    Friend WithEvents BtnCuadrado As Button
    Friend WithEvents BtnTriangulo As Button
    Friend WithEvents Label2 As Label
End Class
