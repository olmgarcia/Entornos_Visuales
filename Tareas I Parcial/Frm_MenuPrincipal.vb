Public Class Frm_MenuPrincipal
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        Dim opcion As Integer
        opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            End

        End If

    End Sub

    Private Sub AreasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AreasToolStripMenuItem.Click
        Me.Hide()
        Frm_Area.Show()

    End Sub

    Private Sub Frm_MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PerimetrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerimetrosToolStripMenuItem.Click
        Me.Hide()
        Frm_Volumen.Show()

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class