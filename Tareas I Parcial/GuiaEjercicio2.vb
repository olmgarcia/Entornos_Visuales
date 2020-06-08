Public Class GuiaEjercicio2

    Dim a, b, c As String
    Dim valor1, valor2 As Double

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Txt_ValorA.Clear()
        Txt_ValorB.Clear()
        Txt_ValorC.Clear()
        Txt_ValorX1.Clear()
        Txt_ValorX2.Clear()

    End Sub

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

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        a = Val(Txt_ValorA.Text)
        b = Val(Txt_ValorB.Text)
        c = Val(Txt_ValorC.Text)

        If Txt_ValorA.Text = "" Then
            MsgBox("Digite un valor para la variable A", vbInformation)
        ElseIf Txt_ValorB.Text = "" Then
            MsgBox("Digite un valor para la variable B", vbInformation)
        ElseIf Txt_ValorC.Text = "" Then
            MsgBox("Digite un valor para la variable C", vbInformation)
        Else
            valor1 = (((b * (-1)) + (((b ^ 2) - (4 * (a * c))) ^ (1 / 2))) / (2 * a))
            valor2 = (((b * (-1)) - (((b ^ 2) - (4 * (a * c))) ^ (1 / 2))) / (2 * a))
        End If

        Txt_ValorX1.Text = valor1
        Txt_ValorX2.Text = valor2

    End Sub
End Class