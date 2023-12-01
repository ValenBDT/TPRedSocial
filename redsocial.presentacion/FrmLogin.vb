Imports redsocial.Entidades

Public Class FrmLogin
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    'Valida los datos de entrada para iniciar sesion, si son verdaderos carga datos del usuario y redirige hacia la presentacion
    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Try

            If (txtNombreUsuario.Text <> "" And txtContraseña.Text <> "") Then
                Dim Neg As New Negocio.NUsuario
                Dim nombreUsuario As String = txtNombreUsuario.Text
                Dim contraseña As String = txtContraseña.Text

                Dim User As New Usuario

                User = Neg.Login(nombreUsuario, contraseña)

                If (User Is Nothing) Then
                    MsgBox("Nombre de usuario o contraseña incorrecta", vbOKOnly + vbCritical, "Datos incorrectos")
                Else
                    Me.Hide()

                    FrmPresentacion.IdUsuario = User.Id
                    FrmPresentacion.NombreUsuario = User.NombreUsuario
                    FrmPresentacion.Rol = User.Rol
                    FrmPresentacion.IdRol = User.Idrol

                    FrmPresentacion.Show()
                End If

            Else
                    MsgBox("Ingrese los datos pedidos", vbOKOnly + vbCritical, "Datos insuficientes")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Funcionalidad de ocultar contraseña
    Private Sub chkContraseña_CheckStateChanged(sender As Object, e As EventArgs) Handles chkContraseña.CheckStateChanged
        If (chkContraseña.Checked = True) Then
            txtContraseña.PasswordChar = ""
            chkContraseña.Text = "Ocultar contraseña"
        Else
            txtContraseña.PasswordChar = "*"
            chkContraseña.Text = "Ver contraseña"
        End If
    End Sub


End Class