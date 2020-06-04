Imports System.ComponentModel

Public Class Frm_VolPrismaRegular
    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        Frm_Volumen.Show()

    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim valor As Int16
        If Txt_AreaBase.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(Txt_AreaBase.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            Txt_AreaBase.Text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(Txt_AreaBase.Text)
            If valor = 0 Then
                MsgBox("Numero cero", vbInformation)
            ElseIf valor < 0 Then
                MsgBox("Numero negativo")
            End If
        End If
        Dim areaBase, altura, volumen As Double

        areaBase = Val(Txt_AreaBase.Text)
        altura = Val(Txt_Altura.Text)

        volumen = areaBase * altura
        Txt_Volumen.Text = (volumen)
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Txt_AreaBase.Clear()
        Txt_Altura.Clear()
        Txt_Volumen.Clear()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dim opcion As Integer
        opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            End

        End If
    End Sub

    Private Sub Txt_AreaBase_TextChanged(sender As Object, e As EventArgs) Handles Txt_AreaBase.TextChanged

    End Sub

    Private Sub Txt_AreaBase_Validating(sender As Object, e As CancelEventArgs) Handles Txt_AreaBase.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub Txt_Altura_TextChanged(sender As Object, e As EventArgs) Handles Txt_Altura.TextChanged

    End Sub

    Private Sub Txt_Altura_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Altura.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub Txt_AreaBase_MouseHover(sender As Object, e As EventArgs) Handles Txt_AreaBase.MouseHover
        ToolTip.SetToolTip(Txt_AreaBase, "Ingrese el area de la Base")
        ToolTip.ToolTipTitle = "Area de Base"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Txt_Altura_MouseHover(sender As Object, e As EventArgs) Handles Txt_Altura.MouseHover
        ToolTip.SetToolTip(Txt_Altura, "Ingrese la Altura")
        ToolTip.ToolTipTitle = "Altura"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class