<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTramitesFinalizar
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
        Me.cboErrorTramite = New System.Windows.Forms.ComboBox()
        Me.btnFinalizar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodTramite = New DevExpress.XtraEditors.TextEdit()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.txtCodTramite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cboErrorTramite)
        Me.Panel1.Controls.Add(Me.btnFinalizar)
        Me.Panel1.Controls.Add(Me.LabelControl2)
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Controls.Add(Me.txtCodTramite)
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Location = New System.Drawing.Point(116, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 356)
        Me.Panel1.TabIndex = 1
        '
        'cboErrorTramite
        '
        Me.cboErrorTramite.FormattingEnabled = True
        Me.cboErrorTramite.Location = New System.Drawing.Point(263, 171)
        Me.cboErrorTramite.Name = "cboErrorTramite"
        Me.cboErrorTramite.Size = New System.Drawing.Size(241, 21)
        Me.cboErrorTramite.TabIndex = 7
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Location = New System.Drawing.Point(394, 216)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(110, 23)
        Me.btnFinalizar.TabIndex = 6
        Me.btnFinalizar.Text = "Finalizar Trámite"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(121, 174)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Seleccione el error"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(121, 128)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(136, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Ingrese el codigo del trámite"
        '
        'txtCodTramite
        '
        Me.txtCodTramite.Location = New System.Drawing.Point(263, 125)
        Me.txtCodTramite.Name = "txtCodTramite"
        Me.txtCodTramite.Size = New System.Drawing.Size(178, 20)
        Me.txtCodTramite.TabIndex = 3
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(636, 40)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmTramitesFinalizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 417)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmTramitesFinalizar"
        Me.Text = "frmTramitesFinalizar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtCodTramite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnFinalizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodTramite As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboErrorTramite As System.Windows.Forms.ComboBox
End Class
