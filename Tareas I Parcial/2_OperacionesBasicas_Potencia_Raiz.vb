Public Class _2_OperacionesBasicas_Potencia_Raiz
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        Dim valor1 As Integer
        Dim valor2 As Integer

        If Me.chkSuma.Checked = True Then

            Dim suma As Integer

            valor1 = Val(TxtNumero1.Text)
            valor2 = Val(TxtNumero2.Text)

            'Proceso
            suma = valor1 + valor2

            'Salidas
            TxtResultado.Text = suma
        End If

        If Me.chkResta.Checked = True Then

            Dim resta As Integer

            valor1 = Val(TxtNumero1.Text)
            valor2 = Val(TxtNumero2.Text)

            'Proceso
            resta = valor1 - valor2

            'Salidas
            TxtResultado.Text = resta
        End If

        If Me.chkMultiplicacion.Checked = True Then

            Dim multiplicacion As Integer

            valor1 = Val(TxtNumero1.Text)
            valor2 = Val(TxtNumero2.Text)

            'Proceso
            multiplicacion = valor1 * valor2

            'Salidas
            TxtResultado.Text = multiplicacion
        End If

        If Me.chkdivision.Checked = True Then

            Dim division As Double

            valor1 = Val(TxtNumero1.Text)
            valor2 = Val(TxtNumero2.Text)

            'Proceso
            If valor2 = 0 Then
                MsgBox("No se puede dividir entre 0", vbInformation)
            End If
            If valor2 <> 0 Then
                division = valor1 / valor2
            End If

            'Salidas
            TxtResultado.Text = division
        End If

        If Me.chkraiz.Checked = True Then

            Dim raiz, num As Integer
            Dim suma2 As Integer

            valor1 = Val(TxtNumero1.Text)
            valor2 = Val(TxtNumero2.Text)

            suma2 = valor1 + valor2

            'Proceso
            If suma2 <> 0 Then
                num = suma2
                raiz = num ^ (1 / 2)
            End If


            'Salidas
            TxtResultado.Text = raiz
        End If

        If Me.chkpotencia.Checked = True Then

            Dim potencia As Integer

            valor1 = Val(TxtNumero1.Text)
            valor2 = Val(TxtNumero2.Text)

            'Proceso
            potencia = valor1 ^ valor2

            'Salidas
            TxtResultado.Text = potencia
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtNumero1.Clear()
        TxtNumero2.Clear()
        TxtResultado.Clear()
        chkSuma.Checked = False
        chkResta.Checked = False
        chkMultiplicacion.Checked = False
        chkdivision.Checked = False
        chkpotencia.Checked = False
        chkraiz.Checked = False

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub
End Class