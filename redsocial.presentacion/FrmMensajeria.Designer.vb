<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMensajeria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblTotalRegistros = New System.Windows.Forms.Label()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.panelChat = New System.Windows.Forms.Panel()
        Me.dgvChat = New System.Windows.Forms.DataGridView()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.txtEnviarMensaje = New System.Windows.Forms.TextBox()
        Me.lblUsuarioContacto = New System.Windows.Forms.Label()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelChat.SuspendLayout()
        CType(Me.dgvChat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(696, 39)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(183, 28)
        Me.btnBuscar.TabIndex = 11
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(156, 42)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(503, 22)
        Me.txtBuscar.TabIndex = 10
        '
        'lblTotalRegistros
        '
        Me.lblTotalRegistros.AutoSize = True
        Me.lblTotalRegistros.Location = New System.Drawing.Point(907, 487)
        Me.lblTotalRegistros.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalRegistros.Name = "lblTotalRegistros"
        Me.lblTotalRegistros.Size = New System.Drawing.Size(48, 16)
        Me.lblTotalRegistros.TabIndex = 7
        Me.lblTotalRegistros.Text = "Label1"
        '
        'dgvListado
        '
        Me.dgvListado.AllowUserToAddRows = False
        Me.dgvListado.AllowUserToDeleteRows = False
        Me.dgvListado.AllowUserToOrderColumns = True
        Me.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListado.Location = New System.Drawing.Point(40, 74)
        Me.dgvListado.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.ReadOnly = True
        Me.dgvListado.RowHeadersWidth = 51
        Me.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListado.Size = New System.Drawing.Size(1008, 382)
        Me.dgvListado.TabIndex = 6
        '
        'panelChat
        '
        Me.panelChat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.panelChat.Controls.Add(Me.dgvChat)
        Me.panelChat.Controls.Add(Me.btnCerrar)
        Me.panelChat.Controls.Add(Me.btnRefrescar)
        Me.panelChat.Controls.Add(Me.btnEnviar)
        Me.panelChat.Controls.Add(Me.txtEnviarMensaje)
        Me.panelChat.Controls.Add(Me.lblUsuarioContacto)
        Me.panelChat.Location = New System.Drawing.Point(174, 2)
        Me.panelChat.Name = "panelChat"
        Me.panelChat.Size = New System.Drawing.Size(637, 547)
        Me.panelChat.TabIndex = 12
        '
        'dgvChat
        '
        Me.dgvChat.AllowUserToAddRows = False
        Me.dgvChat.AllowUserToDeleteRows = False
        Me.dgvChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChat.Location = New System.Drawing.Point(3, 69)
        Me.dgvChat.Name = "dgvChat"
        Me.dgvChat.ReadOnly = True
        Me.dgvChat.RowHeadersWidth = 51
        Me.dgvChat.RowTemplate.Height = 24
        Me.dgvChat.Size = New System.Drawing.Size(631, 406)
        Me.dgvChat.TabIndex = 5
        '
        'btnCerrar
        '
        Me.btnCerrar.Font = New System.Drawing.Font("Wide Latin", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.Red
        Me.btnCerrar.Location = New System.Drawing.Point(572, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(43, 32)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Location = New System.Drawing.Point(497, 493)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(99, 23)
        Me.btnRefrescar.TabIndex = 3
        Me.btnRefrescar.Text = "Refrescar"
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(343, 494)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(98, 23)
        Me.btnEnviar.TabIndex = 2
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'txtEnviarMensaje
        '
        Me.txtEnviarMensaje.Location = New System.Drawing.Point(14, 494)
        Me.txtEnviarMensaje.Name = "txtEnviarMensaje"
        Me.txtEnviarMensaje.Size = New System.Drawing.Size(311, 22)
        Me.txtEnviarMensaje.TabIndex = 1
        '
        'lblUsuarioContacto
        '
        Me.lblUsuarioContacto.AutoSize = True
        Me.lblUsuarioContacto.Location = New System.Drawing.Point(36, 20)
        Me.lblUsuarioContacto.Name = "lblUsuarioContacto"
        Me.lblUsuarioContacto.Size = New System.Drawing.Size(48, 16)
        Me.lblUsuarioContacto.TabIndex = 0
        Me.lblUsuarioContacto.Text = "Label1"
        '
        'FrmMensajeria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 541)
        Me.Controls.Add(Me.panelChat)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblTotalRegistros)
        Me.Controls.Add(Me.dgvListado)
        Me.Name = "FrmMensajeria"
        Me.Text = "Mensajeria"
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelChat.ResumeLayout(False)
        Me.panelChat.PerformLayout()
        CType(Me.dgvChat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents lblTotalRegistros As Label
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents panelChat As Panel
    Friend WithEvents lblUsuarioContacto As Label
    Friend WithEvents btnRefrescar As Button
    Friend WithEvents btnEnviar As Button
    Friend WithEvents txtEnviarMensaje As TextBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents dgvChat As DataGridView
End Class
