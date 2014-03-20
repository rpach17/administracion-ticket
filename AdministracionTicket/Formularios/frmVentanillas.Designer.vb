<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentanillas
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
        Me.nudNumeroVent = New System.Windows.Forms.NumericUpDown()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpboxGestiones = New System.Windows.Forms.GroupBox()
        Me.btnQuitarSeleccion = New System.Windows.Forms.Button()
        Me.btnQuitarTodas = New System.Windows.Forms.Button()
        Me.btnAsignarSeleccion = New System.Windows.Forms.Button()
        Me.btnAsignarTodas = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvGestionesAsignadas = New System.Windows.Forms.DataGridView()
        Me.dgvGestionesNoAsignadas = New System.Windows.Forms.DataGridView()
        Me.dgvVentanillas = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboOficinas = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSucursales = New System.Windows.Forms.ComboBox()
        Me.cboMunicipio = New System.Windows.Forms.ComboBox()
        Me.cboDepto = New System.Windows.Forms.ComboBox()
        Me.cboPais = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.nudNumeroVent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpboxGestiones.SuspendLayout()
        CType(Me.dgvGestionesAsignadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGestionesNoAsignadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVentanillas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.nudNumeroVent)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.grpboxGestiones)
        Me.Panel1.Controls.Add(Me.dgvVentanillas)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cboOficinas)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cboSucursales)
        Me.Panel1.Controls.Add(Me.cboMunicipio)
        Me.Panel1.Controls.Add(Me.cboDepto)
        Me.Panel1.Controls.Add(Me.cboPais)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1169, 427)
        Me.Panel1.TabIndex = 0
        '
        'nudNumeroVent
        '
        Me.nudNumeroVent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.nudNumeroVent.Location = New System.Drawing.Point(144, 188)
        Me.nudNumeroVent.Name = "nudNumeroVent"
        Me.nudNumeroVent.Size = New System.Drawing.Size(59, 26)
        Me.nudNumeroVent.TabIndex = 62
        Me.nudNumeroVent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnAgregar.Location = New System.Drawing.Point(209, 188)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(125, 27)
        Me.btnAgregar.TabIndex = 61
        Me.btnAgregar.Text = "Agregar ventanilla"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 20)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Nueva ventanilla"
        '
        'grpboxGestiones
        '
        Me.grpboxGestiones.Controls.Add(Me.btnQuitarSeleccion)
        Me.grpboxGestiones.Controls.Add(Me.btnQuitarTodas)
        Me.grpboxGestiones.Controls.Add(Me.btnAsignarSeleccion)
        Me.grpboxGestiones.Controls.Add(Me.btnAsignarTodas)
        Me.grpboxGestiones.Controls.Add(Me.Label8)
        Me.grpboxGestiones.Controls.Add(Me.Label7)
        Me.grpboxGestiones.Controls.Add(Me.dgvGestionesAsignadas)
        Me.grpboxGestiones.Controls.Add(Me.dgvGestionesNoAsignadas)
        Me.grpboxGestiones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.grpboxGestiones.Location = New System.Drawing.Point(444, 5)
        Me.grpboxGestiones.Name = "grpboxGestiones"
        Me.grpboxGestiones.Size = New System.Drawing.Size(718, 412)
        Me.grpboxGestiones.TabIndex = 59
        Me.grpboxGestiones.TabStop = False
        Me.grpboxGestiones.Text = "Gestiones"
        '
        'btnQuitarSeleccion
        '
        Me.btnQuitarSeleccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnQuitarSeleccion.Location = New System.Drawing.Point(361, 360)
        Me.btnQuitarSeleccion.Name = "btnQuitarSeleccion"
        Me.btnQuitarSeleccion.Size = New System.Drawing.Size(191, 40)
        Me.btnQuitarSeleccion.TabIndex = 7
        Me.btnQuitarSeleccion.Text = "Quitar seleccionadas"
        Me.btnQuitarSeleccion.UseVisualStyleBackColor = True
        '
        'btnQuitarTodas
        '
        Me.btnQuitarTodas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnQuitarTodas.Location = New System.Drawing.Point(558, 360)
        Me.btnQuitarTodas.Name = "btnQuitarTodas"
        Me.btnQuitarTodas.Size = New System.Drawing.Size(140, 40)
        Me.btnQuitarTodas.TabIndex = 6
        Me.btnQuitarTodas.Text = "Quitar todas"
        Me.btnQuitarTodas.UseVisualStyleBackColor = True
        '
        'btnAsignarSeleccion
        '
        Me.btnAsignarSeleccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnAsignarSeleccion.Location = New System.Drawing.Point(18, 360)
        Me.btnAsignarSeleccion.Name = "btnAsignarSeleccion"
        Me.btnAsignarSeleccion.Size = New System.Drawing.Size(191, 40)
        Me.btnAsignarSeleccion.TabIndex = 5
        Me.btnAsignarSeleccion.Text = "Asignar seleccionadas"
        Me.btnAsignarSeleccion.UseVisualStyleBackColor = True
        '
        'btnAsignarTodas
        '
        Me.btnAsignarTodas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnAsignarTodas.Location = New System.Drawing.Point(215, 360)
        Me.btnAsignarTodas.Name = "btnAsignarTodas"
        Me.btnAsignarTodas.Size = New System.Drawing.Size(140, 40)
        Me.btnAsignarTodas.TabIndex = 4
        Me.btnAsignarTodas.Text = "Asignar todas"
        Me.btnAsignarTodas.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Gray
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(361, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(337, 34)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Gestiones asignadas"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Gray
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(18, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(337, 34)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Gestiones sin asignar"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvGestionesAsignadas
        '
        Me.dgvGestionesAsignadas.AllowUserToAddRows = False
        Me.dgvGestionesAsignadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvGestionesAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGestionesAsignadas.Location = New System.Drawing.Point(361, 68)
        Me.dgvGestionesAsignadas.Name = "dgvGestionesAsignadas"
        Me.dgvGestionesAsignadas.ReadOnly = True
        Me.dgvGestionesAsignadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGestionesAsignadas.Size = New System.Drawing.Size(337, 286)
        Me.dgvGestionesAsignadas.TabIndex = 1
        '
        'dgvGestionesNoAsignadas
        '
        Me.dgvGestionesNoAsignadas.AllowUserToAddRows = False
        Me.dgvGestionesNoAsignadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvGestionesNoAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGestionesNoAsignadas.Location = New System.Drawing.Point(18, 68)
        Me.dgvGestionesNoAsignadas.Name = "dgvGestionesNoAsignadas"
        Me.dgvGestionesNoAsignadas.ReadOnly = True
        Me.dgvGestionesNoAsignadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGestionesNoAsignadas.Size = New System.Drawing.Size(337, 286)
        Me.dgvGestionesNoAsignadas.TabIndex = 0
        '
        'dgvVentanillas
        '
        Me.dgvVentanillas.AllowUserToAddRows = False
        Me.dgvVentanillas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvVentanillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentanillas.Location = New System.Drawing.Point(144, 231)
        Me.dgvVentanillas.MultiSelect = False
        Me.dgvVentanillas.Name = "dgvVentanillas"
        Me.dgvVentanillas.ReadOnly = True
        Me.dgvVentanillas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentanillas.Size = New System.Drawing.Size(294, 186)
        Me.dgvVentanillas.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(65, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Oficinas"
        '
        'cboOficinas
        '
        Me.cboOficinas.DisplayMember = "NOMBRE_OFICINA"
        Me.cboOficinas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOficinas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOficinas.FormattingEnabled = True
        Me.cboOficinas.Location = New System.Drawing.Point(144, 145)
        Me.cboOficinas.Name = "cboOficinas"
        Me.cboOficinas.Size = New System.Drawing.Size(294, 28)
        Me.cboOficinas.TabIndex = 56
        Me.cboOficinas.ValueMember = "IDOFICINA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Sucursales"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Municipio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Departamento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 20)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Pais"
        '
        'cboSucursales
        '
        Me.cboSucursales.DisplayMember = "NOMBRE"
        Me.cboSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSucursales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSucursales.FormattingEnabled = True
        Me.cboSucursales.Location = New System.Drawing.Point(144, 112)
        Me.cboSucursales.Name = "cboSucursales"
        Me.cboSucursales.Size = New System.Drawing.Size(294, 28)
        Me.cboSucursales.TabIndex = 51
        Me.cboSucursales.ValueMember = "IDSUCURSAL"
        '
        'cboMunicipio
        '
        Me.cboMunicipio.DisplayMember = "NOMBRE_MPIO"
        Me.cboMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMunicipio.FormattingEnabled = True
        Me.cboMunicipio.Location = New System.Drawing.Point(144, 78)
        Me.cboMunicipio.Name = "cboMunicipio"
        Me.cboMunicipio.Size = New System.Drawing.Size(294, 28)
        Me.cboMunicipio.TabIndex = 50
        Me.cboMunicipio.ValueMember = "IDMUNICIPIO"
        '
        'cboDepto
        '
        Me.cboDepto.DisplayMember = "NOMBRE_DEPTO"
        Me.cboDepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDepto.FormattingEnabled = True
        Me.cboDepto.Location = New System.Drawing.Point(144, 44)
        Me.cboDepto.Name = "cboDepto"
        Me.cboDepto.Size = New System.Drawing.Size(294, 28)
        Me.cboDepto.TabIndex = 49
        Me.cboDepto.ValueMember = "IDDEPARTAMENTO"
        '
        'cboPais
        '
        Me.cboPais.DisplayMember = "NOMBRE"
        Me.cboPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPais.FormattingEnabled = True
        Me.cboPais.Location = New System.Drawing.Point(144, 10)
        Me.cboPais.Name = "cboPais"
        Me.cboPais.Size = New System.Drawing.Size(294, 28)
        Me.cboPais.TabIndex = 48
        Me.cboPais.ValueMember = "IDPAIS"
        '
        'frmVentanillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 451)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmVentanillas"
        Me.Text = "Ventanillas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudNumeroVent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpboxGestiones.ResumeLayout(False)
        CType(Me.dgvGestionesAsignadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGestionesNoAsignadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVentanillas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents nudNumeroVent As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grpboxGestiones As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuitarSeleccion As System.Windows.Forms.Button
    Friend WithEvents btnQuitarTodas As System.Windows.Forms.Button
    Friend WithEvents btnAsignarSeleccion As System.Windows.Forms.Button
    Friend WithEvents btnAsignarTodas As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvGestionesAsignadas As System.Windows.Forms.DataGridView
    Friend WithEvents dgvGestionesNoAsignadas As System.Windows.Forms.DataGridView
    Friend WithEvents dgvVentanillas As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboOficinas As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboSucursales As System.Windows.Forms.ComboBox
    Friend WithEvents cboMunicipio As System.Windows.Forms.ComboBox
    Friend WithEvents cboDepto As System.Windows.Forms.ComboBox
    Friend WithEvents cboPais As System.Windows.Forms.ComboBox
End Class
