Public Class GuiaEjercicio4
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dim opcion As Integer
        opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        GuiaMenuPrincipal.Show()
    End Sub

    Private Sub BtnAnalizar_Click(sender As Object, e As EventArgs) Handles BtnAnalizar.Click
        Dim Numero, NumerosPar, NumerosImpar, NumerosPositivos, NumerosNegativos, SumaTotal, CantNumeros As Integer

        CantNumeros = Val(Txt_CantNumeros.Text)
        If Txt_CantNumeros.Text <> "" Then
            For i = 1 To CantNumeros Step 1
                Numero = InputBox("Ingrese un numero", "Ingreso de valores")

                CmbNumeros.Items.Add(Numero)

                If Numero = Int(Numero / 2) * 2 Then
                    NumerosPar = NumerosPar + 1
                Else
                    NumerosImpar = NumerosImpar + 1
                End If

                If Numero < 0 Then
                    NumerosNegativos = NumerosNegativos + 1
                Else
                    NumerosPositivos = NumerosPositivos + 1
                End If

                SumaTotal = SumaTotal + Numero
            Next
        Else
            MsgBox("Debe Inresar una Cantidad de Numeros", vbInformation)
        End If

        Txt_NumPares.Text = NumerosPar
        Txt_NumImpares.Text = NumerosImpar
        Txt_NumPositivos.Text = NumerosPositivos
        Txt_NumNegativos.Text = NumerosNegativos
        Txt_TotalNumeros.Text = SumaTotal
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Txt_CantNumeros.Clear()
        Txt_NumPares.Clear()
        Txt_NumImpares.Clear()
        Txt_NumPositivos.Clear()
        Txt_NumNegativos.Clear()
        Txt_TotalNumeros.Clear()
        CmbNumeros.Items.Clear()
    End Sub
End Class