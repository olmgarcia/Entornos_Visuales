Public Class GuiaEjercicio5
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

        If Txt_Sueldo.Text <> "" Then
            Txt_Sueldo.Clear()
            Chk_Deduccion.Enabled = True
            Chk_Deduccion.Checked = False
            ChkExcento.Enabled = True
            ChkExcento.Checked = False
            Txt_SueldoNeto.Clear()
        End If
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        Dim Sueldo, SueldoNeto As Double

        Sueldo = Val(Txt_Sueldo.Text)
        SueldoNeto = Val(Txt_SueldoNeto.Text)

        If Txt_Sueldo.Text = "" Then
            MsgBox("Usted debe Ingresar el Sueldo", vbInformation)
        ElseIf Sueldo <= 16582.92 Then
            ChkExcento.Checked = True
            Chk_Deduccion.Enabled = False
            MsgBox("Usted aplica a Excentos de Impuesto", vbInformation)
            Txt_SueldoNeto.Text = 0
        ElseIf Txt_Sueldo.Text >= 16528.93 And Txt_Sueldo.Text <= 23536.61 Then
            Chk_Deduccion.Checked = True
            ChkExcento.Enabled = False
            MsgBox("Usted aplica a Deduccion del 15%", vbInformation)
            Txt_SueldoNeto.Text = Txt_Sueldo.Text * 0.15
        ElseIf Txt_Sueldo.Text >= 23536.62 And Txt_Sueldo.Text <= 50317.69 Then
            Chk_Deduccion.Checked = True
            ChkExcento.Enabled = False
            MsgBox("Usted aplica a Deduccion del 20%", vbInformation)
            Txt_SueldoNeto.Text = Txt_Sueldo.Text * 0.2
        ElseIf Txt_Sueldo.Text > 50317.69 Then
            Chk_Deduccion.Checked = True
            ChkExcento.Enabled = False
            MsgBox("Usted aplica a Deduccion del 25%", vbInformation)
            Txt_SueldoNeto.Text = Txt_Sueldo.Text * 0.25
        End If


    End Sub
End Class