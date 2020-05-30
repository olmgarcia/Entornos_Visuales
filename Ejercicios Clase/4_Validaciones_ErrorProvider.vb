Imports System.ComponentModel

Public Class _4_Validaciones_ErrorProvider
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub BtnValidar_Click(sender As Object, e As EventArgs) Handles BtnValidar.Click
        'try catch
        'ValidateChildren Botton
        'Validating Cajas de texto
        Try
            'Si las casillas estan sin ningun valor
            If Me.ValidateChildren And Txt_Producto.Text <> String.Empty And Txt_Precio.Text <> String.Empty And Val(Txt_Cantidad.Text) - Int(Val(Txt_Cantidad.Text)) = 0 Then
                MessageBox.Show("Producto Ingresado", "Formulario Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            MessageBox.Show("Revise los datos Ingresados", "Error en Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Txt_Producto_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Producto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub Txt_Precio_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Precio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese un precio")
        End If
    End Sub

    Private Sub Txt_Cantidad_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Cantidad.Validating
        If Val(Txt_Cantidad.Text) - Int(Val(Txt_Cantidad.Text)) = 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese un numero entero")
        End If
    End Sub

    Private Sub Txt_Producto_MouseHover(sender As Object, e As EventArgs) Handles Txt_Producto.MouseHover
        ToolTip.SetToolTip(Txt_Producto, "Ingrese un producto")
        ToolTip.ToolTipTitle = "Producto"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Txt_Precio_MouseHover(sender As Object, e As EventArgs) Handles Txt_Precio.MouseHover
        ToolTip.SetToolTip(Txt_Descripcion, "Ingrese un Precio")
        ToolTip.ToolTipTitle = "Precio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub Txt_Cantidad_MouseHover(sender As Object, e As EventArgs) Handles Txt_Cantidad.MouseHover
        ToolTip.SetToolTip(Txt_Cantidad, "Ingrese una cantidad (Entero)")
        ToolTip.ToolTipTitle = "Cantidad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Txt_Descripcion_MouseHover(sender As Object, e As EventArgs) Handles Txt_Descripcion.MouseHover
        ToolTip.SetToolTip(Txt_Descripcion, "Ingrese una descripcion")
        ToolTip.ToolTipTitle = "Descripcion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

End Class