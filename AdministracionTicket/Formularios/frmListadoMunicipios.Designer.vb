<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoMunicipios
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
        Me.dgvMunicipios = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvMunicipios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvMunicipios
        '
        Me.dgvMunicipios.AllowUserToAddRows = False
        Me.dgvMunicipios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMunicipios.Location = New System.Drawing.Point(25, 53)
        Me.dgvMunicipios.Name = "dgvMunicipios"
        Me.dgvMunicipios.ReadOnly = True
        Me.dgvMunicipios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMunicipios.Size = New System.Drawing.Size(401, 317)
        Me.dgvMunicipios.TabIndex = 5
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtBuscar.Location = New System.Drawing.Point(86, 21)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(340, 26)
        Me.txtBuscar.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(21, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buscar"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.dgvMunicipios)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(454, 402)
        Me.Panel1.TabIndex = 6
        '
        'frmListadoMunicipios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 428)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmListadoMunicipios"
        Me.Text = "Listado de municipios"
        CType(Me.dgvMunicipios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvMunicipios As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
