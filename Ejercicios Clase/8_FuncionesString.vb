Public Class _8_FuncionesString
    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click

        Dim cadena As String
        cadena = Txt_Cadena.Text
        'length, retorna las posiciones deuna cadena incluye los espacios
        Txt_Longitud.Text = cadena.Length

        Txt_UltimCaracter.Text = cadena.Substring(cadena.Length - 1, 1)
        Txt_PrimeCaracter.Text = cadena.Substring(0, 1)
        Txt_3a8.Text = cadena.Substring(2, 7)
        Txt_PosicionB.Text = cadena.IndexOf("B", 0) + 1
        Txt_Mayusculas.Text = cadena.ToUpper
        Txt_Minusculas.Text = cadena.ToLower
        Txt_BorrarEspacios.Text = cadena.Replace(" ", "")

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End

    End Sub
End Class