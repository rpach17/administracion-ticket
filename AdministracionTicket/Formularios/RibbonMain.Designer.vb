<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RibbonMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RibbonMain))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.ApplicationMenu1 = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.lblInfoConexion = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.lblInfoUbicacion = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.ClientPanel = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabManager = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ApplicationButtonDropDownControl = Me.ApplicationMenu1
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem6, Me.BarButtonItem11, Me.BarStaticItem1, Me.lblInfoConexion, Me.BarStaticItem2, Me.lblInfoUbicacion, Me.BarButtonItem12, Me.BarButtonItem13})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 19
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.RibbonControl.Size = New System.Drawing.Size(937, 146)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'ApplicationMenu1
        '
        Me.ApplicationMenu1.ItemLinks.Add(Me.BarButtonItem6)
        Me.ApplicationMenu1.ItemLinks.Add(Me.BarButtonItem11)
        Me.ApplicationMenu1.Name = "ApplicationMenu1"
        Me.ApplicationMenu1.Ribbon = Me.RibbonControl
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Cerrar sesión"
        Me.BarButtonItem6.Description = "Cierra la sesión actual"
        Me.BarButtonItem6.Id = 11
        Me.BarButtonItem6.LargeGlyph = Global.AdministracionTicket.My.Resources.Resources.switch
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Salir"
        Me.BarButtonItem11.Description = "Se sale de la aplicación"
        Me.BarButtonItem11.Id = 12
        Me.BarButtonItem11.LargeGlyph = Global.AdministracionTicket.My.Resources.Resources.door_out
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.ActAsDropDown = True
        Me.BarButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.BarButtonItem1.Caption = "Sucursales"
        Me.BarButtonItem1.DropDownControl = Me.PopupMenu1
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.ItemLinks.Add(Me.BarButtonItem7)
        Me.PopupMenu1.ItemLinks.Add(Me.BarButtonItem8)
        Me.PopupMenu1.ItemLinks.Add(Me.BarButtonItem9)
        Me.PopupMenu1.ItemLinks.Add(Me.BarButtonItem10)
        Me.PopupMenu1.Name = "PopupMenu1"
        Me.PopupMenu1.Ribbon = Me.RibbonControl
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Nueva sucursal"
        Me.BarButtonItem7.Glyph = Global.AdministracionTicket.My.Resources.Resources.building_add
        Me.BarButtonItem7.Id = 7
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Catálogo de sucursales"
        Me.BarButtonItem8.Glyph = Global.AdministracionTicket.My.Resources.Resources.text_list_bullets
        Me.BarButtonItem8.Id = 8
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Catálogo de oficinas"
        Me.BarButtonItem9.Glyph = Global.AdministracionTicket.My.Resources.Resources.text_list_bullets
        Me.BarButtonItem9.Id = 9
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Asignar oficina a sucursal"
        Me.BarButtonItem10.Glyph = Global.AdministracionTicket.My.Resources.Resources.building_go
        Me.BarButtonItem10.Id = 10
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Gestiones"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.LargeGlyph = CType(resources.GetObject("BarButtonItem2.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Ventanillas"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.LargeGlyph = CType(resources.GetObject("BarButtonItem3.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Lista de usuarios"
        Me.BarButtonItem4.Id = 4
        Me.BarButtonItem4.LargeGlyph = CType(resources.GetObject("BarButtonItem4.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Búsqueda rápida"
        Me.BarButtonItem5.Id = 5
        Me.BarButtonItem5.LargeGlyph = CType(resources.GetObject("BarButtonItem5.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Conectado como:"
        Me.BarStaticItem1.Id = 13
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'lblInfoConexion
        '
        Me.lblInfoConexion.Caption = "aaa"
        Me.lblInfoConexion.Id = 14
        Me.lblInfoConexion.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblInfoConexion.ItemAppearance.Normal.Options.UseFont = True
        Me.lblInfoConexion.Name = "lblInfoConexion"
        Me.lblInfoConexion.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "|"
        Me.BarStaticItem2.Id = 15
        Me.BarStaticItem2.Name = "BarStaticItem2"
        Me.BarStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'lblInfoUbicacion
        '
        Me.lblInfoUbicacion.Caption = "bbb"
        Me.lblInfoUbicacion.Id = 16
        Me.lblInfoUbicacion.Name = "lblInfoUbicacion"
        Me.lblInfoUbicacion.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Procesos"
        Me.BarButtonItem12.Id = 17
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Menú"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem12)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Administración"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem5)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem13)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Usuarios"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonStatusBar.ItemLinks.Add(Me.lblInfoConexion)
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarStaticItem2)
        Me.RibbonStatusBar.ItemLinks.Add(Me.lblInfoUbicacion)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 386)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(937, 27)
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013"
        '
        'ClientPanel
        '
        Me.ClientPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ClientPanel.ContentImage = Global.AdministracionTicket.My.Resources.Resources.rnp1
        Me.ClientPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClientPanel.Location = New System.Drawing.Point(0, 146)
        Me.ClientPanel.Name = "ClientPanel"
        Me.ClientPanel.Size = New System.Drawing.Size(937, 240)
        Me.ClientPanel.TabIndex = 5
        '
        'XtraTabManager
        '
        Me.XtraTabManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover
        Me.XtraTabManager.MdiParent = Me
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "BarButtonItem13"
        Me.BarButtonItem13.Id = 18
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'RibbonMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 413)
        Me.Controls.Add(Me.ClientPanel)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.IsMdiContainer = True
        Me.Name = "RibbonMain"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Administración"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ApplicationMenu1 As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ClientPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents XtraTabManager As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblInfoConexion As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblInfoUbicacion As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem


End Class
