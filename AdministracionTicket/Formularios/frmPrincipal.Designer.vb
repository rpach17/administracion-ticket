<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblInfoConexion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblInfoUbicacion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucursalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaSucursalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoDeSucursalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoDeOficinasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarOficinasASucursalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanillasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeUsuariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblInfoConexion, Me.ToolStripStatusLabel2, Me.lblInfoUbicacion})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 368)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1048, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(105, 17)
        Me.ToolStripStatusLabel1.Text = "Conectado como: "
        '
        'lblInfoConexion
        '
        Me.lblInfoConexion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfoConexion.Name = "lblInfoConexion"
        Me.lblInfoConexion.Size = New System.Drawing.Size(128, 17)
        Me.lblInfoConexion.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(16, 17)
        Me.ToolStripStatusLabel2.Text = " | "
        '
        'lblInfoUbicacion
        '
        Me.lblInfoUbicacion.Name = "lblInfoUbicacion"
        Me.lblInfoUbicacion.Size = New System.Drawing.Size(121, 17)
        Me.lblInfoUbicacion.Text = "ToolStripStatusLabel3"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem1, Me.OpcionesToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1048, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem1
        '
        Me.OpcionesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem1.Name = "OpcionesToolStripMenuItem1"
        Me.OpcionesToolStripMenuItem1.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem1.Text = "Opciones"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SucursalesToolStripMenuItem, Me.GestionesToolStripMenuItem, Me.VentanillasToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.OpcionesToolStripMenuItem.Text = "Administracion"
        '
        'SucursalesToolStripMenuItem
        '
        Me.SucursalesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaSucursalToolStripMenuItem, Me.CatalogoDeSucursalesToolStripMenuItem, Me.CatalogoDeOficinasToolStripMenuItem, Me.AsignarOficinasASucursalToolStripMenuItem})
        Me.SucursalesToolStripMenuItem.Name = "SucursalesToolStripMenuItem"
        Me.SucursalesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SucursalesToolStripMenuItem.Text = "Sucursales"
        '
        'NuevaSucursalToolStripMenuItem
        '
        Me.NuevaSucursalToolStripMenuItem.Name = "NuevaSucursalToolStripMenuItem"
        Me.NuevaSucursalToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.NuevaSucursalToolStripMenuItem.Text = "Nueva Sucursal"
        '
        'CatalogoDeSucursalesToolStripMenuItem
        '
        Me.CatalogoDeSucursalesToolStripMenuItem.Name = "CatalogoDeSucursalesToolStripMenuItem"
        Me.CatalogoDeSucursalesToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.CatalogoDeSucursalesToolStripMenuItem.Text = "Catalogo de sucursales"
        '
        'CatalogoDeOficinasToolStripMenuItem
        '
        Me.CatalogoDeOficinasToolStripMenuItem.Name = "CatalogoDeOficinasToolStripMenuItem"
        Me.CatalogoDeOficinasToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.CatalogoDeOficinasToolStripMenuItem.Text = "Catalogo de oficinas"
        '
        'AsignarOficinasASucursalToolStripMenuItem
        '
        Me.AsignarOficinasASucursalToolStripMenuItem.Name = "AsignarOficinasASucursalToolStripMenuItem"
        Me.AsignarOficinasASucursalToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.AsignarOficinasASucursalToolStripMenuItem.Text = "Asignar oficinas a sucursal"
        '
        'GestionesToolStripMenuItem
        '
        Me.GestionesToolStripMenuItem.Name = "GestionesToolStripMenuItem"
        Me.GestionesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GestionesToolStripMenuItem.Text = "Gestiones"
        '
        'VentanillasToolStripMenuItem
        '
        Me.VentanillasToolStripMenuItem.Name = "VentanillasToolStripMenuItem"
        Me.VentanillasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VentanillasToolStripMenuItem.Text = "Ventanillas"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaDeUsuariosToolStripMenuItem, Me.ListaDeUsuariosToolStripMenuItem1})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'ListaDeUsuariosToolStripMenuItem
        '
        Me.ListaDeUsuariosToolStripMenuItem.Name = "ListaDeUsuariosToolStripMenuItem"
        Me.ListaDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ListaDeUsuariosToolStripMenuItem.Text = "Búsqueda rápida"
        '
        'ListaDeUsuariosToolStripMenuItem1
        '
        Me.ListaDeUsuariosToolStripMenuItem1.Name = "ListaDeUsuariosToolStripMenuItem1"
        Me.ListaDeUsuariosToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.ListaDeUsuariosToolStripMenuItem1.Text = "Lista de usuarios"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 390)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "frmPrincipal"
        Me.Text = "Administracion de Ticket"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblInfoConexion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblInfoUbicacion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SucursalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatalogoDeSucursalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatalogoDeOficinasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignarOficinasASucursalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentanillasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeUsuariosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaSucursalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
