Public Class GuiaEjercicio3
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

    Private Sub GuiaEjercicio3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Txt_Almacen.Clear()
        Txt_Promedio.Clear()
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Try
            'Declaración de variables
            Dim numalumnos As Integer
            Dim nota, sumanotas, notabaja, promedio As Double

            If (Val(Txt_Almacen.Text) - Int(Val(Txt_Almacen.Text)) = 0) Then
                'Entrada de datos
                numalumnos = Val(Txt_Almacen.Text)
                'Inicializamos las variables
                sumanotas = 0
                notabaja = 20

                For i = 1 To numalumnos Step 1
                    nota = InputBox("Ingrese Ventas Primer Semana " & i, "Registro de Almacen")
                    sumanotas = sumanotas + nota
                    'Evaluamos si esta nota es la más baja
                    If (nota < notabaja) Then
                        notabaja = nota
                    End If
                Next
                promedio = sumanotas / numalumnos
                'Salida de Información
                Txt_Promedio.Text = promedio
                Txt_Promedio.Text = notabaja
            Else
                MessageBox.Show("Ingrese un valor entero", "Promedio de Notas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class