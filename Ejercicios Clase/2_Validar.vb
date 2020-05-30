Public Class _2_Validar
    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        Dim itemId As Integer
        Dim itemNombre As String

        itemId = Cmb_Equipos.SelectedIndex
        itemNombre = Cmb_Equipos.SelectedItem.ToString

        Select Case itemId
            Case 0
                MsgBox(itemNombre)
            Case 1
                MsgBox(itemNombre)
            Case 2
                MsgBox(itemNombre)
            Case 3
                MsgBox(itemNombre)
            Case 4
                MsgBox(itemNombre)
            Case 5
                MsgBox(itemNombre)
            Case Else
                MsgBox("Seleccione un valor correcto")
        End Select
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Cmb_Equipos.Text = Nothing
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End

    End Sub
End Class