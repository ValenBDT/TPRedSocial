Imports System.IO
Imports Microsoft.VisualBasic.Devices
Imports redsocial.Entidades
Imports redsocial.Negocio

Public Class FrmUsuarios

    'Formato de la tabla de usuarios
    Private Sub Formato()
        dgvListado.Columns("ID").Visible = False
        dgvListado.Columns("Seleccionar").Visible = False

        dgvListado.Columns(2).Width = 200
        dgvListado.Columns(3).Width = 200


        btnEliminar.Visible = False
        chkEliminacion.CheckState = False
    End Sub
    'Resetea el formulario a su estado inicial
    Private Sub Limpiar()
        txtBuscar.Text = ""
        txtContraseña.Text = ""
        txtNombreUsuario.Text = ""
        lblId.Text = ""
        lblInformeContraseña.Visible = False
        btnActualizar.Visible = False
        btnInsertar.Visible = True
        chkContraseña.Checked = False
    End Sub

    'Carga los roles actuales en el combo box (Los roles los trae desde la base de datos, de la tabla rol)
    Private Sub CargarRoles()
        Try
            Dim Neg As New NRol
            cbRol.DataSource = Neg.Listar()
            cbRol.ValueMember = "idrol"
            cbRol.DisplayMember = "nombre"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Lista todos los usuarios que esten registrados en la base de datos
    Private Sub Listar()
        Try
            Dim Neg As New Negocio.NUsuario()
            dgvListado.DataSource = Neg.Listar()
            lblTotalRegistros.Text = "Total de registros: " & dgvListado.RowCount
            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Busca a los usuarios que tengan compatibilidad con cierto valor
    Private Sub Buscar()
        Try
            Dim Neg As New Negocio.NUsuario
            Dim Busqueda As String = txtBuscar.Text
            dgvListado.DataSource = Neg.Buscar(Busqueda)
            lblTotalRegistros.Text = "Total de registros: " & dgvListado.RowCount
            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Insertar un usuario
    Private Sub Insertar()
        Try
            If (txtNombreUsuario.Text <> "" And txtContraseña.Text <> "") Then
                Dim Neg As New Negocio.NUsuario
                Dim User As New Usuario
                User.Idrol = cbRol.SelectedValue
                User.NombreUsuario = txtNombreUsuario.Text
                User.Contraseña = txtContraseña.Text

                If (Neg.BuscarNombreUsuario(txtNombreUsuario.Text)) Then
                    If (Neg.Insertar(User)) Then
                        MsgBox("Se ha registrado correctamente", vbOKOnly + vbInformation, "Registro correcto")
                        Me.Listar()
                    Else
                        MsgBox("No se ha podido registrar", vbOKOnly + vbCritical, "Registro incorrecto")
                    End If
                Else
                    MsgBox("Nombre de usuario ya registrado", vbOKOnly + vbCritical, "Usuario ya registrado")
                End If

            Else
                MsgBox("Rellene todos los campos obligatorios (*)", vbOKOnly + vbCritical, "Falta Ingresar datos")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FrmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarRoles()
        Me.Listar()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Limpiar()
        tabGeneral.SelectedIndex = 0
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Me.Insertar()
        Me.Limpiar()
    End Sub

    'Funcionalidad para mostrar el boton de eliminar si es que el check esta activo
    Private Sub chkEliminacion_CheckedChanged(sender As Object, e As EventArgs) Handles chkEliminacion.CheckedChanged
        If (chkEliminacion.CheckState = CheckState.Checked) Then

            dgvListado.Columns("Seleccionar").Visible = True
            btnEliminar.Visible = True
        Else

            dgvListado.Columns("Seleccionar").Visible = False
            btnEliminar.Visible = False
        End If
    End Sub

    'Funcionalidad de marcar el check de una fila (previamente el check de eliminacion general tiene que estar activo)
    Private Sub dgvListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellContentClick
        If (e.ColumnIndex = dgvListado.Columns("Seleccionar").Index) Then
            Dim chkcell As DataGridViewCheckBoxCell = dgvListado.Rows(e.RowIndex).Cells("Seleccionar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    'Elimina fisicamente todos los registros marcados
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

    'Funcionalidad para pasar los datos de una fila al panel de actualizacion, ademas setea los elementos necesarios para actualizar
    Private Sub dgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellDoubleClick
        lblId.Text = dgvListado.SelectedCells.Item(1).Value
        txtNombreUsuario.Text = dgvListado.SelectedCells.Item(2).Value
        cbRol.Text = dgvListado.SelectedCells(3).Value
        btnActualizar.Visible = True
        btnInsertar.Visible = False
        lblInformeContraseña.Visible = True
        tabGeneral.SelectedIndex = 1
    End Sub

    'Actualiza el usuario que se haya seleccionado
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            If (txtNombreUsuario.Text <> "") Then
                Dim Neg As New Negocio.NUsuario
                Dim User As New Usuario

                If (Neg.BuscarNombreUsuario(txtNombreUsuario.Text)) Then
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
                    MsgBox("Nombre de usuario ya registrado", vbOKOnly + vbCritical, "Usuario ya registrado")
                End If

            Else
                MsgBox("Rellene todos los campos obligatorios (*)", vbOKOnly + vbCritical, "Falta Ingresar datos")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Funcionalidad de mostrar y ocultar contraseña
    Private Sub chkContraseña_CheckedChanged(sender As Object, e As EventArgs) Handles chkContraseña.CheckedChanged
        If (chkContraseña.Checked = True) Then
            txtContraseña.PasswordChar = ""
            chkContraseña.Text = "Ocultar contraseña"
        Else
            txtContraseña.PasswordChar = "*"
            chkContraseña.Text = "Ver contraseña"
        End If
    End Sub

    'Funcionalidad para importar usuarios masivamente
    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Try


            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt"
            openFileDialog.Title = "Seleccionar archivo de texto"

            If openFileDialog.ShowDialog() = DialogResult.OK Then

                Dim filePath As String = openFileDialog.FileName


                If File.Exists(filePath) Then
                    Dim Neg As New Negocio.NUsuario
                    Using reader As New StreamReader(filePath)

                        Dim linea As String = reader.ReadLine()

                        Dim nuevosUsuarios() As String = linea.Split(";"c)

                        For Each parte As String In nuevosUsuarios
                            Dim UsuarioNuevo() As String = parte.Split(","c)
                            Dim UserObj As New Usuario
                            UserObj.NombreUsuario = UsuarioNuevo(0)
                            UserObj.Contraseña = UsuarioNuevo(1)
                            UserObj.Idrol = UsuarioNuevo(2)
                            If (UserObj.NombreUsuario <> "" And UserObj.Contraseña <> "" And UserObj.Contraseña <> "") Then 'Validaciones muuuuy tranquis, habria que controlar varias cosas mas, se puede romper muy facil el archivo de imports!
                                Neg.Insertar(UserObj)
                            End If
                        Next

                    End Using
                    Me.Listar()
                Else
                    Console.WriteLine("El archivo no existe.")
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Exporta todos los datos de los usuarios a un txt
    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try

            Dim folderBrowserDialog As New FolderBrowserDialog()
            folderBrowserDialog.Description = "Seleccionar directorio para guardar el archivo export"


            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then

                Dim directorioSeleccionado As String = folderBrowserDialog.SelectedPath

                Dim rutaArchivo As String = Path.Combine(directorioSeleccionado, "Export.txt")
                Using writer As New StreamWriter(rutaArchivo)
                    Dim totalRegistros As Integer = 0

                    Dim Neg As New Negocio.NUsuario

                    Dim tablaUsuarios As New DataTable

                    tablaUsuarios = Neg.Listar()

                    writer.WriteLine("Usuarios registrados en el sistema: ")
                    writer.WriteLine("")
                    writer.WriteLine("---------------------------------------------------")
                    For Each fila As DataRow In tablaUsuarios.Rows

                        Dim idUsuario As String = fila.Item(0)
                        Dim nombreUsuario As String = fila.Item(1)
                        Dim rol As String = fila.Item(2)

                        writer.WriteLine("ID: " & idUsuario & " Nombre de Usuario: " & nombreUsuario & " Rol: " & rol)
                        writer.WriteLine("---------------------------------------------------")
                        totalRegistros = totalRegistros + 1
                    Next
                    writer.WriteLine("")
                    writer.WriteLine("Cantidad de registros: " & totalRegistros)

                End Using

                MsgBox($"Archivo guardado en: {rutaArchivo}", vbOKOnly, "Exportacion exitosa")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class