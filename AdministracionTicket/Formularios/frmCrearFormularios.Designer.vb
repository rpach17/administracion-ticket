<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrearFormularios
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.panelCampos = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cboComboForm = New System.Windows.Forms.ComboBox()
        Me.btnAgregarSQL = New System.Windows.Forms.Button()
        Me.lblArchivo = New System.Windows.Forms.TextBox()
        Me.btnSubir = New System.Windows.Forms.Button()
        Me.txtIdComboBox = New System.Windows.Forms.TextBox()
        Me.btnNuevoCampo = New System.Windows.Forms.Button()
        Me.btnAgregarCampo = New System.Windows.Forms.Button()
        Me.btnAsignarDatosCampo = New System.Windows.Forms.Button()
        Me.chkSoloLectura = New System.Windows.Forms.CheckBox()
        Me.chkRequerido = New System.Windows.Forms.CheckBox()
        Me.numOrden = New System.Windows.Forms.NumericUpDown()
        Me.numLogitud = New System.Windows.Forms.NumericUpDown()
        Me.cboValidacion = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboTiposCampo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNombreCombobox = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMascara = New System.Windows.Forms.TextBox()
        Me.txtEtiqueta = New System.Windows.Forms.TextBox()
        Me.txtNombreCampo = New System.Windows.Forms.TextBox()
        Me.dgvCampos = New System.Windows.Forms.DataGridView()
        Me.btnNuevoForm = New System.Windows.Forms.Button()
        Me.btnGuardarForm = New System.Windows.Forms.Button()
        Me.cboFormPadre = New System.Windows.Forms.ComboBox()
        Me.chkEsGrid = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.OpenF = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.panelCampos.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.numOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numLogitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.chkActivo)
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Controls.Add(Me.panelCampos)
        Me.Panel1.Controls.Add(Me.btnNuevoForm)
        Me.Panel1.Controls.Add(Me.btnGuardarForm)
        Me.Panel1.Controls.Add(Me.cboFormPadre)
        Me.Panel1.Controls.Add(Me.chkEsGrid)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtTitulo)
        Me.Panel1.Location = New System.Drawing.Point(12, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(876, 478)
        Me.Panel1.TabIndex = 0
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkActivo.Location = New System.Drawing.Point(173, 75)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkActivo.Size = New System.Drawing.Size(65, 21)
        Me.chkActivo.TabIndex = 7
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(876, 30)
        Me.lblTitulo.TabIndex = 6
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelCampos
        '
        Me.panelCampos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelCampos.Controls.Add(Me.Label3)
        Me.panelCampos.Controls.Add(Me.SplitContainer1)
        Me.panelCampos.Location = New System.Drawing.Point(25, 180)
        Me.panelCampos.Name = "panelCampos"
        Me.panelCampos.Size = New System.Drawing.Size(827, 277)
        Me.panelCampos.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(827, 35)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Campos del formulario"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 38)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboComboForm)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAgregarSQL)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblArchivo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSubir)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtIdComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnNuevoCampo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAgregarCampo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAsignarDatosCampo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkSoloLectura)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkRequerido)
        Me.SplitContainer1.Panel1.Controls.Add(Me.numOrden)
        Me.SplitContainer1.Panel1.Controls.Add(Me.numLogitud)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboValidacion)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboTiposCampo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblNombreCombobox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtMascara)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtEtiqueta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtNombreCampo)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvCampos)
        Me.SplitContainer1.Size = New System.Drawing.Size(827, 239)
        Me.SplitContainer1.SplitterDistance = 453
        Me.SplitContainer1.TabIndex = 0
        '
        'cboComboForm
        '
        Me.cboComboForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboComboForm.FormattingEnabled = True
        Me.cboComboForm.Location = New System.Drawing.Point(128, 121)
        Me.cboComboForm.Name = "cboComboForm"
        Me.cboComboForm.Size = New System.Drawing.Size(295, 21)
        Me.cboComboForm.TabIndex = 14
        Me.cboComboForm.Visible = False
        '
        'btnAgregarSQL
        '
        Me.btnAgregarSQL.Location = New System.Drawing.Point(313, 15)
        Me.btnAgregarSQL.Name = "btnAgregarSQL"
        Me.btnAgregarSQL.Size = New System.Drawing.Size(88, 23)
        Me.btnAgregarSQL.TabIndex = 13
        Me.btnAgregarSQL.Text = "Agregar SQL"
        Me.btnAgregarSQL.UseVisualStyleBackColor = True
        Me.btnAgregarSQL.Visible = False
        '
        'lblArchivo
        '
        Me.lblArchivo.Location = New System.Drawing.Point(313, 43)
        Me.lblArchivo.Name = "lblArchivo"
        Me.lblArchivo.ReadOnly = True
        Me.lblArchivo.Size = New System.Drawing.Size(123, 20)
        Me.lblArchivo.TabIndex = 12
        Me.lblArchivo.Visible = False
        '
        'btnSubir
        '
        Me.btnSubir.Location = New System.Drawing.Point(312, 15)
        Me.btnSubir.Name = "btnSubir"
        Me.btnSubir.Size = New System.Drawing.Size(29, 23)
        Me.btnSubir.TabIndex = 11
        Me.btnSubir.Text = "..."
        Me.btnSubir.UseVisualStyleBackColor = True
        Me.btnSubir.Visible = False
        '
        'txtIdComboBox
        '
        Me.txtIdComboBox.Location = New System.Drawing.Point(401, 89)
        Me.txtIdComboBox.Name = "txtIdComboBox"
        Me.txtIdComboBox.Size = New System.Drawing.Size(36, 20)
        Me.txtIdComboBox.TabIndex = 10
        Me.txtIdComboBox.Visible = False
        '
        'btnNuevoCampo
        '
        Me.btnNuevoCampo.Location = New System.Drawing.Point(277, 176)
        Me.btnNuevoCampo.Name = "btnNuevoCampo"
        Me.btnNuevoCampo.Size = New System.Drawing.Size(143, 33)
        Me.btnNuevoCampo.TabIndex = 9
        Me.btnNuevoCampo.Text = "Nuevo campo"
        Me.btnNuevoCampo.UseVisualStyleBackColor = True
        Me.btnNuevoCampo.Visible = False
        '
        'btnAgregarCampo
        '
        Me.btnAgregarCampo.Location = New System.Drawing.Point(128, 176)
        Me.btnAgregarCampo.Name = "btnAgregarCampo"
        Me.btnAgregarCampo.Size = New System.Drawing.Size(143, 33)
        Me.btnAgregarCampo.TabIndex = 9
        Me.btnAgregarCampo.Text = "Guardar"
        Me.btnAgregarCampo.UseVisualStyleBackColor = True
        '
        'btnAsignarDatosCampo
        '
        Me.btnAsignarDatosCampo.Location = New System.Drawing.Point(313, 15)
        Me.btnAsignarDatosCampo.Name = "btnAsignarDatosCampo"
        Me.btnAsignarDatosCampo.Size = New System.Drawing.Size(110, 23)
        Me.btnAsignarDatosCampo.TabIndex = 1
        Me.btnAsignarDatosCampo.Text = "Datos lista"
        Me.btnAsignarDatosCampo.UseVisualStyleBackColor = True
        Me.btnAsignarDatosCampo.Visible = False
        '
        'chkSoloLectura
        '
        Me.chkSoloLectura.AutoSize = True
        Me.chkSoloLectura.Location = New System.Drawing.Point(313, 91)
        Me.chkSoloLectura.Name = "chkSoloLectura"
        Me.chkSoloLectura.Size = New System.Drawing.Size(82, 17)
        Me.chkSoloLectura.TabIndex = 8
        Me.chkSoloLectura.Text = "Solo lectura"
        Me.chkSoloLectura.UseVisualStyleBackColor = True
        '
        'chkRequerido
        '
        Me.chkRequerido.AutoSize = True
        Me.chkRequerido.Location = New System.Drawing.Point(313, 68)
        Me.chkRequerido.Name = "chkRequerido"
        Me.chkRequerido.Size = New System.Drawing.Size(75, 17)
        Me.chkRequerido.TabIndex = 7
        Me.chkRequerido.Text = "Requerido"
        Me.chkRequerido.UseVisualStyleBackColor = True
        '
        'numOrden
        '
        Me.numOrden.Location = New System.Drawing.Point(243, 95)
        Me.numOrden.Name = "numOrden"
        Me.numOrden.Size = New System.Drawing.Size(65, 20)
        Me.numOrden.TabIndex = 4
        '
        'numLogitud
        '
        Me.numLogitud.Location = New System.Drawing.Point(128, 95)
        Me.numLogitud.Name = "numLogitud"
        Me.numLogitud.Size = New System.Drawing.Size(65, 20)
        Me.numLogitud.TabIndex = 4
        Me.numLogitud.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'cboValidacion
        '
        Me.cboValidacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboValidacion.FormattingEnabled = True
        Me.cboValidacion.Location = New System.Drawing.Point(128, 121)
        Me.cboValidacion.Name = "cboValidacion"
        Me.cboValidacion.Size = New System.Drawing.Size(179, 21)
        Me.cboValidacion.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(201, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Orden"
        '
        'cboTiposCampo
        '
        Me.cboTiposCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTiposCampo.FormattingEnabled = True
        Me.cboTiposCampo.Location = New System.Drawing.Point(128, 16)
        Me.cboTiposCampo.Name = "cboTiposCampo"
        Me.cboTiposCampo.Size = New System.Drawing.Size(179, 21)
        Me.cboTiposCampo.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(75, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Longitud"
        '
        'lblNombreCombobox
        '
        Me.lblNombreCombobox.AutoSize = True
        Me.lblNombreCombobox.Location = New System.Drawing.Point(65, 124)
        Me.lblNombreCombobox.Name = "lblNombreCombobox"
        Me.lblNombreCombobox.Size = New System.Drawing.Size(56, 13)
        Me.lblNombreCombobox.TabIndex = 1
        Me.lblNombreCombobox.Text = "Validación"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(75, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Máscara"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Etiqueta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Tipo de campo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nombre del campo"
        '
        'txtMascara
        '
        Me.txtMascara.Location = New System.Drawing.Point(128, 148)
        Me.txtMascara.Name = "txtMascara"
        Me.txtMascara.Size = New System.Drawing.Size(295, 20)
        Me.txtMascara.TabIndex = 6
        '
        'txtEtiqueta
        '
        Me.txtEtiqueta.Location = New System.Drawing.Point(128, 69)
        Me.txtEtiqueta.Name = "txtEtiqueta"
        Me.txtEtiqueta.Size = New System.Drawing.Size(179, 20)
        Me.txtEtiqueta.TabIndex = 3
        '
        'txtNombreCampo
        '
        Me.txtNombreCampo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtNombreCampo.Location = New System.Drawing.Point(128, 43)
        Me.txtNombreCampo.Name = "txtNombreCampo"
        Me.txtNombreCampo.Size = New System.Drawing.Size(179, 20)
        Me.txtNombreCampo.TabIndex = 2
        '
        'dgvCampos
        '
        Me.dgvCampos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCampos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvCampos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCampos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCampos.Location = New System.Drawing.Point(0, 0)
        Me.dgvCampos.MultiSelect = False
        Me.dgvCampos.Name = "dgvCampos"
        Me.dgvCampos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCampos.Size = New System.Drawing.Size(370, 239)
        Me.dgvCampos.TabIndex = 0
        '
        'btnNuevoForm
        '
        Me.btnNuevoForm.Location = New System.Drawing.Point(311, 131)
        Me.btnNuevoForm.Name = "btnNuevoForm"
        Me.btnNuevoForm.Size = New System.Drawing.Size(132, 37)
        Me.btnNuevoForm.TabIndex = 3
        Me.btnNuevoForm.Text = "Nuevo formulario"
        Me.btnNuevoForm.UseVisualStyleBackColor = True
        Me.btnNuevoForm.Visible = False
        '
        'btnGuardarForm
        '
        Me.btnGuardarForm.Location = New System.Drawing.Point(173, 131)
        Me.btnGuardarForm.Name = "btnGuardarForm"
        Me.btnGuardarForm.Size = New System.Drawing.Size(132, 37)
        Me.btnGuardarForm.TabIndex = 3
        Me.btnGuardarForm.Text = "Guardar formulario"
        Me.btnGuardarForm.UseVisualStyleBackColor = True
        '
        'cboFormPadre
        '
        Me.cboFormPadre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormPadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboFormPadre.FormattingEnabled = True
        Me.cboFormPadre.Location = New System.Drawing.Point(174, 101)
        Me.cboFormPadre.Name = "cboFormPadre"
        Me.cboFormPadre.Size = New System.Drawing.Size(389, 24)
        Me.cboFormPadre.TabIndex = 2
        '
        'chkEsGrid
        '
        Me.chkEsGrid.AutoSize = True
        Me.chkEsGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkEsGrid.Location = New System.Drawing.Point(256, 75)
        Me.chkEsGrid.Name = "chkEsGrid"
        Me.chkEsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkEsGrid.Size = New System.Drawing.Size(74, 21)
        Me.chkEsGrid.TabIndex = 1
        Me.chkEsGrid.Text = "Es Grid"
        Me.chkEsGrid.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(50, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Formulario padre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(35, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Título del formulario"
        '
        'txtTitulo
        '
        Me.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTitulo.Location = New System.Drawing.Point(174, 48)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(389, 23)
        Me.txtTitulo.TabIndex = 0
        '
        'OpenF
        '
        Me.OpenF.FileName = "OpenFileDialog1"
        '
        'frmCrearFormularios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 505)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCrearFormularios"
        Me.Text = "Crear formulario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelCampos.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.numOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numLogitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCampos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboFormPadre As System.Windows.Forms.ComboBox
    Friend WithEvents chkEsGrid As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardarForm As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents panelCampos As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnAsignarDatosCampo As System.Windows.Forms.Button
    Friend WithEvents chkSoloLectura As System.Windows.Forms.CheckBox
    Friend WithEvents chkRequerido As System.Windows.Forms.CheckBox
    Friend WithEvents numLogitud As System.Windows.Forms.NumericUpDown
    Friend WithEvents cboValidacion As System.Windows.Forms.ComboBox
    Friend WithEvents cboTiposCampo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblNombreCombobox As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMascara As System.Windows.Forms.TextBox
    Friend WithEvents txtEtiqueta As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreCampo As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarCampo As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents numOrden As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnNuevoForm As System.Windows.Forms.Button
    Friend WithEvents txtIdComboBox As System.Windows.Forms.TextBox
    Friend WithEvents dgvCampos As System.Windows.Forms.DataGridView
    Friend WithEvents btnNuevoCampo As System.Windows.Forms.Button
    Friend WithEvents btnSubir As System.Windows.Forms.Button
    Friend WithEvents OpenF As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblArchivo As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarSQL As System.Windows.Forms.Button
    Friend WithEvents cboComboForm As System.Windows.Forms.ComboBox
End Class
