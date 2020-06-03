Imports System.ComponentModel

Public Class _7_EntregaMascarillas
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Txt_CantDepartamentos.Clear()
        Txt_CantMunicipios.Clear()
        Cmb_CantDepartamento.Items.Clear()
        TxtStock.Clear()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End

    End Sub

    Private Sub BtnSolicitar_Click(sender As Object, e As EventArgs) Handles BtnSolicitar.Click

        Dim vMascarilla() As Double
        Dim gasto As Double, totalMascarilla As Double, departmayor As Double, gastoMayor As Double
        Dim cantDepartamentos As Integer

        totalMascarilla = 0
        departmayor = 1
        gastoMayor = 0

        cantDepartamentos = Val(Txt_CantDepartamentos.Text)
        ReDim Preserve vMascarilla(cantDepartamentos)

        For mascarilla As Integer = 1 To cantDepartamentos Step 1
            gasto = InputBox("Ingrese cantidad de Mascarillas " & mascarilla, " Mascarillas")
            vMascarilla(mascarilla - 1) = gasto
        Next

        For i As Integer = 0 To cantDepartamentos - 1 Step 1
            If (vMascarilla(i) > gastoMayor) Then
                gastoMayor = vMascarilla(i)
                departmayor = i + 1
            End If
            totalMascarilla = totalMascarilla + vMascarilla(i)
            Cmb_CantDepartamento.Items.Add("Depto" & (i + 1) & "Mascarillas: " & vMascarilla(i))
        Next

        Txt_CantMunicipios.Text = departmayor
        TxtStock.Text = totalMascarilla
    End Sub

    Private Sub _7_EntregaMascarillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cmb_CantDepartamento.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Txt_CantDepartamentos_TextChanged(sender As Object, e As EventArgs) Handles Txt_CantDepartamentos.TextChanged

    End Sub

    Private Sub Txt_CantDepartamentos_Validating(sender As Object, e As CancelEventArgs) Handles Txt_CantDepartamentos.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorvalidacion.SetError(sender, "")
        Else
            Me.errorvalidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub Txt_CantDepartamentos_MouseHover(sender As Object, e As EventArgs) Handles Txt_CantDepartamentos.MouseHover
        ToolTip.SetToolTip(Txt_CantDepartamentos, "Ingrese un Numero")
        ToolTip.ToolTipTitle = "Cantidad Departamento"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Cmb_CantDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_CantDepartamento.SelectedIndexChanged

    End Sub
End Class