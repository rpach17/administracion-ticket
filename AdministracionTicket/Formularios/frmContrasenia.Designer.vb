<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContrasenia
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
        Dim USUARIOLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim APELLIDOSLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        USUARIOLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        APELLIDOSLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'USUARIOLabel
        '
        USUARIOLabel.AutoSize = True
        USUARIOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        USUARIOLabel.Location = New System.Drawing.Point(51, 21)
        USUARIOLabel.Name = "USUARIOLabel"
        USUARIOLabel.Size = New System.Drawing.Size(64, 20)
        USUARIOLabel.TabIndex = 28
        USUARIOLabel.Text = "Usuario"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        NOMBRELabel.Location = New System.Drawing.Point(50, 53)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(65, 20)
        NOMBRELabel.TabIndex = 29
        NOMBRELabel.Text = "Nombre"
        '
        'APELLIDOSLabel
        '
        APELLIDOSLabel.AutoSize = True
        APELLIDOSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        APELLIDOSLabel.Location = New System.Drawing.Point(42, 85)
        APELLIDOSLabel.Name = "APELLIDOSLabel"
        APELLIDOSLabel.Size = New System.Drawing.Size(73, 20)
        APELLIDOSLabel.TabIndex = 30
        APELLIDOSLabel.Text = "Apellidos"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Label1.Location = New System.Drawing.Point(23, 118)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(92, 20)
        Label1.TabIndex = 31
        Label1.Text = "Contraseña"
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(125, 115)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(180, 26)
        Me.txtPass.TabIndex = 35
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(308, 114)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(99, 28)
        Me.btnActualizar.TabIndex = 36
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(125, 21)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(71, 20)
        Me.lblUser.TabIndex = 37
        Me.lblUser.Text = "Usuario"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(125, 53)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(71, 20)
        Me.lblNombre.TabIndex = 38
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.Location = New System.Drawing.Point(125, 85)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(82, 20)
        Me.lblApellidos.TabIndex = 39
        Me.lblApellidos.Text = "Apellidos"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblApellidos)
        Me.Panel1.Controls.Add(APELLIDOSLabel)
        Me.Panel1.Controls.Add(Me.lblNombre)
        Me.Panel1.Controls.Add(NOMBRELabel)
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.Controls.Add(USUARIOLabel)
        Me.Panel1.Controls.Add(Me.btnActualizar)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(Me.txtPass)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(442, 166)
        Me.Panel1.TabIndex = 40
        '
        'frmContrasenia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 189)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmContrasenia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Contraseña"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellidos As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
