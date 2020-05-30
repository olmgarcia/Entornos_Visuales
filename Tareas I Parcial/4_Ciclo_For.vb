Public Class _4_Ciclo_For
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        Lst_Tabla.Items.Clear()
        Dim valor As Integer

        If Txt_Numero.Text = "" Then
            MsgBox("Usted debe Ingresar un Numero", vbInformation)
        Else
            valor = Val(Txt_Numero.Text)

            For a = 1 To 10
                Lst_Tabla.Items.Add(valor & " * " & a & " = " & valor * a)
            Next
        End If

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Txt_Numero.Clear()
        Lst_Tabla.Items.Clear()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End

    End Sub
End Class