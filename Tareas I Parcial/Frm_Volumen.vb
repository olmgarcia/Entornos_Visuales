Public Class Frm_Volumen
    Private Sub Frm_Volumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        Frm_MenuPrincipal.Show()

    End Sub

    Private Sub BtnCubo_Click(sender As Object, e As EventArgs) Handles BtnCubo.Click
        Me.Hide()
        Frm_VolumenCubo.Show()

    End Sub

    Private Sub BtnCono_Click(sender As Object, e As EventArgs) Handles BtnCono.Click
        Me.Hide()
        Frm_VolumenCono.Show()

    End Sub
End Class