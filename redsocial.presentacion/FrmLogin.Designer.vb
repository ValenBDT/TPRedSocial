<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.btnIniciarSesion = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.chkContraseña = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de usuario (*): "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña (*): "
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Location = New System.Drawing.Point(202, 90)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(285, 22)
        Me.txtNombreUsuario.TabIndex = 2
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(202, 168)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(285, 22)
        Me.txtContraseña.TabIndex = 3
        '
        'btnIniciarSesion
        '
        Me.btnIniciarSesion.Location = New System.Drawing.Point(116, 248)
        Me.btnIniciarSesion.Name = "btnIniciarSesion"
        Me.btnIniciarSesion.Size = New System.Drawing.Size(195, 35)
        Me.btnIniciarSesion.TabIndex = 4
        Me.btnIniciarSesion.Text = "Iniciar sesion"
        Me.btnIniciarSesion.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(327, 248)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(195, 35)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'chkContraseña
        '
        Me.chkContraseña.AutoSize = True
        Me.chkContraseña.Location = New System.Drawing.Point(510, 171)
        Me.chkContraseña.Name = "chkContraseña"
        Me.chkContraseña.Size = New System.Drawing.Size(120, 20)
        Me.chkContraseña.TabIndex = 6
        Me.chkContraseña.Text = "Ver contraseña"
        Me.chkContraseña.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 383)
        Me.Controls.Add(Me.chkContraseña)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIniciarSesion)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents btnIniciarSesion As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents chkContraseña As CheckBox
End Class
