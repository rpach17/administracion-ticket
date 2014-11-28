<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ATENCIONXOFICINABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NUMFILADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPARTAMENTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MUNICIPIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUCURSALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OFICINADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREEMPLEADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GESTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GESTIONESATENDIDASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROMEDIOESPERADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROMEDIOATENCIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ATENCIONXOFICINABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUMFILADataGridViewTextBoxColumn, Me.DEPARTAMENTODataGridViewTextBoxColumn, Me.MUNICIPIODataGridViewTextBoxColumn, Me.SUCURSALDataGridViewTextBoxColumn, Me.OFICINADataGridViewTextBoxColumn, Me.NOMBREEMPLEADODataGridViewTextBoxColumn, Me.GESTIONDataGridViewTextBoxColumn, Me.GESTIONESATENDIDASDataGridViewTextBoxColumn, Me.PROMEDIOESPERADataGridViewTextBoxColumn, Me.PROMEDIOATENCIONDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ATENCIONXOFICINABindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(716, 392)
        Me.DataGridView1.TabIndex = 0
        '
        'ATENCIONXOFICINABindingSource
        '
        Me.ATENCIONXOFICINABindingSource.DataSource = GetType(AdministracionTicket.ATENCION_X_OFICINA)
        '
        'NUMFILADataGridViewTextBoxColumn
        '
        Me.NUMFILADataGridViewTextBoxColumn.DataPropertyName = "NUMFILA"
        Me.NUMFILADataGridViewTextBoxColumn.HeaderText = "NUMFILA"
        Me.NUMFILADataGridViewTextBoxColumn.Name = "NUMFILADataGridViewTextBoxColumn"
        '
        'DEPARTAMENTODataGridViewTextBoxColumn
        '
        Me.DEPARTAMENTODataGridViewTextBoxColumn.DataPropertyName = "DEPARTAMENTO"
        Me.DEPARTAMENTODataGridViewTextBoxColumn.HeaderText = "DEPARTAMENTO"
        Me.DEPARTAMENTODataGridViewTextBoxColumn.Name = "DEPARTAMENTODataGridViewTextBoxColumn"
        '
        'MUNICIPIODataGridViewTextBoxColumn
        '
        Me.MUNICIPIODataGridViewTextBoxColumn.DataPropertyName = "MUNICIPIO"
        Me.MUNICIPIODataGridViewTextBoxColumn.HeaderText = "MUNICIPIO"
        Me.MUNICIPIODataGridViewTextBoxColumn.Name = "MUNICIPIODataGridViewTextBoxColumn"
        '
        'SUCURSALDataGridViewTextBoxColumn
        '
        Me.SUCURSALDataGridViewTextBoxColumn.DataPropertyName = "SUCURSAL"
        Me.SUCURSALDataGridViewTextBoxColumn.HeaderText = "SUCURSAL"
        Me.SUCURSALDataGridViewTextBoxColumn.Name = "SUCURSALDataGridViewTextBoxColumn"
        '
        'OFICINADataGridViewTextBoxColumn
        '
        Me.OFICINADataGridViewTextBoxColumn.DataPropertyName = "OFICINA"
        Me.OFICINADataGridViewTextBoxColumn.HeaderText = "OFICINA"
        Me.OFICINADataGridViewTextBoxColumn.Name = "OFICINADataGridViewTextBoxColumn"
        '
        'NOMBREEMPLEADODataGridViewTextBoxColumn
        '
        Me.NOMBREEMPLEADODataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_EMPLEADO"
        Me.NOMBREEMPLEADODataGridViewTextBoxColumn.HeaderText = "NOMBRE_EMPLEADO"
        Me.NOMBREEMPLEADODataGridViewTextBoxColumn.Name = "NOMBREEMPLEADODataGridViewTextBoxColumn"
        '
        'GESTIONDataGridViewTextBoxColumn
        '
        Me.GESTIONDataGridViewTextBoxColumn.DataPropertyName = "GESTION"
        Me.GESTIONDataGridViewTextBoxColumn.HeaderText = "GESTION"
        Me.GESTIONDataGridViewTextBoxColumn.Name = "GESTIONDataGridViewTextBoxColumn"
        '
        'GESTIONESATENDIDASDataGridViewTextBoxColumn
        '
        Me.GESTIONESATENDIDASDataGridViewTextBoxColumn.DataPropertyName = "GESTIONES_ATENDIDAS"
        Me.GESTIONESATENDIDASDataGridViewTextBoxColumn.HeaderText = "GESTIONES_ATENDIDAS"
        Me.GESTIONESATENDIDASDataGridViewTextBoxColumn.Name = "GESTIONESATENDIDASDataGridViewTextBoxColumn"
        '
        'PROMEDIOESPERADataGridViewTextBoxColumn
        '
        Me.PROMEDIOESPERADataGridViewTextBoxColumn.DataPropertyName = "PROMEDIO_ESPERA"
        Me.PROMEDIOESPERADataGridViewTextBoxColumn.HeaderText = "PROMEDIO_ESPERA"
        Me.PROMEDIOESPERADataGridViewTextBoxColumn.Name = "PROMEDIOESPERADataGridViewTextBoxColumn"
        '
        'PROMEDIOATENCIONDataGridViewTextBoxColumn
        '
        Me.PROMEDIOATENCIONDataGridViewTextBoxColumn.DataPropertyName = "PROMEDIO_ATENCION"
        Me.PROMEDIOATENCIONDataGridViewTextBoxColumn.HeaderText = "PROMEDIO_ATENCION"
        Me.PROMEDIOATENCIONDataGridViewTextBoxColumn.Name = "PROMEDIOATENCIONDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 416)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ATENCIONXOFICINABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NUMFILADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPARTAMENTODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MUNICIPIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SUCURSALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OFICINADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBREEMPLEADODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GESTIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GESTIONESATENDIDASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROMEDIOESPERADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROMEDIOATENCIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ATENCIONXOFICINABindingSource As System.Windows.Forms.BindingSource
End Class
