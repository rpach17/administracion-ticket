﻿Public Class frmPerfiles

#Region "Propiedades"
    Private _idUsuario As Integer
    Public Property IdUsuario() As Integer
        Get
            Return _idUsuario
        End Get
        Set(ByVal value As Integer)
            _idUsuario = value
        End Set
    End Property

    Private _idSucursal As Integer
    Public Property IdSucursal() As Integer
        Get
            Return _idSucursal
        End Get
        Set(ByVal value As Integer)
            _idSucursal = value
        End Set
    End Property

    Private _esNuevo As Boolean
    Public Property EsNuevo() As Boolean
        Get
            Return _esNuevo
        End Get
        Set(ByVal value As Boolean)
            _esNuevo = value
        End Set
    End Property
#End Region

#Region "Procedimientos"

    Private Sub CargarDatosUsuario(ByVal IdU As Integer)
        Dim usuario As New USUARIOS
        usuario = EntityTablas.SelectUsuario(IdU)
        USUARIOTextBox.Text = usuario.USUARIO
        CONTRASENATextBox.Text = usuario.CONTRASENA
        NOMBRETextBox.Text = usuario.NOMBRE
        APELLIDOSTextBox.Text = usuario.APELLIDOS
        ESTADOCheckBox.Checked = IIf(usuario.ESTADO = 1, True, False)
        cboOficinas.SelectedValue = usuario.IDDETALLE_SUCURSAL_OFICINA
        CargarPerfilesUsuario(IdU)

    End Sub

    Private Sub LimpiarForm()
        USUARIOTextBox.Text = Nothing
        CONTRASENATextBox.Text = Nothing
        NOMBRETextBox.Text = Nothing
        APELLIDOSTextBox.Text = Nothing
        ESTADOCheckBox.Checked = False

        cboOficinas.SelectedValue = -1
        cboPerfil.SelectedValue = -1
        CargarPerfilesUsuario(0)
        '   DataGridViewTextBoxColumn1.Visible = False
    End Sub

    Private Sub CargarPerfilesUsuario(ByVal IdU As Integer)
        EntityTablas.CargarPerfiles(PERFILES_USUARIODataGridView, IdUsuario)
    End Sub

    Private Function ValidarForm() As Boolean
        If EsNuevo Then
            If cboOficinas.Text = "" Then
                MsgBox("Seleccione la oficina", MsgBoxStyle.Exclamation, "Oficina")
                cboOficinas.Focus()
                Return False
            End If
        End If

        If USUARIOTextBox.Text.Trim = "" Then
            MsgBox("Ingrese el usuario", MsgBoxStyle.Exclamation, "Usuario")
            USUARIOTextBox.Focus()
            Return False
        End If

        If EsNuevo Then
            If CONTRASENATextBox.Text.Trim = "" Then
                MsgBox(String.Format("Ingrese una contraseña segura{0}Para una contraseña segura, combine letras (minúsculas y mayúsculas), números y simbolos", vbCrLf), MsgBoxStyle.Exclamation, "Contraseña")
                CONTRASENATextBox.Focus()
                Return False
            End If
        End If

        If NOMBRETextBox.Text.Trim = "" Then
            MsgBox("Ingrese el nombre", MsgBoxStyle.Exclamation, "Nombre")
            NOMBRETextBox.Focus()
            Return False
        End If

        If APELLIDOSTextBox.Text.Trim = "" Then
            MsgBox("Ingrese el apellido", MsgBoxStyle.Exclamation, "Apellido")
            APELLIDOSTextBox.Focus()
            Return False
        End If

        Return True
    End Function
#End Region

    Private Sub frmPerfiles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cargar perfile
        EntityTablas.CargarCboPerfiles(cboPerfil)
        'cargar oficinas
        EntityTablas.CargarCombos(cboOficinas, IdSucursal)

        If EsNuevo Then 'Nuevo usuario
            lblAccion.Text = "Agregando nuevo usuario"
            cboOficinas.SelectedValue = -1
            LimpiarForm() 'Se limpian los controles en caso de que el form ya haya visualizado info de otro usuario cuando EsNuevo = False
            btnAgregarP.Enabled = False 'No puede agregar perfil hasta que se haya agregado el usuario
            CONTRASENATextBox.Enabled = True 'Se habilita el txt contraseña en caso que haya quedado inhabilitado al editar un usuario
            btnOK.Text = "Agregar usuario"
        Else 'No es nuevo usuario
            lblAccion.Text = "Editando información del usuario"
            'lblOficina.Visible = False
            'cboOficina.Visible = False
            CargarDatosUsuario(_idUsuario) ' Carga los datos del usuario y las oficinas de la sucursal
            btnAgregarP.Enabled = True 'Se habilita el boton para agregar perfiles (En caso de que haya quedado deshabilitado al intentar agregar un nuevo usuario)
            CONTRASENATextBox.Enabled = False
            btnOK.Text = "Actualizar usuario"
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If EsNuevo Then
            If Not ValidarForm() Then
                Exit Sub
            End If

            IdUsuario = EntityTablas.AgregarUsuario(New USUARIOS() With {.USUARIO = USUARIOTextBox.Text, _
                                                                 .CONTRASENA = SHA1(CONTRASENATextBox.Text), _
                                                                 .NOMBRE = NOMBRETextBox.Text, _
                                                                 .APELLIDOS = APELLIDOSTextBox.Text, _
                                                                 .ESTADO = IIf(ESTADOCheckBox.Checked = True, Convert.ToDecimal(Val(1)), Convert.ToDecimal(Val(0))), _
                                                                 .IDDETALLE_SUCURSAL_OFICINA = cboOficinas.SelectedValue
                                                                })

            Dim m As String = String.Format("El usuario ha sido agregado correctamente.{0}{0}Proceda a asignar los perfiles necesarios al usuario.", vbCrLf)
            MsgBox(m, MsgBoxStyle.Information, "Usuario agregado")
            EsNuevo = False 'Ya no es un nuevo usuario y se puede actualizar
            btnAgregarP.Enabled = True
            btnOK.Text = "Actualizar usuario"
            lblAccion.Text = "Editando información del usuario"

        Else
            If Not ValidarForm() Then
                Exit Sub
            End If

            EntityTablas.ActualizarUsuario(IdUsuario, USUARIOTextBox.Text, NOMBRETextBox.Text, APELLIDOSTextBox.Text, IIf(ESTADOCheckBox.Checked, 1, 0))
            MsgBox("Se actualizó la información del usuario", MsgBoxStyle.Information, "Usuario actualizado")

        End If
    End Sub

    Private Sub btnAgregarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarP.Click
        If cboPerfil.Text <> "" Then
            EntityTablas.AgregarPerfilUser(IdUsuario, cboPerfil.SelectedValue)
            CargarPerfilesUsuario(_idUsuario)
            cboPerfil.SelectedValue = -1 'Limpia de nuevo de combo para una nueva seleccion
        End If
    End Sub

    Private Sub QuitarPerfilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarPerfilToolStripMenuItem.Click
        If MsgBox("¿Está seguro de remover el perfil?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirme") = MsgBoxResult.Yes Then
            EntityTablas.QuitarPerfilUser(IdUsuario, ObtenerDatoGrid(PERFILES_USUARIODataGridView))
            CargarPerfilesUsuario(_idUsuario)
            cboPerfil.SelectedValue = -1 'Limpia de nuevo de combo para una nueva seleccion
        End If
    End Sub

    Private Sub frmPerfiles_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        With frmUsuarios
            .cargarUsuarios()
        End With
    End Sub

    Private Sub USUARIOTextBox_Leave(sender As Object, e As EventArgs) Handles USUARIOTextBox.Leave
        If EntityTablas.VerificarUsuario(USUARIOTextBox.Text) = False Then
            MsgBox("Usuario ya existe")
            'USUARIOTextBox.Focus() 'usuario ya existe o no valido
        End If
    End Sub


End Class