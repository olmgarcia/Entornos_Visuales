Public Class _6_AcumuladorContador
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub BtnSolicitarNuevo_Click(sender As Object, e As EventArgs) Handles BtnSolicitarNuevo.Click

        Try
            Dim precio, total, totalPagar, orden As Integer

            orden = txtPedido.Text
            For i = 1 To orden Step 1
                precio = InputBox("Ingrsa el precio del platillo N." & i, "Precio del plantillo ")
                'Acumulador: guarda los valores ingresados previamente 
                totalPagar += precio
            Next
            total = totalPagar / orden
            Txt_TotalPagar.Text = total
            Txt_Individual.Text = total

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        txtPedido.Clear()
        Txt_TotalPagar.Clear()
        Txt_Individual.Clear()

    End Sub
End Class