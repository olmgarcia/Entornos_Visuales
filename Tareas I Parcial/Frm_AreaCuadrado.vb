Imports System.ComponentModel

Public Class Frm_AreaCuadrado
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim valor As Int16
        If Txt_Lado.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(Txt_Lado.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            Txt_Lado.Text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(Txt_Lado.Text)
            If valor = 0 Then
                MsgBox("Numero cero", vbInformation)
            ElseIf valor < 0 Then
                MsgBox("Numero negativo")
            End If
        End If

        Dim lado, area As Integer

        lado = Val(Txt_Lado.Text)

        area = (lado * lado)
        Txt_Area.Text = (area)

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        Frm_Area.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dim opcion As Integer
        opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Txt_Area.Clear()
        Txt_Lado.Clear()

    End Sub

    Private Sub Txt_Lado_TextChanged(sender As Object, e As EventArgs) Handles Txt_Lado.TextChanged

    End Sub

    Private Sub Txt_Lado_MouseHover(sender As Object, e As EventArgs) Handles Txt_Lado.MouseHover
        ToolTip.SetToolTip(Txt_Lado, "Ingrese un Lado")
        ToolTip.ToolTipTitle = "Lado"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Txt_Lado_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Lado.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
End Class