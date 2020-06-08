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
        Dim numeros As Integer
        Dim par, impar As Integer
        Dim positivo, negativo As Integer
        Dim numDigitos, totalDigitos As Integer
        Dim i, j, cad As Integer

        numeros = Val(Txt_CantNumeros.Text)
        par = Val(Txt_NumPares.Text)
        impar = Val(Txt_NumImpares.Text)
        i = 0
        j = 1
        cad = ""

    End Sub
End Class