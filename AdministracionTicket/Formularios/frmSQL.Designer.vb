<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSQL
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
        Me.txtSQL = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSQL
        '
        Me.txtSQL.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtSQL.Location = New System.Drawing.Point(0, 0)
        Me.txtSQL.Multiline = True
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.Size = New System.Drawing.Size(583, 389)
        Me.txtSQL.TabIndex = 0
        '
        'btnGuardar
        '
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnGuardar.Location = New System.Drawing.Point(0, 395)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(583, 35)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar SQL"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 430)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtSQL)
        Me.Name = "frmSQL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sintaxis SQL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSQL As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
End Class
