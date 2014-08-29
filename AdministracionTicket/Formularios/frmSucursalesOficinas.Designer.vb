<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSucursalesOficinas
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscarSucursal = New System.Windows.Forms.TextBox()
        Me.dgvSucursales = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cboOficicinas = New System.Windows.Forms.ComboBox()
        Me.dgvOficinas = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvOficinas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtBuscarSucursal)
        Me.Panel1.Controls.Add(Me.dgvSucursales)
        Me.Panel1.Location = New System.Drawing.Point(33, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(383, 365)
        Me.Panel1.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(383, 40)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Sucursales"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = Global.AdministracionTicket.My.Resources.Resources.magnifier
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 33)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar sucursal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBuscarSucursal
        '
        Me.txtBuscarSucursal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscarSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtBuscarSucursal.Location = New System.Drawing.Point(170, 49)
        Me.txtBuscarSucursal.Name = "txtBuscarSucursal"
        Me.txtBuscarSucursal.Size = New System.Drawing.Size(203, 23)
        Me.txtBuscarSucursal.TabIndex = 6
        '
        'dgvSucursales
        '
        Me.dgvSucursales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSucursales.Location = New System.Drawing.Point(12, 79)
        Me.dgvSucursales.MultiSelect = False
        Me.dgvSucursales.Name = "dgvSucursales"
        Me.dgvSucursales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSucursales.Size = New System.Drawing.Size(361, 270)
        Me.dgvSucursales.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnQuitar)
        Me.Panel2.Controls.Add(Me.btnAgregar)
        Me.Panel2.Controls.Add(Me.cboOficicinas)
        Me.Panel2.Controls.Add(Me.dgvOficinas)
        Me.Panel2.Location = New System.Drawing.Point(422, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(319, 365)
        Me.Panel2.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(319, 40)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Oficinas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnQuitar
        '
        Me.btnQuitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnQuitar.Location = New System.Drawing.Point(36, 79)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(118, 33)
        Me.btnQuitar.TabIndex = 9
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnAgregar.Location = New System.Drawing.Point(161, 79)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(118, 33)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'cboOficicinas
        '
        Me.cboOficicinas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOficicinas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboOficicinas.FormattingEnabled = True
        Me.cboOficicinas.Location = New System.Drawing.Point(38, 49)
        Me.cboOficicinas.Name = "cboOficicinas"
        Me.cboOficicinas.Size = New System.Drawing.Size(240, 24)
        Me.cboOficicinas.TabIndex = 6
        '
        'dgvOficinas
        '
        Me.dgvOficinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvOficinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOficinas.Location = New System.Drawing.Point(38, 114)
        Me.dgvOficinas.MultiSelect = False
        Me.dgvOficinas.Name = "dgvOficinas"
        Me.dgvOficinas.Size = New System.Drawing.Size(240, 235)
        Me.dgvOficinas.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Location = New System.Drawing.Point(12, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(772, 420)
        Me.Panel3.TabIndex = 17
        '
        'frmSucursalesOficinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 442)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "frmSucursalesOficinas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Oficinas por sucursal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvOficinas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBuscarSucursal As System.Windows.Forms.TextBox
    Friend WithEvents dgvSucursales As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents cboOficicinas As System.Windows.Forms.ComboBox
    Friend WithEvents dgvOficinas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
