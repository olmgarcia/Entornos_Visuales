Public Class _1_Suma
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim suma As Integer
        Dim valor1 As Integer
        Dim valor2 As Integer

        valor1 = Val(TxtNumero1.Text)
        valor2 = Val(TxtNumero2.Text)

        suma = valor1 + valor2
        TxtResultado.Text = suma
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtNumero1.Clear()
        TxtNumero2.Clear()
        TxtResultado.Clear()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End

    End Sub
End Class