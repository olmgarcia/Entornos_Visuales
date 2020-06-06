Public Class GuiaMenuPrincipal
    Private Sub CalculadoraBasicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraBasicaToolStripMenuItem.Click
        Me.Hide()
        GuiaEjercicio1.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim opcion As Integer
        opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub FormulaCuadraticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormulaCuadraticaToolStripMenuItem.Click
        Me.Hide()
        GuiaEjercicio2.Show()
    End Sub

    Private Sub AlmacenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlmacenesToolStripMenuItem.Click
        Me.Hide()
        GuiaEjercicio3.Show()
    End Sub

    Private Sub IdentificarNumerosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IdentificarNumerosToolStripMenuItem.Click
        Me.Hide()
        GuiaEjercicio4.Show()
    End Sub

    Private Sub EmpleosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleosToolStripMenuItem.Click
        Me.Hide()
        GuiaEjercicio5.Show()
    End Sub
End Class