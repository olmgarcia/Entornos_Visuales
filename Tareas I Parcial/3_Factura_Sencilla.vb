Public Class _3_Factura_Sencilla
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        Dim PrecioUnitario, Cantidad As Integer
        Dim SubtotalDescuento, SubtotalImpuesto, Descuento, Total, Impuesto As Double

        If Txt_PrecioUnitario.Text = "" Then
            MsgBox("Escriba un Precio Unitario", vbInformation)
        ElseIf Not IsNumeric(Txt_PrecioUnitario.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            Txt_PrecioUnitario.Text = ""
        ElseIf Txt_Cantidad.Text = "" Then
            MsgBox("Escriba la Cantidad del Producto", vbInformation)
        ElseIf Not IsNumeric(Txt_Cantidad.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            Txt_Cantidad.Text = ""
        End If

        PrecioUnitario = Val(Txt_PrecioUnitario.Text)
        Cantidad = Val(Txt_Cantidad.Text)

        Descuento = 0
        SubtotalDescuento = PrecioUnitario * Cantidad

        If Chk_AplicarDescuento.Checked Then
            If Cbo_AplicaDescuento.SelectedIndex = 0 Then
                Descuento = SubtotalDescuento * 0.2
            ElseIf Cbo_AplicaDescuento.SelectedIndex = 1 Then
                Descuento = SubtotalDescuento * 0.3
            ElseIf Cbo_AplicaDescuento.SelectedIndex = 2 Then
                Descuento = SubtotalDescuento * 0.4
            ElseIf Cbo_AplicaDescuento.SelectedIndex = 3 Then
                Descuento = SubtotalDescuento * 0.5
            ElseIf Cbo_AplicaDescuento.SelectedIndex = 4 Then
                Descuento = SubtotalDescuento * 0.6
            ElseIf Cbo_AplicaDescuento.SelectedIndex = 5 Then
                Descuento = SubtotalDescuento * 0.8
            End If

            Total = SubtotalDescuento - Descuento
            Txt_Subtotal.Text = SubtotalDescuento
            Txt_Descuento.Text = Descuento
            Txt_Total.Text = Total

        End If

        Impuesto = 0
        SubtotalImpuesto = PrecioUnitario * Cantidad

        If Chk_AplicarISV.Checked Then
            If Cbo_AplicaISV.SelectedIndex = 0 Then
                Impuesto = SubtotalImpuesto * 0.15
            ElseIf Cbo_AplicaISV.SelectedIndex = 1 Then
                Impuesto = SubtotalImpuesto * 0.17
            End If

            Total = SubtotalImpuesto + Impuesto
            Txt_Subtotal.Text = SubtotalImpuesto
            Txt_Impuesto.Text = Impuesto
            Txt_Total.Text = Total

        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        If Txt_Subtotal.Text = "" Then
            MsgBox("Usted debe realizar un Calculo", vbInformation)
        Else
            If Txt_Subtotal.Text <> "" Then
                Txt_PrecioUnitario.Clear()
                Txt_Cantidad.Clear()
                Chk_AplicarDescuento.Enabled = True
                Chk_AplicarDescuento.Checked = False
                Cbo_AplicaDescuento.Text = ""
                Chk_AplicarISV.Enabled = True
                Chk_AplicarISV.Checked = False
                Cbo_AplicaISV.Text = ""
                Cbo_AplicaDescuento.Enabled = False
                Cbo_AplicaISV.Enabled = False

                Txt_Subtotal.Clear()
                Txt_Descuento.Clear()
                Txt_Impuesto.Clear()
                Txt_Total.Clear()
            End If
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub Chk_AplicarISV_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_AplicarISV.CheckedChanged
        If Chk_AplicarISV.Checked Then
            Cbo_AplicaISV.Enabled = True
            Chk_AplicarDescuento.Enabled = False
        End If
    End Sub

    Private Sub Chk_AplicarDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_AplicarDescuento.CheckedChanged
        If Chk_AplicarDescuento.Checked Then
            Cbo_AplicaDescuento.Enabled = True
            Chk_AplicarISV.Enabled = False
        End If
    End Sub
End Class