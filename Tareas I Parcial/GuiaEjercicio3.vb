Public Class GuiaEjercicio3
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

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click

        Txt_Promedio.Clear()
        Txt_Ventas.Clear()

    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        Dim numeroAlmacenes As Integer
        Dim ventas, sumaVentas, ventaMasAlta, mediaVentas As Double

        numeroAlmacenes = 10
        sumaVentas = 0
        ventaMasAlta = 0

        For i = 1 To numeroAlmacenes Step 1
            ventas = InputBox("Usted debe Ingresar Ventas del Almacen " & i, "Registro de Ventas")
            sumaVentas = sumaVentas + ventas
            If (ventas > ventaMasAlta) Then
                ventaMasAlta = ventas
            End If
        Next
        mediaVentas = sumaVentas / numeroAlmacenes

        Txt_Promedio.Text = mediaVentas
        Txt_Ventas.Text = ventaMasAlta

    End Sub
End Class