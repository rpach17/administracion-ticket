﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.BtnVisualizar = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.NuevoP = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ActualizarP = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.GuardarP = New System.Windows.Forms.ToolStripButton()
        Me.CancelarP = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.EliminarP = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtNumProceso = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtDescripcion = New System.Windows.Forms.ToolStripTextBox()
        Me.dgvProcesos = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvPasos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDescripcionPaso = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDecision = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkDecision = New System.Windows.Forms.CheckBox()
        Me.txtNumPaso = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPuesto = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkUltimoPaso = New System.Windows.Forms.CheckBox()
        Me.cboPasoSi = New System.Windows.Forms.ComboBox()
        Me.txtDuracion = New System.Windows.Forms.NumericUpDown()
        Me.lblSi = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboPasoNo = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgvProcesos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPasos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtNumPaso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDuracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Nuevo, Me.ToolStripSeparator1, Me.Actualizar, Me.ToolStripSeparator2, Me.Guardar, Me.Cancelar, Me.ToolStripSeparator3, Me.Eliminar, Me.ToolStripSeparator4, Me.BtnVisualizar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1238, 48)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Nuevo
        '
        Me.Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Nuevo.Image = Global.AdministracionTicket.My.Resources.Resources.page_add
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
        Me.Actualizar.Image = Global.AdministracionTicket.My.Resources.Resources.pencil
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
        Me.Guardar.Image = Global.AdministracionTicket.My.Resources.Resources.save
        Me.Guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(36, 45)
        Me.Guardar.Text = "Guardar"
        '
        'Cancelar
        '
        Me.Cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cancelar.Image = Global.AdministracionTicket.My.Resources.Resources.cancel
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
        Me.Eliminar.Image = Global.AdministracionTicket.My.Resources.Resources.delete
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
        'BtnVisualizar
        '
        Me.BtnVisualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnVisualizar.Image = Global.AdministracionTicket.My.Resources.Resources.table_select_column
        Me.BtnVisualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnVisualizar.Name = "BtnVisualizar"
        Me.BtnVisualizar.Size = New System.Drawing.Size(36, 45)
        Me.BtnVisualizar.Text = "Ver Pasos de la Gestión"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.dgvPasos)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1213, 459)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ToolStrip2)
        Me.Panel2.Controls.Add(Me.dgvProcesos)
        Me.Panel2.Location = New System.Drawing.Point(540, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(648, 400)
        Me.Panel2.TabIndex = 36
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoP, Me.ToolStripSeparator5, Me.ActualizarP, Me.ToolStripSeparator6, Me.GuardarP, Me.CancelarP, Me.ToolStripSeparator7, Me.EliminarP, Me.ToolStripSeparator8, Me.ToolStripLabel1, Me.txtNumProceso, Me.ToolStripLabel2, Me.txtDescripcion})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(646, 48)
        Me.ToolStrip2.TabIndex = 3
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'NuevoP
        '
        Me.NuevoP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NuevoP.Image = Global.AdministracionTicket.My.Resources.Resources.page_add
        Me.NuevoP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevoP.Name = "NuevoP"
        Me.NuevoP.Size = New System.Drawing.Size(36, 45)
        Me.NuevoP.Text = "Nuevo Proceso"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 48)
        '
        'ActualizarP
        '
        Me.ActualizarP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ActualizarP.Image = Global.AdministracionTicket.My.Resources.Resources.pencil
        Me.ActualizarP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ActualizarP.Name = "ActualizarP"
        Me.ActualizarP.Size = New System.Drawing.Size(36, 45)
        Me.ActualizarP.Text = "Modificar Registro"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 48)
        '
        'GuardarP
        '
        Me.GuardarP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuardarP.Image = Global.AdministracionTicket.My.Resources.Resources.save
        Me.GuardarP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarP.Name = "GuardarP"
        Me.GuardarP.Size = New System.Drawing.Size(36, 45)
        Me.GuardarP.Text = "Guardar"
        '
        'CancelarP
        '
        Me.CancelarP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CancelarP.Image = Global.AdministracionTicket.My.Resources.Resources.cancel
        Me.CancelarP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelarP.Name = "CancelarP"
        Me.CancelarP.Size = New System.Drawing.Size(36, 45)
        Me.CancelarP.Text = "Cancelar"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 48)
        '
        'EliminarP
        '
        Me.EliminarP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EliminarP.Image = Global.AdministracionTicket.My.Resources.Resources.delete
        Me.EliminarP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EliminarP.Name = "EliminarP"
        Me.EliminarP.Size = New System.Drawing.Size(36, 45)
        Me.EliminarP.Text = "Eliminar"
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
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(250, 48)
        '
        'dgvProcesos
        '
        Me.dgvProcesos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProcesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvProcesos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProcesos.Location = New System.Drawing.Point(3, 51)
        Me.dgvProcesos.MultiSelect = False
        Me.dgvProcesos.Name = "dgvProcesos"
        Me.dgvProcesos.ReadOnly = True
        Me.dgvProcesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProcesos.Size = New System.Drawing.Size(640, 344)
        Me.dgvProcesos.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(540, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(648, 38)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Procesos del paso"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(458, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 38)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Pasos"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvPasos
        '
        Me.dgvPasos.AllowUserToAddRows = False
        Me.dgvPasos.AllowUserToDeleteRows = False
        Me.dgvPasos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPasos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvPasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPasos.Location = New System.Drawing.Point(458, 48)
        Me.dgvPasos.MultiSelect = False
        Me.dgvPasos.Name = "dgvPasos"
        Me.dgvPasos.ReadOnly = True
        Me.dgvPasos.RowHeadersVisible = False
        Me.dgvPasos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPasos.Size = New System.Drawing.Size(76, 400)
        Me.dgvPasos.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionPaso)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDecision)
        Me.GroupBox1.Controls.Add(Me.Label3)
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
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 446)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del paso"
        '
        'txtDescripcionPaso
        '
        Me.txtDescripcionPaso.Location = New System.Drawing.Point(160, 66)
        Me.txtDescripcionPaso.Name = "txtDescripcionPaso"
        Me.txtDescripcionPaso.Size = New System.Drawing.Size(262, 29)
        Me.txtDescripcionPaso.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(65, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Descripción"
        '
        'txtDecision
        '
        Me.txtDecision.Location = New System.Drawing.Point(82, 406)
        Me.txtDecision.Name = "txtDecision"
        Me.txtDecision.Size = New System.Drawing.Size(307, 29)
        Me.txtDecision.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(11, 412)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Decisión"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(145, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "¿Tiene desición?"
        '
        'chkDecision
        '
        Me.chkDecision.AutoSize = True
        Me.chkDecision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.chkDecision.Location = New System.Drawing.Point(202, 278)
        Me.chkDecision.Name = "chkDecision"
        Me.chkDecision.Size = New System.Drawing.Size(15, 14)
        Me.chkDecision.TabIndex = 7
        Me.chkDecision.UseVisualStyleBackColor = True
        '
        'txtNumPaso
        '
        Me.txtNumPaso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumPaso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtNumPaso.Location = New System.Drawing.Point(160, 36)
        Me.txtNumPaso.Name = "txtNumPaso"
        Me.txtNumPaso.Size = New System.Drawing.Size(63, 26)
        Me.txtNumPaso.TabIndex = 4
        Me.txtNumPaso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(28, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Número de paso"
        '
        'cboPuesto
        '
        Me.cboPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cboPuesto.FormattingEnabled = True
        Me.cboPuesto.Location = New System.Drawing.Point(160, 100)
        Me.cboPuesto.Name = "cboPuesto"
        Me.cboPuesto.Size = New System.Drawing.Size(262, 28)
        Me.cboPuesto.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(95, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Puesto"
        '
        'chkUltimoPaso
        '
        Me.chkUltimoPaso.AutoSize = True
        Me.chkUltimoPaso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.chkUltimoPaso.Location = New System.Drawing.Point(160, 131)
        Me.chkUltimoPaso.Name = "chkUltimoPaso"
        Me.chkUltimoPaso.Size = New System.Drawing.Size(132, 24)
        Me.chkUltimoPaso.TabIndex = 18
        Me.chkUltimoPaso.Text = "Es último paso"
        Me.chkUltimoPaso.UseVisualStyleBackColor = True
        '
        'cboPasoSi
        '
        Me.cboPasoSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPasoSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cboPasoSi.FormattingEnabled = True
        Me.cboPasoSi.Location = New System.Drawing.Point(340, 371)
        Me.cboPasoSi.Name = "cboPasoSi"
        Me.cboPasoSi.Size = New System.Drawing.Size(49, 28)
        Me.cboPasoSi.TabIndex = 17
        '
        'txtDuracion
        '
        Me.txtDuracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtDuracion.Location = New System.Drawing.Point(160, 155)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(63, 26)
        Me.txtDuracion.TabIndex = 20
        Me.txtDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSi
        '
        Me.lblSi.AutoSize = True
        Me.lblSi.BackColor = System.Drawing.Color.White
        Me.lblSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblSi.Location = New System.Drawing.Point(311, 239)
        Me.lblSi.Name = "lblSi"
        Me.lblSi.Size = New System.Drawing.Size(25, 20)
        Me.lblSi.TabIndex = 16
        Me.lblSi.Text = "SI"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(2, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Duración en minutos"
        '
        'lblNo
        '
        Me.lblNo.AutoSize = True
        Me.lblNo.BackColor = System.Drawing.Color.White
        Me.lblNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblNo.Location = New System.Drawing.Point(78, 239)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(32, 20)
        Me.lblNo.TabIndex = 15
        Me.lblNo.Text = "NO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AdministracionTicket.My.Resources.Resources.Decision
        Me.PictureBox1.Location = New System.Drawing.Point(55, 191)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(314, 179)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'cboPasoNo
        '
        Me.cboPasoNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPasoNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cboPasoNo.FormattingEnabled = True
        Me.cboPasoNo.Location = New System.Drawing.Point(38, 371)
        Me.cboPasoNo.Name = "cboPasoNo"
        Me.cboPasoNo.Size = New System.Drawing.Size(49, 28)
        Me.cboPasoNo.TabIndex = 8
        '
        'frmSaltos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1238, 529)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSaltos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pasos de la gestión"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgvProcesos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPasos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtNumPaso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDuracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BtnVisualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents NuevoP As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ActualizarP As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GuardarP As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelarP As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EliminarP As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtNumProceso As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtDescripcion As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents dgvProcesos As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgvPasos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDecision As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkDecision As System.Windows.Forms.CheckBox
    Friend WithEvents txtNumPaso As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPuesto As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkUltimoPaso As System.Windows.Forms.CheckBox
    Friend WithEvents cboPasoSi As System.Windows.Forms.ComboBox
    Friend WithEvents txtDuracion As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSi As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblNo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cboPasoNo As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescripcionPaso As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
