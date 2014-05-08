<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaltos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaltos))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Actualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Guardar = New System.Windows.Forms.ToolStripButton()
        Me.Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumPaso = New System.Windows.Forms.NumericUpDown()
        Me.cboPuesto = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkDecision = New System.Windows.Forms.CheckBox()
        Me.cboPasoNo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNo = New System.Windows.Forms.Label()
        Me.lblSi = New System.Windows.Forms.Label()
        Me.cboPasoSi = New System.Windows.Forms.ComboBox()
        Me.chkUltimoPaso = New System.Windows.Forms.CheckBox()
        Me.txtDuracion = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvProcesos = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtNumProceso = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtDescripcion = New System.Windows.Forms.ToolStripTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvPasos = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.txtNumPaso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDuracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProcesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgvPasos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Nuevo, Me.ToolStripSeparator1, Me.Actualizar, Me.ToolStripSeparator2, Me.Guardar, Me.Cancelar, Me.ToolStripSeparator3, Me.Eliminar, Me.ToolStripSeparator4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1261, 48)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Nuevo
        '
        Me.Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Nuevo.Image = CType(resources.GetObject("Nuevo.Image"), System.Drawing.Image)
        Me.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(36, 45)
        Me.Nuevo.Text = "Nuevo Paso"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 48)
        '
        'Actualizar
        '
        Me.Actualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Actualizar.Image = CType(resources.GetObject("Actualizar.Image"), System.Drawing.Image)
        Me.Actualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Size = New System.Drawing.Size(36, 45)
        Me.Actualizar.Text = "Modificar Registro"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 48)
        '
        'Guardar
        '
        Me.Guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Guardar.Image = CType(resources.GetObject("Guardar.Image"), System.Drawing.Image)
        Me.Guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(36, 45)
        Me.Guardar.Text = "Guardar"
        '
        'Cancelar
        '
        Me.Cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cancelar.Image = CType(resources.GetObject("Cancelar.Image"), System.Drawing.Image)
        Me.Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(36, 45)
        Me.Cancelar.Text = "Cancelar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 48)
        '
        'Eliminar
        '
        Me.Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Eliminar.Image = CType(resources.GetObject("Eliminar.Image"), System.Drawing.Image)
        Me.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(36, 45)
        Me.Eliminar.Text = "Eliminar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 48)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(40, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Número de paso"
        '
        'txtNumPaso
        '
        Me.txtNumPaso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumPaso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtNumPaso.Location = New System.Drawing.Point(181, 41)
        Me.txtNumPaso.Name = "txtNumPaso"
        Me.txtNumPaso.Size = New System.Drawing.Size(63, 26)
        Me.txtNumPaso.TabIndex = 4
        Me.txtNumPaso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboPuesto
        '
        Me.cboPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cboPuesto.FormattingEnabled = True
        Me.cboPuesto.Location = New System.Drawing.Point(181, 73)
        Me.cboPuesto.Name = "cboPuesto"
        Me.cboPuesto.Size = New System.Drawing.Size(232, 28)
        Me.cboPuesto.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(107, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Puesto"
        '
        'chkDecision
        '
        Me.chkDecision.AutoSize = True
        Me.chkDecision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.chkDecision.Location = New System.Drawing.Point(202, 282)
        Me.chkDecision.Name = "chkDecision"
        Me.chkDecision.Size = New System.Drawing.Size(15, 14)
        Me.chkDecision.TabIndex = 7
        Me.chkDecision.UseVisualStyleBackColor = True
        '
        'cboPasoNo
        '
        Me.cboPasoNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPasoNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cboPasoNo.FormattingEnabled = True
        Me.cboPasoNo.Location = New System.Drawing.Point(38, 375)
        Me.cboPasoNo.Name = "cboPasoNo"
        Me.cboPasoNo.Size = New System.Drawing.Size(49, 28)
        Me.cboPasoNo.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(145, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "¿Tiene desición?"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AdministracionTicket.My.Resources.Resources.Decision
        Me.PictureBox1.Location = New System.Drawing.Point(55, 195)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(314, 179)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'lblNo
        '
        Me.lblNo.AutoSize = True
        Me.lblNo.BackColor = System.Drawing.SystemColors.Control
        Me.lblNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblNo.Location = New System.Drawing.Point(78, 249)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(32, 20)
        Me.lblNo.TabIndex = 15
        Me.lblNo.Text = "NO"
        '
        'lblSi
        '
        Me.lblSi.AutoSize = True
        Me.lblSi.BackColor = System.Drawing.SystemColors.Control
        Me.lblSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblSi.Location = New System.Drawing.Point(311, 249)
        Me.lblSi.Name = "lblSi"
        Me.lblSi.Size = New System.Drawing.Size(25, 20)
        Me.lblSi.TabIndex = 16
        Me.lblSi.Text = "SI"
        '
        'cboPasoSi
        '
        Me.cboPasoSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPasoSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cboPasoSi.FormattingEnabled = True
        Me.cboPasoSi.Location = New System.Drawing.Point(340, 375)
        Me.cboPasoSi.Name = "cboPasoSi"
        Me.cboPasoSi.Size = New System.Drawing.Size(49, 28)
        Me.cboPasoSi.TabIndex = 17
        '
        'chkUltimoPaso
        '
        Me.chkUltimoPaso.AutoSize = True
        Me.chkUltimoPaso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.chkUltimoPaso.Location = New System.Drawing.Point(181, 107)
        Me.chkUltimoPaso.Name = "chkUltimoPaso"
        Me.chkUltimoPaso.Size = New System.Drawing.Size(132, 24)
        Me.chkUltimoPaso.TabIndex = 18
        Me.chkUltimoPaso.Text = "Es último paso"
        Me.chkUltimoPaso.UseVisualStyleBackColor = True
        '
        'txtDuracion
        '
        Me.txtDuracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtDuracion.Location = New System.Drawing.Point(181, 137)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(63, 26)
        Me.txtDuracion.TabIndex = 20
        Me.txtDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(11, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Duración en minutos"
        '
        'dgvProcesos
        '
        Me.dgvProcesos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProcesos.Location = New System.Drawing.Point(3, 51)
        Me.dgvProcesos.Name = "dgvProcesos"
        Me.dgvProcesos.Size = New System.Drawing.Size(713, 261)
        Me.dgvProcesos.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ToolStrip2)
        Me.Panel1.Controls.Add(Me.dgvProcesos)
        Me.Panel1.Location = New System.Drawing.Point(526, 113)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(721, 317)
        Me.Panel1.TabIndex = 22
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator5, Me.ToolStripButton2, Me.ToolStripSeparator6, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator7, Me.ToolStripButton5, Me.ToolStripSeparator8, Me.ToolStripLabel1, Me.txtNumProceso, Me.ToolStripLabel2, Me.txtDescripcion})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(719, 48)
        Me.ToolStrip2.TabIndex = 3
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 45)
        Me.ToolStripButton1.Text = "Nuevo Proceso"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 48)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(36, 45)
        Me.ToolStripButton2.Text = "Modificar Registro"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 48)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(36, 45)
        Me.ToolStripButton3.Text = "Guardar"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(36, 45)
        Me.ToolStripButton4.Text = "Cancelar"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 48)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(36, 45)
        Me.ToolStripButton5.Text = "Eliminar"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 48)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(51, 45)
        Me.ToolStripLabel1.Text = "Número"
        '
        'txtNumProceso
        '
        Me.txtNumProceso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumProceso.Name = "txtNumProceso"
        Me.txtNumProceso.Size = New System.Drawing.Size(40, 48)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(69, 45)
        Me.ToolStripLabel2.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(300, 48)
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label7.Location = New System.Drawing.Point(526, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(721, 38)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Procesos del paso"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvPasos
        '
        Me.dgvPasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPasos.Location = New System.Drawing.Point(444, 113)
        Me.dgvPasos.Name = "dgvPasos"
        Me.dgvPasos.Size = New System.Drawing.Size(76, 317)
        Me.dgvPasos.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label8.Location = New System.Drawing.Point(444, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 38)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Pasos"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.chkDecision)
        Me.GroupBox1.Controls.Add(Me.txtNumPaso)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboPuesto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.chkUltimoPaso)
        Me.GroupBox1.Controls.Add(Me.cboPasoSi)
        Me.GroupBox1.Controls.Add(Me.txtDuracion)
        Me.GroupBox1.Controls.Add(Me.lblSi)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblNo)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.cboPasoNo)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 421)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del paso"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 25)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(422, 393)
        Me.ShapeContainer1.TabIndex = 21
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Silver
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 16
        Me.LineShape1.X2 = 405
        Me.LineShape1.Y1 = 151
        Me.LineShape1.Y2 = 151
        '
        'frmSaltos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1261, 499)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgvPasos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmSaltos"
        Me.Text = "Pasos de la gestión"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.txtNumPaso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDuracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProcesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgvPasos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Actualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumPaso As System.Windows.Forms.NumericUpDown
    Friend WithEvents cboPuesto As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkDecision As System.Windows.Forms.CheckBox
    Friend WithEvents cboPasoNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblNo As System.Windows.Forms.Label
    Friend WithEvents lblSi As System.Windows.Forms.Label
    Friend WithEvents cboPasoSi As System.Windows.Forms.ComboBox
    Friend WithEvents chkUltimoPaso As System.Windows.Forms.CheckBox
    Friend WithEvents txtDuracion As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvProcesos As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtNumProceso As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtDescripcion As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvPasos As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
