<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabGeneral = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.chkEliminacion = New System.Windows.Forms.CheckBox()
        Me.lblTotalRegistros = New System.Windows.Forms.Label()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cbRol = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblInformeContraseña = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.tabGeneral.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabGeneral
        '
        Me.tabGeneral.Controls.Add(Me.TabPage1)
        Me.tabGeneral.Controls.Add(Me.TabPage2)
        Me.tabGeneral.Location = New System.Drawing.Point(12, 13)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.SelectedIndex = 0
        Me.tabGeneral.Size = New System.Drawing.Size(776, 425)
        Me.tabGeneral.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnBuscar)
        Me.TabPage1.Controls.Add(Me.txtBuscar)
        Me.TabPage1.Controls.Add(Me.btnEliminar)
        Me.TabPage1.Controls.Add(Me.chkEliminacion)
        Me.TabPage1.Controls.Add(Me.lblTotalRegistros)
        Me.TabPage1.Controls.Add(Me.dgvListado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(768, 399)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(498, 3)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(137, 23)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(93, 6)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(378, 20)
        Me.txtBuscar.TabIndex = 4
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(175, 359)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(153, 23)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'chkEliminacion
        '
        Me.chkEliminacion.AutoSize = True
        Me.chkEliminacion.Location = New System.Drawing.Point(24, 363)
        Me.chkEliminacion.Name = "chkEliminacion"
        Me.chkEliminacion.Size = New System.Drawing.Size(108, 17)
        Me.chkEliminacion.TabIndex = 2
        Me.chkEliminacion.Text = "Menú eliminacion"
        Me.chkEliminacion.UseVisualStyleBackColor = True
        '
        'lblTotalRegistros
        '
        Me.lblTotalRegistros.AutoSize = True
        Me.lblTotalRegistros.Location = New System.Drawing.Point(656, 367)
        Me.lblTotalRegistros.Name = "lblTotalRegistros"
        Me.lblTotalRegistros.Size = New System.Drawing.Size(39, 13)
        Me.lblTotalRegistros.TabIndex = 1
        Me.lblTotalRegistros.Text = "Label1"
        '
        'dgvListado
        '
        Me.dgvListado.AllowUserToAddRows = False
        Me.dgvListado.AllowUserToDeleteRows = False
        Me.dgvListado.AllowUserToOrderColumns = True
        Me.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        Me.dgvListado.Location = New System.Drawing.Point(6, 32)
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.ReadOnly = True
        Me.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListado.Size = New System.Drawing.Size(756, 310)
        Me.dgvListado.TabIndex = 0
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cbRol)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.btnCancelar)
        Me.TabPage2.Controls.Add(Me.lblInformeContraseña)
        Me.TabPage2.Controls.Add(Me.btnActualizar)
        Me.TabPage2.Controls.Add(Me.btnInsertar)
        Me.TabPage2.Controls.Add(Me.txtContraseña)
        Me.TabPage2.Controls.Add(Me.txtNombreUsuario)
        Me.TabPage2.Controls.Add(Me.lblContraseña)
        Me.TabPage2.Controls.Add(Me.lblNombreUsuario)
        Me.TabPage2.Controls.Add(Me.lblId)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(768, 399)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mantenimiento"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cbRol
        '
        Me.cbRol.FormattingEnabled = True
        Me.cbRol.Location = New System.Drawing.Point(139, 121)
        Me.cbRol.Name = "cbRol"
        Me.cbRol.Size = New System.Drawing.Size(194, 21)
        Me.cbRol.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Rol:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(233, 278)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(151, 23)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblInformeContraseña
        '
        Me.lblInformeContraseña.AutoSize = True
        Me.lblInformeContraseña.Location = New System.Drawing.Point(136, 211)
        Me.lblInformeContraseña.Name = "lblInformeContraseña"
        Me.lblInformeContraseña.Size = New System.Drawing.Size(165, 26)
        Me.lblInformeContraseña.TabIndex = 7
        Me.lblInformeContraseña.Text = "Si no ingresa ninguna contraseña" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " se mantendra la actual"
        Me.lblInformeContraseña.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(62, 278)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(151, 23)
        Me.btnActualizar.TabIndex = 6
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(62, 278)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(151, 23)
        Me.btnInsertar.TabIndex = 5
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(139, 174)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(194, 20)
        Me.txtContraseña.TabIndex = 4
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Location = New System.Drawing.Point(139, 78)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(194, 20)
        Me.txtNombreUsuario.TabIndex = 3
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Location = New System.Drawing.Point(59, 177)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(64, 13)
        Me.lblContraseña.TabIndex = 2
        Me.lblContraseña.Text = "Contraseña:"
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Location = New System.Drawing.Point(11, 81)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(112, 13)
        Me.lblNombreUsuario.TabIndex = 1
        Me.lblNombreUsuario.Text = "Nombre de usuario (*):"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(702, 17)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(39, 13)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "Label1"
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tabGeneral)
        Me.Name = "FrmInicio"
        Me.Text = "Inicio"
        Me.tabGeneral.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabGeneral As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents lblId As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents lblContraseña As Label
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents lblInformeContraseña As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents lblTotalRegistros As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents chkEliminacion As CheckBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents cbRol As ComboBox
    Friend WithEvents Label1 As Label
End Class
