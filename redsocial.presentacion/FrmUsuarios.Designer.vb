<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
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
        Me.chkContraseña = New System.Windows.Forms.CheckBox()
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
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnImportar = New System.Windows.Forms.Button()
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
        Me.tabGeneral.Location = New System.Drawing.Point(16, 16)
        Me.tabGeneral.Margin = New System.Windows.Forms.Padding(4)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.SelectedIndex = 0
        Me.tabGeneral.Size = New System.Drawing.Size(1035, 523)
        Me.tabGeneral.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnImportar)
        Me.TabPage1.Controls.Add(Me.btnExportar)
        Me.TabPage1.Controls.Add(Me.btnBuscar)
        Me.TabPage1.Controls.Add(Me.txtBuscar)
        Me.TabPage1.Controls.Add(Me.btnEliminar)
        Me.TabPage1.Controls.Add(Me.chkEliminacion)
        Me.TabPage1.Controls.Add(Me.lblTotalRegistros)
        Me.TabPage1.Controls.Add(Me.dgvListado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1027, 494)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(664, 4)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(183, 28)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(124, 7)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(503, 22)
        Me.txtBuscar.TabIndex = 4
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(233, 442)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(204, 28)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'chkEliminacion
        '
        Me.chkEliminacion.AutoSize = True
        Me.chkEliminacion.Location = New System.Drawing.Point(32, 447)
        Me.chkEliminacion.Margin = New System.Windows.Forms.Padding(4)
        Me.chkEliminacion.Name = "chkEliminacion"
        Me.chkEliminacion.Size = New System.Drawing.Size(133, 20)
        Me.chkEliminacion.TabIndex = 2
        Me.chkEliminacion.Text = "Menú eliminacion"
        Me.chkEliminacion.UseVisualStyleBackColor = True
        '
        'lblTotalRegistros
        '
        Me.lblTotalRegistros.AutoSize = True
        Me.lblTotalRegistros.Location = New System.Drawing.Point(834, 474)
        Me.lblTotalRegistros.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalRegistros.Name = "lblTotalRegistros"
        Me.lblTotalRegistros.Size = New System.Drawing.Size(48, 16)
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
        Me.dgvListado.Location = New System.Drawing.Point(8, 39)
        Me.dgvListado.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.ReadOnly = True
        Me.dgvListado.RowHeadersWidth = 51
        Me.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListado.Size = New System.Drawing.Size(1008, 382)
        Me.dgvListado.TabIndex = 0
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.MinimumWidth = 6
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.ReadOnly = True
        Me.Seleccionar.Width = 125
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chkContraseña)
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
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1027, 494)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mantenimiento"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'chkContraseña
        '
        Me.chkContraseña.AutoSize = True
        Me.chkContraseña.Location = New System.Drawing.Point(449, 216)
        Me.chkContraseña.Name = "chkContraseña"
        Me.chkContraseña.Size = New System.Drawing.Size(120, 20)
        Me.chkContraseña.TabIndex = 12
        Me.chkContraseña.Text = "Ver contraseña"
        Me.chkContraseña.UseVisualStyleBackColor = True
        '
        'cbRol
        '
        Me.cbRol.FormattingEnabled = True
        Me.cbRol.Location = New System.Drawing.Point(185, 149)
        Me.cbRol.Margin = New System.Windows.Forms.Padding(4)
        Me.cbRol.Name = "cbRol"
        Me.cbRol.Size = New System.Drawing.Size(257, 24)
        Me.cbRol.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 153)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Rol:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(311, 342)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(201, 28)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblInformeContraseña
        '
        Me.lblInformeContraseña.AutoSize = True
        Me.lblInformeContraseña.Location = New System.Drawing.Point(181, 260)
        Me.lblInformeContraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInformeContraseña.Name = "lblInformeContraseña"
        Me.lblInformeContraseña.Size = New System.Drawing.Size(205, 32)
        Me.lblInformeContraseña.TabIndex = 7
        Me.lblInformeContraseña.Text = "Si no ingresa ninguna contraseña" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " se mantendra la actual"
        Me.lblInformeContraseña.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(83, 342)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(201, 28)
        Me.btnActualizar.TabIndex = 6
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(83, 342)
        Me.btnInsertar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(201, 28)
        Me.btnInsertar.TabIndex = 5
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(185, 214)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(257, 22)
        Me.txtContraseña.TabIndex = 4
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Location = New System.Drawing.Point(185, 96)
        Me.txtNombreUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(257, 22)
        Me.txtNombreUsuario.TabIndex = 3
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Location = New System.Drawing.Point(79, 218)
        Me.lblContraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(79, 16)
        Me.lblContraseña.TabIndex = 2
        Me.lblContraseña.Text = "Contraseña:"
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Location = New System.Drawing.Point(15, 100)
        Me.lblNombreUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(141, 16)
        Me.lblNombreUsuario.TabIndex = 1
        Me.lblNombreUsuario.Text = "Nombre de usuario (*):"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(936, 21)
        Me.lblId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(48, 16)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "Label1"
        Me.lblId.Visible = False
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(453, 442)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(204, 28)
        Me.btnExportar.TabIndex = 6
        Me.btnExportar.Text = "Reporte"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnImportar
        '
        Me.btnImportar.Location = New System.Drawing.Point(664, 444)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(204, 23)
        Me.btnImportar.TabIndex = 7
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.tabGeneral)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmUsuarios"
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
    Friend WithEvents chkContraseña As CheckBox
    Friend WithEvents btnImportar As Button
    Friend WithEvents btnExportar As Button
End Class
