Public Class GuiaEjercicio1

    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim PresionarOperador As Boolean

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

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Txt_Resultado.Text = "0"
        Valor2 = Nothing
        ValorResultado = Nothing
        Txt_Resultado.Text = Txt_Historial.Text

    End Sub

    Private Sub BtnIgual_Click(sender As Object, e As EventArgs) Handles BtnIgual.Click
        EvaluaHacerOperacion()
        Operacion = ""
    End Sub

    Public Sub EvaluaHacerOperacion()
        PresionarOperador = True
        Valor2 = Val(Txt_Resultado.Text)
        If ValorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    ValorResultado = ValorResultado + Valor2
                Case "-"
                    ValorResultado -= Valor2
                Case "*"
                    ValorResultado *= Valor2
                Case "/"
                    ValorResultado /= Valor2
            End Select
            Txt_Resultado.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If
    End Sub

    Public Sub EvaluaRestriccionesParaConcatenar()
        If PresionarOperador = True Then
            Txt_Resultado.Text = ""
            PresionarOperador = False
        ElseIf Txt_Resultado .Text = "0" Then
            Txt_Resultado.Text = ""
        End If
    End Sub

    Private Sub BtnNum1_Click(sender As Object, e As EventArgs) Handles BtnNum1.Click
        EvaluaRestriccionesParaConcatenar()
        Txt_Resultado.Text &= "1"
    End Sub

    Private Sub BtnNum2_Click(sender As Object, e As EventArgs) Handles BtnNum2.Click
        EvaluaRestriccionesParaConcatenar()
        Txt_Resultado.Text &= "2"
    End Sub

    Private Sub BtnNum3_Click(sender As Object, e As EventArgs) Handles BtnNum3.Click
        EvaluaRestriccionesParaConcatenar()
        Txt_Resultado.Text &= "3"
    End Sub

    Private Sub BtnNum4_Click(sender As Object, e As EventArgs) Handles BtnNum4.Click
        EvaluaRestriccionesParaConcatenar()
        Txt_Resultado.Text &= "4"
    End Sub

    Private Sub BtnNum5_Click(sender As Object, e As EventArgs) Handles BtnNum5.Click
        EvaluaRestriccionesParaConcatenar()
        Txt_Resultado.Text &= "5"
    End Sub

    Private Sub BtnNum6_Click(sender As Object, e As EventArgs) Handles BtnNum6.Click
        EvaluaRestriccionesParaConcatenar()
        Txt_Resultado.Text &= "6"
    End Sub

    Private Sub BtnNum7_Click(sender As Object, e As EventArgs) Handles BtnNum7.Click
        EvaluaRestriccionesParaConcatenar()
        Txt_Resultado.Text &= "7"
    End Sub

    Private Sub BtnNum8_Click(sender As Object, e As EventArgs) Handles BtnNum8.Click
        EvaluaRestriccionesParaConcatenar()
        Txt_Resultado.Text &= "8"
    End Sub

    Private Sub BtnNum9_Click(sender As Object, e As EventArgs) Handles BtnNum9.Click
        EvaluaRestriccionesParaConcatenar()
        Txt_Resultado.Text &= "9"
    End Sub

    Private Sub BtnNum0_Click(sender As Object, e As EventArgs) Handles BtnNum0.Click
        EvaluaRestriccionesParaConcatenar()
        Txt_Resultado.Text &= "0"
    End Sub

    Private Sub BtnDecimal_Click(sender As Object, e As EventArgs) Handles BtnDecimal.Click
        EvaluaRestriccionesParaConcatenar()
        If InStr(Txt_Resultado.Text, ".", CompareMethod.Text) = 0 Then
            Txt_Resultado.Text &= "."
        End If
    End Sub

    Private Sub BtnSuma_Click(sender As Object, e As EventArgs) Handles BtnSuma.Click
        EvaluaHacerOperacion()
        Operacion = "+"
    End Sub

    Private Sub BtnResta_Click(sender As Object, e As EventArgs) Handles BtnResta.Click
        EvaluaHacerOperacion()
        Operacion = "-"
    End Sub

    Private Sub BtnMultiplicaion_Click(sender As Object, e As EventArgs) Handles BtnMultiplicaion.Click
        EvaluaHacerOperacion()
        Operacion = "*"
    End Sub

    Private Sub BtnDivision_Click(sender As Object, e As EventArgs) Handles BtnDivision.Click
        EvaluaHacerOperacion()
        Operacion = "/"
    End Sub
End Class