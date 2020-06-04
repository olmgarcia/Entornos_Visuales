Public Class Frm_Area
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End

    End Sub

    Private Sub Frm_Area_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        Frm_MenuPrincipal.Show()

    End Sub

    Private Sub BtnTriangulo_Click(sender As Object, e As EventArgs) Handles BtnTriangulo.Click

        Me.Hide()
        Frm_AreaTriangulo.Show()

    End Sub

    Private Sub BtnCuadrado_Click(sender As Object, e As EventArgs) Handles BtnCuadrado.Click

        Me.Hide()
        Frm_AreaCuadrado.Show()

    End Sub

    Private Sub BtnCirculo_Click(sender As Object, e As EventArgs) Handles BtnCirculo.Click
        Me.Hide()
        Frm_AreaCirculo.Show()

    End Sub

    Private Sub BtnRectangulo_Click(sender As Object, e As EventArgs) Handles BtnRectangulo.Click
        Me.Hide()
        Frm_AreaRectangulo.Show()

    End Sub
End Class