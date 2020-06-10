Imports System.ComponentModel

Public Class IngresoPruebasSinager
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        Dim Pos As Integer
        Dim Estado As String

        If Txt_Nombre.Text = "" Then
            MsgBox("Escriba un Nombre", vbInformation)
        ElseIf Txt_Edad.Text = "" Then
            MsgBox("Escriba una Edad", vbInformation)
        ElseIf Txt_Municipio.Text = "" Then
            MsgBox("Escriba una Edad", vbInformation)
        ElseIf Txt_Descripcion.Text = "" Then
            MsgBox("Escriba una Breve Descripcion", vbInformation)
        End If
        Try
            Pos = Dgb_Historial.Rows.Count - 1
            Dgb_Historial.Rows.Add()
            Dgb_Historial.Rows(Pos).Cells(0).Value = Txt_Nombre.Text
            Dgb_Historial.Rows(Pos).Cells(1).Value = Txt_Edad.Text
            Dgb_Historial.Rows(Pos).Cells(2).Value = Cmb_Deptos.SelectedItem
            Dgb_Historial.Rows(Pos).Cells(3).Value = Txt_Municipio.Text

            If Cmb_Estado.SelectedIndex = 0 Then
                Estado = Dgb_Historial.Rows(Pos).Cells(4).Value = Chk_Positivo.Text
            ElseIf Cmb_Estado.SelectedIndex = 1 Then
                Estado = "Activo"
            ElseIf Cmb_Estado.SelectedIndex = 2 Then
                Estado = "Muerto"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub llenarColumnas()
        Dgb_Historial.Columns.Add("nom", "Nombre")
        Dgb_Historial.Columns.Add("edad", "Edad")
        Dgb_Historial.Columns.Add("depto", "Departamento")
        Dgb_Historial.Columns.Add("depto", "Municipio")
        Dgb_Historial.Columns.Add("depto", "Estado")

    End Sub
    Private Sub Txt_Edad_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Edad.Validating
        If Val(Txt_Edad.Text) - Int(Val(Txt_Edad.Text)) = 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese un numero Entero")
        End If
    End Sub

    Private Sub IngresoPruebasSinager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cmb_Deptos.SelectedIndex = 0
        llenarColumnas()

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Txt_Nombre.Clear()
        Txt_Nombre.Focus()
        Txt_Edad.Clear()
        Cmb_Deptos.SelectedIndex = 0
        Txt_Municipio.Clear()
        If Chk_Positivo.Enabled = False Then
            Chk_Positivo.Enabled = True
            Cmb_Estado.Enabled = True
        ElseIf Chk_Negativo.Enabled = False Then
            Chk_Negativo.Enabled = True
        ElseIf Cmb_Estado.Enabled = False Then
            Cmb_Estado.Enabled = True
        End If

        If Chk_Positivo.Checked = True Then
            Chk_Positivo.Checked = False
        End If
        If Chk_Negativo.Checked = True Then
            Chk_Negativo.Checked = False
        End If
        Txt_Descripcion.Clear()


    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dim opcion As Integer

        opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub Dgb_Historial_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgb_Historial.CellContentClick

    End Sub
    Private Sub Txt_Nombre_MouseHover(sender As Object, e As EventArgs) Handles Txt_Nombre.MouseHover
        ToolTip.SetToolTip(Txt_Nombre, "Ingrese un Nombre")
        ToolTip.ToolTipTitle = "Nombre"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Txt_Edad_MouseHover(sender As Object, e As EventArgs) Handles Txt_Edad.MouseHover
        ToolTip.SetToolTip(Txt_Edad, "Ingrese una Edad")
        ToolTip.ToolTipTitle = "Edad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Txt_Descripcion_MouseHover(sender As Object, e As EventArgs) Handles Txt_Descripcion.MouseHover
        ToolTip.SetToolTip(Txt_Descripcion, "Ingrese una Breve Descripcion")
        ToolTip.ToolTipTitle = "Breve Descripcion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Cmb_Deptos_MouseHover(sender As Object, e As EventArgs) Handles Cmb_Deptos.MouseHover
        ToolTip.SetToolTip(Txt_Municipio, "Ingrese un Municipio")
        ToolTip.ToolTipTitle = "Municipio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Chk_Negativo_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Negativo.CheckedChanged

        If Chk_Negativo.Checked Then
            Chk_Positivo.Enabled = False
            Cmb_Estado.Enabled = False
        End If
    End Sub

    Private Sub Chk_Positivo_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Positivo.CheckedChanged

        If Chk_Positivo.Checked Then
            Chk_Negativo.Enabled = False
        End If
    End Sub

End Class