Imports System.ComponentModel

Public Class Frm_VolumenCilindro
    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        Frm_Volumen.Show()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dim opcion As Integer
        opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim valor As Int16
        If Txt_Radio.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(Txt_Radio.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            Txt_Radio.Text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(Txt_Radio.Text)
            If valor = 0 Then
                MsgBox("Numero cero", vbInformation)
            ElseIf valor < 0 Then
                MsgBox("Numero negativo")
            End If
        End If
        Dim radio, altura, volumen As Double

        radio = Val(Txt_Radio.Text)
        altura = Val(Txt_Altura.Text)

        volumen = (3.1416 * (radio ^ 2) * altura)
        Txt_Volumen.Text = (volumen)
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Txt_Radio.Clear()
        Txt_Altura.Clear()
        Txt_Volumen.Clear()

    End Sub

    Private Sub Txt_Radio_TextChanged(sender As Object, e As EventArgs) Handles Txt_Radio.TextChanged

    End Sub

    Private Sub Txt_Radio_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Radio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub Txt_Altura_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Altura.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub Txt_Radio_MouseHover(sender As Object, e As EventArgs) Handles Txt_Radio.MouseHover
        ToolTip.SetToolTip(Txt_Radio, "Ingrese el Radio")
        ToolTip.ToolTipTitle = "Radio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Txt_Altura_TextChanged(sender As Object, e As EventArgs) Handles Txt_Altura.TextChanged

    End Sub

    Private Sub Txt_Altura_MouseHover(sender As Object, e As EventArgs) Handles Txt_Altura.MouseHover
        ToolTip.SetToolTip(Txt_Radio, "Ingrese la Altura")
        ToolTip.ToolTipTitle = "Altura"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class