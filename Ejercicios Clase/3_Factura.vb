Public Class _3_Factura
    Private Sub _3_Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        Dim pUnitario, cantidad As Integer
        Dim descuento, subTotal, total As Double
        Dim aplicaDescuento As Boolean

        pUnitario = Val(txtPunitario.Text)
        cantidad = Val(txtCantidad.Text)

        'chk Descuento.Checked= false 
        aplicaDescuento = Chk_AplicarDescuento.Checked
        descuento = 0
        subTotal = pUnitario * cantidad
        If aplicaDescuento = True Then
            descuento = subTotal * 0.05
        End If

        total = subTotal - descuento
        Txt_Subtotal.Text = subTotal
        Txt_Descuento.Text = descuento
        Txt_Total.Text = total

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End

    End Sub
End Class