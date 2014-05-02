<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequisitos
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
        Me.txtRequisito = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkOpcional = New System.Windows.Forms.CheckBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvRequisitos = New System.Windows.Forms.DataGridView()
        CType(Me.dgvRequisitos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRequisito
        '
        Me.txtRequisito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRequisito.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtRequisito.Location = New System.Drawing.Point(85, 24)
        Me.txtRequisito.Name = "txtRequisito"
        Me.txtRequisito.Size = New System.Drawing.Size(344, 24)
        Me.txtRequisito.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(9, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Requisito"
        '
        'chkOpcional
        '
        Me.chkOpcional.AutoSize = True
        Me.chkOpcional.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.chkOpcional.Location = New System.Drawing.Point(85, 54)
        Me.chkOpcional.Name = "chkOpcional"
        Me.chkOpcional.Size = New System.Drawing.Size(86, 22)
        Me.chkOpcional.TabIndex = 2
        Me.chkOpcional.Text = "Opcional"
        Me.chkOpcional.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnAgregar.Location = New System.Drawing.Point(85, 82)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(112, 31)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvRequisitos
        '
        Me.dgvRequisitos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvRequisitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRequisitos.Location = New System.Drawing.Point(12, 119)
        Me.dgvRequisitos.Name = "dgvRequisitos"
        Me.dgvRequisitos.ReadOnly = True
        Me.dgvRequisitos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRequisitos.Size = New System.Drawing.Size(417, 211)
        Me.dgvRequisitos.TabIndex = 4
        '
        'frmRequisitos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 342)
        Me.Controls.Add(Me.dgvRequisitos)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.chkOpcional)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRequisito)
        Me.Name = "frmRequisitos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Requisitos"
        CType(Me.dgvRequisitos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRequisito As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkOpcional As System.Windows.Forms.CheckBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents dgvRequisitos As System.Windows.Forms.DataGridView
End Class
