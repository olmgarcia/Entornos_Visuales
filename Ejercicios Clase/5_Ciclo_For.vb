Public Class _5_Ciclo_For


    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dim opcion As Integer
        opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        Dim suma, resta, multiplicacion, valor As Integer
        Dim division As Double

        valor = Val(Txt_Ingresar.Text)

        For i = 1 To 10 Step 1
            suma = valor + i
            resta = valor - i
            multiplicacion = valor * i
            division = Format((valor / i).ToString, 2)

            Cmb_Suma.Items.Add(valor & " + " & i & " = " & suma)
            Cmb_Resta.Items.Add(valor & " - " & i & " = " & resta)
            Cmb_Multiplicacion.Items.Add(valor & " * " & i & " = " & multiplicacion)
            Cmb_Division.Items.Add(valor & " / " & i & " = " & division)

        Next
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim Valor As Integer
        Valor = InputBox("Ingrese Numero", "Ingreso")
        Txt_Ingresar.Text = Valor
    End Sub
End Class