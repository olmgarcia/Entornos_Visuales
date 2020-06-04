<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Volumen
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnIcosaedro = New System.Windows.Forms.Button()
        Me.BtnPrismaRectangular = New System.Windows.Forms.Button()
        Me.BtnPiramide = New System.Windows.Forms.Button()
        Me.BtnCono = New System.Windows.Forms.Button()
        Me.BtnOctaedro = New System.Windows.Forms.Button()
        Me.BtnEsfera = New System.Windows.Forms.Button()
        Me.BtnCilindro = New System.Windows.Forms.Button()
        Me.BtnCubo = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(726, 35)
        Me.Panel1.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(304, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Calcular Volumen"
        '
        'BtnIcosaedro
        '
        Me.BtnIcosaedro.Location = New System.Drawing.Point(410, 357)
        Me.BtnIcosaedro.Name = "BtnIcosaedro"
        Me.BtnIcosaedro.Size = New System.Drawing.Size(213, 43)
        Me.BtnIcosaedro.TabIndex = 22
        Me.BtnIcosaedro.Text = "Icosaedro"
        Me.BtnIcosaedro.UseVisualStyleBackColor = True
        '
        'BtnPrismaRectangular
        '
        Me.BtnPrismaRectangular.Location = New System.Drawing.Point(410, 277)
        Me.BtnPrismaRectangular.Name = "BtnPrismaRectangular"
        Me.BtnPrismaRectangular.Size = New System.Drawing.Size(213, 43)
        Me.BtnPrismaRectangular.TabIndex = 21
        Me.BtnPrismaRectangular.Text = "Prisma Rectangular"
        Me.BtnPrismaRectangular.UseVisualStyleBackColor = True
        '
        'BtnPiramide
        '
        Me.BtnPiramide.Location = New System.Drawing.Point(410, 195)
        Me.BtnPiramide.Name = "BtnPiramide"
        Me.BtnPiramide.Size = New System.Drawing.Size(213, 43)
        Me.BtnPiramide.TabIndex = 20
        Me.BtnPiramide.Text = "Piramide"
        Me.BtnPiramide.UseVisualStyleBackColor = True
        '
        'BtnCono
        '
        Me.BtnCono.Location = New System.Drawing.Point(410, 112)
        Me.BtnCono.Name = "BtnCono"
        Me.BtnCono.Size = New System.Drawing.Size(213, 43)
        Me.BtnCono.TabIndex = 19
        Me.BtnCono.Text = "Cono"
        Me.BtnCono.UseVisualStyleBackColor = True
        '
        'BtnOctaedro
        '
        Me.BtnOctaedro.Location = New System.Drawing.Point(92, 357)
        Me.BtnOctaedro.Name = "BtnOctaedro"
        Me.BtnOctaedro.Size = New System.Drawing.Size(213, 43)
        Me.BtnOctaedro.TabIndex = 18
        Me.BtnOctaedro.Text = "Octaedro"
        Me.BtnOctaedro.UseVisualStyleBackColor = True
        '
        'BtnEsfera
        '
        Me.BtnEsfera.Location = New System.Drawing.Point(92, 277)
        Me.BtnEsfera.Name = "BtnEsfera"
        Me.BtnEsfera.Size = New System.Drawing.Size(213, 43)
        Me.BtnEsfera.TabIndex = 17
        Me.BtnEsfera.Text = "Esfera"
        Me.BtnEsfera.UseVisualStyleBackColor = True
        '
        'BtnCilindro
        '
        Me.BtnCilindro.Location = New System.Drawing.Point(92, 195)
        Me.BtnCilindro.Name = "BtnCilindro"
        Me.BtnCilindro.Size = New System.Drawing.Size(213, 43)
        Me.BtnCilindro.TabIndex = 16
        Me.BtnCilindro.Text = "Cilindro"
        Me.BtnCilindro.UseVisualStyleBackColor = True
        '
        'BtnCubo
        '
        Me.BtnCubo.Location = New System.Drawing.Point(92, 112)
        Me.BtnCubo.Name = "BtnCubo"
        Me.BtnCubo.Size = New System.Drawing.Size(213, 43)
        Me.BtnCubo.TabIndex = 15
        Me.BtnCubo.Text = "Cubo"
        Me.BtnCubo.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(424, 486)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(104, 44)
        Me.BtnRegresar.TabIndex = 14
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(570, 486)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(104, 44)
        Me.BtnSalir.TabIndex = 13
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Frm_Volumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(726, 542)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnIcosaedro)
        Me.Controls.Add(Me.BtnPrismaRectangular)
        Me.Controls.Add(Me.BtnPiramide)
        Me.Controls.Add(Me.BtnCono)
        Me.Controls.Add(Me.BtnOctaedro)
        Me.Controls.Add(Me.BtnEsfera)
        Me.Controls.Add(Me.BtnCilindro)
        Me.Controls.Add(Me.BtnCubo)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Name = "Frm_Volumen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Volumen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnIcosaedro As Button
    Friend WithEvents BtnPrismaRectangular As Button
    Friend WithEvents BtnPiramide As Button
    Friend WithEvents BtnCono As Button
    Friend WithEvents BtnOctaedro As Button
    Friend WithEvents BtnEsfera As Button
    Friend WithEvents BtnCilindro As Button
    Friend WithEvents BtnCubo As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnSalir As Button
End Class
