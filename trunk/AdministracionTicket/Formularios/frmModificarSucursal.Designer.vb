<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarSucursal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim NOMBRELabel As System.Windows.Forms.Label
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.txtNombreM = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtLongitud = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLatitud = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIDM = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDireccionS = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NOMBRELabel.Location = New System.Drawing.Point(67, 11)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(73, 20)
        NOMBRELabel.TabIndex = 13
        NOMBRELabel.Text = "Empresa"
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnActualizar.Location = New System.Drawing.Point(244, 343)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(148, 43)
        Me.btnActualizar.TabIndex = 17
        Me.btnActualizar.Text = "Realizar Cambios"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'txtNombreM
        '
        Me.txtNombreM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtNombreM.Location = New System.Drawing.Point(194, 149)
        Me.txtNombreM.Name = "txtNombreM"
        Me.txtNombreM.ReadOnly = True
        Me.txtNombreM.Size = New System.Drawing.Size(198, 26)
        Me.txtNombreM.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtLongitud)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtLatitud)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 199)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 138)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Coordenadas de ubicación"
        '
        'txtLongitud
        '
        Me.txtLongitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtLongitud.Location = New System.Drawing.Point(112, 81)
        Me.txtLongitud.Name = "txtLongitud"
        Me.txtLongitud.Size = New System.Drawing.Size(232, 26)
        Me.txtLongitud.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(35, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Longitud"
        '
        'txtLatitud
        '
        Me.txtLatitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtLatitud.Location = New System.Drawing.Point(112, 49)
        Me.txtLatitud.Name = "txtLatitud"
        Me.txtLatitud.Size = New System.Drawing.Size(232, 26)
        Me.txtLatitud.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(48, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Latitud"
        '
        'txtIDM
        '
        Me.txtIDM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtIDM.Location = New System.Drawing.Point(160, 149)
        Me.txtIDM.Name = "txtIDM"
        Me.txtIDM.ReadOnly = True
        Me.txtIDM.Size = New System.Drawing.Size(35, 26)
        Me.txtIDM.TabIndex = 18
        Me.txtIDM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(65, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Municipio"
        '
        'txtDireccionS
        '
        Me.txtDireccionS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtDireccionS.Location = New System.Drawing.Point(160, 74)
        Me.txtDireccionS.Multiline = True
        Me.txtDireccionS.Name = "txtDireccionS"
        Me.txtDireccionS.Size = New System.Drawing.Size(232, 69)
        Me.txtDireccionS.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(65, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Dirección"
        '
        'txtNombreS
        '
        Me.txtNombreS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtNombreS.Location = New System.Drawing.Point(160, 42)
        Me.txtNombreS.Name = "txtNombreS"
        Me.txtNombreS.Size = New System.Drawing.Size(232, 26)
        Me.txtNombreS.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nombre sucursal"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.Location = New System.Drawing.Point(156, 11)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(73, 20)
        Me.lblEmpresa.TabIndex = 22
        Me.lblEmpresa.Text = "Empresa"
        '
        'frmModificarSucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 401)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.txtNombreM)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtIDM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDireccionS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombreS)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(NOMBRELabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmModificarSucursal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editando Sucursal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents txtNombreM As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLongitud As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLatitud As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtIDM As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDireccionS As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombreS As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
End Class
