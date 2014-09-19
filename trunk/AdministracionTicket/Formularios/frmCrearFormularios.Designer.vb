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
        Me.panelCampos = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnAgregarCampo = New System.Windows.Forms.Button()
        Me.btnAsignarDatosCampo = New System.Windows.Forms.Button()
        Me.chkSoloLectura = New System.Windows.Forms.CheckBox()
        Me.chkRequerido = New System.Windows.Forms.CheckBox()
        Me.numLogitud = New System.Windows.Forms.NumericUpDown()
        Me.cboValidacion = New System.Windows.Forms.ComboBox()
        Me.cboTiposCampo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMascara = New System.Windows.Forms.TextBox()
        Me.txtEtiqueta = New System.Windows.Forms.TextBox()
        Me.txtNombreCampo = New System.Windows.Forms.TextBox()
        Me.dgvCampos = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnGuardarForm = New System.Windows.Forms.Button()
        Me.cboFormPadre = New System.Windows.Forms.ComboBox()
        Me.chkEsGrid = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.numOrden = New System.Windows.Forms.NumericUpDown()
        Me.Panel1.SuspendLayout()
        Me.panelCampos.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.numLogitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.chkActivo)
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Controls.Add(Me.panelCampos)
        Me.Panel1.Controls.Add(Me.btnGuardarForm)
        Me.Panel1.Controls.Add(Me.cboFormPadre)
        Me.Panel1.Controls.Add(Me.chkEsGrid)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtTitulo)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(876, 454)
        Me.Panel1.TabIndex = 0
        '
        'panelCampos
        '
        Me.panelCampos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelCampos.Controls.Add(Me.Label3)
        Me.panelCampos.Controls.Add(Me.SplitContainer1)
        Me.panelCampos.Location = New System.Drawing.Point(25, 180)
        Me.panelCampos.Name = "panelCampos"
        Me.panelCampos.Size = New System.Drawing.Size(827, 257)
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(827, 219)
        Me.SplitContainer1.SplitterDistance = 453
        Me.SplitContainer1.TabIndex = 0
        '
        'btnAgregarCampo
        '
        Me.btnAgregarCampo.Location = New System.Drawing.Point(137, 176)
        Me.btnAgregarCampo.Name = "btnAgregarCampo"
        Me.btnAgregarCampo.Size = New System.Drawing.Size(179, 33)
        Me.btnAgregarCampo.TabIndex = 9
        Me.btnAgregarCampo.Text = "Agregar campo"
        Me.btnAgregarCampo.UseVisualStyleBackColor = True
        '
        'btnAsignarDatosCampo
        '
        Me.btnAsignarDatosCampo.Location = New System.Drawing.Point(322, 15)
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
        Me.chkSoloLectura.Location = New System.Drawing.Point(322, 68)
        Me.chkSoloLectura.Name = "chkSoloLectura"
        Me.chkSoloLectura.Size = New System.Drawing.Size(82, 17)
        Me.chkSoloLectura.TabIndex = 8
        Me.chkSoloLectura.Text = "Solo lectura"
        Me.chkSoloLectura.UseVisualStyleBackColor = True
        '
        'chkRequerido
        '
        Me.chkRequerido.AutoSize = True
        Me.chkRequerido.Location = New System.Drawing.Point(322, 45)
        Me.chkRequerido.Name = "chkRequerido"
        Me.chkRequerido.Size = New System.Drawing.Size(75, 17)
        Me.chkRequerido.TabIndex = 7
        Me.chkRequerido.Text = "Requerido"
        Me.chkRequerido.UseVisualStyleBackColor = True
        '
        'numLogitud
        '
        Me.numLogitud.Location = New System.Drawing.Point(137, 95)
        Me.numLogitud.Name = "numLogitud"
        Me.numLogitud.Size = New System.Drawing.Size(65, 20)
        Me.numLogitud.TabIndex = 4
        '
        'cboValidacion
        '
        Me.cboValidacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboValidacion.FormattingEnabled = True
        Me.cboValidacion.Location = New System.Drawing.Point(137, 121)
        Me.cboValidacion.Name = "cboValidacion"
        Me.cboValidacion.Size = New System.Drawing.Size(179, 21)
        Me.cboValidacion.TabIndex = 5
        '
        'cboTiposCampo
        '
        Me.cboTiposCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTiposCampo.FormattingEnabled = True
        Me.cboTiposCampo.Location = New System.Drawing.Point(137, 16)
        Me.cboTiposCampo.Name = "cboTiposCampo"
        Me.cboTiposCampo.Size = New System.Drawing.Size(179, 21)
        Me.cboTiposCampo.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(84, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Longitud"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(74, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Validación"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(84, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Máscara"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(84, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Etiqueta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Tipo de campo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nombre del campo"
        '
        'txtMascara
        '
        Me.txtMascara.Location = New System.Drawing.Point(137, 148)
        Me.txtMascara.Name = "txtMascara"
        Me.txtMascara.Size = New System.Drawing.Size(179, 20)
        Me.txtMascara.TabIndex = 6
        '
        'txtEtiqueta
        '
        Me.txtEtiqueta.Location = New System.Drawing.Point(137, 69)
        Me.txtEtiqueta.Name = "txtEtiqueta"
        Me.txtEtiqueta.Size = New System.Drawing.Size(179, 20)
        Me.txtEtiqueta.TabIndex = 3
        '
        'txtNombreCampo
        '
        Me.txtNombreCampo.Location = New System.Drawing.Point(137, 43)
        Me.txtNombreCampo.Name = "txtNombreCampo"
        Me.txtNombreCampo.Size = New System.Drawing.Size(179, 20)
        Me.txtNombreCampo.TabIndex = 2
        '
        'dgvCampos
        '
        Me.dgvCampos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCampos.Location = New System.Drawing.Point(0, 0)
        Me.dgvCampos.MainView = Me.GridView1
        Me.dgvCampos.Name = "dgvCampos"
        Me.dgvCampos.Size = New System.Drawing.Size(370, 219)
        Me.dgvCampos.TabIndex = 0
        Me.dgvCampos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.dgvCampos
        Me.GridView1.Name = "GridView1"
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
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(876, 30)
        Me.lblTitulo.TabIndex = 6
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(210, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Orden"
        '
        'numOrden
        '
        Me.numOrden.Location = New System.Drawing.Point(252, 95)
        Me.numOrden.Name = "numOrden"
        Me.numOrden.Size = New System.Drawing.Size(65, 20)
        Me.numOrden.TabIndex = 4
        '
        'frmCrearFormularios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 478)
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
        CType(Me.numLogitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numOrden, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMascara As System.Windows.Forms.TextBox
    Friend WithEvents txtEtiqueta As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreCampo As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarCampo As System.Windows.Forms.Button
    Friend WithEvents dgvCampos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents numOrden As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
