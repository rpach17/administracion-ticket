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
        Me.dgvSucursales = New System.Windows.Forms.DataGridView()
        Me.txtBuscarSucursal = New System.Windows.Forms.TextBox()
        Me.dgvOficinas = New System.Windows.Forms.DataGridView()
        Me.cboOficicinas = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        CType(Me.dgvSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOficinas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSucursales
        '
        Me.dgvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSucursales.Location = New System.Drawing.Point(12, 35)
        Me.dgvSucursales.Name = "dgvSucursales"
        Me.dgvSucursales.Size = New System.Drawing.Size(240, 282)
        Me.dgvSucursales.TabIndex = 0
        '
        'txtBuscarSucursal
        '
        Me.txtBuscarSucursal.Location = New System.Drawing.Point(12, 9)
        Me.txtBuscarSucursal.Name = "txtBuscarSucursal"
        Me.txtBuscarSucursal.Size = New System.Drawing.Size(240, 20)
        Me.txtBuscarSucursal.TabIndex = 1
        '
        'dgvOficinas
        '
        Me.dgvOficinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOficinas.Location = New System.Drawing.Point(258, 79)
        Me.dgvOficinas.Name = "dgvOficinas"
        Me.dgvOficinas.Size = New System.Drawing.Size(240, 238)
        Me.dgvOficinas.TabIndex = 2
        '
        'cboOficicinas
        '
        Me.cboOficicinas.FormattingEnabled = True
        Me.cboOficicinas.Location = New System.Drawing.Point(258, 8)
        Me.cboOficicinas.Name = "cboOficicinas"
        Me.cboOficicinas.Size = New System.Drawing.Size(240, 21)
        Me.cboOficicinas.TabIndex = 3
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(380, 35)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(118, 38)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'frmSucursalesOficinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 329)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.cboOficicinas)
        Me.Controls.Add(Me.dgvOficinas)
        Me.Controls.Add(Me.txtBuscarSucursal)
        Me.Controls.Add(Me.dgvSucursales)
        Me.Name = "frmSucursalesOficinas"
        Me.Text = "frmSucursalesOficinas"
        CType(Me.dgvSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOficinas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSucursales As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscarSucursal As System.Windows.Forms.TextBox
    Friend WithEvents dgvOficinas As System.Windows.Forms.DataGridView
    Friend WithEvents cboOficicinas As System.Windows.Forms.ComboBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
End Class
