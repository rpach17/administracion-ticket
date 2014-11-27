Public Class rptAtencionXOficina
    Public Sub New(Optional idso As Integer = 0, Optional finicio As Date = Nothing, Optional ffin As Date = Nothing)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim ctx As New EntidadesVistas(My.Settings.CadenaAPPCAVistas)

        If idso = 0 AndAlso finicio = Nothing AndAlso ffin = Nothing Then
            BindingSource1.DataSource = (From v In ctx.V_ATENCIONXOFICINA Select v).ToList()
        End If

        If idso <> 0 AndAlso finicio = Nothing AndAlso ffin = Nothing Then
            BindingSource1.DataSource = (From v In ctx.V_ATENCIONXOFICINA Where v.IDDETALLE_SUCURSAL_OFICINA = idso Select v).ToList()
        End If
    End Sub
End Class