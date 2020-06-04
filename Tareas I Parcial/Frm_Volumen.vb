Public Class Frm_Volumen
    Private Sub Frm_Volumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
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

    Private Sub BtnCilindro_Click(sender As Object, e As EventArgs) Handles BtnCilindro.Click
        Me.Hide()
        Frm_VolumenCilindro.Show()

    End Sub

    Private Sub BtnPrismaRegular_Click(sender As Object, e As EventArgs) Handles BtnPrismaRegular.Click
        Me.Hide()
        Frm_VolPrismaRegular.Show()

    End Sub
End Class