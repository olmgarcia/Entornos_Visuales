Imports System.ComponentModel

Public Class Frm_VolumenCubo
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        Dim valor As Int16
        If Txt_Arista.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(Txt_Arista.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            Txt_Arista.Text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(Txt_Arista.Text)
            If valor = 0 Then
                MsgBox("Numero cero", vbInformation)
            ElseIf valor < 0 Then
                MsgBox("Numero negativo")
            End If
        End If
        Dim arista, volumen As Integer

        arista = Val(Txt_Arista.Text)

        volumen = (arista) ^ 3
        Txt_Volumen.Text = (volumen)

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

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Txt_Arista.Clear()
        Txt_Volumen.Clear()
    End Sub

    Private Sub Txt_Arista_TextChanged(sender As Object, e As EventArgs) Handles Txt_Arista.TextChanged

    End Sub

    Private Sub Txt_Arista_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Arista.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub Txt_Arista_MouseHover(sender As Object, e As EventArgs) Handles Txt_Arista.MouseHover
        ToolTip.SetToolTip(Txt_Arista, "Ingrese la Arista")
        ToolTip.ToolTipTitle = "Arista"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class