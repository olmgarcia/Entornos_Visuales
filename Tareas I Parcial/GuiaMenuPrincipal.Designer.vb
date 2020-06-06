<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GuiaMenuPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraBasicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormulaCuadraticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlmacenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdentificarNumerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.CalculadoraBasicaToolStripMenuItem, Me.FormulaCuadraticaToolStripMenuItem, Me.AlmacenesToolStripMenuItem, Me.IdentificarNumerosToolStripMenuItem, Me.EmpleosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(747, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(57, 21)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'CalculadoraBasicaToolStripMenuItem
        '
        Me.CalculadoraBasicaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CalculadoraBasicaToolStripMenuItem.Name = "CalculadoraBasicaToolStripMenuItem"
        Me.CalculadoraBasicaToolStripMenuItem.Size = New System.Drawing.Size(144, 21)
        Me.CalculadoraBasicaToolStripMenuItem.Text = "Calculadora Basica"
        '
        'FormulaCuadraticaToolStripMenuItem
        '
        Me.FormulaCuadraticaToolStripMenuItem.Name = "FormulaCuadraticaToolStripMenuItem"
        Me.FormulaCuadraticaToolStripMenuItem.Size = New System.Drawing.Size(148, 21)
        Me.FormulaCuadraticaToolStripMenuItem.Text = "Formula Cuadratica"
        '
        'AlmacenesToolStripMenuItem
        '
        Me.AlmacenesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AlmacenesToolStripMenuItem.Name = "AlmacenesToolStripMenuItem"
        Me.AlmacenesToolStripMenuItem.Size = New System.Drawing.Size(92, 21)
        Me.AlmacenesToolStripMenuItem.Text = "Almacenes"
        '
        'IdentificarNumerosToolStripMenuItem
        '
        Me.IdentificarNumerosToolStripMenuItem.Name = "IdentificarNumerosToolStripMenuItem"
        Me.IdentificarNumerosToolStripMenuItem.Size = New System.Drawing.Size(151, 21)
        Me.IdentificarNumerosToolStripMenuItem.Text = "Identificar Numeros"
        '
        'EmpleosToolStripMenuItem
        '
        Me.EmpleosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmpleosToolStripMenuItem.Name = "EmpleosToolStripMenuItem"
        Me.EmpleosToolStripMenuItem.Size = New System.Drawing.Size(77, 21)
        Me.EmpleosToolStripMenuItem.Text = "Empleos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(49, 21)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GuiaMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(747, 389)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GuiaMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraBasicaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormulaCuadraticaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlmacenesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IdentificarNumerosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
