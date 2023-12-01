Imports System.Windows.Forms

Public Class FrmPresentacion

    Private _idUsuario As Integer
    Private _nombreUsuario As String
    Private _rol As String
    Private _idRol As Integer

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Public Property IdUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(value As Integer)
            _idUsuario = value
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

    Public Property Rol As String
        Get
            Return _rol
        End Get
        Set(value As String)
            _rol = value
        End Set
    End Property

    Public Property IdRol As Integer
        Get
            Return _idRol
        End Get
        Set(value As Integer)
            _idRol = value
        End Set
    End Property

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles menuUsuarios.Click
        Dim Frm As New FrmUsuarios
        Frm.MdiParent = Me
        Frm.Show()
    End Sub
    'Valida el rol del usuario logeado y le da sus respectivos permisos
    Private Sub FrmPresentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        status.Text = Me.NombreUsuario
        Select Case Me.Rol
            Case "Administrador"
                menuUsuarios.Enabled = True
                menuMensajeria.Enabled = True
            Case "Usuario"
                'menuUsuarios.Enabled = False
                menuUsuarios.Visible = False
                menuMensajeria.Enabled = True
            Case Else
                'menuUsuarios.Enabled = False
                menuUsuarios.Visible = False
                menuMensajeria.Visible = False
        End Select

    End Sub

    Private Sub FrmPresentacion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub


    Private Sub MensajeriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuMensajeria.Click
        Dim Frm As New FrmMensajeria
        Frm.Idusuario = Me.IdUsuario
        Frm.NombreUsuario = Me.NombreUsuario
        Frm.MdiParent = Me
        Frm.Show()
    End Sub


End Class
