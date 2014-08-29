<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuariosSucursal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuariosSucursal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ResetearContraseñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(28, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Buscar por usuario y/o nombre"
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.ContextMenuStrip = Me.ContextMenuStrip2
        Me.dgvUsuarios.Location = New System.Drawing.Point(27, 56)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(594, 254)
        Me.dgvUsuarios.TabIndex = 4
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetearContraseñaToolStripMenuItem, Me.EditarUsuarioToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(180, 48)
        '
        'ResetearContraseñaToolStripMenuItem
        '
        Me.ResetearContraseñaToolStripMenuItem.Image = CType(resources.GetObject("ResetearContraseñaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ResetearContraseñaToolStripMenuItem.Name = "ResetearContraseñaToolStripMenuItem"
        Me.ResetearContraseñaToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ResetearContraseñaToolStripMenuItem.Text = "Resetear contraseña"
        '
        'EditarUsuarioToolStripMenuItem
        '
        Me.EditarUsuarioToolStripMenuItem.Image = CType(resources.GetObject("EditarUsuarioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditarUsuarioToolStripMenuItem.Name = "EditarUsuarioToolStripMenuItem"
        Me.EditarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.EditarUsuarioToolStripMenuItem.Text = "Editar usuario"
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtBuscar.ForeColor = System.Drawing.Color.Black
        Me.txtBuscar.Location = New System.Drawing.Point(237, 20)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(384, 27)
        Me.txtBuscar.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.dgvUsuarios)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 333)
        Me.Panel1.TabIndex = 6
        '
        'frmUsuariosSucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 356)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmUsuariosSucursal"
        Me.Text = "Búsqueda de usuarios"
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ResetearContraseñaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
