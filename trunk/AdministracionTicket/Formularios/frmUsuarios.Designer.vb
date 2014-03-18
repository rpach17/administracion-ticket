<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DEPARTAMENTOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.MUNICIPIOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.SUCURSALESDataGridView = New System.Windows.Forms.DataGridView()
        Me.USUARIOS_SUCURSALDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DEPARTAMENTOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.MUNICIPIOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.SUCURSALESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USUARIOS_SUCURSALDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1194, 41)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuarios por zona geográfica"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(-6, 50)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.DEPARTAMENTOSDataGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1206, 400)
        Me.SplitContainer1.SplitterDistance = 229
        Me.SplitContainer1.TabIndex = 3
        '
        'DEPARTAMENTOSDataGridView
        '
        Me.DEPARTAMENTOSDataGridView.AllowUserToAddRows = False
        Me.DEPARTAMENTOSDataGridView.AllowUserToDeleteRows = False
        Me.DEPARTAMENTOSDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DEPARTAMENTOSDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DEPARTAMENTOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DEPARTAMENTOSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DEPARTAMENTOSDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.DEPARTAMENTOSDataGridView.MultiSelect = False
        Me.DEPARTAMENTOSDataGridView.Name = "DEPARTAMENTOSDataGridView"
        Me.DEPARTAMENTOSDataGridView.ReadOnly = True
        Me.DEPARTAMENTOSDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DEPARTAMENTOSDataGridView.Size = New System.Drawing.Size(229, 400)
        Me.DEPARTAMENTOSDataGridView.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.MUNICIPIOSDataGridView)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(973, 400)
        Me.SplitContainer2.SplitterDistance = 257
        Me.SplitContainer2.TabIndex = 0
        '
        'MUNICIPIOSDataGridView
        '
        Me.MUNICIPIOSDataGridView.AllowUserToAddRows = False
        Me.MUNICIPIOSDataGridView.AllowUserToDeleteRows = False
        Me.MUNICIPIOSDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MUNICIPIOSDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.MUNICIPIOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MUNICIPIOSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MUNICIPIOSDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MUNICIPIOSDataGridView.MultiSelect = False
        Me.MUNICIPIOSDataGridView.Name = "MUNICIPIOSDataGridView"
        Me.MUNICIPIOSDataGridView.ReadOnly = True
        Me.MUNICIPIOSDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MUNICIPIOSDataGridView.Size = New System.Drawing.Size(257, 400)
        Me.MUNICIPIOSDataGridView.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.AutoScroll = True
        Me.SplitContainer3.Panel1.Controls.Add(Me.SUCURSALESDataGridView)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.USUARIOS_SUCURSALDataGridView)
        Me.SplitContainer3.Size = New System.Drawing.Size(712, 400)
        Me.SplitContainer3.SplitterDistance = 237
        Me.SplitContainer3.TabIndex = 0
        '
        'SUCURSALESDataGridView
        '
        Me.SUCURSALESDataGridView.AllowUserToAddRows = False
        Me.SUCURSALESDataGridView.AllowUserToDeleteRows = False
        Me.SUCURSALESDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SUCURSALESDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.SUCURSALESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SUCURSALESDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SUCURSALESDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.SUCURSALESDataGridView.MultiSelect = False
        Me.SUCURSALESDataGridView.Name = "SUCURSALESDataGridView"
        Me.SUCURSALESDataGridView.ReadOnly = True
        Me.SUCURSALESDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SUCURSALESDataGridView.Size = New System.Drawing.Size(237, 400)
        Me.SUCURSALESDataGridView.TabIndex = 0
        '
        'USUARIOS_SUCURSALDataGridView
        '
        Me.USUARIOS_SUCURSALDataGridView.AllowUserToAddRows = False
        Me.USUARIOS_SUCURSALDataGridView.AllowUserToDeleteRows = False
        Me.USUARIOS_SUCURSALDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.USUARIOS_SUCURSALDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.USUARIOS_SUCURSALDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.USUARIOS_SUCURSALDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.USUARIOS_SUCURSALDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.USUARIOS_SUCURSALDataGridView.MultiSelect = False
        Me.USUARIOS_SUCURSALDataGridView.Name = "USUARIOS_SUCURSALDataGridView"
        Me.USUARIOS_SUCURSALDataGridView.ReadOnly = True
        Me.USUARIOS_SUCURSALDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.USUARIOS_SUCURSALDataGridView.Size = New System.Drawing.Size(471, 400)
        Me.USUARIOS_SUCURSALDataGridView.TabIndex = 0
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1194, 456)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmUsuarios"
        Me.Text = "frmUsuarios"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DEPARTAMENTOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.MUNICIPIOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.SUCURSALESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USUARIOS_SUCURSALDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DEPARTAMENTOSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents MUNICIPIOSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents SUCURSALESDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents USUARIOS_SUCURSALDataGridView As System.Windows.Forms.DataGridView
End Class
