Imports System.ComponentModel

Public Class LoginSinager

    Dim NuevoUsuario, Contraseña As String

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dim opcion As Integer

        opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub BtnNuevoUsuario_Click(sender As Object, e As EventArgs) Handles BtnNuevoUsuario.Click

        NuevoUsuario = UCase(Txt_Usuario.Text)
        Contraseña = UCase(Txt_Contraseña.Text)
    End Sub

    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click

        If UCase(Txt_Usuario.Text) = NuevoUsuario And UCase(Txt_Contraseña.Text) = Contraseña Then
            MsgBox("Bienvenido")
            Me.Hide()
            IngresoPruebasSinager.Show()
        Else
            MsgBox("Datos Incorrectos")
        End If
        If Txt_Usuario.Text = "" Then
            MsgBox("Ingrese un Usuario", vbInformation)
        End If
        If Txt_Contraseña.Text = "" Then
            MsgBox("Ingrese una Contraseña", vbInformation)
        End If
    End Sub
    Private Sub Limpiar()
        Txt_Usuario.Clear()
        Txt_Contraseña.Clear()
    End Sub

    Private Sub Txt_Usuario_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Usuario.Validating
        If Val(Txt_Usuario.Text) - Int(Val(Txt_Usuario.Text)) = 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese un numero Entero")
        End If
    End Sub

    Private Sub Txt_Contraseña_Validating(sender As Object, e As CancelEventArgs) Handles Txt_Contraseña.Validating
        If Val(Txt_Usuario.Text) - Int(Val(Txt_Usuario.Text)) = 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese un numero Entero")
        End If
    End Sub

    Private Sub Txt_Usuario_MouseHover(sender As Object, e As EventArgs) Handles Txt_Usuario.MouseHover
        ToolTip.SetToolTip(Txt_Usuario, "Ingrese un Usuario")
        ToolTip.ToolTipTitle = "Usuario"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Txt_Contraseña_MouseHover(sender As Object, e As EventArgs) Handles Txt_Contraseña.MouseHover
        ToolTip.SetToolTip(Txt_Usuario, "Ingrese una Contraseña")
        ToolTip.ToolTipTitle = "Contraseña"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub chk_VerContraseña_CheckedChanged(sender As Object, e As EventArgs) Handles chk_VerContraseña.CheckedChanged
        If chk_VerContraseña.Checked = True Then
            Txt_Contraseña.PasswordChar = ""
        Else
            Txt_Contraseña.PasswordChar = "*"

        End If
    End Sub


End Class