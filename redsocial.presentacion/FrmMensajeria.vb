Imports redsocial.Negocio

Public Class FrmMensajeria

    Private _idusuario As Integer
    Private _nombreUsuario As String

    Public Property Idusuario As Integer
        Get
            Return _idusuario
        End Get
        Set(value As Integer)
            _idusuario = value
        End Set
    End Property

    Public Property NombreUsuario As String
        Get
            Return _nombreUsuario
        End Get
        Set(value As String)
            _nombreUsuario = value
        End Set
    End Property

    'Formato del listado de conctactos
    Private Sub Formato()
        dgvListado.Columns("ID").Visible = False

        dgvListado.Columns(1).Width = 200
        dgvListado.Columns(2).Width = 200

        panelChat.Visible = False


    End Sub

    Private Sub Limpiar()
        txtBuscar.Text = ""
        txtEnviarMensaje.Text = ""
    End Sub

    'Lista contactos del usuario
    Private Sub Listar()
        Try
            Dim Neg As New Negocio.NUsuario()
            dgvListado.DataSource = Neg.ListarContactos(Me.Idusuario)

            lblTotalRegistros.Text = "Total de registros: " & dgvListado.RowCount
            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Busca contactos del usuario en base a un valor
    Private Sub Buscar()
        Try
            Dim Neg As New Negocio.NUsuario
            Dim Busqueda As String = txtBuscar.Text
            dgvListado.DataSource = Neg.BuscarContactos(Me.Idusuario, Busqueda)
            lblTotalRegistros.Text = "Total de registros: " & dgvListado.RowCount
            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Creo las columnas para visualizar los mensajes
    Private Sub FrmMensajeria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvChat.Columns.Add("Emisor", "Enviado por")
        dgvChat.Columns.Add("Mensaje", "Mensaje")
        dgvChat.Columns.Add("EnviadoPorUsuario", "Enviado por Usuario")
        dgvChat.Columns.Add("FechaEnvio", "Fecha de Envío")

        dgvChat.Columns("Emisor").Width = 100
        dgvChat.Columns("Mensaje").Width = 200
        dgvChat.Columns("EnviadoPorUsuario").Visible = False ' Esta columna la ocultamos porque solo es para determinar el estilo de visualización
        dgvChat.Columns("FechaEnvio").Width = 120
        Me.Listar()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.Buscar()
    End Sub
    'Itera todos los mensajes visualizados y cambia su estilo 
    Private Sub formatoMensajes()
        For Each row As DataGridViewRow In dgvChat.Rows
            Dim enviadoPorUsuario As Boolean = CBool(row.Cells("EnviadoPorUsuario").Value)

            If enviadoPorUsuario Then
                row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                row.DefaultCellStyle.BackColor = Color.Fuchsia
            Else
                row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Next
    End Sub

    'Busca los mensajes en los que el usuario a y el usuario b hayan participado y los carga al dgv
    Private Sub cargarMensajes()
        Dim Tabla As DataTable
        Dim Neg As New NMensaje
        Tabla = Neg.Listar(Me.Idusuario, Convert.ToInt16(dgvListado.SelectedCells.Item(0).Value))

        For Each row As DataRow In Tabla.Rows
            Dim Mensaje As String = row.Item(1)
            Dim Fecha As Date = row.Item(2)
            Dim Emisor As String
            Dim Enviado As Boolean

            If (Me.Idusuario = row.Item(0)) Then
                Emisor = "Vos"
                Enviado = True
            Else
                Emisor = lblUsuarioContacto.Text
                Enviado = False
            End If

            dgvChat.Rows.Add(Emisor, Mensaje, Enviado, Fecha)
        Next
        formatoMensajes()
        Limpiar()
    End Sub

    'Abre el chat
    Private Sub dgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellDoubleClick
        lblUsuarioContacto.Text = dgvListado.SelectedCells.Item(1).Value
        cargarMensajes()

        panelChat.Visible = True
    End Sub
    'Cierra el chat
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        dgvChat.Rows.Clear()
        panelChat.Visible = False
    End Sub

    'Envia el mensaje y vuelve a cargar los mensajes
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            If (txtEnviarMensaje.Text <> "") Then
                Dim Neg As New Negocio.NMensaje

                Dim idContacto As Integer = Convert.ToInt32(dgvListado.SelectedCells.Item(0).Value)

                If (Neg.Insertar(Me.Idusuario, idContacto, txtEnviarMensaje.Text)) Then
                    dgvChat.Rows.Clear()
                    cargarMensajes()
                Else
                    MsgBox("No se pudo enviar el mensaje", vbOKOnly + vbCritical, "Error de envio")
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Elimina todos los valores que se estan visualizando y vuelve a cargar los nuevos (Solucion a la imposibilidad de que la base de datos me avise cuando llega un nuevo mensaje de la otra persona :p)
    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        dgvChat.Rows.Clear()
        cargarMensajes()
    End Sub
End Class