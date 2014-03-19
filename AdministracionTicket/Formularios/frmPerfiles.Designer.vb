<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerfiles
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
        Me.components = New System.ComponentModel.Container()
        Dim USUARIOLabel As System.Windows.Forms.Label
        Dim CONTRASENALabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim APELLIDOSLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPerfiles))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PERFILES_USUARIODataGridView = New System.Windows.Forms.DataGridView()
        Me.cboPerfil = New System.Windows.Forms.ComboBox()
        Me.btnAgregarP = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblOficina = New System.Windows.Forms.Label()
        Me.cboOficinas = New System.Windows.Forms.ComboBox()
        Me.lblAccion = New System.Windows.Forms.Label()
        Me.USUARIOTextBox = New System.Windows.Forms.TextBox()
        Me.CONTRASENATextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox()
        Me.APELLIDOSTextBox = New System.Windows.Forms.TextBox()
        Me.ESTADOCheckBox = New System.Windows.Forms.CheckBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.QuitarPerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        USUARIOLabel = New System.Windows.Forms.Label()
        CONTRASENALabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        APELLIDOSLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PERFILES_USUARIODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PERFILES_USUARIODataGridView)
        Me.Panel1.Controls.Add(Me.cboPerfil)
        Me.Panel1.Controls.Add(Me.btnAgregarP)
        Me.Panel1.Location = New System.Drawing.Point(454, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(381, 222)
        Me.Panel1.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 40)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Perfiles del usuario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PERFILES_USUARIODataGridView
        '
        Me.PERFILES_USUARIODataGridView.AllowUserToAddRows = False
        Me.PERFILES_USUARIODataGridView.AllowUserToDeleteRows = False
        Me.PERFILES_USUARIODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.PERFILES_USUARIODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PERFILES_USUARIODataGridView.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PERFILES_USUARIODataGridView.Location = New System.Drawing.Point(45, 86)
        Me.PERFILES_USUARIODataGridView.MultiSelect = False
        Me.PERFILES_USUARIODataGridView.Name = "PERFILES_USUARIODataGridView"
        Me.PERFILES_USUARIODataGridView.ReadOnly = True
        Me.PERFILES_USUARIODataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PERFILES_USUARIODataGridView.Size = New System.Drawing.Size(300, 120)
        Me.PERFILES_USUARIODataGridView.TabIndex = 13
        '
        'cboPerfil
        '
        Me.cboPerfil.DisplayMember = "NOMBRE_PERFIL"
        Me.cboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cboPerfil.FormattingEnabled = True
        Me.cboPerfil.Location = New System.Drawing.Point(45, 52)
        Me.cboPerfil.Name = "cboPerfil"
        Me.cboPerfil.Size = New System.Drawing.Size(212, 28)
        Me.cboPerfil.TabIndex = 14
        Me.cboPerfil.ValueMember = "IDPERFIL"
        '
        'btnAgregarP
        '
        Me.btnAgregarP.Location = New System.Drawing.Point(258, 51)
        Me.btnAgregarP.Name = "btnAgregarP"
        Me.btnAgregarP.Size = New System.Drawing.Size(87, 30)
        Me.btnAgregarP.TabIndex = 16
        Me.btnAgregarP.Text = "Agregar"
        Me.btnAgregarP.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnOK.Location = New System.Drawing.Point(122, 254)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(175, 39)
        Me.btnOK.TabIndex = 33
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblOficina
        '
        Me.lblOficina.AutoSize = True
        Me.lblOficina.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblOficina.Location = New System.Drawing.Point(47, 65)
        Me.lblOficina.Name = "lblOficina"
        Me.lblOficina.Size = New System.Drawing.Size(58, 20)
        Me.lblOficina.TabIndex = 32
        Me.lblOficina.Text = "Oficina"
        '
        'cboOficinas
        '
        Me.cboOficinas.DisplayMember = "NOMBRE_OFICINA"
        Me.cboOficinas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOficinas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cboOficinas.FormattingEnabled = True
        Me.cboOficinas.Location = New System.Drawing.Point(122, 62)
        Me.cboOficinas.Name = "cboOficinas"
        Me.cboOficinas.Size = New System.Drawing.Size(326, 28)
        Me.cboOficinas.TabIndex = 31
        Me.cboOficinas.ValueMember = "IDDETALLE_SUCURSAL_OFICINA"
        '
        'lblAccion
        '
        Me.lblAccion.BackColor = System.Drawing.Color.Gray
        Me.lblAccion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblAccion.ForeColor = System.Drawing.Color.White
        Me.lblAccion.Location = New System.Drawing.Point(0, 0)
        Me.lblAccion.Name = "lblAccion"
        Me.lblAccion.Size = New System.Drawing.Size(877, 44)
        Me.lblAccion.TabIndex = 30
        Me.lblAccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'USUARIOLabel
        '
        USUARIOLabel.AutoSize = True
        USUARIOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        USUARIOLabel.Location = New System.Drawing.Point(41, 99)
        USUARIOLabel.Name = "USUARIOLabel"
        USUARIOLabel.Size = New System.Drawing.Size(64, 20)
        USUARIOLabel.TabIndex = 21
        USUARIOLabel.Text = "Usuario"
        '
        'USUARIOTextBox
        '
        Me.USUARIOTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.USUARIOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.USUARIOTextBox.Location = New System.Drawing.Point(122, 96)
        Me.USUARIOTextBox.MaxLength = 20
        Me.USUARIOTextBox.Name = "USUARIOTextBox"
        Me.USUARIOTextBox.Size = New System.Drawing.Size(175, 26)
        Me.USUARIOTextBox.TabIndex = 22
        '
        'CONTRASENALabel
        '
        CONTRASENALabel.AutoSize = True
        CONTRASENALabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        CONTRASENALabel.Location = New System.Drawing.Point(13, 131)
        CONTRASENALabel.Name = "CONTRASENALabel"
        CONTRASENALabel.Size = New System.Drawing.Size(92, 20)
        CONTRASENALabel.TabIndex = 23
        CONTRASENALabel.Text = "Contraseña"
        '
        'CONTRASENATextBox
        '
        Me.CONTRASENATextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CONTRASENATextBox.Location = New System.Drawing.Point(122, 128)
        Me.CONTRASENATextBox.Name = "CONTRASENATextBox"
        Me.CONTRASENATextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CONTRASENATextBox.Size = New System.Drawing.Size(175, 26)
        Me.CONTRASENATextBox.TabIndex = 24
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        NOMBRELabel.Location = New System.Drawing.Point(40, 163)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(65, 20)
        NOMBRELabel.TabIndex = 25
        NOMBRELabel.Text = "Nombre"
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NOMBRETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NOMBRETextBox.Location = New System.Drawing.Point(122, 160)
        Me.NOMBRETextBox.MaxLength = 35
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(175, 26)
        Me.NOMBRETextBox.TabIndex = 26
        '
        'APELLIDOSLabel
        '
        APELLIDOSLabel.AutoSize = True
        APELLIDOSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        APELLIDOSLabel.Location = New System.Drawing.Point(32, 195)
        APELLIDOSLabel.Name = "APELLIDOSLabel"
        APELLIDOSLabel.Size = New System.Drawing.Size(73, 20)
        APELLIDOSLabel.TabIndex = 27
        APELLIDOSLabel.Text = "Apellidos"
        '
        'APELLIDOSTextBox
        '
        Me.APELLIDOSTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.APELLIDOSTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.APELLIDOSTextBox.Location = New System.Drawing.Point(122, 192)
        Me.APELLIDOSTextBox.MaxLength = 35
        Me.APELLIDOSTextBox.Name = "APELLIDOSTextBox"
        Me.APELLIDOSTextBox.Size = New System.Drawing.Size(175, 26)
        Me.APELLIDOSTextBox.TabIndex = 28
        '
        'ESTADOCheckBox
        '
        Me.ESTADOCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ESTADOCheckBox.Location = New System.Drawing.Point(122, 224)
        Me.ESTADOCheckBox.Name = "ESTADOCheckBox"
        Me.ESTADOCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ESTADOCheckBox.TabIndex = 29
        Me.ESTADOCheckBox.Text = "Estado"
        Me.ESTADOCheckBox.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitarPerfilToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(138, 26)
        '
        'QuitarPerfilToolStripMenuItem
        '
        Me.QuitarPerfilToolStripMenuItem.Image = CType(resources.GetObject("QuitarPerfilToolStripMenuItem.Image"), System.Drawing.Image)
        Me.QuitarPerfilToolStripMenuItem.Name = "QuitarPerfilToolStripMenuItem"
        Me.QuitarPerfilToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.QuitarPerfilToolStripMenuItem.Text = "Quitar perfil"
        '
        'frmPerfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 319)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblOficina)
        Me.Controls.Add(Me.cboOficinas)
        Me.Controls.Add(Me.lblAccion)
        Me.Controls.Add(USUARIOLabel)
        Me.Controls.Add(Me.USUARIOTextBox)
        Me.Controls.Add(CONTRASENALabel)
        Me.Controls.Add(Me.CONTRASENATextBox)
        Me.Controls.Add(NOMBRELabel)
        Me.Controls.Add(Me.NOMBRETextBox)
        Me.Controls.Add(APELLIDOSLabel)
        Me.Controls.Add(Me.APELLIDOSTextBox)
        Me.Controls.Add(Me.ESTADOCheckBox)
        Me.Name = "frmPerfiles"
        Me.Text = "Gestión de Usuarios"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PERFILES_USUARIODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PERFILES_USUARIODataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cboPerfil As System.Windows.Forms.ComboBox
    Friend WithEvents btnAgregarP As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblOficina As System.Windows.Forms.Label
    Friend WithEvents cboOficinas As System.Windows.Forms.ComboBox
    Friend WithEvents lblAccion As System.Windows.Forms.Label
    Friend WithEvents USUARIOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CONTRASENATextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRETextBox As System.Windows.Forms.TextBox
    Friend WithEvents APELLIDOSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ESTADOCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents QuitarPerfilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
