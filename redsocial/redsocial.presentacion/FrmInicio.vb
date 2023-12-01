Imports redsocial.Entidades
Imports redsocial.Negocio

Public Class FrmInicio

    Private Sub Formato()
        dgvListado.Columns("ID").Visible = False
        dgvListado.Columns("Seleccionar").Visible = False

        lblId.Visible = False
        lblInformeContraseña.Visible = False
        btnEliminar.Visible = False
        btnActualizar.Visible = False
        chkEliminacion.CheckState = False
    End Sub

    Private Sub Limpiar()
        txtBuscar.Text = ""
        txtContraseña.Text = ""
        txtNombreUsuario.Text = ""
        lblId.Text = ""
        btnInsertar.Visible = True

    End Sub

    Private Sub CargarRoles()
        Try
            Dim Neg As New NRol
            cbRol.DataSource = Neg.Listar()
            cbRol.ValueMember = "idrol"
            cbRol.DisplayMember = "nombre"

        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub Listar()
        Dim Neg As New Negocio.NUsuario()
        dgvListado.DataSource = Neg.Listar()
        lblTotalRegistros.Text = "Total de registros: " & dgvListado.RowCount
        Me.Formato()
    End Sub

    Private Sub Buscar()
        Dim Neg As New Negocio.NUsuario
        Dim Busqueda As String = txtBuscar.Text
        dgvListado.DataSource = Neg.Buscar(Busqueda)
        lblTotalRegistros.Text = "Total de registros: " & dgvListado.RowCount
        Me.Formato()
        Me.Limpiar()
    End Sub

    Private Sub Insertar()
        Try
            If (txtNombreUsuario.Text <> "") Then
                Dim Neg As New Negocio.NUsuario
                Dim User As New Usuario
                User.Idrol = cbRol.SelectedValue
                User.NombreUsuario = txtNombreUsuario.Text
                User.Contraseña = txtContraseña.Text

                If (Neg.Insertar(User)) Then
                    MsgBox("Se ha registrado correctamente", vbOKOnly + vbInformation, "Registro correcto")
                    Me.Listar()
                Else
                    MsgBox("No se ha podido registrar", vbOKOnly + vbCritical, "Registro incorrecto")
                End If
            Else
                MsgBox("Rellene todos los campos obligatorios (*)", vbOKOnly + vbCritical, "Falta Ingresar datos")
            End If

        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
    Private Sub FrmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarRoles()
        Listar()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Buscar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Limpiar()
        tabGeneral.SelectedIndex = 0
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Me.Insertar()
        Me.Limpiar()
    End Sub

    Private Sub chkEliminacion_CheckedChanged(sender As Object, e As EventArgs) Handles chkEliminacion.CheckedChanged
        If (chkEliminacion.CheckState = CheckState.Checked) Then

            dgvListado.Columns("Seleccionar").Visible = True
            btnEliminar.Visible = True
        Else

            dgvListado.Columns("Seleccionar").Visible = False
            btnEliminar.Visible = False
        End If
    End Sub

    Private Sub dgvListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellContentClick
        If (e.ColumnIndex = dgvListado.Columns("Seleccionar").Index) Then
            Dim chkcell As DataGridViewCheckBoxCell = dgvListado.Rows(e.RowIndex).Cells("Seleccionar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (MsgBox("Estas seguro de eliminar los registros seleccionados?", vbYesNo + vbQuestion, "Eliminar registros") = vbYes) Then
            Try
                Dim Neg As New Negocio.NUsuario
                For Each row As DataGridViewRow In dgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim OneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Neg.Eliminar(OneKey)
                        Me.Formato()
                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub dgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellDoubleClick
        lblId.Text = dgvListado.SelectedCells.Item(1).Value
        txtNombreUsuario.Text = dgvListado.SelectedCells.Item(2).Value
        cbRol.Text = dgvListado.SelectedCells(3).Value
        btnActualizar.Visible = True
        btnInsertar.Visible = False
        lblInformeContraseña.Visible = True
        tabGeneral.SelectedIndex = 1
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            If (txtNombreUsuario.Text <> "") Then
                Dim Neg As New Negocio.NUsuario
                Dim User As New Usuario
                User.Id = lblId.Text
                User.Idrol = cbRol.SelectedValue
                User.NombreUsuario = txtNombreUsuario.Text
                User.Contraseña = txtContraseña.Text

                If (Neg.Actualizar(User)) Then
                    MsgBox("Se ha registrado correctamente", vbOKOnly + vbInformation, "Registro correcto")
                    Me.Listar()
                    Me.Limpiar()
                Else
                    MsgBox("No se ha podido registrar", vbOKOnly + vbCritical, "Registro incorrecto")
                End If
            Else
                MsgBox("Rellene todos los campos obligatorios (*)", vbOKOnly + vbCritical, "Falta Ingresar datos")
            End If

        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
End Class