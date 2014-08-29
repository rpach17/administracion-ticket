<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DEPARTAMENTOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.MUNICIPIOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.dgvSucursales = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarNuevoUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USUARIOS_SUCURSALDataGridView = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ResetearContraseñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DEPARTAMENTOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.MUNICIPIOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.dgvSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.USUARIOS_SUCURSALDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1207, 41)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuarios por zona geográfica"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(10, 50)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.DEPARTAMENTOSDataGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1185, 400)
        Me.SplitContainer1.SplitterDistance = 225
        Me.SplitContainer1.TabIndex = 3
        '
        'DEPARTAMENTOSDataGridView
        '
        Me.DEPARTAMENTOSDataGridView.AllowUserToAddRows = False
        Me.DEPARTAMENTOSDataGridView.AllowUserToDeleteRows = False
        Me.DEPARTAMENTOSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DEPARTAMENTOSDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DEPARTAMENTOSDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DEPARTAMENTOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DEPARTAMENTOSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DEPARTAMENTOSDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.DEPARTAMENTOSDataGridView.MultiSelect = False
        Me.DEPARTAMENTOSDataGridView.Name = "DEPARTAMENTOSDataGridView"
        Me.DEPARTAMENTOSDataGridView.ReadOnly = True
        Me.DEPARTAMENTOSDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DEPARTAMENTOSDataGridView.Size = New System.Drawing.Size(225, 400)
        Me.DEPARTAMENTOSDataGridView.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.MUNICIPIOSDataGridView)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(956, 400)
        Me.SplitContainer2.SplitterDistance = 252
        Me.SplitContainer2.TabIndex = 0
        '
        'MUNICIPIOSDataGridView
        '
        Me.MUNICIPIOSDataGridView.AllowUserToAddRows = False
        Me.MUNICIPIOSDataGridView.AllowUserToDeleteRows = False
        Me.MUNICIPIOSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MUNICIPIOSDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MUNICIPIOSDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.MUNICIPIOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MUNICIPIOSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MUNICIPIOSDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MUNICIPIOSDataGridView.MultiSelect = False
        Me.MUNICIPIOSDataGridView.Name = "MUNICIPIOSDataGridView"
        Me.MUNICIPIOSDataGridView.ReadOnly = True
        Me.MUNICIPIOSDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MUNICIPIOSDataGridView.Size = New System.Drawing.Size(252, 400)
        Me.MUNICIPIOSDataGridView.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.AutoScroll = True
        Me.SplitContainer3.Panel1.Controls.Add(Me.dgvSucursales)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.USUARIOS_SUCURSALDataGridView)
        Me.SplitContainer3.Size = New System.Drawing.Size(700, 400)
        Me.SplitContainer3.SplitterDistance = 233
        Me.SplitContainer3.TabIndex = 0
        '
        'dgvSucursales
        '
        Me.dgvSucursales.AllowUserToAddRows = False
        Me.dgvSucursales.AllowUserToDeleteRows = False
        Me.dgvSucursales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSucursales.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSucursales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSucursales.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvSucursales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSucursales.Location = New System.Drawing.Point(0, 0)
        Me.dgvSucursales.MultiSelect = False
        Me.dgvSucursales.Name = "dgvSucursales"
        Me.dgvSucursales.ReadOnly = True
        Me.dgvSucursales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSucursales.Size = New System.Drawing.Size(233, 400)
        Me.dgvSucursales.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarNuevoUsuarioToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(195, 26)
        '
        'AgregarNuevoUsuarioToolStripMenuItem
        '
        Me.AgregarNuevoUsuarioToolStripMenuItem.Image = CType(resources.GetObject("AgregarNuevoUsuarioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AgregarNuevoUsuarioToolStripMenuItem.Name = "AgregarNuevoUsuarioToolStripMenuItem"
        Me.AgregarNuevoUsuarioToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AgregarNuevoUsuarioToolStripMenuItem.Text = "Agregar nuevo usuario"
        '
        'USUARIOS_SUCURSALDataGridView
        '
        Me.USUARIOS_SUCURSALDataGridView.AllowUserToAddRows = False
        Me.USUARIOS_SUCURSALDataGridView.AllowUserToDeleteRows = False
        Me.USUARIOS_SUCURSALDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.USUARIOS_SUCURSALDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.USUARIOS_SUCURSALDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.USUARIOS_SUCURSALDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.USUARIOS_SUCURSALDataGridView.ContextMenuStrip = Me.ContextMenuStrip2
        Me.USUARIOS_SUCURSALDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.USUARIOS_SUCURSALDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.USUARIOS_SUCURSALDataGridView.MultiSelect = False
        Me.USUARIOS_SUCURSALDataGridView.Name = "USUARIOS_SUCURSALDataGridView"
        Me.USUARIOS_SUCURSALDataGridView.ReadOnly = True
        Me.USUARIOS_SUCURSALDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.USUARIOS_SUCURSALDataGridView.Size = New System.Drawing.Size(463, 400)
        Me.USUARIOS_SUCURSALDataGridView.TabIndex = 0
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
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 456)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de usuarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DEPARTAMENTOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.MUNICIPIOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.dgvSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.USUARIOS_SUCURSALDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DEPARTAMENTOSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents MUNICIPIOSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents USUARIOS_SUCURSALDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents dgvSucursales As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AgregarNuevoUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ResetearContraseñaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
