Imports System.ComponentModel

Public Class Frm_AreaRectangulo
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim valor As Int16
        If Txt_Base.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(Txt_Base.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            Txt_Base.Text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(Txt_Base.Text)
            If valor = 0 Then
                MsgBox("Numero cero", vbInformation)
            ElseIf valor < 0 Then
                MsgBox("Numero negativo")
            End If
        End If

        Dim base, altura, area As Integer

        base = Val(Txt_Base.Text)
        altura = Val(Txt_Altura.Text)

        area = (base * altura)
        Txt_Area.Text = (area)

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Txt_Base.Clear()
        Txt_Altura.Clear()
        Txt_Area.Clear()

    End Sub

    Private Sub Frm_AreaRectangulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub Txt_Base_TextChanged(sender As Object, e As EventArgs) Handles Txt_Base.TextChanged

    End Sub

    Private Sub Txt_Base_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Base.Validating
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

    Private Sub Txt_Base_MouseHover(sender As Object, e As EventArgs) Handles Txt_Base.MouseHover
        ToolTip.SetToolTip(Txt_Base, "Ingrese la Base")
        ToolTip.ToolTipTitle = "Base"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Txt_Altura_MouseHover(sender As Object, e As EventArgs) Handles Txt_Altura.MouseHover
        ToolTip.SetToolTip(Txt_Altura, "Ingrese la Altura")
        ToolTip.ToolTipTitle = "Altura"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class