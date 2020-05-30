Public Class _1_Operaciones_Basicas
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim suma As Integer
        Dim resta As Integer
        Dim multiplicacion As Integer
        Dim division As Double

        valor1 = Val(TxtNumero1.Text)
        valor2 = Val(TxtNumero2.Text)

        suma = valor1 + valor2
        resta = valor1 - valor2
        multiplicacion = valor1 * valor2
        division = valor1 / valor2

        TxtSuma.Text = suma
        TxtResta.Text = resta
        TxtMultiplicacion.Text = multiplicacion
        TxtDivision.Text = division

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtNumero1.Clear()
        TxtNumero2.Clear()
        TxtSuma.Clear()
        TxtResta.Clear()
        TxtMultiplicacion.Clear()
        TxtDivision.Clear()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End

    End Sub
End Class