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
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVentanilla = New System.Windows.Forms.TextBox()
        Me.grpboxGestiones = New System.Windows.Forms.GroupBox()
        Me.btnQuitarSeleccion = New System.Windows.Forms.Button()
        Me.btnQuitarTodas = New System.Windows.Forms.Button()
        Me.btnAsignarSeleccion = New System.Windows.Forms.Button()
        Me.btnAsignarTodas = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvGestionesAsignadas = New System.Windows.Forms.DataGridView()
        Me.dgvGestionesNoAsignadas = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.grpboxGestiones.SuspendLayout()
        CType(Me.dgvGestionesAsignadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGestionesNoAsignadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnAgregar.Location = New System.Drawing.Point(318, 195)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 26)
        Me.btnAgregar.TabIndex = 46
        Me.btnAgregar.Text = "Agregar ventanilla"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 20)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Nueva ventanilla"
        '
        'txtVentanilla
        '
        Me.txtVentanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtVentanilla.Location = New System.Drawing.Point(156, 195)
        Me.txtVentanilla.Name = "txtVentanilla"
        Me.txtVentanilla.Size = New System.Drawing.Size(156, 26)
        Me.txtVentanilla.TabIndex = 44
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
        Me.grpboxGestiones.Location = New System.Drawing.Point(456, 17)
        Me.grpboxGestiones.Name = "grpboxGestiones"
        Me.grpboxGestiones.Size = New System.Drawing.Size(723, 407)
        Me.grpboxGestiones.TabIndex = 43
        Me.grpboxGestiones.TabStop = False
        Me.grpboxGestiones.Text = "Gestiones"
        '
        'btnQuitarSeleccion
        '
        Me.btnQuitarSeleccion.Location = New System.Drawing.Point(361, 360)
        Me.btnQuitarSeleccion.Name = "btnQuitarSeleccion"
        Me.btnQuitarSeleccion.Size = New System.Drawing.Size(191, 40)
        Me.btnQuitarSeleccion.TabIndex = 7
        Me.btnQuitarSeleccion.Text = "Quitar seleccionadas"
        Me.btnQuitarSeleccion.UseVisualStyleBackColor = True
        '
        'btnQuitarTodas
        '
        Me.btnQuitarTodas.Location = New System.Drawing.Point(558, 360)
        Me.btnQuitarTodas.Name = "btnQuitarTodas"
        Me.btnQuitarTodas.Size = New System.Drawing.Size(140, 40)
        Me.btnQuitarTodas.TabIndex = 6
        Me.btnQuitarTodas.Text = "Quitar todas"
        Me.btnQuitarTodas.UseVisualStyleBackColor = True
        '
        'btnAsignarSeleccion
        '
        Me.btnAsignarSeleccion.Location = New System.Drawing.Point(18, 360)
        Me.btnAsignarSeleccion.Name = "btnAsignarSeleccion"
        Me.btnAsignarSeleccion.Size = New System.Drawing.Size(191, 40)
        Me.btnAsignarSeleccion.TabIndex = 5
        Me.btnAsignarSeleccion.Text = "Asignar seleccionadas"
        Me.btnAsignarSeleccion.UseVisualStyleBackColor = True
        '
        'btnAsignarTodas
        '
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
        Me.dgvGestionesNoAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGestionesNoAsignadas.Location = New System.Drawing.Point(18, 68)
        Me.dgvGestionesNoAsignadas.Name = "dgvGestionesNoAsignadas"
        Me.dgvGestionesNoAsignadas.ReadOnly = True
        Me.dgvGestionesNoAsignadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGestionesNoAsignadas.Size = New System.Drawing.Size(337, 286)
        Me.dgvGestionesNoAsignadas.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(156, 238)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(294, 186)
        Me.DataGridView1.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(77, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Oficinas"
        '
        'ComboBox5
        '
        Me.ComboBox5.DisplayMember = "NOMBRE_OFICINA"
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(156, 152)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(294, 28)
        Me.ComboBox5.TabIndex = 40
        Me.ComboBox5.ValueMember = "IDOFICINA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Sucursales"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Municipio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Departamento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 20)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Pais"
        '
        'ComboBox4
        '
        Me.ComboBox4.DisplayMember = "NOMBRE"
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(156, 119)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(294, 28)
        Me.ComboBox4.TabIndex = 35
        Me.ComboBox4.ValueMember = "IDSUCURSAL"
        '
        'ComboBox3
        '
        Me.ComboBox3.DisplayMember = "NOMBRE_MPIO"
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(156, 85)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(294, 28)
        Me.ComboBox3.TabIndex = 34
        Me.ComboBox3.ValueMember = "IDMUNICIPIO"
        '
        'ComboBox2
        '
        Me.ComboBox2.DisplayMember = "NOMBRE_DEPTO"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(156, 51)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(294, 28)
        Me.ComboBox2.TabIndex = 33
        Me.ComboBox2.ValueMember = "IDDEPARTAMENTO"
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "NOMBRE"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(156, 17)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(294, 28)
        Me.ComboBox1.TabIndex = 32
        Me.ComboBox1.ValueMember = "IDPAIS"
        '
        'frmVentanillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 443)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtVentanilla)
        Me.Controls.Add(Me.grpboxGestiones)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "frmVentanillas"
        Me.Text = "frmVentanillas"
        Me.grpboxGestiones.ResumeLayout(False)
        CType(Me.dgvGestionesAsignadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGestionesNoAsignadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtVentanilla As System.Windows.Forms.TextBox
    Friend WithEvents grpboxGestiones As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuitarSeleccion As System.Windows.Forms.Button
    Friend WithEvents btnQuitarTodas As System.Windows.Forms.Button
    Friend WithEvents btnAsignarSeleccion As System.Windows.Forms.Button
    Friend WithEvents btnAsignarTodas As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvGestionesAsignadas As System.Windows.Forms.DataGridView
    Friend WithEvents dgvGestionesNoAsignadas As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
